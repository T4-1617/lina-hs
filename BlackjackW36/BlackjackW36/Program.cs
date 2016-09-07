using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackW36
{
    class Program
    {
        static Random RNG = new Random();

        class Blackjack
        {
            Deck deck = new Deck();
            int playerPoints;
            int cardSetsInDeck = 2;

            public Blackjack()
            {
            }

            void PlayGame()
            {
                // Play until no cards remain
                while (deck.GetNumCardsInDeck() > 0)
                {
                    Console.WriteLine("Write \"Y\" to be hit with a card. \"N\" to stand and start a new round.");
                    string command = Console.ReadLine();
                    switch (command)
                    {
                        case "Y":
                            Hit();
                            Console.WriteLine("Points: {0}", playerPoints);
                            if (CheckWinCondition())
                            {
                                Console.WriteLine("You won!");
                                StopGame();
                            }
                            else if (CheckLooseCondition())
                            {
                                Console.WriteLine("Your points exceeded 21. You lost!");
                                NewRound();
                            }
                            break;
                        case "N":
                            Stand();
                            NewRound();
                            break;
                        default:
                            break;
                    }
                }

                Console.WriteLine("No cards remaining; game is over.");
            }
            void StopGame()
            {
                deck.ClearDeck();
            }
            public void NewGame()
            {
                // Set up the deck
                deck.ClearDeck();
                for (int set = 0; set < cardSetsInDeck; set++)
                {
                    deck.AddCardSetToDeck();
                }

                // Set up the round
                NewRound();

                // Play
                PlayGame();
            }
            void NewRound()
            {
                playerPoints = 0;
            }
            void Hit()
            {
                Card card = deck.DrawRandomCard();
                playerPoints += card.number;

                Console.WriteLine("You were hit by the {0}.", card.GetCardName());
            }
            void Stand()
            {
                Console.WriteLine("You finished with {0} points.", playerPoints);
            }
            bool CheckWinCondition()
            {
                switch (playerPoints)
                {
                    case 21:
                        return true;
                    default:
                        return false;
                }
            }
            bool CheckLooseCondition()
            {
                if (playerPoints > 21)
                {
                    return true;
                }

                return false;
            }

        }
        class Deck
        {
            List<Card> deck = new List<Card>();
            int suits = 4;
            int minCardNumber = 1;
            int maxCardNumber = 13;

            public Deck()
            {

            }
            public void AddCardSetToDeck()
            {
                // For each suit create one card for each number
                for (int suit = 0; suit < suits; suit++)
                {
                    for (int number = minCardNumber; number <= maxCardNumber; number++)
                    {
                        deck.Add(new Card(suit, number));
                    }
                }
            }
            public void ClearDeck()
            {
                deck.Clear();
            }
            public Card DrawRandomCard()
            {
                // Take a random card from the deck
                int cardPos = RNG.Next(0, deck.Count);
                Card card = deck[cardPos];
                deck.RemoveAt(cardPos);
                return card;
            }
            public int GetNumCardsInDeck()
            {
                return deck.Count();
            }
        }
        class Card
        {
            public int suit;
            public int number;

            public Card(int cardSuit, int cardNumber)
            {
                suit = cardSuit;
                number = cardNumber;
            }
            string GetSuitName()
            {
                // Get the name of the suit based on the number of the card suit
                switch (suit)
                {
                    case 0:
                        return "Hearts";
                    case 1:
                        return "Diamonds";
                    case 2:
                        return "Spades";
                    case 3:
                        return "Clubs";
                    default:
                        return string.Empty;
                }
            }
            string GetNumberName()
            {
                // Get the name of the number on the card
                switch (number)
                {
                    case 1:
                        return "Ace";
                    case 11:
                        return "Jack";
                    case 12:
                        return "Queen";
                    case 13:
                        return "King";
                    default:
                        return number.ToString();
                }
            }
            public string GetCardName()
            {
                return string.Format("{0} of {1}", GetNumberName(), GetSuitName());
            }
        }

        static void Main(string[] args)
        {
            Blackjack Game = new Blackjack();

            Game.NewGame();
        }
    }
}
