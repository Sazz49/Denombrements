using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static long fact(int n)
        {
            if (n < 0)
            {
                return 0;
            }
            if ((n == 1) || (n==0))
            {
                return 1;
            }
            else
            {
               return n * fact(n - 1);
            }
        }
        static void Main(string[] args)
        {
            int c = 1;
            while (c != 0)
            {
                do
                {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());
                }
                while ((c<0) ||(c>3));
                if (c == 0) 
                { 
                    Environment.Exit(0); 
                }
                if (c == 1)
                { Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                    int n = int.Parse(Console.ReadLine()); // saisir le nombre
                    long r = fact(n);                      // calcul de r
                    Console.WriteLine(n + "! = " + r);
                }
                else
                {
                    if (c == 2)
                    {
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int t = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int n = int.Parse(Console.ReadLine()); // saisir le nombre
                        long r = fact(t) / fact(t-n); // calcul de r

                        Console.WriteLine("A(" + t + "/" + n + ") = " + r); //Console.WriteLine("résultat = " + (r1 / r2));
                    }
                    else
                    {
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int t = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int n = int.Parse(Console.ReadLine()); // saisir le nombre
                        long r1 = fact(t);// calcul de r1                       
                        long r2 = fact(t-n)*fact(n);// calcul de r2               
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2)); //Console.WriteLine("résultat = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
