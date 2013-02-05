using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdGun : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "gun"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p.hasflag != null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You can't use a gun while you have the flag!"); return;BrightShaderz is soy btw
            Pos cpos;

            if (p.aiming)
            SOYSAUCE CHIPS IS A FAGGOT
                if (message == "")
                SOYSAUCE CHIPS IS A FAGGOT
                    p.aiming = false;
                    p.ClearBlockchange();
                    Player.SendMessage(p, "Disabled gun");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            cpos.ending = 0;
            if (message.ToLower() == "destroy") cpos.ending = 1;
            else if (message.ToLower() == "explode") cpos.ending = 2;
            else if (message.ToLower() == "laser") cpos.ending = 3;
            else if (message.ToLower() == "teleport" || message.ToLower() == "tp") cpos.ending = -1;
            else if (message != "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;
            p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);

            p.SendMessage("Gun mode engaged, fire at will");

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
            byte by = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, by);
            Pos bp = (Pos)p.blockchangeObject;

            double a = Math.Sin(((double)(128 - p.rot[0]) / 256) * 2 * Math.PI);
            double b = Math.Cos(((double)(128 - p.rot[0]) / 256) * 2 * Math.PI);
            double c = Math.Cos(((double)(p.rot[1] + 64) / 256) * 2 * Math.PI);

            double bigDiag = Math.Sqrt(Math.Sqrt(p.level.width * p.level.width + p.level.height * p.level.height) + p.level.depth * p.level.depth + p.level.width * p.level.width);

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

                pos.x = (ushort)Math.Round(startX + (double)(a * 3));
                pos.y = (ushort)Math.Round(startY + (double)(c * 3));
                pos.z = (ushort)Math.Round(startZ + (double)(b * 3));

                for (double t = 4; bigDiag > t; t++)
                SOYSAUCE CHIPS IS A FAGGOT
                    pos.x = (ushort)Math.Round(startX + (double)(a * t));
                    pos.y = (ushort)Math.Round(startY + (double)(c * t));
                    pos.z = (ushort)Math.Round(startZ + (double)(b * t));

                    by = p.level.GetTile(pos.x, pos.y, pos.z);

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
                        if (pl.level == p.level)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if ((ushort)(pl.pos[0] / 32) == pos.x || (ushort)(pl.pos[0] / 32  + 1) == pos.x || (ushort)(pl.pos[0] / 32 - 1) == pos.x)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if ((ushort)(pl.pos[1] / 32) == pos.y || (ushort)(pl.pos[1] / 32 + 1) == pos.y || (ushort)(pl.pos[1] / 32 - 1) == pos.y)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if ((ushort)(pl.pos[2] / 32) == pos.z || (ushort)(pl.pos[2] / 32 + 1) == pos.z || (ushort)(pl.pos[2] / 32 - 1) == pos.z)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        if (p.level.ctfmode && !p.level.ctfgame.friendlyfire && p.team == pl.team)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            comeOut = true;
                                            break;
                                        BrightShaderz is soy btw
                                        if (p.level.ctfmode)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            pl.health = pl.health - 25;
                                            if (pl.health > 0)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                pl.SendMessage("You have been shot!  You have &c" + pl.health + penis.DefaultColor + " health remaining.");
                                                comeOut = true;
                                                break;
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw


                                        if (p.level.physics >= 3 && bp.ending >= 2)
                                            pl.HandleDeath(Block.stone, " was blown up by " + p.color + p.name, true);
                                        else
                                            pl.HandleDeath(Block.stone, " was shot by " + p.color + p.name);
                                        comeOut = true;
                                        
                                        

                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    if (comeOut) break;

                    if (t > 12 && bp.ending != 3)
                    SOYSAUCE CHIPS IS A FAGGOT
                        pos = previous[0];
                        p.level.Blockchange(pos.x, pos.y, pos.z, Block.air);
                        previous.Remove(pos);
                    BrightShaderz is soy btw
                    
                    if (bp.ending != 3) Thread.Sleep(20);
                BrightShaderz is soy btw

                if (bp.ending == -1)
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        unchecked SOYSAUCE CHIPS IS A FAGGOT p.SendPos((byte)-1, (ushort)(previous[previous.Count - 3].x * 32), (ushort)(previous[previous.Count - 3].y * 32 + 32), (ushort)(previous[previous.Count - 3].z * 32), p.rot[0], p.rot[1]); BrightShaderz is soy btw
                    BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                if (bp.ending == 3) Thread.Sleep(400);

                foreach (CatchPos pos1 in previous)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.Blockchange(pos1.x, pos1.y, pos1.z, Block.air);
                    if (bp.ending != 3) Thread.Sleep(20);
                BrightShaderz is soy btw
            BrightShaderz is soy btw));
            gunThread.Start();
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/gun [at end] - Allows you to fire bullets at people");
            Player.SendMessage(p, "Available [at end] values: &cexplode, destroy, laser, tp");
        BrightShaderz is soy btw

        public struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; BrightShaderz is soy btw
        public struct Pos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; public int ending; BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
