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

namespace SAFERsleep.Recordings.Post_Op_Medications.AdministrationDateTime
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AdminDT_EnterTime recording.
    /// </summary>
    [TestModule("f13e80dc-732a-407f-ac17-acf4ee5afe0b", ModuleType.Recording, 1)]
    public partial class AdminDT_EnterTime : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static AdminDT_EnterTime instance = new AdminDT_EnterTime();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AdminDT_EnterTime()
        {
            AdminTime = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AdminDT_EnterTime Instance
        {
            get { return instance; }
        }

#region Variables

        string _AdminTime;

        /// <summary>
        /// Gets or sets the value of variable AdminTime.
        /// </summary>
        [TestVariable("e80e31c1-710e-4e94-b567-ef4ead9908fe")]
        public string AdminTime
        {
            get { return _AdminTime; }
            set { _AdminTime = value; }
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

            UserCodeCollection_OR.Clear_TextBox(repo.AddAdministrationDateTime.AdminTimeInfo, "Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AdminTime'.", new RecordItemIndex(1));
            Keyboard.Press(AdminTime);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
