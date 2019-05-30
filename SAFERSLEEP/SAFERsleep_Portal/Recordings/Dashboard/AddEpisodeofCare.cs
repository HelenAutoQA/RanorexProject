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

namespace SAFERsleep_Portal.Recordings.Dashboard
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddEpisodeofCare recording.
    /// </summary>
    [TestModule("88b53894-8933-400d-801a-ac1e16b7dacc", ModuleType.Recording, 1)]
    public partial class AddEpisodeofCare : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep_Portal.SAFERsleep_PortalRepository repository.
        /// </summary>
        public static SAFERsleep_Portal.SAFERsleep_PortalRepository repo = SAFERsleep_Portal.SAFERsleep_PortalRepository.Instance;

        static AddEpisodeofCare instance = new AddEpisodeofCare();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddEpisodeofCare()
        {
            EpisodeName = "Test Episode";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddEpisodeofCare Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable EpisodeName.
        /// </summary>
        [TestVariable("39fd5862-e2f9-4fec-984f-0c9a58ead461")]
        public string EpisodeName
        {
            get { return repo.EpisodeName; }
            set { repo.EpisodeName = value; }
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
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PatientDashboard.AddEpisode.AddEpisodeOfCare' at Center.", repo.PatientDashboard.AddEpisode.AddEpisodeOfCareInfo, new RecordItemIndex(0));
            repo.PatientDashboard.AddEpisode.AddEpisodeOfCare.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PatientDashboard.AddEpisode.EpisodeDescription' at Center.", repo.PatientDashboard.AddEpisode.EpisodeDescriptionInfo, new RecordItemIndex(1));
            repo.PatientDashboard.AddEpisode.EpisodeDescription.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EpisodeName'.", new RecordItemIndex(2));
            Keyboard.Press(EpisodeName);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PatientDashboard.AddEpisode.ReferralDate' at Center.", repo.PatientDashboard.AddEpisode.ReferralDateInfo, new RecordItemIndex(3));
            repo.PatientDashboard.AddEpisode.ReferralDate.Click();
            
            DateNow();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PatientDashboard.AddEpisode.BtnSave' at Center.", repo.PatientDashboard.AddEpisode.BtnSaveInfo, new RecordItemIndex(5));
            repo.PatientDashboard.AddEpisode.BtnSave.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}