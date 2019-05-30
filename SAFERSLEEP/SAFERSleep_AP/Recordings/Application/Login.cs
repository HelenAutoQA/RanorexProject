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

namespace SAFERSleep_AP.Recordings.Application
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Login recording.
    /// </summary>
    [TestModule("f3904c16-39e3-4284-a39e-6d1cc6622e09", ModuleType.Recording, 1)]
    public partial class Login : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SAFERSleep_AP.SAFERSleep_APRepository repository.
        /// </summary>
        public static SAFERSleep_AP.SAFERSleep_APRepository repo = SAFERSleep_AP.SAFERSleep_APRepository.Instance;

        static Login instance = new Login();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Login()
        {
            userName = "admin";
            passWord = "poi098)(*";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Login Instance
        {
            get { return instance; }
        }

#region Variables

        string _userName;

        /// <summary>
        /// Gets or sets the value of variable userName.
        /// </summary>
        [TestVariable("d4c774d3-cd33-41b6-84dc-f049c0bd82f5")]
        public string userName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        string _passWord;

        /// <summary>
        /// Gets or sets the value of variable passWord.
        /// </summary>
        [TestVariable("213fdd1f-b1ce-4926-a8ef-5260cfbcd6de")]
        public string passWord
        {
            get { return _passWord; }
            set { _passWord = value; }
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
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.UserLogin.UserName' at Center.", repo.MainWindow.UserLogin.UserNameInfo, new RecordItemIndex(0));
            repo.MainWindow.UserLogin.UserName.Click();
            
            // Enter username
            Report.Log(ReportLevel.Info, "Keyboard", "Enter username\r\nKey sequence from variable '$userName' with focus on 'MainWindow.UserLogin.UserName'.", repo.MainWindow.UserLogin.UserNameInfo, new RecordItemIndex(1));
            repo.MainWindow.UserLogin.UserName.PressKeys(userName);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.UserLogin.Password' at Center.", repo.MainWindow.UserLogin.PasswordInfo, new RecordItemIndex(2));
            repo.MainWindow.UserLogin.Password.Click();
            
            // Enter password
            Report.Log(ReportLevel.Info, "Keyboard", "Enter password\r\nKey sequence from variable '$passWord' with focus on 'MainWindow.UserLogin.Password'.", repo.MainWindow.UserLogin.PasswordInfo, new RecordItemIndex(3));
            repo.MainWindow.UserLogin.Password.PressKeys(passWord);
            
            // Click Ok
            Report.Log(ReportLevel.Info, "Mouse", "Click Ok\r\nMouse Left Click item 'MainWindow.UserLogin.Login' at Center.", repo.MainWindow.UserLogin.LoginInfo, new RecordItemIndex(4));
            repo.MainWindow.UserLogin.Login.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}