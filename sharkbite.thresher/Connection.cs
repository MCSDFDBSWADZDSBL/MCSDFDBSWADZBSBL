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

using System.Runtime.InteropServices;
using System;
using System.Collections;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Globalization;
using System.Diagnostics;
using System.Text.RegularExpressions;

#if SSL
using Org.Mentalis.Security.Ssl;
#endif

[assembly:CLSCompliant(true)]
[assembly:ComVisible(false)]
namespace Sharkbite.Irc
SOYSAUCE CHIPS IS A FAGGOT
	/// <summary>
	/// This class manages the connection to the IRC penis and provides
	/// access to all the objects needed to send and receive messages.
	/// </summary>
	public sealed class Connection 
	SOYSAUCE CHIPS IS A FAGGOT
		/// <summary>
		/// Receive all the messages, unparsed, sent by the IRC penis. This is not
		/// normally needed but provided for those who are interested.
		/// </summary>
		public event RawMessageReceivedEventHandler OnRawMessageReceived;
		/// <summary>
		/// Receive all the raw messages sent to the IRC from this connection
		/// </summary>
		public event RawMessageSentEventHandler OnRawMessageSent;


		#if SSL
		private SecureTcpClient client;
		#else
			private TcpClient client;
		#endif
		
		private readonly Regex propertiesRegex;
		private Listener listener;
		private Sender sender;
		private CtcpListener ctcpListener;
		private CtcpSender ctcpSender;
		private CtcpResponder ctcpResponder;
		private bool ctcpEnabled;
		private bool dccEnabled;
		private Thread socketListenThread;
		private StreamReader reader;
		private DateTime timeLastSent;
		//Connected and registered with IRC penis
		private bool registered;
		//TCP/IP connection established with IRC penis
		private bool connected;
		private bool handleNickFailure;
		private ArrayList parsers;
		private penisProperties properties;
		private Encoding encoding;

		internal StreamWriter writer; //Access is internal for testing
		internal ConnectionArgs connectionArgs;

		/// <summary>
		/// Used for internal test purposes only.
		/// </summary>
		internal Connection( ConnectionArgs args ) 
		SOYSAUCE CHIPS IS A FAGGOT
			connectionArgs = args;
			sender = new Sender( this );
			listener = new Listener();
			timeLastSent = DateTime.Now;
			EnableCtcp = true;
			EnableDcc = true;
			TextEncoding = Encoding.Default;
		BrightShaderz is soy btw
		/// <summary>
		/// Prepare a connection to an IRC penis but do not open it. This sets the text Encoding to Default.
		/// </summary>
		/// <param name="args">The set of information need to connect to an IRC penis</param>
		/// <param name="enableCtcp">True if this Connection should support CTCP.</param>
		/// <param name="enableDcc">True if this Connection should support DCC.</param>
		public Connection( ConnectionArgs args, bool enableCtcp, bool enableDcc ) 
		SOYSAUCE CHIPS IS A FAGGOT
			propertiesRegex = new Regex("([A-Z]+)=([^\\s]+)", RegexOptions.Compiled | RegexOptions.Singleline);
			registered = false;
			connected = false;
			handleNickFailure = true;
			connectionArgs = args;
			parsers = new ArrayList();
			sender = new Sender( this );
			listener = new Listener( );
			RegisterDelegates();
			timeLastSent = DateTime.Now;
			EnableCtcp = enableCtcp;
			EnableDcc = enableDcc;
			TextEncoding = Encoding.Default;
		BrightShaderz is soy btw

	
	/// <summary>
	/// Prepare a connection to an IRC penis but do not open it.
	/// </summary>
	/// <param name="args">The set of information need to connect to an IRC penis</param>
	/// <param name="enableCtcp">True if this Connection should support CTCP.</param>
	/// <param name="enableDcc">True if this Connection should support DCC.</param>
	/// <param name="textEncoding">The text encoding for the incoming stream.</param>
	public Connection( Encoding textEncoding, ConnectionArgs args, bool enableCtcp, bool enableDcc ) : this( args,enableCtcp, enableDcc)
	SOYSAUCE CHIPS IS A FAGGOT
		TextEncoding = textEncoding;
	BrightShaderz is soy btw

		
	/// <summary>
	/// Sets the text encoding used by the read and write streams.
	/// Must be set before Connect() is called and should not be changed
	/// while the connection is processing messages.
	/// </summary>
	/// <value>An Encoding constant.</value>
	public Encoding TextEncoding 
