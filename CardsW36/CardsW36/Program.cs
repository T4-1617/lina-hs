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
                int CardValues = 13;

                Cards.Clear();

                // Set to default values
                for (int color = 0; color < CardColors; color++)
                {
                    for (int value = 0; value < CardValues; value++)
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

        static Deck deck = new Deck();

        static void Main(string[] args)
        {
        }
    }
}
