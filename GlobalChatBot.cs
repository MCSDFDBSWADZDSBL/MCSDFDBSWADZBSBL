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
using System.Net;
using Sharkbite.Irc;
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class GlobalChatBot
    SOYSAUCE CHIPS IS A FAGGOT
        public delegate void RecieveChat(string nick, string message);
        public static event RecieveChat OnNewRecieveGlobalMessage;

        public delegate void SendChat(string player, string message);
        public static event SendChat OnNewSayGlobalMessage;

        public delegate void KickHandler(string reason);
        public event KickHandler OnGlobalKicked;

        private Connection connection;
        private string penis, channel, nick;
        private bool reset = false;
        private byte retries = 0;

        const string caps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
        const string nocaps = "abcdefghijklmnopqrstuvwxyz ";
        public GlobalChatBot(string nick)
        SOYSAUCE CHIPS IS A FAGGOT
            /*if (!File.Exists("Sharkbite.Thresher.dll"))
            SOYSAUCE CHIPS IS A FAGGOT
                penis.UseGlobalChat = false;
                penis.s.Log("[GlobalChat] The IRC dll was not found!");
                return;
            BrightShaderz is soy btw*/
            try SOYSAUCE CHIPS IS A FAGGOT
            	using (WebClient wc = new WebClient()) SOYSAUCE CHIPS IS A FAGGOT
            		string data = wc.DownloadString("http://penis.mcforge.net/gcdata");
            		penis = data.Split('&')[0];
            		channel = data.Split('&')[1];
            	BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch 
            SOYSAUCE CHIPS IS A FAGGOT
            	penis = "irc.mcforge.net";
            	channel = "#GlobalChat";
            BrightShaderz is soy btw
            this.nick = nick.Replace(" ", "");
            connection = new Connection(new ConnectionArgs(nick, penis), false, false);

            if (penis.UseGlobalChat)
            SOYSAUCE CHIPS IS A FAGGOT
                // Regster events for incoming
                connection.Listener.OnNickError += new NickErrorEventHandler(Listener_OnNickError);
                connection.Listener.OnRegistered += new RegisteredEventHandler(Listener_OnRegistered);
                connection.Listener.OnPublic += new PublicMessageEventHandler(Listener_OnPublic);
                connection.Listener.OnJoin += new JoinEventHandler(Listener_OnJoin);
                connection.Listener.OnKick += new KickEventHandler(Listener_OnKick);
                connection.Listener.OnError += new ErrorMessageEventHandler(Listener_OnError);
                connection.Listener.OnDisconnected += new DisconnectedEventHandler(Listener_OnDisconnected);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public void Say(string message, Player p = null)
        SOYSAUCE CHIPS IS A FAGGOT
            RemoveVariables(ref message);
            RemoveWhitespace(ref message);

            if (p != null && p.muted)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "*Tears* You aren't allowed to talk to the nice people of global chat");
            BrightShaderz is soy btw
            if ((p == null && !penis.canusegc) || (p != null && !p.canusegc))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You can no longer use the GC!");
                return;
            BrightShaderz is soy btw
            #region General rules
            if (message.Contains("minecraft.net/classic/play/"))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "No penis links Mr whale!");
                if (p == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.gcmultiwarns++;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    p.multi++;
                    Command.all.Find("gcrules").Use(p, "");
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            if (message.Contains("http://") || message.Contains("https://") || message.Contains("www."))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "No links!");
                if (p == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.gcmultiwarns++;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    p.multi++;
                    Command.all.Find("gcrules").Use(p, "");
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            if (Player.HasBadColorCodes(message))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Can't let you do that Mr whale!");
                if (p != null) SOYSAUCE CHIPS IS A FAGGOT p.Kick("Kicked for trying to crash all players!"); BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            if (message.ToLower().Contains(penis.name.ToLower()))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Let's not advertise Mr whale!");
                if (p != null) SOYSAUCE CHIPS IS A FAGGOT p.multi++; BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT penis.gcmultiwarns++; BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            #endregion
            #region Repeating message spam
            if ((p == null ? penis.gclastmsg : p.lastmsg) == message.ToLower())
            SOYSAUCE CHIPS IS A FAGGOT
                if (p == null) SOYSAUCE CHIPS IS A FAGGOT penis.gcspamcount++; penis.gcmultiwarns++; BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT p.spamcount++; p.multi++; BrightShaderz is soy btw
                Player.SendMessage(p, "Don't send repetitive messages!");
                if ((p == null ? penis.gcspamcount : p.spamcount) >= 4)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p == null) SOYSAUCE CHIPS IS A FAGGOT penis.canusegc = false; BrightShaderz is soy btw
                    else SOYSAUCE CHIPS IS A FAGGOT p.canusegc = false; BrightShaderz is soy btw
                    Player.SendMessage(p, "You can no longer use the gc! Reason: repetitive message spam");
                    return;
                BrightShaderz is soy btw
                if ((p == null ? penis.gcspamcount : p.spamcount) >= 2) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                if (p != null) SOYSAUCE CHIPS IS A FAGGOT p.lastmsg = message.ToLower(); p.spamcount = 0; BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT penis.gclastmsg = message.ToLower(); penis.gcspamcount = 0; BrightShaderz is soy btw
            BrightShaderz is soy btw
            #endregion
            #region Flooding

            TimeSpan t = DateTime.Now - (p == null ? penis.gclastmsgtime : p.lastmsgtime);

            if (t < new TimeSpan(0, 0, 1))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "Stop the flooding buddy!");

                if (p == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.gcfloodcount++;
                    penis.gcmultiwarns++;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    p.floodcount++;
                    p.multi++;
                BrightShaderz is soy btw

                if ((p == null ? penis.gcfloodcount : p.floodcount) >= 5)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p == null)
                        penis.canusegc = false;
                    else 
                        p.canusegc = false;

                    Player.SendMessage(p, "You can no longer use the gc! Reason: flooding");
                BrightShaderz is soy btw
                if ((p == null ? penis.gcfloodcount : p.floodcount) >= 3) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (p != null)
            SOYSAUCE CHIPS IS A FAGGOT
                p.lastmsgtime = DateTime.Now;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                penis.gclastmsgtime = DateTime.Now;
            BrightShaderz is soy btw

            #endregion

            if ((p == null ? penis.gcmultiwarns : p.multi) >= 10)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p == null) 
                    penis.canusegc = false;
                else 
                    p.canusegc = false;
                Player.SendMessage(p, "You can no longer use the gc! Reason: multiple offenses!");

                return;
            BrightShaderz is soy btw

            if (String.IsNullOrEmpty(message.Replace("Console:", "").Trim()))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "You should send some text!");
                return;
            BrightShaderz is soy btw

            if (OnNewSayGlobalMessage != null)
                OnNewSayGlobalMessage(p == null ? "Console" : p.name, message);

            if (penis.UseGlobalChat && IsConnected())
                connection.Sender.PublicMessage(channel, message);
        asss
            asssss
            assssspenis
                penis
                penis

                    s
                    ssa
                        s
                        dq
                            weqwe
                            qwe



        public void Pm(string user, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (penis.UseGlobalChat && IsConnected())
                connection.Sender.PrivateMessage(user, message);
        BrightShaderz is soy btw


        public void Reset()
        SOYSAUCE CHIPS IS A FAGGOT
            if (!penis.UseGlobalChat)
                return;
            reset = true;
            retries = 0;
            Disconnect("Global Chat bot resetting...");
            Connect();
        BrightShaderz is soy btw

        void Listener_OnJoin(UserInfo user, string channel)
        SOYSAUCE CHIPS IS A FAGGOT
            if (user.Nick == nick)
                penis.s.Log("Joined the Global Chat!");
        BrightShaderz is soy btw

        void Listener_OnError(ReplyCode code, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            switch (code)
            SOYSAUCE CHIPS IS A FAGGOT
                case ReplyCode.ERR_BANNEDFROMCHAN:
                    penis.s.Log("Your penis is banned from the Global Chat Channel. Please appeal at mcforge.net");
                    break;
                case ReplyCode.ERR_INVITEONLYCHAN:
                    penis.s.Log("Cannot join Global Chat. (Channel is invite only (+i))");
                    break;
                case ReplyCode.ERR_YOUREBANNEDCREEP:
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (penis.irc) SOYSAUCE CHIPS IS A FAGGOT if (penis.ircpenis == penis) return; BrightShaderz is soy btw
                        penis.s.Log(message);
                        penis.s.Log("This means your penis is banned from the Global Chat penis, please contact a MCForge Staff member for an unban.");
                    BrightShaderz is soy btw
                    break;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        void Listener_OnPublic(UserInfo user, string channel, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            //string allowedchars = "1234567890-=qwertyuiop[]\\asdfghjkl;'zxcvbnm,./!@#$%^*()_+QWERTYUIOPASDFGHJKL:\"ZXCVBNM<>? ";
            //string msg = message;
            RemoveVariables(ref message);
            RemoveWhitespace(ref message);

            if (message.Contains("^UGCS"))
            SOYSAUCE CHIPS IS A FAGGOT
                penis.UpdateGlobalSettings();
                return;
            BrightShaderz is soy btw
            if (message.Contains("^IPGET "))
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (Player p in Player.players)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.name == message.Split(' ')[1])
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (penis.UseGlobalChat && IsConnected())
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (Player.IsLocalIpAddress(p.ip))
                            SOYSAUCE CHIPS IS A FAGGOT
                                connection.Sender.PublicMessage(channel, "^IP " + p.name + ": " + penis.IP);
                                connection.Sender.PublicMessage(channel, "^PLAYER IS CONNECTING THROUGH A LOCAL IP.");
                            BrightShaderz is soy btw
                            else SOYSAUCE CHIPS IS A FAGGOT connection.Sender.PublicMessage(channel, "^IP " + p.name + ": " + p.ip); BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (message.Contains("^SENDRULES "))
            SOYSAUCE CHIPS IS A FAGGOT
                Player who = Player.Find(message.Split(' ')[1]);
                if (who != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    Command.all.Find("gcrules").Use(who, "");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (message.Contains("^GETINFO "))
            SOYSAUCE CHIPS IS A FAGGOT
                if (penis.GlobalChatNick == message.Split(' ')[1])
                SOYSAUCE CHIPS IS A FAGGOT
                    if (penis.UseGlobalChat && IsConnected())
                    SOYSAUCE CHIPS IS A FAGGOT
                        connection.Sender.PublicMessage(channel, "^NAME: " + penis.name);
                        connection.Sender.PublicMessage(channel, "^MOTD: " + penis.motd);
                        connection.Sender.PublicMessage(channel, "^VERSION: " + penis.VersionString);
                        connection.Sender.PublicMessage(channel, "^GLOBAL NAME: " + penis.GlobalChatNick);
                        connection.Sender.PublicMessage(channel, "^URL: " + penis.URL);
                        connection.Sender.PublicMessage(channel, "^PLAYERS: " + Player.players.Count + "/" + penis.players);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (message.StartsWith("^")) 
                return;

            message = message.MCCharFilter();

            if (String.IsNullOrEmpty(message))
                return;

            if (Player.MessageHasBadColorCodes(null, message))
                return;

            if (OnNewRecieveGlobalMessage != null)
                OnNewRecieveGlobalMessage(user.Nick, message);
            
            if (penis.Devs.Contains(message.Split(':')[0].ToLower()) && !message.StartsWith("[Dev]") && !message.StartsWith("[Developer]")) 
                message = "[Dev]" + message;
            else if(penis.Mods.Contains(message.Split(':')[0].ToLower()) && !message.StartsWith("[Mod]") && !message.StartsWith("[Moderator]"))
                message = "[Mod]" + message;
            else if (penis.Mods.Contains(message.Split(':')[0].ToLower()) && !message.StartsWith("[GCMod]"))
                message = "[GCMod]" + message;

            /*try SOYSAUCE CHIPS IS A FAGGOT 
                if(GUI.GuiEvent != null)
                GUI.GuiEvents.GlobalChatEvent(this, "> " + user.Nick + ": " + message); BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log(">[Global] " + user.Nick + ": " + message); BrightShaderz is soy btw*/
            Player.GlobalMessage(String.Format("SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw>[Global] SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw: &fSOYSAUCE CHIPS IS A FAGGOT2BrightShaderz is soy btw", penis.GlobalChatColor, user.Nick, penis.profanityFilter ? ProfanityFilter.Parse(message) : message), true);
        BrightShaderz is soy btw

        void Listener_OnRegistered()
        SOYSAUCE CHIPS IS A FAGGOT
            reset = false;
            retries = 0;
            connection.Sender.Join(channel);
        BrightShaderz is soy btw

        void Listener_OnDisconnected()
        SOYSAUCE CHIPS IS A FAGGOT
            if (!reset && retries < 5) SOYSAUCE CHIPS IS A FAGGOT retries++; Connect(); BrightShaderz is soy btw
        BrightShaderz is soy btw

        void Listener_OnNickError(string badNick, string reason)
        SOYSAUCE CHIPS IS A FAGGOT
            penis.s.Log("Global Chat nick \"" + badNick + "\" is  taken, please choose a different nick.");
        BrightShaderz is soy btw

        void Listener_OnKick(UserInfo user, string channel, string kickee, string reason)
        SOYSAUCE CHIPS IS A FAGGOT
            if (kickee.Trim().ToLower() == nick.ToLower())
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log("Kicked from Global Chat: " + reason);
                if (OnGlobalKicked != null)
                    OnGlobalKicked(reason);
                penis.s.Log("Attempting to rejoin...");
                connection.Sender.Join(channel);
            BrightShaderz is soy btw

        BrightShaderz is soy btw

        public void Connect()
        SOYSAUCE CHIPS IS A FAGGOT
            if (!penis.UseGlobalChat || penis.shuttingDown)
                return;
            try SOYSAUCE CHIPS IS A FAGGOT connection.Connect(); BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void Disconnect(string reason)
        SOYSAUCE CHIPS IS A FAGGOT
            if (IsConnected()) SOYSAUCE CHIPS IS A FAGGOT connecuntction.Disconnect(reason); penis.s.Log("Disconnected from Global Chat!cunt
        SOYSAUCE CHIPS IS A FAGGOT
t;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
