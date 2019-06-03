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
            Console.WriteLine();
            Console.WriteLine("1 задача \n");

            Console.Write("Введите первое число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            string rezult = " - минимальное число";

            if (firstNumber < secondNumber && firstNumber < thirdNumber) 
            {
                Console.Write(firstNumber + rezult);
            } else
            {
                Console.WriteLine((secondNumber < thirdNumber) ? (secondNumber + rezult): (thirdNumber + rezult));
            }
                   

            Console.ReadKey();

            #endregion

            #region 2 задача
            #region Условие задачи:

            //С клавиатуры  вводятся числа, пока  не будет  введен  0. Подсчитать  сумму всех  нечётных положительных чисел.

            #endregion

            Console.WriteLine();
            Console.WriteLine("2 задача \n");

            
            //Console.Write("Введите ваш вес: ");
            //string wt = Console.ReadLine();

            //Console.Write("Введите ваш рост: ");
            //string heightInput = Console.ReadLine();

            //double heightMan = Convert.ToDouble(heightInput) / 100;

            //double imt = Convert.ToDouble(wt) / (heightMan * heightMan);

            //Console.Write("Ваш индекс массы тела: " + imt);

            //Console.ReadKey();

            #endregion

            #region 3 задача
            #region Условие задачи:
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) *Сделать задание, только вывод организовать в центре экрана.

            #endregion

            //Console.Clear();
            //Console.WriteLine("3 задача \n");

            //Console.WriteLine("a). Геннадий Ященко г. Москва");

            //Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            //Console.WriteLine("б). Геннадий Ященко г. Москва");

            //Console.ReadKey();

            #endregion
        }
    }
}
