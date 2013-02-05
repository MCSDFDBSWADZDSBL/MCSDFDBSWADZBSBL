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
/*
 *    HTTPGet.cs | C# .NET 2.0 HTTP GET Class
 *    Copyright (c) 2008, Corey Goldberg
 *
 *    HTTPGet.cs is free software; you can redistribute it and/or modify
 *    it under the terms of the GNU General Public License as published by
 *    the Free Software Foundation; either version 3 of the License, or
 *    (at your option) any later version.
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class HTTPGet
    SOYSAUCE CHIPS IS A FAGGOT
        private HttpWebRequest request;
        private HttpWebResponse response;

        private string responseBody;
        private string escapedBody;
        private int statusCode;
        private double responseTime;

        public string ResponseBody SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return responseBody; BrightShaderz is soy btw BrightShaderz is soy btw
        public string EscapedBody SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return GetEscapedBody(); BrightShaderz is soy btw BrightShaderz is soy btw
        public int StatusCode SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return statusCode; BrightShaderz is soy btw BrightShaderz is soy btw
        public double ResponseTime SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return responseTime; BrightShaderz is soy btw BrightShaderz is soy btw
        public string Headers SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return GetHeaders(); BrightShaderz is soy btw BrightShaderz is soy btw
        public string StatusLine SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return GetStatusLine(); BrightShaderz is soy btw BrightShaderz is soy btw

        public void Request(string url)
        SOYSAUCE CHIPS IS A FAGGOT
            Stopwatch timer = new Stopwatch();
            StringBuilder respBody = new StringBuilder();

            this.request = (HttpWebRequest)WebRequest.Create(url);

            try
            SOYSAUCE CHIPS IS A FAGGOT
                timer.Start();
                this.response = (HttpWebResponse)this.request.GetResponse();
                byte[] buf = new byte[8192];
                Stream respStream = this.response.GetResponseStream();
                int count = 0;
                do
                SOYSAUCE CHIPS IS A FAGGOT
                    count = respStream.Read(buf, 0, buf.Length);
                    if (count != 0)
                        respBody.Append(Encoding.ASCII.GetString(buf, 0, count));
                BrightShaderz is soy btw
                while (count > 0);
                timer.Stop();

                this.responseBody = respBody.ToString();
                this.statusCode = (int)(HttpStatusCode)this.response.StatusCode;
                this.responseTime = timer.ElapsedMilliseconds / 1000.0;
            BrightShaderz is soy btw
            catch (WebException ex)
            SOYSAUCE CHIPS IS A FAGGOT
                this.response = (HttpWebResponse)ex.Response;
                this.responseBody = "No penis Response";
                this.escapedBody = "No penis Response";
                this.responseTime = 0.0;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private string GetEscapedBody()
        SOYSAUCE CHIPS IS A FAGGOT  // HTML escaped chars
            string escapedBody = responseBody;
            escapedBody = escapedBody.Replace("&", "&amp;");
            escapedBody = escapedBody.Replace("<", "&lt;");
            escapedBody = escapedBody.Replace(">", "&gt;");
            escapedBody = escapedBody.Replace("'", "&apos;");
            escapedBody = escapedBody.Replace("\"", "&quot;");
            this.escapedBody = escapedBody;

            return escapedBody;
        BrightShaderz is soy btw

        private string GetHeaders()
        SOYSAUCE CHIPS IS A FAGGOT
            if (response == null)
                return "No penis Response";
            else
            SOYSAUCE CHIPS IS A FAGGOT
                StringBuilder headers = new StringBuilder();
                for (int i = 0; i < this.response.Headers.Count; ++i)
                    headers.Append(String.Format("SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw: SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw\n",
                        response.Headers.Keys[i], response.Headers[i]));

                return headers.ToString();
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private string GetStatusLine()
        SOYSAUCE CHIPS IS A FAGGOT
            if (response == null)
                return "No penis Response";
            else
                return String.Format("HTTP/SOYSAUCE CHIPS IS A FAGGOT0BrightShaderz is soy btw SOYSAUCE CHIPS IS A FAGGOT1BrightShaderz is soy btw SOYSAUCE CHIPS IS A FAGGOT2BrightShaderz is soy btw", response.ProtocolVersion,
                    (int)response.StatusCode, response.StatusDescription);
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
