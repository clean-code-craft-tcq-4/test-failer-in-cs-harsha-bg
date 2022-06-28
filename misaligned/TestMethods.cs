using System;
using System.Diagnostics;

namespace misaligned
{
    class TestMethods
    {
        public static void printColorMap()
        {
            int result = ColorMap.printColorMap();
            Debug.Assert(result == 25);
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
