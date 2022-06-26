using System;

class MainClass
{



    //Итоговое задание 5.6
    #region
    static int ControlAge(int age1)
    {
        bool flag = true;
        do
        {
            if (age1 < 1)
            {
                Console.WriteLine("Введите корректное значение вашего возраста, надо указать количество полных лет");
                flag = false;
            }
        }
        while (true);

        return age1;
    }



    static bool ControlHasAnimal(string hasanimal1)
    {
        bool answer = true;
        string hasanimal2 = hasanimal1;
        bool flag = true;
        do
        {
            if (hasanimal2 != "Да" | hasanimal2 != "да")
            {
                if (hasanimal2 == "Нет" | hasanimal2 == "нет")
                {
                    answer = false;
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите корректный ответ - или да, или нет");
                    hasanimal2 = Console.ReadLine();
                    flag = false;
                }
            }
            if (hasanimal2 == "Да" | hasanimal2 == "да")
            {
                answer = true;
                flag = true;
            }
        }
        while (flag);

        return answer;
    }





    static int ControlQuantityAnimals(int quantityanimal1)
    {
        int quantityanimal2 = quantityanimal1;
        bool flag = true;
        do
        {
            if (quantityanimal2 == 0)
            {
                Console.WriteLine("Вы не любите животных, да/нет?");
                var temp1 = Console.ReadLine();
                if (temp1 == "Да" | temp1 == "да")
                {
                    quantityanimal2 = 0;
                }
                else
                {
                    if (quantityanimal2 < 0)
                    {
                        Console.WriteLine("Пожалуйста, введите корректное число");
                        quantityanimal2 = int.Parse(Console.ReadLine());
                        flag = false;
                    }
                }
            }
        }
        while (flag);
        return quantityanimal2;
    }

    static int ControlQuantityFlowers(int quantityflowers1)
    {
        int quantityflowers2 = quantityflowers1;
        bool flag = true;
        do
        {
            if (quantityflowers2 == 0)
            {
                Console.WriteLine("Вы не любите цветы, да/нет?");
                var temp1 = Console.ReadLine();
                if (temp1 == "Да" | temp1 == "да")
                {
                    quantityflowers2 = 0;
                }
                else
                {
                    if (quantityflowers2 < 0)
                    {
                        Console.WriteLine("Пожалуйста, введите корректное число");
                        quantityflowers2 = int.Parse(Console.ReadLine());
                        flag = false;
                    }
                }
            }
        } 
        while (flag);
        return quantityflowers2;
    }




    static string[] ArrayFavoritAnimals(int i)
    {
        string[] FavoritAnimals = new string[i];
        for(i = 0; i < FavoritAnimals.Length; i++)
        {
            Console.WriteLine("Введите кличку {0} питомца", i);
            string nickname = Console.ReadLine();
            FavoritAnimals[i] = nickname;
        }
        return FavoritAnimals;
    }
 
    


    static string[] ArrayFavoritFlowers(int i)
    {
        string[] FavoritFlowers = new string[i];
        for(int j = 0; j < FavoritFlowers.Length; j++)
        {
            Console.WriteLine("Введите название {0} цветка", j);
            string flower = Console.ReadLine();
            FavoritFlowers[j] = flower;
        }
        return FavoritFlowers;
    }




    static Tuple<string, string, int, bool, int, int> Opros()
    {
        (string name, string lastname, int age, bool hasanimal, int quantityanimals, int quantityflowers) anketa;

        Console.WriteLine("Введите своё имя");
        anketa.name = Console.ReadLine();

        Console.WriteLine("Введите свою фамилию");
        anketa.lastname = Console.ReadLine();

        Console.WriteLine("Сколько вам полных лет?");
        anketa.age = ControlAge(int.Parse(Console.ReadLine()));

        Console.WriteLine("Есть ли у вас домашнее животное, Да/Нет?");
        anketa.hasanimal = ControlHasAnimal(Console.ReadLine());


        int item1 = ControlQuantityAnimals(int.Parse(Console.ReadLine()));
        anketa.quantityanimals = item1;
        if (item1 > 0)
        {
            ArrayFavoritAnimals(item1);
        }

        Console.WriteLine("Сколько у вас любимых цветов, их количество?");
        int item2 = ControlQuantityFlowers(int.Parse(Console.ReadLine()));
        anketa.quantityflowers = item2;
        if (item2 > 0)
        {
            ArrayFavoritFlowers(item2);
        }

        return Tuple.Create(anketa.name, anketa.lastname, anketa.age, anketa.hasanimal, anketa.quantityanimals, anketa.quantityflowers);
    }



