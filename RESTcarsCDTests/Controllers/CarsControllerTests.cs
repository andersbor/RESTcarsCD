﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using RESTcarsCD.Models;

namespace RESTcarsCD.Controllers.Tests
{
    [TestClass()]
    public class CarsControllerTests
    {
        private CarsController controller = new CarsController();

        [TestMethod()]
        public void GetTest()
        {
            IEnumerable<Car> all = controller.Get();
            Assert.AreEqual(2, all.Count());
            Assert.IsNotNull(controller);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Car car = controller.GetById(1);
            Assert.IsNotNull(car);
            Assert.IsNull(controller.GetById(3));
        }

        [TestMethod()]
        public void PostTest()
        {

        }

        [TestMethod()]
        public void PutTest()
        {

        }

        [TestMethod()]
        public void DeleteTest()
        {

        }
    }
}