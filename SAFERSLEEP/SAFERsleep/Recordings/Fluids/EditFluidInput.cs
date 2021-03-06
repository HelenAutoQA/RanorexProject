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

namespace SAFERsleep.Recordings.Fluids
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EditFluidInput recording.
    /// </summary>
    [TestModule("2ac2b714-1197-402b-914f-ebdf304a69ed", ModuleType.Recording, 1)]
    public partial class EditFluidInput : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static EditFluidInput instance = new EditFluidInput();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditFluidInput()
        {
            EditStartVolume = "1000";
            EditFinishVolume = "100";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditFluidInput Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable InputUnit.
        /// </summary>
        [TestVariable("f7ae56b5-4f13-4bca-9e52-cb482d8ef45c")]
        public string InputUnit
        {
            get { return repo.InputUnit; }
            set { repo.InputUnit = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable StartInputLevel.
        /// </summary>
        [TestVariable("f7d2923b-5e58-46ad-bc1e-8e36673a7b21")]
        public string StartInputLevel
        {
            get { return repo.StartInputLevel; }
            set { repo.StartInputLevel = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FluidInputName.
        /// </summary>
        [TestVariable("85b9105e-a9b6-4a9c-be8e-99aed3840454")]
        public string FluidInputName
        {
            get { return repo.FluidInputName; }
            set { repo.FluidInputName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable EditInputUnit.
        /// </summary>
        [TestVariable("b7874ba9-9473-4b4e-8449-b49179a8717d")]
        public string EditInputUnit
        {
            get { return repo.EditInputUnit; }
            set { repo.EditInputUnit = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable EditVolumeGiven.
        /// </summary>
        [TestVariable("4bcd71b9-3ad3-44a9-9c80-3c481a2ed6e1")]
        public string EditVolumeGiven
        {
            get { return repo.EditVolumeGiven; }
            set { repo.EditVolumeGiven = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable EditFinishVolume.
        /// </summary>
        [TestVariable("7bb3001d-bac5-4197-93a3-87a8e72a21be")]
        public string EditFinishVolume
        {
            get { return repo.EditFinishVolume; }
            set { repo.EditFinishVolume = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable EditStartVolume.
        /// </summary>
        [TestVariable("be4be9e2-66f1-42dc-a589-11fac6bc7b1a")]
        public string EditStartVolume
        {
            get { return repo.EditStartVolume; }
            set { repo.EditStartVolume = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable EditFluidInputName.
        /// </summary>
        [TestVariable("34518d4b-cae1-4928-b338-792a14a030ca")]
        public string EditFluidInputName
        {
            get { return repo.EditFluidInputName; }
            set { repo.EditFluidInputName = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.FluidBalance.Tabs.FluidInput' at Center.", repo.FrmORMain.FluidBalance.Tabs.FluidInputInfo, new RecordItemIndex(0));
            repo.FrmORMain.FluidBalance.Tabs.FluidInput.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.FluidBalance.AddedFluidInput' at Center.", repo.FrmORMain.FluidBalance.AddedFluidInputInfo, new RecordItemIndex(1));
            repo.FrmORMain.FluidBalance.AddedFluidInput.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.FluidBalance.EditFluidInput' at Center.", repo.FrmORMain.FluidBalance.EditFluidInputInfo, new RecordItemIndex(2));
            repo.FrmORMain.FluidBalance.EditFluidInput.Click();
            Delay.Milliseconds(200);
            
            UserCodeCollection_OR.Clear_TextBox(repo.AddFluidInput.StartVolumeInfo, "Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EditStartVolume'.", new RecordItemIndex(4));
            Keyboard.Press(EditStartVolume);
            Delay.Milliseconds(100);
            
            UserCodeCollection_OR.Clear_TextBox(repo.AddFluidInput.FinishVolumeInfo, "Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EditFinishVolume'.", new RecordItemIndex(6));
            Keyboard.Press(EditFinishVolume);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddFluidInput.ButtonOK' at Center.", repo.AddFluidInput.ButtonOKInfo, new RecordItemIndex(7));
            repo.AddFluidInput.ButtonOK.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmORMain.FluidBalance.EditedFluidInput'.", repo.FrmORMain.FluidBalance.EditedFluidInputInfo, new RecordItemIndex(8));
            Validate.Exists(repo.FrmORMain.FluidBalance.EditedFluidInputInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
