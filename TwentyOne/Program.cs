using System;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {
        static void Main()
        {
            Deck deck = new Deck();
            foreach (var card in deck.Cards)
            {
                Console.WriteLine($"{card.Face} of {card.Suit}");
            }

            Console.WriteLine($"Card Count: {deck.Cards.Count}");
            Console.ReadLine();
        }
    }
}
