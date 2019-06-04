using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ященко Геннадий

            #region 1 задача
            #region Условие задачи:

            //Написать метод, возвращающий минимальное из трёх чисел.

            #endregion

            //Console.WriteLine();
            //Console.WriteLine("1 задача \n");

            //Console.Write("Введите первое число: ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введите второе число: ");
            //int secondNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введите третье число: ");
            //int thirdNumber = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();

            //string rezult = " - минимальное число";

            //if (firstNumber < secondNumber && firstNumber < thirdNumber) 
            //{
            //    Console.Write(firstNumber + rezult);
            //} else
            //{
            //    Console.WriteLine((secondNumber < thirdNumber) ? (secondNumber + rezult): (thirdNumber + rezult));
            //}


            //Console.ReadKey();

            #endregion

            #region 2 задача
            #region Условие задачи:

            //С клавиатуры  вводятся числа, пока  не будет  введен  0. Подсчитать  сумму всех  нечётных положительных чисел.

            #endregion

            //Console.WriteLine();
            //Console.WriteLine("2 задача \n");
            //Console.WriteLine("Для завершения программы введите цифру - 0 \n");

            //int number;
            //int odd = 0;

            //do
            //{               
            //    Console.Write("Введите целое число: ");
            //    number = Convert.ToInt32(Console.ReadLine());
            //    if (number % 2 > 0 && number > 0)
            //    {
            //        odd += number;
            //    }

            //    if (number == 0)
            //    {
            //        Console.WriteLine("Сумма все нечетных, положительных чисел равна - " + odd);
            //        break;
            //    }

            //} while (number != 0);


            //Console.ReadKey();

            #endregion

            #region 3 задача
            #region Условие задачи:

            // Написать метод подсчета количества цифр числа.

            #endregion

            Console.Clear();
            Console.WriteLine("3 задача \n");

            Console.Write("Введите многозначное число: ");
            string text = Console.ReadLine();
            
            int summa = 0;

            for (int i = 0; i < text.Length; i++)
            {
                summa += Convert.ToInt32(text.Substring(i, 1));
            }

            Console.WriteLine("Сумма цифр введенного числа равняется - " + summa);
            Console.ReadKey();

            #endregion
        }
    }
}
