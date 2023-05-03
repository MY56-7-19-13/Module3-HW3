using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public delegate double DelegateForPow(double a, double b);
    public delegate bool DelegateCalcHandler(double q);

    public class MyClass2
    {

        double resultOfCalc;
        public DelegateCalcHandler Calc(double a, double b)
        {

            MyClass1 myClass1 = new MyClass1();
            DelegateForPow delegateForPow = myClass1.Pow;
            resultOfCalc = delegateForPow.Invoke(a, b);
            DelegateCalcHandler delegateCalcHandler = Result;
            return delegateCalcHandler;

        }
        public bool Result(double number)
        {
            var resultOfResult = resultOfCalc % number;
            if (resultOfResult == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
