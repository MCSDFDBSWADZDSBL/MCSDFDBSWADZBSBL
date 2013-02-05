using System;
using System.IO;
using System.Collections.Generic;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdLastCmd : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "lastcmd"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "last"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (Player pl in Player.players)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, pl.color + pl.name + penis.DefaultColor + " last used \"" + pl.lastCMD + "\"");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player who = Player.Find(message);
                if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find player entered"); return; BrightShaderz is soy btw
                Player.SendMessage(p, who.color + who.name + penis.DefaultColor + " last used \"" + who.lastCMD + "\"");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/last [user] - Shows last command used by [user]");
            Player.SendMessage(p, "/last by itself will show all last commands (SPAMMY)");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
