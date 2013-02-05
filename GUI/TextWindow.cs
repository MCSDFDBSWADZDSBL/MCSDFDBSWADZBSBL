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
    public partial class TextWindow : Form
    {
        public TextWindow()
        {
            InitializeComponent();
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

        private string loadedFile = "";
        private string loadedPath = "";

        private void btnClose_Click(object sender, EventArgs e)
        {
            Window.txtLoaded = false;
            this.Close();
        }

        private void reload()
        {
            cmbFile.Items.Clear();
            string[] files = System.IO.Directory.GetFiles("text/", "*.txt", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                cmbFile.Items.Add(file.Replace("text/", ""));
            }
        }

        private void TextWindow_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("MCSong.Lawl.ico"));

            Window.txtLoaded = true;
            reload();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbFile.SelectedItem != null)
            {
                loadedFile = "text/" + cmbFile.SelectedItem.ToString();
                txtEditor.Text = File.ReadAllText(loadedFile);
                loadedPath = Path.GetFullPath("text/" + cmbFile.SelectedItem.ToString());
                txtFile.Text = loadedPath;
                toolTip1.SetToolTip(txtFile, txtFile.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (loadedFile.Trim() != "" && loadedFile != null)
            {
                try
                {
                    File.WriteAllText(loadedFile, txtEditor.Text);
                    MessageBox.Show("File was saved to:\r\n" + loadedPath, "Save Successful!", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    Server.ErrorLog(ex);
                    MessageBox.Show("MCSong could not save the file: \r\n" + loadedPath, "Save Failed!", MessageBoxButtons.OK);
                }
                loadedFile = "";
                loadedPath = "";
                txtEditor.Clear();
                txtFile.Clear();
                cmbFile.SelectedItem = null;
                reload();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (loadedPath != null && loadedPath.Trim() != "")
            {
                if (MessageBox.Show("Do you really want to delete the loaded file?\r\n" + loadedPath, "Delete File?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(loadedFile);
                        MessageBox.Show("File was deleted: \r\n" + loadedPath, "Delet Successful!", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        Server.ErrorLog(ex);
                        MessageBox.Show("MCSong could not delete the file: \r\n" + loadedPath, "Delete Failed!", MessageBoxButtons.OK);
                    }
                }
                loadedFile = "";
                loadedPath = "";
                txtEditor.Clear();
                txtFile.Clear();
                cmbFile.SelectedItem = null;
                reload();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (txtNew.Text == null || txtNew.Text.Trim() == "")
            {
                return;
            }
            if (txtNew.Text.EndsWith(".txt"))
            {
                txtNew.Text = txtNew.Text.Replace(".txt", "");
            }
            if (!File.Exists("text/" + txtNew.Text + ".txt"))
            {
                try
                {
                    File.Create("text/" + txtNew.Text + ".txt");
                    MessageBox.Show("Created new: \r\n" + "text/" + txtNew.Text + ".txt", "Creation Successful!", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    Server.ErrorLog(ex);
                    MessageBox.Show("MCSong could not create the file: \r\n" + "text/" + txtNew.Text + ".txt", "Creation Failed!", MessageBoxButtons.OK);
                }
            }
            txtNew.Clear();
            loadedFile = "";
            loadedPath = "";
            txtEditor.Clear();
            txtFile.Clear();
            cmbFile.SelectedItem = null;
            reload();
        }

        private void cmbFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadedFile = "";
            loadedPath = "";
            txtEditor.Clear();
            txtFile.Clear();
        }
    }
}