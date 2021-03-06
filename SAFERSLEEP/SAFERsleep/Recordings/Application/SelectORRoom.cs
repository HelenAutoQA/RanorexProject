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
    ///The SelectORRoom recording.
    /// </summary>
    [TestModule("d7a6f22f-4b57-4545-ab33-82bc5c44b76e", ModuleType.Recording, 1)]
    public partial class SelectORRoom : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static SelectORRoom instance = new SelectORRoom();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectORRoom()
        {
            ORRoom = "OR 01";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectORRoom Instance
        {
            get { return instance; }
        }

#region Variables

        string _ORRoom;

        /// <summary>
        /// Gets or sets the value of variable ORRoom.
        /// </summary>
        [TestVariable("df72fac0-e06c-4e2b-9cb0-67b7ffef5343")]
        public string ORRoom
        {
            get { return _ORRoom; }
            set { _ORRoom = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ORRoom' with focus on 'FrmORConfirmation.ORRoom'.", repo.FrmORConfirmation.ORRoomInfo, new RecordItemIndex(0));
            repo.FrmORConfirmation.ORRoom.PressKeys(ORRoom);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORConfirmation.OK' at Center.", repo.FrmORConfirmation.OKInfo, new RecordItemIndex(1));
            repo.FrmORConfirmation.OK.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
