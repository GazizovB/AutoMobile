using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobile
{
    public class AutoCars
    {
        public string Name;
        public int Speed;
        public int Finish_Time;


        public AutoCars() { }

        //public AutoCars(int speed)
        //{
        //    Speed = speed;
        //}


        public void PrintCar()
        {
            Console.WriteLine($"Модель: {Name}\nСкорость: {Speed} км/час\nВремя: {Finish_Time}мин");
            Console.WriteLine();
        }

        public void Winner()
        {
            Console.WriteLine("Winner: ");
        }

    }
}   
