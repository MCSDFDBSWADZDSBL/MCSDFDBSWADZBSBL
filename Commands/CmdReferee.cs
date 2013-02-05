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
    /// This is the command /referee
    /// use /help referee in-game for more info
    /// </summary>
    public sealed class CmdReferee : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "ref"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdReferee() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "This command can only be used in-game!"); return; BrightShaderz is soy btw
            if (p.referee)
            SOYSAUCE CHIPS IS A FAGGOT
                p.referee = false;
                LevelPermission perm = Group.findPlayerGroup(name).Permission;
                Player.GlobalDie(p, false);
                Player.GlobalChat(p, p.color + p.name + penis.DefaultColor + " is no longer a referee", false);
                if (penis.zombie.GameInProgess())
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.zombie.InfectPlayer(p);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.GlobalDie(p, false);
                    Player.GlobalSpawn(p, p.pos[0], p.pos[1], p.pos[2], p.rot[0], p.rot[1], false);
                    ZombieGame.infectd.Remove(p);
                    ZombieGame.alive.Add(p);
                    p.color = p.group.color;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                p.referee = true;
                Player.GlobalChat(p, p.color + p.name + penis.DefaultColor + " is now a referee", false);
                Player.GlobalDie(p, false);
                if (penis.zombie.GameInProgess())
                SOYSAUCE CHIPS IS A FAGGOT
                    p.color = p.group.color;
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        ZombieGame.infectd.Remove(p);
                        ZombieGame.alive.Remove(p);
                    BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    penis.zombie.InfectedPlayerDC();
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    ZombieGame.infectd.Remove(p);
                    ZombieGame.alive.Remove(p);
                    p.color = p.group.color;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/referee - Turns referee mode on/off.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
