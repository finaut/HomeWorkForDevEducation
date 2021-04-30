using System;

namespace ClassWork11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            State state1 = new State();
            State state2 = new State();
            
            state2.x = 1;
            state2.y = 2;
            state2.country = new Country();
            state2.country.x = 11;
            state2.country.y = 22;
         
            state1 = state2;

            Console.WriteLine($"state1.x = {state1.x}");
            Console.WriteLine($"state1.y = {state1.y}");
            Console.WriteLine($"state1.country.x = {state1.country.x}");
            Console.WriteLine($"state1.country.y = {state1.country.y}");
            
            state2.x = 3;
            state2.y = 4;
            state2.country = new Country();
            state2.country.x = 33;
            state2.country.y = 44;

            Console.WriteLine($"state2.x = {state2.x}");
            Console.WriteLine($"state2.y = {state2.y}");
            Console.WriteLine($"state2.country.x = {state2.country.x}");
            Console.WriteLine($"state2.country.y = {state2.country.y}");

            Console.WriteLine($"state1.x = {state1.x}");
            Console.WriteLine($"state1.y = {state1.y}");
            Console.WriteLine($"state1.country.x = {state1.country.x}");
            Console.WriteLine($"state1.country.y = {state1.country.y}");
            // state2.x = 11;
            // state2.y = 22;
            //
            // Console.WriteLine($"state2.x = {state2.x}");
            // Console.WriteLine($"state2.y = {state2.y}");
            //
            // Console.WriteLine($"state1.x = {state1.x}");
            // Console.WriteLine($"state1.y = {state1.y}");
            //
            // Country country1 = new Country();
            // Country country2 = new Country();
            //
            // country2.x = 1;
            // country2.y = 2;
            //
            // country1 = country2;
            // Console.WriteLine($"country1.x = {country1.x}");
            // Console.WriteLine($"country1.y = {country1.y}");
            //
            // country2.x = 11;
            // country2.y = 22;
            //
            // Console.WriteLine($"country2.x = {country2.x}");
            // Console.WriteLine($"country2.y = {country2.y}");
            //
            // Console.WriteLine($"country1.x = {country1.x}");
            // Console.WriteLine($"country1.y = {country1.y}");            
            //
            
        }
        public struct State
        {
            public int x;
            public int y;
            public Country country;

        }
        public class Country
        {
            public int x;
            public int y;
        }
    }
}