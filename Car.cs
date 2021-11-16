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
        public List<Car> carList = new List<Car>();
        
        public Car(string letterPlate, int numberPlate, string color, string brand)
        {

            this.letterPlate = letterPlate;
            this.numberPlate = numberPlate;
            this.color = color;
            this.brand = brand;
        }

        public void addCarToList(Car newCar)
        {
            carList.Add(newCar);
        }

        public void printCarlist()
        {
            System.Console.WriteLine("Listan med bilar:");
            foreach (Car car in carList)
            {
                System.Console.WriteLine($"- En {car.color} {car.brand} med registreringsnumret {car.letterPlate}{car.numberPlate}");
            }
        }

    }
}