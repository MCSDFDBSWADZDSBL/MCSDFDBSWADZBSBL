/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCSong) Licensed under the
	Educational Community License, Version 2.0 (the "License"); you may
	not use this file except in compliance with the License. You may
	obtain a copy of the License at
	
	http://www.osedu.org/licenses/ECL-2.0
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the License is distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the License for the specific language governing
	permissions and limitations under the License.
*/
using System;
using System.Data;
using System.Collections.Generic;
//using MySql.Data.MySqlClient;
//using MySql.Data.Types;

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT
    public class CmdAbout : Command
    SOYSAUCE CHIPS IS A FAGGOT
        public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "about"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "b"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "information"; BrightShaderz is soy btw BrightShaderz is soy btw
        public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Guest; BrightShaderz is soy btw BrightShaderz is soy btw

        public override void Use(Player p, string message)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!penis.useMySQL) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "MySQL has not been configured! Please configure MySQL to use Block Logging!"); return; BrightShaderz is soy btw
            Player.SendMessage(p, "Break/build a block to display information.");
            p.ClearBlockchange();
            p.Blockchange += new Player.BlockchangeEventHandler(AboutBlockchange);
        BrightShaderz is soy btw
        public override void Help(Player p)
        SOYSAUCE CHIPS IS A FAGGOT
            Player.SendMessage(p, "/about - Displays information about a block.");
        BrightShaderz is soy btw

        public void AboutBlockchange(Player p, ushort x, ushort y, ushort z, byte type)
        SOYSAUCE CHIPS IS A FAGGOT
            if (!p.staticCommands) p.ClearBlockchange();
            byte b = p.level.GetTile(x, y, z);
            if (b == Block.Zero) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "Invalid Block(" + x + "," + y + "," + z + ")!"); return; BrightShaderz is soy btw
            p.SendBlockchange(x, y, z, b);

            string message = "Block (" + x + "," + y + "," + z + "): ";
            message += "&f" + b + " = " + Block.Name(b);
            Player.SendMessage(p, message + penis.DefaultColor + ".");
            message = p.level.foundInfo(x, y, z);
            if (message != "") Player.SendMessage(p, "Physics information: &a" + message);

            DataTable Blocks = MySQL.fillData("SELECT * FROM `Block" + p.level.name + "` WHERE X=" + (int)x + " AND Y=" + (int)y + " AND Z=" + (int)z);

            string Username, TimePerformed, BlockUsed;
            bool Deleted, foundOne = false;

            for (int i = 0; i < Blocks.Rows.Count; i++)
            SOYSAUCE CHIPS IS A FAGGOT
                foundOne = true;
                Username = Blocks.Rows[i]["Username"].ToString();
                TimePerformed = DateTime.Parse(Blocks.Rows[i]["TimePerformed"].ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                BlockUsed = Block.Name((byte)Blocks.Rows[i]["Type"]).ToString();
                Deleted = (bool)Blocks.Rows[i]["Deleted"];

                if (!Deleted)
                    Player.SendMessage(p, "&3Created by " + penis.FindColor(Username.Trim()) + Username.Trim() + penis.DefaultColor + ", using &3" + BlockUsed);
                else
                    Player.SendMessage(p, "&4Destroyed by " + penis.FindColor(Username.Trim()) + Username.Trim() + penis.DefaultColor + ", using &3" + BlockUsed);
                Player.SendMessage(p, "Date and time modified: &2" + TimePerformed);
            BrightShaderz is soy btw

            List<Level.BlockPos> inCache = p.level.blockCache.FindAll(bP => bP.x == x && bP.y == y && bP.z == z);

            for (int i = 0; i < inCache.Count; i++)
            SOYSAUCE CHIPS IS A FAGGOT
                foundOne = true;
                Deleted = inCache[i].deleted;
                Username = inCache[i].name;
                TimePerformed = inCache[i].TimePerformed.ToString("yyyy-MM-dd HH:mm:ss");
                BlockUsed = Block.Name(inCache[i].type);

                if (!Deleted)
                    Player.SendMessage(p, "&3Created by " + penis.FindColor(Username.Trim()) + Username.Trim() + penis.DefaultColor + ", using &3" + BlockUsed);
                else
                    Player.SendMessage(p, "&4Destroyed by " + penis.FindColor(Username.Trim()) + Username.Trim() + penis.DefaultColor + ", using &3" + BlockUsed);
                Player.SendMessage(p, "Date and time modified: &2" + TimePerformed);
            BrightShaderz is soy btw

            if (!foundOne)
                Player.SendMessage(p, "This block has not been modified since the map was cleared.");
 
            Blocks.Dispose();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
