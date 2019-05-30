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
    ///The FluidPres_Save_Template recording.
    /// </summary>
    [TestModule("9bb1712d-238a-4896-9106-51f58ed4e4d4", ModuleType.Recording, 1)]
    public partial class FluidPres_Save_Template : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static FluidPres_Save_Template instance = new FluidPres_Save_Template();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FluidPres_Save_Template()
        {
            TemplateName = "Auto Fluid Prescription";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FluidPres_Save_Template Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable TemplateName.
        /// </summary>
        [TestVariable("90c95f62-4fe4-4da4-8962-abbb2a7a6cd4")]
        public string TemplateName
        {
            get { return repo.TemplateName; }
            set { repo.TemplateName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FluidInstruction.
        /// </summary>
        [TestVariable("6ec28f55-412a-4d98-a958-d1b30ccecd21")]
        public string FluidInstruction
        {
            get { return repo.FluidInstruction; }
            set { repo.FluidInstruction = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FluidRate.
        /// </summary>
        [TestVariable("f438dd07-70ce-4ff2-ab1f-87313b802fbc")]
        public string FluidRate
        {
            get { return repo.FluidRate; }
            set { repo.FluidRate = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FluidVolume.
        /// </summary>
        [TestVariable("ea79c042-41bd-43a7-82f0-cf631466a6dd")]
        public string FluidVolume
        {
            get { return repo.FluidVolume; }
            set { repo.FluidVolume = value; }
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
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TemplateAdministration.FluidPresListItem'.", repo.TemplateAdministration.FluidPresListItemInfo, new RecordItemIndex(9));
            Validate.Exists(repo.TemplateAdministration.FluidPresListItemInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TemplateAdministration.ButtonClose' at Center.", repo.TemplateAdministration.ButtonCloseInfo, new RecordItemIndex(10));
            repo.TemplateAdministration.ButtonClose.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Templates.TemplatesForm.Close' at Center.", repo.Templates.TemplatesForm.CloseInfo, new RecordItemIndex(11));
            repo.Templates.TemplatesForm.Close.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
