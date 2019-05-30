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

namespace SAFERsleep_MedRec.Recordings.AutoUpdate
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CheckMedRecVersion recording.
    /// </summary>
    [TestModule("5ba09725-738a-4c0e-897a-8af9ba0d098a", ModuleType.Recording, 1)]
    public partial class CheckMedRecVersion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep_MedRec.SAFERsleep_MedRecRepository repository.
        /// </summary>
        public static SAFERsleep_MedRec.SAFERsleep_MedRecRepository repo = SAFERsleep_MedRec.SAFERsleep_MedRecRepository.Instance;

        static CheckMedRecVersion instance = new CheckMedRecVersion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckMedRecVersion()
        {
            Version = "7.10.62.23113";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CheckMedRecVersion Instance
        {
            get { return instance; }
        }

#region Variables

        string _Version;

        /// <summary>
        /// Gets or sets the value of variable Version.
        /// </summary>
        [TestVariable("d1537a3a-5d7e-464b-8461-7c5510cb5b00")]
        public string Version
        {
            get { return _Version; }
            set { _Version = value; }
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

            ValidateMedRecVersion(Version);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}