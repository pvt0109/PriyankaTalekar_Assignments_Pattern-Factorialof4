using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPattern_Factorialof4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StarPattern1();
                StarPatter2();
                Factorialof4();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }

        public static void StarPattern1()
        {
            try
            {
                int i, j;

                for (i = 1; i <= 5; i++)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write("* ");

                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Please Press Enter Button To Find The Next Result");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }


        }

        public static void StarPatter2()
        {
            try
            {
                int i, j, n;


                n = 4;
                for (i = 1; i <= n; i++)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine("\n");
                }
                for (i = 1; i <= n; i++)
                {
                    for (j = 4; j >= i; j--)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine("\n");
                }
                Console.WriteLine("Please Press Enter Button To Find The Next Result");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }

        public static void Factorialof4()
        {
            try
            {
                int numberInt = 4;

                int factorial = 1;

                for (int i = numberInt; i >= 2; i--)
                {
                    factorial = factorial * i;
                    //Console.WriteLine(factorial.ToString());
                }

                Console.WriteLine("The Factorial of 4 is " + factorial.ToString());
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }


        }
    }
}
