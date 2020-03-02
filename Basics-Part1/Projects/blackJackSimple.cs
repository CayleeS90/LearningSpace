using System;
using System.Collections.Generic;
using System.Text;

class BlackJackSimple
{
    public void Run()
    {
        Console.WriteLine("Welcome to BlackJack!");
        bool isGameOn = true;
        while (isGameOn)
        {
            //set score to 0 
            int userScore = 0;
            int compScore = 0;
            //deal cards 2 cards to user and computer, add up points of cards
            List<string> deck = GenerateDeck();
            int temp = DealCard(deck, true, "user");
            userScore += temp;

            int temp2 = DealCard(deck, true, "user");
            userScore += temp2;

            int temp3 = DealCard(deck, false, "computer");
            compScore += temp3;

            int temp4 = DealCard(deck, true, "computer");
            compScore += temp4;

            //ask if user wants to hit
            Console.WriteLine("Would you like to hit? (Y/N)");
            //take user input Y or N
            string userHit = Console.ReadLine().ToUpper();

            bool hit = false;
                
            if (userHit == "Y") hit = true;
            else hit = false;
            
            while (hit == true)
            {
                int temp5 = DealCard(deck, true, "user");
                userScore += temp5;
                if (userScore > 21)
                {
                    Console.WriteLine("Computer wins");
                    break;
                }
                Console.WriteLine("Hit again?");
                //to do: console.ReadLine take Y or N from player
                userHit = Console.ReadLine().ToUpper();
                if (userHit != "Y") hit = false;
            }
            //add up points of cards
            if (userScore > compScore)
            {
                Console.WriteLine($"User score is {userScore} User wins!");
            }
            else
            {
                Console.WriteLine($"Computer score is {compScore}. Computer wins!");
            }
            //to do: console.ReadLine take Y or N from player
            isGameOn = false;
        }
    }
    public static List<string> GenerateDeck()
    {
        List<string> deck = new List<string>();
        string[] cardTypes = new string[] { "Spades", "hearts", "Diamonds", "Clubs" };
        string[] cardValues = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        foreach (var cardType in cardTypes)
        {
            foreach (var cardValue in cardValues)
            {
                string card = cardValue + " of " + cardType;
                deck.Add(card);
            }
        }
        return deck;
    }
    public static int DealCard(List<string> deck, bool displayCard, string player)
    {
        Random rnd = new Random();
        int cardIndex = rnd.Next(0, deck.Count);
        string card = deck[cardIndex];
        if (displayCard == true)
        {
            Console.WriteLine($"{player} card is {card}");
        }
        var cardValue = CardValueToScore(card);
        deck.RemoveAt(cardIndex);
        return cardValue;
    }

    private static int CardValueToScore(string card)
    {
        if (card.Contains("2"))
        {
            return 2;
        }
        if (card.Contains("3"))
        {
            return 3;
        }
        if (card.Contains("4"))
        {
            return 4;
        }
        if (card.Contains("5"))
        {
            return 5;
        }
        if (card.Contains("6"))
        {
            return 6;
        }
        if (card.Contains("7"))
        {
            return 7;
        }
        if (card.Contains("8"))
        {
            return 8;
        }
        if (card.Contains("9"))
        {
            return 9;
        }
        if (card.Contains("10") || card.Contains("Jack") || card.Contains("Queen") || card.Contains("King"))
        {
            return 10;
        }

        if (card.Contains("Ace"))
        {
            return 1;
        }
        return 0;
    }
}

