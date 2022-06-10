using System;

class MainClass
{
	public static void Main(string[] args)
	{

		///string myName;
		///myName = "Jane";

		///Console.WriteLine("\t Привет, \n мир!");

		///Console.ReadKey();


		//byte age;
		//age = 51;
		//Console.WriteLine($"Мой возраст {age}");


		//Console.WriteLine("\n {0} \n {1} \n {2}", "Jane", 27, "black");


		//string str = Console.ReadLine();

		//double result = 5 / 2 * 3;
		//Console.WriteLine("Value: {0}", result);

		//double result = 10 % 3;
		//Console.WriteLine(result);


		// Задание 3.7.3
		//Console.Write("Enter your name: ");
		//string name = Console.ReadLine();
		//Console.Write("Enter your age: ");
		//byte age = (byte)int.Parse(Console.ReadLine());
		//Console.WriteLine("Your name is {0} and age is {1} ", name, age);
		//Console.ReadKey();



		//var name = "Jane";

		//var age = checked((byte)int.Parse(Console.ReadLine()));
		//Console.WriteLine("Your name is {0} and age is {1} ", name, age);

		//Console.Write("What is your favorite day of week? ");

		//var day = (DayOfWeek)int.Parse(Console.ReadLine());
		//Console.WriteLine("Your favorite day is {0}", day);


		Console.Write("Enter your name: ");
		var name = Console.ReadLine();
		Console.Write("Enter your age: ");
		var age = Console.ReadLine();
		Console.WriteLine("Your name is {0} and your age is {1}", name, age);

		Console.Write("Enter your birthdate: ");
		var birthdate = Console.ReadLine();
		Console.Write("Your birthdate is {0}", birthdate);


	}
}
