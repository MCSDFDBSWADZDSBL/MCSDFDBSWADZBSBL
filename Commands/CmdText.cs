using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdText : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "text"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!Directory.Exists("extra/text/")) Directory.CreateDirectory("extra/text");
            if (message.IndexOf(' ') == -1) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (message.Split(' ')[0].ToLower() == "delete")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (File.Exists("extra/text/" + message.Split(' ')[1] + ".txt"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        File.Delete("extra/text/" + message.Split(' ')[1] + ".txt");
                        Player.SendMessage(p, "Deleted file");
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Could not find file specified");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    bool again = false;
                    string fileName = "extra/text/" + message.Split(' ')[0] + ".txt";
                    string group = Group.findPerm(LevelPermission.Guest).name;
                    if (Group.Find(message.Split(' ')[1]) != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        group = Group.Find(message.Split(' ')[1]).name;
                        again = true;
                    BrightShaderz is soy btw
                    message = message.Substring(message.IndexOf(' ') + 1);
                    if (again)
                        message = message.Substring(message.IndexOf(' ') + 1);
                    string contents = message;
                    if (contents == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
                    if (!File.Exists(fileName))
                        contents = "#" + group + System.Environment.NewLine + contents;
                    else
                        contents = " " + contents;
                    File.AppendAllText(fileName, contents);
                    Player.SendMessage(p, "Added text");
                BrightShaderz is soy btw
            BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT Help(p); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/text [file] [rank] [message] - Makes a /view-able text");
            Player.SendMessage(p, "The [rank] entered is the minimum rank to view the file");
            Player.SendMessage(p, "The [message] is entered into the text file");
            Player.SendMessage(p, "If the file already exists, text will be added to the end");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
