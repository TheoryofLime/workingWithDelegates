using System;

namespace Assignment8ex2
{
    public class MathSolutions
    {
        public delegate void calcSmaller(double x, double y);
        /*
        public double GetSum(double x, double y)
        {
            return x + y;
        }
        
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        */
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            // action
            Action<double, double> GetSum = delegate (double x, double y) { Console.WriteLine($" {num1} + {num2} is: {num1 + num2}"); };
            GetSum(num1,num2);
            // func-y
            Func<double, double, double> calcProduct = delegate (double x, double y) { return x * y;  };
            Console.WriteLine($" {num1} * {num2} = {calcProduct(num1, num2)}");
            // custom thing
            MathSolutions.calcSmaller newCalcSmaller = new MathSolutions.calcSmaller(answer.GetSmaller);
            newCalcSmaller(num1,num2);
        }
    }
}