using System;
using System.IO;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson6
{
    class Program
    {
        //Геннадий Ященко
        static void Main(string[] args)
        {

            #region Задача 2
            #region Условие задачи
            // Модифицировать программу "нахождения минимума функции" так, чтобы можно было передавать функцию в виде делегата.
            //  а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке 
            //    находить минимум. Использовать массив(или список) делегатов, в котором хранятся различные функции.
            //  б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через 
            //    параметр(с использованием модификатора out).
            #endregion

            Console.WriteLine(" Задача 2 \n");

            DlgSaveFunc mySaveFunc = MinFunction.SaveFunc;
            DlgLoad myload = MinFunction.Load;
             
            int key;

            Console.WriteLine("Введите 1 - если вы хотите расчитать функцию с заданными параметрами");
            Console.WriteLine("Введите 2 - если вы хотите ввести параметры для расчета функции вручную");
            Console.WriteLine("Введите 0 - для выхода из меню");

            // меню выбора 
            do {
                Console.Write("Введите число: ");
                key = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (key == 1)
                {
                    MinFunction.SaveFunc("data.bin", -100, 100, 0.5);
                    Console.WriteLine(myload("data.bin") + "\n");
                }

                if (key == 2)
                {                    
                    Console.Write("Введите начало отрезка: ");
                    Double a = Double.Parse(Console.ReadLine());

                    Console.Write("Введите конец отрезка: ");
                    Double b = Double.Parse(Console.ReadLine());

                    Console.Write("Введите шаг: ");
                    Double c = Double.Parse(Console.ReadLine());

                    mySaveFunc("data.bin", a, b, c);
                    Console.WriteLine(myload("data.bin") + "\n");
                }
            } while (key != 0);

            Console.Write("Вы вышли из программы!\n\n");

            #endregion


            #region Задача 3
            #region Условие
            // Переделать программу "Пример использования коллекций" для решения следующих задач:
            // + а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
            //  б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
            // + в) отсортировать список по возрасту студента;
            //  г) *отсортировать список по курсу и возрасту студента;

            #endregion

            Console.WriteLine(" Задача 3 \n");
            MyCollection.StatisticStudent();            

            #endregion

        }
    }
}
