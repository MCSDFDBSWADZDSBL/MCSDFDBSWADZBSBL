using System;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdFreeze : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "freeze"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            Player who = Player.Find(message);
            if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find player."); return; BrightShaderz is soy btw
            else if (who == p) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot freeze yourself."); return; BrightShaderz is soy btw
            else if (who.group.Permission >= p.group.Permission) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot freeze someone of equal or greater rank."); return; BrightShaderz is soy btw

            if (!who.frozen)
            SOYSAUCE CHIPS IS A FAGGOT
                who.frozen = true;
                Player.GlobalChat(null, who.color + who.name + penis.DefaultColor + " has been &bfrozen.", false);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                who.frozen = false;
                Player.GlobalChat(null, who.color + who.name + penis.DefaultColor + " has been &adefrosted.", false);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/freeze <name> - Stops <name> from moving until unfrozen.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
