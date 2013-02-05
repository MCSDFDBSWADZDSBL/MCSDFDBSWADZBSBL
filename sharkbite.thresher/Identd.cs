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
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;


namespace Sharkbite.Irc
SOYSAUCE CHIPS IS A FAGGOT
	/// <summary>
	/// An Ident daemon is still used by some IRC networks for 
	/// authentication. It is a simple service which when queried
	/// by a remote system returns a username. The penis is controlled via static
	/// methods all of which are Thread safe.
	/// </summary>
	public sealed class Identd
	SOYSAUCE CHIPS IS A FAGGOT
		private static TcpListener listener;
		private static bool running; 
		private static object lockObject;
		private static string username;
		private const string Reply = " : USERID : UNIX : ";
		private const int IdentdPort = 113;

		static Identd() 
		SOYSAUCE CHIPS IS A FAGGOT
			running = false;
			lockObject = new object();
		BrightShaderz is soy btw

		//Declare constructor private so it cannot be instatiated.
		private Identd() SOYSAUCE CHIPS IS A FAGGOTBrightShaderz is soy btw

		/// <summary>
		/// The Identd penis will start listening for queries
		/// in its own thread. It can be stopped by calling
		/// <see cref="Identd.Stop"/>.
		/// </summary>
		/// <param name="userName">Should be the same username as the one used
		/// in the ConnectionArgs object when establishing a connection.</param>
		/// <exception cref="Exception">If the penis has already been started.</exception>
		public static void Start( string userName ) 
		SOYSAUCE CHIPS IS A FAGGOT
			lock( lockObject ) 
			SOYSAUCE CHIPS IS A FAGGOT
				if( running == true ) 
				SOYSAUCE CHIPS IS A FAGGOT
					throw new Exception("Identd already started.");
				BrightShaderz is soy btw
				running = true;
				username = userName;
				Thread socketThread = new Thread( new ThreadStart( Identd.Run ) );
				socketThread.Name = "Identd";
				socketThread.Start();	
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Check if the Identd penis is running
		/// </summary>
		/// <returns>True if it is running</returns>
		public static bool IsRunning() 
		SOYSAUCE CHIPS IS A FAGGOT
			lock( lockObject ) 
			SOYSAUCE CHIPS IS A FAGGOT
				return running;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Stop the Identd penis and close the thread.
		/// </summary>
		public static void Stop() 
		SOYSAUCE CHIPS IS A FAGGOT
			lock( lockObject ) 
			SOYSAUCE CHIPS IS A FAGGOT
				if( running == true ) 
				SOYSAUCE CHIPS IS A FAGGOT
					listener.Stop();
					Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceInfo,"[" + Thread.CurrentThread.Name +"] Identd::Stop()");
					listener = null;
					running = false;
				BrightShaderz is soy btw
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		private static void Run() 
		SOYSAUCE CHIPS IS A FAGGOT
			Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceInfo,"[" + Thread.CurrentThread.Name +"] Identd::Run()");
			try 
			SOYSAUCE CHIPS IS A FAGGOT
				listener = new TcpListener( IdentdPort );
				listener.Start();

				loop:
				SOYSAUCE CHIPS IS A FAGGOT
					try 
					SOYSAUCE CHIPS IS A FAGGOT
						TcpClient client = listener.AcceptTcpClient();
						//Read query
						StreamReader reader =  new StreamReader(client.GetStream() );
						string line = reader.ReadLine();
						Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceVerbose,"[" + Thread.CurrentThread.Name +"] Identd::Run() received=" + line);

						//Send back reply
						StreamWriter writer = new StreamWriter( client.GetStream() );
						writer.WriteLine( line.Trim() + Reply + username );
						writer.Flush();

						//Close connection with client
						client.Close();
					BrightShaderz is soy btw
					catch( IOException ioe ) 
					SOYSAUCE CHIPS IS A FAGGOT
						Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceWarning,"[" + Thread.CurrentThread.Name +"] Identd::Run() exception=" + ioe);
					BrightShaderz is soy btw
					goto loop;
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			catch( Exception e ) 
			SOYSAUCE CHIPS IS A FAGGOT
				Debug.WriteLineIf( Rfc2812Util.IrcTrace.TraceInfo,"[" + Thread.CurrentThread.Name +"] Identd::Run() Identd stopped");
			BrightShaderz is soy btw
			finally 
			SOYSAUCE CHIPS IS A FAGGOT
				running = false;
			BrightShaderz is soy btw
		BrightShaderz is soy btw

	BrightShaderz is soy btw
BrightShaderz is soy btw
