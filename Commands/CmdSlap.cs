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
    public class CmdSlap : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "slap"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            Player who = Player.Find(message);

            if (who == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Could not find player specified");
                return;
            BrightShaderz is soy btw

            ushort currentX = (ushort)(who.pos[0] / 32);
            ushort currentY = (ushort)(who.pos[1] / 32);
            ushort currentZ = (ushort)(who.pos[2] / 32);
            ushort foundHeight = 0;

            for (ushort yy = currentY; yy <= 1000; yy++)
            SOYSAUCE CHIPS IS A FAGGOT
                if (!Block.Walkthrough(p.level.GetTile(currentX, yy, currentZ)) && p.level.GetTile(currentX, yy, currentZ) != Block.Zero)
                SOYSAUCE CHIPS IS A FAGGOT
                    foundHeight = (ushort)(yy - 1);
                    who.level.ChatLevel(who.color + who.name + penis.DefaultColor + " was slapped into the roof by " + p.color + p.name);
                    break;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (foundHeight == 0)
            SOYSAUCE CHIPS IS A FAGGOT
                who.level.ChatLevel(who.color + who.name + penis.DefaultColor + " was slapped sky high by " + p.color + p.name);
                foundHeight = 1000;
            BrightShaderz is soy btw
            
            unchecked SOYSAUCE CHIPS IS A FAGGOT who.SendPos((byte)-1, who.pos[0], (ushort)(foundHeight * 32), who.pos[2], who.rot[0], who.rot[1]); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/slap <name> - Slaps <name>, knocking them into the air");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
