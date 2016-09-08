using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackW36
{
    class Program
    {
        // Random Number Generator
        static Random RNG = new Random();

        /// <summary>
        /// Class with built-in functions able to simulate the card game Blackjack
        /// </summary>
        public class BlackjackSimulator
        {
            // Game variables
            Deck deck = new Deck();
            int cardSets = 4;

            // Scores & Points
            int score = 0;
            int playerPoints = 0;
            int dealerPoints = 0;

            /// <summary>
            /// Initialize and instance of the BlackjackSimulator class with built-in functions able to simulate the card game Blackjack
            /// </summary>
            public BlackjackSimulator() { }

            // Game functions
            /// <summary>
            /// Initialize the deck and set game variables to the default values
            /// </summary>
            void NewGame()
            {
                //
                score = 0;

                //
                deck.cards.Clear();
                deck.AddCardSetsToDeck(cardSets);
            }
            /// <summary>
            /// Plays the Blackjack simulation
            /// </summary>
            public void Play()
            {
                while (true)
                {
                    NewGame();

                    while (deck.cards.Count() > 15)
                    {
                        Console.WriteLine("Another round? (y/n)\n Cards remaining: {0}", deck.cards.Count());
                        bool read = ReadYesOrNo();

                        if (read)
                        {
                            PlayRound();
                        }
                        else
                        {
                            return;
                        }
                    }

                }
            }

            // Round functions
            /// <summary>
            /// Plays one round according to Blackjack rules
            /// </summary>
            void PlayRound()
            {
                // Read init
                bool hit = true;

                // Points init
                playerPoints = 0;
                dealerPoints = 0;

                // Board init
                Console.Clear();
                Hit("Dealer");
                Display();

                while (hit && playerPoints < 21)
                {
                    Console.WriteLine("Hit (y) or Stand (n)?");
                    hit = ReadYesOrNo();
                    if (hit)
                    {
                        Console.Clear();
                        Hit("Player");
                        Display();
                    }
                }

                if (!hit)
                {
                    Console.Clear();
                    while (dealerPoints < playerPoints)
                    {
                        Hit("Dealer");
                    }
                    Display();
                }

                SetRoundWinner();

            }
            /// <summary>
            /// Determines the winner of the round and changes the score accordingly
            /// </summary>
            void SetRoundWinner()
            {
                // Decide winner
                string winner;

                if (playerPoints > 21)
                {
                    winner = "Dealer";
                    score--;
                }
                else if (playerPoints == 21)
                {
                    winner = "Player";
                    score += 3;
                }
                else if (playerPoints > dealerPoints)
                {
                    winner = "Player";
                    score++;
                }
                else if (dealerPoints > 21)
                {
                    winner = "Player";
                    score++;
                }
                else
                {
                    winner = "Dealer";
                    score--;
                }

                Console.WriteLine("{0} won!", winner);
                Console.ReadKey();
                Console.Clear();
            }

            /// <summary>
            /// Give the target a card and add it to their round points
            /// </summary>
            /// <param name="target">A string variable representing the target of the hit, can either be Player or Dealer</param>
            void Hit(string target)
            {
                Card card = deck.DrawRandomCard();
                Console.WriteLine("{0} drew the {1}", target, card.GetCardName());

                switch (target)
                {
                    case "Player":
                        playerPoints += GetCardValue(card.number, playerPoints);
                        break;
                    case "Dealer":
                        dealerPoints += GetCardValue(card.number, dealerPoints);
                        break;
                    default:
                        break;
                }

            }

            /// <summary>
            /// Displays the game score and the round points of both the player and the dealer
            /// </summary>
            void Display()
            {
                Console.WriteLine("\nPlayer score: {0}\nPlayer points: {1}\nDealer points: {2}", score, playerPoints, dealerPoints);
            }

            /// <summary>
            /// Get the value of a card according to the Blackjack rules
            /// </summary>
            /// <param name="number">An integer value representing the number of the card</param>
            /// <param name="points">An integer value representing the number of round points of the target player</param>
            /// <returns></returns>
            int GetCardValue(int number, int points)
            {
                if (number == 1 && points <= 10)
                {
                    return 11;
                }
                else if (number > 10)
                {
                    return 10;
                }

                return number;
            }
        }

        /// <summary>
        /// Simulates the functionalities of a real-life card deck, holds a list of cards and relevant deck functions
        /// </summary>
        public class Deck
        {
            /* Note: The list is NOT public, meaning only the class has access to the functions that may be useful
             * to the program, therefore have created functions which return or change the list privately.
             * This is, however, largely ineffective and am contemplating simply making the deck public. */
            public List<Card> cards = new List<Card>();
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
            public void AddCardSetsToDeck(int sets)
            {
                // For each suit create one card for each number
                for (int suit = 0; suit < suits; suit++)
                {
                    for (int number = minCardNumber; number <= maxCardNumber; number++)
                    {
                        for (int set = 0; set < sets; set++)
                        {
                            cards.Add(new Card(suit, number));
                        }
                    }
                }
            }

            /*
            /// <summary>
            /// Removes all cards from the deck
            /// </summary>
            public void ClearDeck()
            {
                // Clears the cards list
                cards.Clear();
            }
            /// <summary>
            /// Get the number of cards in the deck
            /// </summary>
            /// <returns>Returns an integer containing the number of cards in the deck</returns>
            public int GetNumCards()
            {
                return cards.Count();
            }
            /// <summary>
            /// Adds the card to the deck
            /// </summary>
            /// <param name="card">The card to be added</param>
            public void AddCard(Card card)
            {
                cards.Add(card);
            }
            */

            /// <summary>
            /// Take a card at a random position in the deck and remove it from the deck
            /// </summary>
            /// <returns>
            /// Returns the drawn card.
            /// </returns>
            public Card DrawRandomCard()
            {
                // Through this function the deck is able to simulate a 'shuffled' deck by always taking a random card from the list
                int cardPos = RNG.Next(0, cards.Count);
                Card card = cards[cardPos];
                cards.RemoveAt(cardPos);
                return card;
            }
        }

        /// <summary>
        /// Represents a playing card
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
            public Card(int suit, int number)
            {
                this.suit = suit;
                this.number = number;
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
            BlackjackSimulator blackjack = new BlackjackSimulator();

            blackjack.Play();
        }
        static bool ReadYesOrNo()
        {
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.KeyChar)
                {
                    case 'y':
                        return true;
                    case 'n':
                        return false;
                    default:
                        break;
                }
            }
        }
    }
}
