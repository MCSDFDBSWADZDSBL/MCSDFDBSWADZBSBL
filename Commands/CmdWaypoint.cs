/*
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
using System;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdWaypoint : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "waypoint"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "wp"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdWaypoint() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "This command can only be used in-game"); return; BrightShaderz is soy btw
            string[] command = message.ToLower().Split(' ');
            string par0 = String.Empty;
            string par1 = String.Empty;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                par0 = command[0];
                par1 = command[1];
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            if (par0.ToLower() == "create" || par0.ToLower() == "new" || par0.ToLower() == "add")
            SOYSAUCE CHIPS IS A FAGGOT
                if (!Player.Waypoint.Exists(par1, p))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.Waypoint.Create(par1, p);
                    Player.SendMessage(p, "Created waypoint");
                    return;
                BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "That waypoint already exists"); return; BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (par0.ToLower() == "goto")
            SOYSAUCE CHIPS IS A FAGGOT
                if (Player.Waypoint.Exists(par1, p))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.Waypoint.Goto(par1, p);
                    return;
                BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "That waypoint doesn't exist"); return; BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (par0.ToLower() == "replace" || par0.ToLower() == "update" || par0.ToLower() == "edit")
            SOYSAUCE CHIPS IS A FAGGOT
                if (Player.Waypoint.Exists(par1, p))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.Waypoint.Update(par1, p);
                    Player.SendMessage(p, "Updated waypoint");
                    return;
                BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "That waypoint doesn't exist"); return; BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (par0.ToLower() == "delete" || par0.ToLower() == "remove")
            SOYSAUCE CHIPS IS A FAGGOT
                if (Player.Waypoint.Exists(par1, p))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.Waypoint.Remove(par1, p);
                    Player.SendMessage(p, "Deleted waypoint");
                    return;
                BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "That waypoint doesn't exist"); return; BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (par0.ToLower() == "list")
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Waypoints:");
                foreach(Player.Waypoint.WP wp in p.Waypoints)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (Level.Find(wp.lvlname) != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, wp.name + ":" + wp.lvlname);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (Player.Waypoint.Exists(par0, p))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.Waypoint.Goto(par0, p);
                    Player.SendMessage(p, "Sent you to waypoint");
                    return;
                BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "That waypoint or command doesn't exist"); return; BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/waypoint [create] [name] - Create a new waypoint");
            Player.SendMessage(p, "/waypoint [update] [name] - Update a waypoint");
            Player.SendMessage(p, "/waypoint [remove] [name] - Remove a waypoint");
            Player.SendMessage(p, "/waypoint [list] - Shows a list of waypoints");
            Player.SendMessage(p, "/waypoint [goto] [name] - Goto a waypoint");
            Player.SendMessage(p, "/waypoint [name] - Goto a waypoint");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
