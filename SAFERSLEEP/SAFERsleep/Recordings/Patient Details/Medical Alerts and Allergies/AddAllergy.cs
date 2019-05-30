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
    ///The AddAllergy recording.
    /// </summary>
    [TestModule("3d8d1ef2-e432-4cf5-94a1-b511f84c0036", ModuleType.Recording, 1)]
    public partial class AddAllergy : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static AddAllergy instance = new AddAllergy();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddAllergy()
        {
            AllergyName = "Morphine";
            AllergyDetails = "this is a test allergy";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddAllergy Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable WarningType.
        /// </summary>
        [TestVariable("b77bf5d2-c512-4cb5-bdeb-569bd2e82eb6")]
        public string WarningType
        {
            get { return repo.WarningType; }
            set { repo.WarningType = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable AllergyDetails.
        /// </summary>
        [TestVariable("1d157962-fa22-461b-97d9-0b418f81fcd5")]
        public string AllergyDetails
        {
            get { return repo.AllergyDetails; }
            set { repo.AllergyDetails = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable AllergyName.
        /// </summary>
        [TestVariable("ea2098c1-4962-4eb8-a950-122fadae2ce6")]
        public string AllergyName
        {
            get { return repo.AllergyName; }
            set { repo.AllergyName = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AddDrugAllergyCI' at Center.", repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AddDrugAllergyCIInfo, new RecordItemIndex(0));
            repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AddDrugAllergyCI.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAddDrugAllergy.AllergyName' at Center.", repo.FrmAddDrugAllergy.AllergyNameInfo, new RecordItemIndex(1));
            repo.FrmAddDrugAllergy.AllergyName.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AllergyName'.", new RecordItemIndex(2));
            Keyboard.Press(AllergyName);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAddDrugAllergy.AllergyName' at Center.", repo.FrmAddDrugAllergy.AllergyNameInfo, new RecordItemIndex(3));
            repo.FrmAddDrugAllergy.AllergyName.Click();
            
            // Adverse Reaction; Possible Contraindication; Contraindication; Possible Allergy; Allergy
            Report.Log(ReportLevel.Info, "Mouse", "Adverse Reaction; Possible Contraindication; Contraindication; Possible Allergy; Allergy\r\nMouse Left Click item 'FrmAddDrugAllergy.WarningType' at Center.", repo.FrmAddDrugAllergy.WarningTypeInfo, new RecordItemIndex(4));
            repo.FrmAddDrugAllergy.WarningType.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAddDrugAllergy.AllergyDetails' at Center.", repo.FrmAddDrugAllergy.AllergyDetailsInfo, new RecordItemIndex(5));
            repo.FrmAddDrugAllergy.AllergyDetails.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AllergyDetails'.", new RecordItemIndex(6));
            Keyboard.Press(AllergyDetails);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAddDrugAllergy.OK' at Center.", repo.FrmAddDrugAllergy.OKInfo, new RecordItemIndex(7));
            repo.FrmAddDrugAllergy.OK.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AllergyListItem'.", repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AllergyListItemInfo, new RecordItemIndex(8));
            Validate.Exists(repo.FrmORMain.Patient_Details.Medical_Alerts_and_Allergies.AllergyListItemInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
