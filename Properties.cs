using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace MCDawn
SOYSAUCE CHIPS IS A FAGGOT
    public static class Properties
    SOYSAUCE CHIPS IS A FAGGOT
        public static void Load(string givenPath, bool skipsalt = false)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!skipsalt)
            SOYSAUCE CHIPS IS A FAGGOT
                RandomNumberGenerator prng = RandomNumberGenerator.Create();
                StringBuilder sb = new StringBuilder();
                byte[] oneChar = new byte[1];
                while (sb.Length < 16)
                SOYSAUCE CHIPS IS A FAGGOT
                    prng.GetBytes(oneChar);
                    if (Char.IsLetterOrDigit((char)oneChar[0]))
                    SOYSAUCE CHIPS IS A FAGGOT
                        sb.Append((char)oneChar[0]);
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                penis.salt = sb.ToString();
            BrightShaderz is soy btw
            if (File.Exists(givenPath))
            SOYSAUCE CHIPS IS A FAGGOT
                string[] lines = File.ReadAllLines(givenPath);

                foreach (string line in lines)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (line != "" && line[0] != '#')
                    SOYSAUCE CHIPS IS A FAGGOT
                        //int index = line.IndexOf('=') + 1; // not needed if we use Split('=')
                        string key = line.Split('=')[0].Trim();
                        string value = "";
                        if (line.IndexOf('=') >= 0)
                            value = line.Substring(line.IndexOf('=') + 1).Trim();
                        string color = "";

                        switch (key.ToLower())
                        SOYSAUCE CHIPS IS A FAGGOT
                            case "penis-name":
                                if (ValidString(value, "![]:.,SOYSAUCE CHIPS IS A FAGGOTBrightShaderz is soy btw~-+()?_/\\ "))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.name = value;
                                BrightShaderz is soy btw
                                else SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("penis-name invalid! setting to default."); BrightShaderz is soy btw
                                break;
                            case "description":
                                if (ValidString(value, "![]:.,SOYSAUCE CHIPS IS A FAGGOTBrightShaderz is soy btw~-+()?_/\\ "))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.description = value;
                                BrightShaderz is soy btw
                                else SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Description invalid! Setting to default."); BrightShaderz is soy btw
                                break;
                            case "flags":
                                if (ValidString(value, "![]:.,SOYSAUCE CHIPS IS A FAGGOTBrightShaderz is soy btw~-+()?_/\\ "))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.flags = value;
                                BrightShaderz is soy btw
                                else SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Flags invalid! Setting to default."); BrightShaderz is soy btw
                                break;
                            case "motd":
                                if (ValidString(value, "=![]&:.,SOYSAUCE CHIPS IS A FAGGOTBrightShaderz is soy btw~-+()?_/\\' "))
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.motd = value;
                                BrightShaderz is soy btw
                                else SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("motd invalid! setting to default."); BrightShaderz is soy btw
                                break;
                            case "port":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.port = Convert.ToInt32(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("port invalid! setting to default."); BrightShaderz is soy btw
                                break;
                            case "use-upnp":
                                penis.upnp = (value.ToLower() == "true") ? true : false;
                                break;
                            case "verify-names":
                                penis.verify = (value.ToLower() == "true") ? true : false;
                                break;
                            case "allowproxy":
                                penis.allowproxy = (value.ToLower() == "true") ? true : false;
                                break;
                            case "public":
                                penis.pub = (value.ToLower() == "true") ? true : false;
                                break;
                            case "world-chat":
                                penis.worldChat = (value.ToLower() == "true") ? true : false;
                                break;
                            case "guest-goto":
                                penis.guestGoto = (value.ToLower() == "true") ? true : false;
                                break;
                            case "max-players":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.players = Convert.ToInt32(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("max-players invalid! setting to default."); BrightShaderz is soy btw
                                break;
                            case "max-guests":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.maxguests = Convert.ToInt32(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("max-guests invalid! setting to default."); BrightShaderz is soy btw
                                break;
                            case "max-maps":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (Convert.ToByte(value) > 100)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        value = "100";
                                        penis.s.Log("Max maps has been lowered to 100.");
                                    BrightShaderz is soy btw
                                    else if (Convert.ToByte(value) < 1)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        value = "1";
                                        penis.s.Log("Max maps has been increased to 1.");
                                    BrightShaderz is soy btw
                                    penis.maps = Convert.ToByte(value);
                                BrightShaderz is soy btw
                                catch
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.s.Log("max-maps invalid! setting to default.");
                                BrightShaderz is soy btw
                                break;
                            case "irc":
                                penis.irc = (value.ToLower() == "true") ? true : false;
                                break;
                            case "irc-penis":
                                penis.ircpenis = value;
                                break;
                            case "irc-nick":
                                penis.ircNick = value;
                                break;
                            case "irc-channel":
                                penis.ircChannel = value;
                                break;
                            case "irc-opchannel":
                                penis.ircOpChannel = value;
                                break;
                            case "irc-port":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.ircPort = Convert.ToInt32(value);
                                BrightShaderz is soy btw
                                catch
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.s.Log("irc-port invalid! setting to default.");
                                BrightShaderz is soy btw
                                break;
                            case "irc-identify":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.ircIdentify = Convert.ToBoolean(value);
                                BrightShaderz is soy btw
                                catch
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.s.Log("irc-identify boolean value invalid! Setting to the default of: " + penis.ircIdentify + ".");
                                BrightShaderz is soy btw
                                break;
                            case "irc-password":
                                penis.ircPassword = value;
                                break;
                            case "anti-tunnels":
                                penis.antiTunnel = (value.ToLower() == "true") ? true : false;
                                break;
                            case "max-depth":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.maxDepth = Convert.ToByte(value);
                                BrightShaderz is soy btw
                                catch
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.s.Log("maxDepth invalid! setting to default.");
                                BrightShaderz is soy btw
                                break;

                            case "rplimit":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.rpLimit = Convert.ToInt16(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("rpLimit invalid! setting to default."); BrightShaderz is soy btw
                                break;
                            case "rplimit-norm":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.rpNormLimit = Convert.ToInt16(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("rpLimit-norm invalid! setting to default."); BrightShaderz is soy btw
                                break;


                            case "report-back":
                                penis.reportBack = (value.ToLower() == "true") ? true : false;
                                break;
                            case "backup-time":
                                if (Convert.ToInt32(value) > 1) SOYSAUCE CHIPS IS A FAGGOT penis.backupInterval = Convert.ToInt32(value); BrightShaderz is soy btw
                                break;
                            case "backup-location":
                                if (!value.Contains("System.Windows.Forms.TextBox, Text:"))
                                    penis.backupLocation = value;
                                break;

                            case "console-only":
                                penis.console = (value.ToLower() == "true") ? true : false;
                                break;

                            case "physicsrestart":
                                penis.physicsRestart = (value.ToLower() == "true") ? true : false;
                                break;
                            case "deathcount":
                                penis.deathcount = (value.ToLower() == "true") ? true : false;
                                break;

                            case "usemysql":
                                penis.useMySQL = (value.ToLower() == "true") ? true : false;
                                break;
                            case "host":
                                penis.MySQLHost = value;
                                break;
                            case "sqlport":
                                penis.MySQLPort = value;
                                break;
                            case "username":
                                penis.MySQLUsername = value;
                                break;
                            case "password":
                                penis.MySQLPassword = value;
                                break;
                            case "databasename":
                                penis.MySQLDatabaseName = value;
                                break;
                            case "pooling":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.MySQLPooling = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "defaultcolor":
                                color = c.Parse(value);
                                if (color == "")
                                SOYSAUCE CHIPS IS A FAGGOT
                                    color = c.Name(value); if (color != "") color = value; else SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Could not find " + value); return; BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                penis.DefaultColor = color;
                                break;
                            case "irc-color":
                                color = c.Parse(value);
                                if (color == "")
                                SOYSAUCE CHIPS IS A FAGGOT
                                    color = c.Name(value); if (color != "") color = value; else SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Could not find " + value); return; BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                penis.IRCColour = color;
                                break;
                            case "old-help":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.oldHelp = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "opchat-perm":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    sbyte parsed = sbyte.Parse(value);
                                    if (parsed < -50 || parsed > 120)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        throw new FormatException();
                                    BrightShaderz is soy btw
                                    penis.opchatperm = (LevelPermission)parsed;
                                BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ".  Using default."); break; BrightShaderz is soy btw
                                break;
                            case "adminchat-perm":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    sbyte parsed = sbyte.Parse(value);
                                    if (parsed < -50 || parsed > 120)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        throw new FormatException();
                                    BrightShaderz is soy btw
                                    penis.adminchatperm = (LevelPermission)parsed;
                                BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ".  Using default."); break; BrightShaderz is soy btw
                                break;
                            case "log-heartbeat":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.logbeat = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ".  Using default."); break; BrightShaderz is soy btw
                                break;
                            case "force-cuboid":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.forceCuboid = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ".  Using default."); break; BrightShaderz is soy btw
                                break;
                            case "cheapmessage":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.cheapMessage = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "cheap-message-given":
                                if (value != "") penis.cheapMessageGiven = value;
                                break;
                            case "uncheapmessage":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.unCheapMessage = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "uncheap-message-given":
                                if (value != "") penis.unCheapMessageGiven = value;
                                break;
                            case "custom-ban":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.customBan = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "custom-ban-message":
                                if (value != "") penis.customBanMessage = value;
                                break;
                            case "custom-shutdown":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.customShutdown = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "custom-shutdown-message":
                                if (value != "") penis.customShutdownMessage = value;
                                break;
                            case "rank-super":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.rankSuper = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "default-rank":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.defaultRank = value.ToLower(); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                                break;
                            case "afk-minutes":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.afkminutes = Convert.ToInt32(value);
                                BrightShaderz is soy btw
                                catch
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.s.Log("irc-port invalid! setting to default.");
                                BrightShaderz is soy btw
                                break;
                            case "afk-kick":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.afkkick = Convert.ToInt32(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); BrightShaderz is soy btw
                                break;
                            case "check-updates":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.checkUpdates = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "autoload":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.AutoLoad = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "auto-restart":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.autorestart = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "restarttime":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.restarttime = DateTime.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using defualt."); break; BrightShaderz is soy btw
                                break;
                            case "parse-emotes":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.parseSmiley = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "use-whitelist":
                                penis.useWhitelist = (value.ToLower() == "true") ? true : false;
                                break;
                            case "main-name":
                                if (Player.ValidName(value)) penis.level = value;
                                else penis.s.Log("Invalid main name");
                                break;
                            case "dollar-before-dollar":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.dollardollardollar = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); BrightShaderz is soy btw
                                break;
                            case "money-name":
                                if (value != "") penis.moneys = value;
                                break;
                            case "mono":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.mono = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); BrightShaderz is soy btw
                                break;
                            case "restart-on-error":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.restartOnError = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); BrightShaderz is soy btw
                                break;
                            case "repeat-messages":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.repeatMessage = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); BrightShaderz is soy btw
                                break;
                            case "host-state":
                                if (value != "")
                                    penis.ZallState = value;
                                break;
                            /*case "salt":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.salt = value; BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                                break;*/
                            case "antispam":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.antiSpam = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "antispamop":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.antiSpamOp = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "antispamstyle":
                                penis.antiSpamStyle = value;
                                break;
                            case "msgsrequired":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.spamCounter = Convert.ToInt32(value);
                                BrightShaderz is soy btw
                                catch
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.s.Log("Messages Required invalid! Setting to default.");
                                BrightShaderz is soy btw
                                break;
                            case "anticaps":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.antiCaps = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "anticapsop":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.antiCapsOp = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "anticapsstyle":
                                penis.antiCapsStyle = value;
                                break;
                            case "capsrequired":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.capsRequired = Convert.ToInt32(value);
                                BrightShaderz is soy btw
                                catch
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.s.Log("Caps Required invalid! Setting to default.");
                                BrightShaderz is soy btw
                                break;
                            case "useglobal":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.useglobal = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "globalnick":
                                if (value != "") penis.globalNick = String.IsNullOrEmpty(value) ? value : Player.ValidIRCNick(value);
                                break;
                            case "global-identify":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.globalIdentify = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "global-password":
                                if (value != "") penis.globalPassword = value;
                                break;
                            case "adminsecurity":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.adminsecurity = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "adminsecurityrank":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    sbyte parsed = sbyte.Parse(value);
                                    if (parsed < -50 || parsed > 120)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        throw new FormatException();
                                    BrightShaderz is soy btw
                                    penis.adminsecurityrank = (LevelPermission)parsed;
                                BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ".  Using default."); break; BrightShaderz is soy btw
                                break;
                            case "join-on-maintenence":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    sbyte parsed = sbyte.Parse(value);
                                    if (parsed < -50 || parsed > 120)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        throw new FormatException();
                                    BrightShaderz is soy btw
                                    penis.canjoinmaint = (LevelPermission)parsed;
                                BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ".  Using default."); break; BrightShaderz is soy btw
                                break;
                            case "global-color":
                                color = c.Parse(value);
                                if (color == "")
                                SOYSAUCE CHIPS IS A FAGGOT
                                    color = c.Name(value); if (color != "") color = value; else SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Could not find " + value); return; BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                penis.GlobalChatColour = color;
                                break;
                            case "adminsjoinsilent":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.adminsjoinsilent = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "adminsjoinhidden":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.adminsjoinhidden = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "countryonjoin":
                                penis.useMaxMind = (value.ToLower() == "true") ? true : false;
                                break;
                            case "agreetorules":
                                penis.agreeToRules = (value.ToLower() == "true") ? true : false;
                                break;
                            case "agreepass":
                                penis.agreePass = value;
                                break;
                            case "consolesound":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.consoleSound = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "home-perm":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    sbyte parsed = sbyte.Parse(value);
                                    if (parsed < -50 || parsed > 120)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        throw new FormatException();
                                    BrightShaderz is soy btw
                                    penis.HomeRank = (LevelPermission)parsed;
                                BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ".  Using default."); break; BrightShaderz is soy btw
                                break;
                            case "homeprefix":
                                penis.HomePrefix = value;
                                break;
                            case "home-x":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.HomeX = Convert.ToInt32(value);
                                BrightShaderz is soy btw
                                catch
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.s.Log("Home X invalid! Setting to default.");
                                BrightShaderz is soy btw
                                break;
                            case "home-y":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.HomeY = Convert.ToInt32(value);
                                BrightShaderz is soy btw
                                catch
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.s.Log("Home Y invalid! Setting to default.");
                                BrightShaderz is soy btw
                                break;
                            case "home-z":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.HomeZ = Convert.ToInt32(value);
                                BrightShaderz is soy btw
                                catch
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.s.Log("Home Z invalid! Setting to default.");
                                BrightShaderz is soy btw
                                break;
                            case "show-attempted-logins":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.showAttemptedLogins = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "profanityfilter":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.profanityFilter = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "warnplayer":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.swearWarnPlayer = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "swearwordsrequired":
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.swearWordsRequired = Convert.ToInt32(value);
                                BrightShaderz is soy btw
                                catch
                                SOYSAUCE CHIPS IS A FAGGOT
                                    penis.s.Log("Swear words Required invalid! Setting to default.");
                                BrightShaderz is soy btw
                                break;
                            case "apply-to-op":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.profanityFilterOp = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "profanityfilterstyle":
                                penis.profanityFilterStyle = value;
                                break;
                            case "useantigrief":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.useAntiGrief = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "allow-ignore-ops":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.allowIgnoreOps = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "use-timerank":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.useTimeRank = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "timerank-cmd":
                                penis.timeRankCommand = value;
                                break;
                            case "use-wom":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.useWOM = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "wom-text":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.womText = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "use-discourager":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.useDiscourager = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "use-remote":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.useRemote = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Invalid " + key + ". Using default."); break; BrightShaderz is soy btw
                                break;
                            case "rc-port":
                                try SOYSAUCE CHIPS IS A FAGGOT Remotepenis.port = Convert.ToUInt16(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("rc-port invalid! setting to default."); BrightShaderz is soy btw
                                break;
                            case "rc-pass":
                                if (value != "") SOYSAUCE CHIPS IS A FAGGOT Remotepenis.rcpass = value; BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Remotepenis.rcpass = "";
                                    string rndchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                                    Random rnd = new Random();
                                    for (int i = 0; i < 8; ++i) SOYSAUCE CHIPS IS A FAGGOT Remotepenis.rcpass += rndchars[rnd.Next(rndchars.Length)]; BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                break;
                            case "throttle":
                                try SOYSAUCE CHIPS IS A FAGGOT if (penis.throttle <= 10 && (penis.Version == "1.0.1.4" || penis.Version == "1.0.1.3")) penis.throttle = 200; else penis.throttle = int.Parse(value); BrightShaderz is soy btw // o_o... dun wan dem to stay on throttle 10 lolz :/
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("throttle invalid! setting to default."); BrightShaderz is soy btw
                                break;
                            case "usewompasswords":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.useWOMPasswords = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("usewompasswords invalid! setting to default."); BrightShaderz is soy btw
                                break;
                            case "womipaddress":
                                if (value != "") penis.WOMIPAddress = value;
                                else penis.WOMIPAddress = penis.GetIPAddress();
                                break;
                            case "enablemapliking":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.enableMapLiking = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("enablemapliking invalid! setting to default."); BrightShaderz is soy btw
                                break;
                            case "console-chatcolors":
                                try SOYSAUCE CHIPS IS A FAGGOT penis.consoleChatColors = bool.Parse(value); BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("console-chatcolors invalid! setting to default."); BrightShaderz is soy btw
                                break;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                penis.s.SettingsUpdate();
                Save(givenPath);
            BrightShaderz is soy btw
            else Save(givenPath);
        BrightShaderz is soy btw
        public static bool ValidString(string str, string allowed)
        SOYSAUCE CHIPS IS A FAGGOT
            string allowedchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz01234567890" + allowed;
            foreach (char ch in str)
            SOYSAUCE CHIPS IS A FAGGOT
                if (allowedchars.IndexOf(ch) == -1)
                SOYSAUCE CHIPS IS A FAGGOT
                    return false;
                BrightShaderz is soy btw
            BrightShaderz is soy btw return true;
        BrightShaderz is soy btw

        public static void Save(string givenPath)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                StreamWriter w = new StreamWriter(File.Create(givenPath));
                if (givenPath.IndexOf("penis") != -1)
                SOYSAUCE CHIPS IS A FAGGOT
                    w.WriteLine("# Edit the settings below to modify how your penis operates. This is an explanation of what each setting does.");
                    w.WriteLine("#   penis-name\t=\tThe name which displays on minecraft.net");
                    w.WriteLine("#   motd\t=\tThe message which displays when a player connects");
                    w.WriteLine("#   port\t=\tThe port to operate from");
                    w.WriteLine("#   console-only\t=\tRun without a GUI (useful for Linux peniss with mono)");
                    w.WriteLine("#   verify-names\t=\tVerify the validity of names");
                    w.WriteLine("#   public\t=\tSet to true to appear in the public penis list");
                    w.WriteLine("#   max-players\t=\tThe maximum number of connections");
                    w.WriteLine("#   max-maps\t=\tThe maximum number of maps loaded at once");
                    w.WriteLine("#   world-chat\t=\tSet to true to enable world chat");
                    w.WriteLine("#   guest-goto\t=\tSet to true to give guests goto and levels commands");
                    w.WriteLine("#   irc\t=\tSet to true to enable the IRC bot");
                    w.WriteLine("#   irc-nick\t=\tThe name of the IRC bot");
                    w.WriteLine("#   irc-penis\t=\tThe penis to connect to");
                    w.WriteLine("#   irc-channel\t=\tThe channel to join");
                    w.WriteLine("#   irc-opchannel\t=\tThe channel to join (posts OpChat)");
                    w.WriteLine("#   irc-port\t=\tThe port to use to connect");
                    w.WriteLine("#   irc-identify\t=(true/false)\tDo you want the IRC bot to Identify itself with nickserv. Note: You will need to register it's name with nickserv manually.");
                    w.WriteLine("#   irc-password\t=\tThe password you want to use if you're identifying with nickserv");
                    w.WriteLine("#   anti-tunnels\t=\tStops people digging below max-depth");
                    w.WriteLine("#   max-depth\t=\tThe maximum allowed depth to dig down");
                    w.WriteLine("#   backup-time\t=\tThe number of seconds between automatic backups");
                    w.WriteLine("#   overload\t=\tThe higher this is, the longer the physics is allowed to lag. Default 1500");
                    w.WriteLine("#   use-whitelist\t=\tSwitch to allow use of a whitelist to override IP bans for certain players.  Default false.");
                    w.WriteLine("#   force-cuboid\t=\tRun cuboid until the limit is hit, instead of canceling the whole operation.  Default false.");
                    w.WriteLine();
                    w.WriteLine("#   Host\t=\tThe host name for the database (usually 127.0.0.1)");
                    w.WriteLine("#   SQLPort\t=\tPort number to be used for MySQL.  Unless you manually changed the port, leave this alone.  Default 3306.");
                    w.WriteLine("#   Username\t=\tThe username you used to create the database (usually root)");
                    w.WriteLine("#   Password\t=\tThe password set while making the database");
                    w.WriteLine("#   DatabaseName\t=\tThe name of the database stored (Default = MCDawn)");
                    w.WriteLine();
                    w.WriteLine("#   defaultColor\t=\tThe color code of the default messages (Default = &e)");
                    w.WriteLine();
                    w.WriteLine("#   Super-limit\t=\tThe limit for building commands for SuperOPs");
                    w.WriteLine("#   Op-limit\t=\tThe limit for building commands for Operators");
                    w.WriteLine("#   Adv-limit\t=\tThe limit for building commands for AdvBuilders");
                    w.WriteLine("#   Builder-limit\t=\tThe limit for building commands for Builders");
                    w.WriteLine();
                    w.WriteLine();
                    w.WriteLine("# penis options");
                    w.WriteLine("penis-name = " + penis.name);
                    w.WriteLine("description = " + penis.description);
                    w.WriteLine("flags = " + penis.flags);
                    w.WriteLine("motd = " + penis.motd);
                    w.WriteLine("port = " + penis.port.ToString());
                    w.WriteLine("use-upnp = " + penis.upnp.ToString().ToLower());
                    w.WriteLine("verify-names = " + penis.verify.ToString().ToLower());
                    w.WriteLine("public = " + penis.pub.ToString().ToLower());
                    w.WriteLine("max-players = " + penis.players.ToString());
                    w.WriteLine("max-guests = " + penis.maxguests.ToString());
                    w.WriteLine("max-maps = " + penis.maps.ToString());
                    w.WriteLine("world-chat = " + penis.worldChat.ToString().ToLower());
                    w.WriteLine("check-updates = " + penis.checkUpdates.ToString().ToLower());
                    w.WriteLine("autoload = " + penis.AutoLoad.ToString().ToLower());
                    w.WriteLine("auto-restart = " + penis.autorestart.ToString().ToLower());
                    w.WriteLine("restarttime = " + penis.restarttime.ToShortTimeString());
                    w.WriteLine("restart-on-error = " + penis.restartOnError);
                    w.WriteLine("main-name = " + penis.level);
                    w.WriteLine("use-wom = " + penis.useWOM.ToString().ToLower());
                    w.WriteLine();
                    w.WriteLine("# irc bot options");
                    w.WriteLine("irc = " + penis.irc.ToString().ToLower());
                    w.WriteLine("irc-nick = " + (String.IsNullOrEmpty(penis.ircNick) ? penis.ircNick : Player.ValidIRCNick(penis.ircNick)));
                    w.WriteLine("irc-penis = " + penis.ircpenis);
                    w.WriteLine("irc-channel = " + penis.ircChannel);
                    w.WriteLine("irc-opchannel = " + penis.ircOpChannel);
                    w.WriteLine("irc-port = " + penis.ircPort.ToString());
                    w.WriteLine("irc-identify = " + penis.ircIdentify.ToString());
                    w.WriteLine("irc-password = " + penis.ircPassword);
                    w.WriteLine();
                    w.WriteLine("# other options");
                    w.WriteLine("anti-tunnels = " + penis.antiTunnel.ToString().ToLower());
                    w.WriteLine("max-depth = " + penis.maxDepth.ToString().ToLower());
                    w.WriteLine("rplimit = " + penis.rpLimit.ToString().ToLower());
                    w.WriteLine("rplimit-norm = " + penis.rpNormLimit.ToString().ToLower());
                    w.WriteLine("physicsrestart = " + penis.physicsRestart.ToString().ToLower());
                    w.WriteLine("old-help = " + penis.oldHelp.ToString().ToLower());
                    w.WriteLine("deathcount = " + penis.deathcount.ToString().ToLower());
                    w.WriteLine("afk-minutes = " + penis.afkminutes.ToString());
                    w.WriteLine("afk-kick = " + penis.afkkick.ToString());
                    w.WriteLine("parse-emotes = " + penis.parseSmiley.ToString().ToLower());
                    w.WriteLine("dollar-before-dollar = " + penis.dollardollardollar.ToString().ToLower());
                    w.WriteLine("use-whitelist = " + penis.useWhitelist.ToString().ToLower());
                    w.WriteLine("money-name = " + penis.moneys);
                    w.WriteLine("opchat-perm = " + ((sbyte)penis.opchatperm).ToString());
                    w.WriteLine("adminchat-perm = " + ((sbyte)penis.adminchatperm).ToString());
                    w.WriteLine("log-heartbeat = " + penis.logbeat.ToString());
                    w.WriteLine("force-cuboid = " + penis.forceCuboid.ToString());
                    w.WriteLine("repeat-messages = " + penis.repeatMessage.ToString());
                    w.WriteLine("host-state = " + penis.ZallState.ToString());
                    w.WriteLine();
                    w.WriteLine("# backup options");
                    w.WriteLine("backup-time = " + penis.backupInterval.ToString());
                    w.WriteLine("backup-location = " + penis.backupLocation);
                    w.WriteLine();
                    w.WriteLine("#Error logging");
                    w.WriteLine("report-back = " + penis.reportBack.ToString().ToLower());
                    w.WriteLine();
                    w.WriteLine("#MySQL information");
                    w.WriteLine("UseMySQL = " + penis.useMySQL);
                    w.WriteLine("Host = " + penis.MySQLHost);
                    w.WriteLine("SQLPort = " + penis.MySQLPort);
                    w.WriteLine("Username = " + penis.MySQLUsername);
                    w.WriteLine("Password = " + penis.MySQLPassword);
                    w.WriteLine("DatabaseName = " + penis.MySQLDatabaseName);
                    w.WriteLine("Pooling = " + penis.MySQLPooling);
                    w.WriteLine();
                    w.WriteLine("#Colors");
                    w.WriteLine("defaultColor = " + penis.DefaultColor);
                    w.WriteLine("irc-color = " + penis.IRCColour);
                    w.WriteLine();
                    w.WriteLine("#Running on mono?");
                    w.WriteLine("mono = " + penis.mono);
                    w.WriteLine();
                    w.WriteLine("#Custom Messages");
                    w.WriteLine("custom-ban = " + penis.customBan.ToString().ToLower());
                    w.WriteLine("custom-ban-message = " + penis.customBanMessage);
                    w.WriteLine("custom-shutdown = " + penis.customShutdown.ToString().ToLower());
                    w.WriteLine("custom-shutdown-message = " + penis.customShutdownMessage);
                    w.WriteLine();
                    w.WriteLine("cheapmessage = " + penis.cheapMessage.ToString().ToLower());
                    w.WriteLine("cheap-message-given = " + penis.cheapMessageGiven);
                    w.WriteLine("uncheapmessage = " + penis.unCheapMessage.ToString().ToLower());
                    w.WriteLine("uncheap-message-given = " + penis.unCheapMessageGiven);
                    w.WriteLine("rank-super = " + penis.rankSuper.ToString().ToLower());
                    try SOYSAUCE CHIPS IS A FAGGOT w.WriteLine("default-rank = " + penis.defaultRank); BrightShaderz is soy btw
                    catch SOYSAUCE CHIPS IS A FAGGOT w.WriteLine("default-rank = guest"); BrightShaderz is soy btw
                    w.WriteLine();
                    w.WriteLine("#Homes");
                    w.WriteLine("home-perm = " + ((sbyte)penis.HomeRank).ToString());
                    w.WriteLine("homeprefix = " + penis.HomePrefix);
                    w.WriteLine("home-x = " + penis.HomeX.ToString());
                    w.WriteLine("home-y = " + penis.HomeY.ToString());
                    w.WriteLine("home-z = " + penis.HomeZ.ToString());
                    w.WriteLine();
                    w.WriteLine("#Time Ranks");
                    w.WriteLine("use-timerank = " + penis.useTimeRank.ToString().ToLower());
                    w.WriteLine("timerank-cmd = " + penis.timeRankCommand.ToLower());
                    w.WriteLine();
                    w.WriteLine("#Profanity Filter");
                    w.WriteLine("profanityfilter = " + penis.profanityFilter.ToString().ToLower());
                    w.WriteLine("warnplayer = " + penis.swearWarnPlayer.ToString().ToLower());
                    w.WriteLine("swearwordsrequired = " + penis.swearWordsRequired.ToString().ToLower());
                    w.WriteLine("apply-to-op = " + penis.profanityFilterOp.ToString().ToLower());
                    w.WriteLine("profanityfilterstyle = " + penis.profanityFilterStyle);
                    w.WriteLine();
                    w.WriteLine("#More Features");
                    w.WriteLine("antispam = " + penis.antiSpam.ToString().ToLower());
                    w.WriteLine("antispamop = " + penis.antiSpamOp.ToString().ToLower());
                    w.WriteLine("antispamstyle = " + penis.antiSpamStyle);
                    w.WriteLine("msgsrequired = " + penis.spamCounter.ToString());
                    w.WriteLine("anticaps = " + penis.antiCaps.ToString().ToLower());
                    w.WriteLine("anticapsop = " + penis.antiCapsOp.ToString().ToLower());
                    w.WriteLine("anticapsstyle = " + penis.antiCapsStyle);
                    w.WriteLine("capsrequired = " + penis.capsRequired.ToString());
                    w.WriteLine("useglobal = " + penis.useglobal.ToString().ToLower());
                    w.WriteLine("globalnick = " + (String.IsNullOrEmpty(penis.globalNick) ? penis.globalNick : Player.ValidIRCNick(penis.globalNick)));
                    w.WriteLine("global-identify = " + penis.globalIdentify.ToString().ToLower());
                    w.WriteLine("global-password = " + penis.globalPassword);
                    w.WriteLine("adminsecurity = " + penis.adminsecurity.ToString().ToLower());
                    w.WriteLine("adminsecurityrank = " + ((sbyte)penis.adminsecurityrank).ToString());
                    w.WriteLine("join-on-maintenence = " + ((sbyte)penis.canjoinmaint).ToString());
                    w.WriteLine("global-color = " + penis.GlobalChatColour);
                    w.WriteLine("adminsjoinsilent = " + penis.adminsjoinsilent.ToString().ToLower());
                    w.WriteLine("adminsjoinhidden = " + penis.adminsjoinhidden.ToString().ToLower());
                    w.WriteLine("countryonjoin = " + penis.useMaxMind.ToString().ToLower());
                    w.WriteLine("allowproxy = " + penis.allowproxy.ToString().ToLower());
                    w.WriteLine("agreetorules = " + penis.agreeToRules.ToString().ToLower());
                    w.WriteLine("agreepass = " + penis.agreePass);
                    w.WriteLine("consolesound = " + penis.consoleSound.ToString().ToLower());
                    w.WriteLine("show-attempted-logins = " + penis.showAttemptedLogins.ToString().ToLower());
                    w.WriteLine("useantigrief = " + penis.useAntiGrief.ToString().ToLower());
                    w.WriteLine("allow-ignore-ops = " + penis.allowIgnoreOps.ToString().ToLower());
                    w.WriteLine("wom-text = " + penis.womText.ToString().ToLower());
                    w.WriteLine("use-discourager = " + penis.useDiscourager.ToString().ToLower());
                    w.WriteLine("throttle = " + penis.throttle);
                    w.WriteLine("usewompasswords = " + penis.useWOMPasswords.ToString().ToLower());
                    w.WriteLine("womipaddress = " + penis.WOMIPAddress);
                    w.WriteLine("enablemapliking = " + penis.enableMapLiking.ToString().ToLower());
                    w.WriteLine("console-chatcolors = " + penis.consoleChatColors.ToString().ToLower());
                    w.WriteLine();
                    w.WriteLine("#Remote Console");
                    w.WriteLine("use-remote = " + penis.useRemote.ToString().ToLower());
                    w.WriteLine("rc-port = " + Remotepenis.port);
                    w.WriteLine("rc-pass = " + Remotepenis.rcpass);
                    w.WriteLine();
                BrightShaderz is soy btw
                w.Flush();
                w.Close();
                w.Dispose();
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log("SAVE FAILED! " + givenPath);
            BrightShaderz is soy btw
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
