using System;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdPay : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "pay"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message.IndexOf(' ') == -1) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (message.Split(' ').Length != 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            Player who = Player.Find(message.Split(' ')[0]);
            if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find player entered"); return; BrightShaderz is soy btw
            if (who == p) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Sorry. Can't allow you to pay yourself"); return; BrightShaderz is soy btw

            int amountPaid;
            try SOYSAUCE CHIPS IS A FAGGOT amountPaid = int.Parse(message.Split(' ')[1]); BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid amount"); return; BrightShaderz is soy btw

            if (who.money + amountPaid > 16777215) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Players cannot have over 16777215 " + penis.moneys); return; BrightShaderz is soy btw
            if (p.money - amountPaid < 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You don't have that much " + penis.moneys); return; BrightShaderz is soy btw
            if (amountPaid < 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot pay negative " + penis.moneys); return; BrightShaderz is soy btw

            who.money += amountPaid;
            p.money -= amountPaid;
            Player.GlobalMessage(p.color + p.name + penis.DefaultColor + " paid " + who.color + who.name + penis.DefaultColor + " " + amountPaid + " " + penis.moneys);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/pay [player] <amount> - Pays <amount> of " + penis.moneys + " to [player]");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
