using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace
{
    class BlackJackSimple2
    {
        public void Run()
        {
            //Initiate game and set score to 0
            Console.WriteLine("Welcome to Blackjack!");
            var isGameOn = true;
            while (isGameOn)
            {
                var userScore = 0;
                var compScore = 0;
                //Deal two cards to user and computer
                //Before the computer can deal cards a deck must be made
                //Show user cards and only one of the computers cards
                //Set points for cards
                var deck = GenerateDeck();
                userScore += DealCard(deck, true, "user");

                userScore += DealCard(deck, true, "user");

                compScore += DealCard(deck, false, "computer");

                compScore += DealCard(deck, true, "computer");

                //After two cards are dealt user can choose to HIT or not
                Console.WriteLine("Would you like to hit? (Y/N)");
                var userHit = Console.ReadLine().ToUpper();
                var hit = false;
                if (userHit == "Y") hit = true;
                while (hit)
                {
                    userScore += DealCard(deck, true, "user");

                    if (userScore < 21)
                    {
                        Console.WriteLine("Computer wins!");
                        break;
                    }
                    Console.WriteLine("Hit again?");
                    if (userHit != "Y") hit = false;
                }
                //Calculate score and declare winner for score closest to and under 21
            }
        }
        public List<string> GenerateDeck()
        {
            var deck = new List<string>();
            var cardTypes = new string[] { "Spades", "hearts", "Diamonds", "Clubs" };
            var cardValues = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            foreach (var cardType in cardTypes)
            {
                foreach (var cardValue in cardValues)
                {
                    var card = cardValue + "of" + cardType;
                    deck.Add(card);
                }
            }
            return deck; 
        }
        public int DealCard(List<string> deck, bool displayCard, string player)
        {
            Random rnd = new Random();
            var cardIndex = rnd.Next(0, deck.Count);
            var card = deck[cardIndex];
            if (displayCard) Console.WriteLine($"{player} card is {card}");
            var cardValue = CardValueToScore(card);
            deck.RemoveAt(cardIndex);

            return cardValue;
        }
        public int CardValueToScore(string card)
        {
            if (card.Contains("2")) return 2;
            if (card.Contains("3")) return 3;
            if (card.Contains("4")) return 4;
            if (card.Contains("5")) return 5;
            if (card.Contains("6")) return 6;
            if (card.Contains("7")) return 7;
            if (card.Contains("8")) return 8;
            if (card.Contains("9")) return 9;
            if (card.Contains("10") || card.Contains("Jack") || card.Contains("Queen") || card.Contains("King")) return 10;
            if (card.Contains("Ace")) return 1;

            return 0;
        }
    }
}
