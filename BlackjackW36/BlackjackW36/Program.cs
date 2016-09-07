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

        class Deck
        {
            List<Card> deck = new List<Card>();
            int suits = 4;
            int minCardNumber = 1;
            int maxCardNumber = 13;

            public Deck()
            {

            }
            public void AddCardsToDeck()
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
        }

        static void Main(string[] args)
        {
        }
    }
}
