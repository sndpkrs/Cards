using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.Entities
{

    public class Card
    {
        public string Name { get; set; } //A, 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K
        public CardSuit Suit { get; set; } //Clubs, Hearts, Spades, Diamond
    }
}
