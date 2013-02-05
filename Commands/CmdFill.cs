using System;
using System.Collections.Generic;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdFill : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "fill"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "f"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            CatchPos cpos;

            int number = message.Split(' ').Length;
            if (number > 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (number == 2)
            SOYSAUCE CHIPS IS A FAGGOT
                int pos = message.IndexOf(' ');
                string t = message.Substring(0, pos).ToLower();
                string s = message.Substring(pos + 1).ToLower();
                cpos.type = Block.Byte(t);
                if (cpos.type == 255) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no block \"" + t + "\"."); return; BrightShaderz is soy btw

                if (!Block.canPlace(p, cpos.type)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot place that."); return; BrightShaderz is soy btw

                if (s == "up") cpos.FillType = 1;
                else if (s == "down") cpos.FillType = 2;
                else if (s == "layer") cpos.FillType = 3;
                else if (s == "vertical_x") cpos.FillType = 4;
                else if (s == "vertical_z") cpos.FillType = 5;
                else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid fill type"); return; BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (message != "")
            SOYSAUCE CHIPS IS A FAGGOT
                message = message.ToLower();
                if (message == "up") SOYSAUCE CHIPS IS A FAGGOT cpos.FillType = 1; cpos.type = Block.Zero; BrightShaderz is soy btw
                else if (message == "down") SOYSAUCE CHIPS IS A FAGGOT cpos.FillType = 2; cpos.type = Block.Zero; BrightShaderz is soy btw
                else if (message == "layer") SOYSAUCE CHIPS IS A FAGGOT cpos.FillType = 3; cpos.type = Block.Zero; BrightShaderz is soy btw
                else if (message == "vertical_x") SOYSAUCE CHIPS IS A FAGGOT cpos.FillType = 4; cpos.type = Block.Zero; BrightShaderz is soy btw
                else if (message == "vertical_z") SOYSAUCE CHIPS IS A FAGGOT cpos.FillType = 5; cpos.type = Block.Zero; BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    cpos.type = Block.Byte(message);
                    if (cpos.type == (byte)255) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid block or fill type"); return; BrightShaderz is soy btw
                    if (!Block.canPlace(p, cpos.type)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot place that."); return; BrightShaderz is soy btw

                    cpos.FillType = 0;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                cpos.type = Block.Zero; cpos.FillType = 0;
            BrightShaderz is soy btw

            cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;

            Player.SendMessage(p, "Destroy the block you wish to fill."); p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/fill [block] [type] - Fills the area specified with [block].");
            Player.SendMessage(p, "[types] - up, down, layer, vertical_x, vertical_z");
        BrightShaderz is soy btw
        
        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                p.ClearBlockchange();
                CatchPos cpos = (CatchPos)p.blockchangeObject;
                if (cpos.type == Block.Zero) cpos.type = p.bindings[type];

                byte oldType = p.level.GetTile(x, y, z);
                p.SendBlockchange(x, y, z, oldType);

                if (cpos.type == oldType) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot fill the same time"); return; BrightShaderz is soy btw
                if (!Block.canPlace(p, oldType) && !Block.BuildIn(oldType)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot fill that."); return; BrightShaderz is soy btw

                byte[] mapBlocks = new byte[p.level.blocks.Length];
                List<Pos> buffer = new List<Pos>();
                p.level.blocks.CopyTo(mapBlocks, 0);

                fromWhere.Clear();
                deep = 0;
                FloodFill(p, x, y, z, cpos.type, oldType, cpos.FillType, ref mapBlocks, ref buffer);

                int totalFill = fromWhere.Count;
                for (int i = 0; i < totalFill; i++)
                SOYSAUCE CHIPS IS A FAGGOT
                    totalFill = fromWhere.Count;
                    Pos pos = fromWhere[i];
                    deep = 0;
                    FloodFill(p, pos.x, pos.y, pos.z, cpos.type, oldType, cpos.FillType, ref mapBlocks, ref buffer);
                    totalFill = fromWhere.Count;
                BrightShaderz is soy btw
                fromWhere.Clear();

                if (buffer.Count > p.group.maxBlocks)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "You tried to fill " + buffer.Count + " blocks.");
                    Player.SendMessage(p, "You cannot fill more than " + p.group.maxBlocks + ".");
                    return;
                BrightShaderz is soy btw

                foreach (Pos pos in buffer)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.Blockchange(p, pos.x, pos.y, pos.z, cpos.type);
                BrightShaderz is soy btw

                Player.SendMessage(p, "Filled " + buffer.Count + " blocks.");
                buffer.Clear();

                if (p.staticCommands) p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        int deep;
        List<Pos> fromWhere = new List<Pos>();
        public void FloodFill(Player p, ushort x, ushort y, ushort z, byte b, byte oldType, int fillType, ref byte[] blocks, ref List<Pos> buffer)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                Pos pos;
                pos.x = x; pos.y = y; pos.z = z;

                if (deep > 4000)
                SOYSAUCE CHIPS IS A FAGGOT
                    fromWhere.Add(pos);
                    return;
                BrightShaderz is soy btw

                blocks[x + p.level.width * z + p.level.width * p.level.height * y] = b;
                buffer.Add(pos);

                //x
                if (fillType != 4)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (GetTile((ushort)(x + 1), y, z, p.level, blocks) == oldType)
                    SOYSAUCE CHIPS IS A FAGGOT
                        deep++;
                        FloodFill(p, (ushort)(x + 1), y, z, b, oldType, fillType, ref blocks, ref buffer);
                        deep--;
                    BrightShaderz is soy btw

                    if (x - 1 > 0)
                        if (GetTile((ushort)(x - 1), y, z, p.level, blocks) == oldType)
                        SOYSAUCE CHIPS IS A FAGGOT
                            deep++;
                            FloodFill(p, (ushort)(x - 1), y, z, b, oldType, fillType, ref blocks, ref buffer);
                            deep--;
                        BrightShaderz is soy btw
                BrightShaderz is soy btw

                //z
                if (fillType != 5)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (GetTile(x, y, (ushort)(z + 1), p.level, blocks) == oldType)
                    SOYSAUCE CHIPS IS A FAGGOT
                        deep++;
                        FloodFill(p, x, y, (ushort)(z + 1), b, oldType, fillType, ref blocks, ref buffer);
                        deep--;
                    BrightShaderz is soy btw

                    if (z - 1 > 0)
                        if (GetTile(x, y, (ushort)(z - 1), p.level, blocks) == oldType)
                        SOYSAUCE CHIPS IS A FAGGOT
                            deep++;
                            FloodFill(p, x, y, (ushort)(z - 1), b, oldType, fillType, ref blocks, ref buffer);
                            deep--;
                        BrightShaderz is soy btw
                BrightShaderz is soy btw

                //y
                if (fillType == 0 || fillType == 1 || fillType > 3)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (GetTile(x, (ushort)(y + 1), z, p.level, blocks) == oldType)
                    SOYSAUCE CHIPS IS A FAGGOT
                        deep++;
                        FloodFill(p, x, (ushort)(y + 1), z, b, oldType, fillType, ref blocks, ref buffer);
                        deep--;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                if (fillType == 0 || fillType == 2 || fillType > 3)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (y - 1 > 0)
                        if (GetTile(x, (ushort)(y - 1), z, p.level, blocks) == oldType)
                        SOYSAUCE CHIPS IS A FAGGOT
                            deep++;
                            FloodFill(p, x, (ushort)(y - 1), z, b, oldType, fillType, ref blocks, ref buffer);
                            deep--;
                        BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw

        public byte GetTile(ushort x, ushort y, ushort z, Level l, byte[] blocks)
        SOYSAUCE CHIPS IS A FAGGOT
            //if (PosToInt(x, y, z) >= blocks.Length) SOYSAUCE CHIPS IS A FAGGOT return null; BrightShaderz is soy btw
            //Avoid internal overflow
            if (x < 0) SOYSAUCE CHIPS IS A FAGGOT return Block.Zero; BrightShaderz is soy btw
            if (x >= l.width) SOYSAUCE CHIPS IS A FAGGOT return Block.Zero; BrightShaderz is soy btw
            if (y < 0) SOYSAUCE CHIPS IS A FAGGOT return Block.Zero; BrightShaderz is soy btw
            if (y >= l.depth) SOYSAUCE CHIPS IS A FAGGOT return Block.Zero; BrightShaderz is soy btw
            if (z < 0) SOYSAUCE CHIPS IS A FAGGOT return Block.Zero; BrightShaderz is soy btw
            if (z >= l.height) SOYSAUCE CHIPS IS A FAGGOT return Block.Zero; BrightShaderz is soy btw
            try
            SOYSAUCE CHIPS IS A FAGGOT
                return blocks[l.PosToInt(x, y, z)];
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); return Block.Zero; BrightShaderz is soy btw
        BrightShaderz is soy btw

        struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; public byte type; public int FillType; BrightShaderz is soy btw
        public struct Pos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
