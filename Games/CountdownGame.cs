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
using System.Linq;
using System.Threading;
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class CountdownGame
    SOYSAUCE CHIPS IS A FAGGOT
        public static List<Player> players = new List<Player>();
        public static List<Player> playersleftlist = new List<Player>();
        public static List<string> squaresleft = new List<string>();
        public static Level mapon;

        public static int playersleft;
        public static int speed;

        public static bool freezemode = false;
        public static bool cancel = false;

        public static string speedtype;

        public static CountdownGameStatus gamestatus = CountdownGameStatus.Disabled;

        //private static ushort[] x; // this is useless?

        public static void GameStart(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            switch (gamestatus)
            SOYSAUCE CHIPS IS A FAGGOT
                case CountdownGameStatus.Disabled:
                    Player.SendMessage(p, "Please enable Countdown first!!");
                    return;

                case CountdownGameStatus.AboutToStart:
                    Player.SendMessage(p, "Game is about to start");
                    return;

                case CountdownGameStatus.InProgress:
                    Player.SendMessage(p, "Game is already in progress");
                    return;

                case CountdownGameStatus.Finished:
                    Player.SendMessage(p, "Game has finished");
                    return;

                case CountdownGameStatus.Enabled:
                    gamestatus = CountdownGameStatus.AboutToStart;
                    Thread.Sleep(2000);
                    break;
            BrightShaderz is soy btw
            SOYSAUCE CHIPS IS A FAGGOT
                SOYSAUCE CHIPS IS A FAGGOT
                    mapon.Blockchange(15, 27, 16, Block.glass);
                    mapon.Blockchange(16, 27, 15, Block.glass);
                    mapon.Blockchange(16, 27, 16, Block.glass);
                    mapon.Blockchange(15, 27, 15, Block.glass);
                BrightShaderz is soy btw
                SOYSAUCE CHIPS IS A FAGGOT
                    SOYSAUCE CHIPS IS A FAGGOT
                        mapon.Blockchange(15, 18, 14, Block.glass);
                        mapon.Blockchange(16, 18, 14, Block.glass);
                        mapon.Blockchange(15, 17, 14, Block.glass);
                        mapon.Blockchange(16, 17, 14, Block.glass);
                    BrightShaderz is soy btw
                    SOYSAUCE CHIPS IS A FAGGOT
                        mapon.Blockchange(14, 17, 15, Block.glass);
                        mapon.Blockchange(14, 18, 16, Block.glass);
                        mapon.Blockchange(14, 17, 16, Block.glass);
                        mapon.Blockchange(14, 18, 15, Block.glass);
                    BrightShaderz is soy btw
                    SOYSAUCE CHIPS IS A FAGGOT
                        mapon.Blockchange(15, 17, 17, Block.glass);
                        mapon.Blockchange(16, 18, 17, Block.glass);
                        mapon.Blockchange(15, 18, 17, Block.glass);
                        mapon.Blockchange(16, 17, 17, Block.glass);
                    BrightShaderz is soy btw
                    SOYSAUCE CHIPS IS A FAGGOT
                        mapon.Blockchange(17, 17, 16, Block.glass);
                        mapon.Blockchange(17, 18, 15, Block.glass);
                        mapon.Blockchange(17, 18, 16, Block.glass);
                        mapon.Blockchange(17, 17, 15, Block.glass);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                SOYSAUCE CHIPS IS A FAGGOT
                    mapon.Blockchange(16, 16, 15, Block.glass);
                    mapon.Blockchange(15, 16, 16, Block.glass);
                    mapon.Blockchange(15, 16, 15, Block.glass);
                    mapon.Blockchange(16, 16, 16, Block.glass);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            mapon.ChatLevel("Countdown is about to start!!");
            mapon.permissionbuild = LevelPermission.Nobody;
            ushort x1 = (ushort)((15.5) * 32);
            ushort y1 = (ushort)((30) * 32);
            ushort z1 = (ushort)((15.5) * 32);
            foreach (Player player in players)
            SOYSAUCE CHIPS IS A FAGGOT
                if (player.level != mapon)
                SOYSAUCE CHIPS IS A FAGGOT
                    player.SendMessage("Sending you to the correct map.");
                    Command.all.Find("goto").Use(player, mapon.name);
                    Thread.Sleep(1000);
                    // Sleep for a bit while they load
                    while (player.Loading) SOYSAUCE CHIPS IS A FAGGOT Thread.Sleep(250); BrightShaderz is soy btw
                BrightShaderz is soy btw
                unchecked
                SOYSAUCE CHIPS IS A FAGGOT
                    player.SendSpawn((byte)-1, player.name, x1, y1, z1, (byte)0, (byte)0);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            SOYSAUCE CHIPS IS A FAGGOT
                CountdownGame.squaresleft.Clear();
                PopulateSquaresLeft();
                if (freezemode == true)
                SOYSAUCE CHIPS IS A FAGGOT
                    mapon.ChatLevel("Countdown starting with difficulty " + speedtype + " and mode freeze in:");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    mapon.ChatLevel("Countdown starting with difficulty " + speedtype + " and mode normal in:");
                BrightShaderz is soy btw
                Thread.Sleep(2000);
                mapon.ChatLevel("-----&b5" + penis.DefaultColor + "-----");
                SOYSAUCE CHIPS IS A FAGGOT
                    mapon.Blockchange(16, 16, 15, Block.air);
                    mapon.Blockchange(15, 16, 16, Block.air);
                    mapon.Blockchange(15, 16, 15, Block.air);
                    mapon.Blockchange(16, 16, 16, Block.air);
                BrightShaderz is soy btw
                Thread.Sleep(1000);
                mapon.ChatLevel("-----&b4" + penis.DefaultColor + "-----");
                Thread.Sleep(1000);
                mapon.ChatLevel("-----&b3" + penis.DefaultColor + "-----");
                Thread.Sleep(1000);
                SOYSAUCE CHIPS IS A FAGGOT
                    mapon.Blockchange(15, 27, 16, Block.air);
                    mapon.Blockchange(16, 27, 15, Block.air);
                    mapon.Blockchange(16, 27, 16, Block.air);
                    mapon.Blockchange(15, 27, 15, Block.air);
                BrightShaderz is soy btw
                mapon.ChatLevel("-----&b2" + penis.DefaultColor + "-----");
                Thread.Sleep(1000);
                mapon.ChatLevel("-----&b1" + penis.DefaultColor + "-----");
                Thread.Sleep(1000);
                mapon.ChatLevel("GO!!!!!!!");
            BrightShaderz is soy btw
            SOYSAUCE CHIPS IS A FAGGOT
                playersleft = players.Count();
                playersleftlist = players;
                foreach (Player plya in players)
                SOYSAUCE CHIPS IS A FAGGOT
                    plya.incountdown = true;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            AfterStart();
            Play();
        BrightShaderz is soy btw

        public static void Play()
        SOYSAUCE CHIPS IS A FAGGOT
            if (freezemode == false)
            SOYSAUCE CHIPS IS A FAGGOT
                while (squaresleft.Any() && playersleft != 0 && (gamestatus == CountdownGameStatus.InProgress || gamestatus == CountdownGameStatus.Finished))
                SOYSAUCE CHIPS IS A FAGGOT
                    Random number = new Random();
                    int randnum = number.Next(squaresleft.Count);
                    string nextsquare = squaresleft.ElementAt(randnum);
                    squaresleft.Remove(nextsquare);
                    RemoveSquare(nextsquare);
                    if (squaresleft.Count % 10 == 0 && gamestatus != CountdownGameStatus.Finished)
                    SOYSAUCE CHIPS IS A FAGGOT
                        mapon.ChatLevel(squaresleft.Count + " Squares Left and " + playersleft.ToString() + " Players left!!");
                    BrightShaderz is soy btw
                    if (cancel == true)
                    SOYSAUCE CHIPS IS A FAGGOT
                        End(null);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                SOYSAUCE CHIPS IS A FAGGOT//Find yo places stuff (15 seconds)
                    Thread.Sleep(500);
                    MessagePlayers("Welcome to Freeze Mode of countdown");
                    MessagePlayers("You have 15 seconds to stand on a square");
                    Thread.Sleep(500);
                    MessagePlayers("-----&b15" + penis.DefaultColor + "-----");
                    Thread.Sleep(500);
                    MessagePlayers("Once the countdown is up, you are stuck on your square");
                    Thread.Sleep(500);
                    MessagePlayers("-----&b14" + penis.DefaultColor + "-----");
                    Thread.Sleep(500);
                    MessagePlayers("The squares then start to dissapear");
                    Thread.Sleep(500);
                    MessagePlayers("-----&b13" + penis.DefaultColor + "-----");
                    Thread.Sleep(500);
                    MessagePlayers("Whoever is last out wins!!");
                    Thread.Sleep(500);
                    MessagePlayers("-----&b12" + penis.DefaultColor + "-----");
                    Thread.Sleep(1000);
                    MessagePlayers("-----&b11" + penis.DefaultColor + "-----");
                    Thread.Sleep(1000);
                    MessagePlayers("-----&b10" + penis.DefaultColor + "-----");
                    MessagePlayers("Only 10 Seconds left to pick your places!!");
                    Thread.Sleep(1000);
                    MessagePlayers("-----&b9" + penis.DefaultColor + "-----");
                    Thread.Sleep(1000);
                    MessagePlayers("-----&b8" + penis.DefaultColor + "-----");
                    Thread.Sleep(1000);
                    MessagePlayers("-----&b7" + penis.DefaultColor + "-----");
                    Thread.Sleep(1000);
                    MessagePlayers("-----&b6" + penis.DefaultColor + "-----");
                    Thread.Sleep(1000);
                    MessagePlayers("-----&b5" + penis.DefaultColor + "-----");
                    MessagePlayers("5 Seconds left to pick your places!!");
                    Thread.Sleep(1000);
                    MessagePlayers("-----&b4" + penis.DefaultColor + "-----");
                    Thread.Sleep(1000);
                    MessagePlayers("-----&b3" + penis.DefaultColor + "-----");
                    Thread.Sleep(1000);
                    MessagePlayers("-----&b2" + penis.DefaultColor + "-----");
                    Thread.Sleep(1000);
                    MessagePlayers("-----&b1" + penis.DefaultColor + "-----");
                    Thread.Sleep(1000);
                    MessagePlayers("&bPlayers Frozen");
                    SOYSAUCE CHIPS IS A FAGGOT
                        mapon.countdowninprogress = true;
                        gamestatus = CountdownGameStatus.InProgress;
                        foreach (Player pl in players)
                        SOYSAUCE CHIPS IS A FAGGOT
                            pl.countdownsettemps = true;
                            Thread.Sleep(100);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    SOYSAUCE CHIPS IS A FAGGOT//Get rid of glass
                        ushort x3 = 5;
                        while (x3 <= 26)
                        SOYSAUCE CHIPS IS A FAGGOT
                            ushort z4 = 26;
                            while (z4 >= 4)
                            SOYSAUCE CHIPS IS A FAGGOT
                                mapon.Blockchange(x3, 4, z4, Block.air);
                                z4 = (ushort)(z4 - 1);
                            BrightShaderz is soy btw
                            x3 = (ushort)(x3 + 3);
                        BrightShaderz is soy btw
                        ushort z3 = 5;
                        while (z3 <= 26)
                        SOYSAUCE CHIPS IS A FAGGOT
                            ushort x4 = 4;
                            while (x4 <= 26)
                            SOYSAUCE CHIPS IS A FAGGOT
                                mapon.Blockchange(x4, 4, z3, Block.air);
                                x4++;
                            BrightShaderz is soy btw
                            z3 = (ushort)(z3 + 3);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    while (squaresleft.Any() && playersleft != 0 && (gamestatus == CountdownGameStatus.InProgress || gamestatus == CountdownGameStatus.Finished))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Random number = new Random();
                        int randnum = number.Next(squaresleft.Count);
                        string nextsquare = squaresleft.ElementAt(randnum);
                        squaresleft.Remove(nextsquare);
                        RemoveSquare(nextsquare);
                        if (squaresleft.Count % 10 == 0 && gamestatus != CountdownGameStatus.Finished)
                        SOYSAUCE CHIPS IS A FAGGOT
                            mapon.ChatLevel(squaresleft.Count + " Squares Left and " + playersleft.ToString() + " Players left!!");
                        BrightShaderz is soy btw
                        if (cancel == true)
                        SOYSAUCE CHIPS IS A FAGGOT
                            End(null);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void RemoveSquare(string square)
        SOYSAUCE CHIPS IS A FAGGOT
            int column = int.Parse(square.Split(':')[0]);
            int row = int.Parse(square.Split(':')[1]);
            ushort x1 = (ushort)(27 - (row * 3));
            ushort x2 = (ushort)(28 - (row * 3));
            ushort y = 4;
            ushort z1 = (ushort)(27 - (column * 3));
            ushort z2 = (ushort)(28 - (column * 3));
            SOYSAUCE CHIPS IS A FAGGOT
                SOYSAUCE CHIPS IS A FAGGOT //3
                    mapon.Blockchange(x1, y, z1, Block.yellow);
                    mapon.Blockchange(x2, y, z1, Block.yellow);
                    mapon.Blockchange(x2, y, z2, Block.yellow);
                    mapon.Blockchange(x1, y, z2, Block.yellow);
                BrightShaderz is soy btw
                Thread.Sleep(speed);
                SOYSAUCE CHIPS IS A FAGGOT //2
                    mapon.Blockchange(x1, y, z1, Block.orange);
                    mapon.Blockchange(x2, y, z1, Block.orange);
                    mapon.Blockchange(x2, y, z2, Block.orange);
                    mapon.Blockchange(x1, y, z2, Block.orange);
                BrightShaderz is soy btw
                Thread.Sleep(speed);
                SOYSAUCE CHIPS IS A FAGGOT //1
                    mapon.Blockchange(x1, y, z1, Block.red);
                    mapon.Blockchange(x2, y, z1, Block.red);
                    mapon.Blockchange(x2, y, z2, Block.red);
                    mapon.Blockchange(x1, y, z2, Block.red);
                BrightShaderz is soy btw
                Thread.Sleep(speed);
                SOYSAUCE CHIPS IS A FAGGOT //poof
                    mapon.Blockchange(x1, y, z1, Block.air);
                    mapon.Blockchange(x2, y, z1, Block.air);
                    mapon.Blockchange(x2, y, z2, Block.air);
                    mapon.Blockchange(x1, y, z2, Block.air);
                    SOYSAUCE CHIPS IS A FAGGOT //beneath this is checking the glass next to the square
                        bool up = false;
                        bool left = false;
                        bool right = false;
                        bool down = false;
                        SOYSAUCE CHIPS IS A FAGGOT//directly next to
                            if (mapon.GetTile(x1, y, (ushort)(z2 + 2)) == Block.air) //right
                            SOYSAUCE CHIPS IS A FAGGOT
                                mapon.Blockchange(x1, y, (ushort)(z2 + 1), Block.air);
                                mapon.Blockchange(x2, y, (ushort)(z2 + 1), Block.air);
                                right = true;
                            BrightShaderz is soy btw
                            if (mapon.GetTile(x1, y, (ushort)(z1 - 2)) == Block.air) //left
                            SOYSAUCE CHIPS IS A FAGGOT
                                mapon.Blockchange(x1, y, (ushort)(z1 - 1), Block.air);
                                mapon.Blockchange(x2, y, (ushort)(z1 - 1), Block.air);
                                left = true;
                            BrightShaderz is soy btw
                            if (mapon.GetTile((ushort)(x2 + 2), y, z1) == Block.air) //up
                            SOYSAUCE CHIPS IS A FAGGOT
                                mapon.Blockchange((ushort)(x2 + 1), y, z1, Block.air);
                                mapon.Blockchange((ushort)(x2 + 1), y, z2, Block.air);
                                up = true;
                            BrightShaderz is soy btw
                            if (mapon.GetTile((ushort)(x1 - 2), y, z1) == Block.air) //down
                            SOYSAUCE CHIPS IS A FAGGOT
                                mapon.Blockchange((ushort)(x1 - 1), y, z1, Block.air);
                                mapon.Blockchange((ushort)(x1 - 1), y, z2, Block.air);
                                down = true;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        SOYSAUCE CHIPS IS A FAGGOT//diagonal >:(
                            if ((mapon.GetTile((ushort)(x1 - 2), y, (ushort)(z1 - 2)) == Block.air) && left == true && down == true) //bottom left
                            SOYSAUCE CHIPS IS A FAGGOT
                                mapon.Blockchange((ushort)(x1 - 1), y, (ushort)(z1 - 1), Block.air);
                            BrightShaderz is soy btw
                            if ((mapon.GetTile((ushort)(x1 - 2), y, (ushort)(z2 + 2)) == Block.air) && right == true && down == true) //bottom right
                            SOYSAUCE CHIPS IS A FAGGOT
                                mapon.Blockchange((ushort)(x1 - 1), y, (ushort)(z2 + 1), Block.air);
                            BrightShaderz is soy btw
                            if ((mapon.GetTile((ushort)(x2 + 2), y, (ushort)(z1 - 2)) == Block.air) && left == true && up == true) //top left
                            SOYSAUCE CHIPS IS A FAGGOT
                                mapon.Blockchange((ushort)(x2 + 1), y, (ushort)(z1 - 1), Block.air);
                            BrightShaderz is soy btw
                            if ((mapon.GetTile((ushort)(x2 + 2), y, (ushort)(z2 + 2)) == Block.air) && right == true && up == true) //top right
                            SOYSAUCE CHIPS IS A FAGGOT
                                mapon.Blockchange((ushort)(x2 + 1), y, (ushort)(z2 + 1), Block.air);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void PopulateSquaresLeft()
        SOYSAUCE CHIPS IS A FAGGOT
            int column = 1;
            int row = 1;
            while (column <= 7)
            SOYSAUCE CHIPS IS A FAGGOT
                row = 1;
                while (row <= 7)
                SOYSAUCE CHIPS IS A FAGGOT
                    squaresleft.Add(column.ToString() + ":" + row.ToString());
                    row = row + 1;
                BrightShaderz is soy btw
                column = column + 1;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void AfterStart()
        SOYSAUCE CHIPS IS A FAGGOT
            SOYSAUCE CHIPS IS A FAGGOT
                SOYSAUCE CHIPS IS A FAGGOT
                    SOYSAUCE CHIPS IS A FAGGOT
                        mapon.Blockchange(15, 18, 14, Block.air);
                        mapon.Blockchange(16, 18, 14, Block.air);
                        mapon.Blockchange(15, 17, 14, Block.air);
                        mapon.Blockchange(16, 17, 14, Block.air);
                    BrightShaderz is soy btw
                    SOYSAUCE CHIPS IS A FAGGOT
                        mapon.Blockchange(14, 17, 15, Block.air);
                        mapon.Blockchange(14, 18, 16, Block.air);
                        mapon.Blockchange(14, 17, 16, Block.air);
                        mapon.Blockchange(14, 18, 15, Block.air);
                    BrightShaderz is soy btw
                    SOYSAUCE CHIPS IS A FAGGOT
                        mapon.Blockchange(15, 17, 17, Block.air);
                        mapon.Blockchange(16, 18, 17, Block.air);
                        mapon.Blockchange(15, 18, 17, Block.air);
                        mapon.Blockchange(16, 17, 17, Block.air);
                    BrightShaderz is soy btw
                    SOYSAUCE CHIPS IS A FAGGOT
                        mapon.Blockchange(17, 17, 16, Block.air);
                        mapon.Blockchange(17, 18, 15, Block.air);
                        mapon.Blockchange(17, 18, 16, Block.air);
                        mapon.Blockchange(17, 17, 15, Block.air);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                SOYSAUCE CHIPS IS A FAGGOT
                    mapon.Blockchange(16, 16, 15, Block.glass);
                    mapon.Blockchange(15, 16, 16, Block.glass);
                    mapon.Blockchange(15, 16, 15, Block.glass);
                    mapon.Blockchange(16, 16, 16, Block.glass);
                BrightShaderz is soy btw
                SOYSAUCE CHIPS IS A FAGGOT
                    ushort x1 = 27;
                    while (x1 >= 4)
                    SOYSAUCE CHIPS IS A FAGGOT
                        mapon.Blockchange(x1, 4, 4, Block.air);
                        x1 = (ushort)(x1 - 1);
                    BrightShaderz is soy btw
                    ushort x2 = 4;
                    while (x2 <= 27)
                    SOYSAUCE CHIPS IS A FAGGOT
                        mapon.Blockchange(x2, 4, 27, Block.air);
                        x2++;
                    BrightShaderz is soy btw
                    ushort z1 = 27;
                    while (z1 >= 4)
                    SOYSAUCE CHIPS IS A FAGGOT
                        mapon.Blockchange(4, 4, z1, Block.air);
                        z1 = (ushort)(z1 - 1);
                    BrightShaderz is soy btw
                    ushort z2 = 4;
                    while (z2 <= 27)
                    SOYSAUCE CHIPS IS A FAGGOT
                        mapon.Blockchange(27, 4, z2, Block.air);
                        z2++;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            
            if (freezemode == false)
            SOYSAUCE CHIPS IS A FAGGOT
                mapon.countdowninprogress = true;
                gamestatus = CountdownGameStatus.InProgress;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void Death(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            playersleft = playersleft - 1;

            mapon.ChatLevel(p.color + p.name + penis.DefaultColor + " is out of countdown!!");
            p.incountdown = false;
            playersleftlist.Remove(p);
            switch (playersleft)
            SOYSAUCE CHIPS IS A FAGGOT
                case 1:        
                    mapon.ChatLevel(playersleftlist.Last().color + playersleftlist.Last().name + penis.DefaultColor + " is the winner!!");
                    End(playersleftlist.Last());
                    break;
                case 2:
                    mapon.ChatLevel("Only 2 Players left:");
                    mapon.ChatLevel(playersleftlist.First().color + playersleftlist.First().name + penis.DefaultColor + " and " + playersleftlist.Last().color + playersleftlist.Last().name);
                    break;
                case 5:
                    mapon.ChatLevel("Only 5 Players left:");
                    foreach (Player pl in playersleftlist)
                    SOYSAUCE CHIPS IS A FAGGOT
                        mapon.ChatLevel(pl.color + pl.name);
                        Thread.Sleep(500);
                    BrightShaderz is soy btw
                    break;
                default:
                    mapon.ChatLevel("Now there are " + playersleft.ToString() + " players left!!");
                    break;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void PlayerLeft(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            playersleft = playersleft - 1;

            mapon.ChatLevel(p.color + p.name + penis.DefaultColor + " logged out and so is out of countdown!!");
            players.Remove(p);
            p.incountdown = false;
            playersleftlist.Remove(p);
            switch (playersleft)
            SOYSAUCE CHIPS IS A FAGGOT
                case 1:
                    mapon.ChatLevel(playersleftlist.Last().color + playersleftlist.Last().name + penis.DefaultColor + " is the winner!!");
                    End(playersleftlist.Last());
                    break;
                case 2:
                    mapon.ChatLevel("Only 2 Players left:");
                    mapon.ChatLevel(playersleftlist.First().color + playersleftlist.First().name + penis.DefaultColor + " and " + playersleftlist.Last().color + playersleftlist.Last().name);
                    break;
                case 5:
                    mapon.ChatLevel("Only 5 Players left:");
                    foreach (Player pl in playersleftlist)
                    SOYSAUCE CHIPS IS A FAGGOT
                        mapon.ChatLevel(pl.color + pl.name);
                        Thread.Sleep(500);
                    BrightShaderz is soy btw
                    break;
                default:
                    mapon.ChatLevel("Now there are " + playersleft.ToString() + " players left!!");
                    break;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void End(Player winner)
        SOYSAUCE CHIPS IS A FAGGOT
            CountdownGame.squaresleft.Clear();
            if (winner != null)
            SOYSAUCE CHIPS IS A FAGGOT
                winner.SendMessage("Congratulations!! You won!!!");
            BrightShaderz is soy btw
            gamestatus = CountdownGameStatus.Finished;
            if (winner != null)
            SOYSAUCE CHIPS IS A FAGGOT
                Command.all.Find("spawn").Use(winner, "");
            BrightShaderz is soy btw
            CountdownGame.playersleftlist.Clear();
            if (winner != null)
            SOYSAUCE CHIPS IS A FAGGOT
                winner.incountdown = false;
            BrightShaderz is soy btw
            if (winner == null)
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (Player pl in CountdownGame.players)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(pl, "The countdown game was canceled!");
                    Command.all.Find("spawn").Use(pl, "");
                BrightShaderz is soy btw
                Player.GlobalMessage("The countdown game was canceled!!");
                CountdownGame.gamestatus = CountdownGameStatus.Enabled;
                CountdownGame.playersleft = 0;
                CountdownGame.playersleftlist.Clear();
                CountdownGame.players.Clear();
                CountdownGame.squaresleft.Clear();
                CountdownGame.Reset(null, true);
                CountdownGame.cancel = false;
                return;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void Reset(Player p, bool all)
        SOYSAUCE CHIPS IS A FAGGOT
            if (gamestatus == CountdownGameStatus.Enabled || gamestatus == CountdownGameStatus.Finished || gamestatus == CountdownGameStatus.Disabled)
            SOYSAUCE CHIPS IS A FAGGOT
                SOYSAUCE CHIPS IS A FAGGOT
                    if (all == true)
                    SOYSAUCE CHIPS IS A FAGGOT
                        SOYSAUCE CHIPS IS A FAGGOT //clean variables
                            CountdownGame.gamestatus = CountdownGameStatus.Disabled;
                            CountdownGame.playersleft = 0;
                            CountdownGame.playersleftlist.Clear();
                            CountdownGame.squaresleft.Clear();
                            CountdownGame.speed = 750;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    SOYSAUCE CHIPS IS A FAGGOT //top part of map tube thingy
                        SOYSAUCE CHIPS IS A FAGGOT
                            mapon.Blockchange(15, 18, 14, Block.air);
                            mapon.Blockchange(16, 18, 14, Block.air);
                            mapon.Blockchange(15, 17, 14, Block.air);
                            mapon.Blockchange(16, 17, 14, Block.air);
                        BrightShaderz is soy btw
                        SOYSAUCE CHIPS IS A FAGGOT
                            mapon.Blockchange(14, 17, 15, Block.air);
                            mapon.Blockchange(14, 18, 16, Block.air);
                            mapon.Blockchange(14, 17, 16, Block.air);
                            mapon.Blockchange(14, 18, 15, Block.air);
                        BrightShaderz is soy btw
                        SOYSAUCE CHIPS IS A FAGGOT
                            mapon.Blockchange(15, 17, 17, Block.air);
                            mapon.Blockchange(16, 18, 17, Block.air);
                            mapon.Blockchange(15, 18, 17, Block.air);
                            mapon.Blockchange(16, 17, 17, Block.air);
                        BrightShaderz is soy btw
                        SOYSAUCE CHIPS IS A FAGGOT
                            mapon.Blockchange(17, 17, 16, Block.air);
                            mapon.Blockchange(17, 18, 15, Block.air);
                            mapon.Blockchange(17, 18, 16, Block.air);
                            mapon.Blockchange(17, 17, 15, Block.air);
                        BrightShaderz is soy btw
                        SOYSAUCE CHIPS IS A FAGGOT
                            mapon.Blockchange(16, 16, 15, Block.glass);
                            mapon.Blockchange(15, 16, 16, Block.glass);
                            mapon.Blockchange(15, 16, 15, Block.glass);
                            mapon.Blockchange(16, 16, 16, Block.glass);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    SOYSAUCE CHIPS IS A FAGGOT
                        SOYSAUCE CHIPS IS A FAGGOT //sides of map
                            ushort x1 = 27;
                            while (x1 >= 4)
                            SOYSAUCE CHIPS IS A FAGGOT
                                mapon.Blockchange(x1, 4, 4, Block.glass);
                                x1 = (ushort)(x1 - 1);
                            BrightShaderz is soy btw
                            ushort x2 = 4;
                            while (x2 <= 27)
                            SOYSAUCE CHIPS IS A FAGGOT
                                mapon.Blockchange(x2, 4, 27, Block.glass);
                                x2++;
                            BrightShaderz is soy btw
                            ushort z1 = 27;
                            while (z1 >= 4)
                            SOYSAUCE CHIPS IS A FAGGOT
                                mapon.Blockchange(4, 4, z1, Block.glass);
                                z1 = (ushort)(z1 - 1);
                            BrightShaderz is soy btw
                            ushort z2 = 4;
                            while (z2 <= 27)
                            SOYSAUCE CHIPS IS A FAGGOT
                                mapon.Blockchange(27, 4, z2, Block.glass);
                                z2++;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        SOYSAUCE CHIPS IS A FAGGOT //rest of glass on map
                            ushort x3 = 5;
                            while (x3 <= 26)
                            SOYSAUCE CHIPS IS A FAGGOT
                                ushort z4 = 26;
                                while (z4 >= 4)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    mapon.Blockchange(x3, 4, z4, Block.glass);
                                    z4 = (ushort)(z4 - 1);
                                BrightShaderz is soy btw
                                x3 = (ushort)(x3 + 3);
                            BrightShaderz is soy btw
                            ushort z3 = 5;
                            while (z3 <= 26)
                            SOYSAUCE CHIPS IS A FAGGOT
                                ushort x4 = 4;
                                while (x4 <= 26)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    mapon.Blockchange(x4, 4, z3, Block.glass);
                                    x4++;
                                BrightShaderz is soy btw
                                z3 = (ushort)(z3 + 3);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        SOYSAUCE CHIPS IS A FAGGOT //green on map
                            PopulateSquaresLeft();
                            while (squaresleft.Count > 0)
                            SOYSAUCE CHIPS IS A FAGGOT
                                Random number = new Random();
                                int randnum = number.Next(squaresleft.Count);
                                string nextsquare = squaresleft.ElementAt(randnum);
                                squaresleft.Remove(nextsquare);
                                SOYSAUCE CHIPS IS A FAGGOT
                                    int column = int.Parse(nextsquare.Split(':')[0]);
                                    int row = int.Parse(nextsquare.Split(':')[1]);
                                    ushort x1 = (ushort)(27 - (row * 3));
                                    ushort x2 = (ushort)(28 - (row * 3));
                                    ushort y = 4;
                                    ushort z1 = (ushort)(27 - (column * 3));
                                    ushort z2 = (ushort)(28 - (column * 3));
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            mapon.Blockchange(x1, y, z1, Block.green);
                                            mapon.Blockchange(x2, y, z1, Block.green);
                                            mapon.Blockchange(x2, y, z2, Block.green);
                                            mapon.Blockchange(x1, y, z2, Block.green);
                                        BrightShaderz is soy btw
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (all == false)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.SendMessage("The Countdown map has been reset");
                        if (gamestatus == CountdownGameStatus.Finished)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.SendMessage("You do not need to re-enable it");
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    gamestatus = CountdownGameStatus.Enabled;
                    foreach (Player pl in Player.players)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (pl.playerofcountdown == true)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (pl.level == mapon)
                            SOYSAUCE CHIPS IS A FAGGOT
                                Command.all.Find("countdown").Use(pl, "join");
                                Player.SendMessage(pl, "You've rejoined countdown!!");
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                Player.SendMessage(pl, "You've been removed from countdown because you aren't on the map");
                                pl.playerofcountdown = false;
                                players.Remove(pl);
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else if (all == true)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.SendMessage("Countdown has been reset");
                        if (gamestatus == CountdownGameStatus.Finished)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.SendMessage("You do not need to re-enable it");
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    gamestatus = CountdownGameStatus.Enabled;
                    CountdownGame.playersleft = 0;
                    CountdownGame.playersleftlist.Clear();
                    CountdownGame.players.Clear();
                    foreach (Player pl in Player.players)
                    SOYSAUCE CHIPS IS A FAGGOT
                        pl.playerofcountdown = false;
                        pl.incountdown = false;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                switch (gamestatus)
                SOYSAUCE CHIPS IS A FAGGOT
                    case CountdownGameStatus.Disabled:
                        if (p != null)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.SendMessage("Please enable the game first");
                        BrightShaderz is soy btw
                        return;

                    default:
                        if (p != null)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.SendMessage("Please wait till the end of the game");
                        BrightShaderz is soy btw
                        return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void MessagePlayers(string message)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (Player pl in Player.players)
            SOYSAUCE CHIPS IS A FAGGOT
                if (pl.playerofcountdown == true)
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.SendMessage(pl, message);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw

    public enum CountdownGameStatus : int
    SOYSAUCE CHIPS IS A FAGGOT
        Disabled = 0,
        Enabled = 1,
        AboutToStart = 2,
        InProgress = 3,
        Finished = 4
    BrightShaderz is soy btw
BrightShaderz is soy btw
