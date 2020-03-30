using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace
{
    class BlackJackSimple2
    {
        /// <summary> 
        /// initiate game
        /// create deck of cards 
        /// deal 2 random cards to user and computer
        /// show both user cards and only one comp card
        /// ask if user would like to hit for new card
        /// check score, winner is closest to 21 without going over
        /// </summary> 
        public void Run()
        {
            Console.WriteLine("Welcome to Blackjack!");

            var isGameOn = true;
            while (isGameOn)
            {
                var userScore = 0;
                var compScore = 0;
                var deck = GenerateDeck();

                userScore += DealCard(deck, true, "User");
                userScore += DealCard(deck, true, "User");
                compScore += DealCard(deck, false, "Computer");
                compScore += DealCard(deck, true, "Computer");

                Console.WriteLine("Would you like to hit?");
                var hitInput = Console.ReadLine().ToUpper();
                var hit = true;

                if (hitInput != "Y") hit = false;
                while (hit)
                {
                    userScore += DealCard(deck, true, "User");

                    if (userScore > 21) 
                    {
                        Console.WriteLine($"Your score is {userScore}, you lose!");
                        break;
                    }

                    Console.WriteLine("Would you like to hit again?");
                    hitInput = Console.ReadLine().ToUpper();

                    if (hitInput != "Y") hit = false;
                }

                if (userScore > compScore && userScore > 21) Console.WriteLine($"User score is {userScore}, you win!");
                else Console.WriteLine($"Computer score is {compScore}, you lose!");

                isGameOn = false;
            }
        }
        /// <summary>
        /// hardcode card values
        /// hardcode card types
        /// loop through the string arrays to combine types and values
        /// make the card and add to deck
        /// </summary>
        /// <returns></returns>
        public List<string> GenerateDeck()
        {
            var deck = new List<string>();
            var cardTypes = new string[] { "Hearts", "Clubs", "Spades", "Diamonds", };
            var cardValues = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            foreach (var cardType in cardTypes)
            {
                foreach (var cardValue in cardValues)
                {
                    var card = cardValue + " of " + cardType;
                    deck.Add(card);
                }
            }

            return deck;
        }

        /// <summary>
        /// generate random number for deck index
        /// convert card to points 
        /// remove card from deck
        /// only display user cards and one computer card
        /// </summary>
        /// <returns></returns>
        public int DealCard(List<string> deck, bool displayCard, string player)
        {
            Random rnd = new Random();
            var cardIndex = rnd.Next(0, deck.Count);
            var card = deck[cardIndex];
            deck.RemoveAt(cardIndex);
            if (displayCard) Console.WriteLine($"{player} card is {card}");
            var cardScore = CardsToPoints(card);

            return cardScore;
        }

        public int CardsToPoints(string card)
        {
            if (card.Contains("2")) return 2;
            if (card.Contains("3")) return 3;
            if (card.Contains("4")) return 4;
            if (card.Contains("5")) return 5;
            if (card.Contains("6")) return 6;
            if (card.Contains("7")) return 7;
            if (card.Contains("8")) return 8;
            if (card.Contains("9")) return 9;
            if (card.Contains("10") || card.Contains("Jack") || card.Contains("queen") || card.Contains("King")) return 10;
            if (card.Contains("Ace")) return 1;

            return 0;
        }

       
    }
}
