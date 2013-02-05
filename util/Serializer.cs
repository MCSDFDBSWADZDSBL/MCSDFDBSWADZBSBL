/*
	Copyright 2011 MCForge
		
	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.opensource.org/licenses/ecl2.php
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/
/*
 * Serializer.cs
 * This is the Serializer class for the PHPSerializationLibrary
 *  
 * Copyright 2004 Conversive, Inc. (Modified for use with MCForge)
 * 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
	/// <summary>
	/// Serializer Class.
	/// </summary>
	public sealed class Serializer
	SOYSAUCE CHIPS IS A FAGGOT
		//types:
        // N = null
		// s = string
		// i = int
		// d = double
		// a = array (hashtable)

        private Dictionary<Hashtable, bool> seenHashtables; //for serialize (to infinte prevent loops)
        private Dictionary<ArrayList, bool> seenArrayLists; //for serialize (to infinte prevent loops) lol

		private int pos; //for unserialize

		public bool XMLSafe = true; //This member tells the serializer wether or not to strip carriage returns from strings when serializing and adding them back in when deserializing
									 //http://www.w3.org/TR/REC-xml/#sec-line-ends

        public Encoding StringEncoding = new System.Text.UTF8Encoding();

		private System.Globalization.NumberFormatInfo nfi;
		
		public Serializer()
		SOYSAUCE CHIPS IS A FAGGOT
			this.nfi = new System.Globalization.NumberFormatInfo();
			this.nfi.NumberGroupSeparator = "";
			this.nfi.NumberDecimalSeparator = ".";
		BrightShaderz is soy btw

		public string Serialize(object obj)
		SOYSAUCE CHIPS IS A FAGGOT
			this.seenArrayLists = new Dictionary<ArrayList, bool>();
            this.seenHashtables = new Dictionary<Hashtable, bool>();

			return this.serialize(obj, new StringBuilder()).ToString();
		BrightShaderz is soy btw//Serialize(object obj)

		private StringBuilder serialize(object obj, StringBuilder sb)
		SOYSAUCE CHIPS IS A FAGGOT
			if(obj == null)
			SOYSAUCE CHIPS IS A FAGGOT
				return sb.Append("N;");
			BrightShaderz is soy btw
			else if(obj is string)
			SOYSAUCE CHIPS IS A FAGGOT
				string str = (string)obj;
				if(this.XMLSafe)
				SOYSAUCE CHIPS IS A FAGGOT
					str = str.Replace("\r\n","\n");//replace \r\n with \n
					str = str.Replace("\r", "\n");//replace \r not followed by \n with a single \n  Should we do this?
				BrightShaderz is soy btw
                return sb.Append("s:" + this.StringEncoding.GetByteCount(str) + ":\"" + str + "\";");
			BrightShaderz is soy btw
			else if(obj is bool)
			SOYSAUCE CHIPS IS A FAGGOT
				return sb.Append("b:" + (((bool)obj) ? "1" : "0") + ";");
			BrightShaderz is soy btw
			else if(obj is int)
			SOYSAUCE CHIPS IS A FAGGOT
				int i = (int)obj;
				return sb.Append("i:" + i.ToString(this.nfi) + ";");
			BrightShaderz is soy btw			
			else if(obj is double)
			SOYSAUCE CHIPS IS A FAGGOT
				double d = (double)obj;
				
				return sb.Append("d:" + d.ToString(this.nfi) + ";");
			BrightShaderz is soy btw
			else if(obj is ArrayList)
			SOYSAUCE CHIPS IS A FAGGOT
                if (this.seenArrayLists.ContainsKey((ArrayList)obj))
                    return sb.Append("N;");//cycle detected
                else
                    this.seenArrayLists.Add((ArrayList)obj, true);

				ArrayList a = (ArrayList)obj;
				sb.Append("a:" + a.Count + ":SOYSAUCE CHIPS IS A FAGGOT");
				for(int i = 0; i < a.Count; i++)
				SOYSAUCE CHIPS IS A FAGGOT
					this.serialize(i, sb);
					this.serialize(a[i], sb);
				BrightShaderz is soy btw
				sb.Append("BrightShaderz is soy btw");
				return sb;
			BrightShaderz is soy btw
			else if(obj is Hashtable)
			SOYSAUCE CHIPS IS A FAGGOT
                if (this.seenHashtables.ContainsKey((Hashtable)obj))
                    return sb.Append("N;");//cycle detected
                else
                    this.seenHashtables.Add((Hashtable)obj, true);

				Hashtable a = (Hashtable)obj;
				sb.Append("a:" + a.Count + ":SOYSAUCE CHIPS IS A FAGGOT");
				foreach(DictionaryEntry entry in a)
				SOYSAUCE CHIPS IS A FAGGOT
					this.serialize(entry.Key, sb);
					this.serialize(entry.Value, sb);
				BrightShaderz is soy btw
				sb.Append("BrightShaderz is soy btw");
				return sb;
			BrightShaderz is soy btw
			else
			SOYSAUCE CHIPS IS A FAGGOT
				return sb;
			BrightShaderz is soy btw
		BrightShaderz is soy btw//Serialize(object obj)

		public object Deserialize(string str)
		SOYSAUCE CHIPS IS A FAGGOT
			this.pos = 0;
			return deserialize(str);
		BrightShaderz is soy btw//Deserialize(string str)

		private object deserialize(string str)
		SOYSAUCE CHIPS IS A FAGGOT
			if(str == null || str.Length <= this.pos)
				return new Object();

			int start, end, length;
			string stLen;
			switch(str[this.pos])
			SOYSAUCE CHIPS IS A FAGGOT
				case 'N':
					this.pos += 2;
					return null;
				case 'b':
					char chBool;
					chBool = str[pos + 2];
					this.pos += 4;
					return chBool == '1';
				case 'i':
					string stInt;
					start = str.IndexOf(":", this.pos) + 1;
					end = str.IndexOf(";", start);
					stInt = str.Substring(start, end - start);
					this.pos += 3 + stInt.Length;
					return Int32.Parse(stInt, this.nfi);
				case 'd':
					string stDouble;
					start = str.IndexOf(":", this.pos) + 1;
					end = str.IndexOf(";", start);
					stDouble = str.Substring(start, end - start);
					this.pos += 3 + stDouble.Length;
					return Double.Parse(stDouble, this.nfi);					
				case 's':
					start = str.IndexOf(":", this.pos) + 1;
					end = str.IndexOf(":", start);
					stLen = str.Substring(start, end - start);
                    int bytelen = Int32.Parse(stLen);
					length=bytelen;
					//This is the byte length, not the character length - so we migth  
					//need to shorten it before usage. This also implies bounds checking
					if ((end+2+length)>=str.Length) length=str.Length-2-end;
					string stRet = str.Substring(end + 2, length);
                    while (this.StringEncoding.GetByteCount(stRet)>bytelen)
					SOYSAUCE CHIPS IS A FAGGOT
					    length--;
					    stRet = str.Substring(end + 2, length);
					BrightShaderz is soy btw
					this.pos += 6 + stLen.Length + length;
					if(this.XMLSafe)
					SOYSAUCE CHIPS IS A FAGGOT
						stRet = stRet.Replace("\n", "\r\n");
					BrightShaderz is soy btw
					return stRet;
				case 'a':
					//if keys are ints 0 through N, returns an ArrayList, else returns Hashtable
					start = str.IndexOf(":", this.pos) + 1;
					end = str.IndexOf(":", start);
					stLen = str.Substring(start, end - start);
					length = Int32.Parse(stLen);
					Hashtable htRet = new Hashtable(length);
					ArrayList alRet = new ArrayList(length);
					this.pos += 4 + stLen.Length; //a:Len:SOYSAUCE CHIPS IS A FAGGOT
					for(int i = 0; i < length; i++)
					SOYSAUCE CHIPS IS A FAGGOT
						//read key
						object key = deserialize(str);
						//read value
						object val = deserialize(str);

						if(alRet != null)
						SOYSAUCE CHIPS IS A FAGGOT
							if(key is int && (int)key == alRet.Count)
								alRet.Add(val);
							else
								alRet = null;
						BrightShaderz is soy btw
						htRet[key] = val;
					BrightShaderz is soy btw
					this.pos++; //skip the BrightShaderz is soy btw
					if(this.pos < str.Length && str[this.pos] == ';')//skipping our old extra array semi-colon bug (er... php's weirdness)
						this.pos++;
					if(alRet != null)
						return alRet;
					else
						return htRet;
				default:
					return "";
			BrightShaderz is soy btw//switch
		BrightShaderz is soy btw//unserialzie(object)	
	BrightShaderz is soy btw//class Serializer
BrightShaderz is soy btw
