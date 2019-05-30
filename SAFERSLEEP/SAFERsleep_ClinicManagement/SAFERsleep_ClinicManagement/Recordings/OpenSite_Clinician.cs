﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SAFERsleep_ClinicManagement.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OpenSite_Clinician recording.
    /// </summary>
    [TestModule("8be73b34-dc2d-44cb-bdff-70e920cf365f", ModuleType.Recording, 1)]
    public partial class OpenSite_Clinician : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep_ClinicManagement.SAFERsleep_ClinicManagementRepository repository.
        /// </summary>
        public static SAFERsleep_ClinicManagement.SAFERsleep_ClinicManagementRepository repo = SAFERsleep_ClinicManagement.SAFERsleep_ClinicManagementRepository.Instance;

        static OpenSite_Clinician instance = new OpenSite_Clinician();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenSite_Clinician()
        {
            Browser = "Chrome";
            URL = "http://testlab.safersleep.net/ClinicManagement/#/home";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenSite_Clinician Instance
        {
            get { return instance; }
        }

#region Variables

        string _Browser;

        /// <summary>
        /// Gets or sets the value of variable Browser.
        /// </summary>
        [TestVariable("e9127848-ad0b-4091-a75d-3827f2768f7c")]
        public string Browser
        {
            get { return _Browser; }
            set { _Browser = value; }
        }

        string _URL;

        /// <summary>
        /// Gets or sets the value of variable URL.
        /// </summary>
        [TestVariable("31bd2fc4-b55b-457f-aabc-3edf34dbc75d")]
        public string URL
        {
            get { return _URL; }
            set { _URL = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            // Launch the site
            Report.Log(ReportLevel.Info, "Website", "Launch the site\r\nOpening web site URL in variable $URL with browser specified by variable $Browser in maximized mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser(URL, Browser, "", false, true, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'SAFERsleepClinicManagement.Roles.CLINICIAN'.", repo.SAFERsleepClinicManagement.Roles.CLINICIANInfo, new RecordItemIndex(1));
            repo.SAFERsleepClinicManagement.Roles.CLINICIAN.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SAFERsleepClinicManagement.Roles.CLINICIAN' at 2;26.", repo.SAFERsleepClinicManagement.Roles.CLINICIANInfo, new RecordItemIndex(2));
            repo.SAFERsleepClinicManagement.Roles.CLINICIAN.Click("2;26");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}