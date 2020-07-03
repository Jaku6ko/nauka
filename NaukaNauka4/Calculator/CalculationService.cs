using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculationService
    {
        private double Add(Calculation calc)
        {
            return calc.InputOne + calc.InputTwo;
        }
        private double Subtract(Calculation calc)
        {
           return calc.InputOne - calc.InputTwo;
        }
        private double Multiply(Calculation calc)
        {
            return calc.InputOne * calc.InputTwo;
        }
        private double Divide(Calculation calc)
        {
            return calc.InputOne / calc.InputTwo;
        }
        private double Modulo(Calculation calc)
        {
            return calc.InputOne % calc.InputTwo;
        }
        public double Calculate(Calculation calc)
        {
            switch (calc.Type)
            {
                case TypeEnum.Add:
                    return Add(calc);
                case TypeEnum.Sub:
                    return Subtract(calc);
                case TypeEnum.Mult:
                    return Multiply(calc);
                case TypeEnum.Div:
                    return Divide(calc);
                case TypeEnum.Mod:
                    return Modulo(calc);
                default:
                    return 0;
            }


        }
    }
}
