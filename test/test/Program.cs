using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Alege Operatie:");
            // added branch "Operatii"
            Console.WriteLine("1.Adunare");
            Console.WriteLine("2.Scadere");
            Console.WriteLine("3.Inmultire");
            Console.WriteLine("4.Impartire");
            Console.WriteLine("5.Ridicare la putere");
            Console.WriteLine("6.Radacina patrada");
            Console.WriteLine("7.Modul de x");

            // un branch
            Console.WriteLine("8.Par / Impar");
            Console.WriteLine("9.Prim");

            // un branch
            Console.WriteLine("10.Oglindit");
            Console.WriteLine("11.Palindrom");
            Console.WriteLine("12.SuperPalindrom");
            Console.WriteLine("13.Afiseaza numerele palindrom si superpalindrom intre 1 si 10000");

            var operatie = Console.ReadLine();

            if (operatie == "1")
            {
                Console.WriteLine("Ai ales operatia de adunare. Te rog alege valoarea lui A");
                Console.WriteLine("A=");
                int a;
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Te rog alege valoarea lui B");
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
