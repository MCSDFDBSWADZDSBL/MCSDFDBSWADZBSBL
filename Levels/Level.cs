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
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Data;
using System.Threading;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;

///WARNING! DO NOT CHANGE THE WAY THE LEVEL IS SAVED/LOADED!
///You MUST make it able to save and load as a new version other wise you will make old levels incompatible!


namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public enum LevelPermission
    SOYSAUCE CHIPS IS A FAGGOT
        Banned = -20,
        Guest = 0,
        Builder = 30,
        AdvBuilder = 50,
        Operator = 80,
        Admin = 100,
        Nobody = 120,
        Null = 150
    BrightShaderz is soy btw

    public class Level
    SOYSAUCE CHIPS IS A FAGGOT
        public int id;
        public string name;
        public ushort width; // x
        public ushort depth; // y       THIS IS STUPID, SHOULD HAVE BEEN Z
        public ushort height; // z      THIS IS STUPID, SHOULD HAVE BEEN Y

        public int currentUndo = 0;
        public List<UndoPos> UndoBuffer = new List<UndoPos>();
        public struct UndoPos SOYSAUCE CHIPS IS A FAGGOT public int location; public byte oldType, newType; public DateTime timePerformed; BrightShaderz is soy btw


        //Block change recording
        public struct BlockPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; public byte type; public DateTime TimePerformed; public bool deleted; public string name; BrightShaderz is soy btw
        public List<BlockPos> blockCache = new List<BlockPos>();


        public ushort spawnx;
        public ushort spawny;
        public ushort spawnz;
        public byte rotx;
        public byte roty;

        public ushort jailx, jaily, jailz;
        public byte jailrotx, jailroty;

        public bool edgeWater = false;

        public List<Player> players SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return getPlayers(); BrightShaderz is soy btw BrightShaderz is soy btw

        public Thread physThread;
        public bool physPause = false;
        public DateTime physResume;
        public System.Timers.Timer physTimer = new System.Timers.Timer(1000);
        public int physics = 0;
        public bool realistic = true;
        public bool finite = false;
        public bool ai = true;
        public bool Death = false;
        public int fall = 9;
        public int drown = 70;
        public bool unload = true;
        public bool rp = true;
        public bool Instant = false;
        public bool Killer = true;
        public bool GrassDestroy = true;
        public bool GrassGrow = true;
        public bool worldChat = true;
        public bool fishstill = false;

        public bool locked = false;

        public int speedPhysics = 250;
        public int overload = 1500;

        public string theme = "Normal";
        public string motd = "ignore";
        public LevelPermission permissionvisit = LevelPermission.Guest;// What ranks can go to this map (excludes banned)
        public LevelPermission permissionbuild = LevelPermission.Builder;// What ranks can build on this map (excludes banned)

        public byte[] blocks;
        public struct Zone SOYSAUCE CHIPS IS A FAGGOT public ushort smallX, smallY, smallZ, bigX, bigY, bigZ; public string Owner; BrightShaderz is soy btw
        public List<Zone> ZoneList;

        List<Check> ListCheck = new List<Check>();  //A list of blocks that need to be updated
        List<Update> ListUpdate = new List<Update>();  //A list of block to change after calculation

        //CTF STUFF
        public CTFGame ctfgame = new CTFGame();
        public bool ctfmode = false;

        public int lastCheck = 0;
        public int lastUpdate = 0;

        public bool changed = false;
        public bool backedup = false;
        public Level(string n, ushort x, ushort y, ushort z, string type)
        SOYSAUCE CHIPS IS A FAGGOT
            width = x; depth = y; height = z;
            if (width < 16) SOYSAUCE CHIPS IS A FAGGOT width = 16; BrightShaderz is soy btw
            if (depth < 16) SOYSAUCE CHIPS IS A FAGGOT depth = 16; BrightShaderz is soy btw
            if (height < 16) SOYSAUCE CHIPS IS A FAGGOT height = 16; BrightShaderz is soy btw

            name = n;
            blocks = new byte[width * depth * height];
            ZoneList = new List<Zone>();

            switch (type)
            SOYSAUCE CHIPS IS A FAGGOT
                case "flat":
                case "pixel":
                    ushort half = (ushort)(depth / 2);
                    for (x = 0; x < width; ++x)
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (z = 0; z < height; ++z)
                        SOYSAUCE CHIPS IS A FAGGOT
                            for (y = 0; y < depth; ++y)
                            SOYSAUCE CHIPS IS A FAGGOT
                                //Block b = new Block();
                                switch (type)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    case "flat":
                                        if (y != half)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            SetTile(x, y, z, (byte)((y >= half) ? Block.air : Block.dirt));
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            SetTile(x, y, z, Block.grass);
                                        BrightShaderz is soy btw
                                        break;

                                    case "pixel":
                                        if (y == 0)
                                            SetTile(x, y, z, Block.blackrock);
                                        else
                                            if (x == 0 || x == width - 1 || z == 0 || z == height - 1)
                                                SetTile(x, y, z, Block.white);
                                        break;
                                BrightShaderz is soy btw
                                //blocks[x + width * z + width * height * y] = b;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    break;

                case "island":
                case "mountains":
                case "ocean":
                case "forest":
                case "desert":
                    penis.MapGen.GenerateMap(this, type);
                    break;

                default:
                    break;
            BrightShaderz is soy btw

            spawnx = (ushort)(width / 2);
            spawny = (ushort)(depth * 0.75f);
            spawnz = (ushort)(height / 2);
            rotx = 0; roty = 0;
        BrightShaderz is soy btw

        public void CopyBlocks(byte[] source, int offset)
        SOYSAUCE CHIPS IS A FAGGOT
            blocks = new byte[width * depth * height];
            Array.Copy(source, offset, blocks, 0, blocks.Length);

            for (int i = 0; i < blocks.Length; i++)
            SOYSAUCE CHIPS IS A FAGGOT
                if (blocks[i] >= 50) blocks[i] = 0;
                if (blocks[i] == Block.waterstill) blocks[i] = Block.water;
                else if (blocks[i] == Block.water) blocks[i] = Block.waterstill;
                else if (blocks[i] == Block.lava) blocks[i] = Block.lavastill;
                else if (blocks[i] == Block.lavastill) blocks[i] = Block.lava;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public bool Unload()
        SOYSAUCE CHIPS IS A FAGGOT
            if (penis.mainLevel == this) return false;
            if (this.name.Contains("&cMuseum ")) return false;

            Player.players.ForEach(delegate(Player pl)
            SOYSAUCE CHIPS IS A FAGGOT
                if (pl.level == this) Command.all.Find("goto").Use(pl, penis.mainLevel.name);
            BrightShaderz is soy btw);

            if (changed)
            SOYSAUCE CHIPS IS A FAGGOT
                Save();
                saveChanges();
            BrightShaderz is soy btw
            physThread.Abort();
            physThread.Join();
            penis.levels.Remove(this);
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Player.GlobalMessageOps("&3" + name + penis.DefaultColor + " was unloaded.");
            penis.s.Log(name + " was unloaded.");
            return true;
        BrightShaderz is soy btw

        public void saveChanges()
        SOYSAUCE CHIPS IS A FAGGOT
            if (blockCache.Count == 0) return;
            List<BlockPos> tempCache = blockCache;
            blockCache = new List<BlockPos>();
            string queryString;
            queryString = "INSERT INTO `Block" + name + "` (Username, TimePerformed, X, Y, Z, type, deleted) VALUES ";

            foreach (BlockPos bP in tempCache)
            SOYSAUCE CHIPS IS A FAGGOT
                queryString += "('" + bP.name + "', '" + bP.TimePerformed.ToString("yyyy-MM-dd HH:mm:ss") + "', " + (int)bP.x + ", " + (int)bP.y + ", " + (int)bP.z + ", " + bP.type + ", " + bP.deleted + "), ";
            BrightShaderz is soy btw

            queryString = queryString.Remove(queryString.Length - 2);

            MySQL.executeQuery(queryString);
            tempCache.Clear();
        BrightShaderz is soy btw

        public byte GetTile(ushort x, ushort y, ushort z)
        SOYSAUCE CHIPS IS A FAGGOT
            //if (PosToInt(x, y, z) >= blocks.Length) SOYSAUCE CHIPS IS A FAGGOT return null; BrightShaderz is soy btw
            //Avoid internal overflow
            if (x < 0) SOYSAUCE CHIPS IS A FAGGOT return Block.Zero; BrightShaderz is soy btw
            if (x >= width) SOYSAUCE CHIPS IS A FAGGOT return Block.Zero; BrightShaderz is soy btw
            if (y < 0) SOYSAUCE CHIPS IS A FAGGOT return Block.Zero; BrightShaderz is soy btw
            if (y >= depth) SOYSAUCE CHIPS IS A FAGGOT return Block.Zero; BrightShaderz is soy btw
            if (z < 0) SOYSAUCE CHIPS IS A FAGGOT return Block.Zero; BrightShaderz is soy btw
            if (z >= height) SOYSAUCE CHIPS IS A FAGGOT return Block.Zero; BrightShaderz is soy btw
            return blocks[PosToInt(x, y, z)];
        BrightShaderz is soy btw
        public byte GetTile(int b)
        SOYSAUCE CHIPS IS A FAGGOT
            ushort x = 0, y = 0, z = 0;
            IntToPos(b, out x, out y, out z);
            return GetTile(x, y, z);
        BrightShaderz is soy btw
        public void SetTile(ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            blocks[x + width * z + width * height * y] = type;
            //blockchanges[x + width * z + width * height * y] = pName;
        BrightShaderz is soy btw

        public static Level Find(string levelName)
        SOYSAUCE CHIPS IS A FAGGOT
            Level tempLevel = null; bool returnNull = false;

            foreach (Level level in penis.levels)
            SOYSAUCE CHIPS IS A FAGGOT
                if (level.name.ToLower() == levelName) return level;
                if (level.name.ToLower().IndexOf(levelName.ToLower()) != -1)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (tempLevel == null) tempLevel = level;
                    else returnNull = true;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (returnNull == true) return null;
            if (tempLevel != null) return tempLevel;
            return null;
        BrightShaderz is soy btw
        public static Level FindExact(string levelName)
        SOYSAUCE CHIPS IS A FAGGOT
            return penis.levels.Find(lvl => levelName.ToLower() == lvl.name.ToLower());
        BrightShaderz is soy btw

        public static bool Exists(string levelName)
        SOYSAUCE CHIPS IS A FAGGOT
            return (File.Exists("levels/" + levelName + ".lvl"));
        BrightShaderz is soy btw

        public void Blockchange(Player p, ushort x, ushort y, ushort z, byte type) SOYSAUCE CHIPS IS A FAGGOT Blockchange(p, x, y, z, type, true); BrightShaderz is soy btw
        public void Blockchange(Player p, ushort x, ushort y, ushort z, byte type, bool addaction)
        SOYSAUCE CHIPS IS A FAGGOT
            string errorLocation = "start";
    retry:  try
            SOYSAUCE CHIPS IS A FAGGOT
                if (x < 0 || y < 0 || z < 0) return;
                if (x >= width || y >= depth || z >= height) return;

                byte b = GetTile(x, y, z);

                errorLocation = "Block rank checking";
                if (!Block.AllowBreak(b))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!Block.canPlace(p, b) && !Block.BuildIn(b))
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.SendBlockchange(x, y, z, b);
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                errorLocation = "Zone checking";
                #region zones
                bool AllowBuild = true, foundDel = false, inZone = false; string Owners = ""; List<Zone> toDel = new List<Zone>();
                if ((p.group.Permission < LevelPermission.Admin || p.ZoneCheck || p.zoneDel) && !Block.AllowBreak(b))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (ZoneList.Count == 0) AllowBuild = true;
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        foreach (Zone Zn in ZoneList)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (Zn.smallX <= x && x <= Zn.bigX && Zn.smallY <= y && y <= Zn.bigY && Zn.smallZ <= z && z <= Zn.bigZ)
                            SOYSAUCE CHIPS IS A FAGGOT
                                inZone = true;
                                if (p.zoneDel)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    //DB
                                    MySQL.executeQuery("DELETE FROM `Zone" + p.level.name + "` WHERE Owner='" + Zn.Owner + "' AND SmallX='" + Zn.smallX + "' AND SMALLY='" + Zn.smallY + "' AND SMALLZ='" + Zn.smallZ + "' AND BIGX='" + Zn.bigX + "' AND BIGY='" + Zn.bigY + "' AND BIGZ='" + Zn.bigZ + "'");
                                    toDel.Add(Zn);

                                    p.SendBlockchange(x, y, z, b);
                                    Player.SendMessage(p, "Zone deleted for &b" + Zn.Owner);
                                    foundDel = true;
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (Zn.Owner.Substring(0, 3) == "grp")
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        if (Group.Find(Zn.Owner.Substring(3)).Permission <= p.group.Permission && !p.ZoneCheck)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            AllowBuild = true;
                                            break;
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            AllowBuild = false;
                                            Owners += ", " + Zn.Owner.Substring(3);
                                        BrightShaderz is soy btw
                                    BrightShaderz is soy btw
                                    else
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        if (Zn.Owner.ToLower() == p.name.ToLower() && !p.ZoneCheck)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            AllowBuild = true;
                                            break;
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            AllowBuild = false;
                                            Owners += ", " + Zn.Owner;
                                        BrightShaderz is soy btw
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw

                    if (p.zoneDel)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!foundDel) Player.SendMessage(p, "No zones found to delete.");
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            foreach (Zone Zn in toDel)
                            SOYSAUCE CHIPS IS A FAGGOT
                                ZoneList.Remove(Zn);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        p.zoneDel = false;
                        return;
                    BrightShaderz is soy btw

                    if (!AllowBuild || p.ZoneCheck)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (Owners != "") Player.SendMessage(p, "This zone belongs to &b" + Owners.Remove(0, 2) + ".");
                        else Player.SendMessage(p, "This zone belongs to no one.");

                        p.ZoneSpam = DateTime.Now;
                        p.SendBlockchange(x, y, z, b);

                        if (p.ZoneCheck) if (!p.staticCommands) p.ZoneCheck = false;
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                #endregion

                errorLocation = "Map rank checking";
                if (Owners == "")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.group.Permission < this.permissionbuild && (!inZone || !AllowBuild))
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.SendBlockchange(x, y, z, b);
                        Player.SendMessage(p, "Must be at least " + PermissionToName(permissionbuild) + " to build here");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                errorLocation = "Block sending";
                if (Block.Convert(b) != Block.Convert(type) && !Instant)
                    Player.GlobalBlockchange(this, x, y, z, type);

                if (b == Block.sponge && physics > 0 && type != Block.sponge) PhysSpongeRemoved(PosToInt(x, y, z));

                errorLocation = "Undo buffer filling";
                Player.UndoPos Pos;
                Pos.x = x; Pos.y = y; Pos.z = z; Pos.mapName = name;
                Pos.type = b; Pos.newtype = type; Pos.timePlaced = DateTime.Now;
                p.UndoBuffer.Add(Pos);

                errorLocation = "Setting tile";
                p.loginBlocks++; 
                p.overallBlocks++;
                SetTile(x, y, z, type);               //Updates penis level blocks

                errorLocation = "Growing grass";
                if (GetTile(x, (ushort)(y - 1), z) == Block.grass && GrassDestroy && !Block.LightPass(type)) SOYSAUCE CHIPS IS A FAGGOT Blockchange(p, x, (ushort)(y - 1), z, Block.dirt); BrightShaderz is soy btw

                errorLocation = "Adding physics";
                if (physics > 0) if (Block.Physics(type)) AddCheck(PosToInt(x, y, z));

                changed = true;
                backedup = false;
            BrightShaderz is soy btw
            catch (OutOfMemoryException)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Undo buffer too big! Cleared!");
                p.UndoBuffer.Clear();
                goto retry;
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
                Player.GlobalMessageOps(p.name + " triggered a non-fatal error on " + name);
                Player.GlobalMessageOps("Error location: " + errorLocation);
                penis.s.Log(p.name + " triggered a non-fatal error on " + name);
                penis.s.Log("Error location: " + errorLocation);
            BrightShaderz is soy btw

            //if (addaction)
            //SOYSAUCE CHIPS IS A FAGGOT
            //    if (edits.Count == edits.Capacity) SOYSAUCE CHIPS IS A FAGGOT edits.Capacity += 1024; BrightShaderz is soy btw
            //    if (p.actions.Count == p.actions.Capacity) SOYSAUCE CHIPS IS A FAGGOT p.actions.Capacity += 128; BrightShaderz is soy btw
            //    if (b.lastaction.Count == 5) SOYSAUCE CHIPS IS A FAGGOT b.lastaction.RemoveAt(0); BrightShaderz is soy btw
            //    Edit foo = new Edit(this); foo.block = b; foo.from = p.name;
            //    foo.before = b.type; foo.after = type;
            //    b.lastaction.Add(foo); edits.Add(foo); p.actions.Add(foo);
            //BrightShaderz is soy btw b.type = type;
        BrightShaderz is soy btw
        public void Blockchange(ushort x, ushort y, ushort z, byte type, bool overRide = false, string extraInfo = "")    //Block change made by physics
        SOYSAUCE CHIPS IS A FAGGOT
            if (x < 0 || y < 0 || z < 0) return;
            if (x >= width || y >= depth || z >= height) return;
            byte b = GetTile(x, y, z);

            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (!overRide)
                    if (Block.OPBlocks(b) || Block.OPBlocks(type)) return;

                if (Block.Convert(b) != Block.Convert(type))    //Should save bandwidth sending identical looking blocks, like air/op_air changes.
                    Player.GlobalBlockchange(this, x, y, z, type);

                if (b == Block.sponge && physics > 0 && type != Block.sponge)
                    PhysSpongeRemoved(PosToInt(x, y, z));

                try
                SOYSAUCE CHIPS IS A FAGGOT
                    UndoPos uP;
                    uP.location = PosToInt(x, y, z);
                    uP.newType = type;
                    uP.oldType = b;
                    uP.timePerformed = DateTime.Now;

                    if (currentUndo > penis.physUndo)
                    SOYSAUCE CHIPS IS A FAGGOT
                        currentUndo = 0;
                        UndoBuffer[currentUndo] = uP;
                    BrightShaderz is soy btw
                    else if (UndoBuffer.Count < penis.physUndo)
                    SOYSAUCE CHIPS IS A FAGGOT
                        currentUndo++;
                        UndoBuffer.Add(uP);
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        currentUndo++;
                        UndoBuffer[currentUndo] = uP;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                SetTile(x, y, z, type);               //Updates penis level blocks

                if (physics > 0)
                    if (Block.Physics(type) || extraInfo != "") AddCheck(PosToInt(x, y, z), extraInfo);
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT
                SetTile(x, y, z, type);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void skipChange(ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            if (x < 0 || y < 0 || z < 0) return;
            if (x >= width || y >= depth || z >= height) return;

            SetTile(x, y, z, type);
        BrightShaderz is soy btw

        public void Save(Boolean Override = false)
        SOYSAUCE CHIPS IS A FAGGOT
            string path = "levels/" + name + ".lvl";

            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (!Directory.Exists("levels")) Directory.CreateDirectory("levels");
                if (!Directory.Exists("levels/level properties")) Directory.CreateDirectory("levels/level properties");

                if (changed == true || !File.Exists(path) || Override)
                SOYSAUCE CHIPS IS A FAGGOT
                    FileStream fs = File.Create(path + ".back");
                    GZipStream gs = new GZipStream(fs, CompressionMode.Compress);

                    byte[] header = new byte[16];
                    BitConverter.GetBytes(1874).CopyTo(header, 0);
                    gs.Write(header, 0, 2);

                    BitConverter.GetBytes(width).CopyTo(header, 0);
                    BitConverter.GetBytes(height).CopyTo(header, 2);
                    BitConverter.GetBytes(depth).CopyTo(header, 4);
                    BitConverter.GetBytes(spawnx).CopyTo(header, 6);
                    BitConverter.GetBytes(spawnz).CopyTo(header, 8);
                    BitConverter.GetBytes(spawny).CopyTo(header, 10);
                    header[12] = rotx; header[13] = roty;
                    header[14] = (byte)permissionvisit;
                    header[15] = (byte)permissionbuild;
                    gs.Write(header, 0, header.Length);
                    byte[] level = new byte[blocks.Length];
                    for (int i = 0; i < blocks.Length; ++i)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (blocks[i] < 80)
                        SOYSAUCE CHIPS IS A FAGGOT
                            level[i] = blocks[i];
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            level[i] = Block.SaveConvert(blocks[i]);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw gs.Write(level, 0, level.Length); gs.Close();
                    fs.Close();

                    File.Delete(path + ".backup");
                    File.Copy(path + ".back", path + ".backup");
                    File.Delete(path);
                    File.Move(path + ".back", path);

                    StreamWriter SW = new StreamWriter(File.Create("levels/level properties/" + name + ".properties"));
                    SW.WriteLine("#Level properties for " + name);
                    SW.WriteLine("Theme = " + theme);
                    SW.WriteLine("Physics = " + physics.ToString());
                    SW.WriteLine("Physics speed = " + speedPhysics.ToString());
                    SW.WriteLine("Physics overload = " + overload.ToString());
                    SW.WriteLine("Finite mode = " + finite.ToString());
                    SW.WriteLine("Animal AI = " + ai.ToString());
                    SW.WriteLine("Edge water = " + edgeWater.ToString());
                    SW.WriteLine("Survival death = " + Death.ToString());
                    SW.WriteLine("Fall = " + fall.ToString());
                    SW.WriteLine("Drown = " + drown.ToString());
                    SW.WriteLine("MOTD = " + motd);
                    SW.WriteLine("JailX = " + jailx.ToString());
                    SW.WriteLine("JailY = " + jaily.ToString());
                    SW.WriteLine("JailZ = " + jailz.ToString());
                    SW.WriteLine("Unload = " + unload);
                    SW.WriteLine("PerBuild = " + PermissionToName(permissionbuild));
                    SW.WriteLine("PerVisit = " + PermissionToName(permissionvisit));
                    SW.Flush();
                    SW.Close();

                    penis.s.Log("SAVED: Level \"" + name + "\". (" + players.Count + "/" + Player.players.Count  + "/" + penis.players + ")");
                    changed = false;
                    
                    fs.Dispose();
                    gs.Dispose();
                    SW.Dispose();
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.s.Log("Skipping level save for " + name + ".");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log("FAILED TO SAVE :" + name);
                Player.GlobalMessage("FAILED TO SAVE :" + name);

                penis.ErrorLog(e);
                return;
            BrightShaderz is soy btw

            GC.Collect();
            GC.WaitForPendingFinalizers();
        BrightShaderz is soy btw

        public int Backup(bool Forced = false, string backupName = "")
        SOYSAUCE CHIPS IS A FAGGOT
            if (!backedup || Forced)
            SOYSAUCE CHIPS IS A FAGGOT
                int backupNumber = 1; string backupPath = @penis.backupLocation;
                if (Directory.Exists(backupPath + "/" + name))
                SOYSAUCE CHIPS IS A FAGGOT
                    backupNumber = Directory.GetDirectories(backupPath + "/" + name).Length + 1;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Directory.CreateDirectory(backupPath + "/" + name);
                BrightShaderz is soy btw
                string path = backupPath + "/" + name + "/" + backupNumber;
                if (backupName != "")
                SOYSAUCE CHIPS IS A FAGGOT
                    path = backupPath + "/" + name + "/" + backupName;
                BrightShaderz is soy btw
                Directory.CreateDirectory(path);

                string BackPath = path + "/" + name + ".lvl";
                string current = "levels/" + name + ".lvl";
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    File.Copy(current, BackPath, true);
                    backedup = true;
                    return backupNumber;
                BrightShaderz is soy btw
                catch (Exception e)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.ErrorLog(e);
                    penis.s.Log("FAILED TO INCREMENTAL BACKUP :" + name);
                    return -1;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log("Level unchanged, skipping backup");
                return -1;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static Level Load(string givenName) SOYSAUCE CHIPS IS A FAGGOT return Load(givenName, 0); BrightShaderz is soy btw
        public static Level Load(string givenName, byte phys)
        SOYSAUCE CHIPS IS A FAGGOT
            MySQL.executeQuery("CREATE TABLE if not exists `Block" + givenName + "` (Username CHAR(20), TimePerformed DATETIME, X SMALLINT UNSIGNED, Y SMALLINT UNSIGNED, Z SMALLINT UNSIGNED, Type TINYINT UNSIGNED, Deleted BOOL)");
            MySQL.executeQuery("CREATE TABLE if not exists `Portals" + givenName + "` (EntryX SMALLINT UNSIGNED, EntryY SMALLINT UNSIGNED, EntryZ SMALLINT UNSIGNED, ExitMap CHAR(20), ExitX SMALLINT UNSIGNED, ExitY SMALLINT UNSIGNED, ExitZ SMALLINT UNSIGNED)");
            MySQL.executeQuery("CREATE TABLE if not exists `Messages" + givenName + "` (X SMALLINT UNSIGNED, Y SMALLINT UNSIGNED, Z SMALLINT UNSIGNED, Message CHAR(255));");
            MySQL.executeQuery("CREATE TABLE if not exists `Zone" + givenName + "` (SmallX SMALLINT UNSIGNED, SmallY SMALLINT UNSIGNED, SmallZ SMALLINT UNSIGNED, BigX SMALLINT UNSIGNED, BigY SMALLINT UNSIGNED, BigZ SMALLINT UNSIGNED, Owner VARCHAR(20));");
            
            string path = "levels/" + givenName + ".lvl";
            if (File.Exists(path))
            SOYSAUCE CHIPS IS A FAGGOT
                FileStream fs = File.OpenRead(path);
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    GZipStream gs = new GZipStream(fs, CompressionMode.Decompress);
                    byte[] ver = new byte[2];
                    gs.Read(ver, 0, ver.Length);
                    ushort version = BitConverter.ToUInt16(ver, 0);
                    Level level;
                    if (version == 1874)
                    SOYSAUCE CHIPS IS A FAGGOT
                        byte[] header = new byte[16]; gs.Read(header, 0, header.Length);
                        ushort width = BitConverter.ToUInt16(header, 0);
                        ushort height = BitConverter.ToUInt16(header, 2);
                        ushort depth = BitConverter.ToUInt16(header, 4);
                        level = new Level("temp", width, depth, height, "empty");
                        level.spawnx = BitConverter.ToUInt16(header, 6);
                        level.spawnz = BitConverter.ToUInt16(header, 8);
                        level.spawny = BitConverter.ToUInt16(header, 10);
                        level.rotx = header[12]; level.roty = header[13];
                        //level.permissionvisit = (LevelPermission)header[14];
                        //level.permissionbuild = (LevelPermission)header[15];
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        byte[] header = new byte[12]; gs.Read(header, 0, header.Length);
                        ushort width = version;
                        ushort height = BitConverter.ToUInt16(header, 0);
                        ushort depth = BitConverter.ToUInt16(header, 2);
                        level = new Level("temp", width, depth, height, "grass");
                        level.spawnx = BitConverter.ToUInt16(header, 4);
                        level.spawnz = BitConverter.ToUInt16(header, 6);
                        level.spawny = BitConverter.ToUInt16(header, 8);
                        level.rotx = header[10]; level.roty = header[11];
                    BrightShaderz is soy btw
                    level.permissionbuild = (LevelPermission)11;

                    level.name = givenName;
                    level.setPhysics(phys);

                    byte[] blocks = new byte[level.width * level.height * level.depth];
                    gs.Read(blocks, 0, blocks.Length);
                    level.blocks = blocks;
                    gs.Close();

                    level.backedup = true;

                    DataTable ZoneDB = MySQL.fillData("SELECT * FROM `Zone" + givenName + "`");

                    Zone Zn;
                    for (int i = 0; i < ZoneDB.Rows.Count; ++i)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Zn.smallX = (ushort)ZoneDB.Rows[i]["SmallX"];
                        Zn.smallY = (ushort)ZoneDB.Rows[i]["SmallY"];
                        Zn.smallZ = (ushort)ZoneDB.Rows[i]["SmallZ"];
                        Zn.bigX = (ushort)ZoneDB.Rows[i]["BigX"];
                        Zn.bigY = (ushort)ZoneDB.Rows[i]["BigY"];
                        Zn.bigZ = (ushort)ZoneDB.Rows[i]["BigZ"];
                        Zn.Owner = ZoneDB.Rows[i]["Owner"].ToString();
                        level.ZoneList.Add(Zn);
                    BrightShaderz is soy btw

                    ZoneDB.Dispose();

                    level.jailx = (ushort)(level.spawnx * 32); level.jaily = (ushort)(level.spawny * 32); level.jailz = (ushort)(level.spawnz * 32);
                    level.jailrotx = level.rotx; level.jailroty = level.roty;

                    level.physThread = new Thread(new ThreadStart(level.Physics));

                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        DataTable foundDB = MySQL.fillData("SELECT * FROM `Portals" + givenName + "`");

                        for (int i = 0; i < foundDB.Rows.Count; ++i)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (!Block.portal(level.GetTile((ushort)foundDB.Rows[i]["EntryX"], (ushort)foundDB.Rows[i]["EntryY"], (ushort)foundDB.Rows[i]["EntryZ"])))
                            SOYSAUCE CHIPS IS A FAGGOT
                                MySQL.executeQuery("DELETE FROM `Portals" + givenName + "` WHERE EntryX=" + foundDB.Rows[i]["EntryX"] + " AND EntryY=" + foundDB.Rows[i]["EntryY"] + " AND EntryZ=" + foundDB.Rows[i]["EntryZ"]);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw

                        foundDB = MySQL.fillData("SELECT * FROM `Messages" + givenName + "`");

                        for (int i = 0; i < foundDB.Rows.Count; ++i)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (!Block.mb(level.GetTile((ushort)foundDB.Rows[i]["X"], (ushort)foundDB.Rows[i]["Y"], (ushort)foundDB.Rows[i]["Z"])))
                            SOYSAUCE CHIPS IS A FAGGOT
                                MySQL.executeQuery("DELETE FROM `Messages" + givenName + "` WHERE X=" + foundDB.Rows[i]["X"] + " AND Y=" + foundDB.Rows[i]["Y"] + " AND Z=" + foundDB.Rows[i]["Z"]);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        foundDB.Dispose();
                    BrightShaderz is soy btw
                    catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw

                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        string foundLocation;
                        foundLocation = "levels/level properties/" + level.name + ".properties";
                        if (!File.Exists(foundLocation))
                        SOYSAUCE CHIPS IS A FAGGOT
                            foundLocation = "levels/level properties/" + level.name;
                        BrightShaderz is soy btw

                        foreach (string line in File.ReadAllLines(foundLocation))
                        SOYSAUCE CHIPS IS A FAGGOT
                            try
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (line[0] != '#')
                                SOYSAUCE CHIPS IS A FAGGOT
                                    string value = line.Substring(line.IndexOf(" = ") + 3);

                                    switch (line.Substring(0, line.IndexOf(" = ")).ToLower())
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        case "theme": level.theme = value; break;
                                        case "physics": level.setPhysics(int.Parse(value)); break;
                                        case "physics speed": level.speedPhysics = int.Parse(value); break;
                                        case "physics overload": level.overload = int.Parse(value); break;
                                        case "finite mode": level.finite = bool.Parse(value); break;
                                        case "animal ai": level.ai = bool.Parse(value); break;
                                        case "edge water": level.edgeWater = bool.Parse(value); break;
                                        case "survival death": level.Death = bool.Parse(value); break;
                                        case "fall": level.fall = int.Parse(value); break;
                                        case "drown": level.drown = int.Parse(value); break;
                                        case "motd": level.motd = value; break;
                                        case "jailx": level.jailx = ushort.Parse(value); break;
                                        case "jaily": level.jaily = ushort.Parse(value); break;
                                        case "jailz": level.jailz = ushort.Parse(value); break;
                                        case "unload": level.unload = bool.Parse(value); break;

                                        case "perbuild":
                                            if (PermissionFromName(value) != LevelPermission.Null) level.permissionbuild = PermissionFromName(value);
                                            break;
                                        case "pervisit":
                                            if (PermissionFromName(value) != LevelPermission.Null) level.permissionvisit = PermissionFromName(value);
                                            break;
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw



                    penis.s.Log("Level \"" + level.name + "\" loaded.");
                    level.ctfgame.mapOn = level;
                    return level;
                BrightShaderz is soy btw
                catch (Exception ex) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(ex); return null; BrightShaderz is soy btw
                finally SOYSAUCE CHIPS IS A FAGGOT fs.Close(); BrightShaderz is soy btw
            BrightShaderz is soy btw
            else SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("ERROR loading level."); return null; BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void ChatLevel(string message)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (Player pl in Player.players)
            SOYSAUCE CHIPS IS A FAGGOT
                if (pl.level == this) pl.SendMessage(message);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void setPhysics(int newValue)
        SOYSAUCE CHIPS IS A FAGGOT
            if (physics == 0 && newValue != 0)
            SOYSAUCE CHIPS IS A FAGGOT
                for (int i = 0; i < blocks.Length; i++)
                    if (Block.NeedRestart(blocks[i]))
                        AddCheck(i);
            BrightShaderz is soy btw
            physics = newValue;
            
        BrightShaderz is soy btw

        public void Physics()
        SOYSAUCE CHIPS IS A FAGGOT
            int wait = speedPhysics;
            while (true)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                retry: if (wait > 0) Thread.Sleep(wait);
                    if (physics == 0 || ListCheck.Count == 0) goto retry;

                    DateTime Start = DateTime.Now;

                    if (physics > 0) CalcPhysics();

                    TimeSpan Took = DateTime.Now - Start;
                    wait = (int)speedPhysics - (int)Took.TotalMilliseconds;

                    if (wait < (int)(-overload * 0.75f))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Level Cause = this;

                        if (wait < -overload)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (!penis.physicsRestart) Cause.setPhysics(0);
                            Cause.ClearPhysics();

                            Player.GlobalMessage("Physics shutdown on &b" + Cause.name);
                            penis.s.Log("Physics shutdown on " + name);

                            wait = speedPhysics;
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            foreach (Player p in Player.players)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (p.level == this) Player.SendMessage(p, "Physics warning!");
                            BrightShaderz is soy btw
                            penis.s.Log("Physics warning on " + name);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch
                SOYSAUCE CHIPS IS A FAGGOT
                    wait = speedPhysics;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public int PosToInt(ushort x, ushort y, ushort z)
        SOYSAUCE CHIPS IS A FAGGOT
            if (x < 0) SOYSAUCE CHIPS IS A FAGGOT return -1; BrightShaderz is soy btw
            if (x >= width) SOYSAUCE CHIPS IS A FAGGOT return -1; BrightShaderz is soy btw
            if (y < 0) SOYSAUCE CHIPS IS A FAGGOT return -1; BrightShaderz is soy btw
            if (y >= depth) SOYSAUCE CHIPS IS A FAGGOT return -1; BrightShaderz is soy btw
            if (z < 0) SOYSAUCE CHIPS IS A FAGGOT return -1; BrightShaderz is soy btw
            if (z >= height) SOYSAUCE CHIPS IS A FAGGOT return -1; BrightShaderz is soy btw
            return x + (z * width) + (y * width * height);
            //alternate method: (h * widthY + y) * widthX + x;
        BrightShaderz is soy btw
        public void IntToPos(int pos, out ushort x, out ushort y, out ushort z)
        SOYSAUCE CHIPS IS A FAGGOT
            y = (ushort)(pos / width / height); pos -= y * width * height;
            z = (ushort)(pos / width); pos -= z * width; x = (ushort)pos;
        BrightShaderz is soy btw
        public int IntOffset(int pos, int x, int y, int z)
        SOYSAUCE CHIPS IS A FAGGOT
            return pos + x + z * width + y * width * height;
        BrightShaderz is soy btw

        #region ==Physics==
        public struct Pos SOYSAUCE CHIPS IS A FAGGOT public ushort x, z; BrightShaderz is soy btw

        public string foundInfo(ushort x, ushort y, ushort z)
        SOYSAUCE CHIPS IS A FAGGOT
            Check foundCheck = null;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                foundCheck = ListCheck.Find(Check => Check.b == PosToInt(x, y, z));
            BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            if (foundCheck != null)
                return foundCheck.extraInfo;
            return "";
        BrightShaderz is soy btw

        public void CalcPhysics()
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (physics > 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    ushort x, y, z; int mx, my, mz;

                    Random rand = new Random();
                    lastCheck = ListCheck.Count;
                    ListCheck.ForEach(delegate(Check C)
                    SOYSAUCE CHIPS IS A FAGGOT
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            IntToPos(C.b, out x, out y, out z);
                            bool InnerChange = false; bool skip = false;
                            int storedRand = 0;
                            Player foundPlayer = null; int foundNum = 75, currentNum, newNum, oldNum;
                            string foundInfo = C.extraInfo;

                        newPhysic: if (foundInfo != "")
                            SOYSAUCE CHIPS IS A FAGGOT
                                int currentLoop = 0;
                                if (!foundInfo.Contains("wait")) if (blocks[C.b] == Block.air) C.extraInfo = "";

                                bool drop = false; int dropnum = 0;
                                bool wait = false; int waitnum = 0;
                                bool dissipate = false; int dissipatenum = 0;
                                bool revert = false; byte reverttype = 0;
                                bool explode = false; int explodenum = 0;
                                bool finiteWater = false;
                                bool rainbow = false; int rainbownum = 0;
                                bool door = false;

                                foreach (string s in C.extraInfo.Split(' '))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (currentLoop % 2 == 0)
                                    SOYSAUCE CHIPS IS A FAGGOT //Type of code
                                        switch (s)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            case "wait":
                                                wait = true;
                                                waitnum = int.Parse(C.extraInfo.Split(' ')[currentLoop + 1]);
                                                break;
                                            case "drop":
                                                drop = true;
                                                dropnum = int.Parse(C.extraInfo.Split(' ')[currentLoop + 1]);
                                                break;
                                            case "dissipate":
                                                dissipate = true;
                                                dissipatenum = int.Parse(C.extraInfo.Split(' ')[currentLoop + 1]);
                                                break;
                                            case "revert":
                                                revert = true;
                                                reverttype = Byte.Parse(C.extraInfo.Split(' ')[currentLoop + 1]);
                                                break;
                                            case "explode":
                                                explode = true;
                                                explodenum = int.Parse(C.extraInfo.Split(' ')[currentLoop + 1]);
                                                break;

                                            case "finite":
                                                finiteWater = true;
                                                break;

                                            case "rainbow":
                                                rainbow = true;
                                                rainbownum = int.Parse(C.extraInfo.Split(' ')[currentLoop + 1]);
                                                break;

                                            case "door":
                                                door = true;
                                                break;
                                        BrightShaderz is soy btw
                                    BrightShaderz is soy btw currentLoop++;
                                BrightShaderz is soy btw

                            startCheck:
                                if (wait)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    int storedInt = 0;
                                    if (door && C.time < 2)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        storedInt = IntOffset(C.b, -1, 0, 0);
                                        if (Block.tDoor(blocks[storedInt])) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(storedInt, Block.air, false, "wait 10 door 1 revert " + blocks[storedInt].ToString()); BrightShaderz is soy btw
                                        storedInt = IntOffset(C.b, 1, 0, 0);
                                        if (Block.tDoor(blocks[storedInt])) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(storedInt, Block.air, false, "wait 10 door 1 revert " + blocks[storedInt].ToString()); BrightShaderz is soy btw
                                        storedInt = IntOffset(C.b, 0, 1, 0);
                                        if (Block.tDoor(blocks[storedInt])) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(storedInt, Block.air, false, "wait 10 door 1 revert " + blocks[storedInt].ToString()); BrightShaderz is soy btw
                                        storedInt = IntOffset(C.b, 0, -1, 0);
                                        if (Block.tDoor(blocks[storedInt])) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(storedInt, Block.air, false, "wait 10 door 1 revert " + blocks[storedInt].ToString()); BrightShaderz is soy btw
                                        storedInt = IntOffset(C.b, 0, 0, 1);
                                        if (Block.tDoor(blocks[storedInt])) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(storedInt, Block.air, false, "wait 10 door 1 revert " + blocks[storedInt].ToString()); BrightShaderz is soy btw
                                        storedInt = IntOffset(C.b, 0, 0, -1);
                                        if (Block.tDoor(blocks[storedInt])) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(storedInt, Block.air, false, "wait 10 door 1 revert " + blocks[storedInt].ToString()); BrightShaderz is soy btw
                                    BrightShaderz is soy btw

                                    if (waitnum <= C.time)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        wait = false;
                                        C.extraInfo = C.extraInfo.Substring(0, C.extraInfo.IndexOf("wait ")) + C.extraInfo.Substring(C.extraInfo.IndexOf(' ', C.extraInfo.IndexOf("wait ") + 5) + 1);
                                        //C.extraInfo = C.extraInfo.Substring(8);
                                        goto startCheck;
                                    BrightShaderz is soy btw
                                    else
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        C.time++;
                                        foundInfo = "";
                                        goto newPhysic;
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (finiteWater)
                                        finiteMovement(C, x, y, z);
                                    else if (rainbow)
                                        if (C.time < 4)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            C.time++;
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (rainbownum > 2)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                if (blocks[C.b] < Block.red || blocks[C.b] > Block.darkpink)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    AddUpdate(C.b, Block.red, true);
                                                BrightShaderz is soy btw
                                                else
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    if (blocks[C.b] == Block.darkpink) AddUpdate(C.b, Block.red);
                                                    else AddUpdate(C.b, (blocks[C.b] + 1));
                                                BrightShaderz is soy btw
                                            BrightShaderz is soy btw
                                            else
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                AddUpdate(C.b, rand.Next(21, 33));
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                    else
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        if (revert) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(C.b, reverttype); C.extraInfo = ""; BrightShaderz is soy btw
                                        if (dissipate) if (rand.Next(1, 100) <= dissipatenum) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(C.b, Block.air); C.extraInfo = ""; BrightShaderz is soy btw
                                        if (explode) if (rand.Next(1, 100) <= explodenum) SOYSAUCE CHIPS IS A FAGGOT MakeExplosion(x, y, z, 0); C.extraInfo = ""; BrightShaderz is soy btw
                                        if (drop)
                                            if (rand.Next(1, 100) <= dropnum)
                                                if (GetTile(x, (ushort)(y - 1), z) == Block.air || GetTile(x, (ushort)(y - 1), z) == Block.lava || GetTile(x, (ushort)(y - 1), z) == Block.water)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    if (rand.Next(1, 100) < int.Parse(C.extraInfo.Split(' ')[1]))
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        AddUpdate(PosToInt(x, (ushort)(y - 1), z), blocks[C.b], false, C.extraInfo);
                                                        AddUpdate(C.b, Block.air); C.extraInfo = "";
                                                    BrightShaderz is soy btw
                                                BrightShaderz is soy btw

                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                switch (blocks[C.b])
                                SOYSAUCE CHIPS IS A FAGGOT
                                    case Block.air:         //Placed air
                                        //initialy checks if block is valid
                                        PhysAir(PosToInt((ushort)(x + 1), y, z));
                                        PhysAir(PosToInt((ushort)(x - 1), y, z));
                                        PhysAir(PosToInt(x, y, (ushort)(z + 1)));
                                        PhysAir(PosToInt(x, y, (ushort)(z - 1)));
                                        PhysAir(PosToInt(x, (ushort)(y + 1), z));  //Check block above the air

                                        //Edge of map water
                                        if (edgeWater == true)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (y < depth / 2 && y >= (depth / 2) - 2)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                if (x == 0 || x == width - 1 || z == 0 || z == height - 1)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    AddUpdate(C.b, Block.water);
                                                BrightShaderz is soy btw
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw

                                        if (!C.extraInfo.Contains("wait")) C.time = 255;
                                        break;

                                    case Block.dirt:     //Dirt
                                        if (!GrassGrow) SOYSAUCE CHIPS IS A FAGGOT C.time = 255; break; BrightShaderz is soy btw

                                        if (C.time > 20)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (Block.LightPass(GetTile(x, (ushort)(y + 1), z)))
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                AddUpdate(C.b, Block.grass);
                                            BrightShaderz is soy btw
                                            C.time = 255;
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            C.time++;
                                        BrightShaderz is soy btw
                                        break;

                                    case Block.water:         //Active_water
                                    case Block.activedeathwater:
                                        //initialy checks if block is valid
                                        if (!finite)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (!PhysSpongeCheck(C.b))
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                if (GetTile(x, (ushort)(y + 1), z) != Block.Zero) SOYSAUCE CHIPS IS A FAGGOT PhysSandCheck(PosToInt(x, (ushort)(y + 1), z)); BrightShaderz is soy btw
                                                PhysWater(PosToInt((ushort)(x + 1), y, z), blocks[C.b]);
                                                PhysWater(PosToInt((ushort)(x - 1), y, z), blocks[C.b]);
                                                PhysWater(PosToInt(x, y, (ushort)(z + 1)), blocks[C.b]);
                                                PhysWater(PosToInt(x, y, (ushort)(z - 1)), blocks[C.b]);
                                                PhysWater(PosToInt(x, (ushort)(y - 1), z), blocks[C.b]);
                                            BrightShaderz is soy btw
                                            else
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                AddUpdate(C.b, Block.air);  //was placed near sponge
                                            BrightShaderz is soy btw

                                            if (C.extraInfo.IndexOf("wait") == -1) C.time = 255;
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            goto case Block.finiteWater;
                                        BrightShaderz is soy btw
                                        break;

                                    case Block.WaterDown:
                                        rand = new Random();

                                        if (GetTile(x, (ushort)(y - 1), z) == Block.air)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.WaterDown);
                                            if (C.extraInfo.IndexOf("wait") == -1) C.time = 255;
                                        BrightShaderz is soy btw
                                        else if (GetTile(x, (ushort)(y - 1), z) == Block.air_flood_down)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                        BrightShaderz is soy btw
                                        else if (GetTile(x, (ushort)(y - 1), z) == Block.waterstill || GetTile(x, (ushort)(y - 1), z) == Block.lavastill)
                                        SOYSAUCE CHIPS IS A FAGGOT

                                        BrightShaderz is soy btw
                                        else if (GetTile(x, (ushort)(y - 1), z) != Block.WaterDown)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            PhysWater(PosToInt((ushort)(x + 1), y, z), blocks[C.b]);
                                            PhysWater(PosToInt((ushort)(x - 1), y, z), blocks[C.b]);
                                            PhysWater(PosToInt(x, y, (ushort)(z + 1)), blocks[C.b]);
                                            PhysWater(PosToInt(x, y, (ushort)(z - 1)), blocks[C.b]);
                                            if (C.extraInfo.IndexOf("wait") == -1) C.time = 255;
                                        BrightShaderz is soy btw
                                        break;

                                    case Block.LavaDown:
                                        rand = new Random();

                                        if (GetTile(x, (ushort)(y - 1), z) == Block.air)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.LavaDown);
                                            if (C.extraInfo.IndexOf("wait") == -1) C.time = 255;
                                        BrightShaderz is soy btw
                                        else if (GetTile(x, (ushort)(y - 1), z) == Block.air_flood_down)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                        BrightShaderz is soy btw
                                        else if (GetTile(x, (ushort)(y - 1), z) == Block.waterstill || GetTile(x, (ushort)(y - 1), z) == Block.lavastill)
                                        SOYSAUCE CHIPS IS A FAGGOT

                                        BrightShaderz is soy btw
                                        else if (GetTile(x, (ushort)(y - 1), z) != Block.LavaDown)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            PhysLava(PosToInt((ushort)(x + 1), y, z), blocks[C.b]);
                                            PhysLava(PosToInt((ushort)(x - 1), y, z), blocks[C.b]);
                                            PhysLava(PosToInt(x, y, (ushort)(z + 1)), blocks[C.b]);
                                            PhysLava(PosToInt(x, y, (ushort)(z - 1)), blocks[C.b]);
                                            if (C.extraInfo.IndexOf("wait") == -1) C.time = 255;
                                        BrightShaderz is soy btw
                                        break;

                                    case Block.WaterFaucet:
                                        //rand = new Random();
                                        C.time++;
                                        if (C.time < 2) break;

                                        C.time = 0;

                                        if (GetTile(x, (ushort)(y - 1), z) == Block.air || GetTile(x, (ushort)(y - 1), z) == Block.WaterDown)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (rand.Next(1, 10) > 7) AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.air_flood_down);
                                        BrightShaderz is soy btw
                                        else if (GetTile(x, (ushort)(y - 1), z) == Block.air_flood_down)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (rand.Next(1, 10) > 4) AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.WaterDown);
                                        BrightShaderz is soy btw
                                        break;

                                    case Block.LavaFaucet:
                                        //rand = new Random();
                                        C.time++;
                                        if (C.time < 2) break;

                                        C.time = 0;

                                        if (GetTile(x, (ushort)(y - 1), z) == Block.air || GetTile(x, (ushort)(y - 1), z) == Block.LavaDown)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (rand.Next(1, 10) > 7) AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.air_flood_down);
                                        BrightShaderz is soy btw
                                        else if (GetTile(x, (ushort)(y - 1), z) == Block.air_flood_down)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (rand.Next(1, 10) > 4) AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.LavaDown);
                                        BrightShaderz is soy btw
                                        break;

                                    case Block.lava:         //Active_lava
                                    case Block.activedeathlava:
                                        //initialy checks if block is valid
                                        if (C.time < 4) SOYSAUCE CHIPS IS A FAGGOT C.time++; break; BrightShaderz is soy btw
                                        if (!finite)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            PhysLava(PosToInt((ushort)(x + 1), y, z), blocks[C.b]);
                                            PhysLava(PosToInt((ushort)(x - 1), y, z), blocks[C.b]);
                                            PhysLava(PosToInt(x, y, (ushort)(z + 1)), blocks[C.b]);
                                            PhysLava(PosToInt(x, y, (ushort)(z - 1)), blocks[C.b]);
                                            PhysLava(PosToInt(x, (ushort)(y - 1), z), blocks[C.b]);
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            goto case Block.finiteWater;
                                        BrightShaderz is soy btw
                                        if (C.extraInfo.IndexOf("wait") == -1) C.time = 255;
                                        break;
                                    #region fire
                                    case Block.fire:
                                        if (C.time < 2) SOYSAUCE CHIPS IS A FAGGOT C.time++; break; BrightShaderz is soy btw

                                        storedRand = rand.Next(1, 20);
                                        if (storedRand < 2 && C.time % 2 == 0)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            storedRand = rand.Next(1, 18);

                                            if (storedRand <= 3 && GetTile((ushort)(x - 1), y, z) == Block.air)
                                                AddUpdate(PosToInt((ushort)(x - 1), y, z), Block.fire);
                                            else if (storedRand <= 6 && GetTile((ushort)(x + 1), y, z) == Block.air)
                                                AddUpdate(PosToInt((ushort)(x + 1), y, z), Block.fire);
                                            else if (storedRand <= 9 && GetTile(x, (ushort)(y - 1), z) == Block.air)
                                                AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.fire);
                                            else if (storedRand <= 12 && GetTile(x, (ushort)(y + 1), z) == Block.air)
                                                AddUpdate(PosToInt(x, (ushort)(y + 1), z), Block.fire);
                                            else if (storedRand <= 15 && GetTile(x, y, (ushort)(z - 1)) == Block.air)
                                                AddUpdate(PosToInt(x, y, (ushort)(z - 1)), Block.fire);
                                            else if (storedRand <= 18 && GetTile(x, y, (ushort)(z + 1)) == Block.air)
                                                AddUpdate(PosToInt(x, y, (ushort)(z + 1)), Block.fire);
                                        BrightShaderz is soy btw

                                        if (Block.LavaKill(GetTile((ushort)(x - 1), y, (ushort)(z - 1))))
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (GetTile((ushort)(x - 1), y, z) == Block.air)
                                                AddUpdate(PosToInt((ushort)(x - 1), y, z), Block.fire);
                                            if (GetTile(x, y, (ushort)(z - 1)) == Block.air)
                                                AddUpdate(PosToInt(x, y, (ushort)(z - 1)), Block.fire);
                                        BrightShaderz is soy btw
                                        if (Block.LavaKill(GetTile((ushort)(x + 1), y, (ushort)(z - 1))))
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (GetTile((ushort)(x + 1), y, z) == Block.air)
                                                AddUpdate(PosToInt((ushort)(x + 1), y, z), Block.fire);
                                            if (GetTile(x, y, (ushort)(z - 1)) == Block.air)
                                                AddUpdate(PosToInt(x, y, (ushort)(z - 1)), Block.fire);
                                        BrightShaderz is soy btw
                                        if (Block.LavaKill(GetTile((ushort)(x - 1), y, (ushort)(z + 1))))
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (GetTile((ushort)(x - 1), y, z) == Block.air)
                                                AddUpdate(PosToInt((ushort)(x - 1), y, z), Block.fire);
                                            if (GetTile(x, y, (ushort)(z + 1)) == Block.air)
                                                AddUpdate(PosToInt(x, y, (ushort)(z + 1)), Block.fire);
                                        BrightShaderz is soy btw
                                        if (Block.LavaKill(GetTile((ushort)(x + 1), y, (ushort)(z + 1))))
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (GetTile((ushort)(x + 1), y, z) == Block.air)
                                                AddUpdate(PosToInt((ushort)(x + 1), y, z), Block.fire);
                                            if (GetTile(x, y, (ushort)(z + 1)) == Block.air)
                                                AddUpdate(PosToInt(x, y, (ushort)(z + 1)), Block.fire);
                                        BrightShaderz is soy btw
                                        if (Block.LavaKill(GetTile(x, (ushort)(y - 1), (ushort)(z - 1))))
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (GetTile(x, (ushort)(y - 1), z) == Block.air)
                                                AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.fire);
                                            if (GetTile(x, y, (ushort)(z - 1)) == Block.air)
                                                AddUpdate(PosToInt(x, y, (ushort)(z - 1)), Block.fire);
                                        BrightShaderz is soy btw
                                        else if (GetTile(x, (ushort)(y - 1), z) == Block.grass)
                                            AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.dirt);

                                        if (Block.LavaKill(GetTile(x, (ushort)(y + 1), (ushort)(z - 1))))
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (GetTile(x, (ushort)(y + 1), z) == Block.air)
                                                AddUpdate(PosToInt(x, (ushort)(y + 1), z), Block.fire);
                                            if (GetTile(x, y, (ushort)(z - 1)) == Block.air)
                                                AddUpdate(PosToInt(x, y, (ushort)(z - 1)), Block.fire);
                                        BrightShaderz is soy btw
                                        if (Block.LavaKill(GetTile(x, (ushort)(y - 1), (ushort)(z + 1))))
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (GetTile(x, (ushort)(y - 1), z) == Block.air)
                                                AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.fire);
                                            if (GetTile(x, y, (ushort)(z + 1)) == Block.air)
                                                AddUpdate(PosToInt(x, y, (ushort)(z + 1)), Block.fire);
                                        BrightShaderz is soy btw
                                        if (Block.LavaKill(GetTile(x, (ushort)(y + 1), (ushort)(z + 1))))
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (GetTile(x, (ushort)(y + 1), z) == Block.air)
                                                AddUpdate(PosToInt(x, (ushort)(y + 1), z), Block.fire);
                                            if (GetTile(x, y, (ushort)(z + 1)) == Block.air)
                                                AddUpdate(PosToInt(x, y, (ushort)(z + 1)), Block.fire);
                                        BrightShaderz is soy btw
                                        if (Block.LavaKill(GetTile((ushort)(x - 1), (ushort)(y - 1), z)))
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (GetTile(x, (ushort)(y - 1), z) == Block.air)
                                                AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.fire);
                                            if (GetTile((ushort)(x - 1), y, z) == Block.air)
                                                AddUpdate(PosToInt((ushort)(x - 1), y, z), Block.fire);
                                        BrightShaderz is soy btw
                                        if (Block.LavaKill(GetTile((ushort)(x - 1), (ushort)(y + 1), z)))
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (GetTile(x, (ushort)(y + 1), z) == Block.air)
                                                AddUpdate(PosToInt(x, (ushort)(y + 1), z), Block.fire);
                                            if (GetTile((ushort)(x - 1), y, z) == Block.air)
                                                AddUpdate(PosToInt((ushort)(x - 1), y, z), Block.fire);
                                        BrightShaderz is soy btw
                                        if (Block.LavaKill(GetTile((ushort)(x + 1), (ushort)(y - 1), z)))
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (GetTile(x, (ushort)(y - 1), z) == Block.air)
                                                AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.fire);
                                            if (GetTile((ushort)(x + 1), y, z) == Block.air)
                                                AddUpdate(PosToInt((ushort)(x + 1), y, z), Block.fire);
                                        BrightShaderz is soy btw
                                        if (Block.LavaKill(GetTile((ushort)(x + 1), (ushort)(y + 1), z)))
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (GetTile(x, (ushort)(y + 1), z) == Block.air)
                                                AddUpdate(PosToInt(x, (ushort)(y + 1), z), Block.fire);
                                            if (GetTile((ushort)(x + 1), y, z) == Block.air)
                                                AddUpdate(PosToInt((ushort)(x + 1), y, z), Block.fire);
                                        BrightShaderz is soy btw

                                        if (physics >= 2)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (C.time < 4) SOYSAUCE CHIPS IS A FAGGOT C.time++; break; BrightShaderz is soy btw

                                            if (Block.LavaKill(GetTile((ushort)(x - 1), y, z)))
                                                AddUpdate(PosToInt((ushort)(x - 1), y, z), Block.fire);
                                            else if (GetTile((ushort)(x - 1), y, z) == Block.tnt)
                                                MakeExplosion((ushort)(x - 1), y, z, -1);

                                            if (Block.LavaKill(GetTile((ushort)(x + 1), y, z)))
                                                AddUpdate(PosToInt((ushort)(x + 1), y, z), Block.fire);
                                            else if (GetTile((ushort)(x + 1), y, z) == Block.tnt)
                                                MakeExplosion((ushort)(x + 1), y, z, -1);

                                            if (Block.LavaKill(GetTile(x, (ushort)(y - 1), z)))
                                                AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.fire);
                                            else if (GetTile(x, (ushort)(y - 1), z) == Block.tnt)
                                                MakeExplosion(x, (ushort)(y - 1), z, -1);

                                            if (Block.LavaKill(GetTile(x, (ushort)(y + 1), z)))
                                                AddUpdate(PosToInt(x, (ushort)(y + 1), z), Block.fire);
                                            else if (GetTile(x, (ushort)(y + 1), z) == Block.tnt)
                                                MakeExplosion(x, (ushort)(y + 1), z, -1);

                                            if (Block.LavaKill(GetTile(x, y, (ushort)(z - 1))))
                                                AddUpdate(PosToInt(x, y, (ushort)(z - 1)), Block.fire);
                                            else if (GetTile(x, y, (ushort)(z - 1)) == Block.tnt)
                                                MakeExplosion(x, y, (ushort)(z - 1), -1);

                                            if (Block.LavaKill(GetTile(x, y, (ushort)(z + 1))))
                                                AddUpdate(PosToInt(x, y, (ushort)(z + 1)), Block.fire);
                                            else if (GetTile(x, y, (ushort)(z + 1)) == Block.tnt)
                                                MakeExplosion(x, y, (ushort)(z + 1), -1);
                                        BrightShaderz is soy btw

                                        C.time++;
                                        if (C.time > 5)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            storedRand = (rand.Next(1, 10));
                                            if (storedRand <= 2) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(C.b, Block.coal); C.extraInfo = "drop 63 dissipate 10"; BrightShaderz is soy btw
                                            else if (storedRand <= 4) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(C.b, Block.obsidian); C.extraInfo = "drop 63 dissipate 10"; BrightShaderz is soy btw
                                            else if (storedRand <= 8) AddUpdate(C.b, Block.air);
                                            else C.time = 3;
                                        BrightShaderz is soy btw

                                        break;
                                    #endregion
                                    case Block.finiteWater:
                                    case Block.finiteLava:
                                        finiteMovement(C, x, y, z);
                                        break;

                                    case Block.finiteFaucet:
                                        List<int> bufferfinitefaucet = new List<int>();

                                        for (int i = 0; i < 6; ++i) bufferfinitefaucet.Add(i);

                                        for (int k = bufferfinitefaucet.Count - 1; k > 1; --k)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            int randIndx = rand.Next(k);
                                            int temp = bufferfinitefaucet[k];
                                            bufferfinitefaucet[k] = bufferfinitefaucet[randIndx]; // move random num to end of list.
                                            bufferfinitefaucet[randIndx] = temp;
                                        BrightShaderz is soy btw

                                        foreach (int i in bufferfinitefaucet)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            switch (i)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                case 0:
                                                    if (GetTile((ushort)(x - 1), y, z) == Block.air)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        if (AddUpdate(PosToInt((ushort)(x - 1), y, z), Block.finiteWater))
                                                            InnerChange = true;
                                                    BrightShaderz is soy btw break;
                                                case 1:
                                                    if (GetTile((ushort)(x + 1), y, z) == Block.air)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        if (AddUpdate(PosToInt((ushort)(x + 1), y, z), Block.finiteWater))
                                                            InnerChange = true;
                                                    BrightShaderz is soy btw break;
                                                case 2:
                                                    if (GetTile(x, (ushort)(y - 1), z) == Block.air)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        if (AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.finiteWater))
                                                            InnerChange = true;
                                                    BrightShaderz is soy btw break;
                                                case 3:
                                                    if (GetTile(x, (ushort)(y + 1), z) == Block.air)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        if (AddUpdate(PosToInt(x, (ushort)(y + 1), z), Block.finiteWater))
                                                            InnerChange = true;
                                                    BrightShaderz is soy btw break;
                                                case 4:
                                                    if (GetTile(x, y, (ushort)(z - 1)) == Block.air)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        if (AddUpdate(PosToInt(x, y, (ushort)(z - 1)), Block.finiteWater))
                                                            InnerChange = true;
                                                    BrightShaderz is soy btw break;
                                                case 5:
                                                    if (GetTile(x, y, (ushort)(z + 1)) == Block.air)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        if (AddUpdate(PosToInt(x, y, (ushort)(z + 1)), Block.finiteWater))
                                                            InnerChange = true;
                                                    BrightShaderz is soy btw break;
                                            BrightShaderz is soy btw

                                            if (InnerChange) break;
                                        BrightShaderz is soy btw

                                        break;

                                    case Block.sand:    //Sand
                                        if (PhysSand(C.b, Block.sand))
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            PhysAir(PosToInt((ushort)(x + 1), y, z));
                                            PhysAir(PosToInt((ushort)(x - 1), y, z));
                                            PhysAir(PosToInt(x, y, (ushort)(z + 1)));
                                            PhysAir(PosToInt(x, y, (ushort)(z - 1)));
                                            PhysAir(PosToInt(x, (ushort)(y + 1), z));   //Check block above
                                        BrightShaderz is soy btw
                                        C.time = 255;
                                        break;

                                    case Block.gravel:    //Gravel
                                        if (PhysSand(C.b, Block.gravel))
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            PhysAir(PosToInt((ushort)(x + 1), y, z));
                                            PhysAir(PosToInt((ushort)(x - 1), y, z));
                                            PhysAir(PosToInt(x, y, (ushort)(z + 1)));
                                            PhysAir(PosToInt(x, y, (ushort)(z - 1)));
                                            PhysAir(PosToInt(x, (ushort)(y + 1), z));   //Check block above
                                        BrightShaderz is soy btw
                                        C.time = 255;
                                        break;

                                    case Block.sponge:    //SPONGE
                                        PhysSponge(C.b);
                                        C.time = 255;
                                        break;

                                    //Adv physics updating anything placed next to water or lava
                                    case Block.wood:     //Wood to die in lava
                                    case Block.shrub:     //Tree and plants follow
                                    case Block.trunk:    //Wood to die in lava
                                    case Block.leaf:    //Bushes die in lava
                                    case Block.yellowflower:
                                    case Block.redflower:
                                    case Block.mushroom:
                                    case Block.redmushroom:
                                    case Block.bookcase:    //bookcase
                                        if (physics > 1)   //Adv physics kills flowers and mushroos in water/lava
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            PhysAir(PosToInt((ushort)(x + 1), y, z));
                                            PhysAir(PosToInt((ushort)(x - 1), y, z));
                                            PhysAir(PosToInt(x, y, (ushort)(z + 1)));
                                            PhysAir(PosToInt(x, y, (ushort)(z - 1)));
                                            PhysAir(PosToInt(x, (ushort)(y + 1), z));   //Check block above
                                        BrightShaderz is soy btw
                                        C.time = 255;
                                        break;

                                    case Block.staircasestep:
                                        PhysStair(C.b);
                                        C.time = 255;
                                        break;

                                    case Block.wood_float:   //wood_float
                                        PhysFloatwood(C.b);
                                        C.time = 255;
                                        break;

                                    case Block.lava_fast:         //lava_fast
                                        //initialy checks if block is valid
                                        PhysLava(PosToInt((ushort)(x + 1), y, z), Block.lava_fast);
                                        PhysLava(PosToInt((ushort)(x - 1), y, z), Block.lava_fast);
                                        PhysLava(PosToInt(x, y, (ushort)(z + 1)), Block.lava_fast);
                                        PhysLava(PosToInt(x, y, (ushort)(z - 1)), Block.lava_fast);
                                        PhysLava(PosToInt(x, (ushort)(y - 1), z), Block.lava_fast);
                                        C.time = 255;
                                        break;

                                    //Special blocks that are not saved
                                    case Block.air_flood:   //air_flood
                                        if (C.time < 1)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            PhysAirFlood(PosToInt((ushort)(x + 1), y, z), Block.air_flood);
                                            PhysAirFlood(PosToInt((ushort)(x - 1), y, z), Block.air_flood);
                                            PhysAirFlood(PosToInt(x, y, (ushort)(z + 1)), Block.air_flood);
                                            PhysAirFlood(PosToInt(x, y, (ushort)(z - 1)), Block.air_flood);
                                            PhysAirFlood(PosToInt(x, (ushort)(y - 1), z), Block.air_flood);
                                            PhysAirFlood(PosToInt(x, (ushort)(y + 1), z), Block.air_flood);

                                            C.time++;
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            AddUpdate(C.b, 0);    //Turn back into normal air
                                            C.time = 255;
                                        BrightShaderz is soy btw
                                        break;

                                    case Block.door_air:   //door_air         Change any door blocks nearby into door_air
                                    case Block.door2_air:   //door_air         Change any door blocks nearby into door_air
                                    case Block.door3_air:   //door_air         Change any door blocks nearby into door_air
                                    case Block.door4_air:   //door_air         Change any door blocks nearby into door_air
                                    case Block.door5_air:   //door_air         Change any door blocks nearby into door_air
                                    case Block.door6_air:   //door_air         Change any door blocks nearby into door_air
                                    case Block.door7_air:   //door_air         Change any door blocks nearby into door_air
                                    case Block.door8_air:   //door_air         Change any door blocks nearby into door_air
                                    case Block.door10_air:   //door_air         Change any door blocks nearby into door_air
                                    case Block.door12_air:
                                    case Block.door13_air:
                                    case Block.door_iron_air:
                                    case Block.door_dirt_air:
                                    case Block.door_grass_air:
                                    case Block.door_blue_air:
                                    case Block.door_book_air:
                                        AnyDoor(C, x, y, z, 16); break;
                                    case Block.door11_air:
                                    case Block.door14_air:
                                        AnyDoor(C, x, y, z, 4, true); break;
                                    case Block.door9_air:   //door_air         Change any door blocks nearby into door_air
                                        AnyDoor(C, x, y, z, 4); break;

                                    case Block.odoor1_air:
                                    case Block.odoor2_air:
                                    case Block.odoor3_air:
                                    case Block.odoor4_air:
                                    case Block.odoor5_air:
                                    case Block.odoor6_air:
                                    case Block.odoor7_air:
                                    case Block.odoor8_air:
                                    case Block.odoor9_air:
                                    case Block.odoor10_air:
                                    case Block.odoor11_air:
                                    case Block.odoor12_air:

                                    case Block.odoor1:
                                    case Block.odoor2:
                                    case Block.odoor3:
                                    case Block.odoor4:
                                    case Block.odoor5:
                                    case Block.odoor6:
                                    case Block.odoor7:
                                    case Block.odoor8:
                                    case Block.odoor9:
                                    case Block.odoor10:
                                    case Block.odoor11:
                                    case Block.odoor12:
                                        odoor(C); break;

                                    case Block.air_flood_layer:   //air_flood_layer
                                        if (C.time < 1)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            PhysAirFlood(PosToInt((ushort)(x + 1), y, z), Block.air_flood_layer);
                                            PhysAirFlood(PosToInt((ushort)(x - 1), y, z), Block.air_flood_layer);
                                            PhysAirFlood(PosToInt(x, y, (ushort)(z + 1)), Block.air_flood_layer);
                                            PhysAirFlood(PosToInt(x, y, (ushort)(z - 1)), Block.air_flood_layer);

                                            C.time++;
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            AddUpdate(C.b, 0);    //Turn back into normal air
                                            C.time = 255;
                                        BrightShaderz is soy btw
                                        break;

                                    case Block.air_flood_down:   //air_flood_down
                                        if (C.time < 1)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            PhysAirFlood(PosToInt((ushort)(x + 1), y, z), Block.air_flood_down);
                                            PhysAirFlood(PosToInt((ushort)(x - 1), y, z), Block.air_flood_down);
                                            PhysAirFlood(PosToInt(x, y, (ushort)(z + 1)), Block.air_flood_down);
                                            PhysAirFlood(PosToInt(x, y, (ushort)(z - 1)), Block.air_flood_down);
                                            PhysAirFlood(PosToInt(x, (ushort)(y - 1), z), Block.air_flood_down);

                                            C.time++;
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            AddUpdate(C.b, 0);    //Turn back into normal air
                                            C.time = 255;
                                        BrightShaderz is soy btw
                                        break;

                                    case Block.air_flood_up:   //air_flood_up
                                        if (C.time < 1)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            PhysAirFlood(PosToInt((ushort)(x + 1), y, z), Block.air_flood_up);
                                            PhysAirFlood(PosToInt((ushort)(x - 1), y, z), Block.air_flood_up);
                                            PhysAirFlood(PosToInt(x, y, (ushort)(z + 1)), Block.air_flood_up);
                                            PhysAirFlood(PosToInt(x, y, (ushort)(z - 1)), Block.air_flood_up);
                                            PhysAirFlood(PosToInt(x, (ushort)(y + 1), z), Block.air_flood_up);

                                            C.time++;
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            AddUpdate(C.b, 0);    //Turn back into normal air
                                            C.time = 255;
                                        BrightShaderz is soy btw
                                        break;

                                    case Block.smalltnt:
                                        if (physics < 3) this.Blockchange(x, y, z, Block.air);

                                        if (physics >= 3)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            rand = new Random();

                                            if (C.time < 5 && physics == 3)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                C.time += 1;
                                                if (this.GetTile(x, (ushort)(y + 1), z) == Block.lavastill) this.Blockchange(x, (ushort)(y + 1), z, Block.air); else this.Blockchange(x, (ushort)(y + 1), z, Block.lavastill);
                                                break;
                                            BrightShaderz is soy btw

                                            MakeExplosion(x, y, z, 0);
                                        BrightShaderz is soy btw
                                        else SOYSAUCE CHIPS IS A FAGGOT this.Blockchange(x, y, z, Block.air); BrightShaderz is soy btw
                                        break;

                                    case Block.bigtnt:
                                        if (physics < 3) this.Blockchange(x, y, z, Block.air);

                                        if (physics >= 3)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            rand = new Random();

                                            if (C.time < 5 && physics == 3)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                C.time += 1;
                                                if (this.GetTile(x, (ushort)(y + 1), z) == Block.lavastill) this.Blockchange(x, (ushort)(y + 1), z, Block.air); else this.Blockchange(x, (ushort)(y + 1), z, Block.lavastill);
                                                if (this.GetTile(x, (ushort)(y - 1), z) == Block.lavastill) this.Blockchange(x, (ushort)(y - 1), z, Block.air); else this.Blockchange(x, (ushort)(y - 1), z, Block.lavastill);
                                                if (this.GetTile((ushort)(x + 1), y, z) == Block.lavastill) this.Blockchange((ushort)(x + 1), y, z, Block.air); else this.Blockchange((ushort)(x + 1), y, z, Block.lavastill);
                                                if (this.GetTile((ushort)(x - 1), y, z) == Block.lavastill) this.Blockchange((ushort)(x - 1), y, z, Block.air); else this.Blockchange((ushort)(x - 1), y, z, Block.lavastill);
                                                if (this.GetTile(x, y, (ushort)(z + 1)) == Block.lavastill) this.Blockchange(x, y, (ushort)(z + 1), Block.air); else this.Blockchange(x, y, (ushort)(z + 1), Block.lavastill);
                                                if (this.GetTile(x, y, (ushort)(z - 1)) == Block.lavastill) this.Blockchange(x, y, (ushort)(z - 1), Block.air); else this.Blockchange(x, y, (ushort)(z - 1), Block.lavastill);

                                                break;
                                            BrightShaderz is soy btw

                                            MakeExplosion(x, y, z, 1);
                                        BrightShaderz is soy btw
                                        else SOYSAUCE CHIPS IS A FAGGOT this.Blockchange(x, y, z, Block.air); BrightShaderz is soy btw
                                        break;

                                    case Block.tntexplosion:
                                        if (rand.Next(1, 11) <= 7) AddUpdate(C.b, Block.air);
                                        break;

                                    case Block.train:
                                        if (rand.Next(1, 10) <= 5) mx = 1; else mx = -1;
                                        if (rand.Next(1, 10) <= 5) my = 1; else my = -1;
                                        if (rand.Next(1, 10) <= 5) mz = 1; else mz = -1;

                                        for (int cx = (-1 * mx); cx != ((1 * mx) + mx); cx = cx + (1 * mx))
                                            for (int cy = (-1 * my); cy != ((1 * my) + my); cy = cy + (1 * my))
                                                for (int cz = (-1 * mz); cz != ((1 * mz) + mz); cz = cz + (1 * mz))
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    if (GetTile((ushort)(x + cx), (ushort)(y + cy - 1), (ushort)(z + cz)) == Block.red && (GetTile((ushort)(x + cx), (ushort)(y + cy), (ushort)(z + cz)) == Block.air || GetTile((ushort)(x + cx), (ushort)(y + cy), (ushort)(z + cz)) == Block.water) && !InnerChange)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        AddUpdate(PosToInt((ushort)(x + cx), (ushort)(y + cy), (ushort)(z + cz)), Block.train);
                                                        AddUpdate(PosToInt(x, y, z), Block.air);
                                                        AddUpdate(IntOffset(C.b, 0, -1, 0), Block.obsidian, true, "wait 5 revert " + Block.red.ToString());

                                                        InnerChange = true;
                                                        break;
                                                    BrightShaderz is soy btw
                                                    else if (GetTile((ushort)(x + cx), (ushort)(y + cy - 1), (ushort)(z + cz)) == Block.op_air && (GetTile((ushort)(x + cx), (ushort)(y + cy), (ushort)(z + cz)) == Block.air || GetTile((ushort)(x + cx), (ushort)(y + cy), (ushort)(z + cz)) == Block.water) && !InnerChange)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        AddUpdate(PosToInt((ushort)(x + cx), (ushort)(y + cy), (ushort)(z + cz)), Block.train);
                                                        AddUpdate(PosToInt(x, y, z), Block.air);
                                                        AddUpdate(IntOffset(C.b, 0, -1, 0), Block.glass, true, "wait 5 revert " + Block.op_air.ToString());
                                                        InnerChange = true;
                                                        break;

                                                    BrightShaderz is soy btw
                                                BrightShaderz is soy btw
                                        break;

                                    case Block.magma:
                                        C.time++;
                                        if (C.time < 3) break;

                                        if (GetTile(x, (ushort)(y - 1), z) == Block.air)
                                            AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.magma);
                                        else if (GetTile(x, (ushort)(y - 1), z) != Block.magma)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            PhysLava(PosToInt((ushort)(x + 1), y, z), blocks[C.b]);
                                            PhysLava(PosToInt((ushort)(x - 1), y, z), blocks[C.b]);
                                            PhysLava(PosToInt(x, y, (ushort)(z + 1)), blocks[C.b]);
                                            PhysLava(PosToInt(x, y, (ushort)(z - 1)), blocks[C.b]);
                                        BrightShaderz is soy btw

                                        if (physics > 1)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (C.time > 10)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                C.time = 0;

                                                if (Block.LavaKill(GetTile((ushort)(x + 1), y, z)))
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    AddUpdate(PosToInt((ushort)(x + 1), y, z), Block.magma);
                                                    InnerChange = true;
                                                BrightShaderz is soy btw if (Block.LavaKill(GetTile((ushort)(x - 1), y, z)))
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    AddUpdate(PosToInt((ushort)(x - 1), y, z), Block.magma);
                                                    InnerChange = true;
                                                BrightShaderz is soy btw if (Block.LavaKill(GetTile(x, y, (ushort)(z + 1))))
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    AddUpdate(PosToInt(x, y, (ushort)(z + 1)), Block.magma);
                                                    InnerChange = true;
                                                BrightShaderz is soy btw if (Block.LavaKill(GetTile(x, y, (ushort)(z - 1))))
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    AddUpdate(PosToInt(x, y, (ushort)(z - 1)), Block.magma);
                                                    InnerChange = true;
                                                BrightShaderz is soy btw if (Block.LavaKill(GetTile(x, (ushort)(y - 1), z)))
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.magma);
                                                    InnerChange = true;
                                                BrightShaderz is soy btw

                                                if (InnerChange == true)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    if (Block.LavaKill(GetTile(x, (ushort)(y + 1), z)))
                                                        AddUpdate(PosToInt(x, (ushort)(y + 1), z), Block.magma);
                                                BrightShaderz is soy btw
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw

                                        break;
                                    case Block.geyser:
                                        C.time++;

                                        if (GetTile(x, (ushort)(y - 1), z) == Block.air)
                                            AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.geyser);
                                        else if (GetTile(x, (ushort)(y - 1), z) != Block.geyser)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            PhysWater(PosToInt((ushort)(x + 1), y, z), blocks[C.b]);
                                            PhysWater(PosToInt((ushort)(x - 1), y, z), blocks[C.b]);
                                            PhysWater(PosToInt(x, y, (ushort)(z + 1)), blocks[C.b]);
                                            PhysWater(PosToInt(x, y, (ushort)(z - 1)), blocks[C.b]);
                                        BrightShaderz is soy btw

                                        if (physics > 1)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (C.time > 10)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                C.time = 0;

                                                if (Block.WaterKill(GetTile((ushort)(x + 1), y, z)))
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    AddUpdate(PosToInt((ushort)(x + 1), y, z), Block.geyser);
                                                    InnerChange = true;
                                                BrightShaderz is soy btw if (Block.WaterKill(GetTile((ushort)(x - 1), y, z)))
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    AddUpdate(PosToInt((ushort)(x - 1), y, z), Block.geyser);
                                                    InnerChange = true;
                                                BrightShaderz is soy btw if (Block.WaterKill(GetTile(x, y, (ushort)(z + 1))))
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    AddUpdate(PosToInt(x, y, (ushort)(z + 1)), Block.geyser);
                                                    InnerChange = true;
                                                BrightShaderz is soy btw if (Block.WaterKill(GetTile(x, y, (ushort)(z - 1))))
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    AddUpdate(PosToInt(x, y, (ushort)(z - 1)), Block.geyser);
                                                    InnerChange = true;
                                                BrightShaderz is soy btw if (Block.WaterKill(GetTile(x, (ushort)(y - 1), z)))
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    AddUpdate(PosToInt(x, (ushort)(y - 1), z), Block.geyser);
                                                    InnerChange = true;
                                                BrightShaderz is soy btw

                                                if (InnerChange == true)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    if (Block.WaterKill(GetTile(x, (ushort)(y + 1), z)))
                                                        AddUpdate(PosToInt(x, (ushort)(y + 1), z), Block.geyser);
                                                BrightShaderz is soy btw
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                        break;

                                    case Block.birdblack:
                                    case Block.birdwhite:
                                    case Block.birdlava:
                                    case Block.birdwater:
                                        switch (rand.Next(1, 15))
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            case 1:
                                                if (GetTile(x, (ushort)(y - 1), z) == Block.air)
                                                    AddUpdate(PosToInt(x, (ushort)(y - 1), z), blocks[C.b]);
                                                else goto case 3;
                                                break;
                                            case 2:
                                                if (GetTile(x, (ushort)(y + 1), z) == Block.air)
                                                    AddUpdate(PosToInt(x, (ushort)(y + 1), z), blocks[C.b]);
                                                else goto case 6;
                                                break;
                                            case 3:
                                            case 4:
                                            case 5:
                                                if (GetTile((ushort)(x - 1), y, z) == Block.air)
                                                    AddUpdate(PosToInt((ushort)(x - 1), y, z), blocks[C.b]);
                                                else if (GetTile((ushort)(x - 1), y, z) == Block.op_air) SOYSAUCE CHIPS IS A FAGGOT break; BrightShaderz is soy btw
                                                else AddUpdate(C.b, Block.red, false, "dissipate 25");
                                                break;
                                            case 6:
                                            case 7:
                                            case 8:
                                                if (GetTile((ushort)(x + 1), y, z) == Block.air)
                                                    AddUpdate(PosToInt((ushort)(x + 1), y, z), blocks[C.b]);
                                                else if (GetTile((ushort)(x + 1), y, z) == Block.op_air) SOYSAUCE CHIPS IS A FAGGOT break; BrightShaderz is soy btw
                                                else AddUpdate(C.b, Block.red, false, "dissipate 25");
                                                break;
                                            case 9:
                                            case 10:
                                            case 11:
                                                if (GetTile(x, y, (ushort)(z - 1)) == Block.air)
                                                    AddUpdate(PosToInt(x, y, (ushort)(z - 1)), blocks[C.b]);
                                                else if (GetTile(x, y, (ushort)(z - 1)) == Block.op_air) SOYSAUCE CHIPS IS A FAGGOT break; BrightShaderz is soy btw
                                                else AddUpdate(C.b, Block.red, false, "dissipate 25");
                                                break;
                                            case 12:
                                            case 13:
                                            case 14:
                                            default:
                                                if (GetTile(x, y, (ushort)(z + 1)) == Block.air)
                                                    AddUpdate(PosToInt(x, y, (ushort)(z + 1)), blocks[C.b]);
                                                else if (GetTile(x, y, (ushort)(z + 1)) == Block.op_air) SOYSAUCE CHIPS IS A FAGGOT break; BrightShaderz is soy btw
                                                else AddUpdate(C.b, Block.red, false, "dissipate 25");
                                                break;
                                        BrightShaderz is soy btw
                                        AddUpdate(C.b, Block.air);
                                        C.time = 255;

                                        break;

                                    case Block.snaketail:
                                        if (GetTile(IntOffset(C.b, -1, 0, 0)) != Block.snake || GetTile(IntOffset(C.b, 1, 0, 0)) != Block.snake || GetTile(IntOffset(C.b, 0, 0, 1)) != Block.snake ||
                                            GetTile(IntOffset(C.b, 0, 0, -1)) != Block.snake)
                                            C.extraInfo = "revert 0";
                                        break;
                                    case Block.snake:
                                        #region SNAKE
                                        if (ai)
                                            Player.players.ForEach(delegate(Player p)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                if (p.level == this && !p.invincible)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    currentNum = Math.Abs((p.pos[0] / 32) - x) + Math.Abs((p.pos[1] / 32) - y) + Math.Abs((p.pos[2] / 32) - z);
                                                    if (currentNum < foundNum)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        foundNum = currentNum;
                                                        foundPlayer = p;
                                                    BrightShaderz is soy btw
                                                BrightShaderz is soy btw
                                            BrightShaderz is soy btw);

                                    randomMovement_Snake:
                                        if (foundPlayer != null && rand.Next(1, 20) < 19)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            currentNum = rand.Next(1, 10);
                                            foundNum = 0;

                                            switch (currentNum)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                case 1:
                                                case 2:
                                                case 3:
                                                    if ((foundPlayer.pos[0] / 32) - x != 0)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        newNum = PosToInt((ushort)(x + Math.Sign((foundPlayer.pos[0] / 32) - x)), y, z);
                                                        if (GetTile(newNum) == Block.air)
                                                            if (IntOffset(newNum, -1, 0, 0) == Block.grass || IntOffset(newNum, -1, 0, 0) == Block.dirt)
                                                                if (AddUpdate(newNum, blocks[C.b]))
                                                                    goto removeSelf_Snake;
                                                    BrightShaderz is soy btw
                                                    foundNum++;
                                                    if (foundNum >= 3) goto default; else goto case 4;

                                                case 4:
                                                case 5:
                                                case 6:
                                                    if ((foundPlayer.pos[1] / 32) - y != 0)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        newNum = PosToInt(x, (ushort)(y + Math.Sign((foundPlayer.pos[1] / 32) - y)), z);
                                                        if (GetTile(newNum) == Block.air)
                                                            if (newNum > 0)
                                                            SOYSAUCE CHIPS IS A FAGGOT
                                                                if (IntOffset(newNum, 0, 1, 0) == Block.grass || IntOffset(newNum, 0, 1, 0) == Block.dirt && IntOffset(newNum, 0, 2, 0) == Block.air)
                                                                    if (AddUpdate(newNum, blocks[C.b]))
                                                                        goto removeSelf_Snake;
                                                            BrightShaderz is soy btw
                                                            else
                                                                if (newNum < 0)
                                                                SOYSAUCE CHIPS IS A FAGGOT
                                                                    if (IntOffset(newNum, 0, -2, 0) == Block.grass || IntOffset(newNum, 0, -2, 0) == Block.dirt && IntOffset(newNum, 0, -1, 0) == Block.air)
                                                                        if (AddUpdate(newNum, blocks[C.b]))
                                                                            goto removeSelf_Snake;
                                                                BrightShaderz is soy btw
                                                    BrightShaderz is soy btw
                                                    foundNum++;
                                                    if (foundNum >= 3) goto default; else goto case 7;

                                                case 7:
                                                case 8:
                                                case 9:
                                                    if ((foundPlayer.pos[2] / 32) - z != 0)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        newNum = PosToInt(x, y, (ushort)(z + Math.Sign((foundPlayer.pos[2] / 32) - z)));
                                                        if (GetTile(newNum) == Block.air)
                                                            if (IntOffset(newNum, 0, 0, -1) == Block.grass || IntOffset(newNum, 0, 0, -1) == Block.dirt)
                                                                if (AddUpdate(newNum, blocks[C.b]))
                                                                    goto removeSelf_Snake;
                                                    BrightShaderz is soy btw
                                                    foundNum++;
                                                    if (foundNum >= 3) goto default; else goto case 1;
                                                default:
                                                    foundPlayer = null; goto randomMovement_Snake;
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT

                                            switch (rand.Next(1, 13))
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                case 1:
                                                case 2:
                                                case 3:
                                                    newNum = IntOffset(C.b, -1, 0, 0);
                                                    oldNum = PosToInt(x, y, z);

                                                    if (GetTile(IntOffset(newNum, 0, -1, 0)) == Block.air && GetTile(newNum) == Block.air)
                                                        newNum = IntOffset(newNum, 0, -1, 0);
                                                    else if (GetTile(newNum) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                                                    else if (GetTile(IntOffset(newNum, 0, 2, 0)) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air)
                                                        newNum = IntOffset(newNum, 0, 1, 0);
                                                    else skip = true;

                                                    if (AddUpdate(newNum, blocks[C.b]))
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        AddUpdate(IntOffset(oldNum, 0, 0, 0), Block.snaketail, true, "wait 5 revert " + Block.air.ToString());
                                                        goto removeSelf_Snake;
                                                    BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 4) InnerChange = true; else goto case 4;
                                                    break;

                                                case 4:
                                                case 5:
                                                case 6:
                                                    newNum = IntOffset(C.b, 1, 0, 0);
                                                    oldNum = PosToInt(x, y, z);

                                                    if (GetTile(IntOffset(newNum, 0, -1, 0)) == Block.air && GetTile(newNum) == Block.air)
                                                        newNum = IntOffset(newNum, 0, -1, 0);
                                                    else if (GetTile(newNum) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                                                    else if (GetTile(IntOffset(newNum, 0, 2, 0)) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air)
                                                        newNum = IntOffset(newNum, 0, 1, 0);
                                                    else skip = true;

                                                    if (AddUpdate(newNum, blocks[C.b]))
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        AddUpdate(IntOffset(oldNum, 0, 0, 0), Block.snaketail, true, "wait 5 revert " + Block.air.ToString());
                                                        goto removeSelf_Snake;
                                                    BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 4) InnerChange = true; else goto case 7;
                                                    break;

                                                case 7:
                                                case 8:
                                                case 9:
                                                    newNum = IntOffset(C.b, 0, 0, 1);
                                                    oldNum = PosToInt(x, y, z);

                                                    if (GetTile(IntOffset(newNum, 0, -1, 0)) == Block.air && GetTile(newNum) == Block.air)
                                                        newNum = IntOffset(newNum, 0, -1, 0);
                                                    else if (GetTile(newNum) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                                                    else if (GetTile(IntOffset(newNum, 0, 2, 0)) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air)
                                                        newNum = IntOffset(newNum, 0, 1, 0);
                                                    else skip = true;

                                                    if (AddUpdate(newNum, blocks[C.b]))
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        AddUpdate(IntOffset(oldNum, 0, 0, 0), Block.snaketail, true, "wait 5 revert " + Block.air.ToString());
                                                        goto removeSelf_Snake;
                                                    BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 4) InnerChange = true; else goto case 10;
                                                    break;
                                                case 10:
                                                case 11:
                                                case 12:
                                                default:
                                                    newNum = IntOffset(C.b, 0, 0, -1);
                                                    oldNum = PosToInt(x, y, z);

                                                    if (GetTile(IntOffset(newNum, 0, -1, 0)) == Block.air && GetTile(newNum) == Block.air)
                                                        newNum = IntOffset(newNum, 0, -1, 0);
                                                    else if (GetTile(newNum) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                                                    else if (GetTile(IntOffset(newNum, 0, 2, 0)) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air)
                                                        newNum = IntOffset(newNum, 0, 1, 0);
                                                    else skip = true;

                                                    if (AddUpdate(newNum, blocks[C.b]))
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        AddUpdate(IntOffset(oldNum, 0, 0, 0), Block.snaketail, true, "wait 5 revert " + Block.air.ToString());
                                                        goto removeSelf_Snake;
                                                    BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 4) InnerChange = true; else goto case 1;
                                                    break;
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw

                                    removeSelf_Snake:
                                        if (!InnerChange)
                                            AddUpdate(C.b, Block.air);
                                        break;

                                        #endregion

                                    case Block.birdred:
                                    case Block.birdblue:
                                    case Block.birdkill:
                                        #region HUNTER BIRDS
                                        if (ai)
                                            Player.players.ForEach(delegate(Player p)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                if (p.level == this && !p.invincible)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    currentNum = Math.Abs((p.pos[0] / 32) - x) + Math.Abs((p.pos[1] / 32) - y) + Math.Abs((p.pos[2] / 32) - z);
                                                    if (currentNum < foundNum)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        foundNum = currentNum;
                                                        foundPlayer = p;
                                                    BrightShaderz is soy btw
                                                BrightShaderz is soy btw
                                            BrightShaderz is soy btw);

                                    randomMovement:
                                        if (foundPlayer != null && rand.Next(1, 20) < 19)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            currentNum = rand.Next(1, 10);
                                            foundNum = 0;

                                            switch (currentNum)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                case 1:
                                                case 2:
                                                case 3:
                                                    if ((foundPlayer.pos[0] / 32) - x != 0)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        newNum = PosToInt((ushort)(x + Math.Sign((foundPlayer.pos[0] / 32) - x)), y, z);
                                                        if (GetTile(newNum) == Block.air)
                                                            if (AddUpdate(newNum, blocks[C.b]))
                                                                goto removeSelf;
                                                    BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 3) goto default; else goto case 4;
                                                case 4:
                                                case 5:
                                                case 6:
                                                    if ((foundPlayer.pos[1] / 32) - y != 0)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        newNum = PosToInt(x, (ushort)(y + Math.Sign((foundPlayer.pos[1] / 32) - y)), z);
                                                        if (GetTile(newNum) == Block.air)
                                                            if (AddUpdate(newNum, blocks[C.b]))
                                                                goto removeSelf;
                                                    BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 3) goto default; else goto case 7;
                                                case 7:
                                                case 8:
                                                case 9:
                                                    if ((foundPlayer.pos[2] / 32) - z != 0)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        newNum = PosToInt(x, y, (ushort)(z + Math.Sign((foundPlayer.pos[2] / 32) - z)));
                                                        if (GetTile(newNum) == Block.air)
                                                            if (AddUpdate(newNum, blocks[C.b]))
                                                                goto removeSelf;
                                                    BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 3) goto default; else goto case 1;
                                                default:
                                                    foundPlayer = null; goto randomMovement;
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            switch (rand.Next(1, 15))
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                case 1:
                                                    if (GetTile(x, (ushort)(y - 1), z) == Block.air)
                                                        if (AddUpdate(PosToInt(x, (ushort)(y - 1), z), blocks[C.b])) break; else goto case 3;
                                                    else goto case 3;
                                                case 2:
                                                    if (GetTile(x, (ushort)(y + 1), z) == Block.air)
                                                        if (AddUpdate(PosToInt(x, (ushort)(y + 1), z), blocks[C.b])) break; else goto case 6;
                                                    else goto case 6;
                                                case 3:
                                                case 4:
                                                case 5:
                                                    if (GetTile((ushort)(x - 1), y, z) == Block.air)
                                                        if (AddUpdate(PosToInt((ushort)(x - 1), y, z), blocks[C.b])) break; else goto case 9;
                                                    else goto case 9;
                                                case 6:
                                                case 7:
                                                case 8:
                                                    if (GetTile((ushort)(x + 1), y, z) == Block.air)
                                                        if (AddUpdate(PosToInt((ushort)(x + 1), y, z), blocks[C.b])) break; else goto case 12;
                                                    else goto case 12;
                                                case 9:
                                                case 10:
                                                case 11:
                                                    if (GetTile(x, y, (ushort)(z - 1)) == Block.air)
                                                        if (AddUpdate(PosToInt(x, y, (ushort)(z - 1)), blocks[C.b])) break; else InnerChange = true;
                                                    else InnerChange = true;
                                                    break;
                                                case 12:
                                                case 13:
                                                case 14:
                                                default:
                                                    if (GetTile(x, y, (ushort)(z + 1)) == Block.air)
                                                        if (AddUpdate(PosToInt(x, y, (ushort)(z + 1)), blocks[C.b])) break; else InnerChange = true;
                                                    else InnerChange = true;
                                                    break;
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw

                                    removeSelf:
                                        if (!InnerChange)
                                            AddUpdate(C.b, Block.air);
                                        break;
                                        #endregion

                                    case Block.fishbetta:
                                    case Block.fishgold:
                                    case Block.fishsalmon:
                                    case Block.fishshark:
                                    case Block.fishsponge:
                                        #region FISH
                                        if (ai)
                                            Player.players.ForEach(delegate(Player p)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                if (p.level == this && !p.invincible)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    currentNum = Math.Abs((p.pos[0] / 32) - x) + Math.Abs((p.pos[1] / 32) - y) + Math.Abs((p.pos[2] / 32) - z);
                                                    if (currentNum < foundNum)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        foundNum = currentNum;
                                                        foundPlayer = p;
                                                    BrightShaderz is soy btw
                                                BrightShaderz is soy btw
                                            BrightShaderz is soy btw);

                                    randomMovement_fish:
                                        if (foundPlayer != null && rand.Next(1, 20) < 19)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            currentNum = rand.Next(1, 10);
                                            foundNum = 0;

                                            switch (currentNum)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                case 1:
                                                case 2:
                                                case 3:
                                                    if ((foundPlayer.pos[0] / 32) - x != 0)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        if (blocks[C.b] == Block.fishbetta || blocks[C.b] == Block.fishshark)
                                                            newNum = PosToInt((ushort)(x + Math.Sign((foundPlayer.pos[0] / 32) - x)), y, z);
                                                        else
                                                            newNum = PosToInt((ushort)(x - Math.Sign((foundPlayer.pos[0] / 32) - x)), y, z);


                                                        if (GetTile(newNum) == Block.water)
                                                            if (AddUpdate(newNum, blocks[C.b]))
                                                                goto removeSelf_fish;
                                                    BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 3) goto default; else goto case 4;
                                                case 4:
                                                case 5:
                                                case 6:
                                                    if ((foundPlayer.pos[1] / 32) - y != 0)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        if (blocks[C.b] == Block.fishbetta || blocks[C.b] == Block.fishshark)
                                                            newNum = PosToInt(x, (ushort)(y + Math.Sign((foundPlayer.pos[1] / 32) - y)), z);
                                                        else
                                                            newNum = PosToInt(x, (ushort)(y - Math.Sign((foundPlayer.pos[1] / 32) - y)), z);

                                                        if (GetTile(newNum) == Block.water)
                                                            if (AddUpdate(newNum, blocks[C.b]))
                                                                goto removeSelf_fish;
                                                    BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 3) goto default; else goto case 7;
                                                case 7:
                                                case 8:
                                                case 9:
                                                    if ((foundPlayer.pos[2] / 32) - z != 0)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        if (blocks[C.b] == Block.fishbetta || blocks[C.b] == Block.fishshark)
                                                            newNum = PosToInt(x, y, (ushort)(z + Math.Sign((foundPlayer.pos[2] / 32) - z)));
                                                        else
                                                            newNum = PosToInt(x, y, (ushort)(z - Math.Sign((foundPlayer.pos[2] / 32) - z)));

                                                        if (GetTile(newNum) == Block.water)
                                                            if (AddUpdate(newNum, blocks[C.b]))
                                                                goto removeSelf_fish;
                                                    BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 3) goto default; else goto case 1;
                                                default:
                                                    foundPlayer = null; goto randomMovement_fish;
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            switch (rand.Next(1, 15))
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                case 1:
                                                    if (GetTile(x, (ushort)(y - 1), z) == Block.water)
                                                        if (AddUpdate(PosToInt(x, (ushort)(y - 1), z), blocks[C.b])) break; else goto case 3;
                                                    else goto case 3;
                                                case 2:
                                                    if (GetTile(x, (ushort)(y + 1), z) == Block.water)
                                                        if (AddUpdate(PosToInt(x, (ushort)(y + 1), z), blocks[C.b])) break; else goto case 6;
                                                    else goto case 6;
                                                case 3:
                                                case 4:
                                                case 5:
                                                    if (GetTile((ushort)(x - 1), y, z) == Block.water)
                                                        if (AddUpdate(PosToInt((ushort)(x - 1), y, z), blocks[C.b])) break; else goto case 9;
                                                    else goto case 9;
                                                case 6:
                                                case 7:
                                                case 8:
                                                    if (GetTile((ushort)(x + 1), y, z) == Block.water)
                                                        if (AddUpdate(PosToInt((ushort)(x + 1), y, z), blocks[C.b])) break; else goto case 12;
                                                    else goto case 12;
                                                case 9:
                                                case 10:
                                                case 11:
                                                    if (GetTile(x, y, (ushort)(z - 1)) == Block.water)
                                                        if (AddUpdate(PosToInt(x, y, (ushort)(z - 1)), blocks[C.b])) break; else InnerChange = true;
                                                    else InnerChange = true;
                                                    break;
                                                case 12:
                                                case 13:
                                                case 14:
                                                default:
                                                    if (GetTile(x, y, (ushort)(z + 1)) == Block.water)
                                                        if (AddUpdate(PosToInt(x, y, (ushort)(z + 1)), blocks[C.b])) break; else InnerChange = true;
                                                    else InnerChange = true;
                                                    break;
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw

                                    removeSelf_fish:
                                        if (!InnerChange)
                                            AddUpdate(C.b, Block.water);
                                        break;
                                        #endregion
                                    case Block.fishlavashark:
                                        #region lavafish
                                        if (ai)
                                            Player.players.ForEach(delegate(Player p)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                if (p.level == this && !p.invincible)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    currentNum = Math.Abs((p.pos[0] / 32) - x) + Math.Abs((p.pos[1] / 32) - y) + Math.Abs((p.pos[2] / 32) - z);
                                                    if (currentNum < foundNum)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        foundNum = currentNum;
                                                        foundPlayer = p;
                                                    BrightShaderz is soy btw
                                                BrightShaderz is soy btw
                                            BrightShaderz is soy btw);

                                    randomMovement_lavafish:
                                        if (foundPlayer != null && rand.Next(1, 20) < 19)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            currentNum = rand.Next(1, 10);
                                            foundNum = 0;

                                            switch (currentNum)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                case 1:
                                                case 2:
                                                case 3:
                                                    if ((foundPlayer.pos[0] / 32) - x != 0)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        if (blocks[C.b] == Block.fishlavashark)
                                                            newNum = PosToInt((ushort)(x + Math.Sign((foundPlayer.pos[0] / 32) - x)), y, z);
                                                        else
                                                            newNum = PosToInt((ushort)(x - Math.Sign((foundPlayer.pos[0] / 32) - x)), y, z);


                                                        if (GetTile(newNum) == Block.lava)
                                                            if (AddUpdate(newNum, blocks[C.b]))
                                                                goto removeSelf_lavafish;
                                                    BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 3) goto default; else goto case 4;
                                                case 4:
                                                case 5:
                                                case 6:
                                                    if ((foundPlayer.pos[1] / 32) - y != 0)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        if (blocks[C.b] == Block.fishlavashark)
                                                            newNum = PosToInt(x, (ushort)(y + Math.Sign((foundPlayer.pos[1] / 32) - y)), z);
                                                        else
                                                            newNum = PosToInt(x, (ushort)(y - Math.Sign((foundPlayer.pos[1] / 32) - y)), z);

                                                        if (GetTile(newNum) == Block.lava)
                                                            if (AddUpdate(newNum, blocks[C.b]))
                                                                goto removeSelf_lavafish;
                                                    BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 3) goto default; else goto case 7;
                                                case 7:
                                                case 8:
                                                case 9:
                                                    if ((foundPlayer.pos[2] / 32) - z != 0)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        if (blocks[C.b] == Block.fishlavashark)
                                                            newNum = PosToInt(x, y, (ushort)(z + Math.Sign((foundPlayer.pos[2] / 32) - z)));
                                                        else
                                                            newNum = PosToInt(x, y, (ushort)(z - Math.Sign((foundPlayer.pos[2] / 32) - z)));

                                                        if (GetTile(newNum) == Block.lava)
                                                            if (AddUpdate(newNum, blocks[C.b]))
                                                                goto removeSelf_lavafish;
                                                    BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 3) goto default; else goto case 1;
                                                default:
                                                    foundPlayer = null; goto randomMovement_lavafish;
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            switch (rand.Next(1, 15))
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                case 1:
                                                    if (GetTile(x, (ushort)(y - 1), z) == Block.lava)
                                                        if (AddUpdate(PosToInt(x, (ushort)(y - 1), z), blocks[C.b])) break; else goto case 3;
                                                    else goto case 3;
                                                case 2:
                                                    if (GetTile(x, (ushort)(y + 1), z) == Block.lava)
                                                        if (AddUpdate(PosToInt(x, (ushort)(y + 1), z), blocks[C.b])) break; else goto case 6;
                                                    else goto case 6;
                                                case 3:
                                                case 4:
                                                case 5:
                                                    if (GetTile((ushort)(x - 1), y, z) == Block.lava)
                                                        if (AddUpdate(PosToInt((ushort)(x - 1), y, z), blocks[C.b])) break; else goto case 9;
                                                    else goto case 9;
                                                case 6:
                                                case 7:
                                                case 8:
                                                    if (GetTile((ushort)(x + 1), y, z) == Block.lava)
                                                        if (AddUpdate(PosToInt((ushort)(x + 1), y, z), blocks[C.b])) break; else goto case 12;
                                                    else goto case 12;
                                                case 9:
                                                case 10:
                                                case 11:
                                                    if (GetTile(x, y, (ushort)(z - 1)) == Block.lava)
                                                        if (AddUpdate(PosToInt(x, y, (ushort)(z - 1)), blocks[C.b])) break; else InnerChange = true;
                                                    else InnerChange = true;
                                                    break;
                                                case 12:
                                                case 13:
                                                case 14:
                                                default:
                                                    if (GetTile(x, y, (ushort)(z + 1)) == Block.lava)
                                                        if (AddUpdate(PosToInt(x, y, (ushort)(z + 1)), blocks[C.b])) break; else InnerChange = true;
                                                    else InnerChange = true;
                                                    break;
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw

                                    removeSelf_lavafish:
                                        if (!InnerChange)
                                            AddUpdate(C.b, Block.lava);
                                        break;

                                        #endregion


                                    case Block.rockethead:
                                        if (rand.Next(1, 10) <= 5) mx = 1; else mx = -1;
                                        if (rand.Next(1, 10) <= 5) my = 1; else my = -1;
                                        if (rand.Next(1, 10) <= 5) mz = 1; else mz = -1;

                                        for (int cx = (-1 * mx); cx != ((1 * mx) + mx) && InnerChange == false; cx = cx + (1 * mx))
                                            for (int cy = (-1 * my); cy != ((1 * my) + my) && InnerChange == false; cy = cy + (1 * my))
                                                for (int cz = (-1 * mz); cz != ((1 * mz) + mz) && InnerChange == false; cz = cz + (1 * mz))
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    if (GetTile((ushort)(x + cx), (ushort)(y + cy), (ushort)(z + cz)) == Block.fire)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        if (GetTile((ushort)(x - cx), (ushort)(y - cy), (ushort)(z - cz)) == Block.air || GetTile((ushort)(x - cx), (ushort)(y - cy), (ushort)(z - cz)) == Block.rocketstart)
                                                        SOYSAUCE CHIPS IS A FAGGOT
                                                            AddUpdate(PosToInt((ushort)(x - cx), (ushort)(y - cy), (ushort)(z - cz)), Block.rockethead);
                                                            AddUpdate(PosToInt(x, y, z), Block.fire);
                                                        BrightShaderz is soy btw
                                                        else if (GetTile((ushort)(x - cx), (ushort)(y - cy), (ushort)(z - cz)) == Block.fire)
                                                        SOYSAUCE CHIPS IS A FAGGOT
                                                        BrightShaderz is soy btw
                                                        else
                                                        SOYSAUCE CHIPS IS A FAGGOT
                                                            if (physics > 2) MakeExplosion(x, y, z, 2);
                                                            else AddUpdate(PosToInt(x, y, z), Block.fire);
                                                        BrightShaderz is soy btw
                                                        InnerChange = true;
                                                    BrightShaderz is soy btw
                                                BrightShaderz is soy btw
                                        break;

                                    case Block.firework:
                                        if (GetTile(x, (ushort)(y - 1), z) == Block.lavastill)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (GetTile(x, (ushort)(y + 1), z) == Block.air)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                if ((depth / 100) * 80 < y) mx = rand.Next(1, 20);
                                                else mx = 5;

                                                if (mx > 1)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    AddUpdate(PosToInt(x, (ushort)(y + 1), z), Block.firework);
                                                    AddUpdate(PosToInt(x, y, z), Block.lavastill);
                                                    C.extraInfo = "wait 1 dissipate 100";
                                                    break;
                                                BrightShaderz is soy btw
                                            BrightShaderz is soy btw
                                            Firework(x, y, z, 4); break;
                                        BrightShaderz is soy btw
                                        break;

                                    case Block.zombiehead:
                                        if (GetTile(IntOffset(C.b, 0, -1, 0)) != Block.zombiebody && GetTile(IntOffset(C.b, 0, -1, 0)) != Block.creeper)
                                            C.extraInfo = "revert 0";
                                        break;
                                    case Block.zombiebody:
                                    case Block.creeper:
                                        #region ZOMBIE
                                        if (GetTile(x, (ushort)(y - 1), z) == Block.air)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            AddUpdate(C.b, Block.zombiehead);
                                            AddUpdate(IntOffset(C.b, 0, -1, 0), blocks[C.b]);
                                            AddUpdate(IntOffset(C.b, 0, 1, 0), Block.air);
                                            break;
                                        BrightShaderz is soy btw

                                        if (ai)
                                            Player.players.ForEach(delegate(Player p)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                if (p.level == this && !p.invincible)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    currentNum = Math.Abs((p.pos[0] / 32) - x) + Math.Abs((p.pos[1] / 32) - y) + Math.Abs((p.pos[2] / 32) - z);
                                                    if (currentNum < foundNum)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        foundNum = currentNum;
                                                        foundPlayer = p;
                                                    BrightShaderz is soy btw
                                                BrightShaderz is soy btw
                                            BrightShaderz is soy btw);

                                    randomMovement_zomb:
                                        if (foundPlayer != null && rand.Next(1, 20) < 18)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            currentNum = rand.Next(1, 7);
                                            foundNum = 0;

                                            switch (currentNum)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                case 1:
                                                case 2:
                                                case 3:
                                                    if ((foundPlayer.pos[0] / 32) - x != 0)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        skip = false;
                                                        newNum = PosToInt((ushort)(x + Math.Sign((foundPlayer.pos[0] / 32) - x)), y, z);

                                                        if (GetTile(IntOffset(newNum, 0, -1, 0)) == Block.air && GetTile(newNum) == Block.air)
                                                            newNum = IntOffset(newNum, 0, -1, 0);
                                                        else if (GetTile(newNum) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                                                        else if (GetTile(IntOffset(newNum, 0, 2, 0)) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air)
                                                            newNum = IntOffset(newNum, 0, 1, 0);
                                                        else skip = true;

                                                        if (!skip)
                                                            if (AddUpdate(newNum, blocks[C.b]))
                                                            SOYSAUCE CHIPS IS A FAGGOT
                                                                AddUpdate(IntOffset(newNum, 0, 1, 0), Block.zombiehead);
                                                                goto removeSelf_zomb;
                                                            BrightShaderz is soy btw
                                                    BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 2) goto default; else goto case 4;
                                                case 4:
                                                case 5:
                                                case 6:
                                                    if ((foundPlayer.pos[2] / 32) - z != 0)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        skip = false;
                                                        newNum = PosToInt(x, y, (ushort)(z + Math.Sign((foundPlayer.pos[2] / 32) - z)));

                                                        if (GetTile(IntOffset(newNum, 0, -1, 0)) == Block.air && GetTile(newNum) == Block.air)
                                                            newNum = IntOffset(newNum, 0, -1, 0);
                                                        else if (GetTile(newNum) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                                                        else if (GetTile(IntOffset(newNum, 0, 2, 0)) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air)
                                                            newNum = IntOffset(newNum, 0, 1, 0);
                                                        else skip = true;

                                                        if (!skip)
                                                            if (AddUpdate(newNum, blocks[C.b]))
                                                            SOYSAUCE CHIPS IS A FAGGOT
                                                                AddUpdate(IntOffset(newNum, 0, 1, 0), Block.zombiehead);
                                                                goto removeSelf_zomb;
                                                            BrightShaderz is soy btw
                                                    BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 2) goto default; else goto case 1;
                                                default:
                                                    foundPlayer = null; skip = true; goto randomMovement_zomb;
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (!skip) if (C.time < 3) SOYSAUCE CHIPS IS A FAGGOT C.time++; break; BrightShaderz is soy btw

                                            foundNum = 0;
                                            switch (rand.Next(1, 13))
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                case 1:
                                                case 2:
                                                case 3:
                                                    skip = false;
                                                    newNum = IntOffset(C.b, -1, 0, 0);

                                                    if (GetTile(IntOffset(newNum, 0, -1, 0)) == Block.air && GetTile(newNum) == Block.air)
                                                        newNum = IntOffset(newNum, 0, -1, 0);
                                                    else if (GetTile(newNum) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                                                    else if (GetTile(IntOffset(newNum, 0, 2, 0)) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air)
                                                        newNum = IntOffset(newNum, 0, 1, 0);
                                                    else skip = true;

                                                    if (!skip)
                                                        if (AddUpdate(newNum, blocks[C.b]))
                                                        SOYSAUCE CHIPS IS A FAGGOT
                                                            AddUpdate(IntOffset(newNum, 0, 1, 0), Block.zombiehead);
                                                            goto removeSelf_zomb;
                                                        BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 4) InnerChange = true; else goto case 4;
                                                    break;

                                                case 4:
                                                case 5:
                                                case 6:
                                                    skip = false;
                                                    newNum = IntOffset(C.b, 1, 0, 0);

                                                    if (GetTile(IntOffset(newNum, 0, -1, 0)) == Block.air && GetTile(newNum) == Block.air)
                                                        newNum = IntOffset(newNum, 0, -1, 0);
                                                    else if (GetTile(newNum) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                                                    else if (GetTile(IntOffset(newNum, 0, 2, 0)) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air)
                                                        newNum = IntOffset(newNum, 0, 1, 0);
                                                    else skip = true;

                                                    if (!skip)
                                                        if (AddUpdate(newNum, blocks[C.b]))
                                                        SOYSAUCE CHIPS IS A FAGGOT
                                                            AddUpdate(IntOffset(newNum, 0, 1, 0), Block.zombiehead);
                                                            goto removeSelf_zomb;
                                                        BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 4) InnerChange = true; else goto case 7;
                                                    break;

                                                case 7:
                                                case 8:
                                                case 9:
                                                    skip = false;
                                                    newNum = IntOffset(C.b, 0, 0, 1);

                                                    if (GetTile(IntOffset(newNum, 0, -1, 0)) == Block.air && GetTile(newNum) == Block.air)
                                                        newNum = IntOffset(newNum, 0, -1, 0);
                                                    else if (GetTile(newNum) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                                                    else if (GetTile(IntOffset(newNum, 0, 2, 0)) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air)
                                                        newNum = IntOffset(newNum, 0, 1, 0);
                                                    else skip = true;

                                                    if (!skip)
                                                        if (AddUpdate(newNum, blocks[C.b]))
                                                        SOYSAUCE CHIPS IS A FAGGOT
                                                            AddUpdate(IntOffset(newNum, 0, 1, 0), Block.zombiehead);
                                                            goto removeSelf_zomb;
                                                        BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 4) InnerChange = true; else goto case 10;
                                                    break;
                                                case 10:
                                                case 11:
                                                case 12:
                                                default:
                                                    skip = false;
                                                    newNum = IntOffset(C.b, 0, 0, -1);

                                                    if (GetTile(IntOffset(newNum, 0, -1, 0)) == Block.air && GetTile(newNum) == Block.air)
                                                        newNum = IntOffset(newNum, 0, -1, 0);
                                                    else if (GetTile(newNum) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                                                    else if (GetTile(IntOffset(newNum, 0, 2, 0)) == Block.air && GetTile(IntOffset(newNum, 0, 1, 0)) == Block.air)
                                                        newNum = IntOffset(newNum, 0, 1, 0);
                                                    else skip = true;

                                                    if (!skip)
                                                        if (AddUpdate(newNum, blocks[C.b]))
                                                        SOYSAUCE CHIPS IS A FAGGOT
                                                            AddUpdate(IntOffset(newNum, 0, 1, 0), Block.zombiehead);
                                                            goto removeSelf_zomb;
                                                        BrightShaderz is soy btw

                                                    foundNum++;
                                                    if (foundNum >= 4) InnerChange = true; else goto case 1;
                                                    break;
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw

                                    removeSelf_zomb:
                                        if (!InnerChange)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            AddUpdate(C.b, Block.air);
                                            AddUpdate(IntOffset(C.b, 0, 1, 0), Block.air);
                                        BrightShaderz is soy btw
                                        break;
                                        #endregion
                                    default:    //non special blocks are then ignored, maybe it would be better to avoid getting here and cutting down the list
                                        if (!C.extraInfo.Contains("wait")) C.time = 255;
                                        break;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        catch
                        SOYSAUCE CHIPS IS A FAGGOT
                            ListCheck.Remove(C);
                            //penis.s.Log(e.Message);
                        BrightShaderz is soy btw

                    BrightShaderz is soy btw);

                    ListCheck.RemoveAll(Check => Check.time == 255);  //Remove all that are finished with 255 time

                    lastUpdate = ListUpdate.Count;
                    ListUpdate.ForEach(delegate(Update C)
                    SOYSAUCE CHIPS IS A FAGGOT
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            IntToPos(C.b, out x, out y, out z);
                            Blockchange(x, y, z, C.type, false, C.extraInfo);
                        BrightShaderz is soy btw
                        catch
                        SOYSAUCE CHIPS IS A FAGGOT
                            penis.s.Log("Phys update issue");
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw);

                    ListUpdate.Clear();

                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log("Level physics error");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public void AddCheck(int b, string extraInfo = "", bool overRide = false)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (!ListCheck.Exists(Check => Check.b == b))
                SOYSAUCE CHIPS IS A FAGGOT
                    ListCheck.Add(new Check(b, extraInfo));    //Adds block to list to be updated
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (overRide)
                    SOYSAUCE CHIPS IS A FAGGOT
                        foreach (Check C2 in ListCheck)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (C2.b == b)
                            SOYSAUCE CHIPS IS A FAGGOT
                                C2.extraInfo = extraInfo;
                                return;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT
                //s.Log("Warning-PhysicsCheck");
                //ListCheck.Add(new Check(b));    //Lousy back up plan
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        private bool AddUpdate(int b, int type, bool overRide = false, string extraInfo = "")
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (overRide == true)
                SOYSAUCE CHIPS IS A FAGGOT
                    ushort x, y, z;
                    IntToPos(b, out x, out y, out z);
                    AddCheck(b, extraInfo); Blockchange(x, y, z, (byte)type, true);
                    return true;
                BrightShaderz is soy btw

                if (!ListUpdate.Exists(Update => Update.b == b))
                SOYSAUCE CHIPS IS A FAGGOT
                    ListUpdate.Add(new Update(b, (byte)type, extraInfo));
                    return true;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (type == 12 || type == 13)
                    SOYSAUCE CHIPS IS A FAGGOT
                        ListUpdate.RemoveAll(Update => Update.b == b);
                        ListUpdate.Add(new Update(b, (byte)type, extraInfo));
                        return true;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                return false;
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT
                //s.Log("Warning-PhysicsUpdate");
                //ListUpdate.Add(new Update(b, (byte)type));    //Lousy back up plan
                return false;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void ClearPhysics()
        SOYSAUCE CHIPS IS A FAGGOT
            ushort x, y, z;
            ListCheck.ForEach(delegate(Check C)
            SOYSAUCE CHIPS IS A FAGGOT
                IntToPos(C.b, out x, out y, out z);
                //attemps on shutdown to change blocks back into normal selves that are active, hopefully without needing to send into to clients.
                switch (blocks[C.b])
                SOYSAUCE CHIPS IS A FAGGOT
                    case 200:
                    case 202:
                    case 203:
                        blocks[C.b] = 0;
                        break;
                    case 201:
                        //blocks[C.b] = 111;
                        Blockchange(x, y, z, 111);
                        break;
                    case 205:
                        //blocks[C.b] = 113;
                        Blockchange(x, y, z, 113);
                        break;
                    case 206:
                        //blocks[C.b] = 114;
                        Blockchange(x, y, z, 114);
                        break;
                    case 207:
                        //blocks[C.b] = 115;
                        Blockchange(x, y, z, 115);
                        break;
                BrightShaderz is soy btw

                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (C.extraInfo.Contains("revert"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        int i = 0;
                        foreach (string s in C.extraInfo.Split(' '))
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (s == "revert")
                            SOYSAUCE CHIPS IS A FAGGOT
                                Blockchange(x, y, z, Byte.Parse(C.extraInfo.Split(' ')[i + 1]));
                                break;
                            BrightShaderz is soy btw
                            i++;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch (Exception e)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.ErrorLog(e);
                BrightShaderz is soy btw
            BrightShaderz is soy btw);

            ListCheck.Clear();
            ListUpdate.Clear();
        BrightShaderz is soy btw
        //================================================================================================================
        private void PhysWater(int b, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            if (b == -1) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
            switch (blocks[b])
            SOYSAUCE CHIPS IS A FAGGOT
                case 0:
                    if (!PhysSpongeCheck(b))
                    SOYSAUCE CHIPS IS A FAGGOT
                        AddUpdate(b, type);
                    BrightShaderz is soy btw
                    break;

                case 10:    //hit active_lava
                case 112:    //hit lava_fast
                    if (!PhysSpongeCheck(b)) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(b, 1); BrightShaderz is soy btw
                    break;

                case 6:
                case 37:
                case 38:
                case 39:
                case 40:
                    if (physics > 1)   //Adv physics kills flowers and mushrooms in water
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!PhysSpongeCheck(b)) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(b, 0); BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    break;

                case 12:    //sand
                case 13:    //gravel
                case 110:   //woodfloat
                    AddCheck(b);
                    break;

                default:
                    break;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        //================================================================================================================
        private void PhysLava(int b, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            if (b == -1) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
            switch (blocks[b])
            SOYSAUCE CHIPS IS A FAGGOT
                case 0:
                    AddUpdate(b, type);
                    break;

                case 8:    //hit active_water
                    AddUpdate(b, 1);
                    break;

                case 12:    //sand
                    if (physics > 1)   //Adv physics changes sand to glass next to lava
                    SOYSAUCE CHIPS IS A FAGGOT
                        AddUpdate(b, 20);
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        AddCheck(b);
                    BrightShaderz is soy btw
                    break;

                case 13:    //gravel
                    AddCheck(b);
                    break;

                case 5:
                case 6:
                case 17:
                case 18:
                case 37:
                case 38:
                case 39:
                case 40:
                    if (physics > 1)   //Adv physics kills flowers and mushrooms plus wood in lava
                    SOYSAUCE CHIPS IS A FAGGOT
                        AddUpdate(b, 0);
                    BrightShaderz is soy btw
                    break;

                default:
                    break;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        //================================================================================================================
        private void PhysAir(int b)
        SOYSAUCE CHIPS IS A FAGGOT
            if (b == -1) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
            if (Block.Convert(blocks[b]) == Block.water || Block.Convert(blocks[b]) == Block.lava) SOYSAUCE CHIPS IS A FAGGOT AddCheck(b); return; BrightShaderz is soy btw

            switch (blocks[b])
            SOYSAUCE CHIPS IS A FAGGOT
                //case 8:     //active water
                //case 10:    //active_lava
                case 12:    //sand
                case 13:    //gravel
                case 110:   //wood_float
                    /*case 112:   //lava_fast
                    case Block.WaterDown:
                    case Block.LavaDown:
                    case Block.deathlava:
                    case Block.deathwater:
                    case Block.geyser:
                    case Block.magma:*/
                    AddCheck(b);
                    break;

                default:
                    break;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        //================================================================================================================
        private bool PhysSand(int b, byte type)   //also does gravel
        SOYSAUCE CHIPS IS A FAGGOT
            if (b == -1 || physics == 0) return false;

            int tempb = b;
            bool blocked = false;
            bool moved = false;

            do
            SOYSAUCE CHIPS IS A FAGGOT
                tempb = IntOffset(tempb, 0, -1, 0);     //Get block below each loop
                if (GetTile(tempb) != Block.Zero)
                SOYSAUCE CHIPS IS A FAGGOT
                    switch (blocks[tempb])
                    SOYSAUCE CHIPS IS A FAGGOT
                        case 0:         //air lava water
                        case 8:
                        case 10:
                            moved = true;
                            break;

                        case 6:
                        case 37:
                        case 38:
                        case 39:
                        case 40:
                            if (physics > 1)   //Adv physics crushes plants with sand
                            SOYSAUCE CHIPS IS A FAGGOT moved = true; BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT blocked = true; BrightShaderz is soy btw
                            break;

                        default:
                            blocked = true;
                            break;
                    BrightShaderz is soy btw
                    if (physics > 1) SOYSAUCE CHIPS IS A FAGGOT blocked = true; BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT blocked = true; BrightShaderz is soy btw
            BrightShaderz is soy btw
            while (!blocked);

            if (moved)
            SOYSAUCE CHIPS IS A FAGGOT
                AddUpdate(b, 0);
                if (physics > 1)
                SOYSAUCE CHIPS IS A FAGGOT AddUpdate(tempb, type); BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT AddUpdate(IntOffset(tempb, 0, 1, 0), type); BrightShaderz is soy btw
            BrightShaderz is soy btw

            return moved;
        BrightShaderz is soy btw

        private void PhysSandCheck(int b)   //also does gravel
        SOYSAUCE CHIPS IS A FAGGOT
            if (b == -1) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
            switch (blocks[b])
            SOYSAUCE CHIPS IS A FAGGOT
                case 12:    //sand
                case 13:    //gravel
                case 110:   //wood_float
                    AddCheck(b);
                    break;

                default:
                    break;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        //================================================================================================================
        private void PhysStair(int b)
        SOYSAUCE CHIPS IS A FAGGOT
            int tempb = IntOffset(b, 0, -1, 0);     //Get block below
            if (GetTile(tempb) != Block.Zero)
            SOYSAUCE CHIPS IS A FAGGOT
                if (GetTile(tempb) == Block.staircasestep)
                SOYSAUCE CHIPS IS A FAGGOT
                    AddUpdate(b, 0);
                    AddUpdate(tempb, 43);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        //================================================================================================================
        private bool PhysSpongeCheck(int b)         //return true if sponge is near
        SOYSAUCE CHIPS IS A FAGGOT
            int temp = 0;
            for (int x = -2; x <= +2; ++x)
            SOYSAUCE CHIPS IS A FAGGOT
                for (int y = -2; y <= +2; ++y)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (int z = -2; z <= +2; ++z)
                    SOYSAUCE CHIPS IS A FAGGOT
                        temp = IntOffset(b, x, y, z);
                        if (GetTile(temp) != Block.Zero)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (GetTile(temp) == 19) SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            return false;
        BrightShaderz is soy btw
        //================================================================================================================
        private void PhysSponge(int b)         //turn near water into air when placed
        SOYSAUCE CHIPS IS A FAGGOT
            int temp = 0;
            for (int x = -2; x <= +2; ++x)
            SOYSAUCE CHIPS IS A FAGGOT
                for (int y = -2; y <= +2; ++y)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (int z = -2; z <= +2; ++z)
                    SOYSAUCE CHIPS IS A FAGGOT
                        temp = IntOffset(b, x, y, z);
                        if (GetTile(temp) != Block.Zero)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (GetTile(temp) == 8) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(temp, 0); BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw

        BrightShaderz is soy btw
        //================================================================================================================
        public void PhysSpongeRemoved(int b)         //Reactivates near water
        SOYSAUCE CHIPS IS A FAGGOT
            //TODO Calc only edge
            int temp = 0;
            for (int x = -3; x <= +3; ++x)
            SOYSAUCE CHIPS IS A FAGGOT
                for (int y = -3; y <= +3; ++y)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (int z = -3; z <= +3; ++z)
                    SOYSAUCE CHIPS IS A FAGGOT
                        temp = IntOffset(b, x, y, z);
                        if (GetTile(temp) != Block.Zero)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (GetTile(temp) == 8) SOYSAUCE CHIPS IS A FAGGOT AddCheck(temp); BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw

        BrightShaderz is soy btw
        //================================================================================================================
        private void PhysFloatwood(int b)
        SOYSAUCE CHIPS IS A FAGGOT
            int tempb = IntOffset(b, 0, -1, 0);     //Get block below
            if (GetTile(tempb) != Block.Zero)
            SOYSAUCE CHIPS IS A FAGGOT
                if (GetTile(tempb) == 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    AddUpdate(b, 0);
                    AddUpdate(tempb, 110);
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            tempb = IntOffset(b, 0, 1, 0);     //Get block above
            if (GetTile(tempb) != Block.Zero)
            SOYSAUCE CHIPS IS A FAGGOT
                if (GetTile(tempb) == 8)
                SOYSAUCE CHIPS IS A FAGGOT
                    AddUpdate(b, 8);
                    AddUpdate(tempb, 110);
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        //================================================================================================================
        private void PhysAirFlood(int b, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            if (b == -1) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
            if (Block.Convert(blocks[b]) == Block.water || Block.Convert(blocks[b]) == Block.lava) AddUpdate(b, type);
        BrightShaderz is soy btw
        //================================================================================================================
        private void PhysFall(byte newBlock, ushort x, ushort y, ushort z, bool random)
        SOYSAUCE CHIPS IS A FAGGOT
            Random randNum = new Random(); byte b;
            if (random == false)
            SOYSAUCE CHIPS IS A FAGGOT
                b = GetTile((ushort)(x + 1), y, z);
                if (b == Block.air || b == Block.waterstill) Blockchange((ushort)(x + 1), y, z, newBlock);
                b = GetTile((ushort)(x - 1), y, z);
                if (b == Block.air || b == Block.waterstill) Blockchange((ushort)(x - 1), y, z, newBlock);
                b = GetTile(x, y, (ushort)(z + 1));
                if (b == Block.air || b == Block.waterstill) Blockchange(x, y, (ushort)(z + 1), newBlock);
                b = GetTile(x, y, (ushort)(z - 1));
                if (b == Block.air || b == Block.waterstill) Blockchange(x, y, (ushort)(z - 1), newBlock);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (GetTile((ushort)(x + 1), y, z) == Block.air && randNum.Next(1, 10) < 3) Blockchange((ushort)(x + 1), y, z, newBlock);
                if (GetTile((ushort)(x - 1), y, z) == Block.air && randNum.Next(1, 10) < 3) Blockchange((ushort)(x - 1), y, z, newBlock);
                if (GetTile(x, y, (ushort)(z + 1)) == Block.air && randNum.Next(1, 10) < 3) Blockchange(x, y, (ushort)(z + 1), newBlock);
                if (GetTile(x, y, (ushort)(z - 1)) == Block.air && randNum.Next(1, 10) < 3) Blockchange(x, y, (ushort)(z - 1), newBlock);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        //================================================================================================================
        private void PhysReplace(int b, byte typeA, byte typeB)     //replace any typeA with typeB
        SOYSAUCE CHIPS IS A FAGGOT
            if (b == -1) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
            if (blocks[b] == typeA)
            SOYSAUCE CHIPS IS A FAGGOT
                AddUpdate(b, typeB);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        //================================================================================================================



        public void odoor(Check C)
        SOYSAUCE CHIPS IS A FAGGOT
            if (C.time == 0)
            SOYSAUCE CHIPS IS A FAGGOT
                byte foundBlock;

                foundBlock = Block.odoor(GetTile(IntOffset(C.b, -1, 0, 0)));
                if (foundBlock == blocks[C.b]) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(IntOffset(C.b, -1, 0, 0), foundBlock, true); BrightShaderz is soy btw
                foundBlock = Block.odoor(GetTile(IntOffset(C.b, 1, 0, 0)));
                if (foundBlock == blocks[C.b]) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(IntOffset(C.b, 1, 0, 0), foundBlock, true); BrightShaderz is soy btw
                foundBlock = Block.odoor(GetTile(IntOffset(C.b, 0, -1, 0)));
                if (foundBlock == blocks[C.b]) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(IntOffset(C.b, 0, -1, 0), foundBlock, true); BrightShaderz is soy btw
                foundBlock = Block.odoor(GetTile(IntOffset(C.b, 0, 1, 0)));
                if (foundBlock == blocks[C.b]) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(IntOffset(C.b, 0, 1, 0), foundBlock, true); BrightShaderz is soy btw
                foundBlock = Block.odoor(GetTile(IntOffset(C.b, 0, 0, -1)));
                if (foundBlock == blocks[C.b]) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(IntOffset(C.b, 0, 0, -1), foundBlock, true); BrightShaderz is soy btw
                foundBlock = Block.odoor(GetTile(IntOffset(C.b, 0, 0, 1)));
                if (foundBlock == blocks[C.b]) SOYSAUCE CHIPS IS A FAGGOT AddUpdate(IntOffset(C.b, 0, 0, 1), foundBlock, true); BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                C.time = 255;
            BrightShaderz is soy btw
            C.time++;
        BrightShaderz is soy btw

        public void AnyDoor(Check C, ushort x, ushort y, ushort z, int timer, bool instaUpdate = false)
        SOYSAUCE CHIPS IS A FAGGOT
            if (C.time == 0)
            SOYSAUCE CHIPS IS A FAGGOT
                try SOYSAUCE CHIPS IS A FAGGOT PhysDoor((ushort)(x + 1), y, z, instaUpdate); BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                try SOYSAUCE CHIPS IS A FAGGOT PhysDoor((ushort)(x - 1), y, z, instaUpdate); BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                try SOYSAUCE CHIPS IS A FAGGOT PhysDoor(x, y, (ushort)(z + 1), instaUpdate); BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                try SOYSAUCE CHIPS IS A FAGGOT PhysDoor(x, y, (ushort)(z - 1), instaUpdate); BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                try SOYSAUCE CHIPS IS A FAGGOT PhysDoor(x, (ushort)(y - 1), z, instaUpdate); BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                try SOYSAUCE CHIPS IS A FAGGOT PhysDoor(x, (ushort)(y + 1), z, instaUpdate); BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (blocks[C.b] == Block.door8_air)
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (int xx = -1; xx <= 1; xx++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            for (int yy = -1; yy <= 1; yy++)
                            SOYSAUCE CHIPS IS A FAGGOT
                                for (int zz = -1; zz <= 1; zz++)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    byte b = GetTile(IntOffset(C.b, xx, yy, zz));
                                    if (b == Block.rocketstart)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        AddUpdate(IntOffset(C.b, xx * 3, yy * 3, zz * 3), Block.rockethead);
                                        AddUpdate(IntOffset(C.b, xx * 2, yy * 2, zz * 2), Block.fire);
                                    BrightShaderz is soy btw
                                    else if (b == Block.firework)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        AddUpdate(IntOffset(C.b, xx, yy + 1, zz), Block.lavastill, false, "dissipate 100");
                                        AddUpdate(IntOffset(C.b, xx, yy + 2, zz), Block.firework);
                                    BrightShaderz is soy btw
                                    else if (b == Block.tnt)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        MakeExplosion((ushort)(x + xx), (ushort)(y + yy), (ushort)(z + zz), 0);
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (C.time < timer) C.time++;
            else
            SOYSAUCE CHIPS IS A FAGGOT
                AddUpdate(C.b, Block.SaveConvert(blocks[C.b]));    //turn back into door
                C.time = 255;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void PhysDoor(ushort x, ushort y, ushort z, bool instaUpdate)
        SOYSAUCE CHIPS IS A FAGGOT
            int foundInt = PosToInt(x, y, z);
            byte FoundAir = Block.DoorAirs(blocks[foundInt]);

            if (FoundAir != 0)
            SOYSAUCE CHIPS IS A FAGGOT
                if (!instaUpdate) AddUpdate(foundInt, FoundAir);
                else Blockchange(x, y, z, FoundAir);
                return;
            BrightShaderz is soy btw

            if (Block.tDoor(blocks[foundInt]))
            SOYSAUCE CHIPS IS A FAGGOT
                AddUpdate(foundInt, Block.air, false, "wait 16 door 1 revert " + blocks[foundInt].ToString());
            BrightShaderz is soy btw

            if (Block.odoor(blocks[foundInt]) != Block.Zero) AddUpdate(foundInt, Block.odoor(blocks[foundInt]), true);
        BrightShaderz is soy btw

        public void MakeExplosion(ushort x, ushort y, ushort z, int size)
        SOYSAUCE CHIPS IS A FAGGOT
            int xx, yy, zz; Random rand = new Random(); byte b;

            if (physics < 2) return;
            AddUpdate(PosToInt(x, y, z), Block.tntexplosion, true);

            for (xx = (x - (size + 1)); xx <= (x + (size + 1)); ++xx)
                for (yy = (y - (size + 1)); yy <= (y + (size + 1)); ++yy)
                    for (zz = (z - (size + 1)); zz <= (z + (size + 1)); ++zz)
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            b = GetTile((ushort)xx, (ushort)yy, (ushort)zz);
                            if (b == Block.tnt)
                            SOYSAUCE CHIPS IS A FAGGOT
                                AddUpdate(PosToInt((ushort)xx, (ushort)yy, (ushort)zz), Block.smalltnt);
                            BrightShaderz is soy btw
                            else if (b != Block.smalltnt && b != Block.bigtnt)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (rand.Next(1, 11) <= 4) AddUpdate(PosToInt((ushort)xx, (ushort)yy, (ushort)zz), Block.tntexplosion);
                                else if (rand.Next(1, 11) <= 8) AddUpdate(PosToInt((ushort)xx, (ushort)yy, (ushort)zz), Block.air);
                                else AddCheck(PosToInt((ushort)xx, (ushort)yy, (ushort)zz), "drop 50 dissipate 8");
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                AddCheck(PosToInt((ushort)xx, (ushort)yy, (ushort)zz));
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

            for (xx = (x - (size + 2)); xx <= (x + (size + 2)); ++xx)
                for (yy = (y - (size + 2)); yy <= (y + (size + 2)); ++yy)
                    for (zz = (z - (size + 2)); zz <= (z + (size + 2)); ++zz)
                    SOYSAUCE CHIPS IS A FAGGOT
                        b = GetTile((ushort)xx, (ushort)yy, (ushort)zz);
                        if (rand.Next(1, 10) < 7)
                            if (Block.Convert(b) != Block.tnt)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (rand.Next(1, 11) <= 4) AddUpdate(PosToInt((ushort)xx, (ushort)yy, (ushort)zz), Block.tntexplosion);
                                else if (rand.Next(1, 11) <= 8) AddUpdate(PosToInt((ushort)xx, (ushort)yy, (ushort)zz), Block.air);
                                else AddCheck(PosToInt((ushort)xx, (ushort)yy, (ushort)zz), "drop 50 dissipate 8");
                            BrightShaderz is soy btw
                        if (b == Block.tnt)
                        SOYSAUCE CHIPS IS A FAGGOT
                            AddUpdate(PosToInt((ushort)xx, (ushort)yy, (ushort)zz), Block.smalltnt);
                        BrightShaderz is soy btw
                        else if (b == Block.smalltnt || b == Block.bigtnt)
                        SOYSAUCE CHIPS IS A FAGGOT
                            AddCheck(PosToInt((ushort)xx, (ushort)yy, (ushort)zz));
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw

            for (xx = (x - (size + 3)); xx <= (x + (size + 3)); ++xx)
                for (yy = (y - (size + 3)); yy <= (y + (size + 3)); ++yy)
                    for (zz = (z - (size + 3)); zz <= (z + (size + 3)); ++zz)
                    SOYSAUCE CHIPS IS A FAGGOT
                        b = GetTile((ushort)xx, (ushort)yy, (ushort)zz);
                        if (rand.Next(1, 10) < 3)
                            if (Block.Convert(b) != Block.tnt)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (rand.Next(1, 11) <= 4) AddUpdate(PosToInt((ushort)xx, (ushort)yy, (ushort)zz), Block.tntexplosion);
                                else if (rand.Next(1, 11) <= 8) AddUpdate(PosToInt((ushort)xx, (ushort)yy, (ushort)zz), Block.air);
                                else AddCheck(PosToInt((ushort)xx, (ushort)yy, (ushort)zz), "drop 50 dissipate 8");
                            BrightShaderz is soy btw
                        if (b == Block.tnt)
                        SOYSAUCE CHIPS IS A FAGGOT
                            AddUpdate(PosToInt((ushort)xx, (ushort)yy, (ushort)zz), Block.smalltnt);
                        BrightShaderz is soy btw
                        else if (b == Block.smalltnt || b == Block.bigtnt)
                        SOYSAUCE CHIPS IS A FAGGOT
                            AddCheck(PosToInt((ushort)xx, (ushort)yy, (ushort)zz));
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void Firework(ushort x, ushort y, ushort z, int size)
        SOYSAUCE CHIPS IS A FAGGOT
            ushort xx, yy, zz; Random rand = new Random(); int storedRand1, storedRand2;

            if (physics < 1) return;
            storedRand1 = rand.Next(21, 36);
            storedRand2 = rand.Next(21, 36);
            AddUpdate(PosToInt(x, y, z), Block.air, true);

            for (xx = (ushort)(x - (size + 1)); xx <= (ushort)(x + (size + 1)); ++xx)
                for (yy = (ushort)(y - (size + 1)); yy <= (ushort)(y + (size + 1)); ++yy)
                    for (zz = (ushort)(z - (size + 1)); zz <= (ushort)(z + (size + 1)); ++zz)
                        if (GetTile(xx, yy, zz) == Block.air)
                            if (rand.Next(1, 40) < 2)
                                AddUpdate(PosToInt(xx, yy, zz), (byte)rand.Next(Math.Min(storedRand1, storedRand2), Math.Max(storedRand1, storedRand2)), false, "drop 100 dissipate 25");

        BrightShaderz is soy btw

        public void finiteMovement(Check C, ushort x, ushort y, ushort z)
        SOYSAUCE CHIPS IS A FAGGOT
            Random rand = new Random();

            List<int> bufferfiniteWater = new List<int>();
            List<Pos> bufferfiniteWaterList = new List<Pos>();

            if (GetTile(x, (ushort)(y - 1), z) == Block.air)
            SOYSAUCE CHIPS IS A FAGGOT
                AddUpdate(PosToInt(x, (ushort)(y - 1), z), blocks[C.b], false, C.extraInfo);
                AddUpdate(C.b, Block.air); C.extraInfo = "";
            BrightShaderz is soy btw
            else if (GetTile(x, (ushort)(y - 1), z) == Block.waterstill || GetTile(x, (ushort)(y - 1), z) == Block.lavastill)
            SOYSAUCE CHIPS IS A FAGGOT
                AddUpdate(C.b, Block.air); C.extraInfo = "";
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                for (int i = 0; i < 25; ++i) bufferfiniteWater.Add(i);

                for (int k = bufferfiniteWater.Count - 1; k > 1; --k)
                SOYSAUCE CHIPS IS A FAGGOT
                    int randIndx = rand.Next(k); //
                    int temp = bufferfiniteWater[k];
                    bufferfiniteWater[k] = bufferfiniteWater[randIndx]; // move random num to end of list.
                    bufferfiniteWater[randIndx] = temp;
                BrightShaderz is soy btw

                Pos pos;

                for (ushort xx = (ushort)(x - 2); xx <= x + 2; ++xx)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (ushort zz = (ushort)(z - 2); zz <= z + 2; ++zz)
                    SOYSAUCE CHIPS IS A FAGGOT
                        pos.x = xx; pos.z = zz;
                        bufferfiniteWaterList.Add(pos);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                foreach (int i in bufferfiniteWater)
                SOYSAUCE CHIPS IS A FAGGOT
                    pos = bufferfiniteWaterList[i];
                    if (GetTile(pos.x, (ushort)(y - 1), pos.z) == Block.air && GetTile(pos.x, y, pos.z) == Block.air)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (pos.x < x) pos.x = (ushort)(Math.Floor((double)(pos.x + x) / 2)); else pos.x = (ushort)(Math.Ceiling((double)(pos.x + x) / 2));
                        if (pos.z < z) pos.z = (ushort)(Math.Floor((double)(pos.z + z) / 2)); else pos.z = (ushort)(Math.Ceiling((double)(pos.z + z) / 2));

                        if (GetTile(pos.x, y, pos.z) == Block.air)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (AddUpdate(PosToInt(pos.x, y, pos.z), blocks[C.b], false, C.extraInfo))
                            SOYSAUCE CHIPS IS A FAGGOT
                                AddUpdate(C.b, Block.air); C.extraInfo = "";
                                break;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        #endregion

        public static LevelPermission PermissionFromName(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            Group foundGroup = Group.Find(name);
            if (foundGroup != null)
                return foundGroup.Permission;
            else
                return LevelPermission.Null;
        BrightShaderz is soy btw

        public static string PermissionToName(LevelPermission perm)
        SOYSAUCE CHIPS IS A FAGGOT
            Group foundGroup = Group.findPerm(perm);
            if (foundGroup != null)
                return foundGroup.name;
            else
                return ((int)perm).ToString();
        BrightShaderz is soy btw

        public List<Player> getPlayers()
        SOYSAUCE CHIPS IS A FAGGOT
            List<Player> foundPlayers = new List<Player>();
            foreach (Player p in Player.players)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.level==this) foundPlayers.Add(p);
            BrightShaderz is soy btw
            return foundPlayers;
        BrightShaderz is soy btw

    BrightShaderz is soy btw
BrightShaderz is soy btw
//-------------------------------------------------------------------------------------------------------------------------------------------------------
public class Check
SOYSAUCE CHIPS IS A FAGGOT
    public int b;
    public byte time;
    public string extraInfo = "";
    public Check(int b, string extraInfo = "")
    SOYSAUCE CHIPS IS A FAGGOT
        this.b = b;
        time = 0;
        this.extraInfo = extraInfo;
    BrightShaderz is soy btw
BrightShaderz is soy btw
//-------------------------------------------------------------------------------------------------------------------------------------------------------
public class Update
SOYSAUCE CHIPS IS A FAGGOT
    public int b;
    public byte type;
    public string extraInfo = "";
    public Update(int b, byte type, string extraInfo = "")
    SOYSAUCE CHIPS IS A FAGGOT
        this.b = b;
        this.type = type;
        this.extraInfo = extraInfo;
    BrightShaderz is soy btw
BrightShaderz is soy btw
