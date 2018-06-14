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

            myDeck.Add(new Card(7, "A"));
            myDeck.Add(new Card(10, "B"));
            myDeck.Add(new Card(1, "C"));
            myDeck.Add(new Card(11, "D"));
            myDeck.Add(new Card(7, "E"));
            myDeck.Add(new Card(2, "F"));

            Console.WriteLine($"{myDeck.GetLength()} Set Length of Collection");
            Console.WriteLine("---");

            Console.WriteLine($"{myDeck.Length()} Deck slots in use");
            Console.WriteLine("---");

            foreach (Card card in myDeck)
            {
                Console.WriteLine($"{card.Suite} {card.NumberValue}");
            }

            //myDeck.Shuffle();
            //Console.WriteLine("---");
            //foreach (Card card in myDeck)
            //{
            //    Console.WriteLine($"{card.Suite} {card.NumberValue}");
            //}

            myDeck.Remove(3);
            Console.WriteLine("---");
            foreach (Card card in myDeck)
            {
                Console.WriteLine($"{card.Suite} {card.NumberValue}");
            }
            Console.WriteLine("---");
            Console.WriteLine($"{myDeck.Length()} Deck slots in use");
            

            myDeck.Add(new Card(56, "G"));
            Console.WriteLine("---");
            foreach (Card card in myDeck)
            {
                Console.WriteLine($"{card.Suite} {card.NumberValue}");
            }
        }
    }
}
