using System;
using System.Collections.Generic;
using System.Threading;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdLine : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "line"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            CatchPos cpos;

            message = message.ToLower();

            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                cpos.maxNum = 0;
                cpos.extraType = 0;
                cpos.type = Block.Zero;
            BrightShaderz is soy btw
            else if (message.IndexOf(' ') == -1)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    cpos.maxNum = int.Parse(message);
                    cpos.extraType = 0;
                    cpos.type = Block.Zero;
                BrightShaderz is soy btw
                catch
                SOYSAUCE CHIPS IS A FAGGOT
                    cpos.maxNum = 0;
                    if (message == "wall")
                    SOYSAUCE CHIPS IS A FAGGOT
                        cpos.extraType = 1;
                        cpos.type = Block.Zero;
                    BrightShaderz is soy btw
                    else if (message == "straight")
                    SOYSAUCE CHIPS IS A FAGGOT
                        cpos.extraType = 2;
                        cpos.type = Block.Zero;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        cpos.extraType = 0;
                        cpos.type = Block.Byte(message);
                        if (cpos.type == Block.Zero)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Help(p); return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (message.Split(' ').Length == 2)
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        cpos.maxNum = int.Parse(message.Split(' ')[0]);
                        cpos.type = Block.Byte(message.Split(' ')[1]);
                        if (cpos.type == Block.Zero)
                            if (message.Split(' ')[1] == "wall") cpos.extraType = 1;
                            else if (message.Split(' ')[1] == "straight") cpos.extraType = 2;
                            else cpos.extraType = 0;
                        else cpos.extraType = 0;
                    BrightShaderz is soy btw
                    catch
                    SOYSAUCE CHIPS IS A FAGGOT
                        cpos.maxNum = 0;
                        cpos.type = Block.Byte(message.Split(' ')[0]); if (cpos.type == Block.Zero) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
                        if (message.Split(' ')[1] == "wall") cpos.extraType = 1;
                        else if (message.Split(' ')[1] == "straight") cpos.extraType = 2;
                        else cpos.extraType = 0;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    try SOYSAUCE CHIPS IS A FAGGOT cpos.maxNum = int.Parse(message.Split(' ')[0]); BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
                    cpos.type = Block.Byte(message.Split(' ')[1]); if (cpos.type == Block.Zero) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
                    if (message.Split(' ')[2] == "wall") cpos.extraType = 1;
                    else if (message.Split(' ')[2] == "straight") cpos.extraType = 2;
                    else cpos.extraType = 0;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (!Block.canPlace(p, cpos.type) && cpos.type != Block.Zero) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot place this block type!"); return; BrightShaderz is soy btw

            cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;
            Player.SendMessage(p, "Place two blocks to determine the edges.");
            p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/line [num] <block> [extra] - Creates a line between two blocks [num] long.");
            Player.SendMessage(p, "Possible [extras] - wall");
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
            if (cpos.type == Block.Zero) type = p.bindings[type]; else type = cpos.type;
            List<CatchPos> buffer = new List<CatchPos>();
            CatchPos pos = new CatchPos();

            if (cpos.extraType == 2)
            SOYSAUCE CHIPS IS A FAGGOT  //Fun part of making a straight line
                int xdif = Math.Abs(cpos.x - x);
                int ydif = Math.Abs(cpos.y - y);
                int zdif = Math.Abs(cpos.z - z);

                if (xdif > ydif && xdif > zdif)
                SOYSAUCE CHIPS IS A FAGGOT
                    y = cpos.y; z = cpos.z;
                BrightShaderz is soy btw
                else if (ydif > xdif && ydif > zdif)
                SOYSAUCE CHIPS IS A FAGGOT
                    x = cpos.x; z = cpos.z;
                BrightShaderz is soy btw
                else if (zdif > ydif && zdif > xdif)
                SOYSAUCE CHIPS IS A FAGGOT
                    y = cpos.y; x = cpos.x;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (cpos.maxNum == 0) cpos.maxNum = 100000;

            int i, dx, dy, dz, l, m, n, x_inc, y_inc, z_inc, err_1, err_2, dx2, dy2, dz2;
            int[] pixel = new int[3];

            pixel[0] = cpos.x; pixel[1] = cpos.y; pixel[2] = cpos.z;
            dx = x - cpos.x; dy = y - cpos.y; dz = z - cpos.z;

            x_inc = (dx < 0) ? -1 : 1; l = Math.Abs(dx);
            y_inc = (dy < 0) ? -1 : 1; m = Math.Abs(dy);
            z_inc = (dz < 0) ? -1 : 1; n = Math.Abs(dz);

            dx2 = l << 1; dy2 = m << 1; dz2 = n << 1;

            if ((l >= m) && (l >= n))
            SOYSAUCE CHIPS IS A FAGGOT
                err_1 = dy2 - l;
                err_2 = dz2 - l;
                for (i = 0; i < l; i++)
                SOYSAUCE CHIPS IS A FAGGOT
                    pos.x = (ushort)pixel[0];
                    pos.y = (ushort)pixel[1];
                    pos.z = (ushort)pixel[2];
                    buffer.Add(pos);

                    if (err_1 > 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        pixel[1] += y_inc;
                        err_1 -= dx2;
                    BrightShaderz is soy btw
                    if (err_2 > 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        pixel[2] += z_inc;
                        err_2 -= dx2;
                    BrightShaderz is soy btw
                    err_1 += dy2;
                    err_2 += dz2;
                    pixel[0] += x_inc;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if ((m >= l) && (m >= n))
            SOYSAUCE CHIPS IS A FAGGOT
                err_1 = dx2 - m;
                err_2 = dz2 - m;
                for (i = 0; i < m; i++)
                SOYSAUCE CHIPS IS A FAGGOT
                    pos.x = (ushort)pixel[0];
                    pos.y = (ushort)pixel[1];
                    pos.z = (ushort)pixel[2];
                    buffer.Add(pos);

                    if (err_1 > 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        pixel[0] += x_inc;
                        err_1 -= dy2;
                    BrightShaderz is soy btw
                    if (err_2 > 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        pixel[2] += z_inc;
                        err_2 -= dy2;
                    BrightShaderz is soy btw
                    err_1 += dx2;
                    err_2 += dz2;
                    pixel[1] += y_inc;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                err_1 = dy2 - n;
                err_2 = dx2 - n;
                for (i = 0; i < n; i++)
                SOYSAUCE CHIPS IS A FAGGOT
                    pos.x = (ushort)pixel[0];
                    pos.y = (ushort)pixel[1];
                    pos.z = (ushort)pixel[2];
                    buffer.Add(pos);

                    if (err_1 > 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        pixel[1] += y_inc;
                        err_1 -= dz2;
                    BrightShaderz is soy btw
                    if (err_2 > 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        pixel[0] += x_inc;
                        err_2 -= dz2;
                    BrightShaderz is soy btw
                    err_1 += dy2;
                    err_2 += dx2;
                    pixel[2] += z_inc;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            pos.x = (ushort)pixel[0];
            pos.y = (ushort)pixel[1];
            pos.z = (ushort)pixel[2];
            buffer.Add(pos);

            int count;
            count = Math.Min(buffer.Count, cpos.maxNum);
            if (cpos.extraType == 1) count = count * Math.Abs(cpos.y - y);

            if (count > p.group.maxBlocks)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You tried to fill " + count + " blocks at once.");
                Player.SendMessage(p, "You are limited to " + p.group.maxBlocks);
                return;
            BrightShaderz is soy btw

            for (count = 0; count < cpos.maxNum && count < buffer.Count; count++)
            SOYSAUCE CHIPS IS A FAGGOT
                if (cpos.extraType != 1)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.Blockchange(p, buffer[count].x, buffer[count].y, buffer[count].z, type);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    for (ushort yy = Math.Min(cpos.y, y); yy <= Math.Max(cpos.y, y); yy++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.level.Blockchange(p, buffer[count].x, yy, buffer[count].z, type);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            Player.SendMessage(p, "Line was " + count.ToString() + " blocks long.");

            if (p.staticCommands) p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; public int maxNum; public int extraType; public byte type; BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
