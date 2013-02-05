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
    class CmdPlayers : Command
    SOYSAUCE CHIPS IS A FAGGOT

        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "players"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        struct groups SOYSAUCE CHIPS IS A FAGGOT public Group group; public List<string> players; BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                List<groups> playerList = new List<groups>();

                foreach (Group grp in Group.GroupList)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (grp.name != "nobody")
                    SOYSAUCE CHIPS IS A FAGGOT
                        groups groups;
                        groups.group = grp;
                        groups.players = new List<string>();
                        playerList.Add(groups);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                string devs = "";
                int totalPlayers = 0;
                foreach (Player pl in Player.players)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!pl.hidden || p.group.Permission > LevelPermission.AdvBuilder || penis.devs.Contains(p.name.ToLower()))
                    SOYSAUCE CHIPS IS A FAGGOT
                        totalPlayers++;
                        string foundName = pl.name;

                        if (penis.afkset.Contains(pl.name))
                        SOYSAUCE CHIPS IS A FAGGOT
                            foundName = pl.name + "-afk";
                        BrightShaderz is soy btw

                        if (penis.devs.Contains(pl.name.ToLower()))
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (pl.voice)
                                devs += " " + "&f+" + penis.DefaultColor + foundName + " (" + pl.level.name + "),";
                            else
                                devs += " " + foundName + " (" + pl.level.name + "),";
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (pl.voice)
                                playerList.Find(grp => grp.group == pl.group).players.Add("&f+" + penis.DefaultColor + foundName + " (" + pl.level.name + ")");
                            else
                                playerList.Find(grp => grp.group == pl.group).players.Add(foundName + " (" + pl.level.name + ")");
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                Player.SendMessage(p, "There are " + totalPlayers + " players online.");
                if (devs.Length > 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, ":&9Developers:" + penis.DefaultColor + devs.Trim(','));
                BrightShaderz is soy btw

                for (int i = playerList.Count - 1; i >= 0; i--)
                SOYSAUCE CHIPS IS A FAGGOT
                    groups groups = playerList[i];
                    string appendString = "";

                    foreach (string player in groups.players)
                    SOYSAUCE CHIPS IS A FAGGOT
                        appendString += ", " + player;
                    BrightShaderz is soy btw

                    if (appendString != "")
                        appendString = appendString.Remove(0, 2);
                    appendString = ":" + groups.group.color + getPlural(groups.group.trueName) + ": " + appendString;

                    Player.SendMessage(p, appendString);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw

        public string getPlural(string groupName)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                string last2 = groupName.Substring(groupName.Length - 2).ToLower();
                if ((last2 != "ed" || groupName.Length <= 3) && last2[1] != 's')
                SOYSAUCE CHIPS IS A FAGGOT
                    return groupName + "s";
                BrightShaderz is soy btw
                return groupName;
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT
                return groupName;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/players - Shows name and general rank of all players");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
