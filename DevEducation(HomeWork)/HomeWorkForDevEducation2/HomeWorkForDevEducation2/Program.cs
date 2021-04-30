using System;

namespace HomeWorkForDevEducation2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
        }
        private static void Task5()
        {
            // Task №5 -- twenty five
            int dozentsForExaption;
            int unitsForExaption;
            Console.WriteLine("Please entry  two-digit number: ");
            string number = Console.ReadLine(); 
            string dozents = number.Substring(0, 1);
            string units = number.Substring(1, 1);
            bool tryCheckDozents = int.TryParse(dozents, out dozentsForExaption);
            bool tryCheckUnits = int.TryParse(units, out unitsForExaption);
            if ( tryCheckDozents == true && tryCheckUnits == true)
            {
                if (dozents == "1")
                {
                    switch (units)
                    {
                        case "0":
                            Console.WriteLine("Ten");
                            break;
                        case "1":
                            Console.WriteLine("Eleven");
                            break;
                        case "2":
                            Console.WriteLine("Twelve");
                            break;
                        case "3":
                            Console.WriteLine("Thirteen");
                            break;
                        case "4":
                            Console.WriteLine("Fourteen");
                            break;
                        case "5":
                            Console.WriteLine("Fifteen");
                            break;
                        case "6":
                            Console.WriteLine("Sixteen");
                            break;
                        case "7":
                            Console.WriteLine("Seventeen");
                            break;
                        case "8":
                            Console.WriteLine("Eighteen");
                            break;
                        case "9":
                            Console.WriteLine("Nineteen");
                            break;
                    }
                }
                else
                {
                    string phrase = "";

                    switch (dozents)
                    {
                        case "2":
                            phrase += "twenty ";
                            break;
                        case "3":
                            phrase += "thirty ";
                            break;
                        case "4":
                            phrase += "forty ";
                            break;
                        case "5":
                            phrase += "fifty ";
                            break;
                        case "6":
                            phrase += "sixty ";
                            break;
                        case "7":
                            phrase += "seventy ";
                            break;
                        case "8":
                            phrase += "eighty ";
                            break;
                        case "9":
                            phrase += "ninety ";
                            break;
                    }
                    switch (units)
                    {
                        case "1":
                            phrase += "one";
                            break;
                        case "2":
                            phrase += "two";
                            break;
                        case "3":
                            phrase += "three";
                            break;
                        case "4":
                            phrase += "four";
                            break;
                        case "5":
                            phrase += "five";
                            break;
                        case "6":
                            phrase += "six";
                            break;
                        case "7":
                            phrase += "seven";
                            break;
                        case "8":
                            phrase += "eigh";
                            break;
                        case "9":
                            phrase += "nine";
                            break;
                        case "0":
                            break;
                    }
                    Console.WriteLine(phrase);
                }
            } else
            {
                Console.WriteLine("Invalid data format, please entry currect value again.");
                Console.WriteLine("==========================================================");
            }
        }

        private static void Task4()
        {
            //Task №4 -- quadratic equation
            double a;
            double b;
            double c;
            double x;
            Console.WriteLine("Formula: AX*2 + BX + C = 0");

            Console.WriteLine("Please entry number A: ");
            bool input1 = double.TryParse(Console.ReadLine(), out a);
            
            Console.WriteLine("Entry number B: ");
            bool input2 = double.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("Entry number C: ");
            bool input3 = double.TryParse(Console.ReadLine(), out c);
            if (input1 == true && input2 == true && input3 == true)
            {
                double discriminant = (b * b) - (4 * a * c);
                if (discriminant > 0)
                {
                    double x1 = ((-b - Math.Sqrt(discriminant)) / (2 * a));
                    double x2 = ((-b + Math.Sqrt(discriminant)) / (2 * a));
                    Console.WriteLine($"Discriminant: {discriminant}, first root(x1): {x1},  second root(x2): {x2}");
                }
                else if (discriminant == 0)
                {
                    x = (-b / (2 * a));
                    Console.WriteLine($"Discriminant: {discriminant}, x = {x}");
                }
                else
                {
                    Console.WriteLine("operation is impossible because the decrementant < 0");
                }
            }
            else
            {
                Console.WriteLine("Invalid data format, please entry currect value again.");
                Console.WriteLine("==========================================================");
            }
        }

        private static void Task3()
        {

            //// Task  №3  -- sort
            double a;
            double b;
            double c;
            Console.WriteLine("Program for sorting numbers.");
            Console.WriteLine("Entry number A: ");
            bool input1 = double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Entry number B: ");
            bool input2 = double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Entry number C: ");
            bool input3 = double.TryParse(Console.ReadLine(), out c);
            if ( input1 == true &&  input2 == true && input3 == true )
            {
                if (a > b && a > c)
                {
                    if (b > c)
                    {
                        Console.Write($"Output: {c} {b} {a}");
                    }
                    else
                    {
                        Console.Write($"Output: {b} {c} {a}");
                    }
                }
                else if (b > a && b > c)
                {
                    if (a > c)
                    {
                        Console.Write($"Output: {c} {a} {b}");
                    }
                    else
                    {
                        Console.Write($"Output: {a} {c} {b}");
                    }
                }
                else
                {
                    if (b > a)
                    {
                        Console.Write($"Output: {a} {b} {c}");
                    }
                    else
                    {
                        Console.Write($"Output: {b} {a} {c}");
                    }
                }
            } else
            {
                Console.WriteLine("Invalid data format, please entry currect value again.");
                Console.WriteLine("==========================================================");
            }
        }

        private static void Task2()
        {
            //// Task №2 -- IV coordinate 
            double x;
            double y;
            Console.WriteLine("Please entry coordinate X: ");
            bool input1 = double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Entry coordinate Y: ");
            bool input2 = double.TryParse(Console.ReadLine(), out y);
            if (input1 == true && input2 == true)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Coordinate point == I ");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Coordinate point == II");

                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Coordinate point == III");
                }
                else
                {
                    Console.WriteLine("Coordinate point == IV ");
                }
            } else
            {
                Console.WriteLine("Invalid data format, please entry currect coordinats again.");
                Console.WriteLine("==========================================================");
            }
        }

        private static void Task1()
        {
            //// Task №1
            double a;
            double b;
            Console.WriteLine("Please entry number A: ");
            bool input1 = double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Please entry number B: ");
            bool input2 = double.TryParse(Console.ReadLine(), out b);
            if ( input1 == true && input2 == true)
            {
                //(как по мне слабочитаемо но это работает выбрал
                //что бы показать что я запомнил терналку)

                var result = ((a > b) ? a + b
                    : (a == b) ? a * b
                    : (a - b));
                Console.WriteLine($"answer: {result}");
                
                
                //if (a > b)
                //{
                //    Console.WriteLine($"answer: {a + b}");
                //}
                //else if (a == b)
                //{
                //    Console.WriteLine($"answer: {a * b}");
                //}
                //else
                //{
                //    Console.WriteLine($"answer: {a - b}");
                //}
            }
            else
            {   
                Console.WriteLine("Invalid data format, please entry currect value again.");
                Console.WriteLine("==========================================================");
            }
        }
    }
}
