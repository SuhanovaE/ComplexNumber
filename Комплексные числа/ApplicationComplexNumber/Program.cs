using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryComplexNumber;

namespace ApplicationComplexNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое число");
            ClassComplexNumber complexNumber = new ClassComplexNumber();
            complexNumber.X = 112.2;
            complexNumber.Y = 9.56;
            Console.WriteLine(complexNumber.ToString());
            Console.WriteLine("Второе число");
            ClassComplexNumber complexNumber1 = new ClassComplexNumber();
            complexNumber1.X = double.Parse(Console.ReadLine());
            complexNumber1.Y = double.Parse(Console.ReadLine());
            Console.WriteLine(complexNumber1.ToString());
            

            Console.WriteLine("Сумма:");                     
            Console.WriteLine(complexNumber.Summation(complexNumber1).ToString());

            Console.WriteLine("Разность:");
            Console.WriteLine(complexNumber.Substraction(complexNumber1).ToString());

            Console.WriteLine("Умножени:");
            Console.WriteLine(complexNumber.Multiplication(complexNumber1).ToString());

            Console.WriteLine("Деление:");
            Console.WriteLine(complexNumber.Divisionm(complexNumber1).ToString());

            ClassComplexNumber complexNumber3 = new ClassComplexNumber(44, -100);
            Console.WriteLine(complexNumber3.ToString());
            Console.ReadKey();
        }
    }
}
