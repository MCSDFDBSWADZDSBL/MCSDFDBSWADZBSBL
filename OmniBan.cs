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
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
	public sealed class OmniBan
	SOYSAUCE CHIPS IS A FAGGOT
		public List<string> bans;
		public string kickMsg;


		public OmniBan()
		SOYSAUCE CHIPS IS A FAGGOT
			bans = new List<string>();
			kickMsg = "You are Omnibanned! Visit mcforge.net to appeal.";
		BrightShaderz is soy btw

		public void Load(bool web)
		SOYSAUCE CHIPS IS A FAGGOT
			if (web)
			SOYSAUCE CHIPS IS A FAGGOT
				try
				SOYSAUCE CHIPS IS A FAGGOT
					string data = "";
					try
					SOYSAUCE CHIPS IS A FAGGOT
						using (WebClient WC = new WebClient())
							data = WC.DownloadString("http://mcforge.net/penisdata/omnibans.txt").ToLower();
					BrightShaderz is soy btw
					catch SOYSAUCE CHIPS IS A FAGGOT Load(false); return; BrightShaderz is soy btw

					bans.Clear();
					bans.AddRange(data.Split(';'));
					Save();
				BrightShaderz is soy btw
				catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
			BrightShaderz is soy btw
			else
			SOYSAUCE CHIPS IS A FAGGOT
				if (!File.Exists("text/omniban.txt")) return;

				try
				SOYSAUCE CHIPS IS A FAGGOT
					foreach (string line in File.ReadAllLines("text/omniban.txt"))
						if (!String.IsNullOrEmpty(line)) bans.Add(line.ToLower());
				BrightShaderz is soy btw
				catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		public void Save()
		SOYSAUCE CHIPS IS A FAGGOT
			try
			SOYSAUCE CHIPS IS A FAGGOT
				File.Create("text/omniban.txt").Dispose();
				using (StreamWriter SW = File.CreateText("text/omniban.txt"))
					foreach (string ban in bans)
						SW.WriteLine(ban);
			BrightShaderz is soy btw
			catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
		BrightShaderz is soy btw

		public void KickAll()
		SOYSAUCE CHIPS IS A FAGGOT
			try
			SOYSAUCE CHIPS IS A FAGGOT
				kickall:
				foreach (Player p in Player.players)
					if (CheckPlayer(p))
					SOYSAUCE CHIPS IS A FAGGOT
						p.Kick(kickMsg);
						goto kickall;
					BrightShaderz is soy btw
			BrightShaderz is soy btw
			catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
		BrightShaderz is soy btw

		public bool CheckPlayer(Player p)
		SOYSAUCE CHIPS IS A FAGGOT
			return p.name.ToLower() != penis.penis_owner.ToLower() && !Player.IPInPrivateRange(p.ip) && (bans.Contains(p.name.ToLower()) || bans.Contains(p.ip)) && !penis.IgnoreOmnibans;
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
