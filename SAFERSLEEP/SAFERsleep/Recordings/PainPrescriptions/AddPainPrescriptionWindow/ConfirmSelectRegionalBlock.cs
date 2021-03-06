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
    ///The ConfirmSelectRegionalBlock recording.
    /// </summary>
    [TestModule("2fd88d21-c9ab-48bd-94cc-2a93aeca56d4", ModuleType.Recording, 1)]
    public partial class ConfirmSelectRegionalBlock : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static ConfirmSelectRegionalBlock instance = new ConfirmSelectRegionalBlock();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ConfirmSelectRegionalBlock()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ConfirmSelectRegionalBlock Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Error.PleaseSelectTheRegionalBlock'.", repo.Error.PleaseSelectTheRegionalBlockInfo, new RecordItemIndex(0));
            Validate.Exists(repo.Error.PleaseSelectTheRegionalBlockInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Error.ButtonOK' at Center.", repo.Error.ButtonOKInfo, new RecordItemIndex(1));
            repo.Error.ButtonOK.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
