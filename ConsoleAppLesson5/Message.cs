using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson5
{
    static public class Message
    {
        static string newString;
        static string[] splitString;
        static string lastSymbol;
        static string outWord;


        /// <summary>
        /// Создаем массив из слов сообщения
        /// </summary>
        /// <param name="s"></param>
        static string[] MessageArray(string s)
        {
            char[] div = {' '};
            string [] splitStringTmp = s.Split(div);

            return splitStringTmp;
        }

        
        /// <summary>
        /// Выводит слова сообщения,  которые содержат не более n букв.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="a"></param>
        static public string OutWords(string s, int a)
        {
            splitString = MessageArray(s);
            
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
            splitString = MessageArray(s);

            newString = " ";

            for (int i = 0; i < splitString.Length; i++)
            {
                // узнаем длинну слова
                var a = splitString[i].Length;
                if (a > 1)
                {
                     lastSymbol = splitString[i].Substring(a - 1, 1);
                } else { lastSymbol = splitString[i]; }
                    
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
            splitString = MessageArray(s);
            newString = splitString[0];

            //if​ ​(​char​.​IsPunctuation​(splitString​[​i​]))​ splitString​.​Remove​(​i​,​1​);

            for (int i = 0; i < splitString.Length; i++)
           {
                int a = splitString[i].Length;
                int b = newString.Length;

                if (a > b) newString = splitString[i];                
            }
            return (" " + newString);
        }

        
        /// <summary>
        /// Формирует строку с помощью StringBuilder из самых длинных слов сообщения
        /// </summary>
        /// <param name="s"></param>
        static public string StringFromLongWords(string s)
        {
            splitString = MessageArray(s);

            StringBuilder str = new StringBuilder();

            //Array.Sort(splitString);
            newString = splitString[0];

            
            for (int i = 0; i < splitString.Length; i++)
            {
                outWord = splitString[i];
                int a = splitString[i].Length;
                int b = newString.Length;

                if (a > b)
                {
                    outWord = splitString[i];                    
                }                
            }
            return (" " + str.Append(" " + outWord));            
        }
    }
}
