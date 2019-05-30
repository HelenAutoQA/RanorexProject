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

namespace SAFERsleep.Recordings.Fluids.FunctionalTesting.Output
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DeleteFluidOutput recording.
    /// </summary>
    [TestModule("3d8890a7-0c0f-4963-896a-2948d73cd7a4", ModuleType.Recording, 1)]
    public partial class DeleteFluidOutput : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static DeleteFluidOutput instance = new DeleteFluidOutput();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteFluidOutput()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeleteFluidOutput Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable RunningTotal.
        /// </summary>
        [TestVariable("f71b1ff7-2c24-413a-b09b-ab0ce189b5a2")]
        public string RunningTotal
        {
            get { return repo.RunningTotal; }
            set { repo.RunningTotal = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FluidUnit.
        /// </summary>
        [TestVariable("56d230ba-1e26-4d25-95c6-43a8ccbac0bd")]
        public string FluidUnit
        {
            get { return repo.FluidUnit; }
            set { repo.FluidUnit = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable VolumeGiven.
        /// </summary>
        [TestVariable("0ed5254b-a894-4973-b9d5-992eb91a14cb")]
        public string VolumeGiven
        {
            get { return repo.VolumeGiven; }
            set { repo.VolumeGiven = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FinishLevel.
        /// </summary>
        [TestVariable("247396c2-02ad-4b32-a559-00b229dd1494")]
        public string FinishLevel
        {
            get { return repo.FinishLevel; }
            set { repo.FinishLevel = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable StartLevel.
        /// </summary>
        [TestVariable("9f1ad5c6-5061-441b-b4e2-3ac5e8bc0274")]
        public string StartLevel
        {
            get { return repo.StartLevel; }
            set { repo.StartLevel = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FluidName.
        /// </summary>
        [TestVariable("f8802379-a5c2-4098-a0d6-3cbad52dc7a7")]
        public string FluidName
        {
            get { return repo.FluidName; }
            set { repo.FluidName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TimeAddFluid.
        /// </summary>
        [TestVariable("343d9d2d-04a7-4e1a-a64d-5654d3ea683c")]
        public string TimeAddFluid
        {
            get { return repo.TimeAddFluid; }
            set { repo.TimeAddFluid = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.FluidBalance.Tabs.FluidOutput' at Center.", repo.FrmORMain.FluidBalance.Tabs.FluidOutputInfo, new RecordItemIndex(0));
            repo.FrmORMain.FluidBalance.Tabs.FluidOutput.Click();
            Delay.Milliseconds(200);
            
            SelectFirstOutputItem();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.FluidBalance.AddedFluidOutputDetail' at Center.", repo.FrmORMain.FluidBalance.AddedFluidOutputDetailInfo, new RecordItemIndex(2));
            repo.FrmORMain.FluidBalance.AddedFluidOutputDetail.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.FluidBalance.ButtonDeleteOutput' at Center.", repo.FrmORMain.FluidBalance.ButtonDeleteOutputInfo, new RecordItemIndex(3));
            repo.FrmORMain.FluidBalance.ButtonDeleteOutput.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmConfirmation.DeleteFluidOutputItem'.", repo.FrmConfirmation.DeleteFluidOutputItemInfo, new RecordItemIndex(4));
            Validate.Exists(repo.FrmConfirmation.DeleteFluidOutputItemInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmConfirmation.Yes' at Center.", repo.FrmConfirmation.YesInfo, new RecordItemIndex(5));
            repo.FrmConfirmation.Yes.Click();
            Delay.Milliseconds(200);
            
            SelectFirstOutputItem();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}