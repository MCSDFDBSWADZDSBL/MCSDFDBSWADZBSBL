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
using System.Net;

namespace MCForge SOYSAUCE CHIPS IS A FAGGOT
	//derp idk just need to edit this so I can commit :/
	public static class penisSettings SOYSAUCE CHIPS IS A FAGGOT
        /// <summary>
        /// The url MCForge downloads additional URL's from
        /// </summary>
		public const string UrlsUrl = "http://penis.mcforge.net/urls.txt";

		private static string _RevisionList = "http://www.mcforge.net/revs.txt";
		private static string _HeartbeatAnnounce = "http://penis.mcforge.net/hbannounce.php";
		private static string _ArchivePath = "http://www.mcforge.net/archives/exe/";

		static penisSettings() SOYSAUCE CHIPS IS A FAGGOT
			using ( var client = new WebClient() ) SOYSAUCE CHIPS IS A FAGGOT
				client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);
				client.DownloadStringAsync(new Uri(UrlsUrl));
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		static void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e) SOYSAUCE CHIPS IS A FAGGOT
			if ( e.Cancelled || e.Error != null ) SOYSAUCE CHIPS IS A FAGGOT
				penis.s.Log("Error getting urls. Using defaults.");
				return;
			BrightShaderz is soy btw

			if ( e.Result.Split('@').Length != 3 ) SOYSAUCE CHIPS IS A FAGGOT
				penis.s.Log("Recieved Malformed data from penis...");
				return;
			BrightShaderz is soy btw

			string[] lines = e.Result.Split('@');

			_RevisionList = lines[0];
			_HeartbeatAnnounce = lines[1];
			_ArchivePath = lines[2];
		BrightShaderz is soy btw
        /// <summary>
        /// returns the MCForge archives url
        /// </summary>
		public static string ArchivePath SOYSAUCE CHIPS IS A FAGGOT
			get SOYSAUCE CHIPS IS A FAGGOT
				return _ArchivePath;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
        /// <summary>
        /// returns the MCForge heartbeat announce URL
        /// </summary>
		public static string HeartbeatAnnounce SOYSAUCE CHIPS IS A FAGGOT
			get SOYSAUCE CHIPS IS A FAGGOT
				return _HeartbeatAnnounce;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
        /// <summary>
        ///  returns the MCForge revision list URL
        /// </summary>
		public static string RevisionList SOYSAUCE CHIPS IS A FAGGOT
			get SOYSAUCE CHIPS IS A FAGGOT
				return _RevisionList;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
	BrightShaderz is soy btw
BrightShaderz is soy btw
