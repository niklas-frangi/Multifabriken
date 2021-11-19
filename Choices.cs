using System;
using System.Collections.Generic;
using System.Threading;

namespace multifabriken_niklas_frangi
{
    class Choices
    {
        List<Car> carList = new List<Car>();
        List<Candy> candyList = new List<Candy>();
        List<Tofu> tofuList = new List<Tofu>();
        List<String> stringList = new List<String>();
        public Choices(List<Car> carList, List<Candy> candyList, List<Tofu> tofuList, List<String> stringList)
        {
            this.carList = carList;
            this.candyList = candyList;
            this.tofuList = tofuList;
            this.stringList = stringList;
        }
        public Boolean makeChoice(int choice)
        {

            switch (choice)
            {
                case 1:
                    // Bilar
                    Console.Clear();
                    Console.WriteLine("Skriv registreringsnumrets tre bokstäver.");
                    string letterPlate = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Skriv registreringsnumrets tre siffror.");
                    int numberPlate = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Vilken färg vill du att bilen ska ha?");
                    string color = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Vilket märke vill du ha på bilen?.");
                    string brand = Console.ReadLine();
                    Console.WriteLine();
                    Car newCar = new Car(letterPlate, numberPlate, color, brand);
                    carList.Add(newCar);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Du har beställt en {color} {brand} med registreringsnumret {letterPlate}{numberPlate}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    break;

                case 2:
                    // Godis
                    Console.Clear();
                    Console.WriteLine("Vilken smak av godis vill du ha?");
                    string candyFlavour = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Hur många godisbitar vill du ha?");
                    int candyAmount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Candy newCandy = new Candy(candyFlavour, candyAmount);
                    candyList.Add(newCandy);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Du har beställt {candyAmount} godisbitar med smaken {candyFlavour}.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    break;

                case 3:
                    // Snöre
                    Console.Clear();
                    Console.WriteLine("Vilken färg ska ditt snöre ha?");
                    string stringColor = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Hur långt (heltal i cm) ska snöret vara?");
                    int stringLength = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    String newString = new String(stringColor, stringLength);
                    stringList.Add(newString);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Du har beställt ett {stringLength} cm långt snöre med färgen {stringColor}.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    break;

                case 4:
                    // Tofu
                    Console.Clear();
                    Console.WriteLine("Hur mycket (heltal i liter) tofu vill du beställa?");
                    int tofuAmount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Vilken kryddning vill du ha i din tofu?");
                    string tofuSeasoning = Console.ReadLine();
                    Console.WriteLine();
                    Tofu newTofu = new Tofu(tofuSeasoning, tofuAmount);
                    tofuList.Add(newTofu);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Du har beställt {tofuAmount} liter tofu med kryddningen {tofuSeasoning}.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    break;

                case 5:
                    // Skriva ut listor                
                    Console.Clear();
                    Console.Write("           ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(" Det här har du beställt ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    foreach (Car car in carList)
                    {
                        Console.WriteLine($"- En {car.color} {car.brand} med registreringsnumret {car.letterPlate}{car.numberPlate}");
                    }
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    foreach (Candy candy in candyList)
                    {
                        Console.WriteLine($"- {candy.candyAmount} st godisbitar med smaken {candy.flavour}");
                    }
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    foreach (Tofu tofu in tofuList)
                    {
                        Console.WriteLine($"- {tofu.tofuAmount} liter tofu med kryddningen {tofu.tofuSeasoning}");
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    foreach (String thisString in stringList)
                    {
                        Console.WriteLine($"- Ett {thisString.length} cm långt snöre med färgen {thisString.color}");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    var delay4 = 700;
                    Thread.Sleep(delay4);
                    do
                    {
                        while (!Console.KeyAvailable)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\r Tryck på Enter för att återgå till menyn.");
                            var delay2 = 600;
                            Thread.Sleep(delay2);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("\r Tryck på Enter för att återgå till menyn.");
                            var delay3 = 600;
                            Thread.Sleep(delay3);
                        }
                    } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Clear();
                    break;

                case 6:
                    // Avsluta program
                    Console.Clear();
                    Console.WriteLine("Programmet har avslutats.");
                    return false;

                default:
                    // Fel input
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Fel input, välj en siffra mellan 1-6.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    var delay = 1000;
                    Thread.Sleep(delay);
                    break;
            }
            return true;
        }
    }
}