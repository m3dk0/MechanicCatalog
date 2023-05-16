using System;
namespace MechanicSystemCatalog
{
	public class MechanicCatalog
    {
        private List<Car> cars;

        public MechanicCatalog()
        {
            cars = new List<Car>();
        }

        public void AddCar(string model, string manufacturer)
        {
            Car car = new Car(model, manufacturer);
            cars.Add(car);
            Console.WriteLine($"Car {model} by {manufacturer} has been added to the catalog.");
        }

        public void AddPartToCar(string model, string part)
        {
            Car car = FindCarByModel(model);

            if (car != null)
            {
                car.AddPart(part);
                Console.WriteLine($"Part '{part}' has been added to the car {model}.");
            }
            else
            {
                Console.WriteLine($"Car with model {model} does not exist in the catalog.");
            }
        }

        public void DisplayCarInfo(string model)
        {
            Car car = FindCarByModel(model);

            if (car != null)
            {
                car.DisplayInfo();
            }
            else
            {
                Console.WriteLine($"Car with model {model} does not exist in the catalog.");
            }
        }

        private Car FindCarByModel(string model)
        {
            foreach (Car car in cars)
            {
                if (car.Model == model)
                {
                    return car;
                }
            }

            return null;
        }
    }

}

