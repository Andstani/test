using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string shouldContinue;
            do
            {
                Console.WriteLine("Alege Operatie:");
                // added branch "Operatii"
                Console.WriteLine("1.Adunare");
                Console.WriteLine("2.Scadere");
                Console.WriteLine("3.Inmultire");
                Console.WriteLine("4.Impartire");
                Console.WriteLine("5.Ridicare la putere");
                Console.WriteLine("6.Radacina patrata");
                Console.WriteLine("7.Modul de x");

                // added branch par/impar, prim
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
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ai ales operatia de Adunare. Alege valoarea lui A");
                    Console.WriteLine("A=");
                    double a;
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" Alege valoarea lui B");
                    Console.WriteLine("B=");
                    double b;
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"A+B={a + b}");

                }
                if (operatie == "2")
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Ai ales operatia de Scadere. Alege valoarea lui A");
                    Console.WriteLine("A=");
                    double a;
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" Alege valoarea lui B");
                    Console.WriteLine("B=");
                    double b;
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"A-B={a - b}");
                }
                if (operatie == "3")
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Ai ales operatia de Inmultire. Alege valoarea lui A");
                    Console.WriteLine("A=");
                    double a;
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" Alege valoarea lui B");
                    Console.WriteLine("B=");
                    double b;
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"A*B={a * b}");
                }
                if (operatie == "4")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Ai ales operatia de Impartire. Alege valoarea lui A");
                    Console.WriteLine("A=");
                    double a;
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" Alege valoarea lui B");
                    Console.WriteLine("B=");
                    double b;
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"A/B={a / b}");

                }
                if (operatie == "5")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Ai ales operatia de Ridicare la putere. Alege valoarea lui A");
                    Console.WriteLine("A=");
                    int a;
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" Alege valoarea lui B");
                    Console.WriteLine("B=");
                    int b;
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"A^B={Math.Pow(a, b)}");

                }
                if (operatie == "6")
                {
                    Console.WriteLine("Ai ales operatia de aflare a Radacinii patrate. Alege valoarea lui A");
                    Console.WriteLine("A=");
                    int a;
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Radacina patrata a lui A={Math.Sqrt(a)}");
                }
                if (operatie == "7")
                {
                    Console.WriteLine("Ai ales operatia de aflare a Valorii absolute (Modul de x). Alege valoarea lui A");
                    Console.WriteLine("A=");
                    double a;
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Valoarea absoluta a lui A={Math.Abs(a)}");
                }
                if (operatie == "8")
                {
                    Console.WriteLine("Ai ales sa afli daca numarul este par/impar. Alege valoarea lui A");
                    Console.WriteLine("A=");
                    int a;
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a % 2 == 0)
                    {
                        Console.WriteLine($"A={a} este numar par.");
                    }
                    else
                    {
                        Console.WriteLine($"A={a} este numar impar.");
                    }
                }

                if (operatie == "9")
                {
                    Console.WriteLine("Ai ales sa afli daca numarul este prim. Alege valoarea lui A");
                    Console.WriteLine("A=");
                    int a;
                    a = Convert.ToInt32(Console.ReadLine());

                    if (IsPrime(a))
                    {
                        Console.WriteLine($"{a} este numar prim");
                    }
                    else
                    {
                        Console.WriteLine($"{a} nu este numar prim");

                    }

                }
                if (operatie == "10")
                {
                         Console.WriteLine("Ai ales sa afli oglinditul unui numar. Alege valoarea lui A");
                         Console.WriteLine("A=");
                         int a;
                         a = Convert.ToInt32(Console.ReadLine());
                    int b = a;
                         int oglindit = 0;
                         int reminder;
     
                         while (b > 0)
                         {
                             reminder = b % 10;
                             oglindit = oglindit * 10 + reminder;
                             b =  b / 10;
                         }
                             Console.WriteLine($"Oglinditul numarului {a} este {oglindit}");
                }
                if (operatie == "11")
                {
                    Console.WriteLine("Ai ales sa afli daca un numar este palindrom. Alege valoarea lui A");
                    Console.WriteLine("A=");
                    int a;
                    a = Convert.ToInt32(Console.ReadLine());

                    if (IsPalindrom(a))
                    {
                        Console.WriteLine($"{a} este numar palindrom");
                    }
                    else
                    {
                        Console.WriteLine($"{a} nu este numar palindrom");

                    }

                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Vrei sa continui cu alta operatie?");
                Console.WriteLine("1.Da\n2.Nu");

                shouldContinue = Console.ReadLine();
                Console.Clear();
            } while (shouldContinue == "1");


        }

        static bool IsPrime(int numar)
        {
            bool isPrime = true;
            if (numar == 1 || numar == 0)
                isPrime = false;
            for (int i = 2; i < Math.Sqrt(numar); i++)
            {
                if (numar % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        private static bool IsPalindrom(int b)
        {
            bool isPalindrom = true;
            int oglindit = 0;
            int reminder;
            int numar = b;

            while (numar > 0)
            {
                reminder = numar % 10;
                oglindit = oglindit * 10 + reminder;
                numar = numar / 10;
                
            }

            Console.WriteLine($"Oglinditul numarului {b} este {oglindit}");

            if (b == oglindit)
                isPalindrom = true;
            else
                isPalindrom = false;
            return isPalindrom;
            
        
        }

    }
}   