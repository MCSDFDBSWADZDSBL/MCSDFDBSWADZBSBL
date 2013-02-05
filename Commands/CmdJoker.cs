using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdJoker : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "joker"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            bool stealth = false;
            if (message[0] == '#')
            SOYSAUCE CHIPS IS A FAGGOT
                message = message.Remove(0, 1).Trim();
                stealth = true;
                penis.s.Log("Stealth joker attempted");
            BrightShaderz is soy btw

            Player who = Player.Find(message);
            if (who == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Could not find player.");
                return;
            BrightShaderz is soy btw
            //     else if (who.group.Permission >= p.group.Permission) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot joker someone of equal or greater rank."); return; BrightShaderz is soy btw

            if (!who.joker)
            SOYSAUCE CHIPS IS A FAGGOT
                who.joker = true;
                if (stealth) SOYSAUCE CHIPS IS A FAGGOT Player.GlobalMessageOps(who.color + who.name + penis.DefaultColor + " is now STEALTH joker'd. "); return; BrightShaderz is soy btw
                Player.GlobalChat(null, who.color + who.name + penis.DefaultColor + " is now a &aJ&bo&ck&5e&9r" + penis.DefaultColor + ".", false);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                who.joker = false;
                if (stealth) SOYSAUCE CHIPS IS A FAGGOT Player.GlobalMessageOps(who.color + who.name + penis.DefaultColor + " is now STEALTH Unjoker'd. "); return; BrightShaderz is soy btw
                Player.GlobalChat(null, who.color + who.name + penis.DefaultColor + " is no longer a &aJ&bo&ck&5e&9r" + penis.DefaultColor + ".", false);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/joker <name> - Causes a player to become a joker!");
            Player.SendMessage(p, "/joker # <name> - Makes the player a joker silently");
            return;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
