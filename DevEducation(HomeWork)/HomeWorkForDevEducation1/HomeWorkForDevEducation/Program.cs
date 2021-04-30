using System;

namespace HomeWorkForDevEducation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task №1 -- console output


            /*
            
            Console.WriteLine("Formula: ((5 * A) + B*B)/(B - A)");
            Console.WriteLine("Please, Entry A number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, Entry B number: ");
            double b = double.Parse(Console.ReadLine());
            double decision = ((5 * a) + Math.Pow(b, 2)) / (b - a);
            Console.WriteLine($"Decision: {decision}");
           
            */



            // Task №2 -- swap value
            // с использованием буфера ?

            /*
             
            Console.WriteLine("Please, Entry A number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, Entry B number: ");
            double b = double.Parse(Console.ReadLine());

            double c = a;
            a = b;
            b = c;
            Console.WriteLine($"A number: {a}");
            Console.WriteLine($"B number: {b}");

            */


            // Task №3 -- divison

            /*
             
            Console.WriteLine("Please, Entry A number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, Entry B number: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Divison: {a / b}");
            Console.WriteLine($"Whole part: {(int)(a / b)}");
            Console.WriteLine($"Remainder of the division: {a % b}");

            */


            // Task №4 -- Linear Equation

            /*
             
            Console.WriteLine("Formula: A * X + B = C");
            Console.WriteLine("Please, Entry A number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, Entry B number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, Entry C number: ");
            double c = double.Parse(Console.ReadLine());
            double x = (c - b) / a;
            Console.WriteLine($"X = {x}");

            */

            // Task №5 -- equation of a straight line

            /*
             
            Console.WriteLine("Formula: Y = (A * X) + B");
            Console.WriteLine("Please enter coordinates X1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter coordinates Y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter coordinates X2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter coordinates Y2: ");
            double y2 = double.Parse(Console.ReadLine());
            
            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - (a * x2);
            Console.WriteLine($"y = {a}x + {b}");

            */
        }
    }
}
