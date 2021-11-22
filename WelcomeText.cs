using System;

namespace multifabriken_niklas_frangi
{
    class Welcome
    {
        public void printWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Introduktion:");
            Console.WriteLine();
            Console.WriteLine("Här kan du beställa olika produkter från vår fabrik.");
            Console.WriteLine("Välj alternativ genom att skriva en siffra och tryck sedan på enterknappen.");
            Console.WriteLine("Du kan inte ta bort produkter efter att du beställt dem, så var försiktig!");
            Console.WriteLine();
        }
    }
}
