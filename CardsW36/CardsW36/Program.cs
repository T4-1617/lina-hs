using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsW36
{
    class Program
    {

        static Random RNG = new Random();

        /*
         *      Card Suits:
         *      0: Heart
         *      1: Diamond
         *      2: Spade
         *      3: Club
         * 
         */


        class Deck
        {
            // Contains a list of the cards currently in play.
            public List<Card> Cards;
            public int CardsRemaining;
            public int CardsDrawn;

            public Deck()
            {
                // Set initial values
                Cards = new List<Card>();
                CardsRemaining = 52;
                CardsDrawn = 0;

                Shuffle();

            }
            public void Shuffle()
            {
                // Sets the card deck with all existing values

                // Standard deck cards
                int CardColors = 4;
                int CardValues = 14;

                Cards.Clear();

                // Set to default values
                for (int color = 0; color < CardColors; color++)
                {
                    for (int value = 1; value < CardValues; value++)
                    {
                        Cards.Add(new Card(color, value));
                    }
                }
            }
            public Card Draw()
            {
                // Draw a card from the deck

                // Choose a card
                int cardIndex = RNG.Next(0, Cards.Count());
                Card card = Cards[cardIndex];

                // Remove the card
                CardsRemaining--;
                Cards.RemoveAt(cardIndex);

                // Draw the card
                CardsDrawn++;
                return card;
            }

        }
        class Card
        {
            public int suit;
            public int value;

            public Card(int color, int number)
            {
                suit = color;
                value = number;
            }
        }


        static void Main(string[] args)
        {

            Deck deck = new Deck();
            int DrawnCardValue = 0;

            // Player draws cards until no cards remaining
            while (deck.CardsRemaining > 0)
            {

                Console.WriteLine("Press Enter for a card.");
                Console.ReadLine();

                string suit;
                string value;
                Card card = deck.Draw();

                // Get suit 'name'
                switch (card.suit)
                {
                    case 0:
                        suit = "Hearts";
                        break;
                    case 1:
                        suit = "Diamonds";
                        break;
                    case 2:
                        suit = "Spades";
                        break;
                    case 3:
                        suit = "Clubs";
                        break;
                    default:
                        suit = String.Empty;
                        break;
                }
                // Get value name if value has name
                switch (card.value)
                {
                    case 1:
                        value = "Ace";
                        break;
                    case 11:
                        value = "Jack";
                        break;
                    case 12:
                        value = "Queen";
                        break;
                    case 13:
                        value = "King";
                        break;
                    default:
                        value = card.value.ToString();
                        break;
                }

                DrawnCardValue += card.value;

                Console.WriteLine(String.Format("You drew the {0} of {1}. There are {2} cards remaining. Your total score is {3}.", value, suit, deck.CardsRemaining, DrawnCardValue));

            }

        }
    }
}
