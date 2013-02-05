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
    public class CmdClick : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "click"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "x"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            string[] parameters = message.Split(' ');
            ushort[] click = p.lastClick;

            if (message.IndexOf(' ') != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                if (parameters.Length != 3)
                SOYSAUCE CHIPS IS A FAGGOT
                    Help(p);
                    return;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    for (int value = 0; value < 3; value++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (parameters[value].ToLower() == "x" || parameters[value].ToLower() == "y" || parameters[value].ToLower() == "z")
                            click[value] = p.lastClick[value];
                        else if (isValid(parameters[value], value, p))
                            click[value] = ushort.Parse(parameters[value]);
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "\"" + parameters[value] + "\" was not valid");
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            p.manualChange(click[0], click[1], click[2], 0, Block.rock);
            Player.SendMessage(p, "Clicked &b(" + click[0] + ", " + click[1] + ", " + click[2] + ")");
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/click [x y z] - Fakes a click");
            Player.SendMessage(p, "If no xyz is given, it uses the last place clicked");
            Player.SendMessage(p, "/click 200 y 200 will cause it to click at 200x, last y and 200z");
        BrightShaderz is soy btw

        private bool isValid(string message, int dimension, Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            ushort testValue;
            try SOYSAUCE CHIPS IS A FAGGOT
                testValue = ushort.Parse(message);
            BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw

            if (testValue < 0)
                return false;

            if (testValue >= p.level.width && dimension == 0) return false;
            else if (testValue >= p.level.depth && dimension == 1) return false;
            else if (testValue >= p.level.height && dimension == 2) return false;

            return true;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
