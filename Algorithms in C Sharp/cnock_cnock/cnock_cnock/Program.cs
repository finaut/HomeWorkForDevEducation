using System;

namespace cnock_cnock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entry the number of minute: ");
            string input2 = Console.ReadLine();
            int minutes = Convert.ToInt32(input2);
            ConvertMinute(minutes);
        }

        private static void ConvertMinute(int minutes)
        {
            int minutesLeft = minutes%60;
            int hours = (minutes / 60) ;
            Console.WriteLine($"{minutesLeft} - current minutes.");
            Console.WriteLine($"{hours} - current hours.");
        }
    }
}
