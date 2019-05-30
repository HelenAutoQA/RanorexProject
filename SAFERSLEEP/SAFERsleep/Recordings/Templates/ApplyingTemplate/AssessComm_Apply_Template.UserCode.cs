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

namespace SAFERsleep.Recordings.Templates.ApplyingTemplate
{
    public partial class AssessComm_Apply_Template
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        private string Assessment;
        private string Comment;
		
        public void GetTemplateValues()
        {
        	Ranorex.Report.Info("Getting the values of Assessment and Comment");
        	Assessment = repo.TemplateAdministration.PreOpAssessment.TextValue;
        	Comment = repo.TemplateAdministration.IntraOpComments.TextValue;
        	Delay.Milliseconds(200);
        }
        
        public void ValidateTemplateApplied()
        {
        	Ranorex.Report.Info("Checking values applied from the Template");
        	Validate.AreEqual(repo.FrmORMain.Patient_Details.Assessment.PreOpAssessment.TextValue, Assessment);
        	Delay.Milliseconds(200);
        	Validate.AreEqual(repo.FrmORMain.Patient_Details.Assessment.IntraOpComments.TextValue, Comment);
        	Delay.Milliseconds(200);
        }
    }
}
