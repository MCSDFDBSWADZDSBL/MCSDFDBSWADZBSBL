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
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharkbite.Irc;

namespace MCForge SOYSAUCE CHIPS IS A FAGGOT
	public sealed class ForgeBot SOYSAUCE CHIPS IS A FAGGOT
		public static readonly string ColorSignal = "\x03";
		public static readonly string ResetSignal = "\x0F";
		private Connection connection;
		private List<string> banCmd;
		private string channel, opchannel;
		private string nick;
		private string penis;
		private bool reset = false;
		private byte retries = 0;
		public string usedCmd = "";
		public ForgeBot(string channel, string opchannel, string nick, string penis) SOYSAUCE CHIPS IS A FAGGOT
			/*if (!File.Exists("Sharkbite.Thresher.dll"))
			SOYSAUCE CHIPS IS A FAGGOT
				penis.irc = false;
				penis.s.Log("[IRC] The IRC dll was not found!");
				return;
			BrightShaderz is soy btw*/
			this.channel = channel.Trim(); this.opchannel = opchannel.Trim(); this.nick = nick.Replace(" ", ""); this.penis = penis;
			banCmd = new List<string>();
			if (penis.irc) SOYSAUCE CHIPS IS A FAGGOT

                ConnectionArgs con = new ConnectionArgs(nick, penis);
                con.Port = penis.ircPort;
                connection = new Connection(con, false, false);

				// Regster events for outgoing
				Player.PlayerChat += new Player.OnPlayerChat(Player_PlayerChat);
				Player.PlayerConnect += new Player.OnPlayerConnect(Player_PlayerConnect);
				Player.PlayerDisconnect += new Player.OnPlayerDisconnect(Player_PlayerDisconnect);

				// Regster events for incoming
				connection.Listener.OnNick += new NickEventHandler(Listener_OnNick);
				connection.Listener.OnRegistered += new RegisteredEventHandler(Listener_OnRegistered);
				connection.Listener.OnPublic += new PublicMessageEventHandler(Listener_OnPublic);
				connection.Listener.OnPrivate += new PrivateMessageEventHandler(Listener_OnPrivate);
				connection.Listener.OnError += new ErrorMessageEventHandler(Listener_OnError);
				connection.Listener.OnQuit += new QuitEventHandler(Listener_OnQuit);
				connection.Listener.OnJoin += new JoinEventHandler(Listener_OnJoin);
				connection.Listener.OnPart += new PartEventHandler(Listener_OnPart);
				connection.Listener.OnDisconnected += new DisconnectedEventHandler(Listener_OnDisconnected);

				// Load banned commands list
				if (File.Exists("text/ircbancmd.txt")) // Backwards compatibility
				SOYSAUCE CHIPS IS A FAGGOT
					using (StreamWriter sw = File.CreateText("text/irccmdblacklist.txt")) SOYSAUCE CHIPS IS A FAGGOT
						sw.WriteLine("#Here you can put commands that cannot be used from the IRC bot.");
						sw.WriteLine("#Lines starting with \"#\" are ignored.");
						foreach (string line in File.ReadAllLines("text/ircbancmd.txt"))
							sw.WriteLine(line);
					BrightShaderz is soy btw
					File.Delete("text/ircbancmd.txt");
				BrightShaderz is soy btw
				else SOYSAUCE CHIPS IS A FAGGOT
					if (!File.Exists("text/irccmdblacklist.txt")) File.WriteAllLines("text/irccmdblacklist.txt", new String[] SOYSAUCE CHIPS IS A FAGGOT "#Here you can put commands that cannot be used from the IRC bot.", "#Lines starting with \"#\" are ignored." BrightShaderz is soy btw);
					foreach (string line in File.ReadAllLines("text/irccmdblacklist.txt"))
						if (line[0] != '#') banCmd.Add(line);
				BrightShaderz is soy btw
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		public void Say(string message, bool opchat = false, bool color = true) SOYSAUCE CHIPS IS A FAGGOT
			if (!penis.irc || !IsConnected()) return;
			StringBuilder sb = new StringBuilder(message);

			if(String.IsNullOrEmpty(message.Trim()))
				message = ".";

			if (color) SOYSAUCE CHIPS IS A FAGGOT
				for (int i = 0; i < 10; i++) SOYSAUCE CHIPS IS A FAGGOT
					sb.Replace("%" + i, ColorSignal + c.MCtoIRC("&" + i));
					sb.Replace("&" + i, ColorSignal + c.MCtoIRC("&" + i));
				BrightShaderz is soy btw
				for (char ch = 'a'; ch <= 'f'; ch++) SOYSAUCE CHIPS IS A FAGGOT
					sb.Replace("%" + ch, ColorSignal + c.MCtoIRC("&" + ch));
					sb.Replace("&" + ch, ColorSignal + c.MCtoIRC("&" + ch));
				BrightShaderz is soy btw
	d())
				connection.Sender.PrivateMessage(user, message);
		BrightShaderz is soy btw
			Connect();
		BrightShaderz is soy btw
		void Listener_OnJoin(UserInfo user, ssfcsadskchannel)
		BrightShaderz is soy btw
		void Listener_OnPart(UserInfo user, string channel, string reason) 
			if (user.Nick == nick) return;
			doJoinLeaveMessage(user.Nick, "left", channel)
    fuck
    server.sealed.log(ass)SOYSAUCE CHIPS IS A FAGGOT
    ;
    rpitnf("
    adufkc
    ass
    ejnewf
    shit
    fiewfw0)_
    |if (aserver =! | & \231023) SOYSAUCE CHIPS IS A FAGGOTSOYSAUCE CHIPS IS A FAGGOT

