/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCSong) Licensed under the
	Educational Community License, Version 2.0 (the "License"); you may
	not use this file except in compliance with the License. You may
	obtain a copy of the License at
	
	http://www.osedu.org/licenses/ECL-2.0
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the License is distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the License for the specific language governing
	permissions and limitations under the License.
*/
using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class PlayerBot
    SOYSAUCE CHIPS IS A FAGGOT
        public static List<PlayerBot> playerbots = new List<PlayerBot>(64);

        public bool hunt = false;
        public bool kill = false;

        public string AIName = "";
        public string name;
        public byte id;
        public string color;
        public Level level;
        public int currentPoint = 0;
        public int countdown = 0;
        public bool nodUp = false;
        public List<Pos> Waypoints = new List<Pos>();
        public struct Pos SOYSAUCE CHIPS IS A FAGGOT public string type, newscript; public int seconds, rotspeed; public ushort x, y, z; public byte rotx, roty; BrightShaderz is soy btw

        public ushort[] pos = new ushort[3] SOYSAUCE CHIPS IS A FAGGOT 0, 0, 0 BrightShaderz is soy btw;
        ushort[] oldpos = new ushort[3] SOYSAUCE CHIPS IS A FAGGOT 0, 0, 0 BrightShaderz is soy btw;
        ushort[] basepos = new ushort[3] SOYSAUCE CHIPS IS A FAGGOT 0, 0, 0 BrightShaderz is soy btw;
        public byte[] rot = new byte[2] SOYSAUCE CHIPS IS A FAGGOT 0, 0 BrightShaderz is soy btw;
        byte[] oldrot = new byte[2] SOYSAUCE CHIPS IS A FAGGOT 0, 0 BrightShaderz is soy btw;

        ushort[] foundPos = new ushort[3] SOYSAUCE CHIPS IS A FAGGOT 0, 0, 0 BrightShaderz is soy btw;
        byte[] foundRot = new byte[2] SOYSAUCE CHIPS IS A FAGGOT 0, 0 BrightShaderz is soy btw;
        bool movement = false;
        public int movementSpeed = 24;
        bool jumping = false;
        int currentjump = 0;

        public System.Timers.Timer botTimer = new System.Timers.Timer(100);
        public System.Timers.Timer moveTimer = new System.Timers.Timer(100 / 24);
        public System.Timers.Timer jumpTimer = new System.Timers.Timer(95);

        #region == constructors ==
        public PlayerBot(string n, Level l)
        SOYSAUCE CHIPS IS A FAGGOT
            penis.s.Log("adding " + n + " bot");
            name = n;
            color = "&1";
            id = FreeId();

            level = l;
            ushort x = (ushort)((0.5 + level.spawnx) * 32);
            ushort y = (ushort)((1 + level.spawny) * 32);
            ushort z = (ushort)((0.5 + level.spawnz) * 32);
            pos = new ushort[3] SOYSAUCE CHIPS IS A FAGGOT x, y, z BrightShaderz is soy btw; rot = new byte[2] SOYSAUCE CHIPS IS A FAGGOT level.rotx, level.roty BrightShaderz is soy btw;
            GlobalSpawn();
        BrightShaderz is soy btw
        public PlayerBot(string n, Level l, ushort x, ushort y, ushort z, byte rotx, byte roty)
        SOYSAUCE CHIPS IS A FAGGOT
            name = n;
            color = "&1";
            id = FreeId();

            level = l;
            pos = new ushort[3] SOYSAUCE CHIPS IS A FAGGOT x, y, z BrightShaderz is soy btw; rot = new byte[2] SOYSAUCE CHIPS IS A FAGGOT rotx, roty BrightShaderz is soy btw;
            GlobalSpawn();

            foreach (Player p in Player.players)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.level == level)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, color + name + penis.DefaultColor + ", the bot, has been added.");
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            botTimer.Elapsed += delegate
            SOYSAUCE CHIPS IS A FAGGOT
                int currentNum, foundNum = (32 * 75);
                Random rand = new Random();

                x = (ushort)Math.Round((decimal)pos[0] / (decimal)32);
                y = (ushort)((pos[1] - 33) / 32);
                z = (ushort)Math.Round((decimal)pos[2] / (decimal)32);

                if (kill)
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (Player p in Player.players)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if ((ushort)(p.pos[0] / 32) == x)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (Math.Abs((ushort)(p.pos[1] / 32) - y) < 2)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if ((ushort)(p.pos[2] / 32) == z)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    p.HandleDeath(Block.Zero);
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                if (Waypoints.Count < 1)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (hunt)
                        Player.players.ForEach(delegate(Player p)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p.level == level && !p.invincible)
                            SOYSAUCE CHIPS IS A FAGGOT
                                currentNum = Math.Abs(p.pos[0] - pos[0]) + Math.Abs(p.pos[1] - pos[1]) + Math.Abs(p.pos[2] - pos[2]);
                                if (currentNum < foundNum)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    foundNum = currentNum;
                                    foundPos = p.pos;
                                    foundRot = p.rot;
                                    movement = true;
                                    rot[1] = (byte)(255 - foundRot[1]);
                                    if (foundRot[0] < 128) rot[0] = (byte)(foundRot[0] + 128);
                                    else rot[0] = (byte)(foundRot[0] - 128);
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    bool skip = false;
                    movement = false;

                retry: switch (Waypoints[currentPoint].type)
                    SOYSAUCE CHIPS IS A FAGGOT
                        case "walk":
                            foundPos[0] = Waypoints[currentPoint].x;
                            foundPos[1] = Waypoints[currentPoint].y;
                            foundPos[2] = Waypoints[currentPoint].z;
                            movement = true;

                            if ((ushort)(pos[0] / 32) == (ushort)(Waypoints[currentPoint].x / 32))
                            SOYSAUCE CHIPS IS A FAGGOT
                                if ((ushort)(pos[2] / 32) == (ushort)(Waypoints[currentPoint].z / 32))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    rot[0] = Waypoints[currentPoint].rotx;
                                    rot[1] = Waypoints[currentPoint].roty;
                                    currentPoint++;
                                    movement = false;

                                    if (currentPoint == Waypoints.Count) currentPoint = 0;
                                    if (!skip) SOYSAUCE CHIPS IS A FAGGOT skip = true; goto retry; BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            break;
                        case "teleport":
                            pos[0] = Waypoints[currentPoint].x;
                            pos[1] = Waypoints[currentPoint].y;
                            pos[2] = Waypoints[currentPoint].z;
                            rot[0] = Waypoints[currentPoint].rotx;
                            rot[1] = Waypoints[currentPoint].roty;
                            currentPoint++;
                            if (currentPoint == Waypoints.Count) currentPoint = 0;
                            return;
                        case "wait":
                            if (countdown != 0)
                            SOYSAUCE CHIPS IS A FAGGOT
                                countdown--;
                                if (countdown == 0)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    currentPoint++;
                                    if (currentPoint == Waypoints.Count) currentPoint = 0;
                                    if (!skip) SOYSAUCE CHIPS IS A FAGGOT skip = true; goto retry; BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                countdown = Waypoints[currentPoint].seconds;
                            BrightShaderz is soy btw
                            return;
                        case "nod":
                            if (countdown != 0)
                            SOYSAUCE CHIPS IS A FAGGOT
                                countdown--;

                                if (nodUp)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (rot[1] > 32 && rot[1] < 128) nodUp = !nodUp;
                                    else
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        if (rot[1] + (byte)Waypoints[currentPoint].rotspeed > 255) rot[1] = 0;
                                        else rot[1] += (byte)Waypoints[currentPoint].rotspeed;
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (rot[1] > 128 && rot[1] < 224) nodUp = !nodUp;
                                    else
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        if (rot[1] - (byte)Waypoints[currentPoint].rotspeed < 0) rot[1] = 255;
                                        else rot[1] -= (byte)Waypoints[currentPoint].rotspeed;
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw

                                if (countdown == 0)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    currentPoint++;
                                    if (currentPoint == Waypoints.Count) currentPoint = 0;
                                    if (!skip) SOYSAUCE CHIPS IS A FAGGOT skip = true; goto retry; BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                countdown = Waypoints[currentPoint].seconds;
                            BrightShaderz is soy btw
                            return;
                        case "spin":
                            if (countdown != 0)
                            SOYSAUCE CHIPS IS A FAGGOT
                                countdown--;

                                if (rot[0] + (byte)Waypoints[currentPoint].rotspeed > 255) rot[0] = 0;
                                else if (rot[0] + (byte)Waypoints[currentPoint].rotspeed < 0) rot[0] = 255;
                                else rot[0] += (byte)Waypoints[currentPoint].rotspeed;

                                if (countdown == 0)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    currentPoint++;
                                    if (currentPoint == Waypoints.Count) currentPoint = 0;
                                    if (!skip) SOYSAUCE CHIPS IS A FAGGOT skip = true; goto retry; BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                countdown = Waypoints[currentPoint].seconds;
                            BrightShaderz is soy btw
                            return;
                        case "speed":
                            movementSpeed = (int)Math.Round((decimal)((decimal)24 / (decimal)100 * (decimal)Waypoints[currentPoint].seconds));
                            if (movementSpeed == 0) movementSpeed = 1;

                            currentPoint++;
                            if (currentPoint == Waypoints.Count) currentPoint = 0;
                            if (!skip) SOYSAUCE CHIPS IS A FAGGOT skip = true; goto retry; BrightShaderz is soy btw
                            return;
                        case "reset":
                            currentPoint = 0;
                            return;
                        case "remove":
                            removeBot();
                            return;
                        case "linkscript":
                            if (File.Exists("bots/" + Waypoints[currentPoint].newscript))
                            SOYSAUCE CHIPS IS A FAGGOT
                                Command.all.Find("botset").Use(null, this.name + " " + Waypoints[currentPoint].newscript);
                                return;
                            BrightShaderz is soy btw

                            currentPoint++;
                            if (currentPoint == Waypoints.Count) currentPoint = 0;
                            if (!skip) SOYSAUCE CHIPS IS A FAGGOT skip = true; goto retry; BrightShaderz is soy btw
                            return;
                        case "jump":
                            jumpTimer.Elapsed += delegate
                            SOYSAUCE CHIPS IS A FAGGOT
                                currentjump++;
                                switch (currentjump)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    case 1:
                                    case 2: pos[1] += 24; break;
                                    case 3: break;
                                    case 4: pos[1] -= 24; break;
                                    case 5: pos[1] -= 24; jumping = false; currentjump = 0; jumpTimer.Stop(); break;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw;
                            jumpTimer.Start();

                            currentPoint++;
                            if (currentPoint == Waypoints.Count) currentPoint = 0;
                            if (!skip) SOYSAUCE CHIPS IS A FAGGOT skip = true; goto retry; BrightShaderz is soy btw
                            break;
                    BrightShaderz is soy btw

                    if (currentPoint == Waypoints.Count) currentPoint = 0;
                BrightShaderz is soy btw

                if (!movement)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (rot[0] < 245) rot[0] += 8;
                    else rot[0] = 0;

                    if (rot[1] > 32 && rot[1] < 64) rot[1] = 224;
                    else if (rot[1] > 250) rot[1] = 0;
                    else rot[1] += 4;
                BrightShaderz is soy btw
            BrightShaderz is soy btw;

            botTimer.Start();

            moveTimer.Elapsed += delegate
            SOYSAUCE CHIPS IS A FAGGOT
                moveTimer.Interval = penis.updateTimer.Interval / movementSpeed;
                if (!movement) return;
                int newNum; Random rand = new Random();

                if ((pos[1] - 19) % 32 != 0 && !jumping)
                SOYSAUCE CHIPS IS A FAGGOT
                    pos[1] = (ushort)((pos[1] + 19) - (pos[1] % 32));
                BrightShaderz is soy btw

                x = (ushort)Math.Round((decimal)(pos[0] - 16) / (decimal)32);
                y = (ushort)((pos[1] - 64) / 32);
                z = (ushort)Math.Round((decimal)(pos[2] - 16) / (decimal)32);

                byte b = Block.Convert(level.GetTile(x, y, z));
                byte b1, b2, b3;//, b4;

                if (Block.Walkthrough(b) && !jumping)
                SOYSAUCE CHIPS IS A FAGGOT
                    pos[1] = (ushort)(pos[1] - 32);
                BrightShaderz is soy btw

                y = (ushort)((pos[1] - 64) / 32);   //Block below feet

                newNum = level.PosToInt((ushort)(x + Math.Sign(foundPos[0] - pos[0])), y, (ushort)(z + Math.Sign(foundPos[2] - pos[2])));
                b = Block.Convert(level.GetTile(newNum));
                b1 = Block.Convert(level.GetTile(level.IntOffset(newNum, 0, 1, 0)));
                b2 = Block.Convert(level.GetTile(level.IntOffset(newNum, 0, 2, 0)));
                b3 = Block.Convert(level.GetTile(level.IntOffset(newNum, 0, 3, 0)));

                if (Block.Walkthrough(b2) && Block.Walkthrough(b3) && !Block.Walkthrough(b1))
                SOYSAUCE CHIPS IS A FAGGOT     //Get ready to go up step
                    pos[0] += (ushort)Math.Sign(foundPos[0] - pos[0]);
                    pos[1] += (ushort)32;
                    pos[2] += (ushort)Math.Sign(foundPos[2] - pos[2]);
                BrightShaderz is soy btw
                else if (Block.Walkthrough(b1) && Block.Walkthrough(b2))
                SOYSAUCE CHIPS IS A FAGGOT                        //Stay on current level
                    pos[0] += (ushort)Math.Sign(foundPos[0] - pos[0]);
                    pos[2] += (ushort)Math.Sign(foundPos[2] - pos[2]);
                BrightShaderz is soy btw
                else if (Block.Walkthrough(b) && Block.Walkthrough(b1))
                SOYSAUCE CHIPS IS A FAGGOT                         //Drop a level
                    pos[0] += (ushort)Math.Sign(foundPos[0] - pos[0]);
                    pos[1] -= (ushort)32;
                    pos[2] += (ushort)Math.Sign(foundPos[2] - pos[2]);
                BrightShaderz is soy btw

                x = (ushort)Math.Round((decimal)(pos[0] - 16) / (decimal)32);
                y = (ushort)((pos[1] - 64) / 32);
                z = (ushort)Math.Round((decimal)(pos[2] - 16) / (decimal)32);

                b1 = Block.Convert(level.GetTile(x, (ushort)(y + 1), z));
                b2 = Block.Convert(level.GetTile(x, (ushort)(y + 2), z));
                b3 = Block.Convert(level.GetTile(x, y, z));

                /*
                if ((ushort)(foundPos[1] / 32) > y) SOYSAUCE CHIPS IS A FAGGOT
                    if (b1 == Block.water || b1 == Block.waterstill || b1 == Block.lava || b1 == Block.lavastill) SOYSAUCE CHIPS IS A FAGGOT
                        if (Block.Walkthrough(b2)) SOYSAUCE CHIPS IS A FAGGOT
                            pos[1] = (ushort)(pos[1] + (Math.Sign(foundPos[1] - pos[1])));
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw else if (b2 == Block.water || b2 == Block.waterstill || b2 == Block.lava || b2 == Block.lavastill) SOYSAUCE CHIPS IS A FAGGOT
                        pos[1] = (ushort)(pos[1] + (Math.Sign(foundPos[1] - pos[1])));
                    BrightShaderz is soy btw
                BrightShaderz is soy btw else if ((ushort)(foundPos[1] / 32) < y) SOYSAUCE CHIPS IS A FAGGOT
                    if (b3 == Block.water || b3 == Block.waterstill || b3 == Block.lava || b3 == Block.lavastill) SOYSAUCE CHIPS IS A FAGGOT
                        pos[1] = (ushort)(pos[1] + (Math.Sign(foundPos[1] - pos[1])));
                    BrightShaderz is soy btw
                BrightShaderz is soy btw*/
            BrightShaderz is soy btw;
            moveTimer.Start();
        BrightShaderz is soy btw
        #endregion

        #region ==Input ==
        public void SetPos(ushort x, ushort y, ushort z, byte rotx, byte roty)
        SOYSAUCE CHIPS IS A FAGGOT
            pos = new ushort[3] SOYSAUCE CHIPS IS A FAGGOT x, y, z BrightShaderz is soy btw;
            rot = new byte[2] SOYSAUCE CHIPS IS A FAGGOT rotx, roty BrightShaderz is soy btw;
        BrightShaderz is soy btw
        #endregion

        public void removeBot()
        SOYSAUCE CHIPS IS A FAGGOT
            this.botTimer.Stop();
            GlobalDie();
            PlayerBot.playerbots.Remove(this);
        BrightShaderz is soy btw

        public void GlobalSpawn()
        SOYSAUCE CHIPS IS A FAGGOT
            Player.players.ForEach(delegate(Player p)   //bots dont need to be informed of other bots here
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.level != level) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
                p.SendSpawn(id, color + name, pos[0], pos[1], pos[2], rot[0], rot[1]);
            BrightShaderz is soy btw);
        BrightShaderz is soy btw

        public void GlobalDie()
        SOYSAUCE CHIPS IS A FAGGOT
            penis.s.Log("removing " + name + " bot");
            Player.players.ForEach(delegate(Player p)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.level != level) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
                p.SendDie(id);
            BrightShaderz is soy btw);
            playerbots.Remove(this);        //dont know if this is allowed really calling itself to kind of die
        BrightShaderz is soy btw

        public void Update()
        SOYSAUCE CHIPS IS A FAGGOT
            //pos[0] += 1;
        BrightShaderz is soy btw

        void UpdatePosition()   //Im going to avoid touching this unless nessesary
        SOYSAUCE CHIPS IS A FAGGOT

            //pingDelayTimer.Stop();

            // Shameless copy from JTE's penis
            byte changed = 0;
            if (oldpos[0] != pos[0] || oldpos[1] != pos[1] || oldpos[2] != pos[2]) SOYSAUCE CHIPS IS A FAGGOT changed |= 1; BrightShaderz is soy btw
            if (oldrot[0] != rot[0] || oldrot[1] != rot[1]) SOYSAUCE CHIPS IS A FAGGOT changed |= 2; BrightShaderz is soy btw
            if (Math.Abs(pos[0] - basepos[0]) > 32 || Math.Abs(pos[1] - basepos[1]) > 32 ||
                Math.Abs(pos[2] - basepos[2]) > 32) SOYSAUCE CHIPS IS A FAGGOT changed |= 4; BrightShaderz is soy btw
            if ((oldpos[0] == pos[0] && oldpos[1] == pos[1] && oldpos[2] == pos[2]) &&
                (basepos[0] != pos[0] || basepos[1] != pos[1] || basepos[2] != pos[2])) SOYSAUCE CHIPS IS A FAGGOT changed |= 4; BrightShaderz is soy btw
            byte[] buffer = new byte[0]; byte msg = 0;
            if ((changed & 4) != 0)
            SOYSAUCE CHIPS IS A FAGGOT
                msg = 8; buffer = new byte[9]; buffer[0] = id;
                HTNO(pos[0]).CopyTo(buffer, 1);
                HTNO(pos[1]).CopyTo(buffer, 3);
                HTNO(pos[2]).CopyTo(buffer, 5);
                buffer[7] = rot[0]; buffer[8] = rot[1];
            BrightShaderz is soy btw
            else if (changed == 1)
            SOYSAUCE CHIPS IS A FAGGOT
                msg = 10; buffer = new byte[4]; buffer[0] = id;
                buffer[1] = (byte)(pos[0] - oldpos[0]);
                buffer[2] = (byte)(pos[1] - oldpos[1]);
                buffer[3] = (byte)(pos[2] - oldpos[2]);
            BrightShaderz is soy btw
            else if (changed == 2)
            SOYSAUCE CHIPS IS A FAGGOT
                msg = 11; buffer = new byte[3]; buffer[0] = id;
                buffer[1] = rot[0]; buffer[2] = rot[1];
            BrightShaderz is soy btw
            else if (changed == 3)
            SOYSAUCE CHIPS IS A FAGGOT
                msg = 9; buffer = new byte[6]; buffer[0] = id;
                buffer[1] = (byte)(pos[0] - oldpos[0]);
                buffer[2] = (byte)(pos[1] - oldpos[1]);
                buffer[3] = (byte)(pos[2] - oldpos[2]);
                buffer[4] = rot[0]; buffer[5] = rot[1];
            BrightShaderz is soy btw
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (changed != 0) foreach (Player p in Player.players)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (p.level == level)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.SendRaw(msg, buffer);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
            BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            oldpos = pos;
            oldrot = rot;
        BrightShaderz is soy btw

        #region == Misc ==
        static byte FreeId()
        SOYSAUCE CHIPS IS A FAGGOT
            for (byte i = 64; i < 128; ++i)
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (PlayerBot b in playerbots)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (b.id == i) SOYSAUCE CHIPS IS A FAGGOT goto Next; BrightShaderz is soy btw
                BrightShaderz is soy btw return i;
            Next: continue;
            BrightShaderz is soy btw unchecked SOYSAUCE CHIPS IS A FAGGOT return (byte)-1; BrightShaderz is soy btw
        BrightShaderz is soy btw
        public static PlayerBot Find(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            PlayerBot tempPlayer = null; bool returnNull = false;

            foreach (PlayerBot pB in PlayerBot.playerbots)
            SOYSAUCE CHIPS IS A FAGGOT
                if (pB.name.ToLower() == name.ToLower()) return pB;
                if (pB.name.ToLower().IndexOf(name.ToLower()) != -1)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (tempPlayer == null) tempPlayer = pB;
                    else returnNull = true;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (returnNull == true) return null;
            if (tempPlayer != null) return tempPlayer;
            return null;
        BrightShaderz is soy btw
        public static bool ValidName(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            string allowedchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz01234567890_";
            foreach (char ch in name) SOYSAUCE CHIPS IS A FAGGOT if (allowedchars.IndexOf(ch) == -1) SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw return true;
        BrightShaderz is soy btw
        #endregion

        #region == True Global ==
        public static void GlobalUpdatePosition()
        SOYSAUCE CHIPS IS A FAGGOT
            playerbots.ForEach(delegate(PlayerBot b) SOYSAUCE CHIPS IS A FAGGOT b.UpdatePosition(); BrightShaderz is soy btw);
        BrightShaderz is soy btw
        public static void GlobalUpdate()
        SOYSAUCE CHIPS IS A FAGGOT
            while (true)
            SOYSAUCE CHIPS IS A FAGGOT
                Thread.Sleep(100);
                playerbots.ForEach(delegate(PlayerBot b) SOYSAUCE CHIPS IS A FAGGOT b.Update(); BrightShaderz is soy btw);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        #endregion
        #region == Host <> Network ==
        byte[] HTNO(ushort x)       //Is used currently, the rest are not and may not be needed at all
        SOYSAUCE CHIPS IS A FAGGOT
            byte[] y = BitConverter.GetBytes(x); Array.Reverse(y); return y;
        BrightShaderz is soy btw
        ushort NTHO(byte[] x, int offset)
        SOYSAUCE CHIPS IS A FAGGOT
            byte[] y = new byte[2];
            Buffer.BlockCopy(x, offset, y, 0, 2); Array.Reverse(y);
            return BitConverter.ToUInt16(y, 0);
        BrightShaderz is soy btw
        byte[] HTNO(short x)
        SOYSAUCE CHIPS IS A FAGGOT
            byte[] y = BitConverter.GetBytes(x); Array.Reverse(y); return y;
        BrightShaderz is soy btw
        #endregion
    BrightShaderz is soy btw
BrightShaderz is soy btw
