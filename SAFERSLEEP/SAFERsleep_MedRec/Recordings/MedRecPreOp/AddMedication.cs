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

namespace SAFERsleep_MedRec.Recordings.MedRecPreOp
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddMedication recording.
    /// </summary>
    [TestModule("03e72852-92a0-44e3-8275-15451fb32d6f", ModuleType.Recording, 1)]
    public partial class AddMedication : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep_MedRec.SAFERsleep_MedRecRepository repository.
        /// </summary>
        public static SAFERsleep_MedRec.SAFERsleep_MedRecRepository repo = SAFERsleep_MedRec.SAFERsleep_MedRecRepository.Instance;

        static AddMedication instance = new AddMedication();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddMedication()
        {
            Medication = "Amiodarone";
            Dose = "50";
            Unit = "ml";
            Route = "PO";
            Frequency = "Nocte";
            Comment = "this is a test medication";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddMedication Instance
        {
            get { return instance; }
        }

#region Variables

        string _Dose;

        /// <summary>
        /// Gets or sets the value of variable Dose.
        /// </summary>
        [TestVariable("549f2c4d-b3fe-4474-93df-cbcd2d08933c")]
        public string Dose
        {
            get { return _Dose; }
            set { _Dose = value; }
        }

        string _Unit;

        /// <summary>
        /// Gets or sets the value of variable Unit.
        /// </summary>
        [TestVariable("7be9fbba-0132-410d-bc91-7269d6557300")]
        public string Unit
        {
            get { return _Unit; }
            set { _Unit = value; }
        }

        string _Route;

        /// <summary>
        /// Gets or sets the value of variable Route.
        /// </summary>
        [TestVariable("7b4d5367-6417-4627-883e-fbdb90eb2d75")]
        public string Route
        {
            get { return _Route; }
            set { _Route = value; }
        }

        string _Frequency;

        /// <summary>
        /// Gets or sets the value of variable Frequency.
        /// </summary>
        [TestVariable("f64bdd47-077f-4207-affc-a7422a2580da")]
        public string Frequency
        {
            get { return _Frequency; }
            set { _Frequency = value; }
        }

        string _Comment;

        /// <summary>
        /// Gets or sets the value of variable Comment.
        /// </summary>
        [TestVariable("b79f8d80-b2e8-4eed-aa55-832954b94c29")]
        public string Comment
        {
            get { return _Comment; }
            set { _Comment = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ListItem.
        /// </summary>
        [TestVariable("4d5c41a9-3c68-4ec9-8255-7cf1b033829e")]
        public string ListItem
        {
            get { return repo.ListItem; }
            set { repo.ListItem = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ListItem_2.
        /// </summary>
        [TestVariable("33a108c7-070b-4b73-bc16-439f04193a06")]
        public string ListItem_2
        {
            get { return repo.ListItem_2; }
            set { repo.ListItem_2 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Medication.
        /// </summary>
        [TestVariable("c41c0baf-eae5-4b58-9d05-4b672d15b8b9")]
        public string Medication
        {
            get { return repo.Medication; }
            set { repo.Medication = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MedRecWindow.PreOp.AddMed' at Center.", repo.MedRecWindow.PreOp.AddMedInfo, new RecordItemIndex(0));
            repo.MedRecWindow.PreOp.AddMed.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MedRecWindow.MedRec.AddMedication.SourceOne' at Center.", repo.MedRecWindow.MedRec.AddMedication.SourceOneInfo, new RecordItemIndex(1));
            repo.MedRecWindow.MedRec.AddMedication.SourceOne.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Dropdown.ListItem' at Center.", repo.Dropdown.ListItemInfo, new RecordItemIndex(2));
            repo.Dropdown.ListItem.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MedRecWindow.MedRec.AddMedication.SourceTwo' at Center.", repo.MedRecWindow.MedRec.AddMedication.SourceTwoInfo, new RecordItemIndex(3));
            repo.MedRecWindow.MedRec.AddMedication.SourceTwo.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Dropdown.ListItem_2' at Center.", repo.Dropdown.ListItem_2Info, new RecordItemIndex(4));
            repo.Dropdown.ListItem_2.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MedRecWindow.MedRec.AddMedication.Medication' at Center.", repo.MedRecWindow.MedRec.AddMedication.MedicationInfo, new RecordItemIndex(5));
            repo.MedRecWindow.MedRec.AddMedication.Medication.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Medication'.", new RecordItemIndex(6));
            Keyboard.Press(Medication);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MedRecWindow.MedRec.AddMedication.Dose' at Center.", repo.MedRecWindow.MedRec.AddMedication.DoseInfo, new RecordItemIndex(7));
            repo.MedRecWindow.MedRec.AddMedication.Dose.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Dose'.", new RecordItemIndex(8));
            Keyboard.Press(Dose);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MedRecWindow.MedRec.AddMedication.Unit' at Center.", repo.MedRecWindow.MedRec.AddMedication.UnitInfo, new RecordItemIndex(9));
            repo.MedRecWindow.MedRec.AddMedication.Unit.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Unit'.", new RecordItemIndex(10));
            Keyboard.Press(Unit);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MedRecWindow.MedRec.AddMedication.Route' at Center.", repo.MedRecWindow.MedRec.AddMedication.RouteInfo, new RecordItemIndex(11));
            repo.MedRecWindow.MedRec.AddMedication.Route.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Route'.", new RecordItemIndex(12));
            Keyboard.Press(Route);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MedRecWindow.MedRec.AddMedication.Frequency' at Center.", repo.MedRecWindow.MedRec.AddMedication.FrequencyInfo, new RecordItemIndex(13));
            repo.MedRecWindow.MedRec.AddMedication.Frequency.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Frequency'.", new RecordItemIndex(14));
            Keyboard.Press(Frequency);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MedRecWindow.MedRec.AddMedication.Comment' at Center.", repo.MedRecWindow.MedRec.AddMedication.CommentInfo, new RecordItemIndex(15));
            repo.MedRecWindow.MedRec.AddMedication.Comment.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Comment'.", new RecordItemIndex(16));
            Keyboard.Press(Comment);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MedRecWindow.MedRec.Save' at Center.", repo.MedRecWindow.MedRec.SaveInfo, new RecordItemIndex(17));
            repo.MedRecWindow.MedRec.Save.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MedRecWindow.MedicationListItem'.", repo.MedRecWindow.MedicationListItemInfo, new RecordItemIndex(18));
            Validate.Exists(repo.MedRecWindow.MedicationListItemInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
