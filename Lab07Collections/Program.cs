using System;
using Lab07Collections.Classes;

namespace Lab07Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DeckFunctionality();
        }
        static void DeckFunctionality()
        {
            Deck<Card> myDeck = new Deck<Card>();

            Console.WriteLine($"{myDeck.GetLength()} Set Length of Collection");
            Console.WriteLine("---");

            myDeck.Add(new Card(1, "A"));
            myDeck.Add(new Card(2, "B"));
            myDeck.Add(new Card(3, "C"));
            myDeck.Add(new Card(4, "D"));
            myDeck.Add(new Card(5, "E"));
            myDeck.Add(new Card(6, "F"));
            myDeck.Add(new Card(7, "G"));
            myDeck.Add(new Card(8, "H"));
            myDeck.Add(new Card(9, "I"));
            myDeck.Add(new Card(10, "J"));
            myDeck.Add(new Card(11, "K"));

            Console.WriteLine($"{myDeck.GetLength()} Set Length of Collection");
            Console.WriteLine("---");
            Console.WriteLine($"{myDeck.Length()} Deck slots in use");
            Console.WriteLine("---");
            foreach (Card card in myDeck)
            {
                Console.WriteLine($"{card.Suite} {card.NumberValue}");
            }

            myDeck.Shuffle();
            Console.WriteLine("---");
            foreach (Card card in myDeck)
            {
                Console.WriteLine($"{card.Suite} {card.NumberValue}");
            }
        }
    }
}
