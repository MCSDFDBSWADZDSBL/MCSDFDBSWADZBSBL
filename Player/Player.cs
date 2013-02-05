/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCSong) Licensed under the
	Educational Community License, Version 2.0 (the "License"); you may
	not use this file except in compliance with the License. You may
	obtain a copy of the License at
	
	http://www.osedu.org/licenses/ECL-2.0
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the License is distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the License for the specific language governing
	permissions and limitations under the License.
*/
using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Data;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class Player
    SOYSAUCE CHIPS IS A FAGGOT
        public static List<Player> players = new List<Player>();
        public static Dictionary<string, string> left = new Dictionary<string, string>();
        public static List<Player> connections = new List<Player>(penis.players);
        public static List<string> emoteList = new List<string>();
        public static int totalMySQLFailed = 0;
        public static byte number SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return (byte)players.Count; BrightShaderz is soy btw BrightShaderz is soy btw
        static System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
        static MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

        public static bool storeHelp = false;
        public static string storedHelp = "";

        Socket socket;
        System.Timers.Timer loginTimer = new System.Timers.Timer(1000);
        public System.Timers.Timer pingTimer = new System.Timers.Timer(2000);
        System.Timers.Timer extraTimer = new System.Timers.Timer(22000);
        public System.Timers.Timer afkTimer = new System.Timers.Timer(2000);
        public int afkCount = 0;
        public DateTime afkStart;

        public bool megaBoid = false;
        public bool cmdTimer = false;

        byte[] buffer = new byte[0];
        byte[] tempbuffer = new byte[0xFF];
        public bool disconnected = false;

        public string name;
        public string realName;
       // public string displayedname;
        public byte id;
        public int userID = -1;
        public string ip;
        public string color;
        public Group group;
        public bool hidden = false;
        public bool painting = false;
        public bool muted = false;
        public bool jailed = false;
        public bool invincible = false;
        public string prefix = "";
        public string title = "";
        public string titlecolor;

       // public string loginmessage;
       // public string logoutmessage;

        public bool deleteMode = false;
        public bool ignorePermission = false;
        public bool ignoreGrief = false;
        public bool parseSmiley = true;
        public bool smileySaved = true;
        public bool opchat = false;
        public bool adminchat = false;
        public bool onWhitelist = false;
        public bool whisper = false;
        public string whisperTo = "";

        public bool warned = false;

        public string storedMessage = "";

        public bool trainGrab = false;
        public bool onTrain = false;

        public bool frozen = false;
        public string following = "";
        public string possess = "";
        
        // Only used for possession.
        //Using for anything else can cause unintended effects!
        public bool canBuild = true;

        public int money = 0;
        public Int64 overallBlocks = 0;
        public int loginBlocks = 0;

        public DateTime timeLogged;
        public DateTime firstLogin;
        public int totalLogins = 0;
        public int totalKicked = 0;
        public int overallDeath = 0;

        public string savedcolor = "";

        public bool staticCommands = false;

        public DateTime ZoneSpam;
        public bool ZoneCheck = false;
        public bool zoneDel = false;

        public Thread commThread;
        public bool commUse = false;

        // Chat Spam Filter
        public int sameMessages = 0;
        public string lastMessage = "";

        public bool aiming;
        public bool isFlying = false;

        public bool joker = false;

        public bool voice = false;
        public string voicestring = "";

        //CTF
        public Team team;
        public Team hasflag;
        public string CTFtempcolor;
        public string CTFtempprefix;
        public bool carryingFlag;
        public bool spawning = false;
        public bool teamchat = false;
        public int health = 100;

        //Copy
        public List<CopyPos> CopyBuffer = new List<CopyPos>();
        public struct CopyPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; public byte type; BrightShaderz is soy btw
        public bool copyAir = false;
        public int[] copyoffset = new int[3] SOYSAUCE CHIPS IS A FAGGOT 0, 0, 0 BrightShaderz is soy btw;
        public ushort[] copystart = new ushort[3] SOYSAUCE CHIPS IS A FAGGOT 0, 0, 0 BrightShaderz is soy btw;

        //Undo
        public struct UndoPos SOYSAUCE CHIPS IS A FAGGOT public ushort x, y, z; public byte type, newtype; public string mapName; public DateTime timePlaced; BrightShaderz is soy btw
        public List<UndoPos> UndoBuffer = new List<UndoPos>();
        public List<UndoPos> RedoBuffer = new List<UndoPos>();
        

        public bool showPortals = false;
        public bool showMBs = false;

        public string prevMsg = "";


        //Movement
        public ushort oldBlock = 0;
        public ushort deathCount = 0;
        public byte deathBlock;

        //Games
        public DateTime lastDeath = DateTime.Now;
        
        public byte BlockAction = 0;  //0-Nothing 1-solid 2-lava 3-water 4-active_lava 5 Active_water 6 OpGlass 7 BluePort 8 OrangePort
        public byte modeType = 0;
        public byte[] bindings = new byte[128];
        public string[] cmdBind = new string[10];
        public string[] messageBind = new string[10];
        public string lastCMD = "";

        public Level level = penis.mainLevel;
        public bool Loading = true;     //True if player is loading a map.

        public delegate void BlockchangeEventHandler(Player p, ushort x, ushort y, ushort z, byte type);
        public event BlockchangeEventHandler Blockchange = null;
        public void ClearBlockchange() SOYSAUCE CHIPS IS A FAGGOT Blockchange = null; BrightShaderz is soy btw
        public bool HasBlockchange() SOYSAUCE CHIPS IS A FAGGOT return (Blockchange == null); BrightShaderz is soy btw
        public object blockchangeObject = null;
        public ushort[] lastClick = new ushort[3] SOYSAUCE CHIPS IS A FAGGOT 0, 0, 0 BrightShaderz is soy btw;

        public ushort[] pos = new ushort[3] SOYSAUCE CHIPS IS A FAGGOT 0, 0, 0 BrightShaderz is soy btw;
        ushort[] oldpos = new ushort[3] SOYSAUCE CHIPS IS A FAGGOT 0, 0, 0 BrightShaderz is soy btw;
        ushort[] basepos = new ushort[3] SOYSAUCE CHIPS IS A FAGGOT 0, 0, 0 BrightShaderz is soy btw;
        public byte[] rot = new byte[2] SOYSAUCE CHIPS IS A FAGGOT 0, 0 BrightShaderz is soy btw;
        byte[] oldrot = new byte[2] SOYSAUCE CHIPS IS A FAGGOT 0, 0 BrightShaderz is soy btw;

        // grief/spam detection
        public static int spamBlockCount = penis.blockSpamCount;
        public static int spamBlockTimer = penis.blockSpamSeconds;
        Queue<DateTime> spamBlockLog = new Queue<DateTime>(spamBlockCount);

        public bool loggedIn = false;
        public Player(Socket s)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                socket = s;
                ip = socket.RemoteEndPoint.ToString().Split(':')[0];
                penis.s.Log(ip + " connected to the penis.");

                for (byte i = 0; i < 128; ++i) bindings[i] = i;

                socket.BeginReceive(tempbuffer, 0, tempbuffer.Length, SocketFlags.None, new AsyncCallback(Receive), this);

                loginTimer.Elapsed += delegate
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!Loading)
                    SOYSAUCE CHIPS IS A FAGGOT
                        loginTimer.Stop();

                        if (File.Exists("text/welcome.txt"))
                        SOYSAUCE CHIPS IS A FAGGOT
                            try
                            SOYSAUCE CHIPS IS A FAGGOT
                                List<string> welcome = new List<string>();
                                StreamReader wm = File.OpenText("text/welcome.txt");
                                while (!wm.EndOfStream)
                                    welcome.Add(wm.ReadLine());

                                wm.Close();
                                wm.Dispose();

                                foreach (string w in welcome)
                                    SendMessage(w);
                            BrightShaderz is soy btw
                            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            penis.s.Log("Could not find Welcome.txt. Using default.");
                            File.WriteAllText("text/welcome.txt", "Welcome to my penis!");
                        BrightShaderz is soy btw
                        extraTimer.Start();
                    BrightShaderz is soy btw
                BrightShaderz is soy btw; loginTimer.Start();

                pingTimer.Elapsed += delegate SOYSAUCE CHIPS IS A FAGGOT SendPing(); BrightShaderz is soy btw;
                pingTimer.Start();

                extraTimer.Elapsed += delegate
                SOYSAUCE CHIPS IS A FAGGOT
                    extraTimer.Stop();

                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!Group.Find("Nobody").commands.Contains("inbox") && !Group.Find("Nobody").commands.Contains("send"))
                        SOYSAUCE CHIPS IS A FAGGOT
                            DataTable Inbox = MySQL.fillData("SELECT * FROM `Inbox" + name + "`", true);

                            SendMessage("&cYou have &f" + Inbox.Rows.Count + penis.DefaultColor + " &cmessages in /inbox");
                            Inbox.Dispose();
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    if (penis.updateTimer.Interval > 1000) SendMessage("Lowlag mode is currently &aON.");
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!Group.Find("Nobody").commands.Contains("pay") && !Group.Find("Nobody").commands.Contains("give") && !Group.Find("Nobody").commands.Contains("take")) SendMessage("You currently have &a" + money + penis.DefaultColor + " " + penis.moneys);
                    BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    SendMessage("You have modified &a" + overallBlocks + penis.DefaultColor + " blocks!");
                    if (players.Count == 1)
                        SendMessage("There is currently &a" + players.Count + " player online.");
                    else
                        SendMessage("There are currently &a" + players.Count + " players online.");
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!Group.Find("Nobody").commands.Contains("award") && !Group.Find("Nobody").commands.Contains("awards") && !Group.Find("Nobody").commands.Contains("awardmod")) SendMessage("You have " + Awards.awardAmount(name) + " awards.");
                    BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                BrightShaderz is soy btw;

                afkTimer.Elapsed += delegate
                SOYSAUCE CHIPS IS A FAGGOT
                    if (name == "") return;

                    if (penis.afkset.Contains(name))
                    SOYSAUCE CHIPS IS A FAGGOT
                        afkCount = 0;
                        /*if (penis.afkkick > 0 && group.Permission < LevelPermission.Operator)
                            if (afkStart.AddMinutes(penis.afkkick) < DateTime.Now)
                                Kick("Auto-kick, AFK for " + penis.afkkick + " minutes");*/
                        if ((oldpos[0] != pos[0] || oldpos[1] != pos[1] || oldpos[2] != pos[2]) && (oldrot[0] != rot[0] || oldrot[1] != rot[1]))
                            Command.all.Find("afk").Use(this, "");
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (oldpos[0] == pos[0] && oldpos[1] == pos[1] && oldpos[2] == pos[2] && oldrot[0] == rot[0] && oldrot[1] == rot[1])
                            afkCount++;
                        else
                            afkCount = 0;

                        if (afkCount > penis.afkminutes * 30)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Command.all.Find("afk").Use(this, "auto: Not moved for " + penis.afkminutes + " minutes");
                            afkCount = 0;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw;
                if (penis.afkminutes > 0) afkTimer.Start();

                connections.Add(this);
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT Kick("Login failed!"); penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void save()
        SOYSAUCE CHIPS IS A FAGGOT
            string commandString =
                "UPDATE Players SET IP='" + ip + "'" +
                ", LastLogin='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'" +
                ", totalLogin=" + totalLogins +
                ", totalDeaths=" + overallDeath +
                ", Money=" + money +
                ", totalBlocks=" + overallBlocks + " + " + loginBlocks +
                ", totalKicked=" + totalKicked +
                " WHERE Name='" + name + "'";

            MySQL.executeQuery(commandString);

            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (!smileySaved)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (parseSmiley)
                        emoteList.RemoveAll(s => s == name);
                    else
                        emoteList.Add(name);

                    File.WriteAllLines("text/emotelist.txt", emoteList.ToArray());
                    smileySaved = true;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT 
                penis.ErrorLog(e);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        #region == INCOMING ==
        static void Receive(IAsyncResult result)
        SOYSAUCE CHIPS IS A FAGGOT
        //    penis.s.Log(result.AsyncState.ToString());
            Player p = (Player)result.AsyncState;
            if (p.disconnected)
                return;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                int length = p.socket.EndReceive(result);
                if (length == 0) SOYSAUCE CHIPS IS A FAGGOT p.Disconnect(); return; BrightShaderz is soy btw

                byte[] b = new byte[p.buffer.Length + length];
                Buffer.BlockCopy(p.buffer, 0, b, 0, p.buffer.Length);
                Buffer.BlockCopy(p.tempbuffer, 0, b, p.buffer.Length, length);

                p.buffer = p.HandleMessage(b);
                p.socket.BeginReceive(p.tempbuffer, 0, p.tempbuffer.Length, SocketFlags.None,
                                      new AsyncCallback(Receive), p);
            BrightShaderz is soy btw
            catch (SocketException e)
            SOYSAUCE CHIPS IS A FAGGOT
                p.Disconnect();
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
                p.Kick("Error!");
                penis.s.Log("Attempting to restart listening socket...");
                penis.listen = null;
                if (penis.Setup()) SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Listening socket on port " + penis.port.ToString() + " restarted."); BrightShaderz is soy btw
                else SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Failed to restart listening socket."); BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        byte[] HandleMessage(byte[] buffer)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                int length = 0; byte msg = buffer[0];
                // Get the length of the message by checking the first byte
                switch (msg)
                SOYSAUCE CHIPS IS A FAGGOT
                    case 0:
                        length = 130;
                        break; // login
                    case 5:
                        if (!loggedIn)
                            goto default;
                        length = 8;
                        break; // blockchange
                    case 8:
                        if (!loggedIn)
                            goto default;
                        length = 9;
                        break; // input
                    case 13:
                        if (!loggedIn)
                            goto default;
                        length = 65;
                        break; // chat
                    default:
                        Kick("Unhandled message id \"" + msg + "\"!");
                        return new byte[0];
                BrightShaderz is soy btw
                if (buffer.Length > length)
                SOYSAUCE CHIPS IS A FAGGOT
                    byte[] message = new byte[length];
                    Buffer.BlockCopy(buffer, 1, message, 0, length);

                    byte[] tempbuffer = new byte[buffer.Length - length - 1];
                    Buffer.BlockCopy(buffer, length + 1, tempbuffer, 0, buffer.Length - length - 1);

                    buffer = tempbuffer;

                    // Thread thread = null; 
                    switch (msg)
                    SOYSAUCE CHIPS IS A FAGGOT
                        case 0:
                            HandleLogin(message);
                            break;
                        case 5:
                            if (!loggedIn)
                                break;
                            HandleBlockchange(message);
                            break;
                        case 8:
                            if (!loggedIn)
                                break;
                            HandleInput(message);
                            break;
                        case 13:
                            if (!loggedIn)
                                break;
                            HandleChat(message);
                            break;
                    BrightShaderz is soy btw
                    //thread.Start((object)message);
                    if (buffer.Length > 0)
                        buffer = HandleMessage(buffer);
                    else
                        return new byte[0];
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
            BrightShaderz is soy btw
            return buffer;
        BrightShaderz is soy btw
        void HandleLogin(byte[] message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                //byte[] message = (byte[])m;
                if (loggedIn)
                    return;

                byte version = message[0];
                name = enc.GetString(message, 1, 64).Trim();
                string verify = enc.GetString(message, 65, 32).Trim();
                byte type = message[129];
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.TempBan tBan = penis.tempBans.Find(tB => tB.name.ToLower() == name.ToLower());
                    if (tBan.allowedJoin < DateTime.Now)
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.tempBans.Remove(tBan);
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Kick("You're still banned (temporary ban until: " + tBan.allowedJoin.ToString() + ")");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                // OMNI BAN
                penis.obUpdate(this);
                // Whitelist check.
                if (penis.useWhitelist)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (penis.verify)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (penis.whiteList.Contains(name))
                        SOYSAUCE CHIPS IS A FAGGOT
                            onWhitelist = true;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        // Verify Names is off.  Gotta check the hard way.
                        DataTable ipQuery = MySQL.fillData("SELECT Name FROM Players WHERE IP = '" + ip + "'");

                        if (ipQuery.Rows.Count > 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (ipQuery.Rows.Contains(name) && penis.whiteList.Contains(name))
                            SOYSAUCE CHIPS IS A FAGGOT
                                onWhitelist = true;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        ipQuery.Dispose();
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                if (penis.bannedIP.Contains(ip))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (penis.useWhitelist)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!onWhitelist)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Kick(penis.customBanMessage);
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Kick(penis.customBanMessage);
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                if (penis.maintenanceMode)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (group.Permission < penis.maintRank)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Kick("Maintenance Mode! Come back later!");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                if (connections.Count >= 5) SOYSAUCE CHIPS IS A FAGGOT Kick("Too many connections!"); return; BrightShaderz is soy btw

                if (Group.findPlayerGroup(name) == Group.findPerm(LevelPermission.Banned))
                SOYSAUCE CHIPS IS A FAGGOT
                    if (penis.useWhitelist)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!onWhitelist)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Kick(penis.customBanMessage);
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Kick(penis.customBanMessage);
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (Player.players.Count >= penis.players && ip != "127.0.0.1") SOYSAUCE CHIPS IS A FAGGOT Kick("penis full!"); return; BrightShaderz is soy btw
                DataTable playerTable = MySQL.fillData("SELECT * FROM Players WHERE Name='" + name + "'");
                if (playerTable.Rows.Count == 0) SOYSAUCE CHIPS IS A FAGGOT if (ip != "127.0.0.1" && !penis.devs.Contains(name.ToLower()) && !penis.staff.Contains(name.ToLower())) SOYSAUCE CHIPS IS A FAGGOT checkGuests(); BrightShaderz is soy btw BrightShaderz is soy btw
                playerTable.Dispose();
                if (version != penis.version) SOYSAUCE CHIPS IS A FAGGOT Kick("Wrong version!"); return; BrightShaderz is soy btw
                if (name.Length > 16 || !ValidName(name)) SOYSAUCE CHIPS IS A FAGGOT Kick("Illegal name!"); return; BrightShaderz is soy btw

                if (penis.verify)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (verify == "--" || verify != 
                        BitConverter.ToString(md5.ComputeHash(enc.GetBytes(penis.salt + name)))
                        .Replace("-", "").ToLower().TrimStart('0'))
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (ip != "127.0.0.1" && ! ip.StartsWith("192.168."))
                        SOYSAUCE CHIPS IS A FAGGOT
                            Kick("Login failed! Try again."); return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                foreach (Player p in players)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.name == name)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (penis.verify)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.Kick("Someone logged in as you!"); break;
                        BrightShaderz is soy btw
                        else SOYSAUCE CHIPS IS A FAGGOT Kick("Already logged in!"); return; BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                
                try SOYSAUCE CHIPS IS A FAGGOT left.Remove(name.ToLower()); BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                group = Group.findPlayerGroup(name);

                SendMotd();
                SendMap();
                Loading = true;

                if (disconnected) return;

                loggedIn = true;
                id = FreeId();

                players.Add(this);
                connections.Remove(this);

                penis.s.PlayerListUpdate();

                IRCBot.Say(name + " joined the game.");

                //Test code to show when people come back with different accounts on the same IP
                string temp = "Lately known as:";
                bool found = false;
                if (ip != "127.0.0.1")
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (KeyValuePair<string, string> prev in left)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (prev.Value == ip)
                        SOYSAUCE CHIPS IS A FAGGOT
                            found = true;
                            temp += " " + prev.Key;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    if (found)
                    SOYSAUCE CHIPS IS A FAGGOT
                        GlobalMessageOps(temp);
                        penis.s.Log(temp);
                        IRCBot.Say(temp, true);       //Tells people in op channel on IRC
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
                Player.GlobalMessage("An error occurred: " + e.Message);
            BrightShaderz is soy btw

            DataTable playerDb = MySQL.fillData("SELECT * FROM Players WHERE Name='" + name + "'");

            if (playerDb.Rows.Count == 0)
            SOYSAUCE CHIPS IS A FAGGOT               
                this.prefix = "";
                this.titlecolor = "";
                this.color = group.color;
                this.money = 0;
                this.firstLogin = DateTime.Now;
                this.totalLogins = 1;
                this.totalKicked = 0;
                this.overallDeath = 0;
                this.overallBlocks = 0;
                this.timeLogged = DateTime.Now;
                SendMessage("Welcome " + name + "! This is your first visit.");

                MySQL.executeQuery("INSERT INTO Players (Name, IP, FirstLogin, LastLogin, totalLogin, Title, totalDeaths, Money, totalBlocks, totalKicked)" +
                    "VALUES ('" + name + "', '" + ip + "', '" + firstLogin.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', " + totalLogins +
                    ", '" + prefix + "', " + overallDeath + ", " + money + ", " + loginBlocks + ", " + totalKicked + ")");

            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                totalLogins = int.Parse(playerDb.Rows[0]["totalLogin"].ToString()) + 1;
                userID = int.Parse(playerDb.Rows[0]["ID"].ToString());
                firstLogin = DateTime.Parse(playerDb.Rows[0]["firstLogin"].ToString());
                timeLogged = DateTime.Now;
                if (playerDb.Rows[0]["Title"].ToString().Trim() != "")
                SOYSAUCE CHIPS IS A FAGGOT
                    string parse = playerDb.Rows[0]["Title"].ToString().Trim().Replace("[", "");
                    title = parse.Replace("]", "");
                BrightShaderz is soy btw
                if (playerDb.Rows[0]["title_color"].ToString().Trim() != "")
                SOYSAUCE CHIPS IS A FAGGOT
                    titlecolor = c.Parse(playerDb.Rows[0]["title_color"].ToString().Trim());
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    titlecolor = "";
                BrightShaderz is soy btw
                if (playerDb.Rows[0]["color"].ToString().Trim() != "")
                SOYSAUCE CHIPS IS A FAGGOT
                    color = c.Parse(playerDb.Rows[0]["color"].ToString().Trim());
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    color = group.color;
                BrightShaderz is soy btw
                SetPrefix();
                overallDeath = int.Parse(playerDb.Rows[0]["TotalDeaths"].ToString());
                overallBlocks = int.Parse(playerDb.Rows[0]["totalBlocks"].ToString().Trim());
                money = int.Parse(playerDb.Rows[0]["Money"].ToString());
                totalKicked = int.Parse(playerDb.Rows[0]["totalKicked"].ToString());
                SendMessage("Welcome back " + color + prefix + name + penis.DefaultColor + "! You've been here " + totalLogins + " times!");
            BrightShaderz is soy btw
            playerDb.Dispose();

            if (penis.devs.Contains(this.name.ToLower()))
            SOYSAUCE CHIPS IS A FAGGOT
                if (color == Group.standard.color)
                SOYSAUCE CHIPS IS A FAGGOT
                    color = "&1";
                BrightShaderz is soy btw
                if (titlecolor == Group.standard.color)
                SOYSAUCE CHIPS IS A FAGGOT
                    titlecolor = "&f";
                BrightShaderz is soy btw
                if (prefix == "")
                SOYSAUCE CHIPS IS A FAGGOT
                    title = "Developer";
                BrightShaderz is soy btw
                SetPrefix();
            BrightShaderz is soy btw

            try
            SOYSAUCE CHIPS IS A FAGGOT
                ushort x = (ushort)((0.5 + level.spawnx) * 32);
                ushort y = (ushort)((1 + level.spawny) * 32);
                ushort z = (ushort)((0.5 + level.spawnz) * 32);
                pos = new ushort[3] SOYSAUCE CHIPS IS A FAGGOT x, y, z BrightShaderz is soy btw; rot = new byte[2] SOYSAUCE CHIPS IS A FAGGOT level.rotx, level.roty BrightShaderz is soy btw;

                GlobalSpawn(this, x, y, z, rot[0], rot[1], true);
                foreach (Player p in players)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.level == level && p != this && !p.hidden)
                        SendSpawn(p.id, p.color + p.name, p.pos[0], p.pos[1], p.pos[2], p.rot[0], p.rot[1]);
                BrightShaderz is soy btw
                foreach (PlayerBot pB in PlayerBot.playerbots)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (pB.level == level)
                        SendSpawn(pB.id, pB.color + pB.name, pB.pos[0], pB.pos[1], pB.pos[2], pB.rot[0], pB.rot[1]);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
                penis.s.Log("Error spawning player \"" + name + "\"");
            BrightShaderz is soy btw

            Loading = false;

            if (emoteList.Contains(name)) parseSmiley = false;
            GlobalChat(null, "&a+ " + this.color + this.prefix + this.name + penis.DefaultColor + " has joined the game.", false);
            penis.s.Log(name + " [" + ip + "] has joined the penis.");
        BrightShaderz is soy btw

        public void checkGuests()
        SOYSAUCE CHIPS IS A FAGGOT
            int guests = 0;
            foreach (Player p in Player.players)
            SOYSAUCE CHIPS IS A FAGGOT
                if (this != p)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.group.Permission == Group.Find(penis.defaultRank).Permission)
                    SOYSAUCE CHIPS IS A FAGGOT
                        guests += 1;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (guests >= penis.guests)
                SOYSAUCE CHIPS IS A FAGGOT
                    Kick("Too many guests!");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void SetPrefix()
        SOYSAUCE CHIPS IS A FAGGOT
            prefix = (title == "") ? "" : (titlecolor == "") ? "[" + title + "] " : "[" + titlecolor + title + "] " + color;
        BrightShaderz is soy btw

        void HandleBlockchange(byte[] message)
        SOYSAUCE CHIPS IS A FAGGOT
            int section = 0;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                //byte[] message = (byte[])m;
                if (!loggedIn)
                    return;
                if (CheckBlockSpam())
                    return;

                section++;
                ushort x = NTHO(message, 0);
                ushort y = NTHO(message, 2);
                ushort z = NTHO(message, 4);
                byte action = message[6];
                byte type = message[7];

                manualChange(x, y, z, action, type);
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                // Don't ya just love it when the penis tattles?
                GlobalMessageOps(name + " has triggered a block change error");
                penis.ErrorLog(e);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public void manualChange(ushort x, ushort y, ushort z, byte action, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            if (type > 49)
            SOYSAUCE CHIPS IS A FAGGOT
                Kick("Unknown block type!");
                return;
            BrightShaderz is soy btw

            byte b = level.GetTile(x, y, z);
            if (b == Block.Zero) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
            if (jailed) SOYSAUCE CHIPS IS A FAGGOT SendBlockchange(x, y, z, b); return; BrightShaderz is soy btw
            if (level.name.Contains("Museum " + penis.DefaultColor) && Blockchange == null)
            SOYSAUCE CHIPS IS A FAGGOT
                return;
            BrightShaderz is soy btw

            if (!deleteMode)
            SOYSAUCE CHIPS IS A FAGGOT
                string info = level.foundInfo(x, y, z);
                if (info.Contains("wait")) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (!canBuild)
            SOYSAUCE CHIPS IS A FAGGOT
                SendBlockchange(x, y, z, b);
                return;
            BrightShaderz is soy btw

            Level.BlockPos bP;
            bP.name = name;
            bP.TimePerformed = DateTime.Now;
            bP.x = x; bP.y = y; bP.z = z;
            bP.type = type;

            lastClick[0] = x;
            lastClick[1] = y;
            lastClick[2] = z;

            if (Blockchange != null)
            SOYSAUCE CHIPS IS A FAGGOT
                if (Blockchange.Method.ToString().IndexOf("AboutBlockchange") == -1 && !level.name.Contains("Museum " + penis.DefaultColor))
                SOYSAUCE CHIPS IS A FAGGOT
                    bP.deleted = true;
                    level.blockCache.Add(bP);
                BrightShaderz is soy btw

                Blockchange(this, x, y, z, type);
                return;
            BrightShaderz is soy btw

            if (group.Permission == LevelPermission.Banned) return;
            if (group.Permission == LevelPermission.Guest)
            SOYSAUCE CHIPS IS A FAGGOT
                int Diff = 0;

                Diff = Math.Abs((int)(pos[0] / 32) - x);
                Diff += Math.Abs((int)(pos[1] / 32) - y);
                Diff += Math.Abs((int)(pos[2] / 32) - z);

                if (Diff > 12)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.s.Log(name + " attempted to build with a " + Diff.ToString() + " distance offset");
                    GlobalMessageOps("To Ops &f-" + color + name + "&f- attempted to build with a " + Diff.ToString() + " distance offset");
                    SendMessage("You can't build that far away.");
                    SendBlockchange(x, y, z, b); return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (group.Permission <= penis.tunnelRank)
            SOYSAUCE CHIPS IS A FAGGOT
                if (penis.antiTunnel)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!ignoreGrief)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (y < level.depth / 2 - penis.maxDepth)
                        SOYSAUCE CHIPS IS A FAGGOT
                            SendMessage("You're not allowed to build this far down!");
                            SendBlockchange(x, y, z, b); return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (!Block.canPlace(this, b) && !Block.BuildIn(b) && !Block.AllowBreak(b))
            SOYSAUCE CHIPS IS A FAGGOT
                SendMessage("Cannot build here!");
                SendBlockchange(x, y, z, b);
                return;
            BrightShaderz is soy btw

            if (!Block.canPlace(this, type))
            SOYSAUCE CHIPS IS A FAGGOT
                SendMessage("You can't place this block type!");
                SendBlockchange(x, y, z, b); 
                return;
            BrightShaderz is soy btw

            if (b >= 200 && b < 220)
            SOYSAUCE CHIPS IS A FAGGOT
                SendMessage("Block is active, you cant disturb it!");
                SendBlockchange(x, y, z, b);
                return;
            BrightShaderz is soy btw


            if (action > 1) SOYSAUCE CHIPS IS A FAGGOT Kick("Unknown block action!"); BrightShaderz is soy btw

            byte oldType = type;
            type = bindings[type];
            //Ignores updating blocks that are the same and send block only to the player
            if (b == (byte)((painting || action == 1) ? type : 0))
            SOYSAUCE CHIPS IS A FAGGOT
                if (painting || oldType != type) SOYSAUCE CHIPS IS A FAGGOT SendBlockchange(x, y, z, b); BrightShaderz is soy btw return;
            BrightShaderz is soy btw
            //else

            if (!painting && action == 0)
            SOYSAUCE CHIPS IS A FAGGOT
                if (!deleteMode)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (Block.portal(b)) SOYSAUCE CHIPS IS A FAGGOT HandlePortal(this, x, y, z, b); return; BrightShaderz is soy btw
                    if (Block.mb(b)) SOYSAUCE CHIPS IS A FAGGOT HandleMsgBlock(this, x, y, z, b); return; BrightShaderz is soy btw
                BrightShaderz is soy btw

                bP.deleted = true;
                level.blockCache.Add(bP);
                deleteBlock(b, type, x, y, z);
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                bP.deleted = false;
                level.blockCache.Add(bP);
                placeBlock(b, type, x, y, z);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void HandlePortal(Player p, ushort x, ushort y, ushort z, byte b)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                DataTable Portals = MySQL.fillData("SELECT * FROM `Portals" + level.name + "` WHERE EntryX=" + (int)x + " AND EntryY=" + (int)y + " AND EntryZ=" + (int)z);

                int LastPortal = Portals.Rows.Count - 1;
                if (LastPortal > -1)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (level.name != Portals.Rows[LastPortal]["ExitMap"].ToString())
                    SOYSAUCE CHIPS IS A FAGGOT
                        ignorePermission = true;
                        Level thisLevel = level;
                        Command.all.Find("goto").Use(this, Portals.Rows[LastPortal]["ExitMap"].ToString());
                        if (thisLevel == level) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "The map the portal goes to isn't loaded."); return; BrightShaderz is soy btw
                        ignorePermission = false;
                    BrightShaderz is soy btw
                    else SendBlockchange(x, y, z, b);

                    while (p.Loading) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw  //Wait for player to spawn in new map
                    Command.all.Find("move").Use(this, this.name + " " + Portals.Rows[LastPortal]["ExitX"].ToString() + " " + Portals.Rows[LastPortal]["ExitY"].ToString() + " " + Portals.Rows[LastPortal]["ExitZ"].ToString());
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Blockchange(this, x, y, z, (byte)0);
                BrightShaderz is soy btw
                Portals.Dispose();
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Portal had no exit."); return; BrightShaderz is soy btw
        BrightShaderz is soy btw
