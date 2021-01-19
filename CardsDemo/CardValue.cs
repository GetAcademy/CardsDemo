using System;
using System.Collections.Generic;
using System.Text;

namespace CardsDemo
{
    public class CardValue
    {
        private int _value;

        private CardValue(int value)
        {
            _value = value;
        }

        public static CardValue Create(int value)
        {
            if (value < 1 || value > 14) return null;
            return new CardValue(value); 
        }


    }
}
