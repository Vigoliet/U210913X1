using System;
using System.Collections.Generic;

namespace ACME_Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<Car> allCars = new List<Car>();
            
            while (true)
            {
                Console.WriteLine("X = Exit, N=Add Car, E=Edit existing Car, D=Remove Car, S=Show all cars");
                string alternatives = Console.ReadLine();
                switch (alternatives)
                {
                    case "x":
                        Console.Clear();        
                        break;

                    case "n":
                        Console.WriteLine("Skriv modell på bilen:");
                        string model = Console.ReadLine();

                        Console.WriteLine("Vilken färg har bilen?:");
                        string color = Console.ReadLine();

                        Console.WriteLine("Hur mycket kostar bilen?:");
                        string price = Console.ReadLine();

                        Console.WriteLine("Mata in årsmodellen på bilen:");
                        string yearmodel = Console.ReadLine();

                        allCars.Add(new Car() { Model = model, Color = color, Price = price, YearModel = yearmodel });
                        break;

                    case "e":
                        break;

                    case "d":
                        break;

                    case "s":
                        break;

                }


            }
        }
    }
}
    public class Car                        // är nu en datatyp / klass
{
    public string Model { get; set; }       // Model
    public string Color { get; set; }       // Färg
    public string Price { get; set; }       // Pris
    public string YearModel { get; set; }   // Årsmodell
}