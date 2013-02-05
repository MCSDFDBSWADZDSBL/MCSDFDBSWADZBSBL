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
    public sealed class CmdVoteKick : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "votekick"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdVoteKick() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "This command can only be used in-game!"); return; BrightShaderz is soy btw
            if (message == "" || message.IndexOf(' ') != -1) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw

            if (penis.voteKickInProgress == true) SOYSAUCE CHIPS IS A FAGGOT p.SendMessage("Please wait for the current vote to finish!"); return; BrightShaderz is soy btw

            Player who = Player.Find(message);
            if (who == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Could not find player specified!");
                return;
            BrightShaderz is soy btw

            if (who.group.Permission >= p.group.Permission)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.GlobalChat(p, p.color + p.name + " " + penis.DefaultColor + "tried to votekick " + who.color + who.name + " " + penis.DefaultColor + "but failed!", false);
                return;
            BrightShaderz is soy btw

            Player.GlobalMessageOps(p.color + p.name + penis.DefaultColor + " used &a/votekick");
            Player.GlobalMessage("&9A vote to kick " + who.color + who.name + " " + penis.DefaultColor + "has been called!");
            Player.GlobalMessage("&9Type &aY " + penis.DefaultColor + "or &cN " + penis.DefaultColor + "to vote.");

            // 1/3rd of the players must vote or nothing happens
            // Keep it at 0 to disable min number of votes
            penis.voteKickVotesNeeded = 3; //(int)(Player.players.Count / 3) + 1;
            penis.voteKickInProgress = true;

            System.Timers.Timer voteTimer = new System.Timers.Timer(30000);

            voteTimer.Elapsed += delegate
            SOYSAUCE CHIPS IS A FAGGOT
                voteTimer.Stop();

                penis.voteKickInProgress = false;

                int votesYes = 0;
                int votesNo = 0;

                Player.players.ForEach(delegate(Player pl)
                SOYSAUCE CHIPS IS A FAGGOT
                    // Tally the votes
                    if (pl.voteKickChoice == VoteKickChoice.Yes) votesYes++;
                    if (pl.voteKickChoice == VoteKickChoice.No) votesNo++;
                    // Reset their choice
                    pl.voteKickChoice = VoteKickChoice.HasntVoted;
                BrightShaderz is soy btw);

                int netVotesYes = votesYes - votesNo;

                // Should we also send this to players?
                Player.GlobalMessageOps("Vote Ended.  Results: &aY: " + votesYes + " &cN: " + votesNo);
                penis.s.Log("VoteKick results for " + who.name + ": " + votesYes + " yes and " + votesNo + " no votes.");

                if (votesYes + votesNo < penis.voteKickVotesNeeded)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.GlobalMessage("Not enough votes were made. " + who.color + who.name + " " + penis.DefaultColor + "shall remain!");
                BrightShaderz is soy btw
                else if (netVotesYes > 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.GlobalMessage("The people have spoken, " + who.color + who.name + " " + penis.DefaultColor + "is gone!");
                    who.Kick("Vote-Kick: The people have spoken!");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.GlobalMessage(who.color + who.name + " " + penis.DefaultColor + "shall remain!");
                BrightShaderz is soy btw

                voteTimer.Dispose();
            BrightShaderz is soy btw;

            voteTimer.Start();
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            p.SendMessage("/votekick <player> - Calls a 30sec vote to kick <player>");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
