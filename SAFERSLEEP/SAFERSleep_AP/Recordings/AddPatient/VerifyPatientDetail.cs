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

namespace SAFERSleep_AP.Recordings.AddPatient
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VerifyPatientDetail recording.
    /// </summary>
    [TestModule("09a19dbf-c6ac-4343-8fa4-ddd4a8a3cb74", ModuleType.Recording, 1)]
    public partial class VerifyPatientDetail : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERSleep_AP.SAFERSleep_APRepository repository.
        /// </summary>
        public static SAFERSleep_AP.SAFERSleep_APRepository repo = SAFERSleep_AP.SAFERSleep_APRepository.Instance;

        static VerifyPatientDetail instance = new VerifyPatientDetail();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyPatientDetail()
        {
            DOB = "08-Jan-2017";
            Gender = "male";
            Weight = "60";
            Height = "170";
            RefDate = "Today";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyPatientDetail Instance
        {
            get { return instance; }
        }

#region Variables

        string _Height;

        /// <summary>
        /// Gets or sets the value of variable Height.
        /// </summary>
        [TestVariable("3f358e50-918d-4f54-9c66-9b2cb8fb18b0")]
        public string Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        string _RefDate;

        /// <summary>
        /// Gets or sets the value of variable RefDate.
        /// </summary>
        [TestVariable("bbc8ef0a-8596-4758-9ac1-3e872f316e6b")]
        public string RefDate
        {
            get { return _RefDate; }
            set { _RefDate = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Age.
        /// </summary>
        [TestVariable("66765106-b07a-43cd-bd86-459384bf6f84")]
        public string Age
        {
            get { return repo.Age; }
            set { repo.Age = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Gender.
        /// </summary>
        [TestVariable("73a78519-0a06-4ff0-bf1e-ce8e1d029575")]
        public string Gender
        {
            get { return repo.Gender; }
            set { repo.Gender = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable BMI.
        /// </summary>
        [TestVariable("f224f7df-037c-42fc-92d2-a66e85b6ea1c")]
        public string BMI
        {
            get { return repo.BMI; }
            set { repo.BMI = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Weight.
        /// </summary>
        [TestVariable("3b98b415-071b-4c35-bd7a-da6105b92168")]
        public string Weight
        {
            get { return repo.Weight; }
            set { repo.Weight = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ReferralDate.
        /// </summary>
        [TestVariable("6c216c96-34ae-4972-89d2-03f6feb55bd7")]
        public string ReferralDate
        {
            get { return repo.ReferralDate; }
            set { repo.ReferralDate = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable RefDays.
        /// </summary>
        [TestVariable("0fca950c-88d5-47f9-84f1-76c06b7de42b")]
        public string RefDays
        {
            get { return repo.RefDays; }
            set { repo.RefDays = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NHI.
        /// </summary>
        [TestVariable("e027bc68-a644-4689-a8bc-9f072a168278")]
        public string NHI
        {
            get { return repo.NHI; }
            set { repo.NHI = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Ward.
        /// </summary>
        [TestVariable("86013d6d-817a-4fae-b75c-0efe3bd89f54")]
        public string Ward
        {
            get { return repo.Ward; }
            set { repo.Ward = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Room.
        /// </summary>
        [TestVariable("4423e698-bc8f-41c1-8563-5d74026b9676")]
        public string Room
        {
            get { return repo.Room; }
            set { repo.Room = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DOB.
        /// </summary>
        [TestVariable("3437a502-a17c-4124-b727-216c9ff7f04b")]
        public string DOB
        {
            get { return repo.DOB; }
            set { repo.DOB = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ASA.
        /// </summary>
        [TestVariable("1e1ce02d-79ce-40c3-a91b-372d1e83cdc4")]
        public string ASA
        {
            get { return repo.ASA; }
            set { repo.ASA = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MainWindow.PainReviewHeader.PatientRibbon.NHI'.", repo.MainWindow.PainReviewHeader.PatientRibbon.NHIInfo, new RecordItemIndex(0));
            Validate.Exists(repo.MainWindow.PainReviewHeader.PatientRibbon.NHIInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MainWindow.PainReviewHeader.PatientRibbon.Location'.", repo.MainWindow.PainReviewHeader.PatientRibbon.LocationInfo, new RecordItemIndex(1));
            Validate.Exists(repo.MainWindow.PainReviewHeader.PatientRibbon.LocationInfo);
            Delay.Milliseconds(0);
            
            ValidatePatientAge(DOB);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MainWindow.PainReviewHeader.PatientDetails.DateOfBirth'.", repo.MainWindow.PainReviewHeader.PatientDetails.DateOfBirthInfo, new RecordItemIndex(3));
            Validate.Exists(repo.MainWindow.PainReviewHeader.PatientDetails.DateOfBirthInfo);
            Delay.Milliseconds(0);
            
            ValidateGender(Gender);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MainWindow.PainReviewHeader.PatientDetails.ASA'.", repo.MainWindow.PainReviewHeader.PatientDetails.ASAInfo, new RecordItemIndex(5));
            Validate.Exists(repo.MainWindow.PainReviewHeader.PatientDetails.ASAInfo);
            Delay.Milliseconds(0);
            
            ValidateWeight(ValueConverter.ArgumentFromString<double>("Weight", Weight));
            Delay.Milliseconds(0);
            
            ValidateBMI(ValueConverter.ArgumentFromString<double>("Weight", Weight), ValueConverter.ArgumentFromString<double>("Height", Height));
            Delay.Milliseconds(0);
            
            ValidateReferralDate(RefDate);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}