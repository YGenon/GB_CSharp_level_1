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
        /// <summary>
        /// 3 задача - Создаем метод для сравнения экземпляров 
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <returns></returns>
        static int MyDelegat(Student st1, Student st2) 
        {
            return String.Compare(st1.firstName, st2.firstName); //  Сравниваем две строки 
        }

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
            

            MinFunction.SaveFunc("data.bin", -100, 100, 0.5);
            Console.WriteLine(MinFunction.Load("data.bin"));
            Console.ReadKey();
            #endregion


            #region Задача 3
            #region Условие
            // Переделать программу "Пример использования коллекций" для решения следующих задач:
            //  а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
            //  б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
            //  в) отсортировать список по возрасту студента;
            //  г) *отсортировать список по курсу и возрасту студента;

            #endregion

            int bakalavr = 0;
            int magistr = 0;

            List<Student> list = new List<Student>();

            // Создаем список студентов 
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader(@"D:\GIT\ConsoleAppLesson6\students_6.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';'); // Добавляем в список новый экземпляр класса Student 
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    // Одновременно подсчитываем количество бакалавров и магистров 
                    if (int.Parse(s[5]) < 5) bakalavr++; else magistr++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main 
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }

            sr.Close();

            list.Sort(new Comparison<Student>(MyDelegat));

            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalavr);

            foreach (var v in list) Console.WriteLine(v.firstName);

            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();

            #endregion

        }
    }
}
