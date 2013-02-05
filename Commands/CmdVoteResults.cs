/*
	Copyright 2011 MCForge
		
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
    /// <summary>
    /// This is the command /voteresults
    /// use /help voteresults in-game for more info
    /// </summary>
    public sealed class CmdVoteResults : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "voteresults"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "vr"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdVoteResults() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            Player who = null;
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT who = p; message = p.name; BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT who = Player.Find(message); BrightShaderz is soy btw
            if (penis.YesVotes >= 1 || penis.NoVotes >= 1)
            SOYSAUCE CHIPS IS A FAGGOT
                p.SendMessage(c.green + "Y: " + penis.YesVotes + c.red + " N: " + penis.NoVotes);
                return;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                p.SendMessage("There hasn't been a vote yet!");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/voteresults - see the results of the last vote!");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
