using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OODPractice
{
    using OODPractice;

    [TestClass]
    public class CarsTests
    {

        [TestMethod]
        public void TestCarInstantiationDefault()
        {
            var car = new Car();

            Assert.AreEqual(car.Make, "Honda");
            Assert.AreEqual(car.Model, "Accord");
            Assert.AreEqual(car.Year, 2000);
            Assert.IsNotNull(car.OwnerHistory);
        }
        [TestMethod]
        public void TestCarInstantiation()
        {
            var car = new Car("Toyota", "Camry", 1999, 200_000);

            Assert.AreEqual(car.Make, "Toyota");
            Assert.AreEqual(car.Model, "Camry");
            Assert.AreEqual(car.Year, 1999);
            Assert.IsNotNull(car.OwnerHistory);
        }

        [TestMethod]
        public void TestAddMiles()
        {
            var car = new Car();
            var mileage = car.AddMiles(100_000);

            Assert.AreEqual(mileage, 300_000);
        }

        [TestMethod]
        public void TestGetNumWheels()
        {
            var car = new Car();
            var numWheels = car.GetNumWheels();

            Assert.AreEqual(numWheels, 4);
        }

        //[TestMethod]
        //public void TestAddMiles()
        //{
        //    var car = new Car();
        //    car.SetMileage(200_000);
        //    var mileage = car.AddMiles(100_000);

        //    Assert.AreEqual(mileage, 300_000);
        //}

        //[TestMethod]
        //public void TestSetMileage()
        //{
        //    var car = new Car();
        //    car.SetMileage(400_000);
        //    var mileage = car.GetMileage();

        //    Assert.AreEqual(mileage, 400_000);
        //}
    }
}
