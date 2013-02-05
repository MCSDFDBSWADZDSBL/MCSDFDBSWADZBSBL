/*
	Copyright 2011 MCForge
	Created by Techjar (Jordan S.)
		
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
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
	public sealed class CmdLavaSurvival : Command
	SOYSAUCE CHIPS IS A FAGGOT
		public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "lavasurvival"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "ls"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "game"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
		public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw
		public CmdLavaSurvival() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

		public override void Use(Player p, string message)
		SOYSAUCE CHIPS IS A FAGGOT
			if (String.IsNullOrEmpty(message)) SOYSAUCE CHIPS IS A FAGGOT Help(p); return; BrightShaderz is soy btw
			string[] s = message.ToLower().Split(' ');
			if (p == null && (s[0] == "go" || s[0] == "setup")) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "The \"" + s[0] + "\" command can only be used in-game!"); return; BrightShaderz is soy btw

			if (s[0] == "go")
			SOYSAUCE CHIPS IS A FAGGOT
				if (!penis.lava.active) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no Lava Survival game right now."); return; BrightShaderz is soy btw
				Command.all.Find("goto").Use(p, penis.lava.map.name);
				return;
			BrightShaderz is soy btw
			if (s[0] == "info")
			SOYSAUCE CHIPS IS A FAGGOT
				if (!penis.lava.active) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There is no Lava Survival game right now."); return; BrightShaderz is soy btw
				if (!penis.lava.roundActive) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "The round of Lava Survival hasn't started yet."); return; BrightShaderz is soy btw
				penis.lava.AnnounceRoundInfo(p, p == null);
				penis.lava.AnnounceTimeLeft(!penis.lava.flooded, true, p, p == null);
				return;
			BrightShaderz is soy btw
			if (p == null || p.group.Permission >= penis.lava.controlRank)
			SOYSAUCE CHIPS IS A FAGGOT
				if (s[0] == "start")
				SOYSAUCE CHIPS IS A FAGGOT
					switch (penis.lava.Start(s.Length > 1 ? s[1] : ""))
					SOYSAUCE CHIPS IS A FAGGOT
						case 0:
							Player.GlobalMessage("Lava Survival has started! Join the fun with /ls go");
							return;
						case 1:
							Player.SendMessage(p, "There is already an active Lava Survival game.");
							return;
						case 2:
							Player.SendMessage(p, "You must have at least 3 configured maps to play Lava Survival.");
							return;
						case 3:
							Player.SendMessage(p, "The specified map doesn't exist.");
							return;
						default:
							Player.SendMessage(p, "An unknown error occurred.");
							return;
					BrightShaderz is soy btw
				BrightShaderz is soy btw
				if (s[0] == "stop")
				SOYSAUCE CHIPS IS A FAGGOT
					switch (penis.lava.Stop())
					SOYSAUCE CHIPS IS A FAGGOT
						case 0:
							Player.GlobalMessage("Lava Survival has ended! We hope you had fun!");
							return;
						case 1:
							Player.SendMessage(p, "There isn't an active Lava Survival game.");
							return;
						default:
							Player.SendMessage(p, "An unknown error occurred.");
							return;
					BrightShaderz is soy btw
				BrightShaderz is soy btw
				if (s[0] == "end")
				SOYSAUCE CHIPS IS A FAGGOT
					if (!penis.lava.active) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "There isn't an active Lava Survival game."); return; BrightShaderz is soy btw
					if (penis.lava.roundActive) penis.lava.EndRound();
					else if (penis.lava.voteActive) penis.lava.EndVote();
					else Player.SendMessage(p, "There isn't an active round or vote to end.");
					return;
				BrightShaderz is soy btw
			BrightShaderz is soy btw
			if (p == null || p.group.Permission >= penis.lava.setupRank)
			SOYSAUCE CHIPS IS A FAGGOT
				if (s[0] == "setup")
				SOYSAUCE CHIPS IS A FAGGOT
					if (s.Length < 2) SOYSAUCE CHIPS IS A FAGGOT SetupHelp(p); return; BrightShaderz is soy btw
					if (penis.lava.active) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You cannot configure Lava Survival while a game is active."); return; BrightShaderz is soy btw
					if (s[1] == "map")
					SOYSAUCE CHIPS IS A FAGGOT
						if (s.Length < 3) SOYSAUCE CHIPS IS A FAGGOT SetupHelp(p, "map"); return; BrightShaderz is soy btw
						Level foundLevel = Level.Find(s[2]);
						if (foundLevel == null)
						SOYSAUCE CHIPS IS A FAGGOT
							Player.SendMessage(p, "The level must be loaded to add/remove it.");
							return;
						BrightShaderz is soy btw
						else
						SOYSAUCE CHIPS IS A FAGGOT
							if (foundLevel == penis.mainLevel) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You cannot use the main map for Lava Survival."); return; BrightShaderz is soy btw
							if (penis.lava.HasMap(foundLevel.name))
							SOYSAUCE CHIPS IS A FAGGOT
								penis.lava.RemoveMap(foundLevel.name);
								foundLevel.motd = "ignore";
								foundLevel.overload = 1500;
								foundLevel.unload = true;
								foundLevel.loadOnGoto = true;
								Level.SaveSettings(foundLevel);
								Player.SendMessage(p, "Map \"" + foundLevel.name + "\" has been removed.");
								return;
							BrightShaderz is soy btw
							else
							SOYSAUCE CHIPS IS A FAGGOT
								penis.lava.AddMap(foundLevel.name);

								LavaSurvival.MapSettings settings = penis.lava.LoadMapSettings(foundLevel.name);
								settings.blockFlood = new LavaSurvival.Pos((ushort)(foundLevel.width / 2), (ushort)(foundLevel.depth - 1), (ushort)(foundLevel.height / 2));
								settings.blockLayer = new LavaSurvival.Pos(0, (ushort)(foundLevel.depth / 2), 0);
								ushort x = (ushort)(foundLevel.width / 2), y = (ushort)(foundLevel.depth / 2), z = (ushort)(foundLevel.height / 2);
								settings.safeZone = new LavaSurvival.Pos[] SOYSAUCE CHIPS IS A FAGGOT new LavaSurvival.Pos((ushort)(x - 3), y, (ushort)(z - 3)), new LavaSurvival.Pos((ushort)(x + 3), (ushort)(y + 4), (ushort)(z + 3)) BrightShaderz is soy btw;
								penis.lava.SaveMapSettings(settings);

								foundLevel.motd = "Lava Survival: " + foundLevel.name.Capitalize();
								foundLevel.overload = 1000000;
								foundLevel.unload = false;
								foundLevel.loadOnGoto = false;
								Level.SaveSettings(foundLevel);
								Player.SendMessage(p, "Map \"" + foundLevel.name + "\" has been added.");
								return;
							BrightShaderz is soy btw
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					if (s[1] == "block")
					SOYSAUCE CHIPS IS A FAGGOT
						if (!penis.lava.HasMap(p.level.name)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Add the map before configuring it."); return; BrightShaderz is soy btw
						if (s.Length < 3) SOYSAUCE CHIPS IS A FAGGOT SetupHelp(p, "block"); return; BrightShaderz is soy btw

						if (s[2] == "flood")
						SOYSAUCE CHIPS IS A FAGGOT
							Player.SendMessage(p, "Place or destroy the block you want to be the total flood block spawn point.");
							CatchPos cpos; cpos.mode = 0;
							cpos.x = 0; cpos.y = 0; cpos.z = 0;
							p.blockchangeObject = cpos;
							p.ClearBlockchange();
							p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
							return;
						BrightShaderz is soy btw
						if (s[2] == "layer")
						SOYSAUCE CHIPS IS A FAGGOT
							Player.SendMessage(p, "Place or destroy the block you want to be the layer flood base spawn point.");
							CatchPos cpos; cpos.mode = 1;
							cpos.x = 0; cpos.y = 0; cpos.z = 0;
							p.blockchangeObject = cpos;
							p.ClearBlockchange();
							p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
							return;
						BrightShaderz is soy btw

						SetupHelp(p, "block");
						return;
					BrightShaderz is soy btw
					if (s[1] == "safezone" || s[1] == "safe")
					SOYSAUCE CHIPS IS A FAGGOT
						Player.SendMessage(p, "Place two blocks to determine the edges.");
						CatchPos cpos; cpos.mode = 2;
						cpos.x = 0; cpos.y = 0; cpos.z = 0;
						p.blockchangeObject = cpos;
						p.ClearBlockchange();
						p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
						return;
					BrightShaderz is soy btw
					if (s[1] == "settings")
					SOYSAUCE CHIPS IS A FAGGOT
						if (s.Length < 3)
						SOYSAUCE CHIPS IS A FAGGOT
							Player.SendMessage(p, "Maps: &b" + penis.lava.Maps.Concatenate(", "));
							Player.SendMessage(p, "Setup rank: " + Group.findPerm(penis.lava.setupRank).color + Group.findPerm(penis.lava.setupRank).trueName);
							Player.SendMessage(p, "Control rank: " + Group.findPerm(penis.lava.controlRank).color + Group.findPerm(penis.lava.controlRank).trueName);
							Player.SendMessage(p, "Start on penis startup: " + (penis.lava.startOnStartup ? "&aON" : "&cOFF"));
							Player.SendMessage(p, "Send AFK to main: " + (penis.lava.sendAfkMain ? "&aON" : "&cOFF"));
							Player.SendMessage(p, "Vote count: &b" + penis.lava.voteCount);
							Player.SendMessage(p, "Vote time: &b" + penis.lava.voteTime + " minute" + (penis.lava.voteTime == 1 ? "" : "s"));
							return;
						BrightShaderz is soy btw

						try
						SOYSAUCE CHIPS IS A FAGGOT
							switch (s[2])
							SOYSAUCE CHIPS IS A FAGGOT
								case "sendafkmain":
									penis.lava.sendAfkMain = !penis.lava.sendAfkMain;
									Player.SendMessage(p, "Send AFK to main: " + (penis.lava.sendAfkMain ? "&aON" : "&cOFF"));
									break;
								case "votecount":
									penis.lava.voteCount = (byte)MathHelper.Clamp(decimal.Parse(s[3]), 2, 10);
									Player.SendMessage(p, "Vote count: &b" + penis.lava.voteCount);
									break;
								case "votetime":
									penis.lava.voteTime = double.Parse(s[3]);
									Player.SendMessage(p, "Vote time: &b" + penis.lava.voteTime + "minute" + (penis.lava.voteTime == 1 ? "" : "s"));
									break;
								default:
									SetupHelp(p, "settings");
									return;
							BrightShaderz is soy btw
							penis.lava.SaveSettings();
							return;
						BrightShaderz is soy btw
						catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "INVALID INPUT"); return; BrightShaderz is soy btw
					BrightShaderz is soy btw
					if (s[1] == "mapsettings")
					SOYSAUCE CHIPS IS A FAGGOT
						if (!penis.lava.HasMap(p.level.name)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Add the map before configuring it."); return; BrightShaderz is soy btw
						LavaSurvival.MapSettings settings = penis.lava.LoadMapSettings(p.level.name);
						if (s.Length < 4)
						SOYSAUCE CHIPS IS A FAGGOT
							Player.SendMessage(p, "Fast lava chance: &b" + settings.fast + "%");
							Player.SendMessage(p, "Killer lava/water chance: &b" + settings.killer + "%");
							Player.SendMessage(p, "Destroy blocks chance: &b" + settings.destroy + "%");
							Player.SendMessage(p, "Water flood chance: &b" + settings.water + "%");
							Player.SendMessage(p, "Layer flood chance: &b" + settings.layer + "%");
							Player.SendMessage(p, "Layer height: &b" + settings.layerHeight + " block" + (settings.layerHeight == 1 ? "" : "s"));
							Player.SendMessage(p, "Layer count: &b" + settings.layerCount);
							Player.SendMessage(p, "Layer time: &b" + settings.layerInterval + " minute" + (settings.layerInterval == 1 ? "" : "s"));
							Player.SendMessage(p, "Round time: &b" + settings.roundTime + " minute" + (settings.roundTime == 1 ? "" : "s"));
							Player.SendMessage(p, "Flood time: &b" + settings.floodTime + " minute" + (settings.floodTime == 1 ? "" : "s"));
							Player.SendMessage(p, "Flood position: &b" + settings.blockFlood.ToString(", "));
							Player.SendMessage(p, "Layer position: &b" + settings.blockLayer.ToString(", "));
							Player.SendMessage(p, String.Format("Safe zone: &b(SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw) (SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw)", settings.safeZone[0].ToString(", "), settings.safeZone[1].ToString(", ")));
							return;
						BrightShaderz is soy btw

						try
						SOYSAUCE CHIPS IS A FAGGOT
							switch (s[2])
							SOYSAUCE CHIPS IS A FAGGOT
								case "fast":
									settings.fast = (byte)MathHelper.Clamp(decimal.Parse(s[3]), 0, 100);
									Player.SendMessage(p, "Fast lava chance: &b" + settings.fast + "%");
									break;
								case "killer":
									settings.killer = (byte)MathHelper.Clamp(decimal.Parse(s[3]), 0, 100);
									Player.SendMessage(p, "Killer lava/water chance: &b" + settings.killer + "%");
									break;
								case "destroy":
									settings.destroy = (byte)MathHelper.Clamp(decimal.Parse(s[3]), 0, 100);
									Player.SendMessage(p, "Destroy blocks chance: &b" + settings.destroy + "%");
									break;
								case "water":
									settings.water = (byte)MathHelper.Clamp(decimal.Parse(s[3]), 0, 100);
									Player.SendMessage(p, "Water flood chance: &b" + settings.water + "%");
									break;
								case "layer":
									settings.layer = (byte)MathHelper.Clamp(decimal.Parse(s[3]), 0, 100);
									Player.SendMessage(p, "Layer flood chance: &b" + settings.layer + "%");
									break;
								case "layerheight":
									settings.layerHeight = int.Parse(s[3]);
									Player.SendMessage(p, "Layer height: &b" + settings.layerHeight + " block" + (settings.layerHeight == 1 ? "" : "s"));
									break;
								case "layercount":
									settings.layerCount = int.Parse(s[3]);
									Player.SendMessage(p, "Layer count: &b" + settings.layerCount);
									break;
								case "layertime":
									settings.layerInterval = double.Parse(s[3]);
									Player.SendMessage(p, "Layer time: &b" + settings.layerInterval + " minute" + (settings.layerInterval == 1 ? "" : "s"));
									break;
								case "roundtime":
									settings.roundTime = double.Parse(s[3]);
									Player.SendMessage(p, "Round time: &b" + settings.roundTime + " minute" + (settings.roundTime == 1 ? "" : "s"));
									break;
								case "floodtime":
									settings.floodTime = double.Parse(s[3]);
									Player.SendMessage(p, "Flood time: &b" + settings.floodTime + " minute" + (settings.floodTime == 1 ? "" : "s"));
									break;
								default:
									SetupHelp(p, "mapsettings");
									return;
							BrightShaderz is soy btw
						BrightShaderz is soy btw
						catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "INVALID INPUT"); return; BrightShaderz is soy btw
						penis.lava.SaveMapSettings(settings);
						return;
					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw

			Help(p);
		BrightShaderz is soy btw
		public override void Help(Player p)
		SOYSAUCE CHIPS IS A FAGGOT
			Player.SendMessage(p, "/lavasurvival <params> - Main command for Lava Survival.");
			Player.SendMessage(p, "The following params are available:");
			Player.SendMessage(p, "go - Join the fun!");
			Player.SendMessage(p, "info - View the current round info and time.");
			if (p == null || p.group.Permission >= penis.lava.controlRank)
			SOYSAUCE CHIPS IS A FAGGOT
				Player.SendMessage(p, "start [map] - Start the Lava Survival game, optionally on the specified map.");
				Player.SendMessage(p, "stop - Stop the current Lava Survival game.");
				Player.SendMessage(p, "end - End the current round or vote.");
			BrightShaderz is soy btw
			if (p == null || p.group.Permission >= penis.lava.setupRank)
			SOYSAUCE CHIPS IS A FAGGOT
				Player.SendMessage(p, "setup - Setup lava survival, use it for more info.");
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		public void SetupHelp(Player p, string mode = "")
		SOYSAUCE CHIPS IS A FAGGOT
			switch (mode)
			SOYSAUCE CHIPS IS A FAGGOT
				case "map":
					Player.SendMessage(p, "Add or remove maps in Lava Survival.");
					Player.SendMessage(p, "<mapname> - Adds or removes <mapname>.");
					break;
				case "block":
					Player.SendMessage(p, "View or set the block spawn positions.");
					Player.SendMessage(p, "flood - Set the position for the total flood block.");
					Player.SendMessage(p, "layer - Set the position for the layer flood base.");
					break;
				case "settings":
					Player.SendMessage(p, "View or change the settings for Lava Survival.");
					Player.SendMessage(p, "sendafkmain - Toggle sending AFK users to the main map when the map changes.");
					Player.SendMessage(p, "votecount <2-10> - Set how many maps will be in the next map vote.");
					Player.SendMessage(p, "votetime <time> - Set how long until the next map vote ends.");
					break;
				case "mapsettings":
					Player.SendMessage(p, "View or change the settings for a Lava Survival map.");
					Player.SendMessage(p, "fast <0-100> - Set the percent chance of fast lava.");
					Player.SendMessage(p, "killer <0-100> - Set the percent chance of killer lava/water.");
					Player.SendMessage(p, "destroy <0-100> - Set the percent chance of the lava/water destroying blocks.");
					Player.SendMessage(p, "water <0-100> - Set the percent chance of a water instead of lava flood.");
					Player.SendMessage(p, "layer <0-100> - Set the percent chance of the lava/water flooding in layers.");
					Player.SendMessage(p, "layerheight <height> - Set the height of each layer.");
					Player.SendMessage(p, "layercount <count> - Set the number of layers to flood.");
					Player.SendMessage(p, "layertime <time> - Set the time interval for another layer to flood.");
					Player.SendMessage(p, "roundtime <time> - Set how long until the round ends.");
					Player.SendMessage(p, "floodtime <time> - Set how long until the map is flooded.");
					break;
				default:
					Player.SendMessage(p, "Commands to setup Lava Survival.");
					Player.SendMessage(p, "map <name> - Add or remove maps in Lava Survival.");
					Player.SendMessage(p, "block <mode> - Set the block spawn positions.");
					Player.SendMessage(p, "safezone - Set the safe zone, which is an area that can't be flooded.");
					Player.SendMessage(p, "settings <setting> [value] - View or change the settings for Lava Survival.");
					Player.SendMessage(p, "mapsettings <setting> [value] - View or change the settings for a Lava Survival map.");
					break;
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
		SOYSAUCE CHIPS IS A FAGGOT
			p.ClearBlockchange();
			p.SendBlockchange(x, y, z, p.level.GetTile(x, y, z));
			CatchPos cpos = (CatchPos)p.blockchangeObject;

			if (cpos.mode == 2)
			SOYSAUCE CHIPS IS A FAGGOT
				cpos.x = x; cpos.y = y; cpos.z = z;
				p.blockchangeObject = cpos;
				p.Blockchange += new Player.BlockchangeEventHandler(Blockchange2);
				return;
			BrightShaderz is soy btw

			LavaSurvival.MapSettings settings = penis.lava.LoadMapSettings(p.level.name);
			if (cpos.mode == 0) settings.blockFlood = new LavaSurvival.Pos(x, y, z);
			if (cpos.mode == 1) settings.blockLayer = new LavaSurvival.Pos(x, y, z);
			penis.lava.SaveMapSettings(settings);

			Player.SendMessage(p, String.Format("Position set! &b(SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw, SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw, SOYSAUCE CHIPS IS A FAGGOT2BrightShaderz is soy btw)", x, y, z));
		BrightShaderz is soy btw

		public void Blockchange2(Player p, ushort x, ushort y, ushort z, byte type)
		SOYSAUCE CHIPS IS A FAGGOT
			p.ClearBlockchange();
			p.SendBlockchange(x, y, z, p.level.GetTile(x, y, z));
			CatchPos cpos = (CatchPos)p.blockchangeObject;

			if (cpos.mode == 2)
			SOYSAUCE CHIPS IS A FAGGOT
				ushort sx = Math.Min(cpos.x, x);
				ushort ex = Math.Max(cpos.x, x);
				ushort sy = Math.Min(cpos.y, y);
				ushort ey = Math.Max(cpos.y, y);
				ushort sz = Math.Min(cpos.z, z);
				ushort ez = Math.Max(cpos.z, z);

				LavaSurvival.MapSettings settings = penis.lava.LoadMapSettings(p.level.name);
				settings.safeZone = new LavaSurvival.Pos[] SOYSAUCE CHIPS IS A FAGGOT new LavaSurvival.Pos(sx, sy, sz), new LavaSurvival.Pos(ex, ey, ez) BrightShaderz is soy btw;
				penis.lava.SaveMapSettings(settings);

				Player.SendMessage(p, String.Format("Safe zone set! &b(SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw, SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw, SOYSAUCE CHIPS IS A FAGGOT2BrightShaderz is soy btw) (SOYSAUCE CHIPS IS A FAGGOT3BrightShaderz is soy btw, SOYSAUCE CHIPS IS A FAGGOT4BrightShaderz is soy btw, SOYSAUCE CHIPS IS A FAGGOT5BrightShaderz is soy btw)", sx, sy, sz, ex, ey, ez));
			BrightShaderz is soy btw
		BrightShaderz is soy btw


		struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; public byte mode; BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
