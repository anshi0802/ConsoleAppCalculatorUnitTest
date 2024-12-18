using ClassLibraryBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculatorUnitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(100, 200);
            Console.WriteLine("Sum Of Two Numbers Are:");
            Console.WriteLine(result);

            Console.WriteLine("\n");

            Console.WriteLine("Subtraction Of Two Numbers Are:");
            int Sub = calculator.Subtract(300, 200);
            Console.WriteLine(Sub);
            Console.ReadLine();


        }
    }
}
