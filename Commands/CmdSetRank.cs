/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCSong) Licensed under the
	Educational Community License, Version 2.0 (the "License"); you may
	not use this file except in compliance with the License. You may
	obtain a copy of the License at
	
	http://www.osedu.org/licenses/ECL-2.0
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the License is distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the License for the specific language governing
	permissions and limitations under the License.
*/

using System;
namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdSetRank : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "setrank"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "rank"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "mod"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Operator; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (message.Split(' ').Length < 2) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
            Player who = Player.Find(message.Split(' ')[0]);
            Group newRank = Group.Find(message.Split(' ')[1]);
            string msgGave;

            if (message.Split(' ').Length > 2) msgGave = message.Substring(message.IndexOf(' ', message.IndexOf(' ') + 1)); else msgGave = "Congratulations!";
            if (newRank == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Could not find specified rank."); return; BrightShaderz is soy btw

            Group bannedGroup = Group.findPerm(LevelPermission.Banned);
            if (who == null)
            SOYSAUCE CHIPS IS A FAGGOT
                string foundName = message.Split(' ')[0];
                if (Group.findPlayerGroup(foundName) == bannedGroup || newRank == bannedGroup)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Cannot change the rank to or from \"" + bannedGroup.name + "\".");
                    return;
                BrightShaderz is soy btw

                if (p != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (Group.findPlayerGroup(foundName).Permission >= p.group.Permission || newRank.Permission >= p.group.Permission)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Cannot change the rank of someone equal or higher than you"); return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                Group oldGroup = Group.findPlayerGroup(foundName);
                oldGroup.playerList.Remove(foundName);
                oldGroup.playerList.Save();

                newRank.playerList.Add(foundName);
                newRank.playerList.Save();

                Player.GlobalMessage(foundName + " &f(offline)" + penis.DefaultColor + "'s rank was set to " + newRank.color + newRank.name);
            BrightShaderz is soy btw
            else if (who == p)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Cannot change your own rank."); return;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (p != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (who.group == bannedGroup || newRank == bannedGroup)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Cannot change the rank to or from \"" + bannedGroup.name + "\".");
                        return;
                    BrightShaderz is soy btw

                    if (who.group.Permission >= p.group.Permission || newRank.Permission >= p.group.Permission)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Cannot change the rank of someone equal or higher to yourself."); return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                who.group.playerList.Remove(who.name);
                who.group.playerList.Save();

                newRank.playerList.Add(who.name);
                newRank.playerList.Save();

                Player.GlobalChat(who, who.color + who.name + penis.DefaultColor + "'s rank was set to " + newRank.color + newRank.name, false);
                Player.GlobalChat(null, "&6" + msgGave, false);
                who.group = newRank;
                who.color = who.group.color;
                Player.GlobalDie(who, false);
                who.SendMessage("You are now ranked " + newRank.color + newRank.name + penis.DefaultColor + ", type /help for your new set of commands.");
                Player.GlobalSpawn(who, who.pos[0], who.pos[1], who.pos[2], who.rot[0], who.rot[1], false);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/setrank <player> <rank> <yay> - Sets or returns a players rank.");
            Player.SendMessage(p, "You may use /rank as a shortcut");
            Player.SendMessage(p, "Valid Ranks are: " + Group.concatList(true, true));
            Player.SendMessage(p, "<yay> is a celebratory message");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
