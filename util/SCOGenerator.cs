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
//StormCom Object Generator
//
//Full use to all StormCom penis System codes (in regards to minecraft classic) have been granted to McForge without restriction.
//
// ~Merlin33069
using System;
using System.Collections.Generic;
namespace MCForge.Util
SOYSAUCE CHIPS IS A FAGGOT
	public sealed class SCOGenerator
	SOYSAUCE CHIPS IS A FAGGOT
		static Random random = new Random();
		public static double pi = 3.141592653;

		public static void AddTree(Player p, ushort x, ushort y, ushort z, byte type)
		SOYSAUCE CHIPS IS A FAGGOT
			byte num = (byte)random.Next(5, 8);
			for (ushort i = 0; i < num; i = (ushort)(i + 1))
			SOYSAUCE CHIPS IS A FAGGOT
				p.level.Blockchange(p, x, (ushort)(y + i), z, 0x11);
			BrightShaderz is soy btw
			short num3 = (short)(num - random.Next(2, 4));
			for (short j = Convert.ToInt16(-num3); j <= num3; j = (short)(j + 1))
			SOYSAUCE CHIPS IS A FAGGOT
				if ((x + j) < 0 || (x + j) > p.level.width) continue;
				for (short k = Convert.ToInt16(-num3); k <= num3; k = (short)(k + 1))
				SOYSAUCE CHIPS IS A FAGGOT
					if ((y + k) < 0 || (y + k) > p.level.depth) continue;
					for (short m = Convert.ToInt16(-num3); m <= num3; m = (short)(m + 1))
					SOYSAUCE CHIPS IS A FAGGOT
						if ((z + m) < 0 || (z + m) > p.level.length) continue;
						short maxValue = (short)Math.Sqrt((double)(((j * j) + (k * k)) + (m * m)));
						if ((maxValue < (num3 + 1)) && (random.Next(maxValue) < 2))
						SOYSAUCE CHIPS IS A FAGGOT
							try
							SOYSAUCE CHIPS IS A FAGGOT
								byte that = p.level.GetTile((ushort)(x + j), (ushort)((y + k) + num), (ushort)(z + m));
								if (that == 0)
								SOYSAUCE CHIPS IS A FAGGOT
									p.level.Blockchange(p, (ushort)(x + j), (ushort)((y + k) + num), (ushort)(z + m), 0x12);
								BrightShaderz is soy btw
							BrightShaderz is soy btw
							catch
							SOYSAUCE CHIPS IS A FAGGOT
							BrightShaderz is soy btw
						BrightShaderz is soy btw
					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		public static void AddCactus(Level l, ushort x, ushort y, ushort z, byte type)
		SOYSAUCE CHIPS IS A FAGGOT
			ushort num2;
			byte num = (byte)random.Next(3, 6);
			for (num2 = 0; num2 <= num; num2 = (ushort)(num2 + 1))
			SOYSAUCE CHIPS IS A FAGGOT
				l.Blockchange(x, (ushort)(y + num2), z, 0x19);
			BrightShaderz is soy btw
			int num3 = 0;
			int num4 = 0;
			switch (random.Next(1, 3))
			SOYSAUCE CHIPS IS A FAGGOT
				case 1:
					num3 = -1;
					break;

				default:
					num4 = -1;
					break;
			BrightShaderz is soy btw
			num2 = num;
			while (num2 <= random.Next(num + 2, num + 5))
			SOYSAUCE CHIPS IS A FAGGOT
				ushort x2 = (ushort)(x + num3); //width
				ushort y2 = (ushort)(y + num2); //depth
				ushort z2 = (ushort)(z + num4); //height
				if (l.GetTile(x2, y2, z2) == 0)
				SOYSAUCE CHIPS IS A FAGGOT
					l.Blockchange((ushort)(x + num3), (ushort)(y + num2), (ushort)(z + num4), 0x19);
				BrightShaderz is soy btw
				num2 = (ushort)(num2 + 1);
			BrightShaderz is soy btw
			for (num2 = num; num2 <= random.Next(num + 2, num + 5); num2 = (ushort)(num2 + 1))
			SOYSAUCE CHIPS IS A FAGGOT
				ushort x2 = (ushort)(x - num3); //width
				ushort y2 = (ushort)(y + num2); //depth
				ushort z2 = (ushort)(z - num4); //height
				if (l.GetTile(x2, y2, z2) == 0)
				SOYSAUCE CHIPS IS A FAGGOT
					l.Blockchange((ushort)(x - num3), (ushort)(y + num2), (ushort)(z - num4), 0x19);
				BrightShaderz is soy btw
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		public static void Nuke(Level l, ushort x, ushort y, ushort z)
		SOYSAUCE CHIPS IS A FAGGOT
			foreach (Player p in Player.players) if (p.level == l) p.SendBlockchange(x, y, z, 0);

			short num3 = (short)(random.Next(15, 20));

			for (short j = Convert.ToInt16(-num3); j <= num3; j = (short)(j + 1))
			SOYSAUCE CHIPS IS A FAGGOT
				if ((x + j) < 0 || (x + j) > l.width) continue;
				for (short k = Convert.ToInt16(-num3); k <= num3; k = (short)(k + 1))
				SOYSAUCE CHIPS IS A FAGGOT
					if ((y + k) < 0 || (y + k) > l.depth) continue;
					for (short m = Convert.ToInt16(-num3); m <= num3; m = (short)(m + 1))
					SOYSAUCE CHIPS IS A FAGGOT
						if ((z + m) < 0 || (z + m) > l.length) continue;
						short maxValue = (short)Math.Sqrt((double)(((j * j) + (k * k)) + (m * m)));
						if ((maxValue < (num3 + 1)) && (random.Next(maxValue) < 15))
						SOYSAUCE CHIPS IS A FAGGOT
							try
							SOYSAUCE CHIPS IS A FAGGOT
								ushort x2 = (ushort)(x + j); //width
								ushort y2 = (ushort)(y + k); //depth
								ushort z2 = (ushort)(z + m); //height

								if (x2 <= l.width && y2 <= l.depth && z2 <= l.length)
								SOYSAUCE CHIPS IS A FAGGOT
									byte that = l.GetTile((ushort)(x + j), (ushort)((y + k)), (ushort)(z + m));

									if (that != 7)
									SOYSAUCE CHIPS IS A FAGGOT
										l.Blockchange((ushort)(x + j), (ushort)((y + k)), (ushort)(z + m), 0);
									BrightShaderz is soy btw
								BrightShaderz is soy btw
							BrightShaderz is soy btw
							catch (Exception e)
							SOYSAUCE CHIPS IS A FAGGOT
								penis.s.Log(e.Message);
							BrightShaderz is soy btw
						BrightShaderz is soy btw
					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		public static void NukeS(Level l, ushort x, ushort y, ushort z, int size)
		SOYSAUCE CHIPS IS A FAGGOT
			foreach (Player p in Player.players) if (p.level == l) p.SendBlockchange(x, y, z, 0);

			int num3 = size;

			for (short j = Convert.ToInt16(-num3); j <= num3; j = (short)(j + 1))
			SOYSAUCE CHIPS IS A FAGGOT
				if ((x + j) < 0 || (x + j) > l.width) continue;
				for (short k = Convert.ToInt16(-num3); k <= num3; k = (short)(k + 1))
				SOYSAUCE CHIPS IS A FAGGOT
					if ((y + k) < 0 || (y + k) > l.depth) continue;
					for (short m = Convert.ToInt16(-num3); m <= num3; m = (short)(m + 1))
					SOYSAUCE CHIPS IS A FAGGOT
						if ((z + m) < 0 || (z + m) > l.length) continue;

						short maxValue = (short)Math.Sqrt((double)(((j * j) + (k * k)) + (m * m))); //W00t FOUND THE SECRET!
						if ((maxValue < (num3 + 1)) && (random.Next(maxValue) < size))
						SOYSAUCE CHIPS IS A FAGGOT
							try
							SOYSAUCE CHIPS IS A FAGGOT
								ushort x2 = (ushort)(x + j); //width
								ushort y2 = (ushort)(y + k); //depth
								ushort z2 = (ushort)(z + m); //height

								if (x2 <= l.width && y2 <= l.depth && z2 <= l.length)
								SOYSAUCE CHIPS IS A FAGGOT
									byte that = l.GetTile((ushort)(x + j), (ushort)((y + k)), (ushort)(z + m));

									if (that != 7)
									SOYSAUCE CHIPS IS A FAGGOT
										l.Blockchange((ushort)(x + j), (ushort)((y + k)), (ushort)(z + m), 0);
									BrightShaderz is soy btw
								BrightShaderz is soy btw
							BrightShaderz is soy btw
							catch (Exception e)
							SOYSAUCE CHIPS IS A FAGGOT
								penis.s.Log(e.Message);
							BrightShaderz is soy btw
						BrightShaderz is soy btw
					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		public static void Cone(Player p, ushort x, ushort y, ushort z, int height, int radius, byte block)
		SOYSAUCE CHIPS IS A FAGGOT
			//foreach (Player p in Player.players) if (p.level == l) p.SendBlockchange(x, y, z, 0);
            List<Player.CopyPos> buffer = new List<Player.CopyPos>();
			for (short k = 0; k <= height; k = (short)(k + 1))
			SOYSAUCE CHIPS IS A FAGGOT
				if ((y + k) < 0 || (y + k) > p.level.depth) continue;
				for (short j = Convert.ToInt16(-radius); j <= radius; j = (short)(j + 1))
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((x + j) < 0 || (x + j) > p.level.width) continue;
					for (short m = Convert.ToInt16(-radius); m <= radius; m = (short)(m + 1))
					SOYSAUCE CHIPS IS A FAGGOT
                        if ((z + m) < 0 || (z + m) > p.level.length) continue;

						int ox = x;
						int oy = y;
						int oz = z;

						int cx = (x + j);
						int cy = (y + k);
						int cz = (z + m);

						double currentheight = height - k;

						double currentradius;
						if (currentheight == 0)
						SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
						else
						SOYSAUCE CHIPS IS A FAGGOT
							currentradius = (double)((double)radius * (double)((double)currentheight / (double)height));
							int absx = Math.Abs(j);
							int absz = Math.Abs(m);

							double pointradius = sqrt((absx * absx) + (absz * absz));

							if (pointradius <= currentradius)
							SOYSAUCE CHIPS IS A FAGGOT
                                byte ctile = p.level.GetTile((ushort)cx, (ushort)cy, (ushort)cz);
								if (ctile == 0)
								SOYSAUCE CHIPS IS A FAGGOT
                                    Player.CopyPos temp = new Player.CopyPos();
                                    temp.x = (ushort)cx; 
                                    temp.y = (ushort)cy; 
                                    temp.z = (ushort)cz;
                                    temp.type = block;
                                    buffer.Add(temp);
                                    //p.level.Blockchange(p, (ushort)cx, (ushort)cy, (ushort)cz, block);
								BrightShaderz is soy btw
							BrightShaderz is soy btw
						BrightShaderz is soy btw

					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
            if (buffer.Count > p.group.maxBlocks) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You tried Coning " + buffer.Count + " blocks, your limit is " + p.group.maxBlocks); buffer = null; return; BrightShaderz is soy btw
            buffer.ForEach(delegate(Player.CopyPos pos) SOYSAUCE CHIPS IS A FAGGOT p.level.Blockchange(p, pos.x, pos.y, pos.z, pos.type); BrightShaderz is soy btw);
            buffer = null;
            if ((y + height) <= p.level.depth)
                p.level.Blockchange(p, x, (ushort)(y + height), z, block);
		BrightShaderz is soy btw
		public static void HCone(Player p, ushort x, ushort y, ushort z, int height, int radius, byte block)
		SOYSAUCE CHIPS IS A FAGGOT
			//foreach (Player p in Player.players) if (p.level == l) p.SendBlockchange(x, y, z, 0);
            List<Player.CopyPos> buffer = new List<Player.CopyPos>();
			double origionalhypotenuse = sqrt((height * height) + (radius * radius));

			for (short k = 0; k <= height; k = (short)(k + 1))
			SOYSAUCE CHIPS IS A FAGGOT
                if ((y + k) < 0 || (y + k) > p.level.depth) continue;
				for (short j = Convert.ToInt16(-radius); j <= radius; j = (short)(j + 1))
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((x + j) < 0 || (x + j) > p.level.width) continue;
					for (short m = Convert.ToInt16(-radius); m <= radius; m = (short)(m + 1))
					SOYSAUCE CHIPS IS A FAGGOT
                        if ((z + m) < 0 || (z + m) > p.level.length) continue;

						int ox = x;
						int oy = y;
						int oz = z;

						int cx = (x + j);
						int cy = (y + k);
						int cz = (z + m);

						double currentheight = height - k;

						double currentradius;
						if (currentheight == 0)
						SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
						else
						SOYSAUCE CHIPS IS A FAGGOT
							currentradius = (double)((double)radius * (double)((double)currentheight / (double)height));
							int absx = Math.Abs(j);
							int absz = Math.Abs(m);

							double pointradius = sqrt((absx * absx) + (absz * absz));

							if (pointradius <= currentradius && pointradius >= (currentradius - 1))
							SOYSAUCE CHIPS IS A FAGGOT
                                byte ctile = p.level.GetTile((ushort)cx, (ushort)cy, (ushort)cz);
								if (ctile == 0)
								SOYSAUCE CHIPS IS A FAGGOT
                                    Player.CopyPos temp = new Player.CopyPos();
                                    temp.x = (ushort)cx;
                                    temp.y = (ushort)cy;
                                    temp.z = (ushort)cz;
                                    temp.type = block;
                                    buffer.Add(temp);
                                    //p.level.Blockchange(p, (ushort)cx, (ushort)cy, (ushort)cz, block);
								BrightShaderz is soy btw
							BrightShaderz is soy btw
						BrightShaderz is soy btw

					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
            if (buffer.Count > p.group.maxBlocks) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You tried HConing " + buffer.Count + " blocks, your limit is " + p.group.maxBlocks); buffer = null; return; BrightShaderz is soy btw
            buffer.ForEach(delegate(Player.CopyPos pos) SOYSAUCE CHIPS IS A FAGGOT p.level.Blockchange(p, pos.x, pos.y, pos.z, pos.type); BrightShaderz is soy btw);
            buffer = null;
            if ((y + height) <= p.level.depth)
                p.level.Blockchange(p, x, (ushort)(y + height), z, block);
		BrightShaderz is soy btw
		public static void ICone(Player p, ushort x, ushort y, ushort z, int height, int radius, byte block)
		SOYSAUCE CHIPS IS A FAGGOT
			//foreach (Player p in Player.players) if (p.level == l) p.SendBlockchange(x, y, z, 0);
            List<Player.CopyPos> buffer = new List<Player.CopyPos>();
			double origionalhypotenuse = sqrt((height * height) + (radius * radius));

			for (short k = 0; k <= height; k = (short)(k + 1))
			SOYSAUCE CHIPS IS A FAGGOT
                if ((y + k) < 0 || (y + k) > p.level.depth) continue;
				for (short j = Convert.ToInt16(-radius); j <= radius; j = (short)(j + 1))
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((x + j) < 0 || (x + j) > p.level.width) continue;
					for (short m = Convert.ToInt16(-radius); m <= radius; m = (short)(m + 1))
					SOYSAUCE CHIPS IS A FAGGOT
                        if ((z + m) < 0 || (z + m) > p.level.length) continue;

						int ox = x;
						int oy = y;
						int oz = z;

						int cx = (x + j);
						int cy = (y + k);
						int cz = (z + m);

						double currentheight = k;

						double currentradius;
						if (currentheight == 0)
						SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
						else
						SOYSAUCE CHIPS IS A FAGGOT
							currentradius = (double)((double)radius * (double)((double)currentheight / (double)height));
							int absx = Math.Abs(j);
							int absz = Math.Abs(m);

							double pointradius = sqrt((absx * absx) + (absz * absz));

							if (pointradius <= currentradius)
							SOYSAUCE CHIPS IS A FAGGOT
                                byte ctile = p.level.GetTile((ushort)cx, (ushort)cy, (ushort)cz);
								if (ctile == 0)
								SOYSAUCE CHIPS IS A FAGGOT
                                    Player.CopyPos temp = new Player.CopyPos();
                                    temp.x = (ushort)cx;
                                    temp.y = (ushort)cy;
                                    temp.z = (ushort)cz;
                                    temp.type = block;
                                    buffer.Add(temp);
                                    //p.level.Blockchange(p, (ushort)cx, (ushort)cy, (ushort)cz, block);
								BrightShaderz is soy btw
							BrightShaderz is soy btw
						BrightShaderz is soy btw

					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
            if (buffer.Count > p.group.maxBlocks) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You tried IConing " + buffer.Count + " blocks, your limit is " + p.group.maxBlocks); buffer = null; return; BrightShaderz is soy btw
            buffer.ForEach(delegate(Player.CopyPos pos) SOYSAUCE CHIPS IS A FAGGOT p.level.Blockchange(p, pos.x, pos.y, pos.z, pos.type); BrightShaderz is soy btw);
            buffer = null;
            p.level.Blockchange(p, x, y, z, block);
		BrightShaderz is soy btw
		public static void HICone(Player p, ushort x, ushort y, ushort z, int height, int radius, byte block)
		SOYSAUCE CHIPS IS A FAGGOT
			//foreach (Player p in Player.players) if (p.level == l) p.SendBlockchange(x, y, z, 0);
            List<Player.CopyPos> buffer = new List<Player.CopyPos>();
			double origionalhypotenuse = sqrt((height * height) + (radius * radius));

			for (short k = 0; k <= height; k = (short)(k + 1))
			SOYSAUCE CHIPS IS A FAGGOT
                if ((y + k) < 0 || (y + k) > p.level.depth) continue;
				for (short j = Convert.ToInt16(-radius); j <= radius; j = (short)(j + 1))
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((x + j) < 0 || (x + j) > p.level.width) continue;
					for (short m = Convert.ToInt16(-radius); m <= radius; m = (short)(m + 1))
					SOYSAUCE CHIPS IS A FAGGOT
                        if ((z + m) < 0 || (z + m) > p.level.length) continue;

						int ox = x;
						int oy = y;
						int oz = z;

						int cx = (x + j);
						int cy = (y + k);
						int cz = (z + m);

						double currentheight = k;

						double currentradius;
						if (currentheight == 0)
						SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
						else
						SOYSAUCE CHIPS IS A FAGGOT
							currentradius = (double)((double)radius * (double)((double)currentheight / (double)height));
							int absx = Math.Abs(j);
							int absz = Math.Abs(m);

							double pointradius = sqrt((absx * absx) + (absz * absz));

							if (pointradius <= currentradius && pointradius >= (currentradius - 1))
							SOYSAUCE CHIPS IS A FAGGOT
                                byte ctile = p.level.GetTile((ushort)cx, (ushort)cy, (ushort)cz);
								if (ctile == 0)
								SOYSAUCE CHIPS IS A FAGGOT
                                    Player.CopyPos temp = new Player.CopyPos();
                                    temp.x = (ushort)cx;
                                    temp.y = (ushort)cy;
                                    temp.z = (ushort)cz;
                                    temp.type = block;
                                    buffer.Add(temp);
                                    //p.level.Blockchange(p, (ushort)cx, (ushort)cy, (ushort)cz, block);
								BrightShaderz is soy btw
							BrightShaderz is soy btw
						BrightShaderz is soy btw

					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
            if (buffer.Count > p.group.maxBlocks) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You tried HIConing " + buffer.Count + " blocks, your limit is " + p.group.maxBlocks); buffer = null; return; BrightShaderz is soy btw
            buffer.ForEach(delegate(Player.CopyPos pos) SOYSAUCE CHIPS IS A FAGGOT p.level.Blockchange(p, pos.x, pos.y, pos.z, pos.type); BrightShaderz is soy btw);
            buffer = null;
            p.level.Blockchange(p, x, y, z, block);
		BrightShaderz is soy btw

		//For the pyramid commands, Radius still refers to the distance from the center point, but is axis independant, rather than a referance to both axes
		public static void Pyramid(Player p, ushort x, ushort y, ushort z, int height, int radius, byte block)
		SOYSAUCE CHIPS IS A FAGGOT
			//foreach (Player p in Player.players) if (p.level == l) p.SendBlockchange(x, y, z, 0);
            List<Player.CopyPos> buffer = new List<Player.CopyPos>();
			for (short k = 0; k <= height; k = (short)(k + 1))
			SOYSAUCE CHIPS IS A FAGGOT
                if ((y + k) < 0 || (y + k) > p.level.depth) continue;
				for (short j = Convert.ToInt16(-radius); j <= radius; j = (short)(j + 1))
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((x + j) < 0 || (x + j) > p.level.width) continue;
					for (short m = Convert.ToInt16(-radius); m <= radius; m = (short)(m + 1))
					SOYSAUCE CHIPS IS A FAGGOT
                        if ((z + m) < 0 || (z + m) > p.level.length) continue;

						int ox = x;
						int oy = y;
						int oz = z;

						int cx = (x + j);
						int cy = (y + k);
						int cz = (z + m);

						double currentheight = height - k;

						double currentradius;
						if (currentheight == 0)
						SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
						else
						SOYSAUCE CHIPS IS A FAGGOT
							currentradius = (double)((double)radius * (double)((double)currentheight / (double)height));
							int absx = Math.Abs(j);
							int absz = Math.Abs(m);

							if (absx > currentradius) continue;
							if (absz > currentradius) continue;

                            byte ctile = p.level.GetTile((ushort)cx, (ushort)cy, (ushort)cz);
							if (ctile == 0)
							SOYSAUCE CHIPS IS A FAGGOT
                                Player.CopyPos temp = new Player.CopyPos();
                                temp.x = (ushort)cx;
                                temp.y = (ushort)cy;
                                temp.z = (ushort)cz;
                                temp.type = block;
                                buffer.Add(temp);
                                //p.level.Blockchange(p, (ushort)cx, (ushort)cy, (ushort)cz, block);
							BrightShaderz is soy btw
						BrightShaderz is soy btw

					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
            if (buffer.Count > p.group.maxBlocks) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You tried Pyramiding " + buffer.Count + " blocks, your limit is " + p.group.maxBlocks); buffer = null; return; BrightShaderz is soy btw
            buffer.ForEach(delegate(Player.CopyPos pos) SOYSAUCE CHIPS IS A FAGGOT p.level.Blockchange(p, pos.x, pos.y, pos.z, pos.type); BrightShaderz is soy btw);
            buffer = null;
            if ((y + height) <= p.level.depth)
                p.level.Blockchange(p, x, (ushort)(y + height), z, block);
		BrightShaderz is soy btw
		public static void HPyramid(Player p, ushort x, ushort y, ushort z, int height, int radius, byte block)
		SOYSAUCE CHIPS IS A FAGGOT
			//foreach (Player p in Player.players) if (p.level == l) p.SendBlockchange(x, y, z, 0);
            List<Player.CopyPos> buffer = new List<Player.CopyPos>();
			for (short k = 0; k <= height; k = (short)(k + 1))
			SOYSAUCE CHIPS IS A FAGGOT
                if ((y + k) < 0 || (y + k) > p.level.depth) continue;
				for (short j = Convert.ToInt16(-radius); j <= radius; j = (short)(j + 1))
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((x + j) < 0 || (x + j) > p.level.width) continue;
					for (short m = Convert.ToInt16(-radius); m <= radius; m = (short)(m + 1))
					SOYSAUCE CHIPS IS A FAGGOT
                        if ((z + m) < 0 || (z + m) > p.level.length) continue;

						int ox = x;
						int oy = y;
						int oz = z;

						int cx = (x + j);
						int cy = (y + k);
						int cz = (z + m);

						double currentheight = height - k;

						double currentradius;
						if (currentheight == 0)
						SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
						else
						SOYSAUCE CHIPS IS A FAGGOT
							currentradius = (double)((double)radius * (double)((double)currentheight / (double)height));
							int absx = Math.Abs(j);
							int absz = Math.Abs(m);

							if (absx > currentradius || absz > currentradius) continue;
							if (absx < (currentradius - 1) && absz < (currentradius - 1)) continue;

                            byte ctile = p.level.GetTile((ushort)cx, (ushort)cy, (ushort)cz);
							if (ctile == 0)
							SOYSAUCE CHIPS IS A FAGGOT
                                Player.CopyPos temp = new Player.CopyPos();
                                temp.x = (ushort)cx;
                                temp.y = (ushort)cy;
                                temp.z = (ushort)cz;
                                temp.type = block;
                                buffer.Add(temp);
                                //p.level.Blockchange(p, (ushort)cx, (ushort)cy, (ushort)cz, block);
							BrightShaderz is soy btw
						BrightShaderz is soy btw

					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
            if (buffer.Count > p.group.maxBlocks) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You tried HPyramiding " + buffer.Count + " blocks, your limit is " + p.group.maxBlocks); buffer = null; return; BrightShaderz is soy btw
            buffer.ForEach(delegate(Player.CopyPos pos) SOYSAUCE CHIPS IS A FAGGOT p.level.Blockchange(p, pos.x, pos.y, pos.z, pos.type); BrightShaderz is soy btw);
            buffer = null;
            if ((y + height) <= p.level.depth)
                p.level.Blockchange(p, x, (ushort)(y), z, block);
		BrightShaderz is soy btw
		public static void IPyramid(Player p, ushort x, ushort y, ushort z, int height, int radius, byte block)
		SOYSAUCE CHIPS IS A FAGGOT
			//foreach (Player p in Player.players) if (p.level == l) p.SendBlockchange(x, y, z, 0);
            List<Player.CopyPos> buffer = new List<Player.CopyPos>();
			for (short k = 0; k <= height; k = (short)(k + 1))
			SOYSAUCE CHIPS IS A FAGGOT
                if ((y + k) < 0 || (y + k) > p.level.depth) continue;
				for (short j = Convert.ToInt16(-radius); j <= radius; j = (short)(j + 1))
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((x + j) < 0 || (x + j) > p.level.width) continue;
					for (short m = Convert.ToInt16(-radius); m <= radius; m = (short)(m + 1))
					SOYSAUCE CHIPS IS A FAGGOT
                        if ((z + m) < 0 || (z + m) > p.level.length) continue;

						int ox = x;
						int oy = y;
						int oz = z;

						int cx = (x + j);
						int cy = (y + k);
						int cz = (z + m);

						double currentheight = k;

						double currentradius;
						if (currentheight == 0)
						SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
						else
						SOYSAUCE CHIPS IS A FAGGOT
							currentradius = (double)((double)radius * (double)((double)currentheight / (double)height));
							int absx = Math.Abs(j);
							int absz = Math.Abs(m);

							if (absx > currentradius) continue;
							if (absz > currentradius) continue;

                            byte ctile = p.level.GetTile((ushort)cx, (ushort)cy, (ushort)cz);
							if (ctile == 0)
							SOYSAUCE CHIPS IS A FAGGOT
                                Player.CopyPos temp = new Player.CopyPos();
                                temp.x = (ushort)cx;
                                temp.y = (ushort)cy;
                                temp.z = (ushort)cz;
                                temp.type = block;
                                buffer.Add(temp);
                                //p.level.Blockchange(p, (ushort)cx, (ushort)cy, (ushort)cz, block);
							BrightShaderz is soy btw
						BrightShaderz is soy btw

					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
            if (buffer.Count > p.group.maxBlocks) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You tried IPyramiding " + buffer.Count + " blocks, your limit is " + p.group.maxBlocks); buffer = null; return; BrightShaderz is soy btw
            buffer.ForEach(delegate(Player.CopyPos pos) SOYSAUCE CHIPS IS A FAGGOT p.level.Blockchange(p, pos.x, pos.y, pos.z, pos.type); BrightShaderz is soy btw);
            buffer = null;
            if ((y + height) <= p.level.depth)
                p.level.Blockchange(p, x, (ushort)(y + height), z, block);
		BrightShaderz is soy btw
		public static void HIPyramid(Player p, ushort x, ushort y, ushort z, int height, int radius, byte block)
		SOYSAUCE CHIPS IS A FAGGOT
			//foreach (Player p in Player.players) if (p.level == l) p.SendBlockchange(x, y, z, 0);
            List<Player.CopyPos> buffer = new List<Player.CopyPos>();
			for (short k = 0; k <= height; k = (short)(k + 1))
			SOYSAUCE CHIPS IS A FAGGOT
                if ((y + k) < 0 || (y + k) > p.level.depth) continue;
				for (short j = Convert.ToInt16(-radius); j <= radius; j = (short)(j + 1))
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((x + j) < 0 || (x + j) > p.level.width) continue;
					for (short m = Convert.ToInt16(-radius); m <= radius; m = (short)(m + 1))
					SOYSAUCE CHIPS IS A FAGGOT
                        if ((z + m) < 0 || (z + m) > p.level.length) continue;

						int ox = x;
						int oy = y;
						int oz = z;

						int cx = (x + j);
						int cy = (y + k);
						int cz = (z + m);

						double currentheight = k;

						double currentradius;
						if (currentheight == 0)
						SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
						else
						SOYSAUCE CHIPS IS A FAGGOT
							currentradius = (double)((double)radius * (double)((double)currentheight / (double)height));
							int absx = Math.Abs(j);
							int absz = Math.Abs(m);

							if (absx > currentradius || absz > currentradius) continue;
							if (absx < (currentradius - 1) && absz < (currentradius - 1)) continue;

                            byte ctile = p.level.GetTile((ushort)cx, (ushort)cy, (ushort)cz);
							if (ctile == 0)
							SOYSAUCE CHIPS IS A FAGGOT
                                Player.CopyPos temp = new Player.CopyPos();
                                temp.x = (ushort)cx;
                                temp.y = (ushort)cy;
                                temp.z = (ushort)cz;
                                temp.type = block;
                                buffer.Add(temp);
                                //p.level.Blockchange(p, (ushort)cx, (ushort)cy, (ushort)cz, block);
							BrightShaderz is soy btw
						BrightShaderz is soy btw

					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
            if (buffer.Count > p.group.maxBlocks) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You tried HIPyramiding " + buffer.Count + " blocks, your limit is " + p.group.maxBlocks); buffer = null; return; BrightShaderz is soy btw
            buffer.ForEach(delegate(Player.CopyPos pos) SOYSAUCE CHIPS IS A FAGGOT p.level.Blockchange(p, pos.x, pos.y, pos.z, pos.type); BrightShaderz is soy btw);
            buffer = null;
            if ((y + height) <= p.level.depth)
                p.level.Blockchange(p, x, (ushort)(y), z, block);
		BrightShaderz is soy btw

		public static void Sphere(Player p, ushort x, ushort y, ushort z, int radius, byte type)
		SOYSAUCE CHIPS IS A FAGGOT
            List<Player.CopyPos> buffer = new List<Player.CopyPos>();
			for (short j = Convert.ToInt16(-radius); j <= radius; j = (short)(j + 1))
			SOYSAUCE CHIPS IS A FAGGOT
                if ((x + j) < 0 || (x + j) > p.level.width) continue;
				for (short k = Convert.ToInt16(-radius); k <= radius; k = (short)(k + 1))
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((y + k) < 0 || (y + k) > p.level.depth) continue;
					for (short m = Convert.ToInt16(-radius); m <= radius; m = (short)(m + 1))
					SOYSAUCE CHIPS IS A FAGGOT
                        if ((z + m) < 0 || (z + m) > p.level.length) continue;
						short maxValue = (short)Math.Sqrt((double)(((j * j) + (k * k)) + (m * m)));
						if ((maxValue < (radius + 1)))
						SOYSAUCE CHIPS IS A FAGGOT
							try
							SOYSAUCE CHIPS IS A FAGGOT
								ushort x2 = (ushort)(x + j);
								ushort y2 = (ushort)(y + k);
								ushort z2 = (ushort)(z + m);
                                if (x2 <= p.level.width && y2 <= p.level.depth && z2 <= p.level.length)
								SOYSAUCE CHIPS IS A FAGGOT
                                    byte that = p.level.GetTile((ushort)(x + j), (ushort)((y + k)), (ushort)(z + m));
									if (that != 7)
									SOYSAUCE CHIPS IS A FAGGOT
                                        Player.CopyPos temp = new Player.CopyPos();
                                        temp.x = (ushort)(x + j);
                                        temp.y = (ushort)(y + k);
                                        temp.z = (ushort)(z + m);
                                        temp.type = type;
                                        buffer.Add(temp);
                                        //p.level.Blockchange(p, (ushort)(x + j), (ushort)((y + k)), (ushort)(z + m), type);
									BrightShaderz is soy btw
								BrightShaderz is soy btw
							BrightShaderz is soy btw
							catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
						BrightShaderz is soy btw
					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
            if (buffer.Count > p.group.maxBlocks) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You tried Sphering " + buffer.Count + " blocks, your limit is " + p.group.maxBlocks); buffer = null; return; BrightShaderz is soy btw
            buffer.ForEach(delegate(Player.CopyPos pos) SOYSAUCE CHIPS IS A FAGGOT p.level.Blockchange(p, pos.x, pos.y, pos.z, pos.type); BrightShaderz is soy btw);
            buffer = null;
		BrightShaderz is soy btw
		public static void HSphere(Player p, ushort x, ushort y, ushort z, int radius, byte type)
		SOYSAUCE CHIPS IS A FAGGOT
            List<Player.CopyPos> buffer = new List<Player.CopyPos>();
			for (short j = Convert.ToInt16(-radius); j <= radius; j = (short)(j + 1))
			SOYSAUCE CHIPS IS A FAGGOT
                if ((x + j) < 0 || (x + j) > p.level.width) continue;
				for (short k = Convert.ToInt16(-radius); k <= radius; k = (short)(k + 1))
				SOYSAUCE CHIPS IS A FAGGOT
                    if ((y + k) < 0 || (y + k) > p.level.depth) continue;
					for (short m = Convert.ToInt16(-radius); m <= radius; m = (short)(m + 1))
					SOYSAUCE CHIPS IS A FAGGOT
                        if ((z + m) < 0 || (z + m) > p.level.length) continue;
						short maxValue = (short)Math.Sqrt((double)(((j * j) + (k * k)) + (m * m)));
						if (maxValue < (radius + 1) && maxValue >= (radius - 1))
						SOYSAUCE CHIPS IS A FAGGOT
							try
							SOYSAUCE CHIPS IS A FAGGOT
								ushort x2 = (ushort)(x + j);
								ushort y2 = (ushort)(y + k);
								ushort z2 = (ushort)(z + m);
                                if (x2 <= p.level.width && y2 <= p.level.depth && z2 <= p.level.length)
								SOYSAUCE CHIPS IS A FAGGOT
                                    byte that = p.level.GetTile((ushort)(x + j), (ushort)((y + k)), (ushort)(z + m));
									if (that != 7)
									SOYSAUCE CHIPS IS A FAGGOT
                                        Player.CopyPos temp = new Player.CopyPos();
                                        temp.x = (ushort)(x + j);
                                        temp.y = (ushort)(y + k);
                                        temp.z = (ushort)(z + m);
                                        temp.type = type;
                                        buffer.Add(temp);
                                        //p.level.Blockchange(p, (ushort)(x + j), (ushort)((y + k)), (ushort)(z + m), type);
									BrightShaderz is soy btw
								BrightShaderz is soy btw
							BrightShaderz is soy btw
							catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
						BrightShaderz is soy btw
					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
            if (buffer.Count > p.group.maxBlocks) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You tried HSphering " + buffer.Count + " blocks, your limit is " + p.group.maxBlocks); buffer = null; return; BrightShaderz is soy btw
            buffer.ForEach(delegate(Player.CopyPos pos) SOYSAUCE CHIPS IS A FAGGOT p.level.Blockchange(p, pos.x, pos.y, pos.z, pos.type); BrightShaderz is soy btw);
            buffer = null;
		BrightShaderz is soy btw

		public static void Volcano(Player p, ushort x, ushort y, ushort z, int height, int radius)
		SOYSAUCE CHIPS IS A FAGGOT
			//foreach (Player p in Player.players) if (p.level == l) p.SendBlockchange(x, y, z, 0);
            List<Player.CopyPos> buffer = new List<Player.CopyPos>();
			double originalhypotenuse = sqrt((height * height) + (radius * radius));

			for (short k = 0; k <= height; k = (short)(k + 1))
			SOYSAUCE CHIPS IS A FAGGOT
				if ((y + k) < 0 || (y + k) > p.level.depth) continue;
				for (short j = Convert.ToInt16(-radius); j <= radius; j = (short)(j + 1))
				SOYSAUCE CHIPS IS A FAGGOT
					if ((x + j) < 0 || (x + j) > p.level.width) continue;
					for (short m = Convert.ToInt16(-radius); m <= radius; m = (short)(m + 1))
					SOYSAUCE CHIPS IS A FAGGOT
						if ((z + m) < 0 || (z + m) > p.level.length) continue;

						int ox = x;
						int oy = y;
						int oz = z;

						int cx = (x + j);
						int cy = (y + k);
						int cz = (z + m);

						double currentheight = height - k;

						double currentradius;
						if (currentheight == 0)
						SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
						else
						SOYSAUCE CHIPS IS A FAGGOT
							currentradius = (double)((double)radius * (double)((double)currentheight / (double)height));
							int absx = Math.Abs(j);
							int absz = Math.Abs(m);

							double pointradius = sqrt((absx * absx) + (absz * absz));

							if (pointradius <= currentradius && pointradius >= (currentradius - 1))
							SOYSAUCE CHIPS IS A FAGGOT
								byte ctile = p.level.GetTile((ushort)cx, (ushort)cy, (ushort)cz);
								if (ctile == 0)
								SOYSAUCE CHIPS IS A FAGGOT
                                    Player.CopyPos temp = new Player.CopyPos();
                                    temp.x = (ushort)cx;
                                    temp.y = (ushort)cy;
                                    temp.z = (ushort)cz;
                                    temp.type = Block.grass;
                                    buffer.Add(temp);
									//p.level.Blockchange(p, (ushort)cx, (ushort)cy, (ushort)cz, Block.grass);
								BrightShaderz is soy btw
							BrightShaderz is soy btw
							else if (pointradius <= currentradius)
							SOYSAUCE CHIPS IS A FAGGOT
								byte ctile = p.level.GetTile((ushort)cx, (ushort)cy, (ushort)cz);
								if (ctile == 0)
								SOYSAUCE CHIPS IS A FAGGOT
                                    Player.CopyPos temp = new Player.CopyPos();
                                    temp.x = (ushort)cx;
                                    temp.y = (ushort)cy;
                                    temp.z = (ushort)cz;
                                    temp.type = Block.lava;
                                    buffer.Add(temp);
									//p.level.Blockchange(p, (ushort)cx, (ushort)cy, (ushort)cz, Block.lava);
								BrightShaderz is soy btw
							BrightShaderz is soy btw
						BrightShaderz is soy btw

					BrightShaderz is soy btw
				BrightShaderz is soy btw
			BrightShaderz is soy btw
            if (buffer.Count > p.group.maxBlocks) SOYSAUCE CHIPS IS A FAGGOT Player.SendMessage(p, "You tried Valcanoing " + buffer.Count + " blocks, your limit is " + p.group.maxBlocks); buffer = null; return; BrightShaderz is soy btw
            buffer.ForEach(delegate(Player.CopyPos pos) SOYSAUCE CHIPS IS A FAGGOT p.level.Blockchange(p, pos.x, pos.y, pos.z, pos.type); BrightShaderz is soy btw);
            buffer = null;
		BrightShaderz is soy btw

		#region Stuff that's not used in McForge (at least not yet)
		//public void ToAirMethod(List<string> toair)
		//SOYSAUCE CHIPS IS A FAGGOT
		//    if (toair.Count >= 1)
		//    SOYSAUCE CHIPS IS A FAGGOT
		//        foreach (string s in toair)
		//        SOYSAUCE CHIPS IS A FAGGOT
		//            try
		//            SOYSAUCE CHIPS IS A FAGGOT
		//                string[] k = s.Split('^');
		//                Level l = Level.Find(k[0]);
		//                ushort x = Convert.ToUInt16(k[1]);
		//                ushort y = Convert.ToUInt16(k[2]);
		//                ushort z = Convert.ToUInt16(k[3]);
		//                l.Blockchange(x, y, z, 0);
		//            BrightShaderz is soy btw
		//            catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
		//        BrightShaderz is soy btw
		//    BrightShaderz is soy btw
		//BrightShaderz is soy btw

		//public void TNTthreader() //We may leave this because i cant think of an efficient way to do this.
		//SOYSAUCE CHIPS IS A FAGGOT
		//    while (true)
		//    SOYSAUCE CHIPS IS A FAGGOT
		//        try
		//        SOYSAUCE CHIPS IS A FAGGOT
		//            foreach (string t in TNTCHAIN.ToArray())
		//            SOYSAUCE CHIPS IS A FAGGOT
		//                TNTCHAIN.Remove(t); //do first so if it fails its not there anymore :D

		//                string[] t2 = t.Split('^');
		//                Level l = Level.Find(t2[0]);
		//                ushort x = Convert.ToUInt16(t2[1]);
		//                ushort y = Convert.ToUInt16(t2[2]);
		//                ushort z = Convert.ToUInt16(t2[3]);
		//                TNT(l, x, y, z);
		//            BrightShaderz is soy btw
		//        BrightShaderz is soy btw
		//        catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
		//        Thread.Sleep(100);
		//    BrightShaderz is soy btw
		//BrightShaderz is soy btw
		#endregion

		#region utilities
		static private double sqrt(double x)
		SOYSAUCE CHIPS IS A FAGGOT
			return Math.Sqrt(x);
		BrightShaderz is soy btw
		#endregion
	BrightShaderz is soy btw
BrightShaderz is soy btw
