using System;

class MainClass
{

    //Задача 5.5.3
    #region

    static void Eho(string phrase, ref int deep)
    {

        var modif = phrase;
        
        if (modif.Length > 2)
        {
            
            modif = modif.Remove(0, 2);
            Console.WriteLine(modif);
            
        }
        
        if(deep > 1)
        {
            deep--;
            Eho(modif, ref deep);
        }
        
        
    }


    #endregion



    // ------------------------------------------------------------------

    //Архив
    #region



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



    public static void Main(string[] args)
	{

        //Задача 5.5.3
        #region
        
        Console.WriteLine("Напишите что-то");
        string say = Console.ReadLine();
        
        Console.WriteLine("Укажите глубину эха");
        int deep = int.Parse(Console.ReadLine());
        
        Eho(say, ref deep);
        Console.ReadKey();
        
        #endregion


        //---------------------------------------------------------
        //Архив
        #region



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

