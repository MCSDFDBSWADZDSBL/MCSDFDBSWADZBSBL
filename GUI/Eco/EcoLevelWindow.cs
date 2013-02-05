using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MCForge.GUI.Eco SOYSAUCE CHIPS IS A FAGGOT
    public partial class EcoLevelWindow : Form SOYSAUCE CHIPS IS A FAGGOT

        private bool edit = false;
        private struct LevelEdit SOYSAUCE CHIPS IS A FAGGOT
            public string name, x, y, z, oldname;
            public int price;
            public string type;
        BrightShaderz is soy btw
        private LevelEdit lvledit;

        EconomyWindow eco;

        public EcoLevelWindow(EconomyWindow eco, string name = "", int price = 0, string x = "", string y = "", string z = "", string type = "", bool edit = false) SOYSAUCE CHIPS IS A FAGGOT
            this.edit = edit;
            this.eco = eco;
            lvledit.name = name;
            lvledit.oldname = name;
            lvledit.price = price;
            lvledit.x = x;
            lvledit.y = y;
            lvledit.z = z;
            lvledit.type = type;

            InitializeComponent();

            SystemEvents.UserPreferenceChanged += new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            this.Font = SystemFonts.IconTitleFont;
        BrightShaderz is soy btw

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            if (e.Category == UserPreferenceCategory.Window) SOYSAUCE CHIPS IS A FAGGOT
                this.Font = SystemFonts.IconTitleFont;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void PropertyWindow_FormClosing(object sender, FormClosingEventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            SystemEvents.UserPreferenceChanged -= new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            edit = false;
        BrightShaderz is soy btw

        private void EcoLevelWindow_Load(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            List<string> dimensionsX = new List<string>();
            string[] dimensionsY = new string[6];
            string[] dimensionsZ = new string[6];
            dimensionsX.Add("16");
            dimensionsX.Add("32");
            dimensionsX.Add("64");
            dimensionsX.Add("128");
            dimensionsX.Add("256");
            dimensionsX.Add("512");
            dimensionsX.CopyTo(dimensionsY);
            dimensionsX.CopyTo(dimensionsZ);
            comboBoxX.DataSource = dimensionsX;
            comboBoxY.DataSource = dimensionsY;
            comboBoxZ.DataSource = dimensionsZ;

            List<string> types = new List<string>();
            types.Add("Flat");
            types.Add("Pixel");
            types.Add("Island");
            types.Add("Mountains");
            types.Add("Ocean");
            types.Add("Forest");
            types.Add("Desert");
            types.Add("Space");
            types.Add("Rainbow");
            types.Add("Hell");
            comboBoxType.DataSource = types;

            if (edit) SOYSAUCE CHIPS IS A FAGGOT
                textBoxName.Text = lvledit.name;
                numericUpDownPrice.Value = lvledit.price;
                comboBoxX.SelectedItem = lvledit.x;
                comboBoxY.SelectedItem = lvledit.y;
                comboBoxZ.SelectedItem = lvledit.z;
                comboBoxType.SelectedItem = lvledit.type;
            BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                numericUpDownPrice.Value = 1000;
                comboBoxX.SelectedItem = "64";
                comboBoxY.SelectedItem = "64";
                comboBoxZ.SelectedItem = "64";
                comboBoxType.SelectedItem = "Flat";
            BrightShaderz is soy btw
            buttonOk.Enabled = edit;
        BrightShaderz is soy btw

        private void buttonCancel_Click(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            this.Close();
        BrightShaderz is soy btw

        private void buttonOk_Click(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            if (edit) Economy.Settings.LevelsList.Remove(Economy.FindLevel(lvledit.oldname));
            Economy.Settings.Level level = new Economy.Settings.Level();
            level.name = textBoxName.Text.Split()[0];
            level.price = (int)numericUpDownPrice.Value;
            level.x = comboBoxX.SelectedItem.ToString();
            level.y = comboBoxY.SelectedItem.ToString();
            level.z = comboBoxZ.SelectedItem.ToString();
            level.type = comboBoxType.SelectedItem.ToString().ToLower();
            Economy.Settings.LevelsList.Add(level);
            eco.UpdateLevels();
            eco.CheckLevelEnables();
            this.Close();
        BrightShaderz is soy btw

        private void textBoxName_TextChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            buttonOk.Enabled = textBoxName.Text != null && textBoxName.Text != String.Empty && textBoxName.Text != "";
        BrightShaderz is soy btw

    BrightShaderz is soy btw
BrightShaderz is soy btw
