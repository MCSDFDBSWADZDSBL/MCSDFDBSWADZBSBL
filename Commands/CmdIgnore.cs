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
using System.IO;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdIgnore : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "ignore"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw
        public CmdIgnore() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        public static byte lastused = 0;
        public static string ignore = "";
        public static string ignore2 = "";

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "This command can only be used in-game!"); return; BrightShaderz is soy btw
            if (message.Split(' ')[0] == "all")
            SOYSAUCE CHIPS IS A FAGGOT
                p.ignoreglobal = !p.ignoreglobal;
                p.muteGlobal = p.ignoreglobal;
                if (p.ignoreglobal) Player.globalignores.Add(p.name);
                else Player.globalignores.Remove(p.name);
                Player.SendMessage(p, p.ignoreglobal ? "&cAll chat is now ignored!" : "&aAll chat is no longer ignored!");
                return;
            BrightShaderz is soy btw
            if (message.Split(' ')[0] == "global")
            SOYSAUCE CHIPS IS A FAGGOT
                p.muteGlobal = !p.muteGlobal;
                Player.SendMessage(p, p.muteGlobal ? "&cGlobal Chat is now ignored!" : "&aGlobal Chat is no longer ignored!");
                return;
            BrightShaderz is soy btw
            if (message.Split(' ')[0] == "list")
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "&cCurrently ignoring the following players:");
                foreach (string ignoring in p.listignored)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "- " + ignoring);
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            Player who = Player.Find(message.Split(' ')[0]);
            if (who == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Could not find player specified!");
                return;
            BrightShaderz is soy btw

            if (who.name == p.name)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You cannot ignore yourself!!");
                return;
            BrightShaderz is soy btw

            if (who.group.Permission >= penis.opchatperm)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.group.Permission <= who.group.Permission)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "You cannot ignore an operator of higher rank!");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            
     
            if (!Directory.Exists("ranks/ignore"))
            SOYSAUCE CHIPS IS A FAGGOT
                Directory.CreateDirectory("ranks/ignore");
            BrightShaderz is soy btw
            if (!File.Exists("ranks/ignore/" + p.name + ".txt"))
            SOYSAUCE CHIPS IS A FAGGOT
                File.Create("ranks/ignore/" + p.name + ".txt").Dispose();
            BrightShaderz is soy btw
            string chosenpath = "ranks/ignore/" + p.name + ".txt";
            if (!File.Exists(chosenpath) || !p.listignored.Contains(who.name))
            SOYSAUCE CHIPS IS A FAGGOT
                p.listignored.Add(who.name);
                Player.SendMessage(p, "Player now ignored: &c" + who.name + "!");
                return;
            BrightShaderz is soy btw
            if (p.listignored.Contains(who.name))
            SOYSAUCE CHIPS IS A FAGGOT
                p.listignored.Remove(who.name);
                Player.SendMessage(p, "Player is no longer ignored: &a" + who.name + "!");
                return;
            BrightShaderz is soy btw
            Player.SendMessage(p, "Something is stuffed.... Tell a MCForge Developer!");
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/ignore [Player] - Ignores the specified player.");
            Player.SendMessage(p, "/ignore global - Ignores the global chat.");
            Player.SendMessage(p, "Note: You cannot ignore operators of higher rank!");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
