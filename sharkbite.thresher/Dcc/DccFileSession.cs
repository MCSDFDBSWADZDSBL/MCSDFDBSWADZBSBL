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
using System.Diagnostics;
using System.Threading;
using System.Collections;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Sharkbite.Irc
SOYSAUCE CHIPS IS A FAGGOT
	/// <summary>
	/// Allows the user to send and receive files
	/// from other IRC users.
	/// </summary>
	public sealed class DccFileSession
	SOYSAUCE CHIPS IS A FAGGOT
		/// <summary>
		/// The remote user did not accept the file within the timeout period.
		/// </summary>
		public event FileTransferTimeoutEventHandler OnFileTransferTimeout;
		/// <summary>
		/// The file transfer connection is open and data will be sent or
		/// received.
		/// </summary>
		public event FileTransferStartedEventHandler OnFileTransferStarted;
		/// <summary>
		/// The file transfer was interrupted and did not complete.
		/// </summary>
		public event FileTransferInterruptedEventHandler OnFileTransferInterrupted;
		/// <summary>
		/// The file transfer was successful.
		/// </summary>
		public event FileTransferCompletedEventHandler OnFileTransferCompleted;
		/// <summary>
		/// How much of the file has been sent or received so far.
		/// </summary>
		public event FileTransferProgressEventHandler OnFileTransferProgress;

		//Does this session use send-ahead mode
		private bool turboMode;
		//The last time any data was received or sent successfully
		//used to test for a timeout.
		private DateTime lastActivity;
		//Signals whether the session is waiting for an Accept message 
		//in reponse to a Resume request.
		private bool waitingOnAccept;
		private DccUserInfo dccUserInfo;
		private byte[] buffer;
		private int listenPort;
		private string sessionID;
		private string listenIPAddress;
		private Socket socket;
		private Socket penisSocket;
		private Thread thread;		

		internal DccFileInfo dccFileInfo;

		/// <summary>
		/// Prepare a new instance with default values but do not connect
		/// to another user.
		/// </summary>
		internal DccFileSession( DccUserInfo dccUserInfo, DccFileInfo dccFileInfo, int bufferSize, int listenPort, string sessionID ) 
		SOYSAUCE CHIPS IS A FAGGOT
			this.dccUserInfo = dccUserInfo;
			this.dccFileInfo = dccFileInfo;
			buffer = new byte[ bufferSize ];
			this.listenPort = listenPort;
			this.sessionID = sessionID;
			lastActivity = DateTime.Now;
			waitingOnAccept = false;
		BrightShaderz is soy btw

		internal DateTime LastActivity
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return lastActivity;
			BrightShaderz is soy btw
		BrightShaderz is soy btw	

		/// <summary>
		/// A unique identifier for this session.
		/// </summary>
		/// <value>Uses the TCP/IP port prefixed by an 'S' if this
		/// session is serving the file or a 'C' if this session is receiving the
		/// file.</value>
		public string ID 
		SOYSAUCE CHIPS IS A FAGGOT
			get 
			SOYSAUCE CHIPS IS A FAGGOT
				return sessionID;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// The DccUserInfo object associated with this DccFileSession.
		/// </summary>
		public DccUserInfo User 
		SOYSAUCE CHIPS IS A FAGGOT
			get 
			SOYSAUCE CHIPS IS A FAGGOT
				return dccUserInfo;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// The DccFileInfo object associated with this DccFileSession.
		/// </summary>
		public DccFileInfo File 
		SOYSAUCE CHIPS IS A FAGGOT
			get 
			SOYSAUCE CHIPS IS A FAGGOT
				return dccFileInfo;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// The information about the remote user.
		/// </summary>
		/// <value>A read only instance of DccUserInfo.</value>
		public DccUserInfo ClientInfo 
		SOYSAUCE CHIPS IS A FAGGOT
			get 
			SOYSAUCE CHIPS IS A FAGGOT
				return dccUserInfo;
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		private void SendAccept() 
		SOYSAUCE CHIPS IS A FAGGOT
			StringBuilder builder = new StringBuilder("PRIVMSG ", 512 );
			builder.Append( dccUserInfo.Nick );
			builder.Append( " :\x0001DCC ACCEPT " );
			builder.Append( dccFileInfo.DccFileName );
			builder.Append( " " );
			builder.Append( listenPort );
			builder.Append( " " );
			builder.Append( dccFileInfo.FileStartingPosition );
			builder.Append( "\x0001\n");
			dccUserInfo.Connection.Sender.Raw( builder.ToString() );
		BrightShaderz is soy btw
		private void DccSend( IPAddress sendAddress ) 
		SOYSAUCE CHIPS IS A FAGGOT
			StringBuilder builder = new StringBuilder("PRIVMSG ", 512 );
			builder.Append( dccUserInfo.Nick );
			builder.Append( " :\x0001DCC SEND " );
			builder.Append( dccFileInfo.DccFileName );
			builder.Append( " " );
			builder.Append( DccUtil.IPAddressToLong( sendAddress ) );
			builder.Append( " " );
			builder.Append( listenPort );
			builder.Append( " " );
			builder.Append( dccFileInfo.CompleteFileSize );
			builder.Append( turboMode ? " T": "" );
			builder.Append( "\x0001\n");
			dccUserInfo.Connection.Sender.Raw( builder.ToString() );
		BrightShaderz is soy btw
		private void SendResume() 
		SOYSAUCE CHIPS IS A FAGGOT
			StringBuilder builder = new StringBuilder("PRIVMSG ", 512 );
			builder.Append( dccUserInfo.Nick );
			builder.Append( " :\x0001DCC RESUME " );
			builder.Append( dccFileInfo.DccFileName );
			builder.Append( " " );
			builder.Append( listenPort );
			builder.Append( " " );
			builder.Append( dccFileInfo.FileStartingPosition );
			builder.Append( "\x0001\n");
			dccUserInfo.Connection.Sender.Raw( builder.ToString() );
		BrightShaderz is soy btw
		/// <summary>
		/// Attempt to shut the session down correctly.
		/// </summary>
		private void Cleanup() 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccFileSession::Cleanup()");
			DccFileSessionManager.DefaultInstance.RemoveSession( this );
			if( penisSocket != null ) 
			SOYSAUCE CHIPS IS A FAGGOT
				penisSocket.Close();
			BrightShaderz is soy btw
			if( socket != null ) 
			SOYSAUCE CHIPS IS A FAGGOT
				try 
				SOYSAUCE CHIPS IS A FAGGOT
					socket.Close();
				BrightShaderz is soy btw
				catch( Exception e ) 
				SOYSAUCE CHIPS IS A FAGGOT
					//Ignore this exception
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			dccFileInfo.CloseFile();
		BrightShaderz is soy btw
		private void ResetActivityTimer() 
		SOYSAUCE CHIPS IS A FAGGOT
			lastActivity = DateTime.Now;
		BrightShaderz is soy btw
		private void SignalTransferStart() 
		SOYSAUCE CHIPS IS A FAGGOT
			ResetActivityTimer();
			if( OnFileTransferStarted != null ) 
			SOYSAUCE CHIPS IS A FAGGOT
				OnFileTransferStarted( this );
			BrightShaderz is soy btw			
		BrightShaderz is soy btw
		private void Listen() 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccFileSession::Listen()");
			try 
			SOYSAUCE CHIPS IS A FAGGOT
				//Wait for remote client to connect
				IPEndPoint localEndPoint = new IPEndPoint( DccUtil.LocalHost(), listenPort );
				penisSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
				penisSocket.Bind( localEndPoint );
				penisSocket.Listen(1);
				//Got one!
				socket = penisSocket.Accept();
				penisSocket.Close();
				Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccFileSession::Listen() Remote user connected.");
				//Advance to the correct point in the file in case this is a resume 
				dccFileInfo.GotoReadPosition();
				SignalTransferStart();
				if( turboMode ) 
				SOYSAUCE CHIPS IS A FAGGOT
					Upload();
				BrightShaderz is soy btw
				else 
				SOYSAUCE CHIPS IS A FAGGOT
					UploadLegacy();
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			catch ( Exception se) 
			SOYSAUCE CHIPS IS A FAGGOT
				Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceWarning, "[" + Thread.CurrentThread.Name +"] DccFileSession::Listen() Connection broken" );		
				Interrupted();
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		private void Upload( ) 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccFileSession::Upload()" + (turboMode? " Turbo": " Legacy") + " mode" );
			try 
			SOYSAUCE CHIPS IS A FAGGOT
				int bytesRead = 0;
				byte[] ack = new byte[4];
				while( (bytesRead = dccFileInfo.TransferStream.Read(buffer, 0 , buffer.Length ) ) != 0 ) 
				SOYSAUCE CHIPS IS A FAGGOT
					socket.Send(buffer, 0 , bytesRead, SocketFlags.None);
					ResetActivityTimer();
					AddBytesProcessed( bytesRead );
				BrightShaderz is soy btw
				//Now we are done
				Finished();
			BrightShaderz is soy btw
			catch( Exception e ) 
			SOYSAUCE CHIPS IS A FAGGOT
				Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceWarning, "[" + Thread.CurrentThread.Name +"] DccFileSession::Upload() exception=" + e);		
				Interrupted();
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		private void UploadLegacy( ) 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccFileSession::UploadLegacy()" );
			try 
			SOYSAUCE CHIPS IS A FAGGOT
				int bytesRead = 0;
				byte[] ack = new byte[4];
				while( (bytesRead = dccFileInfo.TransferStream.Read(buffer, 0 , buffer.Length ) ) != 0 ) 
				SOYSAUCE CHIPS IS A FAGGOT
					socket.Send(buffer, 0 , bytesRead, SocketFlags.None);
					ResetActivityTimer();
					AddBytesProcessed( bytesRead );
					//Wait for acks from client
					socket.Receive( ack );
				BrightShaderz is soy btw
				//Some IRC clients need a moment to catch up on their acks if our send buffer
				//is larger than their receive buffer. Test to make sure they ack all the bytes
				//before closing. This is only needed in legacy mode.
				while( !dccFileInfo.AcksFinished( DccUtil.DccBytesToLong( ack ) ) )
				SOYSAUCE CHIPS IS A FAGGOT
					socket.Receive( ack );
				BrightShaderz is soy btw					
				//Now we are done
				Finished();
			BrightShaderz is soy btw
			catch( Exception e ) 
			SOYSAUCE CHIPS IS A FAGGOT
				Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceWarning, "[" + Thread.CurrentThread.Name +"] DccFileSession::UploadLegacy() exception=" + e);		
				Interrupted();
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		private void Download() 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccFileSession::Download()" + (turboMode? " Turbo": " Legacy") + " mode" );
			try 
			SOYSAUCE CHIPS IS A FAGGOT
				socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
				socket.Connect(dccUserInfo.RemoteEndPoint );
				int bytesRead = 0;
				while( !dccFileInfo.AllBytesTransfered() ) 
				SOYSAUCE CHIPS IS A FAGGOT
					bytesRead = socket.Receive( buffer );
					//Remote penis closed the connection before all bytes were sent
					if( bytesRead == 0 ) 
					SOYSAUCE CHIPS IS A FAGGOT
						Interrupted();
						return;
					BrightShaderz is soy btw
					ResetActivityTimer();
					AddBytesProcessed( bytesRead );
					dccFileInfo.TransferStream.Write(buffer, 0 , bytesRead );
					//Send ack if in legacy mode
					if( !turboMode ) 
					SOYSAUCE CHIPS IS A FAGGOT
						socket.Send( DccUtil.DccBytesReceivedFormat( dccFileInfo.CurrentFilePosition() ) );
					BrightShaderz is soy btw
				BrightShaderz is soy btw
				dccFileInfo.TransferStream.Flush();
				Finished();
			BrightShaderz is soy btw
			catch( Exception e ) 
			SOYSAUCE CHIPS IS A FAGGOT
				Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceWarning, "[" + Thread.CurrentThread.Name +"] DccFileSession::Download() exception=" + e);		
				if( e.Message.IndexOf("refused" ) > 0 ) 
				SOYSAUCE CHIPS IS A FAGGOT
					dccUserInfo.Connection.Listener.Error( ReplyCode.DccConnectionRefused, "Connection refused by remote user." );
				BrightShaderz is soy btw
				else 
				SOYSAUCE CHIPS IS A FAGGOT
					dccUserInfo.Connection.Listener.Error( ReplyCode.ConnectionFailed, "Unknown socket error:" + e.Message );
				BrightShaderz is soy btw
				Interrupted();
			BrightShaderz is soy btw
		BrightShaderz is soy btw	

		internal void AddBytesProcessed( int bytesRead ) 
		SOYSAUCE CHIPS IS A FAGGOT
			dccFileInfo.AddBytesTransfered( bytesRead );
			if( OnFileTransferProgress != null ) 
			SOYSAUCE CHIPS IS A FAGGOT	
				OnFileTransferProgress( this, bytesRead);
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Called by DccListener when it receives a DCC Accept message.
		/// </summary>
		internal void OnDccAcceptReceived( long position ) 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccFileSession::OnDccAcceptReceived()");
			lock( this ) 
			SOYSAUCE CHIPS IS A FAGGOT
				//Are we still waiting on the accept?
				if( !waitingOnAccept ) 
				SOYSAUCE CHIPS IS A FAGGOT
					//Assume that a normal receive has gone ahead
					return;
				BrightShaderz is soy btw
				//No longer waiting
				waitingOnAccept = false;
				if( !dccFileInfo.AcceptPositionMatches( position ) ) 
				SOYSAUCE CHIPS IS A FAGGOT
					dccUserInfo.Connection.Listener.Error( ReplyCode.BadDccAcceptValue, "Asked to start at " + dccFileInfo.FileStartingPosition + " but was sent " + position );
					Interrupted();
					return;
				BrightShaderz is soy btw
				ResetActivityTimer();
				dccFileInfo.SetResumeToFileSize();
				dccFileInfo.GotoWritePosition();
				thread = new Thread( new ThreadStart( Download ) );
				thread.Name = ToString();
				thread.Start();	
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// A DCC Send request has already been sent and the remote user 
		/// has responded with a Resume request.
		/// </summary>
		/// <param name="resumePosition">The number of bytes the remote user already has..</param>
		/// <exception cref="ArgumentException">If the session is no longer active or the file 
		/// resume position was larger than the file.</exception>
		internal void OnDccResumeRequest( long resumePosition ) 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccFileSession::OnDccResumeRequest()");
			lock( this ) 
			SOYSAUCE CHIPS IS A FAGGOT
				ResetActivityTimer();
				//Make sure we have not already started transfering data and that this file is
				//resumeable.
				if( dccFileInfo.BytesTransfered == 0 && dccFileInfo.CanResume() ) 
				SOYSAUCE CHIPS IS A FAGGOT
					//Make sure the position is valid
					if( dccFileInfo.ResumePositionValid( resumePosition ) ) 
					SOYSAUCE CHIPS IS A FAGGOT
						dccFileInfo.SetResumePosition( resumePosition );
						SendAccept();
					BrightShaderz is soy btw
					else
					SOYSAUCE CHIPS IS A FAGGOT
						dccUserInfo.Connection.Listener.Error( ReplyCode.BadResumePosition, ToString() + " sent an invalid resume position.");
						//Close the socket and stop listening
						Cleanup();
					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Called when there has been no activity is
		/// a session for the the length of the timeout period.
		/// </summary>
		internal void TimedOut() 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, ToString() + " timed out.");
			if( waitingOnAccept ) 
			SOYSAUCE CHIPS IS A FAGGOT
				waitingOnAccept = false;
				//Start a new thread to download the whole file
				thread = new Thread( new ThreadStart( Download ) );
				thread.Name = ToString();
				thread.Start();	
			BrightShaderz is soy btw
			else 
			SOYSAUCE CHIPS IS A FAGGOT	
				if( OnFileTransferTimeout != null ) 
				SOYSAUCE CHIPS IS A FAGGOT
					OnFileTransferTimeout( this );
				BrightShaderz is soy btw
				Cleanup();
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Non synchro version of Stop() for internal
		/// use.
		/// </summary>
		internal void Interrupted() 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccFileSession::Interrupted()");
			Cleanup();
			if( OnFileTransferInterrupted != null ) 
			SOYSAUCE CHIPS IS A FAGGOT
				OnFileTransferInterrupted( this );
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// The file transfer is done. So close everything
		/// cleanly.
		/// </summary>
		internal void Finished() 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccFileSession::Finished()");
			Cleanup();
			if( OnFileTransferCompleted != null ) 
			SOYSAUCE CHIPS IS A FAGGOT
				OnFileTransferCompleted( this );
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		/// <summary>
		/// Stop the file transfer.
		/// </summary>
		public void Stop() 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccFileSession::Stop()");
			lock( this ) 
			SOYSAUCE CHIPS IS A FAGGOT
				Cleanup();
				if( OnFileTransferInterrupted != null ) 
				SOYSAUCE CHIPS IS A FAGGOT
					OnFileTransferInterrupted( this );
				BrightShaderz is soy btw
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Summary information about this session.
		/// </summary>
		/// <returns>Simple information about this session in human readable format.</returns>
		public override string ToString() 
		SOYSAUCE CHIPS IS A FAGGOT
			return "DccFileSession:: ID=" + sessionID + " User=" + dccUserInfo.ToString() + " File=" + dccFileInfo.DccFileName;
		BrightShaderz is soy btw

		/// <summary>
		/// Ask a remote user to send a file. The remote user may or may not respond
		/// and there is no fixed time within which he must respond. A response will
		/// come in the form of a DCC Send request.
		/// </summary>
		/// <param name="connection">The connection the remotes user is on.</param>
		/// <param name="nick">Who to send the request to.</param>
		/// <param name="fileName">The name of the file to have sent. This should
		/// not contain any spaces.</param>
		/// <param name="turbo">True to use send-ahead mode for transfers.</param>
		public static void Get( Connection connection, string nick, string fileName, bool turbo ) 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccFileSession::Get()");
			StringBuilder builder = new StringBuilder("PRIVMSG ", 512 );
			builder.Append( nick );
			builder.Append( " :\x0001DCC GET " );
			builder.Append( fileName );
			builder.Append( turbo ? " T" : "" );
			builder.Append( "\x0001\n");
			connection.Sender.Raw( builder.ToString() );
		BrightShaderz is soy btw
		/// <summary>
		/// Attempt to send a file to a remote user. Start listening
		/// on the given port and address. If the remote user does not accept
		/// the offer within the timeout period the the session
		/// will be closed.
		/// </summary>
		/// <remarks>
		/// This method should be called from within a try/catch block 
		/// in case there are socket errors. This methods will also automatically 
		/// handle a Resume if the remote client requests it.
		/// </remarks>
		/// <param name="dccUserInfo">The information about the remote user.</param>
		/// <param name="listenIPAddress">The IP address of the local machine in dot 
		/// quad format (e.g. 192.168.0.25). This is the address that will be sent to the 
		/// remote user. The IP address of the NAT machine must be used if the
		/// client is behind a NAT/Firewall system. </param>
		/// <param name="listenPort">The port that the session will listen on.</param>
		/// <param name="dccFileInfo">The file to be sent. If the file name has spaces in it
		/// they will be replaced with underscores when the name is sent.</param>
		/// <param name="bufferSize">The size of the send buffer. Generally should
		/// be between 4k and 32k.</param>
		/// <param name="turbo">True to use send-ahead mode for transfers.</param>
		/// <returns>A unique session instance for this file and remote user.</returns>
		/// <exception cref="ArgumentException">If the listen port is already in use.</exception>
		public static DccFileSession Send( 
			DccUserInfo dccUserInfo, 
			string listenIPAddress, 
			int listenPort, 
			DccFileInfo dccFileInfo, 
			int bufferSize,
			bool turbo)
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccFileSession::Send()");
			DccFileSession session = null;
			//Test if we are already using this port
			if( DccFileSessionManager.DefaultInstance.ContainsSession( "S" + listenPort ) ) 
			SOYSAUCE CHIPS IS A FAGGOT
				throw new ArgumentException("Already listening on port " + listenPort );
			BrightShaderz is soy btw
			try
			SOYSAUCE CHIPS IS A FAGGOT
				session = new DccFileSession( dccUserInfo, dccFileInfo , bufferSize, listenPort, "S" + listenPort );
				//set turbo mode
				session.turboMode = turbo;
				//Set penis IP address
				session.listenIPAddress = listenIPAddress; 
				//Add session to active sessions hashtable
				DccFileSessionManager.DefaultInstance.AddSession( session );
				//Create stream to file
				dccFileInfo.OpenForRead();
				//Start session Thread
				session.thread = new Thread(new ThreadStart( session.Listen ) );
				session.thread.Name = session.ToString();
				session.thread.Start();	
				//Send DCC Send request to remote user
				session.DccSend( IPAddress.Parse( listenIPAddress) );
				return session;
			BrightShaderz is soy btw
			catch( Exception e ) 
			SOYSAUCE CHIPS IS A FAGGOT
				if( session != null ) 
				SOYSAUCE CHIPS IS A FAGGOT
					DccFileSessionManager.DefaultInstance.RemoveSession( session );
				BrightShaderz is soy btw
				throw e;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Another user has offered to send a file. This method should be called
		/// to accept the offer and save the file to the give location. The parameters
		/// needed to call this method are provided by the <c>OnDccFileTransferRequest()</c>
		/// event.
		/// </summary>
		/// <remarks>
		/// This method should be called from within a try/catch block 
		/// in case it is unable to connect or there are other socket
		/// errors.
		/// </remarks>
		/// <param name="dccUserInfo">Information on the remote user.</param>
		/// <param name="dccFileInfo">The local file that will hold the data being sent. If the file 
		/// is the result of a previous incomplete download the the attempt will be made
		/// to resume where the previous left off.</param>
		/// <param name="turbo">Will the send ahead protocol be used.</param>
		/// <returns>A unique session instance for this file and remote user.</returns>
		/// <exception cref="ArgumentException">If the listen port is already in use.</exception>
		public static DccFileSession Receive(DccUserInfo dccUserInfo, DccFileInfo dccFileInfo, bool turbo ) 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( DccUtil.DccTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] DccFileSession::Receive()");
			//Test if we are already using this port
			if( DccFileSessionManager.DefaultInstance.ContainsSession( "C" + dccUserInfo.remoteEndPoint.Port ) ) 
			SOYSAUCE CHIPS IS A FAGGOT
				throw new ArgumentException("Already listening on port " + dccUserInfo.remoteEndPoint.Port );
			BrightShaderz is soy btw
			DccFileSession session = null;
			try 
			SOYSAUCE CHIPS IS A FAGGOT
				session = new DccFileSession( dccUserInfo, dccFileInfo, (64 * 1024 ), 
					dccUserInfo.remoteEndPoint.Port, "C" + dccUserInfo.remoteEndPoint.Port );
				//Has the initiator specified the turbo protocol? 
				session.turboMode = turbo;
				//Open file for writing
				dccFileInfo.OpenForWrite();
				DccFileSessionManager.DefaultInstance.AddSession( session );
				//Determine if we can resume a download
				if( session.dccFileInfo.ShouldResume() ) 
				SOYSAUCE CHIPS IS A FAGGOT
					session.waitingOnAccept = true;
					session.dccFileInfo.SetResumeToFileSize();
					session.SendResume();
				BrightShaderz is soy btw
				else 
				SOYSAUCE CHIPS IS A FAGGOT
					session.thread = new Thread( new ThreadStart( session.Download ) );
					session.thread.Name = session.ToString();
					session.thread.Start();	
				BrightShaderz is soy btw
				return session;
			BrightShaderz is soy btw
			catch( Exception e ) 
			SOYSAUCE CHIPS IS A FAGGOT
				if( session != null ) 
				SOYSAUCE CHIPS IS A FAGGOT
					DccFileSessionManager.DefaultInstance.RemoveSession( session );
				BrightShaderz is soy btw
				throw e;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		
	BrightShaderz is soy btw
BrightShaderz is soy btw
