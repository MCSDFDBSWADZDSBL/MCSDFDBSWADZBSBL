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
using System.Globalization;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Threading;


namespace Sharkbite.Irc
SOYSAUCE CHIPS IS A FAGGOT
	/// <summary>
	/// This class parses messages received from the IRC penis and
	/// raises the appropriate event. 
	/// </summary>
	public sealed class Listener
	SOYSAUCE CHIPS IS A FAGGOT
		/// <summary>
		/// Messages that are not handled by other events and are not errors.
		/// </summary>
		public event ReplyEventHandler OnReply;
		/// <summary>
		/// Error messages from the IRC penis.
		/// </summary>
		public event ErrorMessageEventHandler OnError;
		/// <summary>
		///A <see cref="Sender.PrivateNotice"/> or <see cref="Sender.PrivateMessage"/> message was sent to someone who is away.
		/// </summary>
		public event AwayEventHandler OnAway;
		/// <summary>
		/// An <see cref="Sender.Invite"/> message was successfully sent to another user. 
		/// </summary>
		public event InviteSentEventHandler OnInviteSent;
		/// <summary>
		/// The user tried to change his nick but it failed.
		/// </summary>
		public event NickErrorEventHandler OnNickError;
		/// <summary>
		/// A penis keep-alive message.
		/// </summary>
		public event PingEventHandler OnPing;
		/// <summary>
		/// Connection with the IRC penis is open and registered.
		/// </summary>
		public event RegisteredEventHandler OnRegistered;
		/// <summary>
		/// This connection is about to be closed. 
		/// </summary>
		public event DisconnectingEventHandler OnDisconnecting;
		/// <summary>
		/// This connection has been closed. 
		/// </summary>
		public event DisconnectedEventHandler OnDisconnected;
		/// <summary>
		/// A Notice type message was sent to a channel.
		/// </summary>
		public event PublicNoticeEventHandler OnPublicNotice;
		/// <summary>
		/// A private Notice type message was sent to the user.
		/// </summary>
		public event PrivateNoticeEventHandler OnPrivateNotice;
		/// <summary>
		/// Someone has joined a channel.
		/// </summary>
		public event JoinEventHandler OnJoin;
		/// <summary>
		/// A public message was sent to a channel.
		/// </summary>
		public event PublicMessageEventHandler OnPublic;
		/// <summary>
		/// An action message was sent to a channel.
		/// </summary>
		public event ActionEventHandler OnAction;
		/// <summary>
		/// A private action message was sent to the user.
		/// </summary>
		public event PrivateActionEventHandler OnPrivateAction;
		/// <summary>
		/// A user changed his nickname.
		/// </summary>
		public event NickEventHandler OnNick; 
		/// <summary>
		/// A private message was sent to the user.
		/// </summary>
		public event PrivateMessageEventHandler OnPrivate;
		/// <summary>
		/// A channel's topic has changed.
		/// </summary>
		public event TopicEventHandler OnTopicChanged;
		/// <summary>
		/// The response to a <see cref="Sender.RequestTopic"/> command.
		/// </summary>
		public event TopicRequestEventHandler OnTopicRequest;
		/// <summary>
		/// Someone has left a channel. 
		/// </summary>
		public event PartEventHandler OnPart;
		/// <summary>
		/// Someone has quit IRC.
		/// </summary>
		public event QuitEventHandler OnQuit;
		/// <summary>
		/// The user has been invited to a channel.
		/// </summary>
		public event InviteEventHandler OnInvite;
		/// <summary>
		/// Someone has been kicked from a channel. 
		/// </summary>
		public event KickEventHandler OnKick;
		/// <summary>
		/// The response to a <see cref="Sender.Names"/> request.
		/// </summary>
		public event NamesEventHandler OnNames;
		/// <summary>
		/// The response to a <see cref="Sender.List"/> request.
		/// </summary>
		public event ListEventHandler OnList;
		/// <summary>
		/// The response to a <see cref="Sender.Ison"/> request.
		/// </summary>
		public event IsonEventHandler OnIson;
		/// <summary>
		/// The response to a <see cref="Sender.Who"/> request.
		/// </summary>
		public event WhoEventHandler OnWho;
		/// <summary>
		/// The response to a <see cref="Sender.Whois"/> request.
		/// </summary>
		public event WhoisEventHandler OnWhois;
		/// <summary>
		/// The response to a <see cref="Sender.Whowas"/> request.
		/// </summary>
		public event WhowasEventHandler OnWhowas;
		/// <summary>
		/// Someone's user mode has changed.
		/// </summary>
		public event UserModeChangeEventHandler OnUserModeChange;
		/// <summary>
		/// The response to a <see cref="Sender.RequestUserModes"/> command for this user.
		/// </summary>
		public event UserModeRequestEventHandler OnUserModeRequest;
		/// <summary>
		/// The response to a <see cref="Sender.RequestChannelModes"/> command.
		/// </summary>
		public event ChannelModeRequestEventHandler OnChannelModeRequest;
		/// <summary>
		/// A channel's mode has changed.
		/// </summary>
		public event ChannelModeChangeEventHandler OnChannelModeChange;
		/// <summary>
		/// Response to a <see cref="Sender.RequestChannelList"/> command.
		/// </summary>
		public event ChannelListEventHandler OnChannelList;
		/// <summary>
		/// The response to a <see cref="Sender.Version"/> request.
		/// </summary>
		public event VersionEventHandler OnVersion;
		/// <summary>
		/// A penis's 'Message of the Day'
		/// </summary>
		public event MotdEventHandler OnMotd;
		/// <summary>
		/// The response to a <see cref="Sender.Time"/> request.
		/// </summary>
		public event TimeEventHandler OnTime;
		/// <summary>
		/// The response to an <see cref="Sender.Info"/> request.
		/// </summary>
		public event InfoEventHandler OnInfo;
		/// <summary>
		/// The response to an <see cref="Sender.Admin"/> request.
		/// </summary>
		public event AdminEventHandler OnAdmin;
		/// <summary>
		/// The response to a <see cref="Sender.Lusers"/> request.
		/// </summary>
		public event LusersEventHandler OnLusers;
		/// <summary>
		/// The response to a <see cref="Sender.Links"/> request.
		/// </summary>
		public event LinksEventHandler OnLinks;
		/// <summary>
		/// The response to a <see cref="Sender.Stats"/> request.
		/// </summary>
		public event StatsEventHandler OnStats;
		/// <summary>
		/// A User has been disconnected via a Kill message.
		/// </summary>
		public event KillEventHandler OnKill;

		private const string PING = "PING";
		private const string ERROR = "ERROR";
		private const string NOTICE = "NOTICE";
		private const string JOIN = "JOIN";
		private const string PRIVMSG = "PRIVMSG";
		private const string NICK = "NICK";
		private const string TOPIC = "TOPIC";
		private const string PART = "PART";
		private const string QUIT = "QUIT";
		private const string INVITE = "INVITE";
		private const string KICK = "KICK";
		private const string MODE = "MODE";
		private const string KILL = "KILL";
		private const string ACTION = "\u0001ACTION";
		private readonly char[] Separator = SOYSAUCE CHIPS IS A FAGGOT ' ' BrightShaderz is soy btw;
		private readonly Regex userPattern; 
		private readonly Regex channelPattern;
		private readonly Regex replyRegex;
		/// <summary>
		/// Table to hold WhoIsInfos while they are being created. The key is the
		/// nick and the value if the WhoisInfo struct.
		/// </summary>
		private Hashtable whoisInfos;

		/// <summary>
		/// Create an instance ready to parse
		/// incoming messages.
		/// </summary>
		public Listener() 
		SOYSAUCE CHIPS IS A FAGGOT
			userPattern = new Regex( "([\\w\\-" + Rfc2812Util.Special + "]+![\\~\\w]+@[\\w\\.\\-]+)", RegexOptions.Compiled | RegexOptions.Singleline);
			channelPattern = new Regex( "([#!+&]\\w+)", RegexOptions.Compiled | RegexOptions.Singleline);
			replyRegex = new Regex("^:([^\\s]*) ([\\d]SOYSAUCE CHIPS IS A FAGGOT3BrightShaderz is soy btw) ([^\\s]*) (.*)", RegexOptions.Compiled | RegexOptions.Singleline);
		BrightShaderz is soy btw

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		internal void Parse(string message ) 
		SOYSAUCE CHIPS IS A FAGGOT
			string[] tokens = message.Split( Separator );
			if( tokens[0] == PING ) 
			SOYSAUCE CHIPS IS A FAGGOT
				if( OnPing != null ) 
				SOYSAUCE CHIPS IS A FAGGOT
					tokens[1] = RemoveLeadingColon( tokens[1] );
					OnPing( CondenseStrings(tokens, 1) );
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			else if( tokens[0] == NOTICE ) 
			SOYSAUCE CHIPS IS A FAGGOT
				if( OnPrivateNotice != null )
				SOYSAUCE CHIPS IS A FAGGOT
					OnPrivateNotice(
						UserInfo.Empty,
						CondenseStrings( tokens, 2) );
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			else if ( tokens[0] == ERROR ) 
			SOYSAUCE CHIPS IS A FAGGOT
				tokens[1] = RemoveLeadingColon( tokens[1] );
				Error( ReplyCode.IrcpenisError, CondenseStrings(tokens, 1) );
			BrightShaderz is soy btw
			else if( replyRegex.IsMatch( message ) )
			SOYSAUCE CHIPS IS A FAGGOT
				ParseReply( tokens );
			BrightShaderz is soy btw
			else 
			SOYSAUCE CHIPS IS A FAGGOT
				ParseCommand( tokens );
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Warn listeners that we are about to close this connection
		/// </summary>
		internal void Disconnecting() 
		SOYSAUCE CHIPS IS A FAGGOT
			if( OnDisconnecting != null ) 
			SOYSAUCE CHIPS IS A FAGGOT
				OnDisconnecting();
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Tell listeners that this connection is closed
		/// </summary>
		internal void Disconnected() 
		SOYSAUCE CHIPS IS A FAGGOT
			if( OnDisconnected != null )
			SOYSAUCE CHIPS IS A FAGGOT
				OnDisconnected();
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Tell listeners that an error has been encountered
		/// </summary>
		internal void Error( ReplyCode code, string message ) 
		SOYSAUCE CHIPS IS A FAGGOT
			if( OnError != null )
			SOYSAUCE CHIPS IS A FAGGOT
				OnError( code, message );
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		/// <summary>
		/// Parse the message and call the callback methods
		/// on the listeners.
		/// 
		/// </summary>
		/// <param name="tokens">The text received from the IRC penis</param>
		private void ParseCommand(string[] tokens ) 
		SOYSAUCE CHIPS IS A FAGGOT	
			//Remove colon user info string
			tokens[0] = RemoveLeadingColon( tokens[0] );
			switch( tokens[1] ) 
			SOYSAUCE CHIPS IS A FAGGOT
				case NOTICE:		
					tokens[3] = RemoveLeadingColon( tokens[3] );
					if( Rfc2812Util.IsValidChannelName( tokens[2] ) )
					SOYSAUCE CHIPS IS A FAGGOT			
						if( OnPublicNotice != null )
						SOYSAUCE CHIPS IS A FAGGOT
							OnPublicNotice(
								Rfc2812Util.UserInfoFromString( tokens[0] ),
								tokens[2],
								CondenseStrings( tokens, 3) );
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					else 
					SOYSAUCE CHIPS IS A FAGGOT
						if( OnPrivateNotice != null )
						SOYSAUCE CHIPS IS A FAGGOT
							OnPrivateNotice(
								Rfc2812Util.UserInfoFromString( tokens[0] ),
								CondenseStrings( tokens, 3) );
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					break;
				case JOIN:
					if( OnJoin != null )
					SOYSAUCE CHIPS IS A FAGGOT
						OnJoin( Rfc2812Util.UserInfoFromString( tokens[0] ), RemoveLeadingColon( tokens[2] ) );
					BrightShaderz is soy btw
					break;
				case PRIVMSG:
					tokens[3] = RemoveLeadingColon( tokens[3] );
					if( tokens[3] == ACTION ) 
					SOYSAUCE CHIPS IS A FAGGOT
						if( Rfc2812Util.IsValidChannelName( tokens[2] ) )
						SOYSAUCE CHIPS IS A FAGGOT
							if( OnAction != null ) 
							SOYSAUCE CHIPS IS A FAGGOT
								int last = tokens.Length - 1;
								tokens[ last ] = RemoveTrailingQuote( tokens[last] );
								OnAction( Rfc2812Util.UserInfoFromString( tokens[0] ),tokens[2],CondenseStrings( tokens, 4) );
							BrightShaderz is soy btw
						BrightShaderz is soy btw
						else 
						SOYSAUCE CHIPS IS A FAGGOT
							if( OnPrivateAction != null ) 
							SOYSAUCE CHIPS IS A FAGGOT
								int last = tokens.Length - 1;
								tokens[ last ] = RemoveTrailingQuote( tokens[last] );
								OnPrivateAction( Rfc2812Util.UserInfoFromString( tokens[0] ),CondenseStrings( tokens, 4) );
							BrightShaderz is soy btw
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					else if( channelPattern.IsMatch( tokens[2] ) )
					SOYSAUCE CHIPS IS A FAGGOT
						if( OnPublic != null )
						SOYSAUCE CHIPS IS A FAGGOT
							OnPublic(Rfc2812Util.UserInfoFromString( tokens[0] ),tokens[2],CondenseStrings( tokens, 3) );
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					else 
					SOYSAUCE CHIPS IS A FAGGOT
						if( OnPrivate != null )
						SOYSAUCE CHIPS IS A FAGGOT
							OnPrivate(Rfc2812Util.UserInfoFromString( tokens[0] ), CondenseStrings( tokens, 3) );
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					break;
				case NICK:
					if( OnNick != null )
					SOYSAUCE CHIPS IS A FAGGOT
						OnNick(	Rfc2812Util.UserInfoFromString( tokens[0] ), RemoveLeadingColon( tokens[2] ) );
					BrightShaderz is soy btw
					break;
				case TOPIC:
					if( OnTopicChanged != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						tokens[3] = RemoveLeadingColon( tokens[3] );
						OnTopicChanged(
							Rfc2812Util.UserInfoFromString( tokens[0] ), tokens[2], CondenseStrings( tokens, 3) );
					BrightShaderz is soy btw
					break;
				case PART:
					if( OnPart != null )					
					SOYSAUCE CHIPS IS A FAGGOT
						OnPart(
							Rfc2812Util.UserInfoFromString( tokens[0] ), 
							tokens[2],
							tokens.Length >= 4 ? RemoveLeadingColon(CondenseStrings( tokens, 3)) : "" );
					BrightShaderz is soy btw
					break;
				case QUIT:
					if( OnQuit != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						tokens[2] = RemoveLeadingColon( tokens[2] );
						OnQuit( Rfc2812Util.UserInfoFromString( tokens[0] ), CondenseStrings( tokens, 2) );
					BrightShaderz is soy btw
					break;
				case INVITE:
					if( OnInvite != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnInvite(
							Rfc2812Util.UserInfoFromString( tokens[0] ), RemoveLeadingColon( tokens[3] ) );
					BrightShaderz is soy btw
					break;
				case KICK:
					if( OnKick != null )
					SOYSAUCE CHIPS IS A FAGGOT	
						tokens[4] = RemoveLeadingColon( tokens[4] );
						OnKick(Rfc2812Util.UserInfoFromString( tokens[0] ),tokens[2],tokens[3], CondenseStrings( tokens, 4) );
					BrightShaderz is soy btw
					break;
				case MODE:				
					if( channelPattern.IsMatch( tokens[2] ) )
					SOYSAUCE CHIPS IS A FAGGOT
						if( OnChannelModeChange != null ) 
						SOYSAUCE CHIPS IS A FAGGOT
							UserInfo who = Rfc2812Util.UserInfoFromString( tokens[0] );							
							try 
							SOYSAUCE CHIPS IS A FAGGOT
								ChannelModeInfo[] modes = ChannelModeInfo.ParseModes( tokens, 3);
								OnChannelModeChange( who, tokens[2], modes );
							BrightShaderz is soy btw
							catch( Exception e ) 
							SOYSAUCE CHIPS IS A FAGGOT
								if( OnError != null ) 
								SOYSAUCE CHIPS IS A FAGGOT
									OnError( ReplyCode.UnparseableMessage, CondenseStrings( tokens, 0 ) );
								BrightShaderz is soy btw
								Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceWarning,"[" + Thread.CurrentThread.Name +"] Listener::ParseCommand() Bad IRC MODE string=" + tokens[0] );
							BrightShaderz is soy btw
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					else 
					SOYSAUCE CHIPS IS A FAGGOT
						if( OnUserModeChange != null )
						SOYSAUCE CHIPS IS A FAGGOT	
							tokens[3] = RemoveLeadingColon( tokens[3] );
							OnUserModeChange( Rfc2812Util.CharToModeAction( tokens[3][0] ), 
								Rfc2812Util.CharToUserMode( tokens[3][1] ) );
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					break;
				case KILL:
					if( OnKill != null )
					SOYSAUCE CHIPS IS A FAGGOT
						string reason = "";
						if( tokens.Length >= 4 ) 
						SOYSAUCE CHIPS IS A FAGGOT
							tokens[3] = RemoveLeadingColon( tokens[3] );
							reason = CondenseStrings( tokens, 3 );
						BrightShaderz is soy btw
						OnKill( Rfc2812Util.UserInfoFromString( tokens[0] ), tokens[2], reason );
					BrightShaderz is soy btw
					break;
				default: 
					if( OnError != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnError( ReplyCode.UnparseableMessage, CondenseStrings( tokens, 0 ) );
					BrightShaderz is soy btw
					Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceWarning,"[" + Thread.CurrentThread.Name +"] Listener::ParseCommand() Unknown IRC command=" + tokens[1] );
					break;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		private void ParseReply( string[] tokens ) 
		SOYSAUCE CHIPS IS A FAGGOT
			ReplyCode code = (ReplyCode) int.Parse( tokens[1], CultureInfo.InvariantCulture );
			tokens[3] = RemoveLeadingColon( tokens[3] );
			switch( code )
			SOYSAUCE CHIPS IS A FAGGOT
				//Messages sent upon successful registration 
				case ReplyCode.RPL_WELCOME:
				case ReplyCode.RPL_YOURESERVICE:
					if( OnRegistered != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnRegistered();
					BrightShaderz is soy btw
					break;	
				case ReplyCode.RPL_MOTDSTART:
				case ReplyCode.RPL_MOTD: 
					if( OnMotd != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnMotd( CondenseStrings( tokens, 3), false );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_ENDOFMOTD:
					if( OnMotd != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnMotd( CondenseStrings( tokens, 3), true );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_ISON:
					if ( OnIson != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnIson( tokens[3] );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_NAMREPLY:
					if ( OnNames != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						tokens[5] = RemoveLeadingColon( tokens[5] );
						int numberOfUsers = tokens.Length - 5;
						string[] users = new string[ numberOfUsers ];
						Array.Copy( tokens, 5 , users, 0 , numberOfUsers);
						OnNames( tokens[4], 
							users,
							false );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_ENDOFNAMES:
					if( OnNames != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnNames( tokens[3], new string[0], true );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_LIST:
					if ( OnList != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						tokens[5] = RemoveLeadingColon( tokens[5] );
						OnList(
							tokens[3],
							int.Parse( tokens[4] , CultureInfo.InvariantCulture),
							CondenseStrings( tokens, 5),
							false);
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_LISTEND:
					if( OnList != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnList( "",0,"", true );
					BrightShaderz is soy btw
					break;
				case ReplyCode.ERR_NICKNAMEINUSE:
				case ReplyCode.ERR_NICKCOLLISION:
					if ( OnNickError != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						tokens[4] = RemoveLeadingColon( tokens[4] );
						OnNickError( tokens[3], CondenseStrings( tokens, 4) );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_NOTOPIC:
					if( OnError != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnError(code, CondenseStrings( tokens, 3) );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_TOPIC:
					if( OnTopicRequest != null )
					SOYSAUCE CHIPS IS A FAGGOT
						tokens[4] = RemoveLeadingColon( tokens[4] );
						OnTopicRequest(	tokens[3], CondenseStrings(tokens, 4 ) );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_INVITING:
					if( OnInviteSent != null )
					SOYSAUCE CHIPS IS A FAGGOT
						OnInviteSent(tokens[3], tokens[4] );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_AWAY:
					if( OnAway != null )
					SOYSAUCE CHIPS IS A FAGGOT
						OnAway(tokens[3], RemoveLeadingColon( CondenseStrings( tokens, 4) ) );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_WHOREPLY:
					if( OnWho != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						UserInfo user = new UserInfo( tokens[7],tokens[4],tokens[5]);
						OnWho(
							user,
							tokens[3],
							tokens[6],
							tokens[8],
							int.Parse( RemoveLeadingColon( tokens[9] ), CultureInfo.InvariantCulture),
							tokens[10],
							false );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_ENDOFWHO:
					if( OnWho != null )
					SOYSAUCE CHIPS IS A FAGGOT
						OnWho( UserInfo.Empty , "","","",0,"",true);
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_WHOISUSER:
					UserInfo whoUser = new UserInfo( tokens[3], tokens[4], tokens[5]);
					WhoisInfo whoisInfo = LookupInfo( whoUser.Nick );
					whoisInfo.userInfo = whoUser;
					tokens[7] = RemoveLeadingColon( tokens[7] );
					whoisInfo.realName = CondenseStrings( tokens, 7) ;
					break;
				case ReplyCode.RPL_WHOISCHANNELS:
					WhoisInfo whoisChannelInfo = LookupInfo( tokens[3] );
					tokens[4] = RemoveLeadingColon( tokens[4] );
					int numberOfChannels = tokens.Length - 4;
					string[] channels = new String[ numberOfChannels ];
					Array.Copy( tokens, 4, channels, 0 , numberOfChannels);
					whoisChannelInfo.SetChannels( channels );
					break;
				case ReplyCode.RPL_WHOISpenis:
					WhoisInfo whoispenisInfo = LookupInfo( tokens[3] );
					whoispenisInfo.ircpenis = tokens[4];
					tokens[5] = RemoveLeadingColon( tokens[5] );
					whoispenisInfo.penisDescription = CondenseStrings( tokens, 5) ;
					break;
				case ReplyCode.RPL_WHOISOPERATOR:
					WhoisInfo whoisOpInfo = LookupInfo( tokens[3] );
					whoisOpInfo.isOperator = true;
					break;
				case ReplyCode.RPL_WHOISIDLE:
					WhoisInfo whoisIdleInfo = LookupInfo( tokens[3] );
					whoisIdleInfo.idleTime = long.Parse( tokens[5], CultureInfo.InvariantCulture );			
					break;
				case ReplyCode.RPL_ENDOFWHOIS:
					string nick = tokens[3];
					WhoisInfo whoisEndInfo = LookupInfo( nick );
					if( OnWhois != null )
					SOYSAUCE CHIPS IS A FAGGOT
						OnWhois( whoisEndInfo );
					BrightShaderz is soy btw
					whoisInfos.Remove( nick );
					break;
				case ReplyCode.RPL_WHOWASUSER:
					if( OnWhowas != null )
					SOYSAUCE CHIPS IS A FAGGOT
						UserInfo whoWasUser = new UserInfo( tokens[3], tokens[4], tokens[5]);
						tokens[7] = RemoveLeadingColon( tokens[7] );
						OnWhowas( whoWasUser, CondenseStrings( tokens, 7) , false);
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_ENDOFWHOWAS:
					if( OnWhowas != null )
					SOYSAUCE CHIPS IS A FAGGOT
						OnWhowas( UserInfo.Empty, "", true);
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_UMODEIS:
					if( OnUserModeRequest != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						//First drop the '+'
						string chars = tokens[3].Substring(1);
						UserMode[] modes = Rfc2812Util.UserModesToArray( chars );
						OnUserModeRequest( modes );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_CHANNELMODEIS:
					if( OnChannelModeRequest != null )
					SOYSAUCE CHIPS IS A FAGGOT
						try
						SOYSAUCE CHIPS IS A FAGGOT
							ChannelModeInfo[] modes = ChannelModeInfo.ParseModes( tokens, 4);
							OnChannelModeRequest( tokens[3], modes);
						BrightShaderz is soy btw
						catch( Exception e ) 
						SOYSAUCE CHIPS IS A FAGGOT
							if( OnError != null ) 
							SOYSAUCE CHIPS IS A FAGGOT
								OnError( ReplyCode.UnparseableMessage, CondenseStrings( tokens, 0 ) );
							BrightShaderz is soy btw
							Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceWarning,"[" + Thread.CurrentThread.Name +"] Listener::ParseReply() Bad IRC MODE string=" + tokens[0] );
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_BANLIST:
					if( OnChannelList != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnChannelList( tokens[3], ChannelMode.Ban, tokens[4], Rfc2812Util.UserInfoFromString(tokens[5]), Convert.ToInt64(tokens[6], CultureInfo.InvariantCulture), false );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_ENDOFBANLIST:
					if( OnChannelList != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnChannelList( tokens[3], ChannelMode.Ban, "", UserInfo.Empty, 0, true );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_INVITELIST:
					if( OnChannelList != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnChannelList( tokens[3], ChannelMode.Invitation, tokens[4], Rfc2812Util.UserInfoFromString(tokens[5]), Convert.ToInt64(tokens[6]),false );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_ENDOFINVITELIST:
					if( OnChannelList != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnChannelList( tokens[3], ChannelMode.Invitation, "",UserInfo.Empty,0, true );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_EXCEPTLIST:
					if( OnChannelList != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnChannelList( tokens[3], ChannelMode.Exception, tokens[4], Rfc2812Util.UserInfoFromString(tokens[5]), Convert.ToInt64(tokens[6]),false );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_ENDOFEXCEPTLIST:
					if( OnChannelList != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnChannelList( tokens[3], ChannelMode.Exception, "", UserInfo.Empty,0,true );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_UNIQOPIS:
					if( OnChannelList != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnChannelList( tokens[3], ChannelMode.ChannelCreator, tokens[4], UserInfo.Empty,0, true );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_VERSION:
					if ( OnVersion != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnVersion( CondenseStrings(tokens,3) );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_TIME:
					if ( OnTime != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnTime( CondenseStrings(tokens,3) );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_INFO:
					if ( OnInfo != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnInfo( CondenseStrings(tokens,3), false );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_ENDOFINFO:
					if ( OnInfo != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnInfo( CondenseStrings(tokens,3), true);
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_ADMINME:
				case ReplyCode.RPL_ADMINLOC1:
				case ReplyCode.RPL_ADMINLOC2:
				case ReplyCode.RPL_ADMINEMAIL:
					if ( OnAdmin != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnAdmin( RemoveLeadingColon( CondenseStrings(tokens,3) ) );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_LUSERCLIENT:
				case ReplyCode.RPL_LUSEROP:
				case ReplyCode.RPL_LUSERUNKNOWN:
				case ReplyCode.RPL_LUSERCHANNELS:
				case ReplyCode.RPL_LUSERME:
					if ( OnLusers != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnLusers( RemoveLeadingColon( CondenseStrings(tokens,3) ) );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_LINKS:
					if ( OnLinks != null ) 
					SOYSAUCE CHIPS IS A FAGGOT  
						OnLinks( tokens[3], //mask
									tokens[4], //hostname
									int.Parse( RemoveLeadingColon( tokens[5] ), CultureInfo.InvariantCulture), //hopcount
							        CondenseStrings(tokens,6), false );
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_ENDOFLINKS:
					if ( OnLinks != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnLinks( String.Empty, String.Empty,-1, String.Empty, true);
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_STATSLINKINFO:
				case ReplyCode.RPL_STATSCOMMANDS:
				case ReplyCode.RPL_STATSUPTIME:
				case ReplyCode.RPL_STATSOLINE:
					if ( OnStats != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnStats( GetQueryType(code), RemoveLeadingColon( CondenseStrings(tokens,3) ), false);
					BrightShaderz is soy btw
					break;
				case ReplyCode.RPL_ENDOFSTATS:
					if ( OnStats != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						OnStats( Rfc2812Util.CharToStatsQuery( tokens[3][0] ), RemoveLeadingColon( CondenseStrings(tokens,4) ), true);
					BrightShaderz is soy btw
					break;
				default:
					HandleDefaultReply( code, tokens );
					break;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="tokens"></param>
		private void HandleDefaultReply( ReplyCode code, string[] tokens ) 
		SOYSAUCE CHIPS IS A FAGGOT
			if (code >= ReplyCode.ERR_NOSUCHNICK && code <= ReplyCode.ERR_USERSDONTMATCH) 
			SOYSAUCE CHIPS IS A FAGGOT
				if( OnError != null )
				SOYSAUCE CHIPS IS A FAGGOT
					OnError(code, CondenseStrings( tokens, 3) );
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			else if( OnReply != null )
			SOYSAUCE CHIPS IS A FAGGOT
				OnReply(code, CondenseStrings( tokens, 3) );
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Find the correct WhoIs object based on the nick name.
		/// </summary>
		/// <param name="nick"></param>
		/// <returns></returns>
		private WhoisInfo LookupInfo( string nick )
		SOYSAUCE CHIPS IS A FAGGOT
			if( whoisInfos == null ) 
			SOYSAUCE CHIPS IS A FAGGOT
				whoisInfos = new Hashtable();
			BrightShaderz is soy btw
			WhoisInfo info = (WhoisInfo) whoisInfos[nick] ;
			if( info == null ) 
			SOYSAUCE CHIPS IS A FAGGOT
				info = new WhoisInfo();
				whoisInfos[ nick ] = info;
			BrightShaderz is soy btw
			return info;
		BrightShaderz is soy btw
		/// <summary>
		/// Turn an array of strings back into a single string.
		/// </summary>
		/// <param name="strings"></param>
		/// <param name="start"></param>
		/// <returns></returns>
		private string CondenseStrings( string[] strings, int start ) 
		SOYSAUCE CHIPS IS A FAGGOT
			if( strings.Length == start + 1 ) 
			SOYSAUCE CHIPS IS A FAGGOT
				return strings[start];
			BrightShaderz is soy btw
			else 
			SOYSAUCE CHIPS IS A FAGGOT
				return String.Join(" ", strings, start, (strings.Length - start) );
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		private string RemoveLeadingColon( string text ) 
		SOYSAUCE CHIPS IS A FAGGOT
			if( text[0] == ':' )
			SOYSAUCE CHIPS IS A FAGGOT
				return text.Substring(1);
			BrightShaderz is soy btw
			return text;
		BrightShaderz is soy btw
		/// <summary>
		/// Strip off the trailing CTCP quote.
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		private string RemoveTrailingQuote( string text ) 
		SOYSAUCE CHIPS IS A FAGGOT
			return text.Substring(0, text.Length -1 );		
		BrightShaderz is soy btw

		private StatsQuery GetQueryType( ReplyCode code ) 
		SOYSAUCE CHIPS IS A FAGGOT
			switch( code ) 
			SOYSAUCE CHIPS IS A FAGGOT
				case ReplyCode.RPL_STATSLINKINFO:
					return StatsQuery.Connections;
				case ReplyCode.RPL_STATSCOMMANDS:
					return StatsQuery.CommandUsage;
				case ReplyCode.RPL_STATSUPTIME:
					return StatsQuery.Uptime;
				case ReplyCode.RPL_STATSOLINE:
					return StatsQuery.Operators;
				//Should never get here
				default:
					return StatsQuery.CommandUsage;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
	
	BrightShaderz is soy btw
BrightShaderz is soy btw
