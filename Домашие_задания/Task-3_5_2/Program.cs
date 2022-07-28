using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;




/*
class MyException : Exception
{
    public MyException()
    {

    }
    public MyException (string message) : base(message)
    {
        try()
    }

*/







// -----------------------

//Архив
#region

// Задание 8.4.3
#region
/*
[Serializable]
class Contact
{

    public string Name { get; set; }
    public long PhoneNumber { get; set; }
    public string Email { get; set; }


    public Contact(string name, long phoneNumber, string email)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }

}

*/

#endregion





// Задание 7.6.12
#region
/*


class Engine { }
class ElectricEngine : Engine { }

class GasEngine : Engine { }

class CarPart { }

class Battery : CarPart { }

class Differential : CarPart { }

class Wheel : CarPart { }

class Car<TEngine> where TEngine : Engine

{
    public TEngine Engine;
    public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart
    {

    }

}

class ElectricCar : Car<ElectricEngine> 
{
    public override void ChangePart<TPart>(TPart newPart)
    {

    }
}

class GasCar : Car<GasEngine> 
{
    public override void ChangePart<TPart>(TPart newPart)
    {

    }
}

*/
#endregion



// Задание 7.6.9
#region
/*


class Engine { }
class ElectricEngine : Engine { }

class GasEngine : Engine { }

class CarPart { }

class Battery : CarPart { }

class Differential : CarPart { }

class Wheel : CarPart { }

class Car<TEngine> where TEngine : Engine

{
    public TEngine Engine;
    public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
        {

        }

}

*/
#endregion



// Задание 7.6.7
#region
/*
class ElectricEngine { }

class GasEngine { }

class Battery { }

class Differential { }

class Wheel { }

class Car<T1>
{
    public T1 Engine;
    public virtual void ChangePart<T2>(T2 new newPart)
        {

        }

}

*/
#endregion





// Задание 7.6.6
#region
/*
class Id<T> { }

class Value<T> { }

class Record<T1, T2> 
{
    public T1 Id;
    public T2 Value;
    public DateTime Date;
}

*/
#endregion




// Задание 7.6.2
#region
/*
class ElectricEngine { }

class GasEngine { }

class Car<T>
{
    public T Engine;

}
*/

#endregion






//Задание 7.5.9
#region
/*
static class intExtensions
{
    public static int GetNegativ(this int number)
    {
        if (number < 0) 
        {
            return number;
        }
        else
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return -number;
            }
        }
    }

    public static int GetPositive(this int number)
    {
        if (number > 0)
        {
            return number;
        }
        else
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return -number;
            }
        }
    }
}
*/
#endregion


// Задание 7.5.3
#region
/*
class Helper
{
    public static void Swap(ref int a,ref int b)
    {
        var temp = a;
        a = b;
        b = temp;
    }
}
*/
#endregion





// Задание 7.3.3
#region
/*
abstract class ComputerParts
{
    public abstract void Work();

}

class Processor: ComputerParts
{
    public override void Work() { }

}

class MotherBoard: ComputerParts
{
    public override void Work() { }

}

class GraphicCard: ComputerParts
{
    public override void Work() { }

}



*/
#endregion




//Задание 7.2.7 №куп    
#region
/*
class A
{
    public virtual void Display()
    {
        Console.WriteLine("A");
    }
}
class B : A
{
    public new void Display()
    {
        Console.WriteLine("В");
    }
}

class C : A
{
    public override void Display()
    {
        Console.WriteLine("C");
    }
}

class D : B
{
    public new void Display()
    {
        Console.WriteLine("D");
    }
}

class E : C
{
    public new void Display()
    {
        Console.WriteLine("E");
    }
}
*/
#endregion







//Задание 7.2.5
#region
/*
class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("Метод класса BaseClass");
    }
}

class DerivedClass : BaseClass
{
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Метод класса DerivedClass");
    }
}
*/
#endregion




