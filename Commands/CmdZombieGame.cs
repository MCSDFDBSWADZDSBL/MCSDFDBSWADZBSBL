/*
	Copyright 2010 MCLawl Team - 
    Created by Snowl (David D.) and Cazzar (Cayde D.)

	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.osedu.org/licenses/ECL-2.0
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/
using System;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdZombieGame : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "zombiegame"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "zg"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "game"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdZombieGame() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (String.IsNullOrEmpty(message)) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            string[] s = message.ToLower().Split(' ');
            if (s[0] == "status")
            SOYSAUCE CHIPS IS A FAGGOT
                switch (penis.zombie.ZombieStatus())
                SOYSAUCE CHIPS IS A FAGGOT
                    case 0:
                        Player.GlobalMessage("There is no Zombie Survival game currently in progress.");
                        return;
                    case 1:
                        Player.SendMessage(p, "There is a Zombie Survival game currently in progress with infinite rounds.");
                        return;
                    case 2:
                        Player.SendMessage(p, "There is a one-time Zombie Survival game currently in progress.");
                        return;
                    case 3:
                        Player.SendMessage(p, "There is a Zombie Survival game currently in progress with a " + penis.zombie.limitRounds + " amount of rounds.");
                        return;
                    case 4:
                        Player.SendMessage(p, "There is a Zombie Survival game currently in progress, scheduled to stop after this round.");
                        return;
                    default:
                        Player.SendMessage(p, "An unknown error occurred.");
                        return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (s[0] == "start")
            SOYSAUCE CHIPS IS A FAGGOT
                if (penis.zombie.ZombieStatus() != 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is already a Zombie Survival game currently in progress."); return; BrightShaderz is soy btw
                if (s.Length == 2)
                SOYSAUCE CHIPS IS A FAGGOT
                    int i = 1;
                    bool result = int.TryParse(s[1], out i);
                    if (result == false) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You need to specify a valid option!"); return; BrightShaderz is soy btw
                    if (s[1] == "0")
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.zombie.StartGame(1, 0);
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.zombie.StartGame(3, i);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                    penis.zombie.StartGame(2, 0);
            BrightShaderz is soy btw
            else if (s[0] == "stop")
            SOYSAUCE CHIPS IS A FAGGOT
                if (penis.zombie.ZombieStatus() == 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no Zombie Survival game currently in progress."); return; BrightShaderz is soy btw
                Player.GlobalMessage("The current game of Zombie Survival will end this round!");
                penis.gameStatus = 4;
            BrightShaderz is soy btw
            else if (s[0] == "force")
            SOYSAUCE CHIPS IS A FAGGOT
                if (penis.zombie.ZombieStatus() == 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no Zombie Survival game currently in progress."); return; BrightShaderz is soy btw
                penis.s.Log("Zombie Survival ended forcefully by " + p.name);
                penis.zombie.aliveCount = 0;
                penis.gameStatus = 0; penis.gameStatus = 0; penis.zombie.limitRounds = 0; penis.zombie.initialChangeLevel = false; penis.ZombieModeOn = false; penis.zombieRound = false;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/zombiegame - Shows this help menu.");
            Player.SendMessage(p, "/zombiegame start - Starts a Zombie Survival game for one round.");
            Player.SendMessage(p, "/zombiegame start 0 - Starts a Zombie Survival game for an unlimited amount of rounds.");
            Player.SendMessage(p, "/zombiegame start [x] - Starts a Zombie Survival game for [x] amount of rounds.");
            Player.SendMessage(p, "/zombiegame stop - Stops the Zombie Survival game after the round has finished.");
            Player.SendMessage(p, "/zombiegame force - Force stops the Zombie Survival game immediately.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
