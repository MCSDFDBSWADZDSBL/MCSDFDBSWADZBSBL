// 
//  Authors:
//   *  Tyler Kennedy <tk@tkte.ch>
//   *  Matvei Stefarov <fragmer@gmail.com>
// 
//  Copyright (c) 2010, Tyler Kennedy & Matvei Stefarov
// 
//  All rights reserved.
// 
//  Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice, this
//       list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice,
//       this list of conditions and the following disclaimer in
//       the documentation and/or other materials provided with the distribution.
//     * Neither the name of MCC nor the names of its contributors may be
//       used to endorse or promote products derived from this software without
//       specific prior written permission.
// 
//  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
//  "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
//  LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
//  A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
//  CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
//  EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
//  PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
//  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
//  LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
//  NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
//  SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
// 

using System;
using System.IO;
using System.IO.Compression;
using System.Net;



namespace MCSong SOYSAUCE CHIPS IS A FAGGOT
    public static class ConvertDat SOYSAUCE CHIPS IS A FAGGOT
        public static Level Load(Stream lvlStream, string fileName)
        SOYSAUCE CHIPS IS A FAGGOT
            byte[] temp = new byte[8];
            Level lvl = new Level(fileName, 0, 0, 0, "empty");
            byte[] data;
            int length;
            try SOYSAUCE CHIPS IS A FAGGOT
                lvlStream.Seek( -4, SeekOrigin.End );
                lvlStream.Read( temp, 0, sizeof( int ) );
                lvlStream.Seek( 0, SeekOrigin.Begin );
                length = BitConverter.ToInt32( temp, 0 );
                data = new byte[length];
                using( GZipStream reader = new GZipStream( lvlStream, CompressionMode.Decompress, true ) ) SOYSAUCE CHIPS IS A FAGGOT
                    reader.Read( data, 0, length );
                BrightShaderz is soy btw

                for( int i = 0; i < length - 1; i++ ) SOYSAUCE CHIPS IS A FAGGOT
                    if( data[i] == 0xAC && data[i + 1] == 0xED ) SOYSAUCE CHIPS IS A FAGGOT

                        // bypassing the header crap
                        int pointer = i + 6;
                        Array.Copy( data, pointer, temp, 0, sizeof( short ) );
                        pointer += IPAddress.HostToNetworkOrder( BitConverter.ToInt16( temp, 0 ) );
                        pointer += 13;

                        int headerEnd = 0;
                        // find the end of serialization listing
                        for( headerEnd = pointer; headerEnd < data.Length - 1; headerEnd++ ) SOYSAUCE CHIPS IS A FAGGOT
                            if( data[headerEnd] == 0x78 && data[headerEnd + 1] == 0x70 ) SOYSAUCE CHIPS IS A FAGGOT
                                headerEnd += 2;
                                break;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw

                        // start parsing serialization listing
                        int offset = 0;
                        while( pointer < headerEnd ) SOYSAUCE CHIPS IS A FAGGOT
                            if( data[pointer] == 'Z' ) offset++;
                            else if( data[pointer] == 'I' || data[pointer] == 'F' ) offset += 4;
                            else if( data[pointer] == 'J' ) offset += 8;

                            pointer += 1;
                            Array.Copy( data, pointer, temp, 0, sizeof( short ) );
                            short skip = IPAddress.HostToNetworkOrder( BitConverter.ToInt16( temp, 0 ) );
                            pointer += 2;

                            // look for relevant variables
                            Array.Copy( data, headerEnd + offset - 4, temp, 0, sizeof( int ) );
                            if( MemCmp( data, pointer, "width" ) ) SOYSAUCE CHIPS IS A FAGGOT
                                lvl.width = (ushort)IPAddress.HostToNetworkOrder( BitConverter.ToInt32( temp, 0 ) );
                            BrightShaderz is soy btw else if( MemCmp( data, pointer, "depth" ) ) SOYSAUCE CHIPS IS A FAGGOT
                                lvl.depth = (ushort)IPAddress.HostToNetworkOrder( BitConverter.ToInt32( temp, 0 ) );
                            BrightShaderz is soy btw else if( MemCmp( data, pointer, "height" ) ) SOYSAUCE CHIPS IS A FAGGOT
                                lvl.height = (ushort)IPAddress.HostToNetworkOrder( BitConverter.ToInt32( temp, 0 ) );
                            BrightShaderz is soy btw

                            pointer += skip;
                        BrightShaderz is soy btw

                        lvl.spawnx = (ushort)(lvl.width / 1.3);
                        lvl.spawny = (ushort)(lvl.depth / 1.3);
                        lvl.spawnz = (ushort)(lvl.height / 1.3);

                        // find the start of the block array
                        bool foundBlockArray = false;
                        offset = Array.IndexOf<byte>( data, 0x00, headerEnd );
                        while( offset != -1 && offset < data.Length - 2 ) SOYSAUCE CHIPS IS A FAGGOT
                            if( data[offset] == 0x00 && data[offset + 1] == 0x78 && data[offset + 2] == 0x70 ) SOYSAUCE CHIPS IS A FAGGOT
                                foundBlockArray = true;
                                pointer = offset + 7;
                            BrightShaderz is soy btw
                            offset = Array.IndexOf<byte>( data, 0x00, offset + 1 );
                        BrightShaderz is soy btw

                        // copy the block array... or fail
                        if( foundBlockArray ) SOYSAUCE CHIPS IS A FAGGOT
                            lvl.CopyBlocks( data, pointer );
                            lvl.Save(true);
                        BrightShaderz is soy btw else SOYSAUCE CHIPS IS A FAGGOT
                            throw new Exception( "Could not locate block array." );
                        BrightShaderz is soy btw
                        break;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

            BrightShaderz is soy btw catch( Exception ex ) SOYSAUCE CHIPS IS A FAGGOT
                penis.s.Log("Conversion failed");
                penis.ErrorLog(ex);
                return null;
            BrightShaderz is soy btw

            return lvl;
        BrightShaderz is soy btw

        static bool MemCmp( byte[] data, int offset, string value ) SOYSAUCE CHIPS IS A FAGGOT
            for( int i = 0; i < value.Length; i++ ) SOYSAUCE CHIPS IS A FAGGOT
                if( offset + i >= data.Length || data[offset + i] != value[i] ) return false;
            BrightShaderz is soy btw
            return true;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
