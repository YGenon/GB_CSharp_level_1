using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson2
{
    class Program
    {
        // Ященко Геннадий

        /// <summary>
        /// Проверка введенного логина и пароля
        /// </summary>
        /// <param name="login"></param>
        /// <param name="passwd"></param>
        /// <returns></returns>
        static Boolean Authorization(string login, string passwd)
        {
            if (login == "root" && passwd == "GeekBrains")
            {
                Console.WriteLine(" \n Вы авторизованы в системе! \n");
                return true;
            }
            else
            {
                Console.WriteLine("\n Логин или пароль не верен! \n");
                return false;
            }
        }

        /// <summary>
        /// Подсчет суммы цифр в многозначном числе (через строчный метод)
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static UInt32 SummaNumber(string text)
        {
            uint summa = 0;

            for (int i = 0; i < text.Length; i++)
            {
                summa += Convert.ToUInt32(text.Substring(i, 1));
            }
            return summa;
        }

        /// <summary>
        /// Подсчет суммы цифр в многозначном числе (математ. метод)
        /// </summary>
        /// <param name="inNumber"></param>
        /// <returns></returns>
        static UInt32 Summa(UInt32 inNumber)
        {
            UInt32 summaNumber = 0;

            while (inNumber > 0)
            {
                summaNumber = summaNumber + inNumber % 10;
                inNumber = inNumber / 10;
            }
            return summaNumber;
        }

        // ===================================================================================================

        static void Main(string[] args)
        {


            #region 1 задача
            #region Условие задачи:

            //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains).
            //Используя метод проверки логина и пароля, написать программу: пользователь вводит  логин и  пароль,  программа пропускает  его дальше  или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.
            #endregion


            Console.WriteLine("1 задача - Проверки логина и пароля \n");

            int count = 0;
            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();

                Console.Write("Введите пароль: ");
                string passwd = Console.ReadLine();

                if (Authorization(login, passwd)) break;
                count++;
                // Console.Clear();

            } while (count < 3);

            if (count == 3) Console.WriteLine("Количество попыток ввода исчерпано ! \n");
            Console.ReadKey();

            #endregion

            #region 2 задача
            #region Условие задачи:

            //Написать метод, возвращающий минимальное из трёх чисел.

            #endregion

            Console.WriteLine();
            Console.WriteLine("2 задача - Возвращение минимального числа из трёх введенных чисел \n");

            Console.Write("Введите первое число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            string rezult = "Минимальное введеное число - ";

            if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                Console.WriteLine(rezult + firstNumber + "\n");
            }
            else
            {

                if (secondNumber < thirdNumber)
                {
                    Console.WriteLine(rezult + secondNumber + "\n");
                }
                else
                {
                    Console.WriteLine(rezult + thirdNumber + "\n");
                }
            }
            Console.ReadKey();

            #endregion

            #region 3 задача
            #region Условие задачи:

            //С клавиатуры  вводятся числа, пока  не будет  введен  0. Подсчитать  сумму всех  нечётных положительных чисел.

            #endregion

            Console.WriteLine();
            Console.WriteLine("3 задача - Ввод чисел и подсчет суммы всех нечетных, положительных чисел\n");
            Console.WriteLine("Для завершения программы введите цифру - 0 \n");

            int number;
            int odd = 0;

            do
            {
                Console.Write("Введите целое число: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 > 0 && number > 0)
                {
                    odd += number;
                }

                if (number == 0)
                {
                    Console.WriteLine("\n Сумма все нечетных, положительных чисел равна - " + odd + "\n \n");
                    break;
                }

            } while (number != 0);

            Console.ReadKey();

            #endregion

            #region 4 задача
            #region Условие задачи:

            // Написать метод подсчета количества цифр числа.

            #endregion

            Console.WriteLine("4 задача - Подсчет количества цифр числа\n");

            Console.Write("Введите многозначное, положительное число: ");
            string text = Console.ReadLine();

            Console.WriteLine("\nСумма цифр введенного числа равняется - " + SummaNumber(text) + "\n \n");
            Console.ReadKey();

            #endregion

            #region 5 задача
            #region Условие задачи:

            //*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
            //«Хорошим»  называется число, которое  делится на  ​сумму своих  цифр​.Реализовать подсчёт времени выполнения программы,
            //используя структуру DateTime.


            #endregion

            Console.WriteLine("5 задача - Программа подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000 \n");

            DateTime start = DateTime.Now;
            UInt32 count2 = 0;

            for (UInt32 i = 1; i <= 1000000000; i++)
            {
                //1 variant - Core i7 - 17:50

                //string b = Convert.ToString(i);
                //UInt32 a = SummaNumber(b);

                //2 variant - Core i7 - 1:48

                UInt32 a = Summa(i);

                if (i % a == 0) count2++;
                if(i == 100000 || i == 1000000 || i == 10000000  || i == 1000000000) Console.WriteLine("Нашли числа до " + i + "\n");

            }
            Console.WriteLine();
            Console.WriteLine("Количество \"Хороших чисел\" - " + count2 + "\n");

            
            DateTime end = DateTime.Now;
            Console.WriteLine( "Время затраченное на расчет: " + (end - start));

            Console.ReadKey();

            #endregion
        }

    }
}
