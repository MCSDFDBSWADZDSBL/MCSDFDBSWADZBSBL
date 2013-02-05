using System;
using System.Collections.Generic;


namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class Team
    SOYSAUCE CHIPS IS A FAGGOT
        public char color;
        public int points = 0;
        public ushort[] flagBase = SOYSAUCE CHIPS IS A FAGGOT 0, 0, 0 BrightShaderz is soy btw;
        public ushort[] flagLocation = SOYSAUCE CHIPS IS A FAGGOT 0, 0, 0 BrightShaderz is soy btw;
        public List<Spawn> spawns = new List<Spawn>();
        public List<Player> players = new List<Player>();
        public Level mapOn;
        public bool flagishome;
        public bool spawnset;
        public bool flagmoved;
        public string teamstring = "";
        public Player holdingFlag = null;
        public CatchPos tempFlagblock;
        public CatchPos tfb;
        public int ftcount = 0;

        public void AddMember(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p.team != this)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.carryingFlag) SOYSAUCE CHIPS IS A FAGGOT p.spawning = true; mapOn.ctfgame.DropFlag(p, p.hasflag); p.spawning = false; BrightShaderz is soy btw
                if (p.team != null) SOYSAUCE CHIPS IS A FAGGOT p.team.RemoveMember(p); BrightShaderz is soy btw
                p.team = this;
                Player.GlobalDie(p, false);
                p.CTFtempcolor = p.color;
                p.CTFtempprefix = p.prefix;
                p.color = "&" + color;
                p.carryingFlag = false;
                p.hasflag = null;
                p.prefix = p.color + "[" + c.Name("&" + color).ToUpper() + "] ";
                players.Add(p);
                mapOn.ChatLevel(p.color + p.prefix + p.name + penis.DefaultColor + " has joined the " + teamstring + ".");
                Player.GlobalSpawn(p, p.pos[0], p.pos[1], p.pos[2], p.rot[0], p.rot[1], false);
                if (mapOn.ctfgame.gameOn)
                SOYSAUCE CHIPS IS A FAGGOT
                    SpawnPlayer(p);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void RemoveMember(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p.team == this)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.carryingFlag)
                SOYSAUCE CHIPS IS A FAGGOT
                    mapOn.ctfgame.DropFlag(p, p.hasflag);
                BrightShaderz is soy btw
                p.team = null;
                Player.GlobalDie(p, false);
                p.color = p.CTFtempcolor;
                p.prefix = p.CTFtempprefix;
                p.carryingFlag = false;
                p.hasflag = null;
                players.Remove(p);
                mapOn.ChatLevel(p.color + p.prefix + p.name + penis.DefaultColor + " has left the " + teamstring + ".");
                Player.GlobalSpawn(p, p.pos[0], p.pos[1], p.pos[2], p.rot[0], p.rot[1], false);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void SpawnPlayer(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            p.spawning = true;
            if (spawns.Count != 0)
            SOYSAUCE CHIPS IS A FAGGOT
                Random random = new Random();
                int rnd = random.Next(0, spawns.Count);
                ushort x, y, z, rotx;

                x = spawns[rnd].x;
                y = spawns[rnd].y;
                z = spawns[rnd].z;

                ushort x1 = (ushort)((0.5 + x) * 32);
                ushort y1 = (ushort)((1 + y) * 32);
                ushort z1 = (ushort)((0.5 + z) * 32);
                rotx = spawns[rnd].rotx;
                unchecked
                SOYSAUCE CHIPS IS A FAGGOT
                    p.SendSpawn((byte)-1, p.name, x1, y1, z1, (byte)rotx, 0);
                BrightShaderz is soy btw
                p.health = 100;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                ushort x = (ushort)((0.5 + mapOn.spawnx) * 32);
                ushort y = (ushort)((1 + mapOn.spawny) * 32);
                ushort z = (ushort)((0.5 + mapOn.spawnz) * 32);
                ushort rotx = mapOn.rotx;
                ushort roty = mapOn.roty;

                unchecked
                SOYSAUCE CHIPS IS A FAGGOT
                    p.SendSpawn((byte)-1, p.name, x, y, z, (byte)rotx, (byte)roty);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            p.spawning = false;
        BrightShaderz is soy btw

        public void AddSpawn(ushort x, ushort y, ushort z, ushort rotx, ushort roty)
        SOYSAUCE CHIPS IS A FAGGOT
            Spawn workSpawn = new Spawn();
            workSpawn.x = x;
            workSpawn.y = y;
            workSpawn.z = z;
            workSpawn.rotx = rotx;
            workSpawn.roty = roty;

            spawns.Add(workSpawn);
        BrightShaderz is soy btw

        public void Drawflag()
        SOYSAUCE CHIPS IS A FAGGOT
            
            ushort x = flagLocation[0];
            ushort y = flagLocation[1];
            ushort z = flagLocation[2];

            if (mapOn.GetTile(x, (ushort)(y - 1), z) == Block.air)
            SOYSAUCE CHIPS IS A FAGGOT
                flagLocation[1] = (ushort)(flagLocation[1] - 1);
            BrightShaderz is soy btw

            mapOn.Blockchange(tfb.x, tfb.y, tfb.z, tfb.type);
            mapOn.Blockchange(tfb.x, (ushort)(tfb.y + 1), tfb.z, Block.air);
            mapOn.Blockchange(tfb.x, (ushort)(tfb.y + 2), tfb.z, Block.air);

            if (holdingFlag == null)
            SOYSAUCE CHIPS IS A FAGGOT
                //DRAW ON GROUND SHIT HERE

                tfb.type = mapOn.GetTile(x, y, z);

                if (mapOn.GetTile(x, y, z) != Block.flagbase) SOYSAUCE CHIPS IS A FAGGOT mapOn.Blockchange(x, y, z, Block.flagbase); BrightShaderz is soy btw
                if (mapOn.GetTile(x, (ushort)(y + 1), z) != Block.mushroom) SOYSAUCE CHIPS IS A FAGGOT mapOn.Blockchange(x, (ushort)(y + 1), z, Block.mushroom); BrightShaderz is soy btw
                if (mapOn.GetTile(x, (ushort)(y + 2), z) != GetColorBlock(color)) SOYSAUCE CHIPS IS A FAGGOT mapOn.Blockchange(x, (ushort)(y + 2), z, GetColorBlock(color)); BrightShaderz is soy btw

                tfb.x = x;
                tfb.y = y;
                tfb.z = z;

            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                //DRAW ON PLAYER HEAD
                x = (ushort)(holdingFlag.pos[0] / 32);
                y = (ushort)(holdingFlag.pos[1] / 32 + 3);
                z = (ushort)(holdingFlag.pos[2] / 32);

                if (tempFlagblock.x == x && tempFlagblock.y == y && tempFlagblock.z == z) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw


                mapOn.Blockchange(tempFlagblock.x, tempFlagblock.y, tempFlagblock.z, tempFlagblock.type);

                tempFlagblock.type = mapOn.GetTile(x, y, z);

                mapOn.Blockchange(x, y, z, GetColorBlock(color));

                tempFlagblock.x = x;
                tempFlagblock.y = y;
                tempFlagblock.z = z;
            BrightShaderz is soy btw
            

        BrightShaderz is soy btw

        public static byte GetColorBlock(char color)
        SOYSAUCE CHIPS IS A FAGGOT
            if (color == '2')
                return Block.green;
            if (color == '5')
                return Block.purple;
            if (color == '8')
                return Block.darkgrey;
            if (color == '9')
                return Block.blue;
            if (color == 'c')
                return Block.red;
            if (color == 'e')
                return Block.yellow;
            if (color == 'f')
                return Block.white;
            else
                return Block.air;
        BrightShaderz is soy btw

        public struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; public byte type; BrightShaderz is soy btw
        public struct Spawn SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z, rotx, roty; BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
