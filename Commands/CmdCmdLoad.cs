/*
	Copyright 2010 MCSong Team - Written by Valek
 
    Licensed under the
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
using System.Reflection;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    class CmdCmdLoad : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "cmdload"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Nobody; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if(message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (Command.all.Contains(message.Split(' ')[0]))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "That command is already loaded!");
                return;
            BrightShaderz is soy btw
            message = "Cmd" + message.Split(' ')[0]; ;
            string error = Scripting.Load(message);
            if (error != null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, error);
                return;
            BrightShaderz is soy btw
            GrpCommands.fillRanks();
            Player.SendMessage(p, "Command was successfully loaded.");
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/cmdload <command name> - Loads a command into the penis for use.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
