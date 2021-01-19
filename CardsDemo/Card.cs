using System;
using System.Collections.Generic;
using System.Text;

namespace CardsDemo
{
    public class Card
    {
        private Suit _suit;

        private CardValue _cardValue;
        //public Card(string suit, int value)
        //{
        //    Value = value;
        //}

        public Card(Suit suit, CardValue cardValue)
        {
            _cardValue = cardValue;
            _suit = suit;
        }

        public int Value { get; }
        public bool IsFaceCard { get; set; }
    }
}
