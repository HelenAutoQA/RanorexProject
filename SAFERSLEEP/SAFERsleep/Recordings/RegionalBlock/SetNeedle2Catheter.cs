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
    ///The SetNeedle2Catheter recording.
    /// </summary>
    [TestModule("a39dbefd-cf06-42d4-80f5-46422d1dafcc", ModuleType.Recording, 1)]
    public partial class SetNeedle2Catheter : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static SetNeedle2Catheter instance = new SetNeedle2Catheter();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SetNeedle2Catheter()
        {
            Needle2 = "Sharp";
            NeedleSize2 = "20";
            Needle2InsertionDepth = "10";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SetNeedle2Catheter Instance
        {
            get { return instance; }
        }

#region Variables

        string _Needle2;

        /// <summary>
        /// Gets or sets the value of variable Needle2.
        /// </summary>
        [TestVariable("8befc02c-79be-4b95-b5ca-07131246c1b3")]
        public string Needle2
        {
            get { return _Needle2; }
            set { _Needle2 = value; }
        }

        string _NeedleSize2;

        /// <summary>
        /// Gets or sets the value of variable NeedleSize2.
        /// </summary>
        [TestVariable("1b0b2caa-3151-4af5-8767-8ec9623e6f3d")]
        public string NeedleSize2
        {
            get { return _NeedleSize2; }
            set { _NeedleSize2 = value; }
        }

        string _Needle2InsertionDepth;

        /// <summary>
        /// Gets or sets the value of variable Needle2InsertionDepth.
        /// </summary>
        [TestVariable("4ebe34bf-71f4-4644-a1d5-7dfaf42599fb")]
        public string Needle2InsertionDepth
        {
            get { return _Needle2InsertionDepth; }
            set { _Needle2InsertionDepth = value; }
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

            // CLick on "Seccond Needle" checkbox
            Mouse_Click_SecondNeedleUsed(repo.AddRegionalBlock.Needle.SecondNeedleUsedInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddRegionalBlock.Needle.Needle2.Needle2Name' at Center.", repo.AddRegionalBlock.Needle.Needle2.Needle2NameInfo, new RecordItemIndex(1));
            repo.AddRegionalBlock.Needle.Needle2.Needle2Name.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Needle2'.", new RecordItemIndex(2));
            Keyboard.Press(Needle2);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddRegionalBlock.Needle.Needle2.Needle2Size' at Center.", repo.AddRegionalBlock.Needle.Needle2.Needle2SizeInfo, new RecordItemIndex(4));
            repo.AddRegionalBlock.Needle.Needle2.Needle2Size.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NeedleSize2'.", new RecordItemIndex(5));
            Keyboard.Press(NeedleSize2);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(6));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddRegionalBlock.Needle.Needle2.Needle2InsertionDepth' at Center.", repo.AddRegionalBlock.Needle.Needle2.Needle2InsertionDepthInfo, new RecordItemIndex(7));
            repo.AddRegionalBlock.Needle.Needle2.Needle2InsertionDepth.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Needle2InsertionDepth'.", new RecordItemIndex(8));
            Keyboard.Press(Needle2InsertionDepth);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
