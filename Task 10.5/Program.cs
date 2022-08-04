using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace DirectoryManager
{
    class Program
    {

        static ILogger Logger { get; set; }

        static void Main() 
        {

            Logger = new Logger();

            var add = new Add(Logger);
            var subtract = new Subtract(Logger);
            var multiply = new Multiply(Logger);
            var divis = new Divis(Logger);

            char again = 'д';
            while (again == 'д')
            {
                double a = 0;
                double b = 0;
                char oper = '+';

                try
                {
                    Console.WriteLine("Введите первое число:");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите оператор:");
                    oper = Convert.ToChar(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    b = Convert.ToDouble(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Где-то у вас ошибка в исходных данных.Попробуйте снова.");
                }

                if (oper == '+')
                {
                    add.Work(a, b);
                }
                else if (oper == '-')
                {
                    subtract.Work(a, b);
                }

                else if (oper == '*')
                {
                    multiply.Work(a, b);
                }

                else if (oper == '/')
                {
                    divis.Work(a, b);
                }
                else
                {
                    Console.WriteLine("Неизвестный оператор.");
                }
                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
                again = Convert.ToChar(Console.ReadLine());
            }

        }
    }
    public interface ILogger
    {
        void Event(); 
        void Reset(); 
        void Error(string message);
    }
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void Event() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        public void Reset() 
        {
            Console.ResetColor();
        }
    }

    public interface IWorker
    {
        void Work(double x, double y);
    }

    public class Add : IWorker
    {
        ILogger Logger { get; }
        public Add(ILogger logger)
        {
            Logger = logger;
        }
        public void Work(double _x, double _y)
        {
            Logger.Event();
            double total = _x + _y;
            Console.WriteLine("Cумма " + _x + " и " + _y + " равна " + total + ".");
            Logger.Reset();
        }
    }

    public class Subtract : IWorker
    {
        ILogger Logger { get; }
        public Subtract(ILogger logger)
        {
            Logger = logger;
        }

        public void Work(double _x, double _y)
        {
            Logger.Event();
            double total = _x - _y;
            Console.WriteLine("Разность " + _x + " и " + _y + " равна " + total + ".");
            Logger.Reset();
        }
    }

    public class Multiply : IWorker
    {
        ILogger Logger { get; }
        public Multiply(ILogger logger)
        {
            Logger = logger;
        }

        public void Work(double _x, double _y)
        {
            Logger.Event();
            double total = _x * _y;
            Console.WriteLine("Умножение " + _x + " на " + _y + " равно " + total + ".");
            Logger.Reset();
        }
    }
    public class Divis : IWorker
    {
        ILogger Logger { get; }
        public Divis(ILogger logger)
        {
            Logger = logger;
        }

        public void Work(double _x, double _y)
        {
            Logger.Event();
            double total = _x / _y;
            Console.WriteLine("Деление " + _x + " на " + _y + " равно " + total + ".");
            Logger.Reset();
        }
    }
}