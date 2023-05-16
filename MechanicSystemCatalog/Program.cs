namespace MechanicSystemCatalog;
class Program
{
    static void Main(string[] args)
    {
        MechanicCatalog catalog = new MechanicCatalog();

        catalog.AddCar("Supra", "Toyota");
        catalog.AddPartToCar("Supra", "Engine");
        catalog.AddPartToCar("Supra", "Transmission");
        catalog.AddPartToCar("Supra", "Suspension");

        catalog.AddCar("335i", "BMW");
        catalog.AddPartToCar("335i", "Engine");
        catalog.AddPartToCar("335i", "Transmission");
        catalog.AddPartToCar("335i", "Brakes");

        catalog.DisplayCarInfo("Supra");
        Console.WriteLine("------------------");
        catalog.DisplayCarInfo("335i");
    }
}

