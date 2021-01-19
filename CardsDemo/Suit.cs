using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardsDemo
{
    public class Suit
    {
        private static Suit[] _suits;

        //private static Dictionary<string, Suit> _suits;
        //public static Suit Clubs => GetSuit("kløver");
        public static Suit Clubs { get; }
        public static Suit Hearts { get; }
        public static Suit Diamond { get; }
        public static Suit Spade { get; }
        public string Name { get; }

        private Suit(string name)
        {
            Name = name;
        }

        static Suit()
        {
            Clubs = new Suit("Kløver");
            Hearts = new Suit("Hjerter");
            Diamond = new Suit("Diamond");
            Spade = new Suit("Spar");
            _suits = new[] { Clubs, Hearts, Diamond, Spade};
        }

        public static Suit GetSuit(string name)
        {

            return _suits.FirstOrDefault(
                s => s.Name.ToLower().StartsWith(name.ToLower()));
        }

        //static Suit()
        //{
        //    _suits = new Dictionary<string, Suit>()
        //    {
        //        {"kløver", new Suit("Kløver")},
        //        {"spar", new Suit("Spar")},
        //        {"ruter", new Suit("Ruter")},
        //        {"hjerter", new Suit("Hjerter")},
        //    };
        //}

        //public static Suit GetSuit(string name)
        //{
        //    return _suits.ContainsKey(name) ? _suits[name.ToLower()] : null;
        //}
    }
}
