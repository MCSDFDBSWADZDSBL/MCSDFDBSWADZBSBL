/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCLawl) Licensed under the
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
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MCDawn
{
    public class Block
    {
        // Default blocks
        public const ushort air = 0;
        public const ushort rock = 1;
        public const ushort grass = 2;
        public const ushort dirt = 3;
        public const ushort stone = 4;
        public const ushort wood = 5;
        public const ushort shrub = 6;
        public const ushort blackrock = 7;// adminium
        public const ushort water = 8;
        public const ushort waterstill = 9;
        public const ushort lava = 10;
        public const ushort lavastill = 11;
        public const ushort sand = 12;
        public const ushort gravel = 13;
        public const ushort goldrock = 14;
        public const ushort ironrock = 15;
        public const ushort coal = 16;
        public const ushort trunk = 17;
        public const ushort leaf = 18;
        public const ushort sponge = 19;
        public const ushort glass = 20;
        public const ushort red = 21;
        public const ushort orange = 22;
        public const ushort yellow = 23;
        public const ushort lightgreen = 24;
        public const ushort green = 25;
        public const ushort aquagreen = 26;
        public const ushort cyan = 27;
        public const ushort lightblue = 28;
        public const ushort blue = 29;
        public const ushort purple = 30;
        public const ushort lightpurple = 31;
        public const ushort pink = 32;
        public const ushort darkpink = 33;
        public const ushort darkgrey = 34;
        public const ushort lightgrey = 35;
        public const ushort white = 36;
        public const ushort yellowflower = 37;
        public const ushort redflower = 38;
        public const ushort mushroom = 39;
        public const ushort redmushroom = 40;
        public const ushort goldsolid = 41;
        public const ushort iron = 42;
        public const ushort staircasefull = 43;
        public const ushort staircasestep = 44;
        public const ushort brick = 45;
        public const ushort tnt = 46;
        public const ushort bookcase = 47;
        public const ushort stonevine = 48;
        public const ushort obsidian = 49;
        public const ushort Zero = 0xff;

        //Custom blocks
        public const ushort flagbase = 70;
        public const ushort op_glass = 100;
        public const ushort opsidian = 101;
        public const ushort op_brick = 102;
        public const ushort op_stone = 103;
        public const ushort op_cobblestone = 104;
        public const ushort op_air = 105;
        public const ushort op_water = 106;

        public const ushort wood_float = 110;
        public const ushort door = 111;
        public const ushort lava_fast = 112;
        public const ushort door2 = 113;
        public const ushort door3 = 114;
        public const ushort door4 = 115;
        public const ushort door5 = 116;
        public const ushort door6 = 117;
        public const ushort door7 = 118;
        public const ushort door8 = 119;
        public const ushort door9 = 120;
        public const ushort door10 = 121;

        public const ushort tdoor = 122;
        public const ushort tdoor2 = 123;
        public const ushort tdoor3 = 124;
        public const ushort tdoor4 = 125;
        public const ushort tdoor5 = 126;
        public const ushort tdoor6 = 127;
        public const ushort tdoor7 = 128;
        public const ushort tdoor8 = 129;

        //Messages
        public const ushort MsgWhite = 130;
        public const ushort MsgBlack = 131;
        public const ushort MsgAir = 132;
        public const ushort MsgWater = 133;
        public const ushort MsgLava = 134;

        public const ushort tdoor9 = 135;
        public const ushort tdoor10 = 136;
        public const ushort tdoor11 = 137;
        public const ushort tdoor12 = 138;
        public const ushort tdoor13 = 139;

        //"finite"
        public const ushort WaterDown = 140;
        public const ushort LavaDown = 141;
        public const ushort WaterFaucet = 143;
        public const ushort LavaFaucet = 144;

        public const ushort finiteWater = 145;
        public const ushort finiteLava = 146;
        public const ushort finiteFaucet = 147;

        public const ushort odoor1 = 148;
        public const ushort odoor2 = 149;
        public const ushort odoor3 = 150;
        public const ushort odoor4 = 151;
        public const ushort odoor5 = 152;
        public const ushort odoor6 = 153;
        public const ushort odoor7 = 154;
        public const ushort odoor8 = 155;
        public const ushort odoor9 = 156;
        public const ushort odoor10 = 157;
        public const ushort odoor11 = 158;
        public const ushort odoor12 = 159;

        //movement
        public const ushort air_portal = 160;
        public const ushort water_portal = 161;
        public const ushort lava_portal = 162;

        //Movement doors
        public const ushort air_door = 164;
        public const ushort air_switch = 165;
        public const ushort water_door = 166;
        public const ushort lava_door = 167;

        public const ushort odoor1_air = 168;
        public const ushort odoor2_air = 169;
        public const ushort odoor3_air = 170;
        public const ushort odoor4_air = 171;
        public const ushort odoor5_air = 172;
        public const ushort odoor6_air = 173;
        public const ushort odoor7_air = 174;

        //portals
        public const ushort blue_portal = 175;
        public const ushort orange_portal = 176;

        public const ushort odoor8_air = 177;
        public const ushort odoor9_air = 178;
        public const ushort odoor10_air = 179;
        public const ushort odoor11_air = 180;
        public const ushort odoor12_air = 181;

        //Explosions
        public const ushort smalltnt = 182;
        public const ushort bigtnt = 183;
        public const ushort tntexplosion = 184;

        public const ushort fire = 185;

        public const ushort rocketstart = 187;
        public const ushort rockethead = 188;
        public const ushort firework = 189;

        //Death
        public const ushort deathlava = 190;
        public const ushort deathwater = 191;
        public const ushort deathair = 192;

        public const ushort activedeathwater = 193;
        public const ushort activedeathlava = 194;

        public const ushort magma = 195;
        public const ushort geyser = 196;

        public const ushort air_flood = 200;
        public const ushort door_air = 201;
        public const ushort air_flood_layer = 202;
        public const ushort air_flood_down = 203;
        public const ushort air_flood_up = 204;
        public const ushort door2_air = 205;
        public const ushort door3_air = 206;
        public const ushort door4_air = 207;
        public const ushort door5_air = 208;
        public const ushort door6_air = 209;
        public const ushort door7_air = 210;
        public const ushort door8_air = 211;
        public const ushort door9_air = 212;
        public const ushort door10_air = 213;
        public const ushort door11_air = 214;
        public const ushort door12_air = 215;
        public const ushort door13_air = 216;
        public const ushort door14_air = 217;

        public const ushort door_iron = 220;
        public const ushort door_dirt = 221;
        public const ushort door_grass = 222;
        public const ushort door_blue = 223;
        public const ushort door_book = 224;
        public const ushort door_iron_air = 225;
        public const ushort door_dirt_air = 226;
        public const ushort door_grass_air = 227;
        public const ushort door_blue_air = 228;
        public const ushort door_book_air = 229;

        public const ushort train = 230;

        public const ushort creeper = 231;
        public const ushort zombiebody = 232;
        public const ushort zombiehead = 233;

        public const ushort birdwhite = 235;
        public const ushort birdblack = 236;
        public const ushort birdwater = 237;
        public const ushort birdlava = 238;
        public const ushort birdred = 239;
        public const ushort birdblue = 240;
        public const ushort birdkill = 242;

        public const ushort fishgold = 245;
        public const ushort fishsponge = 246;
        public const ushort fishshark = 247;
        public const ushort fishsalmon = 248;
        public const ushort fishbetta = 249;
        public const ushort fishlavashark = 250;

        public const ushort snake = 251;
        public const ushort snaketail = 252;

        public const ushort cmdblock = 253;

        public const ushort home_portal = 254;

        public const ushort sandstone = 255;

        public static List<Blocks> BlockList = new List<Blocks>();

        public class Blocks
        {
            public ushort type;  
            public LevelPermission lowestRank;
            public List<LevelPermission> disallow = new List<LevelPermission>();
            public List<LevelPermission> allow = new List<LevelPermission>();
        }


        public static void SetBlocks()
        {
            BlockList = new List<Blocks>();
            Blocks b = new Blocks();
            b.lowestRank = LevelPermission.Guest;

            for (int i = 0; i < 65537; i++)
            {
                b = new Blocks();
                b.type = (byte)i;
                BlockList.Add(b);
            }

            List<Blocks> storedList = new List<Blocks>();

            foreach (Blocks bs in BlockList)
            {
                b = new Blocks();
                b.type = bs.type;

                switch (bs.type)
                {
                    case Zero:
                        b.lowestRank = LevelPermission.Admin;
                        break;

                    case op_glass:
                    case opsidian:
                    case op_brick:
                    case op_stone:
                    case op_cobblestone:
                    case op_air:
                    case op_water:
                    case blackrock:

                    case air_flood:
                    case air_flood_down:
                    case air_flood_layer:
                    case air_flood_up:

                    case bigtnt:
                    case rocketstart:
                    case rockethead:

                    case creeper:
                    case zombiebody:
                    case zombiehead:

                    case birdred:
                    case birdkill:
                    case birdblue:

                    case fishgold:
                    case fishsponge:
                    case fishshark:
                    case fishsalmon:
                    case fishbetta:
                    case fishlavashark:

                    case snake:
                    case snaketail:
                    case flagbase:

                    case home_portal:

                        b.lowestRank = LevelPermission.Operator;
                        break;

                    case wood_float:

                    case door_air:
                    case door2_air:
                    case door3_air:
                    case door4_air:
                    case door5_air:
                    case door6_air:
                    case door7_air:
                    case door8_air:
                    case door9_air:
                    case door10_air:
                    case door11_air:
                    case door12_air:
                    case door13_air:
                    case door14_air:
                    case door_iron_air:
                    case door_grass_air:
                    case door_dirt_air:
                    case door_blue_air:
                    case door_book_air:

                    case odoor1_air:
                    case odoor2_air:
                    case odoor3_air:
                    case odoor4_air:
                    case odoor5_air:
                    case odoor6_air:
                    case odoor7_air:
                    case odoor8_air:
                    case odoor9_air:
                    case odoor10_air:
                    case odoor11_air:
                    case odoor12_air:

                    case MsgAir:
                    case MsgBlack:
                    case MsgLava:
                    case MsgWater:
                    case MsgWhite:
                    case air_portal:
                    case water_portal:
                    case lava_portal:
                    case blue_portal:
                    case orange_portal:

                    case water:
                    case lava:
                    case lava_fast:
                    case WaterDown:
                    case LavaDown:
                    case WaterFaucet:
                    case LavaFaucet:
                    case finiteWater:
                    case finiteLava:
                    case finiteFaucet:
                    case magma:
                    case geyser:
                    case deathlava:
                    case deathwater:
                    case deathair:
                    case activedeathwater:
                    case activedeathlava:
                    case fire:

                    case smalltnt:
                    case tntexplosion:
                    case firework:

                    case train:

                    case birdwhite:
                    case birdblack:
                    case birdwater:
                    case birdlava:
                    case cmdblock:
                        b.lowestRank = LevelPermission.AdvBuilder;
                        break;

                    case door:
                    case door2:
                    case door3:
                    case door4:
                    case door5:
                    case door6:
                    case door7:
                    case door8:
                    case door9:
                    case door10:
                    case air_door:
                    case air_switch:
                    case water_door:
                    case lava_door:
                    case door_iron:
                    case door_grass:
                    case door_dirt:
                    case door_blue:
                    case door_book:

                    case tdoor:
                    case tdoor2:
                    case tdoor3:
                    case tdoor4:
                    case tdoor5:
                    case tdoor6:
                    case tdoor7:
                    case tdoor8:
                    case tdoor9:
                    case tdoor10:
                    case tdoor11:
                    case tdoor12:
                    case tdoor13:

                    case odoor1:
                    case odoor2:
                    case odoor3:
                    case odoor4:
                    case odoor5:
                    case odoor6:
                    case odoor7:
                    case odoor8:
                    case odoor9:
                    case odoor10:
                    case odoor11:
                    case odoor12:

                        b.lowestRank = LevelPermission.Builder;
                        break;

                    default:
                        b.lowestRank = LevelPermission.Banned;
                        break;
                }

                storedList.Add(b);
            }

            //CHECK FOR SPECIAL RANK ALLOWANCES SET BY USER
            if (File.Exists("properties/block.properties"))
            {
                string[] lines = File.ReadAllLines("properties/block.properties");

                if (lines.Length == 0) { return; } //Why was this empty..?
                else if (lines[0] == "#Version 2")
                {
                    string[] colon = new string[] { " : " };
                    foreach (string line in lines)
                    {
                        if (line != "" && line[0] != '#')
                        {
                            //Name : Lowest : Disallow : Allow
                            string[] block = line.Split(colon, StringSplitOptions.None);
                            Blocks newBlock = new Blocks();

                            if (Block.Byte(block[0]) == Block.Zero)
                            {
                                continue;
                            }
                            newBlock.type = Block.Byte(block[0]);

                            string[] disallow = new string[0];
                            if (block[2] != "")
                                disallow = block[2].Split(',');
                            string[] allow = new string[0];
                            if (block[3] != "")
                                allow = block[3].Split(',');

                            try
                            {
                                newBlock.lowestRank = (LevelPermission)int.Parse(block[1]);
                                foreach (string s in disallow) { newBlock.disallow.Add((LevelPermission)int.Parse(s)); }
                                foreach (string s in allow) { newBlock.allow.Add((LevelPermission)int.Parse(s)); }
                            }
                            catch
                            {
                                Server.s.Log("Hit an error on the block " + line);
                                continue;
                            }

                            int current = 0;
                            foreach (Blocks bS in storedList)
                            {
                                if (newBlock.type == bS.type)
                                {
                                    storedList[current] = newBlock;
                                    break;
                                }
                                current++;
                            }
                        }
                    }
                }
                else
                {
                    foreach (string s in lines)
                    {
                        if (s[0] != '#')
                        {
                            try
                            {
                                Blocks newBlock = new Blocks();
                                newBlock.type = Block.Byte(s.Split(' ')[0]);
                                newBlock.lowestRank = Level.PermissionFromName(s.Split(' ')[2]);
                                if (newBlock.lowestRank != LevelPermission.Null)
                                    storedList[storedList.FindIndex(sL => sL.type == newBlock.type)] = newBlock;
                                else
                                    throw new Exception();
                            }
                            catch { Server.s.Log("Could not find the rank given on " + s + ". Using default"); }
                        }
                    }
                }
            }

            BlockList.Clear();
            BlockList.AddRange(storedList);
            SaveBlocks(BlockList);
        }
        public static void SaveBlocks(List<Blocks> givenList)
        {
            try
            {
                StreamWriter w = new StreamWriter(File.Create("properties/block.properties"));
                w.WriteLine("#Version 2");
                w.WriteLine("#   This file dictates what levels may use what blocks");
                w.WriteLine("#   If someone has royally screwed up the ranks, just delete this file and let the server restart");
                w.WriteLine("#   Allowed ranks: " + Group.concatList(false, false, true));
                w.WriteLine("#   Disallow and allow can be left empty, just make sure there's 2 spaces between the colons");
                w.WriteLine("#   This works entirely on permission values, not names. Do not enter a rank name. Use it's permission value");
                w.WriteLine("#   BlockName : LowestRank : Disallow : Allow");
                w.WriteLine("#   lava : 60 : 80,67 : 40,41,55");
                w.WriteLine("");

                foreach (Blocks bs in givenList)
                {
                    if (Block.Name(bs.type).ToLower() != "unknown")
                    {
                        string line = Block.Name(bs.type) + " : " + (int)bs.lowestRank + " : " + GrpCommands.getInts(bs.disallow) + " : " + GrpCommands.getInts(bs.allow);
                        w.WriteLine(line);
                    }
                }
                w.Flush();
                w.Close();
                w.Dispose();
            }
            catch (Exception e) { Server.ErrorLog(e); }
        }

        public static bool canPlace(Player p, ushort b) { return canPlace(p.group.Permission, b); }
        public static bool canPlace(LevelPermission givenPerm, ushort givenBlock)
        {
            foreach (Blocks b in BlockList)
            {
                if (givenBlock == b.type)
                {
                    if ((b.lowestRank <= givenPerm && !b.disallow.Contains(givenPerm)) || b.allow.Contains(givenPerm)) return true;
                    return false;
                }
            }

            return false;
        }

        public static bool Walkthrough(ushort type)
        {
            switch (type)
            {
                case air:
                case water:
                case waterstill:
                case lava:
                case lavastill:
                case yellowflower:
                case redflower:
                case mushroom:
                case redmushroom:
                case shrub:
                    return true;
            }
            return false;
        }

        public static bool AnyBuild(ushort type)
        {
            switch (type)
            {
                case Block.air:
                case Block.rock:
                case Block.grass:
                case Block.dirt:
                case Block.stone:
                case Block.wood:
                case Block.shrub:
                case Block.sand:
                case Block.gravel:
                case Block.goldrock:
                case Block.ironrock:
                case Block.coal:
                case Block.trunk:
                case Block.leaf:
                case Block.sponge:
                case Block.glass:
                case Block.red:
                case Block.orange:
                case Block.yellow:
                case Block.lightgreen:
                case Block.green:
                case Block.aquagreen:
                case Block.cyan:
                case Block.lightblue:
                case Block.blue:
                case Block.purple:
                case Block.lightpurple:
                case Block.pink:
                case Block.darkpink:
                case Block.darkgrey:
                case Block.lightgrey:
                case Block.white:
                case Block.yellowflower:
                case Block.redflower:
                case Block.mushroom:
                case Block.redmushroom:
                case Block.goldsolid:
                case Block.iron:
                case Block.staircasefull:
                case Block.staircasestep:
                case Block.brick:
                case Block.tnt:
                case Block.bookcase:
                case Block.stonevine:
                case Block.obsidian:
                    return true;
            }
            return false;
        }

        public static bool AllowBreak(ushort type)
        {
            switch (type)
            {
                case Block.blue_portal:
                case Block.orange_portal:

                case Block.MsgWhite:
                case Block.MsgBlack:

                case Block.door:
                case Block.door2:
                case Block.door3:
                case Block.door4:
                case Block.door5:
                case Block.door6:
                case Block.door7:
                case Block.door8:
                case Block.door9:
                case Block.door10:
                case door_iron:
                case door_dirt:
                case door_grass:
                case door_blue:
                case door_book:

                case Block.smalltnt:
                case Block.bigtnt:
                case Block.rocketstart:
                case Block.firework:

                case zombiebody:
                case creeper:
                case zombiehead:
                    return true;
            }
            return false;
        }

        public static bool Placable(ushort type)
        {
            switch (type)
            {
                //				case Block.air:
                //				case Block.grass:
                case Block.blackrock:
                case Block.water:
                case Block.waterstill:
                case Block.lava:
                case Block.lavastill:
                    return false;
            }

            if (type > 49) { return false; }
            return true;
        }

        public static bool RightClick(ushort type, bool countAir = false)
        {
            if (countAir && type == Block.air) return true;

            switch (type)
            {
                case Block.water:
                case Block.lava:
                case Block.waterstill:
                case Block.lavastill:
                    return true;
            }
            return false;
        }

        public static bool OPBlocks(ushort type)
        {
            switch (type)
            {
                case Block.blackrock:
                case Block.op_air:
                case Block.op_brick:
                case Block.op_cobblestone:
                case Block.op_glass:
                case Block.op_stone:
                case Block.op_water:
                case Block.opsidian:
                case Block.rocketstart:

                case Block.Zero:
                    return true;
            }
            return false;
        }

        public static bool Death(ushort type)
        {
            switch (type)
            {
                case Block.tntexplosion:

                case Block.deathwater:
                case Block.deathlava:
                case Block.deathair:
                case activedeathlava:
                case activedeathwater:

                case Block.magma:
                case Block.geyser:

                case Block.birdkill:
                case fishshark:
                case fishlavashark:

                case train:

                case snake:

                case fire:
                case rockethead:

                case creeper:
                case zombiebody:
                    //case zombiehead:
                    return true;
            }
            return false;
        }

        public static bool BuildIn(ushort type)
        {
            if (type == op_water || Block.portal(type) || Block.mb(type)) return false;

            switch (Block.Convert(type))
            {
                case (byte)water:
                case (byte)lava:
                case (byte)waterstill:
                case (byte)lavastill:
                    return true;
            }
            return false;
        }

        public static bool Mover(ushort type)
        {
            switch (type)
            {
                case Block.air_portal:
                case Block.water_portal:
                case Block.lava_portal:
                case Block.home_portal:

                case Block.air_switch:
                case Block.water_door:
                case Block.lava_door:

                case Block.MsgAir:
                case Block.MsgWater:
                case Block.MsgLava:

                case Block.flagbase:
                    return true;
            }
            return false;
        }

        public static bool LavaKill(ushort type)
        {
            switch (type)
            {
                case Block.wood:
                case Block.shrub:
                case Block.trunk:
                case Block.leaf:
                case Block.sponge:
                case Block.red:
                case Block.orange:
                case Block.yellow:
                case Block.lightgreen:
                case Block.green:
                case Block.aquagreen:
                case Block.cyan:
                case Block.lightblue:
                case Block.blue:
                case Block.purple:
                case Block.lightpurple:
                case Block.pink:
                case Block.darkpink:
                case Block.darkgrey:
                case Block.lightgrey:
                case Block.white:
                case Block.yellowflower:
                case Block.redflower:
                case Block.mushroom:
                case Block.redmushroom:
                case Block.bookcase:
                    return true;
            }
            return false;
        }
        public static bool WaterKill(ushort type)
        {
            switch (type)
            {
                case Block.air:
                case Block.shrub:
                case Block.leaf:
                case Block.yellowflower:
                case Block.redflower:
                case Block.mushroom:
                case Block.redmushroom:
                    return true;
            }
            return false;
        }

        public static bool LightPass(ushort type)
        {
            switch (Convert(type))
            {
                case (byte)Block.air:
                case (byte)Block.glass:
                case (byte)Block.leaf:
                case (byte)Block.redflower:
                case (byte)Block.yellowflower:
                case (byte)Block.mushroom:
                case (byte)Block.redmushroom:
                case (byte)Block.shrub:
                    return true;

                default:
                    return false;
            }
        }

        public static bool NeedRestart(ushort type)
        {
            switch (type)
            {
                case train:

                case snake:
                case snaketail:

                case fire:
                case rockethead:
                case firework:

                case creeper:
                case zombiebody:
                case zombiehead:

                case birdblack:
                case birdblue:
                case birdkill:
                case birdlava:
                case birdred:
                case birdwater:
                case birdwhite:

                case fishbetta:
                case fishgold:
                case fishsalmon:
                case fishshark:
                case fishlavashark:
                case fishsponge:

                case tntexplosion:
                    return true;
            }
            return false;
        }

        public static bool portal(ushort type)
        {
            switch (type)
            {
                case Block.blue_portal:
                case Block.orange_portal:
                case Block.air_portal:
                case Block.water_portal:
                case Block.lava_portal:
                case Block.home_portal:
                    return true;
            }
            return false;
        }
        public static bool mb(ushort type)
        {
            switch (type)
            {
                case Block.MsgAir:
                case Block.MsgWater:
                case Block.MsgLava:
                case Block.MsgBlack:
                case Block.MsgWhite:
                    return true;
            }
            return false;
        }

        public static bool command(ushort type)
        {
            switch (type)
            {
                case Block.cmdblock:
                    return true;
            }
            return false;
        }

        public static bool Physics(ushort type)   //returns false if placing block cant actualy cause any physics to happen
        {
            switch (type)
            {
                case Block.rock:
                case Block.stone:
                case Block.blackrock:
                case Block.waterstill:
                case Block.lavastill:
                case Block.goldrock:
                case Block.ironrock:
                case Block.coal:
                case Block.red:
                case Block.orange:
                case Block.yellow:
                case Block.lightgreen:
                case Block.green:
                case Block.aquagreen:
                case Block.cyan:
                case Block.lightblue:
                case Block.blue:
                case Block.purple:
                case Block.lightpurple:
                case Block.pink:
                case Block.darkpink:
                case Block.darkgrey:
                case Block.lightgrey:
                case Block.white:
                case Block.goldsolid:
                case Block.iron:
                case Block.staircasefull:
                case Block.brick:
                case Block.tnt:
                case Block.stonevine:
                case Block.obsidian:

                case Block.op_glass:
                case Block.opsidian:
                case Block.op_brick:
                case Block.op_stone:
                case Block.op_cobblestone:
                case Block.op_air:
                case Block.op_water:

                case Block.door:
                case Block.door2:
                case Block.door3:
                case Block.door4:
                case Block.door5:
                case Block.door6:
                case Block.door7:
                case Block.door8:
                case Block.door9:
                case Block.door10:
                case door_iron:
                case door_dirt:
                case door_grass:
                case door_blue:
                case door_book:

                case tdoor:
                case tdoor2:
                case tdoor3:
                case tdoor4:
                case tdoor5:
                case tdoor6:
                case tdoor7:
                case tdoor8:
                case tdoor9:
                case tdoor10:
                case tdoor11:
                case tdoor12:
                case tdoor13:

                case air_door:
                case Block.air_switch:
                case Block.water_door:
                case lava_door:

                case Block.MsgAir:
                case Block.MsgWater:
                case Block.MsgLava:
                case Block.MsgBlack:
                case Block.MsgWhite:

                case Block.blue_portal:
                case Block.orange_portal:
                case Block.air_portal:
                case Block.water_portal:
                case Block.lava_portal:
                case Block.home_portal:

                case Block.deathair:
                case Block.deathlava:
                case Block.deathwater:

                case flagbase:

                case sandstone:
                    return false;

                default:
                    return true;
            }
        }

        public static string Name(ushort type)
        {
            switch (type)
            {
                case 0: return "air";
                case 1: return "stone";
                case 2: return "grass";
                case 3: return "dirt";
                case 4: return "cobblestone";
                case 5: return "wood";
                case 6: return "plant";
                case 7: return "adminium";
                case 8: return "active_water";
                case 9: return "water";
                case 10: return "active_lava";
                case 11: return "lava";
                case 12: return "sand";
                case 13: return "gravel";
                case 14: return "gold_ore";
                case 15: return "iron_ore";
                case 16: return "coal";
                case 17: return "tree";
                case 18: return "leaves";
                case 19: return "sponge";
                case 20: return "glass";
                case 21: return "red";
                case 22: return "orange";
                case 23: return "yellow";
                case 24: return "greenyellow";
                case 25: return "green";
                case 26: return "springgreen";
                case 27: return "cyan";
                case 28: return "blue";
                case 29: return "blueviolet";
                case 30: return "indigo";
                case 31: return "purple";
                case 32: return "magenta";
                case 33: return "pink";
                case 34: return "black";
                case 35: return "gray";
                case 36: return "white";
                case 37: return "yellow_flower";
                case 38: return "red_flower";
                case 39: return "brown_shroom";
                case 40: return "red_shroom";
                case 41: return "gold";
                case 42: return "iron";
                case 43: return "double_stair";
                case 44: return "stair";
                case 45: return "brick";
                case 46: return "tnt";
                case 47: return "bookcase";
                case 48: return "mossy_cobblestone";
                case 49: return "obsidian";

                case 70: return "flagbase";
                case 100: return "op_glass";
                case 101: return "opsidian";              //TODO Add command or just use bind?
                case 102: return "op_brick";              //TODO
                case 103: return "op_stone";              //TODO
                case 104: return "op_cobblestone";        //TODO
                case 105: return "op_air";                //TODO
                case 106: return "op_water";              //TODO

                case wood_float: return "wood_float";            //TODO
                case door: return "door_wood";
                case lava_fast: return "lava_fast";
                case door2: return "door_obsidian";
                case door3: return "door_glass";
                case door4: return "door_stone";
                case door5: return "door_leaves";
                case door6: return "door_sand";
                case door7: return "door_wood";
                case door8: return "door_green";
                case door9: return "door_tnt";
                case door10: return "door_stair";
                case door_iron: return "door_iron";
                case door_grass: return "door_grass";
                case door_dirt: return "door_dirt";
                case door_blue: return "door_blue";
                case door_book: return "door_book";

                case tdoor: return "tdoor_wood";
                case tdoor2: return "tdoor_obsidian";
                case tdoor3: return "tdoor_glass";
                case tdoor4: return "tdoor_stone";
                case tdoor5: return "tdoor_leaves";
                case tdoor6: return "tdoor_sand";
                case tdoor7: return "tdoor_wood";
                case tdoor8: return "tdoor_green";
                case tdoor9: return "tdoor_tnt";
                case tdoor10: return "tdoor_stair";
                case tdoor11: return "tdoor_air";
                case tdoor12: return "tdoor_water";
                case tdoor13: return "tdoor_lava";

                case odoor1: return "odoor_wood";
                case odoor2: return "odoor_obsidian";
                case odoor3: return "odoor_glass";
                case odoor4: return "odoor_stone";
                case odoor5: return "odoor_leaves";
                case odoor6: return "odoor_sand";
                case odoor7: return "odoor_wood";
                case odoor8: return "odoor_green";
                case odoor9: return "odoor_tnt";
                case odoor10: return "odoor_stair";
                case odoor11: return "odoor_lava";
                case odoor12: return "odoor_water";

                case odoor1_air: return "odoor_wood_air";
                case odoor2_air: return "odoor_obsidian_air";
                case odoor3_air: return "odoor_glass_air";
                case odoor4_air: return "odoor_stone_air";
                case odoor5_air: return "odoor_leaves_air";
                case odoor6_air: return "odoor_sand_air";
                case odoor7_air: return "odoor_wood_air";
                case odoor8_air: return "odoor_red";
                case odoor9_air: return "odoor_tnt_air";
                case odoor10_air: return "odoor_stair_air";
                case odoor11_air: return "odoor_lava_air";
                case odoor12_air: return "odoor_water_air";

                case 130: return "white_message";
                case 131: return "black_message";
                case 132: return "air_message";
                case 133: return "water_message";
                case 134: return "lava_message";
                case 253: return "white_cmd";

                case 140: return "waterfall";
                case 141: return "lavafall";
                case WaterFaucet: return "water_faucet";
                case LavaFaucet: return "lava_faucet";

                case finiteWater: return "finite_water";
                case finiteLava: return "finite_lava";
                case finiteFaucet: return "finite_faucet";

                case 160: return "air_portal";
                case 161: return "water_portal";
                case 162: return "lava_portal";

                case air_door: return "air_door";
                case air_switch: return "air_switch";
                case water_door: return "door_water";
                case lava_door: return "door_lava";

                case 175: return "blue_portal";
                case 176: return "orange_portal";

                case 182: return "small_tnt";
                case 183: return "big_tnt";
                case 184: return "tnt_explosion";

                case fire: return "fire";

                case rocketstart: return "rocketstart";
                case rockethead: return "rockethead";
                case firework: return "firework";

                case 190: return "hot_lava";
                case 191: return "cold_water";
                case 192: return "nerve_gas";
                case activedeathwater: return "active_cold_water";
                case activedeathlava: return "active_hot_lava";

                case 195: return "magma";
                case 196: return "geyser";

                //Blocks after this are converted before saving
                case 200: return "air_flood";
                case 201: return "door_air";
                case 202: return "air_flood_layer";
                case 203: return "air_flood_down";
                case 204: return "air_flood_up";
                case 205: return "door2_air";
                case 206: return "door3_air";
                case 207: return "door4_air";
                case 208: return "door5_air";
                case 209: return "door6_air";
                case 210: return "door7_air";
                case 211: return "door8_air";
                case 212: return "door9_air";
                case 213: return "door10_air";
                case 214: return "door11_air";
                case 215: return "door12_air";
                case 216: return "door13_air";
                case 217: return "door14_air";
                case door_iron_air: return "door_iron_air";
                case door_dirt_air: return "door_dirt_air";
                case door_grass_air: return "door_grass_air";
                case door_blue_air: return "door_blue_air";
                case door_book_air: return "door_book_air";

                //"AI" blocks
                case train: return "train";

                case snake: return "snake";
                case snaketail: return "snake_tail";

                case creeper: return "creeper";
                case zombiebody: return "zombie";
                case zombiehead: return "zombie_head";

                case Block.birdblue: return "blue_bird";
                case Block.birdred: return "red_robin";
                case Block.birdwhite: return "dove";
                case Block.birdblack: return "pidgeon";
                case Block.birdwater: return "duck";
                case Block.birdlava: return "phoenix";
                case Block.birdkill: return "killer_phoenix";

                case fishbetta: return "betta_fish";
                case fishgold: return "goldfish";
                case fishsalmon: return "salmon";
                case fishshark: return "shark";
                case fishsponge: return "sea_sponge";
                case fishlavashark: return "lava_shark";

                case 254: return "home_portal";
                
                case 255: return "sandstone";

                default: return "unknown";
            }
        }
        public static ushort Ushort(string type)
        {
            switch (type.ToLower())
            {
                case "air": return 0;
                case "stone": return 1;
                case "grass": return 2;
                case "dirt": return 3;
                case "cobblestone": return 4;
                case "wood": return 5;
                case "plant": return 6;
                case "solid":
                case "admintite":
                case "blackrock":
                case "adminium": return 7;
                case "activewater":
                case "active_water": return 8;
                case "water": return 9;
                case "activelava":
                case "active_lava": return 10;
                case "lava": return 11;
                case "sand": return 12;
                case "gravel": return 13;
                case "gold_ore": return 14;
                case "iron_ore": return 15;
                case "coal": return 16;
                case "tree": return 17;
                case "leaves": return 18;
                case "sponge": return 19;
                case "glass": return 20;
                case "red": return 21;
                case "orange": return 22;
                case "yellow": return 23;
                case "greenyellow": return 24;
                case "green": return 25;
                case "springgreen": return 26;
                case "cyan": return 27;
                case "blue": return 28;
                case "blueviolet": return 29;
                case "indigo": return 30;
                case "purple": return 31;
                case "magenta": return 32;
                case "pink": return 33;
                case "black": return 34;
                case "gray": return 35;
                case "white": return 36;
                case "yellow_flower": return 37;
                case "red_flower": return 38;
                case "brown_shroom": return 39;
                case "red_shroom": return 40;
                case "gold": return 41;
                case "iron": return 42;
                case "double_stair": return 43;
                case "stair": return 44;
                case "brick": return 45;
                case "tnt": return 46;
                case "bookcase": return 47;
                case "mossy_cobblestone": return 48;
                case "obsidian": return 49;

                case "op_glass": return 100;
                case "opsidian": return 101;              //TODO Add command or just use bind?
                case "op_brick": return 102;              //TODO
                case "op_stone": return 103;              //TODO
                case "op_cobblestone": return 104;        //TODO
                case "op_air": return 105;                //TODO
                case "op_water": return 106;              //TODO

                case "wood_float": return 110;            //TODO
                case "lava_fast": return 112;

                case "door_tree":
                case "door": return door;
                case "door_obsidian":
                case "door2": return door2;
                case "door_glass":
                case "door3": return door3;
                case "door_stone":
                case "door4": return door4;
                case "door_leaves":
                case "door5": return door5;
                case "door_sand":
                case "door6": return door6;
                case "door_wood":
                case "door7": return door7;
                case "door_green":
                case "door8": return door8;
                case "door_tnt":
                case "door9": return door9;
                case "door_stair":
                case "door10": return door10;
                case "door11":
                case "door_iron": return door_iron;
                case "door12":
                case "door_dirt": return door_dirt;
                case "door13":
                case "door_grass": return door_grass;
                case "door14":
                case "door_blue": return door_blue;
                case "door15":
                case "door_book": return door_book;

                case "tdoor_tree":
                case "tdoor": return tdoor;
                case "tdoor_obsidian":
                case "tdoor2": return tdoor2;
                case "tdoor_glass":
                case "tdoor3": return tdoor3;
                case "tdoor_stone":
                case "tdoor4": return tdoor4;
                case "tdoor_leaves":
                case "tdoor5": return tdoor5;
                case "tdoor_sand":
                case "tdoor6": return tdoor6;
                case "tdoor_wood":
                case "tdoor7": return tdoor7;
                case "tdoor_green":
                case "tdoor8": return tdoor8;
                case "tdoor_tnt":
                case "tdoor9": return tdoor9;
                case "tdoor_stair":
                case "tdoor10": return tdoor10;
                case "tair_switch":
                case "tdoor11": return tdoor11;
                case "tdoor_water":
                case "tdoor12": return tdoor12;
                case "tdoor_lava":
                case "tdoor13": return tdoor13;

                case "odoor_tree":
                case "odoor": return odoor1;
                case "odoor_obsidian":
                case "odoor2": return odoor2;
                case "odoor_glass":
                case "odoor3": return odoor3;
                case "odoor_stone":
                case "odoor4": return odoor4;
                case "odoor_leaves":
                case "odoor5": return odoor5;
                case "odoor_sand":
                case "odoor6": return odoor6;
                case "odoor_wood":
                case "odoor7": return odoor7;
                case "odoor_green":
                case "odoor8": return odoor8;
                case "odoor_tnt":
                case "odoor9": return odoor9;
                case "odoor_stair":
                case "odoor10": return odoor10;
                case "odoor_lava":
                case "odoor11": return odoor11;
                case "odoor_water":
                case "odoor12": return odoor12;
                case "odoor_red": return odoor8_air;

                case "white_message": return 130;
                case "black_message": return 131;
                case "air_message": return 132;
                case "water_message": return 133;
                case "lava_message": return 134;
                case "white_cmd": return 253;

                case "waterfall": return 140;
                case "lavafall": return 141;
                case "water_faucet": return WaterFaucet;
                case "lava_faucet": return LavaFaucet;

                case "finite_water": return finiteWater;
                case "finite_lava": return finiteLava;
                case "finite_faucet": return finiteFaucet;

                case "air_portal": return 160;
                case "water_portal": return 161;
                case "lava_portal": return 162;

                case "air_door": return air_door;
                case "air_switch": return air_switch;
                case "door_water":
                case "water_door": return water_door;
                case "door_lava":
                case "lava_door": return lava_door;

                case "blue_portal": return 175;
                case "orange_portal": return 176;


                case "small_tnt": return 182;
                case "big_tnt": return 183;
                case "tnt_explosion": return 184;

                case "fire": return fire;

                case "rocketstart": return rocketstart;
                case "rockethead": return rockethead;
                case "firework": return firework;

                case "hot_lava": return 190;
                case "cold_water": return 191;
                case "nerve_gas": return 192;
                case "acw":
                case "active_cold_water": return activedeathwater;
                case "ahl":
                case "active_hot_lava": return activedeathlava;

                case "magma": return 195;
                case "geyser": return 196;

                //Blocks after this are converted before saving
                case "air_flood": return air_flood;
                case "air_flood_layer": return air_flood_layer;
                case "air_flood_down": return air_flood_down;
                case "air_flood_up": return air_flood_up;
                case "door_air": return door_air;
                case "door2_air": return door2_air;
                case "door3_air": return door3_air;
                case "door4_air": return door4_air;
                case "door5_air": return door5_air;
                case "door6_air": return door6_air;
                case "door7_air": return door7_air;
                case "door8_air": return door8_air;
                case "door9_air": return door9_air;
                case "door10_air": return door10_air;
                case "door11_air": return door11_air;
                case "door12_air": return door12_air;
                case "door13_air": return door13_air;
                case "door14_air": return door14_air;
                case "door_iron_air": return door_iron_air;
                case "door_dirt_air": return door_dirt_air;
                case "door_grass_air": return door_grass_air;
                case "door_blue_air": return door_blue_air;
                case "door_book_air": return door_book_air;

                case "train": return train;

                case "snake": return snake;
                case "snake_tail": return snaketail;

                case "creeper": return creeper;
                case "zombie": return zombiebody;
                case "zombie_head": return zombiehead;

                case "blue_bird": return Block.birdblue;
                case "red_robin": return Block.birdred;
                case "dove": return Block.birdwhite;
                case "pidgeon": return Block.birdblack;
                case "duck": return Block.birdwater;
                case "phoenix": return Block.birdlava;
                case "killer_phoenix": return Block.birdkill;

                case "betta_fish": return fishbetta;
                case "goldfish": return fishgold;
                case "salmon": return fishsalmon;
                case "shark": return fishshark;
                case "sea_sponge": return fishsponge;
                case "lava_shark": return fishlavashark;

                case "home_portal": return 254;

                case "sandstone": return 255;

                default: return Zero;
            }
        }

        public static byte Convert(ushort b)
        {
            switch (b)
            {
                case flagbase: return (byte)mushroom; //CTF Flagbase
                case 100: return (byte)20; //Op_glass
                case 101: return (byte)49; //Opsidian
                case 102: return (byte)45; //Op_brick
                case 103: return (byte)1; //Op_stone
                case 104: return (byte)4; //Op_cobblestone
                case 105: return (byte)0; //Op_air - Must be cuboided / replaced
                case 106: return (byte)Block.waterstill; //Op_water

                case 110: return (byte)5; //wood_float
                case 112: return (byte)10;

                case door: return (byte)trunk;//door show by treetype
                case door2: return (byte)obsidian;//door show by obsidian
                case door3: return (byte)glass;//door show by glass
                case door4: return (byte)rock;//door show by stone
                case door5: return (byte)leaf;//door show by leaves
                case door6: return (byte)sand;//door show by sand
                case door7: return (byte)wood;//door show by wood
                case door8: return (byte)green;
                case door9: return (byte)tnt;//door show by TNT
                case door10: return (byte)staircasestep;//door show by Stair
                case door_iron: return (byte)iron;
                case door_dirt: return (byte)dirt;
                case door_grass: return (byte)grass;
                case door_blue: return (byte)blue;
                case door_book: return (byte)bookcase;

                case tdoor: return (byte)trunk;//tdoor show by treetype
                case tdoor2: return (byte)obsidian;//tdoor show by obsidian
                case tdoor3: return (byte)glass;//tdoor show by glass
                case tdoor4: return (byte)rock;//tdoor show by stone
                case tdoor5: return (byte)leaf;//tdoor show by leaves
                case tdoor6: return (byte)sand;//tdoor show by sand
                case tdoor7: return (byte)wood;//tdoor show by wood
                case tdoor8: return (byte)green;
                case tdoor9: return (byte)tnt;//tdoor show by TNT
                case tdoor10: return (byte)staircasestep;//tdoor show by Stair
                case tdoor11: return (byte)air;
                case tdoor12: return (byte)waterstill;
                case tdoor13: return (byte)lavastill;

                case odoor1: return (byte)trunk;//odoor show by treetype
                case odoor2: return (byte)obsidian;//odoor show by obsidian
                case odoor3: return (byte)glass;//odoor show by glass
                case odoor4: return (byte)rock;//odoor show by stone
                case odoor5: return (byte)leaf;//odoor show by leaves
                case odoor6: return (byte)sand;//odoor show by sand
                case odoor7: return (byte)wood;//odoor show by wood
                case odoor8: return (byte)green;
                case odoor9: return (byte)tnt;//odoor show by TNT
                case odoor10: return (byte)staircasestep;//odoor show by Stair
                case odoor11: return (byte)lavastill;
                case odoor12: return (byte)waterstill;

                case 130: return (byte)36;  //upVator
                case 253: return (byte)36; //Cmdblock

                case 131: return (byte)34;  //upVator
                case 132: return (byte)0;   //upVator
                case MsgWater: return (byte)waterstill;   //upVator
                case MsgLava: return (byte)lavastill;  //upVator

                case 140: return (byte)8;
                case 141: return (byte)10;
                case WaterFaucet: return (byte)Block.cyan;
                case LavaFaucet: return (byte)Block.orange;

                case finiteWater: return (byte)water;
                case finiteLava: return (byte)lava;
                case finiteFaucet: return (byte)lightblue;

                case 160: return (byte) 0;//air portal
                case 161: return (byte) waterstill;//water portal
                case 162: return (byte) lavastill;//lava portal

                case air_door: return (byte) air;
                case air_switch: return (byte) air;//air door
                case water_door: return (byte) waterstill;//water door
                case lava_door: return (byte) lavastill;

                case 175: return (byte) 28;//blue portal
                case 176: return (byte) 22;//orange portal

                case 182: return (byte) 46;//smalltnt
                case 183: return (byte) 46;//bigtnt
                case 184: return (byte) 10;//explosion

                case fire: return (byte) lava;

                case rocketstart: return (byte) glass;
                case rockethead: return (byte) goldsolid;
                case firework: return (byte) iron;

                case Block.deathwater: return (byte) waterstill;
                case Block.deathlava: return (byte) lavastill;
                case Block.deathair: return (byte) 0;
                case activedeathwater: return (byte) water;
                case activedeathlava: return (byte) lava;

                case Block.magma: return (byte) Block.lava;
                case Block.geyser: return (byte) Block.water;

                case 200: //air_flood
                case 201: //door_air
                case 202: //air_flood_layer
                case 203: //air_flood_down
                case 204: //air_flood_up
                case 205: //door2_air
                case 206: //door3_air
                case 207: //door4_air
                case 208: //door5_air
                case 209: //door6_air
                case 210: //door7_air
                case 213: //door10_air
                case 214: //door10_air
                case 215: //door10_air
                case 216: //door10_air
                case door14_air:
                case door_iron_air:
                case door_dirt_air:
                case door_grass_air:
                case door_blue_air:
                case door_book_air:
                    return (byte) 0;
                case door9_air: return (byte) lava;
                case door8_air: return (byte) red;

                case odoor1_air:
                case odoor2_air:
                case odoor3_air:
                case odoor4_air:
                case odoor5_air:
                case odoor6_air:
                case odoor7_air:
                case odoor10_air:
                case odoor11_air:
                case odoor12_air:
                    return (byte) air;
                case odoor8_air: return (byte) red;
                case odoor9_air: return (byte) lavastill;

                case train: return (byte) cyan;

                case snake: return (byte) darkgrey;
                case snaketail: return (byte) coal;

                case creeper: return (byte) tnt;
                case zombiebody: return (byte) stonevine;
                case zombiehead: return (byte) lightgreen;

                case birdwhite: return (byte) white;
                case birdblack: return (byte) darkgrey;
                case birdlava: return (byte) lava;
                case birdred: return (byte) red;
                case birdwater: return (byte) water;
                case birdblue: return (byte) blue;
                case birdkill: return (byte) lava;

                case fishbetta: return (byte) blue;
                case fishgold: return (byte) goldsolid;
                case fishsalmon: return (byte) red;
                case fishshark: return (byte) lightgrey;
                case fishsponge: return (byte) sponge;
                case fishlavashark: return (byte) obsidian;

                case home_portal: return (byte) waterstill;

                case sandstone: return (byte) sand;

                default:
                    if (b < 50) return (byte)b; else return (byte)22;
            }
        }
        public static byte SaveConvert(ushort b)
        {
            switch (b)
            {
                case 200:
                case 202:
                case 203:
                case 204:
                    return (byte)0; //air_flood must be converted to air on save to prevent issues
                case 201: return 111; //door_air back into door
                case 205: return 113; //door_air back into door
                case 206: return 114; //door_air back into door
                case 207: return 115; //door_air back into door
                case 208: return 116; //door_air back into door
                case 209: return 117; //door_air back into door
                case 210: return 118; //door_air back into door
                case 211: return 119; //door_air back into door
                case 212: return 120; //door_air back into door
                case 213: return 121; //door_air back into door
                case 214: return 165; //door_air back into door
                case 215: return 166; //door_air back into door
                case 216: return 167; //door_air back into door
                case 217: return (byte)air_door; //door_air back into door
                case door_iron_air: return (byte)door_iron;
                case door_dirt_air: return (byte)door_dirt;
                case door_grass_air: return (byte)door_grass;
                case door_blue_air: return (byte)door_blue;
                case door_book_air: return (byte)door_book;

                case odoor1_air:
                case odoor2_air:
                case odoor3_air:
                case odoor4_air:
                case odoor5_air:
                case odoor6_air:
                case odoor7_air:
                case odoor8_air:
                case odoor9_air:
                case odoor10_air:
                case odoor11_air:
                case odoor12_air:
                    return (byte)odoor(b);

                default: return (byte)b;
            }
        }
        public static ushort DoorAirs(ushort b)
        {
            switch (b)
            {
                case door: return door_air;
                case door2: return door2_air;
                case door3: return door3_air;
                case door4: return door4_air;
                case door5: return door5_air;
                case door6: return door6_air;
                case door7: return door7_air;
                case door8: return door8_air;
                case door9: return door9_air;
                case door10: return door10_air;
                case air_switch: return door11_air;
                case water_door: return door12_air;
                case lava_door: return door13_air;
                case air_door: return door14_air;
                case door_iron: return door_iron_air;
                case door_dirt: return door_dirt_air;
                case door_grass: return door_grass_air;
                case door_blue: return door_blue_air;
                case door_book: return door_book_air;
                default: return 0;
            }
        }

        public static bool tDoor(ushort b)
        {
            switch (b)
            {
                case tdoor:
                case tdoor2:
                case tdoor3:
                case tdoor4:
                case tdoor5:
                case tdoor6:
                case tdoor7:
                case tdoor8:
                case tdoor9:
                case tdoor10:
                case tdoor11:
                case tdoor12:
                case tdoor13:
                    return true;
            }
            return false;
        }

        public static ushort odoor(ushort b)
        {
            switch (b)
            {
                case odoor1: return odoor1_air;
                case odoor2: return odoor2_air;
                case odoor3: return odoor3_air;
                case odoor4: return odoor4_air;
                case odoor5: return odoor5_air;
                case odoor6: return odoor6_air;
                case odoor7: return odoor7_air;
                case odoor8: return odoor8_air;
                case odoor9: return odoor9_air;
                case odoor10: return odoor10_air;
                case odoor11: return odoor11_air;
                case odoor12: return odoor12_air;

                case odoor1_air: return odoor1;
                case odoor2_air: return odoor2;
                case odoor3_air: return odoor3;
                case odoor4_air: return odoor4;
                case odoor5_air: return odoor5;
                case odoor6_air: return odoor6;
                case odoor7_air: return odoor7;
                case odoor8_air: return odoor8;
                case odoor9_air: return odoor9;
                case odoor10_air: return odoor10;
                case odoor11_air: return odoor11;
                case odoor12_air: return odoor12;
            }
            return Zero;
        }
    }
}