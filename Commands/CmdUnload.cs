/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCSong) under the
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
using System.IO;
using System.Collections.Generic;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdUnload : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "unload"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message.ToLower() == "empty")
            SOYSAUCE CHIPS IS A FAGGOT
                Boolean Empty = true;

                foreach (Level l in penis.levels)
                SOYSAUCE CHIPS IS A FAGGOT
                    Empty = true;
                    Player.players.ForEach(delegate(Player pl)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (pl.level == l) Empty = false;
                    BrightShaderz is soy btw);

                    if (Empty == true && l.unload)
                    SOYSAUCE CHIPS IS A FAGGOT
                        l.Unload();
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                Player.SendMessage(p, "No levels were empty.");
                return;
            BrightShaderz is soy btw

            Level level = Level.Find(message);

            if (level != null)
            SOYSAUCE CHIPS IS A FAGGOT
                if (!level.Unload()) Player.SendMessage(p, "You cannot unload the main level.");
                return;
            BrightShaderz is soy btw

            Player.SendMessage(p, "There is no level \"" + message + "\" loaded.");
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/unload [level] - Unloads a level.");
            Player.SendMessage(p, "/unload empty - Unloads an empty level.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
