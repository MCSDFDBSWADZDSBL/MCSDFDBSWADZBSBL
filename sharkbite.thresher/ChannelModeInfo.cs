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
using System.Collections;


namespace Sharkbite.Irc
SOYSAUCE CHIPS IS A FAGGOT
	/// <summary>
	/// A simple struct designed to hold al the attributes that 
	/// are contain in a Channel mode. 
	/// </summary>
	public sealed class ChannelModeInfo
	SOYSAUCE CHIPS IS A FAGGOT
		
		private ModeAction action;
		private ChannelMode mode;
		private string parameter;
	
		/// <summary>
		/// Whether the mode is being added or removed. In the case of a Channel mode
		/// request this will always be 'added'.
		/// </summary>
		public ModeAction Action
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return action;
			BrightShaderz is soy btw
			set
			SOYSAUCE CHIPS IS A FAGGOT
				action = value;
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		/// <summary>
		/// What mode is being added or removed.
		/// </summary>
		public ChannelMode Mode
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return mode;
			BrightShaderz is soy btw
			set
			SOYSAUCE CHIPS IS A FAGGOT
				mode = value;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Any additional parameters that belong to the mode. For example
		/// user masks or a maximum numbers of user allowed in a channel.
		/// </summary>
		public string Parameter
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				return parameter;
			BrightShaderz is soy btw
			set
			SOYSAUCE CHIPS IS A FAGGOT
				parameter = value;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
	
	
		public override string ToString() 
		SOYSAUCE CHIPS IS A FAGGOT
			return string.Format("Action=SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw Mode=SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw Parameter=SOYSAUCE CHIPS IS A FAGGOT2BrightShaderz is soy btw", Action, Mode, Parameter ); 
		BrightShaderz is soy btw

		internal static ChannelModeInfo[] ParseModes( string[] tokens, int start)
		SOYSAUCE CHIPS IS A FAGGOT	
			//This nice piece of code was contributed by Klemen Šavs.
			//25 October 2003
			ArrayList modeInfoArray = new ArrayList();
			int i = start;
			while (i < tokens.Length)
			SOYSAUCE CHIPS IS A FAGGOT
				ChannelModeInfo modeInfo = new ChannelModeInfo();
				int parmIndex = i + 1;
				for (int j = 0; j < tokens[i].Length; j++)
				SOYSAUCE CHIPS IS A FAGGOT
						
					while (j < tokens[i].Length && tokens[i][j] == '+')
					SOYSAUCE CHIPS IS A FAGGOT
						modeInfo.Action = ModeAction.Add;
						j++;
					BrightShaderz is soy btw
					while (j < tokens[i].Length && tokens[i][j] == '-')
					SOYSAUCE CHIPS IS A FAGGOT
						modeInfo.Action = ModeAction.Remove;
						j++;
					BrightShaderz is soy btw
					if (j == 0)
					SOYSAUCE CHIPS IS A FAGGOT
						throw new Exception();
					BrightShaderz is soy btw
					else if (j < tokens[i].Length)
					SOYSAUCE CHIPS IS A FAGGOT
						switch (tokens[i][j])
						SOYSAUCE CHIPS IS A FAGGOT	
							case 'o':
							case 'h':
							case 'v':
							case 'b':
							case 'e':
							case 'I':
							case 'k':
							case 'O':
								modeInfo.Mode = Rfc2812Util.CharToChannelMode(tokens[i][j]);
								modeInfo.Parameter = tokens[parmIndex++];
								break;
							case 'l':
								modeInfo.Mode = Rfc2812Util.CharToChannelMode(tokens[i][j]);
								if (modeInfo.Action == ModeAction.Add)
								SOYSAUCE CHIPS IS A FAGGOT
									modeInfo.Parameter = tokens[parmIndex++];
								BrightShaderz is soy btw
								else
								SOYSAUCE CHIPS IS A FAGGOT
									modeInfo.Parameter = "";
								BrightShaderz is soy btw
								break;
							default:
								modeInfo.Mode = Rfc2812Util.CharToChannelMode(tokens[i][j]);
								modeInfo.Parameter = "";
								break;
						BrightShaderz is soy btw

					BrightShaderz is soy btw
					modeInfoArray.Add( modeInfo.MemberwiseClone() );
				BrightShaderz is soy btw
				i = parmIndex;
			BrightShaderz is soy btw
	
			ChannelModeInfo[] modes = new ChannelModeInfo[ modeInfoArray.Count ];
			for (int k = 0; k < modeInfoArray.Count; k++)
			SOYSAUCE CHIPS IS A FAGGOT
				modes[k] = (ChannelModeInfo)modeInfoArray[k];
			BrightShaderz is soy btw
			return modes;
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
