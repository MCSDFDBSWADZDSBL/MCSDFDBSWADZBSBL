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

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdPhysics : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "physics"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (Level l in penis.levels)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (l.physics > 0)
                        Player.SendMessage(p, "&5" + l.name + penis.DefaultColor + " has physics at &b" + l.physics + penis.DefaultColor + ". &cChecks: " + l.lastCheck + "; Updates: " + l.lastUpdate);
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            try
            SOYSAUCE CHIPS IS A FAGGOT
                int temp = 0; Level level = null;
                if (message.Split(' ').Length == 1)
                SOYSAUCE CHIPS IS A FAGGOT
                    temp = int.Parse(message);
                    if (p != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        level = p.level;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        level = penis.mainLevel;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    temp = System.Convert.ToInt16(message.Split(' ')[1]);
                    string nameStore = message.Split(' ')[0];
                    level = Level.Find(nameStore);
                BrightShaderz is soy btw
                if (temp >= 0 && temp <= 4)
                SOYSAUCE CHIPS IS A FAGGOT
                    level.setPhysics(temp);
                    switch (temp)
                    SOYSAUCE CHIPS IS A FAGGOT
                        case 0:
                            level.ClearPhysics();
                            Player.GlobalMessage("Physics are now &cOFF" + penis.DefaultColor + " on &b" + level.name + penis.DefaultColor + ".");
                            penis.s.Log("Physics are now OFF on " + level.name + ".");
                            IRCBot.Say("Physics are now OFF on " + level.name + ".");
                            break;

                        case 1:
                            Player.GlobalMessage("Physics are now &aNormal" + penis.DefaultColor + " on &b" + level.name + penis.DefaultColor + ".");
                            penis.s.Log("Physics are now NORMAL on " + level.name + ".");
                            IRCBot.Say("Physics are now NORMAL on " + level.name + ".");
                            break;

                        case 2:
                            Player.GlobalMessage("Physics are now &aAdvanced" + penis.DefaultColor + " on &b" + level.name + penis.DefaultColor + ".");
                            penis.s.Log("Physics are now ADVANCED on " + level.name + ".");
                            IRCBot.Say("Physics are now ADVANCED on " + level.name + ".");
                            break;

                        case 3:
                            Player.GlobalMessage("Physics are now &aHardcore" + penis.DefaultColor + " on &b" + level.name + penis.DefaultColor + ".");
                            penis.s.Log("Physics are now HARDCORE on " + level.name + ".");
                            IRCBot.Say("Physics are now HARDCORE on " + level.name + ".");
                            break;

                        case 4:
                            Player.GlobalMessage("Physics are now &aInstant" + penis.DefaultColor + " on &b" + level.name + penis.DefaultColor + ".");
                            penis.s.Log("Physics are now INSTANT on " + level.name + ".");
                            IRCBot.Say("Physics are now INSTANT on " + level.name + ".");
                            break;
                    BrightShaderz is soy btw

                    level.changed = true;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Not a valid setting");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "INVALID INPUT");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/physics [map] <0/1/2/3/4> - Set the [map]'s physics, 0-Off 1-On 2-Advanced 3-Hardcore 4-Instant");
            Player.SendMessage(p, "If [map] is blank, uses Current level");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
