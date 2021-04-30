using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Поезд имеет следующие свойства: 
 *      1.1 Имя.
 *      1.2 Количество Вагонов.
 *      1.3 Скорость.
 *      1.4 Текущая станция.
 *      1.5 Текущий маршрут.
 */
namespace Go_Go_Train
{
    class Train
    {
        public Train(string name, int numberCargos,
                     int speed, Station currentStation = null,
                     Route currentRoute = null)
        {
            Name = name;
            NumberCargos = numberCargos;
            Speed = speed;
            CurrentStation = currentStation;
            CurrentRoute = currentRoute;
        }

        private string name;
        private int numberCargos;
        private int speed;
        public Station CurrentStation { get; set; }
        public Route CurrentRoute { get; set; }
        public string Name
        {
            get => $"{name} it`s current name train.";
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name most be full.");
                }
                name = value;
                Console.WriteLine("Set new name for train.");
            }
        }
        public int NumberCargos
        {
            get => numberCargos;
            set
            {
                if (value <= 0 && value > 99)
                {
                    throw new ArgumentNullException("Maximum or unrealistic number of wagons.");
                }
                numberCargos = value;
                Console.WriteLine($"get`s new value for current cargos. {value}");
            }
        }
        public int Speed
        {
            get => speed;
            set
            {
                if (value <= 0 && value > 320)
                {
                    throw new ArgumentNullException("Maximum or unrealistic speed");
                }
                speed = value;
                Console.WriteLine("get new current speed for train: " + value + " km/");
            }
        }
    }
}
