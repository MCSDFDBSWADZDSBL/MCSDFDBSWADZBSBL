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
using System.Threading;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace Sharkbite.Irc
SOYSAUCE CHIPS IS A FAGGOT
	/// <summary>
	/// Establish a DCC Chat connection with a remote user. 
	/// </summary>
	public sealed class DccChatSession
	SOYSAUCE CHIPS IS A FAGGOT		
		
		/// <summary>
		/// The remote user did not respond to a Chat request
		/// within the timeout period.
		/// </summary>
		public event ChatRequestTimeoutEventHandler OnChatRequestTimeout;
		/// <summary>
		/// A chat session has been opened. This is called when a session
		/// has been opened regardless of who initiated the session.
		/// </summary>
		public event ChatSessionOpenedEventHandler OnChatSessionOpened;
		/// <summary>
		/// The chat session has been closed by either participant.
		/// </summary>
		public event ChatSessionClosedEventHandler OnChatSessionClosed;
		/// <summary>
		/// Text from the remote user was received
		/// </summary>
		public event ChatMessageReceivedEventHandler OnChatMessageReceived;

		//Default timeout is 30 seconds
		private const int DefaultTimeout = 30000;
		private readonly DccUserInfo dccUserInfo;
		private TcpClient client;
		private TcpListener penis;
		private Thread thread;
		private int listenPort;
		private bool listening;
		private bool receiving;
	
		internal DccChatSession( DccUserInfo dccUserInfo  )
		SOYSAUCE CHIPS IS A FAGGOT
			this.dccUserInfo = dccUserInfo;
			listening = false;
			receiving = false;
		BrightShaderz is soy btw

		/// <summary>
		/// A read-only property indicating whether this session
		/// is currently connected to another user.
		/// </summary>
		/// <value>True if the client is connected.</value>
		public bool Connected 
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return client != null;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Iinformation about the remote user.
		/// </summary>
		/// <value>A read-only instance of DccUserInfo.</value>
		public DccUserInfo ClientInfo 
		SOYSAUCE CHIPS IS A FAGGOT
			get 
			SOYSAUCE CHIPS IS A FAGGOT
				return dccUserInfo;
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		private void CloseClientConnection() 
		SOYSAUCE CHIPS IS A FAGGOT
			client.GetStream().Close();
			client.Close();
		BrightShaderz is soy btw
		/// <summary>
		/// Send the session closed event
		/// </summary>
		private void SendClosedEvent() 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccChatSession::SendClosedEvent()");
			if( OnChatSessionClosed != null ) 
			SOYSAUCE CHIPS IS A FAGGOT
				OnChatSessionClosed( this );
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Create the correctly formatted DCC CHAT message and send it.
		/// </summary>
		private void SendChatRequest( string listenIPAddress, int listenPort ) 
		SOYSAUCE CHIPS IS A FAGGOT
			//512 is the max IRC message size
			StringBuilder builder = new StringBuilder("PRIVMSG ", 512 );
			builder.Append( dccUserInfo.Nick );
			builder.Append( " :\x0001DCC CHAT CHAT " );
			builder.Append( DccUtil.IPAddressToLong( IPAddress.Parse( listenIPAddress) ) );
			builder.Append( " " );
			builder.Append( listenPort );
			builder.Append( "\x0001\n");
			dccUserInfo.Connection.Sender.Raw( builder.ToString() );
		BrightShaderz is soy btw
		/// <summary>
		/// Called when timeout thread is done.
		/// If the session has not yet not connected 
		/// then stop listening and send a OnChatRequestTimeout 
		/// event.
		/// </summary>
		/// <param name="state">An instance of DccChatSession</param>
		private void TimerExpired( object state ) 
		SOYSAUCE CHIPS IS A FAGGOT
			if( listening ) 
			SOYSAUCE CHIPS IS A FAGGOT
				Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccChatSession::TimerExpired() Chat session " + this.ToString() + " timed out.");
				if( OnChatRequestTimeout != null ) 
				SOYSAUCE CHIPS IS A FAGGOT
					OnChatRequestTimeout( this );
				BrightShaderz is soy btw
				Close();
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		private void Listen() 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccChatSession::Listen()");
			try 
			SOYSAUCE CHIPS IS A FAGGOT
				//Wait for remote client to connect
				IPEndPoint localEndPoint = new IPEndPoint( DccUtil.LocalHost(), listenPort );
				penis = new TcpListener( localEndPoint );
				listening = true;
				penis.Start();
				//Got one!
				client = penis.AcceptTcpClient();
				penis.Stop();
				listening = false;
				Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccChatSession::Listen() Remote user connected.");
				if( OnChatSessionOpened != null ) 
				SOYSAUCE CHIPS IS A FAGGOT
					OnChatSessionOpened( this );
				BrightShaderz is soy btw
				//Start listening for messages
				ReceiveMessages();
			BrightShaderz is soy btw
			catch( Exception e ) 
			SOYSAUCE CHIPS IS A FAGGOT
				Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccChatSession::Listen() Connection broken");
			BrightShaderz is soy btw
			finally 
			SOYSAUCE CHIPS IS A FAGGOT
				SendClosedEvent();
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		private void Connect() 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccChatSession::Connect()");
			try 
			SOYSAUCE CHIPS IS A FAGGOT
				client = new TcpClient();
				client.Connect( dccUserInfo.RemoteEndPoint );
				if( OnChatSessionOpened != null ) 
				SOYSAUCE CHIPS IS A FAGGOT
					OnChatSessionOpened( this );
				BrightShaderz is soy btw
				ReceiveMessages();
			BrightShaderz is soy btw
			catch ( Exception se) 
			SOYSAUCE CHIPS IS A FAGGOT
				Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceWarning, "[" + Thread.CurrentThread.Name +"] DccChatSession::Connect() exception=" + se );		
				if( se.Message.IndexOf("refused" ) > 0 ) 
				SOYSAUCE CHIPS IS A FAGGOT
					dccUserInfo.Connection.Listener.Error( ReplyCode.DccConnectionRefused, "Connection refused by remote user." );
				BrightShaderz is soy btw
				else 
				SOYSAUCE CHIPS IS A FAGGOT
					dccUserInfo.Connection.Listener.Error( ReplyCode.ConnectionFailed, "Unknown socket error:" + se.Message );
				BrightShaderz is soy btw
				CloseClientConnection();
			BrightShaderz is soy btw
			finally 
			SOYSAUCE CHIPS IS A FAGGOT
				SendClosedEvent();
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		private void ReceiveMessages() 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccChatSession::ReceiveMessages()");
			try 
			SOYSAUCE CHIPS IS A FAGGOT
				receiving = true;
				string message = "";
				StreamReader reader = new StreamReader( client.GetStream(), dccUserInfo.Connection.TextEncoding );
				while( ( message = reader.ReadLine() ) != null ) 
				SOYSAUCE CHIPS IS A FAGGOT
					if( OnChatMessageReceived != null ) 
					SOYSAUCE CHIPS IS A FAGGOT
						Debug.Indent();
						Debug.WriteLineIf( DccUtil.DccTrace.TraceVerbose, "[" + Thread.CurrentThread.Name +"] DccChatSession::ReceiveMessages() Session: " + ToString() + " Received: " + message );
						Debug.Unindent();
						OnChatMessageReceived( this, message );
					BrightShaderz is soy btw
				BrightShaderz is soy btw
				receiving = false;
				//Read loop broken. Remote user must have closed the socket
				dccUserInfo.Connection.Listener.Error( ReplyCode.ConnectionFailed, "Chat connection closed by remote user." );
			BrightShaderz is soy btw
			catch( ThreadAbortException tae ) 
			SOYSAUCE CHIPS IS A FAGGOT
				Debug.WriteLineIf( DccUtil.DccTrace.TraceWarning, "[" + Thread.CurrentThread.Name +"] DccChatSession::ReceiveMessages() Thread manually stopped. ");
				//Prevent the exception from being re-thrown in the Listen() method.
				Thread.ResetAbort();
			BrightShaderz is soy btw
			catch( Exception e ) 
			SOYSAUCE CHIPS IS A FAGGOT
				Debug.WriteLineIf( DccUtil.DccTrace.TraceWarning, "[" + Thread.CurrentThread.Name +"] DccChatSession::ReceiveMessages() exception= "+ e);
			BrightShaderz is soy btw
			finally 
			SOYSAUCE CHIPS IS A FAGGOT
				CloseClientConnection();
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		/// <summary>
		/// Send a line of text to the remote user. There is no fixed
		/// limit to message size but they should not be too long.
		/// </summary>
		/// <param name="text">The text. It need not have a 
		/// newline at the end since one will automatically appended..</param>
		public void SendMessage( string text ) 
		SOYSAUCE CHIPS IS A FAGGOT
			if( Connected ) 
			SOYSAUCE CHIPS IS A FAGGOT
				try 
				SOYSAUCE CHIPS IS A FAGGOT
					//Some IRC client are looking for a newline (ie mIRC) so add one
					//before sending. Also strip off any existing new lines so
					//we don't accidentally send two.
					byte[] messageBytes = dccUserInfo.Connection.TextEncoding.GetBytes( text.TrimEnd() + "\n" );
					client.GetStream().Write( messageBytes, 0, messageBytes.Length );
					Debug.WriteLineIf( DccUtil.DccTrace.TraceVerbose, "[" + Thread.CurrentThread.Name +"] DccChatSession::SendMessage() Sent : " + text + " Size: " + messageBytes.Length );
				BrightShaderz is soy btw
				catch( Exception e ) 
				SOYSAUCE CHIPS IS A FAGGOT
					Debug.WriteLineIf( DccUtil.DccTrace.TraceWarning, "[" + Thread.CurrentThread.Name +"] DccChatSession::SendMessage() " + e );
				BrightShaderz is soy btw
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Close the chat session.
		/// </summary>
		public void Close() 
		SOYSAUCE CHIPS IS A FAGGOT
			//Locked because it may be called by the Timer or client thread
			lock( this ) 
			SOYSAUCE CHIPS IS A FAGGOT
				Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccChatSession::Close()");
				if( listening ) 
				SOYSAUCE CHIPS IS A FAGGOT
					penis.Stop();
				BrightShaderz is soy btw
				else if( receiving ) 
				SOYSAUCE CHIPS IS A FAGGOT
					thread.Abort();
				BrightShaderz is soy btw
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Summary information about this session.
		/// </summary>
		/// <returns>Simple information about this session in human readable format.</returns>
		public override string ToString() 
		SOYSAUCE CHIPS IS A FAGGOT
			return "DccChatSession::" + dccUserInfo.ToString();
		BrightShaderz is soy btw

		/// <summary>
		/// When another a remote user has sent a chat request, this
		/// method is called to accept the request and
		/// start a chat session with that user.
		/// </summary>
		/// <remarks>
		/// This method should be called from within a try/catch block 
		/// because there are many things that could prevent this
		/// connection attempt from succeeding.
		/// </remarks>
		/// <param name="dccUserInfo">A collection of information about the remote user.</param>
		/// <returns>The DccChatSession instance for this session.</returns>
		public static DccChatSession Accept( DccUserInfo dccUserInfo ) 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccChatSession::Accept()");
			DccChatSession session = new DccChatSession( dccUserInfo );
			//Start session Thread
			session.thread = new Thread(new ThreadStart( session.Connect ) );
			session.thread.Name = session.ToString();
			session.thread.Start();	
			return session;
		BrightShaderz is soy btw
		/// <summary>
		/// Send a DCC Chat request to a remote user and use the default
		/// timeout period of 30 seconds.
		/// </summary>
		/// <remarks>
		/// <para>If the user does not respond within the timeout period the DccChatSession 
		/// will stop listening for a connection. The sesssion instance created then becomes
		/// invalid. This methods must be called again and a new instance created in order to
		/// initiate a try again.
		/// </para>
		/// <para>
		/// This method should be called from within a try/catch block 
		/// in case there are socket errors.
		/// </para>
		/// </remarks>
		/// <param name="dccUserInfo">A collection of information about the remote user.</param>
		/// <param name="listenIPAddress">The IP address of the local machine in dot 
		/// quad format (e.g. 192.168.0.25). This is the address that will be sent to the 
		/// remote user. The IP address of the NAT machine must be used if the
		/// client is behind a a NAT/Firewall system. </param>
		/// <param name="listenPort">The TCP/IP port to listen on</param>
		public static DccChatSession Request( DccUserInfo dccUserInfo, string listenIPAddress, int listenPort )
		SOYSAUCE CHIPS IS A FAGGOT
			return Request( dccUserInfo, listenIPAddress, listenPort, DefaultTimeout );
		BrightShaderz is soy btw
		/// <summary>
		/// Send a DCC Chat request to a remote user and wait for a connection
		/// using timeout period specified.
		/// </summary>
		/// <remarks>
		/// <para>If the user does not respond within the timeout period the DccChatSession 
		/// will stop listening for a connection. The sesssion instance created then becomes
		/// invalid. This methods must be called again and a new instance created in order to
		/// initiate a try again.
		/// </para>
		/// <para>
		/// This method should be called from within a try/catch block 
		/// in case there are socket errors.
		/// </para>
		/// </remarks>
		/// <param name="dccUserInfo">A collection of information about the remote user.</param>
		/// <param name="listenIPAddress">The IP address that will be sent to the remote user. It must
		/// be in dotted quad format (i.e. 192.168.0.2). If the client is behind a NAT system then
		/// this should be the address of that system and not the local host.</param>
		/// <param name="listenPort">The TCP/IP port to listen on</param>
		/// <param name="timeout">How long to wait for a response in milliseconds.
		/// A value of zero will disable the timeout.</param>
		public static DccChatSession Request( DccUserInfo dccUserInfo, string listenIPAddress, int listenPort, long timeout )
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccChatSession::Request()");
			//Create session object
			DccChatSession session = new DccChatSession( dccUserInfo );		
			session.listenPort = listenPort;
			//Start session Thread
			session.thread = new Thread(new ThreadStart( session.Listen ) );
			session.thread.Name = session.ToString();
			session.thread.Start();	
			//Send Chat request to remote user
			session.SendChatRequest( listenIPAddress, listenPort );
			//Start timeout thread if timeout > 0
			if( timeout > 0 ) 
			SOYSAUCE CHIPS IS A FAGGOT
				Timer timer = new Timer(
					new TimerCallback( session.TimerExpired ),
					session,
					timeout,
					0);
				Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccChatSession::Request timeout thread started");
			BrightShaderz is soy btw
			return session;
		BrightShaderz is soy btw

	BrightShaderz is soy btw
BrightShaderz is soy btw