// Задание 7.1.10
#region
/*
class BaseClass
{
    protected string Name;

    public BaseClass(string name)
    {
        Name = name;
    }
}

class DerivedClass : BaseClass
{
    public string Description;

    public int Counter;
    public DerivedClass(string name, string descripton) : base(name)
    {
        Description = descripton;
    }
    public DerivedClass(string name, string descriptio, int counter) : base(name)
    {
        Description = descripton; 
        Counter = counter;
    }
}

*/



#endregion





// Задание 6.6.2
#region
/*

class User
{
    private int age;

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value < 18)
            {
                Console.WriteLine("Возраст должен быть не меньше 18");
            }
            else
            {
                age = value;
            }
        }
    }
    public string Login
    {
        get
        {
            return Login;
        }

        set
        {
            if (value.Length < 3)
            {
                Console.WriteLine("Логин болжен быть не менее 3 символов");
            }
            else
            {
                Login = value;
            }
        }

    private string email;
    private string Email
    {
        get
        {
            return email;
        }
        set
        {
            var a = "@";
            if(!value.Contains(а))
            {
                Console.WriteLine("Неправильная почта");
            }
            else
            {
                email = value;
            }
        }
    }

}
*/
#endregion




// Задание 6.6.1
#region
/*
class TrafficLight
{
    private void ChangeColor(string color)
    {

    }
    public string GetColor()
    {

    }
}
*/
#endregion





//Юнит 6.3 к видео
#region
/*
namespace FirstApp
{
    struct Data
    {
        public string Name;
        public int Lenght;
        public int Version;
        public int[] Array;
    }

    class Obj
    {
        public string Name;
        public bool IsAlive;
        public int Weight;
    }
}


class Programm
{
    //Юнит 6.3 к видео
    #region
    Data data = new Data { Name = "Запись", Lenght = 10, Version = 1, Array = new int[] { 15, 30 } };
    Obj obj = new Obj { name = "Стол", IsAlive = false, Weight = 15 };

    var dataCopy = data;
    var objCopy = obj;



    #endregion
}



#endregion




class MainClass
{


    //Юнит 6.3 к видео
    #region
    Data data = new Data {Name = "Запись", Lenght = 10, Ver };
*/
#endregion




//Задания 6.3.2
#region
/*
class Bus
{
    public int? Load;

    public void PrintStatus()
    {
        if (Load.HasValue)
        {
            Console.WriteLine("В автобусе {0} пассажиров.", Load.Value);
        }
        else 
        {
            Console.WriteLine("Автобус пуст"); 
        }

    }
}
*/

#endregion





//Задание 6.2.8
#region
/*
class Rectangl
{

    //Поля класса
    public int a;
    public int b;

    //Конструктор класса
    public Rectangl()
    {
        a = 6;
        b = 4;
    }

    //Конструктор класса
    public Rectangl(int a1)
    {
        a = a1;
        b = a1;
    }
    //Конструктор класса
    public Rectangl(int a1, int b1)
    {
        a = a1;
        b = b1;
    }


    //Метод класса
    static double Square()
    {
        return a * b;
    }


}
*/
#endregion



