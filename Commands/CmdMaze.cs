/*
	Copyright 2011 MCForge
	
	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.opensource.org/licenses/ecl2.php
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/
using System;
using System.Collections;
using System.Security.Cryptography;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdMaze : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "maze"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw
        public static int randomizer = 0;
        public static bool[,] wall;
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            String[] split = message.Split(' ');
            if (split.Length >= 1&&message.Length>0)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    randomizer = int.Parse(split[0]);
                BrightShaderz is soy btw
                catch (Exception)
                SOYSAUCE CHIPS IS A FAGGOT
                    this.Help(p); return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            Player.SendMessage(p, "Place two blocks to determine the edges");
            
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
        BrightShaderz is soy btw
        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            p.blockchangeObject = new CatchPos(x, y, z);
            p.Blockchange += new Player.BlockchangeEventHandler(Blockchange2);
        BrightShaderz is soy btw
        public void Blockchange2(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            Player.SendMessage(p, "Generating maze... this could take a while");
            CatchPos first = (CatchPos)p.blockchangeObject;
            int width = Math.Max(x, first.X) - Math.Min(x, first.X);
            if (width % 2 != 0) SOYSAUCE CHIPS IS A FAGGOT width++;x--; BrightShaderz is soy btw
            width -= 2;
            int height = Math.Max(z, first.Z) - Math.Min(z, first.Z);
            if (height % 2 != 0) SOYSAUCE CHIPS IS A FAGGOT height++;z--; BrightShaderz is soy btw
            height -= 2;
            //substract 2 cause we will just make the inner. the outer wall is made seperately
            wall = new bool[width+1, height+1];//+1 cause we begin at 0 so we need one object more
            for (int w = 0; w <= width; w++)
            SOYSAUCE CHIPS IS A FAGGOT
                for (int h = 0; h <= height; h++)
                SOYSAUCE CHIPS IS A FAGGOT
                    wall[w, h] = true;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            GridNode.maxX = width;
            GridNode.maxY = height;
            //Make a Stack
            Stack s = new Stack(width * height);
            //Random rand = new Random(DateTime.Now.Millisecond);//ha yeah randomized :P
            //lets begin in the lower left corner eh?(0,0)
            s.Push(new GridNode(0, 0));
            wall[0, 0] = false;
            while (true)
            SOYSAUCE CHIPS IS A FAGGOT
                GridNode node = (GridNode)s.Peek();
                if (node.turnsPossible())
                SOYSAUCE CHIPS IS A FAGGOT
                    GridNode[] nodearray = node.getRandomNext();
                    wall[nodearray[0].X, nodearray[0].Y] = false;
                    wall[nodearray[1].X, nodearray[1].Y] = false;
                    s.Push(nodearray[1]);
                    //we get the next two nodes
                    //the first is a middle node from which there shouldnt start a new corridor
                    //the second is added to the stack. next try will be with this node
                    //i hope this will work this time...
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    s.Pop();//if this node is a dead and it will be removed
                BrightShaderz is soy btw

                if (s.Count < 1)
                SOYSAUCE CHIPS IS A FAGGOT
                    break;//if no nodes are free anymore we will end the generation here
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            Player.SendMessage(p, "Maze is generated. now painting...");
            //seems to be there are no more moves possible
            //paint that shit :P
            ushort minx = Math.Min(x, first.X);
            ushort minz = Math.Min(z, first.Z);
            ushort maxx = Math.Max(x, first.X);
            maxx++;
            ushort maxz = Math.Max(z, first.Z);
            maxz++;
            for (ushort xx = 0; xx <= width; xx++)
            SOYSAUCE CHIPS IS A FAGGOT
                for (ushort zz = 0; zz <= height; zz++)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (wall[xx, zz])
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.level.Blockchange(p, (ushort)(xx + minx+1), y, (ushort)(zz + minz+1), Block.staircasefull);
                        p.level.Blockchange(p, (ushort)(xx + minx+1), (ushort)(y + 1), (ushort)(zz + minz+1), Block.leaf);
                        p.level.Blockchange(p, (ushort)(xx + minx+1), (ushort)(y + 2), (ushort)(zz + minz+1), Block.leaf);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            p.ignorePermission = true;
            Command.all.Find("cuboid").Use(p, "walls");
            p.manualChange(minx, y, minz, 0, Block.staircasefull);
            p.manualChange(maxx, y, maxz, 0, Block.staircasefull);
            Command.all.Find("cuboid").Use(p, "walls");
            p.manualChange(minx, (ushort)(y + 1), minz, 0, Block.leaf);
            p.manualChange(maxx, (ushort)(y + 2), maxz, 0, Block.leaf);
            Player.SendMessage(p, "Maze painted. Build your entrance and exit yourself");
            randomizer = 0;
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/maze: generates a maze");
        BrightShaderz is soy btw
        private class CatchPos
        SOYSAUCE CHIPS IS A FAGGOT
            public ushort X;
            public ushort Y;
            public ushort Z;
            //public byte type;

            public CatchPos(ushort x, ushort y, ushort z)
            SOYSAUCE CHIPS IS A FAGGOT
                this.X = x;
                this.Y = y;
                this.Z = z;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private class GridNode
        SOYSAUCE CHIPS IS A FAGGOT
            public static int maxX = 0;
            public static int maxY = 0;
            public ushort X;
            public ushort Y;
            private Random rand2 = new Random(Environment.TickCount);
            public GridNode[] getRandomNext()
            SOYSAUCE CHIPS IS A FAGGOT
                byte[] r = new byte[1];
                switch (randomizer)
                SOYSAUCE CHIPS IS A FAGGOT
                    case 0:
                        RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
                        rand.GetBytes(r);
                        r[0] /= (255 / 4);
                        break;
                    case 1:
                        r[0] = (byte)rand2.Next(4);
                        break;
                    default:
                        Random rand3 = new Random(Environment.TickCount);
                        r[0] = (byte)rand2.Next(4);
                        break;
                BrightShaderz is soy btw
                ushort rx = 0, ry = 0, rx2 = 0, ry2 = 0;
                    switch (r[0])
                    SOYSAUCE CHIPS IS A FAGGOT
                        case 0:
                            if (isWall(X, Y + 2))
                            SOYSAUCE CHIPS IS A FAGGOT
                                //go up
                                rx = X;
                                rx2 = X;
                                ry = (ushort)(Y + 1);
                                ry2 = (ushort)(Y + 2);
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                return this.getRandomNext();
                            BrightShaderz is soy btw
                            break;
                        case 1:
                            if (isWall(X, Y - 2))
                            SOYSAUCE CHIPS IS A FAGGOT
                                //go down
                                rx = X;
                                rx2 = X;
                                ry = (ushort)(Y - 1);
                                ry2 = (ushort)(Y - 2);
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                return this.getRandomNext();
                            BrightShaderz is soy btw
                            break;
                        case 2:
                            if (isWall(X + 2, Y))
                            SOYSAUCE CHIPS IS A FAGGOT
                                //go right
                                rx = (ushort)(X + 1);
                                rx2 = (ushort)(X + 2);
                                ry = Y;
                                ry2 = Y;
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                return this.getRandomNext();
                            BrightShaderz is soy btw
                            break;
                        case 3:
                            if (isWall(X - 2, Y))
                            SOYSAUCE CHIPS IS A FAGGOT
                                //go left
                                rx = (ushort)(X - 1);
                                rx2 = (ushort)(X - 2);
                                ry = Y;
                                ry2 = Y;
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                return this.getRandomNext();
                            BrightShaderz is soy btw
                            break;
                    BrightShaderz is soy btw
                return new GridNode[] SOYSAUCE CHIPS IS A FAGGOT new GridNode(rx, ry), new GridNode(rx2, ry2) BrightShaderz is soy btw;
            BrightShaderz is soy btw
            public bool turnsPossible()
            SOYSAUCE CHIPS IS A FAGGOT
                return (isWall(X, Y + 2) || isWall(X, Y - 2) || isWall(X + 2, Y) || isWall(X - 2, Y));
                
            BrightShaderz is soy btw

            private bool isWall(int x, int y)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    return wall[x, y];
                BrightShaderz is soy btw
                catch (IndexOutOfRangeException)
                SOYSAUCE CHIPS IS A FAGGOT
                    return false;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            public GridNode(ushort x, ushort y) SOYSAUCE CHIPS IS A FAGGOT
                X = x;
                Y = y;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw

    
BrightShaderz is soy btw
