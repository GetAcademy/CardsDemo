using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CardsDemo.UnitTest
{
    class SuitTest
    {
        [Test]
        public void TestCreate()
        {
            var clubs = Suit.Clubs;
            Assert.AreEqual(clubs.Name, "Kløver");
        }
    }
}