//Итоговое задание 5.6
#region
/*
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
*/
#endregion





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
            if(c == "Шарик" | c == "Тузик" | c == "Мурзик" | c == "Кеша")
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



            //-----------------
            //Архив
            #region



            //Задание 9.2.3

            #region
            /*
            try
            {
                Console.WriteLine("Отработал блок TRY");
                throw new RankException();
            }
            catch (Exception ex)
            {
                if (ex is RankException)
                {
                    Console.WriteLine("Отработал блок CAPTH");
                    Console.WriteLine(ex.GetType());  
                }
            }
            finally
            {
                Console.WriteLine("Отработал блок FINALLY");
            }
            */
            #endregion



            //Задание 9.2.2
            #region
            /*
            try
            {
                Console.WriteLine("Отработал блок TRY");
                throw new ArgumentOutOfRangeException();
            }
            catch(Exception ex) 
            {
                if (ex is ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Отработал блок CAPTH");
                }
            }
            finally
            {
                Console.WriteLine("Отработал блок FINALLY");
            }
            */
            #endregion




            // Задание 1 юнита 8.6 (для активации кода в начале и конце региона убрать /* и */)
            #region
            /*
            // задаем путь к каталогу, который надо очистить
            string CleanDirectory = @"C:\folder";

            // устанавливаем время "старости" файла или папки в минутах от текущего момента
            double delMinutes = 30;

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(CleanDirectory);
                if (dirInfo.Exists)
                {
                    DeleteFilesAndDirectories(CleanDirectory, delMinutes);
                    Console.WriteLine($"Очистка папки {CleanDirectory} завершена.");
                }
            }
            //Начинаем перехватывать ошибки

            //DirectoryNotFoundException - директория не найдена
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Директория не найдена. Ошибка: " + e.Message);
            }

            //UnauthorizedAccessException - отсутствует доступ к файлу или папке
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Отсутствует доступ. Ошибка: " + e.Message);
            }

            //Во всех остальных случаях
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка. Обратитесь к администратору. Ошибка: " + e.Message);
            }

            // процедура удаление файлов и папок старше _delMinutes минут 
            static void DeleteFilesAndDirectories(string _CleanDirectory, double _delMinutes)
            {
                // получаем все файлы из указанного каталога
                string[] files = Directory.GetFiles(_CleanDirectory);

                // удаление старых файлов в цикле
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);

                    // если дата создания/изменения файла меньше (сегодня - delMinutes), то удаляем файл
                    if (fi.LastWriteTime < DateTime.Now.AddDays(-_delMinutes))
                    {
                        fi.Delete();
                    }
                }

                // получаем все папки из указанного каталога
                string[] dirs = Directory.GetDirectories(_CleanDirectory);

                // удаление старых папок в цикле
                foreach (string dir in dirs)
                {
                    DirectoryInfo di = new DirectoryInfo(dir);

                    // если время создания/изменения меньше (сегодня - _delMinutes), то удаляем папку
                    if (di.LastWriteTime < DateTime.Now.AddDays(-_delMinutes))
                    {
                        // если в папке есть подпапки, то делаем рекурсию данного метода на них
                        DeleteFilesAndDirectories(di.FullName, _delMinutes);

                        di.Delete();
                    }
                }
            }
            */
            #endregion


            // -----------------------


            // Задание 2 юнита 8.6 (для активации кода в начале и конце региона убрать /* и */)
            #region
            /*
            string pathToDirectory = @"D:\\Catalog";
            double catalogSize = 0;

            if (catalogSize != 0)
            {
                sizeOfFolder(pathToDirectory, ref catalogSize);
                Console.WriteLine("Размер каталога {0} составляет {1} байт.", pathToDirectory, catalogSize);
            }
            else
            {
                Console.WriteLine("Каталог {0} пуст.", pathToDirectory);
            }
            Console.ReadLine();

            static void sizeOfFolder(string folder, ref double catalogSize)
            {
                try
                {
                    //В переменную catalogSize будем записывать размеры всех файлов, с каждым
                    //новым файлом перезаписывая данную переменную
                    DirectoryInfo di = new DirectoryInfo(folder);

                    FileInfo[] fi = di.GetFiles();
                    //В цикле пробегаемся по всем файлам директории di и складываем их размеры
                    foreach (FileInfo f in fi)
                    {
                        //Записываем размер файла в байтах
                        catalogSize += f.Length;
                    }

                    DirectoryInfo[] diA = di.GetDirectories();
                    //В цикле пробегаемся по всем вложенным директориям директории di 
                    foreach (DirectoryInfo df in diA)
                    {
                        //рекурсивно вызываем наш метод
                        sizeOfFolder(df.FullName, ref catalogSize);
                    }

                }
                //Начинаем перехватывать ошибки

                //DirectoryNotFoundException - директория не найдена
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine("Директория не найдена. Ошибка: " + e.Message);
                }

                //UnauthorizedAccessException - отсутствует доступ к файлу или папке
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine("Отсутствует доступ. Ошибка: " + e.Message);
                }

                //Во всех остальных случаях
                catch (Exception e)
                {
                    Console.WriteLine("Произошла ошибка. Обратитесь к администратору. Ошибка: " + e.Message);
                }
            }
            */
            #endregion


            // -----------------------


            // Задание 3 юнита 8.6 (для активации кода в начале и конце региона убрать /* и */)
            #region
            /*
            // задаем путь к каталогу, который надо очистить
            string CleanDirectory3 = @"C:\folder";

            // устанавливаем время "старости" файла или папки в минутах от текущего момента
            double delMinutes3 = 30;

            double catalogSize3 = 0;

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(CleanDirectory3);
                if (dirInfo.Exists)
                {
                    //определяем размер папки до очистки
                    sizeOfFolder3(CleanDirectory3, ref catalogSize3);
                    double oldSize = catalogSize3;
                    Console.WriteLine($"Исходный размер папки: {catalogSize3} байт.");

                    //очищаем папку
                    DeleteFilesAndDirectories3(CleanDirectory3, delMinutes3);

                    //определяем размер папки после очистки
                    sizeOfFolder3(CleanDirectory3, ref catalogSize3);

                    // определяем сколько байт было удалено из папки
                    double deleteSize = oldSize - catalogSize3;

                    Console.WriteLine($"Освобождено: {deleteSize} байт.");
                    Console.WriteLine($"Текущий размер папки: {catalogSize3} байт.");
                }
            }
            //Начинаем перехватывать ошибки

            //DirectoryNotFoundException - директория не найдена
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Директория не найдена. Ошибка: " + e.Message);
            }

            //UnauthorizedAccessException - отсутствует доступ к файлу или папке
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Отсутствует доступ. Ошибка: " + e.Message);
            }

            //Во всех остальных случаях
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка. Обратитесь к администратору. Ошибка: " + e.Message);
            }

            // процедура удаление файлов и папок старше _delMinutes минут 
            static void DeleteFilesAndDirectories3(string _CleanDirectory, double _delMinutes)
            {
                // получаем все файлы из указанного каталога
                string[] files = Directory.GetFiles(_CleanDirectory);

                // удаление старых файлов в цикле
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);

                    // если дата создания/изменения файла меньше (сегодня - delMinutes), то удаляем файл
                    if (fi.LastWriteTime < DateTime.Now.AddDays(-_delMinutes))
                    {
                        fi.Delete();
                    }
                }

                // получаем все папки из указанного каталога
                string[] dirs = Directory.GetDirectories(_CleanDirectory);

                // удаление старых папок в цикле
                foreach (string dir in dirs)
                {
                    DirectoryInfo di = new DirectoryInfo(dir);

                    // если время создания/изменения меньше (сегодня - _delMinutes), то удаляем папку
                    if (di.LastWriteTime < DateTime.Now.AddDays(-_delMinutes))
                    {
                        // если в папке есть подпапки, то делаем рекурсию данного метода на них
                        DeleteFilesAndDirectories3(di.FullName, _delMinutes);

                        di.Delete();
                    }
                }
            }

            static void sizeOfFolder3(string folder3, ref double catalogSize3)
            {

                //В переменную catalogSize3 будем записывать размеры всех файлов, с каждым
                //новым файлом перезаписывая данную переменную
                DirectoryInfo di = new DirectoryInfo(folder3);

                FileInfo[] fi = di.GetFiles();
                //В цикле пробегаемся по всем файлам директории di и складываем их размеры
                foreach (FileInfo f in fi)
                {
                    //Записываем размер файла в байтах
                    catalogSize3 += f.Length;
                }

                DirectoryInfo[] diA = di.GetDirectories();
                //В цикле пробегаемся по всем вложенным директориям директории di 
                foreach (DirectoryInfo df in diA)
                {
                    //рекурсивно вызываем наш метод
                    sizeOfFolder3(df.FullName, ref catalogSize3);
                }

            }

            */
            #endregion


            // -----------------------






            // Задание 8.4.3
            #region
            /*
            // объект для сериализации
            var contact = new Contact("Вася", 89692828591, "contact1@mail.ru");
            Console.WriteLine("Новый контакт создан");

            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (var fs = new FileStream("Contact.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, contact);
            }

            Console.ReadLine();
            */
            #endregion



            // Задание 8.4.2
            #region
            /*
            string SettingsFileName = @"C:\Users\Sergey\Desktop\BinaryFile.bin";
            string StringValue;

            if (File.Exists(SettingsFileName))
            {
                using(BinaryWriter writer= new BinaryWriter(File.Open(SettingsFileName, FileMode.Open)))
                {
                    //string sv = "Файл изменен " + DateTime.Now + " на компьютере Windows 11";
                    writer.Write($"Файл изменен { DateTime.Now} на компьютере Windows 11");
                }



                // Создаем объект BinaryReader и инициализируем его возвратом метода File.Open.
                using (BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
                {
                    // Применяем специализированные методы Read для считывания соответствующего типа данных.
                    StringValue = reader.ReadString();

                }

                Console.WriteLine("Из файла считано:");

                Console.WriteLine("Строка: " + StringValue);

            }
            */

            #endregion


            // Задание 8.4.1
            #region
            /*
            string SettingsFileName = @"C:\Users\Sergey\Desktop\BinaryFile.bin";
            string StringValue;

            if (File.Exists(SettingsFileName))
            {
                // Создаем объект BinaryReader и инициализируем его возвратом метода File.Open.
                using (BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
                {
                    // Применяем специализированные методы Read для считывания соответствующего типа данных.
                    StringValue = reader.ReadString();

                }

                Console.WriteLine("Из файла считано:");

                Console.WriteLine("Строка: " + StringValue);

            }

            */
            #endregion




            // Задание 8.3.2
            #region
            /*
            string filePath = @"/Users/luft/Projects/SkillFactory/workwithfiles/Task2/Program.cs"; // Укажем путь

            // Откроем файл и прочитаем его содержимое
            using (StreamWriter sw = FileInfo.AppendText())
            {
                sw.WriteLine($"//Время последнего запуска - {DateTime.Now}");
            }

            //Открываем файл и читаем из него.
            using (StreamReader sr = fileInfo.OpenText())
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
            */
            #endregion





            #region

            /*

            // получим системные диски
            DriveInfo[] drives = DriveInfo.GetDrives();

            // Пробежимся по дискам и выведем их свойства
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем: {drive.TotalSize}");
                    Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}");
                }
            }
            */
            #endregion



            // Задание 8.2.3
            #region
            /*
            try
            {

                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\");
                if (dirInfo.Exists)
                {
                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                }

                DirectoryInfo newDirectory = new DirectoryInfo(@"/newDirectory");
                if (!newDirectory.Exists)
                    newDirectory.Create();

                Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);

                DirectoryInfo dirInfo2 = new DirectoryInfo(@"/newDirectory");
                dirInfo2.Delete(true); // Удаление со всем содержимым
                Console.WriteLine("Папка удалена");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */
            #endregion





            // Задание 8.2.2
            #region
            /*
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\");
                if (dirInfo.Exists)
                {
                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                }

                DirectoryInfo newDirectory = new DirectoryInfo(@"/newDirectory");
                if (!newDirectory.Exists)
                    newDirectory.Create();

                Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */
            #endregion




            // Задание 8.2.1
            #region
            /*

                    try
                    {
                            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\");
                            if (dirInfo.Exists)
                            {
                                Console.WriteLine($"Папок - {dirInfo.GetDirectories().Length} штук и файлов - {dirInfo.GetFiles().Length} штук.");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                    }
            */
            #endregion






            // Задание 7.5.3
            #region
            /*
            int num1 = 3;
            int num2 = 58;

            Helper.Swap(ref num1, ref num2);

            Console.WriteLine(num1); //58
            Console.WriteLine(num2); //3
            */
            #endregion


            // Задача 7.2.8
            #region
            /*
            D d = new D();
            E e = new E();

            d.Display();
            ((A)e).Display();
            ((B)d).Display();
            ((A)d).Display();
            */
            #endregion




            //Итоговое задание 5.6
            #region

            //ShowOpros(Opros());


            #endregion




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