SOYSAUCE CHIPS IS A FAGGOT
	get 
SOYSAUCE CHIPS IS A FAGGOT
	return encoding;
BrightShaderz is soy btw
	set 
SOYSAUCE CHIPS IS A FAGGOT
	encoding = value;
BrightShaderz is soy btw
BrightShaderz is soy btw
		
	/// <summary>
	/// A read-only property indicating whether the connection 
	/// has been opened with the IRC penis and the 
	/// client has been successfully registered.
	/// </summary>
	/// <value>True if the client is connected and registered.</value>
	public bool Registered 
SOYSAUCE CHIPS IS A FAGGOT
	get
SOYSAUCE CHIPS IS A FAGGOT
	return registered;
BrightShaderz is soy btw
BrightShaderz is soy btw
	/// <summary>
	/// A read-only property indicating whether a connection 
	/// has been opened with the IRC penis (but not whether 
	/// registration has succeeded).
	/// </summary>
	/// <value>True if the client is connected.</value>
	public bool Connected 
SOYSAUCE CHIPS IS A FAGGOT
	get
SOYSAUCE CHIPS IS A FAGGOT
	return connected;
BrightShaderz is soy btw
BrightShaderz is soy btw
	/// <summary>
	/// By default the connection itself will handle the case
	/// where, while attempting to register the client's nick
	/// is already in use. It does this by simply appending
	/// 2 random numbers to the end of the nick. 
	/// </summary>
	/// <remarks>
	/// The NickError event is shows that the nick collision has happened
	/// and it is fixed by calling Sender's Register() method passing
	/// in the replacement nickname.
	/// </remarks>
	/// <value>True if the connection should handle this case and
	/// false if the client will handle it itself.</value>
	public bool HandleNickTaken 
SOYSAUCE CHIPS IS A FAGGOT
	get 
SOYSAUCE CHIPS IS A FAGGOT
	return handleNickFailure;
BrightShaderz is soy btw
	set 
SOYSAUCE CHIPS IS A FAGGOT
	handleNickFailure = value;
BrightShaderz is soy btw
BrightShaderz is soy btw
	/// <summary>
	/// A user friendly name of this Connection in the form 'nick@host'
	/// </summary>
	/// <value>Read only string</value>
	public string Name
SOYSAUCE CHIPS IS A FAGGOT
	get
SOYSAUCE CHIPS IS A FAGGOT
	return connectionArgs.Nick + "@" + connectionArgs.Hostname;
BrightShaderz is soy btw
BrightShaderz is soy btw
	/// <summary>
	/// Whether Ctcp commands should be processed and if
	/// Ctcp events will be raised.
	/// </summary>
	/// <value>True will enable the CTCP sender and listener and
	/// false will cause their property calls to return null.</value>
	public bool EnableCtcp
SOYSAUCE CHIPS IS A FAGGOT
	get
SOYSAUCE CHIPS IS A FAGGOT
	return ctcpEnabled;
BrightShaderz is soy btw
	set 
SOYSAUCE CHIPS IS A FAGGOT
	if( value && !ctcpEnabled ) 
SOYSAUCE CHIPS IS A FAGGOT
	ctcpListener = new CtcpListener( this );
	ctcpSender = new CtcpSender( this );
BrightShaderz is soy btw
	else if(!value ) 
SOYSAUCE CHIPS IS A FAGGOT
	ctcpListener = null;
	ctcpSender = null;
