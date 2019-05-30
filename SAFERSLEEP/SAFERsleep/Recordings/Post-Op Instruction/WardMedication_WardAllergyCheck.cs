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

namespace SAFERsleep.Recordings.Post_Op_Instruction
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The WardMedication_WardAllergyCheck recording.
    /// </summary>
    [TestModule("9ceafe7c-17d3-410c-8cee-8751eab125e9", ModuleType.Recording, 1)]
    public partial class WardMedication_WardAllergyCheck : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static WardMedication_WardAllergyCheck instance = new WardMedication_WardAllergyCheck();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WardMedication_WardAllergyCheck()
        {
            AlertName = "Opiod";
            AlertType = "Allergy";
            AlertClass = "Class";
            DrugClass = "Drug";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static WardMedication_WardAllergyCheck Instance
        {
            get { return instance; }
        }

#region Variables

        string _AlertName;

        /// <summary>
        /// Gets or sets the value of variable AlertName.
        /// </summary>
        [TestVariable("70353085-9660-4ba7-b231-a2be3b29602c")]
        public string AlertName
        {
            get { return _AlertName; }
            set { _AlertName = value; }
        }

        string _AlertClass;

        /// <summary>
        /// Gets or sets the value of variable AlertClass.
        /// </summary>
        [TestVariable("a3736f10-5bd6-4d5b-b31e-25fa966bb818")]
        public string AlertClass
        {
            get { return _AlertClass; }
            set { _AlertClass = value; }
        }

        string _DrugClass;

        /// <summary>
        /// Gets or sets the value of variable DrugClass.
        /// </summary>
        [TestVariable("46992b7a-ece1-4a96-a65c-9edb2258cc91")]
        public string DrugClass
        {
            get { return _DrugClass; }
            set { _DrugClass = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable WarningMessage.
        /// </summary>
        [TestVariable("8fd852be-fb2f-4129-adb5-4f5d3e90c2f0")]
        public string WarningMessage
        {
            get { return repo.WarningMessage; }
            set { repo.WarningMessage = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PostInstruction.
        /// </summary>
        [TestVariable("898e6917-c069-471d-826f-f4fdff87d381")]
        public string PostInstruction
        {
            get { return repo.PostInstruction; }
            set { repo.PostInstruction = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PostOpFreqTime.
        /// </summary>
        [TestVariable("361489ef-4ffd-415e-8aa7-2e0740050849")]
        public string PostOpFreqTime
        {
            get { return repo.PostOpFreqTime; }
            set { repo.PostOpFreqTime = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PostOpRoute.
        /// </summary>
        [TestVariable("d80dc34f-7650-4f28-8796-191e7182d876")]
        public string PostOpRoute
        {
            get { return repo.PostOpRoute; }
            set { repo.PostOpRoute = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PostOpUnit.
        /// </summary>
        [TestVariable("acf1e5c4-3a93-40f0-a352-2a27b79298d3")]
        public string PostOpUnit
        {
            get { return repo.PostOpUnit; }
            set { repo.PostOpUnit = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PostOpDose.
        /// </summary>
        [TestVariable("b681d054-a4dc-4938-963e-b9522fa0357d")]
        public string PostOpDose
        {
            get { return repo.PostOpDose; }
            set { repo.PostOpDose = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PostOpDrug.
        /// </summary>
        [TestVariable("e9344f95-32d2-46ac-80d9-403c6fb9e229")]
        public string PostOpDrug
        {
            get { return repo.PostOpDrug; }
            set { repo.PostOpDrug = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable AlertType.
        /// </summary>
        [TestVariable("e06c1321-5060-4857-8738-afc12014125b")]
        public string AlertType
        {
            get { return repo.AlertType; }
            set { repo.AlertType = value; }
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

            // 2. Validate Warning box displays when added Drug is in patient's allergy list
            CheckWarningAllert(AlertName, AlertType, AlertClass, DrugClass);
            Delay.Milliseconds(0);
            
            // Validate OK button is disable
            Report.Log(ReportLevel.Info, "Validation", "Validate OK button is disable\r\nValidating AttributeEqual (Enabled='False') on item 'AddWardMedication.ButtonOK'.", repo.AddWardMedication.ButtonOKInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.AddWardMedication.ButtonOKInfo, "Enabled", "False");
            Delay.Milliseconds(0);
            
            // Click On "Stop Alert" button
            Report.Log(ReportLevel.Info, "Mouse", "Click On \"Stop Alert\" button\r\nMouse Left Click item 'AddWardMedication.StopAlertsForThisDrug' at Center.", repo.AddWardMedication.StopAlertsForThisDrugInfo, new RecordItemIndex(2));
            repo.AddWardMedication.StopAlertsForThisDrug.Click();
            Delay.Milliseconds(200);
            
            // Enter reason for stop alert
            Report.Log(ReportLevel.Info, "Mouse", "Enter reason for stop alert\r\nMouse Left Click item 'StopAlert_ReasonPrescribingDrug.ReasonToPrescribeDrug' at Center.", repo.StopAlert_ReasonPrescribingDrug.ReasonToPrescribeDrugInfo, new RecordItemIndex(3));
            repo.StopAlert_ReasonPrescribingDrug.ReasonToPrescribeDrug.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Stop Alert Reason Test' with focus on 'StopAlert_ReasonPrescribingDrug.ReasonToPrescribeDrug'.", repo.StopAlert_ReasonPrescribingDrug.ReasonToPrescribeDrugInfo, new RecordItemIndex(4));
            repo.StopAlert_ReasonPrescribingDrug.ReasonToPrescribeDrug.PressKeys("Stop Alert Reason Test");
            Delay.Milliseconds(0);
            
            // Click on OK on Stop alert box
            Report.Log(ReportLevel.Info, "Mouse", "Click on OK on Stop alert box\r\nMouse Left Click item 'StopAlert_ReasonPrescribingDrug.ButtonOK' at Center.", repo.StopAlert_ReasonPrescribingDrug.ButtonOKInfo, new RecordItemIndex(5));
            repo.StopAlert_ReasonPrescribingDrug.ButtonOK.Click();
            Delay.Milliseconds(200);
            
            // Click on OK
            Report.Log(ReportLevel.Info, "Mouse", "Click on OK\r\nMouse Left Click item 'AddWardMedication.ButtonOK' at Center.", repo.AddWardMedication.ButtonOKInfo, new RecordItemIndex(6));
            repo.AddWardMedication.ButtonOK.Click();
            Delay.Milliseconds(200);
            
            // Verify the medication is added successfully
            Report.Log(ReportLevel.Info, "Validation", "Verify the medication is added successfully\r\nValidating Exists on item 'FrmORMain.PostOpInstructions.Ward.WardListItem'.", repo.FrmORMain.PostOpInstructions.Ward.WardListItemInfo, new RecordItemIndex(7));
            Validate.Exists(repo.FrmORMain.PostOpInstructions.Ward.WardListItemInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}