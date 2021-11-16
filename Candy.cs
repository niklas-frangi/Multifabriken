using System;
using System.Collections.Generic;

namespace multifabriken_niklas_frangi
{
    class Candy
    {
        public string flavour;
        public int candyAmount;
        public List<Candy> candyList = new List<Candy>();
        public Candy(string flavour, int candyAmount)
        {
            this.flavour = flavour;
            this.candyAmount = candyAmount;
        }

        public void addCandyToList(Candy newCandy)
        {
            candyList.Add(newCandy);
        }

        public void printCandylist()
        {
            System.Console.WriteLine("Listan med godis innehåller:");
            System.Console.WriteLine();
            foreach (Candy candy in candyList)
            {
                System.Console.WriteLine($"- {candy.candyAmount} st godisbitar med smaken {candy.flavour}.");
            }
        }

    }
}