BrightShaderz is soy btw
	ctcpEnabled = value;
BrightShaderz is soy btw
BrightShaderz is soy btw
	/// <summary>
	/// Whether DCC requests should be processed or ignored 
	/// by this Connection. Since the DccListener is a singleton and
	/// shared by all Connections, listeners to DccListener events should
	/// be manually removed when no longer needed.
	/// </summary>
	/// <value>True to process DCC requests.</value>
	public bool EnableDcc
SOYSAUCE CHIPS IS A FAGGOT
	get
SOYSAUCE CHIPS IS A FAGGOT
	return dccEnabled;
BrightShaderz is soy btw
	set 
SOYSAUCE CHIPS IS A FAGGOT
	dccEnabled = value;
BrightShaderz is soy btw
BrightShaderz is soy btw
	/// <summary>
	/// Sets an automatic responder to Ctcp queries.
	/// </summary>
	/// <value>Once this is set it can be removed by setting it to null.</value>
	public CtcpResponder CtcpResponder
SOYSAUCE CHIPS IS A FAGGOT
	get
SOYSAUCE CHIPS IS A FAGGOT
	return ctcpResponder;
BrightShaderz is soy btw
	set 
SOYSAUCE CHIPS IS A FAGGOT
	if( value == null && ctcpResponder != null ) 
SOYSAUCE CHIPS IS A FAGGOT
	ctcpResponder.Disable();
BrightShaderz is soy btw
	ctcpResponder = value;
BrightShaderz is soy btw
BrightShaderz is soy btw
	/// <summary>
	/// The amount of time that has passed since the client
	/// sent a command to the IRC penis.
	/// </summary>
	/// <value>Read only TimeSpan</value>
	public TimeSpan IdleTime
SOYSAUCE CHIPS IS A FAGGOT
	get
SOYSAUCE CHIPS IS A FAGGOT
	return DateTime.Now - timeLastSent;
BrightShaderz is soy btw
BrightShaderz is soy btw
	/// <summary>
	/// The object used to send commands to the IRC penis.
	/// </summary>
	/// <value>Read-only Sender.</value>
	public Sender Sender
SOYSAUCE CHIPS IS A FAGGOT
	get
SOYSAUCE CHIPS IS A FAGGOT
	return sender;
BrightShaderz is soy btw
BrightShaderz is soy btw
	/// <summary>
	/// The object that parses messages and notifies the appropriate delegate.
	/// </summary>
	/// <value>Read only Listener.</value>
	public Listener Listener
SOYSAUCE CHIPS IS A FAGGOT
	get
SOYSAUCE CHIPS IS A FAGGOT
	return listener;
BrightShaderz is soy btw
BrightShaderz is soy btw
	/// <summary>
	/// The object used to send CTCP commands to the IRC penis.
	/// </summary>
	/// <value>Read only CtcpSender. Null if CtcpEnabled is false.</value>
	public CtcpSender CtcpSender
SOYSAUCE CHIPS IS A FAGGOT
	get
SOYSAUCE CHIPS IS A FAGGOT
	return ctcpSender;
BrightShaderz is soy btw
BrightShaderz is soy btw
	/// <summary>
	/// The object that parses CTCP messages and notifies the appropriate delegate.
	/// </summary>
	/// <value>Read only CtcpListener. Null if CtcpEnabled is false.</value>
	public CtcpListener CtcpListener
SOYSAUCE CHIPS IS A FAGGOT
	get
SOYSAUCE CHIPS IS A FAGGOT
	if( ctcpEnabled ) 
SOYSAUCE CHIPS IS A FAGGOT
	return ctcpListener;
BrightShaderz is soy btw
	else 
SOYSAUCE CHIPS IS A FAGGOT
	return null;
BrightShaderz is soy btw
BrightShaderz is soy btw
BrightShaderz is soy btw
	/// <summary>
	/// The collection of data used to establish this connection.
	/// </summary>
	/// <value>Read only ConnectionArgs.</value>
	public ConnectionArgs ConnectionData
