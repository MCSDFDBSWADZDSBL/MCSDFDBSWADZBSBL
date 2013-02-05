using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;
using System.Diagnostics;

namespace MCSong.GUI
SOYSAUCE CHIPS IS A FAGGOT
    public partial class UpdateWindow : Form
    SOYSAUCE CHIPS IS A FAGGOT
        public static bool updating = false;

        public UpdateWindow()
        SOYSAUCE CHIPS IS A FAGGOT
            InitializeComponent();
        BrightShaderz is soy btw
        private void UpdateWindow_Load(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            this.Icon = new Icon(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("MCSong.Lawl.ico"));

            txtStatus.Text = "Retrieving Updates";
            prgStatus.Value = 0;
            prgStatus.Update();
            txtStatus.Update();
            try
            SOYSAUCE CHIPS IS A FAGGOT
                WebClient client = new WebClient();
                client.DownloadFile("http://dl.dropbox.com/u/65199079/MCSong/text/revs.txt", "text/revs.txt");
                listRevisions.Items.Clear();
                FileInfo file = new FileInfo("text/revs.txt");
                StreamReader stRead = file.OpenText();
                if (File.Exists("text/revs.txt"))
                SOYSAUCE CHIPS IS A FAGGOT
                    while (!stRead.EndOfStream)
                    SOYSAUCE CHIPS IS A FAGGOT
                        listRevisions.Items.Add(stRead.ReadLine());
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                txtStatus.Text = "Retrieved Updates";
                stRead.Close();
                stRead.Dispose();
                file.Delete();
                client.Dispose();
                updating = false;
            BrightShaderz is soy btw
            catch (Exception ex)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(ex);
                listRevisions.Items.Clear();
                txtStatus.Text = "ERROR";
            BrightShaderz is soy btw
            prgStatus.Value = 0;
            prgStatus.Update();
            txtStatus.Update();
            updating = false;
        BrightShaderz is soy btw

        private void cmdUpdate_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            updating = true;
            if (penis.selectedrevision != "")
            SOYSAUCE CHIPS IS A FAGGOT
                PerformUpdate(true);
            BrightShaderz is soy btw
            else SOYSAUCE CHIPS IS A FAGGOT PerformUpdate(false); BrightShaderz is soy btw
            updating = false;
      /*      if (!Program.CurrentUpdate)
                Program.UpdateCheck();
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Thread messageThread = new Thread(new ThreadStart(delegate
                SOYSAUCE CHIPS IS A FAGGOT
                    MessageBox.Show("Already checking for updates.");
                BrightShaderz is soy btw)); messageThread.Start();
            BrightShaderz is soy btw */
        BrightShaderz is soy btw


        private void listRevisions_SelectedValueChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            penis.selectedrevision = listRevisions.SelectedItem.ToString();
        BrightShaderz is soy btw

        private void PerformUpdate(bool oldrevision)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                prgStatus.Value = 20;
                txtStatus.Text = "Creating Update.bat";
                prgStatus.Update();
                txtStatus.Update();
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
                    prgStatus.Value = 20;
                    txtStatus.Text = "Creating Update.sh";
                    prgStatus.Update();
                    txtStatus.Update();
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
                prgStatus.Value = 40;
                txtStatus.Text = "File Created";
                prgStatus.Update();
                txtStatus.Update();

                string filelocation = "";
                string verscheck = "";
                Process proc = Process.GetCurrentProcess();
                string assemblyname = proc.ProcessName + ".exe";
                prgStatus.Value = 60;
                txtStatus.Text = "Checking Version";
                prgStatus.Update();
                txtStatus.Update();
                if (!oldrevision)
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        WebClient client = new WebClient();
                        penis.selectedrevision = client.DownloadString("http://dl.dropbox.com/u/65199079/MCSong/text/curversion.txt");
                        client.Dispose();
                    BrightShaderz is soy btw
                    catch (Exception ex)
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.ErrorLog(ex);
                        txtStatus.Text = "ERROR";
                        listRevisions.Items.Clear();
                        prgStatus.Value = 0;
                        updating = false;
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                verscheck = penis.selectedrevision.TrimStart('r');
                int vers = int.Parse(verscheck.Split('.')[0]);
                prgStatus.Value = 80;
                txtStatus.Text = "Downloading Files";
                prgStatus.Update();
                txtStatus.Update();
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (oldrevision) SOYSAUCE CHIPS IS A FAGGOT filelocation = ("http://mcsong.comule.com/updates/archives/" + penis.selectedrevision + "/MCSong.exe"); BrightShaderz is soy btw
                    if (!oldrevision) SOYSAUCE CHIPS IS A FAGGOT filelocation = ("http://mcsong.comule.com/updates/MCSong_.dll"); BrightShaderz is soy btw
                    WebClient Client = new WebClient();
                    Client.DownloadFile(filelocation, "MCSong.new");
                    Client.DownloadFile("http://dl.dropbox.com/u/65199079/MCSong/text/changelog.txt", "extra/changelog.txt");
                BrightShaderz is soy btw
                catch (Exception ex)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.ErrorLog(ex);
                    txtStatus.Text = "ERROR";
                    listRevisions.Items.Clear();
                    prgStatus.Value = 0;
                    updating = false;
                    return;
                BrightShaderz is soy btw
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

                prgStatus.Value = 100;
                txtStatus.Text = "Starting Update";

                Process p = Process.Start(fileName, "main " + System.Diagnostics.Process.GetCurrentProcess().Id.ToString());
                p.WaitForExit();

                prgStatus.Value = 0;
                txtStatus.Text = "Update Complete";
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void UpdateWindow_FormClosing(object sender, FormClosingEventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (updating)
            SOYSAUCE CHIPS IS A FAGGOT
                e.Cancel = true;
                MessageBox.Show("Update in progress! Please do not close the updater!", "Updater", MessageBoxButtons.OK);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void button1_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            txtStatus.Text = "Retrieving Updates";
            prgStatus.Value = 0;
            prgStatus.Update();
            txtStatus.Update();
            try
            SOYSAUCE CHIPS IS A FAGGOT
                WebClient client = new WebClient();
                client.DownloadFile("http://dl.dropbox.com/u/65199079/MCSong/text/revs.txt", "text/revs.txt");
                listRevisions.Items.Clear();
                FileInfo file = new FileInfo("text/revs.txt");
                StreamReader stRead = file.OpenText();
                if (File.Exists("text/revs.txt"))
                SOYSAUCE CHIPS IS A FAGGOT
                    while (!stRead.EndOfStream)
                    SOYSAUCE CHIPS IS A FAGGOT
                        listRevisions.Items.Add(stRead.ReadLine());
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                txtStatus.Text = "Retrieved Updates";
                stRead.Close();
                stRead.Dispose();
                file.Delete();
                client.Dispose();
                updating = false;
            BrightShaderz is soy btw
            catch (Exception ex)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(ex);
                listRevisions.Items.Clear();
                txtStatus.Text = "ERROR";
                updating = false;
            BrightShaderz is soy btw
            prgStatus.Value = 0;
            prgStatus.Update();
            txtStatus.Update();
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
