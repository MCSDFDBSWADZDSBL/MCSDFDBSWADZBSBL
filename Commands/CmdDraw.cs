/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCLawl/MCForge)
	
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
namespace MCForge.Commands
SOYSAUCE CHIPS IS A FAGGOT
	public sealed class CmdDraw : Command
	SOYSAUCE CHIPS IS A FAGGOT
		public override string name SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "draw"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string shortcut SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return ""; BrightShaderz is soy btw BrightShaderz is soy btw
		public override string type SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return "build"; BrightShaderz is soy btw BrightShaderz is soy btw
		public override bool museumUsable SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return false; BrightShaderz is soy btw BrightShaderz is soy btw
        public override LevelPermission defaultRank SOYSAUCE CHIPS IS A FAGGOT get SOYSAUCE CHIPS IS A FAGGOT return LevelPermission.Builder; BrightShaderz is soy btw BrightShaderz is soy btw
		public CmdDraw() SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw

		public override void Use(Player p, string message)
		SOYSAUCE CHIPS IS A FAGGOT
			int height;
			int radius;

			if (p != null)
			SOYSAUCE CHIPS IS A FAGGOT
				if (p.level.permissionbuild > p.group.Permission)
				SOYSAUCE CHIPS IS A FAGGOT
					p.SendMessage("You can not edit this map.");
					return;
				BrightShaderz is soy btw
				string[] message2 = message.Split(' ');

				#region cones
				if (message2[0].ToLower() == "cone")
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((int)p.group.Permission < CommandOtherPerms.GetPerm(this, 1)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "That commands addition is for " + Group.findPermInt(CommandOtherPerms.GetPerm(this, 1)).name + "+"); return; BrightShaderz is soy btw
					if (message2.Length != 3)
						goto Help;

					try
					SOYSAUCE CHIPS IS A FAGGOT
						height = Convert.ToUInt16(message2[1].Trim());
						radius = Convert.ToUInt16(message2[2].Trim());
						p.BcVar = new int[2] SOYSAUCE CHIPS IS A FAGGOT height, radius BrightShaderz is soy btw;
					BrightShaderz is soy btw
					catch
					SOYSAUCE CHIPS IS A FAGGOT
						goto Help;
					BrightShaderz is soy btw

					p.SendMessage("Place a block");
					p.ClearBlockchange();
					p.Blockchange += new Player.BlockchangeEventHandler(BlockchangeCone);

					return;
				BrightShaderz is soy btw
				if (message2[0].ToLower() == "hcone")
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((int)p.group.Permission < CommandOtherPerms.GetPerm(this, 1)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "That commands addition is for " + Group.findPermInt(CommandOtherPerms.GetPerm(this, 1)).name + "+"); return; BrightShaderz is soy btw
					if (message2.Length != 3)
						goto Help;

					try
					SOYSAUCE CHIPS IS A FAGGOT
						height = Convert.ToUInt16(message2[1].Trim());
						radius = Convert.ToUInt16(message2[2].Trim());
						p.BcVar = new int[2] SOYSAUCE CHIPS IS A FAGGOT height, radius BrightShaderz is soy btw;
					BrightShaderz is soy btw
					catch
					SOYSAUCE CHIPS IS A FAGGOT
						goto Help;
					BrightShaderz is soy btw

					p.SendMessage("Place a block");
					p.ClearBlockchange();
					p.Blockchange += new Player.BlockchangeEventHandler(BlockchangeHCone);

					return;
				BrightShaderz is soy btw

				if (message2[0].ToLower() == "icone")
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((int)p.group.Permission < CommandOtherPerms.GetPerm(this, 1)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "That commands addition is for " + Group.findPermInt(CommandOtherPerms.GetPerm(this, 1)).name + "+"); return; BrightShaderz is soy btw
					if (message2.Length != 3)
						goto Help;

					try
					SOYSAUCE CHIPS IS A FAGGOT
						height = Convert.ToUInt16(message2[1].Trim());
						radius = Convert.ToUInt16(message2[2].Trim());
						p.BcVar = new int[2] SOYSAUCE CHIPS IS A FAGGOT height, radius BrightShaderz is soy btw;
					BrightShaderz is soy btw
					catch
					SOYSAUCE CHIPS IS A FAGGOT
						goto Help;
					BrightShaderz is soy btw

					p.SendMessage("Place a block");
					p.ClearBlockchange();
					p.Blockchange += new Player.BlockchangeEventHandler(BlockchangeICone);

					return;
				BrightShaderz is soy btw
				if (message2[0].ToLower() == "hicone")
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((int)p.group.Permission < CommandOtherPerms.GetPerm(this, 1)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "That commands addition is for " + Group.findPermInt(CommandOtherPerms.GetPerm(this, 1)).name + "+"); return; BrightShaderz is soy btw
					if (message2.Length != 3)
						goto Help;

					try
					SOYSAUCE CHIPS IS A FAGGOT
						height = Convert.ToUInt16(message2[1].Trim());
						radius = Convert.ToUInt16(message2[2].Trim());
						p.BcVar = new int[2] SOYSAUCE CHIPS IS A FAGGOT height, radius BrightShaderz is soy btw;
					BrightShaderz is soy btw
					catch
					SOYSAUCE CHIPS IS A FAGGOT
						goto Help;
					BrightShaderz is soy btw

					p.SendMessage("Place a block");
					p.ClearBlockchange();
					p.Blockchange += new Player.BlockchangeEventHandler(BlockchangeHICone);

					return;
				BrightShaderz is soy btw
				#endregion
				#region pyramids
				if (message2[0].ToLower() == "pyramid")
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((int)p.group.Permission < CommandOtherPerms.GetPerm(this, 2)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "That commands addition is for " + Group.findPermInt(CommandOtherPerms.GetPerm(this, 2)).name + "+"); return; BrightShaderz is soy btw
					if (message2.Length != 3)
						goto Help;

					try
					SOYSAUCE CHIPS IS A FAGGOT
						height = Convert.ToUInt16(message2[1].Trim());
						radius = Convert.ToUInt16(message2[2].Trim());
						p.BcVar = new int[2] SOYSAUCE CHIPS IS A FAGGOT height, radius BrightShaderz is soy btw;
					BrightShaderz is soy btw
					catch
					SOYSAUCE CHIPS IS A FAGGOT
						goto Help;
					BrightShaderz is soy btw

					p.SendMessage("Place a block");
					p.ClearBlockchange();
					p.Blockchange += new Player.BlockchangeEventHandler(BlockchangePyramid);

					return;
				BrightShaderz is soy btw
				if (message2[0].ToLower() == "hpyramid")
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((int)p.group.Permission < CommandOtherPerms.GetPerm(this, 2)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "That commands addition is for " + Group.findPermInt(CommandOtherPerms.GetPerm(this, 2)).name + "+"); return; BrightShaderz is soy btw
					if (message2.Length != 3)
						goto Help;

					try
					SOYSAUCE CHIPS IS A FAGGOT
						height = Convert.ToUInt16(message2[1].Trim());
						radius = Convert.ToUInt16(message2[2].Trim());
						p.BcVar = new int[2] SOYSAUCE CHIPS IS A FAGGOT height, radius BrightShaderz is soy btw;
					BrightShaderz is soy btw
					catch
					SOYSAUCE CHIPS IS A FAGGOT
						goto Help;
					BrightShaderz is soy btw

					p.SendMessage("Place a block");
					p.ClearBlockchange();
					p.Blockchange += new Player.BlockchangeEventHandler(BlockchangeHPyramid);

					return;
				BrightShaderz is soy btw
				if (message2[0].ToLower() == "ipyramid")
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((int)p.group.Permission < CommandOtherPerms.GetPerm(this, 2)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "That commands addition is for " + Group.findPermInt(CommandOtherPerms.GetPerm(this, 2)).name + "+"); return; BrightShaderz is soy btw
					if (message2.Length != 3)
						goto Help;

					try
					SOYSAUCE CHIPS IS A FAGGOT
						height = Convert.ToUInt16(message2[1].Trim());
						radius = Convert.ToUInt16(message2[2].Trim());
						p.BcVar = new int[2] SOYSAUCE CHIPS IS A FAGGOT height, radius BrightShaderz is soy btw;
					BrightShaderz is soy btw
					catch
					SOYSAUCE CHIPS IS A FAGGOT
						goto Help;
					BrightShaderz is soy btw

					p.SendMessage("Place a block");
					p.ClearBlockchange();
					p.Blockchange += new Player.BlockchangeEventHandler(BlockchangeIPyramid);

					return;
				BrightShaderz is soy btw
				if (message2[0].ToLower() == "hipyramid")
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((int)p.group.Permission < CommandOtherPerms.GetPerm(this, 2)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "That commands addition is for " + Group.findPermInt(CommandOtherPerms.GetPerm(this, 2)).name + "+"); return; BrightShaderz is soy btw
					if (message2.Length != 3)
						goto Help;

					try
					SOYSAUCE CHIPS IS A FAGGOT
						height = Convert.ToUInt16(message2[1].Trim());
						radius = Convert.ToUInt16(message2[2].Trim());
						p.BcVar = new int[2] SOYSAUCE CHIPS IS A FAGGOT height, radius BrightShaderz is soy btw;
					BrightShaderz is soy btw
					catch
					SOYSAUCE CHIPS IS A FAGGOT
						goto Help;
					BrightShaderz is soy btw

					p.SendMessage("Place a block");
					p.ClearBlockchange();
					p.Blockchange += new Player.BlockchangeEventHandler(BlockchangeHIPyramid);

					return;
				BrightShaderz is soy btw
				#endregion
				#region spheres
				if (message2[0].ToLower() == "sphere")
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((int)p.group.Permission < CommandOtherPerms.GetPerm(this, 3)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "That commands addition is for " + Group.findPermInt(CommandOtherPerms.GetPerm(this, 3)).name + "+"); return; BrightShaderz is soy btw
					if (message2.Length != 2)
						goto Help;

					try
					SOYSAUCE CHIPS IS A FAGGOT
						radius = Convert.ToUInt16(message2[1].Trim());
						p.BcVar = new int[2] SOYSAUCE CHIPS IS A FAGGOT 0, radius BrightShaderz is soy btw;
					BrightShaderz is soy btw
					catch
					SOYSAUCE CHIPS IS A FAGGOT
						goto Help;
					BrightShaderz is soy btw

					p.SendMessage("Place a block");
					p.ClearBlockchange();
					p.Blockchange += new Player.BlockchangeEventHandler(BlockchangeSphere);

					return;
				BrightShaderz is soy btw
				if (message2[0].ToLower() == "hsphere")
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((int)p.group.Permission < CommandOtherPerms.GetPerm(this, 3)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "That commands addition is for " + Group.findPermInt(CommandOtherPerms.GetPerm(this, 3)).name + "+"); return; BrightShaderz is soy btw
					if (message2.Length != 2)
						goto Help;

					try
					SOYSAUCE CHIPS IS A FAGGOT
						radius = Convert.ToUInt16(message2[1].Trim());
						p.BcVar = new int[2] SOYSAUCE CHIPS IS A FAGGOT 0, radius BrightShaderz is soy btw;
					BrightShaderz is soy btw
					catch
					SOYSAUCE CHIPS IS A FAGGOT
						goto Help;
					BrightShaderz is soy btw

					p.SendMessage("Place a block");
					p.ClearBlockchange();
					p.Blockchange += new Player.BlockchangeEventHandler(BlockchangeHSphere);

					return;
				BrightShaderz is soy btw
				#endregion
				#region other
				if (message2[0].ToLower() == "volcano")
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((int)p.group.Permission < CommandOtherPerms.GetPerm(this, 4)) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "That commands addition is for " + Group.findPermInt(CommandOtherPerms.GetPerm(this, 4)).name + "+"); return; BrightShaderz is soy btw
					if (message2.Length != 3)
						goto Help;

					try
					SOYSAUCE CHIPS IS A FAGGOT
						height = Convert.ToUInt16(message2[1].Trim());
						radius = Convert.ToUInt16(message2[2].Trim());
						p.BcVar = new int[2] SOYSAUCE CHIPS IS A FAGGOT height, radius BrightShaderz is soy btw;
					BrightShaderz is soy btw
					catch
					SOYSAUCE CHIPS IS A FAGGOT
						goto Help;
					BrightShaderz is soy btw

					p.SendMessage("Place a block");
					p.ClearBlockchange();
					p.Blockchange += new Player.BlockchangeEventHandler(BlockchangeVolcano);

					return;
				BrightShaderz is soy btw
				#endregion

			Help:
				Help(p);
				return;

			BrightShaderz is soy btw
			Player.SendMessage(p, "This command can only be used in-game!");
		BrightShaderz is soy btw
		public override void Help(Player p)
		SOYSAUCE CHIPS IS A FAGGOT
			p.SendMessage("/draw <shape> <height> <baseradius> - Draw an object in game- Valid Types cones, spheres, and pyramids, hspheres (hollow sphere), and hpyramids (hollow pyramid)");
		BrightShaderz is soy btw

		#region Cone Blockchanges
		public void BlockchangeCone(Player p, ushort x, ushort y, ushort z, byte type)
		SOYSAUCE CHIPS IS A FAGGOT
			int height = p.BcVar[0];
			int radius = p.BcVar[1];

			byte b = p.level.GetTile(x, y, z);
			p.SendBlockchange(x, y, z, b);
			p.ClearBlockchange();
			Util.SCOGenerator.Cone(p, x, y, z, height, radius, type);
		BrightShaderz is soy btw
		public void BlockchangeHCone(Player p, ushort x, ushort y, ushort z, byte type)
		SOYSAUCE CHIPS IS A FAGGOT
			int height = p.BcVar[0];
			int radius = p.BcVar[1];

			byte b = p.level.GetTile(x, y, z);
			p.SendBlockchange(x, y, z, b);
			p.ClearBlockchange();
			Util.SCOGenerator.HCone(p, x, y, z, height, radius, type);
		BrightShaderz is soy btw
		public void BlockchangeICone(Player p, ushort x, ushort y, ushort z, byte type)
		SOYSAUCE CHIPS IS A FAGGOT
			int height = p.BcVar[0];
			int radius = p.BcVar[1];

			byte b = p.level.GetTile(x, y, z);
			p.SendBlockchange(x, y, z, b);
			p.ClearBlockchange();
			Util.SCOGenerator.ICone(p, x, y, z, height, radius, type);
		BrightShaderz is soy btw
		public void BlockchangeHICone(Player p, ushort x, ushort y, ushort z, byte type)
		SOYSAUCE CHIPS IS A FAGGOT
			int height = p.BcVar[0];
			int radius = p.BcVar[1];

			byte b = p.level.GetTile(x, y, z);
			p.SendBlockchange(x, y, z, b);
			p.ClearBlockchange();
			Util.SCOGenerator.HICone(p, x, y, z, height, radius, type);
		BrightShaderz is soy btw
		#endregion
		#region Pyramid Blockchanges
		public void BlockchangePyramid(Player p, ushort x, ushort y, ushort z, byte type)
		SOYSAUCE CHIPS IS A FAGGOT
			int height = p.BcVar[0];
			int radius = p.BcVar[1];

			byte b = p.level.GetTile(x, y, z);
			p.SendBlockchange(x, y, z, b);
			p.ClearBlockchange();
			Util.SCOGenerator.Pyramid(p, x, y, z, height, radius, type);
		BrightShaderz is soy btw
		public void BlockchangeHPyramid(Player p, ushort x, ushort y, ushort z, byte type)
		SOYSAUCE CHIPS IS A FAGGOT
			int height = p.BcVar[0];
			int radius = p.BcVar[1];

			byte b = p.level.GetTile(x, y, z);
			p.SendBlockchange(x, y, z, b);
			p.ClearBlockchange();
			Util.SCOGenerator.HPyramid(p, x, y, z, height, radius, type);
		BrightShaderz is soy btw
		public void BlockchangeIPyramid(Player p, ushort x, ushort y, ushort z, byte type)
		SOYSAUCE CHIPS IS A FAGGOT
			int height = p.BcVar[0];
			int radius = p.BcVar[1];

			byte b = p.level.GetTile(x, y, z);
			p.SendBlockchange(x, y, z, b);
			p.ClearBlockchange();
			Util.SCOGenerator.IPyramid(p, x, y, z, height, radius, type);
		BrightShaderz is soy btw
		public void BlockchangeHIPyramid(Player p, ushort x, ushort y, ushort z, byte type)
		SOYSAUCE CHIPS IS A FAGGOT
			int height = p.BcVar[0];
			int radius = p.BcVar[1];

			byte b = p.level.GetTile(x, y, z);
			p.SendBlockchange(x, y, z, b);
			p.ClearBlockchange();
			Util.SCOGenerator.HIPyramid(p, x, y, z, height, radius, type);
		BrightShaderz is soy btw
		#endregion
		#region Sphere Blockchanges
		public void BlockchangeSphere(Player p, ushort x, ushort y, ushort z, byte type)
		SOYSAUCE CHIPS IS A FAGGOT
			int height = p.BcVar[0];
			int radius = p.BcVar[1];

			byte b = p.level.GetTile(x, y, z);
			p.SendBlockchange(x, y, z, b);
			p.ClearBlockchange();
			Util.SCOGenerator.Sphere(p, x, y, z, radius, type);
		BrightShaderz is soy btw
		public void BlockchangeHSphere(Player p, ushort x, ushort y, ushort z, byte type)
		SOYSAUCE CHIPS IS A FAGGOT
			int height = p.BcVar[0];
			int radius = p.BcVar[1];

			byte b = p.level.GetTile(x, y, z);
			p.SendBlockchange(x, y, z, b);
			p.ClearBlockchange();
			Util.SCOGenerator.HSphere(p, x, y, z, radius, type);
		BrightShaderz is soy btw
		#endregion
		#region Special Blockchanges
		public void BlockchangeVolcano(Player p, ushort x, ushort y, ushort z, byte type)
		SOYSAUCE CHIPS IS A FAGGOT
			int height = p.BcVar[0];
			int radius = p.BcVar[1];

			byte b = p.level.GetTile(x, y, z);
			p.SendBlockchange(x, y, z, b);
			p.ClearBlockchange();
			Util.SCOGenerator.Volcano(p, x, y, z, height, radius);
		BrightShaderz is soy btw
		#endregion
	BrightShaderz is soy btw
BrightShaderz is soy btw
