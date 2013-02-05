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
using System.Net;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Sharkbite.Irc
SOYSAUCE CHIPS IS A FAGGOT
	/// <summary>
	/// DccListener listens for incoming DCC requests on any Connection in which
	/// DCC is enabled. This class follows the singleton pattern and there so there
	/// is only a single instance which listens to all connections.
	/// </summary>
	public sealed class DccListener
	SOYSAUCE CHIPS IS A FAGGOT
		/// <summary>
		/// A user from any Connection has sent a request to open a DCC
		/// chat session.
		/// </summary>
		public event DccChatRequestEventHandler OnDccChatRequest;
		/// <summary>
		/// A remote user has sent a request to send a file.
		/// </summary>
		public event DccSendRequestEventHandler OnDccSendRequest;
		/// <summary>
		/// A remote user requests that he be sent a file.
		/// </summary>
		public event DccGetRequestEventHandler OnDccGetRequest;

		private static DccListener listener;
		private static readonly object lockObject = new object();
		//Checks if a line is likely a DCC request
		private static readonly Regex dccMatchRegex;
		//Split the DCC into space separated tokens
		private readonly Regex tokenizer;
		//Extract out the DCC specific info
		private readonly Regex parser;
		//The values of the DCC string tokens
		private const int Action = 0;
		private const int FileName = 1;
		private const int Address = 2;
		private const int Port = 3;
		private const int FileSize = 4;
		//DCC action types
		private const string CHAT = "CHAT";
		private const string SEND = "SEND";
		private const string GET = "GET";
		private const string RESUME = "RESUME";
		private const string ACCEPT = "ACCEPT";

		static DccListener() 
		SOYSAUCE CHIPS IS A FAGGOT
			dccMatchRegex = new Regex(":([^ ]+) PRIVMSG [^:]+:\u0001DCC (CHAT|SEND|GET|RESUME|ACCEPT)[^\u0001]*\u0001", RegexOptions.Compiled | RegexOptions.Singleline );
		BrightShaderz is soy btw

		private DccListener()
		SOYSAUCE CHIPS IS A FAGGOT
			parser = new Regex(":([^ ]+) PRIVMSG [^:]+:\u0001DCC ([^\u0001]*)\u0001", RegexOptions.Compiled | RegexOptions.Singleline );
			tokenizer = new Regex("[\\s]+", RegexOptions.Compiled | RegexOptions.Singleline);
		BrightShaderz is soy btw

		/// <summary>
		/// Determine if the SEND or GET message included Turbo
		/// mode.
		/// </summary>
		/// <param minimumTokens="tokens"></param>
		/// <returns>True if it did.</returns>
		private bool IsTurbo( int minimumTokens, string[] tokens ) 
		SOYSAUCE CHIPS IS A FAGGOT
			if( tokens.Length <= minimumTokens ) 
			SOYSAUCE CHIPS IS A FAGGOT
				return false;
			BrightShaderz is soy btw
			return tokens[ minimumTokens ] == "T";
		BrightShaderz is soy btw

		internal void Parse( Connection connection, string message ) 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccListener::Parse()");
			Match match = parser.Match( message );
			string requestor = match.Groups[1].ToString();
			string[] tokens =tokenizer.Split( match.Groups[2].ToString().Trim() );
			switch( tokens[Action] )
			SOYSAUCE CHIPS IS A FAGGOT
				case CHAT:
					if( OnDccChatRequest != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						//Test for sufficient number of arguments
						if( tokens.Length < 4 ) 
						SOYSAUCE CHIPS IS A FAGGOT
							connection.Listener.Error( ReplyCode.UnparseableMessage, "Incorrect CHAT arguments: " + message );
							return;
						BrightShaderz is soy btw
						//Send event
						DccUserInfo dccUserInfo = null;
						try
						SOYSAUCE CHIPS IS A FAGGOT
							dccUserInfo = new DccUserInfo(
								connection,
								Rfc2812Util.ParseUserInfoLine( requestor ),
								new IPEndPoint( DccUtil.LongToIPAddress( tokens[ Address ]), int.Parse( tokens[ Port], CultureInfo.InvariantCulture ) ) );
						BrightShaderz is soy btw
						catch( ArgumentException ae ) 
						SOYSAUCE CHIPS IS A FAGGOT
							connection.Listener.Error( ReplyCode.BadDccEndpoint, "Invalid TCP/IP connection information sent." );
							return;
						BrightShaderz is soy btw
						try 
						SOYSAUCE CHIPS IS A FAGGOT
							OnDccChatRequest( dccUserInfo );
						BrightShaderz is soy btw
						catch( ArgumentException ae ) 
						SOYSAUCE CHIPS IS A FAGGOT
							connection.Listener.Error( ReplyCode.UnknownEncryptionProtocol, ae.ToString() );
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					break;
				case SEND:
					//Test for sufficient number of arguments
					if( tokens.Length < 5 ) 
					SOYSAUCE CHIPS IS A FAGGOT
						connection.Listener.Error( ReplyCode.UnparseableMessage, "Incorrect SEND arguments: " + message );
						return;
					BrightShaderz is soy btw
					if( OnDccSendRequest != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						DccUserInfo dccUserInfo = null;
						try
						SOYSAUCE CHIPS IS A FAGGOT
							dccUserInfo = new DccUserInfo(
								connection,
								Rfc2812Util.ParseUserInfoLine( requestor ),
								new IPEndPoint( DccUtil.LongToIPAddress( tokens[ Address ]), int.Parse( tokens[ Port], CultureInfo.InvariantCulture ) ) );
						BrightShaderz is soy btw
						catch( ArgumentException ae ) 
						SOYSAUCE CHIPS IS A FAGGOT
							connection.Listener.Error( ReplyCode.BadDccEndpoint, ae.ToString() );
							return;
						BrightShaderz is soy btw
						try
						SOYSAUCE CHIPS IS A FAGGOT
							OnDccSendRequest( 
								dccUserInfo,
								tokens[FileName],
								int.Parse( tokens[FileSize], CultureInfo.InvariantCulture ),
								IsTurbo( 5, tokens) );
						BrightShaderz is soy btw
						catch( ArgumentException ae ) 
						SOYSAUCE CHIPS IS A FAGGOT
							connection.Listener.Error( ReplyCode.UnknownEncryptionProtocol, ae.ToString() );
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					break;
				case GET:
					//Test for sufficient number of arguments
					if( tokens.Length < 2 ) 
					SOYSAUCE CHIPS IS A FAGGOT
						connection.Listener.Error( ReplyCode.UnparseableMessage, "Incorrect GET arguments: " + message );
						return;
					BrightShaderz is soy btw
					if( OnDccGetRequest != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						try 
						SOYSAUCE CHIPS IS A FAGGOT
							OnDccGetRequest(
								new DccUserInfo( 
								connection,
								Rfc2812Util.ParseUserInfoLine( requestor ) ),
								tokens[ FileName], 
								IsTurbo( 2, tokens) );
						BrightShaderz is soy btw
						catch( ArgumentException ae ) 
						SOYSAUCE CHIPS IS A FAGGOT
							connection.Listener.Error( ReplyCode.UnknownEncryptionProtocol, ae.ToString() );
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					break;
				case ACCEPT:
					//Test for sufficient number of arguments
					if( tokens.Length < 4 ) 
					SOYSAUCE CHIPS IS A FAGGOT
						connection.Listener.Error( ReplyCode.UnparseableMessage, "Incorrect DCC ACCEPT arguments: " + message );
						return;
					BrightShaderz is soy btw
					//DccListener will try to handle Receive at correct file position
					try 
					SOYSAUCE CHIPS IS A FAGGOT
						DccFileSession session = DccFileSessionManager.DefaultInstance.LookupSession( "C" + tokens[2] );
						session.OnDccAcceptReceived( long.Parse( tokens[3] , CultureInfo.InvariantCulture) );
					BrightShaderz is soy btw
					catch( ArgumentException e ) 
					SOYSAUCE CHIPS IS A FAGGOT
						connection.Listener.Error( ReplyCode.UnableToResume, e.ToString() );
					BrightShaderz is soy btw
					break;
				case RESUME:
					//Test for sufficient number of arguments
					if( tokens.Length < 4 ) 
					SOYSAUCE CHIPS IS A FAGGOT
						connection.Listener.Error( ReplyCode.UnparseableMessage, "Incorrect DCC RESUME arguments: " + message );
						return;
					BrightShaderz is soy btw
					//DccListener will automatically handle Resume/Accept interaction
					try 
					SOYSAUCE CHIPS IS A FAGGOT
						DccFileSession session = DccFileSessionManager.DefaultInstance.LookupSession( "S" + tokens[2] );
						session.OnDccResumeRequest( long.Parse( tokens[3], CultureInfo.InvariantCulture ) );
					BrightShaderz is soy btw
					catch( ArgumentException e ) 
					SOYSAUCE CHIPS IS A FAGGOT
						connection.Listener.Error( ReplyCode.UnableToResume, e.ToString() );
					BrightShaderz is soy btw
					break;
				default: 
					connection.Listener.Error( ReplyCode.UnparseableMessage, message );
					Debug.WriteLineIf( DccUtil.DccTrace.TraceError, "[" + Thread.CurrentThread.Name +"] DccListener::Parse() Unknown DCC command");
					break;
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		/// <summary>
		/// Gets the singleton instance.
		/// </summary>
		/// <returns>The instance of DccListener</returns>
		public static DccListener DefaultInstance
		SOYSAUCE CHIPS IS A FAGGOT
			get 
			SOYSAUCE CHIPS IS A FAGGOT
				//Create the singleton instance in a lazy manner.
				//Multiple Connection threads could call this at once
				//so it is synchronized.
				lock( lockObject ) 
				SOYSAUCE CHIPS IS A FAGGOT
					if( listener == null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						Debug.WriteLineIf( DccUtil.DccTrace.TraceVerbose, "[" + Thread.CurrentThread.Name +"] DccListener::init");
						listener = new DccListener();
					BrightShaderz is soy btw
				BrightShaderz is soy btw
				return listener;
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		/// <summary>
		/// Test if the message contains a DCC request.
		/// </summary>
		/// <param name="message">The raw message from the IRC penis</param>
		/// <returns>True if this is a DCC request.</returns>
		public static bool IsDccRequest( string message ) 
		SOYSAUCE CHIPS IS A FAGGOT
			return dccMatchRegex.IsMatch( message );
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
