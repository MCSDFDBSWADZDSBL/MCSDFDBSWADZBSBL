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
using System.IO;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdXJail : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "xjail"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "xj"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/xjail <player> - Mutes <player>, freezes <player> and sends <player> to the XJail map (shortcut = /xj)");
            Player.SendMessage(p, "If <player> is already jailed, <player> will be spawned, unfrozen and unmuted");
            Player.SendMessage(p, "/xjail set - Sets the map to be used for xjail to your current map and sets jail to current location");
        BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            string dir = "extra/jail/";
            string jailMapFile = dir + "xjail.map.xjail";
            if (!Directory.Exists(dir)) SOYSAUCE CHIPS IS A FAGGOT Directory.CreateDirectory(dir); BrightShaderz is soy btw
            if (!File.Exists(jailMapFile))
            SOYSAUCE CHIPS IS A FAGGOT
                using (StreamWriter SW = new StreamWriter(jailMapFile))
                SOYSAUCE CHIPS IS A FAGGOT
                    SW.WriteLine(penis.mainLevel.name);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                using (StreamReader SR = new StreamReader(jailMapFile))
                SOYSAUCE CHIPS IS A FAGGOT
                    string xjailMap = SR.ReadLine();
                    SR.Close();
                    Command jail = Command.all.Find("jail");
                    if (message == "set")
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!p.level.name.Contains("cMuseum"))
                        SOYSAUCE CHIPS IS A FAGGOT
                            jail.Use(p, "create");
                            using (StreamWriter SW = new StreamWriter(jailMapFile))
                            SOYSAUCE CHIPS IS A FAGGOT
                                SW.WriteLine(p.level.name);
                            BrightShaderz is soy btw
                            Player.SendMessage(p, "The xjail map was set from '" + xjailMap + "' to '" + p.level.name + "'");
                            return;
                        BrightShaderz is soy btw
                        else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You are in a museum!"); return; BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player player = Player.Find(message);

                        if (player != null)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Command move = Command.all.Find("move");
                            Command spawn = Command.all.Find("spawn");
                            Command freeze = Command.all.Find("freeze");
                            Command mute = Command.all.Find("mute");
                            string playerFile = dir + player.name + "_temp.xjail";
                            if (!File.Exists(playerFile))
                            SOYSAUCE CHIPS IS A FAGGOT
                                using (StreamWriter writeFile = new StreamWriter(playerFile))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    writeFile.WriteLine(player.level.name);
                                BrightShaderz is soy btw
                                if (!player.muted) SOYSAUCE CHIPS IS A FAGGOT mute.Use(p, message); BrightShaderz is soy btw
                                if (!player.frozen) SOYSAUCE CHIPS IS A FAGGOT freeze.Use(p, message); BrightShaderz is soy btw
                                move.Use(p, message + " " + xjailMap);
                                while (player.Loading)
                                SOYSAUCE CHIPS IS A FAGGOT
                                BrightShaderz is soy btw
                                if (!player.jailed) SOYSAUCE CHIPS IS A FAGGOT jail.Use(p, message); BrightShaderz is soy btw
                                Player.GlobalMessage(player.color + player.name + penis.DefaultColor + " was XJailed!");
                                return;
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                using (StreamReader readFile = new StreamReader(playerFile))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    string playerMap = readFile.ReadLine();
                                    readFile.Close();
                                    File.Delete(playerFile);
                                    move.Use(p, message + " " + playerMap);
                                    while (player.Loading)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                    BrightShaderz is soy btw
                                    mute.Use(p, message);
                                    jail.Use(p, message);
                                    freeze.Use(p, message);
                                    spawn.Use(player, "");
                                    Player.GlobalMessage(player.color + player.name + penis.DefaultColor + " was released from XJail!");
                                BrightShaderz is soy btw
                                return;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Player not found"); return; BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
