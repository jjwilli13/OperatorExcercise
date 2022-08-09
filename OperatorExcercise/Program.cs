using System;

namespace OperatorExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise 1

            int a = 31;
            int b = 5;

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");


            //Excercise 2

            //Allow user input fir radius
            Console.WriteLine($"What is the radius of your circle?");
            var r = double.Parse(Console.ReadLine());

            //Calculate Radius
            var area = AreaOfCircle(r);

         
            Console.WriteLine($"The area of circle with radius of {r} is {area}");


        }

        public static double AreaOfCircle(double r)
        {

            return Math.PI * (r * r);


        }
        


    }
}

