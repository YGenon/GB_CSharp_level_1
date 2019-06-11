using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Геннадий Ященко

            #region 1 задача

            #region Условие задачи

            //Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать  целые
            //значения  от  –10  000  до  10  000  включительно.Заполнить случайными  числами. Написать
            //программу, позволяющую найти и вывести количество пар элементов массива, в которых только
            //одно  число делится  на  3. В  данной задаче  под парой  подразумевается два  подряд идущих
            //элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

            #endregion

            int[] number = new int[20];
            Random random_number = new Random();
            int count = 0;

            Console.Write("Решение 1 задачи:\n\n");
            Console.Write("Дан  массив: ");

            // заполняем массив с помощью генератора случайных чисел и выводим его на консоль
            for (int i = 0; i <= number.Length - 1; i++)
            {
                //number[i] = random_number.Next(-10_000,10_000);
                number[i] = random_number.Next(-10, 10);
                Console.Write(number[i] + ",");
            }

            Console.WriteLine("\n");

            // ищем пару в которой только одно из чисел делится на 3
            for (int j = 0; j <= number.Length - 1; j += 2)
            {                                
                double a = number[j] % 3;
                double b = number[j + 1] % 3;

                if (a == 0 & b != 0 || b == 0 & a != 0)
                {
                    Console.WriteLine("Пара " + number[j] + " и " + number[j + 1] + " - один из элементов делится на 3");
                    count++;
                }
                else { Console.WriteLine("Пара " + number[j] + " и " + number[j + 1]); }
            }

            Console.WriteLine("\nОтвет - " + count + "\n");

            #endregion

            #region 2 задача

            #region Условие задачи

            //Реализуйте задачу 1 в виде статического класса StaticClass;
            //а)  Класс должен  содержать статический  метод,  который принимает на вход массив и решает задачу 1;           

            #endregion
            
            Console.Write("\nРешение 2 задачи:\n\nРезультат работы статического класса:\n\n");

            Console.WriteLine("\nОтвет: " + MyArray.FindPair(number));
            
            #endregion
            
            Console.ReadKey();
        }
    }
}
