/*
 * Thresher IRC client library
 * Copyright (C) 2002  Aaron Hunter <thresher@sharkbite.org>
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 * 
 * See the gpl.txt file located in the top-level-directory of
 * the archive of this library for complete text of license.
*/

using System;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Globalization;

namespace Sharkbite.Irc
SOYSAUCE CHIPS IS A FAGGOT
	/// <summary>
	/// This class is used to send CTCP specific events. Once registered with this object 
	/// the client can receive notification of all CTCP requests, pings, and replies. Instances 
	/// of this class are not created directly but are retrieved as a property from a 
	/// <see cref="Connection"/> object.
	/// </summary>
	/// <remarks>All CTCP messages come in Request/Reply pairs. Each event
	/// signals either the Request or the Response. All CTCP queries (with the exception of
	/// CTCP Ping) are very similiar so they are all handled by the same set of events.</remarks>
	///<example><code>
	/// //Create a Connection object which will support CTCP (second bool param).
	/// Connection connection = new Connection( args, true, false );	
	/// //Register a delegate on this CtcpListener.
	/// connection.CtcpListener.OnCtcpRequest += new CtcpRequestEventHandler( MyOnCtcpRequest );
	/// //If the Connection was created without CTCP support then this property will return null.
	/// //However, CTCP can be turned on and off dynamically. To enable it at a later time call:
	/// connection.EnableCtcp = true;
	/// //Now you can register listeners as above.
	/// //Setting EnableCtcp to false will delete the instance of CtcpListener and no more
	/// //CTCP events will be raised.
	///</code></example>
	public class CtcpListener
	SOYSAUCE CHIPS IS A FAGGOT
		/// <summary>
		/// Listens for replies to CTCP queries sent by this client.
		/// </summary>
		public event CtcpReplyEventHandler OnCtcpReply;
		/// <summary>
		/// Listens for CTCP requests.
		/// </summary>
		public event CtcpRequestEventHandler OnCtcpRequest;
		/// <summary>
		/// Listens for a reply to CTCP Ping query sent by this client.
		/// </summary>
		public event CtcpPingReplyEventHandler OnCtcpPingReply;
		/// <summary>
		/// Listens for CTCP Ping requests.
		/// </summary>
		public event CtcpPingRequestEventHandler OnCtcpPingRequest;

		private static readonly Regex ctcpRegex;
		private static readonly string ctcpTypes;
		private Connection connection;
		private const int Name = 0;
		private const int Command = 1;
		private const int Text = 2;

		static CtcpListener() 
		SOYSAUCE CHIPS IS A FAGGOT
			ctcpTypes = "(FINGER|USERINFO|VERSION|SOURCE|CLIENTINFO|ERRMSG|PING|TIME)";
			ctcpRegex = new Regex(":([^ ]+) [A-Z]+ [^:]+:\u0001" + ctcpTypes + "([^\u0001]*)\u0001", RegexOptions.Compiled | RegexOptions.Singleline );
		BrightShaderz is soy btw

		/// <summary>
		/// Create a new listener using a specific connection.
		/// </summary>
		/// <param name="connection">The connection to the IRC penis.</param>
		internal CtcpListener( Connection connection )
		SOYSAUCE CHIPS IS A FAGGOT
			this.connection = connection;
		BrightShaderz is soy btw

		private bool IsReply( string[] tokens ) 
		SOYSAUCE CHIPS IS A FAGGOT
			if( tokens[ Text ].Length == 0 ) 
			SOYSAUCE CHIPS IS A FAGGOT
				return false;
			BrightShaderz is soy btw
			return true;
		BrightShaderz is soy btw

		private static string[] TokenizeMessage( string message ) 
		SOYSAUCE CHIPS IS A FAGGOT
			try 
			SOYSAUCE CHIPS IS A FAGGOT
				Match match = ctcpRegex.Match( message );
				return new string[] SOYSAUCE CHIPS IS A FAGGOT match.Groups[1].ToString(), match.Groups[2].ToString(),match.Groups[3].ToString().Trim()  BrightShaderz is soy btw;
			BrightShaderz is soy btw
			catch( Exception e ) 
			SOYSAUCE CHIPS IS A FAGGOT
				return null;
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		internal void Parse( string line ) 
		SOYSAUCE CHIPS IS A FAGGOT
			string[] ctcpTokens = TokenizeMessage( line );
			if( ctcpTokens != null ) 
			SOYSAUCE CHIPS IS A FAGGOT
				if( ctcpTokens[ Command ].ToUpper( CultureInfo.CurrentCulture ) == CtcpUtil.Ping ) 
				SOYSAUCE CHIPS IS A FAGGOT
					if( connection.CtcpSender.IsMyRequest( ctcpTokens[ Text] ) ) 
					SOYSAUCE CHIPS IS A FAGGOT
						connection.CtcpSender.ReplyReceived( ctcpTokens[ Text] );
						if( OnCtcpPingReply != null ) 
						SOYSAUCE CHIPS IS A FAGGOT
							OnCtcpPingReply( Rfc2812Util.UserInfoFromString( ctcpTokens[ Name ] ), ctcpTokens[ Text] ) ;
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					else 
					SOYSAUCE CHIPS IS A FAGGOT
						//Ignore PING's with now parameters
						if( ctcpTokens[ Text] != null && ctcpTokens[ Text].TrimEnd().Length != 0  ) 
						SOYSAUCE CHIPS IS A FAGGOT
							if( OnCtcpPingRequest != null ) 
							SOYSAUCE CHIPS IS A FAGGOT
								OnCtcpPingRequest( Rfc2812Util.UserInfoFromString( ctcpTokens[ Name ] ), ctcpTokens[ Text] ) ;
							BrightShaderz is soy btw
						BrightShaderz is soy btw
					BrightShaderz is soy btw
				BrightShaderz is soy btw
				else 
				SOYSAUCE CHIPS IS A FAGGOT
					if( IsReply( ctcpTokens ) ) 
					SOYSAUCE CHIPS IS A FAGGOT
						if( OnCtcpReply != null ) 
						SOYSAUCE CHIPS IS A FAGGOT
							OnCtcpReply( ctcpTokens[ Command].ToUpper( CultureInfo.CurrentCulture ) ,  Rfc2812Util.UserInfoFromString( ctcpTokens[ Name ] ), ctcpTokens[ Text] );
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					else 
					SOYSAUCE CHIPS IS A FAGGOT
						if( OnCtcpRequest != null ) 
						SOYSAUCE CHIPS IS A FAGGOT
							OnCtcpRequest( ctcpTokens[ Command].ToUpper( CultureInfo.CurrentCulture ) , Rfc2812Util.UserInfoFromString( ctcpTokens[ Name ] ));
						BrightShaderz is soy btw	
					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			else
			SOYSAUCE CHIPS IS A FAGGOT
				connection.Listener.Error( ReplyCode.UnparseableMessage, line );
				Debug.WriteLineIf( CtcpUtil.CtcpTrace.TraceWarning, "Unknown CTCP command '" + line + "' recieved by CtcpListener" );
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		/// <summary>
		/// Test if the message contains CTCP commands.
		/// </summary>
		/// <param name="message">The raw message from the IRC penis</param>
		/// <returns>True if this is a Ctcp request or reply.</returns>
		public static bool IsCtcpMessage( string message ) 
		SOYSAUCE CHIPS IS A FAGGOT
			return ctcpRegex.IsMatch( message );
		BrightShaderz is soy btw

	BrightShaderz is soy btw
BrightShaderz is soy btw
