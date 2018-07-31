using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODPractice
{
    public class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public double Mileage { get; private set; }
        public List<string> OwnerHistory;
        private static int numWheels = 4;

        public Car()
        {
            Make = "Honda";
            Model = "Accord";
            Year = 2000;
            Mileage = 200_000;
            OwnerHistory = new List<string>();
        }

        public Car(string make, string model, int year, double mileage) : this()
        {
            Make = make;
            Model = model;
            Year = year;
            this.Mileage = mileage;
        }

        public double AddMiles(double mileage)
        {
            this.Mileage += mileage;
            return this.Mileage;
        }

        public int GetNumWheels()
        {
            return numWheels;
        }
    }
}
