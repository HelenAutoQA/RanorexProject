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

namespace SAFERSleep_AP.Recordings.RoundTeam
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddExistingTeamMember recording.
    /// </summary>
    [TestModule("813c1036-f1c8-4988-99de-7886522b0164", ModuleType.Recording, 1)]
    public partial class AddExistingTeamMember : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERSleep_AP.SAFERSleep_APRepository repository.
        /// </summary>
        public static SAFERSleep_AP.SAFERSleep_APRepository repo = SAFERSleep_AP.SAFERSleep_APRepository.Instance;

        static AddExistingTeamMember instance = new AddExistingTeamMember();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddExistingTeamMember()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddExistingTeamMember Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable TeamMember.
        /// </summary>
        [TestVariable("b8016435-1fb2-4c22-b2d3-8bd780a97d05")]
        public string TeamMember
        {
            get { return repo.TeamMember; }
            set { repo.TeamMember = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.RoundTeam.AddTeamMember' at Center.", repo.MainWindow.RoundTeam.AddTeamMemberInfo, new RecordItemIndex(0));
            repo.MainWindow.RoundTeam.AddTeamMember.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ListItems.TeamMember' at Center.", repo.ListItems.TeamMemberInfo, new RecordItemIndex(1));
            repo.ListItems.TeamMember.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.RoundTeam.Save' at Center.", repo.MainWindow.RoundTeam.SaveInfo, new RecordItemIndex(2));
            repo.MainWindow.RoundTeam.Save.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
