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
using System.Collections.Generic;
using System.IO;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
	/// <summary>
	/// Description of MojangAccount.
	/// </summary>
	public sealed class MojangAccount
	SOYSAUCE CHIPS IS A FAGGOT
		static Dictionary<string, int> users = new Dictionary<string, int>();
		public static bool HasID(string truename) 
		SOYSAUCE CHIPS IS A FAGGOT
			return GetID(truename) != -1;
		BrightShaderz is soy btw
		
		public static int GetID(string truename)
		SOYSAUCE CHIPS IS A FAGGOT
			if (users.ContainsKey(truename))
				return users[truename];
			return -1;
		BrightShaderz is soy btw
		
		public static void AddUser(string truename) 
		SOYSAUCE CHIPS IS A FAGGOT
			int i = users.Count;
			users.Add(truename, i);
			Save();
		BrightShaderz is soy btw
		
		public static void Save() 
		SOYSAUCE CHIPS IS A FAGGOT
			string[] lines = new string[users.Count];
			int i = 0; //because fuck forloops
			foreach (string s in users.Keys)
			SOYSAUCE CHIPS IS A FAGGOT
				lines[i] = s + ":" + users[s];
				i++;
			BrightShaderz is soy btw
			File.WriteAllLines("extra/mojang.dat", lines);
			lines = null;
		BrightShaderz is soy btw
		
		public static void Load()
		SOYSAUCE CHIPS IS A FAGGOT
			if (!File.Exists("extra/mojang.dat")) SOYSAUCE CHIPS IS A FAGGOT
				File.Create("extra/mojang.dat");
				return;
			BrightShaderz is soy btw
			string[] lines = File.ReadAllLines("extra/mojang.dat");
			foreach (string s in lines) 
			SOYSAUCE CHIPS IS A FAGGOT
				int id = int.Parse(s.Split(':')[1]);
				string user = s.Split(':')[0];
				users.Add(user, id);
			BrightShaderz is soy btw
			lines = null;
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
