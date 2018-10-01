using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_8_2
{
    public interface IOperation
    {
        string Operator { get; }

        double Operate(double a, double b);
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

        public double Operate(double a, double b)
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

        public double Operate(double a, double b)
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

        public double Operate(double a, double b)
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

        public double Operate(double a, double b)
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

        public void Calcul(string a, string operation, string b)
        {
            IOperation operationObject = operations.FirstOrDefault(e => e.Operator == operation);

            if (operationObject == null) // L'opérateur n'a pas été trouvé dans la liste
                Console.WriteLine("Nous n'avons pas trouvé l'opération demandée.");
            else
            {
                try
                {
                    double result = operationObject.Operate(double.Parse(a), double.Parse(b));
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
