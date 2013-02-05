using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdView : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "view"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!Directory.Exists("extra/text/")) Directory.CreateDirectory("extra/text");
            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                DirectoryInfo di = new DirectoryInfo("extra/text/");
                string allFiles = "";
                foreach (FileInfo fi in di.GetFiles("*.txt"))
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        string firstLine = File.ReadAllLines("extra/text/" + fi.Name.Substring(0, fi.Name.Length - fi.Extension.Length) + ".txt")[0];
                        if (firstLine[0] == '#')
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (Group.Find(firstLine.Substring(1)).Permission <= p.group.Permission)
                            SOYSAUCE CHIPS IS A FAGGOT
                                allFiles += ", " + fi.Name.Substring(0, fi.Name.Length - fi.Extension.Length);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            allFiles += ", " + fi.Name;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); Player.SendMessage(p, "Error"); BrightShaderz is soy btw
                BrightShaderz is soy btw

                if (allFiles == "")
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "No files are viewable by you");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Available files:");
                    Player.SendMessage(p, allFiles.Remove(0, 2));
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player who = null;
                if (message.IndexOf(' ') != -1)
                SOYSAUCE CHIPS IS A FAGGOT
                    who = Player.Find(message.Split(' ')[message.Split(' ').Length - 1]);
                    if (who != null)
                        message = message.Substring(0, message.LastIndexOf(' '));
                BrightShaderz is soy btw
                if (who == null) who = p;

                if (File.Exists("extra/text/" + message + ".txt"))
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        string[] allLines = File.ReadAllLines("extra/text/" + message + ".txt");
                        if (allLines[0][0] == '#')
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (Group.Find(allLines[0].Substring(1)).Permission <= p.group.Permission)
                            SOYSAUCE CHIPS IS A FAGGOT
                                for (int i = 1; i < allLines.Length; i++)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(who, allLines[i]);
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "You cannot view this file");
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            for (int i = 1; i < allLines.Length; i++)
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(who, allLines[i]);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "An error occurred when retrieving the file"); BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "File specified doesn't exist");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/view [file] [player] - Views [file]'s contents");
            Player.SendMessage(p, "/view by itself will list all files you can view");
            Player.SendMessage(p, "If [player] is give, that player is shown the file");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
