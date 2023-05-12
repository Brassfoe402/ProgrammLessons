using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Car
    {
        public string Make { get; }
        public string Model { get; }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
        }
    }

    class Garage
    {
        private readonly List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void WashAllCars()
        {
            WashCarDelegate washDelegate = new WashCarDelegate(WashCar);
            cars.ForEach(car => washDelegate(car));
        }

        private delegate void WashCarDelegate(Car car);

        private void WashCar(Car car)
        {
            Console.WriteLine($"Моем машину {car.Make} {car.Model}");
        }
    }

    class CarWash
    {
        public static void Main()
        {
            var car1 = new Car("Toyota", "Corolla");

            var car2 = new Car("Honda", "Civic");

            var garage = new Garage();

            garage.AddCar(car1);

            garage.AddCar(car2);

            garage.WashAllCars();
     
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
