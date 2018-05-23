using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AcuCafe.Test
{
    [TestClass]
    public class UnitTest1
    {
        AcuCafe cafe;

        [TestInitialize]
        public void Setup()
        {
            cafe = new AcuCafe();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),
    "Wrong drink type")]
        public void Create_a_drink_with_wrongType()
        {
            var drink = cafe.OrderDrink("wrong type", true, true, true);
            
        }

        [TestMethod]
        
        public void Create_a_expresso_with_Milk_Sugar_Mocha()
        {
           
            var expected = 3.3; // 1.8 +0.5+0.5+0.5
            var drink = cafe.OrderDrink("Expresso", true, true, true);
            var price = drink.Cost();

            Assert.AreEqual(expected, price);

        }

        [TestMethod]
        public void Create_a_expresso_with_Milk_Sugar_NoMocha()
        {
            
            var expected = 2.8; // 1.8 +0.5+0.5
            var drink = cafe.OrderDrink("Expresso", true, true, false);
            var price = drink.Cost();

            Assert.AreEqual(expected, price);

        }

        [TestMethod]
        public void Create_a_Tea_with_Milk_Sugar_NoMocha()
        {

            var expected = 2.0; // 1 +0.5+0.5
            var drink = cafe.OrderDrink("Tea", true, true, false);
            var price = drink.Cost();

            Assert.AreEqual(expected, price);

        }

        [TestMethod]
        public void Create_an_IceTea_with_NoMilk_Sugar_NoMocha()
        {

            var expected = 2.0; // 1.5 +0.5
            var drink = cafe.OrderDrink("IceTea", false, true, false);
            var price = drink.Cost();

            Assert.AreEqual(expected, price);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception),
    "Wrong drink type")]
        public void Create_an_IceTea_with_Milk_ThrowException()
        {
            
            var drink = cafe.OrderDrink("IceTea", true, true, false);
           

        }

    }
}

