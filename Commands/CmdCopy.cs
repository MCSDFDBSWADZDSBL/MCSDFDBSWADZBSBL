using System;
using System.Collections.Generic;
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdCopy : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "copy"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "c"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw
        public int allowoffset = 0;

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            
            CatchPos cpos;
            cpos.ignoreTypes = new List<byte>();
            cpos.type = 0;
            p.copyoffset[0] = 0; p.copyoffset[1] = 0; p.copyoffset[2] = 0;
            allowoffset = (message.IndexOf('@'));
            if (allowoffset != -1) SOYSAUCE CHIPS IS A FAGGOT message = message.Replace("@ ", ""); BrightShaderz is soy btw
            if (message.ToLower() == "cut") SOYSAUCE CHIPS IS A FAGGOT cpos.type = 1; message = ""; BrightShaderz is soy btw
            else if (message.ToLower() == "air") SOYSAUCE CHIPS IS A FAGGOT cpos.type = 2; message = ""; BrightShaderz is soy btw
            else if (message == "@") SOYSAUCE CHIPS IS A FAGGOT message = ""; BrightShaderz is soy btw
            else if (message.IndexOf(' ') != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                if (message.Split(' ')[0] == "ignore")
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (string s in message.Substring(message.IndexOf(' ') + 1).Split(' '))
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (Block.Byte(s) != Block.Zero)
                        SOYSAUCE CHIPS IS A FAGGOT
                            cpos.ignoreTypes.Add(Block.Byte(s));
                            Player.SendMessage(p, "Ignoring &b" + s);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Help(p); return;
                BrightShaderz is soy btw
                message = "";
            BrightShaderz is soy btw

            cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;

            if (message != "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            Player.SendMessage(p, "Place two blocks to determine the edges.");
            p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/copy - Copies the blocks in an area.");
            Player.SendMessage(p, "/copy cut - Copies the blocks in an area, then removes them.");
            Player.SendMessage(p, "/copy air - Copies the blocks in an area, including air.");
            Player.SendMessage(p, "/copy ignore <block1> <block2>.. - Ignores <blocks> when copying");
            Player.SendMessage(p, "/copy @ - @ toggle for all the above, gives you a third click after copying that determines where to paste from");
        BrightShaderz is soy btw

        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            CatchPos bp = (CatchPos)p.blockchangeObject;
            p.copystart[0] = x;
            p.copystart[1] = y;
            p.copystart[2] = z;

            bp.x = x; bp.y = y; bp.z = z; p.blockchangeObject = bp;



            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange2);
        BrightShaderz is soy btw

        public void Blockchange2(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            CatchPos cpos = (CatchPos)p.blockchangeObject;

            p.CopyBuffer.Clear();
            int TotalAir = 0;
            if (cpos.type == 2) p.copyAir = true; else p.copyAir = false;

            for (ushort xx = Math.Min(cpos.x, x); xx <= Math.Max(cpos.x, x); ++xx)
                for (ushort yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); ++yy)
                    for (ushort zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); ++zz)
                    SOYSAUCE CHIPS IS A FAGGOT
                        b = p.level.GetTile(xx, yy, zz);
                        if (Block.canPlace(p, b))
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (b == Block.air && cpos.type != 2 || cpos.ignoreTypes.Contains(b)) TotalAir++;

                            if (cpos.ignoreTypes.Contains(b)) BufferAdd(p, (ushort)(xx - cpos.x), (ushort)(yy - cpos.y), (ushort)(zz - cpos.z), Block.air);
                            else BufferAdd(p, (ushort)(xx - cpos.x), (ushort)(yy - cpos.y), (ushort)(zz - cpos.z), b);
                        BrightShaderz is soy btw
                        else BufferAdd(p, (ushort)(xx - cpos.x), (ushort)(yy - cpos.y), (ushort)(zz - cpos.z), Block.air);
                    BrightShaderz is soy btw

            if ((p.CopyBuffer.Count - TotalAir) > p.group.maxBlocks)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You tried to copy " + p.CopyBuffer.Count + " blocks.");
                Player.SendMessage(p, "You cannot copy more than " + p.group.maxBlocks + ".");
                p.CopyBuffer.Clear();
                return;
            BrightShaderz is soy btw

            if (cpos.type == 1)
                for (ushort xx = Math.Min(cpos.x, x); xx <= Math.Max(cpos.x, x); ++xx)
                    for (ushort yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); ++yy)
                        for (ushort zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); ++zz)
                        SOYSAUCE CHIPS IS A FAGGOT
                            b = p.level.GetTile(xx, yy, zz);
                            if (b != Block.air && Block.canPlace(p, b))
                                p.level.Blockchange(p, xx, yy, zz, Block.air);
                        BrightShaderz is soy btw

            Player.SendMessage(p, (p.CopyBuffer.Count - TotalAir) + " blocks copied.");
            if (allowoffset != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Place a block to determine where to paste from");
                p.Blockchange += new Player.BlockchangeEventHandler(Blockchange3);
            BrightShaderz is soy btw

        BrightShaderz is soy btw

        public void Blockchange3(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT

            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            CatchPos cpos = (CatchPos)p.blockchangeObject;


            p.copyoffset[0] = (p.copystart[0] - x);
            p.copyoffset[1] = (p.copystart[1] - y);
            p.copyoffset[2] = (p.copystart[2] - z);

        BrightShaderz is soy btw

        void BufferAdd(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.CopyPos pos; pos.x = x; pos.y = y; pos.z = z; pos.type = type;
            p.CopyBuffer.Add(pos);
        BrightShaderz is soy btw
        struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; public int type; public List<byte> ignoreTypes; BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
