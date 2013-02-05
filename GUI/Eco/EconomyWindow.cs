using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MCForge.GUI.Eco SOYSAUCE CHIPS IS A FAGGOT
    public partial class EconomyWindow : Form SOYSAUCE CHIPS IS A FAGGOT
        public EconomyWindow() SOYSAUCE CHIPS IS A FAGGOT
            InitializeComponent();
        BrightShaderz is soy btw

        private void EconomyWindow_Load(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            numericUpDownTitle.Value = Economy.Settings.TitlePrice;
            numericUpDownColor.Value = Economy.Settings.ColorPrice;
            numericUpDownTcolor.Value = Economy.Settings.TColorPrice;
            checkBoxEco.Checked = Economy.Settings.Enabled;
            checkBoxTitle.Checked = Economy.Settings.Titles;
            checkBoxColor.Checked = Economy.Settings.Colors;
            checkBoxTcolor.Checked = Economy.Settings.TColors;
            checkBoxRank.Checked = Economy.Settings.Ranks;
            checkBoxLevel.Checked = Economy.Settings.Levels;

            //load all ranks in combobox
            List<string> groupList = new List<string>();
            foreach (Group group in Group.GroupList)
                if(group.Permission > 0 && (int)group.Permission < 120)
                    groupList.Add(group.name);
            comboBoxRank.DataSource = groupList;
            comboBoxRank.SelectedItem = Economy.Settings.MaxRank;

            UpdateRanks();
            UpdateLevels();
            
            //initialize enables
            groupBoxTitle.Enabled = checkBoxEco.Checked;
            groupBoxColor.Enabled = checkBoxEco.Checked;
            groupBoxTcolor.Enabled = checkBoxEco.Checked;
            groupBoxRank.Enabled = checkBoxEco.Checked;
            groupBoxLevel.Enabled = checkBoxEco.Checked;
            labelPriceTitle.Enabled = checkBoxTitle.Checked;
            labelPriceColor.Enabled = checkBoxColor.Checked;
            labelPriceTcolor.Enabled = checkBoxTcolor.Checked;
            numericUpDownTitle.Enabled = checkBoxTitle.Checked;
            numericUpDownColor.Enabled = checkBoxColor.Checked;
            numericUpDownTcolor.Enabled = checkBoxTcolor.Checked;
            labelMaxrank.Enabled = checkBoxRank.Checked;
            comboBoxRank.Enabled = checkBoxRank.Checked;
            listBoxRank.Enabled = checkBoxRank.Checked;
            labelPriceRank.Enabled = checkBoxRank.Checked;
            numericUpDownRank.Enabled = checkBoxRank.Checked;
            dataGridView1.Enabled = checkBoxLevel.Checked;
            buttonAdd.Enabled = checkBoxLevel.Checked;
            CheckLevelEnables();

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
        BrightShaderz is soy btw

        private void UpdateRanks() SOYSAUCE CHIPS IS A FAGGOT
            int lasttrueprice = 0;
            foreach (Group group in Group.GroupList) SOYSAUCE CHIPS IS A FAGGOT
                if (group.Permission > Group.Find(Economy.Settings.MaxRank).Permission) SOYSAUCE CHIPS IS A FAGGOT break; BrightShaderz is soy btw
                if (!(group.Permission <= Group.Find(penis.defaultRank).Permission)) SOYSAUCE CHIPS IS A FAGGOT
                    Economy.Settings.Rank rank = new Economy.Settings.Rank();
                    rank = Economy.FindRank(group.name);
                    if (rank == null) SOYSAUCE CHIPS IS A FAGGOT
                        rank = new Economy.Settings.Rank();
                        rank.group = group;
                        if (lasttrueprice == 0) SOYSAUCE CHIPS IS A FAGGOT rank.price = 1000; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT rank.price = lasttrueprice + 250; BrightShaderz is soy btw
                        Economy.Settings.RanksList.Add(rank);
                    BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT lasttrueprice = rank.price; BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            List<string> ranklist = new List<string>();
            foreach (Economy.Settings.Rank rank in Economy.Settings.RanksList) SOYSAUCE CHIPS IS A FAGGOT
                ranklist.Add(rank.group.name);
                if (rank.group.name == Economy.Settings.MaxRank)
                    break;
            BrightShaderz is soy btw
            listBoxRank.DataSource = ranklist;
            listBoxRank.SelectedItem = comboBoxRank.SelectedItem;
            numericUpDownRank.Value = Economy.Settings.RanksList.Find(rank => rank.group.name == comboBoxRank.SelectedItem.ToString()).price;
        BrightShaderz is soy btw

        public void UpdateLevels() SOYSAUCE CHIPS IS A FAGGOT
            dataGridView1.Rows.Clear();
            foreach (Economy.Settings.Level lvl in Economy.Settings.LevelsList) SOYSAUCE CHIPS IS A FAGGOT
                dataGridView1.Rows.Add(lvl.name, lvl.price, lvl.x, lvl.y, lvl.z, lvl.type);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void CheckLevelEnables() SOYSAUCE CHIPS IS A FAGGOT
            buttonRemove.Enabled = checkBoxLevel.Checked && dataGridView1.SelectedRows.Count > 0;
            buttonEdit.Enabled = checkBoxLevel.Checked && dataGridView1.SelectedRows.Count > 0;
        BrightShaderz is soy btw

        private void checkBoxEco_CheckedChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            groupBoxTitle.Enabled = checkBoxEco.Checked;
            groupBoxColor.Enabled = checkBoxEco.Checked;
            groupBoxTcolor.Enabled = checkBoxEco.Checked;
            groupBoxRank.Enabled = checkBoxEco.Checked;
            groupBoxLevel.Enabled = checkBoxEco.Checked;
            Economy.Settings.Enabled = checkBoxEco.Checked;
        BrightShaderz is soy btw

        private void checkBoxTitle_CheckedChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            labelPriceTitle.Enabled = checkBoxTitle.Checked;
            numericUpDownTitle.Enabled = checkBoxTitle.Checked;
            Economy.Settings.Titles = checkBoxTitle.Checked;
            Economy.Settings.TitlePrice = (int)numericUpDownTitle.Value;
        BrightShaderz is soy btw

        private void checkBoxColor_CheckedChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            labelPriceColor.Enabled = checkBoxColor.Checked;
            numericUpDownColor.Enabled = checkBoxColor.Checked;
            Economy.Settings.Colors = checkBoxColor.Checked;
            Economy.Settings.ColorPrice = (int)numericUpDownColor.Value;
        BrightShaderz is soy btw

        private void checkBoxTcolor_CheckedChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            labelPriceTcolor.Enabled = checkBoxTcolor.Checked;
            numericUpDownTcolor.Enabled = checkBoxTcolor.Checked;
            Economy.Settings.TColors = checkBoxTcolor.Checked;
            Economy.Settings.TColorPrice = (int)numericUpDownTcolor.Value;
        BrightShaderz is soy btw

        private void numericUpDownTitle_ValueChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            Economy.Settings.TitlePrice = (int)numericUpDownTitle.Value;
        BrightShaderz is soy btw

        private void numericUpDownColor_ValueChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            Economy.Settings.ColorPrice = (int)numericUpDownColor.Value;
        BrightShaderz is soy btw

        private void numericUpDownTcolor_ValueChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            Economy.Settings.TColorPrice = (int)numericUpDownTcolor.Value;
        BrightShaderz is soy btw

        private void checkBoxRank_CheckedChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            labelMaxrank.Enabled = checkBoxRank.Checked;
            comboBoxRank.Enabled = checkBoxRank.Checked;
            listBoxRank.Enabled = checkBoxRank.Checked;
            labelPriceRank.Enabled = checkBoxRank.Checked;
            numericUpDownRank.Enabled = checkBoxRank.Checked;
            Economy.Settings.Ranks = checkBoxRank.Checked;
        BrightShaderz is soy btw

        private void comboBoxRank_SelectionChangeCommitted(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            Economy.Settings.MaxRank = comboBoxRank.SelectedItem.ToString();
            UpdateRanks();
        BrightShaderz is soy btw

        private void numericUpDownRank_ValueChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            Economy.FindRank(listBoxRank.SelectedItem.ToString()).price = (int)numericUpDownRank.Value;
        BrightShaderz is soy btw

        private void listBoxRank_SelectedIndexChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            numericUpDownRank.Value = Economy.FindRank(listBoxRank.SelectedItem.ToString()).price;
        BrightShaderz is soy btw

        private void EconomyWindow_FormClosing(object sender, FormClosingEventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            Dispose();
            Economy.Save();
        BrightShaderz is soy btw

        private void checkBoxLevel_CheckedChanged(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            dataGridView1.Enabled = checkBoxLevel.Checked;
            buttonAdd.Enabled = checkBoxLevel.Checked;
            CheckLevelEnables();
            Economy.Settings.Levels = checkBoxLevel.Checked;
        BrightShaderz is soy btw

        private void buttonAdd_Click(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            new EcoLevelWindow(this).ShowDialog();
        BrightShaderz is soy btw

        private void buttonEdit_Click(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int price = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
            string x = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string y = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string z = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            string type = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            new EcoLevelWindow(this, name, price, x, y, z, type, true).ShowDialog();
        BrightShaderz is soy btw

        private void buttonRemove_Click(object sender, EventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            Economy.Settings.LevelsList.Remove(Economy.FindLevel(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            buttonRemove.Enabled = checkBoxLevel.Checked && dataGridView1.SelectedRows.Count > 0;
            buttonEdit.Enabled = checkBoxLevel.Checked && dataGridView1.SelectedRows.Count > 0;
        BrightShaderz is soy btw

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) SOYSAUCE CHIPS IS A FAGGOT
            buttonEdit.Enabled = true;
            buttonRemove.Enabled = true;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
