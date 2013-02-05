using System;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdMute : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mute"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "" || message.Split(' ').Length > 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            Player who = Player.Find(message);
            if (who == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "The player entered is not online.");
                return;
            BrightShaderz is soy btw
            if (who.muted)
            SOYSAUCE CHIPS IS A FAGGOT
                who.muted = false;
                Player.GlobalChat(null, who.color + who.name + penis.DefaultColor + " has been &bun-muted", false);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (p != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (who != p) if (who.group.Permission > p.group.Permission) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot mute someone of a higher rank."); return; BrightShaderz is soy btw
                BrightShaderz is soy btw
                who.muted = true;
                Player.GlobalChat(null, who.color + who.name + penis.DefaultColor + " has been &8muted", false);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/mute <player> - Mutes or unmutes the player.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
