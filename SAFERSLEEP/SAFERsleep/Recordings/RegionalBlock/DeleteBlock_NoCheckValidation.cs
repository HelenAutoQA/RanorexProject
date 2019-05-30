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

namespace SAFERsleep.Recordings.RegionalBlock
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DeleteBlock_NoCheckValidation recording.
    /// </summary>
    [TestModule("6954b56b-33fd-4607-8dc3-f7b676945e88", ModuleType.Recording, 1)]
    public partial class DeleteBlock_NoCheckValidation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static DeleteBlock_NoCheckValidation instance = new DeleteBlock_NoCheckValidation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteBlock_NoCheckValidation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeleteBlock_NoCheckValidation Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.RegionalBlock.DeleteRegional' at Center.", repo.FrmORMain.RegionalBlock.DeleteRegionalInfo, new RecordItemIndex(0));
            repo.FrmORMain.RegionalBlock.DeleteRegional.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmConfirmation.DeleteRegionalBlock'.", repo.FrmConfirmation.DeleteRegionalBlockInfo, new RecordItemIndex(1));
            Validate.Exists(repo.FrmConfirmation.DeleteRegionalBlockInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmConfirmation.Yes' at Center.", repo.FrmConfirmation.YesInfo, new RecordItemIndex(2));
            repo.FrmConfirmation.Yes.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmConfirmation.DeleteRegionalDrugsForThisBlock'.", repo.FrmConfirmation.DeleteRegionalDrugsForThisBlockInfo, new RecordItemIndex(3));
            Validate.Exists(repo.FrmConfirmation.DeleteRegionalDrugsForThisBlockInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmConfirmation.Yes' at Center.", repo.FrmConfirmation.YesInfo, new RecordItemIndex(4));
            repo.FrmConfirmation.Yes.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}