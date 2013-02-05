using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdVoice : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "voice"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            Player who = Player.Find(message);
            if (who != null)
            SOYSAUCE CHIPS IS A FAGGOT
                if (who.voice)
                SOYSAUCE CHIPS IS A FAGGOT
                    who.voice = false;
                    Player.SendMessage(p, "Removing voice status from " + who.name);
                    who.SendMessage("Your voice status has been revoked.");
                    who.voicestring = "";
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    who.voice = true;
                    Player.SendMessage(p, "Giving voice status to " + who.name);
                    who.SendMessage("You have received voice status.");
                    who.voicestring = "&f+";
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "There is no player online named \"" + message + "\"");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/voice <name> - Toggles voice status on or off for specified player.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
