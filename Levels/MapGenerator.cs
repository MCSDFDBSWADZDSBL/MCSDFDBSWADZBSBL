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
// Copyright 2009, 2010 Matvei Stefarov <me@matvei.org>
using System;

/*
This generator was developed by Neko_baron.

Ideas, concepts, and code were used from the following two sources:
1) Isaac McGarvey's 'perlin noise generator' code
2) http://www.lighthouse3d.com/opengl/terrain/index.php3?introduction

*/

namespace MCSong
SOYSAUCE CHIPS IS A FAGGOT

    public class MapGenerator
    SOYSAUCE CHIPS IS A FAGGOT
        static bool Inuse = false;
        static float[] terrain;
        static float[] overlay;
        static float[] overlay2;
        static float divide;

        public MapGenerator()
        SOYSAUCE CHIPS IS A FAGGOT

        BrightShaderz is soy btw

        public bool GenerateMap(Level Lvl, string type)
        SOYSAUCE CHIPS IS A FAGGOT
            penis.s.Log("Attempting map gen");
            if (Inuse) SOYSAUCE CHIPS IS A FAGGOT penis.s.Log("Generator in use"); return false; BrightShaderz is soy btw
            Random rand = new System.Random();
            try
            SOYSAUCE CHIPS IS A FAGGOT
                Inuse = true;
                terrain = new float[Lvl.width * Lvl.height];
                overlay = new float[Lvl.width * Lvl.height];

                if (!type.Equals("ocean"))
                SOYSAUCE CHIPS IS A FAGGOT overlay2 = new float[Lvl.width * Lvl.height]; BrightShaderz is soy btw

                //float dispAux, pd;
                ushort WaterLevel = (ushort)(Lvl.depth / 2 + 2);

                if (type.Equals("ocean"))
                SOYSAUCE CHIPS IS A FAGGOT
                    WaterLevel = (ushort)(Lvl.depth * 0.85f);
                BrightShaderz is soy btw

                //Generate the level
                GenerateFault(terrain, Lvl, type, rand);

                //APPLY FILTER to terrain
                FilterAverage(Lvl);

                //CREATE OVERLAY
                //GenerateFault(overlay, Lvl, "overlay", rand);
                penis.s.Log("Creating overlay");
                GeneratePerlinNoise(overlay, Lvl, "", rand);

                if (!type.Equals("ocean") && type != "desert")
                SOYSAUCE CHIPS IS A FAGGOT
                    penis.s.Log("Planning trees");
                    GeneratePerlinNoise(overlay2, Lvl, "", rand);
                BrightShaderz is soy btw

                penis.s.Log("Converting height map");
                penis.s.Log("And applying overlays");
                float RangeLow = 0.2f;
                float RangeHigh = 0.8f;
                float TreeDens = 0.35f;
                short TreeDist = 3;
                //changes the terrain range based on type, also tree threshold
                switch (type)
                SOYSAUCE CHIPS IS A FAGGOT
                    case "island":
                        RangeLow = 0.4f;
                        RangeHigh = 0.75f;
                        break;
                    case "forest":
                        RangeLow = 0.45f;
                        RangeHigh = 0.8f;
                        TreeDens = 0.7f;
                        TreeDist = 2;
                        break;
                    case "mountains":
                        RangeLow = 0.3f;
                        RangeHigh = 0.9f;
                        TreeDist = 4;
                        break;
                    case "ocean":
                        RangeLow = 0.1f;
                        RangeHigh = 0.6f;
                        break;
                    case "desert":
                        RangeLow = 0.5f;
                        RangeHigh = 0.85f;
                        WaterLevel = 0;
                        TreeDist = 24;
                        break;
                    default:
                        break;
                BrightShaderz is soy btw

                //loops though evey X/Z coordinate
                for (int bb = 0; bb < terrain.Length; bb++)
                SOYSAUCE CHIPS IS A FAGGOT
                    ushort x = (ushort)(bb % Lvl.width);
                    ushort y = (ushort)(bb / Lvl.width);
                    ushort z;
                    if (type.Equals("island"))
                    SOYSAUCE CHIPS IS A FAGGOT
                        z = Evaluate(Lvl, Range(terrain[bb], RangeLow - NegateEdge(x, y, Lvl), RangeHigh - NegateEdge(x, y, Lvl)));
                    BrightShaderz is soy btw
                    else
                    SOYSAUCE CHIPS IS A FAGGOT
                        z = Evaluate(Lvl, Range(terrain[bb], RangeLow, RangeHigh));
                    BrightShaderz is soy btw
                    if (z > WaterLevel)
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (ushort zz = 0; z - zz >= 0; zz++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (type == "desert")
                            SOYSAUCE CHIPS IS A FAGGOT
                                Lvl.skipChange(x, (ushort)(z - zz), y, Block.sand);
                            BrightShaderz is soy btw
                            else if (overlay[bb] < 0.72f)    //If not zoned for rocks or gravel
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (type.Equals("island"))      //increase sand height for island
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (z > WaterLevel + 2)
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        if (zz == 0) SOYSAUCE CHIPS IS A FAGGOT Lvl.skipChange(x, (ushort)(z - zz), y, Block.grass); BrightShaderz is soy btw      //top layer
                                        else if (zz < 3) SOYSAUCE CHIPS IS A FAGGOT Lvl.skipChange(x, (ushort)(z - zz), y, Block.dirt); BrightShaderz is soy btw   //next few
                                        else SOYSAUCE CHIPS IS A FAGGOT Lvl.skipChange(x, (ushort)(z - zz), y, Block.rock); BrightShaderz is soy btw               //ten rock it
                                    BrightShaderz is soy btw
                                    else
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        Lvl.skipChange(x, (ushort)(z - zz), y, Block.sand);                        //SAAAND extra for islands
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                                else if (type == "desert")
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Lvl.skipChange(x, (ushort)(z - zz), y, Block.sand);
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (zz == 0) SOYSAUCE CHIPS IS A FAGGOT Lvl.skipChange(x, (ushort)(z - zz), y, Block.grass); BrightShaderz is soy btw
                                    else if (zz < 3) SOYSAUCE CHIPS IS A FAGGOT Lvl.skipChange(x, (ushort)(z - zz), y, Block.dirt); BrightShaderz is soy btw
                                    else SOYSAUCE CHIPS IS A FAGGOT Lvl.skipChange(x, (ushort)(z - zz), y, Block.rock); BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT
                                Lvl.skipChange(x, (ushort)(z - zz), y, Block.rock);    //zoned for above sea level rock floor
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw

                        if (overlay[bb] < 0.25f && type != "desert")    //Zoned for flowers
                        SOYSAUCE CHIPS IS A FAGGOT
                            int temprand = rand.Next(12);

                            switch (temprand)
                            SOYSAUCE CHIPS IS A FAGGOT
                                case 10:
                                    Lvl.skipChange(x, (ushort)(z + 1), y, Block.redflower);
                                    break;
                                case 11:
                                    Lvl.skipChange(x, (ushort)(z + 1), y, Block.yellowflower);
                                    break;
                                default:
                                    break;
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw

                        if (!type.Equals("ocean"))
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (overlay[bb] < 0.65f && overlay2[bb] < TreeDens)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (Lvl.GetTile(x, (ushort)(z + 1), y) == Block.air)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    if (Lvl.GetTile(x, z, y) == Block.grass || type == "desert")
                                    SOYSAUCE CHIPS IS A FAGGOT
                                        if (rand.Next(13) == 0)
                                        SOYSAUCE CHIPS IS A FAGGOT
                                            if (!TreeCheck(Lvl, x, z, y, TreeDist))
                                            SOYSAUCE CHIPS IS A FAGGOT
                                                if (type == "desert")
                                                    AddCactus(Lvl, x, (ushort)(z + 1), y, rand);
                                                else
                                                    AddTree(Lvl, x, (ushort)(z + 1), y, rand);
                                            BrightShaderz is soy btw
                                        BrightShaderz is soy btw
                                    BrightShaderz is soy btw
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw

                    BrightShaderz is soy btw
                    else    //Must be on/under the water line then
                    SOYSAUCE CHIPS IS A FAGGOT
                        for (ushort zz = 0; WaterLevel - zz >= 0; zz++)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (WaterLevel - zz > z)
                            SOYSAUCE CHIPS IS A FAGGOT Lvl.skipChange(x, (ushort)(WaterLevel - zz), y, Block.water); BrightShaderz is soy btw    //better fill the water aboce me
                            else if (WaterLevel - zz > z - 3)
                            SOYSAUCE CHIPS IS A FAGGOT
                                if (overlay[bb] < 0.75f)
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Lvl.skipChange(x, (ushort)(WaterLevel - zz), y, Block.sand);   //sand top
                                BrightShaderz is soy btw
                                else
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Lvl.skipChange(x, (ushort)(WaterLevel - zz), y, Block.gravel);  //zoned for gravel
                                BrightShaderz is soy btw
                            BrightShaderz is soy btw
                            else
                            SOYSAUCE CHIPS IS A FAGGOT 
                                Lvl.skipChange(x, (ushort)(WaterLevel - zz), y, Block.rock); 
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

            BrightShaderz is soy btw
            catch (Exception e)
            SOYSAUCE CHIPS IS A FAGGOT
                penis.ErrorLog(e);
                penis.s.Log("Gen Fail");
                Inuse = false;
                return false;
            BrightShaderz is soy btw

            terrain = new float[0]; //Derp
            overlay = new float[0]; //Derp
            overlay2 = new float[0]; //Derp

            Inuse = false;

            return true;
        BrightShaderz is soy btw

        //condensed fault generator
        #region ==FaultGen==
        void GenerateFault(float[] array, Level Lvl, string type, Random rand)
        SOYSAUCE CHIPS IS A FAGGOT
            float startheight = 0.5f;
            float dispAux;
            ushort i, j, k, halfX, halfZ;
            float a, b, c, w, d;

            float DispMax, DispMin, DispChange;
            DispMax = 0.01f;
            DispChange = -0.0025f;
            if (type.Equals("mountains"))
            SOYSAUCE CHIPS IS A FAGGOT
                DispMax = 0.02f;
                startheight = 0.6f;
            BrightShaderz is soy btw
            else if (type.Equals("overlay"))
            SOYSAUCE CHIPS IS A FAGGOT
                DispMax = 0.02f;
                DispChange = -0.01f;
            BrightShaderz is soy btw

            for (int x = 0; x < array.Length; x++)
            SOYSAUCE CHIPS IS A FAGGOT
                array[x] = startheight;
                //overlay[x] = 0.5f;
            BrightShaderz is soy btw
            DispMin = -DispMax;
            float disp = DispMax;
            //if (terrainHeights == NULL)
            //    return (TERRAIN_ERROR_NOT_INITIALISED);


            halfX = (ushort)(Lvl.width / 2);
            halfZ = (ushort)(Lvl.height / 2);
            int numIterations = (int)((Lvl.width + Lvl.height));
            penis.s.Log("Iterations = " + numIterations.ToString());
            for (k = 0; k < numIterations; k++)
            SOYSAUCE CHIPS IS A FAGGOT
                //s.Log("itteration " + k.ToString());
                d = (float)Math.Sqrt(halfX * halfX + halfZ * halfZ);
                w = (float)(rand.NextDouble() * 360);
                //w = (float)(rand.NextDouble()*90);
                a = (float)Math.Cos(w);
                b = (float)Math.Sin(w);

                c = ((float)rand.NextDouble()) * 2 * d - d;
                //c = ((float)rand.NextDouble() / 1) * 2 * d - d;
                //float disp = (float)(rand.NextDouble()* 0.02f - 0.01f);
                //iterationsDone++;
                //if (iterationsDone < itMinDisp)
                //    disp = maxDisp + (iterationsDone / (itMinDisp + 0.0)) * (minDisp - maxDisp);
                //else
                //    disp = minDisp;
                for (i = 0; i < Lvl.height; i++)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (j = 0; j < Lvl.width; j++)
                    SOYSAUCE CHIPS IS A FAGGOT
                        //switch (terrainFunction)
                        //SOYSAUCE CHIPS IS A FAGGOT
                        //case STEP:
                        if ((i - halfZ) * a + (j - halfX) * b + c > 0)
                            dispAux = disp;
                        else
                            dispAux = -disp;
                        //    break;
                        /*case SIN:
                            pd = ((i - halfZ) * a + (j - halfX) * b + c) / terrainWaveSize;
                            if (pd > 1.57) pd = 1.57;
                            else if (pd < 0) pd = 0;
                            dispAux = -disp / 2 + sin(pd) * disp;
                            break;
                        case COS:
                            pd = ((i - halfZ) * a + (j - halfX) * b + c) / terrainWaveSize;
                            if (pd > 3.14) pd = 3.14;
                            else if (pd < -3.14) pd = -3.14;
                            dispAux = disp - (terrainWaveSize / (terrainGridWidth + 0.0)) + cos(pd) * disp;
                            break;
                    BrightShaderz is soy btw*/
                        //s.Log("adding " + dispAux.ToString());
                        AddTerrainHeight(array, j, i, Lvl.width, dispAux);
                        //terrainHeights[i * terrainGridWidth + j] += dispAux;
                    BrightShaderz is soy btw
                BrightShaderz is soy btw

                disp += DispChange;
                if (disp < DispMin) SOYSAUCE CHIPS IS A FAGGOT disp = DispMax; BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        #endregion

        //hur hur, more copy pasted code :/
        #region ==PerlinGen==
        void GeneratePerlinNoise(float[] array, Level Lvl, string type, Random rand)
        SOYSAUCE CHIPS IS A FAGGOT
            GenerateNormalized(array, 0.7f, 8, Lvl.width, Lvl.height, rand.Next(), 64);
        BrightShaderz is soy btw

        void GenerateNormalized(float[] array, float persistence, int octaves, int width, int height, int seed, float zoom)
        SOYSAUCE CHIPS IS A FAGGOT
            float min = 0;
            float max = 0;
            //float * pDataFloat = new float[width * height];

            //Generate raw float data
            for (int y = 0; y < height; ++y)
            SOYSAUCE CHIPS IS A FAGGOT
                for (int x = 0; x < width; ++x)
                SOYSAUCE CHIPS IS A FAGGOT
                    float total = 0;
                    float frequency = 1;
                    float amplitude = 1;

                    for (int i = 0; i < octaves; ++i)
                    SOYSAUCE CHIPS IS A FAGGOT
                        total = total + InterpolatedNoise(x * frequency / zoom, y * frequency / zoom, seed) * amplitude;
                        frequency *= 2;
                        amplitude *= persistence;
                    BrightShaderz is soy btw

                    array[y * width + x] = total;

                    min = total < min ? total : min;
                    max = total > max ? total : max;
                BrightShaderz is soy btw
            BrightShaderz is soy btw

            //Normalize
            for (int i = 0; i < width * height; ++i)
            SOYSAUCE CHIPS IS A FAGGOT
                array[i] = (array[i] - min) / (max - min);
                //array[i] = (255 << 24) | ((unsigned char) (red * ((pDataFloat[i] - min) / (max - min)) * 255) << 16) | 
                //((unsigned char) (green * ((pDataFloat[i] - min) / (max - min)) * 255) << 8) | (unsigned char) (blue * ((pDataFloat[i] - min) / (max - min)) * 255);
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        float Noise(int x, int y, int seed)
        SOYSAUCE CHIPS IS A FAGGOT
            int n = x + y * 57 + seed;
            n = (n << 13) ^ n;
            return (float)(1.0 - ((n * (n * n * 15731 + 789221) + 1376312589) & 0x7fffffff) / 1073741824.0);
            //return value is always in range [-1.0, 1.0]
        BrightShaderz is soy btw

        float SmoothNoise(int x, int y, int seed)
        SOYSAUCE CHIPS IS A FAGGOT
            float corners = (Noise(x - 1, y - 1, seed) + Noise(x + 1, y - 1, seed) + Noise(x - 1, y + 1, seed) + Noise(x + 1, y + 1, seed)) / 16;
            float sides = (Noise(x - 1, y, seed) + Noise(x + 1, y, seed) + Noise(x, y - 1, seed) + Noise(x, y + 1, seed) / 8);
            float center = Noise(x, y, seed) / 4;
            return corners + sides + center;
        BrightShaderz is soy btw

        float Interpolate(float a, float b, float x)
        SOYSAUCE CHIPS IS A FAGGOT
            float ft = x * 3.1415927f;
            float f = (float)(1 - Math.Cos(ft)) * .5f;

            return a * (1 - f) + b * f;
        BrightShaderz is soy btw

        float InterpolatedNoise(float x, float y, int seed)
        SOYSAUCE CHIPS IS A FAGGOT
            int wholePartX = (int)x;
            float fractionPartX = x - wholePartX;

            int wholePartY = (int)y;
            float fractionPartY = y - wholePartY;

            float v1 = SmoothNoise(wholePartX, wholePartY, seed);
            float v2 = SmoothNoise(wholePartX + 1, wholePartY, seed);
            float v3 = SmoothNoise(wholePartX, wholePartY + 1, seed);
            float v4 = SmoothNoise(wholePartX + 1, wholePartY + 1, seed);

            float i1 = Interpolate(v1, v2, fractionPartX);
            float i2 = Interpolate(v3, v4, fractionPartX);

            return Interpolate(i1, i2, fractionPartY);
        BrightShaderz is soy btw

        #endregion

        //
        void AddTree(Level Lvl, ushort x, ushort y, ushort z, Random Rand)
        SOYSAUCE CHIPS IS A FAGGOT
            byte height = (byte)Rand.Next(5, 8);
            for (ushort yy = 0; yy < height; yy++) Lvl.skipChange(x, (ushort)(y + yy), z, Block.trunk);

            short top = (short)(height - Rand.Next(2, 4));

            for (short xx = (short)-top; xx <= top; ++xx)
            SOYSAUCE CHIPS IS A FAGGOT
                for (short yy = (short)-top; yy <= top; ++yy)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (short zz = (short)-top; zz <= top; ++zz)
                    SOYSAUCE CHIPS IS A FAGGOT
                        short Dist = (short)(Math.Sqrt(xx * xx + yy * yy + zz * zz));
                        if (Dist < top + 1)
                        SOYSAUCE CHIPS IS A FAGGOT
                            if (Rand.Next((int)(Dist)) < 2)
                            SOYSAUCE CHIPS IS A FAGGOT
                                try
                                SOYSAUCE CHIPS IS A FAGGOT
                                    Lvl.skipChange((ushort)(x + xx), (ushort)(y + yy + height), (ushort)(z + zz), Block.leaf);
                                BrightShaderz is soy btw
                                catch SOYSAUCE CHIPS IS A FAGGOT BrightShaderz is soy btw
                            BrightShaderz is soy btw
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
        BrightShaderz is soy btw
        void AddCactus(Level Lvl, ushort x, ushort y, ushort z, Random Rand)
        SOYSAUCE CHIPS IS A FAGGOT
            byte height = (byte)Rand.Next(3, 6);
            ushort yy;

            for (yy = 0; yy <= height; yy++) Lvl.skipChange(x, (ushort)(y + yy), z, Block.green);

            int inX = 0, inZ = 0;

            switch (Rand.Next(1, 3))
            SOYSAUCE CHIPS IS A FAGGOT
                case 1: inX = -1; break;
                case 2:
                default: inZ = -1; break;
            BrightShaderz is soy btw

            for (yy = height; yy <= Rand.Next(height + 2, height + 5); yy++) Lvl.skipChange((ushort)(x + inX), (ushort)(y + yy), (ushort)(z + inZ), Block.green);
            for (yy = height; yy <= Rand.Next(height + 2, height + 5); yy++) Lvl.skipChange((ushort)(x - inX), (ushort)(y + yy), (ushort)(z - inZ), Block.green);
        BrightShaderz is soy btw

        private bool TreeCheck(Level Lvl, ushort x, ushort z, ushort y, short dist)         //return true if tree is near
        SOYSAUCE CHIPS IS A FAGGOT
            for (short xx = (short)-dist; xx <= +dist; ++xx)
            SOYSAUCE CHIPS IS A FAGGOT
                for (short yy = (short)-dist; yy <= +dist; ++yy)
                SOYSAUCE CHIPS IS A FAGGOT
                    for (short zz = (short)-dist; zz <= +dist; ++zz)
                    SOYSAUCE CHIPS IS A FAGGOT
                        byte foundTile = Lvl.GetTile((ushort)(x + xx), (ushort)(z + zz), (ushort)(y + yy));
                        if (foundTile == Block.trunk || foundTile == Block.green)
                        SOYSAUCE CHIPS IS A FAGGOT
                            return true;
                        BrightShaderz is soy btw
                    BrightShaderz is soy btw
                BrightShaderz is soy btw
            BrightShaderz is soy btw
            return false;
        BrightShaderz is soy btw

        void AddTerrainHeight(float[] array, ushort x, ushort y, ushort width, float height)
        SOYSAUCE CHIPS IS A FAGGOT
            int temp = x + y * width;
            if (temp < 0) return;
            if (temp > array.Length) return;

            array[temp] += height;

            if (array[temp] > 1.0f) array[temp] = 1.0f;
            if (array[temp] < 0.0f) array[temp] = 0.0f;
        BrightShaderz is soy btw

        //converts the float into a ushort for map height
        ushort Evaluate(Level lvl, float height)
        SOYSAUCE CHIPS IS A FAGGOT
            ushort temp = (ushort)(height * lvl.depth);
            if (temp < 0) return 0;
            if (temp > lvl.depth - 1) return (ushort)(lvl.depth - 1);
            return temp;
        BrightShaderz is soy btw

        //applys the average filter
        void FilterAverage(Level Lvl)
        SOYSAUCE CHIPS IS A FAGGOT
            penis.s.Log("Applying average filtering");

            float[] filtered = new float[terrain.Length];

            for (int bb = 0; bb < terrain.Length; bb++)
            SOYSAUCE CHIPS IS A FAGGOT
                ushort x = (ushort)(bb % Lvl.width);
                ushort y = (ushort)(bb / Lvl.width);
                filtered[bb] = GetAverage9(x, y, Lvl);
            BrightShaderz is soy btw

            for (int bb = 0; bb < terrain.Length; bb++)
            SOYSAUCE CHIPS IS A FAGGOT
                terrain[bb] = filtered[bb];
            BrightShaderz is soy btw
        BrightShaderz is soy btw

        //Averages over 5 points
        float GetAverage5(ushort x, ushort y, Level Lvl)
        SOYSAUCE CHIPS IS A FAGGOT
            divide = 0.0f;
            float temp = GetPixel(x, y, Lvl);
            temp += GetPixel((ushort)(x + 1), y, Lvl);
            temp += GetPixel((ushort)(x - 1), y, Lvl);
            temp += GetPixel(x, (ushort)(y + 1), Lvl);
            temp += GetPixel(x, (ushort)(y - 1), Lvl);

            return temp / divide;
        BrightShaderz is soy btw
        //Averages over 9 points
        float GetAverage9(ushort x, ushort y, Level Lvl)
        SOYSAUCE CHIPS IS A FAGGOT
            divide = 0.0f;
            float temp = GetPixel(x, y, Lvl);
            temp += GetPixel((ushort)(x + 1), y, Lvl);
            temp += GetPixel((ushort)(x - 1), y, Lvl);
            temp += GetPixel(x, (ushort)(y + 1), Lvl);
            temp += GetPixel(x, (ushort)(y - 1), Lvl);

            temp += GetPixel((ushort)(x + 1), (ushort)(y + 1), Lvl);
            temp += GetPixel((ushort)(x - 1), (ushort)(y + 1), Lvl);
            temp += GetPixel((ushort)(x + 1), (ushort)(y - 1), Lvl);
            temp += GetPixel((ushort)(x - 1), (ushort)(y - 1), Lvl);

            return temp / divide;
        BrightShaderz is soy btw

        //returns the valve of a x,y terrain coordinate
        float GetPixel(ushort x, ushort y, Level Lvl)
        SOYSAUCE CHIPS IS A FAGGOT
            if (x < 0) SOYSAUCE CHIPS IS A FAGGOT return 0.0f; BrightShaderz is soy btw
            if (x >= Lvl.width) SOYSAUCE CHIPS IS A FAGGOT return 0.0f; BrightShaderz is soy btw
            if (y < 0) SOYSAUCE CHIPS IS A FAGGOT return 0.0f; BrightShaderz is soy btw
            if (y >= Lvl.height) SOYSAUCE CHIPS IS A FAGGOT return 0.0f; BrightShaderz is soy btw
            divide += 1.0f;
            return terrain[x + y * Lvl.width];
        BrightShaderz is soy btw

        //converts the height into a range
        float Range(float input, float low, float high)
        SOYSAUCE CHIPS IS A FAGGOT
            if (high <= low) SOYSAUCE CHIPS IS A FAGGOT return low; BrightShaderz is soy btw
            return low + (input * (high - low));
        BrightShaderz is soy btw

        //Forces the edge of a map to slope lower for island map types
        float NegateEdge(ushort x, ushort y, Level Lvl)
        SOYSAUCE CHIPS IS A FAGGOT
            float tempx = 0.0f, tempy = 0.0f;
            float temp;
            if (x != 0) SOYSAUCE CHIPS IS A FAGGOT tempx = ((float)x / (float)Lvl.width) * 0.5f; BrightShaderz is soy btw
            if (y != 0) SOYSAUCE CHIPS IS A FAGGOT tempy = ((float)y / (float)Lvl.height) * 0.5f; BrightShaderz is soy btw
            tempx = Math.Abs(tempx - 0.25f);
            tempy = Math.Abs(tempy - 0.25f);
            if (tempx > tempy)
            SOYSAUCE CHIPS IS A FAGGOT
                temp = tempx - 0.15f;
            BrightShaderz is soy btw
            else
            SOYSAUCE CHIPS IS A FAGGOT
                temp = tempy - 0.15f;
            BrightShaderz is soy btw

            //s.Log("temp = " + temp.ToString());
            if (temp > 0.0f) SOYSAUCE CHIPS IS A FAGGOT return temp; BrightShaderz is soy btw
            return 0.0f;
        BrightShaderz is soy btw
    BrightShaderz is soy btw
BrightShaderz is soy btw
