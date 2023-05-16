using System;
using System.IO;
using System.Reflection;

namespace MechanicSystemCatalog
{
	public class Car
    { 
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public List<string> Parts { get; set; }

    public Car(string model, string manufacturer)
    {
        Model = model;
        Manufacturer = manufacturer;
        Parts = new List<string>();
    }

    public void AddPart(string part)
    {
        Parts.Add(part);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Car Model: {Model}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine("Parts:");

        foreach (string part in Parts)
        {
            Console.WriteLine(part);
        }
    }
}

}

