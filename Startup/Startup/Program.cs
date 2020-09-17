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


class Program
{
    // Dll call required to make inserting into keys window behave correctly
    [DllImport("User32.dll")]
    static extern int SetForegroundWindow(IntPtr point);

    static void Main(string[] args)
    {

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
        Console.WriteLine("Checking for existing user settings.");
        userCredentials currentUser = new userCredentials();
        string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string path = documents + @"\info.txt";

        // Checks for the credentials file in User\Documents, creates a new one if not present
        if (File.Exists(path) == false) { 
                 
            createCredentials(ref currentUser, path);
            selectionMenu(ref currentUser, path);
            writeFile(ref currentUser, path);        
        }

        // Reads in credentials from the file created in User\Documents
        readFile(ref currentUser, path);
        programLauncher(ref currentUser);

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

    // userCredentials Object to set Username and Password for program instance.
    public class userCredentials
    {

        public string user { get; set; }
        public string pass { get; set; }
        public bool CPS { get; set; }
        public bool LBS { get; set; }
        public bool BMIS { get; set; }
        public bool MFCCPS { get; set; }
        public bool MFCDPS { get; set; }
        public bool AVIS { get; set; }
        public bool INDA { get; set; }
        public bool LOGCRAWLER { get; set; }
        public bool REMOTEMANAGER { get; set; }
        public bool MAPDRIVES { get; set; }
        public bool DPS { get; set; }
        public bool PCO { get; set; } 

        public userCredentials()
        {

            user = "";
            pass = "";
            CPS = false;
            LBS = false;
            BMIS = false;
            DPS = false;
            MFCCPS = false;
            MFCDPS = false;
            AVIS = false;
            INDA = false;
            LOGCRAWLER = false;
            REMOTEMANAGER = false;
            MAPDRIVES = false;
            PCO = false;
            
        }

    }

    // Initial credentials creation for User on first program run. 
    public static void createCredentials(ref userCredentials currentUser, string path)
    {

        bool goodDigits = false;
        bool goodLength = false;
        int length;

        Console.WriteLine("For the first run of this program, you must provide user settings.");
        Console.WriteLine("Please provide your WMS credentials to auto-launch with:");
        Console.WriteLine("Enter WMS User ID #");
        currentUser.user = Console.ReadLine();
        goodDigits = currentUser.user.All(char.IsDigit);
        length = currentUser.user.Length;
        if (length == 7) { goodLength = true; }

        while (goodDigits == false || goodLength == false)
        {
            Console.WriteLine();
            Console.WriteLine("Only enter a 7 digit, all numbers, User ID");
            currentUser.user = Console.ReadLine();
            goodDigits = currentUser.user.All(char.IsDigit);
            length = currentUser.user.Length;
            if (length == 7) { goodLength = true; }
        }

        goodDigits = false;
        goodLength = false;

        Console.WriteLine();
        Console.WriteLine("Enter WMS User Password");
        currentUser.pass = Console.ReadLine();
        goodDigits = currentUser.pass.All(char.IsDigit);
        length = currentUser.pass.Length;
        if (length == 4 || length == 5) { goodLength = true; }

        while (goodDigits == false || goodLength == false)
        {
            Console.WriteLine();
            Console.WriteLine("Only enter a 4 or 5 digit, all numbers, User Password");
            currentUser.pass = Console.ReadLine();
            goodDigits = currentUser.pass.All(char.IsDigit);
            length = currentUser.pass.Length;
            if (length == 4 || length == 5) { goodLength = true; }
        }

        Console.WriteLine();
        Console.WriteLine("Initial run saves Username and Password to " + path);
        Console.WriteLine("User ID      : " + currentUser.user);
        Console.WriteLine("User Password: " + currentUser.pass);
        Console.WriteLine("Any enter key to select Program startup options");
        Console.ReadLine();
    }

    // Writes credentials and menu choices to info.txt file. **
    public static void writeFile(ref userCredentials currentUser, string path){

        var menuList = new List<string>();

        if (currentUser.CPS == true) { menuList.Add("CPS"); }
        if (currentUser.LBS == true) { menuList.Add("LBS"); }
        if (currentUser.BMIS == true) { menuList.Add("BMIS"); }
        if (currentUser.MFCDPS == true) { menuList.Add("MFCDPS"); }
        if (currentUser.MFCCPS == true) { menuList.Add("MFCCPS"); }
        if (currentUser.AVIS == true) { menuList.Add("AVIS"); }
        if (currentUser.INDA == true) { menuList.Add("INDA"); }
        if (currentUser.REMOTEMANAGER == true) { menuList.Add("REMOTEMANAGER"); }
        if (currentUser.LOGCRAWLER == true) { menuList.Add("LOGCRAWLER"); }
        if (currentUser.MAPDRIVES == true) { menuList.Add("MAPDRIVES"); }
        if (currentUser.DPS == true) { menuList.Add("DPS"); }
        if (currentUser.PCO == true) { menuList.Add("PCO"); }

        var menuArray = menuList.ToArray();


        FileStream file = File.Create(path); file.Dispose();

        using (StreamWriter writetext = new StreamWriter(path))
        {
            writetext.WriteLine(currentUser.user);
            writetext.WriteLine(currentUser.pass);
            foreach (string s in menuArray)
                writetext.WriteLine(s);
        }
        file.Close();
        string pass = "#CVS2575";
        EncryptFile(path, pass);
    }

    // Reads into currentUser properties from info.txt file. **
    public static void readFile(ref userCredentials currentUser, string path)
    {
        string pass = "#CVS2575";
        DecryptFile(path, pass);

        StreamReader readtext = new StreamReader(path);
        var lines = File.ReadAllLines(path);
        currentUser.user = lines[0];
        currentUser.pass = lines[1];
        
        // Passes through the file to find Programs. Flags as true if present.
        if (Array.Exists(lines, element => element =="LBS")){ currentUser.LBS = true; }
        if (Array.Exists(lines, element => element == "CPS")) { currentUser.CPS = true; }
        if (Array.Exists(lines, element => element == "BMIS")) { currentUser.BMIS = true; }
        if (Array.Exists(lines, element => element == "MFCDPS")) { currentUser.MFCDPS = true; }
        if (Array.Exists(lines, element => element == "MFCCPS")) { currentUser.MFCCPS = true; }
        if (Array.Exists(lines, element => element == "AVIS")) { currentUser.AVIS = true; }
        if (Array.Exists(lines, element => element == "INDA")) { currentUser.INDA = true; }
        if (Array.Exists(lines, element => element == "LOGCRAWLER")) { currentUser.LOGCRAWLER = true; }
        if (Array.Exists(lines, element => element == "REMOTEMANAGER")) { currentUser.REMOTEMANAGER = true; }
        if (Array.Exists(lines, element => element == "MAPDRIVES")) {currentUser.MAPDRIVES = true;}
        if (Array.Exists(lines, element => element == "DPS")) { currentUser.DPS = true; }
        if (Array.Exists(lines, element => element == "PCO")) { currentUser.PCO = true; }

        readtext.Close();
        Console.WriteLine("Launching These Programs ....");
        printMenu(ref currentUser);
        EncryptFile(path, pass);
    }

    // Program startup selection Menu. **
    public static void selectionMenu(ref userCredentials currentUser, string path) {

        int choice;
        bool valid = false;
        string exit = "n";

        do
        {
            Console.WriteLine();
            Console.WriteLine("Select which programs you want to Auto-Launch:");
            Console.WriteLine("LBS                    - 1");
            Console.WriteLine("CPS                    - 2");
            Console.WriteLine("DService               - 3");
            Console.WriteLine("BMIS                   - 4");
            Console.WriteLine("MFC_DPS                - 5");
            Console.WriteLine("MFC_CPS                - 6");
            Console.WriteLine("AVIS                   - 7");
            Console.WriteLine("INDA                   - 8");
            Console.WriteLine("LOGCRAWLER             - 9");
            Console.WriteLine("Remote Desktop Manager - 10");
            Console.WriteLine("Map Net Drives         - 11");
            Console.WriteLine("PCO View               - 12");

            do
            {
                Console.WriteLine("Enter a single digit selection:");
                string input = Console.ReadLine();
                valid = int.TryParse(input, out choice);
            } while (!valid);


            switch (choice) { 
   
                    
                case 1:
                    currentUser.LBS = true;
                    break;

                case 2:
                    currentUser.CPS = true;
                    break;

                case 3:
                    currentUser.DPS = true;
                    break;

                case 4:
                    currentUser.BMIS = true;
                    break;

                case 5:
                    currentUser.MFCDPS = true;
                    break;

                case 6:
                    currentUser.MFCCPS = true;
                    break;

                case 7:
                    currentUser.AVIS = true;
                    break;

                case 8:
                    currentUser.INDA = true;
                    break;

                case 9:
                    currentUser.LOGCRAWLER = true;
                    break;

                case 10:
                    currentUser.REMOTEMANAGER = true;
                    break;

                case 11:
                    currentUser.MAPDRIVES = true;
                    break;

                case 12:
                    currentUser.PCO = true;
                    break;

               

                default :
                    Console.WriteLine("Invalid Choice, select 1-9.");
                    break;

            
            }

            printMenu(ref currentUser);


            Console.WriteLine();
            Console.WriteLine("Are you finished selecting items?");
            Console.WriteLine("Press Y to finalize menu selection. Or any other key to choose more");
            exit = Console.ReadLine();
        } while (exit != "y" && exit != "Y");

        Console.WriteLine("Program selection & Credentials are now stored at :");
        Console.WriteLine(path);
        Console.WriteLine("Delete this file, and re-run the program, to make a new selection.");
        Console.WriteLine("Press Any key to Continue ...");
        Console.ReadLine();

    
    }

    // Print selected menu items. **
    static void printMenu(ref userCredentials currentUser) {

        Console.WriteLine();
        Console.WriteLine("Current Selection :");
        if (currentUser.LBS == true){Console.WriteLine("LBS                    - 1");}
        if (currentUser.CPS == true){Console.WriteLine("CPS                    - 2");}
        if (currentUser.DPS == true) { Console.WriteLine("DService               - 3"); }
        if (currentUser.BMIS == true){Console.WriteLine("BMIS                   - 4");}
        if (currentUser.MFCDPS == true){Console.WriteLine("MFC_DPS                - 5");}
        if (currentUser.MFCCPS == true){Console.WriteLine("MFC_CPS                - 6");}
        if (currentUser.AVIS == true){Console.WriteLine("AVIS                   - 7");}
        if (currentUser.INDA == true){Console.WriteLine("INDA                   - 8");}
        if (currentUser.LOGCRAWLER == true){Console.WriteLine("LOGCRAWLER             - 9");}
        if (currentUser.REMOTEMANAGER == true) { Console.WriteLine("Remote Desktop Manager - 10"); }
        if (currentUser.MAPDRIVES == true) { Console.WriteLine("Map Net Drives         - 11"); }
        if (currentUser.PCO == true) { Console.WriteLine("PCO View               - 12"); }

    }

    // Launches programs depending on which have been flagged as true. **
    static void programLauncher(ref userCredentials currentUser) {

        if (currentUser.MAPDRIVES == true) { startMAPDRIVES(); }
        if (currentUser.CPS == true) { startCPS(ref currentUser); }
        if (currentUser.LBS == true) { startLBS(ref currentUser); }
        if (currentUser.BMIS == true) { startBMIS(ref currentUser); }
        if (currentUser.MFCDPS == true) { startMFCDPS(ref currentUser); }
        if (currentUser.MFCCPS == true) { startMFCCPS(ref currentUser); }
        if (currentUser.REMOTEMANAGER == true) { startREMOTEMANAGER(); }
        if (currentUser.LOGCRAWLER == true) { startLOGCRAWLER(); }
        if (currentUser.DPS == true) { startDSERVICE(ref currentUser); }
        if (currentUser.AVIS == true) { startAVIS(); }
        if (currentUser.INDA == true) { startINDA(ref currentUser); }
        if (currentUser.PCO == true) { startPCOVIEW(ref currentUser); }
   
    }

    // Used to push Credentials to selected program, and then fills fields with username & password.
    public static void myCredentials(ref userCredentials currentUser)
    {
        string us = currentUser.user;
        string ps = currentUser.pass;

        Thread.Sleep(1500);
        SendKeys.SendWait(us);
        SendKeys.SendWait("{TAB}");
        SendKeys.SendWait(ps);
        SendKeys.SendWait("{ENTER}");

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

    // CPS Option.
    public static void startCPS(ref userCredentials currentUser)
    {
        if (File.Exists("C:\\Witron\\PCO\\MapNetDrives.cmd") == true)
        {
            Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\CPS.lnk");
            Thread.Sleep(1000);
            myCredentials(ref currentUser);
            Thread.Sleep(1000);
        }

        else {
            Process.Start("R:\\abl\\runtime\\bin\\CPS_start.bat");
            Thread.Sleep(1000);
            myCredentials(ref currentUser);
            Thread.Sleep(1000);
        }
    }

    // MFC DPS Option.
    public static void startMFCDPS(ref userCredentials currentUser)
    {
        if (File.Exists("C:\\Witron\\PCO\\MapNetDrives.cmd") == true)
        {
            Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\MFC_DPS.lnk");
            Thread.Sleep(1000);
            myCredentials(ref currentUser);
            Thread.Sleep(1000);
        }

        else {
            Process.Start("R:\\abl\\runtime\\bin\\MFC_DPS.bat");
            Thread.Sleep(1000);
            myCredentials(ref currentUser);
            Thread.Sleep(1000);
        }
    }

    // DSERVICE Option.
    public static void startDSERVICE(ref userCredentials currentUser)
    {
        if (File.Exists("C:\\Witron\\PCO\\MapNetDrives.cmd") == true)
        {
            Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\DPS.lnk");
            Thread.Sleep(1000);
            myCredentials(ref currentUser);
            Thread.Sleep(1000);
        }
        else {
            Process.Start("R:\\abl\\runtime\\bin\\DSERVICE_start.bat");
            Thread.Sleep(1000);
            myCredentials(ref currentUser);
            Thread.Sleep(1000);
        }

    }

    // BMIS Option.
    public static void startBMIS(ref userCredentials currentUser)
    {
        if (File.Exists("C:\\Witron\\PCO\\MapNetDrives.cmd") == true)
        {
            Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\BMIS.lnk");
            Thread.Sleep(1000);
            myCredentials(ref currentUser);
            Thread.Sleep(1000);
        }
        else
        {
            Process.Start("R:\\abl\\runtime\\bin\\BMIS_start.bat");
            Thread.Sleep(1000);
            myCredentials(ref currentUser);
            Thread.Sleep(1000);
        }

    }

    // LBS Option.
    public static void startLBS(ref userCredentials currentUser)
    {
        if (File.Exists("C:\\Witron\\PCO\\MapNetDrives.cmd") == true)
        {
            Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\LBS.lnk");
            Thread.Sleep(1000);
            myCredentials(ref currentUser);
            Thread.Sleep(1000);
        }
        else
        {
            Process.Start("R:\\abl\\runtime\\bin\\LBS_start.bat");
            Thread.Sleep(1000);
            myCredentials(ref currentUser);
            Thread.Sleep(1000);
        }
    }

    // MFC CPS Option.
    public static void startMFCCPS(ref userCredentials currentUser)
    {
        if (File.Exists("C:\\Witron\\PCO\\MapNetDrives.cmd") == true)
        {
            Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\MFC_CPS.lnk");
            Thread.Sleep(1000);
            myCredentials(ref currentUser);
            Thread.Sleep(1000);
        }
        else
        {
            Process.Start("R:\\abl\\runtime\\bin\\MFC_CPS.bat");
            Thread.Sleep(1000);
            myCredentials(ref currentUser);
            Thread.Sleep(1000);
        }
    }

    // PCO View Option.
    public static void startPCOVIEW(ref userCredentials currentUser) {

        if (File.Exists("C:\\Witron\\PCO\\MapNetDrives.cmd") == true)
        {
            Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\PCO View.lnk");
            Thread.Sleep(1000);
            myCredentials(ref currentUser);
            Thread.Sleep(1000);
        }

        else {
            Process.Start("R:\\asl\\runtime\\bin\\pcoview.exe");
            Thread.Sleep(1000);
            myCredentials(ref currentUser);
            Thread.Sleep(1000);
        }

    }

    // Remote Desktop Services Manager.
    public static void startREMOTEMANAGER()
    {
        if (File.Exists("C:\\Windows\\System32\\tsadmin.msc") == true)
        {
            Process.Start("C:\\Windows\\System32\\tsadmin.msc");
            Thread.Sleep(1000);
        }
    }

    // LogCrawler Option.
    public static void startLOGCRAWLER()
    {
        if (File.Exists("R:\\atl\\runtime\\etc\\LogCrawler\\LogCrawler.exe") == true)
        {
            Process.Start("R:\\atl\\runtime\\etc\\LogCrawler\\LogCrawler.exe");
            Thread.Sleep(1000);
        }
    }

    // Avis Option.
    public static void startAVIS()
    {
        if (File.Exists("C:\\Witron\\PCO\\MapNetDrives.cmd") == true)
        {
            Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\AVIS.lnk");
            Thread.Sleep(2000);
        }
        else
        {
            Process.Start("R:\\atl\\runtime\\bin\\AVIS.exe");
            Thread.Sleep(2000);
        }
    }

    //INDA Option.
    public static void startINDA(ref userCredentials currentUser)
    {

        string us = currentUser.user;
        string ps = currentUser.pass;

        if (File.Exists("C:\\Witron\\PCO\\MapNetDrives.cmd") == true)
        {
            Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\INDA.lnk");
            Thread.Sleep(2000);
            SendKeys.SendWait(us);
            SendKeys.SendWait("{ENTER}");
            SendKeys.SendWait(ps);
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(1000);
        }
        else
        {
            Process.Start("R:\\atl\\runtime\\bin\\INDA.EXE");
            Thread.Sleep(2000);
            SendKeys.SendWait(us);
            SendKeys.SendWait("{ENTER}");
            SendKeys.SendWait(ps);
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(1000);
        }
    }

    //Map Net Drives Option.
    public static void startMAPDRIVES()
    {
        if (File.Exists("C:\\Witron\\PCO\\MapNetDrives.cmd") == true)
        {
            Process.Start("C:\\MapNetDrives.cmd");
            Thread.Sleep(25000);
        }
    }
}

