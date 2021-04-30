using System;

namespace enum_example
{
    class Program
    {
        enum WeekDays { Monday, Tuesday, Wednesday,
                            Thursday, Friday, Saturday, Sunday}
        static void Main(string[] args)
        {
            // Массив с названием дней недели на русском.
            string[] WeekDaysRussianNames = { "Понедельник", "Вторник",
             "Среда", "Четверг", "Пятница", "Суббота", "Воскресение" };

            // Вывод как метод у обекта.
            WeekDays day = WeekDays.Thursday;

            // Вывод дня недели в разных форматов
            Console.WriteLine("Today: " + day);
            Console.WriteLine("Today: " + WeekDaysRussianNames[(int)day]);
            int dayIndex = (int)day + 1;
            Console.WriteLine("Number day " + dayIndex);

            // Вот так можно делать проверку сравнением
            if (day == WeekDays.Friday)
            {
                Console.WriteLine("Weekend is coming soon. ");
            }
            Console.ReadLine();
        }
    }

}

