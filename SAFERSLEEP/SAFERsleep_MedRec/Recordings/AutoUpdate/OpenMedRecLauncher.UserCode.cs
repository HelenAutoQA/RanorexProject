﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace SAFERsleep_MedRec.Recordings.AutoUpdate
{
    public partial class OpenMedRecLauncher
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Mouse_Click_ButtonRun(RepoItemInfo buttonInfo)
        {
        	if (buttonInfo.Exists(5000))
        	{
	            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'buttonInfo' at Center.", buttonInfo);
	            buttonInfo.FindAdapter<Button>().Click();
        	}
        }
        
        public void Select_Hospital(string hosp)
        {
        	repo.Hospital = hosp;
        	
        	if (repo.SaferSleepClientApplicationUpdateCore.OKInfo.Exists(5000))
        	{
        		repo.SaferSleepClientApplicationUpdateCore.Hospital.Click();
        		Delay.Milliseconds(200);
        		repo.SaferSleepClientApplicationUpdateCore.HospitalListItem.Click();
        		Delay.Milliseconds(200);
        		repo.SaferSleepClientApplicationUpdateCore.OK.Click();
        	}
        }

    }
}
