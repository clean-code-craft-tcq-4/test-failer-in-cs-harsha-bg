using System;

namespace misaligned
{
    class ColorMap
    {
        public static string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
        public static string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
        public static int printColorMap()
        {
            int i = 0, j = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine("{0} | {1} | {2}", i * 5 + j+1, majorColors[i], minorColors[j]);
                }
            }
            return i * j;
        }
    }
}
