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
using System.Threading;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdLockdown : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "lockdown"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "ld"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!Directory.Exists("text/lockdown"))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Could not locate the folder creating one now.");
                Directory.CreateDirectory("text/lockdown");
                Directory.CreateDirectory("text/lockdown/map");
                Player.SendMessage(p, "Added the settings for the command");
            BrightShaderz is soy btw

            string[] param = message.Split(' ');


            if (param.Length == 2 && (param[0] == "map" || param[0] == "player"))
            SOYSAUCE CHIPS IS A FAGGOT
                if (param[0] == "map")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!Directory.Exists("text/lockdown/map"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.SendMessage("Could not locate the map folder, creating one now.");
                        Directory.CreateDirectory("text/lockdown/map");
                        p.SendMessage("Added the map settings Directory within 'text/lockdown'!");
                    BrightShaderz is soy btw

                    string filepath = "text/lockdown/map/" + param[1] + "";
                    bool mapIsLockedDown = File.Exists(filepath);

                    if (!mapIsLockedDown)
                    SOYSAUCE CHIPS IS A FAGGOT
                        File.Create(filepath).Dispose();
                        Player.GlobalMessage("The map " + param[1] + " has been locked");
                        Player.GlobalMessageOps("Locked by: " + ((p == null) ? "Console" : p.name));
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        File.Delete(filepath);
                        Player.GlobalMessage("The map " + param[1] + " has been unlocked");
                        Player.GlobalMessageOps("Unlocked by: " + ((p == null) ? "Console" : p.name));
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                if (param[0] == "player")
                SOYSAUCE CHIPS IS A FAGGOT
                    Player who = Player.Find(param[1]);

                    if (who == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "There is no player with such name online");
                        return;
                    BrightShaderz is soy btw

                    if (!who.jailed)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (p != null)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (who.group.Permission >= p.group.Permission)
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "Cannot lock down someone of equal or greater rank.");
                                return;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        if (p != null && who.level != p.level)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Moving player to your map...");
                            Command.all.Find("goto").Use(who, p.level.name);
                            int waits = 0;
                            while (who.Loading)
                            SOYSAUCE CHIPS IS A FAGGOT
                                Thread.Sleep(500);
                                // If they don't load in 10 seconds, eff it.
                                if (waits++ == 20)
                                    break;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        who.jailed = true;
                        Player.GlobalMessage(who.color + who.name + penis.DefaultColor + " has been locked down!");
                        Player.GlobalMessageOps("Locked by: " + ((p == null) ? "Console" : p.name));
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        who.jailed = false;
                        Player.GlobalMessage(who.color + who.name + penis.DefaultColor + " has been unlocked.");
                        Player.GlobalMessageOps("Unlocked by: " + ((p == null) ? "Console" : p.name));
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
                return;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, " use /lockdown map <mapname> to lock it down.");
            Player.SendMessage(p, " use /lockdown player <playername> to lock down player."); return;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
