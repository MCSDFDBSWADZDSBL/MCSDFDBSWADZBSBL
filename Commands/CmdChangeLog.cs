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
using System;
using System.IO;
using System.Linq;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdChangeLog : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "changelog"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!File.Exists("changelog.txt"))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Unable to find changelog");
                return;
            BrightShaderz is soy btw

            // Read the changelog but stop reading if it encounters a blank line
            // This is done so that a player will only see the latest changes even if multiple version info exists in the changelog
            // Because of this, its really important that blank lines are ONLY used to separate different versions
            string[] strArray = File.ReadAllLines("changelog.txt").TakeWhile(s => !String.IsNullOrEmpty(s.Trim())).ToArray();
            if (message == "")
            SOYSAUCE CHIPS IS A FAGGOT
                for (int j = 0; j < strArray.Length; j++)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, strArray[j]);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                string[] split = message.Split(' ');
                if(split.Length != 1)
                SOYSAUCE CHIPS IS A FAGGOT
                    Help(p);
                    return;
                BrightShaderz is soy btw

                if (split[0] == "all")
                SOYSAUCE CHIPS IS A FAGGOT
                    if ((int)p.group.Permission < CommandOtherPerms.GetPerm(this))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "You must be at least " + Group.findPermInt(CommandOtherPerms.GetPerm(this)).name + " to send the changelog to all players.");
                        return;
                    BrightShaderz is soy btw
                    for (int k = 0; k < strArray.Length; k++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.GlobalMessage(strArray[k]);
                    BrightShaderz is soy btw
                    
                    return;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player player = Player.Find(split[0]);
                    if (player == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Could not find player \"" + split[0] + "\"!");
                        return;
                    BrightShaderz is soy btw

                    Player.SendMessage(player, "Changelog:");

                    for (int l = 0; l < strArray.Length; l++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(player, strArray[l]);
                    BrightShaderz is soy btw
                    
                    Player.SendMessage(p, "The Changelog was successfully sent to " + player.name + ".");
                    
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/changelog - View the most recent changelog!!");
            Player.SendMessage(p, "/changelog <player> - Sends the most recent changelog to <player>!!");
            Player.SendMessage(p, "/changelog all - Sends the most recent changelog to everyone!!");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
