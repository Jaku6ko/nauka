using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Press 1 if you want to add 2 numbers");
            Console.WriteLine("Press 2 if you want to subtract 2 numbers");
            Console.WriteLine("Press 3 if you want to multiply 2 numbers");
            Console.WriteLine("Press 4 if you want to divide 2 numbers");
            Console.WriteLine("Press 5 if you want to divide 2 numbers modulo");
            Console.WriteLine("Press 6 if you want to see a list of 5 latest operations");
            Console.WriteLine("Press 7 if you want to exit");
            string Menu = Console.ReadLine();
            Console.Clear();
            switch (Menu)
            {
                case "1":
                    AddOption();
                    Console.ReadLine();
                    Console.Clear();
                    Main();
                    break;
                case "2":
                    SubOption();
                    Console.ReadLine();
                    Console.Clear();
                    Main();
                    break;
                case "3":
                    MultOption();
                    Console.ReadLine();
                    Console.Clear();
                    Main();
                    break;
                case "4":
                    DivOption();
                    Console.ReadLine();
                    Console.Clear();
                    Main();
                    break;
                case "5":
                    ModOption();
                    Console.ReadLine();
                    Console.Clear();
                    Main();
                    break;
                case "6":
                    ListOption();
                    Console.ReadLine();
                    Console.Clear();
                    Main();
                    break;
                case "7":
                    break;
                default:
                    Console.WriteLine("wrong input");
                    Console.ReadLine();
                    Main();
                    break;
            }
        }
        static void AddOption()
        {
            Calculation calc = new Calculation();
            CalculatorRepository Repo = new CalculatorRepository();
            calc.InputOne = double.Parse(Console.ReadLine());
            Console.WriteLine("+");
            calc.InputTwo = double.Parse(Console.ReadLine());
            calc.Type = TypeEnum.Add;
            DisplayCalculation(calc);
            Repo.Store(calc);

        }
        static void SubOption()
        {
            Calculation calc = new Calculation();
            CalculatorRepository Repo = new CalculatorRepository();
            calc.InputOne = double.Parse(Console.ReadLine());
            Console.WriteLine("-");
            calc.InputTwo = double.Parse(Console.ReadLine());
            calc.Type = TypeEnum.Sub;
            DisplayCalculation(calc);
            Repo.Store(calc);

        }
        static void MultOption()
        {
            Calculation calc = new Calculation();
            CalculatorRepository Repo = new CalculatorRepository();
            calc.InputOne = double.Parse(Console.ReadLine());
            Console.WriteLine("*");
            calc.InputTwo = double.Parse(Console.ReadLine());
            calc.Type = TypeEnum.Mult;
            DisplayCalculation(calc);
            Repo.Store(calc);

        }
        static void DivOption()
        {
            Calculation calc = new Calculation();
            CalculatorRepository Repo = new CalculatorRepository();
            calc.InputOne = double.Parse(Console.ReadLine());
            Console.WriteLine("/");
            calc.InputTwo = double.Parse(Console.ReadLine());
            calc.Type = TypeEnum.Div;
            DisplayCalculation(calc);
            Repo.Store(calc);

        }
        static void ModOption()
        {

            Calculation calc = new Calculation();
            CalculatorRepository Repo = new CalculatorRepository();
            calc.InputOne = double.Parse(Console.ReadLine());
            Console.WriteLine("%");
            calc.InputTwo = double.Parse(Console.ReadLine());
            calc.Type = TypeEnum.Mod;
            DisplayCalculation(calc);
            Repo.Store(calc);
        }
        static void ListOption()
        {
            Console.WriteLine("How many of the latest operations do you want to view?");
            int NumberOfOperations = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Latest {0} operations:", NumberOfOperations);
            CalculatorRepository Repo = new CalculatorRepository();
            var list = Repo.List(NumberOfOperations);
            Console.WriteLine("The list:");
            foreach (Calculation calc in list)
            {
                DisplayCalculation(calc);
            }

        }
        static void DisplayCalculation(Calculation calc)
        {
            CalculationService CS = new CalculationService();
            string symbol = "";
            switch (calc.Type)
            {
                case TypeEnum.Add:
                    symbol = "+";
                    break;
                case TypeEnum.Sub:
                    symbol = "-";
                    break;
                case TypeEnum.Mult:
                    symbol = "*";
                    break;
                case TypeEnum.Div:
                    symbol = "/";
                    break;
                case TypeEnum.Mod:
                    symbol = "%";
                    break;
            }
            Console.WriteLine("{0} {2} {1} = {3}", calc.InputOne.ToString(), calc.InputTwo.ToString(), symbol, CS.Calculate(calc).ToString());
        }
    }
}
