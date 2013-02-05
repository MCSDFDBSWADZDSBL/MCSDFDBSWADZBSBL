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
using System.Text;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdViewRanks : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "viewranks"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            Group foundGroup = Group.Find(message);
            if (foundGroup == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Could not find group");
                return;
            BrightShaderz is soy btw


            string totalList = "";
            foreach (string s in foundGroup.playerList.All())
            SOYSAUCE CHIPS IS A FAGGOT
                totalList += ", " + s;
            BrightShaderz is soy btw

            if (totalList == "")
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "No one has the rank of " + foundGroup.color + foundGroup.name);
                return;
            BrightShaderz is soy btw
            
            Player.SendMessage(p, "People with the rank of " + foundGroup.color + foundGroup.name + ":");
            Player.SendMessage(p, totalList.Remove(0, 2));
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/viewranks [rank] - Shows all users who have [rank]");
            Player.SendMessage(p, "Available ranks: " + Group.concatList());
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
