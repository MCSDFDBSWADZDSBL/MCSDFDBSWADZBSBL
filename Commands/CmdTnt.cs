using System;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdTnt : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "tnt"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message.Split(' ').Length > 1) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            if (p.BlockAction == 13 || p.BlockAction == 14)
            SOYSAUCE CHIPS IS A FAGGOT
                p.BlockAction = 0; Player.SendMessage(p, "TNT mode is now &cOFF" + penis.DefaultColor + ".");
            BrightShaderz is soy btw
            else if (message.ToLower() == "small" || message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                p.BlockAction = 13; Player.SendMessage(p, "TNT mode is now &aON" + penis.DefaultColor + ".");
            BrightShaderz is soy btw
            else if (message.ToLower() == "big")
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.group.Permission > LevelPermission.AdvBuilder)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.BlockAction = 14; Player.SendMessage(p, "TNT mode is now &aON" + penis.DefaultColor + ".");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "This mode is reserved for OPs");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
            BrightShaderz is soy btw

            p.painting = false;
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/tnt [small/big] - Creates exploding TNT (with Physics 3).");
            Player.SendMessage(p, "Big TNT is reserved for OP+.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
