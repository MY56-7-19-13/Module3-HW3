namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass1 myClass1 = new MyClass1();
            MyClass2 myClass2 = new MyClass2();
            Console.WriteLine("\t ----------------");
            Console.WriteLine("\t|*Delegate Quiz*|");
            Console.WriteLine("\t ----------------");
            Console.WriteLine("*Input 2 numbers*");
            Console.Write("\nNumber 1: ");
            var number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 2: ");
            var number2 = Convert.ToDouble(Console.ReadLine());
            DelegateCalcHandler calcHandler = myClass2.Calc(number1, number2);
            Console.WriteLine("Now add 3-rd number for remainder from division!");
            Console.Write("Number 3: ");
            var number3 = Convert.ToDouble(Console.ReadLine());
            DelegateForShow delegateForShow = myClass1.Show;
            delegateForShow.Invoke(calcHandler(number3));
        }
    }
}