using NUnit.Framework;

namespace CardsDemo.UnitTest
{
    public class Tests
    {
        [Test]
        public void TestCardValue()
        {
            var card = new Card(Suit.Clubs, CardValue.Create(7));
            Assert.AreEqual(7, card.Value);
        }

        [Test]
        public void TestIsNotHighCard()
        {
            var card = new Card(Suit.Clubs, CardValue.Create(7));
            Assert.IsFalse(card.IsFaceCard);
        }

        [Test]
        public void TestIsHighCard()
        {
            var card = new Card(Suit.Clubs, CardValue.Create(12));
            Assert.IsTrue(card.IsFaceCard);
        }
    }
}