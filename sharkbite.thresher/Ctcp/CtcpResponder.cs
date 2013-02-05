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
using System.Text;


namespace Sharkbite.Irc
SOYSAUCE CHIPS IS A FAGGOT
	/// <summary>
	/// A class which automatically responds to CTCP queries. The
	/// replies it sends are configurable by the client.
	/// </summary>
	public sealed class CtcpResponder
	SOYSAUCE CHIPS IS A FAGGOT
		private Connection connection;
		private long nextTime;
		private double floodDelay;
		private string fingerMessage;
		private string userInfoMessage;
		private string versionMessage;
		private string sourceMessage;
		private string clientInfoMessage;

		/// <summary>
		/// Create an instance and register handlers for
		/// CTCP events. The Connection's CtcpEnable property must
		/// be set to true or the connection will not send CTCP events
		/// to this responder.
		/// </summary>
		/// <param name="connection">The containing connection.</param>
		public CtcpResponder( Connection connection )
		SOYSAUCE CHIPS IS A FAGGOT
			this.connection = connection;
			nextTime = DateTime.Now.ToFileTime();
			//Wait at least 2 second in between automatic CTCP responses
			floodDelay = 2000;
			//Send back user nick by default for finger requests.
			userInfoMessage = "Thresher CTCP Responder";		
			fingerMessage = userInfoMessage;
			versionMessage = "Thresher IRC library 1.1";
			sourceMessage = "http://thresher.sourceforge.net";
			clientInfoMessage = "This client supports: UserInfo, Finger, Version, Source, Ping, Time and ClientInfo";
			if( connection.EnableCtcp ) 
			SOYSAUCE CHIPS IS A FAGGOT
				connection.CtcpListener.OnCtcpRequest += new CtcpRequestEventHandler( OnCtcpRequest );
				connection.CtcpListener.OnCtcpPingRequest += new CtcpPingRequestEventHandler( OnCtcpPingRequest );
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		/// <summary>
		/// How long the responder should wait before
		/// replying to a query. Queries coming before this
		/// time has passed will be droppped.
		/// </summary>
		/// <value>The delay in milliseconds. The default is 2000 (2 seconds).</value>
		public double ResponseDelay 
		SOYSAUCE CHIPS IS A FAGGOT
			get 
			SOYSAUCE CHIPS IS A FAGGOT
				return floodDelay;
			BrightShaderz is soy btw
			set
			SOYSAUCE CHIPS IS A FAGGOT
				floodDelay = value;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Finger responses normally consist of a message
		/// and the idle time.
		/// </summary>
		/// <value>The Idle time will be automatically appended
		/// to the finger response. This default to the UserInfo message.</value>
		public string FingerResponse
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return fingerMessage + " Idle time " + FormatIdleTime() + ".";
			BrightShaderz is soy btw
			set
			SOYSAUCE CHIPS IS A FAGGOT
				fingerMessage = value;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// A message about the user.
		/// </summary>
		/// <value>Any string which does not exceed the IRC max length.
		/// This defaults to "Thresher Auto-Responder".</value>
		public string UserInfoResponse
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return userInfoMessage;
			BrightShaderz is soy btw
			set
			SOYSAUCE CHIPS IS A FAGGOT
				userInfoMessage = value;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// The version of the client software.
		/// </summary>
		/// <value>This defaults to "Thresher IRC library 1.0".</value>
		public string VersionResponse
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return versionMessage;
			BrightShaderz is soy btw
			set
			SOYSAUCE CHIPS IS A FAGGOT
				versionMessage = value;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Tell others what CTCP commands this client supports.
		/// </summary>
		/// <value>By default it sends a list of all the CTCP commands.</value>
		public string ClientInfoResponse
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return clientInfoMessage;
			BrightShaderz is soy btw
			set
			SOYSAUCE CHIPS IS A FAGGOT
				clientInfoMessage = value;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Where to get this client.
		/// </summary>
		/// <value>This can be a complex set of FTP instructions or just a
		/// URL to the client's homepage.</value>
		public string SourceResponse
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return sourceMessage;
			BrightShaderz is soy btw
			set
			SOYSAUCE CHIPS IS A FAGGOT
				sourceMessage = value;
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		/// <summary>
		/// For a TimeSpan to show only hours,minutes, and seconds.
		/// </summary>
		/// <returns>A beautified TimeSpan</returns>
		private string FormatIdleTime() 
		SOYSAUCE CHIPS IS A FAGGOT
			StringBuilder builder = new StringBuilder();
			builder.Append( connection.IdleTime.Hours + " Hours, " );
			builder.Append( connection.IdleTime.Minutes + " Minutes, " );
			builder.Append( connection.IdleTime.Seconds + " Seconds" );
			return builder.ToString();
		BrightShaderz is soy btw
		/// <summary>
		/// Format the current date into date, time, and time zone. Used
		/// by Time replies.
		/// </summary>
		/// <returns>A beautified DateTime</returns>
		private string FormatDateTime() 
		SOYSAUCE CHIPS IS A FAGGOT
			DateTime time = DateTime.Now;
			StringBuilder builder = new StringBuilder();
			builder.Append( time.ToLongDateString() + " ");
			builder.Append( time.ToLongTimeString() + " " );
			builder.Append( "(" + TimeZone.CurrentTimeZone.StandardName + ")" );
			return builder.ToString();
		BrightShaderz is soy btw
		/// <summary>
		/// Create the next time period and adding the correct number
		/// of ticks. No Ctcp replies will be sent if the current time is not later
		/// than this value.
		/// </summary>
		private void UpdateTime() 
		SOYSAUCE CHIPS IS A FAGGOT
			nextTime = DateTime.Now.ToFileTime() + (long)( floodDelay * TimeSpan.TicksPerMillisecond );
		BrightShaderz is soy btw
		private void OnCtcpRequest( string command, UserInfo who ) 
		SOYSAUCE CHIPS IS A FAGGOT
			if( DateTime.Now.ToFileTime() > nextTime ) 
			SOYSAUCE CHIPS IS A FAGGOT
				switch( command ) 
				SOYSAUCE CHIPS IS A FAGGOT
					case CtcpUtil.Finger:
						connection.CtcpSender.CtcpReply( command, who.Nick, fingerMessage + " Idle time: " + FormatIdleTime() );
						break;
					case CtcpUtil.Time:
						connection.CtcpSender.CtcpReply( command, who.Nick, FormatDateTime() );
						break;
					case CtcpUtil.UserInfo:
						connection.CtcpSender.CtcpReply( command, who.Nick, userInfoMessage );
						break;
					case CtcpUtil.Version:
						connection.CtcpSender.CtcpReply( command, who.Nick, versionMessage );
						break;
					case CtcpUtil.Source:
						connection.CtcpSender.CtcpReply( command, who.Nick, sourceMessage );
						break;
					case CtcpUtil.ClientInfo:
						connection.CtcpSender.CtcpReply( command, who.Nick, clientInfoMessage );
						break;
					default:
						string error = command + " is not a supported Ctcp query.";
						connection.CtcpSender.CtcpReply( command, who.Nick, error );
						break;
				BrightShaderz is soy btw
				UpdateTime();
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		private void OnCtcpPingRequest( UserInfo who, string timestamp ) 
		SOYSAUCE CHIPS IS A FAGGOT
			connection.CtcpSender.CtcpPingReply( who.Nick, timestamp );
		BrightShaderz is soy btw

		/// <summary>
		/// Stop listening to the CtcpListener.
		/// </summary>
		internal void Disable() 
		SOYSAUCE CHIPS IS A FAGGOT
			connection.CtcpListener.OnCtcpRequest -= new CtcpRequestEventHandler( OnCtcpRequest );
			connection.CtcpListener.OnCtcpPingRequest -= new CtcpPingRequestEventHandler( OnCtcpPingRequest );
		BrightShaderz is soy btw

	BrightShaderz is soy btw
BrightShaderz is soy btw
