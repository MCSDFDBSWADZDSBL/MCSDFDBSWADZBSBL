using System;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdKill : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "kill"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            Player who; string killMsg; int killMethod = 0;
            if (message.IndexOf(' ') == -1)
            SOYSAUCE CHIPS IS A FAGGOT
                who = Player.Find(message);
                killMsg = " was killed by " + p.color + p.name;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                who = Player.Find(message.Split(' ')[0]);
                message = message.Substring(message.IndexOf(' ') + 1);

                if (message.IndexOf(' ') == -1)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (message.ToLower() == "explode")
                    SOYSAUCE CHIPS IS A FAGGOT
                        killMsg = " was exploded by " + p.color + p.name;
                        killMethod = 1;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        killMsg = " " + message;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (message.Split(' ')[0].ToLower() == "explode")
                    SOYSAUCE CHIPS IS A FAGGOT
                        killMethod = 1;
                        message = message.Substring(message.IndexOf(' ') + 1);
                    BrightShaderz is soy btw

                    killMsg = " " + message;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (who == null)
            SOYSAUCE CHIPS IS A FAGGOT
                p.HandleDeath(Block.rock, " killed itself in its confusion");
                Player.SendMessage(p, "Could not find player");
                return;
            BrightShaderz is soy btw

            if (who.group.Permission > p.group.Permission)
            SOYSAUCE CHIPS IS A FAGGOT
                p.HandleDeath(Block.rock, " was killed by " + who.color + who.name);
                Player.SendMessage(p, "Cannot kill someone of higher rank");
                return;
            BrightShaderz is soy btw

            if (killMethod == 1)
                who.HandleDeath(Block.rock, killMsg, true);
            else
                who.HandleDeath(Block.rock, killMsg);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/kill <name> [explode] <message>");
            Player.SendMessage(p, "Kills <name> with <message>. Causes explosion if [explode] is written");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
