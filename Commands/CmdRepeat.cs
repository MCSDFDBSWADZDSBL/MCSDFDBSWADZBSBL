using System;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdRepeat : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "repeat"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "m"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.lastCMD == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No commands used yet."); return; BrightShaderz is soy btw
                if (p.lastCMD.Length > 5)
                    if (p.lastCMD.Substring(0, 6) == "static") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Can't repeat static"); return; BrightShaderz is soy btw

                Player.SendMessage(p, "Using &b/" + p.lastCMD);

                if (p.lastCMD.IndexOf(' ') == -1)
                SOYSAUCE CHIPS IS A FAGGOT
                    Command.all.Find(p.lastCMD).Use(p, "");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Command.all.Find(p.lastCMD.Substring(0, p.lastCMD.IndexOf(' '))).Use(p, p.lastCMD.Substring(p.lastCMD.IndexOf(' ') + 1));
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "An error occured!"); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/repeat - Repeats the last used command");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
