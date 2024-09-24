﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace GmicDrosteAnimate
{
    [SupportedOSPlatform("windows")]
    internal class ConfigFilerManager
    {
        // ------------------------------------------------------------------------------------
        // --------------------------------- PROPERTIES ---------------------------------------
        // ------------------------------------------------------------------------------------

        // Properties to access validated configuration settings
        public string InputFilePath => inputFilePath_Validated;
        public bool SingleThreadMode => SingleThreadMode_Validated;
        public int DebugLogLevel => DebugLogLevel_Validated;

        public bool CreateGIF => CreateGIF_Validated;
        public bool DontCreateImages => DontCreateImages_Validated;
        public bool UseSameOutputDirectory => UseSameOutputDirectory_Validated;

        public string DefaultFilter => defaultFilter_Validated;
        public string DefaultFilterStartParams => defaultFilterStartParams_Validated;
        public string DefaultFilterEndParams => defaultFilterEndParams_Validated;
        public decimal DefaultMasterParameterIndex => DefaultMasterParamIndex_Validated; // This should be the value of the nud control, so starting at 1

        public int DefaultFrameCount => defaultFrameCount_Validated;
        public bool AutoSwitchMasterParameter => AutoSwitchMasterParameter_Validated;

        // -------------------------------------------------------------------------
        // -------------------------- CONFIGURATION SETUP --------------------------
        // -------------------------------------------------------------------------

        private IConfigurationRoot _configuration;
        private readonly string _configFilePath;

        // ---------------------- DEFAULT VALUES ----------------------
        // Create validated versions of each setting to keep track of which validation checks have been created
        // Also set default values for each setting
        static string inputFilePath_Validated = "";

        static bool SingleThreadMode_Validated = false;
        static bool CreateGIF_Validated = true;
        static bool DontCreateImages_Validated = false;
        static bool UseSameOutputDirectory_Validated = false;

        static int defaultFrameCount_Validated = 100;
        static bool AutoSwitchMasterParameter_Validated = true;

        static int DebugLogLevel_Validated = 0;
        static int DefaultMasterParamIndex_Validated = 1;

        static string presetDefaultFilter = "Continuous Droste (Custom)";
        static string defaultFilter_Validated = presetDefaultFilter;

        static string defaultFilterStartParams_Validated = "";
        static string defaultFilterEndParams_Validated = "";

        // ---------------------- DEFAULT CONFIG FILE CONTENT ----------------------
        // File will be created upon first run if it doesn't exist
        private string DefaultConfigContent => ""
            + "# In this file you can change the default startup values for various settings. You can also leave anything blank and it will use the default."
            + "\n[Preferences]\n\n"

            + "Input_File_Path = " + "\n"
            + "\n"

            + $"Single_Thread_Mode = {SingleThreadMode_Validated}" + "\n"
            + $"Debug_Log_Level = {DebugLogLevel_Validated}" + "\n"
            + "\n"

            + $"Create_GIF = {CreateGIF_Validated}" + "\n"
            + $"Dont_Create_Images = {DontCreateImages_Validated}" + "\n"
            + $"Use_Same_Output_Directory = {UseSameOutputDirectory_Validated}" + "\n"
            + "\n"

            + $"Default_Filter = {presetDefaultFilter}" + "\n"
            + "Default_Filter_Start_Params = " + "\n"
            + "Default_Filter_End_Params = " + "\n"
            + "Default_Master_Parameter_Index = " + "\n"
            + "\n"

            + $"Default_Frame_Count = {defaultFrameCount_Validated}" + "\n"
            + $"Auto_Switch_Master_Parameter = {AutoSwitchMasterParameter_Validated}" + "\n"
            ; // End of default config content


        // ---------------------- USER CONFIG VALIDATION ----------------------
        // Takes settings from the config file and validates them. If valid, the validated setting is used. If invalid, the default setting is used.
        private void ValidateConfiguration()
        {
            // Create intermediate variables for those requiring additional processing
            string _inputFilePath =                 ValidateString(_configuration["Preferences:Input_File_Path"]);
            string _debugLogLevel =                 ValidateString(_configuration["Preferences:Debug_Log_Level"]);
            string _defaultMasterParameterIndex =   ValidateString(_configuration["Preferences:Default_Master_Parameter_Index"]);
            string _defaultFilter =                 ValidateString(_configuration["Preferences:Default_Filter"]);
            string _defaultFilterStartParams =      ValidateString(_configuration["Preferences:Default_Filter_Start_Params"]);
            string _defaultFilterEndParams =        ValidateString(_configuration["Preferences:Default_Filter_End_Params"]);

            // Validate booleans Directly - If a null value is returned, the original value is used
            SingleThreadMode_Validated =            ValidateBool(_configuration["Preferences:Single_Thread_Mode"])              ?? SingleThreadMode_Validated;
            CreateGIF_Validated =                   ValidateBool(_configuration["Preferences:Create_GIF"])                      ?? CreateGIF_Validated;
            DontCreateImages_Validated =            ValidateBool(_configuration["Preferences:Dont_Create_Images"])              ?? DontCreateImages_Validated;
            UseSameOutputDirectory_Validated =      ValidateBool(_configuration["Preferences:Use_Same_Output_Directory"])       ?? UseSameOutputDirectory_Validated;
            AutoSwitchMasterParameter_Validated =   ValidateBool(_configuration["Preferences:Auto_Switch_Master_Parameter"])    ?? AutoSwitchMasterParameter_Validated;

            // Validate Integers Directly - If null is returned, the original value is used. If the value is outside the range, the min or max will be returned and used
            defaultFrameCount_Validated = ValidateInt(value: _configuration["Preferences:Default_Frame_Count"], min: 1, max: 10000) ?? defaultFrameCount_Validated;

            // ---------- Further Validation ----------

            // Validate file path either relative or absolute
            if (!string.IsNullOrWhiteSpace(_inputFilePath))
            {
                //string fullPath = Path.Combine(AppContext.BaseDirectory, _inputFilePath);
                if (File.Exists(_inputFilePath))
                {
                    inputFilePath_Validated = _inputFilePath;
                }
                else
                {
                    ShowValidationError(
                        "Input file path in the config appears invalid. It should be either a relative or absolute path to an image file." +
                        "\n\nPath given in config file:" +
                        $"\n{_inputFilePath}");
                    inputFilePath_Validated = "";
                }
            }
            else
            {
                inputFilePath_Validated = "";
            }

            // Validate debug log level, must be 0 to 4
            if (!string.IsNullOrWhiteSpace(_debugLogLevel))
            {
                if (int.TryParse(_debugLogLevel, out int result) && result >= 0 && result <= 4)
                {
                    DebugLogLevel_Validated = result;
                }
                else
                {
                    ShowValidationError(
                        "Debug Log Level in config file should be a whole number from 0 to 4." +
                        $"\n\nValue in config file:\n{_debugLogLevel}" +
                        $"\n\nDefault value of {DebugLogLevel_Validated} will be used.");
                }
            }
            else
            {
                // Nothing to do, default value is already set to 0
            }

            // Validate filter name
            // Check if the filter name is in the list of available filters
            if (!String.IsNullOrWhiteSpace(FilterParameters.FilterExists(_defaultFilter)))
            {
                defaultFilter_Validated = FilterParameters.FilterExists(_defaultFilter);
            }
            else
            {
                ShowValidationError(
                    "Default Filter in config file is not a recognized filter name." +
                    $"\nValue in config file:\n{_defaultFilter}" +
                    $"\n\nDefault filter will be used to start:\n{presetDefaultFilter}");
                defaultFilter_Validated = presetDefaultFilter;
            }

            // Validate master parameter is a whole number greater than 0 and is within the range of the number of parameters in the filter
            if (!string.IsNullOrWhiteSpace(_defaultMasterParameterIndex))
            {
                // If it's a whole number greater than 0
                if (int.TryParse(_defaultMasterParameterIndex, out int result) && result > 0)
                {
                    if (result > FilterParameters.GetSpecificFilterParameters(defaultFilter_Validated).Count)
                    {
                        ShowValidationError(
                            "Default Master Parameter Index in config file is greater than the number of parameters in the selected filter." +
                            $"\nValue in config file:\n{_defaultMasterParameterIndex}" +
                            $"\n\nNumber of parameters in selected filter: {FilterParameters.GetSpecificFilterParameters(_defaultFilter).Count}");

                        DefaultMasterParamIndex_Validated = 1;
                    }
                    else
                    {
                        DefaultMasterParamIndex_Validated = result;
                    }
                    
                }
                else
                {
                    ShowValidationError(
                        "Default Master Parameter Index in config file should be a whole number greater than 0." +
                        $"\nValue in config file:\n{_defaultMasterParameterIndex}");
                    DefaultMasterParamIndex_Validated = 1;
                }
            }
            else
            {
                DefaultMasterParamIndex_Validated = 1;
            }

            // Validate start and end params for the selected default filter
            // Filter name should have already been validated at this point, so just checking if correct number of parameters
            if (!String.IsNullOrWhiteSpace(_defaultFilterStartParams))
            {

                int startParamCount = countParametersInString(_defaultFilterStartParams);
                int expectedParamCount = FilterParameters.GetSpecificFilterParameters(defaultFilter_Validated).Count;

                // Check if the number of parameters in the start params matches the number of parameters expected for the selected filter
                if (expectedParamCount == startParamCount)
                {
                    defaultFilterStartParams_Validated = _defaultFilterStartParams;
                }
                else
                {
                    ShowValidationError(
                        "Default Filter Start Params in config file does not match the number of parameters expected for the selected filter." +
                        $"\n\nValue in config file:\n{_defaultFilterStartParams}" +
                        $"\nParameter count in string above: {startParamCount}" +
                        $"\n\nExpected number of parameters for filter {defaultFilter_Validated}: {expectedParamCount}");
                    defaultFilterStartParams_Validated = "";
                }
            }
            else
            {
                defaultFilterStartParams_Validated = "";
            }

            // Validate end params for the selected default filter same as start
            if (!String.IsNullOrWhiteSpace(_defaultFilterEndParams))
            {

                int startParamCount = countParametersInString(_defaultFilterEndParams);
                int expectedParamCount = FilterParameters.GetSpecificFilterParameters(defaultFilter_Validated).Count;

                // Check if the number of parameters in the start params matches the number of parameters expected for the selected filter
                if (expectedParamCount == startParamCount)
                {
                    defaultFilterEndParams_Validated = _defaultFilterEndParams;
                }
                else
                {
                    ShowValidationError(
                        "Default Filter Start Params in config file does not match the number of parameters expected for the selected filter." +
                        $"\n\nValue in config file:\n{_defaultFilterEndParams}" +
                        $"\nParameter count in string above: {startParamCount}" +
                        $"\n\nExpected number of parameters for filter {defaultFilter_Validated}: {expectedParamCount}");
                    defaultFilterEndParams_Validated = "";
                }
            }
            else
            {
                defaultFilterEndParams_Validated = "";
            }

        }

        // ----------------------- GENERAL FUNCTIONS -----------------------

        public ConfigFilerManager(string configFilePath)
        {
            _configFilePath = configFilePath;
            EnsureConfigFileExists();
            LoadConfiguration();
            //ValidateConfiguration();
        }

        private void EnsureConfigFileExists()
        {
            if (!File.Exists(_configFilePath))
            {
                File.WriteAllText(_configFilePath, DefaultConfigContent);
            }
        }

        private void LoadConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddIniFile(_configFilePath, optional: true, reloadOnChange: false);

            _configuration = configurationBuilder.Build();
        }
        public void RefreshConfiguration()
        {
            LoadConfiguration();
            ValidateConfiguration();
        }

        int countParametersInString(string parameterString)
        {
            int count = 0;
            // Split on commas
            string[] parameters = parameterString.Split(',');
            foreach (string parameter in parameters)
            {
                count++;
            }
            return count;
        }

        // ------------------ VALIDATION FUNCTIONS ------------------

        // Validation methods (you can expand these as needed)
        private string ValidateString(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                //ShowValidationError("String value is invalid.");
                return null;
            }
            return value;
        }

        private bool? ValidateBool(string value)
        {
            if (bool.TryParse(value, out bool result))
            {
                return result;
            }
            ShowValidationError("Boolean value is invalid.");
            return null;
        }

        private int? ValidateInt(string value, int? max, int? min)
        {
            if (int.TryParse(value, out int result))
            {
                if (result >= min && result <= max)
                {
                    return result;
                }
                else if (result < min)
                {
                    ShowValidationError($"Integer value ({value} is too small. Using minimum: {min}");
                    return min;
                }
                else if (result > max)
                {
                    ShowValidationError($"Integer value ({value} is too large. Using maximum: {max}");
                    return max;
                }
            }
            ShowValidationError("Integer value is invalid.");
            return null;
        }

        private void ShowValidationError(string message)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
