using System;
using System.Collections.Generic;
using System.Threading;

namespace multifabriken_niklas_frangi
{
    class Choices
    {
        public void makeChoice(int choice)
        {

            switch (choice)
            {
                case 1:
                    // Bilar
                    Console.Clear();
                    Console.WriteLine("Skriv registreringsnumrets tre bokstäver.");
                    string letterPlate = Console.ReadLine();
                    System.Console.WriteLine();
                    Console.WriteLine("Skriv registreringsnumrets tre siffror.");
                    int numberPlate = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine();
                    Console.WriteLine("Vilken färg vill du att bilen ska ha?");
                    string color = Console.ReadLine();
                    System.Console.WriteLine();
                    Console.WriteLine("Vilket märke vill du ha på bilen?.");
                    string brand = Console.ReadLine();
                    System.Console.WriteLine();
                    Car newCar = new Car(letterPlate, numberPlate, color, brand);
                    newCar.addCarToList(newCar);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Console.WriteLine($"Du har beställt en {color} {brand} med registreringsnumret {letterPlate}{numberPlate}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    System.Console.WriteLine();
                    break;

                case 2:
                    // Godis
                    Console.Clear();
                    System.Console.WriteLine("Vilken smak av godis vill du ha?");
                    string candyFlavour = Console.ReadLine();
                    System.Console.WriteLine();
                    System.Console.WriteLine("Hur många godisbitar vill du ha?");
                    int candyAmount = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine();
                    Candy newCandy = new Candy(candyFlavour, candyAmount);
                    newCandy.addCandyToList(newCandy);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Console.WriteLine($"Du har beställt {candyAmount} godisbitar med smaken {candyFlavour}.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    System.Console.WriteLine();
                    break;

                case 3:
                    // Snöre
                    Console.Clear();
                    System.Console.WriteLine("Vilken färg ska ditt snöre ha?");
                    string stringColor = Console.ReadLine();
                    System.Console.WriteLine();
                    System.Console.WriteLine("Hur långt (heltal i cm) ska snöret vara?");
                    int stringLength = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine();
                    String newString = new String(stringColor, stringLength);
                    newString.addStringToList(newString);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Console.WriteLine($"Du har beställt ett {stringLength} cm långt snöre med färgen {stringColor}.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    System.Console.WriteLine();
                    break;

                case 4:
                    // Tofu
                    Console.Clear();
                    System.Console.WriteLine("Hur mycket (heltal i liter) tofu vill du beställa?");
                    int tofuAmount = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine();
                    System.Console.WriteLine("Vilken kryddning vill du ha i din tofu?");
                    string tofuSeasoning = Console.ReadLine();
                    System.Console.WriteLine();
                    Tofu newTofu = new Tofu(tofuSeasoning, tofuAmount);
                    newTofu.addTofuToList(newTofu);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Console.WriteLine($"Du har beställt {tofuAmount} liter tofu med kryddningen {tofuSeasoning}.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    System.Console.WriteLine();
                    break;

                case 5:
                    // Skriva ut listor
                    Console.Clear();
                    break;

                case 6:
                    // Avsluta program
                    Console.Clear();
                    break;

                default:
                    // Fel input
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("Fel input, välj en siffra mellan 1-6.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    System.Console.WriteLine();
                    var milliseconds = 1000;
                    Thread.Sleep(milliseconds);
                    break;
            }
        }
    }
}