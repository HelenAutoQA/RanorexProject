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
    ///The AddSameMedicalAlert recording.
    /// </summary>
    [TestModule("af25df9a-1740-4b6e-bfbf-77569dda86e2", ModuleType.Recording, 1)]
    public partial class AddSameMedicalAlert : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static AddSameMedicalAlert instance = new AddSameMedicalAlert();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddSameMedicalAlert()
        {
            Category = "Medical Alert";
            Details = "this is a test Medical Alert Details";
            NameToEdit = "Respiratory disease";
            NewMedicalName = "Salmon Sperm";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddSameMedicalAlert Instance
        {
            get { return instance; }
        }

#region Variables

        string _NameToEdit;

        /// <summary>
        /// Gets or sets the value of variable NameToEdit.
        /// </summary>
        [TestVariable("1dda1674-e465-471b-a468-b3cd1f97e02c")]
        public string NameToEdit
        {
            get { return _NameToEdit; }
            set { _NameToEdit = value; }
        }

        string _NewMedicalName;

        /// <summary>
        /// Gets or sets the value of variable NewMedicalName.
        /// </summary>
        [TestVariable("1c95731e-1ba7-4972-a824-166288acfd84")]
        public string NewMedicalName
        {
            get { return _NewMedicalName; }
            set { _NewMedicalName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Details.
        /// </summary>
        [TestVariable("aee1727a-a617-49f6-91ae-b428966cfeb4")]
        public string Details
        {
            get { return repo.Details; }
            set { repo.Details = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Category.
        /// </summary>
        [TestVariable("e92d6c68-635b-48a9-b494-c1c8b38a1e9b")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AddMedicalAlert' at Center.", repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AddMedicalAlertInfo, new RecordItemIndex(0));
            repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AddMedicalAlert.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Category' with focus on 'FrmAddMedicalAlert.Category'.", repo.FrmAddMedicalAlert.CategoryInfo, new RecordItemIndex(1));
            repo.FrmAddMedicalAlert.Category.PressKeys(Category);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'FrmAddMedicalAlert.Category' and assigning its value to variable 'NameToEdit'.", repo.FrmAddMedicalAlert.CategoryInfo, new RecordItemIndex(3));
            NameToEdit = repo.FrmAddMedicalAlert.Category.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAddMedicalAlert.OK' at Center.", repo.FrmAddMedicalAlert.OKInfo, new RecordItemIndex(4));
            repo.FrmAddMedicalAlert.OK.Click();
            Delay.Milliseconds(200);
            
            // Check validate duplicate ame message
            MedicalAlertAllergyCollection.CheckDupplicateDrugLCassConditionName("Condition");
            Delay.Milliseconds(0);
            
            // Click on OK button on Errror poppup
            Report.Log(ReportLevel.Info, "Mouse", "Click on OK button on Errror poppup\r\nMouse Left Click item 'Error.ButtonOK' at Center.", repo.Error.ButtonOKInfo, new RecordItemIndex(6));
            repo.Error.ButtonOK.Click();
            Delay.Milliseconds(200);
            
            // Enter new Medical
            Report.Log(ReportLevel.Info, "Mouse", "Enter new Medical\r\nMouse Left Click item 'FrmAddMedicalAlert.Category' at Center.", repo.FrmAddMedicalAlert.CategoryInfo, new RecordItemIndex(7));
            repo.FrmAddMedicalAlert.Category.Click();
            Delay.Milliseconds(200);
            
            UserCodeCollection_OR.Clear_TextBox(repo.FrmAddMedicalAlert.CategoryInfo, "Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NewMedicalName'.", new RecordItemIndex(9));
            Keyboard.Press(NewMedicalName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(10));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            // ReAssign new Medical Name to its old value
            Report.Log(ReportLevel.Info, "Get Value", "ReAssign new Medical Name to its old value\r\nGetting attribute 'Text' from item 'FrmAddMedicalAlert.Category' and assigning its value to variable 'Category'.", repo.FrmAddMedicalAlert.CategoryInfo, new RecordItemIndex(11));
            Category = repo.FrmAddMedicalAlert.Category.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAddMedicalAlert.Details' at Center.", repo.FrmAddMedicalAlert.DetailsInfo, new RecordItemIndex(12));
            repo.FrmAddMedicalAlert.Details.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Details' with focus on 'FrmAddMedicalAlert.Details'.", repo.FrmAddMedicalAlert.DetailsInfo, new RecordItemIndex(13));
            repo.FrmAddMedicalAlert.Details.PressKeys(Details);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAddMedicalAlert.OK' at Center.", repo.FrmAddMedicalAlert.OKInfo, new RecordItemIndex(14));
            repo.FrmAddMedicalAlert.OK.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.MedicalAlertListItem'.", repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.MedicalAlertListItemInfo, new RecordItemIndex(15));
            Validate.Exists(repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.MedicalAlertListItemInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}