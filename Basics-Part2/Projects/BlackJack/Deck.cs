using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace
{
    /// <summary>
    /// Initializes 52 standard deck of cards
    /// </summary>
    public class Deck
    {
        private static readonly string[] _cardSuits = new string[] { "Spades", "Hearts", "Diamonds", "Clubs" };
        private static readonly string[] _cardValues = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };


        public Deck() /// contructor?
        {
            Cards = new List<Card>();
            GenerateDeck();
        }

        private void GenerateDeck()
        {
            foreach (var cardType in _cardSuits)
            {
                foreach (var cardValue in _cardValues)
                {
                    Card card = new Card
                    {
                        Suit = cardType,
                        Number = cardValue,
                        Color = cardType == "Spades" || cardType == "Clubs" ? "Black" : "Red"
                    };

                    //Equivalent syntax to above
                    //Card card = new Card();
                    //card.Suit = cardType;
                    //card.Number = cardValue;
                    //card.Color = color;

                    bool canParse = int.TryParse(cardValue, out int result);

                    if (canParse) card.Value = result;
                    else
                    {
                        if (cardValue == "Ace") card.Value = 1;
                        else card.Value = 10;
                    }

                    Cards.Add(card);
                }
            }
        }

        private List<Card> Cards { get; set; }

        public int Count => Cards.Count;

        //public int Count { get { return Cards.Count; }} <-- equivalen to above line

        public Card DealTopCard()
        {
            Card topCard = Cards[0];
            Cards.RemoveAt(0);
            return topCard;
        }

        public void Shuffle()
        {
            Random rand = new Random();

            for (int i = 0; i < Cards.Count; i++)
            {
                int randomNum = rand.Next(0, 52);

                var temp = Cards[i];
                Cards[i] = Cards[randomNum];
                Cards[randomNum] = temp;
            }
        }
    }
}
