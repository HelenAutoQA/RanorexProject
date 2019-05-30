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

namespace SAFERsleep.Recordings.PainPrescriptions.AddPainPrescriptionWindow
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddRegionalBlock recording.
    /// </summary>
    [TestModule("d2382dfd-8a63-4377-b719-61f11bd64d1c", ModuleType.Recording, 1)]
    public partial class AddRegionalBlock : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static AddRegionalBlock instance = new AddRegionalBlock();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddRegionalBlock()
        {
            Block = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddRegionalBlock Instance
        {
            get { return instance; }
        }

#region Variables

        string _Block;

        /// <summary>
        /// Gets or sets the value of variable Block.
        /// </summary>
        [TestVariable("e00d0542-ac1a-4c7e-8c40-3dd80f5f6d1f")]
        public string Block
        {
            get { return _Block; }
            set { _Block = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FormName.
        /// </summary>
        [TestVariable("177a8e11-f912-45b7-bebc-eda0b3869398")]
        public string FormName
        {
            get { return repo.FormName; }
            set { repo.FormName = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddPainPrescription.RegionalBlock' at Center.", repo.AddPainPrescription.RegionalBlockInfo, new RecordItemIndex(0));
            repo.AddPainPrescription.RegionalBlock.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddRegionalBlock.BlockName' at Center.", repo.AddRegionalBlock.BlockNameInfo, new RecordItemIndex(1));
            repo.AddRegionalBlock.BlockName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Block'.", new RecordItemIndex(2));
            Keyboard.Press(Block);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddRegionalBlock.ButtonOK' at Center.", repo.AddRegionalBlock.ButtonOKInfo, new RecordItemIndex(4));
            repo.AddRegionalBlock.ButtonOK.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}