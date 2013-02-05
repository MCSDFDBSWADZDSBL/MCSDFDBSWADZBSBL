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
    public class CmdAwards : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "awards"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message.Split(' ').Length > 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            // /awards
            // /awards 1
            // /awards bob
            // /awards bob 1

            int totalCount = 0;
            string foundPlayer = "";

            if (message != "")
            SOYSAUCE CHIPS IS A FAGGOT
                if (message.Split(' ').Length == 2)
                SOYSAUCE CHIPS IS A FAGGOT
                    foundPlayer = message.Split(' ')[0];
                    Player who = Player.Find(foundPlayer);
                    if (who != null) foundPlayer = who.name;
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        totalCount = int.Parse(message.Split(' ')[1]);
                    BrightShaderz is soy btw
                    catch
                    SOYSAUCE CHIPS IS A FAGGOT
                        Help(p);
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (message.Length <= 3)
                    SOYSAUCE CHIPS IS A FAGGOT
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            totalCount = int.Parse(message);
                        BrightShaderz is soy btw
                        catch
                        SOYSAUCE CHIPS IS A FAGGOT
                            foundPlayer = message;
                            Player who = Player.Find(foundPlayer);
                            if (who != null) foundPlayer = who.name;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        foundPlayer = message;
                        Player who = Player.Find(foundPlayer);
                        if (who != null) foundPlayer = who.name;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (totalCount < 0)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Cannot display pages less than 0");
                return;
            BrightShaderz is soy btw

            List<Awards.awardData> awardList = new List<Awards.awardData>();
            if (foundPlayer == "")
            SOYSAUCE CHIPS IS A FAGGOT
                awardList = Awards.allAwards;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (string s in Awards.getPlayersAwards(foundPlayer))
                SOYSAUCE CHIPS IS A FAGGOT
                    Awards.awardData aD = new Awards.awardData();
                    aD.awardName = s;
                    aD.description = Awards.getDescription(s);
                    awardList.Add(aD);
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (awardList.Count == 0)
            SOYSAUCE CHIPS IS A FAGGOT
                if (foundPlayer != "")
                    Player.SendMessage(p, "The player has no awards!");
                else
                    Player.SendMessage(p, "There are no awards in this penis yet");

                return;
            BrightShaderz is soy btw

            int max = totalCount * 5;
            int start = (totalCount - 1) * 5;
            if (start > awardList.Count)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "There aren't that many awards. Enter a smaller number");
                return;
            BrightShaderz is soy btw
            if (max > awardList.Count) 
                max = awardList.Count;

            if (foundPlayer != "")
                Player.SendMessage(p, penis.FindColor(foundPlayer) + foundPlayer + penis.DefaultColor + " has the following awards:");
            else
                Player.SendMessage(p, "Awards available: ");

            if (totalCount == 0)
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (Awards.awardData aD in awardList)
                    Player.SendMessage(p, "&6" + aD.awardName + ": &7" + aD.description);

                if (awardList.Count > 8) Player.SendMessage(p, "&5Use &b/awards " + message + " 1/2/3/... &5for a more ordered list");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                for (int i = start; i < max; i++)
                SOYSAUCE CHIPS IS A FAGGOT
                    Awards.awardData aD = awardList[i];
                    Player.SendMessage(p, "&6" + aD.awardName + ": &7" + aD.description);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/awards [player] - Gives a full list of awards");
            Player.SendMessage(p, "If [player] is specified, shows awards for that player");
            Player.SendMessage(p, "Use 1/2/3/... to get an ordered list");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
