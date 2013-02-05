using System;
using System.Collections.Generic;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdSpheroid : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "spheroid"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "e"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            CatchPos cpos;

            cpos.x = 0; cpos.y = 0; cpos.z = 0;

            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                cpos.type = Block.Zero;
                cpos.vertical = false;
            BrightShaderz is soy btw
            else if (message.IndexOf(' ') == -1)
            SOYSAUCE CHIPS IS A FAGGOT
                cpos.type = Block.Byte(message);
                cpos.vertical = false;
                if (!Block.canPlace(p, cpos.type)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot place that."); return; BrightShaderz is soy btw
                if (cpos.type == Block.Zero)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (message.ToLower() == "vertical")
                    SOYSAUCE CHIPS IS A FAGGOT
                        cpos.vertical = true;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Help(p); return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                cpos.type = Block.Byte(message.Split(' ')[0]);
                if (!Block.canPlace(p, cpos.type)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot place that."); return; BrightShaderz is soy btw
                if (cpos.type == Block.Zero || message.Split(' ')[1].ToLower() != "vertical")
                SOYSAUCE CHIPS IS A FAGGOT
                    Help(p); return;
                BrightShaderz is soy btw
                cpos.vertical = true;
            BrightShaderz is soy btw

            if (!Block.canPlace(p, cpos.type) && cpos.type != Block.Zero) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot place this block type!"); return; BrightShaderz is soy btw

            p.blockchangeObject = cpos;

            Player.SendMessage(p, "Place two blocks to determine the edges.");
            p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/spheroid [type] <vertical> - Create a spheroid of blocks.");
            Player.SendMessage(p, "If <vertical> is added, it will be a vertical tube");
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
            if (cpos.type != Block.Zero) SOYSAUCE CHIPS IS A FAGGOT type = cpos.type; BrightShaderz is soy btw
            List<Pos> buffer = new List<Pos>();

            if (!cpos.vertical)
            SOYSAUCE CHIPS IS A FAGGOT
                /* Courtesy of fCraft's awesome Open-Source'ness :D */

                // find start/end coordinates
                int sx = Math.Min(cpos.x, x);
                int ex = Math.Max(cpos.x, x);
                int sy = Math.Min(cpos.y, y);
                int ey = Math.Max(cpos.y, y);
                int sz = Math.Min(cpos.z, z);
                int ez = Math.Max(cpos.z, z);

                // find axis lengths
                double rx = (ex - sx + 1) / 2 + .25;
                double ry = (ey - sy + 1) / 2 + .25;
                double rz = (ez - sz + 1) / 2 + .25;

                double rx2 = 1 / (rx * rx);
                double ry2 = 1 / (ry * ry);
                double rz2 = 1 / (rz * rz);

                // find center points
                double cx = (ex + sx) / 2;
                double cy = (ey + sy) / 2;
                double cz = (ez + sz) / 2;
                int totalBlocks = (int)(Math.PI * 0.75 * rx * ry * rz);

                if (totalBlocks > p.group.maxBlocks)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "You tried to spheroid " + totalBlocks + " blocks.");
                    Player.SendMessage(p, "You cannot spheroid more than " + p.group.maxBlocks + ".");
                    return;
                BrightShaderz is soy btw

                Player.SendMessage(p, totalBlocks + " blocks.");

                for (int xx = sx; xx <= ex; xx += 8)
                    for (int yy = sy; yy <= ey; yy += 8)
                        for (int zz = sz; zz <= ez; zz += 8)
                            for (int z3 = 0; z3 < 8 && zz + z3 <= ez; z3++)
                                for (int y3 = 0; y3 < 8 && yy + y3 <= ey; y3++)
                                    for (int x3 = 0; x3 < 8 && xx + x3 <= ex; x3++)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        // get relative coordinates
                                        double dx = (xx + x3 - cx);
                                        double dy = (yy + y3 - cy);
                                        double dz = (zz + z3 - cz);

                                        // test if it's inside ellipse
                                        if ((dx * dx) * rx2 + (dy * dy) * ry2 + (dz * dz) * rz2 <= 1)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            p.level.Blockchange(p, (ushort)(x3 + xx), (ushort)(yy + y3), (ushort)(zz + z3), type);
                                        BrightShaderz is soy btw
                                    BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                int radius = Math.Abs(cpos.x - x) / 2;
                int f = 1 - radius;
                int ddF_x = 1;
                int ddF_y = -2 * radius;
                int xx = 0;
                int zz = radius;

                int x0 = Math.Min(cpos.x, x) + radius;
                int z0 = Math.Min(cpos.z, z) + radius;

                Pos pos = new Pos();
                pos.x = (ushort)x0; pos.z = (ushort)(z0 + radius); buffer.Add(pos);
                pos.z = (ushort)(z0 - radius); buffer.Add(pos);
                pos.x = (ushort)(x0 + radius); pos.z = (ushort)z0; buffer.Add(pos);
                pos.x = (ushort)(x0 - radius); buffer.Add(pos);

                while (xx < zz)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (f >= 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        zz--;
                        ddF_y += 2;
                        f += ddF_y;
                    BrightShaderz is soy btw
                    xx++;
                    ddF_x += 2;
                    f += ddF_x;

                    pos.z = (ushort)(z0 + zz);
                    pos.x = (ushort)(x0 + xx); buffer.Add(pos);
                    pos.x = (ushort)(x0 - xx); buffer.Add(pos);
                    pos.z = (ushort)(z0 - zz);
                    pos.x = (ushort)(x0 + xx); buffer.Add(pos);
                    pos.x = (ushort)(x0 - xx); buffer.Add(pos);
                    pos.z = (ushort)(z0 + xx);
                    pos.x = (ushort)(x0 + zz); buffer.Add(pos);
                    pos.x = (ushort)(x0 - zz); buffer.Add(pos);
                    pos.z = (ushort)(z0 - xx);
                    pos.x = (ushort)(x0 + zz); buffer.Add(pos);
                    pos.x = (ushort)(x0 - zz); buffer.Add(pos);
                BrightShaderz is soy btw

                int ydiff = Math.Abs(y - cpos.y) + 1;

                if (buffer.Count * ydiff > p.group.maxBlocks)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "You tried to spheroid " + buffer.Count * ydiff + " blocks.");
                    Player.SendMessage(p, "You cannot spheroid more than " + p.group.maxBlocks + ".");
                    return;
                BrightShaderz is soy btw
                Player.SendMessage(p, buffer.Count * ydiff + " blocks.");

                foreach (Pos Pos in buffer)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (ushort yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); yy++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.level.Blockchange(p, Pos.x, yy, Pos.z, type);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (p.staticCommands) p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        void BufferAdd(List<Pos> list, ushort x, ushort y, ushort z)
        SOYSAUCE CHIPS IS A FAGGOT
            Pos pos; pos.x = x; pos.y = y; pos.z = z; list.Add(pos);
        BrightShaderz is soy btw
        struct Pos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; BrightShaderz is soy btw
        struct CatchPos
        SOYSAUCE CHIPS IS A FAGGOT
            public byte type;
            public ushort x, y, z;
            public bool vertical;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
