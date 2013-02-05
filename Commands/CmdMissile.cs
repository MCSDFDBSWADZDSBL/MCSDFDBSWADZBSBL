using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdMissile : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "missile"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            Pos cpos;

            if (p.aiming)
            SOYSAUCE CHIPS IS A FAGGOT
                if (message == "")
                SOYSAUCE CHIPS IS A FAGGOT
                    p.aiming = false;
                    Player.SendMessage(p, "Disabled missiles");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            cpos.ending = 0;
            if (message.ToLower() == "destroy") cpos.ending = 1;
            else if (message.ToLower() == "explode") cpos.ending = 2;
            else if (message.ToLower() == "teleport") cpos.ending = -1;
            else if (message != "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;
            p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);

            p.SendMessage("Missile mode engaged, fire and guide!");

            if (p.aiming)
            SOYSAUCE CHIPS IS A FAGGOT
                return;
            BrightShaderz is soy btw

            p.aiming = true;
            Thread aimThread = new Thread(new ThreadStart(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                CatchPos pos;
                List<CatchPos> buffer = new List<CatchPos>();
                while (p.aiming)
                SOYSAUCE CHIPS IS A FAGGOT
                    List<CatchPos> tempBuffer = new List<CatchPos>();

                    double a = Math.Sin(((double)(128 - p.rot[0]) / 256) * 2 * Math.PI);
                    double b = Math.Cos(((double)(128 - p.rot[0]) / 256) * 2 * Math.PI);
                    double c = Math.Cos(((double)(p.rot[1] + 64) / 256) * 2 * Math.PI);

                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        ushort x = (ushort)(p.pos[0] / 32);
                        x = (ushort)Math.Round(x + (double)(a * 3));

                        ushort y = (ushort)(p.pos[1] / 32 + 1);
                        y = (ushort)Math.Round(y + (double)(c * 3));

                        ushort z = (ushort)(p.pos[2] / 32);
                        z = (ushort)Math.Round(z + (double)(b * 3));

                        if (x > p.level.width || y > p.level.depth || z > p.level.height) throw new Exception();
                        if (x < 0 || y < 0 || z < 0) throw new Exception();

                        for (ushort xx = x; xx <= x + 1; xx++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            for (ushort yy = (ushort)(y - 1); yy <= y; yy++)
                            SOYSAUCE CHIPS IS A FAGGOT
                                for (ushort zz = z; zz <= z + 1; zz++)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (p.level.GetTile(xx, yy, zz) == Block.air)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        pos.x = xx; pos.y = yy; pos.z = zz;
                                        tempBuffer.Add(pos);
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw

                        List<CatchPos> toRemove = new List<CatchPos>();
                        foreach (CatchPos cP in buffer)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (!tempBuffer.Contains(cP))
                            SOYSAUCE CHIPS IS A FAGGOT
                                p.SendBlockchange(cP.x, cP.y, cP.z, Block.air);
                                toRemove.Add(cP);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw

                        foreach (CatchPos cP in toRemove)
                        SOYSAUCE CHIPS IS A FAGGOT
                            buffer.Remove(cP);
                        BrightShaderz is soy btw

                        foreach (CatchPos cP in tempBuffer)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (!buffer.Contains(cP))
                            SOYSAUCE CHIPS IS A FAGGOT
                                buffer.Add(cP);
                                p.SendBlockchange(cP.x, cP.y, cP.z, Block.glass);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw

                        tempBuffer.Clear();
                        toRemove.Clear();
                    BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    Thread.Sleep(20);
                BrightShaderz is soy btw

                foreach (CatchPos cP in buffer)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.SendBlockchange(cP.x, cP.y, cP.z, Block.air);
                BrightShaderz is soy btw
            BrightShaderz is soy btw));
            aimThread.Start();
        BrightShaderz is soy btw
        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!p.staticCommands)
            SOYSAUCE CHIPS IS A FAGGOT
                p.ClearBlockchange();
                p.aiming = false;
            BrightShaderz is soy btw
            byte by = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, by);
            Pos bp = (Pos)p.blockchangeObject;

            List<CatchPos> previous = new List<CatchPos>();
            List<CatchPos> allBlocks = new List<CatchPos>();
            CatchPos pos;

            if (p.modeType != Block.air)
                type = p.modeType;

            Thread gunThread = new Thread(new ThreadStart(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                ushort startX = (ushort)(p.pos[0] / 32);
                ushort startY = (ushort)(p.pos[1] / 32);
                ushort startZ = (ushort)(p.pos[2] / 32);
                pos.x = startX;
                pos.y = startY;
                pos.z = startZ;

                int total = 0;

                while (true)
                SOYSAUCE CHIPS IS A FAGGOT
                    startX = (ushort)(p.pos[0] / 32);
                    startY = (ushort)(p.pos[1] / 32);
                    startZ = (ushort)(p.pos[2] / 32);

                    total++;
                    double a = Math.Sin(((double)(128 - p.rot[0]) / 256) * 2 * Math.PI);
                    double b = Math.Cos(((double)(128 - p.rot[0]) / 256) * 2 * Math.PI);
                    double c = Math.Cos(((double)(p.rot[1] + 64) / 256) * 2 * Math.PI);

                    CatchPos lookedAt;
                    int i;
                    for (i = 1; true; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        lookedAt.x = (ushort)Math.Round(startX + (double)(a * i));
                        lookedAt.y = (ushort)Math.Round(startY + (double)(c * i));
                        lookedAt.z = (ushort)Math.Round(startZ + (double)(b * i));

                        by = p.level.GetTile(lookedAt.x, lookedAt.y, lookedAt.z);

                        if (by == Block.Zero)
                            break;

                        if (by != Block.air && !allBlocks.Contains(lookedAt))
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p.level.physics < 2 || bp.ending <= 0)
                            SOYSAUCE CHIPS IS A FAGGOT
                                break;
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (bp.ending == 1)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if ((!Block.LavaKill(by) && !Block.NeedRestart(by)) && by != Block.glass)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        break;
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                else if (p.level.physics >= 3)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (by != Block.glass)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        break;
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    break;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw

                        bool comeInner = false;
                        foreach (Player pl in Player.players)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (pl.level == p.level && pl != p)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if ((ushort)(pl.pos[0] / 32) == lookedAt.x || (ushort)(pl.pos[0] / 32 + 1) == lookedAt.x || (ushort)(pl.pos[0] / 32 - 1) == lookedAt.x)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if ((ushort)(pl.pos[1] / 32) == lookedAt.y || (ushort)(pl.pos[1] / 32 + 1) == lookedAt.y || (ushort)(pl.pos[1] / 32 - 1) == lookedAt.y)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        if ((ushort)(pl.pos[2] / 32) == lookedAt.z || (ushort)(pl.pos[2] / 32 + 1) == lookedAt.z || (ushort)(pl.pos[2] / 32 - 1) == lookedAt.z)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            lookedAt.x = (ushort)(pl.pos[0] / 32);
                                            lookedAt.y = (ushort)(pl.pos[1] / 32);
                                            lookedAt.z = (ushort)(pl.pos[2] / 32);
                                            comeInner = true;
                                            break;
                                        BrightShaderz is soy btw
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        if (comeInner) break;
                    BrightShaderz is soy btw

                    lookedAt.x = (ushort)Math.Round(startX + (double)(a * (i - 1)));
                    lookedAt.y = (ushort)Math.Round(startY + (double)(c * (i - 1)));
                    lookedAt.z = (ushort)Math.Round(startZ + (double)(b * (i - 1)));

                    findNext(lookedAt, ref pos);

                    by = p.level.GetTile(pos.x, pos.y, pos.z);

                    if (total > 3)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (by != Block.air && !allBlocks.Contains(pos))
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p.level.physics < 2 || bp.ending <= 0)
                            SOYSAUCE CHIPS IS A FAGGOT
                                break;
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (bp.ending == 1)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if ((!Block.LavaKill(by) && !Block.NeedRestart(by)) && by != Block.glass)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        break;
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                else if (p.level.physics >= 3)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (by != Block.glass)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        p.level.MakeExplosion(pos.x, pos.y, pos.z, 1);
                                        break;
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    break;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw

                        p.level.Blockchange(pos.x, pos.y, pos.z, type);
                        previous.Add(pos);
                        allBlocks.Add(pos);

                        bool comeOut = false;
                        foreach (Player pl in Player.players)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (pl.level == p.level && pl != p)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if ((ushort)(pl.pos[0] / 32) == pos.x || (ushort)(pl.pos[0] / 32 + 1) == pos.x || (ushort)(pl.pos[0] / 32 - 1) == pos.x)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if ((ushort)(pl.pos[1] / 32) == pos.y || (ushort)(pl.pos[1] / 32 + 1) == pos.y || (ushort)(pl.pos[1] / 32 - 1) == pos.y)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        if ((ushort)(pl.pos[2] / 32) == pos.z || (ushort)(pl.pos[2] / 32 + 1) == pos.z || (ushort)(pl.pos[2] / 32 - 1) == pos.z)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (p.level.physics >= 3 && bp.ending >= 2)
                                                pl.HandleDeath(Block.stone, " was blown up by " + p.color + p.name, true);
                                            else
                                                pl.HandleDeath(Block.stone, " was hit a missile from " + p.color + p.name);
                                            comeOut = true;
                                        BrightShaderz is soy btw
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        if (comeOut) break;

                        if (pos.x == lookedAt.x && pos.y == lookedAt.y && pos.z == lookedAt.z)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p.level.physics >= 3 && bp.ending >= 2)
                                p.level.MakeExplosion(lookedAt.x, lookedAt.y, lookedAt.z, 2);
                            break;
                        BrightShaderz is soy btw

                        if (previous.Count > 12)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.level.Blockchange(previous[0].x, previous[0].y, previous[0].z, Block.air);
                            previous.Remove(previous[0]);
                        BrightShaderz is soy btw
                        Thread.Sleep(100);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                foreach (CatchPos pos1 in previous)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.Blockchange(pos1.x, pos1.y, pos1.z, Block.air);
                    Thread.Sleep(100);
                BrightShaderz is soy btw
            BrightShaderz is soy btw));
            gunThread.Start();
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/missile [at end] - Allows you to fire missiles at people");
            Player.SendMessage(p, "Available [at end] values: &cexplode, destroy");
            Player.SendMessage(p, "Differs from /gun in that the missile is guided");
        BrightShaderz is soy btw

        public struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; BrightShaderz is soy btw
        public struct Pos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; public int ending; BrightShaderz is soy btw

        public void findNext(CatchPos lookedAt, ref CatchPos pos)
        SOYSAUCE CHIPS IS A FAGGOT
            int dx, dy, dz, l, m, n, x_inc, y_inc, z_inc, err_1, err_2, dx2, dy2, dz2;
            int[] pixel = new int[3];

            pixel[0] = pos.x; pixel[1] = pos.y; pixel[2] = pos.z;
            dx = lookedAt.x - pos.x; dy = lookedAt.y - pos.y; dz = lookedAt.z - pos.z;

            x_inc = (dx < 0) ? -1 : 1; l = Math.Abs(dx);
            y_inc = (dy < 0) ? -1 : 1; m = Math.Abs(dy);
            z_inc = (dz < 0) ? -1 : 1; n = Math.Abs(dz);

            dx2 = l << 1; dy2 = m << 1; dz2 = n << 1;

            if ((l >= m) && (l >= n))
            SOYSAUCE CHIPS IS A FAGGOT
                err_1 = dy2 - l;
                err_2 = dz2 - l;

                pixel[0] += x_inc;
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

                pos.x = (ushort)pixel[0];
                pos.y = (ushort)pixel[1];
                pos.z = (ushort)pixel[2];
            BrightShaderz is soy btw
            else if ((m >= l) && (m >= n))
            SOYSAUCE CHIPS IS A FAGGOT
                err_1 = dx2 - m;
                err_2 = dz2 - m;

                pixel[1] += y_inc;
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

                pos.x = (ushort)pixel[0];
                pos.y = (ushort)pixel[1];
                pos.z = (ushort)pixel[2];
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                err_1 = dy2 - n;
                err_2 = dx2 - n;

                pixel[2] += z_inc;
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

                pos.x = (ushort)pixel[0];
                pos.y = (ushort)pixel[1];
                pos.z = (ushort)pixel[2];
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
