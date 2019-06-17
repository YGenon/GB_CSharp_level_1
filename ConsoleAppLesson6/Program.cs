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
            //return String.Compare(st1.firstName, st2.firstName); //  Сравниваем две строки 
            return String.Compare(Convert.ToString(st1.age), Convert.ToString(st2.age));
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

            //int bakalavr = 0;
            //int magistr = 0;
            int course_5 = 0;
            int course_6 = 0;


            List<Student> list = new List<Student>();

            // Создаем список студентов 
            DateTime dt = DateTime.Now;
            
            StreamReader sr = new StreamReader(@"E:\GIT\GB_CSharp_level_1\ConsoleAppLesson6\students_6.csv");            

            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';'); // Добавляем в список новый экземпляр класса Student 
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));

                    // Одновременно подсчитываем количество бакалавров и магистров 
                    //if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;

                    if (int.Parse(s[6]) == 5) course_5++;
                    if (int.Parse(s[6]) == 6) course_6++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main 
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }

            sr.Close();

            //list.Sort(new Comparison<Student>(MyDelegat));
            

            Console.WriteLine("Всего студентов:" + list.Count + "\n");
            //Console.WriteLine("Магистров:{0}", magistr);
            //Console.WriteLine("Бакалавров:{0}", bakalavr);

            Console.WriteLine("\n a) Подсчитать количество студентов учащихся на 5 и 6 курсах\n");

            Console.WriteLine($"На 5 курсе учится: {course_5} чел.");
            Console.WriteLine($"На 6 курсе учится: {course_6} чел.");

            Console.WriteLine("\n в) Отсортировать список по возрасту студента\n");

            Console.WriteLine("\nНе отсортированный\n");
            foreach (var v in list) Console.WriteLine($"{v.firstName} {v.age} лет");

            list.Sort(new Comparison<Student>(MyDelegat));

            Console.WriteLine("\nОтсортированный\n");
            foreach (var v in list) Console.WriteLine($"{v.firstName} {v.age} лет");

            Console.WriteLine("\n" + (DateTime.Now - dt));
            Console.ReadKey();

            #endregion

        }
    }
}
