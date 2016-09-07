using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackW36
{
    class Program
    {
        class Blackjack
        {
            public List<Card> deck = new List<Card>();
            int suits = 4;
            int minCardNumber = 1;
            int maxCardNumber = 13;

            public Blackjack()
            {

            }
            void AddCardsToDeck()
            {
                for (int suit = 0; suit < suits; suit++)
                {
                    for (int number = minCardNumber; number <= maxCardNumber; number++)
                    {
                        deck.Add(new Card(suit, number));
                    }
                }
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
