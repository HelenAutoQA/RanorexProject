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

namespace SAFERsleep.Recordings.Patient_Details.Medical_Alerts_and_Allergies
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddMedicalAlert recording.
    /// </summary>
    [TestModule("6d551756-448c-4c89-b2d9-7c2d3c60e90a", ModuleType.Recording, 1)]
    public partial class AddMedicalAlert : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static AddMedicalAlert instance = new AddMedicalAlert();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddMedicalAlert()
        {
            Category = "Medical Alert";
            Details = "this is a test Medical Alert Details";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddMedicalAlert Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Details.
        /// </summary>
        [TestVariable("d1d04d5a-2b36-4848-86b6-07773e8c11bb")]
        public string Details
        {
            get { return repo.Details; }
            set { repo.Details = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Category.
        /// </summary>
        [TestVariable("11fef380-4678-4cb3-97c6-a35c9a11159c")]
        public string Category
        {
            get { return repo.Category; }
            set { repo.Category = value; }
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
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AddMedicalAlert' at Center.", repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AddMedicalAlertInfo, new RecordItemIndex(0));
            repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AddMedicalAlert.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Category' with focus on 'FrmAddMedicalAlert.Category'.", repo.FrmAddMedicalAlert.CategoryInfo, new RecordItemIndex(1));
            repo.FrmAddMedicalAlert.Category.PressKeys(Category);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Details' with focus on 'FrmAddMedicalAlert.Details'.", repo.FrmAddMedicalAlert.DetailsInfo, new RecordItemIndex(3));
            repo.FrmAddMedicalAlert.Details.PressKeys(Details);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAddMedicalAlert.OK' at Center.", repo.FrmAddMedicalAlert.OKInfo, new RecordItemIndex(4));
            repo.FrmAddMedicalAlert.OK.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.MedicalAlertListItem'.", repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.MedicalAlertListItemInfo, new RecordItemIndex(5));
            Validate.Exists(repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.MedicalAlertListItemInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}