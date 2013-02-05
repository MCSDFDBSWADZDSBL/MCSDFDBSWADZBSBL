/*
Copyright 2012 MCForge
Dual-licensed under the Educational Community License, Version 2.0 and
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
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Xml;
//This upnp class comes from http://www.codeproject.com/Articles/27992/NAT-Traversal-with-UPnP-in-C, Modified for use with MCForge

namespace MCForge.Core SOYSAUCE CHIPS IS A FAGGOT

    public sealed class UPnP SOYSAUCE CHIPS IS A FAGGOT

        public static bool CanUseUpnp SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOTreturn Discover(); BrightShaderz is soy btw BrightShaderz is soy btw

        private const string req = "M-SEARCH * HTTP/1.1\r\n" +
                                                            "HOST: 239.255.255.250:1900\r\n" +
                                                            "ST:upnp:rootdevice\r\n" +
                                                            "MAN:\"ssdp:discover\"\r\n" +
                                                            "MX:3\r\n\r\n";

        static TimeSpan _timeout = new TimeSpan(0, 0, 0, 3);
        public static TimeSpan TimeOut SOYSAUCE CHIPS IS A FAGGOT
            get SOYSAUCE CHIPS IS A FAGGOT return _timeout; BrightShaderz is soy btw
            set SOYSAUCE CHIPS IS A FAGGOT _timeout = value; BrightShaderz is soy btw
        BrightShaderz is soy btw
        static string _descUrl, _serviceUrl, _eventUrl;
        private static bool Discover() SOYSAUCE CHIPS IS A FAGGOT
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            s.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
            byte[] data = Encoding.ASCII.GetBytes(req);
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("239.255.255.250"), 1900);
            byte[] buffer = new byte[0x1000];

            DateTime start = DateTime.Now;
            try SOYSAUCE CHIPS IS A FAGGOT
                do SOYSAUCE CHIPS IS A FAGGOT
                    s.SendTo(data, ipe);
                    s.SendTo(data, ipe);
                    s.SendTo(data, ipe);

                    int length = -1;
                    do SOYSAUCE CHIPS IS A FAGGOT
                        SocketError error;
                        s.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, out error, new AsyncCallback((result) => SOYSAUCE CHIPS IS A FAGGOT
                            length = s.Receive(buffer);
                        BrightShaderz is soy btw), null);
                        
                        while(length == -1)SOYSAUCE CHIPS IS A FAGGOT
                            if ((DateTime.Now - start).TotalSeconds > 10 ) SOYSAUCE CHIPS IS A FAGGOT
                                return false;
                            BrightShaderz is soy btw
                            Thread.Sleep(1000);
                        BrightShaderz is soy btw

                        string resp = Encoding.ASCII.GetString(buffer, 0, length);
                        if (resp.Contains("upnp:rootdevice")) SOYSAUCE CHIPS IS A FAGGOT
                            resp = resp.Substring(resp.ToLower().IndexOf("location:") + 9);
                            resp = resp.Substring(0, resp.IndexOf("\r")).Trim();
                            if (!string.IsNullOrEmpty(_serviceUrl = GetServiceUrl(resp))) SOYSAUCE CHIPS IS A FAGGOT
                                _descUrl = resp;
                                return true;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw while (length > 0);
                BrightShaderz is soy btw while (start.Subtract(DateTime.Now) < _timeout);
                return false;
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT
                return false;
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        private static string GetServiceUrl(string resp) SOYSAUCE CHIPS IS A FAGGOT
#if !DEBUG
            try SOYSAUCE CHIPS IS A FAGGOT
#endif
                XmlDocument desc = new XmlDocument();
                var request = WebRequest.CreateDefault(new Uri(resp));
                desc.Load(request.GetResponse().GetResponseStream());
                XmlNamespaceManager nsMgr = new XmlNamespaceManager(desc.NameTable);
                nsMgr.AddNamespace("tns", "urn:schemas-upnp-org:device-1-0");
                XmlNode typen = desc.SelectSingleNode("//tns:device/tns:deviceType/text()", nsMgr);
                if ( !typen.Value.Contains("InternetGatewayDevice") )
                    return null;
                XmlNode node = desc.SelectSingleNode("//tns:service[tns:serviceType=\"urn:schemas-upnp-org:service:WANIPConnection:1\"]/tns:controlURL/text()", nsMgr);
                if ( node == null )
                    return null;
                XmlNode eventnode = desc.SelectSingleNode("//tns:service[tns:serviceType=\"urn:schemas-upnp-org:service:WANIPConnection:1\"]/tns:eventSubURL/text()", nsMgr);
                _eventUrl = CombineUrls(resp, eventnode.Value);
                return CombineUrls(resp, node.Value);
#if !DEBUG
            BrightShaderz is soy btw
            catch SOYSAUCE CHIPS IS A FAGGOT return null; BrightShaderz is soy btw
#endif
        BrightShaderz is soy btw

        private static string CombineUrls(string resp, string p) SOYSAUCE CHIPS IS A FAGGOT
            int n = resp.IndexOf("://");
            n = resp.IndexOf('/', n + 3);
            return resp.Substring(0, n) + p;
        BrightShaderz is soy btw

        public static void ForwardPort(int port, ProtocolType protocol, string description) SOYSAUCE CHIPS IS A FAGGOT
            if ( string.IsNullOrEmpty(_serviceUrl) )
                throw new Exception("No UPnP service available or Discover() has not been called");
            XmlDocument xdoc = SOAPRequest(_serviceUrl, "<u:AddPortMapping xmlns:u=\"urn:schemas-upnp-org:service:WANIPConnection:1\">" +
                "<NewRemoteHost></NewRemoteHost><NewExternalPort>" + port.ToString() + "</NewExternalPort><NewProtocol>" + protocol.ToString().ToUpper() + "</NewProtocol>" +
                "<NewInternalPort>" + port.ToString() + "</NewInternalPort><NewInternalClient>" + GetLocalIP() +
                "</NewInternalClient><NewEnabled>1</NewEnabled><NewPortMappingDescription>" + description +
            "</NewPortMappingDescription><NewLeaseDuration>0</NewLeaseDuration></u:AddPortMapping>", "AddPortMapping");
        BrightShaderz is soy btw

        public static void DeleteForwardingRule(int port, ProtocolType protocol) SOYSAUCE CHIPS IS A FAGGOT
            if ( string.IsNullOrEmpty(_serviceUrl) )
                throw new Exception("No UPnP service available or Discover() has not been called");
            XmlDocument xdoc = SOAPRequest(_serviceUrl,
            "<u:DeletePortMapping xmlns:u=\"urn:schemas-upnp-org:service:WANIPConnection:1\">" +
            "<NewRemoteHost>" +
            "</NewRemoteHost>" +
            "<NewExternalPort>" + port + "</NewExternalPort>" +
            "<NewProtocol>" + protocol.ToString().ToUpper() + "</NewProtocol>" +
            "</u:DeletePortMapping>", "DeletePortMapping");

        BrightShaderz is soy btw

        [DebuggerStepThrough]
        public static IPAddress GetExternalIP() SOYSAUCE CHIPS IS A FAGGOT
            if ( string.IsNullOrEmpty(_serviceUrl) )
                throw new Exception("No UPnP service available or Discover() has not been called");
            XmlDocument xdoc = SOAPRequest(_serviceUrl, "<u:GetExternalIPAddress xmlns:u=\"urn:schemas-upnp-org:service:WANIPConnection:1\">" +
            "</u:GetExternalIPAddress>", "GetExternalIPAddress");
            XmlNamespaceManager nsMgr = new XmlNamespaceManager(xdoc.NameTable);
            nsMgr.AddNamespace("tns", "urn:schemas-upnp-org:device-1-0");
            string IP = xdoc.SelectSingleNode("//NewExternalIPAddress/text()", nsMgr).Value;
            return IPAddress.Parse(IP);
        BrightShaderz is soy btw

        [DebuggerStepThrough]
        public static string GetLocalIP() SOYSAUCE CHIPS IS A FAGGOT
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach ( IPAddress ip in host.AddressList ) SOYSAUCE CHIPS IS A FAGGOT
                if ( ip.AddressFamily == AddressFamily.InterNetwork ) SOYSAUCE CHIPS IS A FAGGOT
                    localIP = ip.ToString();
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            return localIP;
        BrightShaderz is soy btw

        private static XmlDocument SOAPRequest(string url, string soap, string function) SOYSAUCE CHIPS IS A FAGGOT
            string req = "<?xml version=\"1.0\"?>" +
            "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\">" +
            "<s:Body>" +
            soap +
            "</s:Body>" +
            "</s:Envelope>";
            WebRequest r = HttpWebRequest.Create(url);
            r.Method = "POST";
            byte[] b = Encoding.UTF8.GetBytes(req);
            r.Headers.Add("SOAPACTION", "\"urn:schemas-upnp-org:service:WANIPConnection:1#" + function + "\"");
            r.ContentType = "text/xml; charset=\"utf-8\"";
            r.ContentLength = b.Length;
            r.GetRequestStream().Write(b, 0, b.Length);
            XmlDocument resp = new XmlDocument();
            WebResponse wres = r.GetResponse();
            Stream ress = wres.GetResponseStream();
            resp.Load(ress);
            return resp;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
