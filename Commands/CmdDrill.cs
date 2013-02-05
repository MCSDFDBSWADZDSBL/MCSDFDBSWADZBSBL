using System;
using System.Collections.Generic;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdDrill : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "drill"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            CatchPos cpos;
            cpos.distance = 20;

            if (message != "")
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    cpos.distance = int.Parse(message);
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;

            Player.SendMessage(p, "Destroy the block you wish to drill."); p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/drill [distance] - Drills a hole, destroying all similar blocks in a 3x3 rectangle ahead of you.");
        BrightShaderz is soy btw
        
        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!p.staticCommands) p.ClearBlockchange();
            CatchPos cpos = (CatchPos)p.blockchangeObject;
            byte oldType = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, oldType);

            int diffX = 0, diffZ = 0;

            if (p.rot[0] <= 32 || p.rot[0] >= 224) SOYSAUCE CHIPS IS A FAGGOT diffZ = -1; BrightShaderz is soy btw
            else if (p.rot[0] <= 96) SOYSAUCE CHIPS IS A FAGGOT diffX = 1; BrightShaderz is soy btw
            else if (p.rot[0] <= 160) SOYSAUCE CHIPS IS A FAGGOT diffZ = 1; BrightShaderz is soy btw
            else diffX = -1;

            List<Pos> buffer = new List<Pos>();
            Pos pos;
            int total = 0;

            if (diffX != 0)
            SOYSAUCE CHIPS IS A FAGGOT
                for (ushort xx = x; total < cpos.distance; xx += (ushort)diffX)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (ushort yy = (ushort)(y - 1); yy <= (ushort)(y + 1); yy++)
                        for (ushort zz = (ushort)(z - 1); zz <= (ushort)(z + 1); zz++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            pos.x = xx; pos.y = yy; pos.z = zz;
                            buffer.Add(pos);
                        BrightShaderz is soy btw
                    total++;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                for (ushort zz = z; total < cpos.distance; zz += (ushort)diffZ)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (ushort yy = (ushort)(y - 1); yy <= (ushort)(y + 1); yy++)
                        for (ushort xx = (ushort)(x - 1); xx <= (ushort)(x + 1); xx++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            pos.x = xx; pos.y = yy; pos.z = zz;
                            buffer.Add(pos);
                        BrightShaderz is soy btw
                    total++;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (buffer.Count > p.group.maxBlocks)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You tried to drill " + buffer.Count + " blocks.");
                Player.SendMessage(p, "You cannot drill more than " + p.group.maxBlocks + ".");
                return;
            BrightShaderz is soy btw

            foreach (Pos pos1 in buffer)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.level.GetTile(pos1.x, pos1.y, pos1.z) == oldType)
                    p.level.Blockchange(p, pos1.x, pos1.y, pos1.z, Block.air);
            BrightShaderz is soy btw
            Player.SendMessage(p, buffer.Count + " blocks.");
        BrightShaderz is soy btw

        struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; public int distance; BrightShaderz is soy btw
        struct Pos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