    static void ShowOpros(Tuple<string, string, int, bool, int, int> anketa1)
    {
        Console.WriteLine("Ваше имя - " + anketa1.Item1);
        Console.WriteLine("Ваша фамилия - " + anketa1.Item2);
        Console.WriteLine("Ваш возраст - " + anketa1.Item3);
        Console.WriteLine("Наличие у вас животных - " + anketa1.Item4);
        Console.WriteLine("У вас содержится следующее кол-во животных - " + anketa1.Item5);
        Console.WriteLine("Общее количество любимых вами видов цветов - " + anketa1.Item6);
    }

    #endregion





    // -----------------------

    //Архив
    #region




    //Задача 5.5.8
    #region
    /*
    private static decimal PowerUp(int N, byte pow)
    {
        decimal temp = 1;
        if (pow == 0)
        {
            return 1;
        }
        else
        {
            if (pow == 1)
            {
                return N;
            }
            else
            {
                
                //for (var i = 1; i < pow + 1; i++)
                //{
                    //temp = temp * N;
                //}
                
                return N*PowerUp(N, --pow);

            }

        }

        return temp;

    }
    */
    #endregion





    //Задача 5.5.5
    #region
    /*
    static decimal Factorial(int x)
    {

        if (x == 0)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }
    */
    #endregion




    //Задача 5.5.3
    #region
    /*
    static void Eho(string phrase, ref int deep)
    {

        var modif = phrase;
        
        if (modif.Length > 2)
        {
            modif = modif.Remove(0, 2);

        }

        Console.BackgroundColor = (ConsoleColor)deep;
        Console.WriteLine("..." + modif);

        if (deep > 1)
        {
            deep--;
            Eho(modif, ref deep);
        }
        
        
    }
    */

    #endregion





    //Задача 5.3.13
    #region


    /* static void SortArray(in int[] ArrayForSort, out int[] ArrayAsc, out int[] ArrayDesc)
     {
         ArrayAsc = SortArrayAsc(ArrayForSort);
         ArrayDesc = SortArrayDesc(ArrayForSort);
     }


     static int[] SortArrayAsc(int[] result)
     {
         var a = 0;
         for (int i = 0; i < result.Length; i++)
         {
             for (int j = i + 1; j < result.Length; j++)
             {
                 if (result[j] < result[i])
                 {
                     a = result[i];
                     result[i] = result[j];
                     result[j] = a;
                 }
             }
         }
         return result;
     }

     static int[] SortArrayDesc(int[] result)
     {
         var a = 0;
         for (int i = 0; i < result.Length; i++)
         {
             for (int j = i + 1; j < result.Length; j++)
             {
                 if (result[i] < result[j])
                 {
                     a = result[j];
                     result[j] = result[i];
                     result[i] = a;
                 }
             }
         }
         return result;
     }


 */


    #endregion



    //Задача 5.2.18
    #region
    /* static int[] GetArrayFromConsole(int num = 5)
     {

         var result = new int[num];

         for (int i = 0; i < result.Length; i++)
         {
             Console.WriteLine("Введите элемент массива номер {0}", i + 1);
             result[i] = int.Parse(Console.ReadLine());
         }
         return result;
     }


     static int[] SortArray(int[] result)
     {
         var a = 0;
         for (int i = 0; i < result.Length; i++)
         {
             for (int j = i + 1; j < result.Length; j++)
             {
                 if (result[j] < result[i])
                 {
                     a = result[i];
                     result[i] = result[j];
                     result[j] = a;
                 }
             }
         }
         return result;
     }
     static void ShowArray(int[] array, bool isSort = false)
     {
         var temp = array;
         if (isSort)
         {
             temp = SortArray(array);
         }

         foreach (var item in temp)
         {
             Console.WriteLine(item);
         }
     }
    */
    #endregion



