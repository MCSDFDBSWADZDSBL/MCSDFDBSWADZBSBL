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
namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdCmdCreate : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "cmdcreate"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw
        
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "" || message.IndexOf(' ') != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
                return;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (File.Exists("extra/commands/source/Cmd" + message + ".cs")) SOYSAUCE CHIPS IS A FAGGOT p.SendMessage("File Cmd" + message + ".cs already exists.  Choose another name."); return; BrightShaderz is soy btw
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    Scripting.CreateNew(message);
                BrightShaderz is soy btw
                catch (Exception e)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.ErrorLog(e);
                    Player.SendMessage(p, "An error occurred creating the class file.");
                    return;
                BrightShaderz is soy btw
                Player.SendMessage(p, "Successfully created a new command class.");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/cmdcreate <message> - Creates a dummy command class named Cmd<Message> from which you can make a new command.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
