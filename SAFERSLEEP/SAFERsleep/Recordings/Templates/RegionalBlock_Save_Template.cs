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

namespace SAFERsleep.Recordings.Templates
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RegionalBlock_Save_Template recording.
    /// </summary>
    [TestModule("dbb6af1e-4d65-4718-96b2-523ec2cb6a9b", ModuleType.Recording, 1)]
    public partial class RegionalBlock_Save_Template : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static RegionalBlock_Save_Template instance = new RegionalBlock_Save_Template();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RegionalBlock_Save_Template()
        {
            TemplateName = "Auto Regional Blocks";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RegionalBlock_Save_Template Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable TemplateName.
        /// </summary>
        [TestVariable("1f9109e7-7773-40bc-96bf-3bc793d57cfa")]
        public string TemplateName
        {
            get { return repo.TemplateName; }
            set { repo.TemplateName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable BlockSite.
        /// </summary>
        [TestVariable("a8d40c13-3c4b-41b5-acfa-370964474c38")]
        public string BlockSite
        {
            get { return repo.BlockSite; }
            set { repo.BlockSite = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable BlockName.
        /// </summary>
        [TestVariable("32161158-5512-47e8-b851-e8313fc52ffb")]
        public string BlockName
        {
            get { return repo.BlockName; }
            set { repo.BlockName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Technique.
        /// </summary>
        [TestVariable("870ba5d1-d897-4f56-8060-9a72b391098d")]
        public string Technique
        {
            get { return repo.Technique; }
            set { repo.Technique = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NeedleSize.
        /// </summary>
        [TestVariable("8fb39b85-b10a-4afb-8027-4542c19e911b")]
        public string NeedleSize
        {
            get { return repo.NeedleSize; }
            set { repo.NeedleSize = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Needle.
        /// </summary>
        [TestVariable("e21455c7-4603-47f5-b25f-3b4f3361e289")]
        public string Needle
        {
            get { return repo.Needle; }
            set { repo.Needle = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmORMain.Templates' at Center.", repo.FrmORMain.TemplatesInfo, new RecordItemIndex(0));
            repo.FrmORMain.Templates.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Templates.TemplatesForm.SaveCurrentScreenAsTemplate' at Center.", repo.Templates.TemplatesForm.SaveCurrentScreenAsTemplateInfo, new RecordItemIndex(1));
            repo.Templates.TemplatesForm.SaveCurrentScreenAsTemplate.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Back' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SaveTemplate.TemplateName' at Center.", repo.SaveTemplate.TemplateNameInfo, new RecordItemIndex(3));
            repo.SaveTemplate.TemplateName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TemplateName'.", new RecordItemIndex(4));
            Keyboard.Press(TemplateName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(5));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SaveTemplate.ButtonOK' at Center.", repo.SaveTemplate.ButtonOKInfo, new RecordItemIndex(6));
            repo.SaveTemplate.ButtonOK.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Templates.TemplatesForm.TemplateListItem' at Center.", repo.Templates.TemplatesForm.TemplateListItemInfo, new RecordItemIndex(7));
            repo.Templates.TemplatesForm.TemplateListItem.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Templates.TemplatesForm.ViewTemplate' at Center.", repo.Templates.TemplatesForm.ViewTemplateInfo, new RecordItemIndex(8));
            repo.Templates.TemplatesForm.ViewTemplate.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TemplateAdministration.RegionalBlockListItem'.", repo.TemplateAdministration.RegionalBlockListItemInfo, new RecordItemIndex(9));
            Validate.Exists(repo.TemplateAdministration.RegionalBlockListItemInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TemplateAdministration.RegionalBlockTechnique'.", repo.TemplateAdministration.RegionalBlockTechniqueInfo, new RecordItemIndex(10));
            Validate.Exists(repo.TemplateAdministration.RegionalBlockTechniqueInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TemplateAdministration.RegionalBlockNeedle'.", repo.TemplateAdministration.RegionalBlockNeedleInfo, new RecordItemIndex(11));
            Validate.Exists(repo.TemplateAdministration.RegionalBlockNeedleInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TemplateAdministration.ButtonClose' at Center.", repo.TemplateAdministration.ButtonCloseInfo, new RecordItemIndex(12));
            repo.TemplateAdministration.ButtonClose.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Templates.TemplatesForm.Close' at Center.", repo.Templates.TemplatesForm.CloseInfo, new RecordItemIndex(13));
            repo.Templates.TemplatesForm.Close.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}