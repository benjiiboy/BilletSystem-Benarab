﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            //Arrange
            Bil Bil = new Bil();

            //Act
            int Pris = Bil.Pris();

            //Assert
            Assert.AreEqual(240, Pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            //Arrange
            Bil Bil = new Bil();

            //Act
            string Køretøj = Bil.Køretøj();

            //Assert
            Assert.AreEqual("Bil", Køretøj);
        }
    }
}