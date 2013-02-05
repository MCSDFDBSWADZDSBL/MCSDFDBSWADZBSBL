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
    /// This is the command /vote
    /// </summary>
    public sealed class CmdVote : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "vote"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "vo"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdVote() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message != "")
            SOYSAUCE CHIPS IS A FAGGOT
                if (!penis.voting)
                SOYSAUCE CHIPS IS A FAGGOT
                    string temp = message.Substring(0, 1) == "%" ? "" : penis.DefaultColor;
                    penis.voting = true;
                    penis.NoVotes = 0;
                    penis.YesVotes = 0;
                    Player.GlobalMessage(" " + c.green + "VOTE: " + temp + message + "(" + c.green + "Yes " + penis.DefaultColor + "/" + c.red + "No" + penis.DefaultColor + ")");
                    System.Threading.Thread.Sleep(15000);
                    penis.voting = false;
                    Player.GlobalMessage("The vote is in! " + c.green + "Y: " + penis.YesVotes + c.red + " N: " + penis.NoVotes);
                    Player.players.ForEach(delegate(Player winners)
                    SOYSAUCE CHIPS IS A FAGGOT
                        winners.voted = false;
                    BrightShaderz is soy btw);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    p.SendMessage("A vote is in progress!");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            p.SendMessage("/vote [message] - Obviously starts a vote!");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
