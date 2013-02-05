using System;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdGive : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "give"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "gib"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message.IndexOf(' ') == -1) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (message.Split(' ').Length != 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            Player who = Player.Find(message.Split(' ')[0]);
            if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find player entered"); return; BrightShaderz is soy btw
            if (who == p) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Sorry. Can't allow you to give " + penis.moneys + " to yourself"); return; BrightShaderz is soy btw

            int amountGiven;
            try SOYSAUCE CHIPS IS A FAGGOT amountGiven = int.Parse(message.Split(' ')[1]); BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid amount"); return; BrightShaderz is soy btw

            if (who.money + amountGiven > 16777215) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Players cannot have over 16777215 " + penis.moneys); return; BrightShaderz is soy btw
            if (amountGiven < 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot give someone negative " + penis.moneys); return; BrightShaderz is soy btw

            who.money += amountGiven;
            Player.GlobalMessage(who.color + who.prefix + who.name + penis.DefaultColor + " was given " + amountGiven + " " + penis.moneys);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/give [player] <amount> - Gives [player] <amount> " + penis.moneys);
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
