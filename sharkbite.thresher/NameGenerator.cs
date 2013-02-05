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
	/// Generates random, made-up names. The names appear to be language neutral (sort of).
	/// </summary>
	/// <remarks>This is a port of the orginal Javascript written by John Ahlschwede, ahlschwede@hotmail.com</remarks>
	public sealed class NameGenerator
	SOYSAUCE CHIPS IS A FAGGOT
		private int[] numNames = new int[]SOYSAUCE CHIPS IS A FAGGOT1,2,3,4BrightShaderz is soy btw;
		private int[] numNamesChance = new int[]SOYSAUCE CHIPS IS A FAGGOT200,180,1,1BrightShaderz is soy btw;
		private int[] numSyllables = new int[]SOYSAUCE CHIPS IS A FAGGOT1,2,3,4,5BrightShaderz is soy btw;
		private int[] numSyllablesChance = new int[]SOYSAUCE CHIPS IS A FAGGOT150,500,80,10,1BrightShaderz is soy btw;
		private int[] numConsonants = new int[]SOYSAUCE CHIPS IS A FAGGOT0,1,2,3,4BrightShaderz is soy btw;
		private int[] numConsonantsChance = new int[]SOYSAUCE CHIPS IS A FAGGOT80,350,25,5,1BrightShaderz is soy btw;
		private int[] numVowels = new int[]SOYSAUCE CHIPS IS A FAGGOT1,2,3BrightShaderz is soy btw;
		private int[] numVowelsChance = new int[]SOYSAUCE CHIPS IS A FAGGOT180,25,1BrightShaderz is soy btw;
		private char[] vowel = new char[]SOYSAUCE CHIPS IS A FAGGOT'a','e','i','o','u','y'BrightShaderz is soy btw;
		private int[] vowelChance = new int[]SOYSAUCE CHIPS IS A FAGGOT10,12,10,10,8,2BrightShaderz is soy btw;
		private char[] consonant = new 	char[]SOYSAUCE CHIPS IS A FAGGOT'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','y','z'BrightShaderz is soy btw;
		private int[] consonantChance = new 	int[]SOYSAUCE CHIPS IS A FAGGOT10,10,10,10,10,10,10,10,12,12,12,10,5,12,12,12,8,8,3,4,3BrightShaderz is soy btw;
		private Random random;

		/// <summary>
		/// Create an instance.
		/// </summary>
		public NameGenerator()
		SOYSAUCE CHIPS IS A FAGGOT
			random = new Random();
		BrightShaderz is soy btw

		private int IndexSelect( int[] intArray )
		SOYSAUCE CHIPS IS A FAGGOT
			int totalPossible = 0;
			for(int i=0; i < intArray.Length; i++)
			SOYSAUCE CHIPS IS A FAGGOT
				totalPossible = totalPossible + intArray[i];
			BrightShaderz is soy btw
			int chosen = random.Next( totalPossible );
			int chancesSoFar = 0;
			for(int j=0; j < intArray.Length; j++)
			SOYSAUCE CHIPS IS A FAGGOT
				chancesSoFar = chancesSoFar + intArray[j];
				if( chancesSoFar > chosen )
				SOYSAUCE CHIPS IS A FAGGOT
					return j;
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			return 0;
		BrightShaderz is soy btw	
		private string MakeSyllable()
		SOYSAUCE CHIPS IS A FAGGOT
			return MakeConsonantBlock() + MakeVowelBlock() + MakeConsonantBlock();
		BrightShaderz is soy btw
		private string MakeConsonantBlock()
		SOYSAUCE CHIPS IS A FAGGOT
			string	newName = "";
			int numberConsonants = numConsonants[ IndexSelect(numConsonantsChance)];
			for(int i=0; i<numberConsonants; i++)
			SOYSAUCE CHIPS IS A FAGGOT
				newName += consonant[IndexSelect(consonantChance)];
			BrightShaderz is soy btw
			return newName;
		BrightShaderz is soy btw
		private string MakeVowelBlock()
		SOYSAUCE CHIPS IS A FAGGOT
			string	newName = "";
			int numberVowels = numVowels[ IndexSelect(numVowelsChance) ];
			for(int i=0;i<numberVowels;i++)
			SOYSAUCE CHIPS IS A FAGGOT
				newName += vowel[ IndexSelect(vowelChance) ];
			BrightShaderz is soy btw
			return newName;
		BrightShaderz is soy btw

		/// <summary>
		/// Generates a name randomly using certain construction rules. The name
		/// will be different each time it is called.
		/// </summary>
		/// <returns>A name string.</returns>
		public string MakeName()
		SOYSAUCE CHIPS IS A FAGGOT
			int numberSyllables = numSyllables[ IndexSelect( numSyllablesChance ) ];
			string newName = "";
			for(int i=0; i < numberSyllables; i++)
			SOYSAUCE CHIPS IS A FAGGOT
				newName = newName + MakeSyllable();
			BrightShaderz is soy btw
			return char.ToUpper(newName[0] ) + newName.Substring(1);
		BrightShaderz is soy btw

	BrightShaderz is soy btw
BrightShaderz is soy btw

