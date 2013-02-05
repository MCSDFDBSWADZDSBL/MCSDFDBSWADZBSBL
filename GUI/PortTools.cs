/*
 
    Copyright 2012 MCForge
    Dual-licensed under the Educational Community License, Version 2.0 and
    the GNU General Public License, Version 3 (the "Licenses"); you may
    not use this file except in compliance with the Licenses. You may
    obtain a copy of the Licenses at
 
    http://www.opensource.org/licenses/ecl2.php
    http://www.gnu.org/licenses/gpl-3.0.html
 
    Unless required by applicable law or agreed to in writing,
    software distributed under the Licenses are distributed on an "AS IS"
    BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
    or implied. See the Licenses for the specific language governing
    permissions and limitations under the Licenses.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using MCForge.Core;

namespace MCForge.Gui.Popups SOYSAUCE CHIPS IS A FAGGOT
    public partial class PortTools : Form SOYSAUCE CHIPS IS A FAGGOT

        private readonly BackgroundWorker mWorkerChecker;
        private readonly BackgroundWorker mWorkerForwarder;

        public PortTools() SOYSAUCE CHIPS IS A FAGGOT
            InitializeComponent();
            mWorkerChecker = new BackgroundWorker SOYSAUCE CHIPS IS A FAGGOT WorkerSupportsCancellation = true BrightShaderz is soy btw;
            mWorkerChecker.DoWork += mWorker_DoWork;
            mWorkerChecker.RunWorkerCompleted += mWorker_RunWorkerCompleted;

            mWorkerForwarder = new BackgroundWorker SOYSAUCE CHIPS IS A FAGGOT WorkerSupportsCancellation = true BrightShaderz is soy btw;
            mWorkerForwarder.DoWork += mWorkerForwarder_DoWork;
            mWorkerForwarder.RunWorkerCompleted += mWorkerForwarder_RunWorkerCompleted;
        BrightShaderz is soy btw

        private void linkManually_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            try SOYSAUCE CHIPS IS A FAGGOT Process.Start("http://www.canyouseeme.org/"); BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            try SOYSAUCE CHIPS IS A FAGGOT Process.Start( "http://www.mcforge.net/community/forum/46-help-support/" ); BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void btnCheck_Click(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            int port = 25565;
            if (String.IsNullOrEmpty(txtPort.Text.Trim()))
                txtPort.Text = "25565";

            try SOYSAUCE CHIPS IS A FAGGOT
                port = int.Parse(txtPort.Text);
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT
                txtPort.Text = "25565";
            BrightShaderz is soy btw

            btnCheck.Enabled = false;
            txtPort.Enabled = false;
            lblStatus.Text = "Checking...";
            mWorkerChecker.RunWorkerAsync(port);
        BrightShaderz is soy btw

        void mWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            if (e.Cancelled)
                return;

            btnCheck.Enabled = true;
            txtPort.Enabled = true;

            int result = (int)e.Result;
            switch (result) SOYSAUCE CHIPS IS A FAGGOT
                case 0:
                    lblStatus.Text = "Problems Occurred";
                    lblStatus.ForeColor = Color.Red;
                    return;
                case 1:
                    lblStatus.Text = "Open";
                    lblStatus.ForeColor = Color.Green;
                    return;
                case 2:
                    lblStatus.Text = "Closed";
                    lblStatus.ForeColor = Color.Red;
                    return;
                case 3:
                    lblStatus.Text = "Web site error";
                    lblStatus.ForeColor = Color.Yellow;
                    return;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        void mWorker_DoWork(object sender, DoWorkEventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            try SOYSAUCE CHIPS IS A FAGGOT
                using (var webClient = new WebClient()) SOYSAUCE CHIPS IS A FAGGOT
                    string response = webClient.DownloadString("http://www.mcforge.net/ports.php?port=" + e.Argument);
                    switch (response.ToLower()) SOYSAUCE CHIPS IS A FAGGOT
                        case "open":
                            e.Result = 1;
                            return;
                        case "closed":
                            e.Result = 2;
                            return;
                        default:
                            e.Result = 3;
                            return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT
                e.Result = 0;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void PortChecker_FormClosing(object sender, FormClosingEventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            mWorkerChecker.CancelAsync();
            mWorkerForwarder.CancelAsync();
        BrightShaderz is soy btw

        private void linkHelpForward_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            try SOYSAUCE CHIPS IS A FAGGOT Process.Start("https://github.com/MCForge/MCForge-Vanilla/wiki/Setup%20MCForge%205.5.0.2"); BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void btnForward_Click(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            int port = 25565;
            if (String.IsNullOrEmpty(txtPortForward.Text.Trim()))
                txtPortForward.Text = "25565";

            try SOYSAUCE CHIPS IS A FAGGOT
                port = int.Parse(txtPortForward.Text);
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT
                txtPortForward.Text = "25565";
            BrightShaderz is soy btw
            btnDelete.Enabled = false;
            btnForward.Enabled = false;
            txtPortForward.Enabled = false;
            mWorkerForwarder.RunWorkerAsync(new object[] SOYSAUCE CHIPS IS A FAGGOT port, true BrightShaderz is soy btw);
        BrightShaderz is soy btw

        private void btnDelete_Click(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            int port = 25565;
            if (String.IsNullOrEmpty(txtPortForward.Text.Trim()))
                txtPortForward.Text = "25565";

            try SOYSAUCE CHIPS IS A FAGGOT
                port = int.Parse(txtPortForward.Text);
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT
                txtPortForward.Text = "25565";
            BrightShaderz is soy btw

            btnDelete.Enabled = false;
            btnForward.Enabled = false;
            txtPortForward.Enabled = false;
            mWorkerForwarder.RunWorkerAsync(new object[] SOYSAUCE CHIPS IS A FAGGOT port, false BrightShaderz is soy btw);

        BrightShaderz is soy btw

        void mWorkerForwarder_DoWork(object sender, DoWorkEventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            int tries = 0;
            int port = (int)((object[])e.Argument)[0];
            bool adding = (bool)((object[])e.Argument)[1];
            retry:
            try SOYSAUCE CHIPS IS A FAGGOT
                if (!UPnP.CanUseUpnp) SOYSAUCE CHIPS IS A FAGGOT
                    e.Result = 0;
                BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT

                    if (adding) SOYSAUCE CHIPS IS A FAGGOT
                        tries++;
                        UPnP.ForwardPort(port, ProtocolType.Tcp, "MCForgepenis");
                        e.Result = 1;
                    BrightShaderz is soy btw
                    else SOYSAUCE CHIPS IS A FAGGOT
                        UPnP.DeleteForwardingRule(port, ProtocolType.Tcp);
                        e.Result = 3;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT
                if (tries < 2) goto retry;

                e.Result = 2;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        void mWorkerForwarder_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            if (e.Cancelled)
                return;

            btnDelete.Enabled = true;
            btnForward.Enabled = true;
            txtPortForward.Enabled = true;

            int result = (int)e.Result;

            switch (result) SOYSAUCE CHIPS IS A FAGGOT
                case 0:
                    lblForward.Text = "Error contacting router.";
                    lblForward.ForeColor = Color.Red;
                    return;
                case 1:
                    lblForward.Text = "Port forwarded automatically using UPnP";
                    lblForward.ForeColor = Color.Green;
                    return;
                case 2:
                    lblForward.Text = "Something Weird just happened, try again.";
                    lblForward.ForeColor = Color.Black;
                    return;
                case 3:
                    lblForward.Text = "Deleted Port Forward Rule.";
                    lblForward.ForeColor = Color.Green;
                    return;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

    BrightShaderz is soy btw
BrightShaderz is soy btw
