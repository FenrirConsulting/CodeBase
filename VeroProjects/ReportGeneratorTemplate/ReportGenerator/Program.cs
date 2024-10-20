﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Windows.Input;
using System.Security.Cryptography;
using System.Windows.Automation;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading.Tasks;
using Microsoft.Test.Input;


namespace ReportGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program programMethods = new Program();
            AutomationMethods automation = new AutomationMethods();
            string programPath = System.IO.Directory.GetCurrentDirectory();
            string reportPath = programPath + "\\Reports\\";

            if (!Directory.Exists(reportPath))
            {
                Directory.CreateDirectory(reportPath);
            }
          
            // Path to BMIS that server targets. 
            string clientPath = "X:\\abl\\runtime\\bin\\";
            string serverPath = "R:\\abl\\runtime\\bin\\";
            //string absolutePath = "\\\\rfl6dpsapw1v\\WMS-CLIENT\\abl\\runtime\\bin\\";
            string bmisFile = "BMIS.exe";
            string bmisProgram = "BMIS.exe";
            string savedFileOverview = "StockOverview.csv";
            string overviewReport = "INV-104: Stock Overview with Location and Cost"; 
            int time = 0;
           
            string pathSelection = clientPath + bmisFile;
            if (Directory.Exists(clientPath))
            {
                pathSelection = clientPath + bmisFile;
            }
            else if (Directory.Exists(serverPath))
            {
                pathSelection = serverPath + bmisFile;
            }
            else 
            {
                pathSelection = bmisProgram;
            }


            Console.WriteLine("Opening BMIS");

            for (time =5; time > 0; time--){
                Console.WriteLine("Opening in: " + time.ToString() + " seconds.");
                Thread.Sleep(1000);
            }


            Process.Start(pathSelection);
            Thread.Sleep(3000);
            programMethods.loginMethod(automation, programMethods);
            Thread.Sleep(3000);
            
            programMethods.grabReport(automation, programMethods, overviewReport);
            Thread.Sleep(15000);
            programMethods.exportFile(automation, programMethods, reportPath, savedFileOverview);
            programMethods.closeBMIS();
        }

        public void loginMethod(AutomationMethods automation, Program programMethods)
        {

            AutomationElement
               loginFormElement,
                loginUserElement,
                loginOkButton,
                loginPassElement;

            // Set Service Account Here
            string username = "20031";
            string password = "1337";
            loginFormElement = automation.setParentElement("Log on BMIS");


            loginUserElement = automation.setChildElementById(loginFormElement, "4", true);
            loginPassElement = automation.setChildElementById(loginFormElement, "5", true);
            loginOkButton = automation.setChildElementById(loginFormElement, "8", true);
            automation.setValue(loginUserElement, username);
            automation.setValue(loginPassElement, password);

            try
            {

                automation.invokeButtonPress(loginOkButton);
            }

            catch (Exception ex)
            {
                programMethods.generalErrorMessage();
            }

        
        }


        private void grabReport(AutomationMethods automation, Program programMethods, string selectedReport)
        {

            AutomationElement
                   mainFormElement,
                   sampleReportElement,
                   statisticsButtonElement;


            mainFormElement = automation.setParentElement("BMIS V3.4.9");

            int loopCount = 0;
            do
            {
                sampleReportElement = automation.setChildElementByName(mainFormElement, selectedReport, true);
                loopCount++;
                Thread.Sleep(1000);
            } while (sampleReportElement == null && loopCount < 5);
          


            statisticsButtonElement = automation.setChildElementByName(mainFormElement, "F2 Statistics", true);
            automation.selectItem(sampleReportElement);
            Thread.Sleep(1000);
            SendKeys.SendWait("{ENTER}");
        }

        private void exportFile(AutomationMethods automation, Program programMethods, string reportPath, string savedFile) 
        {

            AutomationElement
                mainFormElement,
                exportButton,
                exportAsComboBox,
                okButton;

            mainFormElement = automation.setParentElement("BMIS V3.4.9");

            int count = 0;
            do
            {
                exportButton = automation.setChildElementByName(mainFormElement, "Export", true);
                count++;
                Thread.Sleep(1000);

            } while (exportButton == null & count < 10);

            automation.invokeButtonPress(exportButton);

            Thread.Sleep(500);

            count = 0;
            do
            {
                exportAsComboBox = automation.setChildElementByName(mainFormElement, "Export as", true);
                count++;
                Thread.Sleep(1000);

            } while (exportAsComboBox == null & count < 10);

            
            if (exportAsComboBox != null) {
                SendKeys.SendWait("{UP}");
                SendKeys.SendWait("{TAB}");
                SendKeys.SendWait(" ");
                okButton = automation.setChildElementByName(mainFormElement, "F2 Ok", true);
                automation.invokeButtonPress(okButton);
                saveFile(automation, programMethods, reportPath, savedFile);
            }
           
        
        
        }

        private void saveFile(AutomationMethods automation, Program programMethods,  string reportPath, string savedFile)
        {

            Thread.Sleep(1000);
            

            AutomationElement
                    mainFormElement,
                    saveWindow;

            mainFormElement = automation.setParentElement("BMIS V3.4.9");
            int loopcount = 0;
            do
            {
                loopcount++;
                saveWindow = automation.setChildElementByName(mainFormElement, "Save As", true);
                Thread.Sleep(500);
            } while (saveWindow == null && loopcount < 5);

            if (saveWindow != null) {
                SendKeys.SendWait(savedFile);
                Thread.Sleep(200);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(200);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(200);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(200);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(200);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(200);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(200);
                SendKeys.SendWait("{ENTER}");
                SendKeys.SendWait(reportPath);
                Thread.Sleep(1000);
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(1000);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(200)
                    ;
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(200);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(200);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(200);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(200);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(200);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(200);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(200);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(200);
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(2000);
                SendKeys.SendWait("{LEFT}");
                Thread.Sleep(200);
                SendKeys.SendWait("{ENTER}");

            }


        }

        private void closeBMIS()
        {

            Thread.Sleep(4000);

            
            try
            {

                SendKeys.SendWait("%{F4}");
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                
            }

            int time = 0;

            for (time = 10; time > 0; time--)
            {
                Console.WriteLine(time.ToString() + " seconds left until Exiting.");
                Thread.Sleep(1000);

  
            }

        }





        public void generalErrorMessage()
        {
            MessageBox.Show("LOGIN ERROR", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

    }
}
