using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackW36
{
    class Program
    {

        /*
         *      Possible GOLD PLATING feature(s):
         *          - Ask if player wants to continue the game after it has run
         * 
         */

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
                // Play until no cards remain or win condition has been met
                while (deck.GetNumCardsInDeck() > 0)
                {
                    Console.WriteLine("Write \"Y\" to be hit with a card. \"N\" to stand and start a new round.");
                    string command = Console.ReadLine();
                    switch (command)
                    {
                        case "Y":
                            Hit();
                            Console.WriteLine("Points: {0}", playerPoints);

                            // Check for win or loose condition after a hit
                            if (CheckWinCondition())
                            {
                                Console.WriteLine("You won!");
                                return;
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

                Console.WriteLine("No cards remaining.");
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
                // Sets the points to 0 for a new round
                playerPoints = 0;
            }

            void Hit()
            {
                // Receive a card if player chooses to hit
                Card card = deck.DrawRandomCard();
                playerPoints += GetCardValue(card.number);

                Console.WriteLine("You were hit by the {0}.", card.GetCardName());
            }
            void Stand()
            {
                // Print only if player chooses to stand
                Console.WriteLine("You finished with {0} points.", playerPoints);
            }

            bool CheckWinCondition()
            {
                // Functions returns true if player has met a win condition
                // Function is currently largely useless but may be worth it for future implementations of more win conditions
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
                // Functions returns true if player has met a loose condition
                // Function is currently largely useless but may be worth it for future implementations of more loose conditions
                if (playerPoints > 21)
                {
                    return true;
                }

                return false;
            }

            int GetCardValue(int number)
            {
                // Get the value of a card in a Blackjack game based on the number of the card
                if (number == 1)
                {
                    if (playerPoints + 11 > 21)
                    {
                        return 1;
                    }

                    return 11;
                }
                else if (number > 10 && number <= 13)
                {
                    return 10;
                }
                else
                {
                    return number;
                }
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
                // Clears the deck list
                deck.Clear();
            }
            public int GetNumCardsInDeck()
            {
                // Returns the amount of cards in the deck
                return deck.Count();
            }

            public Card DrawRandomCard()
            {
                // Take and return a random card from the deck
                // The taken card is removed from the deck
                int cardPos = RNG.Next(0, deck.Count);
                Card card = deck[cardPos];
                deck.RemoveAt(cardPos);
                return card;
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
                // Returns the name of the suit based on the number of the card suit
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
                // Returns the name of the number on the card
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
                // Returns the name of the card
                return string.Format("{0} of {1}", GetNumberName(), GetSuitName());
            }
        }

        static void Main(string[] args)
        {
            // Create blackjack game
            Blackjack Game = new Blackjack();

            // Start a new game
            Game.NewGame();
        }
    }
}
