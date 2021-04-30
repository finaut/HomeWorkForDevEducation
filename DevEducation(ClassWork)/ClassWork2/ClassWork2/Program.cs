using System;

namespace ClassWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            var costS = 10;
            var costM = 15;
            var costL = 20;

            var discontSmall = 0.1;
            var discontBig = 0.5;

            double totalPrice = 0;

            Console.WriteLine("Please chose(and entry) size foto : ");
            Console.WriteLine("Small: 9*12");
            Console.WriteLine("Medium: 10*15");
            Console.WriteLine("Large: 15*20");
            var sizeFoto = Console.ReadLine();

            Console.WriteLine("Please entry quantity: ");
            var quantity = int.Parse(Console.ReadLine());

            var currentDiscont = (quantity >= 50) ? discontBig
                : (quantity >= 10) ? discontSmall
                : 0;

            Console.WriteLine(currentDiscont);
            Console.WriteLine();
            switch (sizeFoto)
            {
                case "9*12":
                    totalPrice = (quantity * costS) - ((quantity * costS) * currentDiscont);
                    Console.WriteLine(totalPrice);
                    break;
                case "10*15":
                    totalPrice = (quantity * costM) - ((quantity * costM) * currentDiscont);
                    Console.WriteLine(totalPrice);
                    break;
                case "15*20":
                    totalPrice = (quantity * costL) - ((quantity * costL) * currentDiscont);
                    Console.WriteLine(totalPrice);
                    break;
                default:
                    Console.WriteLine("Size is incorrect.");
                    break;
            }
        }
    }
}
