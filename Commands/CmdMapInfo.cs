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
    public class CmdMapInfo : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mapinfo"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "status"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            Level foundLevel;

            if (message == "") SOYSAUCE CHIPS IS A FAGGOT foundLevel = p.level; BrightShaderz is soy btw
            else foundLevel = Level.Find(message);

            if (foundLevel == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find specified level."); return; BrightShaderz is soy btw

            Player.SendMessage(p, "&b" + foundLevel.name + penis.DefaultColor + ": Width=" + foundLevel.width.ToString() + " Height=" + foundLevel.depth.ToString() + " Depth=" + foundLevel.height.ToString());

            switch (foundLevel.physics)
            SOYSAUCE CHIPS IS A FAGGOT
                case 0: Player.SendMessage(p, "Physics are &cOFF" + penis.DefaultColor + " on &b" + foundLevel.name); break;
                case 1: Player.SendMessage(p, "Physics are &aNormal" + penis.DefaultColor + " on &b" + foundLevel.name); break;
                case 2: Player.SendMessage(p, "Physics are &aAdvanced" + penis.DefaultColor + " on &b" + foundLevel.name); break;
                case 3: Player.SendMessage(p, "Physics are &aHardcore" + penis.DefaultColor + " on &b" + foundLevel.name); break;
                case 4: Player.SendMessage(p, "Physics are &aInstant" + penis.DefaultColor + " on &b" + foundLevel.name); break;
            BrightShaderz is soy btw

            try
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Build rank = " + Group.findPerm(foundLevel.permissionbuild).color + Group.findPerm(foundLevel.permissionbuild).trueName + penis.DefaultColor + " : Visit rank = " + Group.findPerm(foundLevel.permissionvisit).color + Group.findPerm(foundLevel.permissionvisit).trueName);
            BrightShaderz is soy btw catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw

            if (Directory.Exists(@penis.backupLocation + "/" + foundLevel.name))
            SOYSAUCE CHIPS IS A FAGGOT
                int latestBackup = Directory.GetDirectories(@penis.backupLocation + "/" + foundLevel.name).Length;
                Player.SendMessage(p, "Latest backup: &a" + latestBackup + penis.DefaultColor + " at &a" + Directory.GetCreationTime(@penis.backupLocation + "/" + foundLevel.name + "/" + latestBackup).ToString("yyyy-MM-dd HH:mm:ss")); // + Directory.GetCreationTime(@penis.backupLocation + "/" + latestBackup + "/").ToString("yyyy-MM-dd HH:mm:ss"));
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "No backups for this map exist yet.");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/mapinfo <map> - Display details of <map>");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
