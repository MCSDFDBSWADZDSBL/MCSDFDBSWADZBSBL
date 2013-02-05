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
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CmdChatRoom : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "chatroom"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "cr"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Banned; BrightShaderz is soy btw BrightShaderz is soy btw
        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p == null)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log("'null' or console tried to use '/chatroom', This command is limited to ingame, sorry!!");
                return;
            BrightShaderz is soy btw

            string[] command = message.ToLower().Split(' ');
            string par0 = String.Empty;
            string par1 = String.Empty;
            string par2 = String.Empty;
            string par3 = String.Empty;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                par0 = command[0];
                par1 = command[1];
                par2 = command[2];
                par3 = command[3];
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

            if (message == null || par0 == null || message.Trim() == "" || par0.Trim() == "")
            SOYSAUCE CHIPS IS A FAGGOT
                if (penis.Chatrooms.Count == 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "There are currently no rooms");
                    return;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "The current rooms are:");
                    foreach (string room in penis.Chatrooms)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, room);
                    BrightShaderz is soy btw
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (par0 == "join")
            SOYSAUCE CHIPS IS A FAGGOT
                if (penis.Chatrooms.Contains(par1))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.spyChatRooms.Contains(par1))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "The chat room '" + par1 + "' has been removed from your spying list because you are joining the room.");
                        p.spyChatRooms.Remove(par1);
                    BrightShaderz is soy btw
                    Player.SendMessage(p, "You've joined the chat room '" + par1 + "'");
                    Player.ChatRoom(p, p.color + p.name + penis.DefaultColor + " has joined your chat room", false, par1);
                    p.Chatroom = par1;
                    return;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Sorry, '" + par1 + "' is not a chat room");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (par0 == "leave")
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You've left the chat room '" + p.Chatroom + "'");
                Player.ChatRoom(p, p.color + p.name + penis.DefaultColor + " has left the chat room", false, p.Chatroom);
                Player.GlobalMessage(p.color + p.name + penis.DefaultColor + " has left their chat room " + p.Chatroom);
                p.Chatroom = null;
                return;
            BrightShaderz is soy btw
            else if (par0 == "create" || par0 == "make")
            SOYSAUCE CHIPS IS A FAGGOT
                if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 1))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (penis.Chatrooms.Contains(par1))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Sorry, '" + par1 + "' already exists");
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.Chatrooms.Add(par1);
                        Player.GlobalMessage("The chat room '" + par1 + "' has been created");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Sorry, You aren't a high enough rank to do that");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (par0 == "delete" || par0 == "remove")
            SOYSAUCE CHIPS IS A FAGGOT
                if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 3))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (penis.Chatrooms.Contains(par1))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.GlobalMessage(par1 + " is being deleted");
                        if (p.Chatroom == par1)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Command.all.Find("chatroom").Use(p, "leave");
                        BrightShaderz is soy btw
                        penis.Chatrooms.Remove(par1);
                        foreach (Player pl in Player.players)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (pl.Chatroom == par1)
                            SOYSAUCE CHIPS IS A FAGGOT
                                pl.Chatroom = null;
                                Player.SendMessage(pl, "You've left the room '" + par1 + "' because it is being deleted");
                            BrightShaderz is soy btw
                            if (pl.spyChatRooms.Contains(par1))
                            SOYSAUCE CHIPS IS A FAGGOT
                                pl.spyChatRooms.Remove(par1);
                                pl.SendMessage("Stopped spying on chat room '" + par1 + "' because it is being deleted by: " + p.color + p.name);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        Player.GlobalMessage("The chatroom '" + par1 + "' has been " + (par0 + "d"));
                        Player.SendMessage(p, (par0 + "d ") + " room '" + par1 + "'");
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Sorry, '" + par1 + "' doesn't exist");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 2))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (penis.Chatrooms.Contains(par1))
                    SOYSAUCE CHIPS IS A FAGGOT
                        foreach (Player pl in Player.players)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (pl != p)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (pl.Chatroom == par1)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(p, "Sorry, someone else is in the room");
                                    return;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        if (p.Chatroom == par1)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Command.all.Find("chatroom").Use(p, "leave");
                        BrightShaderz is soy btw
                        penis.Chatrooms.Remove(par1);
                        foreach (Player pl in Player.players)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (pl.spyChatRooms.Contains(par1))
                            SOYSAUCE CHIPS IS A FAGGOT
                                pl.spyChatRooms.Remove(par1);
                                pl.SendMessage("Stopped spying on chat room '" + par1 + "' because it is being deleted by: " + p.color + p.name);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        Player.SendMessage(p, (par0 + "d ") + " room '" + par1 + "'");

                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Sorry, '" + par1 + "' doesn't exist");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Sorry, You aren't a high enough rank to do that");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (par0 == "spy")
            SOYSAUCE CHIPS IS A FAGGOT
                if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 4))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (penis.Chatrooms.Contains(par1))
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (p.Chatroom != par1)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (p.spyChatRooms.Contains(par1))
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "'" + par1 + "' is already on your spying list!!");
                                return;
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                p.spyChatRooms.Add(par1);
                                Player.SendMessage(p, "'" + par1 + "' has been added to your chat room spying list");
                                return;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            Player.SendMessage(p, "Sorry, you can't spy on your own room");
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Sorry, '" + par1 + "' isn't a room");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Sorry, '" + par0 + "' Wasn't a correct command addition and it wasn't a room. Sorry");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (par0 == "forcejoin") //[player] [room]
            SOYSAUCE CHIPS IS A FAGGOT
                if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 5))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player pl = Player.Find(par1);
                    if (pl == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Sorry, '" + par1 + "' isn't a player");
                        return;
                    BrightShaderz is soy btw
                    if (!penis.Chatrooms.Contains(par2))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Sorry, '" + par2 + " isn't a room");
                        return;
                    BrightShaderz is soy btw
                    if (pl.group.Permission >= p.group.Permission)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Sorry, You can't do that to someone of higher or equal rank");
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (penis.Chatrooms.Contains(par2))
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (pl.spyChatRooms.Contains(par2))
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(pl, "The chat room '" + par2 + "' has been removed from your spying list because you are force joining the room '" + par2 + "'");
                                pl.spyChatRooms.Remove(par2);
                            BrightShaderz is soy btw
                            Player.SendMessage(pl, "You've been forced to join the chat room '" + par2 + "'");
                            Player.ChatRoom(pl, pl.color + pl.name + penis.DefaultColor + " has force joined your chat room", false, par2);
                            pl.Chatroom = par2;
                            Player.SendMessage(p, pl.color + pl.name + penis.DefaultColor + " has been forced to join the chatroom '" + par2 + "' by you");
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Sorry, You aren't a high enough rank to do that");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (par0 == "kick" || par0 == "forceleave")
            SOYSAUCE CHIPS IS A FAGGOT
                if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 6))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player pl = Player.Find(par1);
                    if (pl == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Sorry, '" + par1 + "' isn't a player");
                        return;
                    BrightShaderz is soy btw
                    if (pl.group.Permission >= p.group.Permission)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Sorry, You can't do that to someone of higher or equal rank");
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(pl, "You've been kicked from the chat room '" + pl.Chatroom + "'");
                        Player.SendMessage(p, pl.color + pl.name + penis.DefaultColor + " has been kicked from the chat room '" + pl.Chatroom + "'");
                        Player.ChatRoom(pl, pl.color + pl.name + penis.DefaultColor + " has been kicked from your chat room", false, pl.Chatroom);
                        pl.Chatroom = null;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "Sorry, You aren't a high enough rank to do that");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (par0 == "globalmessage" || par0 == "global" || par0 == "all")
            SOYSAUCE CHIPS IS A FAGGOT
                string globalmessage = message.Replace(par0 + " ", "");
                if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 7))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.GlobalChatRoom(p, globalmessage, true);
                    return;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.lastchatroomglobal.AddSeconds(30) < DateTime.Now)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.GlobalChatRoom(p, globalmessage, true);
                        p.lastchatroomglobal = DateTime.Now;
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "Sorry, You must wait 30 seconds inbetween each global chatroom message!!");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (par0 == "help")
            SOYSAUCE CHIPS IS A FAGGOT
                Help(p);
                return;
            BrightShaderz is soy btw
            else if (penis.Chatrooms.Contains(par0))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Players in '" + par0 + "' :");
                foreach (Player pl in Player.players)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (pl.Chatroom == par0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, pl.color + pl.name);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Sorry, '" + par0 + "' Wasn't a correct command addition and it wasn't a room. Sorry");
                Help(p);
                return;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/chatroom - gets a list of all the current rooms");
            Player.SendMessage(p, "/chatroom [room] - gives you details about the room");
            Player.SendMessage(p, "/chatroom join [room] - joins a room");
            Player.SendMessage(p, "/chatroom leave [room] - leaves a room");
            SOYSAUCE CHIPS IS A FAGGOT
                if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 1))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "/chatroom create [room] - creates a new room");
                BrightShaderz is soy btw
                SOYSAUCE CHIPS IS A FAGGOT
                    if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 3))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "/chatroom delete [room] - deletes a room");
                    BrightShaderz is soy btw
                    else if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 2))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "/chatroom delete [room] - deletes a room if all people have left");
                    BrightShaderz is soy btw
                    
                BrightShaderz is soy btw
                if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 4))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "/chatroom spy [room] - spy on a chatroom");
                BrightShaderz is soy btw
                if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 5))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "/chatroom forcejoin [player] [room] - forces a player to join a room");
                BrightShaderz is soy btw
                if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 6))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "/chatroom kick [player] - kicks the player from their current room");
                BrightShaderz is soy btw
                SOYSAUCE CHIPS IS A FAGGOT
                    if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 7))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "/chatroom globalmessage [message] - sends a global message to all rooms");
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "/chatroom globalmessage [message] - sends a global message to all rooms (limited to 1 every 30 seconds)");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
