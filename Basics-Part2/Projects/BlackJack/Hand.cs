using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace
{
    /// <summary>
    /// Represents a user's set of cards
    /// </summary>
    public class Hand
    {
        public Hand()
        {
            Cards = new List<Card>();
        }

        public int TotalValue { get; set; }

        public List<Card> Cards { get; set; }

        public bool Bust => TotalValue > 21;

        public void AddCard(Card card, bool userSeesCard, string user)
        {
            Cards.Add(card);
            TotalValue += card.Value;

            if (userSeesCard)
            {
                Console.WriteLine($"Card dealt to {user} hand is: {card.Name}");
            }
        }

        public bool Hit(Card card, string user)
        {
            // All hits are seen by all users
            AddCard(card, true, user);

            if (TotalValue > 21) return false;
            return true;
        }
    }
}
