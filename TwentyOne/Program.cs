﻿using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace TwentyOne
{
    class Program
    {
        static void Main()
        {
            Deck deck = new Deck();
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3);
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine($"{card.Face} of {card.Suit}");
            }

            Console.WriteLine($"Card Count: {deck.Cards.Count}");
            Console.WriteLine($"Times shuffled: {timesShuffled}");
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();
                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;

        }
    }
}
