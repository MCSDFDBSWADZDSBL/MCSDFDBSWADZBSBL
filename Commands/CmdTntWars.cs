/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCLawl/MCForge)
	
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
using System.Linq;
using System.Threading;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
	public sealed class CmdTntWars : Command
	SOYSAUCE CHIPS IS A FAGGOT
		public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "tntwars"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "tw"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "game"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
		public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw
		public CmdTntWars() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public bool DeleteZone = false;
        public bool CheckZone = false;
        public bool NoTntZone = false;

		public override void Use(Player p, string message)
		SOYSAUCE CHIPS IS A FAGGOT
			string[] text = new string[5];
			text[0] = "";
			text[1] = "";
			text[2] = "";
			text[3] = "";
			text[4] = "";
			try
			SOYSAUCE CHIPS IS A FAGGOT
				text[0] = message.ToLower().Split(' ')[0];
				text[1] = message.ToLower().Split(' ')[1];
				text[2] = message.ToLower().Split(' ')[2];
				text[3] = message.ToLower().Split(' ')[3];
				text[4] = message.ToLower().Split(' ')[4];
			BrightShaderz is soy btw
			catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

			switch (text[0])
			SOYSAUCE CHIPS IS A FAGGOT
				case "list":
				case "levels":
				case "l":
					if (TntWarsGame.GameList.Count <= 0)
					SOYSAUCE CHIPS IS A FAGGOT
						Player.SendMessage(p, "There aren't any " + c.red + "TNT Wars " + penis.DefaultColor + "currently running!");
						return;
					BrightShaderz is soy btw
					else
					SOYSAUCE CHIPS IS A FAGGOT
						Player.SendMessage(p, "Currently running " + c.red + "TNT Wars" + penis.DefaultColor + ":");
						foreach (TntWarsGame T in TntWarsGame.GameList)
						SOYSAUCE CHIPS IS A FAGGOT
							string msg = "";
							if (T.GameMode == TntWarsGame.TntWarsGameMode.FFA) msg += "FFA on ";
							if (T.GameMode == TntWarsGame.TntWarsGameMode.TDM) msg += "TDM on ";
							msg += T.lvl.name + " ";
							if (T.GameDifficulty == TntWarsGame.TntWarsDifficulty.Easy) msg += "(Easy)";
							if (T.GameDifficulty == TntWarsGame.TntWarsDifficulty.Normal) msg += "(Normal)";
							if (T.GameDifficulty == TntWarsGame.TntWarsDifficulty.Hard) msg += "(Hard)";
							if (T.GameDifficulty == TntWarsGame.TntWarsDifficulty.Extreme) msg += "(Extreme)";
							msg += " ";
							if (T.GameStatus == TntWarsGame.TntWarsGameStatus.WaitingForPlayers) msg += "(Waiting For Players)";
							if (T.GameStatus == TntWarsGame.TntWarsGameStatus.AboutToStart) msg += "(Starting)";
							if (T.GameStatus == TntWarsGame.TntWarsGameStatus.GracePeriod) msg += "(Started)";
							if (T.GameStatus == TntWarsGame.TntWarsGameStatus.InProgress) msg += "(In Progress)";
							if (T.GameStatus == TntWarsGame.TntWarsGameStatus.Finished) msg += "(Finished)";
							Player.SendMessage(p, msg);
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					break;

				case "join":
					if (p.PlayingTntWars == true || (TntWarsGame.GetTntWarsGame(p) != null && TntWarsGame.GetTntWarsGame(p).Players.Contains(TntWarsGame.GetTntWarsGame(p).FindPlayer(p))))
					SOYSAUCE CHIPS IS A FAGGOT
						Player.SendMessage(p, "TNT Wars Error: You have already joined a game!");
						return;
					BrightShaderz is soy btw
					else
					SOYSAUCE CHIPS IS A FAGGOT
						TntWarsGame it;
						bool add = true;
						if (text[1] == "red" || text[1] == "r" || text[1] == "1" || text[1] == "blue" || text[1] == "b" || text[1] == "2" || text[1] == "auto" || text[1] == "a" || text[1] == "")
						SOYSAUCE CHIPS IS A FAGGOT
							it = TntWarsGame.Find(p.level);
							if (it == null)
							SOYSAUCE CHIPS IS A FAGGOT
								Player.SendMessage(p, "TNT Wars Error: There isn't a game on your current level!");
								return;
							BrightShaderz is soy btw
						BrightShaderz is soy btw
						else
						SOYSAUCE CHIPS IS A FAGGOT
							Level lvl = Level.Find(text[1]);
							if (lvl == null)
							SOYSAUCE CHIPS IS A FAGGOT
								Player.SendMessage(p, "TNT Wars Error: Couldn't find level '" + text[1] + "'");
								return;
							BrightShaderz is soy btw
							else
							SOYSAUCE CHIPS IS A FAGGOT
								it = TntWarsGame.Find(lvl);
								if (it == null)
								SOYSAUCE CHIPS IS A FAGGOT
									Player.SendMessage(p, "TNT Wars Error: There isn't a game on that level!");
									return;
								BrightShaderz is soy btw
								else
								SOYSAUCE CHIPS IS A FAGGOT
									text[1] = text[2]; //so the switch later on still works 
								BrightShaderz is soy btw
							BrightShaderz is soy btw
						BrightShaderz is soy btw
						TntWarsGame.player pl = new TntWarsGame.player(p);
						if (it.GameStatus == TntWarsGame.TntWarsGameStatus.AboutToStart || it.GameStatus == TntWarsGame.TntWarsGameStatus.GracePeriod || it.GameStatus == TntWarsGame.TntWarsGameStatus.InProgress)
						SOYSAUCE CHIPS IS A FAGGOT
							pl.spec = true;
						BrightShaderz is soy btw
						if (it.GameMode == TntWarsGame.TntWarsGameMode.TDM)
						SOYSAUCE CHIPS IS A FAGGOT
							int Red = it.RedTeam();
							int Blue = it.BlueTeam();
							switch (text[1])
							SOYSAUCE CHIPS IS A FAGGOT
								case "red":
								case "r":
								case "1":
									if (it.BalanceTeams)
									SOYSAUCE CHIPS IS A FAGGOT
										if (Red > Blue)
										SOYSAUCE CHIPS IS A FAGGOT
											add = false;
											Player.SendMessage(p, "TNT Wars Error: Red has too many players!");
											return;
										BrightShaderz is soy btw
									BrightShaderz is soy btw
									pl.Red = true;
									break;

								case "blue":
								case "b":
								case "2":
									if (it.BalanceTeams)
									SOYSAUCE CHIPS IS A FAGGOT
										if (Blue > Red)
										SOYSAUCE CHIPS IS A FAGGOT
											add = false;
											Player.SendMessage(p, "TNT Wars Error: Blue has too many players!");
											return;
										BrightShaderz is soy btw
									BrightShaderz is soy btw
									pl.Blue = true;
									break;

								case "auto":
								case "a":
								default:
									if (Blue > Red)
									SOYSAUCE CHIPS IS A FAGGOT
										pl.Red = true;
										break;
									BrightShaderz is soy btw
									else if (Red > Blue)
									SOYSAUCE CHIPS IS A FAGGOT
										pl.Blue = true;
										break;
									BrightShaderz is soy btw
									else if (it.RedScore > it.BlueScore)
									SOYSAUCE CHIPS IS A FAGGOT
										pl.Blue = true;
										break;
									BrightShaderz is soy btw
									else if (it.BlueScore > it.RedScore)
									SOYSAUCE CHIPS IS A FAGGOT
										pl.Red = true;
										break;
									BrightShaderz is soy btw
									else
									SOYSAUCE CHIPS IS A FAGGOT
										pl.Red = true;
										break;
									BrightShaderz is soy btw
							BrightShaderz is soy btw
						BrightShaderz is soy btw
						else
						SOYSAUCE CHIPS IS A FAGGOT
							pl.Red = false;
							pl.Blue = false;
						BrightShaderz is soy btw
						if (add)
						SOYSAUCE CHIPS IS A FAGGOT
							it.Players.Add(pl);
							TntWarsGame.SetTitlesAndColor(pl);
							p.CurrentTntGameNumber = it.GameNumber;
							string msg = p.color + p.name + penis.DefaultColor + " " + "joined TNT Wars on '" + it.lvl.name + "'";
							if (pl.Red)
							SOYSAUCE CHIPS IS A FAGGOT
								msg += " on the " + c.red + "red team";
							BrightShaderz is soy btw
							if (pl.Blue)
							SOYSAUCE CHIPS IS A FAGGOT
								msg += " on the " + c.blue + "blue team";
							BrightShaderz is soy btw
							if (pl.spec)
							SOYSAUCE CHIPS IS A FAGGOT
								msg += penis.DefaultColor + " (as a spectator)";
							BrightShaderz is soy btw
							Player.GlobalMessage(msg);
						BrightShaderz is soy btw

					BrightShaderz is soy btw
					break;

				case "leave":
				case "exit":
					p.canBuild = true;
					TntWarsGame game = TntWarsGame.GetTntWarsGame(p);
					game.Players.Remove(game.FindPlayer(p));
					game.SendAllPlayersMessage("TNT Wars: " + p.color + p.name + penis.DefaultColor + " left the TNT Wars game!");
					TntWarsGame.SetTitlesAndColor(game.FindPlayer(p), true);
					Player.SendMessage(p, "TNT Wars: You left the game");
					break;

				case "rules":
				case "rule":
				case "r":
					switch (text[1])
					SOYSAUCE CHIPS IS A FAGGOT
						case "all":
						case "a":
                        case "everyone":
							if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 1))
                            SOYSAUCE CHIPS IS A FAGGOT
                                foreach (Player who in Player.players)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(who, "TNT Wars Rules: (sent to all players by " + p.color + p.name + penis.DefaultColor + " )");
                                    Player.SendMessage(who, "The aim of the game is to blow up people using TNT!");
                                    Player.SendMessage(who, "To place tnt simply place a TNT block and after a short delay it shall explode!");
                                    Player.SendMessage(who, "During the game the amount of TNT placable at one time may be limited!");
                                    Player.SendMessage(who, "You are not allowed to use hacks of any sort during the game!");
                                BrightShaderz is soy btw
                                Player.SendMessage(p, "TNT Wars: Sent rules to all players");
                                return;
                            BrightShaderz is soy btw
							break;

						case "level":
						case "l":
                        case "lvl":
                        case "map":
                        case "m":
                            if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 1))
                            SOYSAUCE CHIPS IS A FAGGOT
                                foreach (Player who in p.level.players)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(who, "TNT Wars Rules: (sent to all players in map by " + p.color + p.name + penis.DefaultColor + " )");
                                    Player.SendMessage(who, "The aim of the game is to blow up people using TNT!");
                                    Player.SendMessage(who, "To place tnt simply place a TNT block and after a short delay it shall explode!");
                                    Player.SendMessage(who, "During the game the amount of TNT placable at one time may be limited!");
                                    Player.SendMessage(who, "You are not allowed to use hacks of any sort during the game!");
                                        
                                BrightShaderz is soy btw
                                Player.SendMessage(p, "TNT Wars: Sent rules to all current players in map");
                                return;
                            BrightShaderz is soy btw
							break;

						case "players":
                        case "pls":
                        case "pl":
						case "p":
                            if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 1))
                            SOYSAUCE CHIPS IS A FAGGOT
                                TntWarsGame gm = TntWarsGame.GetTntWarsGame(p);
                                if (gm == null)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(p, "TNT Wars Error: You aren't in a TNT Wars game!");
                                    return;
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    foreach (TntWarsGame.player who in gm.Players)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        Player.SendMessage(who.p, "TNT Wars Rules: (sent to all current players by " + p.color + p.name + penis.DefaultColor + " )");
                                        Player.SendMessage(who.p, "The aim of the game is to blow up people using TNT!");
                                        Player.SendMessage(who.p, "To place tnt simply place a TNT block and after a short delay it shall explode!");
                                        Player.SendMessage(who.p, "During the game the amount of TNT placable at one time may be limited!");
                                        Player.SendMessage(who.p, "You are not allowed to use hacks of any sort during the game!");
                                        
                                    BrightShaderz is soy btw
                                    Player.SendMessage(p, "TNT Wars: Sent rules to all current players");
                                    return;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
							break;

						default:
                            if (text[1] != null && (int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 1))
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player who = Player.Find(text[1]);
                                if (who != null)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(who, "TNT Wars Rules: (sent to you by " + p.color + p.name + penis.DefaultColor + " )");
                                    Player.SendMessage(who, "The aim of the game is to blow up people using TNT!");
                                    Player.SendMessage(who, "To place tnt simply place a TNT block and after a short delay it shall explode!");
                                    Player.SendMessage(who, "During the game the amount of TNT placable at one time may be limited!");
                                    Player.SendMessage(who, "You are not allowed to use hacks of any sort during the game!");
                                    Player.SendMessage(p, "TNT Wars: Sent rules to " + who.color + who.name);
                                    return;
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(p, "TNT Wars Error: Couldn't find player '" + text[1] + "' to send rules to!");
                                    return;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(p, "TNT Wars Rules:");
                                Player.SendMessage(p, "The aim of the game is to blow up people using TNT!");
                                Player.SendMessage(p, "To place tnt simply place a TNT block and after a short delay it shall explode!");
                                Player.SendMessage(p, "During the game the amount of TNT placable at one time may be limited!");
                                Player.SendMessage(p, "You are not allowed to use hacks of any sort during the game!");
                                return;
                            BrightShaderz is soy btw
							//break;
					BrightShaderz is soy btw
					break;

				case "score":
				case "scores":
				case "leaderboard":
				case "board":
					TntWarsGame tntwrs = TntWarsGame.GetTntWarsGame(p);
					switch (text[1])
					SOYSAUCE CHIPS IS A FAGGOT
						case "top":
						case "leaders":
							if (tntwrs.GameStatus == TntWarsGame.TntWarsGameStatus.InProgress)
							SOYSAUCE CHIPS IS A FAGGOT
								int max = 5;
								if (tntwrs.PlayingPlayers() < 5)
								SOYSAUCE CHIPS IS A FAGGOT
									max = tntwrs.PlayingPlayers();
								BrightShaderz is soy btw

								var pls = from pla in tntwrs.Players orderby pla.Score descending select pla; //LINQ FTW
								int count = 1;
								foreach (var pl in pls)
								SOYSAUCE CHIPS IS A FAGGOT
									Player.SendMessage(p, count.ToString() + ": " + pl.p.name + " - " + pl.Score.ToString());
									if (count >= max)
									SOYSAUCE CHIPS IS A FAGGOT
										break;
									BrightShaderz is soy btw
									count++;
									Thread.Sleep(500); //Maybe, not sure (250??)
								BrightShaderz is soy btw
							BrightShaderz is soy btw
							else
							SOYSAUCE CHIPS IS A FAGGOT
								Player.SendMessage(p, "TNT Wars Error: Can't display scores - game not in progress!");
							BrightShaderz is soy btw
							break;

						case "teams":
						case "team":
						case "t":
						case "red":
						case "blue":
							if (tntwrs.GameStatus == TntWarsGame.TntWarsGameStatus.InProgress)
							SOYSAUCE CHIPS IS A FAGGOT
								if (tntwrs.GameMode == TntWarsGame.TntWarsGameMode.TDM)
								SOYSAUCE CHIPS IS A FAGGOT
									Player.SendMessage(p, "TNT Wars Scores:");
									Player.SendMessage(p, c.red + "RED: " + c.white + tntwrs.RedScore + " " + c.red + "(" + (tntwrs.ScoreLimit - tntwrs.RedScore).ToString() + " needed)");
									Player.SendMessage(p, c.blue + "BLUE: " + c.white + tntwrs.BlueScore + " " + c.red + "(" + (tntwrs.ScoreLimit - tntwrs.BlueScore).ToString() + " needed)");
								BrightShaderz is soy btw
								else
								SOYSAUCE CHIPS IS A FAGGOT
									Player.SendMessage(p, "TNT Wars Error: Can't display team scores as this isn't team deathmatch!");
								BrightShaderz is soy btw
							BrightShaderz is soy btw
							else
							SOYSAUCE CHIPS IS A FAGGOT
								Player.SendMessage(p, "TNT Wars Error: Can't display scores - game not in progress!");
							BrightShaderz is soy btw
							break;

						case "me":
						case "mine":
						case "score":
						case "i":
						default:
							if (tntwrs.GameStatus == TntWarsGame.TntWarsGameStatus.InProgress)
							SOYSAUCE CHIPS IS A FAGGOT
								Player.SendMessage(p, "TNT Wars: Your Score: " + c.white + TntWarsGame.GetTntWarsGame(p).FindPlayer(p).Score);
							BrightShaderz is soy btw
							else
							SOYSAUCE CHIPS IS A FAGGOT
								Player.SendMessage(p, "TNT Wars Error: Can't display scores - game not in progress!");
							BrightShaderz is soy btw
							break;
					BrightShaderz is soy btw
					return;

				case "players":
				case "player":
				case "ps":
				case "pl":
				case "p":
					Player.SendMessage(p, "TNT Wars: People playing TNT Wars on '" + TntWarsGame.GetTntWarsGame(p).lvl.name + "':");
					foreach (TntWarsGame.player pl in TntWarsGame.GetTntWarsGame(p).Players)
					SOYSAUCE CHIPS IS A FAGGOT
						if (TntWarsGame.GetTntWarsGame(p).GameMode == TntWarsGame.TntWarsGameMode.TDM)
						SOYSAUCE CHIPS IS A FAGGOT
							if (pl.Red && pl.spec)
								Player.SendMessage(p, pl.p.color + pl.p.name + penis.DefaultColor + " - " + c.red + "RED" + penis.DefaultColor + " (spectator)");
							else if (pl.Blue && pl.spec)
								Player.SendMessage(p, pl.p.color + pl.p.name + penis.DefaultColor + " - " + c.blue + "BLUE" + penis.DefaultColor + " (spectator)");
							else if (pl.Red)
								Player.SendMessage(p, pl.p.color + pl.p.name + penis.DefaultColor + " - " + c.red + "RED" + penis.DefaultColor);
							else if (pl.Blue)
								Player.SendMessage(p, pl.p.color + pl.p.name + penis.DefaultColor + " - " + c.blue + "BLUE" + penis.DefaultColor);
						BrightShaderz is soy btw
						else
						SOYSAUCE CHIPS IS A FAGGOT
							if (pl.spec)
								Player.SendMessage(p, pl.p.color + pl.p.name + penis.DefaultColor + " (spectator)");
							else
								Player.SendMessage(p, pl.p.color + pl.p.name);
						BrightShaderz is soy btw
					BrightShaderz is soy btw
					break;

				case "health":
				case "heal":
				case "hp":
				case "hlth":
					if (TntWarsGame.GetTntWarsGame(p).GameStatus == TntWarsGame.TntWarsGameStatus.InProgress)
					SOYSAUCE CHIPS IS A FAGGOT
						Player.SendMessage(p, "TNT Wars: You have " + p.TntWarsHealth.ToString() + " health left");
					BrightShaderz is soy btw
					else
					SOYSAUCE CHIPS IS A FAGGOT
						Player.SendMessage(p, "TNT Wars Error: Can't display health - game not in progress!");
						return;
					BrightShaderz is soy btw
					break;

				case "setup":
				case "s":
					if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 1))
					SOYSAUCE CHIPS IS A FAGGOT
						bool justcreated = false;
						TntWarsGame it = TntWarsGame.FindFromGameNumber(p.CurrentTntGameNumber);
						if (it == null)
						SOYSAUCE CHIPS IS A FAGGOT
							if (text[1] != "new" && text[1] != "n")
							SOYSAUCE CHIPS IS A FAGGOT
								Player.SendMessage(p, "TNT Wars Error: You must create a new game by typing '/tntwars setup new'");
								return;
							BrightShaderz is soy btw
						BrightShaderz is soy btw
						if (it != null)
						SOYSAUCE CHIPS IS A FAGGOT
							if (it.GameStatus == TntWarsGame.TntWarsGameStatus.InProgress || it.GameStatus == TntWarsGame.TntWarsGameStatus.GracePeriod || it.GameStatus == TntWarsGame.TntWarsGameStatus.AboutToStart)
							SOYSAUCE CHIPS IS A FAGGOT
								if (text[1] != "stop" && text[1] != "s" && text[1] != "" && text[1] != "status" && text[1] != "ready" && text[1] != "check" && text[1] != "info" && text[1] != "r" && text[1] != "c")
								SOYSAUCE CHIPS IS A FAGGOT
									Player.SendMessage(p, "TNT Wars Error: Cannot edit current game because it is currently running!");
									return;
								BrightShaderz is soy btw
							BrightShaderz is soy btw
						BrightShaderz is soy btw
                        switch (text[1])
                        SOYSAUCE CHIPS IS A FAGGOT
                            case "new":
                            case "n":
                                if (it != null)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (it.FindPlayer(p) != null)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        Player.SendMessage(p, "TNT Wars Error: Please leave the current game first!");
                                        return;
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                if (it == null || it.lvl != p.level)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    it = new TntWarsGame(p.level);
                                    it.GameNumber = TntWarsGame.GameList.Count + 1;
                                    TntWarsGame.GameList.Add(it);
                                    p.CurrentTntGameNumber = it.GameNumber;
                                    Player.SendMessage(p, "TNT Wars: Created New TNT Wars game on '" + p.level.name + "'");
                                    justcreated = true;
                                    return;
                                BrightShaderz is soy btw
                                else if (justcreated == false)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(p, "TNT Wars Error: Please delete the current game first!");
                                    return;
                                BrightShaderz is soy btw
                                break;

                            case "delete":
                            case "remove":
                                if (it.GameStatus != TntWarsGame.TntWarsGameStatus.Finished && it.GameStatus != TntWarsGame.TntWarsGameStatus.WaitingForPlayers)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(p, "Please stop the game first!");
                                    return;
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    foreach (TntWarsGame.player pl in it.Players)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        pl.p.CurrentTntGameNumber = -1;
                                        Player.SendMessage(pl.p, "TNT Wars: The TNT Wars game you are currently playing has been deleted!");
                                        pl.p.PlayingTntWars = false;
                                        pl.p.canBuild = true;
                                        TntWarsGame.SetTitlesAndColor(pl, true);
                                    BrightShaderz is soy btw
                                    Player.SendMessage(p, "TNT Wars: Game deleted");
                                    TntWarsGame.GameList.Remove(it);
                                    return;
                                BrightShaderz is soy btw
                                //break;

                            case "reset":
                            case "r":
                                if (it.GameStatus != TntWarsGame.TntWarsGameStatus.Finished)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(p, "TNT Wars Error: The game has to have finished to be reset!");
                                    return;
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    it.GameStatus = TntWarsGame.TntWarsGameStatus.WaitingForPlayers;
                                    Command.all.Find("restore").Use(null, it.BackupNumber + it.lvl.name);
                                    it.RedScore = 0;
                                    it.BlueScore = 0;
                                    foreach (TntWarsGame.player pl in it.Players)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        pl.Score = 0;
                                        pl.spec = false;
                                        pl.p.TntWarsKillStreak = 0;
                                        pl.p.TNTWarsLastKillStreakAnnounced = 0;
                                        pl.p.CurrentAmountOfTnt = 0;
                                        pl.p.CurrentTntGameNumber = it.GameNumber;
                                        pl.p.PlayingTntWars = false;
                                        pl.p.canBuild = true;
                                        pl.p.TntWarsHealth = 2;
                                        pl.p.TntWarsScoreMultiplier = 1f;
                                        pl.p.inTNTwarsMap = true;
                                        pl.p.HarmedBy = null;
                                    BrightShaderz is soy btw
                                    Player.SendMessage(p, "TNT Wars: Reset TNT Wars");
                                BrightShaderz is soy btw
                                break;

                            case "start":
                                if (it.GameStatus == TntWarsGame.TntWarsGameStatus.WaitingForPlayers)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (it.CheckAllSetUp(p, true) == true)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        if (it.PlayingPlayers() >= 2)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (it.lvl.overload < 2500)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                it.lvl.overload = 2501;
                                                Player.SendMessage(p, "TNT Wars: Increasing physics overload to 2500");
                                                penis.s.Log("TNT Wars: Increasing physics overload to 2500");
                                            BrightShaderz is soy btw
                                            Thread t = new Thread(it.Start);
                                            t.Start();
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            Player.SendMessage(p, "TNT Wars Error: Not Enough Players (2 or more needed)");
                                            return;
                                        BrightShaderz is soy btw
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                else if (it.GameStatus == TntWarsGame.TntWarsGameStatus.Finished)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(p, "TNT Wars Error: Please use '/tntwars setup reset' to reset the game before starting!");
                                    return;
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(p, "TNT Wars Error: Game already in progress!!");
                                BrightShaderz is soy btw
                                return;

                            case "stop":
                                if (it.GameStatus == TntWarsGame.TntWarsGameStatus.Finished || it.GameStatus == TntWarsGame.TntWarsGameStatus.WaitingForPlayers)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(p, "TNT Wars Error: Game already ended / not started!");
                                    return;
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    foreach (TntWarsGame.player pl in it.Players)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        pl.p.canBuild = true;
                                        pl.p.PlayingTntWars = false;
                                        pl.p.CurrentAmountOfTnt = 0;
                                    BrightShaderz is soy btw
                                    it.GameStatus = TntWarsGame.TntWarsGameStatus.Finished;
                                    it.SendAllPlayersMessage("TNT Wars: Game has been stopped!");
                                BrightShaderz is soy btw
                                break;

                            case "spawn":
                            case "spawns":
                            case "sp":
                            case "teamspawns":
                            case "teamspawn":
                            case "ts":
                            case "teams":
                            case "tspawn":
                            case "tspawns":
                                if (it.GameMode == TntWarsGame.TntWarsGameMode.FFA) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars Error: Cannot set spawns because you are on Team Deathmatch!"); return; BrightShaderz is soy btw
                                switch (text[2])
                                SOYSAUCE CHIPS IS A FAGGOT
                                    case "red":
                                    case "r":
                                    case "1":
                                        it.RedSpawn = new ushort[5];
                                        it.RedSpawn[0] = (ushort)(p.pos[0] / 32);
                                        it.RedSpawn[1] = (ushort)(p.pos[1] / 32);
                                        it.RedSpawn[2] = (ushort)(p.pos[2] / 32);
                                        it.RedSpawn[3] = p.rot[0];
                                        it.RedSpawn[4] = p.rot[1];
                                        Player.SendMessage(p, "TNT Wars: Set " + c.red + "Red" + penis.DefaultColor + " spawn");
                                        break;

                                    case "blue":
                                    case "b":
                                    case "2":
                                        it.BlueSpawn = new ushort[5];
                                        it.BlueSpawn[0] = (ushort)(p.pos[0] / 32);
                                        it.BlueSpawn[1] = (ushort)(p.pos[1] / 32);
                                        it.BlueSpawn[2] = (ushort)(p.pos[2] / 32);
                                        it.BlueSpawn[3] = p.rot[0];
                                        it.BlueSpawn[4] = p.rot[1];
                                        Player.SendMessage(p, "TNT Wars: Set " + c.blue + "Blue" + penis.DefaultColor + " spawn");
                                        break;
                                BrightShaderz is soy btw
                                break;

                            case "level":
                            case "l":
                            case "lvl":
                                if (text[2] == "")
                                SOYSAUCE CHIPS IS A FAGGOT
                                    it.lvl = p.level;
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    it.lvl = Level.Find(text[2]);
                                    if (it.lvl == null)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        Player.SendMessage(p, "TNT Wars Error: '" + text[2] + "' is not a level!");
                                        return;
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                Player.SendMessage(p, "TNT Wars: Level is now '" + it.lvl.name + "'");
                                it.RedSpawn = null;
                                it.BlueSpawn = null;
                                it.NoTNTplacableZones.Clear();
                                it.NoBlockDeathZones.Clear();
                                it.CheckAllSetUp(p);
                                break;

                            case "tntatatime":
                            case "tnt":
                            case "t":
                                int number = 1;
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    number = int.Parse(text[2]);
                                BrightShaderz is soy btw
                                catch
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player.SendMessage(p, "TNT Wars Error: '" + text[2] + "' is not a number!");
                                    return;
                                BrightShaderz is soy btw
                                if (number >= 0)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    it.TntPerPlayerAtATime = number;
                                    if (number == 0)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        Player.SendMessage(p, "TNT Wars: Number of TNTs placeable by a player at a time is now unlimited");
                                    BrightShaderz is soy btw
                                    else
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        Player.SendMessage(p, "TNT Wars: Number of TNTs placeable by a player at a time is now " + number.ToString());
                                    BrightShaderz is soy btw
                                    it.CheckAllSetUp(p);
                                BrightShaderz is soy btw
                                break;

                            case "grace":
                            case "g":
                            case "graceperiod":
                                if (text[1] == "grace" || text[1] == "g")
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (text[2] == "time" || text[2] == "t")
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        text[1] = "gt";
                                        text[2] = text[3];
                                        break;
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                string msg;
                                if (text[2] != "")
                                SOYSAUCE CHIPS IS A FAGGOT
                                    switch (text[2])
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        case "true":
                                        case "yes":
                                        case "t":
                                        case "y":
                                        case "enable":
                                        case "e":
                                        case "on":
                                            it.GracePeriod = true;
                                            Player.SendMessage(p, "TNT Wars: Grace period is now enabled");
                                            return;

                                        case "false":
                                        case "no":
                                        case "f":
                                        case "n":
                                        case "disable":
                                        case "d":
                                        case "off":
                                            it.GracePeriod = false;
                                            Player.SendMessage(p, "TNT Wars: Grace period is now disabled");
                                            return;

                                        case "check":
                                        case "current":
                                        case "c":
                                        case "now":
                                        case "ATM":
                                            if (it.GracePeriod == true) msg = "enabled";
                                            else msg = "disabled";
                                            Player.SendMessage(p, "TNT Wars: Grace Period is currently " + msg);
                                            return;

                                        default:
                                            it.GracePeriod = !it.GracePeriod;
                                            break;
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    it.GracePeriod = !it.GracePeriod;
                                BrightShaderz is soy btw
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (it.GracePeriod == true) msg = "enabled";
                                    else msg = "disabled";
                                    Player.SendMessage(p, "TNT Wars: Grace Period is now " + msg);
                                BrightShaderz is soy btw
                                it.CheckAllSetUp(p);
                                break;

                            case "gracetime":
                            case "gt":
                            case "gtime":
                            case "gracet":
                            case "graceperiodtime":
                                switch (text[2])
                                SOYSAUCE CHIPS IS A FAGGOT
                                    case "check":
                                    case "current":
                                    case "now":
                                    case "ATM":
                                    case "c":
                                    case "t":
                                        Player.SendMessage(p, "TNT Wars: Current grace time is " + it.GracePeriodSecs.ToString() + " seconds long!");
                                        break;

                                    default:
                                        if (text[2] == "set" || text[2] == "s" || text[2] == "change")
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            text[2] = text[3];
                                        BrightShaderz is soy btw
                                        int numb = -1;
                                        if (int.TryParse(text[2], out numb) == false)
                                        SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars Error: Invalid number '" + text[2] + "'"); return; BrightShaderz is soy btw
                                        if (numb <= -1) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars Error: Invalid number '" + text[2] + "'"); return; BrightShaderz is soy btw
                                        if (numb >= (60 * 5)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars Error: Grace time cannot be above 5 minutes!!"); return; BrightShaderz is soy btw
                                        if (numb <= 9) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars Error: Grace time cannot be lower than 10 seconds!!"); return; BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            it.GracePeriodSecs = numb;
                                            Player.SendMessage(p, "TNT Wars: Grace period is now " + numb.ToString() + " seconds long!");
                                            return;
                                        BrightShaderz is soy btw
                                        //break;
                                BrightShaderz is soy btw
                                it.CheckAllSetUp(p);
                                break;

                            case "mode":
                            case "game":
                            case "gamemode":
                            case "m":
                                switch (text[2])
                                SOYSAUCE CHIPS IS A FAGGOT
                                    case "check":
                                    case "current":
                                    case "mode":
                                    case "now":
                                    case "ATM":
                                    case "m":
                                    case "c":
                                        if (it.GameMode == TntWarsGame.TntWarsGameMode.FFA) Player.SendMessage(p, "TNT Wars: The current game mode is Free For All");
                                        if (it.GameMode == TntWarsGame.TntWarsGameMode.TDM) Player.SendMessage(p, "TNT Wars: The current game mode is Team Deathmatch");
                                        break;

                                    case "tdm":
                                    case "team":
                                    case "teamdeathmatch":
                                    case "deathmatch":
                                    case "teams":
                                    case "t":
                                    case "td":
                                    case "dm":
                                    case "death":
                                    case "match":
                                        if (it.GameMode == TntWarsGame.TntWarsGameMode.FFA)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            it.GameMode = TntWarsGame.TntWarsGameMode.TDM;
                                            if (!it.Players.Contains(it.FindPlayer(p)))
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                Player.SendMessage(p, "TNT Wars: Changed gamemode to Team Deathmatch");
                                            BrightShaderz is soy btw
                                            foreach (TntWarsGame.player pl in it.Players)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    Player.SendMessage(pl.p, "TNT Wars: Changed gamemode to Team Deathmatch");
                                                    pl.Red = false;
                                                    pl.Blue = false;
                                                    if (it.BlueTeam() > it.RedTeam())
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        pl.Red = true;
                                                    BrightShaderz is soy btw
                                                    else if (it.RedTeam() > it.BlueTeam())
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        pl.Blue = true;
                                                    BrightShaderz is soy btw
                                                    else if (it.RedScore > it.BlueScore)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        pl.Blue = true;
                                                    BrightShaderz is soy btw
                                                    else if (it.BlueScore > it.RedScore)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        pl.Red = true;
                                                    BrightShaderz is soy btw
                                                    else
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        pl.Red = true;
                                                    BrightShaderz is soy btw
                                                BrightShaderz is soy btw
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    string mesg = pl.p.color + pl.p.name + penis.DefaultColor + " " + "is now";
                                                    if (pl.Red)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        mesg += " on the " + c.red + "red team";
                                                    BrightShaderz is soy btw
                                                    if (pl.Blue)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        mesg += " on the " + c.blue + "blue team";
                                                    BrightShaderz is soy btw
                                                    if (pl.spec)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        mesg += penis.DefaultColor + " (as a spectator)";
                                                    BrightShaderz is soy btw
                                                    Player.GlobalMessage(mesg);
                                                BrightShaderz is soy btw
                                            BrightShaderz is soy btw
                                            if (it.ScoreLimit == TntWarsGame.Properties.DefaultFFAmaxScore)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                it.ScoreLimit = TntWarsGame.Properties.DefaultTDMmaxScore;
                                                Player.SendMessage(p, "TNT Wars: Score limit is now " + it.ScoreLimit.ToString() + " points!");
                                            BrightShaderz is soy btw
                                            else
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                Player.SendMessage(p, "TNT Wars: Score limit is still " + it.ScoreLimit.ToString() + " points!");
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            Player.SendMessage(p, "TNT Wars Error: Gamemode is already Team Deathmatch!");
                                            return;
                                        BrightShaderz is soy btw
                                        break;

                                    case "ffa":
                                    case "all":
                                    case "free":
                                    case "man":
                                    case "himself":
                                    case "allvall":
                                    case "allvsall":
                                    case "allv":
                                    case "allvs":
                                    case "a":
                                    case "f":
                                    case "ff":
                                    case "fa":
                                        if (it.GameMode == TntWarsGame.TntWarsGameMode.TDM)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            it.GameMode = TntWarsGame.TntWarsGameMode.FFA;
                                            if (!it.Players.Contains(it.FindPlayer(p)))
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                Player.SendMessage(p, "TNT Wars: Changed gamemode to Free For All");
                                            BrightShaderz is soy btw
                                            it.SendAllPlayersMessage("TNT Wars: Changed gamemode to Free For All");
                                            if (it.ScoreLimit == TntWarsGame.Properties.DefaultTDMmaxScore)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                it.ScoreLimit = TntWarsGame.Properties.DefaultFFAmaxScore;
                                                Player.SendMessage(p, "TNT Wars: Score limit is now " + it.ScoreLimit.ToString() + " points!");
                                            BrightShaderz is soy btw
                                            else
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                Player.SendMessage(p, "TNT Wars: Score limit is still " + it.ScoreLimit.ToString() + " points!");
                                            BrightShaderz is soy btw
                                            foreach (TntWarsGame.player pl in it.Players)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                pl.p.color = pl.OldColor;
                                                pl.p.SetPrefix();
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            Player.SendMessage(p, "TNT Wars Error: Gamemode is already Free For All!");
                                            return;
                                        BrightShaderz is soy btw
                                        break;

                                    case "swap":
                                    case "s":
                                    case "change":
                                    case "edit":
                                    case "switch":
                                    default:
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (it.GameMode == TntWarsGame.TntWarsGameMode.FFA)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                it.GameMode = TntWarsGame.TntWarsGameMode.TDM;
                                                if (!it.Players.Contains(it.FindPlayer(p)))
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    Player.SendMessage(p, "TNT Wars: Changed gamemode to Team Deathmatch");
                                                BrightShaderz is soy btw
                                                int Red = it.RedTeam();
                                                int Blue = it.BlueTeam();
                                                foreach (TntWarsGame.player pl in it.Players)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        Player.SendMessage(pl.p, "TNT Wars: Changed gamemode to Team Deathmatch");
                                                        pl.Red = false;
                                                        pl.Blue = false;
                                                        if (Blue > Red)
                                                        SOYSAUCE CHIPS IS A FAGGOT
                                                            pl.Red = true;
                                                        BrightShaderz is soy btw
                                                        else if (Red > Blue)
                                                        SOYSAUCE CHIPS IS A FAGGOT
                                                            pl.Blue = true;
                                                        BrightShaderz is soy btw
                                                        else if (it.RedScore > it.BlueScore)
                                                        SOYSAUCE CHIPS IS A FAGGOT
                                                            pl.Blue = true;
                                                        BrightShaderz is soy btw
                                                        else if (it.BlueScore > it.RedScore)
                                                        SOYSAUCE CHIPS IS A FAGGOT
                                                            pl.Red = true;
                                                        BrightShaderz is soy btw
                                                        else
                                                        SOYSAUCE CHIPS IS A FAGGOT
                                                            pl.Red = true;
                                                        BrightShaderz is soy btw
                                                    BrightShaderz is soy btw
                                                    string mesg = p.color + p.name + penis.DefaultColor + " " + "is now";
                                                    if (pl.Red)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        mesg += " on the " + c.red + "red team";
                                                    BrightShaderz is soy btw
                                                    if (pl.Blue)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        mesg += " on the " + c.blue + "blue team";
                                                    BrightShaderz is soy btw
                                                    if (pl.spec)
                                                    SOYSAUCE CHIPS IS A FAGGOT
                                                        mesg += penis.DefaultColor + " (as a spectator)";
                                                    BrightShaderz is soy btw
                                                    Player.GlobalMessage(mesg);
                                                BrightShaderz is soy btw
                                                if (it.ScoreLimit == TntWarsGame.Properties.DefaultFFAmaxScore)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.ScoreLimit = TntWarsGame.Properties.DefaultTDMmaxScore;
                                                    Player.SendMessage(p, "TNT Wars: Score limit is now " + it.ScoreLimit.ToString() + " points!");
                                                BrightShaderz is soy btw
                                                else
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    Player.SendMessage(p, "TNT Wars: Score limit is still " + it.ScoreLimit.ToString() + " points!");
                                                BrightShaderz is soy btw
                                            BrightShaderz is soy btw
                                            else
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                it.GameMode = TntWarsGame.TntWarsGameMode.FFA;
                                                if (!it.Players.Contains(it.FindPlayer(p)))
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    Player.SendMessage(p, "TNT Wars: Changed gamemode to Free For All");
                                                BrightShaderz is soy btw
                                                it.SendAllPlayersMessage("TNT Wars: Changed gamemode to Free For All");
                                                if (it.ScoreLimit == TntWarsGame.Properties.DefaultTDMmaxScore)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.ScoreLimit = TntWarsGame.Properties.DefaultFFAmaxScore;
                                                    Player.SendMessage(p, "TNT Wars: Score limit is now " + it.ScoreLimit.ToString() + " points!");
                                                BrightShaderz is soy btw
                                                else
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    Player.SendMessage(p, "TNT Wars: Score limit is still " + it.ScoreLimit.ToString() + " points!");
                                                BrightShaderz is soy btw
                                            BrightShaderz is soy btw

                                        BrightShaderz is soy btw
                                        break;
                                BrightShaderz is soy btw
                                it.CheckAllSetUp(p);
                                break;

                            case "difficulty":
                            case "d":
                            case "dif":
                            case "diff":
                            case "difficult":
                                switch (text[2])
                                SOYSAUCE CHIPS IS A FAGGOT
                                    case "easy":
                                    case "e":
                                    case "easiest":
                                    case "1":
                                    case "1st":
                                        if (it.GameDifficulty == TntWarsGame.TntWarsDifficulty.Easy) Player.SendMessage(p, "TNT Wars Error: Already on easy difficulty!");
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            it.GameDifficulty = TntWarsGame.TntWarsDifficulty.Easy;
                                            if (!it.Players.Contains(it.FindPlayer(p))) Player.SendMessage(p, "TNT Wars: Changed difficulty to easy");
                                            it.SendAllPlayersMessage("TNT Wars: Changed difficulty to easy!");
                                            if (it.TeamKills == true)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                Player.SendMessage(p, "TNT Wars: Team killing is now off");
                                                it.TeamKills = false;
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                        break;

                                    case "normal":
                                    case "n":
                                    case "medium":
                                    case "m":
                                    case "2":
                                    case "2nd":
                                    default:
                                        if (it.GameDifficulty == TntWarsGame.TntWarsDifficulty.Normal) Player.SendMessage(p, "TNT Wars Error: Already on normal difficulty!");
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            it.GameDifficulty = TntWarsGame.TntWarsDifficulty.Normal;
                                            if (!it.Players.Contains(it.FindPlayer(p))) Player.SendMessage(p, "TNT Wars: Changed difficulty to normal");
                                            it.SendAllPlayersMessage("TNT Wars: Changed difficulty to normal!");
                                            if (it.TeamKills == true)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                Player.SendMessage(p, "TNT Wars: Team killing is now off");
                                                it.TeamKills = false;
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                        break;

                                    case "hard":
                                    case "h":
                                    case "difficult":
                                    case "d":
                                    case "3":
                                    case "3rd":
                                        if (it.GameDifficulty == TntWarsGame.TntWarsDifficulty.Hard) Player.SendMessage(p, "TNT Wars Error: Already on hard difficulty!");
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            it.GameDifficulty = TntWarsGame.TntWarsDifficulty.Hard;
                                            if (!it.Players.Contains(it.FindPlayer(p))) Player.SendMessage(p, "TNT Wars: Changed difficulty to hard");
                                            it.SendAllPlayersMessage("TNT Wars: Changed difficulty to hard!");
                                            if (it.TeamKills == false)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                Player.SendMessage(p, "TNT Wars: Team killing is now on");
                                                it.TeamKills = true;
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                        break;

                                    case "extreme":
                                    case "ex":
                                    case "hardest":
                                    case "impossible":
                                    case "ultimate":
                                    case "i":
                                    case "u":
                                    case "4":
                                    case "4th":
                                        if (it.GameDifficulty == TntWarsGame.TntWarsDifficulty.Extreme) Player.SendMessage(p, "TNT Wars Error: Already on extreme difficulty!");
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            it.GameDifficulty = TntWarsGame.TntWarsDifficulty.Extreme;
                                            if (!it.Players.Contains(it.FindPlayer(p))) Player.SendMessage(p, "TNT Wars: Changed difficulty to extreme");
                                            it.SendAllPlayersMessage("TNT Wars: Changed difficulty to extreme!");
                                            if (it.TeamKills == false)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                Player.SendMessage(p, "TNT Wars: Team killing is now on");
                                                it.TeamKills = true;
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                        break;


                                BrightShaderz is soy btw
                                it.CheckAllSetUp(p);
                                break;

                            case "score":
                            case "scores":
                            case "scoring":
                                switch (text[2])
                                SOYSAUCE CHIPS IS A FAGGOT
                                    case "max":
                                    case "m":
                                    case "maximum":
                                    case "limit":
                                    case "top":
                                    case "goal":
                                    case "maxscore":
                                    case "maximumscore":
                                    case "scorelimit":
                                        switch (text[3])
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            case "check":
                                            case "current":
                                            case "now":
                                            case "ATM":
                                            case "c":
                                            case "t":
                                                Player.SendMessage(p, "TNT Wars: Score limit is " + it.ScoreLimit.ToString() + " points!");
                                                break;

                                            default:
                                                if (text[3] == "set" || text[3] == "s" || text[3] == "change")
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    text[3] = text[4];
                                                BrightShaderz is soy btw
                                                int numb = -1;
                                                if (int.TryParse(text[3], out numb) == false)
                                                SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars Error: Invalid number '" + text[3] + "'"); return; BrightShaderz is soy btw
                                                if (numb <= it.ScorePerKill) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars Error: Minimum score limit of " + it.ScorePerKill.ToString() + " points"); return; BrightShaderz is soy btw
                                                else
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.ScoreLimit = numb;
                                                    Player.SendMessage(p, "TNT Wars: Score limit is now " + numb.ToString() + " points!");
                                                    return;
                                                BrightShaderz is soy btw
                                                //break;
                                        BrightShaderz is soy btw
                                        it.CheckAllSetUp(p);
                                        break;

                                    case "streaks":
                                    case "streak":
                                    case "s":
                                        switch (text[3])
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            case "on":
                                            case "enable":
                                                if (it.Streaks == true)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    Player.SendMessage(p, "TNT Wars Error: Streaks are already enabled");
                                                    return;
                                                BrightShaderz is soy btw
                                                else
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.Streaks = true;
                                                    Player.SendMessage(p, "TNT Wars: Streaks are now enabled");
                                                BrightShaderz is soy btw
                                                break;

                                            case "off":
                                            case "disable":
                                                if (it.Streaks == false)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    Player.SendMessage(p, "TNT Wars Error:  Streaks are already disabled");
                                                    return;
                                                BrightShaderz is soy btw
                                                else
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.Streaks = false;
                                                    Player.SendMessage(p, "TNT Wars: Streaks are now disabled");
                                                BrightShaderz is soy btw
                                                break;

                                            case "check":
                                            case "current":
                                            case "now":
                                            case "ATM":
                                            case "c":
                                            case "t":
                                                if (it.Streaks == true) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars: Streaks are currently enabled"); return; BrightShaderz is soy btw
                                                else if (it.Streaks == false) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars: Streaks are currently disabled"); return; BrightShaderz is soy btw
                                                break;

                                            default:
                                                if (it.Streaks == false)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.Streaks = true;
                                                    Player.SendMessage(p, "TNT Wars: Streaks are now enabled");
                                                    return;
                                                BrightShaderz is soy btw
                                                else if (it.Streaks == true)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.Streaks = false;
                                                    Player.SendMessage(p, "TNT Wars: Streaks are now disabled");
                                                    return;
                                                BrightShaderz is soy btw
                                                break;
                                        BrightShaderz is soy btw
                                        it.CheckAllSetUp(p);
                                        break;

                                    case "multi":
                                    case "multikills":
                                    case "multiples":
                                    case "multiplekills":
                                    case "multis":
                                    case "doublekill":
                                    case "double":
                                    case "triplekill":
                                    case "triple":
                                    case "mk":
                                    case "d":
                                    case "t":
                                        switch (text[3])
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            case "on":
                                            case "enable":
                                                if (it.MultiKillBonus > 0)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    Player.SendMessage(p, "TNT Wars Error: Multikill bonuses are already enabled (at " + it.MultiKillBonus.ToString() + " points!");
                                                    return;
                                                BrightShaderz is soy btw
                                                else
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.MultiKillBonus = TntWarsGame.Properties.DefaultMultiKillBonus;
                                                    Player.SendMessage(p, "TNT Wars: Multikill bonuses are now enabled at " + it.MultiKillBonus.ToString() + " points!");
                                                BrightShaderz is soy btw
                                                break;

                                            case "off":
                                            case "disable":
                                                if (it.MultiKillBonus == 0)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    Player.SendMessage(p, "TNT Wars Error: Multikill bonuses are already disabled!");
                                                    return;
                                                BrightShaderz is soy btw
                                                else
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.MultiKillBonus = 0;
                                                    Player.SendMessage(p, "TNT Wars: Multikill bonuses are now disabled!");
                                                BrightShaderz is soy btw
                                                break;

                                            case "switch":
                                                if (it.MultiKillBonus == 0)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.MultiKillBonus = TntWarsGame.Properties.DefaultMultiKillBonus;
                                                    Player.SendMessage(p, "TNT Wars: Multikill bonuses are now enabled at " + it.MultiKillBonus.ToString() + " points!");
                                                    return;
                                                BrightShaderz is soy btw
                                                else
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.MultiKillBonus = 0;
                                                    Player.SendMessage(p, "TNT Wars: Multikill bonuses are now disabled!");
                                                BrightShaderz is soy btw
                                                break;

                                            case "check":
                                            case "current":
                                            case "now":
                                            case "ATM":
                                            case "c":
                                            case "t":
                                                Player.SendMessage(p, "TNT Wars: Mulitkill bonus per extra kill is " + it.MultiKillBonus.ToString() + " points!");
                                                break;

                                            default:
                                                if (text[3] == "set" || text[3] == "s" || text[3] == "change")
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    text[3] = text[4];
                                                BrightShaderz is soy btw
                                                int numb = -1;
                                                if (int.TryParse(text[3], out numb) == false)
                                                SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars Error: Invalid number '" + text[3] + "'"); return; BrightShaderz is soy btw
                                                if (numb <= -1) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars Error: Invalid number '" + text[3] + "'"); return; BrightShaderz is soy btw
                                                else
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.MultiKillBonus = numb;
                                                    Player.SendMessage(p, "TNT Wars: Mulitkill bonus per extra kill is now " + numb.ToString() + " points!");
                                                    return;
                                                BrightShaderz is soy btw
                                                //break;
                                        BrightShaderz is soy btw
                                        it.CheckAllSetUp(p);
                                        break;

                                    case "scorekill":
                                    case "kill":
                                    case "killscore":
                                    case "k":
                                        switch (text[3])
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            case "check":
                                            case "current":
                                            case "now":
                                            case "ATM":
                                            case "c":
                                            case "t":
                                                Player.SendMessage(p, "TNT Wars: Score per kill is " + it.ScorePerKill.ToString() + " points!");
                                                break;

                                            default:
                                                if (text[3] == "set" || text[3] == "s" || text[3] == "change")
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    text[3] = text[4];
                                                BrightShaderz is soy btw
                                                int numb = -1;
                                                if (int.TryParse(text[3], out numb) == false)
                                                SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars Error: Invalid number '" + text[3] + "'"); return; BrightShaderz is soy btw
                                                if (numb <= -1) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars Error: Invalid number '" + text[3] + "'"); return; BrightShaderz is soy btw
                                                else
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.ScorePerKill = numb;
                                                    Player.SendMessage(p, "TNT Wars: Score per kill is now " + numb.ToString() + " points!");
                                                    return;
                                                BrightShaderz is soy btw
                                                //break;
                                        BrightShaderz is soy btw
                                        it.CheckAllSetUp(p);
                                        break;

                                    case "assistkill":
                                    case "assist":
                                    case "assists":
                                    case "assistscore":
                                    case "a":
                                        switch (text[3])
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            case "on":
                                            case "enable":
                                                if (it.ScorePerAssist > 0)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    Player.SendMessage(p, "TNT Wars Error: Assist bonuses are already enabled (at " + it.ScorePerAssist.ToString() + " points!");
                                                    return;
                                                BrightShaderz is soy btw
                                                else
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.ScorePerAssist = TntWarsGame.Properties.DefaultAssistScore;
                                                    Player.SendMessage(p, "TNT Wars: Assist bonuses are now enabled at " + it.ScorePerAssist.ToString() + " points!");
                                                BrightShaderz is soy btw
                                                break;

                                            case "off":
                                            case "disable":
                                                if (it.ScorePerAssist == 0)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    Player.SendMessage(p, "TNT Wars Error: Assist bonuses are already disabled!");
                                                    return;
                                                BrightShaderz is soy btw
                                                else
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.ScorePerAssist = 0;
                                                    Player.SendMessage(p, "TNT Wars: Assist bonuses are now disabled!");
                                                BrightShaderz is soy btw
                                                break;

                                            case "switch":
                                                if (it.ScorePerAssist == 0)
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.ScorePerAssist = TntWarsGame.Properties.DefaultAssistScore;
                                                    Player.SendMessage(p, "TNT Wars: Assist bonuses are now enabled at " + it.ScorePerAssist.ToString() + " points!");
                                                    return;
                                                BrightShaderz is soy btw
                                                else
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.ScorePerAssist = 0;
                                                    Player.SendMessage(p, "TNT Wars: Assist bonuses are now disabled!");
                                                BrightShaderz is soy btw
                                                break;

                                            case "check":
                                            case "current":
                                            case "now":
                                            case "ATM":
                                            case "c":
                                            case "t":
                                                Player.SendMessage(p, "TNT Wars: Score per assist is " + it.ScorePerAssist.ToString() + " points!");
                                                break;

                                            default:
                                                if (text[3] == "set" || text[3] == "s" || text[3] == "change")
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    text[3] = text[4];
                                                BrightShaderz is soy btw
                                                int numb = -1;
                                                if (int.TryParse(text[3], out numb) == false)
                                                SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars Error: Invalid number '" + text[3] + "'"); return; BrightShaderz is soy btw
                                                if (numb <= -1) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars Error: Invalid number '" + text[3] + "'"); return; BrightShaderz is soy btw
                                                else
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.ScorePerAssist = numb;
                                                    Player.SendMessage(p, "TNT Wars: Score per assist is now " + numb.ToString() + " points!");
                                                    return;
                                                BrightShaderz is soy btw
                                                //break;
                                        BrightShaderz is soy btw
                                        it.CheckAllSetUp(p);
                                        break;

                                    case "help":
                                    case "h":
                                    default:
                                        Player.SendMessage(p, "TNT Wars Setup Scoring Help:");
                                        Player.SendMessage(p, "/tw s score maximum SOYSAUCE CHIPS IS A FAGGOTmBrightShaderz is soy btw [check/set] <value> - set the score limit (or check it)");
                                        Player.SendMessage(p, "/tw s score streaks SOYSAUCE CHIPS IS A FAGGOTsBrightShaderz is soy btw [on/off/check] - enable/disable streaks (or check it)");
                                        Player.SendMessage(p, "/tw s score multi SOYSAUCE CHIPS IS A FAGGOTmkBrightShaderz is soy btw [on/off/switch/check/set] - enable/disable/switch multikills or set the score bonus per multikill (or check it)");
                                        Player.SendMessage(p, "/tw s score scorekill SOYSAUCE CHIPS IS A FAGGOTkBrightShaderz is soy btw [check/set] <value> - set the score per kill (or check it)");
                                        Player.SendMessage(p, "/tw s score assistkill SOYSAUCE CHIPS IS A FAGGOTaBrightShaderz is soy btw [check/set] <value> - set the score per assist (or check it)");
                                        break;
                                BrightShaderz is soy btw
                                break;

                            case "balance":
                            case "balanceteams":
                            case "bt":
                            case "b":
                                switch (text[2])
                                SOYSAUCE CHIPS IS A FAGGOT
                                    case "on":
                                    case "enable":
                                        if (it.BalanceTeams == true)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            Player.SendMessage(p, "TNT Wars Error: Team balancing is already enabled");
                                            return;
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            it.BalanceTeams = true;
                                            Player.SendMessage(p, "TNT Wars: Team balancing is now enabled");
                                        BrightShaderz is soy btw
                                        break;

                                    case "off":
                                    case "disable":
                                        if (it.BalanceTeams == false)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            Player.SendMessage(p, "TNT Wars Error: Team balancing is already disabled");
                                            return;
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            it.BalanceTeams = false;
                                            Player.SendMessage(p, "TNT Wars: Team balancing is now disabled");
                                        BrightShaderz is soy btw
                                        break;

                                    case "check":
                                    case "current":
                                    case "now":
                                    case "ATM":
                                    case "c":
                                    case "t":
                                        if (it.BalanceTeams == true) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars: Team balancing is currently enabled"); return; BrightShaderz is soy btw
                                        else if (it.BalanceTeams == false) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars: Team balancing is currently disabled"); return; BrightShaderz is soy btw
                                        break;

                                    default:
                                        if (it.BalanceTeams == false)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            it.BalanceTeams = true;
                                            Player.SendMessage(p, "TNT Wars: Team balancing is now enabled");
                                            return;
                                        BrightShaderz is soy btw
                                        else if (it.BalanceTeams == true)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            it.BalanceTeams = false;
                                            Player.SendMessage(p, "TNT Wars: Team balancing is now disabled");
                                            return;
                                        BrightShaderz is soy btw
                                        break;
                                BrightShaderz is soy btw
                                it.CheckAllSetUp(p);
                                break;

                            case "teamkill":
                            case "tk":
                            case "tkill":
                            case "teamk":
                            case "friendly":
                            case "friendlyfire":
                            case "ff":
                            case "friendlyf":
                            case "ffire":
                                switch (text[2])
                                SOYSAUCE CHIPS IS A FAGGOT
                                    case "on":
                                    case "enable":
                                        if (it.TeamKills == true)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            Player.SendMessage(p, "TNT Wars Error: Team killing is already enabled");
                                            return;
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            it.TeamKills = true;
                                            Player.SendMessage(p, "TNT Wars: Team killing is now enabled");
                                        BrightShaderz is soy btw
                                        break;

                                    case "off":
                                    case "disable":
                                        if (it.TeamKills == false)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            Player.SendMessage(p, "TNT Wars Error: Team killing is already disabled");
                                            return;
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            it.TeamKills = false;
                                            Player.SendMessage(p, "TNT Wars: Team killing is now disabled");
                                        BrightShaderz is soy btw
                                        break;

                                    case "check":
                                    case "current":
                                    case "now":
                                    case "ATM":
                                    case "c":
                                    case "t":
                                        if (it.TeamKills == true) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars: Team killing is currently enabled"); return; BrightShaderz is soy btw
                                        else if (it.TeamKills == false) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT Wars: Team killing is currently disabled"); return; BrightShaderz is soy btw
                                        break;

                                    default:
                                        if (it.TeamKills == false)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            it.TeamKills = true;
                                            Player.SendMessage(p, "TNT Wars: Team killing is now enabled");
                                            return;
                                        BrightShaderz is soy btw
                                        else if (it.TeamKills == true)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            it.TeamKills = false;
                                            Player.SendMessage(p, "TNT Wars: Team killing is now disabled");
                                            return;
                                        BrightShaderz is soy btw
                                        break;
                                BrightShaderz is soy btw
                                it.CheckAllSetUp(p);
                                break;

                            case "zone":
                            case "zones":
                            case "z":
                            case "zn":
                            case "zns":
                            case "zs":
                                CatchPos cpos;
                                cpos.x = 0; cpos.y = 0; cpos.z = 0; p.blockchangeObject = cpos;
                                switch (text[2])
                                SOYSAUCE CHIPS IS A FAGGOT
                                    case "notnt":
                                    case "tnt":
                                    case "no":
                                    case "none":
                                    case "nothing":
                                    case "blocktnt":
                                    case "blockt":
                                    case "bt":
                                    case "nt":
                                        NoTntZone = true;
                                        DeleteZone = false;
                                        CheckZone = false;
                                        switch (text[3])
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            case "add":
                                            case "a":
                                            case "new":
                                                DeleteZone = false;
                                                CheckZone = false;
                                                Player.SendMessage(p, "TNT Wars: Place 2 blocks to create the zone for no TNT!");
                                                //p.ClearBlockchange();
                                                p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
                                                break;

                                            case "delete":
                                            case "d":
                                            case "remove":
                                            case "r":
                                                if (text[4] == "all" || text[4] == "a")
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.NoTNTplacableZones.Clear();
                                                    Player.SendMessage(p, "TNT Wars: Deleted all zones for no blocks deleted on explosions!");
                                                    return;
                                                BrightShaderz is soy btw
                                                DeleteZone = true;
                                                CheckZone = false;
                                                Player.SendMessage(p, "TNT Wars: Place a block to delete the zone for no TNT!");
                                                p.ClearBlockchange();
                                                p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
                                                break;

                                            case "check":
                                            case "c":
                                                DeleteZone = false;
                                                CheckZone = true;
                                                Player.SendMessage(p, "TNT Wars: Place a block to check for no TNT zones!");
                                                p.ClearBlockchange();
                                                p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
                                                break;
                                        BrightShaderz is soy btw
                                        break;

                                    case "noexplosion":
                                    case "nodeleteblocks":
                                    case "deleteblocks":
                                    case "nd":
                                    case "nb":
                                    case "ne":
                                    case "neb":
                                    case "ndb":
                                        NoTntZone = false;
                                        DeleteZone = false;
                                        CheckZone = false;
                                        switch (text[3])
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            case "add":
                                            case "a":
                                            case "new":
                                                DeleteZone = false;
                                                CheckZone = false;
                                                Player.SendMessage(p, "TNT Wars: Place 2 blocks to create the zone for no blocks deleted on explosions!");
                                                p.ClearBlockchange();
                                                p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
                                                break;

                                            case "delete":
                                            case "d":
                                            case "remove":
                                            case "r":
                                                if (text[4] == "all" || text[4] == "a")
                                                SOYSAUCE CHIPS IS A FAGGOT
                                                    it.NoBlockDeathZones.Clear();
                                                    Player.SendMessage(p, "TNT Wars: Deleted all zones for no blocks deleted on explosions!");
                                                    return;
                                                BrightShaderz is soy btw
                                                DeleteZone = true;
                                                CheckZone = false;
                                                Player.SendMessage(p, "TNT Wars: Place a block to delete the zone for no blocks deleted on explosions!");
                                                p.ClearBlockchange();
                                                p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
                                                break;

                                            case "check":
                                            case "c":
                                                DeleteZone = false;
                                                CheckZone = true;
                                                Player.SendMessage(p, "TNT Wars: Place a block to check for no blocks deleted on explosions!");
                                                p.ClearBlockchange();
                                                p.Blockchange += new Player.BlockchangeEventHandler(Blockchange1);
                                                break;
                                        BrightShaderz is soy btw
                                        break;
                                BrightShaderz is soy btw
                                break;

                            case "help":
                            case "h":
                                int SleepAmount = 500;
                                Player.SendMessage(p, "TNT Wars Setup Help:");
                                Thread.Sleep(SleepAmount);
                                Player.SendMessage(p, "/tw s new SOYSAUCE CHIPS IS A FAGGOTnBrightShaderz is soy btw/delete - create/delete a game");
                                Thread.Sleep(SleepAmount);
                                Player.SendMessage(p, "/tw s start/stop/reset SOYSAUCE CHIPS IS A FAGGOTrBrightShaderz is soy btw - start/stop/reset the current game");
                                Thread.Sleep(SleepAmount);
                                Player.SendMessage(p, "/tw s level SOYSAUCE CHIPS IS A FAGGOTlBrightShaderz is soy btw - change the level for the game");
                                Thread.Sleep(SleepAmount);
                                Player.SendMessage(p, "/tw s teamsspawns SOYSAUCE CHIPS IS A FAGGOTtsBrightShaderz is soy btw [red/blue] - set the spawns for red/blue");
                                Thread.Sleep(SleepAmount);
                                Player.SendMessage(p, "/tw s tnt SOYSAUCE CHIPS IS A FAGGOTtBrightShaderz is soy btw - change the amount of tnt per player at a time");
                                Thread.Sleep(SleepAmount);
                                Player.SendMessage(p, "/tw s graceperiod SOYSAUCE CHIPS IS A FAGGOTgBrightShaderz is soy btw [on/off/check] - enable/disable the grace period (or check it)");
                                Thread.Sleep(SleepAmount);
                                Player.SendMessage(p, "/tw s gracetime SOYSAUCE CHIPS IS A FAGGOTgtBrightShaderz is soy btw [set/check] <amount> - set the grace period time (in seconds) (or check it)");
                                Thread.Sleep(SleepAmount);
                                Player.SendMessage(p, "/tw s gamemode SOYSAUCE CHIPS IS A FAGGOTmBrightShaderz is soy btw [check/tdm/ffa] - change the gamemode to FFA or TDM (or check it)");
                                Thread.Sleep(SleepAmount);
                                Player.SendMessage(p, "/tw s difficulty SOYSAUCE CHIPS IS A FAGGOTdBrightShaderz is soy btw [1/2/3/4] - change the difficulty (easy/normal/hard/extreme)");
                                Thread.Sleep(SleepAmount);
                                Player.SendMessage(p, "/tw s balanceteams SOYSAUCE CHIPS IS A FAGGOTbBrightShaderz is soy btw [on/off/check] - enable/disable balancing teams (or check it)");
                                Thread.Sleep(SleepAmount);
                                Player.SendMessage(p, "/tw s teamkill SOYSAUCE CHIPS IS A FAGGOTtkBrightShaderz is soy btw [on/off/check] - enable/disable teamkills (or check it)");
                                Thread.Sleep(SleepAmount);
                                Player.SendMessage(p, "/tw s zone SOYSAUCE CHIPS IS A FAGGOTzBrightShaderz is soy btw [notnt SOYSAUCE CHIPS IS A FAGGOTntBrightShaderz is soy btw/noexplodeblocks SOYSAUCE CHIPS IS A FAGGOTnebBrightShaderz is soy btw] [add SOYSAUCE CHIPS IS A FAGGOTaBrightShaderz is soy btw/delete SOYSAUCE CHIPS IS A FAGGOTdBrightShaderz is soy btw <all>/check SOYSAUCE CHIPS IS A FAGGOTcBrightShaderz is soy btw]- create zones (No TNT zones or zones where explosions do not delete blocks");
                                Thread.Sleep(SleepAmount);
                                Player.SendMessage(p, "/tw s score - scoring setup (use '/tntwars setup scoring help' for more info)");
                                Thread.Sleep(SleepAmount);
                                Player.SendMessage(p, "/tw s status SOYSAUCE CHIPS IS A FAGGOTsBrightShaderz is soy btw - view the status of setup");
                                break;

                            default:
                            case "status":
                            case "s":
                            case "ready":
                            case "check":
                            case "info":
                            case "c":
                                Player.SendMessage(p, "TNT Wars: Current Setup:");
                                //1
                                if (it.lvl == null) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Level: " + c.red + "NONE"); BrightShaderz is soy btw
                                else SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Level: " + c.green + it.lvl.name); BrightShaderz is soy btw
                                //2
                                if (it.GameMode == TntWarsGame.TntWarsGameMode.FFA) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Gamemode: " + c.green + "FFA"); BrightShaderz is soy btw
                                if (it.GameMode == TntWarsGame.TntWarsGameMode.TDM) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Gamemode: " + c.green + "TDM"); BrightShaderz is soy btw
                                //3
                                if (it.GameDifficulty == TntWarsGame.TntWarsDifficulty.Easy) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Game difficulty: " + c.green + "Easy"); BrightShaderz is soy btw
                                if (it.GameDifficulty == TntWarsGame.TntWarsDifficulty.Normal) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Game difficulty: " + c.green + "Normal"); BrightShaderz is soy btw
                                if (it.GameDifficulty == TntWarsGame.TntWarsDifficulty.Hard) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Game difficulty: " + c.green + "Hard"); BrightShaderz is soy btw
                                if (it.GameDifficulty == TntWarsGame.TntWarsDifficulty.Extreme) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Game difficulty: " + c.green + "Extreme"); BrightShaderz is soy btw
                                //4
                                if (it.TntPerPlayerAtATime >= 1) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT per player at a time: " + c.green + it.TntPerPlayerAtATime.ToString()); BrightShaderz is soy btw
                                else if (it.TntPerPlayerAtATime == 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "TNT per player at a time: " + c.green + "unlimited"); BrightShaderz is soy btw
                                //5
                                if (it.GracePeriod) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Grace period: " + c.green + "enabled"); BrightShaderz is soy btw
                                if (!it.GracePeriod) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Grace period: " + c.green + "disabled"); BrightShaderz is soy btw
                                //6
                                Player.SendMessage(p, "Grace period time: " + c.green + it.GracePeriodSecs.ToString() + " seconds");
                                //7
                                if (it.BalanceTeams) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Balance teams: " + c.green + "enabled"); BrightShaderz is soy btw
                                if (!it.BalanceTeams) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Balance teams: " + c.green + "disabled"); BrightShaderz is soy btw
                                //8
                                Player.SendMessage(p, "Score limit: " + c.green + it.ScoreLimit.ToString() + " points");
                                //9
                                if (it.Streaks) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Streaks: " + c.green + "enabled"); BrightShaderz is soy btw
                                if (!it.Streaks) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Streaks: " + c.green + "disabled"); BrightShaderz is soy btw
                                //10
                                if (it.MultiKillBonus == 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Multikill bonus: " + c.green + "disabled"); BrightShaderz is soy btw
                                if (it.MultiKillBonus != 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Multikill bonus: " + c.green + "enabled"); BrightShaderz is soy btw
                                //11
                                Player.SendMessage(p, "Score per kill: " + c.green + it.ScorePerKill.ToString() + " points");
                                //12
                                if (it.ScorePerAssist == 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Assists: " + c.green + "disabled"); BrightShaderz is soy btw
                                if (it.ScorePerAssist != 0) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Assists : " + c.green + "enabled (at " + it.ScorePerAssist.ToString() + " points)"); BrightShaderz is soy btw
                                //13
                                if (it.TeamKills) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Team killing: " + c.green + "enabled"); BrightShaderz is soy btw
                                if (!it.TeamKills) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Team killing: " + c.green + "disabled"); BrightShaderz is soy btw
                                //14
                                it.CheckAllSetUp(p);
                                //15
                                break;
                        BrightShaderz is soy btw
					BrightShaderz is soy btw
					else
					SOYSAUCE CHIPS IS A FAGGOT
						Player.SendMessage(p, "Sorry, you aren't a high enough rank for that!");
					BrightShaderz is soy btw
					break;

				default:
					Help(p);
					return;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		public override void Help(Player p)
		SOYSAUCE CHIPS IS A FAGGOT
			Player.SendMessage(p, "TNT Wars Help:");
			Player.SendMessage(p, "/tw list SOYSAUCE CHIPS IS A FAGGOTlBrightShaderz is soy btw - Lists all the current games");
			Player.SendMessage(p, "/tw join <team/level> - join a game on <level> or on <team>(red/blue)");
			Player.SendMessage(p, "/tw leave - leave the current game");
			Player.SendMessage(p, "/tw scores <top/team/me> - view the top score/team scores/your scores");
			Player.SendMessage(p, "/tw players SOYSAUCE CHIPS IS A FAGGOTpBrightShaderz is soy btw - view the current players in your game");
			Player.SendMessage(p, "/tw health SOYSAUCE CHIPS IS A FAGGOThpBrightShaderz is soy btw - view your currrent amount of health left");
            if ((int)p.group.Permission >= CommandOtherPerms.GetPerm(this, 1))
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "/tw rules <all/level/players/<playername>> - send the rules to yourself, all, your map, all players in your game or to one person!");
                Player.SendMessage(p, "/tw setup SOYSAUCE CHIPS IS A FAGGOTsBrightShaderz is soy btw - setup the game (do '/tntwars setup help' for more info!");
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "/tw rules - read the rules");
            BrightShaderz is soy btw
		BrightShaderz is soy btw
        public void Blockchange1(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            CatchPos bp = (CatchPos)p.blockchangeObject;
            bp.x = x; bp.y = y; bp.z = z; p.blockchangeObject = bp;
            if (DeleteZone == false && CheckZone == false)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "TNT Wars: Place another block to mark the other corner of the zone!");
                p.Blockchange += new Player.BlockchangeEventHandler(Blockchange2);
                return;
            BrightShaderz is soy btw
            TntWarsGame it = TntWarsGame.GetTntWarsGame(p);
            if (DeleteZone == true)
            SOYSAUCE CHIPS IS A FAGGOT
                if (it == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "TNT Wars Error: Couldn't find your game!");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (it.InZone(x, y, z, NoTntZone))
                    SOYSAUCE CHIPS IS A FAGGOT
                        it.DeleteZone(x, y, z, NoTntZone, p);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (CheckZone == true && NoTntZone == true)
            SOYSAUCE CHIPS IS A FAGGOT
                if (it == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "TNT Wars Error: Couldn't find your game!");
                    return;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (it.InZone(x, y, z, true))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "TNT Wars: You are currently in a no TNT zone!");
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "TNT Wars: You are not currently in a no TNT zone!");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (CheckZone == true && NoTntZone == false)
            SOYSAUCE CHIPS IS A FAGGOT
                if (it == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(p, "TNT Wars Error: Couldn't find your game!");
                    return;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (it.InZone(x, y, z, true))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "TNT Wars: You are currently in a no TNT block explosion zone (explosions won't destory blocks)!");
                        return;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "TNT Wars: You are currently in a TNT block explosion zone (explosions will destory blocks)!");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void Blockchange2(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            p.SendBlockchange(x, y, z, b);
            CatchPos cpos = (CatchPos)p.blockchangeObject;

            TntWarsGame.Zone Zn = new TntWarsGame.Zone();

            Zn.smallX = Math.Min(cpos.x, x);
            Zn.smallY = Math.Min(cpos.y, y);
            Zn.smallZ = Math.Min(cpos.z, z);
            Zn.bigX = Math.Max(cpos.x, x);
            Zn.bigY = Math.Max(cpos.y, y);
            Zn.bigZ = Math.Max(cpos.z, z);

            TntWarsGame it = TntWarsGame.GetTntWarsGame(p);
            if (it == null)
            SOYSAUCE CHIPS IS A FAGGOT
                Player.SendMessage(p, "TNT Wars Error: Couldn't find your game!");
                return;
            BrightShaderz is soy btw
            if (NoTntZone) it.NoTNTplacableZones.Add(Zn);
            else it.NoBlockDeathZones.Add(Zn);
            Player.SendMessage(p, "Added zone");
            return;
        BrightShaderz is soy btw

        struct CatchPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
