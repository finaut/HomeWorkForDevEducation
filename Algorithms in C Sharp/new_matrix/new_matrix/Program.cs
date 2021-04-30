using System;
using System.Collections.Generic;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Album = new Dictionary<string, int>(7);
            Album.Add("The Loosing Subtlety", 145);
            Album.Add("Rainy Promises", 67);
            Album.Add("A Time Of Choice", 89);
            Album.Add("Pure Wonders", 53);
            Album.Add("Forget About Your Midnight", 157);
            Album.Add("Olden Theater", 64);

            foreach(KeyValuePair<string, int> keyValue in Album)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value + " like.");
            }
        }   
    }
}
