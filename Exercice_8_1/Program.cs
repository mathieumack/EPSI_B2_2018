using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_8_1
{
    public interface IOperation
    {
        string Operator { get; }

        int Operate(int a, int b);
    }

    public class Addition : IOperation
    {
        public string Operator
        {
            get
            {
                return "+";
            }
        }

        public int Operate(int a, int b)
        {
            return a + b;
        }
    }

    public class Soustraction : IOperation
    {
        public string Operator
        {
            get
            {
                return "-";
            }
        }

        public int Operate(int a, int b)
        {
            return a - b;
        }
    }

    public class Division : IOperation
    {
        public string Operator
        {
            get
            {
                return "/";
            }
        }

        public int Operate(int a, int b)
        {
            if (b == 0)
                return 0;

            return a / b;
        }
    }

    public class Multiplication : IOperation
    {
        public string Operator
        {
            get
            {
                return "*";
            }
        }

        public int Operate(int a, int b)
        {
            return a * b;
        }
    }

    public class Calculatrice
    {
        private readonly List<IOperation> operations;

        public Calculatrice()
        {
            operations = new List<IOperation>();
            operations.Add(new Addition());
            operations.Add(new Soustraction());
            operations.Add(new Division());
            operations.Add(new Multiplication());
        }

        public void  Calcul(string a, string operation, string b)
        {
            IOperation operationObject = operations.FirstOrDefault(e => e.Operator == operation);

            if (operationObject == null) // L'opérateur n'a pas été trouvé dans la liste
                Console.WriteLine("Nous n'avons pas trouvé l'opération demandée.");
            else
            {
                try
                {
                    int result = operationObject.Operate(int.Parse(a), int.Parse(b));
                    Console.WriteLine(result);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Veuillez vérifier que vous avez saisie des valeurs entières.");
                }
            }
        }
    }
	
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string operation = Console.ReadLine();
            string b = Console.ReadLine();

            Calculatrice calculatrice = new Calculatrice();
            calculatrice.Calcul(a, operation, b);

            Console.ReadLine();
        }
    }
}
