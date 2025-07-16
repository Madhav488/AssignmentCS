using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCS
{
    internal class Assignment1
    {
        static void Main()
        {
            Byte i;
            Console.WriteLine("Enter choice between 1-10:");
            i = Convert.ToByte(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("Hello world");
                    break;
                case 2:
                    Console.WriteLine("Enter first number");
                    int num1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int num2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine($"Sum,Difference,Product and quotient of {num1} and {num2} are {num1 + num2}, {num1 - num2}, {num1 * num2} and {num1 / num2} respectively");
                    break;
                case 3:

                    Console.WriteLine("Enter first number");
                    int numb1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int numb2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter choice");
                    int cha = Convert.ToByte(Console.ReadLine());
                    switch (cha)
                    {
                        case 1:
                            Console.WriteLine($"{numb1}+{numb2}");
                            break;
                        case 2:
                            Console.WriteLine($"{numb1}-{numb2}");
                            break;
                        case 3:
                            Console.WriteLine($"{numb1}*{numb2}");
                            break;
                        case 4:
                            Console.WriteLine($"{numb1}/{numb2}");
                            break;
                        default:
                            Console.WriteLine("Wrong choice");
                            break;

                    }
                    break;
                case 4:
                    string name;
                    Console.WriteLine("Enter your name");
                    name = Console.ReadLine();
                    int num = 1;
                    while (num <= 10)
                    {
                        Console.WriteLine(num);
                        num++;
                    }
                    break;
                case 5:
                    int eve = 1;
                    Console.WriteLine("Even numbers using do-while:");
                    do
                    {
                        if (eve % 2 == 0)
                            Console.WriteLine(i);
                        i++;
                    } while (eve <= 20);
                    break;
                case 6:
                    Console.WriteLine("Odd numbers using for:");
                    for (int z = 1; z <= 20; z++)
                    {
                        if (z % 2 != 0)
                            Console.WriteLine(z);
                    }
                    break;
                case 7:
                    Console.WriteLine("Enter number for Table:");
                    int t = Convert.ToInt16(Console.ReadLine());
                    ;
                    for (int k = 1; k <= 10; k++)
                    {
                        Console.WriteLine($"{t} x {k}= {t * k}");
                    }
                    break;
                case 8:
                    Console.WriteLine("Numbers from 100 to 5 with a gap of 3:");
                    for (int l = 100; l >= 5; l -= 3)
                    {
                        Console.WriteLine(l);
                    }
                    break;
                case 9:
                    int a = 1;
                    int b = 2;
                    int c = 3;

                    Console.Write(a);
                    Console.Write(b);
                    Console.Write(c);
                    break;
                case 10:
                    int d = 10;
                    int e = 20;
                    int f = 30;

                    Console.WriteLine(d);
                    Console.WriteLine(e);
                    Console.WriteLine(f);
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;


            }
        }
    }
}
