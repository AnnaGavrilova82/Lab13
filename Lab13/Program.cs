using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите адрес здания ");
            string address = Console.ReadLine();
            Console.Write("Введите длину здания ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину здания ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту здания ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите этажность здания ");
            int floor = Convert.ToInt32(Console.ReadLine());
            //Building building = new Building(address, length, width, height);
            MultiBuilding multi_building = new MultiBuilding(address, length, width, height, floor);

            multi_building.Print();
            Console.ReadKey();
        }


        class Building
        {
            public string Address { get; set; }
            public double Length { get; set; }
            public double Width { get; set; }
            public double Height { get; set; }

            public Building(string address, double length, double width, double height)
            {
                Address = address;
                Length = length;
                Width = width;
                Height = height;
            }
            public virtual void Print()
            {
                Console.WriteLine("Адрес здания {0}", Address);
                Console.WriteLine("Длина здания {0}", Length);
                Console.WriteLine("Ширина здания: {0}", Width);
                Console.WriteLine("Высота здания: {0}", Height);
            }
        }
        sealed class MultiBuilding : Building
        {
            public double Floor { get; set; }

            public MultiBuilding(string address, double length, double width, double height, int floor)
                : base(address, length, width, height)
            {
                Address = address;
                Length = length;
                Width = width;
                Height = height;
                Floor = floor;
            }

            public override void Print()
            {
                base.Print();
                Console.WriteLine("Этажей в здания {0}", Floor);
            }

        }
    }
  
}
