using System;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdLimit : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "limit"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message.Split(' ').Length != 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            int newLimit;
            try SOYSAUCE CHIPS IS A FAGGOT newLimit = int.Parse(message.Split(' ')[1]); BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid limit amount"); return; BrightShaderz is soy btw
            if (newLimit < 1) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot set below 1."); return; BrightShaderz is soy btw

            Group foundGroup = Group.Find(message.Split(' ')[0]);
            if (foundGroup != null)
            SOYSAUCE CHIPS IS A FAGGOT
                foundGroup.maxBlocks = newLimit;
                Player.GlobalChat(null, foundGroup.color + foundGroup.name + penis.DefaultColor + "'s building limits were set to &b" + newLimit, false);
                Group.saveGroups(Group.GroupList);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                switch (message.Split(' ')[0].ToLower())
                SOYSAUCE CHIPS IS A FAGGOT
                    case "rp":
                    case "restartphysics":
                        penis.rpLimit = newLimit;
                        Player.GlobalMessage("Custom /rp's limit was changed to &b" + newLimit.ToString());
                        break;
                    case "rpnorm":
                    case "rpnormal":
                        penis.rpNormLimit = newLimit;
                        Player.GlobalMessage("Normal /rp's limit was changed to &b" + newLimit.ToString());
                        break;

                    default:
                        Player.SendMessage(p, "No supported /limit");
                        break;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/limit <type> <amount> - Sets the limit for <type>");
            Player.SendMessage(p, "<types> - " + Group.concatList(true, true) + ", RP, RPNormal");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
