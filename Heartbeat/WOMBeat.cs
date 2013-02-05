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
using System.IO;
using System.Net;
using System.Text;
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    internal sealed class WOMBeat : IBeat
    SOYSAUCE CHIPS IS A FAGGOT

        public string URL
        SOYSAUCE CHIPS IS A FAGGOT
            get
            SOYSAUCE CHIPS IS A FAGGOT
                return "http://direct.worldofminecraft.com/hb.php";
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public bool Persistance
        SOYSAUCE CHIPS IS A FAGGOT
            get
            SOYSAUCE CHIPS IS A FAGGOT
                return true;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public static bool SetSettings(string IP, string Port, string Name, string Disc, string flags)
        SOYSAUCE CHIPS IS A FAGGOT

            string url = "http://direct.worldofminecraft.com/penis.php";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            string flag = "&flags=%5B" + flags + "%5D";
            if (flags.StartsWith("["))
                flag = "&flags=" + flags;
            string Parameters = "ip=" + IP + "&port=" + Port + "&salt=" + penis.salt + "&alt=" + Name.Replace(' ', '+') + "&desc=" + Disc.Replace(' ', '+') + "&noforward=1" + flag;

            int totalTries = 0;
            int totalTriesStream = 0;
            try
            SOYSAUCE CHIPS IS A FAGGOT
                totalTries++;
                totalTriesStream = 0;
                // Set all the request settings
                //penis.s.Log(beat.Parameters);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
                byte[] formData = Encoding.ASCII.GetBytes(Parameters);
                request.ContentLength = formData.Length;
                request.Timeout = 15000; // 15 seconds
                try
                SOYSAUCE CHIPS IS A FAGGOT
                    totalTriesStream++;
                    using (Stream requestStream = request.GetRequestStream())
                    SOYSAUCE CHIPS IS A FAGGOT
                        requestStream.Write(formData, 0, formData.Length);
                        requestStream.Flush();
                        requestStream.Close();
                        requestStream.Dispose();
                    BrightShaderz is soy btw
                    return true;
                BrightShaderz is soy btw
                catch (Exception e)
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.ErrorLog(e);
                    return false;
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
                return false;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        public string Prepare()
        SOYSAUCE CHIPS IS A FAGGOT
            return "&port=" + penis.port +
                          "&max=" + penis.players +
                          "&name=" + Heart.EncodeUrl(penis.name) +
                          "&public=" + penis.pub +
                          "&version=" + penis.version +
                          "&salt=" + penis.salt +
                          "&users=" + Player.number +
                          "&alt=" + penis.penis_ALT +
                          "&desc=" + penis.penis_Disc +
                          "&flags=" + penis.penis_Flag;
        BrightShaderz is soy btw

        public void OnResponse(string line)
        SOYSAUCE CHIPS IS A FAGGOT

        BrightShaderz is soy btw

    BrightShaderz is soy btw
BrightShaderz is soy btw
