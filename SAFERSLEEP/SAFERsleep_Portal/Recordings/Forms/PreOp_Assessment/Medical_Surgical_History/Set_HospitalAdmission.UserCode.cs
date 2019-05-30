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

namespace SAFERsleep_Portal.Recordings.Forms.PreOp_Assessment.Medical_Surgical_History
{
    public partial class Set_HospitalAdmission
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
		
        public void Set_HospitalAdmission_Method(string status)
        {
        	Ranorex.Report.Info("Set Relevant previous hospital admissions to: "+status);
        	if (status == "Yes")
        		repo.PreOperativeForm.PreOpAssessment_Form.MedicalSurgicalHistorySection.HospitalAdmissions_Yes.Click();
        	else
        		repo.PreOperativeForm.PreOpAssessment_Form.MedicalSurgicalHistorySection.HospitalAdmissions_No.Click();
        	Delay.Milliseconds(200);
        }
    }
}
