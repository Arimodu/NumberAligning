using System;
using System.Collections.Generic;
using System.Text;

namespace Tools
{
    class Randomizers
    {
        public static int[] RandomIntArrayFiller(int length)
        {
            int[] arr = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            return arr;
        }
    }
}
