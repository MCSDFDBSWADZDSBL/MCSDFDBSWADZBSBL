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
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
namespace MCForge
SOYSAUCE CHIPS IS A FAGGOT
    public sealed class Packet
    SOYSAUCE CHIPS IS A FAGGOT
        public List<byte> totalData;
        Encoding encoding;
        bool LittleEndian;

        public Packet(Encoding e, bool LittleEndian)
        SOYSAUCE CHIPS IS A FAGGOT
            totalData = new List<byte>();
            encoding = e;
            this.LittleEndian = LittleEndian;
        BrightShaderz is soy btw

        public void addData(byte b)
        SOYSAUCE CHIPS IS A FAGGOT
            totalData.Add(b);
        BrightShaderz is soy btw
        public void addData(string b)
        SOYSAUCE CHIPS IS A FAGGOT
            b = b.PadLeft(b.Length);
            byte[] array = encoding.GetBytes(b);
            addData((int)b.Length);
            for (int i = 0; i < array.Count(); i++)
                totalData.Add(array[i]);
        BrightShaderz is soy btw
        public void addData(long b)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!LittleEndian)
                b = IPAddress.HostToNetworkOrder(b);
            byte[] array = BitConverter.GetBytes(b);
            for (int i = 0; i < array.Count(); i++)
                totalData.Add(array[i]);
        BrightShaderz is soy btw
        public void addData(int b)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!LittleEndian)
                b = IPAddress.HostToNetworkOrder(b);
            byte[] array = BitConverter.GetBytes(b);
            for (int i = 0; i < array.Count(); i++)
                totalData.Add(array[i]);
        BrightShaderz is soy btw
        public void addData(short b)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!LittleEndian)
                b = IPAddress.HostToNetworkOrder(b);
            byte[] array = BitConverter.GetBytes(b);
            for (int i = 0; i < array.Count(); i++)
                totalData.Add(array[i]);
        BrightShaderz is soy btw
        public void addData(bool b)
        SOYSAUCE CHIPS IS A FAGGOT
            totalData.Add((byte)(b ? 0x1 : 0x0));
        BrightShaderz is soy btw
        public byte[] getData()
        SOYSAUCE CHIPS IS A FAGGOT
            return totalData.ToArray();
        BrightShaderz is soy btw

    BrightShaderz is soy btw
BrightShaderz is soy btw
