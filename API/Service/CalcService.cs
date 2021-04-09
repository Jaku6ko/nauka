using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIAss.Models;

namespace APIAss.Service
{
    public class CalcService
    {
        public double Add(CalcModel calc)
        {
            return calc.InputOne + calc.InputTwo;
        }
        public double Subtract(CalcModel calc)
        {
            return calc.InputOne - calc.InputTwo;
        }
        public double Multiply(CalcModel calc)
        {
            return calc.InputOne * calc.InputTwo;
        }
        public double Divide(CalcModel calc)
        {
            return calc.InputOne / calc.InputTwo;
        }
        public double Modulo(CalcModel calc)
        {
            return calc.InputOne % calc.InputTwo;
        }
    }
}