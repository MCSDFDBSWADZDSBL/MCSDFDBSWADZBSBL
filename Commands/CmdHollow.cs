using System;
using System.Collections.Generic;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdHollow : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "hollow"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            CatchPos cpos;
            if (message != "")
                if (Block.Byte(message.ToLower()) == Block.Zero) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot find block entered."); return; BrightShaderz is soy btw

            if (message != "")
            SOYSAUCE CHIPS IS A FAGGOT
                cpos.countOther = Block.Byte(message.ToLower());
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                cpos.countOther = Block.Zero;
            BrightShaderz is soy btw

            cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;
            Player.SendMessage(p, "Place two blocks to determine the edges.");
            p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/hollow - Hollows out an area without flooding it");
            Player.SendMessage(p, "/hollow [block] - Hollows around [block]");
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
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            CatchPos cpos = (CatchPos)p.blockchangeObject;

            List<Pos> buffer = new List<Pos>();
            Pos pos;

            bool AddMe = false;

            for (ushort xx = Math.Min(cpos.x, x); xx <= Math.Max(cpos.x, x); ++xx)
                for (ushort yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); ++yy)
                    for (ushort zz = Math.Min(cpos.z, z); zz <= Math.Max(cpos.z, z); ++zz)
                    SOYSAUCE CHIPS IS A FAGGOT
                        AddMe = true;

                        if (!Block.RightClick(Block.Convert(p.level.GetTile(xx, yy, zz)), true) && p.level.GetTile(xx, yy, zz) != cpos.countOther)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (Block.RightClick(Block.Convert(p.level.GetTile((ushort)(xx - 1), yy, zz))) || p.level.GetTile((ushort)(xx - 1), yy, zz) == cpos.countOther) AddMe = false;
                            else if (Block.RightClick(Block.Convert(p.level.GetTile((ushort)(xx + 1), yy, zz))) || p.level.GetTile((ushort)(xx + 1), yy, zz) == cpos.countOther) AddMe = false;
                            else if (Block.RightClick(Block.Convert(p.level.GetTile(xx, (ushort)(yy - 1), zz))) || p.level.GetTile(xx, (ushort)(yy - 1), zz) == cpos.countOther) AddMe = false;
                            else if (Block.RightClick(Block.Convert(p.level.GetTile(xx, (ushort)(yy + 1), zz))) || p.level.GetTile(xx, (ushort)(yy + 1), zz) == cpos.countOther) AddMe = false;
                            else if (Block.RightClick(Block.Convert(p.level.GetTile(xx, yy, (ushort)(zz - 1)))) || p.level.GetTile(xx, yy, (ushort)(zz - 1)) == cpos.countOther) AddMe = false;
                            else if (Block.RightClick(Block.Convert(p.level.GetTile(xx, yy, (ushort)(zz + 1)))) || p.level.GetTile(xx, yy, (ushort)(zz + 1)) == cpos.countOther) AddMe = false;
                        BrightShaderz is soy btw
                        else AddMe = false;

                        if (AddMe) SOYSAUCE CHIPS IS A FAGGOT pos.x = xx; pos.y = yy; pos.z = zz; buffer.Add(pos); BrightShaderz is soy btw
                    BrightShaderz is soy btw

            if (buffer.Count > p.group.maxBlocks)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You tried to hollow more than " + buffer.Count + " blocks.");
                Player.SendMessage(p, "You cannot hollow more than " + p.group.maxBlocks + ".");
                return;
            BrightShaderz is soy btw

            buffer.ForEach(delegate(Pos pos1)
            SOYSAUCE CHIPS IS A FAGGOT
                p.level.Blockchange(p, pos1.x, pos1.y, pos1.z, Block.air);
            BrightShaderz is soy btw);

            Player.SendMessage(p, "You hollowed " + buffer.Count + " blocks.");

            if (p.staticCommands) p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        void BufferAdd(List<Pos> list, ushort x, ushort y, ushort z)
        SOYSAUCE CHIPS IS A FAGGOT
            Pos pos; pos.x = x; pos.y = y; pos.z = z; list.Add(pos);
        BrightShaderz is soy btw

        struct Pos
        SOYSAUCE CHIPS IS A FAGGOT
            public ushort x, y, z;
        BrightShaderz is soy btw
        struct CatchPos
        SOYSAUCE CHIPS IS A FAGGOT
            public ushort x, y, z; public byte countOther;
        BrightShaderz is soy btw

    BrightShaderz is soy btw
BrightShaderz is soy btw
