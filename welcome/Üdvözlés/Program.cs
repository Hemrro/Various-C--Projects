using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Üdvözlés
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üdvözlő program");
            Console.WriteLine();
            string folytat;
            do
            {
                Console.WriteLine("Gépeld be a neved");
                Console.Write("A név: ");

                string nev = Console.ReadLine();
                Console.WriteLine();
              
                if (nev == "UwU")
                {
                   for (int i = 0; i < 2000; i++)
			{
                Random r = new Random();
                        long genRand= r.Next(5000000,999999999);
                        Console.WriteLine(+genRand);
			}
                   for (int i =1;i<3000;i++)
                    {
                        Console.WriteLine("###THREAD DETECTED!###"); 
                         
                    }
                   for (int i = 0; i < 1500; i++)
			{
                Console.WriteLine("#SYSTEM SHUTTING DOWN!#");
			}
          System.Diagnostics.Process.Start("shutdown","/s /t 0"); 
                }
                else
                {
                    Console.WriteLine("Üdvözöllek kedves {0}!", nev);
                }
                

                Console.WriteLine();
                Console.WriteLine("Mégegyszer? [i+enter / n+enter]");

                folytat = Console.ReadLine();


            }
            while (folytat == "i");
             

        }
    }
}
