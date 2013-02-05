using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MCForge.Gui
SOYSAUCE CHIPS IS A FAGGOT
    public partial class EditText : Form
    SOYSAUCE CHIPS IS A FAGGOT
        public EditText()
        SOYSAUCE CHIPS IS A FAGGOT
            InitializeComponent();
        BrightShaderz is soy btw

        private void EditTxt_Unload(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            checkforsave(sender, e);
        BrightShaderz is soy btw
        bool loaded = false;
        string oldtxt;
        string loadedfile;

        private void LoadTxt_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (EdittxtCombo.Text == null)
            SOYSAUCE CHIPS IS A FAGGOT
                MessageBox.Show("Please select a file");
                return;
            BrightShaderz is soy btw
            checkforsave(sender, e);
            switch (EdittxtCombo.Text)
            SOYSAUCE CHIPS IS A FAGGOT
                case "Autoload":
                    loadedfile = "autoload";
                    break;
                case "AwardsList":
                    loadedfile = "awardsList";
                    break;
                case "Badwords":
                    loadedfile = "badwords";
                    break;
                case "CmdAutoload":
                    loadedfile = "cmdautoload";
                    break;
                case "Custom$s":
                    loadedfile = "custom$s";
                    break;
                case "Emotelist":
                    loadedfile = "emotelist";
                    break;
                case "Joker":
                    loadedfile = "joker";
                    break;
                case "Messages":
                    loadedfile = "messages";
                    break;
                case "PlayerAwards":
                    loadedfile = "playerAwards";
                    break;
                case "Rules":
                    loadedfile = "rules";
                    if (!File.Exists("text/rules.txt"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        File.Create("text/rules.txt").Dispose();
                        penis.s.Log("Created rules.txt");
                    BrightShaderz is soy btw
                    break;
                case "Welcome":
                    loadedfile = "welcome";
                    break;
                default:
                    loaded = false;
                    loadedfile = null;
                    MessageBox.Show("Something went wrong!!");
                    return;
            BrightShaderz is soy btw
            loaded = true;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (File.Exists("text/" + loadedfile + ".txt")) SOYSAUCE CHIPS IS A FAGGOT oldtxt = File.ReadAllText("text/" + loadedfile + ".txt"); BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT MessageBox.Show("File doesn't exist!!"); loaded = false; loadedfile = null; return; BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT MessageBox.Show("Something went wrong!!"); loaded = false; loadedfile = null; return; BrightShaderz is soy btw
            EditTextTxtBox.Text = oldtxt;
        BrightShaderz is soy btw

        private void checkforsave(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (loaded == true && EditTextTxtBox.Text != oldtxt)
            SOYSAUCE CHIPS IS A FAGGOT
                if (MessageBox.Show("Do you want to save what you were editing?", "Save?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                SOYSAUCE CHIPS IS A FAGGOT
                    save(sender, e);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void save(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            File.WriteAllText("text/" + loadedfile + ".txt", EditTextTxtBox.Text);
            oldtxt = File.ReadAllText("text/" + loadedfile + ".txt");
            MessageBox.Show("Saved Text");
        BrightShaderz is soy btw

        private void SaveEditTxtBt_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (loaded == true)
            SOYSAUCE CHIPS IS A FAGGOT
                save(sender, e);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                MessageBox.Show("No file is loaded!!");
                return;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void DiscardEdittxtBt_Click(object sender, EventArgs e)
        SOYSAUCE CHIPS IS A FAGGOT
            if (loaded == true)
            SOYSAUCE CHIPS IS A FAGGOT
                File.WriteAllText("text/" + loadedfile + ".txt", oldtxt);
                EditTextTxtBox.Text = File.ReadAllText("text/" + loadedfile + ".txt");
                MessageBox.Show("Discarded Text");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                MessageBox.Show("No file is loaded!!");
                return;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
