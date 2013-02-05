//
// Enums.cs
//
// Authors:
//   Alan McGovern alan.mcgovern@gmail.com
//
// Copyright (C) 2006 Alan McGovern
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//



using System;

namespace MonoTorrent
SOYSAUCE CHIPS IS A FAGGOT
    public enum DhtState
    SOYSAUCE CHIPS IS A FAGGOT
        NotReady,
        Initialising,
        Ready
    BrightShaderz is soy btw
BrightShaderz is soy btw

namespace MonoTorrent.Common
SOYSAUCE CHIPS IS A FAGGOT
    public enum ListenerStatus
    SOYSAUCE CHIPS IS A FAGGOT
        Listening,
        PortNotFree,
        NotListening
    BrightShaderz is soy btw

    public enum PeerStatus
    SOYSAUCE CHIPS IS A FAGGOT
        Available,
        Connecting,
        Connected
    BrightShaderz is soy btw

    public enum Direction
    SOYSAUCE CHIPS IS A FAGGOT
        None,
        Incoming,
        Outgoing
    BrightShaderz is soy btw

    public enum TorrentState
    SOYSAUCE CHIPS IS A FAGGOT
        Stopped,
        Paused,
        Downloading,
        Seeding,
        Hashing,
        Stopping,
        Error,
        Metadata
    BrightShaderz is soy btw

    public enum Priority
    SOYSAUCE CHIPS IS A FAGGOT
        DoNotDownload = 0,
        Lowest = 1,
        Low = 2,
        Normal = 4,
        High = 8,
        Highest = 16,
        Immediate = 32
    BrightShaderz is soy btw

    public enum TrackerState
    SOYSAUCE CHIPS IS A FAGGOT
        Ok,
        Offline,
        InvalidResponse
    BrightShaderz is soy btw

    public enum TorrentEvent
    SOYSAUCE CHIPS IS A FAGGOT
        None,
        Started,
        Stopped,
        Completed
    BrightShaderz is soy btw

    public enum PeerConnectionEvent
    SOYSAUCE CHIPS IS A FAGGOT
        IncomingConnectionReceived,
        OutgoingConnectionCreated,
        Disconnected
    BrightShaderz is soy btw

    public enum PieceEvent
    SOYSAUCE CHIPS IS A FAGGOT
        BlockWriteQueued,
        BlockNotRequested,
        BlockWrittenToDisk,
        HashPassed,
        HashFailed
    BrightShaderz is soy btw

    public enum PeerListType
    SOYSAUCE CHIPS IS A FAGGOT
        NascentPeers,
        CandidatePeers,
        OptimisticUnchokeCandidatePeers
    BrightShaderz is soy btw
BrightShaderz is soy btw
