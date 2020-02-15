using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Unesite broj > ");

            int input = int.Parse(Console.ReadLine());

            /*double count = 1;

            while (count != input + 1)
            {

                if (count % 3 == 0 && count % 5 == 0)
                {
                    Console.WriteLine($"Fizz buzz {count}");
                    count++;

                }
                else if (count % 5 == 0)
                {
                    Console.WriteLine($"Buzz {count}");
                    count++;

                }
                else if (count % 3 == 0)
                {
                    Console.WriteLine($"Fizz {count}");
                    count++;

                }
                else
                {
                    Console.WriteLine(count);
                    count++;
                } */

            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"Fizz buzz {i}");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"Buzz {i}");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"Fizz {i}");

                }
                else
                {
                    Console.WriteLine(i);
                }
            }

                   /* while (input != 1)
                    {
                        if (input % 2 == 0)
                        {
                            input /= 2;
                            Console.WriteLine(input);
                        }
                        else
                        {
                            input = input * 3 + 1;
                            Console.WriteLine(input);
                        }

                    }
                    int num1 = 1;
                    int num2 = 0;
                    int fibonachi = 0;
                    while (fibonachi != input) {
                        if (input > fibonachi) {
                            Console.WriteLine($"Broj {input} nije u fibonacijevom nizu!");
                            break;
                        }
                        fibonachi = num1 + num2;
                        Console.WriteLine(fibonachi);
                        num1 = num2;
                        num2 = fibonachi;

                    } */
                    Console.ReadKey();
             

        }
    }
}

   


