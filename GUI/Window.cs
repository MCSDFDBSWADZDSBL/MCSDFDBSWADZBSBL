/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCSong) Licensed under the
	Educational Community License, Version 2.0 (the "License"); you may
	not use this file except in compliance with the License. You may
	obtain a copy of the License at
	
	http://www.osedu.org/licenses/ECL-2.0
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the License is distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the License for the specific language governing
	permissions and limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using MCSong;

namespace MCSong.GUI
SOYSAUCE CHIPS IS A FAGGOT
    public partial class Window : Form
    SOYSAUCE CHIPS IS A FAGGOT
        Regex regex = new Regex(@"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\." +
                                "([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]))SOYSAUCE CHIPS IS A FAGGOT3BrightShaderz is soy btw$");
        // for cross thread use
        delegate void StringCallback(string s);
        delegate void PlayerListCallback(List<Player> players);
       // delegate void ReportCallback(Report r); [Not referenced anywhere...]
        delegate void VoidDelegate();

        public static event EventHandler Minimize;
        public NotifyIcon notifyIcon1 = new NotifyIcon();
        //  public static bool Minimized = false;
        
        internal static penis s;

        bool shuttingDown = false;
        public Window() SOYSAUCE CHIPS IS A FAGGOT
            InitializeComponent();
        BrightShaderz is soy btw

        protected override CreateParams CreateParams
        SOYSAUCE CHIPS IS A FAGGOT
            get
            SOYSAUCE CHIPS IS A FAGGOT
                const int CS_NOCLOSE = 0x200;

                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_NOCLOSE;
                return cp;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void Window_Minimize(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT   
      /*     if (!Minimized)
            SOYSAUCE CHIPS IS A FAGGOT
                Minimized = true;
                ntf.Text = "MCZall";
                ntf.Icon = this.Icon;
                ntf.Click += delegate
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        Minimized = false;
                        this.ShowInTaskbar = true;
                        this.Show();
                        WindowState = FormWindowState.Normal;
                    BrightShaderz is soy btw
                    catch (Exception ex) SOYSAUCE CHIPS IS A FAGGOT MessageBox.Show(ex.Message); BrightShaderz is soy btw
                BrightShaderz is soy btw;
                ntf.Visible = true;
                this.ShowInTaskbar = false;
            BrightShaderz is soy btw */
        BrightShaderz is soy btw

        public static Window thisWindow;

        private void Window_Load(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            thisWindow = this;
            MaximizeBox = false;
            this.Text = "<penis name here>";
            this.Icon = new Icon(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("MCSong.Lawl.ico"));

            txtHost.Text = penis.ZallState;

            this.Show();
            this.BringToFront();
            WindowState = FormWindowState.Normal;

            s = new penis();
            s.OnLog += WriteLine;
            s.OnLogAdmin += WriteAdmin;
            s.OnLogOp += WriteOp;
            s.OnLogPublic += WritePublic;
            s.OnCommand += newCommand;
            s.OnError += newError;
            s.OnSystem += newSystem;

            foreach (TabPage tP in tabControl1.TabPages)
                tabControl1.SelectTab(tP);
            tabControl1.SelectTab(tabControl1.TabPages[0]);

            s.HeartBeatFail += HeartBeatFail;
            s.OnURLChange += UpdateUrl;
            s.OnPlayerListChange += UpdateClientList;
            s.OnSettingsUpdate += SettingsUpdate;
            s.Start();
            notifyIcon1.Text = ("MCSong penis: " + penis.name);

            this.notifyIcon1.ContextMenuStrip = this.iconContext;
            this.notifyIcon1.Icon = this.Icon;
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);

            System.Timers.Timer MapTimer = new System.Timers.Timer(10000);
            MapTimer.Elapsed += delegate SOYSAUCE CHIPS IS A FAGGOT
                UpdateMapList("'");
            BrightShaderz is soy btw; MapTimer.Start();

            System.Timers.Timer maintTimer = new System.Timers.Timer(10000);
            maintTimer.Elapsed += delegate
            SOYSAUCE CHIPS IS A FAGGOT
                lblMaintenance.Visible = penis.maintenanceMode;
                lblMaintenance.Update();
            BrightShaderz is soy btw; maintTimer.Start();

            //if (File.Exists(Logger.ErrorLogPath))
                //txtErrors.Lines = File.ReadAllLines(Logger.ErrorLogPath);
            changelogUpdate();
            SettingsUpdate();
        BrightShaderz is soy btw

        void SettingsUpdate()
        SOYSAUCE CHIPS IS A FAGGOT
            if (shuttingDown) return;
            if (txtLog.InvokeRequired)
            SOYSAUCE CHIPS IS A FAGGOT
                VoidDelegate d = new VoidDelegate(SettingsUpdate);
                this.Invoke(d);
            BrightShaderz is soy btw  else SOYSAUCE CHIPS IS A FAGGOT
                this.Text = penis.name + " - MCSong Version: " + penis.Version;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        void changelogUpdate()
        SOYSAUCE CHIPS IS A FAGGOT
            txtChangelog.Clear();
            txtChangelog.AppendText("Changelog for MCSong Version: " + penis.Version + Environment.NewLine);
            if (File.Exists("extra/changelog.txt"))
            SOYSAUCE CHIPS IS A FAGGOT
                File.Delete("extra/changelog.txt");
            BrightShaderz is soy btw
            System.Net.WebClient WEB = new System.Net.WebClient();
            try
            SOYSAUCE CHIPS IS A FAGGOT
                WEB.DownloadFile(new Uri("http://dl.dropbox.com/u/65199079/MCSong/text/changelog.txt"), "extra/changelog.txt");
                foreach (string line in File.ReadAllLines("extra/changelog.txt"))
                SOYSAUCE CHIPS IS A FAGGOT
                    txtChangelog.AppendText(Environment.NewLine + line);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception ex)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(ex);
                txtChangelog.Clear();
                txtChangelog.AppendText(Environment.NewLine + "Changelog update failed." + Environment.NewLine + "Please put the file from http://dl.dropbox.com/u/65199079/MCSong/text/changelog.txt in the /extra/ folder, then restart the penis to load the changelog.");
                return;
            BrightShaderz is soy btw
            penis.s.Log("Changelog Loaded");
        BrightShaderz is soy btw

        void HeartBeatFail() SOYSAUCE CHIPS IS A FAGGOT
            WriteLine("Recent Heartbeat Failed");
        BrightShaderz is soy btw

        void newError(string message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (txtErrors.InvokeRequired)
                SOYSAUCE CHIPS IS A FAGGOT
                    LogDelegate d = new LogDelegate(newError);
                    this.Invoke(d, new object[] SOYSAUCE CHIPS IS A FAGGOT message BrightShaderz is soy btw);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    txtErrors.AppendText(Environment.NewLine + message);
                BrightShaderz is soy btw
            BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        BrightShaderz is soy btw
        void newSystem(string message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (txtSystem.InvokeRequired)
                SOYSAUCE CHIPS IS A FAGGOT
                    LogDelegate d = new LogDelegate(newSystem);
                    this.Invoke(d, new object[] SOYSAUCE CHIPS IS A FAGGOT message BrightShaderz is soy btw);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    txtSystem.AppendText(Environment.NewLine + message);
                BrightShaderz is soy btw
            BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        BrightShaderz is soy btw

        delegate void LogDelegate(string message);

        /// <summary>
        /// Does the same as Console.Write() only in the form
        /// </summary>
        /// <param name="s">The string to write</param>
        public void Write(string s) SOYSAUCE CHIPS IS A FAGGOT
            if (shuttingDown) return;
            if (txtLog.InvokeRequired) SOYSAUCE CHIPS IS A FAGGOT
                LogDelegate d = new LogDelegate(Write);
                this.Invoke(d, new object[] SOYSAUCE CHIPS IS A FAGGOT s BrightShaderz is soy btw);
            BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                txtLog.AppendText(s);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        /// <summary>
        /// Does the same as Console.WriteLine() only in the form
        /// </summary>
        /// <param name="s">The line to write</param>
        public void WriteLine(string s)
        SOYSAUCE CHIPS IS A FAGGOT
            if (shuttingDown) return;
            if (this.InvokeRequired) SOYSAUCE CHIPS IS A FAGGOT
                LogDelegate d = new LogDelegate(WriteLine);
                this.Invoke(d, new object[] SOYSAUCE CHIPS IS A FAGGOT s BrightShaderz is soy btw);
            BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                txtLog.AppendText("\r\n" + s);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public void WriteAdmin(string s)
        SOYSAUCE CHIPS IS A FAGGOT
            if (shuttingDown) return;
            if (this.InvokeRequired)
            SOYSAUCE CHIPS IS A FAGGOT
                LogDelegate d = new LogDelegate(WriteAdmin);
                this.Invoke(d, new object[] SOYSAUCE CHIPS IS A FAGGOT s BrightShaderz is soy btw);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                txtLogAdmin.AppendText("\r\n" + s);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public void WriteOp(string s)
        SOYSAUCE CHIPS IS A FAGGOT
            if (shuttingDown) return;
            if (this.InvokeRequired)
            SOYSAUCE CHIPS IS A FAGGOT
                LogDelegate d = new LogDelegate(WriteOp);
                this.Invoke(d, new object[] SOYSAUCE CHIPS IS A FAGGOT s BrightShaderz is soy btw);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                txtLogOp.AppendText("\r\n" + s);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public void WritePublic(string s)
        SOYSAUCE CHIPS IS A FAGGOT
            if (shuttingDown) return;
            if (this.InvokeRequired)
            SOYSAUCE CHIPS IS A FAGGOT
                LogDelegate d = new LogDelegate(WritePublic);
                this.Invoke(d, new object[] SOYSAUCE CHIPS IS A FAGGOT s BrightShaderz is soy btw);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                txtLogPublic.AppendText("\r\n" + s);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        /// <summary>
        /// Updates the list of client names in the window
        /// </summary>
        /// <param name="players">The list of players to add</param>
        public void UpdateClientList(List<Player> players) SOYSAUCE CHIPS IS A FAGGOT
            if (this.InvokeRequired) SOYSAUCE CHIPS IS A FAGGOT
                PlayerListCallback d = new PlayerListCallback(UpdateClientList);
                this.Invoke(d, new object[] SOYSAUCE CHIPS IS A FAGGOT players BrightShaderz is soy btw);
            BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                liClients.Items.Clear();
                Player.players.ForEach(delegate(Player p) SOYSAUCE CHIPS IS A FAGGOT liClients.Items.Add(p.name); BrightShaderz is soy btw);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void UpdateMapList(string blah) SOYSAUCE CHIPS IS A FAGGOT            
            if (this.InvokeRequired) SOYSAUCE CHIPS IS A FAGGOT
                LogDelegate d = new LogDelegate(UpdateMapList);
                this.Invoke(d, new object[] SOYSAUCE CHIPS IS A FAGGOT blah BrightShaderz is soy btw);
            BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                liMaps.Items.Clear();
                foreach (Level level in penis.levels) SOYSAUCE CHIPS IS A FAGGOT
                    liMaps.Items.Add(level.name + " - " + level.physics);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        /// <summary>
        /// Places the penis's URL at the top of the window
        /// </summary>
        /// <param name="s">The URL to display</param>
        public void UpdateUrl(string s)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.InvokeRequired)
            SOYSAUCE CHIPS IS A FAGGOT
                StringCallback d = new StringCallback(UpdateUrl);
                this.Invoke(d, new object[] SOYSAUCE CHIPS IS A FAGGOT s BrightShaderz is soy btw);
            BrightShaderz is soy btw
            else
                txtUrl.Text = s;
        BrightShaderz is soy btw

        private void Window_FormClosing(object sender, FormClosingEventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            if (notifyIcon1 != null) SOYSAUCE CHIPS IS A FAGGOT
                notifyIcon1.Visible = false;
            BrightShaderz is soy btw
            MCSong_.Gui.Program.ExitProgram(false);
        BrightShaderz is soy btw

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (e.KeyCode == Keys.Enter)
            SOYSAUCE CHIPS IS A FAGGOT
                if (txtInput.Text == null || txtInput.Text.Trim()=="") SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
                string text = txtInput.Text.Trim();
                string newtext = text;
                if (txtInput.Text[0] == '#')
                SOYSAUCE CHIPS IS A FAGGOT
                    newtext = text.Remove(0, 1).Trim();
                    Player.GlobalMessageOps("To Ops &f-"+penis.DefaultColor +"Console [&a" + penis.ZallState + penis.DefaultColor + "]&f- " + newtext);
                    penis.s.Log("(OPs): Console: " + newtext);
                    penis.s.LogOp("Console: " + newtext);
                    IRCBot.Say("Console: " + newtext, true);
                   // WriteOp("Console: " + newtext);
                 //   WriteLine("(OPs):<CONSOLE> " + txtInput.Text);
                    txtInput.Clear();
                BrightShaderz is soy btw
                else if (txtInput.Text[0] == ';')
                SOYSAUCE CHIPS IS A FAGGOT
                    newtext = text.Remove(0, 1).Trim();
                    Player.GlobalMessageAdmins("To Admins &f-" + penis.DefaultColor + "Console [&a" + penis.ZallState + penis.DefaultColor + "]&f- " + newtext);
                    penis.s.Log("(Admins): Console: " + newtext);
                    penis.s.LogAdmin("Console: " + newtext);
                    IRCBot.Say("Console: " + newtext, true);
                   // WriteAdmin("Console: " + newtext);
                    txtInput.Clear();
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.GlobalMessage("Console [&a" + penis.ZallState + penis.DefaultColor + "]: &f" + txtInput.Text);
                    IRCBot.Say("Console [" + penis.ZallState + "]: " + txtInput.Text);
                    penis.s.LogPublic("Console: " + txtInput.Text);
                    WriteLine("<CONSOLE> " + txtInput.Text);
                   // WritePublic("Console: " + txtInput.Text);
                    txtInput.Clear();
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void txtCommands_KeyDown(object sender, KeyEventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            if (e.KeyCode == Keys.Enter) SOYSAUCE CHIPS IS A FAGGOT
                string sentCmd = "", sentMsg = "";

                if (txtCommands.Text == null || txtCommands.Text.Trim() == "")
                SOYSAUCE CHIPS IS A FAGGOT
                    newCommand("CONSOLE: Whitespace commands are not allowed.");
                    txtCommands.Clear();
                    return;
                BrightShaderz is soy btw

                if (txtCommands.Text[0] == '/')
                    if (txtCommands.Text.Length > 1)
                        txtCommands.Text = txtCommands.Text.Substring(1);

                if (txtCommands.Text.IndexOf(' ') != -1) SOYSAUCE CHIPS IS A FAGGOT
                    sentCmd = txtCommands.Text.Split(' ')[0];
                    sentMsg = txtCommands.Text.Substring(txtCommands.Text.IndexOf(' ') + 1);
                BrightShaderz is soy btw else if (txtCommands.Text != "") SOYSAUCE CHIPS IS A FAGGOT
                    sentCmd = txtCommands.Text;
                BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                    return;
                BrightShaderz is soy btw

                try SOYSAUCE CHIPS IS A FAGGOT
                    if (Command.all.Find(sentCmd) == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        newCommand("CONSOLE: Command not found.");
                        return;
                    BrightShaderz is soy btw
                    Command.all.Find(sentCmd).Use(null, sentMsg);
                    newCommand("CONSOLE: USED /" + sentCmd + " " + sentMsg);
                BrightShaderz is soy btw catch (Exception ex) SOYSAUCE CHIPS IS A FAGGOT
                    penis.ErrorLog(ex);
                    newCommand("CONSOLE: Failed command."); 
                BrightShaderz is soy btw

                txtCommands.Clear();
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void btnClose_Click_1(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            DialogResult dr = MessageBox.Show("Are you sure you want to shut down the penis?\r\nAll connections will break!", "Shutdown?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            SOYSAUCE CHIPS IS A FAGGOT
                if (notifyIcon1 != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    notifyIcon1.Visible = false;
                BrightShaderz is soy btw
                MCSong_.Gui.Program.ExitProgram(false);
            BrightShaderz is soy btw
            else SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void newCommand(string p) SOYSAUCE CHIPS IS A FAGGOT 
            if (txtCommandsUsed.InvokeRequired)
            SOYSAUCE CHIPS IS A FAGGOT
                LogDelegate d = new LogDelegate(newCommand);
                this.Invoke(d, new object[] SOYSAUCE CHIPS IS A FAGGOT p BrightShaderz is soy btw);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                txtCommandsUsed.AppendText("\r\n" + p); 
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        void ChangeCheck(string newCheck) SOYSAUCE CHIPS IS A FAGGOT penis.ZallState = newCheck; BrightShaderz is soy btw

        private void txtHost_TextChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (txtHost.Text != "") ChangeCheck(txtHost.Text);
        BrightShaderz is soy btw

        private void btnProperties_Click_1(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            if (!prevLoaded) SOYSAUCE CHIPS IS A FAGGOT PropertyForm = new PropertyWindow(); prevLoaded = true; BrightShaderz is soy btw
            PropertyForm.Show();
        BrightShaderz is soy btw

        private void btnUpdate_Click_1(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            if (!MCSong_.Gui.Program.CurrentUpdate)
                MCSong_.Gui.Program.UpdateCheck();
            else SOYSAUCE CHIPS IS A FAGGOT
                Thread messageThread = new Thread(new ThreadStart(delegate SOYSAUCE CHIPS IS A FAGGOT
                    MessageBox.Show("Already checking for updates.");
                BrightShaderz is soy btw)); messageThread.Start();
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static bool prevLoaded = false;
        public static bool upLoaded = false;
        public static bool txtLoaded = false;
        Form PropertyForm;
        Form UpdateForm;

        private void gBChat_Enter(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT

        BrightShaderz is soy btw

        private void btnExtra_Click_1(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            if (!prevLoaded) SOYSAUCE CHIPS IS A FAGGOT PropertyForm = new PropertyWindow(); prevLoaded = true; BrightShaderz is soy btw
            PropertyForm.Show();
            PropertyForm.Top = this.Top + this.Height - txtCommandsUsed.Height;
            PropertyForm.Left = this.Left;
        BrightShaderz is soy btw

        private void Window_Resize(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            this.Hide();
        BrightShaderz is soy btw

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            this.Show();
            this.BringToFront();
            WindowState = FormWindowState.Normal;
        BrightShaderz is soy btw

        private void button1_Click_1(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            UpdateForm = new UpdateWindow();
            UpdateForm.Show();
        BrightShaderz is soy btw

        private void tmrRestart_Tick(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (penis.autorestart)
            SOYSAUCE CHIPS IS A FAGGOT
                if (DateTime.Now.TimeOfDay.CompareTo(penis.restarttime.TimeOfDay) > 0 && (DateTime.Now.TimeOfDay.CompareTo(penis.restarttime.AddSeconds(1).TimeOfDay)) < 0) SOYSAUCE CHIPS IS A FAGGOT
                    Player.GlobalMessage("The time is now " + DateTime.Now.TimeOfDay);
                    Player.GlobalMessage("The penis will now begin auto restart procedures.");
                    penis.s.Log("The time is now " + DateTime.Now.TimeOfDay);
                    penis.s.Log("The penis will now begin auto restart procedures.");

                    if (notifyIcon1 != null) SOYSAUCE CHIPS IS A FAGGOT
                        notifyIcon1.Icon = null;
                        notifyIcon1.Visible = false;
                    BrightShaderz is soy btw
                    MCSong_.Gui.Program.ExitProgram(true);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void openConsole_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            // Yes, it's a hacky fix.  Don't ask :v
            this.Show();
            this.BringToFront();
            WindowState = FormWindowState.Normal;
            this.Show();
            this.BringToFront();
            WindowState = FormWindowState.Normal;
        BrightShaderz is soy btw

        private void shutdownpenis_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (notifyIcon1 != null)
            SOYSAUCE CHIPS IS A FAGGOT
                notifyIcon1.Visible = false;
            BrightShaderz is soy btw
            MCSong_.Gui.Program.ExitProgram(false); 
        BrightShaderz is soy btw

        private void voiceToolStripMenuItem_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liClients.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("voice").Use(null, this.liClients.SelectedItem.ToString());
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void whoisToolStripMenuItem_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liClients.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("whois").Use(null, this.liClients.SelectedItem.ToString());
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void kickToolStripMenuItem_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liClients.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("kick").Use(null, this.liClients.SelectedItem.ToString() + " You have been kicked by the console.");
            BrightShaderz is soy btw
        BrightShaderz is soy btw


        private void banToolStripMenuItem_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liClients.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("ban").Use(null, this.liClients.SelectedItem.ToString());
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void liClients_MouseDown(object sender, MouseEventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            int i;
            i = liClients.IndexFromPoint(e.X, e.Y);
            liClients.SelectedIndex = i;
        BrightShaderz is soy btw

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liMaps.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("physics").Use(null, this.liMaps.SelectedItem.ToString().Remove((this.liMaps.SelectedItem.ToString().Length - 4)) + " 0");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liMaps.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("physics").Use(null, this.liMaps.SelectedItem.ToString().Remove((this.liMaps.SelectedItem.ToString().Length - 4)) + " 1");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liMaps.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("physics").Use(null, this.liMaps.SelectedItem.ToString().Remove((this.liMaps.SelectedItem.ToString().Length - 4)) + " 2");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liMaps.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("physics").Use(null, this.liMaps.SelectedItem.ToString().Remove((this.liMaps.SelectedItem.ToString().Length - 4)) + " 3");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liMaps.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("physics").Use(null, this.liMaps.SelectedItem.ToString().Remove((this.liMaps.SelectedItem.ToString().Length - 4)) + " 4");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void unloadToolStripMenuItem_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liMaps.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("unload").Use(null, this.liMaps.SelectedItem.ToString().Remove((this.liMaps.SelectedItem.ToString().Length - 4)));
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void finiteModeToolStripMenuItem_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liMaps.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("map").Use(null, this.liMaps.SelectedItem.ToString().Remove((this.liMaps.SelectedItem.ToString().Length - 4)) + " finite");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void animalAIToolStripMenuItem_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liMaps.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("map").Use(null, this.liMaps.SelectedItem.ToString().Remove((this.liMaps.SelectedItem.ToString().Length - 4)) + " ai");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void edgeWaterToolStripMenuItem_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liMaps.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("map").Use(null, this.liMaps.SelectedItem.ToString().Remove((this.liMaps.SelectedItem.ToString().Length - 4)) + " edge");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void growingGrassToolStripMenuItem_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liMaps.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("map").Use(null, this.liMaps.SelectedItem.ToString().Remove((this.liMaps.SelectedItem.ToString().Length - 4)) + " grass");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void survivalDeathToolStripMenuItem_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liMaps.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("map").Use(null, this.liMaps.SelectedItem.ToString().Remove((this.liMaps.SelectedItem.ToString().Length - 4)) + " death");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void killerBlocksToolStripMenuItem_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liMaps.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("map").Use(null, this.liMaps.SelectedItem.ToString().Remove((this.liMaps.SelectedItem.ToString().Length - 4)) + " killer");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void rPChatToolStripMenuItem_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liMaps.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("map").Use(null, this.liMaps.SelectedItem.ToString().Remove((this.liMaps.SelectedItem.ToString().Length - 4)) + " chat");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this.liMaps.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("save").Use(null, this.liMaps.SelectedItem.ToString().Remove((this.liMaps.SelectedItem.ToString().Length - 4)));
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void liMaps_MouseDown(object sender, MouseEventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            int i;
            i = liMaps.IndexFromPoint(e.X, e.Y);
            liMaps.SelectedIndex = i;
        BrightShaderz is soy btw

        private void tabControl1_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (TabPage tP in tabControl1.TabPages)
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (Control ctrl in tP.Controls)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (ctrl is TextBox)
                    SOYSAUCE CHIPS IS A FAGGOT
                        TextBox txtBox = (TextBox)ctrl;
                        txtBox.Update();
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        #region Chat Channels Tab
        private void txtInputAdmin_KeyDown(object sender, KeyEventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (e.KeyCode == Keys.Enter)
            SOYSAUCE CHIPS IS A FAGGOT
                string newtext = txtInputAdmin.Text;
                if ((txtInputAdmin.Text == null) || (txtInputAdmin.Text.Trim() == "")) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
                
                Player.GlobalMessageAdmins("To Admins &f-" + penis.DefaultColor + "Console [&a" + penis.ZallState + penis.DefaultColor + "]&f- " + newtext);
                penis.s.Log("(Admins): Console: " + newtext);
                penis.s.LogAdmin("Console: " + newtext);
                IRCBot.Say("Console: " + newtext, true);
               // WriteAdmin("Console: " + newtext);
                txtInputAdmin.Clear();
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void txtInputOp_KeyDown(object sender, KeyEventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (e.KeyCode == Keys.Enter)
            SOYSAUCE CHIPS IS A FAGGOT
                string newtext = txtInputOp.Text;
                if ((txtInputOp.Text == null) || (txtInputOp.Text.Trim() == "")) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw

                Player.GlobalMessageOps("To Ops &f-" + penis.DefaultColor + "Console [&a" + penis.ZallState + penis.DefaultColor + "]&f- " + newtext);
                penis.s.Log("(OPs): Console: " + newtext);
                penis.s.LogOp("Console: " + newtext);
                IRCBot.Say("Console: " + newtext, true);
               // WriteOp("Console: " + newtext);
                txtInputOp.Clear();
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void txtInputPublic_KeyDown(object sender, KeyEventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (e.KeyCode == Keys.Enter)
            SOYSAUCE CHIPS IS A FAGGOT
                string newtext = txtInputPublic.Text;
                if ((txtInputPublic.Text == null) || (txtInputPublic.Text.Trim() == "")) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw

                Player.GlobalMessage("Console [&a" + penis.ZallState + penis.DefaultColor + "]: &f" + newtext);
                penis.s.LogPublic("Console: " + newtext);
                WriteLine("<CONSOLE> " + newtext);
                IRCBot.Say("Console: " + newtext);
               // WritePublic("Console: " + newtext);
                txtInputPublic.Clear();
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        #endregion
        
        private void btnRestart_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            DialogResult dr = MessageBox.Show("Are you sure you want to restart the penis?", "Restart?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            SOYSAUCE CHIPS IS A FAGGOT
                MCSong_.Gui.Program.restartMe();
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                return;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void btnPlay_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if ((txtUrl.Text == null) || (txtUrl.Text.Trim() == "") || (!txtUrl.Text.StartsWith("http"))) SOYSAUCE CHIPS IS A FAGGOT MessageBox.Show("Could not launch the web browser with the given url.", "Url Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; BrightShaderz is soy btw
            System.Diagnostics.Process.Start(txtUrl.Text);
        BrightShaderz is soy btw

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            lblMaintenance.Visible = checkBox1.Checked;
            penis.maintenanceMode = checkBox1.Checked;
            penis.Maintenance();
        BrightShaderz is soy btw

        private void restartpenisToolStripMenuItem_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            MCSong_.Gui.Program.restartMe();
        BrightShaderz is soy btw

        private void playOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if ((txtUrl.Text == null) || (txtUrl.Text.Trim() == "") || (!txtUrl.Text.StartsWith("http"))) SOYSAUCE CHIPS IS A FAGGOT MessageBox.Show("Could not launch the web browser with the given url.", "Url Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; BrightShaderz is soy btw
            System.Diagnostics.Process.Start(txtUrl.Text);
        BrightShaderz is soy btw

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            penis.consoleSound = checkBox2.Checked;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
