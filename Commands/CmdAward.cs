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

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdAward : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "award"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "" || message.IndexOf(' ') == -1) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            bool give = true;
            if (message.Split(' ')[0].ToLower() == "give")
            SOYSAUCE CHIPS IS A FAGGOT
                give = true;
                message = message.Substring(message.IndexOf(' ') + 1);
            BrightShaderz is soy btw
            else if (message.Split(' ')[0].ToLower() == "take")
            SOYSAUCE CHIPS IS A FAGGOT
                give = false;
                message = message.Substring(message.IndexOf(' ') + 1);
            BrightShaderz is soy btw
            
            string foundPlayer = message.Split(' ')[0];
            Player who = Player.Find(message);
            if (who != null) foundPlayer = who.name;
            string awardName = message.Substring(message.IndexOf(' ') + 1);
            if (!Awards.awardExists(awardName))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "The award you entered doesn't exist");
                Player.SendMessage(p, "Use /awards for a list of awards");
                return;
            BrightShaderz is soy btw

            if (give)
            SOYSAUCE CHIPS IS A FAGGOT
                if (Awards.giveAward(foundPlayer, awardName))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.GlobalChat(p, penis.FindColor(foundPlayer) + foundPlayer + penis.DefaultColor + " was awarded: &b" + Awards.camelCase(awardName), false);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "The player already has that award!");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (Awards.takeAward(foundPlayer, awardName))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.GlobalChat(p, penis.FindColor(foundPlayer) + foundPlayer + penis.DefaultColor + " had their &b" + Awards.camelCase(awardName) + penis.DefaultColor + " award removed", false);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "The player didn't have the award you tried to take");
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            Awards.Save();
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/award <give/take> [player] [award] - Gives [player] the [award]");
            Player.SendMessage(p, "If no Give or Take is given, Give is used");
            Player.SendMessage(p, "[award] needs to be the full award's name. Not partial");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
