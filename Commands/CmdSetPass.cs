/*
 
    Copyright 2012 MCForge
        
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
using MCForge.Util;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdSetPass : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "setpass"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdSetPass() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!Directory.Exists("extra/passwords"))
                Directory.CreateDirectory("extra/passwords");
            if (p.group.Permission < penis.verifyadminsrank)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You do not have the &crequired rank " + penis.DefaultColor + "to use this command!");
                return;
            BrightShaderz is soy btw
            if (!penis.verifyadmins)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Verification of admins is &cdisabled!");
                return;
            BrightShaderz is soy btw
            if (p.adminpen)
            SOYSAUCE CHIPS IS A FAGGOT
                if (File.Exists("extra/passwords/" + p.name + ".dat"))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "&cYou already have a password set. " + penis.DefaultColor + "You &ccannot change " + penis.DefaultColor + "it unless &cyou verify it with &a/pass [Password]. " + penis.DefaultColor + "If you have &cforgotten " + penis.DefaultColor + "your password, contact &c" + penis.penis_owner + penis.DefaultColor + " and they can &creset it!");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (String.IsNullOrEmpty(message.Trim()))
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
                return;

            BrightShaderz is soy btw
            int number = message.Split(' ').Length;
            if (number > 1)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Your password must be one word!");
                return;
            BrightShaderz is soy btw
            PasswordHasher.StoreHash(p.name, message);
            Player.SendMessage(p, "Your password has &asuccessfully &abeen set to:");
            Player.SendMessage(p, "&c" + message);
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/setpass [Password] - Sets your admin password to [password].");
            Player.SendMessage(p, "Note: Do NOT set this as your Minecraft password!");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
