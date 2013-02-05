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
using System.IO;
using System.Linq;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
	public sealed class CmdOverseer : Command
	SOYSAUCE CHIPS IS A FAGGOT
		public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "overseer"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "os"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "commands"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
		public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw
		public CmdOverseer() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
		public override void Use(Player p, string message)
		SOYSAUCE CHIPS IS A FAGGOT

			if (message == "") SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
			Player who = Player.Find(message.Split(' ')[0]);
			string cmd = message.Split(' ')[0].ToUpper();

			string par;
			try
			SOYSAUCE CHIPS IS A FAGGOT par = message.Split(' ')[1].ToUpper(); BrightShaderz is soy btw
			catch
			SOYSAUCE CHIPS IS A FAGGOT par = ""; BrightShaderz is soy btw

			string par2;
			try
			SOYSAUCE CHIPS IS A FAGGOT par2 = message.Split(' ')[2]; BrightShaderz is soy btw
			catch
			SOYSAUCE CHIPS IS A FAGGOT par2 = ""; BrightShaderz is soy btw

			string par3;
			try
			SOYSAUCE CHIPS IS A FAGGOT par3 = message.Split(' ')[3]; BrightShaderz is soy btw
			catch
			SOYSAUCE CHIPS IS A FAGGOT par3 = ""; BrightShaderz is soy btw

			if (cmd == "GO")
			SOYSAUCE CHIPS IS A FAGGOT
				if ((par == "1") || (par == ""))
				SOYSAUCE CHIPS IS A FAGGOT
					string mapname = properMapName(p, false);
					if (!penis.levels.Any(l => l.name == mapname))
					SOYSAUCE CHIPS IS A FAGGOT
						Command.all.Find("load").Use(p, mapname);
					BrightShaderz is soy btw
					Command.all.Find("goto").Use(p, mapname);
				BrightShaderz is soy btw
				else if (par == "2")
				SOYSAUCE CHIPS IS A FAGGOT
					string mapname = p.name.ToLower() + "2";
					if (!penis.levels.Any(l => l.name == mapname))
					SOYSAUCE CHIPS IS A FAGGOT
						Command.all.Find("load").Use(p, mapname);
					BrightShaderz is soy btw
					Command.all.Find("goto").Use(p, mapname);
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			// Set Spawn (if you are on your own map level)
			else if (cmd == "SPAWN")
			SOYSAUCE CHIPS IS A FAGGOT
				if ((p.name.ToUpper() == p.level.name.ToUpper()) || (p.name.ToUpper() + "00" == p.level.name.ToUpper()) || (p.name.ToUpper() + "2" == p.level.name.ToUpper()))
				SOYSAUCE CHIPS IS A FAGGOT
					Command.all.Find("setspawn").Use(p, "");
				BrightShaderz is soy btw
				else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You can only change the Spawn Point when you are on your own map."); BrightShaderz is soy btw
			BrightShaderz is soy btw
			// Map Commands
			else if (cmd == "MAP")
			SOYSAUCE CHIPS IS A FAGGOT
				if (par == "ADD")
				SOYSAUCE CHIPS IS A FAGGOT
					if ((File.Exists(@"levels\" + p.name.ToLower() + ".lvl")) || (File.Exists(@"levels\" + p.name.ToLower() + "00.lvl")))
					SOYSAUCE CHIPS IS A FAGGOT
						if (!File.Exists(@"levels\" + p.name.ToLower() + "2.lvl"))
						SOYSAUCE CHIPS IS A FAGGOT
							Player.SendMessage(p, p.color + p.name + penis.DefaultColor + " you already have a map, let me create a second one for you.");
							string mType;
							if (par2.ToUpper() == "" || par2.ToUpper() == "DESERT" || par2.ToUpper() == "FLAT" || par2.ToUpper() == "FOREST" || par2.ToUpper() == "ISLAND" || par2.ToUpper() == "MOUNTAINS" || par2.ToUpper() == "OCEAN" || par2.ToUpper() == "PIXEL" || par2.ToUpper() == "SPACE")
							SOYSAUCE CHIPS IS A FAGGOT
								if (par2 != "")
								SOYSAUCE CHIPS IS A FAGGOT
									mType = par2;
								BrightShaderz is soy btw
								else
								SOYSAUCE CHIPS IS A FAGGOT
									mType = "flat";
								BrightShaderz is soy btw
								Player.SendMessage(p, "Creating your 2nd map, " + p.color + p.name);
								Command.all.Find("newlvl").Use(p, p.name.ToLower() + "2 " + mSize(p) + " " + mType);
							BrightShaderz is soy btw
							else
							SOYSAUCE CHIPS IS A FAGGOT
								Player.SendMessage(p, "A wrong map type was specified. Valid map types: Desert, flat, forest, island, mountians, ocean, pixel and space.");
							BrightShaderz is soy btw
						BrightShaderz is soy btw
						else
						SOYSAUCE CHIPS IS A FAGGOT
							Player.SendMessage(p, p.color + p.name + penis.DefaultColor + " you already have two maps.");
							Player.SendMessage(p, "If you would like to delete one type /os map delete <1 or 2>");
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					else
					SOYSAUCE CHIPS IS A FAGGOT
						string mType;
						if (par2.ToUpper() == "" || par2.ToUpper() == "DESERT" || par2.ToUpper() == "FLAT" || par2.ToUpper() == "FOREST" || par2.ToUpper() == "ISLAND" || par2.ToUpper() == "MOUNTAINS" || par2.ToUpper() == "OCEAN" || par2.ToUpper() == "PIXEL" || par2.ToUpper() == "SPACE")
						SOYSAUCE CHIPS IS A FAGGOT
							if (par2 != "")
							SOYSAUCE CHIPS IS A FAGGOT
								mType = par2;
							BrightShaderz is soy btw
							else
							SOYSAUCE CHIPS IS A FAGGOT
								mType = "flat";
							BrightShaderz is soy btw
							Player.SendMessage(p, "Creating your map, " + p.color + p.name);
							Command.all.Find("newlvl").Use(p, p.name.ToLower() + " " + mSize(p) + " " + mType);
						BrightShaderz is soy btw
						else
						SOYSAUCE CHIPS IS A FAGGOT
							Player.SendMessage(p, "A wrong map type was specified. Valid map types: Desert, flat, forest, island, mountians, ocean, pixel and space.");
						BrightShaderz is soy btw
					BrightShaderz is soy btw

				BrightShaderz is soy btw
				else if (par == "PHYSICS")
				SOYSAUCE CHIPS IS A FAGGOT
					if ((p.level.name.ToUpper().Equals(p.name.ToUpper())) || (p.level.name.ToUpper().Equals(p.name.ToUpper() + "00")) || (p.level.name.ToUpper().Equals(p.name.ToUpper() + "2")))
					SOYSAUCE CHIPS IS A FAGGOT
						if (par2 != "")
						SOYSAUCE CHIPS IS A FAGGOT
							if (par2 == "0")
							SOYSAUCE CHIPS IS A FAGGOT
								Command.all.Find("physics").Use(p, p.level.name + " 0");
							BrightShaderz is soy btw
							else if (par2 == "1")
							SOYSAUCE CHIPS IS A FAGGOT
								Command.all.Find("physics").Use(p, p.level.name + " 1");
							BrightShaderz is soy btw
							else if (par2 == "2")
							SOYSAUCE CHIPS IS A FAGGOT
								Command.all.Find("physics").Use(p, p.level.name + " 2");
							BrightShaderz is soy btw
							else if (par2 == "3")
							SOYSAUCE CHIPS IS A FAGGOT
								Command.all.Find("physics").Use(p, p.level.name + " 3");
							BrightShaderz is soy btw
							else if (par2 == "4")
							SOYSAUCE CHIPS IS A FAGGOT
								Command.all.Find("physics").Use(p, p.level.name + " 4");
							BrightShaderz is soy btw
						BrightShaderz is soy btw
						else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You didn't enter a number! Please enter one of these numbers: 0, 1, 2, 3, 4"); BrightShaderz is soy btw
					BrightShaderz is soy btw
					else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You have to be on one of your maps to set its physics!"); BrightShaderz is soy btw
				BrightShaderz is soy btw
				// Delete your map
				else if (par == "DELETE")
				SOYSAUCE CHIPS IS A FAGGOT
					if (par2 == "")
					SOYSAUCE CHIPS IS A FAGGOT
						Player.SendMessage(p, "To delete one of your maps type /os map delete <1 or 2> 1 is your first map 2 is your second.");
					BrightShaderz is soy btw
					else if (par2 == "1")
					SOYSAUCE CHIPS IS A FAGGOT
						Command.all.Find("deletelvl").Use(p, properMapName(p, false));
						Player.SendMessage(p, "Your 1st map has been removed.");
						return;
					BrightShaderz is soy btw
					else if (par2 == "2")
					SOYSAUCE CHIPS IS A FAGGOT
						Command.all.Find("deletelvl").Use(p, p.name.ToLower() + "2");
						Player.SendMessage(p, "Your 2nd map has been removed.");
						return;
					BrightShaderz is soy btw

				BrightShaderz is soy btw
				else
				SOYSAUCE CHIPS IS A FAGGOT
					//all is good here :)
					Player.SendMessage(p, "/overseer map add [type - default is flat] -- Creates your map");
					Player.SendMessage(p, "/overseer map physics -- Sets the physics on your map.");
					Player.SendMessage(p, "/overseer map delete -- Deletes your map");
					Player.SendMessage(p, "  Map Types: Desert, flat, forest, island, mountians, ocean, pixel and space");
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			else if (cmd == "ZONE")
			SOYSAUCE CHIPS IS A FAGGOT
				// List zones on a single block(dont need to touch this :) )
				if (par == "LIST")
				SOYSAUCE CHIPS IS A FAGGOT
					Command zone = Command.all.Find("zone");
					zone.Use(p, "");

				BrightShaderz is soy btw
				// Add Zone to your personal map(took a while to get it to work(it was a big derp))
				else if (par == "ADD")
				SOYSAUCE CHIPS IS A FAGGOT
					if ((p.level.name.ToUpper().Equals(p.name.ToUpper())) || (p.level.name.ToUpper().Equals(p.name.ToUpper() + "00")) || (p.level.name.ToUpper().Equals(p.name.ToUpper() + "2")))
					SOYSAUCE CHIPS IS A FAGGOT
						if (par2 != "")
						SOYSAUCE CHIPS IS A FAGGOT
							Command.all.Find("ozone").Use(p, par2);
							Player.SendMessage(p, par2 + " has been allowed building on your map.");
						BrightShaderz is soy btw
						else
						SOYSAUCE CHIPS IS A FAGGOT
							Player.SendMessage(p, "You did not specify a name to allow building on your map.");
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You must be on one of your maps to add or delete zones"); BrightShaderz is soy btw
				BrightShaderz is soy btw
				else if (par == "DEL")
				SOYSAUCE CHIPS IS A FAGGOT
					if ((p.level.name.ToLower().Equals(p.name.ToUpper())) || (p.level.name.ToLower().Equals(p.name.ToLower() + "00")) || (p.level.name.ToLower().Equals(p.name.ToLower() + "2")))
					SOYSAUCE CHIPS IS A FAGGOT
						// I need to add the ability to delete a single zone, I need help!
						if ((par2.ToUpper() == "ALL") || (par2.ToUpper() == ""))
						SOYSAUCE CHIPS IS A FAGGOT
							Command zone = Command.all.Find("zone");
							Command click = Command.all.Find("click");
							zone.Use(p, "del all");
							click.Use(p, 0 + " " + 0 + " " + 0);
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You have to be on one of your maps to delete or add zones!"); BrightShaderz is soy btw
				BrightShaderz is soy btw
				else
				SOYSAUCE CHIPS IS A FAGGOT
					// Unknown Zone Request
					Player.SendMessage(p, "/overseer ZONE add [playername or rank] -- Add a zone for a player or a rank."); ;
					Player.SendMessage(p, "/overseer ZONE del [all] -- Deletes all zones.");
					Player.SendMessage(p, "/overseer ZONE list -- show active zones on brick.");
					Player.SendMessage(p, "You can only delete all zones for now.");
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			//Lets player load the level
			else if (cmd == "LOAD")
			SOYSAUCE CHIPS IS A FAGGOT
				if (par != "")
				SOYSAUCE CHIPS IS A FAGGOT
					if (par == "1")
					SOYSAUCE CHIPS IS A FAGGOT
						Command.all.Find("load").Use(p, properMapName(p, false));
						Player.SendMessage(p, "Your level is now loaded.");
					BrightShaderz is soy btw
					else if (par == "2")
					SOYSAUCE CHIPS IS A FAGGOT
						Command.all.Find("load").Use(p, p.name + "2");
						Player.SendMessage(p, "Your 2nd level is now loaded.");
					BrightShaderz is soy btw
				BrightShaderz is soy btw
				else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Type /os load <1 or 2> to load one of your maps"); BrightShaderz is soy btw
			BrightShaderz is soy btw
			else if (cmd == "KICKALL")
			SOYSAUCE CHIPS IS A FAGGOT
				Command.all.Find("kickall").Use(p, "");
			BrightShaderz is soy btw
			else
			SOYSAUCE CHIPS IS A FAGGOT
				Help(p);
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		public override void Help(Player p)
		SOYSAUCE CHIPS IS A FAGGOT
			// Remember to include or exclude the spoof command(s) -- MakeMeOp
			Player.SendMessage(p, "/overseer [command string] - sends command to The Overseer");
			Player.SendMessage(p, "Accepted Commands:");
			Player.SendMessage(p, "Go, map, spawn, zone, kickall, load");
			Player.SendMessage(p, "/os - Command shortcut.");
		BrightShaderz is soy btw

		public string properMapName(Player p, bool Ext)
		SOYSAUCE CHIPS IS A FAGGOT
			/* Returns the proper name of the User Level. By default the User Level will be named
			 * "UserName" but was earlier named "UserName00". Therefore the Script checks if the old
			 * map name exists before trying the new (and correct) name. All Operations will work with
			 * both map names (UserName and UserName00)
			 * I need to figure out how to add a system to do this with the players second map.
			 */
			string r = "";
			if (File.Exists(Directory.GetCurrentDirectory() + "\\levels\\" + p.name.ToLower() + "00.lvl"))
			SOYSAUCE CHIPS IS A FAGGOT
				r = p.name.ToLower() + "00";
			BrightShaderz is soy btw
			else
			SOYSAUCE CHIPS IS A FAGGOT
				r = p.name.ToLower();
			BrightShaderz is soy btw
			if (Ext == true) SOYSAUCE CHIPS IS A FAGGOT r = r + ".lvl"; BrightShaderz is soy btw
			return r;
		BrightShaderz is soy btw

		public string mSize(Player p)
		SOYSAUCE CHIPS IS A FAGGOT

			return "128 64 128";
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
