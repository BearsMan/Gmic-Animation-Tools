﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace DrosteEffectApp
{
    public partial class MainForm : Form
    {
        // Variables to hold the state of the application and user input.
        // inputFilePath stores the path to the image file selected by the user.
        private string inputFilePath;
        // startParams stores the initial parameters for the Droste effect.
        private string startParams;
        // endParams stores the final parameters for the Droste effect to create a transition effect.
        private string endParams;
        // masterParamIndex indicates the index of the parameter that drives the transformation.
        private int masterParamIndex;
        // masterParamIncrement defines the increment by which the master parameter changes.
        private double masterParamIncrement;
        // exponentialIncrements indicates whether exponential interpolation is used.
        private bool exponentialIncrements;
        // masterExponent specifies the exponent used if exponential interpolation is enabled.
        private double masterExponent;
        // exponentArray can contain a custom or default set of exponents for all parameters.
        private string exponentArray;
        // createGif determines whether a GIF should be created from the resulting images.
        private bool createGif;
        // Flag to indicate if a cancellation has been requested by the user. To stop image generation process
        private bool cancellationRequested = false;

        // Setting a default array of exponents for use with exponential interpolation if no custom array is provided.
        // These are arbitrarily chosen values based on experience.
        private double[] defaultExponents = new double[] { 2, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

        public MainForm()
        {
            InitializeComponent();
            InitializeDefaults();
        }

        private void InitializeDefaults()
        {
            // Set initial values for form fields and internal variables to ensure a consistent starting state.
            inputFilePath = string.Empty;
            startParams = "34,100,1,1,1,0,0,-11,-32,-46,3,10,1,0,90,0,0,0,0,1,0,0,1,0,0,0,0,0,1,0,0";
            endParams = "100,100,1,1,1,0,0,0,0,0,3,10,1,0,90,0,0,0,0,1,0,0,1,0,0,0,0,0,1,0,0";
            masterParamIndex = 1;
            masterParamIncrement = 1;
            exponentialIncrements = false;
            masterExponent = 0;
            exponentArray = string.Empty;
            createGif = false;

            // Set default values for the new controls
            chkExponentialIncrements.Checked = false;
            //txtMasterExponent.Text = "0";
            txtExponentArray.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancellationRequested = true;
        }

        private void btnSelectInputFile_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to select an image file.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png, *.jpg, *.jpeg, *.bmp)|*.png;*.jpg;*.jpeg;*.bmp";
            openFileDialog.Title = "Select Input Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Store the selected file path in inputFilePath and display it in txtInputFilePath textbox.
                inputFilePath = openFileDialog.FileName;
                txtInputFilePath.Text = inputFilePath;
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            // Validate that an input file has been selected.
            if (string.IsNullOrEmpty(inputFilePath))
            {
                MessageBox.Show("Please select an input image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve and store user inputs from the form controls.
            startParams = txtStartParams.Text;
            endParams = txtEndParams.Text;
            masterParamIndex = (int)nudMasterParamIndex.Value;
            masterParamIncrement = (double)nudMasterParamIncrement.Value;

            // Validate the increment for the master parameter.
            if (masterParamIncrement <= 0)
            {
                MessageBox.Show("Master Param Increment must be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Read the state of the checkbox to determine if exponential increments are to be used.
            exponentialIncrements = chkExponentialIncrements.Checked;
            // Try to parse the exponent entered by the user; if parsing fails, masterExponent remains at its previously set value (initially 0).
            double.TryParse(txtMasterExponent.Text, out double masterExponent);
            // Store any custom exponent array or use a default one.
            string exponentArray = txtExponentArray.Text;
            // Read the state of the GIF creation option.
            createGif = chkCreateGif.Checked;

            // Check if the start and end parameters are valid.
            if (string.IsNullOrEmpty(startParams) || string.IsNullOrEmpty(endParams))
            {
                MessageBox.Show("Please enter start and end parameters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse the start and end parameters into arrays of doubles for processing.
            string[] startParamsArray = startParams.Split(',');
            string[] endParamsArray = endParams.Split(',');

            // Ensure both parameter arrays have exactly 31 elements.
            if (startParamsArray.Length != 31 || endParamsArray.Length != 31)
            {
                MessageBox.Show("Start and end parameters must contain 31 comma-separated values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double[] startValues = new double[31];
            double[] endValues = new double[31];

            for (int i = 0; i < 31; i++)
            {
                if (!double.TryParse(startParamsArray[i], out startValues[i]) || !double.TryParse(endParamsArray[i], out endValues[i]))
                {
                    MessageBox.Show("Invalid start or end parameter values. Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Calculate the total number of frames required based on the master parameter's range and increment.
            int totalFrames = (int)Math.Ceiling((Math.Abs(endValues[masterParamIndex - 1] - startValues[masterParamIndex - 1])) / masterParamIncrement) + 1;

            // Determine the exponent mode and set up the exponents array based on user selections.
            string exponentMode = null;
            double[] exponents = null;

            if (exponentialIncrements)
            {   
                // Exponent array field is either default or a custom array
                if (!string.IsNullOrEmpty(exponentArray))
                {
                    //User wants to apply default exponent array to all parameters, not just master
                    if (exponentArray.Trim().ToLower() == "default")
                    {
                        exponents = defaultExponents;
                        exponentMode = "default-apply-all";
                    }
                    // User has entered custom array of exponents
                    else
                    {
                        string[] exponentArrayValues = exponentArray.Split(',');
                        if (exponentArrayValues.Length == 31)
                        {
                            exponents = Array.ConvertAll(exponentArrayValues, double.Parse);
                            exponentMode = "custom-array";
                        }
                        else
                        {
                            MessageBox.Show("Exponent array must contain 31 comma-separated values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                // Master exponent field has been filled
                else if (masterExponent != 0)
                {
                    exponents = (double[])defaultExponents.Clone();
                    exponents[masterParamIndex - 1] = masterExponent;
                    exponentMode = "custom-master";
                }
                // No custom exponents have been entered at all, so use exponent from default array for master parameter only
                else
                {
                    exponents = defaultExponents;
                    exponentMode = "default-array";
                    // Set master exponent from default array
                    masterExponent = defaultExponents[masterParamIndex - 1];
                    
                }
            }

            // Generate a unique output directory for storing generated frames based on the input file's name.
            string outputDir = CreateOutputDirectory();

            // Calculate interpolated parameter values for each frame using the selected interpolation method.
            List<string> interpolatedParams = InterpolateValues(startValues, endValues, totalFrames, masterParamIndex - 1, masterParamIncrement, exponents, exponentMode);

            // Create the log file with metadata and interpolated parameters
            CreateLogFile(outputDir, interpolatedParams, exponentMode, defaultExponents, masterExponent);

            btnStart.Visible = false;
            btnCancel.Visible = true;

            // Process each frame using the specified parameters and gmic.exe.
            await Task.Run(() => ProcessFrames(outputDir, interpolatedParams));

            // Optionally create a GIF from the generated frames using ffmpeg.
            if (createGif)
            {
                CreateGif(outputDir);
            }

            // Open the output directory in Windows Explorer for user review.
            //Process.Start("explorer.exe", outputDir);
        }

        private string CreateOutputDirectory()
        {
            // Create a unique output directory based on the input file name, appending numbers to avoid conflicts.
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(inputFilePath);
            string outputDir = fileNameWithoutExtension;
            int folderCount = 1;

            while (Directory.Exists(outputDir))
            {
                outputDir = $"{fileNameWithoutExtension}_{folderCount}";
                folderCount++;
            }

            Directory.CreateDirectory(outputDir);
            return outputDir;
        }

        // Interpolates parameter values for each frame based on given start and end parameters, and the total number of frames.
        // Returns a list of strings representing the interpolated parameter values for each frame.
        private List<string> InterpolateValues(double[] startValues, double[] endValues, int totalFrames, int masterIndex, double increment, double[] exponents, string exponentMode)
        {
            // List to store all interpolated values for each frame.
            List<string> interpolatedValues = new List<string>();

            // Loop through each frame to calculate parameter values.
            for (int frame = 0; frame < totalFrames; frame++)
            {
                // Array to hold the current set of interpolated parameters.
                double[] currentValues = new double[31];

                // Loop through each parameter to interpolate its value.
                for (int i = 0; i < 31; i++)
                {
                    // Initialize the current value with the start value of the parameter.
                    double currentValue = startValues[i];
                    // Initialize the exponential factor to 1.
                    double exponentialFactor = 1;

                    // Decide the interpolation method for the current individual parameter based on the mode set.
                    switch (exponentMode)
                    {
                        // If the user has specified a custom exponent for the master parameter and exponential increments are enabled.
                        case "custom-master":
                            // If the current index is the master index, apply exponential interpolation.
                            if (i == masterIndex)
                            {
                                exponentialFactor = Math.Pow((double)frame / totalFrames, exponents[i]);
                                currentValue = startValues[i] + exponentialFactor * (endValues[i] - startValues[i]);
                            }
                            // For non-master parameters, linear interpolation is used.
                            else
                            {
                                currentValue = startValues[i] + (endValues[i] - startValues[i]) / (totalFrames - 1) * frame;
                            }
                            break;

                        // If the user has specified a custom array of exponents for all parameters and exponential increments are enabled.
                        case "custom-array":
                            // If the user has used the string 'default' for the exponentArray parameter and exponential increments are enabled.
                            exponentialFactor = Math.Pow((double)frame / totalFrames, exponents[i]);
                            currentValue = startValues[i] + exponentialFactor * (endValues[i] - startValues[i]);
                            break;

                        case "default-apply-all":
                            // Apply exponential interpolation using the given exponents for all parameters.
                            exponentialFactor = Math.Pow((double)frame / totalFrames, exponents[i]);
                            currentValue = startValues[i] + exponentialFactor * (endValues[i] - startValues[i]);
                            break;

                        // If exponential increments are enabled but no custom master exponent or full array is specified.
                        // Only the master parameter will be interpolated exponentially, while the rest will be linearly interpolated.
                        case "default-array":
                            // Apply exponential interpolation using a default array, but only for the master parameter.
                            if (i == masterIndex)
                            {
                                exponentialFactor = Math.Pow((double)frame / totalFrames, exponents[i]);
                                currentValue = startValues[i] + exponentialFactor * (endValues[i] - startValues[i]);
                            }
                            // For non-master parameters, linear interpolation is used.
                            else
                            {
                                currentValue = startValues[i] + (endValues[i] - startValues[i]) / (totalFrames - 1) * frame;
                            }
                            break;

                        // If exponential increments are not enabled, default to linear interpolation for all parameters.
                        default:
                            // Apply linear interpolation for parameters where no specific mode is set.
                            currentValue = startValues[i] + (endValues[i] - startValues[i]) / (totalFrames - 1) * frame;
                            break;
                    }

                    // Round the interpolated value to three decimal places and add it to the current values array.
                    currentValues[i] = Math.Round(currentValue, 3);
                }

                // Add the concatenated string of current values for the frame to the interpolated values list.
                interpolatedValues.Add(string.Join(",", currentValues));
            }

            // Return the list of interpolated values for all frames.
            return interpolatedValues;
        }

        private async Task ProcessFrames(string outputDir, List<string> interpolatedParams)
        {
            int parallelJobs = 7;
            int maxAttempts = 3;
            int attempt = 1;

            int totalFrames = interpolatedParams.Count;
            int digitCount = (int)Math.Floor(Math.Log10(totalFrames)) + 1;

            List<string> expectedFiles = new List<string>();
            for (int i = 0; i < totalFrames; i++)
            {
                string outputFile = Path.Combine(outputDir, $"{Path.GetFileNameWithoutExtension(inputFilePath)}_{(i + 1).ToString($"D{digitCount}")}.png");
                expectedFiles.Add(outputFile);
            }

            while (attempt <= maxAttempts)
            {
                await Task.Run(() =>
                {
                    Parallel.For(0, totalFrames, new ParallelOptions { MaxDegreeOfParallelism = parallelJobs }, i =>
                    {
                        if (cancellationRequested)
                        {
                            return;
                        }

                        string outputFile = expectedFiles[i];
                        string parameters = interpolatedParams[i];

                        if (!File.Exists(outputFile))
                        {
                            // Execute gmic.exe to process frame
                            ProcessStartInfo startInfo = new ProcessStartInfo();
                            startInfo.FileName = "gmic.exe";
                            startInfo.Arguments = $"-input \"{inputFilePath}\" -command \"DrosteSingleThread.gmic\" -souphead_droste10 {parameters} -output \"{outputFile}\"";
                            startInfo.UseShellExecute = false;
                            startInfo.CreateNoWindow = true;

                            using (Process process = new Process())
                            {
                                process.StartInfo = startInfo;
                                process.Start();
                                process.WaitForExit();
                            }
                        }
                    });
                });

                List<string> missingFiles = expectedFiles.Where(file => !File.Exists(file)).ToList();
                if (missingFiles.Count == 0)
                {
                    break;
                }

                attempt++;
            }

            List<string> missingFilesAfterRerun = expectedFiles.Where(file => !File.Exists(file)).ToList();
            if (missingFilesAfterRerun.Count > 0)
            {
                BeginInvoke((MethodInvoker)(() =>
                {
                    MessageBox.Show($"Warning: Not all of the {totalFrames} frames have been generated. Missing files:\n{string.Join("\n", missingFilesAfterRerun)}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }));
            }
            else
            {
                BeginInvoke((MethodInvoker)(() =>
                {
                    MessageBox.Show($"All {totalFrames} frames have been verified and generated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            }

            BeginInvoke((MethodInvoker)(() =>
            {
                cancellationRequested = false;
                btnStart.Visible = true;
                btnCancel.Visible = false;
            }));
        }

        private void CreateGif(string outputDir)
        {
            // Check if ffmpeg.exe exists							 
            if (!File.Exists("ffmpeg.exe"))
            {
                MessageBox.Show("ffmpeg.exe not found. Please make sure it is in the same directory as the application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Execute ffmpeg.exe to create GIF								   
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(inputFilePath);
            int totalFrames = Directory.GetFiles(outputDir, "*.png").Length;
            int digitCount = (int)Math.Floor(Math.Log10(totalFrames)) + 1;

            string ffmpegCommand = $"ffmpeg -framerate 25 -i \"{outputDir}\\{fileNameWithoutExtension}_%0{digitCount}d.png\" \"{outputDir}\\combined.gif\"";

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/c {ffmpegCommand}";
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }
        }

        private void CreateLogFile(string outputDir, List<string> interpolatedParams, string exponentMode, double[] defaultExponents, double masterExponent)
        {
            string logFilePath = Path.Combine(outputDir, $"{outputDir}_log.txt");

            string exponentModeString;
            string masterExponentString;
            string exponentArrayString;
            // If exponent mode is 'default-apply-all' or 'default-array', set exponent array to string with values from defaultExponents array.
            // Because in those cases all parameters are interpolated exponentially via array
            if (exponentMode == "default-apply-all" || exponentMode == "custom-array")
            {
                exponentArrayString = string.Join(",", defaultExponents);
                masterExponentString = "From Exponent Array";
                if (exponentMode == "default-apply-all")
                {
                    exponentModeString = "Default Array (Apply to All)";
                }
                else
                {
                    exponentModeString = "Custom Array (Apply to All)";
                }
            }
            // If exponent mode is 'custom-master' or 'default-array', set master exponent to the value entered by the user.
            // Because in those cases only the master parameter is interpolated exponentially
            else if (exponentMode == "custom-master" || exponentMode == "default-array")
            {
                masterExponentString = masterExponent.ToString();
                exponentArrayString = "N/A";
                if (exponentMode == "custom-master")
                {
                    exponentModeString = "Custom Master Parameter Exponent";
                }
                else
                {
                    exponentModeString = "Master Parameter Only (From Default Array)";
                }
            // If exponent mode is not set (exponentialIncrements is false), set all values to N/A. They won't be used anyway.
            } else {
                masterExponentString = "N/A";
                exponentArrayString = "N/A";
                exponentModeString = "N/A";
            }


            using (StreamWriter writer = new StreamWriter(logFilePath))
            {
                writer.WriteLine("Run Metadata:");
                writer.WriteLine($"Start Parameters: {startParams}");
                writer.WriteLine($"End Parameters: {endParams}");
                writer.WriteLine($"Master Parameter Index: {masterParamIndex}");
                writer.WriteLine($"Master Parameter Increment: {masterParamIncrement}");
                writer.WriteLine($"Exponential Increments: {exponentialIncrements}");

                if (exponentialIncrements)
                {
                    writer.WriteLine($"Exponent Mode: {exponentModeString}");
                    writer.WriteLine($"Master Exponent: {masterExponentString}");
                    writer.WriteLine($"Exponent Array: {exponentArrayString}");
                }

                writer.WriteLine();
                writer.WriteLine("Interpolated Parameters:");

                for (int i = 0; i < interpolatedParams.Count; i++)
                {
                    writer.WriteLine($"Frame {i + 1}: {interpolatedParams[i]}");
                }
            }
        }

        private void btnViewOutputDirectory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputFilePath))
            {
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(inputFilePath);
                string outputDir = fileNameWithoutExtension;
                int folderCount = 1;

                while (!Directory.Exists(outputDir))
                {
                    outputDir = $"{fileNameWithoutExtension}_{folderCount}";
                    folderCount++;
                }

                Process.Start("explorer.exe", outputDir);
            }
            else
            {
                MessageBox.Show("Please select an input image file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkExponentialIncrements_CheckedChanged(object sender, EventArgs e)
        {
            // Update the state of controls based on whether exponential increments are enabled.
            exponentialIncrements = chkExponentialIncrements.Checked;
            txtMasterExponent.Enabled = exponentialIncrements;
            txtExponentArray.Enabled = exponentialIncrements;
        }

        private void chkCreateGif_CheckedChanged(object sender, EventArgs e)
        {
            // Update the internal flag to reflect whether a GIF should be created.
            createGif = chkCreateGif.Checked;
        }
    }
}
