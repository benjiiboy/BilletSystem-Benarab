using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            //Arrange
            MC MC = new MC();

            //Act
            int Pris = MC.Pris();

            //Assert
            Assert.AreEqual(125, Pris);
        }

        [TestMethod()]
        public void køretøjTest()
        {
            //Arrange
            MC MC = new MC();

            //Act
            string Køretøj = MC.køretøj();

            //Assert
            Assert.AreEqual("MC", Køretøj);
        }
    }
}