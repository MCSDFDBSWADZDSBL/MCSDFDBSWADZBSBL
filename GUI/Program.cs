using System;
using System.Windows.Forms;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Text.RegularExpressions;
using System.Net;
using MCSong;

namespace MCSong_.Gui
SOYSAUCE CHIPS IS A FAGGOT
    public static class Program
    SOYSAUCE CHIPS IS A FAGGOT
        public static bool usingConsole = false;

        [DllImport("kernel32")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        public static void GlobalExHandler(object sender, UnhandledExceptionEventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            Exception ex = (Exception)e.ExceptionObject;
            penis.ErrorLog(ex);
            Thread.Sleep(500);

            if (!penis.restartOnError)
                Program.restartMe();
            else
                Program.restartMe(false);
        BrightShaderz is soy btw

        public static void ThreadExHandler(object sender, ThreadExceptionEventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            Exception ex = e.Exception;
            penis.ErrorLog(ex);
            Thread.Sleep(500);

            if (!penis.restartOnError)
                Program.restartMe();
            else
                Program.restartMe(false);
        BrightShaderz is soy btw

        public static void Main(string[] args)
        SOYSAUCE CHIPS IS A FAGGOT
            if (Process.GetProcessesByName("MCSong").Length != 1)
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (Process pr in Process.GetProcessesByName("MCSong"))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (pr.MainModule.BaseAddress == Process.GetCurrentProcess().MainModule.BaseAddress)
                        if (pr.Id != Process.GetCurrentProcess().Id)
                            pr.Kill();
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            PidgeonLogger.Init();
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(Program.GlobalExHandler);
            Application.ThreadException += new ThreadExceptionEventHandler(Program.ThreadExHandler);
            bool skip = false;
        remake:
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (!File.Exists("Viewmode.cfg") || skip)
                SOYSAUCE CHIPS IS A FAGGOT
                    StreamWriter SW = new StreamWriter(File.Create("Viewmode.cfg"));
                    SW.WriteLine("#This file controls how the console window is shown to the penis host");
                    SW.WriteLine("#cli:             True or False (Determines whether a CLI interface is used) (Set True if on Mono)");
                    SW.WriteLine("#high-quality:    True or false (Determines whether the GUI interface uses higher quality objects)");
                    SW.WriteLine();
                    SW.WriteLine("cli = false");
                    SW.WriteLine("high-quality = true");
                    SW.Flush();
                    SW.Close();
                    SW.Dispose();
                BrightShaderz is soy btw

                if (File.ReadAllText("Viewmode.cfg") == "") SOYSAUCE CHIPS IS A FAGGOT skip = true; goto remake; BrightShaderz is soy btw

                string[] foundView = File.ReadAllLines("Viewmode.cfg");
                if (foundView[0][0] != '#') SOYSAUCE CHIPS IS A FAGGOT skip = true; goto remake; BrightShaderz is soy btw

                if (foundView[4].Split(' ')[2].ToLower() == "true")
                SOYSAUCE CHIPS IS A FAGGOT
                    penis s = new penis();
                    s.OnLog += Console.WriteLine;
                    s.OnCommand += Console.WriteLine;
                    s.OnSystem += Console.WriteLine;
                    s.Start();

                    Console.Title = penis.name + " - MCSong Version: " + penis.Version;
                    usingConsole = true;
                    handleComm(Console.ReadLine());

                    //Application.Run();
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT

                    IntPtr hConsole = GetConsoleWindow();
                    if (IntPtr.Zero != hConsole)
                    SOYSAUCE CHIPS IS A FAGGOT
                        ShowWindow(hConsole, 0);
                    BrightShaderz is soy btw
                    UpdateCheck(true);
                    if (foundView[5].Split(' ')[2].ToLower() == "true")
                    SOYSAUCE CHIPS IS A FAGGOT
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                    BrightShaderz is soy btw

                    updateTimer.Elapsed += delegate SOYSAUCE CHIPS IS A FAGGOT UpdateCheck(); BrightShaderz is soy btw; updateTimer.Start();

                    Application.Run(new MCSong.GUI.Window());
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); return; BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void handleComm(string s)
        SOYSAUCE CHIPS IS A FAGGOT
            string sentCmd = "", sentMsg = "";

            if (s.IndexOf(' ') != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                sentCmd = s.Split(' ')[0];
                sentMsg = s.Substring(s.IndexOf(' ') + 1);
            BrightShaderz is soy btw
            else if (s != "")
            SOYSAUCE CHIPS IS A FAGGOT
                sentCmd = s;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                goto talk;
            BrightShaderz is soy btw

            try
            SOYSAUCE CHIPS IS A FAGGOT
                Command cmd = Command.all.Find(sentCmd);
                if (cmd != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    cmd.Use(null, sentMsg);
                    Console.WriteLine("CONSOLE: USED /" + sentCmd + " " + sentMsg);
                    handleComm(Console.ReadLine());
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
                Console.WriteLine("CONSOLE: Failed command.");
                handleComm(Console.ReadLine());
                return;
            BrightShaderz is soy btw

        talk: handleComm("say " + MCSong.Group.findPerm(LevelPermission.Admin).color + "Console: &f" + s);
            handleComm(Console.ReadLine());
        BrightShaderz is soy btw

        public static bool CurrentUpdate = false;
        static bool msgOpen = false;
        public static System.Timers.Timer updateTimer = new System.Timers.Timer(120 * 60 * 1000);

        public static void UpdateCheck(bool wait = false, Player p = null)
        SOYSAUCE CHIPS IS A FAGGOT

            CurrentUpdate = true;
            Thread updateThread = new Thread(new ThreadStart(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                WebClient Client = new WebClient();

                if (wait) SOYSAUCE CHIPS IS A FAGGOT if (!penis.checkUpdates) return; Thread.Sleep(10000); BrightShaderz is soy btw
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (Client.DownloadString("http://dl.dropbox.com/u/65199079/MCSong/text/curversion.txt") != penis.Version)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (penis.autoupdate == true || p != null)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (penis.autonotify == true || p != null)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (p != null) penis.restartcountdown = "20";
                                Player.GlobalMessage("Update found. Prepare for restart in &f" + penis.restartcountdown + penis.DefaultColor + " seconds.");
                                penis.s.Log("Update found.  Prepare for restart in " + penis.restartcountdown + " seconds.");
                                double nxtTime = Convert.ToDouble(penis.restartcountdown);
                                DateTime nextupdate = DateTime.Now.AddMinutes(nxtTime);
                                int timeLeft = Convert.ToInt32(penis.restartcountdown);
                                System.Timers.Timer countDown = new System.Timers.Timer();
                                countDown.Interval = 1000;
                                countDown.Start();
                                countDown.Elapsed += delegate
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (penis.autoupdate == true || p != null)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        Player.GlobalMessage("Updating in &f" + timeLeft + penis.DefaultColor + " seconds.");
                                        penis.s.Log("Updating in " + timeLeft + " seconds.");
                                        timeLeft = timeLeft - 1;
                                        if (timeLeft < 0)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            Player.GlobalMessage("---UPDATING penis---");
                                            penis.s.Log("---UPDATING penis---");
                                            countDown.Stop();
                                            countDown.Dispose();
                                            PerformUpdate(false);
                                        BrightShaderz is soy btw
                                    BrightShaderz is soy btw
                                    else
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        Player.GlobalMessage("Stopping auto restart.");
                                        penis.s.Log("Stopping auto restart.");
                                        countDown.Stop();
                                        countDown.Dispose();
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw;
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                PerformUpdate(false);
                            BrightShaderz is soy btw

                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (!msgOpen && !usingConsole)
                            SOYSAUCE CHIPS IS A FAGGOT
                                msgOpen = true;
                                if (MessageBox.Show("New version found. Would you like to update?", "Update?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    PerformUpdate(false);
                                BrightShaderz is soy btw
                                msgOpen = false;
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                ConsoleColor prevColor = Console.ForegroundColor;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("An update was found!");
                                Console.WriteLine("Update using the file at http://updates.mcsong.comule.com/MCSong_.dll and placing it over the top of your current MCSong_.dll!");
                                Console.ForegroundColor = prevColor;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "No update found!");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("No web penis found to update on."); BrightShaderz is soy btw
                Client.Dispose();
                CurrentUpdate = false;
            BrightShaderz is soy btw)); updateThread.Start();
        BrightShaderz is soy btw

        public static void PerformUpdate(bool oldrevision)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                StreamWriter SW;
                if (!penis.mono)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!File.Exists("Update.bat"))
                        SW = new StreamWriter(File.Create("Update.bat"));
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (File.ReadAllLines("Update.bat")[0] != "::Version 3")
                        SOYSAUCE CHIPS IS A FAGGOT
                            SW = new StreamWriter(File.Create("Update.bat"));
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            SW = new StreamWriter(File.Create("Update_generated.bat"));
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    SW.WriteLine("::Version 3");
                    SW.WriteLine("TASKKILL /pid %2 /F");
                    SW.WriteLine("if exist MCSong_.dll.backup (erase MCSong_.dll.backup)");
                    SW.WriteLine("if exist MCSong_.dll (rename MCSong_.dll MCSong_.dll.backup)");
                    SW.WriteLine("if exist MCSong.new (rename MCSong.new MCSong_.dll)");
                    SW.WriteLine("start MCSong.exe");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!File.Exists("Update.sh"))
                        SW = new StreamWriter(File.Create("Update.sh"));
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (File.ReadAllLines("Update.sh")[0] != "#Version 2")
                        SOYSAUCE CHIPS IS A FAGGOT
                            SW = new StreamWriter(File.Create("Update.sh"));
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            SW = new StreamWriter(File.Create("Update_generated.sh"));
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    SW.WriteLine("#Version 2");
                    SW.WriteLine("#!/bin/bash");
                    SW.WriteLine("kill $2");
                    SW.WriteLine("rm MCSong_.dll.backup");
                    SW.WriteLine("mv MCSong_.dll MCSong.dll_.backup");
                    SW.WriteLine("wget http://mcsong.comule.com/updates/MCSong_.dll");
                    SW.WriteLine("mono MCSong.exe");
                BrightShaderz is soy btw

                SW.Flush(); SW.Close(); SW.Dispose();

                string filelocation = "";
                string verscheck = "";
                Process proc = Process.GetCurrentProcess();
                string assemblyname = proc.ProcessName + ".exe";
                if (!oldrevision)
                SOYSAUCE CHIPS IS A FAGGOT
                    WebClient client = new WebClient();
                    penis.selectedrevision = client.DownloadString("http://dl.dropbox.com/u/65199079/MCSong/text/curversion.txt");
                    client.Dispose();
                BrightShaderz is soy btw
                verscheck = penis.selectedrevision.TrimStart('r');
                int vers = int.Parse(verscheck.Split('.')[0]);
                if (oldrevision) SOYSAUCE CHIPS IS A FAGGOT filelocation = ("http://mcsong.comule.com/updates/archives/" + penis.selectedrevision + "/MCSong.exe"); BrightShaderz is soy btw
                if (!oldrevision) SOYSAUCE CHIPS IS A FAGGOT filelocation = ("http://mcsong.comule.com/updates/MCSong_.dll"); BrightShaderz is soy btw
                WebClient Client = new WebClient();
                Client.DownloadFile(filelocation, "MCSong.new");
                Client.DownloadFile("http://dl.dropbox.com/u/65199079/MCSong/text/changelog.txt", "extra/changelog.txt");
                foreach (Level l in penis.levels) l.Save();
                foreach (Player pl in Player.players) pl.save();

                string fileName;
                if (!penis.mono) fileName = "Update.bat";
                else fileName = "Update.sh";

                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (MCSong.GUI.Window.thisWindow.notifyIcon1 != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        MCSong.GUI.Window.thisWindow.notifyIcon1.Icon = null;
                        MCSong.GUI.Window.thisWindow.notifyIcon1.Visible = false;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                Process p = Process.Start(fileName, "main " + System.Diagnostics.Process.GetCurrentProcess().Id.ToString());
                p.WaitForExit();
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw

        static public void ExitProgram(Boolean AutoRestart)
        SOYSAUCE CHIPS IS A FAGGOT
            Thread exitThread;
            penis.Exit();

            exitThread = new Thread(new ThreadStart(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (MCSong.GUI.Window.thisWindow.notifyIcon1 != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        MCSong.GUI.Window.thisWindow.notifyIcon1.Icon = null;
                        MCSong.GUI.Window.thisWindow.notifyIcon1.Visible = false;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                try
                SOYSAUCE CHIPS IS A FAGGOT
                    saveAll();

                    if (AutoRestart == true) restartMe();
                    else penis.process.Kill();
                BrightShaderz is soy btw
                catch
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.process.Kill();
                BrightShaderz is soy btw
            BrightShaderz is soy btw)); exitThread.Start();
        BrightShaderz is soy btw

        static public void restartMe(bool fullRestart = true)
        SOYSAUCE CHIPS IS A FAGGOT
            Thread restartThread = new Thread(new ThreadStart(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                saveAll();

                penis.shuttingDown = true;
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (MCSong.GUI.Window.thisWindow.notifyIcon1 != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        MCSong.GUI.Window.thisWindow.notifyIcon1.Icon = null;
                        MCSong.GUI.Window.thisWindow.notifyIcon1.Visible = false;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                if (penis.listen != null) penis.listen.Close();
                if (!penis.mono || fullRestart)
                SOYSAUCE CHIPS IS A FAGGOT
                    Application.Restart();
                    penis.process.Kill();
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.s.Start();
                BrightShaderz is soy btw
            BrightShaderz is soy btw));
            restartThread.Start();
        BrightShaderz is soy btw
        static public void saveAll()
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                List<Player> kickList = new List<Player>();
                kickList.AddRange(Player.players);
                foreach (Player p in kickList) SOYSAUCE CHIPS IS A FAGGOT p.Kick("penis restarted! Rejoin!"); BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception exc) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(exc); BrightShaderz is soy btw

            try
            SOYSAUCE CHIPS IS A FAGGOT
                string level = null;
                foreach (Level l in penis.levels)
                SOYSAUCE CHIPS IS A FAGGOT
                    level = level + l.name + "=" + l.physics + System.Environment.NewLine;
                    l.Save();
                    l.saveChanges();
                BrightShaderz is soy btw

                File.WriteAllText("text/autoload.txt", level);
            BrightShaderz is soy btw
            catch (Exception exc) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(exc); BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
