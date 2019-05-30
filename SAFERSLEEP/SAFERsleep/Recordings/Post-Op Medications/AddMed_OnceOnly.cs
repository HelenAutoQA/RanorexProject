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

namespace SAFERsleep.Recordings.Post_Op_Medications
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddMed_OnceOnly recording.
    /// </summary>
    [TestModule("d70e3efa-4bf4-464e-b503-a8ad033454e8", ModuleType.Recording, 1)]
    public partial class AddMed_OnceOnly : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static AddMed_OnceOnly instance = new AddMed_OnceOnly();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddMed_OnceOnly()
        {
            Once_DrugName = "Aspirin";
            Once_Dose = "10";
            Once_DoseRange = "1-10";
            Once_Unit = "mg";
            Once_DoseCalculation = "10mg/kg";
            Once_Route = "IV";
            SpecialInstruction = "PACU only";
            Time = "13:30";
            SkipValidation = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddMed_OnceOnly Instance
        {
            get { return instance; }
        }

#region Variables

        string _Time;

        /// <summary>
        /// Gets or sets the value of variable Time.
        /// </summary>
        [TestVariable("973a4d38-b4ef-48cc-873f-84f289168814")]
        public string Time
        {
            get { return _Time; }
            set { _Time = value; }
        }

        string _SkipValidation;

        /// <summary>
        /// Gets or sets the value of variable SkipValidation.
        /// </summary>
        [TestVariable("b7e87497-5776-49a9-8a27-dada1dc01a44")]
        public string SkipValidation
        {
            get { return _SkipValidation; }
            set { _SkipValidation = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable SpecialInstruction.
        /// </summary>
        [TestVariable("e8a24078-e901-4137-8ec6-bffa1167e6c0")]
        public string SpecialInstruction
        {
            get { return repo.SpecialInstruction; }
            set { repo.SpecialInstruction = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Once_Route.
        /// </summary>
        [TestVariable("cf3ffe06-865b-4d67-b4b7-d80ead72a1e6")]
        public string Once_Route
        {
            get { return repo.Once_Route; }
            set { repo.Once_Route = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Once_DoseCalculation.
        /// </summary>
        [TestVariable("fa7998b7-5524-494d-a9f3-9fce156a8f26")]
        public string Once_DoseCalculation
        {
            get { return repo.Once_DoseCalculation; }
            set { repo.Once_DoseCalculation = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Once_Unit.
        /// </summary>
        [TestVariable("099d2ed7-16fb-494a-aaed-ed4ae20a6b5a")]
        public string Once_Unit
        {
            get { return repo.Once_Unit; }
            set { repo.Once_Unit = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Once_DoseRange.
        /// </summary>
        [TestVariable("5ea28b40-e76a-4b4e-a9f6-41612dea503a")]
        public string Once_DoseRange
        {
            get { return repo.Once_DoseRange; }
            set { repo.Once_DoseRange = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Once_Dose.
        /// </summary>
        [TestVariable("c36bbf87-c0ec-4e30-95a6-44390db9c0ea")]
        public string Once_Dose
        {
            get { return repo.Once_Dose; }
            set { repo.Once_Dose = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Once_DrugName.
        /// </summary>
        [TestVariable("5936b947-8dda-44b7-ab02-7062207785f3")]
        public string Once_DrugName
        {
            get { return repo.Once_DrugName; }
            set { repo.Once_DrugName = value; }
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

            // Click on "OnceOnly" tab
            Report.Log(ReportLevel.Info, "Mouse", "Click on \"OnceOnly\" tab\r\nMouse Left Click item 'FrmORMain.PostOpMedication.Tabs.OnceOnly' at Center.", repo.FrmORMain.PostOpMedication.Tabs.OnceOnlyInfo, new RecordItemIndex(0));
            repo.FrmORMain.PostOpMedication.Tabs.OnceOnly.Click();
            
            // Click on "Add" button
            Report.Log(ReportLevel.Info, "Mouse", "Click on \"Add\" button\r\nMouse Left Click item 'FrmORMain.PostOpMedication.OnceMed.AddMed_Once' at Center.", repo.FrmORMain.PostOpMedication.OnceMed.AddMed_OnceInfo, new RecordItemIndex(1));
            repo.FrmORMain.PostOpMedication.OnceMed.AddMed_Once.Click();
            
            // Verify the right window is opened
            Report.Log(ReportLevel.Info, "Validation", "Verify the right window is opened\r\nValidating Exists on item 'AddOnceOnlyMedication.AddOnceOnlyMedication'.", repo.AddOnceOnlyMedication.AddOnceOnlyMedicationInfo, new RecordItemIndex(2));
            Validate.Exists(repo.AddOnceOnlyMedication.AddOnceOnlyMedicationInfo);
            
            // Enter Drug name
            Report.Log(ReportLevel.Info, "Mouse", "Enter Drug name\r\nMouse Left Click item 'AddOnceOnlyMedication.DrugName' at Center.", repo.AddOnceOnlyMedication.DrugNameInfo, new RecordItemIndex(3));
            repo.AddOnceOnlyMedication.DrugName.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Once_DrugName'.", new RecordItemIndex(4));
            Keyboard.Press(Once_DrugName);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(5));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            // Enter Dose
            Report.Log(ReportLevel.Info, "Mouse", "Enter Dose\r\nMouse Left Click item 'AddOnceOnlyMedication.Dose' at Center.", repo.AddOnceOnlyMedication.DoseInfo, new RecordItemIndex(6));
            repo.AddOnceOnlyMedication.Dose.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Once_Dose'.", new RecordItemIndex(7));
            Keyboard.Press(Once_Dose);
            
            // Enter Dose range
            Report.Log(ReportLevel.Info, "Mouse", "Enter Dose range\r\nMouse Left Click item 'AddOnceOnlyMedication.DoseRange' at Center.", repo.AddOnceOnlyMedication.DoseRangeInfo, new RecordItemIndex(8));
            repo.AddOnceOnlyMedication.DoseRange.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Once_DoseRange'.", new RecordItemIndex(9));
            Keyboard.Press(Once_DoseRange);
            
            // Enter Unit
            Report.Log(ReportLevel.Info, "Mouse", "Enter Unit\r\nMouse Left DoubleClick item 'AddOnceOnlyMedication.Unit' at Center.", repo.AddOnceOnlyMedication.UnitInfo, new RecordItemIndex(10));
            repo.AddOnceOnlyMedication.Unit.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Back' Press.", new RecordItemIndex(11));
            Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Once_Unit'.", new RecordItemIndex(12));
            Keyboard.Press(Once_Unit);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(13));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            // Enter Dose calculation
            Report.Log(ReportLevel.Info, "Mouse", "Enter Dose calculation\r\nMouse Left Click item 'AddOnceOnlyMedication.DoseCalculation' at Center.", repo.AddOnceOnlyMedication.DoseCalculationInfo, new RecordItemIndex(14));
            repo.AddOnceOnlyMedication.DoseCalculation.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Once_DoseCalculation'.", new RecordItemIndex(15));
            Keyboard.Press(Once_DoseCalculation);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddOnceOnlyMedication.Route' at Center.", repo.AddOnceOnlyMedication.RouteInfo, new RecordItemIndex(16));
            repo.AddOnceOnlyMedication.Route.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Once_Route'.", new RecordItemIndex(17));
            Keyboard.Press(Once_Route);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(18));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            // Enter Instruction
            Report.Log(ReportLevel.Info, "Mouse", "Enter Instruction\r\nMouse Left Click item 'AddOnceOnlyMedication.Instruction' at Center.", repo.AddOnceOnlyMedication.InstructionInfo, new RecordItemIndex(19));
            repo.AddOnceOnlyMedication.Instruction.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SpecialInstruction'.", new RecordItemIndex(20));
            Keyboard.Press(SpecialInstruction);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(21));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            // Enter Time
            Report.Log(ReportLevel.Info, "Mouse", "Enter Time\r\nMouse Left Click item 'AddOnceOnlyMedication.Time' at Center.", repo.AddOnceOnlyMedication.TimeInfo, new RecordItemIndex(22));
            repo.AddOnceOnlyMedication.Time.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Time'.", new RecordItemIndex(23));
            Keyboard.Press(Time);
            
            // Click OK
            Report.Log(ReportLevel.Info, "Mouse", "Click OK\r\nMouse Left Click item 'AddOnceOnlyMedication.ButtonOK' at Center.", repo.AddOnceOnlyMedication.ButtonOKInfo, new RecordItemIndex(24));
            repo.AddOnceOnlyMedication.ButtonOK.Click();
            
            // Verify that the medication is added successfully
            Validate_AddedOnceMedication(repo.FrmORMain.PostOpMedication.OnceMed.AddedOnceMedicationInfo, SkipValidation);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
