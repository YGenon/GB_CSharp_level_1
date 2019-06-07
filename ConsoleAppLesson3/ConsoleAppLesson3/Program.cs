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

    //+ *Добавить свойства типа int для доступа к числителю и знаменателю;

    //+ *Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;

    //**Добавить  проверку,  чтобы знаменатель  не равнялся  0. Выбрасывать  исключение ArgumentException("Знаменатель не может быть равен 0");

    //***Добавить упрощение дробей. 

    #endregion

    /// <summary>
    /// Операции с дробными числами
    /// </summary>
    class Fraction
    {
        int numerator1;
        int denumerator1;

        int numerator2;
        int denumerator2;

        int numerator;
        int denumerator;
        
        /// <summary>
        /// Числитель 1 дроби
        /// </summary>
        public int Numerator1
        {
            set { numerator1 = value; }
        }

        /// <summary>
        /// Знаменатель 1 дроби
        /// </summary>
        public int Denumerator1
        {
            get { return denumerator1; }
            set
            {
                if (value != 0)
                {
                    denumerator1 = value;

                } else { Console.WriteLine("Знаменатель не может быть равен 0");}
            }
        }

 
        /// <summary>
        /// Числитель 2 дроби
        /// </summary>
        public int Numerator2
        {
            set { numerator2 = value; }
        }

        /// <summary>
        /// Знаменатель 2 дроби
        /// </summary>
        public int Denumerator2
        {
            set { denumerator2 = value; }
        }

        /// <summary>
        /// Преобразует возвращаемое значение в строку
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denumerator"></param>
        /// <returns></returns>
        string OutString(int numerator, int denumerator)
        {
            return Convert.ToString(numerator) + "/" + Convert.ToString(denumerator);
        }


        /// <summary>
        /// Находим наименьший общий делеитель (НОД)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int NOD(int a, int b)
        {
            while (a != b)
                if (a > b) a = a - b; else b = b - a;
            return a;
        }

        /// <summary>
        /// Сложение дробей
        /// </summary>
        public string Summa()
        {   
            if (denumerator1 == denumerator2) { 
                numerator = numerator1 + numerator2;
                denumerator = denumerator1;
            }

            return OutString(numerator, denumerator); 
        }

        /// <summary>
        /// Вычитание дробей
        /// </summary>
        public string Difference()
        {
            if (denumerator1 == denumerator2)
            {
                numerator = numerator1 - numerator2;
                denumerator = denumerator1;
            }

            return OutString(numerator, denumerator);
        }

        /// <summary>
        /// умножение дробей
        /// </summary>
        public string Multiply()
        {
            numerator = numerator1 * numerator2;
            denumerator = denumerator1 * denumerator2;

            return OutString(numerator, denumerator);
        }

        /// <summary>
        /// Деление дробей
        /// </summary>
        public string Division()
        {
            numerator = numerator1 * denumerator2;
            denumerator = denumerator1 * numerator2;

            return OutString(numerator, denumerator);
        }
              

        /// <summary>
        /// свойство получения десятичной дроби числа
        /// </summary>
        public double FloatNumber
        {
            get
            {
                return Convert.ToDouble(numerator1) / Convert.ToDouble(denumerator1);
            }
        }

        public int Test()
        {
           return NOD(numerator1, numerator2);
        }
    }
        


    class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction();
            f.Numerator1 = 34;
            f.Denumerator1 = 3;

            f.Numerator2 = 5;
            f.Denumerator2 = 3;
            
            //string fract = (Convert.ToString(a) + "/" + Convert.ToString(b) + " и " + Convert.ToString(a1) + "/" + Convert.ToString(b1));

            

            //Console.WriteLine("\nЕсть две дроби - " + fract + "\n");
            Console.WriteLine("Сумма дробей = " + f.Summa() + "\n");
            Console.WriteLine("Вычитание дробей = " + f.Difference() + "\n");
            Console.WriteLine("Произведение дробей = " + f.Multiply() + "\n");
            Console.WriteLine("Деление дробей = " + f.Division() + "\n");
            Console.WriteLine("Десятичная дробь = " + f.FloatNumber + "\n");
            Console.WriteLine("НОД = " + f.Test() + "\n");
            Console.ReadKey();

        }
    }
}
