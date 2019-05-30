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

namespace SAFERsleep_Portal.Recordings.Forms.PreOp_Assessment.Medical_Surgical_History
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Set_FamilyHistory recording.
    /// </summary>
    [TestModule("7af47bf2-23f0-40c5-9c15-a99fbacd8032", ModuleType.Recording, 1)]
    public partial class Set_FamilyHistory : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep_Portal.SAFERsleep_PortalRepository repository.
        /// </summary>
        public static SAFERsleep_Portal.SAFERsleep_PortalRepository repo = SAFERsleep_Portal.SAFERsleep_PortalRepository.Instance;

        static Set_FamilyHistory instance = new Set_FamilyHistory();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Set_FamilyHistory()
        {
            FamilyHistory_Status = "Yes";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Set_FamilyHistory Instance
        {
            get { return instance; }
        }

#region Variables

        string _FamilyHistory_Status;

        /// <summary>
        /// Gets or sets the value of variable FamilyHistory_Status.
        /// </summary>
        [TestVariable("232c66f6-e56c-4de0-a5ae-6010d2a2d12e")]
        public string FamilyHistory_Status
        {
            get { return _FamilyHistory_Status; }
            set { _FamilyHistory_Status = value; }
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

            Set_FamilyHistory_Method(FamilyHistory_Status);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
