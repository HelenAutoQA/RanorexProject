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

namespace SAFERsleep.Recordings.Drugs.FunctionalTestDrugs
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CheckDrugInDrugList recording.
    /// </summary>
    [TestModule("f53699d9-e1d6-4acf-a20d-2a69934a3b5e", ModuleType.Recording, 1)]
    public partial class CheckDrugInDrugList : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERsleep.SAFERsleepORRepository repository.
        /// </summary>
        public static SAFERsleep.SAFERsleepORRepository repo = SAFERsleep.SAFERsleepORRepository.Instance;

        static CheckDrugInDrugList instance = new CheckDrugInDrugList();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckDrugInDrugList()
        {
            DoseUnit = "5.5 ml";
            Mode = "Bolus";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CheckDrugInDrugList Instance
        {
            get { return instance; }
        }

#region Variables

        string _Mode;

        /// <summary>
        /// Gets or sets the value of variable Mode.
        /// </summary>
        [TestVariable("7b54b8d7-6771-4e56-a5a1-b1d4dc1e2b80")]
        public string Mode
        {
            get { return _Mode; }
            set { _Mode = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Comment.
        /// </summary>
        [TestVariable("b107503a-1905-4d9f-a866-10f858263131")]
        public string Comment
        {
            get { return repo.Comment; }
            set { repo.Comment = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Route.
        /// </summary>
        [TestVariable("546ee88d-2806-45a5-b54d-c0dc04e81fcc")]
        public string Route
        {
            get { return repo.Route; }
            set { repo.Route = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DoseUnit.
        /// </summary>
        [TestVariable("b39ccba1-21c8-4d2d-9901-b253fec485cf")]
        public string DoseUnit
        {
            get { return repo.DoseUnit; }
            set { repo.DoseUnit = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DrugProduct.
        /// </summary>
        [TestVariable("641b5c67-a6fb-4e92-8699-237e53aff7d5")]
        public string DrugProduct
        {
            get { return repo.DrugProduct; }
            set { repo.DrugProduct = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TimeAddDrug.
        /// </summary>
        [TestVariable("52b8ca0f-383d-46c5-b894-d9ae5ec5540d")]
        public string TimeAddDrug
        {
            get { return repo.TimeAddDrug; }
            set { repo.TimeAddDrug = value; }
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

            // Validate the  Drug is added succesfully
            CheckDrugListItem(Mode);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
