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
                Console.WriteLine("X = Exit, N=Add Car, E=Edit existing Car, D=Remove Car, S=Show all cars"); //meny
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
                        foreach (Car c in allCars)
                        {
                            Console.WriteLine($"{c.Model} {c.Color} {c.Price} {c.YearModel}");
                        }
                        Console.WriteLine("Vilken bil vill du redigera? (Positiva Heltal)");
                        int x = Convert.ToInt32(Console.ReadLine());
                        allCars.RemoveAt(x - 1);
                        // input för att välja hur den redigerade bilen ska se ut

                        Console.WriteLine("Skriv modell på bilen:"); 
                        string editedmodel = Console.ReadLine();
                        
                        Console.WriteLine("Vilken färg har bilen?:");
                        string editedcolor = Console.ReadLine();

                        Console.WriteLine("Hur mycket kostar bilen?:");
                        string editedprice = Console.ReadLine();

                        Console.WriteLine("Mata in årsmodellen på bilen:");
                        string editedyearmodel = Console.ReadLine();
                        
                        allCars.Insert(x-1, new Car() { Model = editedmodel, Color = editedcolor, Price = editedprice, YearModel = editedyearmodel}); 
                        // byter ut den gamla bilen med dessa nya paramterar

                        break;

                    case "d":   // remove car med hjälp av användarens input
                        Console.WriteLine("Dessa bilar finns för tillfället:");
                        foreach (Car c in allCars) // Lista över alla bilar (skriver ut all bilar)
                        {
                            Console.WriteLine($"{c.Model} {c.Color} {c.Price} {c.YearModel}");
                            Console.WriteLine("==========================");
                        }
                                                                                                         
                        Console.WriteLine("Skriv in listnummer på bil du vill ta bort från listan (positivt heltal)");

                        int i = Convert.ToInt32(Console.ReadLine());

                        allCars.RemoveAt(i-1);    // uppstår problem när användaren inmatar negativa tal och 0, då det skapar negativa index nummer.
                                                       
                        foreach (Car c in allCars)
                        {
                            Console.WriteLine($"{c.Model} {c.Color} {c.Price} {c.YearModel}");
                        }
                        Console.Clear();

                        break;

                    case "s":   // Lista över alla bilar (skriver ut all bilar)
                        foreach (Car c in allCars)
                        {
                            Console.WriteLine($"{c.Model} {c.Color} {c.Price} {c.YearModel}");
                        }
                        break;

                    default:
                        Console.WriteLine("Skriv in rätt bokstav, testa med en liten bokstav!");

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