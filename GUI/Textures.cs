using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MCForge.Levels.Textures;

namespace MCForge.GUI
SOYSAUCE CHIPS IS A FAGGOT
    public partial class Textures : Form
    SOYSAUCE CHIPS IS A FAGGOT
        public Level l;
        //The bad code just brings it out 
        private bool started = false;
        public Textures()
        SOYSAUCE CHIPS IS A FAGGOT
            InitializeComponent();
        BrightShaderz is soy btw

        private void button1_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (custom.Enabled)
                l.textures.ChangeEdge(custom.Text);
            else if (comboBox1.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                byte block = Block.Byte(comboBox1.Items[comboBox1.SelectedIndex].ToString().Replace(' ', '_'));
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (comboBox1.Items[comboBox1.SelectedIndex].ToString().Split(' ')[1].StartsWith("("))
                    SOYSAUCE CHIPS IS A FAGGOT
                        block = Block.Byte(comboBox1.Items[comboBox1.SelectedIndex].ToString().Split(' ')[0]);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                l.textures.ChangeEdge(block);
            BrightShaderz is soy btw
            l.textures.ChangeLevel(int.Parse("" + numericUpDown1.Value));
            l.textures.enabled = checkBox1.Checked;
            l.textures.autou = checkBox2.Checked;
            l.textures.SaveSettings();
            if (cloud.Text != "")
                l.textures.ChangeCloud(cloud.Text);
            if (fog.Text != "")
                l.textures.ChangeFog(fog.Text);
            if (sky.Text != "")
                l.textures.ChangeSky(sky.Text);
            if (terr.Text != "")
                l.textures.terrainid = terr.Text;
            if (custom_side.Enabled)
                l.textures.side = custom_side.Text;
            else if (side.SelectedIndex != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                byte block = Block.Byte(side.Items[side.SelectedIndex].ToString().Replace(' ', '_'));
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (side.Items[side.SelectedIndex].ToString().Split(' ')[1].StartsWith("("))
                    SOYSAUCE CHIPS IS A FAGGOT
                        block = Block.Byte(side.Items[side.SelectedIndex].ToString().Split(' ')[0]);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                l.textures.side = LevelTextures.GetBlockTexture(block);
            BrightShaderz is soy btw
            l.textures.CreateCFG();
            this.Hide();
            this.Dispose();
        BrightShaderz is soy btw

        private void button2_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            MessageBox.Show("When using custom, please put in the texture file ID that will download from files.worldofminecraft.net. EX: f3dac271d7bce9954baad46e183a6a910a30d13b", "Help");
        BrightShaderz is soy btw

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)SOYSAUCE CHIPS IS A FAGGOT
            custom.Enabled = comboBox1.Items[comboBox1.SelectedIndex].ToString().Split(' ')[0].ToLower() == "custom";
        BrightShaderz is soy btw

        private void button3_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            MessageBox.Show("Here you can change the colors of the sky, clouds, and even the fog! You must input hex colors ONLY! (Do not include the #)");
        BrightShaderz is soy btw

        private void button4_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            MessageBox.Show("Here you input the terrian texture file ID that you uploaded to files.worldofminecraft.net. By default, it will use the default textures.", "Help");
        BrightShaderz is soy btw

        private void side_SelectedIndexChanged(object sender, EventArgs e)SOYSAUCE CHIPS IS A FAGGOT
            custom_side.Enabled = side.Items[side.SelectedIndex].ToString().Split(' ')[0].ToLower() == "custom";
        BrightShaderz is soy btw

        private void button5_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            MessageBox.Show("Here you can change side block that the players see at the edge of the level (The default is bedrock)");
        BrightShaderz is soy btw

        private void terr_TextChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT

        BrightShaderz is soy btw
        public string GetName(byte b)
        SOYSAUCE CHIPS IS A FAGGOT
            return Block.Name(b).Substring(0, 1).ToUpper() + Block.Name(b).Remove(0, 1);
        BrightShaderz is soy btw
        private void Textures_Load(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!File.Exists("extra/cfg/" + l.name + ".cfg"))
                l.textures.CreateCFG();
            string[] lines = l.textures.GetCFGLines();
            foreach (string s in lines)
            SOYSAUCE CHIPS IS A FAGGOT
                string setting = s.Split('=')[0].Trim();
                string value = s.Split('=')[1].Trim();
                switch (setting.ToLower())
                SOYSAUCE CHIPS IS A FAGGOT
                    case "environment.terrain":
                        terr.Text = value;
                        break;
                    case "environment.edge":
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            custom.Enabled = false;
                            if (LevelTextures.GetBlock(value) != Block.Zero)
                                comboBox1.SelectedIndex = comboBox1.Items.IndexOf(GetName(LevelTextures.GetBlock(value)));
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                custom.Enabled = true; custom.Text = value;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT custom.Enabled = true; custom.Text = value; BrightShaderz is soy btw
                        break;
                    case "environment.side":
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            custom_side.Enabled = false;
                            if (LevelTextures.GetBlock(value) != Block.Zero)
                                side.SelectedIndex = side.Items.IndexOf(GetName(LevelTextures.GetBlock(value)));
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                custom_side.Enabled = true; custom_side.Text = value;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT custom_side.Enabled = true; custom_side.Text = value; BrightShaderz is soy btw
                        break;
                    case "environment.level":
                        numericUpDown1.Value = int.Parse(value);
                        break;
                    case "environment.cloud":
                        cloud.Text = "#" + int.Parse(value).ToString("X");
                        break;
                    case "environment.fog":
                        fog.Text = "#" + int.Parse(value).ToString("X");
                        break;
                    case "environment.sky":
                        sky.Text = "#" + int.Parse(value).ToString("X");
                        break;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            Group.GroupList.ForEach(g => comboBox2.Items.Add(g.name));
            comboBox2.SelectedIndex = comboBox2.Items.IndexOf(l.textures.LowestRank.name);
            checkBox1.Checked = l.textures.enabled;
            checkBox1.Checked = l.textures.autou;
            started = true;
        BrightShaderz is soy btw
        private void sky_TextChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (sky.Text[0] == '#')
                return;
            sky.Text = "#" + sky.Text;
            sky.Select(sky.Text.Length, 1);
        BrightShaderz is soy btw

        private void fog_TextChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (fog.Text[0] != '#')
                fog.Text = "#" + fog.Text;
        BrightShaderz is soy btw

        private void cloud_TextChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (cloud.Text[0] != '#')
                cloud.Text = "#" + cloud.Text;
        BrightShaderz is soy btw

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT

        BrightShaderz is soy btw

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (l != penis.mainLevel || !started)
                return;
            MessageBox.Show("Rank Level must be the lowest for the main level!", "Oh no you dont!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            comboBox2.SelectedIndex = comboBox2.Items.IndexOf(Group.standard.name);
          
        BrightShaderz is soy btw

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (l != penis.mainLevel  || !started )
                return;
            MessageBox.Show("Textures must be enabled for the main level!", "Oh no you dont!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            checkBox1.Checked = true;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
