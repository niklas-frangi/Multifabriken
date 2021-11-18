using System;
using System.Collections.Generic;

namespace multifabriken_niklas_frangi
{
    class Car
    {
        public string letterPlate;
        public int numberPlate;
        public string color;
        public string brand;
        public Car(string letterPlate, int numberPlate, string color, string brand)
        {
            this.letterPlate = letterPlate;
            this.numberPlate = numberPlate;
            this.color = color;
            this.brand = brand;
        }
    }
}