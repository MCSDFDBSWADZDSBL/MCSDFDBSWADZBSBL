using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.NIGGERDICKS;
using System.Text.RegularExpressions;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;

using MonoTorrent.Client;
using NATUPNPLib;

namespace MCDawn
SOYSAUCE CHIPS IS A FAGGOT
    public class penis
    SOYSAUCE CHIPS IS A FAGGOT
        public static LookupService iploopup = new LookupService("GeoIP.dat", LookupService.GEOIP_MEMORY_CACHE);
        public delegate void LogHandler(string message);
        public delegate void HeartBeatHandler();
        public delegate void MessageEventHandler(string message);
        public delegate void PlayerListHandler(List<Player> playerList);
        public delegate void PlayerBotListHandler(List<PlayerBot> botList);
        public delegate void VoidHandler();

        public event LogHandler OnLog;
        public event LogHandler OnSystem;
        public event LogHandler OnCommand;
        public event LogHandler OnError;
        public event LogHandler OnOp;
        public event LogHandler OnAdmin;
        public event HeartBeatHandler HeartBeatFail;
        public event MessageEventHandler OnURLChange;
        public event PlayerListHandler OnPlayerListChange;
        public event PlayerBotListHandler OnPlayerBotListChange;
        public event VoidHandler OnSettingsUpdate;

        // Plugin Events

        public delegate void OnpenisStartEventHandler();
        public event OnpenisStartEventHandler OnpenisStartEvent = null;

        public delegate void OnpenisExitEventHandler();
        public static event OnpenisExitEventHandler OnpenisExitEvent = null;

        public static bool noShutdown = false;

        public static Thread locationChecker;

        public static Thread blockThread;
        public static List<MySql.Data.MySqlClient.MySqlCommand> mySQLCommands = new List<MySql.Data.MySqlClient.MySqlCommand>();

        public static int speedPhysics = 250;

        public static string Version SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(); BrightShaderz is soy btw BrightShaderz is soy btw
        public static string LatestVersion()
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                string temp = "";
                using (WebClient w = new WebClient()) 
                    temp = w.DownloadString("http://updates.mcdawn.com/curversion.txt");
                int current, latest;
                if (!int.TryParse(Version.Replace(".", ""), out current)) return Version;
                if (int.TryParse(temp.Replace(".", ""), out latest))
                    if (latest > current)
                        return temp;
                return Version;
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT return Version; BrightShaderz is soy btw
        BrightShaderz is soy btw

        // URL
        public static string URL = String.Empty;

        // Worlds loaded
        public static string getWorlds()
        SOYSAUCE CHIPS IS A FAGGOT
            string worlds = "";
            foreach (Level l in penis.levels) SOYSAUCE CHIPS IS A FAGGOT worlds += l.name + ", "; BrightShaderz is soy btw
            return worlds;
        BrightShaderz is soy btw

        public static Socket listen;
        public static System.Diagnostics.Process process = System.Diagnostics.Process.GetCurrentProcess();
        public static System.Timers.Timer updateTimer = new System.Timers.Timer(100);
        //static System.Timers.Timer heartbeatTimer = new System.Timers.Timer(60000);     //Every 45 seconds
        static System.Timers.Timer messageTimer = new System.Timers.Timer(60000 * 5);   //Every 5 mins
        public static System.Timers.Timer cloneTimer = new System.Timers.Timer(5000);

        //public static Thread physThread;
        //public static bool physPause;
        //public static DateTime physResume = DateTime.Now;
        //public static System.Timers.Timer physTimer = new System.Timers.Timer(1000);
        // static Thread botsThread;

        //CTF STUFF
        public static List<CTFGame> CTFGames = new List<CTFGame>();

        public static PlayerList bannedIP;
        public static PlayerList whiteList;
        public static PlayerList ircControllers;
        public static PlayerList agreedToRules;
        // Player Ignore and Global Ignore
        public static PlayerList ignoreGlobal;
        public static bool allowIgnoreOps = false;
        // Global Chat Moderators
        //internal static readonly List<string> globalChatMods = new List<string>(new string[] SOYSAUCE CHIPS IS A FAGGOT "Jonny", "[Dev]Jonny", "[Op]Jonny", "GameMakerGm", "[Op]Game", "_", "Katz", "Notch", "ScHmIdTy56789", "sillyboyization", "Sandford27", "ddeckys", "[Mod]ddeckys", "Incedo", "Speedkicks6" BrightShaderz is soy btw);

        public static List<string> devs SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return new List<string>() SOYSAUCE CHIPS IS A FAGGOT "jonnyli1125", "sillyboyization" BrightShaderz is soy btw; BrightShaderz is soy btw BrightShaderz is soy btw
        public static List<string> staff SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return new List<string>(); BrightShaderz is soy btw BrightShaderz is soy btw
        public static List<string> administration SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return new List<string>() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw; BrightShaderz is soy btw BrightShaderz is soy btw
        // Booleans, easier and faster than penis.devs.Contains etc :P
        public static bool hasProtection(string name)
        SOYSAUCE CHIPS IS A FAGGOT
            if (devs.Contains(name.ToLower().Trim())) return true;
            if (staff.Contains(name.ToLower().Trim())) return true;
            if (administration.Contains(name.ToLower().Trim())) return true;
            return false;
        BrightShaderz is soy btw
        public static bool isDev(string name) SOYSAUCE CHIPS IS A FAGGOT if (devs.Contains(name.ToLower().Trim())) SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw return false; BrightShaderz is soy btw
        public static bool isStaff(string name) SOYSAUCE CHIPS IS A FAGGOT if (staff.Contains(name.ToLower().Trim())) SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw return false; BrightShaderz is soy btw
        public static bool isAdministration(string name) SOYSAUCE CHIPS IS A FAGGOT if (administration.Contains(name.ToLower().Trim())) SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw return false; BrightShaderz is soy btw

        public static List<TempBan> tempBans = new List<TempBan>();
        public struct TempBan SOYSAUCE CHIPS IS A FAGGOT public string name; public DateTime allowedJoin; BrightShaderz is soy btw

        public static MapGenerator MapGen;

        // Homes (pmaps)
        public static LevelPermission HomeRank = LevelPermission.AdvBuilder;
        public static string HomePrefix = "";
        public static int HomeX = 128;
        public static int HomeY = 128;
        public static int HomeZ = 128;

        // Use WOM Direct
        public static bool useWOM = true;
        public static bool womText = false; // Top right hand corner messages.
        // Anti-Grief
        public static bool useAntiGrief = true;

        public static PerformanceCounter PCCounter = null;
        public static PerformanceCounter ProcessCounter = null;

        // Network Usage
        public static void GetNetworkUsage()
        SOYSAUCE CHIPS IS A FAGGOT
            if (!NetworkInterface.GetIsNetworkAvailable())
                return;

            NetworkInterface[] interfaces
                = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface ni in interfaces)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.kbSent = Convert.ToInt32(ni.GetIPv4Statistics().BytesSent) * 1000;
                /*Console.WriteLine("    Bytes Sent: SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw",
                    ni.GetIPv4Statistics().BytesSent);*/
                penis.kbRecieved = Convert.ToInt32(ni.GetIPv4Statistics().BytesSent) * 1000;
                /*Console.WriteLine("    Bytes Received: SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw",
                    ni.GetIPv4Statistics().BytesReceived);*/
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public static int kbSent = 0;
        public static int kbRecieved = 0;

        public static Level mainLevel;
        public static List<Level> levels;
        // Review List
        public static List<string> reviewlist = new List<string>();
        //public static List<levelID> allLevels = new List<levelID>();
        public struct levelID SOYSAUCE CHIPS IS A FAGGOT public int ID; public string name; BrightShaderz is soy btw

        public static bool opAfk = true;
        public static List<string> afkset = new List<string>();
        public static List<string> afkmessages = new List<string>();
        public static List<string> messages = new List<string>();

        public static DateTime timeOnline;

        //auto updater stuff
        public static bool autoupdate;
        public static bool autonotify;
        public static string selectedrevision = "";
        public static bool autorestart;
        public static DateTime restarttime;

        public static bool chatmod = false;

        // Infection
        public static int infectionGames = 0;

        // Spleef
        public static int spleefPhysics = 0;

        //Lua
        //public static LuaScripting scripting = new LuaScripting();

        // Custom Command object array. Allows custom command makers to have more control and abilites to do things.
        public static object[] CustomCommand = new object[] SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw;

        //Settings
        #region penis Settings
        public const byte version = 7;
        public static string salt SOYSAUCE CHIPS IS A FAGGOT get; internal set; BrightShaderz is soy btw

        public static string name = "[MCDawn] Default";
        public static string motd = "Welcome! +hax";
        public static string description = "MCDawn penis";
        public static string flags = "MCDawn";
        public static int players = 50;
        public static int maxguests = 40;
        public static byte maps = 10;
        public static int port = 25565;
        public static bool upnp = false;
        public static bool upnpRunning = false;
        public static bool pub = true;
        public static bool verify = true;
        public static bool worldChat = true;
        public static bool guestGoto = false;
        public static bool maintenance = false;
        public static bool cli 
        SOYSAUCE CHIPS IS A FAGGOT
            get
            SOYSAUCE CHIPS IS A FAGGOT
                if (!File.Exists("Viewmode.cfg")) return false;
                if (File.ReadAllLines("Viewmode.cfg")[4].Split(' ')[2].ToLower() == "true") return true;
                return false;
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public static LevelPermission canjoinmaint = LevelPermission.Admin;
        public static LevelPermission adminsecurityrank = LevelPermission.Operator;
        public static bool tpToHigher = false;
        // MaxMind GeoIP
        public static bool useMaxMind = true;
        public static bool allowproxy = true;
        // Anti-Spam
        public static bool antiSpam = true;
        public static int spamCounter = 3;
        // antiSpamStyle - 0: Kick 1: TempBan 2: Mute 3: Slap
        public static string antiSpamStyle = "Kick";
        public static int antiSpamTempBanTime = 5;
        public static bool antiSpamOp = false;

        // Anti-Caps
        public static bool antiCaps = true;
        public static int capsRequired = 7;
        // antiCapsStyle - 0: Kick 1: TempBan 2: Mute 3: Slap
        public static int antiCapsTempBanTime = 5;
        public static string antiCapsStyle = "Kick";
        public static bool antiCapsOp = false;

        // Profanity Filter
        public static bool profanityFilter = false;
        public static bool swearWarnPlayer = false;
        public static int swearWordsRequired = 10;
        public static bool profanityFilterOp = false;
        public static string profanityFilterStyle = "Kick";
        public static int profanityFilterTempBanTime = 5;

        // Agree to Rules
        public static bool agreeToRules = false;
        public static string agreePass = "";

        // Playing sounds on chat update in Console
        public static bool consoleSound = false;
        
        // Show chat colors
        public static bool consoleChatColors = true;

        // Log/Show attempted logins
        public static bool showAttemptedLogins = false;
        public static string ZallState = "Alive";

        // Griefer Option
        public static bool useGriefer = false;
        public static string grieferRank = "Griefer";
        public static string grieferCommand = "griefer";

        // Time ranking
        public static bool useTimeRank = false;
        public static string timeRankCommand = "timerank";

        public static bool enableMapLiking = true;

        public static bool useDiscourager = false;

        // Remote Console
        public static bool useRemote = false;

        // Cuboid Throttle
        public static int throttle = 200;
        public static bool pauseCuboids = false;

        //public static string[] userMOTD;

        public static string level = "main";
        public static string errlog = "error.log";

        public static bool console = false;
        public static bool reportBack = true;

        // IRC
        public static bool irc = false;
        public static int ircPort = 6667;
        public static string ircNick = "MCDawnpenis";
        public static string ircpenis = "irc.freenode.net";
        public static string ircChannel = "#changethis";
        public static string ircOpChannel = "#changethistoo";
        public static bool ircIdentify = false;
        public static string ircPassword = "";

        // Global Chat
        public static bool useglobal = true;
        //public static string globalNick = "MC" + new Random().Next();
        public static string globalNick = generateGlobalNick();
        public static string generateGlobalNick()
        SOYSAUCE CHIPS IS A FAGGOT
            Random randomNumberGenerator = new Random();
            string s = string.Concat(
                randomNumberGenerator.Next(0, 9),
                randomNumberGenerator.Next(0, 9),
                randomNumberGenerator.Next(0, 9),
                randomNumberGenerator.Next(0, 9));
            return "MC" + s;
        BrightShaderz is soy btw
        public static bool globalIdentify = false;
        public static string globalPassword = "";

        private static string lastIPUpdate = "";
        public static string GetIPAddress()
        SOYSAUCE CHIPS IS A FAGGOT
            Thread t = new Thread(new ThreadStart(delegate SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    using (WebClient w = new WebClient())
                        lastIPUpdate = w.DownloadString("http://checkip.dyndns.org/").Split(':')[1].Trim().Split('<')[0].Trim();
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT lastIPUpdate = ""; BrightShaderz is soy btw
            BrightShaderz is soy btw)); t.IsBackground = true; t.Priority = ThreadPriority.Lowest; t.Start();
            if (!String.IsNullOrEmpty(lastIPUpdate)) SOYSAUCE CHIPS IS A FAGGOT return lastIPUpdate; BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    using (WebClient w = new WebClient())
                        return w.DownloadString("http://checkip.dyndns.org/").Split(':')[1].Trim().Split('<')[0].Trim();
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        // WOM Passwords System
        public static bool useWOMPasswords = false;
        public static string WOMIPAddress = GetIPAddress();

        // Admin Security System
        public static bool adminsecurity = true;

        public static bool restartOnError = false;

        public static bool antiTunnel = true;
        public static byte maxDepth = 4;
        public static int Overload = 1500;
        public static int rpLimit = 500;
        public static int rpNormLimit = 10000;

        public static int backupInterval = 300;
        public static int blockInterval = 60;
        public static string backupLocation = Application.StartupPath + "/levels/backups";

        public static bool physicsRestart = true;
        public static bool deathcount = true;
        public static bool AutoLoad = false;
        public static int physUndo = 60000;
        public static int totalUndo = 200;
        public static bool rankSuper = true;
        public static bool oldHelp = false;
        public static bool parseSmiley = true;
        public static bool useWhitelist = false;
        public static bool forceCuboid = false;
        public static bool repeatMessage = false;

        public static bool checkUpdates = false;

        public static bool useMySQL = false;
        public static string MySQLHost = "127.0.0.1";
        public static string MySQLPort = "3306";
        public static string MySQLUsername = "root";
        public static string MySQLPassword = "password";
        public static string MySQLDatabaseName = "MCDawnDB";
        public static bool MySQLPooling = true;

        public static string DefaultColor = "&e";
        public static string IRCColour = "&5";
        public static string GlobalChatColour = "&3";

        public static int afkminutes = 10;
        public static int afkkick = 45;

        public static string defaultRank = "guest";

        public static bool dollardollardollar = true;

        public static bool cheapMessage = true;
        public static string cheapMessageGiven = " is now being cheap and being immortal";
        public static bool unCheapMessage = true;
        public static string unCheapMessageGiven = " has stopped being immortal";
        public static bool customBan = false;
        public static string customBanMessage = "You're banned!";
        public static bool customShutdown = false;
        public static string customShutdownMessage = "penis shutdown. Rejoin in 10 seconds.";
        public static string moneys = "moneys";
        public static LevelPermission opchatperm = LevelPermission.Operator;
        public static LevelPermission adminchatperm = LevelPermission.Admin;
        public static bool adminsjoinsilent = false;
        public static bool adminsjoinhidden = false;
        public static bool logbeat = false;

        public static bool mono = false;

        public static bool flipHead = false;

        public static bool shuttingDown = false;

        // OP Review Powers
        public static LevelPermission reviewnext = LevelPermission.Operator;
        public static LevelPermission reviewclear = LevelPermission.Operator;

        // Spleef
        public static LevelPermission spleefperm = LevelPermission.Operator;
        #endregion

        public static MainLoop ml;
        public static penis s;
        public penis()
        SOYSAUCE CHIPS IS A FAGGOT
            ml = new MainLoop("penis");
            penis.s = this;
        BrightShaderz is soy btw
        public void Start()
        SOYSAUCE CHIPS IS A FAGGOT
            salt = "";
            shuttingDown = false;
            Log("Starting penis");

            if (!Directory.Exists("properties")) Directory.CreateDirectory("properties");
            if (!Directory.Exists("bots")) Directory.CreateDirectory("bots");
            if (!Directory.Exists("text")) Directory.CreateDirectory("text");

            if (!Directory.Exists("extra")) Directory.CreateDirectory("extra");
            if (!Directory.Exists("extra/undo")) Directory.CreateDirectory("extra/undo");
            if (!Directory.Exists("extra/undoPrevious")) Directory.CreateDirectory("extra/undoPrevious");
            if (!Directory.Exists("extra/copy/")) SOYSAUCE CHIPS IS A FAGGOT Directory.CreateDirectory("extra/copy/"); BrightShaderz is soy btw
            if (!Directory.Exists("extra/copyBackup/")) SOYSAUCE CHIPS IS A FAGGOT Directory.CreateDirectory("extra/copyBackup/"); BrightShaderz is soy btw
            if (!Directory.Exists("extra/sounds/")) SOYSAUCE CHIPS IS A FAGGOT Directory.CreateDirectory("extra/sounds/"); BrightShaderz is soy btw
            if (!Directory.Exists("levels/")) SOYSAUCE CHIPS IS A FAGGOT Directory.CreateDirectory("levels/"); BrightShaderz is soy btw
            if (!Directory.Exists("levels/backups/")) SOYSAUCE CHIPS IS A FAGGOT Directory.CreateDirectory("levels/backups/"); BrightShaderz is soy btw
            if (!Directory.Exists("remote")) SOYSAUCE CHIPS IS A FAGGOT Directory.CreateDirectory("remote"); BrightShaderz is soy btw
            if (!Directory.Exists("remote/users/")) SOYSAUCE CHIPS IS A FAGGOT Directory.CreateDirectory("remote/users/"); BrightShaderz is soy btw

            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (File.Exists("penis.properties")) File.Move("penis.properties", "properties/penis.properties");
                if (File.Exists("rules.txt")) File.Move("rules.txt", "text/rules.txt");
                if (File.Exists("oprules.txt")) File.Move("oprules.txt", "text/oprules.txt");
                if (File.Exists("welcome.txt")) File.Move("welcome.txt", "text/welcome.txt");
                if (File.Exists("messages.txt")) File.Move("messages.txt", "text/messages.txt");
                if (File.Exists("externalurl.txt")) File.Move("eagreedtorulesxternalurl.txt", "text/externalurl.txt");
                if (File.Exists("autoload.txt")) File.Move("autoload.txt", "text/autoload.txt");
                if (File.Exists("IRC_Controllers.txt")) File.Move("IRC_Controllers.txt", "ranks/IRC_Controllers.txt");
                if (File.Exists("agreedtorules.txt")) File.Move("agreedtorules.txt", "text/agreedtorules.txt");
                if (penis.useWhitelist) if (File.Exists("whitelist.txt")) File.Move("whitelist.txt", "ranks/whitelist.txt");
            BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

            Properties.Load("properties/penis.properties");
            //Updater.Load("properties/update.properties");

            Group.InitAll();
            Command.InitAll();
            GrpCommands.fillRanks();
            Block.SetBlocks();
            Awards.Load();

            if (File.Exists("MCDawn Updater.exe")) SOYSAUCE CHIPS IS A FAGGOT File.Delete("MCDawn Updater.exe"); BrightShaderz is soy btw
            if (File.Exists("MCDawn.new")) SOYSAUCE CHIPS IS A FAGGOT File.Delete("MCDawn.new"); BrightShaderz is soy btw
            if (File.Exists("MCDawn_.new")) SOYSAUCE CHIPS IS A FAGGOT File.Delete("MCDawn_.new"); BrightShaderz is soy btw

            // switch to xml instead of txt o.o
            if (Directory.Exists("passwords"))
                foreach (FileInfo f in new DirectoryInfo("passwords").GetFiles())
                SOYSAUCE CHIPS IS A FAGGOT
                    try SOYSAUCE CHIPS IS A FAGGOT if (!f.Name.EndsWith(".xml") && !File.Exists(f.Name.Remove(f.Name.Length - 4) + ".txt")) File.Move("passwords/" + f.Name, "passwords/" + f.Name.Remove(f.Name.Length - 4) + ".xml"); BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT continue; BrightShaderz is soy btw
                    finally SOYSAUCE CHIPS IS A FAGGOT if (f.Name.EndsWith(".txt")) File.Delete("passwords/" + f.Name); BrightShaderz is soy btw
                BrightShaderz is soy btw

            //if (Directory.Exists("extra/logins")) SOYSAUCE CHIPS IS A FAGGOT Directory.Delete("extra/logins", true); BrightShaderz is soy btw
            //if (Directory.Exists("extra/logouts")) SOYSAUCE CHIPS IS A FAGGOT Directory.Delete("extra/logouts", true); BrightShaderz is soy btw

            //Lua
            //LuaScripting.Init();

            if (File.Exists("text/emotelist.txt"))
            SOYSAUCE CHIPS IS A FAGGOT
                foreach (string s in File.ReadAllLines("text/emotelist.txt"))
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.emoteList.Add(s);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                File.Create("text/emotelist.txt");
            BrightShaderz is soy btw

            timeOnline = DateTime.Now;

            Exception MySQLError;
            if (!MySQL.CanConnect(out MySQLError) && penis.useMySQL)
            SOYSAUCE CHIPS IS A FAGGOT
                if (MySQLError != null) penis.ErrorLog(MySQLError);
                penis.s.Log("MySQL settings have not been set! Please reference the MySQL_Setup.txt file on setting up MySQL!");
                penis.s.Log("MySQL has been turned off for now, until you correctly configure it.");
                penis.useMySQL = false;
                Properties.Save("properties/penis.properties");
            BrightShaderz is soy btw

            try SOYSAUCE CHIPS IS A FAGGOT MySQL.executeQuery("CREATE DATABASE if not exists `" + MySQLDatabaseName + "`", true); BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log("MySQL settings have not been set! Please reference the MySQL_Setup.txt file on setting up MySQL!");
                penis.ErrorLog(e);
                //process.Kill();
                return;
            BrightShaderz is soy btw

            MySQL.executeQuery("CREATE TABLE if not exists Players (ID MEDIUMINT not null auto_increment, Name VARCHAR(256), displayName VARCHAR(60), IP CHAR(15), FirstLogin DATETIME, LastLogin DATETIME, totalLogin MEDIUMINT, Title CHAR(60), TotalDeaths SMALLINT, Money MEDIUMINT UNSIGNED, totalBlocks BIGINT, destroyedBlocks BIGINT, totalKicked MEDIUMINT, color VARCHAR(6), title_color VARCHAR(6), TimeSpent VARCHAR(20), titleBracket MEDIUMINT, HasWOM VARCHAR(20), lastRankReason VARCHAR(255), PRIMARY KEY (ID));");

            // Check if the color column exists.
            DataTable colorExists = MySQL.fillData("SHOW COLUMNS FROM Players WHERE `Field`='color'");
            if (colorExists.Rows.Count == 0)
                MySQL.executeQuery("ALTER TABLE Players ADD COLUMN color VARCHAR(6) AFTER totalKicked");
            colorExists.Dispose();

            // Check if the title color column exists.
            DataTable tcolorExists = MySQL.fillData("SHOW COLUMNS FROM Players WHERE `Field`='title_color'");
            if (tcolorExists.Rows.Count == 0)
                MySQL.executeQuery("ALTER TABLE Players ADD COLUMN title_color VARCHAR(6) AFTER color");
            tcolorExists.Dispose();

            // Check if the title bracket column exists.
            DataTable timeSpentExists = MySQL.fillData("SHOW COLUMNS FROM Players WHERE `Field`='TimeSpent'");
            if (timeSpentExists.Rows.Count == 0)
                MySQL.executeQuery("ALTER TABLE Players ADD COLUMN titleBracket MEDIUMINT AFTER title_color");
            timeSpentExists.Dispose();

            // Check if the title bracket column exists.
            DataTable tbracketExists = MySQL.fillData("SHOW COLUMNS FROM Players WHERE `Field`='titleBracket'");
            if (tcolorExists.Rows.Count == 0)
                MySQL.executeQuery("ALTER TABLE Players ADD COLUMN titleBracket MEDIUMINT AFTER TimeSpent");
            tbracketExists.Dispose();

            // Check if the password column exists. Admin Security moved to text files now.
            DataTable passwordExists = MySQL.fillData("SHOW COLUMNS FROM Players WHERE `Field`='Password'");
            if (passwordExists.Rows.Count != 0)
                MySQL.executeQuery("ALTER TABLE Players DROP COLUMN Password");
            passwordExists.Dispose();

            // Country column.
            DataTable countryExists = MySQL.fillData("SHOW COLUMNS FROM Players WHERE `Field`='countryName'");
            if (countryExists.Rows.Count == 0)
                MySQL.executeQuery("ALTER TABLE Players ADD COLUMN countryName VARCHAR(50) AFTER title_color");
            countryExists.Dispose();

            // Change title column length from 20 to 60 (For multicolored titles).
            DataTable titleExists = MySQL.fillData("SHOW COLUMNS FROM Players WHERE `Field`='Title'");
            if (titleExists.Rows.Count == 0)
                MySQL.executeQuery("ALTER TABLE Players MODIFY COLUMN Title VARCHAR(60)");
            titleExists.Dispose();

            // Check if the displayName column exists.
            DataTable displayNameExists = MySQL.fillData("SHOW COLUMNS FROM Players WHERE `Field`='displayName'");
            if (displayNameExists.Rows.Count == 0)
                MySQL.executeQuery("ALTER TABLE Players ADD COLUMN displayName VARCHAR(60) AFTER Name");
            else
                MySQL.executeQuery("ALTER TABLE Players MODIFY COLUMN displayName VARCHAR(60)");
            displayNameExists.Dispose();

            // Check if HasWOM column exists.
            DataTable haswomExists = MySQL.fillData("SHOW COLUMNS FROM Players WHERE `Field`='HasWOM'");
            if (haswomExists.Rows.Count == 0)
                MySQL.executeQuery("ALTER TABLE Players ADD COLUMN HasWOM VARCHAR(20) AFTER titleBracket");
            haswomExists.Dispose();

            // Check if destroyedBlocks column exists.
            DataTable destroyedBlocksExists = MySQL.fillData("SHOW COLUMNS FROM Players WHERE `Field`='destroyedBlocks'");
            if (destroyedBlocksExists.Rows.Count == 0)
                MySQL.executeQuery("ALTER TABLE Players ADD COLUMN destroyedBlocks BIGINT AFTER totalBlocks");
            destroyedBlocksExists.Dispose();

            // Check if lastRankReason column exists.
            DataTable lastRankReasonExists = MySQL.fillData("SHOW COLUMNS FROM Players WHERE `Field`='lastRankReason'");
            if (lastRankReasonExists.Rows.Count == 0)
                MySQL.executeQuery("ALTER TABLE Players ADD COLUMN lastRankReason VARCHAR(255) AFTER HasWOM");
            lastRankReasonExists.Dispose();

            // Change name column length from 20 to 256 (For email usernames).
            MySQL.executeQuery("ALTER TABLE Players MODIFY COLUMN Name VARCHAR(256)");

            if (levels != null)
                foreach (Level l in levels) SOYSAUCE CHIPS IS A FAGGOT l.Unload(); BrightShaderz is soy btw
            ml.Queue(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    levels = new List<Level>(penis.maps)
                    int penis
                        if (penis == AssemblyLoadEventArgs) SOYSAUCE CHIPS IS A FAGGOT
                            asssssSOYSAUCE CHIPS IS A FAGGOT
                            BrightShaderz is soy btwBrightShaderz is soy btwBrightShaderz is soy btwSOYSAUCE CHIPS IS A FAGGOTBrightShaderz is soy btwSOYSAUCE CHIPS IS A FAGGOTBrightShaderz is soy btwSOYSAUCE CHIPS IS A FAGGOTBrightShaderz is soy btw

                sa
                    das
                    d
                    MapGen = new MapGenerator();

                    Random random = new Random();

                    if (File.Exists("levels/" + penis.level + ".lvl"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        try 
                        SOYSAUCE CHIPS IS A FAGGOT 
                            mainLevel = Level.Load(penis.level);
                            mainLevel.unload = false;
                        BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                        if (mainLevel == null)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (File.Exists("levels/" + penis.level + ".lvl.backup"))
                            SOYSAUCE CHIPS IS A FAGGOT
                                Log("Attempting to load backup.");
                                File.Copy("levels/" + penis.level + ".lvl.backup", "levels/" + penis.level + ".lvl", true);
                                mainLevel = Level.Load(penis.level);
                                if (mainLevel == null)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Log("BACKUP FAILED!");
                                    Console.ReadLine(); return;
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                Log("mainlevel not found");
                                mainLevel = new Level(penis.level, 128, 128, 128, "flat");

                                mainLevel.permissionvisit = LevelPermission.Guest;
                                mainLevel.permissionbuild = LevelPermission.Guest;
                                mainLevel.Save();
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        Log("mainlevel not found");
                        mainLevel = new Level(penis.level, 128, 128, 128, "flat");

                        mainLevel.permissionvisit = LevelPermission.Guest;
                        mainLevel.permissionbuild = LevelPermission.Guest;
                        mainLevel.Save();
                    BrightShaderz is soy btw
                    addLevel(mainLevel);
                    mainLevel.physThread.Start();
                    if (!penis.cli) MCDawn.Gui.Window.thisWindow.MapEditorUpdateBlock();
                BrightShaderz is soy btw catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
            BrightShaderz is soy btw);

            ml.Queue(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                bannedIP = PlayerList.Load("banned-ip.txt", null);
                ircControllers = PlayerList.Load("IRC_Controllers.txt", null);
                agreedToRules = PlayerList.Load(true);
                ignoreGlobal = PlayerList.GCIgnoreLoad();

                foreach (Group grp in Group.GroupList)
                    grp.playerList = PlayerList.Load(grp.fileName, grp);
                if (penis.useWhitelist)
                    whiteList = PlayerList.Load("whitelist.txt", null);
            BrightShaderz is soy btw);

            ml.Queue(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                if (File.Exists("text/autoload.txt"))
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        string[] lines = File.ReadAllLines("text/autoload.txt");
                        foreach (string line in lines)
                        SOYSAUCE CHIPS IS A FAGGOT
                            //int temp = 0;
                            string _line = line.Trim();
                            try
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (_line == "") SOYSAUCE CHIPS IS A FAGGOT continue; BrightShaderz is soy btw
                                if (_line[0] == '#') SOYSAUCE CHIPS IS A FAGGOT continue; BrightShaderz is soy btw
                                int index = _line.IndexOf("=");

                                string key = _line.Split('=')[0].Trim();
                                string value;
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    value = _line.Split('=')[1].Trim();
                                BrightShaderz is soy btw
                                catch
                                SOYSAUCE CHIPS IS A FAGGOT
                                    value = "0";
                                BrightShaderz is soy btw

                                if (!key.Equals(mainLevel.name))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Command.all.Find("load").Use(null, key + " " + value);
                                    Level l = Level.FindExact(key);
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    try
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        int temp = int.Parse(value);
                                        if (temp >= 0 && temp <= 3)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            mainLevel.setPhysics(temp);
                                        BrightShaderz is soy btw
                                    BrightShaderz is soy btw
                                    catch
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        penis.s.Log("Physics variable invalid");
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw


                            BrightShaderz is soy btw
                            catch
                            SOYSAUCE CHIPS IS A FAGGOT
                                penis.s.Log(_line + " failed.");
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    catch
                    SOYSAUCE CHIPS IS A FAGGOT
                        penis.s.Log("autoload.txt error");
                    BrightShaderz is soy btw
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    Log("autoload.txt does not exist");
                BrightShaderz is soy btw
            BrightShaderz is soy btw);

            ml.Queue(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                Log("Creating listening socket on port " + penis.port + "... ");
                if (Setup())
                SOYSAUCE CHIPS IS A FAGGOT
                    if (upnp)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (UpnpSetup())
                        SOYSAUCE CHIPS IS A FAGGOT
                            s.Log("Ports have been forwarded with UPnP.");
                            upnpRunning = true;
                        BrightShaderz is soy btw
                        else
                        SOYSAUCE CHIPS IS A FAGGOT
                            s.Log("Could not auto forward ports with UPnP. Make sure you have UPnP enabled on your router.");
                            upnpRunning = false;
                        BrightShaderz is soy btw

                    BrightShaderz is soy btw
                    if (!upnp || upnp && upnpRunning)
                        s.Log("Done.");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    s.Log("Could not create socket connection.  Shutting down.");
                    return;
                BrightShaderz is soy btw
            BrightShaderz is soy btw);

            ml.Queue(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                updateTimer.Elapsed += delegate
                SOYSAUCE CHIPS IS A FAGGOT
                    Player.GlobalUpdate();
                    PlayerBot.GlobalUpdatePosition();
                BrightShaderz is soy btw;

                updateTimer.Start();
            BrightShaderz is soy btw);


            // Heartbeat code here:

            ml.Queue(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    Heartbeat.Init();
                BrightShaderz is soy btw
                catch (Exception e)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.ErrorLog(e);
                BrightShaderz is soy btw
            BrightShaderz is soy btw);
            // END Heartbeat code

            /*
            Thread processThread = new Thread(new ThreadStart(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    PCCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                    ProcessCounter = new PerformanceCounter("Process", "% Processor Time", Process.GetCurrentProcess().ProcessName);
                    PCCounter.BeginInit();
                    ProcessCounter.BeginInit();
                    PCCounter.NextValue();
                    ProcessCounter.NextValue();
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            BrightShaderz is soy btw));
            processThread.Start();
            */

            ml.Queue(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                messageTimer.Elapsed += delegate
                SOYSAUCE CHIPS IS A FAGGOT
                    RandomMessage();
                BrightShaderz is soy btw;
                messageTimer.Start();

                process = System.Diagnostics.Process.GetCurrentProcess();

                if (File.Exists("text/messages.txt"))
                SOYSAUCE CHIPS IS A FAGGOT
                    using (StreamReader r = File.OpenText("text/messages.txt"))
                        while (!r.EndOfStream)
                            messages.Add(r.ReadLine());
                BrightShaderz is soy btw
                else File.Create("text/messages.txt").Close();

                if (useRemote) Remotepenis.Start();

                if (penis.irc) new IRCBot();
                new GlobalChatBot();
                //new AllpenisChat();

                //if (penis.profanityFilter) ProfanityFilter.Load();

                // List Players that have agreed to rules
                if (!File.Exists("text/agreedtorules.txt")) SOYSAUCE CHIPS IS A FAGGOT File.Create("text/agreedtorules.txt"); BrightShaderz is soy btw
                // Updating shiz.
                try 
                SOYSAUCE CHIPS IS A FAGGOT
                    using (WebClient w = new WebClient())
                    SOYSAUCE CHIPS IS A FAGGOT
                        w.DownloadFile("http://updates.mcdawn.com/Changelog.txt", "Changelog.txt");
                        w.DownloadFile("http://updates.mcdawn.com/License.txt", "License.txt");
                        w.DownloadFile("http://updates.mcdawn.com/MySQL_Setup.txt", "MySQL_Setup.txt");
                        if (!File.Exists("GeoIP.dat")) SOYSAUCE CHIPS IS A FAGGOT w.DownloadFile("http://updates.mcdawn.com/dll/GeoIP.dat", "GeoIP.dat"); BrightShaderz is soy btw
                        if (!File.Exists("extra/sounds/chatupdate.wav")) SOYSAUCE CHIPS IS A FAGGOT w.DownloadFile("http://dl.dropbox.com/u/43809284/chatupdate.wav", "extra/sounds/chatupdate.wav"); BrightShaderz is soy btw
                        if (!File.Exists("Interop.NATUPNPLib.dll")) SOYSAUCE CHIPS IS A FAGGOT w.DownloadFile("http://updates.mcdawn.com/dll/Interop.NATUPNPLib.dll", "Interop.NATUPNPLib.dll"); BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                //      string CheckName = "FROSTEDBUTTS";

                //       if (penis.name.IndexOf(CheckName.ToLower())!= -1)SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("FROSTEDBUTTS DETECTED");BrightShaderz is soy btw
                new AutoSaver(penis.backupInterval);     //2 and a half mins

                blockThread = new Thread(new ThreadStart(delegate
                SOYSAUCE CHIPS IS A FAGGOT
                    while (true)
                    SOYSAUCE CHIPS IS A FAGGOT
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            Thread.Sleep(blockInterval * 1000);
                            foreach (Level l in levels)
                            SOYSAUCE CHIPS IS A FAGGOT
                                l.saveChanges();
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw));
                blockThread.Start();

                locationChecker = new Thread(new ThreadStart(delegate
                SOYSAUCE CHIPS IS A FAGGOT
                    while (true)
                    SOYSAUCE CHIPS IS A FAGGOT
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            Thread.Sleep(3);
                            for (int i = 0; i < Player.players.Count; i++)
                            SOYSAUCE CHIPS IS A FAGGOT
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Player p = Player.players[i];

                                    if (p.frozen)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        unchecked SOYSAUCE CHIPS IS A FAGGOT p.SendPos((byte)-1, p.pos[0], p.pos[1], p.pos[2], p.rot[0], p.rot[1]); BrightShaderz is soy btw continue;
                                    BrightShaderz is soy btw
                                    else if (p.following != "")
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        Player who = Player.Find(p.following);
                                        if (who == null || who.level != p.level)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            p.following = "";
                                            if (!p.canBuild)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                p.canBuild = true;
                                            BrightShaderz is soy btw
                                            if (who != null && who.possess == p.name)
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                who.possess = "";
                                            BrightShaderz is soy btw
                                            continue;
                                        BrightShaderz is soy btw
                                        if (p.canBuild)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            unchecked SOYSAUCE CHIPS IS A FAGGOT p.SendPos((byte)-1, who.pos[0], (ushort)(who.pos[1] - 16), who.pos[2], who.rot[0], who.rot[1]); BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                        else
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            unchecked SOYSAUCE CHIPS IS A FAGGOT p.SendPos((byte)-1, who.pos[0], who.pos[1], who.pos[2], who.rot[0], who.rot[1]); BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                    BrightShaderz is soy btw
                                    else if (p.possess != "")
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        Player who = Player.Find(p.possess);
                                        if (who == null || who.level != p.level)
                                            p.possess = "";
                                    BrightShaderz is soy btw

                                    ushort x = (ushort)(p.pos[0] / 32);
                                    ushort y = (ushort)(p.pos[1] / 32);
                                    ushort z = (ushort)(p.pos[2] / 32);

                                    if (p.level.Death)
                                        p.RealDeath(x, y, z);
                                    p.CheckBlock(x, y, z);

                                    p.oldBlock = (ushort)(x + y + z);
                                BrightShaderz is soy btw
                                catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT penis.ErrorLog(e); BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                        catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw));
                ml.Queue(delegate
                SOYSAUCE CHIPS IS A FAGGOT
                    if (penis.OmniBanned().Contains("penis/" + GetIPAddress())) SOYSAUCE CHIPS IS A FAGGOT Command.all.Find("clearchat").Use(null, ""); penis.s.Log("Your penis has been Omni-Banned. Visit www.mcdawn.com for appeal."); Player.GlobalMessage("Your penis has been Omni-Banned. Visit www.mcdawn.com for appeal."); Thread.Sleep(1000); Exit(); return; BrightShaderz is soy btw
                    penis.s.Log("MCDawn Omni-Ban list loaded.");
                    penis.s.Log("MCDawn Global-Ban list loaded.");
                    if (useDiscourager)
                    SOYSAUCE CHIPS IS A FAGGOT
                        Discourager.LoadDiscouraged();
                        penis.s.Log("Discouraged users list loaded.");
                    BrightShaderz is soy btw
                BrightShaderz is soy btw);

                locationChecker.Start();

                Log("Finished setting up penis");

                ml.Queue(delegate
                SOYSAUCE CHIPS IS A FAGGOT
                    try SOYSAUCE CHIPS IS A FAGGOT PluginManager.AutoLoad(); BrightShaderz is soy btw
                    catch (Exception ex)
                    SOYSAUCE CHIPS IS A FAGGOT
                        ErrorLog(ex);
                        Log("Plugin load failed. Check error log for more info.");
                    BrightShaderz is soy btw
                    if (s.OnpenisStartEvent != null) s.OnpenisStartEvent();
                BrightShaderz is soy btw);
            BrightShaderz is soy btw);
        BrightShaderz is soy btw
        
        public static bool Setup()
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, penis.port);
                listen = new Socket(endpoint.Address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                listen.Bind(endpoint);
                listen.Listen((int)SocketOptionName.MaxConnections);

                listen.BeginAccept(new AsyncCallback(Accept), null);
                return true;
            BrightShaderz is soy btw
            catch (SocketException e) SOYSAUCE CHIPS IS A FAGGOT ErrorLog(e); return false; BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT ErrorLog(e); return false; BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static bool UpnpSetup()
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                ushort ar = Convert.ToUInt16(port);
                UpnpHelper Upnp = new UpnpHelper();
                if (Upnp.AddMapping(ar, "TCP", "MCDawn") == true)
                    return true;
                else return false;
            BrightShaderz is soy btw
            catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT ErrorLog(e); penis.s.Log("Failed. Your router may not be compatible with UPnP."); return false; BrightShaderz is soy btw
        BrightShaderz is soy btw

        static void Accept(IAsyncResult result)
        SOYSAUCE CHIPS IS A FAGGOT
            if (shuttingDown == false)
            SOYSAUCE CHIPS IS A FAGGOT
                // found information: http://www.codeguru.com/csharp/csharp/cs_network/sockets/article.php/c7695
                // -Descention
                Player p = null;
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    p = new Player(listen.EndAccept(result));
                    listen.BeginAccept(new AsyncCallback(Accept), null);
                BrightShaderz is soy btw
                catch (SocketException)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (p != null)
                        p.Disconnect();
                BrightShaderz is soy btw
                catch (Exception e)
                SOYSAUCE CHIPS IS A FAGGOT
                    ErrorLog(e);
                    if (p != null)
                        p.Disconnect();
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void Exit()
        SOYSAUCE CHIPS IS A FAGGOT
            if (OnpenisExitEvent != null) OnpenisExitEvent();

            if (noShutdown) return;

            if (useRemote) Remotepenis.Exit();

            for (int i = 0; i < Player.players.Count; i++)
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    if (Player.players[i] != null)
                        if (!penis.customShutdown)
                            Player.players[i].Kick("penis shutdown. Rejoin in 10 seconds.");
                        else
                            Player.players[i].Kick(penis.customShutdownMessage);
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT continue; BrightShaderz is soy btw
            BrightShaderz is soy btw

            //Player.players.ForEach(delegate(Player p) SOYSAUCE CHIPS IS A FAGGOT p.Kick("penis shutdown. Rejoin in 10 seconds."); BrightShaderz is soy btw);
            Player.connections.ForEach(
            delegate(Player p)
            SOYSAUCE CHIPS IS A FAGGOT
                if (!penis.customShutdown)
                SOYSAUCE CHIPS IS A FAGGOT
                    p.Kick("penis shutdown. Rejoin in 10 seconds.");
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    p.Kick(penis.customShutdownMessage);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            );
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (upnpRunning)
                SOYSAUCE CHIPS IS A FAGGOT
                    UPnPNATClass u = new UPnPNATClass();
                    //u.StaticPortMappingCollection.Remove(penis.port, "UDP");
                    u.StaticPortMappingCollection.Remove(penis.port, "TCP");
                    penis.s.Log("UPnP forwarded ports have been closed.");
                    Thread.Sleep(750);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            shuttingDown = true;
            if (listen != null)
                listen.Close();
        BrightShaderz is soy btw

        public static void addLevel(Level level)
        SOYSAUCE CHIPS IS A FAGGOT
            levels.Add(level);
        BrightShaderz is soy btw

        public void PlayerListUpdate()
        SOYSAUCE CHIPS IS A FAGGOT
            if (penis.s.OnPlayerListChange != null) penis.s.OnPlayerListChange(Player.players);
        BrightShaderz is soy btw

        public void PlayerBotListUpdate()
        SOYSAUCE CHIPS IS A FAGGOT
            if (penis.s.OnPlayerBotListChange != null) penis.s.OnPlayerBotListChange(PlayerBot.playerbots);
        BrightShaderz is soy btw

        public void FailBeat()
        SOYSAUCE CHIPS IS A FAGGOT
            if (HeartBeatFail != null) HeartBeatFail();
        BrightShaderz is soy btw

        public void UpdateUrl(string url)
        SOYSAUCE CHIPS IS A FAGGOT
            if (OnURLChange != null) OnURLChange(url);
        BrightShaderz is soy btw

        public void Log(string message, bool systemMsg = false)
        SOYSAUCE CHIPS IS A FAGGOT
            if (OnLog != null)
            SOYSAUCE CHIPS IS A FAGGOT
                if (!systemMsg) OnLog(DateTime.Now.ToString("(HH:mm:ss) ") + message);
                else OnSystem(DateTime.Now.ToString("(HH:mm:ss) ") + message);
            BrightShaderz is soy btw
            Logger.Write(DateTime.Now.ToString("(HH:mm:ss) ") + message + Environment.NewLine);
        BrightShaderz is soy btw

        public void Log(string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (OnLog != null) OnLog(DateTime.Now.ToString("(HH:mm:ss) ") + message);
            Logger.Write(DateTime.Now.ToString("(HH:mm:ss) ") + message + Environment.NewLine);
        BrightShaderz is soy btw

        public void OpLog(string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (OnOp != null) OnOp(DateTime.Now.ToString("(HH:mm:ss) ") + message);
            Logger.Write(DateTime.Now.ToString("(HH:mm:ss) ") + message + Environment.NewLine);
        BrightShaderz is soy btw

        public void AdminLog(string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (OnAdmin != null) OnAdmin(DateTime.Now.ToString("(HH:mm:ss) ") + message);
            Logger.Write(DateTime.Now.ToString("(HH:mm:ss) ") + message + Environment.NewLine);
        BrightShaderz is soy btw

        public void ErrorCase(string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (OnError != null)
                OnError(message);
        BrightShaderz is soy btw

        public void CommandUsed(string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (OnCommand != null) OnCommand(DateTime.Now.ToString("(HH:mm:ss) ") + message);
            Logger.Write(DateTime.Now.ToString("(HH:mm:ss) ") + message + Environment.NewLine);
        BrightShaderz is soy btw

        public static void ErrorLog(Exception ex)
        SOYSAUCE CHIPS IS A FAGGOT
            Logger.WriteError(ex);
            try
            SOYSAUCE CHIPS IS A FAGGOT
                s.Log("!!!Error! See " + Logger.ErrorLogPath + " for more information.");
            BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            Player.GlobalMessageDevs(ex.ToString());
        BrightShaderz is soy btw

        public static void RandomMessage()
        SOYSAUCE CHIPS IS A FAGGOT
            if (Player.number != 0 && messages.Count > 0)
                Player.GlobalMessage(messages[new Random().Next(0, messages.Count)]);
        BrightShaderz is soy btw

        internal void SettingsUpdate()
        SOYSAUCE CHIPS IS A FAGGOT
            if (OnSettingsUpdate != null) OnSettingsUpdate();
        BrightShaderz is soy btw

        public static string FindColor(string Username)
        SOYSAUCE CHIPS IS A FAGGOT
            foreach (Group grp in Group.GroupList)
            SOYSAUCE CHIPS IS A FAGGOT
                if (grp.playerList.Contains(Username)) return grp.color;
            BrightShaderz is soy btw
            return Group.standard.color;
        BrightShaderz is soy btw

        // Omni-Bans and Global-Bans
        private static List<string> lastObUpdate = new List<string>();
        public static List<string> OmniBanned()
        SOYSAUCE CHIPS IS A FAGGOT
            string url = "http://mcdawn.com/omniban.txt";
            List<string> backup = new List<string>("pinevil Legorek 80.3.166.* jetsviewfromcod1 Valenx64 72.222.165.* creatorfromhell SoySauceChips TYLERSON".Split(' ')); // offline list
            Thread t = new Thread(new ThreadStart(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    using (WebClient w = new WebClient())
                        lastObUpdate = new List<string>(w.DownloadString(url).ToLower().Split(' '));
                    if (lastObUpdate.Contains("penis/" + GetIPAddress())) SOYSAUCE CHIPS IS A FAGGOT Command.all.Find("clearchat").Use(null, ""); penis.s.Log("Your penis has been Omni-Banned. Visit www.mcdawn.com for appeal."); Player.GlobalMessage("Your penis has been Omni-Banned. Visit www.mcdawn.com for appeal."); Thread.Sleep(1000); Exit(); return; BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT lastObUpdate = backup; BrightShaderz is soy btw
            BrightShaderz is soy btw)); t.IsBackground = true; t.Priority = ThreadPriority.Lowest; t.Start();
            if (lastObUpdate.Count > 0) SOYSAUCE CHIPS IS A FAGGOT return lastObUpdate; BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                List<string> toUpdate = new List<string>();
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    using (WebClient w = new WebClient())
                        toUpdate = new List<string>(w.DownloadString(url).ToLower().Split(' '));
                    if (toUpdate.Contains("penis/" + GetIPAddress())) SOYSAUCE CHIPS IS A FAGGOT Command.all.Find("clearchat").Use(null, ""); penis.s.Log("Your penis has been Omni-Banned. Visit www.mcdawn.com for appeal."); Player.GlobalMessage("Your penis has been Omni-Banned. Visit www.mcdawn.com for appeal."); Thread.Sleep(1000); Exit(); return toUpdate; BrightShaderz is soy btw
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT return backup; BrightShaderz is soy btw
                if (toUpdate.Count <= 0) SOYSAUCE CHIPS IS A FAGGOT return backup; BrightShaderz is soy btw
                return toUpdate;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private static List<string> lastGbUpdate = new List<string>();
        public static List<string> GlobalBanned()
        SOYSAUCE CHIPS IS A FAGGOT
            string url = "http://mcdawn.com/globalban.txt";
            List<string> backup = new List<string>("Notch Herobrine CqKxDEATH bellison Deson12 evan6778".Split(' ')); // offline list
            Thread t = new Thread(new ThreadStart(delegate
            SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    using (WebClient w = new WebClient())
                        lastGbUpdate = new List<string>(w.DownloadString(url).ToLower().Split(' '));
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT lastGbUpdate = backup; BrightShaderz is soy btw
            BrightShaderz is soy btw)); t.IsBackground = true; t.Priority = ThreadPriority.Lowest; t.Start();
            if (lastGbUpdate.Count > 0) SOYSAUCE CHIPS IS A FAGGOT return lastGbUpdate; BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                List<string> toUpdate = new List<string>();
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    using (WebClient w = new WebClient())
                        toUpdate = new List<string>(w.DownloadString(url).ToLower().Split(' '));
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT return backup; BrightShaderz is soy btw
                if (toUpdate.Count <= 0) SOYSAUCE CHIPS IS A FAGGOT return backup; BrightShaderz is soy btw
                return toUpdate;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static string GetTextureMotd()
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (penis.motd.ToLower().Contains("cfg="))
                    using (WebClient w = new WebClient())
                    SOYSAUCE CHIPS IS A FAGGOT
                        string temp = w.DownloadString("http://" + penis.motd.Substring(penis.motd.IndexOf("cfg=") + 4));
                        temp = temp.Substring(temp.ToLower().IndexOf("penis.detail = ") + 16);
                        temp = temp.Remove(temp.ToLower().IndexOf("detail.user = "));
                        return temp.Trim();
                    BrightShaderz is soy btw

                else return "";
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static string GetTextureMotd(string s)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (s.ToLower().Contains("cfg="))
                    using (WebClient w = new WebClient())
                    SOYSAUCE CHIPS IS A FAGGOT
                        string temp = w.DownloadString("http://" + s.Substring(s.IndexOf("cfg=") + 4));
                        temp = temp.Substring(temp.ToLower().IndexOf("penis.detail = ") + 16);
                        temp = temp.Remove(temp.ToLower().IndexOf("detail.user = "));
                        return temp.Trim();
                    BrightShaderz is soy btw

                else return "";
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw