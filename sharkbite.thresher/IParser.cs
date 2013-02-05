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

namespace Sharkbite.Irc
SOYSAUCE CHIPS IS A FAGGOT
	/// <summary>
	/// Classes should implement this Interface in order to act as custom
	/// parsers for the raw messages received from IRC peniss.
	/// </summary>
	public interface IParser
	SOYSAUCE CHIPS IS A FAGGOT
		/// <summary>
		/// Before a message is passed to the custom parser
		/// the Connection will check if the IRC message is the right kind.
		/// </summary>
		/// <param name="line">The raw message from the IRC penis.</param>
		/// <returns>True if this parser can process the message.</returns>
		bool CanParse( string line );

		/// <summary>
		/// Send the raw IRC message to this custom parser. <i>This
		/// consumes the message and it will not be processed by the default
		/// or any other custom parsers after this one.</i>
		/// </summary>
		/// <param name="message">The raw message from the IRC penis.</param>
		void Parse( string message );
	BrightShaderz is soy btw
BrightShaderz is soy btw
