using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson5
{   
    struct Elements
    {
        public string FIO;
        public int N;
    }

    class Program
    {
        static void Main(string[] args)
        {

            // Геннадий Ященко

            #region Задача 2 

            //Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            //а) Вывести только те слова сообщения,  которые содержат не более n букв.
            //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            //в) Найти самое длинное слово сообщения.
            //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            //д) ***Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, 
            //   в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.

            #endregion

            Console.WriteLine("\nЗадача 2\n ");
            //string message = "Кто ищет тот всегда найдет или не кракозябра найдет и пропадет скукатища";
            string message = "А что подумал по этому поводу Кролик, никто так и не узнал, потому что Кролик был очень воспитанный";

            Console.WriteLine("Дано сообщение: "+ message + "\n");

            
            int longMessage = 5;
            Console.WriteLine("\n пункт а)\nВыводим слова сообщения, которые содержат не более " + longMessage + " букв -\n");
            Console.WriteLine(Message.OutWords(message, longMessage));

            string symbol = "у";
            Console.WriteLine("\nпункт б)\nУдалить из сообщения все слова, которые заканчиваются на символ - \"" + symbol + "\" \n");
            Console.WriteLine(Message.DellWords(message, symbol));

            Console.WriteLine("\nпункт в)\nНаходим самое длинное слово сообщения - \n");
            Console.WriteLine(Message.LongWords(message));

            Console.WriteLine("\nпункт г)\nФормируем строку с помощью StringBuilder из самых длинных слов сообщения: \n");
            Console.WriteLine(Message.StringFromLongWords(message));

           
            #region Задача 4 

            //*Задача ЕГЭ.
            //На вход программе подаются сведения о сдаче экзаменов учениками 9 - х классов некоторой средней школы. 

            //В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
            //< Фамилия > < Имя > < оценки >,
            //где < Фамилия > — строка, состоящая не более чем из 20 символов, 
            //    < Имя > — строка, состоящая не более чем из 15 символов, 
            //    < оценки > — через пробел три целых числа, 
            // соответствующие оценкам по пятибалльной системе. < Фамилия > и<Имя>, а также<Имя> и<оценки> разделены одним пробелом. Пример входной строки:
            // Иванов Петр 4 5 3

            //Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
            // Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.

            #endregion

            Console.WriteLine("\nЗадача 4\n ");

            StreamReader sr = new StreamReader(@"D:\GIT\ConsoleAppLesson5\ege.txt");            
            int N = int.Parse(sr.ReadLine());            
            Elements[] a = new Elements[N];

            for (int i = 0; i < N; i ++)
            {
                string[] s = sr.ReadLine().Split(' ');
                a[i].FIO = Convert.ToString(s[0]) + " " + Convert.ToString(s[1]);
                a[i].N = (int.Parse(s[2]) + int.Parse(s[3]) + int.Parse(s[4]))/3;
                
            }
            sr.Close();

            //ищем самый низкий средний бал 

            int min_N = a[0].N;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i].N < min_N)
                {
                    min_N = a[i].N;                    
                }
            }

            StringBuilder str2 = new StringBuilder();
            int count = 0;

            // ищем студентов с самым низким средним балом
            //начинаем с минимального среднего балла если с ним набирается меньше 3 студентов увеличиваем мин. ср. бал на 1 и проходим
            // по массиву еще раз пока не наберем минимум 3 и более студентов.

            do
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i].N == min_N)
                    {
                        Console.Write(a[i].FIO + " ");
                        Console.Write(a[i].N + "\n");
                        count++;
                    }
                }
                min_N++;

            } while (count < 3);

            
            Console.ReadKey();
        }

        
    }
}
