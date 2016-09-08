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
         *      UPCOMMING CHANGES, AND PERSONAL PROJECT:
         *          - Change the deck's card list to public and remove unneccesary functions
         *              - Good for better access to the decks for card games that require more control of decks/hands/boards etc
         *          - Create a score system which counts the worth of a 'hand' using taking a list of cards and a maximum number of cards used as parameters.
         *          - Return the score in the format ScoreType (flush/straight/two pairs) and TypeScore (number of highest card, etc)
         * 
         */

        // Random Number Generator
        static Random RNG = new Random();

        /// <summary>
        /// Simulates a the card game Blackjack with similar rules
        /// </summary>
        public class Blackjack
        {
            // Game variables
            Deck deck = new Deck();
            int cardSets = 4;

            // Scores & Points
            int score = 0;
            int playerPoints = 0;
            int dealerPoints = 0;

            public Blackjack() {}

            void Hit() { }
            void Stand() { }

            // Game functions
            void NewGame()
            {
                //
                score = 0;

                //
                deck.cards.Clear();
                deck.AddCardSetsToDeck(cardSets);
            }
            public void Play()
            {
                bool read = true;

                while (read)
                {
                    NewGame();

                    while (deck.cards.Count() > 15)
                    {
                        Console.WriteLine("Another round? (y/n)\n Cards remaining: {0}", deck.cards.Count());
                        read = ReadYesOrNo();

                        if (read)
                        {
                            PlayRound();
                        }
                        else
                        {
                            return;
                        }
                    }

                    Console.WriteLine("Almost out of cards. Do you want to play a new game?");
                    read = ReadYesOrNo();
                }
            }

            // Round functions
            void PlayRound()
            {
                bool read = true;

                // Points
                playerPoints = 0;
                dealerPoints = 0;


                Console.Clear();
                Hit("Dealer");
                Display();

                while (read && playerPoints < 21)
                {
                    Console.WriteLine("Hit (y) or Stand (n)?");
                    read = ReadYesOrNo();
                    if (read)
                    {
                        Console.Clear();
                        Hit("Player");
                        Display();
                    }
                }

                if (!read)
                {
                    Console.Clear();
                    while (dealerPoints < playerPoints)
                    {
                        Hit("Dealer");
                    }
                    Display();
                }

                FinishRound();

            }
            void FinishRound()
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

            // Hit
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

            // Display
            void Display()
            {
                Console.WriteLine("\nPlayer score: {0}\nPlayer points: {1}\nDealer points: {2}", score, playerPoints, dealerPoints);
            }

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
            Blackjack blackjack = new Blackjack();

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
