using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdModerate : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "moderate"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message != "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            if (penis.chatmod)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.chatmod = false;
                Player.GlobalChat(null, penis.DefaultColor + "Chat moderation has been disabled.  Everyone can now speak.", false);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                penis.chatmod = true;
                Player.GlobalChat(null, penis.DefaultColor + "Chat moderation engaged!  Silence the plebians!", false);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/moderate - Toggles chat moderation status.  When enabled, only voiced");
            Player.SendMessage(p, "players may speak.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
