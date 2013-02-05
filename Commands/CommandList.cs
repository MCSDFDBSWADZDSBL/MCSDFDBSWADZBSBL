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
using System.Collections.Generic;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CommandList
    SOYSAUCE CHIPS IS A FAGGOT
        public List<Command> commands = new List<Command>();
        public CommandList() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public void Add(Command cmd) SOYSAUCE CHIPS IS A FAGGOT commands.Add(cmd); BrightShaderz is soy btw
        public void AddRange(List<Command> listCommands)
        SOYSAUCE CHIPS IS A FAGGOT
            listCommands.ForEach(delegate(Command cmd) SOYSAUCE CHIPS IS A FAGGOT commands.Add(cmd); BrightShaderz is soy btw);
        BrightShaderz is soy btw
        public List<string> commandNames()
        SOYSAUCE CHIPS IS A FAGGOT
            List<string> tempList = new List<string>();

            commands.ForEach(delegate(Command cmd)
            SOYSAUCE CHIPS IS A FAGGOT
                tempList.Add(cmd.name);
            BrightShaderz is soy btw);

            return tempList;
        BrightShaderz is soy btw

        public bool Remove(Command cmd) SOYSAUCE CHIPS IS A FAGGOT return commands.Remove(cmd); BrightShaderz is soy btw
        public bool Contains(Command cmd) SOYSAUCE CHIPS IS A FAGGOT return commands.Contains(cmd); BrightShaderz is soy btw
        public bool Contains(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            name = name.ToLower(); foreach (Command cmd in commands)
            SOYSAUCE CHIPS IS A FAGGOT
                if (cmd.name == name.ToLower()) SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw
            BrightShaderz is soy btw return false;
        BrightShaderz is soy btw
        public Command Find(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            name = name.ToLower(); foreach (Command cmd in commands)
            SOYSAUCE CHIPS IS A FAGGOT
                if (cmd.name == name.ToLower() || cmd.shortcut == name.ToLower()) SOYSAUCE CHIPS IS A FAGGOT return cmd; BrightShaderz is soy btw
            BrightShaderz is soy btw return null;
        BrightShaderz is soy btw

        public string FindShort(string shortcut)
        SOYSAUCE CHIPS IS A FAGGOT
            if (shortcut == "") return "";

            shortcut = shortcut.ToLower();
            foreach (Command cmd in commands)
            SOYSAUCE CHIPS IS A FAGGOT
                if (cmd.shortcut == shortcut) return cmd.name;
            BrightShaderz is soy btw
            return "";
        BrightShaderz is soy btw

        public List<Command> All() SOYSAUCE CHIPS IS A FAGGOT return new List<Command>(commands); BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
