using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public delegate void DelegateForShow(bool x);
    public class MyClass1
    {

        public double Pow(double a, double b)
        {
            return a * b;
        }
        public void Show(bool result)
        {
            Console.WriteLine("Result: " + result);
        }
    }
}
