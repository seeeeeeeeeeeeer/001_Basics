using System;

namespace _001_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Console.WriteLine("Hello Serhij");

            //Console.WriteLine("aaaaaaa");

            //Console.WriteLine("bbbbbbb");

            //int a;

            //int A;

            //int a = 4, b = 5;
            //int sum = a + b;

            //Console.WriteLine(sum);

            //Console.WriteLine(a + " + " + b +"=" + sum);

            //Console.WriteLine("{0}+{1}={2}",a,b,sum);

            // Console.WriteLine($"{a} + {b} = {sum}"); 

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Welcome, {name}");

            //byte b = 123;
            //Console.WriteLine(b);

            // int a;


            //string stringA = Console.ReadLine();
            //string stringB = Console.ReadLine();

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //// string sumStr = stringA + stringB;

            //int sum = a + b;

            //Console.WriteLine(sum);

            //int code = Console.Read();
            // Console.WriteLine(code);

            //char s = (char)Console.Read();
            //Console.WriteLine(s);

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.BackgroundColor = ConsoleColor.Green;  // Заміна кольору консольки
            // Console.WriteLine("Hello");


            //int a = 4;
            //if(a==4)
            //{
            //    Console.WriteLine("Hello");
            //}
            //else
            //{
            //    Console.WriteLine("Goodbye");
            //}

            // int i = 0;
            //while(i<10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //do
            //{
            //    Console.WriteLine(i);
            //} while (i < 10);

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.Write($"{i * j} \t");
            //    }
            //    Console.WriteLine();
            //}


            //int a = 4, b = 5;
            //int max = a > b ? a : b;
            //Console.WriteLine(max);

            // Неявне приведенн 

            //double d = 3.67;
            //int a = d;

            //int a = 5;
            //double d = a;


            // Явне приведення

            //double d = 3.67;
            //int a = (int)d;


            //int a = 1;
            //switch(a)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wensday");
            //        break;
            //    default:
            //        Console.WriteLine("Error");
            //        break;
            //}

            //string color = "blue";
            //switch (color)
            //{
            //    case "red":
            //        Console.WriteLine("Apple");
            //        break;
            //    case "green":
            //        Console.WriteLine("Grass");
            //        break;
            //    case "blue":
            //        Console.WriteLine("Sky");
            //        break;
            //    default:
            //        Console.WriteLine("Error");
            //        break;
            //}

            //Console.Write("Enter first num");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //string sign = Console.ReadLine();

            //Console.Write("Enter second num");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //int res = 0;

            //switch (sign)
            //{
            //    case "+":
            //        res = num1 + num2;
            //        break;
            //    case "-":
            //        res = num1 - num2;
            //        break;
            //    default:
            //        break;
            //}
            //Console.WriteLine(res);


            Console.Write("Enter first num: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            string sign = Console.ReadLine();

            Console.Write("Enter second num: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int res = 0;

            switch (sign)
            {
                case "+":
                    res = num1 + num2;
                    break;
                case "-":
                    res = num1 - num2;
                    break;
                case "*":
                    res = num1 * num2;
                    break;
                case "/":
                    res = num1 / num2;
                    break;
                default:
                    break;
            }
            Console.WriteLine(res);

        }
    }
}
