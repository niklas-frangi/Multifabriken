using System;
using System.Collections.Generic;

namespace multifabriken_niklas_frangi
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome welcomeMsg = new Welcome();
            welcomeMsg.printWelcomeMessage();
            Menu theMenu = new Menu();
            List<Car> carList = new List<Car>();
            List<Candy> candyList = new List<Candy>();
            List<Tofu> tofuList = new List<Tofu>();
            List<String> stringList = new List<String>();

            while (true)
            {
                theMenu.printMenu();
                int menuChoice = Convert.ToInt32(Console.ReadLine());
                Choices newChoice = new Choices(carList, candyList, tofuList, stringList);
                bool cont = newChoice.makeChoice(menuChoice);
                if (!cont)
                {
                    return;
                }
            }
        }
    }
}
