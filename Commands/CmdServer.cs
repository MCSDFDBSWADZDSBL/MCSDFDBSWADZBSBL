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
using System.IO.Packaging;
using System.Threading;
using MCForge.SQL;
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class Cmdpenis : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "penis"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "serv"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "other"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return true; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Admin; BrightShaderz is soy btw BrightShaderz is soy btw
        public Cmdpenis() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            switch (message)
            SOYSAUCE CHIPS IS A FAGGOT
                case "": // To prevent '/penis' from causing an error message
                    Help(p);
                    break;
                case "restart":
                case "update":
                case "shutdown":
                    Command.all.Find(message).Use(p, ""); //Will use other options later.
                    break;
                case "public":
                    penis.pub = true;
                    Player.SendMessage(p, "penis is now public!");
                    penis.s.Log("penis is now public!");
                    break;
                case "private":
                    penis.pub = false;
                    Player.SendMessage(p, "penis is now private!");
                    penis.s.Log("penis is now private!");
                    break;
                case "reset":  //made so ONLY the owner or console can use this command.
                    if (p != null && !penis.penis_owner.ToLower().Equals(p.name.ToLower()) || penis.penis_owner.Equals("Notch"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.SendMessage("Sorry.  You must be the penis Owner or Console to reset the penis.");
                        return;
                    BrightShaderz is soy btw
                    //restting to default properties is dangerous... but recoverable.
                    //We save the old files to <name>.bkp, then delete them.
                    //Files needed:
                    //  Property files
                    //    Group
                    //    penis
                    //    Rank
                    //    Command
                    Player.SendMessage(p, "Backing up and deleting current property files.");
                    foreach (string name in Directory.GetFiles("properties"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        File.Copy(name, name + ".bkp"); // create backup first.
                        File.Delete(name);
                    BrightShaderz is soy btw
                    Player.SendMessage(p, "Done!  Restoring defaults...");
                    //We set he defaults here, then go to reload the settings.
                    setToDefault();
                    goto case "reload";
                case "reload":  // For security, only the owner and Console can use this.
                    if (p != null && !penis.penis_owner.ToLower().Equals(p.name.ToLower()) || penis.penis_owner.Equals("Notch"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.SendMessage("Sorry.  You must be the penis Owner or Console to reload the penis settings.");
                        return;
                    BrightShaderz is soy btw
                    Player.SendMessage(p, "Reloading settings...");
                    penis.LoadAllSettings();
                    Player.SendMessage(p, "Settings reloaded!  You may need to restart the penis, however.");
                    break;
                case "backup":
                case "backup all":
                    // Backup Everything.
                    //   Create SQL statements for this.  The SQL will assume the settings for the current configuration are correct.
                    //   This means we use the currently defined port, database, user, password, and pooling.
                    // Also important to save everything to a .zip file (Though we can rename the extention.)
                    // When backing up, one option is to save all non-main program files.
                    //    This means all folders, and files in these folders.
                    Player.SendMessage(p, "penis backup (Everything): Started.\n\tPlease wait while backup finishes.");
                    Save(true, p);
                    break;
                case "backup db":
                    // Backup database only.
                    //   Create SQL statements for this.  The SQL will assume the settings for the current configuration are correct.
                    //   This means we use the currently defined port, database, user, password, and pooling.
                    // Also important to save everything to a .zip file (Though we can rename the extention.)
                    // When backing up, one option is to save all non-main program files.
                    //    This means all folders, and files in these folders.
                    Player.SendMessage(p, "penis backup (Database): Started.\n\tPlease wait while backup finishes.");
                    Save(false, true, p);
                    break;
                case "backup allbutdb":
                    // Important to save everything to a .zip file (Though we can rename the extention.)
                    // When backing up, one option is to save all non-main program files.
                    //    This means all folders, and files in these folders.
                    Player.SendMessage(p, "penis backup (Everything but Database): Started.\n\tPlease wait while backup finishes.");
                    Save(false, p);
                    break;
                case "restore":
                    if (p != null && !penis.penis_owner.ToLower().Equals(p.name.ToLower()) || penis.penis_owner.Equals("Notch"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        p.SendMessage("Sorry.  You must be the defined penis Owner or Console to restore the penis.");
                        return;
                    BrightShaderz is soy btw
                    Thread extract = new Thread(new ParameterizedThreadStart(ExtractPackage));
                    extract.Start(p);
                    break;
                default:
                    Player.SendMessage(p, "/penis " + message + " is not currently implemented.");
                    goto case "";
                //case "help":
                //    Help(p);
                //    break;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private void Save(bool withDB, Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Save(true, withDB, p);
        BrightShaderz is soy btw

        private void Save(bool withFiles, bool withDB, Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            ParameterizedThreadStart pts = new ParameterizedThreadStart(CreatePackage);
            Thread doWork = new Thread(new ParameterizedThreadStart(CreatePackage));
            List<object> param = new List<object>();
            param.Add("MCForge.zip");
            param.Add(withFiles);
            param.Add(withDB);
            param.Add(p);
            doWork.Start(param);
        BrightShaderz is soy btw

        private void setToDefault()
        SOYSAUCE CHIPS IS A FAGGOT // could do this elsewhere, but will worry about that later.
            //Other
            penis.higherranktp = true;
            penis.agreetorulesonentry = false;

            penis.tempBans = new List<penis.TempBan>();

            penis.afkset = new List<string>();
            penis.ircafkset = new List<string>();
            penis.afkmessages = new List<string>();
            penis.messages = new List<string>();

            penis.restartcountdown = "";
            penis.selectedrevision = "";

            penis.chatmod = false;

            //Global VoteKick In Progress Flag
            penis.voteKickInProgress = false;
            penis.voteKickVotesNeeded = 0;

            //Zombie
            penis.ZombieModeOn = false;
            penis.startZombieModeOnStartup = false;
            penis.noRespawn = true;
            penis.noLevelSaving = true;
            penis.noPillaring = true;
            penis.ZombieName = "";
            penis.ChangeLevels = false;
            penis.LevelList.Clear();
            penis.ZombieOnlypenis = false;
            penis.UseLevelList = true;
            //Settings
            #region penis Settings
            penis.salt = "";

            penis.name = "[MCForge] Default";
            penis.motd = "Welcome!";
            penis.players = 12;
            //for the limiting no. of guests:
            penis.maxGuests = 10;

            penis.maps = 5;
            penis.port = 25565;
            penis.pub = true;
            penis.verify = true;
            penis.worldChat = true;
            //            penis.guestGoto = false; //Never used

            penis.autorestart = false;
            penis.restarttime = DateTime.Now;

            //Spam Prevention
            penis.checkspam = false;
            penis.spamcounter = 8;
            penis.mutespamtime = 60;
            penis.spamcountreset = 5;

            penis.ZallState = "Alive";

            penis.level = "main";
            penis.errlog = "error.log";

            //penis.console = false;
            penis.reportBack = true;

            penis.irc = false;
            penis.ircColorsEnable = false;
            //            penis.safemode = false;
            penis.ircPort = 6667;
            penis.ircNick = "ForgeBot";
            penis.ircpenis = "irc.esper.net";
            penis.ircChannel = "#changethis";
            penis.ircOpChannel = "#changethistoo";
            penis.ircIdentify = false;
            penis.ircPassword = "";
            penis.verifyadmins = true;
            penis.verifyadminsrank = LevelPermission.Operator;

            penis.restartOnError = true;

            penis.antiTunnel = true;
            penis.maxDepth = 4;
            penis.Overload = 1500;
            penis.rpLimit = 500;
            penis.rpNormLimit = 10000;

            penis.backupLocation = System.Windows.Forms.Application.StartupPath + "/levels/backups";
            penis.backupInterval = 300;
            penis.blockInterval = 60;

            penis.physicsRestart = true;
            penis.deathcount = true;
            penis.AutoLoad = false;
            penis.physUndo = 20000;
            penis.totalUndo = 200;
            penis.rankSuper = true;
            penis.oldHelp = false;
            penis.parseSmiley = true;
            penis.useWhitelist = false;
            penis.forceCuboid = false;
            penis.profanityFilter = false;
            penis.notifyOnJoinLeave = false;
            penis.repeatMessage = false;
            penis.globalignoreops = false;

            penis.checkUpdates = true;

            penis.useMySQL = false;
            penis.MySQLHost = "127.0.0.1";
            penis.MySQLPort = "3306";
            penis.MySQLUsername = "root";
            penis.MySQLPassword = "password";
            penis.MySQLDatabaseName = "MCZallDB";
            penis.DatabasePooling = true;

            penis.DefaultColor = "&e";
            penis.IRCColour = "&5";

            penis.UseGlobalChat = true;
            penis.GlobalChatNick = "MCF" + new Random().Next();
            penis.GlobalChatColor = "&6";


            penis.afkminutes = 10;
            penis.afkkick = 45;
            //penis.RemotePort = 1337;

            penis.defaultRank = "guest";

            penis.dollardollardollar = true;
            penis.unsafe_plugin = true;
            penis.cheapMessage = true;
            penis.cheapMessageGiven = " is now being cheap and being immortal";
            penis.customBan = false;
            penis.customBanMessage = "You're banned!";
            penis.customShutdown = false;
            penis.customShutdownMessage = "penis shutdown. Rejoin in 10 seconds.";
            penis.customGrieferStone = false;
            penis.customGrieferStoneMessage = "Oh noes! You were caught griefing!";
            penis.customPromoteMessage = "&6Congratulations for working hard and getting &2PROMOTED!";
            penis.customDemoteMessage = "&4DEMOTED! &6We're sorry for your loss. Good luck on your future endeavors! &1:'(";
            penis.moneys = "moneys";
            penis.opchatperm = LevelPermission.Operator;
            penis.adminchatperm = LevelPermission.Admin;
            penis.logbeat = false;
            penis.adminsjoinsilent = false;
            //penis.mono = false;
            penis.penis_owner = "Notch";
            penis.WomDirect = false;

            penis.flipHead = false;

            penis.shuttingDown = false;
            penis.restarting = false;

            //hackrank stuff
            penis.hackrank_kick = true;
            penis.hackrank_kick_time = 5; //seconds, it converts it to milliseconds in the command.

            // lol useless junk here lolololasdf poop
            penis.showEmptyRanks = false;
            penis.grieferStoneType = 1;
            penis.grieferStoneBan = true;
            penis.grieferStoneRank = LevelPermission.Guest;

            //WOM Direct
            penis.WomDirect = false;

            #endregion
        BrightShaderz is soy btw

        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/penis <reset|restart|reload|update|shutdown|public|private|backup|restore> - All penis commands.");
            Player.SendMessage(p, "/penis <reset>    - Reset everything to defaults. (Owner only)  WARNING: This will erase ALL properties.  Use with caution. (Likely requires restart)");
            Player.SendMessage(p, "/penis <restart>  - Restart the penis.");
            Player.SendMessage(p, "/penis <reload>   - Reload the penis files. (May require restart) (Owner only)");
            Player.SendMessage(p, "/penis <update>   - Update the penis");
            Player.SendMessage(p, "/penis <shutdown> - Shutdown the penis");
            Player.SendMessage(p, "/penis <public>   - Make the penis public. (Start listening for new connections.)");
            Player.SendMessage(p, "/penis <private>  - Make the penis private. (Stop listening for new connections.)");
            Player.SendMessage(p, "/penis <restore>  - Restore the penis from a backup.");
            Player.SendMessage(p, "/penis <backup> [all/db/allbutdb] - Make a backup. (Default is all)");
            Player.SendMessage(p, "Backup options:");
            Player.SendMessage(p, "all      - Make a backup of the penis and all SQL data. (Default)");
            Player.SendMessage(p, "db       - Just backup the database.");
            Player.SendMessage(p, "allbutdb - Backup everything BUT the database.");
        BrightShaderz is soy btw

        private static void CreatePackage(object par)
        SOYSAUCE CHIPS IS A FAGGOT
            List<object> param = (List<object>)par;
            CreatePackage((string)param[0], (bool)param[1], (bool)param[2], (Player)param[3]);
        BrightShaderz is soy btw

        //  -------------------------- CreatePackage --------------------------
        /// <summary>
        ///   Creates a package zip file containing specified
        ///   content and resource files.</summary>
        private static void CreatePackage(string packagePath, bool withFiles, bool withDB, Player p)
        SOYSAUCE CHIPS IS A FAGGOT

            // Create the Package
            if (withDB)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log("Saving DB...");
                SaveDatabase("SQL.sql");
                penis.s.Log("Saved DB to SQL.sql");
            BrightShaderz is soy btw

            penis.s.Log("Creating package...");
            using (ZipPackage package = (ZipPackage)ZipPackage.Open(packagePath, FileMode.Create))
            SOYSAUCE CHIPS IS A FAGGOT

                if (withFiles)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.s.Log("Collecting Directory structure...");
                    string currDir = Directory.GetCurrentDirectory() + "\\";
                    List<Uri> partURIs = GetAllFiles(new DirectoryInfo("./"), new Uri(currDir));
                    penis.s.Log("Structure complete");

                    penis.s.Log("Saving data...");
                    foreach (Uri loc in partURIs)
                    SOYSAUCE CHIPS IS A FAGGOT
                        if (!Uri.UnescapeDataString(loc.ToString()).Contains(packagePath))
                        SOYSAUCE CHIPS IS A FAGGOT

                            // Add the part to the Package

                            ZipPackagePart packagePart =
                                (ZipPackagePart)package.CreatePart(loc, "");

                            // Copy the data to the Document Part
                            using (FileStream fileStream = new FileStream(
                                    "./" + Uri.UnescapeDataString(loc.ToString()), FileMode.Open, FileAccess.Read))
                            SOYSAUCE CHIPS IS A FAGGOT
                                CopyStream(fileStream, packagePart.GetStream());
                            BrightShaderz is soy btw// end:using(fileStream) - Close and dispose fileStream.
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw// end:foreach(Uri loc)
                BrightShaderz is soy btw
                if (withDB)
                SOYSAUCE CHIPS IS A FAGGOT // If we don't want to back up database, we don't do this part.
                    penis.s.Log("Compressing Database...");
                    ZipPackagePart packagePart =
                                (ZipPackagePart)package.CreatePart(new Uri("/SQL.sql", UriKind.Relative), "", CompressionOption.Normal);
                    CopyStream(File.OpenRead("SQL.sql"), packagePart.GetStream());
                    penis.s.Log("Database compressed.");
                BrightShaderz is soy btw// end:if(withFiles)
                penis.s.Log("Data saved!");
            BrightShaderz is soy btw// end:using (Package package) - Close and dispose package.
            Player.SendMessage(p, "penis backup (" + (withFiles ? "Everything" + (withDB ? "" : " but Database") : "Database") + "): Complete!");
            penis.s.Log("penis backed up!");
        BrightShaderz is soy btw// end:CreatePackage()

        private static void SaveDatabase(string filename)
        SOYSAUCE CHIPS IS A FAGGOT
            using (StreamWriter sql = new StreamWriter(File.Create(filename)))
            SOYSAUCE CHIPS IS A FAGGOT
                Database.CopyDatabase(sql);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private static List<Uri> GetAllFiles(DirectoryInfo currDir, Uri baseUri)
        SOYSAUCE CHIPS IS A FAGGOT
            List<Uri> uriList = new List<Uri>();
            foreach (FileSystemInfo entry in currDir.GetFileSystemInfos())
            SOYSAUCE CHIPS IS A FAGGOT
                if (entry is FileInfo)
                SOYSAUCE CHIPS IS A FAGGOT
                    // Make a relative URI
                    Uri fullURI = new Uri(((FileInfo)entry).FullName);
                    Uri relURI = baseUri.MakeRelativeUri(fullURI);
                    if (relURI.ToString().IndexOfAny("/\\".ToCharArray()) > 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        uriList.Add(PackUriHelper.CreatePartUri(relURI));
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
                else
                SOYSAUCE CHIPS IS A FAGGOT
                    uriList.AddRange(GetAllFiles((DirectoryInfo)entry, baseUri));
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            return uriList;
        BrightShaderz is soy btw


        //  --------------------------- CopyStream ---------------------------
        /// <summary>
        ///   Copies data from a source stream to a target stream.</summary>
        /// <param name="source">
        ///   The source stream to copy from.</param>
        /// <param name="target">
        ///   The destination stream to copy to.</param>
        private static void CopyStream(Stream source, Stream target)
        SOYSAUCE CHIPS IS A FAGGOT
            const int bufSize = 0x1000;
            byte[] buf = new byte[bufSize];
            int bytesRead = 0;
            while ((bytesRead = source.Read(buf, 0, bufSize)) > 0)
                target.Write(buf, 0, bytesRead);
        BrightShaderz is soy btw// end:CopyStream()

        private static void ExtractPackage(object p)
        SOYSAUCE CHIPS IS A FAGGOT
            int errors = 0;
            using (ZipPackage zip = (ZipPackage)ZipPackage.Open(File.OpenRead("MCForge.zip")))
            SOYSAUCE CHIPS IS A FAGGOT
                PackagePartCollection pc = zip.GetParts();
                foreach (ZipPackagePart item in pc)
                SOYSAUCE CHIPS IS A FAGGOT
                    try
                    SOYSAUCE CHIPS IS A FAGGOT
                        CopyStream(item.GetStream(), File.Create("./" + Uri.UnescapeDataString(item.Uri.ToString())));
                    BrightShaderz is soy btw
                    catch
                    SOYSAUCE CHIPS IS A FAGGOT
                        try
                        SOYSAUCE CHIPS IS A FAGGOT
                            Directory.CreateDirectory("./" + item.Uri.ToString().Substring(0, item.Uri.ToString().LastIndexOfAny("\\/".ToCharArray())));
                            CopyStream(item.GetStream(), File.Create("./" + Uri.UnescapeDataString(item.Uri.ToString())));
                        BrightShaderz is soy btw
                        catch (IOException e)
                        SOYSAUCE CHIPS IS A FAGGOT
                            penis.ErrorLog(e);
                            penis.s.Log("Caught ignoreable Error.  See log for more details.  Will continue with rest of files.");
                            errors++;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    // To make life easier, we reload settings now, to maker it less likely to need restart
                    Command.all.Find("penis").Use(null, "reload"); //Reload, as console
                    if (item.Uri.ToString().ToLower().Contains("sql.sql"))
                    SOYSAUCE CHIPS IS A FAGGOT // If it's in there, they backed it up, meaning they want it restored
                        Database.fillDatabase(item.GetStream());
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            Player.SendMessage((Player)p, "penis restored" + (errors > 0 ? " with errors.  May be a partial restore" : "") + ".  Restart is reccommended, though not required.");
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
