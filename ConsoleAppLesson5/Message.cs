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
        static string[] splitString;

        /// <summary>
        /// Создаем массив из слов сообщения
        /// </summary>
        /// <param name="s"></param>
        static void MessageArray(string s)
        {
            char[] div = {' '};
            splitString = s.Split(div);
        }


        /// <summary>
        /// Выводит слова сообщения,  которые содержат не более n букв.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="a"></param>
        static public string OutWords(string s, int a)
        {
            MessageArray(s);
            
            for (int i = 0; i < splitString.Length; i++)
            {
                if (splitString[i].Length <= a) newString += " " + splitString[i];                
            }

            return newString;
        }

                        
       /// <summary>
       /// Удаляет из сообщения все слова, которые заканчиваются на заданный символ.
       /// </summary>
       /// <param name="s"></param>
       /// <param name="b"></param>
       /// <returns></returns>
        static public string DellWords(string s, string b)
        {
            MessageArray(s);
            newString = " ";
            for (int i = 0; i < splitString.Length; i++)
            {
                // узнаем длинну слова
                var a = splitString[i].Length;
                var lastSymbol = splitString[i].Substring(a-1, 1);
                if (lastSymbol != b) newString += " " + splitString[i];
            }
            return newString;           
        }


        
        /// <summary>
        /// Находим самое длинное слово сообщения
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static public string LongWords(string s)
        {
            MessageArray(s);
            newString = splitString[0];

            for (int i = 0; i < splitString.Length; i++)
            {
                var a = splitString[i].Length;
                var b = newString.Length;

                if (a > b) newString = " " + splitString[i];                
            }
            return newString;
        }

        //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        static void StringFromLongWords(string s)
        {

        }
    }
}
