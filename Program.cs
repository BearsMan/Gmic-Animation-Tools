﻿using GmicDrosteAnimate;
using System;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace GmicFilterAnimatorApp
{
    [SupportedOSPlatform("windows")]
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static ConfigFilerManager Config { get; private set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); // This is apparently needed to get scaling to work. See: https://eskerahn.dk/?p=5502

            // Load and/or handle config file
            var configFilePath = "GmicAnimatorConfig.ini";
            Config = new ConfigFilerManager(configFilePath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}