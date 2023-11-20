using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nevek_a_megyében
{
    class Program
    {
        static void Main(string[] args)
        {
            int db = 0;
            string[] knevek = new string[500];
            StreamReader nevek = new StreamReader("havi_nevek.txt");
            while (!nevek.EndOfStream)
            {
                knevek[db] = nevek.ReadLine();
                db++;
                
            }
            Console.WriteLine();
            Console.WriteLine("1 feladat;");
            Console.WriteLine();

            Console.WriteLine("Az elsőnek született gyerek a(z) {0}", knevek[0]);

            Console.WriteLine();
            Console.WriteLine("2 feladat;");
            Console.WriteLine();


            int gyerekszam = 0;
            for (int i = 0; i < db; i++)
            {
                gyerekszam = gyerekszam + db;
            }
            Console.WriteLine("számú gyerek született ebben a hónapban: {0}",gyerekszam);


            Console.WriteLine();
            Console.WriteLine("3 feladat;");
            Console.WriteLine();

            Console.WriteLine(knevek[db - 1]);

            Console.WriteLine();
            Console.WriteLine("4 feladat;");
            Console.WriteLine();

            for (int i = 0; i < db; i++)
            {
                if (knevek[i]=="Töhötöm")
                {
                    Console.WriteLine("Van töhötöm");
                }
                else
                {
                    Console.WriteLine("Nincs töhötöm");
                }
            }

            Console.WriteLine();
            Console.WriteLine("5 feladat;");
            Console.WriteLine();

            int leghosszabb = 0;
            string legnev = "";
            for (int i = 0; i < db; i++)
            {
                if (knevek[i].Length > leghosszabb)
                {
                    leghosszabb = knevek[i].Length;
                    legnev = knevek[i];
                }
                
            }
            Console.WriteLine("A leghosszabb név a {0} és {1} tagú",legnev,leghosszabb);
        }
    }
}
