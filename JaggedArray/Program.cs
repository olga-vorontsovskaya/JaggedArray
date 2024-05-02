using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];

            a[0] = new int[2];
            a[1] = new int[3];
            a[2] = new int[4];

            Random random = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                for (int x = 0; x < a[i].Length; x++)
                {
                    a[i][x] = random.Next(1,10);
                    Console.Write(a[i][x] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
