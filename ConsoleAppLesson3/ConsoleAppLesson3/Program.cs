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
        int in_numerator1;
        int in_denumerator1;

        int in_numerator2;
        int in_denumerator2;

        int return_numerator;
        int return_denumerator;
        
        // -------  Свойства

        /// <summary>
        /// Числитель 1 дроби
        /// </summary>
        public int Numerator1
        {
            get { return in_numerator1; }
            set { in_numerator1 = value; }
        }

        /// <summary>
        /// Знаменатель 1 дроби
        /// </summary>
        public int Denumerator1
        {
            get { return in_denumerator1; }
            set
            {
                if (value != 0)
                {
                    in_denumerator1 = value;

                } else
                {
                    Console.WriteLine("\n Знаменатель не может быть равен 0 ! \n");
                    in_denumerator1 = value;
                }
            }
        }
 
        /// <summary>
        /// Числитель 2 дроби
        /// </summary>
        public int Numerator2
        {
            get { return in_numerator2; }
            set { in_numerator2 = value; }
        }

        /// <summary>
        /// Знаменатель 2 дроби
        /// </summary>
        public int Denumerator2
        {
            get { return in_denumerator2; }
            set
            {
                if (value != 0 & Denumerator1 == value)
                {
                    in_denumerator2 = value;

                }
                else
                {
                    Console.WriteLine("\n Знаменатель не может быть равен 0 и должен быть равен знаменателю первой дроби!\n");
                    in_denumerator2 = value;
                }
            }
        }


        //--------- Методы

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
        /// Находим наибольший общий делитель (НОД)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int NOD(int a, int b)
        {
            while ((a != 0) && (b != 0))
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            return Math.Max(a, b);
        }

        /// <summary>
        /// Сложение дробей
        /// </summary>
        public string Summa()
        {   
            if (in_denumerator1 == in_denumerator2) { 
                return_numerator = in_numerator1 + in_numerator2;
                return_denumerator = in_denumerator1;
            }
            //else
            //{
            //    int NOK = Math.Abs(in_denumerator1 * in_denumerator2) / NOD(in_denumerator1, in_denumerator2);

            //    int extra_multiplier1 = NOK / in_denumerator1;
            //    int extra_multiplier2 = NOK / in_denumerator2;

            //    return_numerator = in_numerator1 * extra_multiplier1 + in_numerator2 * extra_multiplier2;
            //    return_denumerator = in_denumerator1 * extra_multiplier1;
            //}

            return OutString(return_numerator, return_denumerator); 
        }

        /// <summary>
        /// Вычитание дробей
        /// </summary>
        public string Difference()
        {
            if (in_denumerator1 == in_denumerator2)
            {
                return_numerator = in_numerator1 - in_numerator2;
                return_denumerator = in_denumerator1;
            }

            return OutString(return_numerator, return_denumerator);
        }

        /// <summary>
        /// умножение дробей
        /// </summary>
        public string Multiply()
        {
            return_numerator = in_numerator1 * in_numerator2;
            return_denumerator = in_denumerator1 * in_denumerator2;

            return OutString(return_numerator, return_denumerator);
        }

        /// <summary>
        /// Деление дробей
        /// </summary>
        public string Division()
        {
            return_numerator = in_numerator1 * in_denumerator2;
            return_denumerator = in_denumerator1 * in_numerator2;

            return OutString(return_numerator, return_denumerator);
        }
              

        /// <summary>
        /// свойство получения десятичной дроби числа
        /// </summary>
        public double FloatNumber
        {
            get
            {
                return Convert.ToDouble(in_numerator1) / Convert.ToDouble(in_denumerator1);
            }
        }

        public int Test()
        {
            return NOD(in_numerator1, in_numerator2);
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction();

            
            Console.Write("Введите числитель первой дроби : ");
            f.Numerator1 = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write("Введите знаменатель первой дроби : ");
                f.Denumerator1 = Convert.ToInt32(Console.ReadLine());

            } while (f.Denumerator1 == 0);

            Console.Write("\nВведите числитель второй дроби : ");
            f.Numerator2 = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write("Введите знаменатель второй дроби : ");
                f.Denumerator2 = Convert.ToInt32(Console.ReadLine());
            } while (f.Denumerator2 == 0 || f.Denumerator1 != f.Denumerator2);

            //f.Numerator1 = 34;
            //f.Denumerator1 = 3;

            //f.Numerator2 = 5;
            //f.Denumerator2 = 3;
            
            string fract = f.Numerator1 + "/" + f.Denumerator1 + " и " + f.Numerator2 + "/" + f.Denumerator2;            

            Console.WriteLine("\nЕсть две дроби - " + fract + "\n");
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
