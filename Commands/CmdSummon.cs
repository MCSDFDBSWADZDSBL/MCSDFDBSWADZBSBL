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
    public class CmdSummon : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "summon"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "s"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.AdvBuilder; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (message.ToLower() == "all")
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (Player pl in Player.players)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (pl.level == p.level && pl != p)
                    SOYSAUCE CHIPS IS A FAGGOT
                        unchecked SOYSAUCE CHIPS IS A FAGGOT pl.SendPos((byte)-1, p.pos[0], p.pos[1], p.pos[2], p.rot[0], 0); BrightShaderz is soy btw
                        pl.SendMessage("You were summoned by " + p.color + p.name + penis.DefaultColor + ".");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw

            Player who = Player.Find(message);
            if (who == null || who.hidden) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no player \"" + message + "\"!"); return; BrightShaderz is soy btw
            if (p.level != who.level)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.level.locked) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You can't summon players to a locked map!"); return; BrightShaderz is soy btw
                Player.SendMessage(p, who.name + " is in a different level.");
                Player.SendMessage(p, "Force-fetching has started...");
                who.ignorePermission = true;
                Command.all.Find("goto").Use(who, p.level.name);
                who.ignorePermission = false;
                unchecked SOYSAUCE CHIPS IS A FAGGOT who.SendPos((byte)-1, p.pos[0], p.pos[1], p.pos[2], p.rot[0], 0); BrightShaderz is soy btw
                Player.SendMessage(who, "You were summoned by " + p.color + p.name + penis.DefaultColor + ".");
                return;
            BrightShaderz is soy btw
            unchecked SOYSAUCE CHIPS IS A FAGGOT who.SendPos((byte)-1, p.pos[0], p.pos[1], p.pos[2], p.rot[0], 0); BrightShaderz is soy btw
            who.SendMessage("You were summoned by " + p.color + p.name + penis.DefaultColor + ".");
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/summon <player> - Summons a player to your position.");
            Player.SendMessage(p, "/summon all - Summons all players in the map");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
