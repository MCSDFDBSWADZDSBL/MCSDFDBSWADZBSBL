using System;
using System.IO;
using System.Collections.Generic;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdLowlag : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "lowlag"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message != "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            if (penis.updateTimer.Interval > 1000)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.updateTimer.Interval = 100;
                Player.GlobalChat(null, "&dLow lag " + penis.DefaultColor + "mode was turned &cOFF" + penis.DefaultColor + ".", false);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                penis.updateTimer.Interval = 10000;
                Player.GlobalChat(null, "&dLow lag " + penis.DefaultColor + "mode was turned &aON" + penis.DefaultColor + ".", false);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/lowlag - Turns lowlag mode on or off");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
