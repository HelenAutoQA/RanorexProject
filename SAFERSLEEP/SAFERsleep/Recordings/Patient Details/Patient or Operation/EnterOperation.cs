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

namespace SAFERsleep.Recordings.Patient_Details.Patient_or_Operation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EnterOperation recording.
    /// </summary>
    [TestModule("2e9ac7cd-0d0d-494c-91a2-4a5fc37657f3", ModuleType.Recording, 1)]
    public partial class EnterOperation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static EnterOperation instance = new EnterOperation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterOperation()
        {
            Operation = "Test Operation";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterOperation Instance
        {
            get { return instance; }
        }

#region Variables

        string _Operation;

        /// <summary>
        /// Gets or sets the value of variable Operation.
        /// </summary>
        [TestVariable("e724a568-bded-4941-b109-72a2211eeb2f")]
        public string Operation
        {
            get { return _Operation; }
            set { _Operation = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Operation' with focus on 'FrmORMain.Patient_Details.Patient_or_Operation.Operation'.", repo.FrmORMain.Patient_Details.Patient_or_Operation.OperationInfo, new RecordItemIndex(0));
            repo.FrmORMain.Patient_Details.Patient_or_Operation.Operation.PressKeys(Operation);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