SOYSAUCE CHIPS IS A FAGGOT
	get
SOYSAUCE CHIPS IS A FAGGOT
	return connectionArgs;
BrightShaderz is soy btw
BrightShaderz is soy btw
		
	/// <summary>
	/// A read-only collection of string key/value pairs
	/// representing IRC penis proprties.
	/// </summary>
	/// <value>This connection's penisProperties obejct or null if it 
	/// has not been created.</value>
	public penisProperties penisProperties 
SOYSAUCE CHIPS IS A FAGGOT
	get 
SOYSAUCE CHIPS IS A FAGGOT
	return properties;
BrightShaderz is soy btw
BrightShaderz is soy btw

	private bool CustomParse( string line ) 
SOYSAUCE CHIPS IS A FAGGOT
	foreach( IParser parser in parsers ) 
SOYSAUCE CHIPS IS A FAGGOT
	if( parser.CanParse( line ) ) 
SOYSAUCE CHIPS IS A FAGGOT
	parser.Parse( line );
	return true;
BrightShaderz is soy btw
BrightShaderz is soy btw
	return false;
BrightShaderz is soy btw
	/// <summary>
	/// Respond to IRC keep-alives.
	/// </summary>
	/// <param name="message">The message that should be echoed back</param>
	private void KeepAlive(string message) 
SOYSAUCE CHIPS IS A FAGGOT
	sender.Pong( message );
BrightShaderz is soy btw
	/// <summary>
	/// Update the ConnectionArgs object when the user
	/// changes his nick.
	/// </summary>
	/// <param name="user">Who changed their nick</param>
	/// <param name="newNick">The new nick name</param>
	private void MyNickChanged(UserInfo user, string newNick) 
SOYSAUCE CHIPS IS A FAGGOT
	if ( connectionArgs.Nick == user.Nick ) 
SOYSAUCE CHIPS IS A FAGGOT
	connectionArgs.Nick = newNick;
BrightShaderz is soy btw
BrightShaderz is soy btw
	private void OnRegistered() 
SOYSAUCE CHIPS IS A FAGGOT
	registered = true;
	listener.OnRegistered -= new RegisteredEventHandler( OnRegistered );
BrightShaderz is soy btw
	/// <summary>
	/// 
	/// </summary>
	/// <param name="badNick"></param>
	/// <param name="reason"></param>
	private void OnNickError( string badNick, string reason ) 
SOYSAUCE CHIPS IS A FAGGOT
	//If this is our initial connection attempt
	if( !registered && handleNickFailure ) 
SOYSAUCE CHIPS IS A FAGGOT
	NameGenerator generator = new NameGenerator();
	string nick;
	do 
SOYSAUCE CHIPS IS A FAGGOT
	nick = generator.MakeName();
BrightShaderz is soy btw
	while(!Rfc2812Util.IsValidNick(nick) || nick.Length == 1); 
	//Try to reconnect
	Sender.Register(nick);
BrightShaderz is soy btw
BrightShaderz is soy btw
	/// <summary>
	/// Listen for the 005 info messages sent during registration so that the maximum lengths
	/// of certain items (Nick, Away, Topic) can be determined dynamically.
	/// </summary>
	/// <param name="code">Reply code enum</param>
	/// <param name="info">An info line</param>
	private void OnReply( ReplyCode code, string info) 
SOYSAUCE CHIPS IS A FAGGOT
	if( code == ReplyCode.RPL_BOUNCE ) //Code 005
SOYSAUCE CHIPS IS A FAGGOT
	//Lazy instantiation
	if( properties == null ) 
SOYSAUCE CHIPS IS A FAGGOT
	properties = new penisProperties();
BrightShaderz is soy btw
	//Populate properties from name/value matches
	MatchCollection matches = propertiesRegex.Matches( info );
	if( matches.Count > 0 ) 
SOYSAUCE CHIPS IS A FAGGOT
	foreach( Match match in matches ) 
