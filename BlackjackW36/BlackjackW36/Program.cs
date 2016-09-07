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

        // Random Number Generator
        static Random RNG = new Random();

        /// <summary>
        /// Holds values and functions that are able to simulate the card game Blackjack
        /// </summary>
        public class Blackjack
        {
            Deck deck = new Deck();
            int playerPoints;
            int cardSetsInDeck = 2;

            /// <summary>
            /// Initialize an instance of the Blackjack class which simulates the Blackjack card game
            /// </summary>
            public Blackjack() { }

            /// <summary>
            /// Game will play until no cards remain or a win condition has been met
            /// </summary>
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
            /// <summary>
            /// Start a new Blackjack game, recreating the deck and start playing
            /// </summary>
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
            /// <summary>
            /// Start a new Blackjack round, resetting the score to zero
            /// </summary>
            void NewRound()
            {
                // Sets the points to 0 for a new round
                playerPoints = 0;
            }

            /// <summary>
            /// Executes everything which should happen if the player chooses to hit
            /// </summary>
            void Hit()
            {
                // Receive a card if player chooses to hit
                Card card = deck.DrawRandomCard();
                playerPoints += GetCardValue(card.number);

                Console.WriteLine("You were hit by the {0}.", card.GetCardName());
            }
            /// <summary>
            /// Executes everything which should happen if the player chooses to stand
            /// </summary>
            void Stand()
            {
                // Print only if player chooses to stand
                Console.WriteLine("You finished with {0} points.", playerPoints);
            }

            /// <summary>
            /// Checks if any win condition has been met, returns true if one condition was met
            /// </summary>
            /// <returns>Returns a boolean with the result</returns>
            bool CheckWinCondition()
            {
                // Function is currently largely useless but may be worth it for future implementations of more win conditions
                switch (playerPoints)
                {
                    case 21:
                        return true;
                    default:
                        return false;
                }
            }
            /// <summary>
            /// Checks if any loose condition has been met, returns true if one condition was met
            /// </summary>
            /// <returns>Returns a boolean with the result</returns>
            bool CheckLooseCondition()
            {
                // Function is currently largely useless but may be worth it for future implementations of more loose conditions
                if (playerPoints > 21)
                {
                    return true;
                }

                return false;
            }

            /// <summary>
            /// Get the point value of a card number in the blackjack game
            /// </summary>
            /// <param name="number">The card number</param>
            /// <returns>Returns an integer containing the point value of the card</returns>
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

        /// <summary>
        /// Holds a list of cards and relevant deck functions
        /// </summary>
        public class Deck
        {
            List<Card> deck = new List<Card>();
            int suits = 4;
            int minCardNumber = 1;
            int maxCardNumber = 13;

            /// <summary>
            /// Initialize a new instance of the Deck with an empty deck
            /// </summary>
            public Deck() { }

            /// <summary>
            /// Add cards of all four suits from, and including, the number 1 to, and including, the number 13
            /// </summary>
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
            /// <summary>
            /// Removes all cards from the deck
            /// </summary>
            public void ClearDeck()
            {
                // Clears the deck list
                deck.Clear();
            }
            /// <summary>
            /// Get the number of cards in the deck
            /// </summary>
            /// <returns>Returns an integer containing the number of cards in the deck</returns>
            public int GetNumCardsInDeck()
            {
                return deck.Count();
            }

            /// <summary>
            /// Take a card at a random position in the deck and remove it from the deck
            /// </summary>
            /// <returns>
            /// Returns the drawn card.
            /// </returns>
            public Card DrawRandomCard()
            {
                int cardPos = RNG.Next(0, deck.Count);
                Card card = deck[cardPos];
                deck.RemoveAt(cardPos);
                return card;
            }
        }

        /// <summary>
        /// Holds the suit and numeric value of a card and relevant card functinos
        /// </summary>
        public class Card
        {
            public int suit;
            public int number;

            /// <summary>
            /// Initialize a new instance of the Card class with the given suit and number value
            /// </summary>
            /// <param name="cardSuit">An integer representing the suit of the card.</param>
            /// <param name="cardNumber">An integer representing the numeric value of the card.</param>
            public Card(int cardSuit, int cardNumber)
            {
                suit = cardSuit;
                number = cardNumber;
            }

            /// <summary>
            /// Get the name of the card's suit.
            /// </summary>
            /// <returns>Returns a string containing the suit name.</returns>
            string GetSuitName()
            {
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
            /// <summary>
            /// Get the name of the card's number.
            /// </summary>
            /// <returns>Returns a string containing the name of the card number.</returns>
            string GetNumberName()
            {
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
            /// <summary>
            /// Get the full name of a card based on its suit and number.
            /// </summary>
            /// <returns>Returns a string containing the card name.</returns>
            public string GetCardName()
            {
                return string.Format("{0} of {1}", GetNumberName(), GetSuitName());
            }
        }

        static void Main(string[] args)
        {
            // Create blackjack game
            Blackjack BlackjackGame = new Blackjack();

            // Start a new game
            BlackjackGame.NewGame();
        }
    }
}
