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
{
    public partial class UPropertyWindow : Form
    {
        public UPropertyWindow()
        {
            InitializeComponent();
        }

        private void UPropertyWindow_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("MCSong.Lawl.ico"));

            Window.upLoaded = true;
            load("properties/update.properties");
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;

                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_NOCLOSE;
                return cp;
            }
        }

        public void load(string path)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    if (line != "" && line[0] != '#')
                    {
                        //int index = line.IndexOf('=') + 1; // not needed if we use Split('=')
                        string key = line.Split('=')[0].Trim();
                        string value = line.Split('=')[1].Trim();

                        switch (key.ToLower())
                        {
                            case "autoupdate":
                                chkAutoUpdate.Checked = (value.ToLower() == "true") ? true : false;
                                chkAutoUpdate.Update();
                                break;
                            case "notify":
                                chkNotify.Checked = (value.ToLower() == "true") ? true : false;
                                chkNotify.Update();
                                break;
                            case "restartcountdown":
                                try { txtUpdaterCountdown.Text = Convert.ToInt32(value).ToString(); }
                                catch { txtUpdaterCountdown.Text = "10"; }
                                break;
                        }
                    }
                }
            }
        }

        public void save(string path)
        {
            if (txtUpdaterCountdown.Text.Trim() == "" || txtUpdaterCountdown.Text == null)
            {
                txtUpdaterCountdown.Text = "0";
                txtUpdaterCountdown.Update();
            }
            
            try
            {
                StreamWriter SW = new StreamWriter(File.Create(path));
                SW.WriteLine("# Edit the settings below to modify how the server updates. This is an explanation of what each setting does.");
                SW.WriteLine();
                SW.WriteLine("#   autoupdate\t=\tChoose wether to automatically update to the latest version");
                SW.WriteLine("#   notify\t=\tChoose wether to notify players of the restart in-game");
                SW.WriteLine("#   restartcountdown\t=\tThe number of seconds to count down before restarting");
                SW.WriteLine();
                SW.WriteLine("autoupdate = " + chkAutoUpdate.Checked.ToString());
                SW.WriteLine("notify = " + chkNotify.Checked.ToString());
                SW.WriteLine("restartcountdown = " + txtUpdaterCountdown.Text);
                SW.Flush();
                SW.Close();
                SW.Dispose();
            }
            catch (Exception ex)
            {
                Server.ErrorLog(ex);
                Server.s.Log("SAVE FAILED! " + path);
            }
            load(path);
        }

        public void discard()
        {
            this.Close();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            discard();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            save("properties/update.properties");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save("properties/update.properties");
            discard();
        }

        private void UPropertyWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Window.upLoaded = false;
        }
    }
}
