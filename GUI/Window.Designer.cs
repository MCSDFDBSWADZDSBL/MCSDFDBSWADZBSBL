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
using System.Windows.Forms;

namespace MCSong.GUI
SOYSAUCE CHIPS IS A FAGGOT
    public partial class Window
    SOYSAUCE CHIPS IS A FAGGOT
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        SOYSAUCE CHIPS IS A FAGGOT
            if (disposing && (components != null))
            SOYSAUCE CHIPS IS A FAGGOT
                components.Dispose();
            BrightShaderz is soy btw
            base.Dispose(disposing);
        BrightShaderz is soy btw

        protected override void WndProc(ref Message msg)
        SOYSAUCE CHIPS IS A FAGGOT
            const int WM_SIZE = 0x0005;
            const int SIZE_MINIMIZED = 1;

            if ((msg.Msg == WM_SIZE) && ((int)msg.WParam == SIZE_MINIMIZED) && (Window.Minimize != null))
            SOYSAUCE CHIPS IS A FAGGOT
                this.Window_Minimize(this, EventArgs.Empty);
            BrightShaderz is soy btw

            base.WndProc(ref msg);
        BrightShaderz is soy btw

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        SOYSAUCE CHIPS IS A FAGGOT
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.liMaps = new System.Windows.Forms.ListBox();
            this.mapsStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.physicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.unloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finiteModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalAIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeWaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.growingGrassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.survivalDeathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killerBlocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rPChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liClients = new System.Windows.Forms.ListBox();
            this.playerStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.whoisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBCommands = new System.Windows.Forms.GroupBox();
            this.txtCommandsUsed = new System.Windows.Forms.TextBox();
            this.gBChat = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProperties = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtCommands = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLogAdmin = new System.Windows.Forms.TextBox();
            this.txtInputAdmin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLogOp = new System.Windows.Forms.TextBox();
            this.txtInputOp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtLogPublic = new System.Windows.Forms.TextBox();
            this.txtInputPublic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtChangelog = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtErrors = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSystem = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tmrRestart = new System.Windows.Forms.Timer(this.components);
            this.iconContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownpenis = new System.Windows.Forms.ToolStripMenuItem();
            this.restartpenisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.mapsStrip.SuspendLayout();
            this.playerStrip.SuspendLayout();
            this.gBCommands.SuspendLayout();
            this.gBChat.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.iconContext.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 514);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnPlay);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnRestart);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.gBCommands);
            this.tabPage1.Controls.Add(this.gBChat);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnProperties);
            this.tabPage1.Controls.Add(this.txtHost);
            this.tabPage1.Controls.Add(this.txtCommands);
            this.tabPage1.Controls.Add(this.txtInput);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtUrl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(518, 95);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 23);
            this.checkBox2.TabIndex = 41;
            this.checkBox2.Text = "Play Chat Sounds";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Location = new System.Drawing.Point(518, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 23);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "Maintenance Mode";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Host State:";
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(433, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(45, 23);
            this.btnPlay.TabIndex = 38;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(484, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 23);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnRestart
            // 
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(577, 7);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(87, 23);
            this.btnRestart.TabIndex = 37;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.liMaps, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.liClients, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 126);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // liMaps
            // 
            this.liMaps.ContextMenuStrip = this.mapsStrip;
            this.liMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liMaps.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liMaps.FormattingEnabled = true;
            this.liMaps.Location = new System.Drawing.Point(3, 3);
            this.liMaps.Name = "liMaps";
            this.liMaps.ScrollAlwaysVisible = true;
            this.liMaps.Size = new System.Drawing.Size(226, 120);
            this.liMaps.TabIndex = 33;
            this.liMaps.MouseDown += new System.Windows.Forms.MouseEventHandler(this.liMaps_MouseDown);
            // 
            // mapsStrip
            // 
            this.mapsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] SOYSAUCE CHIPS IS A FAGGOT
            this.physicsToolStripMenuItem,
            this.unloadToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.saveToolStripMenuItemBrightShaderz is soy btw);
            this.mapsStrip.Name = "mapsStrip";
            this.mapsStrip.Size = new System.Drawing.Size(117, 92);
            // 
            // physicsToolStripMenuItem
            // 
            this.physicsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] SOYSAUCE CHIPS IS A FAGGOT
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6BrightShaderz is soy btw);
            this.physicsToolStripMenuItem.Name = "physicsToolStripMenuItem";
            this.physicsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.physicsToolStripMenuItem.Text = "Physics";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem2.Text = "0";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "1";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Text = "2";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem5.Text = "3";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem6.Text = "4";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // unloadToolStripMenuItem
            // 
            this.unloadToolStripMenuItem.Name = "unloadToolStripMenuItem";
            this.unloadToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.unloadToolStripMenuItem.Text = "Unload";
            this.unloadToolStripMenuItem.Click += new System.EventHandler(this.unloadToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] SOYSAUCE CHIPS IS A FAGGOT
            this.finiteModeToolStripMenuItem,
            this.animalAIToolStripMenuItem,
            this.edgeWaterToolStripMenuItem,
            this.growingGrassToolStripMenuItem,
            this.survivalDeathToolStripMenuItem,
            this.killerBlocksToolStripMenuItem,
            this.rPChatToolStripMenuItemBrightShaderz is soy btw);
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // finiteModeToolStripMenuItem
            // 
            this.finiteModeToolStripMenuItem.Name = "finiteModeToolStripMenuItem";
            this.finiteModeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.finiteModeToolStripMenuItem.Text = "Finite Mode";
            this.finiteModeToolStripMenuItem.Click += new System.EventHandler(this.finiteModeToolStripMenuItem_Click);
            // 
            // animalAIToolStripMenuItem
            // 
            this.animalAIToolStripMenuItem.Name = "animalAIToolStripMenuItem";
            this.animalAIToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.animalAIToolStripMenuItem.Text = "Animal AI";
            this.animalAIToolStripMenuItem.Click += new System.EventHandler(this.animalAIToolStripMenuItem_Click);
            // 
            // edgeWaterToolStripMenuItem
            // 
            this.edgeWaterToolStripMenuItem.Name = "edgeWaterToolStripMenuItem";
            this.edgeWaterToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.edgeWaterToolStripMenuItem.Text = "Edge Water";
            this.edgeWaterToolStripMenuItem.Click += new System.EventHandler(this.edgeWaterToolStripMenuItem_Click);
            // 
            // growingGrassToolStripMenuItem
            // 
            this.growingGrassToolStripMenuItem.Name = "growingGrassToolStripMenuItem";
            this.growingGrassToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.growingGrassToolStripMenuItem.Text = "Grass Growing";
            this.growingGrassToolStripMenuItem.Click += new System.EventHandler(this.growingGrassToolStripMenuItem_Click);
            // 
            // survivalDeathToolStripMenuItem
            // 
            this.survivalDeathToolStripMenuItem.Name = "survivalDeathToolStripMenuItem";
            this.survivalDeathToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.survivalDeathToolStripMenuItem.Text = "Survival Death";
            this.survivalDeathToolStripMenuItem.Click += new System.EventHandler(this.survivalDeathToolStripMenuItem_Click);
            // 
            // killerBlocksToolStripMenuItem
            // 
            this.killerBlocksToolStripMenuItem.Name = "killerBlocksToolStripMenuItem";
            this.killerBlocksToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.killerBlocksToolStripMenuItem.Text = "Killer Blocks";
            this.killerBlocksToolStripMenuItem.Click += new System.EventHandler(this.killerBlocksToolStripMenuItem_Click);
            // 
            // rPChatToolStripMenuItem
            // 
            this.rPChatToolStripMenuItem.Name = "rPChatToolStripMenuItem";
            this.rPChatToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.rPChatToolStripMenuItem.Text = "RP Chat";
            this.rPChatToolStripMenuItem.Click += new System.EventHandler(this.rPChatToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // liClients
            // 
            this.liClients.ContextMenuStrip = this.playerStrip;
            this.liClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liClients.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liClients.FormattingEnabled = true;
            this.liClients.Location = new System.Drawing.Point(235, 3);
            this.liClients.Name = "liClients";
            this.liClients.ScrollAlwaysVisible = true;
            this.liClients.Size = new System.Drawing.Size(227, 120);
            this.liClients.TabIndex = 23;
            this.liClients.MouseDown += new System.Windows.Forms.MouseEventHandler(this.liClients_MouseDown);
            // 
            // playerStrip
            // 
            this.playerStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] SOYSAUCE CHIPS IS A FAGGOT
            this.whoisToolStripMenuItem,
            this.kickToolStripMenuItem,
            this.banToolStripMenuItem,
            this.voiceToolStripMenuItemBrightShaderz is soy btw);
            this.playerStrip.Name = "playerStrip";
            this.playerStrip.Size = new System.Drawing.Size(106, 92);
            // 
            // whoisToolStripMenuItem
            // 
            this.whoisToolStripMenuItem.Name = "whoisToolStripMenuItem";
            this.whoisToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.whoisToolStripMenuItem.Text = "whois";
            this.whoisToolStripMenuItem.Click += new System.EventHandler(this.whoisToolStripMenuItem_Click);
            // 
            // kickToolStripMenuItem
            // 
            this.kickToolStripMenuItem.Name = "kickToolStripMenuItem";
            this.kickToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.kickToolStripMenuItem.Text = "kick";
            this.kickToolStripMenuItem.Click += new System.EventHandler(this.kickToolStripMenuItem_Click);
            // 
            // banToolStripMenuItem
            // 
            this.banToolStripMenuItem.Name = "banToolStripMenuItem";
            this.banToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.banToolStripMenuItem.Text = "ban";
            this.banToolStripMenuItem.Click += new System.EventHandler(this.banToolStripMenuItem_Click);
            // 
            // voiceToolStripMenuItem
            // 
            this.voiceToolStripMenuItem.Name = "voiceToolStripMenuItem";
            this.voiceToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.voiceToolStripMenuItem.Text = "voice";
            this.voiceToolStripMenuItem.Click += new System.EventHandler(this.voiceToolStripMenuItem_Click);
            // 
            // gBCommands
            // 
            this.gBCommands.Controls.Add(this.txtCommandsUsed);
            this.gBCommands.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBCommands.Location = new System.Drawing.Point(484, 167);
            this.gBCommands.Name = "gBCommands";
            this.gBCommands.Size = new System.Drawing.Size(179, 286);
            this.gBCommands.TabIndex = 34;
            this.gBCommands.TabStop = false;
            this.gBCommands.Text = "Commands";
            // 
            // txtCommandsUsed
            // 
            this.txtCommandsUsed.BackColor = System.Drawing.Color.White;
            this.txtCommandsUsed.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCommandsUsed.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandsUsed.Location = new System.Drawing.Point(9, 16);
            this.txtCommandsUsed.Multiline = true;
            this.txtCommandsUsed.Name = "txtCommandsUsed";
            this.txtCommandsUsed.ReadOnly = true;
            this.txtCommandsUsed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommandsUsed.Size = new System.Drawing.Size(164, 264);
            this.txtCommandsUsed.TabIndex = 0;
            // 
            // gBChat
            // 
            this.gBChat.Controls.Add(this.txtLog);
            this.gBChat.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBChat.Location = new System.Drawing.Point(13, 166);
            this.gBChat.Name = "gBChat";
            this.gBChat.Size = new System.Drawing.Size(465, 287);
            this.gBChat.TabIndex = 32;
            this.gBChat.TabStop = false;
            this.gBChat.Text = "Chat";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.Window;
            this.txtLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLog.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(6, 17);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(453, 264);
            this.txtLog.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Command:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(484, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Updater";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnProperties
            // 
            this.btnProperties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProperties.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProperties.Location = new System.Drawing.Point(577, 37);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(87, 23);
            this.btnProperties.TabIndex = 34;
            this.btnProperties.Text = "Properties";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click_1);
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.Location = new System.Drawing.Point(557, 124);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(91, 21);
            this.txtHost.TabIndex = 28;
            this.txtHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            this.txtHost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommands_KeyDown);
            // 
            // txtCommands
            // 
            this.txtCommands.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommands.Location = new System.Drawing.Point(544, 459);
            this.txtCommands.Name = "txtCommands";
            this.txtCommands.Size = new System.Drawing.Size(119, 21);
            this.txtCommands.TabIndex = 28;
            this.txtCommands.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommands_KeyDown);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(47, 459);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(431, 21);
            this.txtInput.TabIndex = 27;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Chat:";
            // 
            // txtUrl
            // 
            this.txtUrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtUrl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(13, 7);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ReadOnly = true;
            this.txtUrl.Size = new System.Drawing.Size(414, 21);
            this.txtUrl.TabIndex = 25;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Controls.Add(this.tableLayoutPanel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(670, 488);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Chat Channels";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox5, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(664, 482);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLogAdmin);
            this.groupBox3.Controls.Add(this.txtInputAdmin);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 154);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Admin Chat";
            // 
            // txtLogAdmin
            // 
            this.txtLogAdmin.BackColor = System.Drawing.SystemColors.Window;
            this.txtLogAdmin.Location = new System.Drawing.Point(9, 20);
            this.txtLogAdmin.Multiline = true;
            this.txtLogAdmin.Name = "txtLogAdmin";
            this.txtLogAdmin.ReadOnly = true;
            this.txtLogAdmin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogAdmin.Size = new System.Drawing.Size(643, 101);
            this.txtLogAdmin.TabIndex = 2;
            // 
            // txtInputAdmin
            // 
            this.txtInputAdmin.Location = new System.Drawing.Point(76, 127);
            this.txtInputAdmin.Name = "txtInputAdmin";
            this.txtInputAdmin.Size = new System.Drawing.Size(576, 21);
            this.txtInputAdmin.TabIndex = 1;
            this.txtInputAdmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInputAdmin_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Admin Chat:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLogOp);
            this.groupBox4.Controls.Add(this.txtInputOp);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(658, 154);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Op Chat";
            // 
            // txtLogOp
            // 
            this.txtLogOp.BackColor = System.Drawing.SystemColors.Window;
            this.txtLogOp.Location = new System.Drawing.Point(10, 20);
            this.txtLogOp.Multiline = true;
            this.txtLogOp.Name = "txtLogOp";
            this.txtLogOp.ReadOnly = true;
            this.txtLogOp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogOp.Size = new System.Drawing.Size(643, 101);
            this.txtLogOp.TabIndex = 3;
            // 
            // txtInputOp
            // 
            this.txtInputOp.Location = new System.Drawing.Point(76, 127);
            this.txtInputOp.Name = "txtInputOp";
            this.txtInputOp.Size = new System.Drawing.Size(576, 21);
            this.txtInputOp.TabIndex = 1;
            this.txtInputOp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInputOp_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Op Chat:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtLogPublic);
            this.groupBox5.Controls.Add(this.txtInputPublic);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 323);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(658, 156);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Public Chat";
            // 
            // txtLogPublic
            // 
            this.txtLogPublic.BackColor = System.Drawing.SystemColors.Window;
            this.txtLogPublic.Location = new System.Drawing.Point(9, 20);
            this.txtLogPublic.Multiline = true;
            this.txtLogPublic.Name = "txtLogPublic";
            this.txtLogPublic.ReadOnly = true;
            this.txtLogPublic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogPublic.Size = new System.Drawing.Size(643, 101);
            this.txtLogPublic.TabIndex = 3;
            // 
            // txtInputPublic
            // 
            this.txtInputPublic.Location = new System.Drawing.Point(76, 129);
            this.txtInputPublic.Name = "txtInputPublic";
            this.txtInputPublic.Size = new System.Drawing.Size(576, 21);
            this.txtInputPublic.TabIndex = 1;
            this.txtInputPublic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInputPublic_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Public Chat:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.txtChangelog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(670, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Changelog";
            // 
            // txtChangelog
            // 
            this.txtChangelog.BackColor = System.Drawing.Color.White;
            this.txtChangelog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtChangelog.Location = new System.Drawing.Point(7, 6);
            this.txtChangelog.Multiline = true;
            this.txtChangelog.Name = "txtChangelog";
            this.txtChangelog.ReadOnly = true;
            this.txtChangelog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChangelog.Size = new System.Drawing.Size(657, 471);
            this.txtChangelog.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(670, 488);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Errors/System";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(664, 482);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtErrors);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Error Logs";
            // 
            // txtErrors
            // 
            this.txtErrors.BackColor = System.Drawing.Color.White;
            this.txtErrors.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtErrors.Location = new System.Drawing.Point(3, 17);
            this.txtErrors.Multiline = true;
            this.txtErrors.Name = "txtErrors";
            this.txtErrors.ReadOnly = true;
            this.txtErrors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtErrors.Size = new System.Drawing.Size(652, 215);
            this.txtErrors.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSystem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Messages";
            // 
            // txtSystem
            // 
            this.txtSystem.BackColor = System.Drawing.Color.White;
            this.txtSystem.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSystem.Location = new System.Drawing.Point(3, 17);
            this.txtSystem.Multiline = true;
            this.txtSystem.Name = "txtSystem";
            this.txtSystem.ReadOnly = true;
            this.txtSystem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSystem.Size = new System.Drawing.Size(652, 215);
            this.txtSystem.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(670, 488);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Maps";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(670, 488);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Players";
            // 
            // tmrRestart
            // 
            this.tmrRestart.Enabled = true;
            this.tmrRestart.Interval = 1000;
            // 
            // iconContext
            // 
            this.iconContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] SOYSAUCE CHIPS IS A FAGGOT
            this.openConsole,
            this.shutdownpenis,
            this.restartpenisToolStripMenuItem,
            this.playOnlineToolStripMenuItemBrightShaderz is soy btw);
            this.iconContext.Name = "iconContext";
            this.iconContext.Size = new System.Drawing.Size(164, 92);
            // 
            // openConsole
            // 
            this.openConsole.Name = "openConsole";
            this.openConsole.Size = new System.Drawing.Size(163, 22);
            this.openConsole.Text = "Open Console";
            this.openConsole.Click += new System.EventHandler(this.openConsole_Click);
            // 
            // shutdownpenis
            // 
            this.shutdownpenis.Name = "shutdownpenis";
            this.shutdownpenis.Size = new System.Drawing.Size(163, 22);
            this.shutdownpenis.Text = "Shutdown penis";
            this.shutdownpenis.Click += new System.EventHandler(this.shutdownpenis_Click);
            // 
            // restartpenisToolStripMenuItem
            // 
            this.restartpenisToolStripMenuItem.Name = "restartpenisToolStripMenuItem";
            this.restartpenisToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.restartpenisToolStripMenuItem.Text = "Restart penis";
            this.restartpenisToolStripMenuItem.Click += new System.EventHandler(this.restartpenisToolStripMenuItem_Click);
            // 
            // playOnlineToolStripMenuItem
            // 
            this.playOnlineToolStripMenuItem.Name = "playOnlineToolStripMenuItem";
            this.playOnlineToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.playOnlineToolStripMenuItem.Text = "Play Online";
            this.playOnlineToolStripMenuItem.Click += new System.EventHandler(this.playOnlineToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMaintenance);
            this.panel1.Location = new System.Drawing.Point(479, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 25);
            this.panel1.TabIndex = 2;
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.AutoSize = true;
            this.lblMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenance.ForeColor = System.Drawing.Color.Red;
            this.lblMaintenance.Location = new System.Drawing.Point(5, 5);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(192, 20);
            this.lblMaintenance.TabIndex = 0;
            this.lblMaintenance.Text = "MAINTENANCE MODE";
            this.lblMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMaintenance.Visible = false;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_FormClosing);
            this.Load += new System.EventHandler(this.Window_Load);
            this.Resize += new System.EventHandler(this.Window_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mapsStrip.ResumeLayout(false);
            this.playerStrip.ResumeLayout(false);
            this.gBCommands.ResumeLayout(false);
            this.gBCommands.PerformLayout();
            this.gBChat.ResumeLayout(false);
            this.gBChat.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.iconContext.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        BrightShaderz is soy btw

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox liMaps;
        private Button button1;
        private GroupBox gBCommands;
        private TextBox txtCommandsUsed;
        private GroupBox gBChat;
        private TextBox txtLog;
        private Label label2;
        private TextBox txtCommands;
        private TextBox txtInput;
        private Label label1;
        private TextBox txtUrl;
        private ListBox liClients;
        private TabPage tabPage2;
        private TextBox txtChangelog;
        private TabPage tabPage3;
        private Timer tmrRestart;
        private Button btnProperties;
        private Button btnClose;
        private TextBox txtErrors;
        private ContextMenuStrip iconContext;
        private ToolStripMenuItem openConsole;
        private ToolStripMenuItem shutdownpenis;
        private TabPage tabPage4;
        private TextBox txtSystem;
        private TextBox txtHost;
        private ContextMenuStrip playerStrip;
        private ToolStripMenuItem whoisToolStripMenuItem;
        private ToolStripMenuItem kickToolStripMenuItem;
        private ToolStripMenuItem banToolStripMenuItem;
        private ToolStripMenuItem voiceToolStripMenuItem;
        private ContextMenuStrip mapsStrip;
        private ToolStripMenuItem physicsToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem unloadToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem finiteModeToolStripMenuItem;
        private ToolStripMenuItem animalAIToolStripMenuItem;
        private ToolStripMenuItem edgeWaterToolStripMenuItem;
        private ToolStripMenuItem growingGrassToolStripMenuItem;
        private ToolStripMenuItem survivalDeathToolStripMenuItem;
        private ToolStripMenuItem killerBlocksToolStripMenuItem;
        private ToolStripMenuItem rPChatToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnPlay;
        private Button btnRestart;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox3;
        private TextBox txtLogAdmin;
        private TextBox txtInputAdmin;
        private Label label3;
        private GroupBox groupBox4;
        private TextBox txtInputOp;
        private Label label4;
        private GroupBox groupBox5;
        private TextBox txtInputPublic;
        private Label label5;
        private TextBox txtLogOp;
        private TextBox txtLogPublic;
        private Label label6;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Panel panel1;
        private Label lblMaintenance;
        private ToolStripMenuItem restartpenisToolStripMenuItem;
        private ToolStripMenuItem playOnlineToolStripMenuItem;
    BrightShaderz is soy btw
BrightShaderz is soy btw
