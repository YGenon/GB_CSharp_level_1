using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson6
{
    class Program
    {
       
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
            MinFunction.SaveFunc("data.bin", -100, 100, 0.5);
            Console.WriteLine(MinFunction.Load("data.bin")+"\n");
            //Console.ReadKey();
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