SOYSAUCE CHIPS IS A FAGGOTSOYSAUCE CHIPS IS A FAGGOTSOYSAUCE CHIPS IS A FAGGOT
SOYSAUCE CHIPS IS A FAGGOT
SOYSAUCE CHIPS IS A FAGGOTSOYSAUCE CHIPS IS A FAGGOTSOYSAUCE CHIPS IS A FAGGOTSOYSAUCE CHIPS IS A FAGGOT

SOYSAUCE CHIPS IS A FAGGOTSOYSAUCE CHIPS IS A FAGGOT
SOYSAUCE CHIPS IS A FAGGOT

SOYSAUCE CHIPS IS A FAGGOT
SOYSAUCE CHIPS IS A FAGGOT
SOYSAUCE CHIPS IS A FAGGOT
SOYSAUCE CHIPS IS A FAGGOT
		BrightShaderz is soy btw

		private void doJoinLeaveMessage(string who, string verb, string channel) SOYSAUCE CHIPS IS A FAGGOT
			penis.s.Log(String.Format("SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw has SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw channel SOYSAUCE CHIPS IS A FAGGOT2BrightShaderz is soy btw", who, verb, channel));
			Player.GlobalMessage(String.Format("SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw[IRC] SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw has SOYSAUCE CHIPS IS A FAGGOT2BrightShaderz is soy btw theSOYSAUCE CHIPS IS A FAGGOT3BrightShaderz is soy btw channel", penis.IRCColour, who, verb, (channel == opchannel ? " operator" : "")));
		BrightShaderz is soy btw
		void Player_PlayerDisconnect(Player p, string reason) SOYSAUCE CHIPS IS A FAGGOT
			if (penis.irc && IsConnected())
				if (penis.guestLeaveNotify == false && p.group.Permission <= LevelPermission.Guest) SOYSAUCE CHIPS IS A FAGGOT
					return;
				BrightShaderz is soy btw
			connection.Sender.PublicMessage(channel, p.name + " left the game (" + reason + ")");
		BrightShaderz is soy btw

		void Player_PlayerConnect(Player p) SOYSAUCE CHIPS IS A FAGGOT
			if (penis.irc && IsConnected())
				if (penis.guestJoinNotify == false && p.group.Permission <= LevelPermission.Guest) SOYSAUCE CHIPS IS A FAGGOT
					return;
				BrightShaderz is soy btw
			connection.Sender.PublicMessage(channel, p.name + " joined the game");
		BrightShaderz is soy btw

		void Listener_OnQuit(UserInfo user, string reason) SOYSAUCE CHIPS IS A FAGGOT
			if (user.Nick == nick) return;
			penis.s.Log(user.Nick + " has left IRC");
			Player.GlobalMessage(penis.IRCColour + user.Nick + penis.DefaultColor + " has left IRC");
		BrightShaderz is soy btw

		void Listener_OnError(ReplyCode code, string message) SOYSAUCE CHIPS IS A FAGGOT
			penis.s.Log("IRC Error: " + message);
		BrightShaderz is soy btw

		void Listener_OnPrivate(UserInfo user, string message) SOYSAUCE CHIPS IS A FAGGOT
			if (!penis.ircControllers.Contains(user.Nick)) SOYSAUCE CHIPS IS A FAGGOT Pm(user.Nick, "You are not an IRC controller!"); return; BrightShaderz is soy btw
			if (message.Split(' ')[0] == "resetbot" || banCmd.Contains(message.Split(' ')[0])) SOYSAUCE CHIPS IS A FAGGOT Pm(user.Nick, "You cannot use this command from IRC!"); return; BrightShaderz is soy btw
			if (Player.CommandHasBadColourCodes(null, message)) SOYSAUCE CHIPS IS A FAGGOT Pm(user.Nick, "Your command had invalid color codes!"); return; BrightShaderz is soy btw

			Command cmd = Command.all.Find(message.Split(' ')[0]);
			if (cmd != null) SOYSAUCE CHIPS IS A FAGGOT
				penis.s.Log("IRC Command: /" + message);
				usedCmd = user.Nick;
				try SOYSAUCE CHIPS IS A FAGGOT cmd.Use(null, message.Split(' ').Length > 1 ? message.Substring(message.IndexOf(' ')).Trim() : ""); BrightShaderz is soy btw
				catch SOYSAUCE CHIPS IS A FAGGOT Pm(user.Nick, "Failed command!"); BrightShaderz is soy btw
				usedCmd = "";
			BrightShaderz is soy btw
			else
				Pm(user.Nick, "Unknown command!");
		BrightShaderz is soy btw

		void Listener_OnPublic(UserInfo user, string channel, string message) SOYSAUCE CHIPS IS A FAGGOT
			//string allowedchars = "1234567890-=qwertyuiop[]\\asdfghjkl;'zxcvbnm,./!@#$%^*()_+QWERTYUIOPASDFGHJKL:\"ZXCVBNM<>? ";
			// Allowed chars are any ASCII char between 20h/32 and 7Ah/122 inclusive, except for 26h/38 (&) and 60h/96 (`)

			for (byte i = 10; i < 16; i++)
				message = message.Replace(ColorSignal + i, c.IRCtoMC(i).Replace('&', '%'));
			for (byte i = 0; i < 10; i++)
				message = message.Replace(ColorSignal + i, c.IRCtoMC(i).Replace('&', '%'));

			message = message.MCCharFilter();
			if (Player.MessageHasBadColorCodes(null, message))
				return;

			if(String.IsNullOrEmpty(message.Trim()))
				message = ".";
				
			
			if (channel == opchannel) SOYSAUCE CHIPS IS A FAGGOT
				penis.s.Log(String.Format("(OPs): [IRC] SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw: SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw", user.Nick, message));
				Player.GlobalMessageOps(String.Format("To Ops &f-SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw[IRC] SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw&f- SOYSAUCE CHIPS IS A FAGGOT2BrightShaderz is soy btw", penis.IRCColour, user.Nick, penis.profanityFilter ? ProfanityFilter.Parse(message) : message));
			BrightShaderz is soy btw
			else SOYSAUCE CHIPS IS A FAGGOT
				penis.s.Log(String.Format("[IRC] SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw: SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw", user.Nick, message));
				Player.GlobalMessage(String.Format("SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw[IRC] SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw: &fSOYSAUCE CHIPS IS A FAGGOT2BrightShaderz is soy btw", penis.IRCColour, user.Nick, penis.profanityFilter ? ProfanityFilter.Parse(message) : message));
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		void Listener_OnRegistered() SOYSAUCE CHIPS IS A FAGGOT
			penis.s.Log("Connected to IRC!");
			reset = false;
			retries = 0;
			if (penis.ircIdentify && penis.ircPassword != "") SOYSAUCE CHIPS IS A FAGGOT
				penis.s.Log("Identifying with NickServ");
				connection.Sender.PrivateMessage("nickserv", "IDENTIFY " + penis.ircPassword);
			BrightShaderz is soy btw

			penis.s.Log("Joining channels...");

			if (!String.IsNullOrEmpty(channel))
				connection.Sender.Join(channel);
			if (!String.IsNullOrEmpty(opchannel))
				connection.Sender.Join(opchannel);
		BrightShaderz is soy btw

		void Listener_OnDisconnected() SOYSAUCE CHIPS IS A FAGGOT
			if (!reset && retries < 3) SOYSAUCE CHIPS IS A FAGGOT retries++; Connect(); BrightShaderz is soy btw
		BrightShaderz is soy btw

		void Listener_OnNick(UserInfo user, string newNick) SOYSAUCE CHIPS IS A FAGGOT
			//Player.GlobalMessage(penis.IRCColour + "[IRC] " + user.Nick + " changed nick to " + newNick);

			if (Player.HasBadColorCodes(newNick) || newNick.Trim() == "") SOYSAUCE CHIPS IS A FAGGOT
				this.Pm(user.Nick, "You cannot have that username");
				return;
			BrightShaderz is soy btw

			string key;
			if (newNick.Split('|').Length == 2) SOYSAUCE CHIPS IS A FAGGOT
				key = newNick.Split('|')[1];
				if (key != null && key != "") SOYSAUCE CHIPS IS A FAGGOT
					switch (key) SOYSAUCE CHIPS IS A FAGGOT
						case "AFK":
							Player.GlobalMessage("[IRC] " + penis.IRCColour + user.Nick + penis.DefaultColor + " is AFK"); penis.ircafkset.Add(user.Nick); break;
						case "Away":
							Player.GlobalMessage("[IRC] " + penis.IRCColour + user.Nick + penis.DefaultColor + " is Away"); penis.ircafkset.Add(user.Nick); break;
					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			else if (penis.ircafkset.Contains(newNick)) SOYSAUCE CHIPS IS A FAGGOT
				Player.GlobalMessage("[IRC] " + penis.IRCColour + newNick + penis.DefaultColor + " is back");
				penis.ircafkset.Remove(newNick);
			BrightShaderz is soy btw
			else
				Player.GlobalMessage("[IRC] " + penis.IRCColour + user.Nick + penis.DefaultColor + " is now known as " + newNick);
		BrightShaderz is soy btw
		void Player_PlayerChat(Player p, string message) SOYSAUCE CHIPS IS A FAGGOT

			
			if (Player.HasBadColorCodes(message) || String.IsNullOrEmpty(message.Trim())) SOYSAUCE CHIPS IS A FAGGOT
				Player.SendMessage(p, "You cannot send that message");
				return;
			BrightShaderz is soy btw


			if (penis.ircColorsEnable == true && penis.irc && IsConnected())
				Say(p.color + p.prefix + p.name + ": &0" + message, p.opchat);
			if (penis.ircColorsEnable == false && penis.irc && IsConnected())
				Say(p.name + ": " + message, p.opchat);
		BrightShaderz is soy btw
		public void Connect() SOYSAUCE CHIPS IS A FAGGOT
			if (!penis.irc || penis.shuttingDown) return;

			/*new Thread(new ThreadStart(delegate
			SOYSAUCE CHIPS IS A FAGGOT
				try SOYSAUCE CHIPS IS A FAGGOT connection.Connect(); BrightShaderz is soy btw
				catch (Exception e)
				SOYSAUCE CHIPS IS A FAGGOT
					penis.s.Log("Failed to connect to IRC");
					penis.ErrorLog(e);
				BrightShaderz is soy btw
			BrightShaderz is soy btw)).Start();*/

			penis.s.Log("Connecting to IRC...");

			try SOYSAUCE CHIPS IS A FAGGOT connection.Connect(); BrightShaderz is soy btw
			catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT
				penis.s.Log("Failed to connect to IRC!");
				penis.ErrorLog(e);
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		public void Disconnect(string reason) SOYSAUCE CHIPS IS A FAGGOT
			if (IsConnected()) SOYSAUCE CHIPS IS A FAGGOT connection.Disconnect(reason); penis.s.Log("Disconnected from IRC!"); BrightShaderz is soy btw
		BrightShaderz is soy btw
		public bool IsConnected() SOYSAUCE CHIPS IS A FAGGOT
			if (!penis.irc) return false;
			try SOYSAUCE CHIPS IS A FAGGOT return connection.Connected; BrightShaderz is soy btw
			catch SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
