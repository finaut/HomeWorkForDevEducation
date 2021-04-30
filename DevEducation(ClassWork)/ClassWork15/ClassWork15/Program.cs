using System;

namespace ClassWork15
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var a = 5;
                if (a > 2)
                {
                    throw new MyExeption("exceptionNumA");
                }
            }
            catch(MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Console.WriteLine("finally");
            }
        }
    }
}