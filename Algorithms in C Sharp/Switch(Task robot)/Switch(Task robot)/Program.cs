using System;

namespace Switch_Task_robot_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!!! Entry command: ");
            Console.WriteLine("(a), (d), (w), (s)");
            string command = Console.ReadLine();
            switch (command)
            {
                case "a":
                    Console.WriteLine("West");
                    break;
                case "d":
                    Console.WriteLine("East");
                    break;
                case "w":
                    Console.WriteLine("South");
                    break;
                case "s":
                    Console.WriteLine("North");
                    break;
                default:
                    Console.WriteLine("Don`t andestend (");
                    break;
            }
        }
    }
}
