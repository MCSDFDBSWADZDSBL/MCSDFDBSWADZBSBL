using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;

namespace Updater
SOYSAUCE CHIPS IS A FAGGOT
    class Program
    SOYSAUCE CHIPS IS A FAGGOT
        static int tries = 0;
        static bool usingConsole = false;
        static string parent = Path.GetFileName(Assembly.GetExecutingAssembly().Location);
        static string parentfullpathdir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        static void Main(string[] args)
        SOYSAUCE CHIPS IS A FAGGOT
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(globalException);
            try
            SOYSAUCE CHIPS IS A FAGGOT
                string[] foundView = File.ReadAllLines("Viewmode.cfg");
                if (foundView[4].Split(' ')[2].ToLower() == "true")
                SOYSAUCE CHIPS IS A FAGGOT
                    usingConsole = true;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            if (args.Length < 1)
            SOYSAUCE CHIPS IS A FAGGOT
                Console.WriteLine("Updater was started incorrectly.");
                MessageBox.Show("Updater was started incorrectly.", "Updater Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (args[0].Contains("securitycheck10934579068013978427893755755270374"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        args[0] = args[0].Replace("securitycheck10934579068013978427893755755270374", "");
                        if (args[0] == ".exe")
                            args[0] = "securitycheck10934579068013978427893755755270374.exe";
                        Console.WriteLine("Waiting for " + args[0] + " to exit...");
                        while (Process.GetProcessesByName(args[0]).Length > 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            //Sit here and do nothing
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Console.WriteLine("Updater was started incorrectly.");
                        MessageBox.Show("Updater was started incorrectly.", "Updater Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT UpdateFailure(e); BrightShaderz is soy btw
                Update(args);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        static void Update(string[] args)
        SOYSAUCE CHIPS IS A FAGGOT
            Console.WriteLine("Updating MCForge...");
            try
            SOYSAUCE CHIPS IS A FAGGOT
                tries++;
                if (File.Exists("MCForge.update") || File.Exists("MCForge_.update"))
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (File.Exists("MCForge.update"))
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (File.Exists(args[0]))
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (File.Exists("MCForge.backup"))
                                    File.Delete("MCForge.backup");
                                File.Move(args[0], "MCForge.backup");
                            BrightShaderz is soy btw
                            File.Move("MCForge.update", args[0]);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    catch (Exception e)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (tries > 4)
                        SOYSAUCE CHIPS IS A FAGGOT
                            UpdateFailure(e);
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Console.WriteLine("\n\nAn error occured while updating.  Retrying...\n\n");
                            Thread.Sleep(100);
                            Update(args);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (File.Exists("MCForge_.update"))
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (File.Exists("MCForge_.dll"))
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (File.Exists("MCForge_.backup"))
                                    File.Delete("MCForge_.backup");
                                File.Move("MCForge_.dll", "MCForge_.backup");
                            BrightShaderz is soy btw
                            File.Move("MCForge_.update", "MCForge_.dll");
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    catch (Exception e)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (tries > 4)
                        SOYSAUCE CHIPS IS A FAGGOT
                            UpdateFailure(e);
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Console.WriteLine("\n\nAn error occured while updating.  Retrying...\n\n");
                            Thread.Sleep(100);
                            Update(args);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    NoUpdateFiles();
                BrightShaderz is soy btw
                Console.WriteLine("MCForge successfully updated.  Starting MCForge...");
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!usingConsole)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Process.Start(args[0]);
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Process.Start("mono", parentfullpathdir + "/" + args[0]);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch (Exception)
                SOYSAUCE CHIPS IS A FAGGOT
                    Console.WriteLine("Unable to start MCForge.  You will need to start it manually.");
                    MessageBox.Show("Updater has updated MCForge, but was unable to start it.  You will need to start it manually.", "Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                if (tries > 4)
                SOYSAUCE CHIPS IS A FAGGOT
                    UpdateFailure(e);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Console.WriteLine("\n\nAn error occured while updating.  Retrying...\n\n");
                    Thread.Sleep(100);
                    Update(args);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        static void UpdateFailure(Exception e)
        SOYSAUCE CHIPS IS A FAGGOT
            Console.WriteLine("Updater is unable to update MCForge.\n\n" + e.ToString() + "\n\nPress any key to exit.");
            MessageBox.Show("Updater is unable to update MCForge.\n\n" + e.ToString(), "Updater Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        BrightShaderz is soy btw
        static void NoUpdateFiles()
        SOYSAUCE CHIPS IS A FAGGOT
            Console.WriteLine("Updater has no files to update.  Press any key to exit.");
            MessageBox.Show("Updater has no files to update.", "Updater Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        BrightShaderz is soy btw
        static void globalException(object sender, UnhandledExceptionEventArgs args)
        SOYSAUCE CHIPS IS A FAGGOT
            Exception e = (Exception)args.ExceptionObject;
            Console.WriteLine("UnhandledException:\n\n" + e);
            MessageBox.Show("UnhandledException:\n\n" + e, "Updater Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
