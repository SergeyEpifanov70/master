using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace DirectoryManager
{
    //Задание 9.6.1
    #region
    public delegate void Handler(); // объявляем делегата
    #endregion

    class Program
    {

        //Задание 9.6.1
        #region

        public static event Handler MyEvent1; // объявляем событие

        class MyException : ApplicationException
        {
            public void MyExceptiona()
            {
                Console.WriteLine("Произошло исключение");
            }
            public void SurnameHasDigitException()
            {
                Console.WriteLine("Ошибка. В фамилии содержится цифра");
            }

            public void SurnameHasNullException()
            {
                Console.WriteLine("Ошибка. В фамилии нет ниодной буквы");
            }

            public void SurnameIsAnimalsNicknameException()
            {
                Console.WriteLine("Ошибка. Это кличка животного");
            }

            public void SurnameHasPunctuationException()
            {
                Console.WriteLine("Ошибка. В фамилии содержаться знаки препинания");
            }

        }

        //проверка на наличие цифры в строке
        public static bool IsSurnameHasDigit(string str)
        {
            foreach (char c in str)
            {
                if (c == '0' | c == '1' | c == '2' | c == '3' | c == '4' | c == '5' | c == '6' | c == '7' | c == '8' | c == '9')
                {
                    //Console.WriteLine(c);
                    return true;
                    break;
                }

            }

            return false;
        }

        //проверка на пустую строку
        public static bool IsSurnameHasNull(string с)
        {
            if (с == "")
                return true;

            return false;
        }

        //проверка на кличку животного
        public static bool IsSurnameIsAnimalsNickname(string c)
        {
            if (c == "Шарик" | c == "Тузик" | c == "Мурзик" | c == "Кеша")
                return true;

            return false;
        }


        //проверка на пустую строку
        public static bool IsSurnameHasPunctuation(string str)
        {
            foreach (char c in str)
            {
                if (Char.IsPunctuation(c))
                {
                    return true;
                    break;
                }
            }
            return false;
        }

        private static int Geek1(string x, string y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    //если х и у указывают на null, то тогда они равны
                    return 0;
                }

                else
                {
                    // Если x равно null, но y не равно null, тогда y больше.
                    return -1;
                }
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }

                else
                {
                    // прямая сортировка        
                    return x.CompareTo(y);
                }
            }
        }

        private static int Geek2(string x, string y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    //если х и у указывают на null, то тогда они равны
                    return 0;
                }

                else
                {
                    // Если x равно null, но y не равно null, тогда y больше.
                    return -1;
                }
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }

                else
                {
                    // прямая сортировка        
                    return y.CompareTo(x);
                }
            }
        }

        private static void Display(List<string> list)
        {
            foreach (string g in list)
            {
                Console.WriteLine(g);
            }
        }

        #endregion


        public static void Main(string[] args)
        {

            //Задание 9.6.1
            #region

            MyEvent1 += SortList1;
            MyEvent1();

        }

        static void SortList1()
        {

            // Формируем пользовательский список фамилий
            Console.WriteLine("Напишите, пожалуйста, 5 любых фамилий.");
            Console.WriteLine("После ввода каждой фамилии нажимите ENTER.");

            List<string> list1 = new List<string>();

            for (int i = 0; i < 5; i++)
            {

                var surname = Console.ReadLine();

                try
                {

                    if (IsSurnameHasDigit(surname) |
                        IsSurnameHasNull(surname) |
                        IsSurnameIsAnimalsNickname(surname) |
                        IsSurnameHasPunctuation(surname))
                    {
                        throw new MyException();
                    }

                    list1.Add(surname);
                    Console.WriteLine("Отлично. Данная фамилия вошла в список");

                }
                catch (MyException e)
                {
                    if (IsSurnameHasDigit(surname))
                        e.SurnameHasDigitException();

                    if (IsSurnameHasNull(surname))
                        e.SurnameHasNullException();

                    if (IsSurnameIsAnimalsNickname(surname))
                        e.SurnameIsAnimalsNicknameException();

                    if (IsSurnameHasPunctuation(surname))
                        e.SurnameHasPunctuationException();

                    i--;
                }

            }


            Console.WriteLine("Исходный список:\n");
            Display(list1);

            Console.WriteLine("\nЗадайте направление сортировки.");
            Console.WriteLine("Подсказка. 1 - это сортировка от А до Я");
            Console.WriteLine("Любая другая цифра - это сортировка от Я до А \n");
            byte sortDirect = Convert.ToByte(Console.ReadLine());

            if (sortDirect == 1)
            {
                Console.WriteLine("\nОтсортировано от А до Я\n");
                list1.Sort(Geek1);
            }
            else
            {
                Console.WriteLine("\nОтсортировано от Я до А\n");
                list1.Sort(Geek2);
            }

            // Показываем отсортированный список
            Display(list1);
            Console.WriteLine("\n\n\n");

        }

        #endregion
    }
}