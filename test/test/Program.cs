using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Alege Operatie:");
            // un branch
            Console.WriteLine("1.Adunare");
            Console.WriteLine("2.Scadere");
            Console.WriteLine("3.Inmultire");
            Console.WriteLine("1.Impartire");
            Console.WriteLine("2.Ridicare la putere");
            Console.WriteLine("3.Radacina patrada");
            Console.WriteLine("1.Modul de x");

            // un branch
            Console.WriteLine("2.Par / Impar");
            Console.WriteLine("3.Prim");

            // un branch
            Console.WriteLine("3.Oglindit");
            Console.WriteLine("3.Palindrom");
            Console.WriteLine("3.SuperPalindrom");
            Console.WriteLine("3.Afiseaza numerele palindrom si superpalindrom intre 1 si 10000");

            var operatie = Console.ReadLine();

            if (operatie == "1")
            {
                Console.WriteLine("A=");
                int a;
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("B=");
                int b;
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"A+B={a + b}");
            }
            if (operatie == "2")
            {
                Console.WriteLine("A=");
                int a;
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("B=");
                int b;
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"A-B={a - b}");
            }

        }
    }
}
