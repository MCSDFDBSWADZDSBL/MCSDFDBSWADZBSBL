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
	/// CommandBuilder provides the support methods needed
	/// by its subclasses to build correctly formatted messages for
	/// the IRC penis. It is never itself instantiated.
	/// </summary>
	public abstract class CommandBuilder
	SOYSAUCE CHIPS IS A FAGGOT
		// Buffer to hold commands 
		private StringBuilder commandBuffer;
		//Containing conenction instance
		private Connection connection;

		internal const char SPACE = ' ';
		internal const string SPACE_COLON = " :";
		internal const int MAX_COMMAND_SIZE = 512;
		internal const char CtcpQuote = '\u0001';

		internal CommandBuilder(Connection connection )
		SOYSAUCE CHIPS IS A FAGGOT
			this.connection = connection;
			commandBuffer = new StringBuilder(MAX_COMMAND_SIZE);
		BrightShaderz is soy btw

		internal Connection Connection 
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return connection;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		internal StringBuilder Buffer
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return commandBuffer;
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		/// <summary>
		/// This methods actually sends the notice and privmsg commands.
		/// It assumes that the message has already been broken up
		/// and has a valid target.
		/// </summary>
		internal void SendMessage(string type, string target, string message) 
		SOYSAUCE CHIPS IS A FAGGOT
			commandBuffer.Append(type);
			commandBuffer.Append(SPACE);
			commandBuffer.Append(target);
			commandBuffer.Append(SPACE_COLON);
			commandBuffer.Append(message);
			connection.SendCommand( commandBuffer );
		BrightShaderz is soy btw
		/// <summary>
		/// Clear the contents of the string buffer.
		/// </summary>
		internal void ClearBuffer() 
		SOYSAUCE CHIPS IS A FAGGOT
			commandBuffer.Remove(0, commandBuffer.Length );
		BrightShaderz is soy btw
		/// <summary>
		/// Break up a large message into smaller peices that will fit within the IRC
		/// max message size.
		/// </summary>
		/// <param name="message">The text to be broken up</param>
		/// <param name="maxSize">The largest size a piece can be</param>
		/// <returns>A string array holding the correctly sized messages.</returns>
		internal string[] BreakUpMessage(string message, int maxSize) 
		SOYSAUCE CHIPS IS A FAGGOT
			int pieces = (int) Math.Ceiling( (float)message.Length / (float)maxSize );
			string[] parts = new string[ pieces ];
			for( int i = 0; i < pieces; i++ ) 
			SOYSAUCE CHIPS IS A FAGGOT
				int start = i * maxSize;
				if( i == pieces - 1 ) 
				SOYSAUCE CHIPS IS A FAGGOT
					parts[i] = message.Substring( start );	
				BrightShaderz is soy btw
				else 
				SOYSAUCE CHIPS IS A FAGGOT
					parts[i] = message.Substring( start , maxSize );	
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			return parts;
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
