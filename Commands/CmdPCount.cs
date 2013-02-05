/*
	Copyright 2010 MCSong Team - Written by Valek
 
    Licensed under the
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
using System.Data;
using System.IO;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    class CmdPCount : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "pcount"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            int bancount = Group.findPerm(LevelPermission.Banned).playerList.All().Count;

            DataTable count = MySQL.fillData("SELECT COUNT(id) FROM players");
            Player.SendMessage(p, "A total of " + count.Rows[0]["COUNT(id)"] + " unique players have visited this penis.");
            Player.SendMessage(p, "Of these players, " + bancount + " have been banned.");
            count.Dispose();

            int playerCount = 0;
            int hiddenCount = 0;
           
            foreach (Player pl in Player.players)
            SOYSAUCE CHIPS IS A FAGGOT
                if (!pl.hidden || p.group.Permission > LevelPermission.AdvBuilder || penis.devs.Contains(p.name.ToLower()))
                SOYSAUCE CHIPS IS A FAGGOT
                    playerCount++;
                    if (pl.hidden && (p.group.Permission > LevelPermission.AdvBuilder || penis.devs.Contains(p.name.ToLower())))
                    SOYSAUCE CHIPS IS A FAGGOT
                        hiddenCount++;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (playerCount == 1)
            SOYSAUCE CHIPS IS A FAGGOT
                if (hiddenCount == 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "There is 1 player currently online.");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "There is 1 player currently online (" + hiddenCount + " hidden).");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (hiddenCount == 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "There are " + playerCount + " players online.");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "There are " + playerCount + " players online (" + hiddenCount + " hidden).");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/pcount - Displays the number of players online and total.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
