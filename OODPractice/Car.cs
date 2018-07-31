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
        private double mileage;
        public List<string> OwnerHistory;

        public Car()
        {
            Make = "Honda";
            Model = "Accord";
            Year = 2000;
            mileage = 200_000;
            OwnerHistory = new List<string>();
        }

        public Car(string make, string model, int year, double mileage) : this()
        {
            Make = make;
            Model = model;
            Year = year;
            this.mileage = mileage;
        }

        public double AddMiles(double mileage)
        {
            this.mileage += mileage;
            return this.mileage;
        }

        public double GetMileage()
        {
            return mileage;
        }

        public void SetMileage(double mileage)
        {
            this.mileage = mileage;
        }
    }
}
