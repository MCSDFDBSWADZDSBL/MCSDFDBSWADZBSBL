/*
Copyright 2011 MCForge
Dual-licensed under the Educational Community License, Version 2.0 and
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
    public sealed class CmdSearch : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "search"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdSearch() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message.Split(' ').Length < 2)
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
                return;
            BrightShaderz is soy btw
            string type = message.Split(' ')[0];
            string keyword = message.Remove(0, (type.Length + 1));
            //
            if (type.ToLower().Contains("command") || type.ToLower().Contains("cmd"))
            SOYSAUCE CHIPS IS A FAGGOT
                bool mode = true;
                string[] keywords = keyword.Split(' ');
                string[] found = null;
                if (keywords.Length == 1) SOYSAUCE CHIPS IS A FAGGOT found = Commands.CommandKeywords.Find(keywords[0]); BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT found = Commands.CommandKeywords.Find(keywords); BrightShaderz is soy btw
                if (found == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No commands found matching keyword(s): '" + message.Remove(0, (type.Length + 1)) + "'"); BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "&bfound: ");
                    foreach (string s in found) SOYSAUCE CHIPS IS A FAGGOT if (mode) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "&2/" + s); BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "&9/" + s); BrightShaderz is soy btw mode = (mode) ? false : true; BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (type.ToLower().Contains("block"))
            SOYSAUCE CHIPS IS A FAGGOT
                string blocks = "";
                bool mode = true;
                for (byte i = 0; i < 255; i++)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (Block.Name(i).ToLower() != "unknown")
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (Block.Name(i).Contains(keyword))
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (mode) SOYSAUCE CHIPS IS A FAGGOT blocks += penis.DefaultColor + ", &9" + Block.Name(i); BrightShaderz is soy btw
                            else SOYSAUCE CHIPS IS A FAGGOT blocks += penis.DefaultColor + ", &2" + Block.Name(i); BrightShaderz is soy btw
                            mode = (mode) ? false : true;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (blocks == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No blocks found containing &b" + keyword); BrightShaderz is soy btw
                Player.SendMessage(p, blocks.Remove(0, 2));
            BrightShaderz is soy btw
            if (type.ToLower().Contains("rank"))
            SOYSAUCE CHIPS IS A FAGGOT
                string ranks = "";
                foreach (Group g in Group.GroupList)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (g.name.Contains(keyword)) 
                    SOYSAUCE CHIPS IS A FAGGOT
                        ranks += g.color + g.name + "'";
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (ranks == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No ranks found containing &b" + keyword); BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT foreach (string r in ranks.Split('\'')) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, r); BrightShaderz is soy btw BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (type.ToLower().Contains("player"))
            SOYSAUCE CHIPS IS A FAGGOT
                string players = "";
                foreach (Player who in Player.players)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (who.name.ToLower().Contains(keyword.ToLower()))
                    SOYSAUCE CHIPS IS A FAGGOT
                        players += ", " + who.color + who.name;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (players == "") SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No usernames found containing &b" + keyword); BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, players.Remove(0, 2)); BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "&b/search &2commands &a<keywords[more]> &e- finds commands with those keywords");
            Player.SendMessage(p, "&b/search &2blocks &a<keyword> &e- finds blocks with that keyword");
            Player.SendMessage(p, "&b/search &2ranks &a<keyword> &e- finds blocks with that keyword");
            Player.SendMessage(p, "&b/search &2players &a<keyword> &e- find players with that keyword");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
