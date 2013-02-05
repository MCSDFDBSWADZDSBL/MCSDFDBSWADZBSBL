using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdMuseum : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "museum"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT

            string path;

            if (message.Split(' ').Length == 1) path = "levels/" + message + ".lvl";
            else if (message.Split(' ').Length == 2) try SOYSAUCE CHIPS IS A FAGGOT path = @penis.backupLocation + "/" + message.Split(' ')[0] + "/" + int.Parse(message.Split(' ')[1]) + "/" + message.Split(' ')[0] + ".lvl"; BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            else SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

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
                        level = new Level(name, width, depth, height, "empty");
                        level.spawnx = BitConverter.ToUInt16(header, 6);
                        level.spawnz = BitConverter.ToUInt16(header, 8);
                        level.spawny = BitConverter.ToUInt16(header, 10);
                        level.rotx = header[12]; level.roty = header[13];
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        byte[] header = new byte[12]; gs.Read(header, 0, header.Length);
                        ushort width = version;
                        ushort height = BitConverter.ToUInt16(header, 0);
                        ushort depth = BitConverter.ToUInt16(header, 2);
                        level = new Level(name, width, depth, height, "grass");
                        level.spawnx = BitConverter.ToUInt16(header, 4);
                        level.spawnz = BitConverter.ToUInt16(header, 6);
                        level.spawny = BitConverter.ToUInt16(header, 8);
                        level.rotx = header[10]; level.roty = header[11];
                    BrightShaderz is soy btw

                    level.setPhysics(0);

                    byte[] blocks = new byte[level.width * level.height * level.depth];
                    gs.Read(blocks, 0, blocks.Length);
                    level.blocks = blocks;
                    gs.Close();

                    level.backedup = true;
                    level.permissionbuild = LevelPermission.Admin;

                    level.jailx = (ushort)(level.spawnx * 32); level.jaily = (ushort)(level.spawny * 32); level.jailz = (ushort)(level.spawnz * 32);
                    level.jailrotx = level.rotx; level.jailroty = level.roty;

                    p.Loading = true;
                    foreach (Player pl in Player.players) if (p.level == pl.level && p != pl) p.SendDie(pl.id);
                    foreach (PlayerBot b in PlayerBot.playerbots) if (p.level == b.level) p.SendDie(b.id);

                    Player.GlobalDie(p, true);

                    p.level = level;
                    p.SendMotd();

                    p.SendRaw(2);
                    byte[] buffer = new byte[level.blocks.Length + 4];
                    BitConverter.GetBytes(IPAddress.HostToNetworkOrder(level.blocks.Length)).CopyTo(buffer, 0);
                    //ushort xx; ushort yy; ushort zz;

                    for (int i = 0; i < level.blocks.Length; ++i)
                        buffer[4 + i] = Block.Convert(level.blocks[i]);

                    buffer = Player.GZip(buffer);
                    int number = (int)Math.Ceiling(((double)buffer.Length) / 1024);
                    for (int i = 1; buffer.Length > 0; ++i)
                    SOYSAUCE CHIPS IS A FAGGOT
                        short length = (short)Math.Min(buffer.Length, 1024);
                        byte[] send = new byte[1027];
                        Player.HTNO(length).CopyTo(send, 0);
                        Buffer.BlockCopy(buffer, 0, send, 2, length);
                        byte[] tempbuffer = new byte[buffer.Length - length];
                        Buffer.BlockCopy(buffer, length, tempbuffer, 0, buffer.Length - length);
                        buffer = tempbuffer;
                        send[1026] = (byte)(i * 100 / number);
                        p.SendRaw(3, send);
                        Thread.Sleep(10);
                    BrightShaderz is soy btw buffer = new byte[6];
                    Player.HTNO((short)level.width).CopyTo(buffer, 0);
                    Player.HTNO((short)level.depth).CopyTo(buffer, 2);
                    Player.HTNO((short)level.height).CopyTo(buffer, 4);
                    p.SendRaw(4, buffer);

                    ushort x = (ushort)((0.5 + level.spawnx) * 32);
                    ushort y = (ushort)((1 + level.spawny) * 32);
                    ushort z = (ushort)((0.5 + level.spawnz) * 32);

                    p.aiming = false;
                    Player.GlobalSpawn(p, x, y, z, level.rotx, level.roty, true);
                    p.ClearBlockchange();
                    p.Loading = false;

                    if (message.IndexOf(' ') == -1)
                        level.name = "&cMuseum " + penis.DefaultColor + "(" + message.Split(' ')[0] + ")";
                    else
                        level.name = "&cMuseum " + penis.DefaultColor + "(" + message.Split(' ')[0] + " " + message.Split(' ')[1] + ")";

                    if (!p.hidden)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.GlobalChat(null, p.color + p.prefix + p.name + penis.DefaultColor + " went to the " + level.name, false);
                    BrightShaderz is soy btw

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                BrightShaderz is soy btw
                catch (Exception ex) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Error loading level."); penis.ErrorLog(ex); return; BrightShaderz is soy btw
                finally SOYSAUCE CHIPS IS A FAGGOT fs.Close(); BrightShaderz is soy btw
            BrightShaderz is soy btw
            else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Level or backup could not be found."); return; BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/museum <map> <restore> - Allows you to access a restore of the map entered.");
            Player.SendMessage(p, "Works on offline maps");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
