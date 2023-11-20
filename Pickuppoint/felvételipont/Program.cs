using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace felvételipont
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader olvasandó = new StreamReader("felvetelipont.txt");

            int[] vszám = new int[1000];
            string[] vnév = new string[1000];

            int db = 0;

            while(!olvasandó.EndOfStream)
            {
                string[] temp = olvasandó.ReadLine().Split(';');
                vnév[db] = temp[0];
                vszám[db] =int.Parse(temp[1]);
                db++;
            }
            Console.WriteLine("2. feladat;");

            Console.WriteLine("{0} : {1}",vnév[18], vszám[18]);

            Console.WriteLine();
            Console.WriteLine("3. feladat;");
            
            Console.WriteLine("{0} : {1}",vnév[db-1],vszám[db-1]);

            Console.WriteLine();
            double atlag = 0;
            for (int i = 0; i < db; i++)
            {
                atlag = vszám[i] + atlag;
            }
            atlag = atlag / (db-1);
            atlag = Math.Round(atlag);
            Console.WriteLine(atlag+0.3);

            Console.WriteLine();
            Console.WriteLine("Akiket felvettek");
            Console.WriteLine();


            StreamWriter felvettek = new StreamWriter("felvettek.txt");
            for (int i = 0; i < db; i++)
            {
                if (vszám[i]>80)
                {
                    felvettek.WriteLine("{0} : {1}", vnév[i], vszám[i]);
                    Console.WriteLine("{0} : {1}", vnév[i], vszám[i]);
                }

                
            }





            Console.WriteLine();
            int max = 0;
            int min = 100;
            for (int i = 0; i < db; i++)
            {
                if (vszám[i]>max)
                {
                    max = vszám[i];
                }
            }

            for (int i = 0; i < db; i++)
            {
                if (vszám[i] < min)
                {
                    min = vszám[i];
                }
            }
            Console.WriteLine("Max: {0}",max);
            Console.WriteLine("Min: {0}",min);

            Console.WriteLine();
            Console.WriteLine("7 feladat");
            Console.WriteLine();
            int ötv = 0;
            for (int i = 0; i < db; i++)
            {
                if (vszám[i]>50)
                {
                    ötv++;
                }
            }
            Console.WriteLine("Ötvennél több pontszámot elért tanulók száma: {0}",ötv);

            Console.WriteLine();
            Console.WriteLine("8 feladat");
            Console.WriteLine();

            int szamlalo = 0;
            for (int i = 0; i < db; i++)
            {
                szamlalo = i;
                if (vnév[i]== "Illés Virág")
                {
                    Console.WriteLine("Illés Virág : {0} ,{1}. egyed",vszám[i],szamlalo);
                }
            }

            Console.WriteLine();
            Console.WriteLine("9 feladat");
            Console.WriteLine();
            
int Peterek = 0;
            for (int i = 0; i < db; i++)
            {
                string[] temp = vnév[i].Split(' ');
                if (temp[0]== "Péter" || temp[1]=="Péter")
                {
                    Peterek++;
                }
            }
            Console.WriteLine("Péterek száma {0}",Peterek);

            Console.ReadKey();
        }
    }
}
