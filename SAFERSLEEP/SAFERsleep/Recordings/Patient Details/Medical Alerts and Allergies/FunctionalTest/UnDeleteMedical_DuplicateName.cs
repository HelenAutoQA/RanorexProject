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

namespace SAFERsleep.Recordings.Patient_Details.Medical_Alerts_and_Allergies.FunctionalTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UnDeleteMedical_DuplicateName recording.
    /// </summary>
    [TestModule("3d41c1fe-dbf0-4860-8bf7-6e1f1d1193ac", ModuleType.Recording, 1)]
    public partial class UnDeleteMedical_DuplicateName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static UnDeleteMedical_DuplicateName instance = new UnDeleteMedical_DuplicateName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UnDeleteMedical_DuplicateName()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UnDeleteMedical_DuplicateName Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Details.
        /// </summary>
        [TestVariable("830de232-3401-4495-b11c-44f6cd4633fe")]
        public string Details
        {
            get { return repo.Details; }
            set { repo.Details = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Category.
        /// </summary>
        [TestVariable("86944804-657a-42a5-b8f8-41de2ccbfb7c")]
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
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            // Click on Allergy item
            Report.Log(ReportLevel.Info, "Mouse", "Click on Allergy item\r\nMouse Left Click item 'FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.MedicalAlertListItem' at Center.", repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.MedicalAlertListItemInfo, new RecordItemIndex(0));
            repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.MedicalAlertListItem.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.UndeleteMedicalAlert' at Center.", repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.UndeleteMedicalAlertInfo, new RecordItemIndex(1));
            repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.UndeleteMedicalAlert.Click();
            Delay.Milliseconds(200);
            
            // Check validate duplicate ame message
            MedicalAlertAllergyCollection.CheckDupplicateDrugLCassConditionName("Condition");
            Delay.Milliseconds(0);
            
            // Click on OK button on Errror poppup
            Report.Log(ReportLevel.Info, "Mouse", "Click on OK button on Errror poppup\r\nMouse Left Click item 'Error.ButtonOK' at Center.", repo.Error.ButtonOKInfo, new RecordItemIndex(3));
            repo.Error.ButtonOK.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
