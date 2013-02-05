/*
	Copyright 2011 MCForge
		
	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.osedu.org/licenses/ECL-2.0
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
    public sealed class CmdReload : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "reload"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "rd"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdReload() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/reload <map> - Reloads the specified map. Uses the current map if no message is given.");
        BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            SOYSAUCE CHIPS IS A FAGGOT
                if (!File.Exists("levels/" + message + ".lvl"))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "The specified level does not exist!");
                    return;
                BrightShaderz is soy btw
                if (penis.mainLevel.name == message)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "You cannot reload the main level!");
                    return;
                BrightShaderz is soy btw
                if (p == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    SOYSAUCE CHIPS IS A FAGGOT
                        foreach (Player pl in Player.players)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (pl.level.name.ToLower() == message.ToLower())
                            SOYSAUCE CHIPS IS A FAGGOT
                                Command.all.Find("unload").Use(p, message);
                                Command.all.Find("load").Use(p, message);
                                Command.all.Find("goto").Use(pl, message);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        Player.GlobalMessage("&cThe map, " + message + " has been reloaded!");
                        //IRCBot.Say("The map, " + message + " has been reloaded.");
                        penis.IRC.Say("The map, " + message + " has been reloaded.");
                        penis.s.Log("The map, " + message + " was reloaded by the console");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (p != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    SOYSAUCE CHIPS IS A FAGGOT
                        foreach (Player pl in Player.players)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (pl.level.name.ToLower() == message.ToLower())
                            SOYSAUCE CHIPS IS A FAGGOT
                                p.ignorePermission = true;
                                Command.all.Find("unload").Use(p, message);
                                Command.all.Find("load").Use(p, message);
                                Command.all.Find("goto").Use(pl, message);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        Player.GlobalMessage("&cThe map, " + message + " has been reloaded!");
						//IRCBot.Say("The map, " + message + " has been reloaded.");
                        penis.IRC.Say("The map, " + message + " has been reloaded.");
						penis.s.Log("The map, " + message + " was reloaded by " + p.name);
						p.ignorePermission = false;
						return;
					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
