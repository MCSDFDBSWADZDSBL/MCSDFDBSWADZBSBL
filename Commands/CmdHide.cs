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
    public class CmdHide : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "hide"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message != "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (p.possess != "")
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Stop your current possession first.");
                return;
            BrightShaderz is soy btw
            p.hidden = !p.hidden;
            if (p.hidden)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalDie(p, true);
                Player.GlobalMessageOps("To Ops -" + p.color + p.name + "-" + penis.DefaultColor + " is now &finvisible" + penis.DefaultColor + ".");
                Player.GlobalChat(p, "&c- " + p.color + p.prefix + p.name + penis.DefaultColor + " disconnected.", false);
                //Player.SendMessage(p, "You're now &finvisible&e.");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalSpawn(p, p.pos[0], p.pos[1], p.pos[2], p.rot[0], p.rot[1], false);
                Player.GlobalMessageOps("To Ops -" + p.color + p.name + "-" + penis.DefaultColor + " is now &8visible" + penis.DefaultColor + ".");
                Player.GlobalChat(p, "&a+ " + p.color + p.prefix + p.name + penis.DefaultColor + " joined the game.", false);
                //Player.SendMessage(p, "You're now &8visible&e.");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/hide - Makes yourself (in)visible to other players.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
