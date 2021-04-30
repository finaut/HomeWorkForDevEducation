using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go_Go_Train
{
    class Station
    {
        // Для начал нужно проинициализировать переменные
        public Station(string name, int sizeDepot)
        {
            Name = name;
            SizeDepot = sizeDepot;

        }
        private string name;
        private int sizeDepot;
        private Train[] depot;

        // Нужно написать метод который будет выводить весь наш массив.
        // Показывать какая платформа свободна(ячейка памяти).
        // Добавлять и убалять поезда.

        public Train[] Show()
        {
            foreach (Train i in this.depot)
            {
                Console.WriteLine(i.Name);
            }
            return this.depot;
        }

        public Train[] AddTrain()
        {
            for (int index = 0; index <= this.depot.Length; index++)
            {

            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name must be blank!");
                }
                name = value;
            }
        }

        public int SizeDepot
        {
            get => sizeDepot;
            set
            {
                if (value < 0 && value > 20)
                {
                    throw new ArgumentNullException("The number must not be more than 20 or less than 0.");
                }
                sizeDepot = value;
                Train[] depot = new Train[value];
            }
        }
    }
}
