using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryComplexNumber
{ 
    /// <summary>
    /// библиотека класса комплексного числа
    /// </summary>
    public class ClassComplexNumber
    {
        //x + y*i;
        private double x;//действительная
        private double y;//мнимая

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        /// <summary>
        /// конструкторы
        /// </summary>
        public ClassComplexNumber() //конструктор по умолчанию
        {
            x = 0;
            y = 0;
        }
        public ClassComplexNumber(double a, double b) // конструктор с параметрами
        {
            x = a;
            y = b;
        }
        public override string ToString()// перезагрухка метода ToString()
        {
            return $"{x} + {y}*i";
        }
        public string Summation(ClassComplexNumber complex2)//сумма
        {
            ClassComplexNumber c3 = new ClassComplexNumber();
            c3.x = x + complex2.x;
            c3.y = y + complex2.y;
            return c3.ToString();
        }
        public string Substraction(ClassComplexNumber complex2)//вычитание
        {
            ClassComplexNumber c3 = new ClassComplexNumber();
            c3.x = x - complex2.x;
            c3.y = y - complex2.y;
            return c3.ToString();
        }
        //добавить умножение
        public string Multiplication(ClassComplexNumber complex2)//вычитание
        {
            ClassComplexNumber c3 = new ClassComplexNumber();
            c3.x = (x * complex2.x - y * complex2.y);
            c3.y = (x * complex2.y - y * complex2.x);
            return c3.ToString();
        }
        //деление
        public string  Divisionm(ClassComplexNumber complex2)//вычитание
        {
            ClassComplexNumber c3 = new ClassComplexNumber();
            c3.x = (x * complex2.x + y * complex2.y)/(complex2.x* complex2.x + complex2.y* complex2.y);
            c3.y = (y * complex2.x - x * complex2.y) / (complex2.x * complex2.x + complex2.y * complex2.y);
            return c3.ToString();
        }

    }
}
