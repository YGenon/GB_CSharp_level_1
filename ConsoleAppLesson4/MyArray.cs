using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson4
{   
    /// <summary>
    /// Статический класс для операций с массивами
    /// </summary>
    static class MyArray
    {
        /// <summary>
        /// Метод реализущий поиск пары в которой только одно из чисел делится на 3
        /// </summary>
        /// <param name="inArray"></param>
        /// <returns></returns>
        static public int FindPair(int[] inArray)
        {

            int count = 0;

            // ищем пару в которой только одно из чисел делится на 3
            for (int j = 0; j <= inArray.Length - 1; j += 2)
            {
                double a = inArray[j] % 3;
                double b = inArray[j + 1] % 3;

                if (a == 0 & b != 0 || b == 0 & a != 0)
                {
                    Console.WriteLine("Пара " + inArray[j] + " и " + inArray[j + 1] + " - один из элементов делится на 3");
                    count++;
                }
                else { Console.WriteLine("Пара " + inArray[j] + " и " + inArray[j + 1]); }
            }

            return  count;
            
        }

    }
}
