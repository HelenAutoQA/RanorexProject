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

namespace SAFERSleep_AP.Recordings.ActiveProblems
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddCondition recording.
    /// </summary>
    [TestModule("3f03a1e4-4085-4630-a78b-050c4f0c136d", ModuleType.Recording, 1)]
    public partial class AddCondition : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERSleep_AP.SAFERSleep_APRepository repository.
        /// </summary>
        public static SAFERSleep_AP.SAFERSleep_APRepository repo = SAFERSleep_AP.SAFERSleep_APRepository.Instance;

        static AddCondition instance = new AddCondition();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddCondition()
        {
            AsthmaNote = "This is a test Asthma note";
            ChronicNote = "This is a test Chronic note";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddCondition Instance
        {
            get { return instance; }
        }

#region Variables

        string _AsthmaNote;

        /// <summary>
        /// Gets or sets the value of variable AsthmaNote.
        /// </summary>
        [TestVariable("720738db-845c-4299-adc4-d7c4ed0881d3")]
        public string AsthmaNote
        {
            get { return _AsthmaNote; }
            set { _AsthmaNote = value; }
        }

        string _ChronicNote;

        /// <summary>
        /// Gets or sets the value of variable ChronicNote.
        /// </summary>
        [TestVariable("f0f0b59d-e641-4ad4-a9bf-57b9ab15ca89")]
        public string ChronicNote
        {
            get { return _ChronicNote; }
            set { _ChronicNote = value; }
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

            // Click on Update /View  Active Problem
            Report.Log(ReportLevel.Info, "Mouse", "Click on Update /View  Active Problem\r\nMouse Left Click item 'MainWindow.ActiveProblems.Add_Allergies' at Center.", repo.MainWindow.ActiveProblems.Add_AllergiesInfo, new RecordItemIndex(0));
            repo.MainWindow.ActiveProblems.Add_Allergies.Click();
            
            // Click on Condition Tab
            Report.Log(ReportLevel.Info, "Mouse", "Click on Condition Tab\r\nMouse Left Click item 'MainWindow.ActiveProblems.PopupWindows.ConditionsTab' at Center.", repo.MainWindow.ActiveProblems.PopupWindows.ConditionsTabInfo, new RecordItemIndex(1));
            repo.MainWindow.ActiveProblems.PopupWindows.ConditionsTab.Click();
            
            // Click on Asthma
            Report.Log(ReportLevel.Info, "Mouse", "Click on Asthma\r\nMouse Left Click item 'MainWindow.ActiveProblems.PopupWindows.Conditions.Asthma' at Center.", repo.MainWindow.ActiveProblems.PopupWindows.Conditions.AsthmaInfo, new RecordItemIndex(2));
            repo.MainWindow.ActiveProblems.PopupWindows.Conditions.Asthma.Click();
            
            // Enter Asthma note
            Report.Log(ReportLevel.Info, "Mouse", "Enter Asthma note\r\nMouse Left Click item 'MainWindow.ActiveProblems.PopupWindows.Conditions.AsthmaNote' at Center.", repo.MainWindow.ActiveProblems.PopupWindows.Conditions.AsthmaNoteInfo, new RecordItemIndex(3));
            repo.MainWindow.ActiveProblems.PopupWindows.Conditions.AsthmaNote.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AsthmaNote'.", new RecordItemIndex(4));
            Keyboard.Press(AsthmaNote);
            
            // Click on Chronic
            Report.Log(ReportLevel.Info, "Mouse", "Click on Chronic\r\nMouse Left Click item 'MainWindow.ActiveProblems.PopupWindows.Conditions.ChronicOpioidUse' at Center.", repo.MainWindow.ActiveProblems.PopupWindows.Conditions.ChronicOpioidUseInfo, new RecordItemIndex(5));
            repo.MainWindow.ActiveProblems.PopupWindows.Conditions.ChronicOpioidUse.Click();
            
            // Enter Chronic Note
            Report.Log(ReportLevel.Info, "Mouse", "Enter Chronic Note\r\nMouse Left Click item 'MainWindow.ActiveProblems.PopupWindows.Conditions.ChronicOpioidUseNote' at Center.", repo.MainWindow.ActiveProblems.PopupWindows.Conditions.ChronicOpioidUseNoteInfo, new RecordItemIndex(6));
            repo.MainWindow.ActiveProblems.PopupWindows.Conditions.ChronicOpioidUseNote.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ChronicNote'.", new RecordItemIndex(7));
            Keyboard.Press(ChronicNote);
            
            // Click on Psychiatric
            Report.Log(ReportLevel.Info, "Mouse", "Click on Psychiatric\r\nMouse Left Click item 'MainWindow.ActiveProblems.PopupWindows.Conditions.PsychiatricDisorder' at Center.", repo.MainWindow.ActiveProblems.PopupWindows.Conditions.PsychiatricDisorderInfo, new RecordItemIndex(8));
            repo.MainWindow.ActiveProblems.PopupWindows.Conditions.PsychiatricDisorder.Click();
            
            // Select Anxiety
            Report.Log(ReportLevel.Info, "Mouse", "Select Anxiety\r\nMouse Left Click item 'MainWindow.ActiveProblems.PopupWindows.Conditions.Anxiety' at Center.", repo.MainWindow.ActiveProblems.PopupWindows.Conditions.AnxietyInfo, new RecordItemIndex(9));
            repo.MainWindow.ActiveProblems.PopupWindows.Conditions.Anxiety.Click();
            
            // Click on Save
            Report.Log(ReportLevel.Info, "Mouse", "Click on Save\r\nMouse Left Click item 'MainWindow.ActiveProblems.PopupWindows.NoComorbidities' at Center.", repo.MainWindow.ActiveProblems.PopupWindows.NoComorbiditiesInfo, new RecordItemIndex(10));
            repo.MainWindow.ActiveProblems.PopupWindows.NoComorbidities.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
