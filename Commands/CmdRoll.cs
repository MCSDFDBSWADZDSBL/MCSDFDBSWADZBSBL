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
    public class CmdRoll : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "roll"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            int min, max; Random rand = new Random();
            try SOYSAUCE CHIPS IS A FAGGOT min = int.Parse(message.Split(' ')[0]); BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT min = 1; BrightShaderz is soy btw
            try SOYSAUCE CHIPS IS A FAGGOT max = int.Parse(message.Split(' ')[1]); BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT max = 7; BrightShaderz is soy btw

            Player.GlobalMessage(p.color + p.name + penis.DefaultColor + " rolled a &a" + rand.Next(Math.Min(min, max), Math.Max(min, max) + 1).ToString() + penis.DefaultColor + " (" + Math.Min(min, max) + "|" + Math.Max(min, max) + ")");
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/roll [min] [max] - Rolls a random number between [min] and [max].");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
