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

namespace SAFERsleep_MedRec.Recordings.AutoUpdate
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OpenMedRecLauncher recording.
    /// </summary>
    [TestModule("612e6ad3-2f65-4436-9e16-835417605870", ModuleType.Recording, 1)]
    public partial class OpenMedRecLauncher : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep_MedRec.SAFERsleep_MedRecRepository repository.
        /// </summary>
        public static SAFERsleep_MedRec.SAFERsleep_MedRecRepository repo = SAFERsleep_MedRec.SAFERsleep_MedRecRepository.Instance;

        static OpenMedRecLauncher instance = new OpenMedRecLauncher();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenMedRecLauncher()
        {
            Hospital = "Generic Hospital 1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenMedRecLauncher Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Hospital.
        /// </summary>
        [TestVariable("1b399279-a763-4c3b-9917-654213e6dfd8")]
        public string Hospital
        {
            get { return repo.Hospital; }
            set { repo.Hospital = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Desktop.SAFERsleepMedRecClientLauncher' at Center.", repo.Desktop.SAFERsleepMedRecClientLauncherInfo, new RecordItemIndex(0));
            repo.Desktop.SAFERsleepMedRecClientLauncher.DoubleClick();
            Delay.Milliseconds(200);
            
            Mouse_Click_ButtonRun(repo.OpenFileSecurityWarning.ButtonRunInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SaferSleepClientApplicationUpdateCore.Yes' at Center.", repo.SaferSleepClientApplicationUpdateCore.YesInfo, new RecordItemIndex(2));
            repo.SaferSleepClientApplicationUpdateCore.Yes.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5m.", new RecordItemIndex(3));
            Delay.Duration(300000, false);
            
            Select_Hospital(Hospital);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
