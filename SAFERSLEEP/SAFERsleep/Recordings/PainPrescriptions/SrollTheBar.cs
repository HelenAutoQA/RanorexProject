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

namespace SAFERsleep.Recordings.PainPrescriptions
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SrollTheBar recording.
    /// </summary>
    [TestModule("c46b7292-5269-4d35-beab-79fa05dfd21f", ModuleType.Recording, 1)]
    public partial class SrollTheBar : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static SrollTheBar instance = new SrollTheBar();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SrollTheBar()
        {
            ScrollDirection = "down";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SrollTheBar Instance
        {
            get { return instance; }
        }

#region Variables

        string _ScrollDirection;

        /// <summary>
        /// Gets or sets the value of variable ScrollDirection.
        /// </summary>
        [TestVariable("a6243a61-3f2d-4832-9d24-afc9cfc68882")]
        public string ScrollDirection
        {
            get { return _ScrollDirection; }
            set { _ScrollDirection = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PrescriptionType.
        /// </summary>
        [TestVariable("16bcb67e-3d39-4841-a19b-65743594bffd")]
        public string PrescriptionType
        {
            get { return repo.PrescriptionType; }
            set { repo.PrescriptionType = value; }
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

            Scroll(repo.FrmORMain.PainPrescriptions.ScrollBarInfo, ScrollDirection, repo.FrmORMain.PainPrescriptions.AddedPrescriptionInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