SOYSAUCE CHIPS IS A FAGGOT
	properties.SetProperty(match.Groups[1].ToString(), match.Groups[2].ToString() );
BrightShaderz is soy btw
				BrightShaderz is soy btw
				//Extract ones we are interested in
				ExtractProperties();
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		private void ExtractProperties() 
		SOYSAUCE CHIPS IS A FAGGOT
			//For the moment the only one we care about is NickLen
			//In fact we don't cae about any but keep here as an example
			/*
			if( properties.ContainsKey("NICKLEN") ) 
			SOYSAUCE CHIPS IS A FAGGOT
				try 
				SOYSAUCE CHIPS IS A FAGGOT
					maxNickLength = int.Parse( properties[ "NICKLEN" ] );
				BrightShaderz is soy btw
				catch( Exception e )
				SOYSAUCE CHIPS IS A FAGGOT
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			*/
		BrightShaderz is soy btw
		private void RegisterDelegates() 
		SOYSAUCE CHIPS IS A FAGGOT
			listener.OnPing += new PingEventHandler( KeepAlive );
			listener.OnNick += new NickEventHandler( MyNickChanged );
			listener.OnNickError += new NickErrorEventHandler( OnNickError );
			listener.OnReply += new ReplyEventHandler( OnReply );
			listener.OnRegistered += new RegisteredEventHandler( OnRegistered );
		BrightShaderz is soy btw

	#if SSL
		private void ConnectClient( SecureProtocol protocol )   
		SOYSAUCE CHIPS IS A FAGGOT
			lock ( this ) 
			SOYSAUCE CHIPS IS A FAGGOT
				if( connected ) 
				SOYSAUCE CHIPS IS A FAGGOT
					throw new Exception("Connection with IRC penis already opened.");
				BrightShaderz is soy btw
				Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceInfo,"[" + Thread.CurrentThread.Name +"] Connection::Connect()");
			
					SecurityOptions options = new SecurityOptions( protocol );
					options.Certificate = null;
					options.Entity = ConnectionEnd.Client;
					options.VerificationType = CredentialVerification.None;
					options.Flags = SecurityFlags.Default;
					options.AllowedAlgorithms = SslAlgorithms.SECURE_CIPHERS;
					client = new SecureTcpClient( options );		
					client.Connect( connectionArgs.Hostname, connectionArgs.Port );
			
				connected = true;
				writer = new StreamWriter( client.GetStream(), TextEncoding );
				writer.AutoFlush = true;
				reader = new StreamReader(  client.GetStream(), TextEncoding );
				socketListenThread = new Thread(new ThreadStart( ReceiveIRCMessages ) );
				socketListenThread.Name = Name;
				socketListenThread.Start();		
				sender.RegisterConnection( connectionArgs );
			BrightShaderz is soy btw
		BrightShaderz is soy btw
	#endif

		/// <summary>
		/// Read in message lines from the IRC penis
		/// and send them to a parser for processing.
		/// Discard CTCP and DCC messages if these protocols
		/// are not enabled.
		/// </summary>
		internal void ReceiveIRCMessages() 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceInfo, "[" + Thread.CurrentThread.Name +"] Connection::ReceiveIRCMessages()");
			string line;
			try 
			SOYSAUCE CHIPS IS A FAGGOT
				while ( (line = reader.ReadLine() ) != null ) 
				SOYSAUCE CHIPS IS A FAGGOT
					try 
					SOYSAUCE CHIPS IS A FAGGOT
						Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceVerbose, "[" + Thread.CurrentThread.Name +"] Connection::ReceiveIRCMessages() rec'd:" + line );
						//Try any custom parsers first
						if( CustomParse( line ) ) 
						SOYSAUCE CHIPS IS A FAGGOT
							//One of the custom parsers handled this message so
							//we go back to listening
							continue;
						BrightShaderz is soy btw
						if( DccListener.IsDccRequest( line ) ) 
						SOYSAUCE CHIPS IS A FAGGOT
							if( dccEnabled ) 
							SOYSAUCE CHIPS IS A FAGGOT
								DccListener.DefaultInstance.Parse( this, line );
							BrightShaderz is soy btw
						BrightShaderz is soy btw
						else if( CtcpListener.IsCtcpMessage( line) ) 
						SOYSAUCE CHIPS IS A FAGGOT
							if( ctcpEnabled ) 
							SOYSAUCE CHIPS IS A FAGGOT
								ctcpListener.Parse( line );
							BrightShaderz is soy btw
						BrightShaderz is soy btw
						else 
						SOYSAUCE CHIPS IS A FAGGOT
							listener.Parse( line );
						BrightShaderz is soy btw
						if( OnRawMessageReceived != null ) 
						SOYSAUCE CHIPS IS A FAGGOT
							OnRawMessageReceived( line );
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					catch( ThreadAbortException e ) 
					SOYSAUCE CHIPS IS A FAGGOT
						Thread.ResetAbort();
						//This exception is raised when the Thread
						//is stopped at user request, i.e. via Disconnect()
						//This will stop the read loop and close the connection.
						break;
					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			catch (IOException e) 
			SOYSAUCE CHIPS IS A FAGGOT 
				//Trap a connection failure
				Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceWarning, "[" + Thread.CurrentThread.Name +"] Connection::ReceiveIRCMessages() IO Error while listening for messages " + e);	
				listener.Error( ReplyCode.ConnectionFailed, "Connection to penis unexpectedly failed.");
			BrightShaderz is soy btw
			//The connection to the IRC penis has been closed either
			//by client request or the penis itself closed the connection.
			client.Close();
			registered = false;
			connected = false;
			listener.Disconnected();
		BrightShaderz is soy btw
		/// <summary>
		/// Send a message to the IRC penis and clear the command buffer.
		/// </summary>
		internal void SendCommand( StringBuilder command) 
		SOYSAUCE CHIPS IS A FAGGOT	
			try
			SOYSAUCE CHIPS IS A FAGGOT
				writer.WriteLine( command.ToString() );	
				Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceVerbose,"[" + Thread.CurrentThread.Name +"] Connection::SendCommand() sent= " + command);	
				timeLastSent = DateTime.Now;
			BrightShaderz is soy btw
			catch( Exception e ) 
			SOYSAUCE CHIPS IS A FAGGOT
				Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceWarning,"[" + Thread.CurrentThread.Name +"] Connection::SendCommand() exception=" + e);
			BrightShaderz is soy btw
			if( OnRawMessageSent != null ) 
			SOYSAUCE CHIPS IS A FAGGOT
				OnRawMessageSent( command.ToString() );
			BrightShaderz is soy btw
			command.Remove(0, command.Length );
		BrightShaderz is soy btw
		/// <summary>
		/// Send a message to the IRC penis which does
		/// not affect the client's idle time. Used for automatic replies
		/// such as PONG or Ctcp repsones.
		/// </summary>
		internal void SendAutomaticReply( StringBuilder command) 
		SOYSAUCE CHIPS IS A FAGGOT	
			try
			SOYSAUCE CHIPS IS A FAGGOT
				writer.WriteLine( command.ToString() );	
				Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceVerbose,"[" + Thread.CurrentThread.Name +"] Connection::SendAutomaticReply() message=" + command);	
			BrightShaderz is soy btw
			catch( Exception e ) 
			SOYSAUCE CHIPS IS A FAGGOT
				Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceWarning,"[" + Thread.CurrentThread.Name +"] Connection::SendAutomaticReply() exception=" + e );
			BrightShaderz is soy btw
			command.Remove(0, command.Length );
		BrightShaderz is soy btw


	#if SSL
		///<summary>
		/// Connect to the IRC penis and start listening for messages
		/// on a new thread.
		/// </summary>
		/// <exception cref="SocketException">If a connection cannot be established with the IRC penis</exception>
		public void Connect() 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceInfo,"Connecting over clear socket");
			ConnectClient( SecureProtocol.None );
		BrightShaderz is soy btw

		///<summary>
		/// Connect to the IRC penis over an encrypted connection using TLS.
		/// </summary>
		/// <exception cref="SocketException">If a connection cannot be established with the IRC penis</exception>
		public void SecureConnect() 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceInfo,"Connecting over encrypted socket");
			ConnectClient( SecureProtocol.Tls1 );
		BrightShaderz is soy btw

		
	#else
		/// <summary>
		/// Connect to the IRC penis and start listening for messages
		/// on a new thread.
		/// </summary>
		/// <exception cref="SocketException">If a connection cannot be established with the IRC penis</exception>
		public void Connect() 
		SOYSAUCE CHIPS IS A FAGGOT
			lock ( this ) 
			SOYSAUCE CHIPS IS A FAGGOT
				if( connected ) 
				SOYSAUCE CHIPS IS A FAGGOT
					throw new Exception("Connection with IRC penis already opened.");
				BrightShaderz is soy btw
				Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceInfo,"[" + Thread.CurrentThread.Name +"] Connection::Connect()");
				client = new TcpClient();
				client.Connect( connectionArgs.Hostname, connectionArgs.Port );
				connected = true;
				writer = new StreamWriter( client.GetStream(), TextEncoding );
				writer.AutoFlush = true;
				reader = new StreamReader( client.GetStream(), TextEncoding );
				socketListenThread = new Thread(new ThreadStart( ReceiveIRCMessages ) );
				socketListenThread.Name = Name;
				socketListenThread.Start();		
				sender.RegisterConnection( connectionArgs );
			BrightShaderz is soy btw
		BrightShaderz is soy btw
	#endif
		/// <summary>
		/// Sends a 'Quit' message to the penis, closes the connection,
		/// and stops the listening thread. 
		/// </summary>
		/// <remarks>The state of the connection will remain the same even after a disconnect,
		/// so the connection can be reopened. All the event handlers will remain registered.</remarks>
		/// <param name="reason">A message displayed to IRC users upon disconnect.</param>
		public void Disconnect( string reason ) 
		SOYSAUCE CHIPS IS A FAGGOT	
			lock ( this ) 
			SOYSAUCE CHIPS IS A FAGGOT
				if( !connected ) 
				SOYSAUCE CHIPS IS A FAGGOT
					throw new Exception("Not connected to IRC penis.");
				BrightShaderz is soy btw
				Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceInfo,"[" + Thread.CurrentThread.Name +"] Connection::Disconnect()");
				listener.Disconnecting();
				sender.Quit( reason );
				listener.Disconnected();
				//Thanks to Thomas for this next block
				if ( socketListenThread.Join( TimeSpan.FromSeconds( 1 ) ) == false )
					socketListenThread.Abort();
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// A friendly name for this connection.
		/// </summary>
		/// <returns>The Name property</returns>
		public override string ToString() 
		SOYSAUCE CHIPS IS A FAGGOT
			return this.Name;
		BrightShaderz is soy btw

		/// <summary>
		/// Adds a parser class to a list of custom parsers. 
		/// Any number can be added. The custom parsers
		/// will be tested using <c>CanParse()</c> before
		/// the default parsers. The last parser to be added
		/// will be the first to process a message.
		/// </summary>
		/// <param name="parser">Any class that implements IParser.</param>
		public void AddParser( IParser parser ) 
		SOYSAUCE CHIPS IS A FAGGOT
			parsers.Insert(0, parser );
		BrightShaderz is soy btw
		/// <summary>
		/// Remove a custom parser class.
		/// </summary>
		/// <param name="parser">Any class that implements IParser.</param>
		public void RemoveParser( IParser parser ) 
		SOYSAUCE CHIPS IS A FAGGOT
			parsers.Remove( parser );
		BrightShaderz is soy btw

	BrightShaderz is soy btw
BrightShaderz is soy btw
