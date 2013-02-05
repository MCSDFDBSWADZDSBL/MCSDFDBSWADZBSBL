/*
    Written by Jack1312
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
using System.IO;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdAllowGuns : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "allowguns"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "ag"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdAllowGuns() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "This command can only be used in-game!"); return; BrightShaderz is soy btw
            if (String.IsNullOrEmpty(message))
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.level.guns)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.guns = false;
                    Player.GlobalMessage("&9Gun usage has been disabled on &c" + p.level.name + "&9!");
                    Level.SaveSettings(p.level);

                    foreach (Player pl in Player.players)
                        if (pl.level == p.level)
                            pl.aiming = false;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    p.level.guns = true;
                    Player.GlobalMessage("&9Gun usage has been enabled on &c" + p.level.name + "&9!");
                    Level.SaveSettings(p.level);
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw







            if (p != null)
            SOYSAUCE CHIPS IS A FAGGOT
                Level foundLevel;
                if (message == "")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.level.guns == true)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.level.guns = false;
                        Player.GlobalMessage("&9Gun usage has been disabled on &c" + p.level.name + "&9!");
                        Level.SaveSettings(p.level);
                        foreach (Player pl in Player.players)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (pl.level.name.ToLower() == p.level.name.ToLower())
                            SOYSAUCE CHIPS IS A FAGGOT
                                pl.aiming = false;
                                p.aiming = false;
                                return;
                            BrightShaderz is soy btw
                            return;
                        BrightShaderz is soy btw
                        return;
                    BrightShaderz is soy btw
                    if (p.level.guns == false)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.level.guns = true;
                        Player.GlobalMessage("&9Gun usage has been enabled on &c" + p.level.name + "&9!");
                        Level.SaveSettings(p.level);
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                if (message != "")
                SOYSAUCE CHIPS IS A FAGGOT
                    foundLevel = Level.Find(message);
                    if (!File.Exists("levels/" + message + ".lvl"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "&9The level, &c" + message + " &9does not exist!"); return;
                    BrightShaderz is soy btw
                    if (foundLevel.guns == true)
                    SOYSAUCE CHIPS IS A FAGGOT
                        foundLevel.guns = false;
                        Player.GlobalMessage("&9Gun usage has been disabled on &c" + message + "&9!");
                        Level.SaveSettings(foundLevel);
                        foreach (Player pl in Player.players)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (pl.level.name.ToLower() == message.ToLower())
                            SOYSAUCE CHIPS IS A FAGGOT
                                pl.aiming = false;
                            BrightShaderz is soy btw
                            if (p.level.name.ToLower() == message.ToLower())
                            SOYSAUCE CHIPS IS A FAGGOT
                                p.aiming = false;

                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        foundLevel.guns = true;
                        Player.GlobalMessage("&9Gun usage has been enabled on &c" + message + "&9!");
                        Level.SaveSettings(foundLevel);
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (p == null)
            SOYSAUCE CHIPS IS A FAGGOT
                if (message == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "You must specify a level!");
                    return;
                BrightShaderz is soy btw
                Level foundLevel;
                foundLevel = Level.Find(message);
                if (!File.Exists("levels/" + message + ".lvl"))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "The level, " + message + " does not exist!"); return;
                BrightShaderz is soy btw
                if (foundLevel.guns == true)
                SOYSAUCE CHIPS IS A FAGGOT
                    foundLevel.guns = false;
                    Player.GlobalMessage("&9Gun usage has been disabled on &c" + message + "&9!");
                    Level.SaveSettings(foundLevel);
                    Player.SendMessage(p, "Gun usage has been disabled on " + message + "!");
                    foreach (Player pl in Player.players)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (pl.level.name.ToLower() == message.ToLower())
                        SOYSAUCE CHIPS IS A FAGGOT
                            pl.aiming = false;
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                foundLevel.guns = true;
                Player.GlobalMessage("&9Gun usage has been enabled on &c" + message + "&9!");
                Level.SaveSettings(foundLevel);
                Player.SendMessage(p, "Gun usage has been enabled on " + message + "!");
                return;
            BrightShaderz is soy btw
        BrightShaderz is soy btw



        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/allowguns - Allow/disallow guns and missiles on the specified level. If no message is given, the current level is taken.");
            Player.SendMessage(p, "Note: If guns are allowed on a map, and /allowguns is used, all guns and missiles will be disabled.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
