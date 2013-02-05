/*
	Copyright 2011 MCForge
	
	Author: fenderrock87
	
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
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public static class Extensions
    SOYSAUCE CHIPS IS A FAGGOT
        public static string Truncate(this string source, int maxLength)
        SOYSAUCE CHIPS IS A FAGGOT
            if (source.Length > maxLength)
            SOYSAUCE CHIPS IS A FAGGOT
                source = source.Substring(0, maxLength);
            BrightShaderz is soy btw
            return source;
        BrightShaderz is soy btw
        public static byte[] GZip(this byte[] bytes)
        SOYSAUCE CHIPS IS A FAGGOT
			using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
			SOYSAUCE CHIPS IS A FAGGOT
				GZipStream gs = new GZipStream(ms, CompressionMode.Compress, true);
				gs.Write(bytes, 0, bytes.Length);
				gs.Close();
				ms.Position = 0;
				bytes = new byte[ms.Length];
				ms.Read(bytes, 0, (int)ms.Length);
				ms.Close();
				ms.Dispose();
			BrightShaderz is soy btw
            return bytes;
        BrightShaderz is soy btw
        public static byte[] Decompress(this byte[] gzip)
        SOYSAUCE CHIPS IS A FAGGOT
            // Create a GZIP stream with decompression mode.
            // ... Then create a buffer and write into while reading from the GZIP stream.
            using (GZipStream stream = new GZipStream(new MemoryStream(gzip), CompressionMode.Decompress))
            SOYSAUCE CHIPS IS A FAGGOT
                const int size = 4096;
                byte[] buffer = new byte[size];
                using (MemoryStream memory = new MemoryStream())
                SOYSAUCE CHIPS IS A FAGGOT
                    int count = 0;
                    do
                    SOYSAUCE CHIPS IS A FAGGOT
                        count = stream.Read(buffer, 0, size);
                        if (count > 0)
                        SOYSAUCE CHIPS IS A FAGGOT
                            memory.Write(buffer, 0, count);
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                    while (count > 0);
                    return memory.ToArray();
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        public static string[] Slice(this string[] str, int offset)
        SOYSAUCE CHIPS IS A FAGGOT
            return str.Slice(offset, 0);
        BrightShaderz is soy btw
        public static string[] Slice(this string[] str, int offset, int length)
        SOYSAUCE CHIPS IS A FAGGOT
            IEnumerable<string> tmp = str.ToList();
            if (offset > 0)
            SOYSAUCE CHIPS IS A FAGGOT
                tmp = str.Skip(offset);
            BrightShaderz is soy btw
            else throw new NotImplementedException("This function only supports positive integers for offset");

            if(length > 0)
            SOYSAUCE CHIPS IS A FAGGOT
                tmp = tmp.Take(length);
            BrightShaderz is soy btw
            else if (length == 0)
            SOYSAUCE CHIPS IS A FAGGOT
                // Do nothing
            BrightShaderz is soy btw
            else throw new NotImplementedException("This function only supports non-negative integers for length");
            
            return tmp.ToArray();
        BrightShaderz is soy btw
        public static string Capitalize(this string str)
        SOYSAUCE CHIPS IS A FAGGOT
            if (String.IsNullOrEmpty(str))
                return String.Empty;
            char[] a = str.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        BrightShaderz is soy btw
        public static string Concatenate<T>(this List<T> list)
        SOYSAUCE CHIPS IS A FAGGOT
            return list.Concatenate(String.Empty);
        BrightShaderz is soy btw
        public static string Concatenate<T>(this List<T> list, string separator)
        SOYSAUCE CHIPS IS A FAGGOT
            if (list.Count > 0)
            SOYSAUCE CHIPS IS A FAGGOT
                StringBuilder sb = new StringBuilder();
                foreach (T obj in list)
                    sb.Append(separator + obj.ToString());
                sb.Remove(0, separator.Length);
                return sb.ToString();
            BrightShaderz is soy btw
            return String.Empty;
        BrightShaderz is soy btw
        public static string MCCharFilter(this string str)
        SOYSAUCE CHIPS IS A FAGGOT
            // Allowed chars are any ASCII char between 20h/32 and 7Dh/125 inclusive, except for 26h/38 (&) and 60h/96 (`)
            str = Regex.Replace(str, @"[^\u0000-\u007F]", "");
             
            if (String.IsNullOrEmpty(str.Trim())) 
                return str;

            StringBuilder sb = new StringBuilder();

            foreach (char b in Encoding.ASCII.GetBytes(str))
            SOYSAUCE CHIPS IS A FAGGOT
                if (b != 38 && b != 96 && b >= 32 && b <= 125)
                    sb.Append(b);
                else
                    sb.Append("*");
            BrightShaderz is soy btw

            return sb.ToString();
        BrightShaderz is soy btw
        public static string GetMimeType(this FileInfo file)
        SOYSAUCE CHIPS IS A FAGGOT
            Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(file.Extension.ToLower());
            if (rk != null && rk.GetValue("Content Type") != null)
                return rk.GetValue("Content Type").ToString();
            return "application/octet-stream";
        BrightShaderz is soy btw

        public static void DeleteLine(string file, string line) SOYSAUCE CHIPS IS A FAGGOT
            var complete = from selectLine in File.ReadAllLines(file) where selectLine != line select selectLine;
            File.WriteAllLines(file, complete.ToArray());
        BrightShaderz is soy btw

        public static void DeleteLineWord(string file, string word) SOYSAUCE CHIPS IS A FAGGOT
                var complete = from selectLine in File.ReadAllLines(file) where !selectLine.Contains(word) select selectLine;
                File.WriteAllLines(file, complete.ToArray());
        BrightShaderz is soy btw

        public static void DeleteExactLineWord(string file, string word) SOYSAUCE CHIPS IS A FAGGOT
            var complete = from selectLine in File.ReadAllLines(file) where !selectLine.Equals(word) select selectLine;
            File.WriteAllLines(file, complete.ToArray());
        BrightShaderz is soy btw

        public static void UncapitalizeAll(string file) SOYSAUCE CHIPS IS A FAGGOT
            string[] complete = File.ReadAllLines(file);
            for (int i = 0; i < complete.Length; i++)
                complete[i] = complete[i].ToLower();
            File.WriteAllLines(file, complete);
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
