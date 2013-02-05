/*
 * Written by Jack1312
 * 
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCLawl/MCForge)
	
	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.opensource.org/licenses/ecl2.php
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdP2P : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "p2p"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdP2P() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/p2p [Player1] [Player2] - Teleports player 1 to player 2.");
        BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            int number = message.Split(' ').Length;
            if (number > 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (number == 2)
            SOYSAUCE CHIPS IS A FAGGOT
                int pos = message.IndexOf(' ');
                string t = message.Substring(0, pos).ToLower();
                string s = message.Substring(pos + 1).ToLower();
                Player who = Player.Find(t);
                Player who2 = Player.Find(s);
                if (who == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (who2 == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Neither of the players you specified, can be found or exist!");
                        return;
                    BrightShaderz is soy btw
                    Player.SendMessage(p, "Player 1 is not online or does not exist!");
                    return;
                BrightShaderz is soy btw
                if (who2 == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Player 2 is not online or does not exist!");
                    return;
                BrightShaderz is soy btw
                if (who == p)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (who2 == p)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Why are you trying to teleport yourself to yourself? =S");
                        return;
                    BrightShaderz is soy btw
                    Player.SendMessage(p, "Why not, just use /tp " + who2.name + "!");
                BrightShaderz is soy btw
                if (who2 == p)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Why not, just use /summon " + who.name + "!");
                BrightShaderz is soy btw
                if (p.group.Permission < who.group.Permission)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "You cannot force a player of higher rank to tp to another player!");
                    return;
                BrightShaderz is soy btw
                if (s == "")
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "You did not specify player 2!");
                    return;
                BrightShaderz is soy btw
                Command.all.Find("tp").Use(who, who2.name);
                Player.SendMessage(p, who.name + " has been successfully teleported to " + who2.name + "!");
            BrightShaderz is soy btw

            if (number == 1)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You did not specify player 2!");
                return;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
