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
    public class CmdBotRemove : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "botremove"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw
        public string[,] botlist;

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (message.ToLower() == "all")
                SOYSAUCE CHIPS IS A FAGGOT
                    for (int i = 0; i < PlayerBot.playerbots.Count; i++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (PlayerBot.playerbots[i].level == p.level)
                        SOYSAUCE CHIPS IS A FAGGOT
                            //   PlayerBot.playerbots.Remove(PlayerBot.playerbots[i]);
                            PlayerBot Pb = PlayerBot.playerbots[i];
                            Pb.removeBot();
                            i--;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    PlayerBot who = PlayerBot.Find(message);
                    if (who == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no bot " + who + "!"); return; BrightShaderz is soy btw
                    if (p.level != who.level) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, who.name + " is in a different level."); return; BrightShaderz is soy btw
                    who.removeBot();
                    Player.SendMessage(p, "Removed bot.");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); Player.SendMessage(p, "Error caught"); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/botremove <name> - Remove a bot on the same level as you");
            //   Player.SendMessage(p, "If All is used, all bots on the current level are removed");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
