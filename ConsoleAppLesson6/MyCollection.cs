using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson6
{
    class MyCollection
    {        
        static int course_5 = 0;
        static int course_6 = 0;

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



        /// <summary>
        /// Метод по подготовке статистики по студентам 
        /// </summary>
        static public void StatisticStudent()
        {

            List<Student> list = new List<Student>();

            // Создаем список студентов 
            DateTime dt = DateTime.Now;

            //StreamReader sr = new StreamReader(@"E:\GIT\GB_CSharp_level_1\ConsoleAppLesson6\students_6.csv");
            StreamReader sr = new StreamReader(@"D:\GIT\ConsoleAppLesson6\students_6.csv");

            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';'); // Добавляем в список новый экземпляр класса Student 
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));

                    // Одновременно подсчитываем количество студентов обучающихся на 5 и 6 курсах

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

            Console.WriteLine("Всего студентов:" + list.Count);

            // подпункт а)

            Console.WriteLine("\n a) Подсчитать количество студентов учащихся на 5 и 6 курсах\n");

            Console.WriteLine($"На 5 курсе учится: {course_5} чел.");
            Console.WriteLine($"На 6 курсе учится: {course_6} чел.");

            // подпункт б)

            Console.WriteLine("\n\n б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся\n");
            int[] mass = new int[100];

            // Подсчитываем вхождение элементов 
            foreach (var v in list)
            {   
                if (v.age >= 18 && v.age <= 20)
                mass[v.course]++;//Элемент массива a является номером в частотном массиве mass
            }
                for (int i = 0; i < mass.Length; i++)
                if (mass[i] > 0) Console.WriteLine($"\n {mass[i]} чел.  на {i} курсе");

            // подпункт в)

            Console.WriteLine("\n\n в) Отсортировать список по возрасту студента\n");

            Console.WriteLine("Не отсортированный\n");
            foreach (var v in list) Console.WriteLine($"{v.firstName} {v.age} лет");

            list.Sort(new Comparison<Student>(MyDelegat));

            Console.WriteLine("\nОтсортированный\n");
            foreach (var v in list) Console.WriteLine($"{v.firstName} {v.age} лет");

            Console.WriteLine("\n" + (DateTime.Now - dt));
            Console.ReadKey();
        }
    }
}
