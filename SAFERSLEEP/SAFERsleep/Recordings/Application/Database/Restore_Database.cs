﻿/*
 * Created by Ranorex
 * User: Admin
 * Date: 27/07/2018
 * Time: 11:26 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace SAFERsleep.Recordings.Application.Database
{
    /// <summary>
    /// Description of Restore_Database.
    /// </summary>
    [TestModule("A13C762C-62E7-4F11-B057-BBB67BB725EC", ModuleType.UserCode, 1)]
    public class Restore_Database : ITestModule
    {
    	
    	int _DelayTimeBeforeRestore = 120000;
    	[TestVariable("82e3109a-0ab8-4173-85ba-947a48111e8e")]
    	public int DelayTimeBeforeRestore
    	{
    		get { return _DelayTimeBeforeRestore; }
    		set { _DelayTimeBeforeRestore = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Restore_Database()
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
            
            SqlConnection con = new SqlConnection("Data Source=ATServer12R2;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=p@ssw0rd");
        	SqlCommand cmd = new SqlCommand();
        	//SqlDataAdapter da;
        	//DataTable dt;
        	
        	//Kill Connections
        	Delay.Milliseconds(DelayTimeBeforeRestore);
        	con.Open();        	
        	cmd.Connection = con;
        	cmd.CommandText = "USE [master]; "
								+ "DECLARE @kill varchar(8000) = ''; "
								+ "SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), session_id) + ';' "
								+ "FROM sys.dm_exec_sessions "
								+ "WHERE database_id  = db_id('SSAutoTest') "
								+ "EXEC(@kill); "; 
            cmd.ExecuteNonQuery();
            con.Close();
            
            //Restore Database
            Delay.Milliseconds(5000);
            con.Open();        	
        	cmd.Connection = con;
        	cmd.CommandText = "RESTORE DATABASE SSAutoTest FROM SSAutoTestBackup "; 
            cmd.ExecuteNonQuery();
            con.Close();	
        }
    }
}
