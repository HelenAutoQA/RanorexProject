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

namespace SAFERsleep.Recordings.Application
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LaunchApplication recording.
    /// </summary>
    [TestModule("db7ec90a-c3c2-4988-8d78-d99257f25e23", ModuleType.Recording, 1)]
    public partial class LaunchApplication : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static LaunchApplication instance = new LaunchApplication();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LaunchApplication()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LaunchApplication Instance
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

            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files\\SAFERsleep\\SAFERsleep OR\\SAFERsleepOR.exe' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\Program Files\\SAFERsleep\\SAFERsleep OR\\SAFERsleepOR.exe", "", "C:\\Program Files\\SAFERsleep\\SAFERsleep OR", false);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
