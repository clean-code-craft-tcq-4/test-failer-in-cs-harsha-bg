using System;

namespace misaligned
{
    class ColorMap
    {
        public static string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
        public static string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
        public static int printColorMap()
        {
            int majorColorsIndex = 0, minorColorsIndex = 0;
            for (majorColorsIndex = 0; majorColorsIndex < majorColors.Length; majorColorsIndex++)
            {
                for (minorColorsIndex = 0; minorColorsIndex < minorColors.Length; minorColorsIndex++)
                {
                    Console.WriteLine("{0} | {1} | {2}", majorColorsIndex * 5 + minorColorsIndex+1, majorColors[majorColorsIndex], minorColors[minorColorsIndex]);
                }
            }
            return majorColorsIndex * minorColorsIndex;
        }
    }
}
