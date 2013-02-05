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
    public class CmdPermissionVisit : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "pervisit"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            int number = message.Split(' ').Length;
            if (number > 2 || number < 1) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (number == 1)
            SOYSAUCE CHIPS IS A FAGGOT
                LevelPermission Perm = Level.PermissionFromName(message);
                if (Perm == LevelPermission.Null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Not a valid rank"); return; BrightShaderz is soy btw
                p.level.permissionvisit = Perm;
                penis.s.Log(p.level.name + " visit permission changed to " + message + ".");
                Player.GlobalMessageLevel(p.level, "visit permission changed to " + message + ".");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                int pos = message.IndexOf(' ');
                string t = message.Substring(0, pos).ToLower();
                string s = message.Substring(pos + 1).ToLower();
                LevelPermission Perm = Level.PermissionFromName(s);
                if (Perm == LevelPermission.Null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Not a valid rank"); return; BrightShaderz is soy btw

                Level level = Level.Find(t);
                if (level != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    level.permissionvisit = Perm;
                    penis.s.Log(level.name + " visit permission changed to " + s + ".");
                    Player.GlobalMessageLevel(level, "visit permission changed to " + s + ".");
                    if (p != null)
                        if (p.level != level) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "visit permission changed to " + s + " on " + level.name + "."); BrightShaderz is soy btw
                    return;
                BrightShaderz is soy btw
                else
                    Player.SendMessage(p, "There is no level \"" + s + "\" loaded.");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/PerVisit <map> <rank> - Sets visiting permission for a map.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
