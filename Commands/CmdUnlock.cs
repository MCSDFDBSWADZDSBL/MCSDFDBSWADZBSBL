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
    public sealed class CmdUnlock : Command
    SOYSAUCE CHIPS IS A FAGGOT
        // The command's name, in all lowercase.  What you'll be putting behind the slash when using it.
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "unlock"; BrightShaderz is soy btw BrightShaderz is soy btw

        // Command's shortcut (please take care not to use an existing one, or you may have issues.
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "ul"; BrightShaderz is soy btw BrightShaderz is soy btw

        // Determines which submenu the command displays in under /help.
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw

        // Determines whether or not this command can be used in a museum.  Block/map altering commands should be made false to avoid errors.
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw

        // Determines the command's default rank.  Valid values are:
        // LevelPermission.Nobody, LevelPermission.Banned, LevelPermission.Guest
        // LevelPermission.Builder, LevelPermission.AdvBuilder, LevelPermission.Operator, LevelPermission.Admin
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        // This is where the magic happens, naturally.
        // p is the player object for the player executing the command.  message is everything after the command invocation itself.
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!Directory.Exists("text/lockdown"))
            SOYSAUCE CHIPS IS A FAGGOT
                p.SendMessage("Could not locate the folder creating one now.");
                Directory.CreateDirectory("text/lockdown");
                Directory.CreateDirectory("text/lockdown/map");
                p.SendMessage("Added the settings for the command.");
            BrightShaderz is soy btw
            string[] param = message.Split(' ');
            if (param.Length == 2 && (param[0] == "map" || param[0] == "player"))
            SOYSAUCE CHIPS IS A FAGGOT
                if (param.Length == 2)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (param[0] == "map")
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (File.Exists("text/lockdown/map/" + param[1] + ""))
                        SOYSAUCE CHIPS IS A FAGGOT
                            File.Delete("text/lockdown/map/" + param[1] + "");
                            Player.SendMessage(p, "The map " + param[1] + " has been unlocked.");
                        BrightShaderz is soy btw
                        else
                            Player.SendMessage(p, "The map " + param[1] + " is not locked or does not exist.");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (param.Length == 2) // shift number to the next lockdown command
                SOYSAUCE CHIPS IS A FAGGOT
                    if (param[0] == "player")
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player who = Player.Find(param[1]);
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (who != null)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (who.jailed)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (p != null) if (who.group.Permission >= p.group.Permission) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Cannot lock down someone of equal or greater rank."); return; BrightShaderz is soy btw
                                    if (who.level != p.level) Command.all.Find("goto").Use(who, p.level.name);
                                    who.jailed = false;
                                    Player.GlobalMessage(who.color + who.name + penis.DefaultColor + " has been unlocked!", true);
                                    return;
                                BrightShaderz is soy btw
                                else Player.SendMessage(p, "The player " + param[1] + " is not locked down."); return;
                            BrightShaderz is soy btw
                            else Player.SendMessage(p, "There is no such player online!"); return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw

                BrightShaderz is soy btw
            BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
                return;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "Use /unlock map <mapname> to unlock it (open it).");
            Player.SendMessage(p, "Use /unlock player <playername> to unlock player."); return;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
