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

namespace SAFERSleep_AP.Recordings.SavingReview
{
    public partial class ReScheduleReview
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
/// <summary>
/// Select a next review round 
/// </summary>
/// <param name="NextReviewRound">0: Default option.Users don't open and select any item in the Review round box</param>
/// <param name="NextReviewRound">1: Users open the Review round box and select the first option</param>
/// <param name="NextReviewRound">2: Users open the Review round box and select the first option</param>
/// <param name="NextReviewRound">3: Users open the Review round box and select the first option</param>


        public void SelectReviewRound(int NextReviewRound)
        {        	
        	if (NextReviewRound==0) 
        	{        	
				Report.Log(ReportLevel.Info,"Select item number: " + NextReviewRound.ToString() +" - " +repo.MainWindow.SavingReview.ReviewRound.Items[NextReviewRound].Text);        		
        		repo.MainWindow.SavingReview.ReviewRound.Items[NextReviewRound].Click();
        		Delay.Milliseconds(200); 
        	}        	
        	else
        	{   
        		Report.Log(ReportLevel.Info,"Select item number: " + (NextReviewRound-1).ToString() +" - " +repo.MainWindow.SavingReview.ReviewRound.Items[NextReviewRound-1].Text);
        		//repo.MainWindow.PrintingReview.ReviewRound.SelectedItemIndex= NextReviewRound-1;
        		//Delay.Milliseconds(200);   
        		
        		repo.MainWindow.SavingReview.ReviewRound.Items[NextReviewRound-1].Click();
        		Delay.Milliseconds(200);     
        	}        	
        }

        public void SelectPrinter(string Printer)
        {
           IList<ListItem> lstItems= repo.MainWindow.SavingReview.SelectPrinter.Items;
           
           if (lstItems!= null && lstItems.Count>0) {
           	
           	 for (int i = 0; i < lstItems.Count; i++)
           	 {
           	 	//Report.Log(ReportLevel.Info, "Item: " + lstItems[i].Text);
           	 	if (lstItems[i].Text == Printer) {
           	 		
           	 		Report.Log(ReportLevel.Info, "Click on Item: " + lstItems[i].Text);
           	 		lstItems[i].Selected= true;
            		lstItems[i].Click();
            		Delay.Milliseconds(200); 
           	 		break;           	 			
           	 	}
           	
             }
           	
           }
          
        }

    }
}
