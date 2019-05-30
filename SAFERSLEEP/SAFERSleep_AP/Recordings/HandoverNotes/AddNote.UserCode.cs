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

namespace SAFERSleep_AP.Recordings.HandoverNotes
{
    public partial class AddNote
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void SelectNoteOption(string IsAlert, string DontPrint)
        {
           if (IsAlert=="Yes") 
           {
	           	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.HandoverNotes.AddNoteWindow.Alert' at Center.", repo.MainWindow.HandoverNotes.AddNoteWindow.HandoverNoteInfo, new RecordItemIndex(6));
	            repo.MainWindow.HandoverNotes.AddNoteWindow.HandoverNote.Click();
	            Delay.Milliseconds(200);
           }
           if (DontPrint=="Yes")
           {
	           	 Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.HandoverNotes.AddNoteWindow.DontPrint' at Center.", repo.MainWindow.HandoverNotes.AddNoteWindow.DontPrintInfo, new RecordItemIndex(7));
	            repo.MainWindow.HandoverNotes.AddNoteWindow.DontPrint.Click();
	            Delay.Milliseconds(200);
           	
           }
        }

        public void VerifyNoteIsAddedSuccessful(string IsAlert, string DontPrint)
        {
           if (IsAlert=="Yes") 
           {
	           	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWindow.HandoverNotes.AddNoteWindow.Alert' at Center.", repo.MainWindow.HandoverNotes.AddNoteWindow.HandoverNoteInfo, new RecordItemIndex(6));
	            repo.MainWindow.HandoverNotes.AddNoteWindow.HandoverNote.Click();
	            Delay.Milliseconds(200);
           }
           else
           {
	           	// Verify that the note is added successfully
	            Report.Log(ReportLevel.Info, "Validation", "Verify that the note is added successfully\r\nValidating Exists on item 'MainWindow.HandoverNotes.AddedNote'.", repo.MainWindow.HandoverNotes.NotesSection.AddedNoteInfo, new RecordItemIndex(5));
	            Validate.Exists(repo.MainWindow.HandoverNotes.NotesSection.AddedNoteInfo);
	            Delay.Milliseconds(0);
           }
           if (DontPrint=="Yes")
           {
	           	 
           	
           }
        }

    }
}