using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This file is made by EmJey
// Project: Calculator
// FileName: Calculator
// Date: 2023/02/05
// Email: emjeydev@gmail.com
// Github: emjeydev

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            String op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.Write(num2 + num1);
            } else if (op == "-")
            {
                Console.Write(num2 - num1);
            } else if (op == "/")
            {
                Console.Write(num2 / num1);
            } else if (op == "*")
            {
                Console.Write(num2 * num1);
            } else
            {
                Console.WriteLine("Invalid Operator");
            }


            Console.ReadLine();
        }
    }
}
