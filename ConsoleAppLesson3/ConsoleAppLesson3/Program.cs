using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson3
{
    // Геннадий Ященко 

    // Задача №3

    #region условие Задачи

    //*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
    //    Предусмотреть методы  сложения,  вычитания,  умножения и  деления дробей.  
    //    Написать программу, демонстрирующую все разработанные элементы класса. 

    //+*Добавить свойства типа int для доступа к числителю и знаменателю;

    //*Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;

    //**Добавить  проверку,  чтобы знаменатель  не равнялся  0. Выбрасывать  исключение ArgumentException("Знаменатель не может быть равен 0");

    //***Добавить упрощение дробей. 

    #endregion

    /// <summary>
    /// Операции с дробными числами
    /// </summary>
    class Fraction
    {
        public int numerator;
        public int denumerator;
        public double number = FloatNumber;

        public Fraction()
        {
        }
        /// <summary>
        /// Сложение дробей
        /// </summary>
        public string Summa(int numerator1, int denumerator1, int numerator2, int denumerator2)
        {   
            if (denumerator1 == denumerator2) { 
                numerator = numerator1 + numerator2;
                denumerator = denumerator1;
            }
            
            return (Convert.ToString(numerator) + "/"+ Convert.ToString(denumerator));
        }

        /// <summary>
        /// Вычитание дробей
        /// </summary>
        public string Difference(int numerator1, int denumerator1, int numerator2, int denumerator2)
        {
            if (denumerator1 == denumerator2)
            {
                numerator = numerator1 - numerator2;
                denumerator = denumerator1;
            }

            return (Convert.ToString(numerator) + "/" + Convert.ToString(denumerator));
        }

        /// <summary>
        /// умножение дробей
        /// </summary>
        public string Multiply(int numerator1, int denumerator1, int numerator2, int denumerator2)
        {
            numerator = numerator1 * numerator2;
            denumerator = denumerator1 * denumerator2;

            return (Convert.ToString(numerator) + "/" + Convert.ToString(denumerator));
        }

        /// <summary>
        /// Деление дробей
        /// </summary>
        public string Division(int numerator1, int denumerator1, int numerator2, int denumerator2)
        {
            numerator = numerator1 * denumerator2;
            denumerator = denumerator1 * numerator2;

            return (Convert.ToString(numerator) + "/" + Convert.ToString(denumerator));
        }

        public double FloatNumber()
        {
            numerator = 3;
            denumerator = 9;
            int rezult = numerator / denumerator;
            return ((rezult));

        }
    }
        


    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            int a1 = 5;
            int b1 = 3;

            string fract = (Convert.ToString(a) + "/" + Convert.ToString(b) + " и " + Convert.ToString(a1) + "/" + Convert.ToString(b1));

            Fraction f = new Fraction();

            Console.WriteLine("\nЕсть две дроби - " + fract + "\n");
            Console.WriteLine("Сумма дробей = " + f.Summa(a, b, a1, b1) + "\n");
            Console.WriteLine("Вычитание дробей = " + f.Difference(a, b, a1, b1) + "\n");
            Console.WriteLine("Произведение дробей = " + f.Multiply(a, b, a1, b1) + "\n");
            Console.WriteLine("Деление дробей = " + f.Division(a, b, a1, b1) + "\n");
            Console.ReadKey();

        }
    }
}