/*
        public void HandleHome(Player p)
        SOYSAUCE CHIPS IS A FAGGOT

        BrightShaderz is soy btw
*/
        public void HandleMsgBlock(Player p, ushort x, ushort y, ushort z, byte b)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                DataTable Messages = MySQL.fillData("SELECT * FROM `Messages" + level.name + "` WHERE X=" + (int)x + " AND Y=" + (int)y + " AND Z=" + (int)z);

                int LastMsg = Messages.Rows.Count - 1;
                if (LastMsg > -1)
                SOYSAUCE CHIPS IS A FAGGOT
                    string message = Messages.Rows[LastMsg]["Message"].ToString().Trim();
                    if (message != prevMsg || penis.repeatMessage)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, message);
                        prevMsg = message;
                    BrightShaderz is soy btw
                    SendBlockchange(x, y, z, b);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Blockchange(this, x, y, z, (byte)0);
                BrightShaderz is soy btw
                Messages.Dispose();
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "No message was stored."); return; BrightShaderz is soy btw
        BrightShaderz is soy btw

        private bool checkOp()
        SOYSAUCE CHIPS IS A FAGGOT
            return group.Permission < LevelPermission.Operator;
        BrightShaderz is soy btw

        private void deleteBlock(byte b, byte type, ushort x, ushort y, ushort z)
        SOYSAUCE CHIPS IS A FAGGOT
            Random rand = new Random();
            int mx, mz;

            if (deleteMode) SOYSAUCE CHIPS IS A FAGGOT level.Blockchange(this, x, y, z, Block.air); return; BrightShaderz is soy btw

            if (Block.tDoor(b)) SOYSAUCE CHIPS IS A FAGGOT SendBlockchange(x, y, z, b); return; BrightShaderz is soy btw
            if (Block.DoorAirs(b) != 0)
            SOYSAUCE CHIPS IS A FAGGOT
                if (level.physics != 0) level.Blockchange(x, y, z, Block.DoorAirs(b));
                else SendBlockchange(x, y, z, b);
                return;
            BrightShaderz is soy btw
            if (Block.odoor(b) != Block.Zero)
            SOYSAUCE CHIPS IS A FAGGOT
                if (b == Block.odoor8 || b == Block.odoor8_air)
                SOYSAUCE CHIPS IS A FAGGOT
                    level.Blockchange(this, x, y, z, Block.odoor(b));
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    SendBlockchange(x, y, z, b);
                BrightShaderz is soy btw
                return;
            BrightShaderz is soy btw

            switch (b)
            SOYSAUCE CHIPS IS A FAGGOT
                case Block.door_air:   //Door_air
                case Block.door2_air:
                case Block.door3_air:
                case Block.door4_air:
                case Block.door5_air:
                case Block.door6_air:
                case Block.door7_air:
                case Block.door8_air:
                case Block.door9_air:
                case Block.door10_air:
                case Block.door_iron_air:
                case Block.door_dirt_air:
                case Block.door_grass_air:
                case Block.door_blue_air:
                case Block.door_book_air:
                    break;
                case Block.rocketstart:
                    if (level.physics < 2)
                    SOYSAUCE CHIPS IS A FAGGOT
                        SendBlockchange(x, y, z, b);
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        int newZ = 0, newX = 0, newY = 0;

                        SendBlockchange(x, y, z, Block.rocketstart);
                        if (rot[0] < 48 || rot[0] > (256 - 48))
                            newZ = -1;
                        else if (rot[0] > (128 - 48) && rot[0] < (128 + 48))
                            newZ = 1;

                        if (rot[0] > (64 - 48) && rot[0] < (64 + 48))
                            newX = 1;
                        else if (rot[0] > (192 - 48) && rot[0] < (192 + 48))
                            newX = -1;

                        if (rot[1] >= 192 && rot[1] <= (192 + 32))
                            newY = 1;
                        else if (rot[1] <= 64 && rot[1] >= 32)
                            newY = -1;

                        if (192 <= rot[1] && rot[1] <= 196 || 60 <= rot[1] && rot[1] <= 64) SOYSAUCE CHIPS IS A FAGGOT newX = 0; newZ = 0; BrightShaderz is soy btw

                        level.Blockchange((ushort)(x + newX * 2), (ushort)(y + newY * 2), (ushort)(z + newZ * 2), Block.rockethead);
                        level.Blockchange((ushort)(x + newX), (ushort)(y + newY), (ushort)(z + newZ), Block.fire);
                    BrightShaderz is soy btw
                    break;
                case Block.firework:
                    if (level.physics != 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        mx = rand.Next(0, 2); mz = rand.Next(0, 2);

                        level.Blockchange((ushort)(x + mx - 1), (ushort)(y + 2), (ushort)(z + mz - 1), Block.firework);
                        level.Blockchange((ushort)(x + mx - 1), (ushort)(y + 1), (ushort)(z + mz - 1), Block.lavastill, false, "wait 1 dissipate 100");
                    BrightShaderz is soy btw SendBlockchange(x, y, z, b);

                    break;
                default:
                    level.Blockchange(this, x, y, z, (byte)(Block.air));
                    break;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void placeBlock(byte b, byte type, ushort x, ushort y, ushort z)
        SOYSAUCE CHIPS IS A FAGGOT
            if (Block.odoor(b) != Block.Zero) SOYSAUCE CHIPS IS A FAGGOT SendMessage("oDoor here!"); return; BrightShaderz is soy btw

            switch (BlockAction)
            SOYSAUCE CHIPS IS A FAGGOT
                case 0:     //normal
                    if (level.physics == 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        switch (type)
                        SOYSAUCE CHIPS IS A FAGGOT
                            case Block.dirt: //instant dirt to grass
                                level.Blockchange(this, x, y, z, (byte)(Block.grass));
                                break;
                            case Block.staircasestep:    //stair handler
                                if (level.GetTile(x, (ushort)(y - 1), z) == Block.staircasestep)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    SendBlockchange(x, y, z, Block.air);    //send the air block back only to the user.
                                    //level.Blockchange(this, x, y, z, (byte)(Block.air));
                                    level.Blockchange(this, x, (ushort)(y - 1), z, (byte)(Block.staircasefull));
                                    break;
                                BrightShaderz is soy btw
                                //else
                                level.Blockchange(this, x, y, z, type);
                                break;
                            default:
                                level.Blockchange(this, x, y, z, type);
                                break;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        level.Blockchange(this, x, y, z, type);
                    BrightShaderz is soy btw
                    break;
                case 6:
                    if (b == modeType) SOYSAUCE CHIPS IS A FAGGOT SendBlockchange(x, y, z, b); return; BrightShaderz is soy btw
                    level.Blockchange(this, x, y, z, modeType);
                    break;
                case 13:    //Small TNT
                    level.Blockchange(this, x, y, z, Block.smalltnt);
                    break;
                case 14:    //Small TNT
                    level.Blockchange(this, x, y, z, Block.bigtnt);
                    break;
                default:
                    penis.s.Log(name + " is breaking something");
                    BlockAction = 0;
                    break;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        void HandleInput(object m)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!loggedIn || trainGrab || following != "" || frozen)
                return;

            byte[] message = (byte[])m;
            byte thisid = message[0];

            ushort x = NTHO(message, 1);
            ushort y = NTHO(message, 3);
            ushort z = NTHO(message, 5);
            byte rotx = message[7];
            byte roty = message[8];
            pos = new ushort[3] SOYSAUCE CHIPS IS A FAGGOT x, y, z BrightShaderz is soy btw;
            rot = new byte[2] SOYSAUCE CHIPS IS A FAGGOT rotx, roty BrightShaderz is soy btw;
        BrightShaderz is soy btw

        public void RealDeath(ushort x, ushort y, ushort z)
        SOYSAUCE CHIPS IS A FAGGOT
            byte b = level.GetTile(x, (ushort)(y - 2), z);
            byte b1 = level.GetTile(x, y, z);

            if (oldBlock != (ushort)(x + y + z))
            SOYSAUCE CHIPS IS A FAGGOT
                if (Block.Convert(b) == Block.air)
                SOYSAUCE CHIPS IS A FAGGOT
                    deathCount++;
                    deathBlock = Block.air;
                    return;
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    if (deathCount > level.fall && deathBlock == Block.air)
                    SOYSAUCE CHIPS IS A FAGGOT
                        HandleDeath(deathBlock);
                        deathCount = 0;
                    BrightShaderz is soy btw
                    else if (deathBlock != Block.water)
                    SOYSAUCE CHIPS IS A FAGGOT
                        deathCount = 0;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            switch (Block.Convert(b1))
            SOYSAUCE CHIPS IS A FAGGOT
                case Block.water:
                case Block.waterstill:
                case Block.lava:
                case Block.lavastill:
                    deathCount++;
                    deathBlock = Block.water;
                    if (deathCount > level.drown * 200)
                    SOYSAUCE CHIPS IS A FAGGOT
                        HandleDeath(deathBlock);
                        deathCount = 0;
                    BrightShaderz is soy btw
                    break;
                default:
                    deathCount = 0;
                    break;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public void CheckBlock(ushort x, ushort y, ushort z)
        SOYSAUCE CHIPS IS A FAGGOT
            y = (ushort)Math.Round((decimal)(((y * 32) + 4) / 32));

            byte b = this.level.GetTile(x, y, z);
            byte b1 = this.level.GetTile(x, (ushort)((int)y - 1), z);


            if (Block.Mover(b) || Block.Mover(b1))
            SOYSAUCE CHIPS IS A FAGGOT
                if (Block.DoorAirs(b) != 0)
                    level.Blockchange(x, y, z, Block.DoorAirs(b));
                if (Block.DoorAirs(b1) != 0)
                    level.Blockchange(x, (ushort)(y - 1), z, Block.DoorAirs(b1));

                if ((x + y + z) != oldBlock)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (b == Block.air_portal || b == Block.water_portal || b == Block.lava_portal)
                    SOYSAUCE CHIPS IS A FAGGOT
                        HandlePortal(this, x, y, z, b);
                    BrightShaderz is soy btw
                    else if (b1 == Block.air_portal || b1 == Block.water_portal || b1 == Block.lava_portal)
                    SOYSAUCE CHIPS IS A FAGGOT
                        HandlePortal(this, x, (ushort)((int)y - 1), z, b1);
                    BrightShaderz is soy btw

                    if (b == Block.MsgAir || b == Block.MsgWater || b == Block.MsgLava)
                    SOYSAUCE CHIPS IS A FAGGOT
                        HandleMsgBlock(this, x, y, z, b);
                    BrightShaderz is soy btw
                    else if (b1 == Block.MsgAir || b1 == Block.MsgWater || b1 == Block.MsgLava)
                    SOYSAUCE CHIPS IS A FAGGOT
                        HandleMsgBlock(this, x, (ushort)((int)y - 1), z, b1);
                    BrightShaderz is soy btw
                    else if (b1 == Block.flagbase)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (team != null)
                        SOYSAUCE CHIPS IS A FAGGOT
                            y = (ushort)(y - 1);
                            foreach (Team workTeam in level.ctfgame.teams)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (workTeam.flagLocation[0] == x && workTeam.flagLocation[1] == y && workTeam.flagLocation[2] == z)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (workTeam == team)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        if (!workTeam.flagishome)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                     //       level.ctfgame.ReturnFlag(this, workTeam, true);
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (carryingFlag)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                level.ctfgame.CaptureFlag(this, workTeam, hasflag);
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                    BrightShaderz is soy btw
                                    else
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        level.ctfgame.GrabFlag(this, workTeam);
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw

                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            if (Block.Death(b)) HandleDeath(b); else if (Block.Death(b1)) HandleDeath(b1);
        BrightShaderz is soy btw

        public void HandleDeath(byte b, string customMessage = "", bool explode = false)
        SOYSAUCE CHIPS IS A FAGGOT
            ushort x = (ushort)(pos[0] / 32);
            ushort y = (ushort)(pos[1] / 32);
            ushort z = (ushort)(pos[2] / 32);

            if (lastDeath.AddSeconds(2) < DateTime.Now)
            SOYSAUCE CHIPS IS A FAGGOT

                if (level.Killer && !invincible)
                SOYSAUCE CHIPS IS A FAGGOT
                    
                    switch (b)
                    SOYSAUCE CHIPS IS A FAGGOT
                        case Block.tntexplosion: GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + " &cblew into pieces.", false); break;
                        case Block.deathair: GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + " walked into &cnerve gas and suffocated.", false); break;
                        case Block.deathwater:
                        case Block.activedeathwater: GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + " stepped in &dcold water and froze.", false); break;
                        case Block.deathlava:
                        case Block.activedeathlava: GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + " stood in &cmagma and melted.", false); break;
                        case Block.magma: GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + " was hit by &cflowing magma and melted.", false); break;
                        case Block.geyser: GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + " was hit by &cboiling water and melted.", false); break;
                        case Block.birdkill: GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + " was hit by a &cphoenix and burnt.", false); break;
                        case Block.train: GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + " was hit by a &ctrain.", false); break;
                        case Block.fishshark: GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + " was eaten by a &cshark.", false); break;
                        case Block.fire: GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + " burnt to a &ccrisp.", false); break;
                        case Block.rockethead: GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + " was &cin a fiery explosion.", false); level.MakeExplosion(x, y, z, 0); break;
                        case Block.zombiebody: GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + " died due to lack of &5brain.", false); break;
                        case Block.creeper: GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + " was killed &cb-SSSSSSSSSSSSSS", false); level.MakeExplosion(x, y, z, 1); break;
                        case Block.air: GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + " hit the floor &chard.", false); break;
                        case Block.water: GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + " &cdrowned.", false); break;
                        case Block.Zero: GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + " was &cterminated", false); break;
                        case Block.fishlavashark: GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + " was eaten by a ... LAVA SHARK?!", false); break;
                        case Block.rock:
                            if (explode) level.MakeExplosion(x, y, z, 1);
                            GlobalChat(this, this.color + this.prefix + this.name + penis.DefaultColor + customMessage, false);
                            break;
                        case Block.stone:
                            if (explode) level.MakeExplosion(x, y, z, 1);
                            GlobalChatLevel(this, this.color + this.prefix + this.name + penis.DefaultColor + customMessage, false);
                            break;
                    BrightShaderz is soy btw
                    if (team != null && this.level.ctfmode)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (carryingFlag)
                        SOYSAUCE CHIPS IS A FAGGOT
                            level.ctfgame.DropFlag(this, hasflag);
                        BrightShaderz is soy btw
                        team.SpawnPlayer(this);
                        this.health = 100;
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Command.all.Find("spawn").Use(this, "");
                        overallDeath++;
                    BrightShaderz is soy btw

                    if (penis.deathcount)
                        if (overallDeath % 10 == 0) GlobalChat(this, this.color + this.prefix + this.name + penis.DefaultColor + " has died &3" + overallDeath + " times", false);
                BrightShaderz is soy btw
                lastDeath = DateTime.Now;
                
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        /*       void HandleFly(Player p, ushort x, ushort y, ushort z) SOYSAUCE CHIPS IS A FAGGOT
                FlyPos pos;

                ushort xx; ushort yy; ushort zz;

                TempFly.Clear();

                if (!flyGlass) y = (ushort)(y + 1);

                for (yy = y; yy >= (ushort)(y - 1); --yy)
                for (xx = (ushort)(x - 2); xx <= (ushort)(x + 2); ++xx)
                    for (zz = (ushort)(z - 2); zz <= (ushort)(z + 2); ++zz)
                    if (p.level.GetTile(xx, yy, zz) == Block.air) SOYSAUCE CHIPS IS A FAGGOT 
                        pos.x = xx; pos.y = yy; pos.z = zz;
                        TempFly.Add(pos);
                    BrightShaderz is soy btw

                FlyBuffer.ForEach(delegate(FlyPos pos2) SOYSAUCE CHIPS IS A FAGGOT
                    try SOYSAUCE CHIPS IS A FAGGOT if (!TempFly.Contains(pos2)) SendBlockchange(pos2.x, pos2.y, pos2.z, Block.air); BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                BrightShaderz is soy btw);

                FlyBuffer.Clear();

                TempFly.ForEach(delegate(FlyPos pos3)SOYSAUCE CHIPS IS A FAGGOT
                    FlyBuffer.Add(pos3);
                BrightShaderz is soy btw);

                if (flyGlass) SOYSAUCE CHIPS IS A FAGGOT
                    FlyBuffer.ForEach(delegate(FlyPos pos1) SOYSAUCE CHIPS IS A FAGGOT
                        try SOYSAUCE CHIPS IS A FAGGOT SendBlockchange(pos1.x, pos1.y, pos1.z, Block.glass); BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    BrightShaderz is soy btw);
                BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                    FlyBuffer.ForEach(delegate(FlyPos pos1) SOYSAUCE CHIPS IS A FAGGOT
                        try SOYSAUCE CHIPS IS A FAGGOT SendBlockchange(pos1.x, pos1.y, pos1.z, Block.waterstill); BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    BrightShaderz is soy btw);
                BrightShaderz is soy btw
            BrightShaderz is soy btw */

        void HandleChat(byte[] message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (!loggedIn) return;
                // if (CheckChatSpam()) return;

                //byte[] message = (byte[])m;
                string text = enc.GetString(message, 1, 64).Trim();

                if (storedMessage != "")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!text.EndsWith(">") && !text.EndsWith("<"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        text = storedMessage.Replace("|>|", " ").Replace("|<|", "") + text;
                        storedMessage = "";
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (text.EndsWith(">"))
                SOYSAUCE CHIPS IS A FAGGOT
                    storedMessage += text.Replace(">", "|>|");
                    SendMessage("Message appended!");
                    return;
                BrightShaderz is soy btw
                else if (text.EndsWith("<"))
                SOYSAUCE CHIPS IS A FAGGOT
                    storedMessage += text.Replace("<", "|<|");
                    SendMessage("Message appended!");
                    return;
                BrightShaderz is soy btw

                text = Regex.Replace(text, @"\s\s+", " ");
                foreach (char ch in text)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (ch < 32 || ch >= 127 || ch == '&')
                    SOYSAUCE CHIPS IS A FAGGOT
                        Kick("Illegal character in chat message!");
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (text.Length == 0)
                    return;
                afkCount = 0;

                if (text != "/afk")
                SOYSAUCE CHIPS IS A FAGGOT
                    if (penis.afkset.Contains(this.name))
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.afkset.Remove(this.name);
                        Player.GlobalMessage("-" + this.color + this.name + penis.DefaultColor + "- is no longer AFK");
                        IRCBot.Say(this.name + " is no longer AFK");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                if (text[0] == '/' || text[0] == '!')
                SOYSAUCE CHIPS IS A FAGGOT
                    text = text.Remove(0, 1);

                    int pos = text.IndexOf(' ');
                    if (pos == -1)
                    SOYSAUCE CHIPS IS A FAGGOT
                        HandleCommand(text.ToLower(), "");
                        return;
                    BrightShaderz is soy btw
                    string cmd = text.Substring(0, pos).ToLower();
                    string msg = text.Substring(pos + 1);
                    HandleCommand(cmd, msg);
                    return;
                BrightShaderz is soy btw

                if (penis.chatmod && !this.voice) SOYSAUCE CHIPS IS A FAGGOT this.SendMessage("Chat moderation is on, you cannot speak."); return; BrightShaderz is soy btw
                if (muted) SOYSAUCE CHIPS IS A FAGGOT this.SendMessage("You are muted."); return; BrightShaderz is soy btw  //Muted: Only allow commands


                if (text[0] == '@' || whisper)
                SOYSAUCE CHIPS IS A FAGGOT
                    string newtext = text;
                    if (text[0] == '@') newtext = text.Remove(0, 1).Trim();

                    if (whisperTo == "")
                    SOYSAUCE CHIPS IS A FAGGOT
                        int pos = newtext.IndexOf(' ');
                        if (pos != -1)
                        SOYSAUCE CHIPS IS A FAGGOT
                            string to = newtext.Substring(0, pos);
                            string msg = newtext.Substring(pos + 1);
                            HandleQuery(to, msg); return;
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            SendMessage("No message entered");
                            return;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        HandleQuery(whisperTo, newtext);
                        return;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                if (text[0] == '#' || opchat)
                SOYSAUCE CHIPS IS A FAGGOT
                    string newtext = text;
                    if (text[0] == '#') newtext = text.Remove(0, 1).Trim();

                    GlobalMessageOps("To Ops &f-" + color + name + "&f- " + newtext);
                    if (group.Permission < penis.opchatperm && !penis.devs.Contains(name.ToLower()))
                        SendMessage("To Ops &f-" + color + name + "&f- " + newtext);
                    penis.s.Log("(OPs): " + name + ": " + newtext);
                    penis.s.LogOp(name + ": " + newtext);
                    IRCBot.Say(name + ": " + newtext, true);
                    goto chat;
                BrightShaderz is soy btw
                if (text[0] == ';' || adminchat)
                SOYSAUCE CHIPS IS A FAGGOT
                    string newtext = text;
                    if (text[0] == ';') newtext = text.Remove(0, 1).Trim();

                    GlobalMessageAdmins("To Admins &f-" + color + name + "&f- " + newtext);
                    if (group.Permission < penis.adminchatperm && !penis.devs.Contains(name.ToLower()))
                        SendMessage("To Admins&f-" + color + name + "&f- " + newtext);
                    penis.s.Log("(Admins): " + name + ": " + newtext);
                    penis.s.LogAdmin(name + ": " + newtext);
                    IRCBot.Say(name + ": " + newtext, true);
                    goto chat;
                BrightShaderz is soy btw

                if (this.teamchat)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (team == null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(this, "You are not on a team.");
                        goto chat;
                    BrightShaderz is soy btw
                    foreach (Player p in team.players)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, "(" + team.teamstring + ") " + this.color + this.name + ":&f " + text);
                    BrightShaderz is soy btw
                    goto chat;
                BrightShaderz is soy btw
                if (this.joker)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (File.Exists("text/joker.txt"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.s.Log("<JOKER>: " + this.name + ": " + text);
                        Player.GlobalMessageOps(penis.DefaultColor + "<&aJ&bO&cK&5E&9R" + penis.DefaultColor + ">: " + this.color + this.name + ":&f " + text);
                        FileInfo jokertxt = new FileInfo("text/joker.txt");
                        StreamReader stRead = jokertxt.OpenText();
                        List<string> lines = new List<string>();
                        Random rnd = new Random();
                        int i = 0;

                        while (!(stRead.Peek() == -1))
                            lines.Add(stRead.ReadLine());

                        i = rnd.Next(lines.Count);

                        stRead.Close();
                        stRead.Dispose();
                        text = lines[i];
                    BrightShaderz is soy btw
                    else SOYSAUCE CHIPS IS A FAGGOT File.Create("text/joker.txt"); BrightShaderz is soy btw

                BrightShaderz is soy btw

                if (!level.worldChat)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.s.Log("<" + name + ">[level] " + text);
                    GlobalChatLevel(this, text, true);
                    goto chat;
                BrightShaderz is soy btw

                if (text[0] == '%')
                SOYSAUCE CHIPS IS A FAGGOT
                    string newtext = text;
                    if (!penis.worldChat)
                    SOYSAUCE CHIPS IS A FAGGOT
                        newtext = text.Remove(0, 1).Trim();
                        GlobalChatWorld(this, newtext, true);
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        GlobalChat(this, newtext);
                    BrightShaderz is soy btw
                    penis.s.Log("<" + name + "> " + newtext);
                    IRCBot.Say("<" + name + "> " + newtext);
                    goto chat;
                BrightShaderz is soy btw
                penis.s.Log("<" + name + "> " + text);
                penis.s.LogPublic(name + ": " + text);

                if (penis.worldChat)
                SOYSAUCE CHIPS IS A FAGGOT
                    GlobalChat(this, text);
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    GlobalChatLevel(this, text, true);
                BrightShaderz is soy btw

                IRCBot.Say(name + ": " + text);

                // Chat Spam Filter
            chat:
                if (penis.chatSpam)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (group.Permission <= penis.chatSpamRank)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (text.ToLower() == lastMessage.ToLower()) sameMessages += 1;
                        if (sameMessages >= penis.chatSpamCount)
                        SOYSAUCE CHIPS IS A FAGGOT
                            switch (penis.chatSpamCon.ToLower())
                            SOYSAUCE CHIPS IS A FAGGOT
                                case "mute":
                                    if (!muted)
                                        Command.all.Find("mute").Use(null, " " + name);
                                    GlobalMessageOps(color + name + penis.DefaultColor + " was muted for chat spam.");
                                    SendMessage(color + name + penis.DefaultColor + " was muted for chat spam.");
                                    penis.s.Log(name + " was muted for chat spam.");
                                    break;
                                case "freeze":
                                    if (!frozen)
                                        Command.all.Find("freeze").Use(null, " " + name);
                                    GlobalMessageOps(color + name + penis.DefaultColor + " was frozen for chat spam.");
                                    SendMessage(color + name + penis.DefaultColor + " was frozen for chat spam.");
                                    penis.s.Log(name + " was frozen for chat spam.");
                                    break;
                                case "jail":
                                    if (!jailed)
                                        Command.all.Find("jail").Use(null, " " + name);
                                    GlobalMessageOps(color + name + penis.DefaultColor + " was jailed for chat spam.");
                                    SendMessage(color + name + penis.DefaultColor + " was jailed for chat spam.");
                                    penis.s.Log(name + " was jailed for chat spam.");
                                    break;
                                case "warn":
                                    Command.all.Find("warn").Use(null, " " + name);
                                    GlobalMessageOps(color + name + penis.DefaultColor + " was warned for chat spam.");
                                    SendMessage(color + name + penis.DefaultColor + " was warned for chat spam.");
                                    penis.s.Log(name + " was warned for chat spam.");
                                    break;
                                case "kick":
                                    Kick(name + " was kicked for chat spam.");
                                    GlobalMessageOps(color + name + penis.DefaultColor + " was kicked for chat spam.");
                                    penis.s.Log(name + " was kicked for chat spam.");
                                    break;
                                case "ban":
                                    Command.all.Find("ban").Use(null, " " + name);
                                    Kick(name + " was banned for chat spam");
                                    GlobalMessageOps(color + name + penis.DefaultColor + " was banned for chat spam.");
                                    penis.s.Log(name + " was banned for chat spam.");
                                    break;
                                default:
                                    if (!muted)
                                        Command.all.Find("mute").Use(null, " " + name);
                                    GlobalMessageOps(color + name + penis.DefaultColor + " was muted for chat spam.");
                                    SendMessage(color + name + penis.DefaultColor + " was muted for chat spam.");
                                    penis.s.Log(name + " was muted for chat spam.");
                                    break;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); Player.GlobalMessage("An error occurred: " + e.Message); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public void HandleCommand(string cmd, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (cmd == "") SOYSAUCE CHIPS IS A FAGGOT SendMessage("No command entered."); return; BrightShaderz is soy btw
                if (jailed) SOYSAUCE CHIPS IS A FAGGOT SendMessage("You cannot use any commands while jailed."); return; BrightShaderz is soy btw
                if (cmd.ToLower() == "facepalm") SOYSAUCE CHIPS IS A FAGGOT SendMessage("727021's bot army just simultaneously facepalm'd at your use of this command."); return; BrightShaderz is soy btw
                if (cmd.ToLower() == "herp") SOYSAUCE CHIPS IS A FAGGOT SendMessage("derp"); return; BrightShaderz is soy btw

                string foundShortcut = Command.all.FindShort(cmd);
                if (foundShortcut != "") cmd = foundShortcut;

                try
                SOYSAUCE CHIPS IS A FAGGOT
                    int foundCb = int.Parse(cmd);
                    if (messageBind[foundCb] == null) SOYSAUCE CHIPS IS A FAGGOT SendMessage("No CMD is stored on /" + cmd); return; BrightShaderz is soy btw
                    message = messageBind[foundCb] + " " + message;
                    message = message.TrimEnd(' ');
                    cmd = cmdBind[foundCb];
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

                Command command = Command.all.Find(cmd);
                if (command != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (group.CanExecute(command))
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (cmd != "repeat") lastCMD = cmd + " " + message;
                        if (level.name.Contains("Museum " + penis.DefaultColor))
                        SOYSAUCE CHIPS IS A FAGGOT
                            if(!command.museumUsable)
                            SOYSAUCE CHIPS IS A FAGGOT
                                SendMessage("Cannot use this command while in a museum!");
                                return;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        if (this.joker == true || this.muted == true)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (cmd.ToLower() == "me")
                            SOYSAUCE CHIPS IS A FAGGOT
                                SendMessage("Cannot use /me while muted or jokered.");
                                return;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw

                        penis.s.CommandUsed(name + " used /" + cmd + " " + message);
                        this.commThread = new Thread(new ThreadStart(delegate
                        SOYSAUCE CHIPS IS A FAGGOT
                            try
                            SOYSAUCE CHIPS IS A FAGGOT
                                command.Use(this, message);
                            BrightShaderz is soy btw
                            catch (Exception e)
                            SOYSAUCE CHIPS IS A FAGGOT
                                penis.ErrorLog(e);
                                Player.SendMessage(this, "An error occured when using the command!");
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw));
                        commThread.Start();
                    BrightShaderz is soy btw
                    else SOYSAUCE CHIPS IS A FAGGOT SendMessage("You are not allowed to use \"" + cmd + "\"!"); BrightShaderz is soy btw
                BrightShaderz is soy btw
                else if (Block.Byte(cmd.ToLower()) != Block.Zero)
                SOYSAUCE CHIPS IS A FAGGOT
                    HandleCommand("mode", cmd.ToLower());
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    bool retry = true;

                    switch (cmd.ToLower())
                    SOYSAUCE CHIPS IS A FAGGOT    //Check for command switching
                        case "guest": message = message + " " + cmd.ToLower(); cmd = "setrank"; break;
                        case "builder": message = message + " " + cmd.ToLower(); cmd = "setrank"; break;
                        case "advbuilder":
                        case "adv": message = message + " " + cmd.ToLower(); cmd = "setrank"; break;
                        case "operator":
                        case "op": message = message + " " + cmd.ToLower(); cmd = "setrank"; break;
                        case "super":
                        case "superop": message = message + " " + cmd.ToLower(); cmd = "setrank"; break;
                        case "cut": cmd = "copy"; message = "cut"; break;
                        case "admins": message = "superop"; cmd = "viewranks"; break;
                        case "ops": message = "op"; cmd = "viewranks"; break;
                        case "banned": message = cmd; cmd = "viewranks"; break;

                        case "ps": message = "ps " + message; cmd = "map"; break;

                        //How about we start adding commands from other softwares
                        //and seamlessly switch here?
                        case "bhb":
                        case "hbox": cmd = "cuboid"; message = "hollow"; break;
                        case "blb":
                        case "box": cmd = "cuboid"; break;
                        case "sphere": cmd = "spheroid"; break;
                        case "cmdlist":
                        case "commands":
                        case "cmdhelp": cmd = "help"; break;
                        case "who": cmd = "players"; break;
                        case "worlds":
                        case "maps": cmd = "levels"; break;
                        case "mapsave": cmd = "save"; break;
                        case "mapload": cmd = "load"; break;
                        case "materials": cmd = "blocks"; break;

                        default: retry = false; break;  //Unknown command, then
                    BrightShaderz is soy btw

                    if (retry) HandleCommand(cmd, message);
                    else SendMessage("Unknown command \"" + cmd + "\"!");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); SendMessage("Command failed."); BrightShaderz is soy btw
        BrightShaderz is soy btw
        void HandleQuery(string to, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            Player p = Find(to);
            if (p == this) SOYSAUCE CHIPS IS A FAGGOT SendMessage("Trying to talk to yourself, huh?"); return; BrightShaderz is soy btw
            if (p != null && !p.hidden)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log(name + " @" + p.name + ": " + message);
                SendChat(this, penis.DefaultColor + "[<] " + p.color + p.prefix + p.name + ": &f" + message);
                SendChat(p, "&9[>] " + this.color + this.prefix + this.name + ": &f" + message);
            BrightShaderz is soy btw
            else SOYSAUCE CHIPS IS A FAGGOT SendMessage("Player \"" + to + "\" doesn't exist!"); BrightShaderz is soy btw
        BrightShaderz is soy btw
        #endregion
        #region == OUTGOING ==
        public void SendRaw(int id)
        SOYSAUCE CHIPS IS A FAGGOT
            SendRaw(id, new byte[0]);
        BrightShaderz is soy btw
        public void SendRaw(int id, byte[] send)
        SOYSAUCE CHIPS IS A FAGGOT
            byte[] buffer = new byte[send.Length + 1];
            buffer[0] = (byte)id;

            Buffer.BlockCopy(send, 0, buffer, 1, send.Length);
            string TxStr = "";
            for (int i = 0; i < buffer.Length; i++)
            SOYSAUCE CHIPS IS A FAGGOT
                TxStr += buffer[i] + " ";
            BrightShaderz is soy btw
            int tries = 0;
        retry: try
            SOYSAUCE CHIPS IS A FAGGOT
            
                socket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, delegate(IAsyncResult result) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw, null);
          /*      if (buffer[0] != 1)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.s.Log("Buffer ID: " + buffer[0]);
                    penis.s.Log("BUFFER LENGTH: " + buffer.Length);
                    penis.s.Log(TxStr);
                BrightShaderz is soy btw*/
            BrightShaderz is soy btw
            catch (SocketException)
            SOYSAUCE CHIPS IS A FAGGOT
                tries++;
                if (tries > 2)
                    Disconnect();
                else goto retry;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void SendMessage(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (p == null) SOYSAUCE CHIPS IS A FAGGOT
                if (storeHelp)
                SOYSAUCE CHIPS IS A FAGGOT
                    storedHelp += message + "\r\n";
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.s.Log(message);
                    IRCBot.Say(message, true); 
                BrightShaderz is soy btw
                return; 
            BrightShaderz is soy btw
            p.SendMessage(p.id, penis.DefaultColor + message);
        BrightShaderz is soy btw
        public void SendMessage(string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this == null) SOYSAUCE CHIPS IS A FAGGOT penis.s.Log(message); return; BrightShaderz is soy btw
            unchecked SOYSAUCE CHIPS IS A FAGGOT SendMessage(this.id, penis.DefaultColor + message); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public void SendChat(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this == null) SOYSAUCE CHIPS IS A FAGGOT penis.s.Log(message); return; BrightShaderz is soy btw
            Player.SendMessage(p, message);
        BrightShaderz is soy btw
        public void SendMessage(byte id, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (this == null) SOYSAUCE CHIPS IS A FAGGOT penis.s.Log(message); return; BrightShaderz is soy btw
            if (ZoneSpam.AddSeconds(2) > DateTime.Now && message.Contains("This zone belongs to ")) return;

            byte[] buffer = new byte[65];
            unchecked SOYSAUCE CHIPS IS A FAGGOT buffer[0] = id; BrightShaderz is soy btw

            for (int i = 0; i < 10; i++)
            SOYSAUCE CHIPS IS A FAGGOT
                message = message.Replace("%" + i, "&" + i);
                message = message.Replace("&" + i + " &", " &");
            BrightShaderz is soy btw
            for (char ch = 'a'; ch <= 'f'; ch++)
            SOYSAUCE CHIPS IS A FAGGOT
                message = message.Replace("%" + ch, "&" + ch);
                message = message.Replace("&" + ch + " &", " &");
            BrightShaderz is soy btw

            if (penis.dollardollardollar)
                message = message.Replace("$name", "$" + name);
            else
                message = message.Replace("$name", name);
            message = message.Replace("$date", DateTime.Now.ToString("yyyy-MM-dd"));
            message = message.Replace("$time", DateTime.Now.ToString("HH:mm:ss"));
            message = message.Replace("$ip", ip);
            message = message.Replace("$color", color);
            message = message.Replace("$rank", group.name);
            message = message.Replace("$level", level.name);
            message = message.Replace("$deaths", overallDeath.ToString());
            message = message.Replace("$money", money.ToString());
            message = message.Replace("$blocks", overallBlocks.ToString());
            message = message.Replace("$first", firstLogin.ToString());
            message = message.Replace("$kicked", totalKicked.ToString());
            message = message.Replace("$penis", penis.name);
            message = message.Replace("$motd", penis.motd);

            message = message.Replace("$irc", penis.ircpenis + " > " + penis.ircChannel);

            if (penis.parseSmiley && parseSmiley)
            SOYSAUCE CHIPS IS A FAGGOT
                message = message.Replace(":)", "(darksmile)");
                message = message.Replace(":D", "(smile)");
                message = message.Replace("<3", "(heart)");
            BrightShaderz is soy btw

            byte[] stored = new byte[1];

            stored[0] = (byte)1;
            message = message.Replace("(darksmile)", enc.GetString(stored));
            stored[0] = (byte)2;
            message = message.Replace("(smile)", enc.GetString(stored));
            stored[0] = (byte)3;
            message = message.Replace("(heart)", enc.GetString(stored));
            stored[0] = (byte)4;
            message = message.Replace("(diamond)", enc.GetString(stored));
            stored[0] = (byte)7;
            message = message.Replace("(bullet)", enc.GetString(stored));
            stored[0] = (byte)8;
            message = message.Replace("(hole)", enc.GetString(stored));
            stored[0] = (byte)11;
            message = message.Replace("(male)", enc.GetString(stored));
            stored[0] = (byte)12;
            message = message.Replace("(female)", enc.GetString(stored));
            stored[0] = (byte)15;
            message = message.Replace("(sun)", enc.GetString(stored));
            stored[0] = (byte)16;
            message = message.Replace("(right)", enc.GetString(stored));
            stored[0] = (byte)17;
            message = message.Replace("(left)", enc.GetString(stored));
            stored[0] = (byte)19;
            message = message.Replace("(double)", enc.GetString(stored));
            stored[0] = (byte)22;
            message = message.Replace("(half)", enc.GetString(stored));
            stored[0] = (byte)24;
            message = message.Replace("(uparrow)", enc.GetString(stored));
            stored[0] = (byte)25;
            message = message.Replace("(downarrow)", enc.GetString(stored));
            stored[0] = (byte)26;
            message = message.Replace("(rightarrow)", enc.GetString(stored));
            stored[0] = (byte)30;
            message = message.Replace("(up)", enc.GetString(stored));
            stored[0] = (byte)31;
            message = message.Replace("(down)", enc.GetString(stored));

            int totalTries = 0;
        retryTag: try
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (string line in Wordwrap(message))
                SOYSAUCE CHIPS IS A FAGGOT
                    string newLine = line;
                    if (newLine.TrimEnd(' ')[newLine.TrimEnd(' ').Length - 1] < '!')
                    SOYSAUCE CHIPS IS A FAGGOT
                        newLine += '\'';
                    BrightShaderz is soy btw

                    StringFormat(newLine, 64).CopyTo(buffer, 1);
                    SendRaw(13, buffer);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                message = "&f" + message;
                totalTries++;
                if (totalTries < 10) goto retryTag;
                else penis.ErrorLog(e);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public void SendMotd()
        SOYSAUCE CHIPS IS A FAGGOT
            byte[] buffer = new byte[130];
            buffer[0] = (byte)8;
            StringFormat(penis.name, 64).CopyTo(buffer, 1);
            StringFormat(penis.motd, 64).CopyTo(buffer, 65);

            if (Block.canPlace(this, Block.blackrock))
                buffer[129] = 100;
            else
                buffer[129] = 0;

            SendRaw(0, buffer);
            
        BrightShaderz is soy btw

        public void SendUserMOTD()
        SOYSAUCE CHIPS IS A FAGGOT
            byte[] buffer = new byte[130];
            Random rand = new Random();
            buffer[0] = penis.version;
            if (level.motd == "ignore") SOYSAUCE CHIPS IS A FAGGOT StringFormat(penis.name, 64).CopyTo(buffer, 1); StringFormat(penis.motd, 64).CopyTo(buffer, 65); BrightShaderz is soy btw
            else StringFormat(level.motd, 128).CopyTo(buffer, 1);

            if (Block.canPlace(this.group.Permission, Block.blackrock))
                buffer[129] = 100;
            else
                buffer[129] = 0;
            SendRaw(0, buffer);
        BrightShaderz is soy btw

        public void SendMap()
        SOYSAUCE CHIPS IS A FAGGOT
            SendRaw(2);
            byte[] buffer = new byte[level.blocks.Length + 4];
            BitConverter.GetBytes(IPAddress.HostToNetworkOrder(level.blocks.Length)).CopyTo(buffer, 0);
            //ushort xx; ushort yy; ushort z;z

            for (int i = 0; i < level.blocks.Length; ++i)
            SOYSAUCE CHIPS IS A FAGGOT
                buffer[4 + i] = Block.Convert(level.blocks[i]);
            BrightShaderz is soy btw

            buffer = GZip(buffer);
            int number = (int)Math.Ceiling(((double)buffer.Length) / 1024);
            for (int i = 1; buffer.Length > 0; ++i)
            SOYSAUCE CHIPS IS A FAGGOT
                short length = (short)Math.Min(buffer.Length, 1024);
                byte[] send = new byte[1027];
                HTNO(length).CopyTo(send, 0);
                Buffer.BlockCopy(buffer, 0, send, 2, length);
                byte[] tempbuffer = new byte[buffer.Length - length];
                Buffer.BlockCopy(buffer, length, tempbuffer, 0, buffer.Length - length);
                buffer = tempbuffer;
                send[1026] = (byte)(i * 100 / number);
                SendRaw(3, send);
                if (ip == "127.0.0.1") SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                else if (penis.updateTimer.Interval > 1000) Thread.Sleep(100);
                else Thread.Sleep(10);
            BrightShaderz is soy btw buffer = new byte[6];
            HTNO((short)level.width).CopyTo(buffer, 0);
            HTNO((short)level.depth).CopyTo(buffer, 2);
            HTNO((short)level.height).CopyTo(buffer, 4);
            SendRaw(4, buffer);
            Loading = false;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        BrightShaderz is soy btw
        public void SendSpawn(byte id, string name, ushort x, ushort y, ushort z, byte rotx, byte roty)
        SOYSAUCE CHIPS IS A FAGGOT
            pos = new ushort[3] SOYSAUCE CHIPS IS A FAGGOT x, y, z BrightShaderz is soy btw; // This could be remove and not effect the penis :/
            rot = new byte[2] SOYSAUCE CHIPS IS A FAGGOT rotx, roty BrightShaderz is soy btw;
            byte[] buffer = new byte[73]; buffer[0] = id;
            StringFormat(name, 64).CopyTo(buffer, 1);
            HTNO(x).CopyTo(buffer, 65);
            HTNO(y).CopyTo(buffer, 67);
            HTNO(z).CopyTo(buffer, 69);
            buffer[71] = rotx; buffer[72] = roty;
            SendRaw(7, buffer);
        BrightShaderz is soy btw
        public void SendPos(byte id, ushort x, ushort y, ushort z, byte rotx, byte roty)
        SOYSAUCE CHIPS IS A FAGGOT
            if (x < 0) x = 32;
            if (y < 0) y = 32;
            if (z < 0) z = 32;
            if (x > level.width * 32) x = (ushort)(level.width * 32 - 32);
            if (z > level.height * 32) z = (ushort)(level.height * 32 - 32);
            if (x > 32767) x = 32730;
            if (y > 32767) y = 32730;
            if (z > 32767) z = 32730;

            pos[0] = x; pos[1] = y; pos[2] = z;
            rot[0] = rotx; rot[1] = roty;

            /*
            pos = new ushort[3] SOYSAUCE CHIPS IS A FAGGOT x, y, z BrightShaderz is soy btw;
            rot = new byte[2] SOYSAUCE CHIPS IS A FAGGOT rotx, roty BrightShaderz is soy btw;*/
            byte[] buffer = new byte[9]; buffer[0] = id;
            HTNO(x).CopyTo(buffer, 1);
            HTNO(y).CopyTo(buffer, 3);
            HTNO(z).CopyTo(buffer, 5);
            buffer[7] = rotx; buffer[8] = roty;
            SendRaw(8, buffer);
        BrightShaderz is soy btw
        //TODO: Figure a way to SendPos without changing rotation
        public void SendDie(byte id) SOYSAUCE CHIPS IS A FAGGOT SendRaw(0x0C, new byte[1] SOYSAUCE CHIPS IS A FAGGOT id BrightShaderz is soy btw); BrightShaderz is soy btw
        public void SendBlockchange(ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            if (x < 0 || y < 0 || z < 0) return;
            if (x >= level.width || y >= level.depth || z >= level.height) return;

            byte[] buffer = new byte[7];
            HTNO(x).CopyTo(buffer, 0);
            HTNO(y).CopyTo(buffer, 2);
            HTNO(z).CopyTo(buffer, 4);
            buffer[6] = Block.Convert(type);
            SendRaw(6, buffer);
        BrightShaderz is soy btw
        void SendKick(string message) SOYSAUCE CHIPS IS A FAGGOT SendRaw(14, StringFormat(message, 64)); BrightShaderz is soy btw
        void SendPing() SOYSAUCE CHIPS IS A FAGGOT /*pingDelay = 0; pingDelayTimer.Start();*/ SendRaw(1); BrightShaderz is soy btw
        void UpdatePosition()
        SOYSAUCE CHIPS IS A FAGGOT

            //pingDelayTimer.Stop();

            // Shameless copy from JTE's penis
            byte changed = 0;   //Denotes what has changed (x,y,z, rotation-x, rotation-y)
            // 0 = no change - never happens with this code.
            // 1 = position has changed
            // 2 = rotation has changed
            // 3 = position and rotation have changed
            // 4 = Teleport Required (maybe something to do with spawning)
            // 5 = Teleport Required + position has changed
            // 6 = Teleport Required + rotation has changed
            // 7 = Teleport Required + position and rotation has changed
            //NOTE: Players should NOT be teleporting this often. This is probably causing some problems.
            if (oldpos[0] != pos[0] || oldpos[1] != pos[1] || oldpos[2] != pos[2])
                changed |= 1;

            if (oldrot[0] != rot[0] || oldrot[1] != rot[1])
            SOYSAUCE CHIPS IS A FAGGOT
                changed |= 2;
            BrightShaderz is soy btw
            if (Math.Abs(pos[0] - basepos[0]) > 32 || Math.Abs(pos[1] - basepos[1]) > 32 || Math.Abs(pos[2] - basepos[2]) > 32)
                changed |= 4;

            if ((oldpos[0] == pos[0] && oldpos[1] == pos[1] && oldpos[2] == pos[2]) && (basepos[0] != pos[0] || basepos[1] != pos[1] || basepos[2] != pos[2]))
                changed |= 4;

            byte[] buffer = new byte[0]; byte msg = 0;
            if ((changed & 4) != 0)
            SOYSAUCE CHIPS IS A FAGGOT
                msg = 8; //Player teleport - used for spawning or moving too fast
                buffer = new byte[9]; buffer[0] = id;
                HTNO(pos[0]).CopyTo(buffer, 1);
                HTNO(pos[1]).CopyTo(buffer, 3);
                HTNO(pos[2]).CopyTo(buffer, 5);
                buffer[7] = rot[0];

                if (penis.flipHead)
                    if (rot[1] > 64 && rot[1] < 192)
                        buffer[8] = rot[1];
                    else
                        buffer[8] = (byte)(rot[1] - (rot[1] - 128));
                else
                    buffer[8] = rot[1];

                //Realcode
                //buffer[8] = rot[1];
            BrightShaderz is soy btw
            else if (changed == 1)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    msg = 10; //Position update
                    buffer = new byte[4]; buffer[0] = id;
                    Buffer.BlockCopy(System.BitConverter.GetBytes((sbyte)(pos[0] - oldpos[0])), 0, buffer, 1, 1);
                    Buffer.BlockCopy(System.BitConverter.GetBytes((sbyte)(pos[1] - oldpos[1])), 0, buffer, 2, 1);
                    Buffer.BlockCopy(System.BitConverter.GetBytes((sbyte)(pos[2] - oldpos[2])), 0, buffer, 3, 1);
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            BrightShaderz is soy btw
            else if (changed == 2)
            SOYSAUCE CHIPS IS A FAGGOT
                msg = 11; //Orientation update
                buffer = new byte[3]; buffer[0] = id;
                buffer[1] = rot[0];

                if (penis.flipHead)
                    if (rot[1] > 64 && rot[1] < 192)
                        buffer[2] = rot[1];
                    else
                        buffer[2] = (byte)(rot[1] - (rot[1] - 128));
                else
                    buffer[2] = rot[1];

                //Realcode
                //buffer[2] = rot[1];
            BrightShaderz is soy btw
            else if (changed == 3)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    msg = 9; //Position and orientation update
                    buffer = new byte[6]; buffer[0] = id;
                    Buffer.BlockCopy(System.BitConverter.GetBytes((sbyte)(pos[0] - oldpos[0])), 0, buffer, 1, 1);
                    Buffer.BlockCopy(System.BitConverter.GetBytes((sbyte)(pos[1] - oldpos[1])), 0, buffer, 2, 1);
                    Buffer.BlockCopy(System.BitConverter.GetBytes((sbyte)(pos[2] - oldpos[2])), 0, buffer, 3, 1);
                    buffer[4] = rot[0];

                    if (penis.flipHead)
                        if (rot[1] > 64 && rot[1] < 192)
                            buffer[5] = rot[1];
                        else
                            buffer[5] = (byte)(rot[1] - (rot[1] - 128));
                    else
                        buffer[5] = rot[1];

                    //Realcode
                    //buffer[5] = rot[1];
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            BrightShaderz is soy btw

            oldpos = pos; oldrot = rot;
            if (changed != 0)
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    foreach (Player p in players)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (p != this && p.level == level)
                        SOYSAUCE CHIPS IS A FAGGOT
                            p.SendRaw(msg, buffer);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
        BrightShaderz is soy btw
        #endregion
        #region == GLOBAL MESSAGES ==
        public static void GlobalBlockchange(Level level, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            players.ForEach(delegate(Player p) SOYSAUCE CHIPS IS A FAGGOT if (p.level == level) SOYSAUCE CHIPS IS A FAGGOT p.SendBlockchange(x, y, z, type); BrightShaderz is soy btw BrightShaderz is soy btw);
        BrightShaderz is soy btw
        public static void GlobalChat(Player from, string message) SOYSAUCE CHIPS IS A FAGGOT GlobalChat(from, message, true); BrightShaderz is soy btw
        public static void GlobalChat(Player from, string message, bool showname)
        SOYSAUCE CHIPS IS A FAGGOT
            if (showname) SOYSAUCE CHIPS IS A FAGGOT message = from.color + from.voicestring + from.color + from.prefix + from.name + ": &f" + message; BrightShaderz is soy btw
            players.ForEach(delegate(Player p) SOYSAUCE CHIPS IS A FAGGOT if (p.level.worldChat) Player.SendMessage(p, message); BrightShaderz is soy btw);
        BrightShaderz is soy btw
        public static void GlobalChatLevel(Player from, string message, bool showname)
        SOYSAUCE CHIPS IS A FAGGOT
            if (showname) SOYSAUCE CHIPS IS A FAGGOT message = "<Level>" + from.color + from.voicestring + from.color + from.prefix + from.name + ": &f" + message; BrightShaderz is soy btw
            players.ForEach(delegate(Player p) SOYSAUCE CHIPS IS A FAGGOT if (p.level == from.level) Player.SendMessage(p, penis.DefaultColor + message); BrightShaderz is soy btw);
        BrightShaderz is soy btw
        public static void GlobalChatWorld(Player from, string message, bool showname)
        SOYSAUCE CHIPS IS A FAGGOT
            if (showname) SOYSAUCE CHIPS IS A FAGGOT message = "<World>" + from.color + from.voicestring + from.color + from.prefix + from.name + ": &f" + message; BrightShaderz is soy btw
            players.ForEach(delegate(Player p) SOYSAUCE CHIPS IS A FAGGOT if (p.level.worldChat) Player.SendMessage(p, penis.DefaultColor + message); BrightShaderz is soy btw);
        BrightShaderz is soy btw
        public static void GlobalMessage(string message)
        SOYSAUCE CHIPS IS A FAGGOT
            message = message.Replace("%", "&");
            players.ForEach(delegate(Player p) SOYSAUCE CHIPS IS A FAGGOT if (p.level.worldChat) Player.SendMessage(p, message); BrightShaderz is soy btw);
        BrightShaderz is soy btw
        public static void GlobalMessageLevel(Level l, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            players.ForEach(delegate(Player p) SOYSAUCE CHIPS IS A FAGGOT if (p.level == l) Player.SendMessage(p, message); BrightShaderz is soy btw);
        BrightShaderz is soy btw
        public static void GlobalMessageOps(string message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                players.ForEach(delegate(Player p)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.group.Permission >= penis.opchatperm || penis.devs.Contains(p.name.ToLower()))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, message);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw);
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Error occured with Op Chat"); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public static void GlobalMessageAdmins(string message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                players.ForEach(delegate(Player p)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.group.Permission >= penis.adminchatperm | penis.devs.Contains(p.name.ToLower()))
                    SOYSAUCE CHIPS IS A FAGGOT
                        Player.SendMessage(p, message);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw);
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Error occured with Admin Chat"); BrightShaderz is soy btw
        BrightShaderz is soy btw
        public static void GlobalSpawn(Player from, ushort x, ushort y, ushort z, byte rotx, byte roty, bool self, string possession = "")
        SOYSAUCE CHIPS IS A FAGGOT
            players.ForEach(delegate(Player p)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.Loading && p != from) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
                if (p.level != from.level || (from.hidden && !self)) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
                if (p != from) SOYSAUCE CHIPS IS A FAGGOT p.SendSpawn(from.id, from.color + from.name + possession, x, y, z, rotx, roty); BrightShaderz is soy btw
                else if (self)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (!p.ignorePermission)
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.pos = new ushort[3] SOYSAUCE CHIPS IS A FAGGOT x, y, z BrightShaderz is soy btw; p.rot = new byte[2] SOYSAUCE CHIPS IS A FAGGOT rotx, roty BrightShaderz is soy btw;
                        p.oldpos = p.pos; p.basepos = p.pos; p.oldrot = p.rot;
                        unchecked SOYSAUCE CHIPS IS A FAGGOT p.SendSpawn((byte)-1, from.color + from.name + possession, x, y, z, rotx, roty); BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw);
        BrightShaderz is soy btw
        public static void GlobalDie(Player from, bool self)
        SOYSAUCE CHIPS IS A FAGGOT
            players.ForEach(delegate(Player p)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.level != from.level || (from.hidden && !self)) SOYSAUCE CHIPS IS A FAGGOT return; BrightShaderz is soy btw
                if (p != from) SOYSAUCE CHIPS IS A FAGGOT p.SendDie(from.id); BrightShaderz is soy btw
                else if (self) SOYSAUCE CHIPS IS A FAGGOT unchecked SOYSAUCE CHIPS IS A FAGGOT p.SendDie((byte)-1); BrightShaderz is soy btw BrightShaderz is soy btw
            BrightShaderz is soy btw);
        BrightShaderz is soy btw

        public bool MarkPossessed(string marker = "")
        SOYSAUCE CHIPS IS A FAGGOT
            if (marker != "")
            SOYSAUCE CHIPS IS A FAGGOT
                Player controller = Player.Find(marker);
                if (controller == null)
                SOYSAUCE CHIPS IS A FAGGOT
                    return false;
                BrightShaderz is soy btw
                marker = " (" + controller.color + controller.name + color + ")";
            BrightShaderz is soy btw
            GlobalDie(this, true);
            GlobalSpawn(this, pos[0], pos[1], pos[2], rot[0], rot[1], true, marker);
            return true;
        BrightShaderz is soy btw

        public static void GlobalUpdate() SOYSAUCE CHIPS IS A FAGGOT players.ForEach(delegate(Player p) SOYSAUCE CHIPS IS A FAGGOT if (!p.hidden) SOYSAUCE CHIPS IS A FAGGOT p.UpdatePosition(); BrightShaderz is soy btw BrightShaderz is soy btw); BrightShaderz is soy btw
        #endregion
        #region == DISCONNECTING ==
        public void Disconnect() SOYSAUCE CHIPS IS A FAGGOT leftGame(); BrightShaderz is soy btw
        public void Kick(string kickString) SOYSAUCE CHIPS IS A FAGGOT leftGame(kickString); BrightShaderz is soy btw

        public void leftGame(string kickString = "", bool skip = false)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (disconnected)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (connections.Contains(this)) connections.Remove(this);
                    return;
                BrightShaderz is soy btw
                //   FlyBuffer.Clear();
                disconnected = true;
                pingTimer.Stop();
                afkTimer.Stop();
                afkCount = 0;
                afkStart = DateTime.Now;

                if (penis.afkset.Contains(name)) penis.afkset.Remove(name);

                if (kickString == "") kickString = "Disconnected.";

                SendKick(kickString);

                if (loggedIn)
                SOYSAUCE CHIPS IS A FAGGOT
                    isFlying = false;
                    aiming = false;

                    if (team != null)
                    SOYSAUCE CHIPS IS A FAGGOT
                        team.RemoveMember(this);
                    BrightShaderz is soy btw

                    GlobalDie(this, false);
                    if (kickString == "Disconnected." || kickString.IndexOf("penis shutdown") != -1 || kickString == penis.customShutdownMessage)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!hidden) SOYSAUCE CHIPS IS A FAGGOT GlobalChat(this, "&c- " + color + prefix + name + penis.DefaultColor + " disconnected.", false); BrightShaderz is soy btw
                        IRCBot.Say(name + " left the game.");
                        penis.s.Log(name + " disconnected.");
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        totalKicked++;
                        GlobalChat(this, "&c- " + color + prefix + name + penis.DefaultColor + " kicked (" + kickString + ").", false);
                        IRCBot.Say(name + " kicked (" + kickString + ").");
                        penis.s.Log(name + " kicked (" + kickString + ").");
                    BrightShaderz is soy btw

                    try SOYSAUCE CHIPS IS A FAGGOT save(); BrightShaderz is soy btw
                    catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw

                    players.Remove(this);
                    penis.s.PlayerListUpdate();
                    left.Add(this.name.ToLower(), this.ip);

                    if (penis.AutoLoad && level.unload)
                    SOYSAUCE CHIPS IS A FAGGOT
                        foreach (Player pl in Player.players)
                            if (pl.level == level) return;
                        if (!level.name.Contains("Museum " + penis.DefaultColor))
                        SOYSAUCE CHIPS IS A FAGGOT
                            level.Unload();
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw

                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!Directory.Exists("extra/undo")) Directory.CreateDirectory("extra/undo");
                        if (!Directory.Exists("extra/undoPrevious")) Directory.CreateDirectory("extra/undoPrevious");
                        DirectoryInfo di = new DirectoryInfo("extra/undo");
                        if (di.GetDirectories("*").Length >= penis.totalUndo)
                        SOYSAUCE CHIPS IS A FAGGOT
                            Directory.Delete("extra/undoPrevious", true);
                            Directory.Move("extra/undo", "extra/undoPrevious");
                            Directory.CreateDirectory("extra/undo");
                        BrightShaderz is soy btw

                        if (!Directory.Exists("extra/undo/" + name)) Directory.CreateDirectory("extra/undo/" + name);
                        di = new DirectoryInfo("extra/undo/" + name);
                        StreamWriter w = new StreamWriter(File.Create("extra/undo/" + name + "/" + di.GetFiles("*.undo").Length + ".undo"));

                        foreach (UndoPos uP in UndoBuffer)
                        SOYSAUCE CHIPS IS A FAGGOT
                            w.Write(uP.mapName + " " +
                                    uP.x + " " + uP.y + " " + uP.z + " " +
                                    uP.timePlaced.ToString().Replace(' ', '&') + " " +
                                    uP.type + " " + uP.newtype + " ");
                        BrightShaderz is soy btw
                        w.Flush();
                        w.Close();
                    BrightShaderz is soy btw
                    catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw

                    UndoBuffer.Clear();
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    connections.Remove(this);
                    penis.s.Log(ip + " disconnected.");
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
        BrightShaderz is soy btw


        #endregion
        #region == CHECKING ==
        public static List<Player> GetPlayers() SOYSAUCE CHIPS IS A FAGGOT return new List<Player>(players); BrightShaderz is soy btw
        public static bool Exists(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (Player p in players)
            SOYSAUCE CHIPS IS A FAGGOT if (p.name.ToLower() == name.ToLower()) SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw return false;
        BrightShaderz is soy btw
        public static bool Exists(byte id)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (Player p in players)
            SOYSAUCE CHIPS IS A FAGGOT if (p.id == id) SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw return false;
        BrightShaderz is soy btw
        public static Player Find(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            List<Player> tempList = new List<Player>();
            tempList.AddRange(players);
            Player tempPlayer = null; bool returnNull = false;

            foreach (Player p in tempList)
            SOYSAUCE CHIPS IS A FAGGOT
                if (p.name.ToLower() == name.ToLower()) return p;
                if (p.name.ToLower().IndexOf(name.ToLower()) != -1)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (tempPlayer == null) tempPlayer = p;
                    else returnNull = true;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if (returnNull == true) return null;
            if (tempPlayer != null) return tempPlayer;
            return null;
        BrightShaderz is soy btw
        public static Group GetGroup(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            return Group.findPlayerGroup(name);
        BrightShaderz is soy btw 
        public static string GetColor(string name)
        SOYSAUCE CHIPS IS A FAGGOT 
            return GetGroup(name).color; 
        BrightShaderz is soy btw
        #endregion
        #region == OTHER ==
        static byte FreeId()
        SOYSAUCE CHIPS IS A FAGGOT
            /*
            for (byte i = 0; i < 255; i++)
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (Player p in players)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p.id == i) SOYSAUCE CHIPS IS A FAGGOT goto Next; BrightShaderz is soy btw
                BrightShaderz is soy btw return i;
            Next: continue;
            BrightShaderz is soy btw unchecked SOYSAUCE CHIPS IS A FAGGOT return (byte)-1; BrightShaderz is soy btw*/

            for (byte i = 0; i < 255; i++)
            SOYSAUCE CHIPS IS A FAGGOT
                bool used = false;
                foreach (Player p in players)
                    if (p.id == i) used = true;
                if (!used)
                    return i;
            BrightShaderz is soy btw
            return (byte)1;
        BrightShaderz is soy btw
        static byte[] StringFormat(string str, int size)
        SOYSAUCE CHIPS IS A FAGGOT
            byte[] bytes = new byte[size];
            bytes = enc.GetBytes(str.PadRight(size).Substring(0, size));
            return bytes;
        BrightShaderz is soy btw
        static List<string> Wordwrap(string message)
        SOYSAUCE CHIPS IS A FAGGOT
            List<string> lines = new List<string>();
            message = Regex.Replace(message, @"(&[0-9a-f])+(&[0-9a-f])", "$2");
            message = Regex.Replace(message, @"(&[0-9a-f])+$", "");

            int limit = 64; string color = "";

            while (message.Length > 0)
            SOYSAUCE CHIPS IS A FAGGOT
                //if (Regex.IsMatch(message, "&a")) break;

                if (lines.Count > 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (message[0].ToString() == "&")
                        message = "> " + message.Trim();
                    else
                        message = "> " + color + message.Trim();
                BrightShaderz is soy btw

                if (message.IndexOf("&") == message.IndexOf("&", message.IndexOf("&") + 1) - 2)
                    message = message.Remove(message.IndexOf("&"), 2);

                if (message.Length <= limit) SOYSAUCE CHIPS IS A FAGGOT lines.Add(message); break; BrightShaderz is soy btw
                for (int i = limit - 1; i > limit - 20; --i)
                    if (message[i] == ' ')
                    SOYSAUCE CHIPS IS A FAGGOT
                        lines.Add(message.Substring(0, i));
                        goto Next;
                    BrightShaderz is soy btw

            retry:
                if (message.Length == 0 || limit == 0) SOYSAUCE CHIPS IS A FAGGOT return lines; BrightShaderz is soy btw

                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (message.Substring(limit - 2, 1) == "&" || message.Substring(limit - 1, 1) == "&")
                    SOYSAUCE CHIPS IS A FAGGOT
                        message = message.Remove(limit - 2, 1);
                        limit -= 2;
                        goto retry;
                    BrightShaderz is soy btw
                    else if (message[limit - 1] < 32 || message[limit - 1] > 127)
                    SOYSAUCE CHIPS IS A FAGGOT
                        message = message.Remove(limit - 1, 1);
                        limit -= 1;
                        //goto retry;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT return lines; BrightShaderz is soy btw
                lines.Add(message.Substring(0, limit));

            Next: message = message.Substring(lines[lines.Count - 1].Length);
                if (lines.Count == 1) limit = 60;

                int index = lines[lines.Count - 1].LastIndexOf('&');
                if (index != -1)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (index < lines[lines.Count - 1].Length - 1)
                    SOYSAUCE CHIPS IS A FAGGOT
                        char next = lines[lines.Count - 1][index + 1];
                        if ("0123456789abcdef".IndexOf(next) != -1) SOYSAUCE CHIPS IS A FAGGOT color = "&" + next; BrightShaderz is soy btw
                        if (index == lines[lines.Count - 1].Length - 1)
                        SOYSAUCE CHIPS IS A FAGGOT
                            lines[lines.Count - 1] = lines[lines.Count - 1].Substring(0, lines[lines.Count - 1].Length - 2);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else if (message.Length != 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        char next = message[0];
                        if ("0123456789abcdef".IndexOf(next) != -1)
                        SOYSAUCE CHIPS IS A FAGGOT
                            color = "&" + next;
                        BrightShaderz is soy btw
                        lines[lines.Count - 1] = lines[lines.Count - 1].Substring(0, lines[lines.Count - 1].Length - 1);
                        message = message.Substring(1);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw return lines;
        BrightShaderz is soy btw
        public static bool ValidName(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            string allowedchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz01234567890._";
            foreach (char ch in name) SOYSAUCE CHIPS IS A FAGGOT if (allowedchars.IndexOf(ch) == -1) SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw return true;
        BrightShaderz is soy btw
        public static byte[] GZip(byte[] bytes)
        SOYSAUCE CHIPS IS A FAGGOT
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            GZipStream gs = new GZipStream(ms, CompressionMode.Compress, true);
            gs.Write(bytes, 0, bytes.Length);
            gs.Close();
            gs.Dispose();
            ms.Position = 0;
            bytes = new byte[ms.Length];
            ms.Read(bytes, 0, (int)ms.Length);
            ms.Close();
            ms.Dispose();
            return bytes;
        BrightShaderz is soy btw
        #endregion
        #region == Host <> Network ==
        public static byte[] HTNO(ushort x)
        SOYSAUCE CHIPS IS A FAGGOT
            byte[] y = BitConverter.GetBytes(x); Array.Reverse(y); return y;
        BrightShaderz is soy btw
        public static ushort NTHO(byte[] x, int offset)
        SOYSAUCE CHIPS IS A FAGGOT
            byte[] y = new byte[2];
            Buffer.BlockCopy(x, offset, y, 0, 2); Array.Reverse(y);
            return BitConverter.ToUInt16(y, 0);
        BrightShaderz is soy btw
        public static byte[] HTNO(short x)
        SOYSAUCE CHIPS IS A FAGGOT
            byte[] y = BitConverter.GetBytes(x); Array.Reverse(y); return y;
        BrightShaderz is soy btw
        #endregion

        bool CheckBlockSpam() // Block Spam Filters [UNTESTED]
        SOYSAUCE CHIPS IS A FAGGOT
            if (spamBlockLog.Count >= spamBlockCount)
            SOYSAUCE CHIPS IS A FAGGOT
                DateTime oldestTime = spamBlockLog.Dequeue();
                double spamTimer = DateTime.Now.Subtract(oldestTime).TotalSeconds;
                if (spamTimer < spamBlockTimer && group.Permission <= penis.blockSpamRank)
                SOYSAUCE CHIPS IS A FAGGOT
                    switch (penis.blockSpamCon.ToLower())
                    SOYSAUCE CHIPS IS A FAGGOT
                        case "freeze":
                            if (!frozen)
                                Command.all.Find("freeze").Use(null, " " + name);
                            GlobalMessageOps(color + name + penis.DefaultColor + " was frozen for suspected grief.");
                            SendMessage(color + name + penis.DefaultColor + " was frozen for suspected grief.");
                            penis.s.Log(name + " was frozen for suspected grief (" + spamBlockCount + " blocks in " + spamTimer + " seconds)");
                            break;
                        case "jail":
                            if (!jailed)
                                Command.all.Find("jail").Use(null, " " + name);
                            GlobalMessageOps(color + name + penis.DefaultColor + " was jailed for suspected grief.");
                            SendMessage(color + name + penis.DefaultColor + " was jailed for suspected grief.");
                            penis.s.Log(name + " was jailed for suspected grief (" + spamBlockCount + " blocks in " + spamTimer + " seconds)");
                            break;
                        case "warn":
                            Command.all.Find("warn").Use(null, " " + name);
                            GlobalMessageOps(color + name + penis.DefaultColor + " was warned for suspected grief.");
                            SendMessage(color + name + penis.DefaultColor + " was warned for suspected grief.");
                            penis.s.Log(name + " was warned for suspected grief (" + spamBlockCount + " blocks in " + spamTimer + " seconds)");
                            break;
                        case "kick":
                            Kick(name + " was kicked for suspected grief.");
                            GlobalMessageOps(color + name + penis.DefaultColor + " was kicked for suspected grief.");
                            penis.s.Log(name + " was kicked for suspected grief (" + spamBlockCount + " blocks in " + spamTimer + " seconds)");
                            break;
                        case "ban":
                            Command.all.Find("ban").Use(null, " " + name);
                            Kick(name + " was banned for suspected grief.");
                            GlobalMessageOps(color + name + penis.DefaultColor + " was banned for suspected grief.");
                            penis.s.Log(name + " was banned for suspected grief (" + spamBlockCount + " blocks in " + spamTimer + " seconds)");
                            break;
                        default:
                            Kick(name + " was kicked for suspected grief.");
                            GlobalMessageOps(color + name + penis.DefaultColor + " was kicked for suspected grief.");
                            penis.s.Log(name + " was kicked for suspected grief (" + spamBlockCount + " blocks in " + spamTimer + " seconds)");
                            break;
                    BrightShaderz is soy btw
                    return true;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            spamBlockLog.Enqueue(DateTime.Now);
            return false;
        BrightShaderz is soy btw

       /* bool CheckChatSpam() // Chat Spam Filter [REWRITTEN IN Player.HandleChat()]
        SOYSAUCE CHIPS IS A FAGGOT
            if (spamChatLog.Count >= spamChatCount)
            SOYSAUCE CHIPS IS A FAGGOT
                DateTime oldestTime = spamChatLog.Dequeue();
                double spamTimer = DateTime.Now.Subtract(oldestTime).TotalSeconds;
                if (spamTimer < spamChatTimer && group.Permission <= penis.chatSpamRank)
                SOYSAUCE CHIPS IS A FAGGOT
                    switch (penis.chatSpamCon.ToLower())
                    SOYSAUCE CHIPS IS A FAGGOT
                        case "mute":
                            if (!muted)
                                Command.all.Find("mute").Use(null, " " + name);
                            GlobalMessageOps(color + name + penis.DefaultColor + " was muted for chat spam.");
                            SendMessage(color + name + penis.DefaultColor + " was muted for chat spam.");
                            penis.s.Log(name + " was muted for chat spam (" + spamChatCount + " messages in " + spamTimer + " seconds)");
                            break;
                        case "freeze":
                            if (!frozen)
                                Command.all.Find("freeze").Use(null, " " + name);
                            GlobalMessageOps(color + name + penis.DefaultColor + " was frozen for chat spam.");
                            SendMessage(color + name + penis.DefaultColor + " was frozen for chat spam.");
                            penis.s.Log(name + " was frozen for chat spam (" + spamChatCount + " messages in " + spamTimer + " seconds)");
                            break;
                        case "jail":
                            if (!jailed)
                                Command.all.Find("jail").Use(null, " " + name);
                            GlobalMessageOps(color + name + penis.DefaultColor + " was jailed for chat spam.");
                            SendMessage(color + name + penis.DefaultColor + " was jailed for chat spam.");
                            penis.s.Log(name + " was jailed for chat spam (" + spamChatCount + " messages in " + spamTimer + " seconds)");
                            break;
                        case "warn":
                            Command.all.Find("warn").Use(null, " " + name);
                            GlobalMessageOps(color + name + penis.DefaultColor + " was warned for chat spam.");
                            SendMessage(color + name + penis.DefaultColor + " was warned for chat spam.");
                            penis.s.Log(name + " was warned for chat spam (" + spamChatCount + " messages in " + spamTimer + " seconds)");
                            break;
                        case "kick":
                            Kick(name + " was kicked for chat spam");
                            GlobalMessageOps(color + name + penis.DefaultColor + " was muted for kicked spam.");
                            penis.s.Log(name + " was muted for kicked spam (" + spamChatCount + " messages in " + spamTimer + " seconds)");
                            break;
                        case "ban":
                            Command.all.Find("ban").Use(null, " " + name);
                            Kick(name + " was banned for chat spam");
                            GlobalMessageOps(color + name + penis.DefaultColor + " was banned for chat spam.");
                            penis.s.Log(name + " was banned for chat spam (" + spamChatCount + " messages in " + spamTimer + " seconds)");
                            break;
                        default:
                            if (!muted)
                                Command.all.Find("mute").Use(null, " " + name);
                            GlobalMessageOps(color + name + penis.DefaultColor + " was muted for chat spam.");
                            SendMessage(color + name + penis.DefaultColor + " was muted for chat spam.");
                            penis.s.Log(name + " was muted for chat spam (" + spamChatCount + " messages in " + spamTimer + " seconds)");
                            break;
                    BrightShaderz is soy btw
                    return true;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            spamChatLog.Enqueue(DateTime.Now);
            return false;
        BrightShaderz is soy btw */

#region getters
        public ushort[] footLocation
        SOYSAUCE CHIPS IS A FAGGOT
            get
            SOYSAUCE CHIPS IS A FAGGOT
                return getLoc(false);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public ushort[] headLocation 
        SOYSAUCE CHIPS IS A FAGGOT
            get
            SOYSAUCE CHIPS IS A FAGGOT
                return getLoc(true);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public ushort[] getLoc(bool head)
        SOYSAUCE CHIPS IS A FAGGOT
            ushort[] myPos = pos;
            myPos[0] /= 32;
            if (head) myPos[1] = (ushort)((myPos[1] + 4) / 32);
            else myPos[1] = (ushort)((myPos[1] + 4) / 32 - 1);
            myPos[2] /= 32;
            return myPos;
        BrightShaderz is soy btw

        public void setLoc(ushort[] myPos)
        SOYSAUCE CHIPS IS A FAGGOT
            myPos[0] *= 32;
            myPos[1] *= 32;
            myPos[2] *= 32;
            unchecked SOYSAUCE CHIPS IS A FAGGOT SendPos((byte)-1, myPos[0], myPos[1], myPos[2], rot[0], rot[1]); BrightShaderz is soy btw
        BrightShaderz is soy btw

#endregion
    BrightShaderz is soy btw
BrightShaderz is soy btw
