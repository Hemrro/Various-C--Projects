using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATRIX
{
    class Program
    {
        static int[,] terep= new int [102,102];
        static void kezdo_allapot()
        {
            for (int i = 0; i <= 101; i++)
            {
            terep[0, i] = 0;
            terep[101, 1] = 0;
            terep[i,0] = 0;
            terep[i, 101] = 0;
            }
            Random v = new Random();
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 1; j <= 100; j++)
                {
                    terep[i, j] = v.Next(10);
                }
            }
        }

        static void terep_w()
        {
            for (int i = 0; i <= 101; i++)
            {
                for (int j = 0; j <= 101; j++)
                {
                    Console.Write(terep[i, j]);
                }
                Console.WriteLine();
            }


        }


        static void Main(string[] args)
        {
            kezdo_allapot();
            terep_w();
            Console.Write("Sor:"); int sor = int.Parse(Console.ReadLine());
            Console.Write("Oszlop"); int oszlop = int.Parse(Console.ReadLine());
            Console.Write("A megadott cellában a szám összege");




            Console.ReadKey();
        }
    }
}
