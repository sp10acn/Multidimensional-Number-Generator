using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_Generation_Class
{
    class Generator
    {
        // Private Variables
        private int _seed;
        private SubtractiveGenerator gen;

        // Public Variables
        public int Seed {
            get { return _seed; }
            set { _seed = value; }
        }

        public Generator() {
            _seed = (int)(new Random().Next(0, int.MaxValue) + int.MaxValue);
            Init();
        }

        public Generator(int seed) {
            _seed = seed;
            Init();
        }

        private void Init() {
            // Initialize class
            gen = new SubtractiveGenerator(_seed);
        }

        public int[] GetSequence1D(int length, int minValue, int maxValue) {
            int[] result = new int[length];
            int range = maxValue - minValue;

            for (int i = 0; i < length; i++)
            {
                result[i] = (int)((double)gen.next() / (double)SubtractiveGenerator.MAX * (double)range) + minValue;
            }
            return result;
        }

        public int[,] GetSequence2D(int length, int width, int minValue, int maxValue) {
            int[,] result = new int[length, width];
            int range = maxValue - minValue;

            for (int l = 0; l < length; l++)
            {
                for (int w = 0; w < width; w++)
                {
                    result[l, w] = (int)((double)gen.next() / (double)SubtractiveGenerator.MAX * (double)range) + minValue;
                }
            }
            return result;
        }
    }
}
