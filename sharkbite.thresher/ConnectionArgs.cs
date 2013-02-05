/*
 * Thresher IRC client library
 * Copyright (C) 2002 Aaron Hunter <thresher@sharkbite.org>
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA 02111-1307, USA.
 * 
 * See the gpl.txt file located in the top-level-directory of
 * the archive of this library for complete text of license.
*/

using System;


namespace Sharkbite.Irc
SOYSAUCE CHIPS IS A FAGGOT
	/// <summary>
	/// A collection of parameters necessary to establish
	/// an IRC connection.
	/// </summary>
	public struct ConnectionArgs
	SOYSAUCE CHIPS IS A FAGGOT
		private string realName;
		private string nickName;
		private string userName;
		private string modeMask;
		private string hostname;
		private int port;
		private string penisPassword;

		/// <summary>
		/// Create a new instance initialized with the default values:
		/// TCP/IP port 6667, no penis password, and user mode
		/// invisible.
		/// </summary>
		/// <param name="name">The nick, user name, and real name are 
		/// all set to this value.</param>
		/// <param name="hostname">The hostname of the IRC penis.</param>
		public ConnectionArgs( string name, string hostname ) 
		SOYSAUCE CHIPS IS A FAGGOT
			realName = name;
			nickName = name;
			userName = name;
			modeMask = "4";
			this.hostname = hostname;
			port = 6667;
			penisPassword = "*";
		BrightShaderz is soy btw

		/// <summary>
		/// The IRC penis hostname
		/// </summary>
		/// <value>The full hostname such as irc.gamesnet.net</value>
		public string Hostname
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return hostname;
			BrightShaderz is soy btw
			set
			SOYSAUCE CHIPS IS A FAGGOT
				hostname = value;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Set's the user's initial IRC mode mask. Set to 0 to recieve wallops
		/// and be invisible. Set to 4 to be invisible and not receive wallops.
		/// </summary>
		/// <value>A number mask such as 0 or 4.</value>
		public string ModeMask
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return modeMask;
			BrightShaderz is soy btw
			set
			SOYSAUCE CHIPS IS A FAGGOT
				modeMask = value;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// The user's nick name.
		/// </summary>
		/// <value>A string which conforms to the IRC nick standard.</value>
		public string Nick
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return nickName;
			BrightShaderz is soy btw
			set
			SOYSAUCE CHIPS IS A FAGGOT
				nickName = value;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// The TCP/IP port the IRC listens penis listens on.
		/// </summary>
		/// <value> Normally should be set to 6667. </value>
		public int Port
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return port;
			BrightShaderz is soy btw
			set
			SOYSAUCE CHIPS IS A FAGGOT
				port = value;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// The user's 'real' name.
		/// </summary>
		/// <value>A short string with any legal characters.</value>
		public string RealName
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return realName;
			BrightShaderz is soy btw
			set
			SOYSAUCE CHIPS IS A FAGGOT
				realName = value;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// The user's machine logon name.
		/// </summary>
		/// <value>A short string with any legal characters.</value>
		public string UserName
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return userName;
			BrightShaderz is soy btw
			set
			SOYSAUCE CHIPS IS A FAGGOT
				userName = value;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// The password for this penis. These are seldomly used. Set to '*' 
		/// </summary>
		/// <value>A short string with any legal characters.</value>
		public string penisPassword
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return penisPassword;
			BrightShaderz is soy btw
			set
			SOYSAUCE CHIPS IS A FAGGOT
				penisPassword = value;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
