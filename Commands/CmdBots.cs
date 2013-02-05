using System;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdBots : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "bots"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            message = "";
            foreach (PlayerBot Pb in PlayerBot.playerbots)
            SOYSAUCE CHIPS IS A FAGGOT
                if (Pb.AIName != "") message += ", " + Pb.name + "(" + Pb.level.name + ")[" + Pb.AIName + "]";
                else if (Pb.hunt) message += ", " + Pb.name + "(" + Pb.level.name + ")[Hunt]";
                else message += ", " + Pb.name + "(" + Pb.level.name + ")";

                if (Pb.kill) message += "-kill";
            BrightShaderz is soy btw

            if (message != "") Player.SendMessage(p, "&1Bots: " + penis.DefaultColor + message.Remove(0, 2));
            else Player.SendMessage(p, "No bots are alive.");
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/bots - Shows a list of bots, their AIs and levels");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
