﻿/*
 * Created by Ranorex
 * User: Admin
 * Date: 17/04/2019
 * Time: 2:26 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace SAFERSleep_AP.Recordings.Modalities.PCA
{
    /// <summary>
    /// Description of ValidateAddedPCA.
    /// </summary>
    [TestModule("B90995E9-2BE3-49AA-8A99-B5762587786F", ModuleType.UserCode, 1)]
    public class ValidateAddedPCA : ITestModule
    {
    	SAFERSleep_APRepository MyRepo = new SAFERSleep_APRepository();
		
    	string _Medication = "";
    	[TestVariable("b6d3cfd9-9ccc-40ca-b92e-69ffbc66a547")]
    	public string Medication
    	{
    		get { return _Medication; }
    		set { _Medication = value; }
    	}
    	
    	string _Dose = "";
    	[TestVariable("123dc33e-61a1-4808-9cdc-a9bcc610e348")]
    	public string Dose
    	{
    		get { return _Dose; }
    		set { _Dose = value; }
    	}
    	
    	string _Lockout = "";
    	[TestVariable("cf308de6-9c77-4df8-be97-accd42f0cf02")]
    	public string Lockout
    	{
    		get { return _Lockout; }
    		set { _Lockout = value; }
    	}
    	
    	string _Unit = "";
    	[TestVariable("acae6d43-5694-4eed-8a7d-9461af233350")]
    	public string Unit
    	{
    		get { return _Unit; }
    		set { _Unit = value; }
    	}
    	
    	string _Rate = "";
    	[TestVariable("07b11001-81a4-40e3-9160-620c51f3d7f2")]
    	public string Rate
    	{
    		get { return _Rate; }
    		set { _Rate = value; }
    	}
    	
    	string _hr = "";
    	[TestVariable("3f68e6a8-4f80-4fd1-a057-a77f36f53884")]
    	public string hr
    	{
    		get { return _hr; }
    		set { _hr = value; }
    	}
    	
    	string _DoseLimit = "";
    	[TestVariable("a81d948d-881a-4f3a-806e-7d89dc6aae70")]
    	public string DoseLimit
    	{
    		get { return _DoseLimit; }
    		set { _DoseLimit = value; }
    	}    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateAddedPCA()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            int index = Medication.IndexOf("(");
            if (index > 0)
            	Medication = Medication.Substring(0, index - 1);
            MyRepo.Medication = Medication;
            
            Ranorex.Report.Info("Validate PCA Medication: "+Medication);
            Validate.Exists(MyRepo.MainWindow.Modalities.AdvancedModalities.AddedPCAInfo);
            
            if (Dose != "")
            {
            	Ranorex.Report.Info("Validate Bolus Dose: "+Dose+" "+Unit);
            	Validate.AttributeContains(MyRepo.MainWindow.Modalities.AdvancedModalities.AddedPCAInfo, "caption", "Bolus dose: "+Dose+" "+Unit);
            }
            
            if (Dose != "")
            {
            	Ranorex.Report.Info("Validate Bolus Lockout: "+Lockout+" minutes");
            	Validate.AttributeContains(MyRepo.MainWindow.Modalities.AdvancedModalities.AddedPCAInfo, "caption", "Lockout: "+Lockout+" minutes");
            }
            
            if (Rate != "")
            {
            	Ranorex.Report.Info("Validate Continuous Rate: "+Rate+" "+Unit);
            	Validate.AttributeContains(MyRepo.MainWindow.Modalities.AdvancedModalities.AddedPCAInfo, "caption", "Continuous rate: "+Rate+" "+Unit);
            }
            
            if (DoseLimit != "")
            {
            	Ranorex.Report.Info("Validate "+hr+" hr Dose Limit: "+DoseLimit+" "+Unit);
            	Validate.AttributeContains(MyRepo.MainWindow.Modalities.AdvancedModalities.AddedPCAInfo, "caption", hr+" hr dose limit: "+DoseLimit+" "+Unit);
            }
        }
    }
}