    //Задача 5.2.17
    #region
    //static int[] GetArrayFromConsole(int num = 5)
    //{

    //    var result = new int[num];

    //    for (int i = 0; i < result.Length; i++)
    //    {
    //        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
    //        result[i] = int.Parse(Console.ReadLine());
    //    }
    //    return result;
    //}


    //static int[] SortArray(int[] result)
    //{
    //        var a = 0;
    //        for (int i = 0; i < result.Length; i++)
    //        {
    //            for (int j = i + 1; j < result.Length; j++)
    //            {
    //                if (result[j] < result[i])
    //                {
    //                    a = result[i];
    //                    result[i] = result[j];
    //                    result[j] = a;
    //                }
    //            }
    //        }
    //        return result;
    //}
    //static void ShowArray(int[] array, bool isSort = false)
    //{
    //    var temp = array;
    //    if (isSort)
    //    {
    //        temp = SortArray(array);
    //    }   

    //    foreach(var item in temp)
    //    {
    //        Console.WriteLine(item);
    //    }
    //}
    #endregion




    //Задача 5.2.14
    #region
    //static int[] GetArrayFromConsole(int num = 5)
    //{

    //    var result = new int[num];

    //    for (int i = 0; i < result.Length; i++)
    //    {
    //        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
    //        result[i] = int.Parse(Console.ReadLine());
    //    }
    //    return result;
    //}


    //static int[] SortArray(int[] result)
    //{
    //    var a = 0;

    //    for (int i = 0; i < result.Length; i++)
    //    {
    //        for (int j = i + 1; j < result.Length; j++)
    //        {
    //            if (result[j] < result[i])
    //            {
    //                a = result[i];
    //                result[i] = result[j];
    //                result[j] = a;
    //            }
    //        }
    //    }

    //    return result;
    //}


    #endregion





    //Задача 5.2.8
    #region
    //static int[] GetArrayFromConsole()
    //{
    //    var result = new int[5];

    //    for (int i = 0; i < result.Length; i++)
    //        {
    //            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
    //            result[i] = int.Parse(Console.ReadLine());
    //        }
    //    return result;
    //}

    //static int[] SortArray(int[] result)
    //{
    //    var a = 0;

    //    for (int i = 0; i < result.Length; i++)
    //    {
    //        for (int j = i + 1; j < result.Length; j++)
    //        {
    //            if (result[j] < result[i])
    //            {
    //                a = result[i];
    //                result[i] = result[j];
    //                result[j] = a;
    //            }
    //        }
    //    }

    //    return result;
    //}
    #endregion







    //Задача 5.1.6
    #region
    //static string ShowColor(string username)
    //{
    //Console.WriteLine("Напишите свой любимый цвет на английском маленькими буквами.");

    //switch (Console.ReadLine())

    //{

    //case "red":
    //Console.BackgroundColor = ConsoleColor.Red;
    //Console.ForegroundColor = ConsoleColor.Black;
    //Console.WriteLine("Your color is red!");
    //break;

    //case "cyan":
    //Console.BackgroundColor = ConsoleColor.Cyan;
    //Console.ForegroundColor = ConsoleColor.Black;
    //Console.WriteLine("Your color is cyan!");
    //break;

    //default:
    //Console.BackgroundColor = ConsoleColor.Green;
    //Console.ForegroundColor = ConsoleColor.Black;
    //Console.WriteLine("Your color is green!");
    //break;

    //}

    //return Console.WriteLine();

    //}
    #endregion






    //Задача 5.1.6
    #region
    //static int[] GetArrayFromConsole()
    //{
    //var result = new int[5];

    //for (int i = 0; i < result.Length; i++)
    //{
    //Console.WriteLine("Введите элемент массива номер {0}", i + 1);
    //result[i] = int.Parse(Console.ReadLine());
    //}

    //var a = 0;

