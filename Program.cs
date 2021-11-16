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

            while (true)
            {
                theMenu.printMenu();
                int menuChoice = Convert.ToInt32(Console.ReadLine());
                Choices newChoice = new Choices();
                newChoice.makeChoice(menuChoice);                
            }

        }
    }
}



/* Fullösning med return

if (menuChoice == 6)
{
    return;
}
else
{
    newChoice.makeChoice(menuChoice);
} */