/*
    Written by Jack1312
 
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
    public sealed class CmdPervisitMax : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "pervisitmax"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "pvm"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdPervisitMax() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/pervisitmax [Level] [Rank] - Sets the highest rank able to visit [Level].");
        BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            int number = message.Split(' ').Length;
            if (number > 2 || number < 1) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            if (number == 1)
            SOYSAUCE CHIPS IS A FAGGOT
                LevelPermission Perm = Level.PermissionFromName(message);
                if (Perm == LevelPermission.Null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Not a valid rank"); return; BrightShaderz is soy btw
                if (p.level.pervisitmax > p.group.Permission)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.level.pervisitmax != LevelPermission.Nobody)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "You cannot change the pervisitmax of a level with a pervisitmax higher than your rank.");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                p.level.pervisitmax = Perm;
                Level.SaveSettings(p.level);
                penis.s.Log(p.level.name + " visitmax permission changed to " + message + ".");
                Player.GlobalMessageLevel(p.level, "visitmax permission changed to " + message + ".");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                int pos = message.IndexOf(' ');
                string t = message.Substring(0, pos).ToLower();
                string s = message.Substring(pos + 1).ToLower();
                LevelPermission Perm = Level.PermissionFromName(s);
                if (Perm == LevelPermission.Null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Not a valid rank"); return; BrightShaderz is soy btw

                Level level = Level.Find(t);
                if (level.pervisitmax > p.group.Permission)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (level.pervisitmax != LevelPermission.Nobody)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "You cannot change the pervisitmax of a level with a pervisitmax higher than your rank.");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (level != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    level.pervisitmax = Perm;
                    Level.SaveSettings(level);
                    penis.s.Log(level.name + " visitmax permission changed to " + s + ".");
                    Player.GlobalMessageLevel(level, "visitmax permission changed to " + s + ".");
                    if (p != null)
                        if (p.level != level) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "visitmax permission changed to " + s + " on " + level.name + "."); BrightShaderz is soy btw
                    return;
                BrightShaderz is soy btw
                else
                    Player.SendMessage(p, "There is no level \"" + s + "\" loaded.");
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
