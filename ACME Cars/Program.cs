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

                    case "n":   // Skapa en ny bil
                        Console.WriteLine("Skriv modell på bilen:");
                        string model = Console.ReadLine();

                        Console.WriteLine("Vilken färg har bilen?:");
                        string color = Console.ReadLine();

                        Console.WriteLine("Hur mycket kostar bilen?:");
                        string price = Console.ReadLine();

                        Console.WriteLine("Mata in årsmodellen på bilen:");
                        string yearmodel = Console.ReadLine();
                        
                        allCars.Add(new Car() { Model = model, Color = color, Price = price, YearModel = yearmodel });
                        Console.Clear();

                        break;

                    case "e": // Edit list kommer behöva ändra 1an till en int som användaren bestämmer

                        allCars.Insert(1, new Car() { Model = "Audi", Color = "Blue", Price = "2000k", YearModel = "2020"});
                        break;

                    case "d":   // remove car med hjälp av användarens input
                        Console.WriteLine("Dessa bilar finns för tillfället:");
                        foreach (Car c in allCars) 
                        {
                            Console.WriteLine($"{c.Model} {c.Color} {c.Price} {c.YearModel}");
                        }
                                                                                                         //string i = Console.ReadLine(); //måste konvertera string till int senare
                        Console.WriteLine("Skriv in listnummer på bil du vill ta bort från listan (positivt heltal)");

                        int i = Convert.ToInt32(Console.ReadLine());

                        allCars.RemoveAt(i-1);    
                                                                                                        // uppstår problem när användaren inmatar negativa tal och 0, då det skapar negativa index nummer.
                        Console.WriteLine("================");

                        foreach (Car c in allCars)
                        {
                            Console.WriteLine($"{c.Model} {c.Color} {c.Price} {c.YearModel}");
                        }

                        break;

                    case "s":   // Lista över alla bilar
                        foreach (Car c in allCars)
                        {
                            Console.WriteLine($"{c.Model} {c.Color} {c.Price} {c.YearModel}");
                        }
                        break;

                    default:
                        Console.WriteLine("Skriv in rätt bokstav, testa med en liten bokstav!");
                        Console.Clear();
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