using System;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdInvincible : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "invincible"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            Player who;
            if (message != "")
            SOYSAUCE CHIPS IS A FAGGOT
                who = Player.Find(message);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                who = p;
            BrightShaderz is soy btw

            if (who == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Cannot find player.");
                return;
            BrightShaderz is soy btw

            if (who.group.Permission > p.group.Permission)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Cannot toggle invincibility for someone of higher rank");
                return;
            BrightShaderz is soy btw

            if (who.invincible == true)
            SOYSAUCE CHIPS IS A FAGGOT
                who.invincible = false;
                if (penis.cheapMessage)
                    Player.GlobalChat(p, who.color + who.name + penis.DefaultColor + " has stopped being immortal", false);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                who.invincible = true;
                if (penis.cheapMessage)
                    Player.GlobalChat(p, who.color + who.name + penis.DefaultColor + " " + penis.cheapMessageGiven, false);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/invincible [name] - Turns invincible mode on/off.");
            Player.SendMessage(p, "If [name] is given, that player's invincibility is toggled");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
