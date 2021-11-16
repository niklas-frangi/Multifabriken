using System;
using System.Collections.Generic;

namespace multifabriken_niklas_frangi
{
    class Tofu
    {
        public string tofuSeasoning;
        public int tofuAmount;
        public List<Tofu> tofuList = new List<Tofu>();
        public Tofu(string tofuSeasoning, int tofuAmount)
        {
            this.tofuSeasoning = tofuSeasoning;
            this.tofuAmount = tofuAmount;
        }

        public void addTofuToList(Tofu newTofu)
        {
            tofuList.Add(newTofu);
        }

        public void printTofulist()
        {
            System.Console.WriteLine("Listan med tofu innehåller:");
            System.Console.WriteLine();
            foreach (Tofu tofu in tofuList)
            {
                System.Console.WriteLine($"- {tofu.tofuAmount} liter tofu med kryddningen {tofu.tofuSeasoning}.");
            }
        }

    }
}