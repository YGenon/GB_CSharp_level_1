using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ященко Геннадий

            #region 1 задача
            #region Условие задачи:
            //Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
            //В результате вся информация выводится в одну строчку:
            //    а) используя склеивание;
            //    б) используя форматированный вывод;
            //    в) используя вывод со знаком $.

            #endregion
            Console.WriteLine();
            Console.WriteLine("1 задача \n");

            Console.Write("Введите ваше имя: ");
            string firstName = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            string lastName = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            string age = Console.ReadLine();

            Console.Write("Введите ваш рocт: ");
            string height = Console.ReadLine();

            Console.Write("Введите ваш вес: ");
            string weight = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(firstName + " " + lastName + " Возраст: " + age + " Рост: " + height + " Вес: " + weight);
            Console.WriteLine("{0} {1} Возраст: {2} Рост: {3} Вес: {4}", firstName, lastName, age, height, weight);
            Console.WriteLine($"{firstName} {lastName} Возраст: {age} Рост: {height} Вес: {weight}");
            
            Console.ReadKey();

            #endregion

            #region 2 задача
            #region Условие задачи:
            //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h);
            //где m — масса тела в килограммах, h — рост в метрах.
            #endregion

            Console.WriteLine();
            Console.WriteLine("2 задача \n");

            Console.Write("Введите ваш вес: ");
            string wt = Console.ReadLine();

            Console.Write("Введите ваш рост: ");
            string heightInput = Console.ReadLine();

            double heightMan = Convert.ToDouble(heightInput) / 100;

            double imt = Convert.ToDouble(wt) / (heightMan * heightMan);

            Console.Write("Ваш индекс массы тела: " + imt);

            Console.ReadKey();

            #endregion

            #region 3 задача
            #region Условие задачи:
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) *Сделать задание, только вывод организовать в центре экрана.

            #endregion

            Console.Clear();
            Console.WriteLine("3 задача \n");

            Console.WriteLine("a). Геннадий Ященко г. Москва");

            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine("б). Геннадий Ященко г. Москва");

            Console.ReadKey();

            #endregion
        }
    }
}
