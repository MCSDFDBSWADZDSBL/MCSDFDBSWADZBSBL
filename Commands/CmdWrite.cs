using System;
using System.Collections.Generic;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdWrite : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "write"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            CatchPos cpos;

            cpos.givenMessage = message.ToUpper();
            cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;
            Player.SendMessage(p, "Place two blocks to determine direction.");
            p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/write [message] - Writes [message] in blocks");
        BrightShaderz is soy btw
        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            CatchPos bp = (CatchPos)p.blockchangeObject;
            bp.x = x; bp.y = y; bp.z = z; p.blockchangeObject = bp;
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange2);
        BrightShaderz is soy btw
        public void Blockchange2(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            type = p.bindings[type];

            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);

            CatchPos cpos = (CatchPos)p.blockchangeObject;

            ushort cur;

            if (x == cpos.x && z == cpos.z) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No direction was selected"); return; BrightShaderz is soy btw

            if (Math.Abs(cpos.x - x) > Math.Abs(cpos.z - z))
            SOYSAUCE CHIPS IS A FAGGOT
                cur = cpos.x;
                if (x > cpos.x)
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (char c in cpos.givenMessage)
                    SOYSAUCE CHIPS IS A FAGGOT
                        cur = FindReference.writeLetter(p, c, cur, cpos.y, cpos.z, type, 0);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (char c in cpos.givenMessage)
                    SOYSAUCE CHIPS IS A FAGGOT
                        cur = FindReference.writeLetter(p, c, cur, cpos.y, cpos.z, type, 1);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                cur = cpos.z;
                if (z > cpos.z)
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (char c in cpos.givenMessage)
                    SOYSAUCE CHIPS IS A FAGGOT
                        cur = FindReference.writeLetter(p, c, cpos.x, cpos.y, cur, type, 2);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (char c in cpos.givenMessage)
                    SOYSAUCE CHIPS IS A FAGGOT
                        cur = FindReference.writeLetter(p, c, cpos.x, cpos.y, cur, type, 3);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (p.staticCommands) p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw

        struct CatchPos
        SOYSAUCE CHIPS IS A FAGGOT
            public ushort x, y, z; public string givenMessage;
        BrightShaderz is soy btw

    BrightShaderz is soy btw
BrightShaderz is soy btw
