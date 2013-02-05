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
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public static class Logger
    SOYSAUCE CHIPS IS A FAGGOT
        public static void Write(string str) //Kept for backwards compatibility
        SOYSAUCE CHIPS IS A FAGGOT
            PidgeonLogger.LogMessage(str);
        BrightShaderz is soy btw
        public static void WriteError(Exception ex)
        SOYSAUCE CHIPS IS A FAGGOT
            PidgeonLogger.LogError(ex);
        BrightShaderz is soy btw
        public static string LogPath SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return PidgeonLogger.MessageLogPath; BrightShaderz is soy btw set SOYSAUCE CHIPS IS A FAGGOT PidgeonLogger.MessageLogPath = value; BrightShaderz is soy btw BrightShaderz is soy btw
        public static string ErrorLogPath SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return PidgeonLogger.ErrorLogPath; BrightShaderz is soy btw set SOYSAUCE CHIPS IS A FAGGOT PidgeonLogger.ErrorLogPath = value; BrightShaderz is soy btw BrightShaderz is soy btw

        //Everything is static..!
        public static void Dispose()
        SOYSAUCE CHIPS IS A FAGGOT
            PidgeonLogger.Dispose();
        BrightShaderz is soy btw

    BrightShaderz is soy btw
    /// <summary>
    /// Temporary class, will replace Logger completely once satisfied
    /// </summary>
    static class PidgeonLogger
    SOYSAUCE CHIPS IS A FAGGOT
        //TODO: Implement report back feature

        static Boolean NeedRestart = false;
        static System.Timers.Timer RestartTimer = new System.Timers.Timer(30000);

        static bool _disposed;
        static bool _reportBack = false;
        static string _messagePath = "logs/" + DateTime.Now.ToString("yyyy-MM-dd").Replace("/", "-") + ".txt";
        static string _errorPath = "logs/errors/" + DateTime.Now.ToString("yyyy-MM-dd").Replace("/", "-") + "error.log";

        static object _lockObject = new object();
        static object _fileLockObject = new object();
        static Thread _workingThread;
        static Queue<string> _messageCache = new Queue<string>();
        static Queue<string> _errorCache = new Queue<string>(); //always handle this first!

        static public void Init()
        SOYSAUCE CHIPS IS A FAGGOT
            _reportBack = penis.reportBack;
            //Should be done as part of the config
            if (!Directory.Exists("logs")) Directory.CreateDirectory("logs");
            if (!Directory.Exists("logs/errors")) Directory.CreateDirectory("logs/errors");

            _workingThread = new Thread(new ThreadStart(WorkerThread));
            _workingThread.IsBackground = true;
            _workingThread.Start();
        BrightShaderz is soy btw

        public static string MessageLogPath
        SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT return _messagePath; BrightShaderz is soy btw
            set SOYSAUCE CHIPS IS A FAGGOT _messagePath = value; BrightShaderz is soy btw
        BrightShaderz is soy btw
        public static string ErrorLogPath
        SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT return _errorPath; BrightShaderz is soy btw
            set SOYSAUCE CHIPS IS A FAGGOT _errorPath = value; BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static void LogMessage(string message)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                if (!string.IsNullOrEmpty(message))
                    lock (_lockObject)
                    SOYSAUCE CHIPS IS A FAGGOT
                        _messageCache.Enqueue(message);
                        Monitor.Pulse(_lockObject);
                    BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch
            SOYSAUCE CHIPS IS A FAGGOT

            BrightShaderz is soy btw
            //Should it error or passed null or zero string?
        BrightShaderz is soy btw
        public static void LogError(Exception ex)
        SOYSAUCE CHIPS IS A FAGGOT
            try
            SOYSAUCE CHIPS IS A FAGGOT
                StringBuilder sb = new StringBuilder();
                Exception e = ex;

                sb.AppendLine("----" + DateTime.Now + " ----");
                while (e != null)
                SOYSAUCE CHIPS IS A FAGGOT
                    sb.AppendLine(getErrorText(e));
                    e = e.InnerException;
                BrightShaderz is soy btw

                sb.AppendLine(new string('-', 25));

                if(penis.s != null)
                    penis.s.ErrorCase(sb.ToString());

                lock (_lockObject)
                SOYSAUCE CHIPS IS A FAGGOT
                    _errorCache.Enqueue(sb.ToString());
                    Monitor.Pulse(_lockObject);
                BrightShaderz is soy btw



                if (NeedRestart)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.listen.Close();
                    penis.Setup();
                    //http://alltheragefaces.com/img/faces/large/misc-jackie-chan-l.png

                    NeedRestart = false;
                BrightShaderz is soy btw
            BrightShaderz is soy btw catch (Exception e) SOYSAUCE CHIPS IS A FAGGOT
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    File.AppendAllText("ErrorLogError.log", getErrorText(e));
                BrightShaderz is soy btw
                catch (Exception _ex)
                SOYSAUCE CHIPS IS A FAGGOT
                    MessageBox.Show("ErrorLogError Error:\n Could not log the error logs error. This is a big error. \n" + _ex.Message);
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw


        static void WorkerThread()
        SOYSAUCE CHIPS IS A FAGGOT
            while (!_disposed)
            SOYSAUCE CHIPS IS A FAGGOT
                lock (_lockObject)
                SOYSAUCE CHIPS IS A FAGGOT
                    if (_errorCache.Count > 0)
                        FlushCache(_errorPath, _errorCache);

                    if (_messageCache.Count > 0)
                        FlushCache(_messagePath, _messageCache);
                    //Monitor.Wait(_lockObject, 500);
                BrightShaderz is soy btw
                Thread.Sleep(500);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        //Only call from within synchronised code or all hell will break loose
        static void FlushCache(string path, Queue<string> cache)
        SOYSAUCE CHIPS IS A FAGGOT
            // Extra layer of protection
            lock (_fileLockObject)
            SOYSAUCE CHIPS IS A FAGGOT
                FileStream fs = null;
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    //TODO: not happy about constantly opening and closing a stream like this but I suppose its ok (Pidgeon)
                    fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                    while (cache.Count > 0)
                    SOYSAUCE CHIPS IS A FAGGOT
                        byte[] tmp = Encoding.Default.GetBytes(cache.Dequeue());
                        fs.Write(tmp, 0, tmp.Length);
                    BrightShaderz is soy btw
                    fs.Close();
                BrightShaderz is soy btw
                finally
                SOYSAUCE CHIPS IS A FAGGOT
                    fs.Dispose();
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        static string getErrorText(Exception e)
        SOYSAUCE CHIPS IS A FAGGOT
            if(e == null)
                return String.Empty;

            StringBuilder sb = new StringBuilder();

            // Attempt to gather this info.  Skip anything that you can't read for whatever reason
            try SOYSAUCE CHIPS IS A FAGGOT sb.AppendLine("Type: " + e.GetType().Name); BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            try SOYSAUCE CHIPS IS A FAGGOT sb.AppendLine("Source: " + e.Source); BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            try SOYSAUCE CHIPS IS A FAGGOT sb.AppendLine("Message: " + e.Message); BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            try SOYSAUCE CHIPS IS A FAGGOT sb.AppendLine("Target: " + e.TargetSite.Name); BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
            try SOYSAUCE CHIPS IS A FAGGOT sb.AppendLine("Trace: " + e.StackTrace); BrightShaderz is soy btw catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

            if (e.Message != null && e.Message.IndexOf("An existing connection was forcibly closed by the remote host") != -1)
            SOYSAUCE CHIPS IS A FAGGOT
                NeedRestart = true;
            BrightShaderz is soy btw

            return sb.ToString();
        BrightShaderz is soy btw

        #region IDisposable Members

        public static void Dispose()
        SOYSAUCE CHIPS IS A FAGGOT
            if (_disposed)
                return;
            _disposed = true;
            lock (_lockObject)
            SOYSAUCE CHIPS IS A FAGGOT
                if (_errorCache.Count > 0)
                SOYSAUCE CHIPS IS A FAGGOT
                    FlushCache(_errorPath, _errorCache);
                BrightShaderz is soy btw

                _messageCache.Clear();
                Monitor.Pulse(_lockObject);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        #endregion
    BrightShaderz is soy btw
BrightShaderz is soy btw
