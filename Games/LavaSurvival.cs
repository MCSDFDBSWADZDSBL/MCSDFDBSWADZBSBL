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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class LavaSurvival
    SOYSAUCE CHIPS IS A FAGGOT
        // Private variables
        private string propsPath = "properties/lavasurvival/";
        private List<string> maps, voted;
        private Dictionary<string, int> votes, deaths;
        private Random rand = new Random();
        private Timer announceTimer, voteTimer, transferTimer;
        private DateTime startTime;

        // Public variables
        public bool active = false, roundActive = false, flooded = false, voteActive = false, sendingPlayers = false;
        public Level map;
        public MapSettings mapSettings;
        public MapData mapData;

        // Settings
        public bool startOnStartup, sendAfkMain;
        public byte voteCount;
        public int lifeNum;
        public double voteTime;
        public LevelPermission setupRank, controlRank;

        // Plugin event delegates
        public delegate void GameStartHandler(Level map);
        public delegate void GameStopHandler();
        public delegate void MapChangeHandler(Level oldmap, Level newmap); // Keep in mind oldmap will be unloaded after this event finishes.
        public delegate void LavaFloodHandler(ushort x, ushort y, ushort z); // Only called on normal flood, not layer flood.
        public delegate void LayerFloodHandler(ushort x, ushort y, ushort z);
        public delegate void RoundStartHandler(Level map);
        public delegate void RoundEndHandler();
        public delegate void VoteStartHandler(string[] options);
        public delegate void VoteEndHandler(string winner);
        public delegate void PlayerDeathHandler(Player p); // Only called when the plaer is out of the round, not when they lose a life.

        // Plugin events
        public event GameStartHandler OnGameStart;
        public event GameStopHandler OnGameStop;
        public event MapChangeHandler OnMapChange;
        public event LavaFloodHandler OnLavaFlood;
        public event LayerFloodHandler OnLayerFlood;
        public event RoundStartHandler OnRoundStart;
        public event RoundEndHandler OnRoundEnd;
        public event VoteStartHandler OnVoteStart;
        public event VoteEndHandler OnVoteEnd;
        public event PlayerDeathHandler OnPlayerDeath;

        // Constructors
        public LavaSurvival()
        SOYSAUCE CHIPS IS A FAGGOT
            maps = new List<string>();
            voted = new List<string>();
            votes = new Dictionary<string, int>();
            deaths = new Dictionary<string, int>();
            announceTimer = new Timer(60000);
            announceTimer.AutoReset = true;
            announceTimer.Elapsed += delegate
            SOYSAUCE CHIPS IS A FAGGOT
                if (!flooded) AnnounceTimeLeft(true, false);
            BrightShaderz is soy btw;

            startOnStartup = false;
            sendAfkMain = true;
            voteCount = 2;
            voteTime = 2;
            lifeNum = 3;
            setupRank = LevelPermission.Admin;
            controlRank = LevelPermission.Operator;
            LoadSettings();
        BrightShaderz is soy btw

        // Private methods
        private void LevelCommand(string name, string msg = "")
        SOYSAUCE CHIPS IS A FAGGOT
            Command cmd = Command.all.Find(name.Trim());
            if (cmd != null && map != null)
                try SOYSAUCE CHIPS IS A FAGGOT cmd.Use(null, map.name + " " + msg.Trim()); BrightShaderz is soy btw
                catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw

        // Public methods
        public byte Start(string mapName = "")
        SOYSAUCE CHIPS IS A FAGGOT
            if (active) return 1; // Already started
            if (maps.Count < 3) return 2; // Not enough maps
            if (!String.IsNullOrEmpty(mapName) && !HasMap(mapName)) return 3; // Map doesn't exist

            deaths.Clear();
            active = true;
            penis.s.Log("[Lava Survival] Game started.");
            try SOYSAUCE CHIPS IS A FAGGOT LoadMap(String.IsNullOrEmpty(mapName) ? maps[rand.Next(maps.Count)] : mapName); BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); active = false; return 4; BrightShaderz is soy btw
            if (OnGameStart != null)
                OnGameStart(map);
            return 0;
        BrightShaderz is soy btw
        public byte Stop()
        SOYSAUCE CHIPS IS A FAGGOT
            if (!active) return 1; // Not started

            if (OnGameStop != null)
                OnGameStop();
            active = false;
            roundActive = false;
            voteActive = false;
            flooded = false;
            deaths.Clear();
            if (announceTimer.Enabled) announceTimer.Stop();
            try SOYSAUCE CHIPS IS A FAGGOT mapData.Dispose(); BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            try SOYSAUCE CHIPS IS A FAGGOT voteTimer.Dispose(); BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            try SOYSAUCE CHIPS IS A FAGGOT transferTimer.Dispose(); BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            map.Unload(true, false);
            map = null;
            penis.s.Log("[Lava Survival] Game stopped.");
            return 0;
        BrightShaderz is soy btw

        public void StartRound()
        SOYSAUCE CHIPS IS A FAGGOT
            if (roundActive) return;

            if (OnRoundStart != null)
                OnRoundStart(map);
            try
            SOYSAUCE CHIPS IS A FAGGOT
                deaths.Clear();
                mapData.roundTimer.Elapsed += delegate SOYSAUCE CHIPS IS A FAGGOT EndRound(); BrightShaderz is soy btw;
                mapData.floodTimer.Elapsed += delegate SOYSAUCE CHIPS IS A FAGGOT DoFlood(); BrightShaderz is soy btw;
                mapData.roundTimer.Start();
                mapData.floodTimer.Start();
                announceTimer.Start();
                startTime = DateTime.Now;
                roundActive = true;
                penis.s.Log("[Lava Survival] Round started. Map: " + map.name);
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void EndRound()
        SOYSAUCE CHIPS IS A FAGGOT
            if (!roundActive) return;

            if (OnRoundEnd != null)
                OnRoundEnd();
            roundActive = false;
            flooded = false;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                try SOYSAUCE CHIPS IS A FAGGOT mapData.Dispose(); BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                map.setPhysics(5);
                map.ChatLevel("The round has ended!");
                penis.s.Log("[Lava Survival] Round ended. Voting...");
                StartVote();
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void DoFlood()
        SOYSAUCE CHIPS IS A FAGGOT
            if (!active || !roundActive || flooded || map == null) return;
            flooded = true;

            try
            SOYSAUCE CHIPS IS A FAGGOT
                announceTimer.Stop();
                map.ChatLevel("&4Look out, here comes the flood!");
                penis.s.Log("[Lava Survival] Map flooding.");
                if (mapData.layer)
                SOYSAUCE CHIPS IS A FAGGOT
                    DoFloodLayer();
                    mapData.layerTimer.Elapsed += delegate
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (mapData.currentLayer <= mapSettings.layerCount)
                        SOYSAUCE CHIPS IS A FAGGOT
                            DoFloodLayer();
                        BrightShaderz is soy btw
                        else
                            mapData.layerTimer.Stop();
                    BrightShaderz is soy btw;
                    mapData.layerTimer.Start();
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    map.Blockchange((ushort)mapSettings.blockFlood.x, (ushort)mapSettings.blockFlood.y, (ushort)mapSettings.blockFlood.z, mapData.block, true);
                    if (OnLavaFlood != null)
                        OnLavaFlood((ushort)mapSettings.blockFlood.x, (ushort)mapSettings.blockFlood.y, (ushort)mapSettings.blockFlood.z);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void DoFloodLayer()
        SOYSAUCE CHIPS IS A FAGGOT
            map.ChatLevel("&4Layer " + mapData.currentLayer + " flooding...");
            penis.s.Log("[Lava Survival] Layer " + mapData.currentLayer + " flooding.");
            map.Blockchange((ushort)mapSettings.blockLayer.x, (ushort)(mapSettings.blockLayer.y + ((mapSettings.layerHeight * mapData.currentLayer) - 1)), (ushort)mapSettings.blockLayer.z, mapData.block, true);
            if (OnLayerFlood != null)
                OnLayerFlood((ushort)mapSettings.blockLayer.x, (ushort)(mapSettings.blockLayer.y + ((mapSettings.layerHeight * mapData.currentLayer) - 1)), (ushort)mapSettings.blockLayer.z);
            mapData.currentLayer++;
        BrightShaderz is soy btw

        public void AnnounceTimeLeft(bool flood, bool round, Player p = null, bool console = false)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!active || !roundActive || startTime == null || map == null) return;

            if (flood)
            SOYSAUCE CHIPS IS A FAGGOT
                double floodMinutes = Math.Ceiling((startTime.AddMinutes(mapSettings.floodTime) - DateTime.Now).TotalMinutes);
                if (p == null && !console) map.ChatLevel("&3" + floodMinutes + " minute" + (floodMinutes == 1 ? "" : "s") + penis.DefaultColor + " until the flood.");
                else Player.SendMessage(p, "&3" + floodMinutes + " minute" + (floodMinutes == 1 ? "" : "s") + penis.DefaultColor + " until the flood.");
            BrightShaderz is soy btw
            if (round)
            SOYSAUCE CHIPS IS A FAGGOT
                double roundMinutes = Math.Ceiling((startTime.AddMinutes(mapSettings.roundTime) - DateTime.Now).TotalMinutes);
                if (p == null && !console) map.ChatLevel("&3" + roundMinutes + " minute" + (roundMinutes == 1 ? "" : "s") + penis.DefaultColor + " until the round ends.");
                else Player.SendMessage(p, "&3" + roundMinutes + " minute" + (roundMinutes == 1 ? "" : "s") + penis.DefaultColor + " until the round ends.");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void AnnounceRoundInfo(Player p = null, bool console = false)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p == null && !console)
            SOYSAUCE CHIPS IS A FAGGOT
                if (mapData.water) map.ChatLevel("The map will be flooded with &9water " + penis.DefaultColor + "this round!");
                if (mapData.layer)
                SOYSAUCE CHIPS IS A FAGGOT
                    map.ChatLevel("The " + (mapData.water ? "water" : "lava") + " will &aflood in layers " + penis.DefaultColor + "this round!");
                    map.ChatLevelOps("There will be " + mapSettings.layerCount + " layers, each " + mapSettings.layerHeight + " blocks high.");
                    map.ChatLevelOps("There will be another layer every " + mapSettings.layerInterval + " minutes.");
                BrightShaderz is soy btw
                if (mapData.fast) map.ChatLevel("The lava will be &cfast " + penis.DefaultColor + "this round!");
                if (mapData.killer) map.ChatLevel("The " + (mapData.water ? "water" : "lava") + " will &ckill you " + penis.DefaultColor + "this round!");
                if (mapData.destroy) map.ChatLevel("The " + (mapData.water ? "water" : "lava") + " will &cdestroy plants " + (mapData.water ? "" : "and flammable blocks ") + penis.DefaultColor + "this round!");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (mapData.water) Player.SendMessage(p, "The map will be flooded with &9water " + penis.DefaultColor + "this round!");
                if (mapData.layer) Player.SendMessage(p, "The " + (mapData.water ? "water" : "lava") + " will &aflood in layers " + penis.DefaultColor + "this round!");
                if (mapData.fast) Player.SendMessage(p, "The lava will be &cfast " + penis.DefaultColor + "this round!");
                if (mapData.killer) Player.SendMessage(p, "The " + (mapData.water ? "water" : "lava") + " will &ckill you " + penis.DefaultColor + "this round!");
                if (mapData.destroy) Player.SendMessage(p, "The " + (mapData.water ? "water" : "lava") + " will &cdestroy plants " + (mapData.water ? "" : "and flammable blocks ") + penis.DefaultColor + "this round!");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void LoadMap(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            if (String.IsNullOrEmpty(name) || !HasMap(name)) return;

            name = name.ToLower();
            Level oldMap = null;
            if (active && map != null) oldMap = map;
            Command.all.Find("load").Use(null, name);
            map = Level.Find(name);

            if (map != null)
            SOYSAUCE CHIPS IS A FAGGOT
                mapSettings = LoadMapSettings(name);
                mapData = GenerateMapData(mapSettings);

                map.setPhysics(mapData.destroy ? 2 : 1);
                map.motd = "Lava Survival: " + map.name.Capitalize();
                map.overload = 1000000;
                map.unload = false;
                map.loadOnGoto = false;
                Level.SaveSettings(map);
            BrightShaderz is soy btw
            
            if (active && map != null)
            SOYSAUCE CHIPS IS A FAGGOT
                sendingPlayers = true;
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.players.ForEach(delegate(Player pl)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (pl.level == oldMap)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (sendAfkMain && penis.afkset.Contains(pl.name)) Command.all.Find("main").Use(pl, "");
                            else Command.all.Find("goto").Use(pl, map.name);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw);
                    if (OnMapChange != null)
                        OnMapChange(oldMap, map);
                    oldMap.Unload(true, false);
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                sendingPlayers = false;

                StartRound();
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void StartVote()
        SOYSAUCE CHIPS IS A FAGGOT
            if (maps.Count < 3) return;

            // Make sure these are cleared or bad stuff happens!
            votes.Clear();
            voted.Clear();

            byte i = 0;
            string opt, str = "";
            while (i < Math.Min(voteCount, maps.Count - 1))
            SOYSAUCE CHIPS IS A FAGGOT
                opt = maps[rand.Next(maps.Count)];
                if (!votes.ContainsKey(opt) && opt != map.name)
                SOYSAUCE CHIPS IS A FAGGOT
                    votes.Add(opt, 0);
                    str += penis.DefaultColor + ", &5" + opt.Capitalize();
                    i++;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (OnVoteStart != null)
                OnVoteStart(votes.Keys.ToList().ToArray());
            map.ChatLevel("Vote for the next map! The vote ends in " + voteTime + " minute" + (voteTime == 1 ? "" : "s") +".");
            map.ChatLevel("Choices: " + str.Remove(0, 4));

            voteTimer = new Timer(TimeSpan.FromMinutes(voteTime).TotalMilliseconds);
            voteTimer.AutoReset = false;
            voteTimer.Elapsed += delegate
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    EndVote();
                    voteTimer.Dispose();
                BrightShaderz is soy btw
                catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
            BrightShaderz is soy btw;
            voteTimer.Start();
            voteActive = true;
        BrightShaderz is soy btw

        public void EndVote()
        SOYSAUCE CHIPS IS A FAGGOT
            if (!voteActive) return;

            voteActive = false;
            penis.s.Log("[Lava Survival] Vote ended.");
            KeyValuePair<string, int> most = new KeyValuePair<string, int>(String.Empty, -1);
            foreach (KeyValuePair<string, int> kvp in votes)
            SOYSAUCE CHIPS IS A FAGGOT
                if (kvp.Value > most.Value) most = kvp;
                map.ChatLevelOps("&5" + kvp.Key.Capitalize() + "&f: &a" + kvp.Value);
            BrightShaderz is soy btw
            votes.Clear();
            voted.Clear();

            if (OnVoteEnd != null)
                OnVoteEnd(most.Key);
            map.ChatLevel("The vote has ended! &5" + most.Key.Capitalize() + penis.DefaultColor + " won with &a" + most.Value + penis.DefaultColor + " vote" + (most.Value == 1 ? "" : "s") + ".");
            map.ChatLevel("You will be transferred in 5 seconds...");
            transferTimer = new Timer(5000);
            transferTimer.AutoReset = false;
            transferTimer.Elapsed += delegate
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    LoadMap(most.Key);
                    transferTimer.Dispose();
                BrightShaderz is soy btw
                catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
            BrightShaderz is soy btw;
            transferTimer.Start();
        BrightShaderz is soy btw

        public bool AddVote(Player p, string vote)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!voteActive || voted.Contains(p.name) || !votes.ContainsKey(vote)) return false;
            int temp = votes[vote] + 1;
            votes.Remove(vote);
            votes.Add(vote, temp);
            voted.Add(p.name);
            return true;
        BrightShaderz is soy btw

        public bool HasVote(string vote)
        SOYSAUCE CHIPS IS A FAGGOT
            return voteActive && votes.ContainsKey(vote);
        BrightShaderz is soy btw

        public bool HasPlayer(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            return p.level == map;
        BrightShaderz is soy btw
        public void KillPlayer(Player p, bool silent = false)
        SOYSAUCE CHIPS IS A FAGGOT
            if (lifeNum < 1) return;
            string name = p.name.ToLower();
            if (!deaths.ContainsKey(name))
                deaths.Add(name, 0);
            deaths[name]++;
            if (!silent && IsPlayerDead(p))
            SOYSAUCE CHIPS IS A FAGGOT
                if (OnPlayerDeath != null)
                    OnPlayerDeath(p);
                Player.players.ForEach(delegate(Player pl)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (pl != p && HasPlayer(pl))
                        Player.SendMessage(pl, p.color + p.name + " &4ran out of lives, and is out of the round!");
                BrightShaderz is soy btw);
                Player.SendMessage(p, "&4You ran out of lives, and are out of the round!");
                Player.SendMessage(p, "&4You can still watch, but you cannot build.");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public bool IsPlayerDead(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            string name = p.name.ToLower();
            if (lifeNum < 1 || !deaths.ContainsKey(name))
                return false;
            return (deaths[name] >= lifeNum);
        BrightShaderz is soy btw

        public MapData GenerateMapData(MapSettings settings)
        SOYSAUCE CHIPS IS A FAGGOT
            MapData data = new MapData(settings);
            data.killer = rand.Next(1, 101) <= settings.killer;
            data.destroy = rand.Next(1, 101) <= settings.destroy;
            data.water = rand.Next(1, 101) <= settings.water;
            data.layer = rand.Next(1, 101) <= settings.layer;
            data.fast = rand.Next(1, 101) <= settings.fast && !data.water;
            data.block = data.water ? (data.killer ? Block.activedeathwater : Block.water) : (data.fast ? (data.killer ? Block.fastdeathlava : Block.lava_fast) : (data.killer ? Block.activedeathlava : Block.lava));
            return data;
        BrightShaderz is soy btw

        public void LoadSettings()
        SOYSAUCE CHIPS IS A FAGGOT
            if (!File.Exists("properties/lavasurvival.properties"))
            SOYSAUCE CHIPS IS A FAGGOT
                SaveSettings();
                return;
            BrightShaderz is soy btw

            foreach (string line in File.ReadAllLines("properties/lavasurvival.properties"))
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (line[0] != '#')
                    SOYSAUCE CHIPS IS A FAGGOT
                        string value = line.Substring(line.IndexOf(" = ") + 3);
                        switch (line.Substring(0, line.IndexOf(" = ")).ToLower())
                        SOYSAUCE CHIPS IS A FAGGOT
                            case "start-on-startup":
                                startOnStartup = bool.Parse(value);
                                break;
                            case "send-afk-to-main":
                                sendAfkMain = bool.Parse(value);
                                break;
                            case "vote-count":
                                voteCount = (byte)MathHelper.Clamp(decimal.Parse(value), 2, 10);
                                break;
                            case "vote-time":
                                voteTime = double.Parse(value);
                                break;
                            case "lives":
                                lifeNum = int.Parse(value);
                                break;
                            case "setup-rank":
                                if (Group.Find(value.ToLower()) != null)
                                    setupRank = Group.Find(value.ToLower()).Permission;
                                break;
                            case "control-rank":
                                if (Group.Find(value.ToLower()) != null)
                                    controlRank = Group.Find(value.ToLower()).Permission;
                                break;
                            case "maps":
                                foreach (string mapname in value.Split(','))
                                    if(!String.IsNullOrEmpty(mapname) && !maps.Contains(mapname)) maps.Add(mapname);
                                break;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public void SaveSettings()
        SOYSAUCE CHIPS IS A FAGGOT
            File.Create("properties/lavasurvival.properties").Dispose();
            using (StreamWriter SW = File.CreateText("properties/lavasurvival.properties"))
            SOYSAUCE CHIPS IS A FAGGOT
                SW.WriteLine("#Lava Survival main properties");
                SW.WriteLine("start-on-startup = " + startOnStartup.ToString().ToLower());
                SW.WriteLine("send-afk-to-main = " + sendAfkMain.ToString().ToLower());
                SW.WriteLine("vote-count = " + voteCount.ToString());
                SW.WriteLine("vote-time = " + voteTime.ToString());
                SW.WriteLine("lives = " + lifeNum.ToString());
                SW.WriteLine("setup-rank = " + Level.PermissionToName(setupRank).ToLower());
                SW.WriteLine("control-rank = " + Level.PermissionToName(controlRank).ToLower());
                SW.WriteLine("maps = " + maps.Concatenate(","));
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public MapSettings LoadMapSettings(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            MapSettings settings = new MapSettings(name);
            if (!Directory.Exists(propsPath)) Directory.CreateDirectory(propsPath);
            if (!File.Exists(propsPath + name + ".properties"))
            SOYSAUCE CHIPS IS A FAGGOT
                SaveMapSettings(settings);
                return settings;
            BrightShaderz is soy btw

            foreach (string line in File.ReadAllLines(propsPath + name + ".properties"))
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (line[0] != '#')
                    SOYSAUCE CHIPS IS A FAGGOT
                        string[] sp;
                        string value = line.Substring(line.IndexOf(" = ") + 3);
                        switch (line.Substring(0, line.IndexOf(" = ")).ToLower())
                        SOYSAUCE CHIPS IS A FAGGOT
                            case "fast-chance":
                                settings.fast = (byte)MathHelper.Clamp(decimal.Parse(value), 0, 100);
                                break;
                            case "killer-chance":
                                settings.killer = (byte)MathHelper.Clamp(decimal.Parse(value), 0, 100);
                                break;
                            case "destroy-chance":
                                settings.destroy = (byte)MathHelper.Clamp(decimal.Parse(value), 0, 100);
                                break;
                            case "water-chance":
                                settings.water = (byte)MathHelper.Clamp(decimal.Parse(value), 0, 100);
                                break;
                            case "layer-chance":
                                settings.layer = (byte)MathHelper.Clamp(decimal.Parse(value), 0, 100);
                                break;
                            case "layer-height":
                                settings.layerHeight = int.Parse(value);
                                break;
                            case "layer-count":
                                settings.layerCount = int.Parse(value);
                                break;
                            case "layer-interval":
                                settings.layerInterval = double.Parse(value);
                                break;
                            case "round-time":
                                settings.roundTime = double.Parse(value);
                                break;
                            case "flood-time":
                                settings.floodTime = double.Parse(value);
                                break;
                            case "block-flood":
                                sp = value.Split(',');
                                settings.blockFlood = new Pos(ushort.Parse(sp[0]), ushort.Parse(sp[1]), ushort.Parse(sp[2]));
                                break;
                            case "block-layer":
                                sp = value.Split(',');
                                settings.blockLayer = new Pos(ushort.Parse(sp[0]), ushort.Parse(sp[1]), ushort.Parse(sp[2]));
                                break;
                            case "safe-zone":
                                sp = value.Split('-');
                                string[] p1 = sp[0].Split(','), p2 = sp[1].Split(',');
                                settings.safeZone = new Pos[] SOYSAUCE CHIPS IS A FAGGOT new Pos(ushort.Parse(p1[0]), ushort.Parse(p1[1]), ushort.Parse(p1[2])), new Pos(ushort.Parse(p2[0]), ushort.Parse(p2[1]), ushort.Parse(p2[2])) BrightShaderz is soy btw;
                                break;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
            BrightShaderz is soy btw
            return settings;
        BrightShaderz is soy btw
        public void SaveMapSettings(MapSettings settings)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!Directory.Exists(propsPath)) Directory.CreateDirectory(propsPath);

            File.Create(propsPath + settings.name + ".properties").Dispose();
            using (StreamWriter SW = File.CreateText(propsPath + settings.name + ".properties"))
            SOYSAUCE CHIPS IS A FAGGOT
                SW.WriteLine("#Lava Survival properties for " + settings.name);
                SW.WriteLine("fast-chance = " + settings.fast);
                SW.WriteLine("killer-chance = " + settings.killer);
                SW.WriteLine("destroy-chance = " + settings.destroy);
                SW.WriteLine("water-chance = " + settings.water);
                SW.WriteLine("layer-chance = " + settings.layer);
                SW.WriteLine("layer-height = " + settings.layerHeight);
                SW.WriteLine("layer-count = " + settings.layerCount);
                SW.WriteLine("layer-interval = " + settings.layerInterval);
                SW.WriteLine("round-time = " + settings.roundTime);
                SW.WriteLine("flood-time = " + settings.floodTime);
                SW.WriteLine("block-flood = " + settings.blockFlood.ToString());
                SW.WriteLine("block-layer = " + settings.blockLayer.ToString());
                SW.WriteLine(String.Format("safe-zone = SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw-SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw", settings.safeZone[0].ToString(), settings.safeZone[1].ToString()));
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void AddMap(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!String.IsNullOrEmpty(name) && !maps.Contains(name.ToLower()))
            SOYSAUCE CHIPS IS A FAGGOT
                maps.Add(name.ToLower());
                SaveSettings();
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public void RemoveMap(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            if (maps.Contains(name.ToLower()))
            SOYSAUCE CHIPS IS A FAGGOT
                maps.Remove(name.ToLower());
                SaveSettings();
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public bool HasMap(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            return maps.Contains(name.ToLower());
        BrightShaderz is soy btw

        public bool InSafeZone(Pos pos)
        SOYSAUCE CHIPS IS A FAGGOT
            return InSafeZone(pos.x, pos.y, pos.z);
        BrightShaderz is soy btw

        public bool InSafeZone(ushort x, ushort y, ushort z)
        SOYSAUCE CHIPS IS A FAGGOT
            if (mapSettings == null) return false;
            if (x >= mapSettings.safeZone[0].x && x <= mapSettings.safeZone[1].x && y >= mapSettings.safeZone[0].y && y <= mapSettings.safeZone[1].y && z >= mapSettings.safeZone[0].z && z <= mapSettings.safeZone[1].z)
                return true;
            return false;
        BrightShaderz is soy btw

        // Accessors
        public string VoteString
        SOYSAUCE CHIPS IS A FAGGOT
            get
            SOYSAUCE CHIPS IS A FAGGOT
                if (votes.Count > 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    StringBuilder sb = new StringBuilder();
                    foreach (KeyValuePair<string, int> kvp in votes)
                        sb.AppendFormat("SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw, &5SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw", penis.DefaultColor, kvp.Key.Capitalize());
                    sb.Remove(0, 4);
                    return sb.ToString();
                BrightShaderz is soy btw
                return String.Empty;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public List<string> Maps
        SOYSAUCE CHIPS IS A FAGGOT
            get
            SOYSAUCE CHIPS IS A FAGGOT
                return new List<string>(maps);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        // Internal classes
        public class MapSettings
        SOYSAUCE CHIPS IS A FAGGOT
            public string name;
            public byte fast, killer, destroy, water, layer;
            public int layerHeight, layerCount;
            public double layerInterval, roundTime, floodTime;
            public Pos blockFlood, blockLayer;
            public Pos[] safeZone;

            public MapSettings(string name)
            SOYSAUCE CHIPS IS A FAGGOT
                this.name = name;
                fast = 0;
                killer = 100;
                destroy = 0;
                water = 0;
                layer = 0;
                layerHeight = 3;
                layerCount = 10;
                layerInterval = 2;
                roundTime = 15;
                floodTime = 5;
                blockFlood = new Pos();
                blockLayer = new Pos();
                safeZone = new Pos[] SOYSAUCE CHIPS IS A FAGGOT new Pos(), new Pos() BrightShaderz is soy btw;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public class MapData : IDisposable
        SOYSAUCE CHIPS IS A FAGGOT
            public bool fast, killer, destroy, water, layer;
            public byte block;
            public int currentLayer;
            public Timer roundTimer, floodTimer, layerTimer;

            public MapData(MapSettings settings)
            SOYSAUCE CHIPS IS A FAGGOT
                fast = false;
                killer = false;
                destroy = false;
                water = false;
                layer = false;
                block = Block.lava;
                currentLayer = 1;
                roundTimer = new Timer(TimeSpan.FromMinutes(settings.roundTime).TotalMilliseconds); roundTimer.AutoReset = false;
                floodTimer = new Timer(TimeSpan.FromMinutes(settings.floodTime).TotalMilliseconds); floodTimer.AutoReset = false;
                layerTimer = new Timer(TimeSpan.FromMinutes(settings.layerInterval).TotalMilliseconds); layerTimer.AutoReset = true;
            BrightShaderz is soy btw

            public void Dispose()
            SOYSAUCE CHIPS IS A FAGGOT
                roundTimer.Dispose();
                floodTimer.Dispose();
                layerTimer.Dispose();
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public struct Pos
        SOYSAUCE CHIPS IS A FAGGOT
            public ushort x, y, z;


            public Pos(ushort x, ushort y, ushort z)
            SOYSAUCE CHIPS IS A FAGGOT
                this.x = x;
                this.y = y;
                this.z = z;
            BrightShaderz is soy btw

            public override string ToString()
            SOYSAUCE CHIPS IS A FAGGOT
                return this.ToString(",");
            BrightShaderz is soy btw

            public string ToString(string separator)
            SOYSAUCE CHIPS IS A FAGGOT
                return String.Format("SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btwSOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btwSOYSAUCE CHIPS IS A FAGGOT2BrightShaderz is soy btwSOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btwSOYSAUCE CHIPS IS A FAGGOT3BrightShaderz is soy btw", separator, this.x, this.y, this.z);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
