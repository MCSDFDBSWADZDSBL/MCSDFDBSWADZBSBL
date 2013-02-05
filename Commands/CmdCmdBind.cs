using System;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdCmdBind : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "cmdbind"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "cb"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            string foundcmd, foundmessage = ""; int foundnum = 0;

            if (message.IndexOf(' ') == -1)
            SOYSAUCE CHIPS IS A FAGGOT
                bool OneFound = false;
                for (int i = 0; i < 10; i++)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.cmdBind[i] != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "&c/" + i + penis.DefaultColor + " bound to &b" + p.cmdBind[i] + " " + p.messageBind[i]);
                        OneFound = true;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (!OneFound) Player.SendMessage(p, "You have no commands binded");
                return;
            BrightShaderz is soy btw

            if (message.Split(' ').Length == 1)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    foundnum = Convert.ToInt16(message);
                    if (p.cmdBind[foundnum] == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No command stored here yet."); return; BrightShaderz is soy btw
                    foundcmd = "/" + p.cmdBind[foundnum] + " " + p.messageBind[foundnum];
                    Player.SendMessage(p, "Stored command: &b" + foundcmd);
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT Help(p); BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (message.Split(' ').Length > 1)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    foundnum = Convert.ToInt16(message.Split(' ')[message.Split(' ').Length - 1]);
                    foundcmd = message.Split(' ')[0];
                    if (message.Split(' ').Length > 2)
                    SOYSAUCE CHIPS IS A FAGGOT
                        foundmessage = message.Substring(message.IndexOf(' ') + 1);
                        foundmessage = foundmessage.Remove(foundmessage.LastIndexOf(' '));
                    BrightShaderz is soy btw

                    p.cmdBind[foundnum] = foundcmd;
                    p.messageBind[foundnum] = foundmessage;

                    Player.SendMessage(p, "Binded &b/" + foundcmd + " " + foundmessage + " to &c/" + foundnum);
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT Help(p); BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/cmdbind [command] [num] - Binds [command] to [num]");
            Player.SendMessage(p, "[num] must be between 0 and 9");
            Player.SendMessage(p, "Use with \"/[num]\" &b(example: /2)");
            Player.SendMessage(p, "Use /cmdbind [num] to see stored commands.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
