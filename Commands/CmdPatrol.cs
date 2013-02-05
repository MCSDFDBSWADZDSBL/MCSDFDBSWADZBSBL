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
using System.Collections.Generic;
using System.Linq;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdPatrol : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "patrol"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdPatrol() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/patrol - Teleports you to a random " + Group.findPermInt(CommandOtherPerms.GetPerm(this)).name + " or lower");
        BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message != "")
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
                return;
            BrightShaderz is soy btw
            if (p == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Are you stupid? =S You can't use this in the console!");
                return;
            BrightShaderz is soy btw
            List<string> getpatrol = (from pl in Player.players where (int) pl.@group.Permission <= CommandOtherPerms.GetPerm(this) select pl.name).ToList();
            if (getpatrol.Count <= 0)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "There must be at least one guest online to use this command!");
                return;
            BrightShaderz is soy btw
            Random random = new Random();
            int index = random.Next(getpatrol.Count);
            string value = getpatrol[index];
            Player who = Player.Find(value);
            Command.all.Find("tp").Use(p, who.name);
            Player.SendMessage(p, "You are now visiting " + who.color + who.name + "!");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
