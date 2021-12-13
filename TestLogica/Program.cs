using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogica
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] left = new int[] { 1, 3, 2, 6, 9 };
            int[] right = new int[] { 0, 0, 0, 0, 0 };
            for (int i = 0; i < left.Length; i++)
            {
                Console.WriteLine(left[i]);
            }

            right =Swapping.ArraySwap(right);
            left = Swapping.ArraySwap(left);

            Console.WriteLine("changed the array");
            for (int i = 0; i < left.Length; i++)
            {
                Console.WriteLine(left[i]);
                Console.WriteLine(right[i]);
            }

        }
    }
}