    //for (int i = 0; i < result.Length; i++)
    //{
    //for (int j = i+1; j < result.Length; j++)
    //{
    //if (result[j] < result[i])
    //{
    //a = result[i];
    //result[i] = result[j];
    //result[j] = a;
    //}
    //}
    //}
    //for (int i = 0; i < result.Length; i++)
    //{
    //Console.WriteLine(result[i]);
    //}

    //return result;

    //}
    #endregion



    #endregion


    //------------------------------------------------------------------------------------
    //------------------------------------------------------------------------------------
    public static void Main(string[] args)
	{



        //Итоговое задание 5.6
        #region

       ShowOpros(Opros());



        /*
        static Tuple<string, string, int, bool, int, int> FedyaAnketa()
        {
            string name = "name", lastname = "lastname";
            bool hasAnimal = false;
            int age = 11, quantityAnimals = 0, quantityFlowers = 1;

            (string name, string lastname, int age, bool hasanimal, int quantityanimals, int quantityflowers) anketa;


            // return Tuple.Create(name, lastname, age, hasAnimal, quantityAnimals, quantityFlowers);

            return Tuple<string, string, int, bool, int, int>(anketa);
        }

        static void Show(Tuple<string, string, int, bool, int, int> anketa)
        {

        }
        */




        #endregion








        //-----------------
        //Архив
        #region




        //Задача 5.5.8
        #region
        /*
        Console.WriteLine("Введите базовое число для вычисления степени");
        var num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите степень возведения");
        var num2 = byte.Parse(Console.ReadLine());


        Console.WriteLine(PowerUp(num1, num2));
        Console.ReadKey();
        */

        #endregion





        //Задача 5.5.5
        #region
        /*
        Console.WriteLine("Введите число для вычисления факториала");
        var a = int.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(a));
        Console.ReadKey();
        */

        #endregion




        //Задача 5.5.3
        #region
        /*
        Console.WriteLine("Напишите что-то");
        string say = Console.ReadLine();

        Console.WriteLine("Укажите глубину эха");
        int deep = int.Parse(Console.ReadLine());

        Eho(say, ref deep);
        Console.ReadKey();
        */
        #endregion



        //Задача 5.2.18
        #region
        //var array = GetArrayFromConsole(10);
        //ShowArray(array, true);
        #endregion



        //Задача 5.2.17
        #region
        //var array = GetArrayFromConsole();
        //var array1 = SortArray(array);
        //ShowArray(array1, true);
        #endregion



        //Задача 5.2.14
        #region
        //var array = GetArrayFromConsole();
        //var sortedarray = SortArray(array);
        #endregion





        //Самые первые задания
        #region
        //string myName;
        //myName = "Jane";

        //Console.WriteLine("\t Привет, \n мир!");

        //Console.ReadKey();


        //byte age;
        //age = 51;
        //Console.WriteLine($"Мой возраст {age}");


        //Console.WriteLine("\n {0} \n {1} \n {2}", "Jane", 27, "black");


        //string str = Console.ReadLine();

        //double result = 5 / 2 * 3;
        //Console.WriteLine("Value: {0}", result);

        //double result = 10 % 3;
        //Console.WriteLine(result);
        #endregion




        //Задания самых первых уроков
        #region
        //var name = "Jane";

        //var age = checked((byte)int.Parse(Console.ReadLine()));
        //Console.WriteLine("Your name is {0} and age is {1} ", name, age);

        //Console.Write("What is your favorite day of week? ");

        //var day = (DayOfWeek)int.Parse(Console.ReadLine());
        //Console.WriteLine("Your favorite day is {0}", day);


        //Console.Write("Enter your name: ");
        //var name = Console.ReadLine();
        //Console.Write("Enter your age: ");
        //var age = Console.ReadLine();
        //Console.WriteLine("Your name is {0} and your age is {1}", name, age);

        //Console.Write("Enter your birthdate: ");
        //var birthdate = Console.ReadLine();
        //Console.Write("Your birthdate is {0}", birthdate);
        #endregion




        // Задание 3.7.3
        #region
        //Console.Write("Enter your name: ");
        //string name = Console.ReadLine();
        //Console.Write("Enter your age: ");
        //byte age = (byte)int.Parse(Console.ReadLine());
        //Console.WriteLine("Your name is {0} and age is {1} ", name, age);
        //Console.ReadKey();
        #endregion









        //Задача 4.1.10
        #region
        //var inv = true;
        //var result = !inv;
        //Console.WriteLine(result);
        #endregion





        //Задача 4.1.17
        #region
        //var color = Console.ReadLine();

        //if (color == "red")
        //{
        //Console.BackgroundColor = ConsoleColor.Red;
        //Console.ForegroundColor = ConsoleColor.Black;

        //Console.WriteLine("Your color is red!");
        //}

        //else if (color == "green")
        //{
        //Console.BackgroundColor = ConsoleColor.Green;
        //Console.ForegroundColor = ConsoleColor.Black;

        //Console.WriteLine("Your color is green!");
        //}
        //else
        //{
        //Console.BackgroundColor = ConsoleColor.Cyan;
        //Console.ForegroundColor = ConsoleColor.Black;

        //Console.WriteLine("Your color is cyan!");
        //}
        #endregion





        //Задача 4.1.18
        #region
        //Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

        //var color = Console.ReadLine();

        //switch (color)
        //{
        //case "red":
        //Console.BackgroundColor = ConsoleColor.Red;
        //Console.ForegroundColor = ConsoleColor.Black;

        //Console.WriteLine("Your color is red!");
        //break;

        //case "green":
        //Console.BackgroundColor = ConsoleColor.Green;
        //Console.ForegroundColor = ConsoleColor.Black;

        //Console.WriteLine("Your color is green!");
        //break;

        //case "cyan":
        //Console.BackgroundColor = ConsoleColor.Cyan;
        //Console.ForegroundColor = ConsoleColor.Black;

        //Console.WriteLine("Your color is cyan!");
        //break;

        //default:
        //Console.BackgroundColor = ConsoleColor.Yellow;
        //Console.ForegroundColor = ConsoleColor.Red;

        //Console.WriteLine("Your color is yellow!");
        //break;
        #endregion





        //Задача 4.2.11
        #region
        //Console.WriteLine("Цикл do");
        //int t = 0;

        //do
        //{
        //Console.WriteLine(t);

        //Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
        //switch (Console.ReadLine())
        //{
        //case "red":
        //Console.BackgroundColor = ConsoleColor.Red;
        //Console.ForegroundColor = ConsoleColor.Black;

        //Console.WriteLine("Your color is red!");
        //break;

        //case "green":
        //Console.BackgroundColor = ConsoleColor.Green;
        //Console.ForegroundColor = ConsoleColor.Black;

        //Console.WriteLine("Your color is green!");
        //break;
        //case "cyan":
        //Console.BackgroundColor = ConsoleColor.Cyan;
        //Console.ForegroundColor = ConsoleColor.Black;

        //Console.WriteLine("Your color is cyan!");
        //break;
        //default:
        //Console.BackgroundColor = ConsoleColor.Yellow;
        //Console.ForegroundColor = ConsoleColor.Red;

        //Console.WriteLine("Your color is yellow!");
        //break;
        //}

        //t++;
        //} while (t < 3);
        #endregion





        //после задачи Задача 4.2.15 идет видео. это к нему.
        #region
        //int sum = 0;

        //while (true)
        //{
        //Console.WriteLine("Введите число");
        //var number = Convert.ToInt32(Console.ReadLine());

        //if (number < 0)
        //{
        //continue;
        //}
        //else if (number == 0)
        //{
        //break;
        //}

        // number > 0
        //sum += number;
        //}

        //Console.WriteLine("Итоговая сумма: {0}", sum);
        #endregion





        //перед Задачей 4.3.5 
        #region
        //Console.WriteLine("Введите своё имя");

        //var name = Console.ReadLine();

        //Console.WriteLine("Ваше имя по буквам: ");	

        //foreach(var ch in name)
        //{
        //Console.Write(ch + " ");
        //}
        //Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);
        //Console.ReadKey();
        #endregion







        //перед Задачей 4.3.7 
        #region
        //Console.WriteLine("Введите своё имя");

        //var name = Console.ReadLine();
        //var k = name.Length;

        //Console.WriteLine("Ваше имя по буквам: ");

        //foreach (var ch in name)
        //{

        //for (var i = 0; i > name[name.Length - 1]; i++)
        // {
        //var a = name[i]

        //name[i] = name[k - 1];

        //name[k - 1] = a;

        //k = k--;
        //}

        //}
        //Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);
        //Console.ReadKey();
        #endregion





        //Задача 4.4.5
        #region
        //(string Name, string Type, double Age, int NameCount) Pet;
        //Console.WriteLine("Введите кличку животного: ");
        //Pet.Name = Console.ReadLine();
        //Pet.NameCount = Pet.Name.Length;
        //Console.WriteLine("Введите тип животного: ");
        //Pet.Type = Console.ReadLine();
        //Console.WriteLine("Введите возраст животного: ");
        //Pet.Age = Convert.ToDouble(Console.ReadLine());
        //Pet.NameCount = double.Parse(Console.ReadLine()):
        #endregion





        //Задача 4.5.1
        #region
        //(string Name, string LastName, string Login, int LoginLength, bool HasPet, double Age, string[] FavColor) User;

        //for(var k = 0; k < 3; k++)
        //{
        //Console.WriteLine("Введите своё имя: ");
        //User.Name = Console.ReadLine();

        //Console.WriteLine("Введите свою фамилию: ");
        //User.LastName = Console.ReadLine();

        //Console.WriteLine("Введите свой логин: ");
        //User.Login = Console.ReadLine();
        //User.LoginLength = User.Login.Length;

        //Console.WriteLine("Есть ли у вас животное, да/нет ? ");
        //var YesNoAnimal = Console.ReadLine();
        //If(YesNoAnimal == "Да")
        //{
        //HasPet = true;
        //}
        //else
        //{
        //HasPet = false;
        //}

        //Console.WriteLine("Введите свой возраст: ");
        //User.Age = double.Parse(Console.ReadLine());


        //User.FavColor = new string[3];
        //Console.WriteLine("Введите три своих любимых цвета: ");

        //for (int i = 0; i < User.FavColor.Length ; i++)
        //{
        //FavColor[i] = Console.ReadLine();
        //}
        //}
        #endregion






        //Задача 5.1.5
        #region
        //static string ShowColor()
        //{
        //Console.WriteLine("Напишите свой любимый цвет на английском маленькими буквами.");
        //switch (Console.ReadLine())
        //{

        //case "red":
        //Console.BackgroundColor = ConsoleColor.Red;
        //Console.ForegroundColor = ConsoleColor.Black;
        //Console.WriteLine("Your color is red!");
        //break;

        //case "cyan":
        //Console.BackgroundColor = ConsoleColor.Cyan;
        //Console.ForegroundColor = ConsoleColor.Black;
        //Console.WriteLine("Your color is cyan!");
        //break;

        //default: 
        //Console.BackgroundColor = ConsoleColor.Green;
        //Console.ForegroundColor = ConsoleColor.Black;
        //Console.WriteLine("Your color is green!");
        //break;

        //}
        //return Console.WriteLine();			
        //}

        //var favcolors = new string[3];

        //for(int i = 0; i < favcolors.Length; i++)
        //{
        //favcolors[i] = ShowColor();
        //}

        //foreach(var color in favcolors)
        //{
        //Console.WriteLine(color);
        //}
        #endregion





        //Задача 5.1.6
        #region
        //GetArrayFromConsole();
        #endregion





        //Задача 5.1.6
        #region
        //(string name, int age) anketa;

        //Console.Write("Введите имя: ");
        //anketa.name = Console.ReadLine();
        //Console.Write("Введите возраст с цифрами: ");
        //anketa.age = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Ваше имя: {0}", anketa.name);
        //Console.WriteLine("Ваш возраст: {0}", anketa.age);

        //ShowColor(anketa.name);

        //Console.ReadKey();
        #endregion


        #endregion

    }
}

