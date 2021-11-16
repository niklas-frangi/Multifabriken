using System;
using System.Collections.Generic;

namespace multifabriken_niklas_frangi
{
    class String
    {
        public string color;
        public int length;
        public List<String> stringList = new List<String>();
        public String(string color, int length)
        {
            this.color = color;
            this.length = length;
        }

        public void addStringToList(String newString)
        {
            stringList.Add(newString);
        }

        public void printStringlist()
        {
            System.Console.WriteLine("Listan med snören innehåller:");
            System.Console.WriteLine();
            foreach (String thisString in stringList)
            {
                System.Console.WriteLine($"- Ett {thisString.length} cm långt snöre med färgen {thisString.color}.");
            }
        }

    }
}