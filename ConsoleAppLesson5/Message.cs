using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson5
{
    static public class Message
    {
        static private string newString;


        /// <summary>
        /// Выводит слова сообщения,  которые содержат не более n букв.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="a"></param>
        static public string OutWords(string s, int a)
        {

            //newString = s + a;
            char[] div = { ' ' };
            string[] splitString = s.Split(div);
            for (int i = 0; i < splitString.Length; i++)
            {
                if (splitString[i].Length <= a) newString += " " + splitString[i];

                //Console.WriteLine(splitString[i]);
            }

            return newString;
        }

                        
       /// <summary>
       /// Удаляет из сообщения все слова, которые заканчиваются на заданный символ.
       /// </summary>
       /// <param name="s"></param>
       /// <param name="b"></param>
       /// <returns></returns>
        static string DellWords(string s, string b)
        {
            

            return newString;
        }


        //в) Найти самое длинное слово сообщения.
        static void LongWords(string s)
        {

        }

        //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        static void StringFromLongWords(string s)
        {

        }
    }
}
