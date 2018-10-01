using System;

namespace Exercice_8_3
{
    public interface IOperation
    {
        string Operate(string a, string b);
    }

    public class Addition : IOperation
    {
        public string Operate(string a, string b)
        {
            return (int.Parse(a) + int.Parse(b)).ToString();
        }
    }

    public class Soustraction : IOperation
    {
        public string Operate(string a, string b)
        {
            return (int.Parse(a) - int.Parse(b)).ToString();
        }
    }

    public class Division : IOperation
    {
        public string Operate(string a, string b)
        {
            return (int.Parse(a) / int.Parse(b)).ToString();
        }
    }

    public class Multiplication : IOperation
    {
        public string Operate(string a, string b)
        {
            return (int.Parse(a) * int.Parse(b)).ToString();
        }
    }

    public class OperateObject
    {
        public string Operate(string a, string operation, string b)
        {
            if (operation == "+")
                return Operate<Addition>(a, b);
            if (operation == "-")
                return Operate<Soustraction>(a, b);
            if (operation == "/")
                return Operate<Division>(a, b);
            else
                return Operate<Multiplication>(a, b);
        }

        private string Operate<T>(string a, string b) where T : IOperation, new()
        {
            T operation = new T();
            return operation.Operate(a, b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string operation = Console.ReadLine();
            string b = Console.ReadLine();

            OperateObject operate = new OperateObject();
            string result = operate.Operate(a, operation, b);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
