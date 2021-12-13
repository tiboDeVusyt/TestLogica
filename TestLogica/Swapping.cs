using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogica
{
    public class Swapping
    {
        public static int[] ArraySwap(int[] right1)
        {
            int[] left = new int[] { 1, 3, 2, 6, 9 };
            for (int i = 0; i < left.Length; i++)
            {
                right1[i] = left[i];
            }
            return right1;
        }
        public static int[] ArraySwapLeft(int[] left1)
        {
            int[] right = new int[] { 0, 0, 0, 0, 0 };
            for (int i = 0; i < left1.Length; i++)
            {
                right[i] = left1[i];
            }
            return left1;
        }
    }
}
