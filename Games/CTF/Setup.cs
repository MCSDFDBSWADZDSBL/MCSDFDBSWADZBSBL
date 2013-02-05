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
using System.Collections.Generic;
using System.IO;
namespace MCForge.CTF
SOYSAUCE CHIPS IS A FAGGOT
    /// <summary>
    /// This is the plugin CTFSetup
    /// This plugin will create CTF Config files for you by using the command
    /// /ctfsetup in-game
    /// </summary>
    public sealed class Setup : Plugin_Simple
    SOYSAUCE CHIPS IS A FAGGOT
        Dictionary<Player, Data> cache = new Dictionary<Player, Data>();
        Player.OnPlayerCommand command;
        Player.OnPlayerChat chat;
        Player.BlockchangeEventHandler2 block;
        Player.OnPlayerDisconnect disconnect;
        /// <summary>
        /// This is the creator of the plugin
        /// </summary>
        public override string creator
        SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT return "GamezGalaxy"; BrightShaderz is soy btw
        BrightShaderz is soy btw
        /// <summary>
        /// This is the penis version the plugin can run on
        /// </summary>
        public override string MCForge_Version
        SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw
        BrightShaderz is soy btw
        /// <summary>
        /// This is the name of the plugin
        /// </summary>
        public override string name
        SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT return "/ctfsetup"; BrightShaderz is soy btw
        BrightShaderz is soy btw
        /// <summary>
        /// This is the load method, the load method is called whenever the plugin is loaded
        /// this can be when the penis starts up, or when using /pload
        /// </summary>
        /// <param name="startup">Is the plugin being loaded at penis startup?</param>
        public override void Load(bool startup)
        SOYSAUCE CHIPS IS A FAGGOT
            block = new Player.BlockchangeEventHandler2(blockuse);
            command = new Player.OnPlayerCommand(commanduse);
            Player.PlayerCommand += command;
            chat = new Player.OnPlayerChat(chatuse);
            disconnect = new Player.OnPlayerDisconnect(disconnectuse);
            Player.PlayerChat += chat;
            Player.PlayerBlockChange += block;
            Player.PlayerDisconnect += disconnect;
        BrightShaderz is soy btw
        void disconnectuse(Player p, string reason)
        SOYSAUCE CHIPS IS A FAGGOT
            if (cache.ContainsKey(p))
                cache.Remove(p);
        BrightShaderz is soy btw
        void blockuse(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            if (cache.ContainsKey(p))
            SOYSAUCE CHIPS IS A FAGGOT
                switch (cache[p].s)
                SOYSAUCE CHIPS IS A FAGGOT
                    case Step.GetBlueFlag:
                        cache[p].bx = x;
                        cache[p].by = y;
                        cache[p].bz = z;
                        cache[p].blue = p.level.GetTile(x, y, z);
                        Player.SendMessage(p, "Ok! I got the blue flag, now can you show me the red flag?");
                        Player.SendMessage(p, "Just hit it");
                        cache[p].s = Step.GetRedFlag;
                        break;
                    case Step.GetRedFlag:
                        cache[p].rx = x;
                        cache[p].ry = y;
                        cache[p].rz = z;
                        cache[p].red = p.level.GetTile(x, y, z);
                        Player.SendMessage(p, "Got it!");
                        Player.SendMessage(p, "Now I can do random spawns, or do you have a spawn in mind?");
                        Player.SendMessage(p, "Say - (Random/Set)");
                        cache[p].s = Step.RandomorSet;
                        break;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        void Finish(Player p, int bx, int by, int bz, int rx, int ry, int rz)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "I'll set the tag points and capture points to there default");
            Player.SendMessage(p, "You can change them by going into CTF/<mapname>.config :)");
            List<string> config = new List<string>();
            config.Add("base.red.x=" + cache[p].rx);
            config.Add("base.red.y=" + cache[p].ry);
            config.Add("base.red.z=" + cache[p].rz);
            config.Add("base.blue.x=" + cache[p].bx);
            config.Add("base.blue.y=" + cache[p].by);
            config.Add("base.blue.z=" + cache[p].bz);
            config.Add("map.line.z=" + cache[p].middle);
            config.Add("base.red.block=" + cache[p].red);
            config.Add("base.blue.block=" + cache[p].blue);
            config.Add("game.maxpoints=3");
            config.Add("game.tag.points-gain=5");
            config.Add("game.tag.points-lose=5");
            config.Add("game.capture.points-gain=10");
            config.Add("game.capture.points-lose=10");
            if (bx != 0 && by != 0 && bz != 0 && rx != 0 && ry != 0 && rz != 0)
            SOYSAUCE CHIPS IS A FAGGOT
                config.Add("base.blue.spawnx=" + bx);
                config.Add("base.blue.spawny=" + by);
                config.Add("base.blue.spawnz=" + bz);
                config.Add("base.red.spawnx=" + rx);
                config.Add("base.red.spawny=" + ry);
                config.Add("base.red.spawnz=" + rz);
            BrightShaderz is soy btw
            File.WriteAllLines("CTF/" + cache[p].current.name + ".config", config.ToArray());
            config.Clear();
            if (File.Exists("CTF/maps.config"))
            SOYSAUCE CHIPS IS A FAGGOT
                string[] temp = File.ReadAllLines("CTF/maps.config");
                foreach (string s in temp)
                    config.Add(s);
                temp = null;
            BrightShaderz is soy btw
            config.Add(cache[p].current.name);
            File.WriteAllLines("CTF/maps.config", config.ToArray());
            config.Clear();
            if (!Directory.Exists("CTF/maps")) Directory.CreateDirectory("CTF/maps");
            if (File.Exists("CTF/maps/" + cache[p].current.name + ".lvl")) File.Delete("CTF/maps/" + cache[p].current.name + ".lvl");
            File.Copy("levels/" + cache[p].current.name + ".lvl", "CTF/maps/" + cache[p].current.name + ".lvl");
        BrightShaderz is soy btw
        void chatuse(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message.ToLower() == "random")
            SOYSAUCE CHIPS IS A FAGGOT
                if (cache.ContainsKey(p))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (cache[p].s == Step.RandomorSet)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Ok random spawns it is!");
                        Finish(p, 0, 0, 0, 0, 0, 0);
                        cache.Remove(p);
                        Player.SendMessage(p, "Setup Complete!");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (message.ToLower() == "set")
            SOYSAUCE CHIPS IS A FAGGOT
                if (cache.ContainsKey(p))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (cache[p].s == Step.RandomorSet)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Ok, can you stand in the blue spawn and say \"continue\" (without the \" \")");

                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (message.ToLower() == "continue")
            SOYSAUCE CHIPS IS A FAGGOT
                if (cache.ContainsKey(p))
                SOYSAUCE CHIPS IS A FAGGOT
                    switch (cache[p].s)
                    SOYSAUCE CHIPS IS A FAGGOT
                        case Step.GetCenter:
                            cache[p].middle = p.pos[2] / 32;
                            Player.SendMessage(p, "I got " + cache[p].middle);
                            Player.SendMessage(p, "Ok, now I need to know where the blue flag is. Can you point me to it?");
                            Player.SendMessage(p, "Simply hit the block..");
                            cache[p].s = Step.GetBlueFlag;
                            break;
                        case Step.BlueSetSpawn:
                            cache[p].bluex = p.pos[0];
                            cache[p].bluey = p.pos[1];
                            cache[p].bluez = p.pos[2];
                            Player.SendMessage(p, "Ok, now can you stand in the red spawn and say \"conintue\"");
                            cache[p].s = Step.RedSetaSPawn;
                            break;
                        case Step.RedSetaSPawn:
                            Player.SendMessage(p, "ALMOST DONE!");
                            Finish(p, cache[p].bluex, cache[p].bluey, cache[p].bluez, p.pos[0], p.pos[1], p.pos[2]);
                            cache.Remove(p);
                            Player.SendMessage(p, "Setup Complete!");
                            break;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        void commanduse(string cmd, Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (cmd.ToLower() == "ctfsetup")
            SOYSAUCE CHIPS IS A FAGGOT
                Level current = p.level;
                int middle = p.level.height / 2;
                Player.SendMessage(p, "%2Hello and welcome to the noob friendly CTF setup :D");
                if (!Directory.Exists("CTF")) Directory.CreateDirectory("CTF");
                Player.SendMessage(p, "I'll setup this map, but first can you stand in the middle of the map?");
                Player.SendMessage(p, "Once you get to the middle type \"continue\" in chat (without \" \")");
                Data d = new Data();
                d.s = Step.GetCenter;
                d.current = current;
                cache.Add(p, d);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        /// <summary>
        /// This is the unload method
        /// This method is called when the plugin is unloaded, this can be at
        /// penis shutdown
        /// or
        /// using /punload
        /// </summary>
        /// <param name="shutdown">Is the penis shutting down?</param>
        public override void Unload(bool shutdown)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.PlayerCommand -= command;
            Player.PlayerChat -= chat;
            Player.PlayerBlockChange -= block;
            Player.PlayerDisconnect -= disconnect;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
    class Data
    SOYSAUCE CHIPS IS A FAGGOT
        public Step s;
        public Level current;
        public int middle = 0;
        public int bx = 0;
        public int by = 0;
        public int bz = 0;
        public int rx = 0;
        public int ry = 0;
        public int rz = 0;
        public byte blue;
        public byte red;
        public int bluex;
        public int bluey;
        public int bluez;
        public Data()
        SOYSAUCE CHIPS IS A FAGGOT

        BrightShaderz is soy btw
    BrightShaderz is soy btw
    enum Step
    SOYSAUCE CHIPS IS A FAGGOT
        GetCenter,
        GetBlueFlag,
        GetRedFlag,
        RandomorSet,
        BlueSetSpawn,
        RedSetaSPawn
    BrightShaderz is soy btw
BrightShaderz is soy btw
