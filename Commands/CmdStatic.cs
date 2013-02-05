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
using System.IO;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdStatic : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "static"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "t"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            p.staticCommands = !p.staticCommands;
            p.ClearBlockchange();
            p.BlockAction = 0;

            Player.SendMessage(p, "Static mode: &a" + p.staticCommands.ToString());

            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (message != "")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (message.IndexOf(' ') == -1)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (p.group.CanExecute(Command.all.Find(message)))
                            Command.all.Find(message).Use(p, "");
                        else
                            Player.SendMessage(p, "Cannot use that command.");
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (p.group.CanExecute(Command.all.Find(message.Split(' ')[0])))
                            Command.all.Find(message.Split(' ')[0]).Use(p, message.Substring(message.IndexOf(' ') + 1));
                        else
                            Player.SendMessage(p, "Cannot use that command.");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find specified command"); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/static [command] - Makes every command a toggle.");
            Player.SendMessage(p, "If [command] is given, then that command is used");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
