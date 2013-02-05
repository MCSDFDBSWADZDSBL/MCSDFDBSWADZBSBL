using System;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdTake : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "take"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message.IndexOf(' ') == -1) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (message.Split(' ').Length != 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            Player who = Player.Find(message.Split(' ')[0]);
            if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find player entered"); return; BrightShaderz is soy btw
            if (who == p) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Sorry. Can't allow you to take money from yourself"); return; BrightShaderz is soy btw

            int amountTaken;
            try SOYSAUCE CHIPS IS A FAGGOT amountTaken = int.Parse(message.Split(' ')[1]); BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid amount"); return; BrightShaderz is soy btw

            if (who.money - amountTaken < 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Players cannot have under 0 " + penis.moneys); return; BrightShaderz is soy btw
            if (amountTaken < 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot take negative " + penis.moneys); return; BrightShaderz is soy btw

            who.money -= amountTaken;
            Player.GlobalMessage(who.color + who.prefix + who.name + penis.DefaultColor + " was rattled down for " + amountTaken + " " + penis.moneys);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/take [player] <amount> - Takes <amount> of " + penis.moneys + " from [player]");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
