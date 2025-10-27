using System;
using System.Diagnostics.CodeAnalysis;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("калькулятор");
            int b;
            int a;
            string data;
            string operation;
            Console.WriteLine("число 1");
            data = Console.ReadLine();
            a = Convert.ToInt32(data);
            Console.WriteLine("число 2");
            data = Console.ReadLine();
            b = Convert.ToInt32(data);
            int resultPlus = a + b;
            Console.WriteLine("ваша операция/действие");
            operation = Console.ReadLine();

            switch(operation)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
            }
            Console.ReadLine();
        }
    }
}
