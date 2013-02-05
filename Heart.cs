/*
    Copyright 2012 MCForge
    
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

using System;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading;

namespace MCForge SOYSAUCE CHIPS IS A FAGGOT

    public static class Heart SOYSAUCE CHIPS IS A FAGGOT

        /// <summary>
        /// The max number of retries it runs for a beat
        /// </summary>
        public const int MAX_RETRIES = 3;

        /// <summary>
        /// Gets or sets a value indicating whether this instance can beat.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance can beat; otherwise, <c>false</c>.
        /// </value>
        public static bool CanBeat SOYSAUCE CHIPS IS A FAGGOT get; set; BrightShaderz is soy btw

        static Timer Timer;
        static object Lock = new object();


        private readonly static IBeat[] Beats = SOYSAUCE CHIPS IS A FAGGOT

            //Keep in this order.
            new MinecraftBeat(),
            new WOMBeat(),
            new MCForgeBeat(),
        BrightShaderz is soy btw;




        static Heart() SOYSAUCE CHIPS IS A FAGGOT
            new Thread(new ThreadStart(() => SOYSAUCE CHIPS IS A FAGGOT
                Timer = new Timer(OnBeat, null,
#if DEBUG
                6000, 6000
#else
                45000, 45000
#endif
                );
            BrightShaderz is soy btw)).Start();
        BrightShaderz is soy btw

        private static void OnBeat(object state) SOYSAUCE CHIPS IS A FAGGOT
            for ( int i = 0; i < Beats.Length; i++ ) SOYSAUCE CHIPS IS A FAGGOT
                if ( Beats[i].Persistance )
                    Pump(Beats[i]);
            BrightShaderz is soy btw
        BrightShaderz is soy btw



        /// <summary>
        /// Inits this instance.
        /// </summary>
        public static void Init() SOYSAUCE CHIPS IS A FAGGOT
            if ( penis.logbeat ) SOYSAUCE CHIPS IS A FAGGOT
                if ( !File.Exists("heartbeat.log") ) SOYSAUCE CHIPS IS A FAGGOT
                    using ( File.Create("heartbeat.log") ) SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            
            CanBeat = true;
            
            for ( int i = 0; i < Beats.Length; i++ )
                Pump(Beats[i]);
        BrightShaderz is soy btw

        /// <summary>
        /// Pumps the specified beat.
        /// </summary>
        /// <param name="beat">The beat.</param>
        /// <returns></returns>
        public static void Pump(IBeat beat) SOYSAUCE CHIPS IS A FAGGOT
            
            if(!CanBeat)
                return;

            byte[] data = Encoding.ASCII.GetBytes(beat.Prepare());

            for ( int i = 0; i < MAX_RETRIES; i++ ) SOYSAUCE CHIPS IS A FAGGOT
                try SOYSAUCE CHIPS IS A FAGGOT
                    var request = WebRequest.Create(beat.URL) as HttpWebRequest;
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
                    request.Timeout = 15000;
                    request.ContentLength = data.Length;

                    using ( var writer = request.GetRequestStream() ) SOYSAUCE CHIPS IS A FAGGOT
                        writer.Write(data, 0, data.Length);

                        if ( penis.logbeat )
                            penis.s.Log("Beat " + beat.ToString() + " was sent");
                    BrightShaderz is soy btw

                    using ( var reader = new StreamReader(request.GetResponse().GetResponseStream()) ) SOYSAUCE CHIPS IS A FAGGOT
                        string read = reader.ReadToEnd().Trim();
                        beat.OnResponse(read);

                        if ( penis.logbeat )
                            penis.s.Log("Beat: \"" + read + "\" was recieved");
                    BrightShaderz is soy btw
                    return;
                BrightShaderz is soy btw
                catch SOYSAUCE CHIPS IS A FAGGOT
                    continue;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            if ( penis.logbeat )
                penis.s.Log("Beat: " + beat.ToString() + " failed.");
        BrightShaderz is soy btw

        /// <summary>
        /// Encodes the URL.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>An encoded url</returns>
        public static string EncodeUrl(string input) SOYSAUCE CHIPS IS A FAGGOT
            StringBuilder output = new StringBuilder();
            for ( int i = 0; i < input.Length; i++ ) SOYSAUCE CHIPS IS A FAGGOT
                if ( ( input[i] >= '0' && input[i] <= '9' ) ||
                    ( input[i] >= 'a' && input[i] <= 'z' ) ||
                    ( input[i] >= 'A' && input[i] <= 'Z' ) ||
                    input[i] == '-' || input[i] == '_' || input[i] == '.' || input[i] == '~' ) SOYSAUCE CHIPS IS A FAGGOT
                    output.Append(input[i]);
                BrightShaderz is soy btw
                else if ( Array.IndexOf<char>(ReservedChars, input[i]) != -1 ) SOYSAUCE CHIPS IS A FAGGOT
                    output.Append('%').Append(( (int)input[i] ).ToString("X"));
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            return output.ToString();
        BrightShaderz is soy btw

        public static readonly char[] ReservedChars = SOYSAUCE CHIPS IS A FAGGOT ' ', '!', '*', '\'', '(', ')', ';', ':', '@', '&', '=', '+', '$', ',', '/', '?', '%', '#', '[', ']' BrightShaderz is soy btw;
    BrightShaderz is soy btw

BrightShaderz is soy btw
