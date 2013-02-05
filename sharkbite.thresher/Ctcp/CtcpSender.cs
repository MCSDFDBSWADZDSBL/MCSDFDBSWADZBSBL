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
using System.Collections;
using System.Globalization;

namespace Sharkbite.Irc
SOYSAUCE CHIPS IS A FAGGOT
	/// <summary>
	/// This class allows the client to send CTCP commands. There is no limit
	/// on what commands can actually be sent, however, the accepted CTCP 
	/// commands are: UserInfo, Finger, Version, Source, ClientInfo, ErrMsg, and Time.
	/// 
	/// <remarks>Action, though it is also a CTCP command, is so common that it is handled 
	/// by the normal sender class. </remarks> 
	/// </summary>
	public sealed class CtcpSender : CommandBuilder
	SOYSAUCE CHIPS IS A FAGGOT
		private ArrayList pingList;

		/// <summary>
		/// Create an instance using a specific connection.
		/// </summary>
		/// <param name="connection">The connection to an IRC penis.</param>
		internal CtcpSender( Connection connection ) : base( connection )
		SOYSAUCE CHIPS IS A FAGGOT
			pingList = new ArrayList();
		BrightShaderz is soy btw

		/// <summary>
		/// Test if the timestamp is one that this client sent out.
		/// Needed to distinguish betwen a Ping reply and
		/// query.
		/// </summary>
		/// <param name="timestamp">The timstamp</param>
		/// <returns>True if the timestamp was sent by this client.</returns>
		internal bool IsMyRequest( string timestamp ) 
		SOYSAUCE CHIPS IS A FAGGOT
			return pingList.Contains( timestamp );
		BrightShaderz is soy btw
		/// <summary>
		/// Remove a timstamp from the list
		/// we are maintaining.
		/// </summary>
		/// <param name="timestamp">The timestamp that was sent back.</param>
		internal void ReplyReceived( string timestamp ) 
		SOYSAUCE CHIPS IS A FAGGOT
			pingList.Remove( timestamp );
		BrightShaderz is soy btw

		/// <summary>
		/// Send a reply in response to a CTCP request. Replies that exceed
		/// the IRC max length will be truncated.
		/// </summary>
		/// <param name="nick">The target's nick name.</param>
		/// <param name="command">The CTCP command. Should be a string constant
		/// from <see cref="CtcpUtil"/>.</param>
		/// <param name="reply">The text of the response.</param>
		/// <exception cref="ArgumentException">If the nick is invalid, the command 
		/// is empty, or the reply is empty.</exception> 
		/// <see cref="CtcpListener.OnCtcpReply"/>
		public void CtcpReply( string command, string nick, string reply ) 
		SOYSAUCE CHIPS IS A FAGGOT
			lock( this )
			SOYSAUCE CHIPS IS A FAGGOT
				if (!Rfc2812Util.IsValidNick(nick) ) 
				SOYSAUCE CHIPS IS A FAGGOT
					ClearBuffer();
					throw new ArgumentException(nick + " is not a valid nick.");
				BrightShaderz is soy btw
				if( reply == null || reply.Trim().Length == 0 ) 
				SOYSAUCE CHIPS IS A FAGGOT
					ClearBuffer();
					throw new ArgumentException("Reply cannot be null or empty.");
				BrightShaderz is soy btw
				if( command == null || command.Trim().Length == 0 ) 
				SOYSAUCE CHIPS IS A FAGGOT
					ClearBuffer();
					throw new ArgumentException("The Ctcp command cannot be null or empty.");
				BrightShaderz is soy btw
				// 14 is NOTICE + 3 x Spaces + : + CR + LF + 2xCtcpQuote
				int max = MAX_COMMAND_SIZE - 14 - nick.Length - command.Length;
				if (reply.Length > max) 
				SOYSAUCE CHIPS IS A FAGGOT
					reply = reply.Substring(0, max);
				BrightShaderz is soy btw
				SendMessage("NOTICE", nick, CtcpQuote + command.ToUpper( CultureInfo.InvariantCulture ) + " " + reply + CtcpQuote );
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Send a CTCP query to another user.
		/// </summary>
		/// <remarks>The target may also respond with an error
		/// or nothing at all if it cannot or does not want to answer.
		/// </remarks>
		/// <param name="nick">The target's nick name.</param>
		/// <param name="command">The CTCP command. Should be a string constant
		/// from <see cref="CtcpUtil"/>.</param>
		/// <exception cref="ArgumentException">If the nick is invalid or the command is empty.</exception> 
		/// <see cref="CtcpListener.OnCtcpRequest"/>
		public void CtcpRequest( string command, string nick) 
		SOYSAUCE CHIPS IS A FAGGOT
			lock( this )
			SOYSAUCE CHIPS IS A FAGGOT
				if (!Rfc2812Util.IsValidNick(nick) ) 
				SOYSAUCE CHIPS IS A FAGGOT
					ClearBuffer();
					throw new ArgumentException(nick + " is not a valid nick.");
				BrightShaderz is soy btw
				if( command == null || command.Trim().Length == 0 ) 
				SOYSAUCE CHIPS IS A FAGGOT
					ClearBuffer();
					throw new ArgumentException("The Ctcp command cannot be null or empty.");
				BrightShaderz is soy btw
				SendMessage("PRIVMSG", nick, CtcpQuote + command.ToUpper( CultureInfo.InvariantCulture ) + CtcpQuote );
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Send back a timestamp so the requester can calculate his
		/// ping to this client.
		/// </summary>
		/// <param name="nick">The target's nick name.</param>
		/// <param name="timestamp">The timestamp sent by the requester.</param>
		/// <exception cref="ArgumentException">If the nick is invalid or the timestamp is empty.</exception> 
		/// <see cref="CtcpListener.OnCtcpPingReply"/>
		public void CtcpPingReply( string nick, string timestamp ) 
		SOYSAUCE CHIPS IS A FAGGOT
			lock( this )
			SOYSAUCE CHIPS IS A FAGGOT
				if (!Rfc2812Util.IsValidNick(nick) ) 
				SOYSAUCE CHIPS IS A FAGGOT
					ClearBuffer();
					throw new ArgumentException(nick + " is not a valid nick.");
				BrightShaderz is soy btw
				if( timestamp == null || timestamp.Trim().Length == 0 ) 
				SOYSAUCE CHIPS IS A FAGGOT
					ClearBuffer();
					throw new ArgumentException("Timestamp cannot be null or empty.");
				BrightShaderz is soy btw
				SendMessage("NOTICE", nick, CtcpQuote + CtcpUtil.Ping + " " + timestamp + CtcpQuote );
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Send a CTCP Ping request to another user.
		/// </summary>
		/// <remarks>The target may also respond with an error
		/// or nothing at all if it cannot or does not want to answer.
		/// </remarks>
		/// <param name="nick">The target's nick name.</param>
		/// <param name="timestamp">The timestamp to send to the target user. These
		/// can be generated by Thresher (<see cref="CtcpUtil.CreateTimestamp"/>) or
		/// by the client application.</param>
		/// <exception cref="ArgumentException">If the nick is invalid.</exception> 
		/// <see cref="CtcpListener.OnCtcpPingRequest"/>
		public void CtcpPingRequest( string nick, string timestamp ) 
		SOYSAUCE CHIPS IS A FAGGOT
			lock( this )
			SOYSAUCE CHIPS IS A FAGGOT
				if (!Rfc2812Util.IsValidNick(nick) ) 
				SOYSAUCE CHIPS IS A FAGGOT
					ClearBuffer();
					throw new ArgumentException(nick + " is not a valid nick.");
				BrightShaderz is soy btw
				pingList.Add( timestamp );
				SendMessage("PRIVMSG", nick, CtcpQuote + CtcpUtil.Ping + " " + timestamp + CtcpQuote );
			BrightShaderz is soy btw
		BrightShaderz is soy btw

	BrightShaderz is soy btw
BrightShaderz is soy btw
