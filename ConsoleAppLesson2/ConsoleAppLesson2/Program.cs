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
        /// Подсчет суммы цифр в многозначном числе
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static int SummaNumber(string text)
        {
            int summa = 0;

            for (int i = 0; i < text.Length; i++)
            {
                summa += Convert.ToInt32(text.Substring(i, 1));
            }
            return summa;
        }

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
            else { 

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
                    Console.WriteLine("Сумма все нечетных, положительных чисел равна - " + odd +"\n \n");
                    break;
                }

            } while (number != 0);

            Console.ReadKey();

            #endregion

            #region 4 задача
            #region Условие задачи:

            // Написать метод подсчета количества цифр числа.

            #endregion

            Console.Clear();
            Console.WriteLine("4 задача - Подсчет количества цифр числа\n");

            Console.Write("Введите многозначное число: ");
            string text = Console.ReadLine();           

            Console.WriteLine("Сумма цифр введенного числа равняется - " + SummaNumber(text));
            Console.ReadKey();

            #endregion
        }

    }
}
