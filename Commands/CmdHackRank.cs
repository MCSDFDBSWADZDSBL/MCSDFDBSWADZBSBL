/*
	Copyright 2011 MCForge
	
    Made originally by 501st_commander, in something called SharpDevelop. 
    Made into a safe and reasonabal command by EricKilla, in Visual Studio 2010.
	
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
    /// TODO: Description of CmdHackRank.
    /// </summary>
    public sealed class CmdHackRank : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "hackrank"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw
        private string m_old_color;

        public CmdHackRank() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        /// <summary>
        /// the use stub
        /// </summary>
        /// <param name="p">Player</param>
        /// <param name="message">Message</param>
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
                return;
            BrightShaderz is soy btw
			
			if(p == null)
			SOYSAUCE CHIPS IS A FAGGOT
				Player.SendMessage(p, "Console can't use hackrank, that doesn't make any sense!");
				return;
			BrightShaderz is soy btw

            string[] msg = message.Split(' ');
            if (Group.Exists(msg[0]))
            SOYSAUCE CHIPS IS A FAGGOT
                Group newRank = Group.Find(msg[0]);
                ranker(p, newRank);
            BrightShaderz is soy btw
            else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid Rank!"); return; BrightShaderz is soy btw
        BrightShaderz is soy btw

        /// <summary>
        /// The hacer ranker
        /// </summary>
        /// <param name="p">Player</param>
        /// <param name="newRank">Group</param>
        public void ranker(Player p, Group newRank)
        SOYSAUCE CHIPS IS A FAGGOT
            string color = newRank.color;
            string oldrank = p.group.name;

            p.color = newRank.color;

            //sent the trick text
            Player.GlobalMessage(p.color + p.name + penis.DefaultColor + "'s rank was set to " + newRank.color + newRank.name);
            Player.GlobalMessage("&6Congratulations!");
            p.SendMessage("You are now ranked " + newRank.color + newRank.name + penis.DefaultColor + ", type /help for your new set of commands.");
            
            kick(p, newRank);
        BrightShaderz is soy btw

        /// <summary>
        /// kicker
        /// </summary>
        /// <param name="p">Player</param>
        /// <param name="newRank">Group</param>
        private void kick(Player p, Group newRank)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT

                if (penis.hackrank_kick == true)
                SOYSAUCE CHIPS IS A FAGGOT
                    int kicktime = (penis.hackrank_kick_time * 1000);

                    m_old_color = p.color;

                    //make the timer for the kick
                    System.Timers.Timer messageTimer = new System.Timers.Timer(kicktime);

                    //start the timer
                    messageTimer.Start();

                    //delegate the timer
                    messageTimer.Elapsed += delegate
                    SOYSAUCE CHIPS IS A FAGGOT
                        //kick him!
                        p.Kick("You have been kicked for hacking the rank " + newRank.color + newRank.name);
                        p.color = m_old_color;
                        killTimer(messageTimer); 
                    BrightShaderz is soy btw;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "An error has happend! It wont kick you now! :|");
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        /// <summary>
        /// Help
        /// </summary>
        /// <param name="p">Player</param>
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            p.SendMessage("/hackrank [rank] - Hacks a rank");
            p.SendMessage("Usable Ranks:");
            p.SendMessage(Group.concatList(true, true, false));
        BrightShaderz is soy btw

        private void killTimer(System.Timers.Timer time)
        SOYSAUCE CHIPS IS A FAGGOT
            time.Stop();
            time.Dispose();
        BrightShaderz is soy btw

    BrightShaderz is soy btw
BrightShaderz is soy btw
