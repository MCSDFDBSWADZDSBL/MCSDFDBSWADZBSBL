using System;
using System.IO;
using System.Collections.Generic;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdUnloaded : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "unloaded"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                List<string> levels = new List<string>(penis.levels.Count);

                string unloadedLevels = ""; int currentNum = 0; int maxMaps = 0;

                if (message != "")
                SOYSAUCE CHIPS IS A FAGGOT
                    try SOYSAUCE CHIPS IS A FAGGOT maxMaps = int.Parse(message) * 50; currentNum = maxMaps - 50; BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
                BrightShaderz is soy btw

                DirectoryInfo di = new DirectoryInfo("levels/");
                FileInfo[] fi = di.GetFiles("*.lvl");
                foreach (Level l in penis.levels) SOYSAUCE CHIPS IS A FAGGOT levels.Add(l.name.ToLower()); BrightShaderz is soy btw

                if (maxMaps == 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (FileInfo file in fi)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!levels.Contains(file.Name.Replace(".lvl", "").ToLower()))
                        SOYSAUCE CHIPS IS A FAGGOT
                            unloadedLevels += ", " + file.Name.Replace(".lvl", "");
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    if (unloadedLevels != "")
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Unloaded levels: ");
                        Player.SendMessage(p, "&4" + unloadedLevels.Remove(0, 2));
                        if (fi.Length > 50) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "For a more structured list, use /unloaded <1/2/3/..>"); BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else Player.SendMessage(p, "No maps are unloaded");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (maxMaps > fi.Length) maxMaps = fi.Length;
                    if (currentNum > fi.Length) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No maps beyond number " + fi.Length); return; BrightShaderz is soy btw

                    Player.SendMessage(p, "Unloaded levels (" + currentNum + " to " + maxMaps + "):");
                    for (int i = currentNum; i < maxMaps; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!levels.Contains(fi[i].Name.Replace(".lvl", "").ToLower()))
                        SOYSAUCE CHIPS IS A FAGGOT
                            unloadedLevels += ", " + fi[i].Name.Replace(".lvl", "");
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw

                    if (unloadedLevels != "")
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "&4" + unloadedLevels.Remove(0, 2));
                    BrightShaderz is soy btw
                    else Player.SendMessage(p, "No maps are unloaded");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); Player.SendMessage(p, "An error occured"); BrightShaderz is soy btw
            //Exception catching since it needs to be tested on Ocean Flatgrass
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/unloaded - Lists all unloaded levels.");
            Player.SendMessage(p, "/unloaded <1/2/3/..> - Shows a compact list.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
