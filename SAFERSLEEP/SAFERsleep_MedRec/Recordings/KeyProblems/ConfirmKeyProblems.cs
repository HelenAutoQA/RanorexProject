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

namespace SAFERsleep_MedRec.Recordings.KeyProblems
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ConfirmKeyProblems recording.
    /// </summary>
    [TestModule("5223f628-a791-4497-a3c4-6cf0f4aefd77", ModuleType.Recording, 1)]
    public partial class ConfirmKeyProblems : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep_MedRec.SAFERsleep_MedRecRepository repository.
        /// </summary>
        public static SAFERsleep_MedRec.SAFERsleep_MedRecRepository repo = SAFERsleep_MedRec.SAFERsleep_MedRecRepository.Instance;

        static ConfirmKeyProblems instance = new ConfirmKeyProblems();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ConfirmKeyProblems()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ConfirmKeyProblems Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MedRecWindow.MedRec.KeyProblems.ConfirmKeyProblems' at Center.", repo.MedRecWindow.MedRec.KeyProblems.ConfirmKeyProblemsInfo, new RecordItemIndex(0));
            repo.MedRecWindow.MedRec.KeyProblems.ConfirmKeyProblems.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}