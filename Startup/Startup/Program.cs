/*
    WMS Auto-Launcher Program , Server Version
    April 25th, 2019
    By : Christopher Olson
    ** = Places need to be changed when adding program options. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Automation;

namespace Startup {


    public class Program
    {
        // Dll call required to make inserting into keys window behave correctly
        [DllImport("User32.dll")]
        [STAThread]
        static extern int SetForegroundWindow(IntPtr point);


        static void Main(string[] args)
        {
            Startup.UserCredentials currentUser = new Startup.UserCredentials();
            AutomationMethods automation = new AutomationMethods();

            currentUser.user = "Test2";
            currentUser.pass = "";
            currentUser.CPS = false;
            currentUser.LBS = false;
            currentUser.BMIS = false;
            currentUser.DPS = false;
            currentUser.MFCCPS = false;
            currentUser.MFCDPS = false;
            currentUser.AVIS = false;
            currentUser.INDA = false;
            currentUser.LOGCRAWLER = false;
            currentUser.REMOTEMANAGER = false;
            currentUser.MAPDRIVES = false;
            currentUser.PCO = false;
            setColor();
            Console.WriteLine("WMS Auto-Launcher Program, By Christopher Olson");
            Console.WriteLine("****************************************************");
            Console.WriteLine("****************************************************");
            Console.WriteLine("");
            Console.WriteLine(" CCCCCCCC  VVV      VVV   SSSSSSS");
            Console.WriteLine("CCCCCCCCC  VVV      VVV   SSSSSSS");
            Console.WriteLine("CC          VVV    VVV   SSSS");
            Console.WriteLine("CC          VVV    VVV   SSSS");
            Console.WriteLine("CC           VVV  VVV      SSSSSSS");
            Console.WriteLine("CC           VVV  VVV      SSSSSSS");
            Console.WriteLine("CC            VVVVVV          SSSS");
            Console.WriteLine("CCCCCCCCC     VVVVV           SSSS");
            Console.WriteLine(" CCCCCCCC      VVV        SSSSSSSS");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("");
            Console.WriteLine("WWW             WWW       MMMMM MMMMM        SSSSSSS");
            Console.WriteLine("WWW             WWW      MMMMMM MMMMMM       SSSSSSS");
            Console.WriteLine(" WWW           WWW       MMM MMMMM MMM      SSSS");
            Console.WriteLine(" WWW           WWW      MMM  MMMMM  MMM     SSSS");
            Console.WriteLine("  WWW   WWW   WWW       MMM   MMM   MMM       SSSSSSS");
            Console.WriteLine("  WWW  WWWWW  WWW      MMM           MMM      SSSSSSS");
            Console.WriteLine("   WWW WWWWW WWW       MMM           MMM 	 SSSS");
            Console.WriteLine("   WWWWWW WWWWWW      MMM             MMM        SSSS");
            Console.WriteLine("    WWWWW WWWWW       MMM             MMM    SSSSSSS");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("");
            Console.WriteLine("Checking for mapped Drives.");

            int driveWait = 0;
            bool foundDrive = false;

            do
            {
                driveWait++;
                if ((File.Exists("R:\\abl\\runtime\\bin\\LBS_start2.bat") == true))
                {
                    foundDrive = true;
                }
                Thread.Sleep(1000);

                if (driveWait == 10) {

                    Console.WriteLine("Mapped Drive not found, exiting program in:");
                    Thread.Sleep(1000);
                    Console.WriteLine("4");
                    Thread.Sleep(1000);
                    Console.WriteLine("3");
                    Thread.Sleep(1000);
                    Console.WriteLine("2");
                    Thread.Sleep(1000);
                    Console.WriteLine("1");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }

            } while (foundDrive == false);




            Console.WriteLine("Checking for existing user settings.");
            string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = documents + @"\info.txt";
            // Checks for the credentials file in User\Documents, creates a new one if not present
            if (File.Exists(path) == false)
            {

                Application.EnableVisualStyles();


                Application.Run(new Startup.CredentialsForm(currentUser, path));



            }

            if (File.Exists(path) == false)
            {

                Environment.Exit(0);
            }

            // Reads in credentials from the file created in User\Documents
            readFile(currentUser, path);
            programLauncher(currentUser, automation);

        }

        // Sets the Console Text Color.
        static void setColor()
        {
            ConsoleColor background = Console.BackgroundColor;
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        // Reads into currentUser properties from info.txt file. **
        public static void readFile(Startup.UserCredentials currentUser, string path)
        {
            string key = "#CVS2575";
            DecryptFile(path, key);

            StreamReader readtext = new StreamReader(path);
            var lines = File.ReadAllLines(path);
            currentUser.user = lines[0];
            currentUser.pass = lines[1];

            // Passes through the file to find Programs. Flags as true if present.
            if (Array.Exists(lines, element => element == "LBS")) { currentUser.LBS = true; }
            if (Array.Exists(lines, element => element == "CPS")) { currentUser.CPS = true; }
            if (Array.Exists(lines, element => element == "BMIS")) { currentUser.BMIS = true; }
            if (Array.Exists(lines, element => element == "MFCDPS")) { currentUser.MFCDPS = true; }
            if (Array.Exists(lines, element => element == "MFCCPS")) { currentUser.MFCCPS = true; }
            if (Array.Exists(lines, element => element == "AVIS")) { currentUser.AVIS = true; }
            if (Array.Exists(lines, element => element == "INDA")) { currentUser.INDA = true; }
            if (Array.Exists(lines, element => element == "LOGCRAWLER")) { currentUser.LOGCRAWLER = true; }
            if (Array.Exists(lines, element => element == "REMOTEMANAGER")) { currentUser.REMOTEMANAGER = true; }
            if (Array.Exists(lines, element => element == "MAPDRIVES")) { currentUser.MAPDRIVES = true; }
            if (Array.Exists(lines, element => element == "DPS")) { currentUser.DPS = true; }
            if (Array.Exists(lines, element => element == "PCO")) { currentUser.PCO = true; }

            readtext.Close();
            Console.WriteLine("Launching These Programs ....");
            EncryptFile(path, key);
            printMenu(currentUser);
        }

        // Print selected menu items. **
        static void printMenu(Startup.UserCredentials currentUser)
        {

            Console.WriteLine();
            Console.WriteLine("Current Selection :");
            if (currentUser.LBS == true) { Console.WriteLine("LBS"); }
            if (currentUser.CPS == true) { Console.WriteLine("CPS"); }
            if (currentUser.DPS == true) { Console.WriteLine("DService"); }
            if (currentUser.BMIS == true) { Console.WriteLine("BMIS"); }
            if (currentUser.MFCDPS == true) { Console.WriteLine("MFC_DPS"); }
            if (currentUser.MFCCPS == true) { Console.WriteLine("MFC_CPS"); }
            if (currentUser.AVIS == true) { Console.WriteLine("AVIS"); }
            if (currentUser.INDA == true) { Console.WriteLine("INDA "); }
            if (currentUser.LOGCRAWLER == true) { Console.WriteLine("LOGCRAWLER"); }
            if (currentUser.REMOTEMANAGER == true) { Console.WriteLine("Remote Desktop Manager"); }
            if (currentUser.MAPDRIVES == true) { Console.WriteLine("Map Net Drives"); }
            if (currentUser.PCO == true) { Console.WriteLine("PCO View"); }

            Thread.Sleep(4000);
        }

        // Launches programs depending on which have been flagged as true. **
        static void programLauncher(Startup.UserCredentials currentUser, AutomationMethods automation)
        {


            if (currentUser.LBS == true) { startLBS(currentUser, automation); }
            if (currentUser.CPS == true) { startCPS(currentUser, automation); }
            if (currentUser.DPS == true) { startDSERVICE(currentUser, automation); }
            if (currentUser.BMIS == true) { startBMIS(currentUser, automation); }
            if (currentUser.MFCDPS == true) { startMFCDPS(currentUser, automation); }
            if (currentUser.MFCCPS == true) { startMFCCPS(currentUser, automation); }
            if (currentUser.PCO == true) { startPCOVIEW(currentUser, automation); }
            if (currentUser.AVIS == true) { startAVIS(); }


        }

        // Encrypts Configuration File.
        static void EncryptFile(string path, string key)
        {

            byte[] plainContent = File.ReadAllBytes(path);
            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = Encoding.UTF8.GetBytes(key);
                DES.Key = Encoding.UTF8.GetBytes(key);
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;

                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memStream, DES.CreateEncryptor(), CryptoStreamMode.Write);
                    cryptoStream.Write(plainContent, 0, plainContent.Length);
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(path, memStream.ToArray());
                }

            }

        }

        // Decrypts Configuration File.
        private static void DecryptFile(string path, string key)
        {

            byte[] encrypted = File.ReadAllBytes(path);
            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = Encoding.UTF8.GetBytes(key);
                DES.Key = Encoding.UTF8.GetBytes(key);
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;

                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memStream, DES.CreateDecryptor(), CryptoStreamMode.Write);
                    cryptoStream.Write(encrypted, 0, encrypted.Length);
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(path, memStream.ToArray());
                }
            }
        }

        // LBS Option.
        public static void startLBS(Startup.UserCredentials currentUser, AutomationMethods automation)
        {
            if (File.Exists("R:\\abl\\runtime\\bin\\LBS_start2.bat") == true)
            {

                Process.Start("R:\\abl\\runtime\\bin\\LBS_start2.bat");
                Thread.Sleep(2000);

                AutomationElement
                lbsForm,
                lbsUser,
                lbsPass,
                lbsOk;

                string username = currentUser.user;
                string password = currentUser.pass;

                lbsForm = automation.setParentElement("Log on LBS");

                if (lbsForm != null)
                {

                    lbsUser = automation.setChildElementById(lbsForm, "4", true);
                    lbsPass = automation.setChildElementById(lbsForm, "5", true);
                    lbsOk = automation.setChildElementById(lbsForm, "8", true);
                    automation.setValue(lbsUser, username);
                    automation.setValue(lbsPass, password);

                    try
                    {

                        automation.invokeButtonPress(lbsOk);
                    }

                    catch (Exception ex)
                    {

                    }

                    Thread.Sleep(2000);

                }
                else {

                    return;
                }
            }
            else {

                return;
            }
        }

        // CPS Option.
        public static void startCPS(Startup.UserCredentials currentUser, AutomationMethods automation)
        {
            if (File.Exists("R:\\abl\\runtime\\bin\\CPS_start2.bat") == true)
            {
                Process.Start("R:\\abl\\runtime\\bin\\CPS_start2.bat");

                AutomationElement
                cpsForm,
                cpsUser,
                cpsPass,
                cpsOk;

                string username = currentUser.user;
                string password = currentUser.pass;

                cpsForm = automation.setParentElement("Log on cps");

                if (cpsForm != null)
                {

                    cpsUser = automation.setChildElementById(cpsForm, "4", true);
                    cpsPass = automation.setChildElementById(cpsForm, "5", true);
                    cpsOk = automation.setChildElementById(cpsForm, "8", true);
                    automation.setValue(cpsUser, username);
                    automation.setValue(cpsPass, password);

                    try
                    {

                        automation.invokeButtonPress(cpsOk);
                    }

                    catch (Exception ex)
                    {

                    }

                    Thread.Sleep(2000);

                }
                else
                {

                    return;
                }
            }
            else
            {

                return;
            }
        }

        // DSERVICE Option.
        public static void startDSERVICE(Startup.UserCredentials currentUser, AutomationMethods automation)
        {
            if (File.Exists("R:\\abl\\runtime\\bin\\DSERVICE_start2.bat") == true)
            {
                Process.Start("R:\\abl\\runtime\\bin\\DSERVICE_start2.bat");
                AutomationElement
                dpsForm,
                dpsUser,
                dpsPass,
                dpsOk;

                string username = currentUser.user;
                string password = currentUser.pass;

                dpsForm = automation.setParentElement("Log on dservice");

                if (dpsForm != null)
                {

                    dpsUser = automation.setChildElementById(dpsForm, "4", true);
                    dpsPass = automation.setChildElementById(dpsForm, "5", true);
                    dpsOk = automation.setChildElementById(dpsForm, "8", true);
                    automation.setValue(dpsUser, username);
                    automation.setValue(dpsPass, password);

                    try
                    {

                        automation.invokeButtonPress(dpsOk);
                    }

                    catch (Exception ex)
                    {

                    }

                    Thread.Sleep(2000);

                }
                else
                {

                    return;
                }
            }
            else
            {

                return;
            }
        }

        // BMIS Option.
        public static void startBMIS(Startup.UserCredentials currentUser, AutomationMethods automation)
        {
            if (File.Exists("R:\\abl\\runtime\\bin\\BMIS_start2.bat") == true)
            {
                Process.Start("R:\\abl\\runtime\\bin\\BMIS_start2.bat");
                AutomationElement
                bmisForm,
                bmisUser,
                bmisPass,
                bmisOk;

                string username = currentUser.user;
                string password = currentUser.pass;

                bmisForm = automation.setParentElement("Log on BMIS");

                if (bmisForm != null)
                {

                    bmisUser = automation.setChildElementById(bmisForm, "4", true);
                    bmisPass = automation.setChildElementById(bmisForm, "5", true);
                    bmisOk = automation.setChildElementById(bmisForm, "8", true);
                    automation.setValue(bmisUser, username);
                    automation.setValue(bmisPass, password);

                    try
                    {

                        automation.invokeButtonPress(bmisOk);
                    }

                    catch (Exception ex)
                    {

                    }

                    Thread.Sleep(2000);

                }
                else
                {

                    return;
                }
            }
            else
            {

                return;
            }
        }

        // MFC DPS Option.
        public static void startMFCDPS(Startup.UserCredentials currentUser, AutomationMethods automation)
        {
            if (File.Exists("R:\\abl\\runtime\\bin\\MFC_DPS2.bat") == true)
            {
               Process.Start("R:\\abl\\runtime\\bin\\MFC_DPS2.bat");
               AutomationElement
               mfcdpsForm,
               mfcdpsUser,
               mfcdpsPass,
               mfcdpsOk;

                string username = currentUser.user;
                string password = currentUser.pass;

                mfcdpsForm = automation.setParentElement("Log on mfc");

                if (mfcdpsForm != null)
                {

                    mfcdpsUser = automation.setChildElementById(mfcdpsForm, "4", true);
                    mfcdpsPass = automation.setChildElementById(mfcdpsForm, "5", true);
                    mfcdpsOk = automation.setChildElementById(mfcdpsForm, "8", true);
                    automation.setValue(mfcdpsUser, username);
                    automation.setValue(mfcdpsPass, password);

                    try
                    {

                        automation.invokeButtonPress(mfcdpsOk);
                    }

                    catch (Exception ex)
                    {

                    }

                    Thread.Sleep(2000);

                }
                else
                {

                    return;
                }
            }
            else
            {

                return;
            }
        }

        // MFC CPS Option.
        public static void startMFCCPS(Startup.UserCredentials currentUser, AutomationMethods automation)
        {
            if (File.Exists("R:\\abl\\runtime\\bin\\MFC_CPS2.bat") == true)
            {
                Process.Start("R:\\abl\\runtime\\bin\\MFC_CPS2.bat");
                AutomationElement
               mfccpsForm,
               mfccpsUser,
               mfccpsPass,
               mfccpsOk;

                string username = currentUser.user;
                string password = currentUser.pass;

                mfccpsForm = automation.setParentElement("Log on mfc");

                if (mfccpsForm != null)
                {

                    mfccpsUser = automation.setChildElementById(mfccpsForm, "4", true);
                    mfccpsPass = automation.setChildElementById(mfccpsForm, "5", true);
                    mfccpsOk = automation.setChildElementById(mfccpsForm, "8", true);
                    automation.setValue(mfccpsUser, username);
                    automation.setValue(mfccpsPass, password);

                    try
                    {

                        automation.invokeButtonPress(mfccpsOk);
                    }

                    catch (Exception ex)
                    {

                    }

                    Thread.Sleep(2000);

                }
                else
                {

                    return;
                }
            }
            else
            {

                return;
            }
        }

        // PCO View Option.
        public static void startPCOVIEW(Startup.UserCredentials currentUser, AutomationMethods automation)
        {
            if (File.Exists("R:\\asl\\runtime\\bin\\pcoview.exe") == true)
            {
                Process.Start("R:\\asl\\runtime\\bin\\pcoview.exe");
                AutomationElement
              pcoForm,
              pcoUser,
              pcoPass,
              pcoOk;

                string username = currentUser.user;
                string password = currentUser.pass;

                pcoForm = automation.setParentElement("PCO View Login");

                if (pcoForm != null)
                {

                    pcoUser = automation.setChildElementById(pcoForm, "1019", true);
                    pcoPass = automation.setChildElementById(pcoForm, "1020", true);
                    pcoOk = automation.setChildElementById(pcoForm, "1", true);
                    automation.setValue(pcoUser, username);
                    automation.setValue(pcoPass, password);

                    try
                    {

                        automation.invokeButtonPress(pcoOk);
                    }

                    catch (Exception ex)
                    {

                    }

                    Thread.Sleep(2000);

                }
                else
                {

                    return;
                }
            }
            else
            {

                return;
            }
        }

        // Avis Option.
        public static void startAVIS()
        {
            if (File.Exists("R:\\atl\\runtime\\bin\\AVIS.exe") == true)
            {
                Process.Start("R:\\atl\\runtime\\bin\\AVIS.exe");
                Thread.Sleep(2000);
            }
            else
            {
                return;
            }
        }

    }

}


