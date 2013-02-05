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

namespace Sharkbite.Irc
SOYSAUCE CHIPS IS A FAGGOT
	/// <summary>
	/// A convenient holder of user information. Instances of this class
	/// are created internally.
	/// </summary>
	public class UserInfo 
	SOYSAUCE CHIPS IS A FAGGOT
		/// <summary>The user's handle.</summary>
		private readonly string nickName;
		/// <summary>The user's username on the local machine</summary>
		private readonly string userName;
		/// <summary>The user's fully qualified host name</summary>
		private readonly string hostName;
		private static readonly UserInfo EmptyInstance = new UserInfo();

		/// <summary>
		/// Creat an empty instance
		/// </summary>
		private UserInfo() 
		SOYSAUCE CHIPS IS A FAGGOT
			nickName = "";
			userName = "";
			hostName = "";
		BrightShaderz is soy btw
		/// <summary>
		/// Create a new UserInfo and set all its values.
		/// </summary>
		public UserInfo(string nick, string name, string host) 
		SOYSAUCE CHIPS IS A FAGGOT
			nickName = nick;
			userName = name;
			hostName = host;
		BrightShaderz is soy btw

		/// <summary>
		/// An IRC user's nick name.
		/// </summary>
		public string Nick
		SOYSAUCE CHIPS IS A FAGGOT
			get 
			SOYSAUCE CHIPS IS A FAGGOT
				return nickName;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// An IRC user's system username.
		/// </summary>
		public string User
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return userName;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// The hostname of the IRC user's machine.
		/// </summary>
		public string Hostname 
		SOYSAUCE CHIPS IS A FAGGOT
			get 
			SOYSAUCE CHIPS IS A FAGGOT
				return hostName;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// A singleton blank instance of UserInfo used when an instance is required
		/// by a method signature but no infomation is available, e.g. the last reply
		/// from a Who request.
		/// </summary>
		public static UserInfo Empty 
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return EmptyInstance;
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		/// <summary>
		/// A string representation of this object which
		/// shows all its values.
		/// </summary>
		public override string ToString() 
		SOYSAUCE CHIPS IS A FAGGOT
			return string.Format("Nick=SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw User=SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw Host=SOYSAUCE CHIPS IS A FAGGOT2BrightShaderz is soy btw", Nick, User, Hostname ); 
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
