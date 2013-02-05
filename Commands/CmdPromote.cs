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
    public class CmdPromote : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "promote"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "pr"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "" || message.IndexOf(' ') != -1) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            Player who = Player.Find(message);
            string foundName;
            Group foundGroup;
            if (who == null)
            SOYSAUCE CHIPS IS A FAGGOT
                foundName = message;
                foundGroup = Group.findPlayerGroup(message);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                foundName = who.name;
                foundGroup = who.group;
            BrightShaderz is soy btw

            Group nextGroup = null; bool nextOne = false;
            for (int i = 0; i < Group.GroupList.Count; i++)
            SOYSAUCE CHIPS IS A FAGGOT
                Group grp = Group.GroupList[i];
                if (nextOne)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (grp.Permission >= LevelPermission.Nobody) break;
                    nextGroup = grp;
                    break;
                BrightShaderz is soy btw
                if (grp == foundGroup)
                    nextOne = true;
            BrightShaderz is soy btw

            if (nextGroup != null)
                Command.all.Find("setrank").Use(p, foundName + " " + nextGroup.name);
            else
                Player.SendMessage(p, "No higher ranks exist");
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/promote <name> - Promotes <name> up a rank");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
