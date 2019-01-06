using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobile
{
    class Program
    {
        public delegate void Result();

        static void Main(string[] args)
        {
            Console.Write("Введите количество машины: ");
            int AmountCar = int.Parse(Console.ReadLine());
            Console.WriteLine();
            AutoCars[] autoCars = new AutoCars[AmountCar];


            const int Distance = 100;
            Random rand = new Random();

            for (int i = 0; i < AmountCar; i++)
            {
                int Speed123 = rand.Next(200, 240);
                autoCars[i] = new AutoCars();
                Console.Write((i + 1) + " Введите модель машины: ");
                autoCars[i].Name = Console.ReadLine();
                autoCars[i].Speed = Speed123;

                autoCars[i].Finish_Time = Distance * 60 / (autoCars[i].Speed);
                //Array.Sort(autoCars);

                Console.WriteLine();
            }

            //Show
            for (int i = 0; i < autoCars.Length; i++)
            {
                autoCars[i].PrintCar();

            }

            AutoCars res = new AutoCars();
            Result del_res = res.Winner;
            del_res(); // Winner

            Console.ReadKey();
        }
    }
}
