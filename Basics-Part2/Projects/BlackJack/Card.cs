using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace
{
    public class Card
    {
        public string Name => $"{Number} of {Suit}";
        //public string Name { get { return $"{Number} of {Suit}"; } }  <-- Equivalent syntax as above

        public string Suit { get; set; } /// these are properties?
        public string Number { get; set; }
        public string Color { get; set; }
        public int Value { get; set; } // can change to List<int> to account for Ace being 1 or 11
    }
}
