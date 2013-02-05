using System;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdMode : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mode"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.modeType != 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "&b" + Block.Name(p.modeType)[0].ToString().ToUpper() + Block.Name(p.modeType).Remove(0, 1).ToLower() + penis.DefaultColor + " mode: &cOFF");
                    p.modeType = 0;
                    p.BlockAction = 0;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Help(p); return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                byte b = Block.Byte(message);
                if (b == Block.Zero) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find block given."); return; BrightShaderz is soy btw
                if (b == Block.air) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot use Air Mode."); return; BrightShaderz is soy btw
                if (!Block.canPlace(p, b)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot place this block at your rank."); return; BrightShaderz is soy btw

                if (p.modeType == b)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "&b" + Block.Name(p.modeType)[0].ToString().ToUpper() + Block.Name(p.modeType).Remove(0, 1).ToLower() + penis.DefaultColor + " mode: &cOFF");
                    p.modeType = 0;
                    p.BlockAction = 0;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    p.BlockAction = 6;
                    p.modeType = b;
                    Player.SendMessage(p, "&b" + Block.Name(p.modeType)[0].ToString().ToUpper() + Block.Name(p.modeType).Remove(0, 1).ToLower() + penis.DefaultColor + " mode: &aON");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/mode [block] - Makes every block placed into [block].");
            Player.SendMessage(p, "/[block] also works");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
