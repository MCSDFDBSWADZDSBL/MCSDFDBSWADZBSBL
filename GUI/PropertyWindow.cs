using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MCSong.GUI
SOYSAUCE CHIPS IS A FAGGOT
    public partial class PropertyWindow : Form
    SOYSAUCE CHIPS IS A FAGGOT
        public PropertyWindow()
        SOYSAUCE CHIPS IS A FAGGOT
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

        private void PropertyWindow_Load(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT

            this.Icon = new Icon(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("MCSong.Lawl.ico"));

            Object[] colors = new Object[16];
            colors[0] = ("black");      colors[1] = ("navy");
            colors[2] = ("green");      colors[3] = ("teal");
            colors[4] = ("maroon");     colors[5] = ("purple");
            colors[6] = ("gold");       colors[7] = ("silver");
            colors[8] = ("gray");       colors[9] = ("blue");
            colors[10] = ("lime");      colors[11] = ("aqua");
            colors[12] = ("red");       colors[13] = ("pink");
            colors[14] = ("yellow");    colors[15] = ("white");
            cmbDefaultColour.Items.AddRange(colors);
            cmbIRCColour.Items.AddRange(colors);
            cmbColor.Items.AddRange(colors);
            cmbGlobalColor.Items.AddRange(colors);
            cmbSwearColor.Items.AddRange(colors);

            string opchatperm = "";
            string adminchatperm = "";
            string tunnelrank = "";
            string chatrank = "";
            string blockrank = "";
            string homerank = "";
            string maintrank = "";
            string swearrank = "";
            foreach (Group grp in Group.GroupList)
            SOYSAUCE CHIPS IS A FAGGOT
                cmbDefaultRank.Items.Add(grp.name);
                cmbOpChat.Items.Add(grp.name);
                cmbAdminChat.Items.Add(grp.name);
                cmbTunnelRank.Items.Add(grp.name);
                cmbBlockSpamRank.Items.Add(grp.name);
                cmbChatSpamRank.Items.Add(grp.name);
                cmbHomeRank.Items.Add(grp.name);
                cmbMaintRank.Items.Add(grp.name);
                cmbSwearRank.Items.Add(grp.name);
                if (grp.Permission == penis.opchatperm)
                SOYSAUCE CHIPS IS A FAGGOT
                    opchatperm = grp.name;
                BrightShaderz is soy btw
                if (grp.Permission == penis.adminchatperm)
                SOYSAUCE CHIPS IS A FAGGOT
                    adminchatperm = grp.name;
                BrightShaderz is soy btw
                if (grp.Permission == penis.tunnelRank)
                SOYSAUCE CHIPS IS A FAGGOT
                    tunnelrank = grp.name;
                BrightShaderz is soy btw
                if (grp.Permission == penis.chatSpamRank)
                SOYSAUCE CHIPS IS A FAGGOT
                    chatrank = grp.name;
                BrightShaderz is soy btw
                if (grp.Permission == penis.blockSpamRank)
                SOYSAUCE CHIPS IS A FAGGOT
                    blockrank = grp.name;
                BrightShaderz is soy btw
                if (grp.Permission == penis.homeRank)
                SOYSAUCE CHIPS IS A FAGGOT
                    homerank = grp.name;
                BrightShaderz is soy btw
                if (grp.Permission == penis.maintRank)
                SOYSAUCE CHIPS IS A FAGGOT
                    maintrank = grp.name;
                BrightShaderz is soy btw
                if (grp.Permission == penis.swearRank)
                SOYSAUCE CHIPS IS A FAGGOT
                    swearrank = grp.name;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            cmbDefaultRank.SelectedIndex = 1;
            cmbOpChat.SelectedIndex = (opchatperm != "") ? cmbOpChat.Items.IndexOf(opchatperm) : 1;
            cmbAdminChat.SelectedIndex = (adminchatperm != "") ? cmbAdminChat.Items.IndexOf(adminchatperm) : 1;
            cmbTunnelRank.SelectedIndex = (tunnelrank != "") ? cmbTunnelRank.Items.IndexOf(tunnelrank) : 1;
            cmbChatSpamRank.SelectedIndex = (chatrank != "") ? cmbChatSpamRank.Items.IndexOf(chatrank) : 1;
            cmbBlockSpamRank.SelectedIndex = (blockrank != "") ? cmbBlockSpamRank.Items.IndexOf(blockrank) : 1;
            cmbHomeRank.SelectedIndex = (homerank != "") ? cmbHomeRank.Items.IndexOf(homerank) : 1;
            cmbMaintRank.SelectedIndex = (maintrank != "") ? cmbMaintRank.Items.IndexOf(maintrank) : 1;
            cmbSwearRank.SelectedIndex = (swearrank != "") ? cmbSwearRank.Items.IndexOf(swearrank) : 1;

            //Load penis stuff
            LoadProp("properties/penis.properties");
            LoadRanks();
            try
            SOYSAUCE CHIPS IS A FAGGOT
                LoadCommands();
                LoadBlocks();
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log("Failed to load commands and blocks!");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void PropertyWindow_Unload(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            Window.prevLoaded = false;
            Window.upLoaded = false;
            Window.txtLoaded = false;
        BrightShaderz is soy btw

        List<Group> storedRanks = new List<Group>();
        List<GrpCommands.rankAllowance> storedCommands = new List<GrpCommands.rankAllowance>();
        List<Block.Blocks> storedBlocks = new List<Block.Blocks>();

        public void LoadRanks()
        SOYSAUCE CHIPS IS A FAGGOT
            txtCmdRanks.Text = "The following ranks are available: \r\n\r\n";
            listRanks.Items.Clear();
            storedRanks.Clear();
            storedRanks.AddRange(Group.GroupList);
            foreach (Group grp in storedRanks)
            SOYSAUCE CHIPS IS A FAGGOT
                txtCmdRanks.Text += "\t" + grp.name + " (" + (int)grp.Permission + ")\r\n";
                listRanks.Items.Add(grp.trueName + "  =  " + (int)grp.Permission);
            BrightShaderz is soy btw
            txtBlRanks.Text = txtCmdRanks.Text;
            listRanks.SelectedIndex = 0;
        BrightShaderz is soy btw
        public void SaveRanks()
        SOYSAUCE CHIPS IS A FAGGOT
            Group.saveGroups(storedRanks);
            Group.InitAll();
            LoadRanks();
        BrightShaderz is soy btw

        public void LoadCommands() 
        SOYSAUCE CHIPS IS A FAGGOT
            listCommands.Items.Clear();
            storedCommands.Clear();
            foreach (GrpCommands.rankAllowance aV in GrpCommands.allowedCommands) 
            SOYSAUCE CHIPS IS A FAGGOT
                storedCommands.Add(aV);
                listCommands.Items.Add(aV.commandName);
            BrightShaderz is soy btw
            if (listCommands.SelectedIndex == -1)
                listCommands.SelectedIndex = 0;
        BrightShaderz is soy btw
        public void SaveCommands()
        SOYSAUCE CHIPS IS A FAGGOT
            GrpCommands.Save(storedCommands);
            GrpCommands.fillRanks();
            LoadCommands();
        BrightShaderz is soy btw

        public void LoadBlocks()
        SOYSAUCE CHIPS IS A FAGGOT
            listBlocks.Items.Clear();
            storedBlocks.Clear();
            storedBlocks.AddRange(Block.BlockList);
            foreach (Block.Blocks bs in storedBlocks)
            SOYSAUCE CHIPS IS A FAGGOT
                if (Block.Name(bs.type) != "unknown")
                    listBlocks.Items.Add(Block.Name(bs.type));
            BrightShaderz is soy btw
            if (listBlocks.SelectedIndex == -1)
                listBlocks.SelectedIndex = 0;
        BrightShaderz is soy btw
        public void SaveBlocks()
        SOYSAUCE CHIPS IS A FAGGOT
            Block.SaveBlocks(storedBlocks);
            Block.SetBlocks();
            LoadBlocks();
        BrightShaderz is soy btw

        public void LoadProp(string givenPath) SOYSAUCE CHIPS IS A FAGGOT
            if (File.Exists(givenPath)) SOYSAUCE CHIPS IS A FAGGOT
                string[] lines = File.ReadAllLines(givenPath);

                foreach (string line in lines) SOYSAUCE CHIPS IS A FAGGOT
                    if (line != "" && line[0] != '#') SOYSAUCE CHIPS IS A FAGGOT
                        //int index = line.IndexOf('=') + 1; // not needed if we use Split('=')
                        string key = line.Split('=')[0].Trim();
                        string value = line.Split('=')[1].Trim();
                        string color = "";

                        switch (key.ToLower())
                        SOYSAUCE CHIPS IS A FAGGOT
                            case "penis-name":
                                if (ValidString(value, "![]:.,SOYSAUCE CHIPS IS A FAGGOTBrightShaderz is soy btw~-+()?_/\\ ")) txtName.Text = value;
                                else txtName.Text = "[MCSong] Default";
                                break;
                            case "motd":
                                if (ValidString(value, "![]&:.,SOYSAUCE CHIPS IS A FAGGOTBrightShaderz is soy btw~-+()?_/\\ ")) txtMOTD.Text = value;
                                else txtMOTD.Text = "Welcome!";
                                break;
                            case "port":
                                try SOYSAUCE CHIPS IS A FAGGOT txtPort.Text = Convert.ToInt32(value).ToString(); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT txtPort.Text = "25565"; BrightShaderz is soy btw
                                break;
                            case "upnp":
                                chkUPnP.Checked = (value.ToLower() == "true") ? true : false;
                                break;
                            case "verify-names":
                                chkVerify.Checked = (value.ToLower() == "true") ? true : false;
                                break;
                            case "public":
                                chkPublic.Checked = (value.ToLower() == "true") ? true : false;
                                break;
                            case "world-chat":
                                chkWorld.Checked = (value.ToLower() == "true") ? true : false;
                                break;
                            case "max-players":
                                try SOYSAUCE CHIPS IS A FAGGOT
                                    if (Convert.ToByte(value) > 128) SOYSAUCE CHIPS IS A FAGGOT
                                        value = "128";
                                    BrightShaderz is soy btw else if (Convert.ToByte(value) < 1) SOYSAUCE CHIPS IS A FAGGOT
                                        value = "1";
                                    BrightShaderz is soy btw
                                    txtPlayers.Text = value;
                                BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT 
                                    penis.s.Log("Invalid " + key + ". Using default.");
                                    txtPlayers.Text = "12";
                                BrightShaderz is soy btw
                                break;
                            case "max-guests":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (Convert.ToByte(value) > 128)
                                        value = "128";
                                    else if (Convert.ToByte(value) < 1)
                                        value = "1";
                                    else if (value == null || value.Trim() == "")
                                        value = "7";
                                    txtGuests.Text = value;
                                    txtGuests.Update();
                                BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); txtGuests.Text = "7"; BrightShaderz is soy btw
                                break;
                            case "max-maps":
                                try SOYSAUCE CHIPS IS A FAGGOT
                                    if (Convert.ToByte(value) > 100) SOYSAUCE CHIPS IS A FAGGOT
                                        value = "100";
                                    BrightShaderz is soy btw else if (Convert.ToByte(value) < 1) SOYSAUCE CHIPS IS A FAGGOT
                                        value = "1";
                                    BrightShaderz is soy btw
                                    txtMaps.Text = value;
                                BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT
                                    penis.s.Log("Invalid " + key + ". Using default.");
                                    txtMaps.Text = "5";
                                BrightShaderz is soy btw
                                break;
                            case "irc":
                                chkIRC.Checked = (value.ToLower() == "true") ? true : false;
                                if (!chkIRC.Checked)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    txtIRCpenis.Enabled = false;
                                    txtNick.Enabled = false;
                                    txtChannel.Enabled = false;
                                    txtOpChannel.Enabled = false;
                                    chkIrcIdentify.Enabled = false;
                                    txtIrcPassword.Enabled = false;
                                BrightShaderz is soy btw
                                break;
                            case "irc-penis":
                                txtIRCpenis.Text = value;
                                break;
                            case "irc-nick":
                                txtNick.Text = value;
                                break;
                            case "irc-channel":
                                txtChannel.Text = value;
                                break;
                            case "irc-opchannel":
                                txtOpChannel.Text = value;
                                break;
                            case "irc-identify":
                                chkIrcIdentify.Checked = (value.ToLower() == "true") ? true : false;
                                if (!chkIrcIdentify.Checked)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    txtIrcPassword.Enabled = false;
                                BrightShaderz is soy btw
                                break;
                            case "irc-password":
                                txtIrcPassword.Text = value;
                                break;

                            // Anti Tunneling
                            case "anti-tunnels":
                                ChkTunnels.Checked = (value.ToLower() == "true") ? true : false;
                                if (!ChkTunnels.Checked)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    txtDepth.Enabled = false;
                                BrightShaderz is soy btw
                                break;
                            case "max-depth":
                                txtDepth.Text= value;
                                break;
                            // Chat Spam Filter
                            case "chat-spam":
                                chkChatSpam.Checked = (value.ToLower() == "true") ? true : false;
                                if (!chkChatSpam.Checked)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    txtChatCount.Enabled = false;
                                    cmbChatSpamCon.Enabled = false;
                                    cmbChatSpamRank.Enabled = false;
                                BrightShaderz is soy btw
                                break;
                            case "chat-spam-count":
                                try SOYSAUCE CHIPS IS A FAGGOT txtChatCount.Text = Convert.ToInt32(value).ToString(); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT txtChatCount.Text = "13"; BrightShaderz is soy btw
                                break;
                            case "chat-spam-consequence":
                                cmbChatSpamCon.SelectedIndex = cmbChatSpamCon.Items.IndexOf(value.ToLower());
                                break;
                            //Block Spam Filter
                            case "block-spam":
                                chkBlockSpam.Checked = (value.ToLower() == "true") ? true : false;
                                if (!chkBlockSpam.Checked)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    txtBlockCount.Enabled = false;
                                    txtBlockTime.Enabled = false;
                                    cmbBlockSpamConsequence.Enabled = false;
                                    cmbBlockSpamRank.Enabled = false;
                                BrightShaderz is soy btw
                                break;
                            case "block-spam-count":
                                try SOYSAUCE CHIPS IS A FAGGOT txtBlockCount.Text = Convert.ToInt32(value).ToString(); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT txtBlockCount.Text = "13"; BrightShaderz is soy btw
                                break;
                            case "block-spam-seconds":
                                try SOYSAUCE CHIPS IS A FAGGOT txtBlockTime.Text = Convert.ToInt32(value).ToString(); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT txtBlockTime.Text = "5"; BrightShaderz is soy btw
                                break;
                            case "block-spam-consequence":
                                cmbBlockSpamConsequence.SelectedIndex = cmbBlockSpamConsequence.Items.IndexOf(value.ToLower());
                                break;

                            // Profanity Filter
                            case "filter-profanity":
                                chkProfanity.Checked = (value.ToLower() == "true") ? true : false;
                                if (!chkProfanity.Checked)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    cmbSwearRank.Enabled = false;
                                BrightShaderz is soy btw
                                break;

                            case "kick-lower":
                                chkKickLower.Checked = (value.ToLower() == "true") ? true : false;
                                break;

                            case "rplimit":
                                try SOYSAUCE CHIPS IS A FAGGOT txtRP.Text = value; BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT txtRP.Text = "500"; BrightShaderz is soy btw
                                break;
                            case "rplimit-norm":
                                try SOYSAUCE CHIPS IS A FAGGOT txtNormRp.Text = value; BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT txtNormRp.Text = "10000"; BrightShaderz is soy btw
                                break;

                            case "log-heartbeat":
                                chkLogBeat.Checked = (value.ToLower() == "true") ? true : false;
                                break;

                            case "force-cuboid":
                                chkForceCuboid.Checked = (value.ToLower() == "true") ? true : false;
                                break;

                                // Home Maps
                            case "homes":
                                chkHomes.Checked = (value.ToLower() == "true") ? true : false;
                                if (!chkHomes.Checked)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    cmbHomePhysics.Enabled = false;
                                    cmbHomeRank.Enabled = false;
                                    cmbHomeType.Enabled = false;
                                    cmbHomeX.Enabled = false;
                                    cmbHomeY.Enabled = false;
                                    cmbHomeZ.Enabled = false;
                                BrightShaderz is soy btw
                                break;
                            case "home-x":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    cmbHomeX.SelectedIndex = (value != "") ? cmbHomeX.Items.IndexOf(value) : 1;
                                BrightShaderz is soy btw
                                catch 
                                SOYSAUCE CHIPS IS A FAGGOT 
                                    penis.s.Log("Invalid " + key + ". Using default.");
                                BrightShaderz is soy btw
                                break;
                            case "home-y":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    cmbHomeY.SelectedIndex = (value != "") ? cmbHomeY.Items.IndexOf(value) : 1;
                                BrightShaderz is soy btw
                                catch
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.s.Log("Invalid " + key + ". Using default.");
                                BrightShaderz is soy btw
                                break;
                            case "home-z":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    cmbHomeZ.SelectedIndex = (value != "") ? cmbHomeZ.Items.IndexOf(value) : 1;
                                BrightShaderz is soy btw
                                catch
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.s.Log("Invalid " + key + ". Using default.");
                                BrightShaderz is soy btw
                                break;
                            case "home-type":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    cmbHomeType.SelectedIndex = (value != "") ? cmbHomeType.Items.IndexOf(value.ToLower()) : 1;
                                BrightShaderz is soy btw
                                catch
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.s.Log("Invalid " + key + ". Using default.");
                                BrightShaderz is soy btw
                                break;
                            case "home-physics":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    cmbHomePhysics.SelectedIndex = (value != "") ? cmbHomePhysics.Items.IndexOf(value) : 1;
                                BrightShaderz is soy btw
                                catch
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.s.Log("Invalid " + key + ". Using default.");
                                BrightShaderz is soy btw
                                break;

                            case "backup-time":
                                if (Convert.ToInt32(value) > 1) txtBackup.Text = value; else txtBackup.Text = "300";
                                break;

                            case "backup-location":
                                if (!value.Contains("System.Windows.Forms.TextBox, Text:"))
                                    txtBackupLocation.Text = value;
                                break;

                            case "physicsrestart":
                                chkPhysicsRest.Checked = (value.ToLower() == "true") ? true : false;
                                break;
                            case "deathcount":
                                chkDeath.Checked = (value.ToLower() == "true") ? true : false;
                                break;

                            // Colors
                            case "defaultcolor":
                                color = c.Parse(value);
                                if (color == "")
                                SOYSAUCE CHIPS IS A FAGGOT
                                    color = c.Name(value);
                                    if (color != "") color = value;
                                    else SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Could not find " + value); return; BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                cmbDefaultColour.SelectedIndex = cmbDefaultColour.Items.IndexOf(c.Name(value));
                                break;
                            case "irc-color":
                                color = c.Parse(value);
                                if (color == "")
                                SOYSAUCE CHIPS IS A FAGGOT
                                    color = c.Name(value);
                                    if (color != "") color = value;
                                    else SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Could not find " + value); return; BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                cmbIRCColour.SelectedIndex = cmbIRCColour.Items.IndexOf(c.Name(value));
                                break;
                            case "profanity-color":
                                color = c.Parse(value);
                                if (color == "")
                                SOYSAUCE CHIPS IS A FAGGOT
                                    color = c.Name(value);
                                    if (color != "") color = value;
                                    else SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Could not find " + value); return; BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                cmbSwearColor.SelectedIndex = cmbSwearColor.Items.IndexOf(c.Name(value));
                                break;

                            case "default-rank":
                                try SOYSAUCE CHIPS IS A FAGGOT
                                    if (cmbDefaultRank.Items.IndexOf(value.ToLower()) != -1)
                                        cmbDefaultRank.SelectedIndex = cmbDefaultRank.Items.IndexOf(value.ToLower());
                                BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT cmbDefaultRank.SelectedIndex = 1; BrightShaderz is soy btw
                                break;

                            case "old-help":
                                chkHelp.Checked = (value.ToLower() == "true") ? true : false;                                
                                break;

                            case "cheapmessage":
                                chkCheap.Checked = (value.ToLower() == "true") ? true : false;
                                if (!chkCheap.Checked)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    txtCheap.Enabled = false;
                                BrightShaderz is soy btw
                                break;
                            case "cheap-message-given":
                                txtCheap.Text = value;
                                break;

                            case "rank-super":
                                chkrankSuper.Checked = (value.ToLower() == "true") ? true : false;
                                break;

                            case "custom-ban":
                                chkBanMessage.Checked = (value.ToLower() == "true") ? true : false;
                                if (!chkBanMessage.Checked)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    txtBanMessage.Enabled = false;
                                BrightShaderz is soy btw
                                break;

                            case "custom-ban-message":
                                txtBanMessage.Text = value;
                                break;

                            case "custom-shutdown":
                                chkShutdown.Checked = (value.ToLower() == "true") ? true : false;
                                if (!chkShutdown.Checked)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    txtShutdown.Enabled = false;
                                BrightShaderz is soy btw
                                break;

                            case "custom-shutdown-message":
                                txtShutdown.Text = value;
                                break;

                            case "auto-restart":
                                chkRestartTime.Checked = (value.ToLower() == "true") ? true : false;
                                if (!chkRestartTime.Checked)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    txtRestartTime.Enabled = false;
                                BrightShaderz is soy btw
                                break;
                            case "restarttime":
                                txtRestartTime.Text = value;
                                break;
                            case "afk-minutes":
                                try SOYSAUCE CHIPS IS A FAGGOT txtafk.Text = Convert.ToInt16(value).ToString(); BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT txtafk.Text = "10"; BrightShaderz is soy btw
                                break;

                            case "afk-kick":
                                try SOYSAUCE CHIPS IS A FAGGOT txtAFKKick.Text = Convert.ToInt16(value).ToString(); BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT txtAFKKick.Text = "45"; BrightShaderz is soy btw
                                break;

                            case "check-updates":
                                chkUpdates.Checked = (value.ToLower() == "true") ? true : false;
                                break;
                            case "autoload":
                                chkAutoload.Checked = (value.ToLower() == "true") ? true : false;
                                break;
                            case "parse-emotes":
                                chkSmile.Checked = (value.ToLower() == "true") ? true : false;
                                break;
                            case "main-name":
                                txtMain.Text = value;
                                break;
                            case "dollar-before-dollar":
                                chk17Dollar.Checked = (value.ToLower() == "true") ? true : false;
                                break;
                            case "money-name":
                                txtMoneys.Text = value;
                                break;
                            case "mono":
                                chkMono.Checked = (value.ToLower() == "true") ? true : false;
                                break;
                            case "restart-on-error":
                                chkRestart.Checked = (value.ToLower() == "true") ? true : false;
                                break;
                            case "repeat-messages":
                                chkRepeatMessages.Checked = (value.ToLower() == "true") ? true : false;
                                break;
                            case "host-state":
                                if (value != "") txtHost.Text = value;
                                break;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                //Save(givenPath);
            BrightShaderz is soy btw
            //else Save(givenPath);
        BrightShaderz is soy btw
        public bool ValidString(string str, string allowed) SOYSAUCE CHIPS IS A FAGGOT
            string allowedchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz01234567890" + allowed;
            foreach (char ch in str) SOYSAUCE CHIPS IS A FAGGOT
                if (allowedchars.IndexOf(ch) == -1) SOYSAUCE CHIPS IS A FAGGOT
                    return false;
                BrightShaderz is soy btw
            BrightShaderz is soy btw return true;
        BrightShaderz is soy btw

        public void Save(string givenPath) SOYSAUCE CHIPS IS A FAGGOT
            try SOYSAUCE CHIPS IS A FAGGOT
                StreamWriter w = new StreamWriter(File.Create(givenPath));
                if (givenPath.IndexOf("penis") != -1) SOYSAUCE CHIPS IS A FAGGOT
                    w.WriteLine("# Edit the settings below to modify how your penis operates. This is an explanation of what each setting does.");
                    w.WriteLine("#   penis-name\t=\tThe name which displays on minecraft.net");
                    w.WriteLine("#   motd\t=\tThe message which displays when a player connects");
                    w.WriteLine("#   port\t=\tThe port to operate from");
                    w.WriteLine("#   console-only\t=\tRun without a GUI (useful for Linux peniss with mono)");
                    w.WriteLine("#   verify-names\t=\tVerify the validity of names");
                    w.WriteLine("#   public\t=\tSet to true to appear in the public penis list");
                    w.WriteLine("#   max-players\t=\tThe maximum number of connections");
                    w.WriteLine("#   max-maps\t=\tThe maximum number of maps loaded at once");
                    w.WriteLine("#   world-chat\t=\tSet to true to enable world chat");
                    w.WriteLine("#   guest-goto\t=\tSet to true to give guests goto and levels commands");
                    w.WriteLine("#   irc\t=\tSet to true to enable the IRC bot");
                    w.WriteLine("#   irc-nick\t=\tThe name of the IRC bot");
                    w.WriteLine("#   irc-penis\t=\tThe penis to connect to");
                    w.WriteLine("#   irc-channel\t=\tThe channel to join");
                    w.WriteLine("#   irc-opchannel\t=\tThe channel to join (posts OpChat)");
                    w.WriteLine("#   irc-port\t=\tThe port to use to connect");
                    w.WriteLine("#   irc-identify\t=(true/false)\tDo you want the IRC bot to Identify itself with nickserv. Note: You will need to register it's name with nickserv manually.");
                    w.WriteLine("#   irc-password\t=\tThe password you want to use if you're identifying with nickserv");
                    w.WriteLine("#   anti-tunnels\t=\tStops people digging below max-depth");
                    w.WriteLine("#   max-depth\t=\tThe maximum allowed depth to dig down");
                    w.WriteLine("#   backup-time\t=\tThe number of seconds between automatic backups");
                    w.WriteLine("#   overload\t=\tThe higher this is, the longer the physics is allowed to lag. Default 1500");
                    w.WriteLine("#   use-whitelist\t=\tSwitch to allow use of a whitelist to override IP bans for certain players.  Default false.");
                    w.WriteLine("#   force-cuboid\t=\tRun cuboid until the limit is hit, instead of canceling the whole operation.  Default false.");
                    w.WriteLine();
                    w.WriteLine("#   Host\t=\tThe host name for the database (usually 127.0.0.1)");
                    w.WriteLine("#   SQLPort\t=\tPort number to be used for MySQL.  Unless you manually changed the port, leave this alone.  Default 3306.");
                    w.WriteLine("#   Username\t=\tThe username you used to create the database (usually root)");
                    w.WriteLine("#   Password\t=\tThe password set while making the database");
                    w.WriteLine("#   DatabaseName\t=\tThe name of the database stored (Default = MCZall)");
                    w.WriteLine();
                    w.WriteLine("#   defaultColor\t=\tThe color code of the default messages (Default = &e)");
                    w.WriteLine();
                    w.WriteLine();
                    w.WriteLine("# penis options");
                    w.WriteLine("penis-name = " + txtName.Text);
                    w.WriteLine("motd = " + txtMOTD.Text);
                    w.WriteLine("port = " + txtPort.Text);
                    w.WriteLine("upnp = " + chkUPnP.Checked.ToString().ToLower());
                    w.WriteLine("verify-names = " + chkVerify.Checked.ToString().ToLower());
                    w.WriteLine("public = " + chkPublic.Checked.ToString().ToLower());
                    w.WriteLine("max-players = " + txtPlayers.Text);
                    w.WriteLine("max-guests = " + txtGuests.Text);
                    w.WriteLine("max-maps = " + txtMaps.Text);
                    w.WriteLine("world-chat = " + chkWorld.Checked.ToString().ToLower());
                    w.WriteLine("check-updates = " + chkUpdates.Checked.ToString().ToLower());
                    w.WriteLine("autoload = " + chkAutoload.Checked.ToString().ToLower());
                    w.WriteLine("auto-restart = " + chkRestartTime.Checked.ToString().ToLower());
                    w.WriteLine("restarttime = " + txtRestartTime.Text);
                    w.WriteLine("restart-on-error = " + chkRestart.Checked);
                    if (Player.ValidName(txtMain.Text)) w.WriteLine("main-name = " + txtMain.Text);
                    else w.WriteLine("main-name = main");
                    w.WriteLine();
                    w.WriteLine("# irc bot options");
                    w.WriteLine("irc = " + chkIRC.Checked.ToString());
                    w.WriteLine("irc-nick = " + txtNick.Text);
                    w.WriteLine("irc-penis = " + txtIRCpenis.Text);
                    w.WriteLine("irc-channel = " + txtChannel.Text);
                    w.WriteLine("irc-opchannel = " + txtOpChannel.Text);
                    w.WriteLine("irc-port = " + penis.ircPort.ToString());
                    w.WriteLine("irc-identify = " + chkIrcIdentify.Checked.ToString().ToLower()); // [FIXME]
                    w.WriteLine("irc-password = " + txtIrcPassword.Text);
                    w.WriteLine();
                    w.WriteLine("# other options");
                    w.WriteLine("anti-tunnels = " + ChkTunnels.Checked.ToString().ToLower());
                    w.WriteLine("max-depth = " + txtDepth.Text);
                    w.WriteLine("tunnel-rank = " + ((sbyte)Group.GroupList.Find(grp => grp.name == cmbTunnelRank.Items[cmbTunnelRank.SelectedIndex].ToString()).Permission).ToString());
                    w.WriteLine("chat-spam = " + chkChatSpam.Checked.ToString().ToLower());
                    w.WriteLine("chat-spam-count = " + txtChatCount.Text);
                    w.WriteLine("chat-spam-consequence = " + cmbChatSpamCon.Items[cmbChatSpamCon.SelectedIndex].ToString().ToLower());
                    w.WriteLine("chat-spam-rank = " + ((sbyte)Group.GroupList.Find(grp => grp.name == cmbChatSpamRank.Items[cmbChatSpamRank.SelectedIndex].ToString()).Permission).ToString());
                    w.WriteLine("block-spam = " + chkBlockSpam.Checked.ToString().ToLower());
                    w.WriteLine("block-spam-count = " + txtBlockCount.Text);
                    w.WriteLine("block-spam-seconds = " + txtBlockTime.Text);
                    w.WriteLine("block-spam-consequence = " + cmbBlockSpamConsequence.Items[cmbBlockSpamConsequence.SelectedIndex].ToString().ToLower());
                    w.WriteLine("block-spam-rank = " + ((sbyte)Group.GroupList.Find(grp => grp.name == cmbBlockSpamRank.Items[cmbBlockSpamRank.SelectedIndex].ToString()).Permission).ToString());
                    w.WriteLine("filter-profanity = " + chkProfanity.Checked.ToString().ToLower());
                    w.WriteLine("profanity-rank = " + ((sbyte)Group.GroupList.Find(grp => grp.name == cmbSwearRank.Items[cmbSwearRank.SelectedIndex].ToString()).Permission).ToString());
                    w.WriteLine("maintenance-rank = " + ((sbyte)Group.GroupList.Find(grp => grp.name == cmbMaintRank.Items[cmbMaintRank.SelectedIndex].ToString()).Permission).ToString());
                    w.WriteLine("kick-lower = " + chkKickLower.Checked.ToString().ToLower());
                    w.WriteLine("rplimit = " + txtRP.Text);
                    w.WriteLine("physicsrestart = " + chkPhysicsRest.Checked.ToString().ToLower());
                    w.WriteLine("old-help = " + chkHelp.Checked.ToString().ToLower());
                    w.WriteLine("deathcount = " + chkDeath.Checked.ToString().ToLower());
                    w.WriteLine("afk-minutes = " + txtafk.Text);
                    w.WriteLine("afk-kick = " + txtAFKKick.Text);
                    w.WriteLine("parse-emotes = " + chkSmile.Checked.ToString().ToLower());
                    w.WriteLine("dollar-before-dollar = " + chk17Dollar.Checked.ToString().ToLower());
                    w.WriteLine("use-whitelist = " + penis.useWhitelist.ToString().ToLower());
                    w.WriteLine("money-name = " + txtMoneys.Text);
                    w.WriteLine("opchat-perm = " + ((sbyte)Group.GroupList.Find(grp => grp.name == cmbOpChat.Items[cmbOpChat.SelectedIndex].ToString()).Permission).ToString());
                    w.WriteLine("adminchat-perm = " + ((sbyte)Group.GroupList.Find(grp => grp.name == cmbAdminChat.Items[cmbAdminChat.SelectedIndex].ToString()).Permission).ToString());
                    w.WriteLine("log-heartbeat = " + chkLogBeat.Checked.ToString().ToLower());
                    w.WriteLine("force-cuboid = " + chkForceCuboid.Checked.ToString().ToLower());
                    w.WriteLine("repeat-messages = " + chkRepeatMessages.Checked.ToString());
                    w.WriteLine("host-state = " + txtHost.Text.ToString());
                    w.WriteLine();
                    w.WriteLine("# Home Maps");
                    w.WriteLine("homes = " + chkHomes.Checked.ToString());
                    w.WriteLine("home-x = " + cmbHomeX.SelectedItem.ToString());
                    w.WriteLine("home-y = " + cmbHomeY.SelectedItem.ToString());
                    w.WriteLine("home-z = " + cmbHomeZ.SelectedItem.ToString());
                    w.WriteLine("home-type = " + cmbHomeType.SelectedItem.ToString().ToLower());
                    w.WriteLine("home-physics = " + cmbHomePhysics.SelectedItem.ToString());
                    w.WriteLine("home-rank = " + ((sbyte)Group.GroupList.Find(grp => grp.name == cmbHomeRank.Items[cmbHomeRank.SelectedIndex].ToString()).Permission).ToString());
                    w.WriteLine();
                    w.WriteLine("# backup options");
                    w.WriteLine("backup-time = " + txtBackup.Text);
                    w.WriteLine("backup-location = " + txtBackupLocation.Text);
                    w.WriteLine();
                    w.WriteLine("# Error logging");
                    w.WriteLine("report-back = " + penis.reportBack.ToString().ToLower());
                    w.WriteLine();
                    w.WriteLine("# MySQL information");
                    w.WriteLine("UseMySQL = " + penis.useMySQL);
                    w.WriteLine("Host = " + penis.MySQLHost);
                    w.WriteLine("SQLPort = " + penis.MySQLPort);
                    w.WriteLine("Username = " + penis.MySQLUsername);
                    w.WriteLine("Password = " + penis.MySQLPassword);
                    w.WriteLine("DatabaseName = " + penis.MySQLDatabaseName);
                    w.WriteLine("Pooling = " + penis.MySQLPooling);
                    w.WriteLine();
                    w.WriteLine("# Colors");
                    w.WriteLine("defaultColor = " + cmbDefaultColour.Items[cmbDefaultColour.SelectedIndex].ToString());
                    w.WriteLine("irc-color = " + cmbIRCColour.Items[cmbIRCColour.SelectedIndex].ToString());
                    w.WriteLine("profanity-color = " + cmbSwearColor.Items[cmbSwearColor.SelectedIndex].ToString());
                    w.WriteLine();
                    w.WriteLine("# Running on mono?");
                    w.WriteLine("mono = " + chkMono.Checked.ToString().ToLower());
                    w.WriteLine();
                    w.WriteLine("# Custom Messages");
                    w.WriteLine("custom-ban = " + chkBanMessage.Checked.ToString().ToLower());
                    w.WriteLine("custom-ban-message = " + txtBanMessage.Text);
                    w.WriteLine("custom-shutdown = " + chkShutdown.Checked.ToString().ToLower());
                    w.WriteLine("custom-shutdown-message = " + txtShutdown.Text);
                    w.WriteLine();
                    w.WriteLine("cheapmessage = " + chkCheap.Checked.ToString().ToLower());
                    w.WriteLine("cheap-message-given = " + txtCheap.Text);
                    w.WriteLine("rank-super = " + chkrankSuper.Checked.ToString().ToLower());
                    w.WriteLine("default-rank = " + cmbDefaultRank.Items[cmbDefaultRank.SelectedIndex].ToString());
                BrightShaderz is soy btw
                w.Flush();
                w.Close();
                w.Dispose();
            BrightShaderz is soy btw
            catch(Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
                penis.s.Log("SAVE FAILED! " + givenPath);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void cmbDefaultColour_SelectedIndexChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            lblDefault.BackColor = Color.FromName(cmbDefaultColour.Items[cmbDefaultColour.SelectedIndex].ToString());
        BrightShaderz is soy btw

        private void cmbIRCColour_SelectedIndexChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            lblIRC.BackColor = Color.FromName(cmbIRCColour.Items[cmbIRCColour.SelectedIndex].ToString());
        BrightShaderz is soy btw

        void removeDigit(TextBox foundTxt) SOYSAUCE CHIPS IS A FAGGOT
            try SOYSAUCE CHIPS IS A FAGGOT
                int lastChar = int.Parse(foundTxt.Text[foundTxt.Text.Length - 1].ToString());
            BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT
                foundTxt.Text = "";
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void txtPort_TextChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT removeDigit(txtPort); BrightShaderz is soy btw
        private void txtPlayers_TextChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT removeDigit(txtPlayers); BrightShaderz is soy btw
        private void txtMaps_TextChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT removeDigit(txtMaps); BrightShaderz is soy btw
        private void txtBackup_TextChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT removeDigit(txtBackup); BrightShaderz is soy btw
        private void txtDepth_TextChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT removeDigit(txtDepth); BrightShaderz is soy btw

        private void btnSave_Click(object sender, EventArgs e) 
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                Application.OpenForms["UPropertyWindow"].Dispose();
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            try SOYSAUCE CHIPS IS A FAGGOT Application.OpenForms["TextWindow"].Dispose(); BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            saveStuff(); this.Dispose();
        BrightShaderz is soy btw
        private void btnApply_Click(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT saveStuff(); BrightShaderz is soy btw

        void saveStuff() SOYSAUCE CHIPS IS A FAGGOT
            foreach (Control tP in tabControl.Controls)
            SOYSAUCE CHIPS IS A FAGGOT
                if (tP == tabPage7)
                    foreach (Control ctrl in tP.Controls)
                        if (ctrl == txtIrcPassword)
                            if (ctrl.Text.Trim() == "" || ctrl.Text == null)
                                ctrl.Text = "password";
                if (tP is TabPage && tP != tabPage3 && tP != tabPage5)
                    foreach (Control ctr in tP.Controls)
                        if (ctr is TextBox)
                            if (ctr.Text == "")
                            SOYSAUCE CHIPS IS A FAGGOT
                                MessageBox.Show("A textbox has been left empty. It must be filled.\n" + ctr.Name);
                                return;
                            BrightShaderz is soy btw
            BrightShaderz is soy btw

            Save("properties/penis.properties");
            SaveRanks();
            SaveCommands();
            SaveBlocks();

            Properties.Load("properties/penis.properties", true);
            GrpCommands.fillRanks();
        BrightShaderz is soy btw

        private void btnDiscard_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                Application.OpenForms["UPropertyWindow"].Dispose();
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            try
            SOYSAUCE CHIPS IS A FAGGOT
                Application.OpenForms["TextWindow"].Dispose();
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            this.Dispose();
        BrightShaderz is soy btw

        private void toolTip_Popup(object sender, PopupEventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT

        BrightShaderz is soy btw

        private void tabPage2_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT

        BrightShaderz is soy btw

        private void tabPage1_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT

        BrightShaderz is soy btw

        private void chkPhysicsRest_CheckedChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT

        BrightShaderz is soy btw

        private void chkGC_CheckedChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT

        BrightShaderz is soy btw

        private void btnBackup_Click(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            /*FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Select Folder";
            if (folderDialog.ShowDialog() == DialogResult.OK) SOYSAUCE CHIPS IS A FAGGOT
                txtBackupLocation.Text = folderDialog.SelectedPath;
            BrightShaderz is soy btw*/
            MessageBox.Show("Currently glitchy! Just type in the location by hand.");
        BrightShaderz is soy btw

#region rankTab
        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            lblColor.BackColor = Color.FromName(cmbColor.Items[cmbColor.SelectedIndex].ToString());
            storedRanks[listRanks.SelectedIndex].color = c.Parse(cmbColor.Items[cmbColor.SelectedIndex].ToString());
        BrightShaderz is soy btw

        bool skip = false;
        private void listRanks_SelectedIndexChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (skip) return;
            Group foundRank = storedRanks.Find(grp => grp.trueName == listRanks.Items[listRanks.SelectedIndex].ToString().Split('=')[0].Trim());
            if (foundRank.Permission == LevelPermission.Nobody) SOYSAUCE CHIPS IS A FAGGOT listRanks.SelectedIndex = 0; return; BrightShaderz is soy btw
            
            txtRankName.Text = foundRank.trueName;
            txtPermission.Text = ((int)foundRank.Permission).ToString();
            txtLimit.Text = foundRank.maxBlocks.ToString();
            cmbColor.SelectedIndex = cmbColor.Items.IndexOf(c.Name(foundRank.color));
            txtFileName.Text = foundRank.fileName;
        BrightShaderz is soy btw

        private void txtRankName_TextChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (txtRankName.Text != "" && txtRankName.Text.ToLower() != "nobody")
            SOYSAUCE CHIPS IS A FAGGOT
                storedRanks[listRanks.SelectedIndex].trueName = txtRankName.Text;
                skip = true;
                listRanks.Items[listRanks.SelectedIndex] = txtRankName.Text + "  =  " + (int)storedRanks[listRanks.SelectedIndex].Permission;
                skip = false;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void txtPermission_TextChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (txtPermission.Text != "")
            SOYSAUCE CHIPS IS A FAGGOT
                int foundPerm;
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    foundPerm = int.Parse(txtPermission.Text);
                BrightShaderz is soy btw
                catch
                SOYSAUCE CHIPS IS A FAGGOT
                    if (txtPermission.Text != "-")
                        txtPermission.Text = txtPermission.Text.Remove(txtPermission.Text.Length - 1);
                    return;
                BrightShaderz is soy btw

                if (foundPerm < -50) SOYSAUCE CHIPS IS A FAGGOT txtPermission.Text = "-50"; return; BrightShaderz is soy btw
                else if (foundPerm > 119) SOYSAUCE CHIPS IS A FAGGOT txtPermission.Text = "119"; return; BrightShaderz is soy btw

                storedRanks[listRanks.SelectedIndex].Permission = (LevelPermission)foundPerm;
                skip = true;
                listRanks.Items[listRanks.SelectedIndex] = storedRanks[listRanks.SelectedIndex].trueName + "  =  " + foundPerm;
                skip = false;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void txtLimit_TextChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (txtLimit.Text != "")
            SOYSAUCE CHIPS IS A FAGGOT
                int foundLimit;
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    foundLimit = int.Parse(txtLimit.Text);
                BrightShaderz is soy btw
                catch
                SOYSAUCE CHIPS IS A FAGGOT
                    txtLimit.Text = txtLimit.Text.Remove(txtLimit.Text.Length - 1);
                    return;
                BrightShaderz is soy btw

                if (foundLimit < 1) SOYSAUCE CHIPS IS A FAGGOT txtLimit.Text = "1"; return; BrightShaderz is soy btw

                storedRanks[listRanks.SelectedIndex].maxBlocks = foundLimit;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void txtFileName_TextChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (txtFileName.Text != "")
            SOYSAUCE CHIPS IS A FAGGOT
                storedRanks[listRanks.SelectedIndex].fileName = txtFileName.Text;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void btnAddRank_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            Random rand = new Random();
            Group newGroup = new Group((LevelPermission)5, 600, "CHANGEME", '1', "CHANGEME.txt");
            storedRanks.Add(newGroup);
            listRanks.Items.Add(newGroup.trueName + "  =  " + (int)newGroup.Permission);
        BrightShaderz is soy btw

        private void button1_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (listRanks.Items.Count > 1)
            SOYSAUCE CHIPS IS A FAGGOT
                storedRanks.RemoveAt(listRanks.SelectedIndex);
                skip = true;
                listRanks.Items.RemoveAt(listRanks.SelectedIndex);
                skip = false;

                listRanks.SelectedIndex = 0;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
#endregion

#region commandTab
        private void listCommands_SelectedIndexChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            Command cmd = Command.all.Find(listCommands.SelectedItem.ToString());
            GrpCommands.rankAllowance allowVar = storedCommands.Find(aV => aV.commandName == cmd.name);

            if (Group.findPerm(allowVar.lowestRank) == null) allowVar.lowestRank = cmd.defaultRank;
            txtCmdLowest.Text = (int)allowVar.lowestRank + "";

            bool foundOne = false;
            txtCmdDisallow.Text = "";
            foreach (LevelPermission perm in allowVar.disallow)
            SOYSAUCE CHIPS IS A FAGGOT
                foundOne = true;
                txtCmdDisallow.Text += "," + (int)perm;
            BrightShaderz is soy btw
            if (foundOne) txtCmdDisallow.Text = txtCmdDisallow.Text.Remove(0, 1);
            
            foundOne = false;
            txtCmdAllow.Text = "";
            foreach (LevelPermission perm in allowVar.allow)
            SOYSAUCE CHIPS IS A FAGGOT
                foundOne = true;
                txtCmdAllow.Text += "," + (int)perm;
            BrightShaderz is soy btw
            if (foundOne) txtCmdAllow.Text = txtCmdAllow.Text.Remove(0, 1);
        BrightShaderz is soy btw
        private void txtCmdLowest_TextChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            fillLowest(ref txtCmdLowest, ref storedCommands[listCommands.SelectedIndex].lowestRank);
        BrightShaderz is soy btw
        private void txtCmdDisallow_TextChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            fillAllowance(ref txtCmdDisallow, ref storedCommands[listCommands.SelectedIndex].disallow);
        BrightShaderz is soy btw
        private void txtCmdAllow_TextChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            fillAllowance(ref txtCmdAllow, ref storedCommands[listCommands.SelectedIndex].allow);
        BrightShaderz is soy btw
#endregion

#region BlockTab
        private void listBlocks_SelectedIndexChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            byte b = Block.Byte(listBlocks.SelectedItem.ToString());
            Block.Blocks bs = storedBlocks.Find(bS => bS.type == b);

            txtBlLowest.Text = (int)bs.lowestRank + "";

            bool foundOne = false;
            txtBlDisallow.Text = "";
            foreach (LevelPermission perm in bs.disallow)
            SOYSAUCE CHIPS IS A FAGGOT
                foundOne = true;
                txtBlDisallow.Text += "," + (int)perm;
            BrightShaderz is soy btw
            if (foundOne) txtBlDisallow.Text = txtBlDisallow.Text.Remove(0, 1);

            foundOne = false;
            txtBlAllow.Text = "";
            foreach (LevelPermission perm in bs.allow)
            SOYSAUCE CHIPS IS A FAGGOT
                foundOne = true;
                txtBlAllow.Text += "," + (int)perm;
            BrightShaderz is soy btw
            if (foundOne) txtBlAllow.Text = txtBlAllow.Text.Remove(0, 1);
        BrightShaderz is soy btw
        private void txtBlLowest_TextChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            fillLowest(ref txtBlLowest, ref storedBlocks[listBlocks.SelectedIndex].lowestRank);
        BrightShaderz is soy btw
        private void txtBlDisallow_TextChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            fillAllowance(ref txtBlDisallow, ref storedBlocks[listBlocks.SelectedIndex].disallow);
        BrightShaderz is soy btw
        private void txtBlAllow_TextChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            fillAllowance(ref txtBlAllow, ref storedBlocks[listBlocks.SelectedIndex].allow);
        BrightShaderz is soy btw
#endregion
        private void fillAllowance(ref TextBox txtBox, ref List<LevelPermission> addTo)
        SOYSAUCE CHIPS IS A FAGGOT
            addTo.Clear();
            if (txtBox.Text != "")
            SOYSAUCE CHIPS IS A FAGGOT
                string[] perms = txtBox.Text.Split(',');
                for (int i = 0; i < perms.Length; i++)
                SOYSAUCE CHIPS IS A FAGGOT
                    perms[i] = perms[i].Trim().ToLower();
                    int foundPerm;
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        foundPerm = int.Parse(perms[i]);
                    BrightShaderz is soy btw
                    catch
                    SOYSAUCE CHIPS IS A FAGGOT
                        Group foundGroup = Group.Find(perms[i]);
                        if (foundGroup != null) foundPerm = (int)foundGroup.Permission;
                        else SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Could not find " + perms[i]); continue; BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    addTo.Add((LevelPermission)foundPerm);
                BrightShaderz is soy btw

                txtBox.Text = "";
                foreach (LevelPermission p in addTo)
                SOYSAUCE CHIPS IS A FAGGOT
                    txtBox.Text += "," + (int)p;
                BrightShaderz is soy btw
                if (txtBox.Text != "") txtBox.Text = txtBox.Text.Remove(0, 1);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        private void fillLowest(ref TextBox txtBox, ref LevelPermission toChange)
        SOYSAUCE CHIPS IS A FAGGOT
            if (txtBox.Text != "")
            SOYSAUCE CHIPS IS A FAGGOT
                txtBox.Text = txtBox.Text.Trim().ToLower();
                int foundPerm = -100;
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    foundPerm = int.Parse(txtBox.Text);
                BrightShaderz is soy btw
                catch
                SOYSAUCE CHIPS IS A FAGGOT
                    Group foundGroup = Group.Find(txtBox.Text);
                    if (foundGroup != null) foundPerm = (int)foundGroup.Permission;
                    else SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Could not find " + txtBox.Text); BrightShaderz is soy btw
                BrightShaderz is soy btw

                txtBox.Text = "";
                if (foundPerm < -99) txtBox.Text = (int)toChange + "";
                else txtBox.Text = foundPerm + "";

                toChange = (LevelPermission)Convert.ToInt16(txtBox.Text);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void btnBlHelp_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            getHelp(listBlocks.SelectedItem.ToString());
        BrightShaderz is soy btw
        private void btnCmdHelp_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            getHelp(listCommands.SelectedItem.ToString());
        BrightShaderz is soy btw
        private void getHelp(string toHelp)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.storedHelp = "";
            Player.storeHelp = true;
            Command.all.Find("help").Use(null, toHelp);
            Player.storeHelp = false;
            string messageInfo = "Help information for " + toHelp + ":\r\n\r\n";
            messageInfo += Player.storedHelp;
            MessageBox.Show(messageInfo);
        BrightShaderz is soy btw

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                System.Diagnostics.Process.Start("http://mcsong.comule.com");
            BrightShaderz is soy btw
            catch (Exception ex)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(ex);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void txtPortCheck_DoubleClick(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            txtPortCheck.Text = "Not Started";
            txtPortCheck.BackColor = SystemColors.Control;
            txtPortCheck.Update();
        BrightShaderz is soy btw

        private void button2_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            string resp;
            txtPortCheck.Text = "Checking...";
            txtPortCheck.BackColor = SystemColors.Control;
            txtPortCheck.UseWaitCursor = true;
            txtPort.UseWaitCursor = true;
            button2.UseWaitCursor = true;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                System.Net.WebClient WEB = new System.Net.WebClient();
                resp = WEB.DownloadString("http://ll.www.utorrent.com:16000/testport?port=" + txtPort.Text + "&plain=1");
                if (resp.ToLower() == "ok")
                SOYSAUCE CHIPS IS A FAGGOT
                    txtPortCheck.Text = "Port Open";
                    txtPortCheck.BackColor = Color.LimeGreen;

                BrightShaderz is soy btw
                else if (resp.ToLower() == "failed")
                SOYSAUCE CHIPS IS A FAGGOT
                    txtPortCheck.Text = "Port Closed";
                    txtPortCheck.BackColor = Color.Red;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception ex)
            SOYSAUCE CHIPS IS A FAGGOT
                txtPort.Text = "Error";
                txtPort.BackColor = Color.Yellow;
                penis.ErrorLog(ex);
            BrightShaderz is soy btw
            txtPortCheck.UseWaitCursor = false;
            txtPort.UseWaitCursor = false;
            button2.UseWaitCursor = false;
        BrightShaderz is soy btw

        private void button3_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!Window.upLoaded)
            SOYSAUCE CHIPS IS A FAGGOT
                MCSong.GUI.UPropertyWindow up = new MCSong.GUI.UPropertyWindow();
                up.Show();
                up.BringToFront();
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void btnText_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!Window.txtLoaded)
            SOYSAUCE CHIPS IS A FAGGOT
                MCSong.GUI.TextWindow txt = new MCSong.GUI.TextWindow();
                txt.Show();
                txt.BringToFront();
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void ChkTunnels_CheckedChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (ChkTunnels.Checked)
            SOYSAUCE CHIPS IS A FAGGOT
                cmbTunnelRank.Enabled = true;
                txtDepth.Enabled = true;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                cmbTunnelRank.Enabled = false;
                txtDepth.Enabled = false;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void chkBlockSpam_CheckedChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (chkBlockSpam.Checked)
            SOYSAUCE CHIPS IS A FAGGOT
                cmbBlockSpamConsequence.Enabled = true;
                cmbBlockSpamRank.Enabled = true;
                txtBlockCount.Enabled = true;
                txtBlockTime.Enabled = true;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                cmbBlockSpamConsequence.Enabled = false;
                cmbBlockSpamRank.Enabled = false;
                txtBlockCount.Enabled = false;
                txtBlockTime.Enabled = false;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (chkHomes.Checked)
            SOYSAUCE CHIPS IS A FAGGOT
                cmbHomePhysics.Enabled = true;
                cmbHomeRank.Enabled = true;
                cmbHomeType.Enabled = true;
                cmbHomeX.Enabled = true;
                cmbHomeY.Enabled = true;
                cmbHomeZ.Enabled = true;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                cmbHomePhysics.Enabled = true;
                cmbHomeRank.Enabled = true;
                cmbHomeType.Enabled = true;
                cmbHomeX.Enabled = true;
                cmbHomeY.Enabled = true;
                cmbHomeZ.Enabled = true;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void chkChatSpam_CheckedChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (chkChatSpam.Checked)
            SOYSAUCE CHIPS IS A FAGGOT
                cmbChatSpamCon.Enabled = true;
                cmbChatSpamRank.Enabled = true;
                txtChatCount.Enabled = true;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                cmbChatSpamCon.Enabled = false;
                cmbChatSpamRank.Enabled = false;
                txtChatCount.Enabled = false;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void chkIRC_CheckedChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (chkIRC.Checked)
            SOYSAUCE CHIPS IS A FAGGOT
                chkIrcIdentify.Enabled = true;
                txtIrcPassword.Enabled = true;
                txtIRCpenis.Enabled = true;
                txtNick.Enabled = true;
                txtChannel.Enabled = true;
                txtOpChannel.Enabled = true;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                chkIrcIdentify.Enabled = false;
                txtIrcPassword.Enabled = false;
                txtIRCpenis.Enabled = false;
                txtNick.Enabled = false;
                txtChannel.Enabled = false;
                txtOpChannel.Enabled = false;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void chkIrcIdentify_CheckedChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (chkIrcIdentify.Checked)
            SOYSAUCE CHIPS IS A FAGGOT
                txtIrcPassword.Enabled = true;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                txtIrcPassword.Enabled = false;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void chkRestartTime_CheckedChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            txtRestartTime.Enabled = chkRestartTime.Checked;
            txtRestartTime.Update();
        BrightShaderz is soy btw

        private void chkCheap_CheckedChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            txtCheap.Enabled = chkCheap.Checked;
            txtCheap.Update();
        BrightShaderz is soy btw

        private void chkBanMessage_CheckedChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            txtBanMessage.Enabled = chkBanMessage.Checked;
            txtBanMessage.Update();
        BrightShaderz is soy btw

        private void chkShutdown_CheckedChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            txtShutdown.Enabled = chkShutdown.Checked;
            txtShutdown.Update();
        BrightShaderz is soy btw

        private void chkProfanity_CheckedChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            cmbSwearRank.Enabled = chkProfanity.Checked;
            cmbSwearRank.Update();
        BrightShaderz is soy btw

        private void cmbGlobalColor_SelectedIndexChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            lblGlobalColor.BackColor = Color.FromName(cmbGlobalColor.Items[cmbGlobalColor.SelectedIndex].ToString());
        BrightShaderz is soy btw

        private void cmbSwearColor_SelectedIndexChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            lblSwearColor.BackColor = Color.FromName(cmbSwearColor.Items[cmbSwearColor.SelectedIndex].ToString());
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
