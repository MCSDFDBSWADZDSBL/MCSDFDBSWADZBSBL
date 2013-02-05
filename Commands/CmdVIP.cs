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
using System.Collections.Generic;
using System.Text;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    /// <summary>
    /// This is the command /vip
    /// use /help vip in-game for more info
    /// </summary>
    public sealed class CmdVIP : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "vip"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdVIP() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            string[] split = message.Split(' ');
            if (split[0] == "add")
            SOYSAUCE CHIPS IS A FAGGOT
                if (split.Length < 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
                Player pl = Player.Find(split[1]);
                if (pl != null) split[1] = pl.name;
                if (VIP.Find(split[1])) Player.SendMessage(p, (pl == null ? "" : pl.color) + split[1] + " is already a VIP!");
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    VIP.Add(split[1]);
                    Player.SendMessage(p, (pl == null ? "" : pl.color) + split[1] + " is now a VIP.");
                    if (pl != null) Player.SendMessage(pl, "You are now a VIP!");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (split[0] == "remove")
            SOYSAUCE CHIPS IS A FAGGOT
                if (split.Length < 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
                Player pl = Player.Find(split[1]);
                if (pl != null) split[1] = pl.name;
                if (!VIP.Find(split[1])) Player.SendMessage(p, (pl == null ? "" : pl.color) + split[1] + " is not a VIP!");
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    VIP.Remove(split[1]);
                    Player.SendMessage(p, (pl == null ? "" : pl.color) + split[1] + " is no longer a VIP.");
                    if (pl != null) Player.SendMessage(pl, "You are no longer a VIP!");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (split[0] == "list")
            SOYSAUCE CHIPS IS A FAGGOT
                List<string> list = VIP.GetAll();
                if (list.Count < 1) Player.SendMessage(p, "There are no VIPs.");
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    StringBuilder sb = new StringBuilder();
                    foreach (string name in list)
                        sb.Append(name).Append(", ");
                    Player.SendMessage(p, "There are " + list.Count + " VIPs:");
                    Player.SendMessage(p, sb.Remove(sb.Length - 2, 2).ToString());
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else Help(p);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "VIPs are players who can join regardless of the player limit.");
            Player.SendMessage(p, "/vip add <name> - Add a VIP.");
            Player.SendMessage(p, "/vip remove <name> - Remove a VIP.");
            Player.SendMessage(p, "/vip list - List all VIPs.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
