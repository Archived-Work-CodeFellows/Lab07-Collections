using System;
using Lab07Collections.Classes;

namespace Lab07Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck<Card> myDeck = new Deck<Card>
            {
                new Card(1, Card.Suite.Hearts),
                new Card(7, Card.Suite.Club),
                new Card(1, Card.Suite.Spade),
                new Card(8, Card.Suite.Hearts),
                new Card(1, Card.Suite.Diamond),
                new Card(10, Card.Suite.Hearts),
                new Card(1, Card.Suite.Spade),
                new Card(8, Card.Suite.Hearts),
                new Card(1, Card.Suite.Diamond),
                new Card(10, Card.Suite.Hearts),
                new Card(11, Card.Suite.Club),
                new Card(10, Card.Suite.Club),
                new Card(1, Card.Suite.Spade),
                new Card(4, Card.Suite.Hearts),
                new Card(6, Card.Suite.Spade)
            };

            DeckFunctionality(myDeck);
            AddSomeCards(myDeck);
            RemoveSomeCards(myDeck);
            Deal(myDeck);
        }
        static void DeckFunctionality(Deck<Card> myDeck)
        {
            Console.WriteLine($"{myDeck.GetLength()} Set Length of Collection");
            Console.WriteLine("---");
            Console.WriteLine($"{myDeck.Length()} Deck slots in use");
            Console.WriteLine("---");
            foreach (Card card in myDeck)
            {
                Console.WriteLine($"{card.CardSuite} {card.NumberValue}");
            }
            Console.ReadLine();
        }
        static void AddSomeCards(Deck<Card> myDeck)
        {
            Console.Clear();
            Console.WriteLine("Adding cards...");
            Console.WriteLine("---");
            myDeck.Add(new Card(12, Card.Suite.Hearts));
            myDeck.Add(new Card(4, Card.Suite.Diamond));
            myDeck.Add(new Card(5, Card.Suite.Spade));
            myDeck.Add(new Card(12, Card.Suite.Club));
            myDeck.Add(new Card(1, Card.Suite.Diamond));
            myDeck.Add(new Card(11, Card.Suite.Club));
            Console.WriteLine($"{myDeck.GetLength()} Set Length of Collection");
            Console.WriteLine("---");
            Console.WriteLine($"{myDeck.Length()} Deck slots in use");
            Console.WriteLine("---");
            foreach (Card card in myDeck)
            {
                Console.WriteLine($"{card.CardSuite} {card.NumberValue}");
            }
            Console.ReadLine();
        }
        static void RemoveSomeCards(Deck<Card> myDeck)
        {
            Console.Clear();
            Console.WriteLine("Now to remove some...");
            Console.WriteLine("---");
            myDeck.Remove(4);
            myDeck.Remove(4);
            myDeck.Remove(7);
            myDeck.Remove(10);
            myDeck.Remove(12);
            Console.WriteLine($"{myDeck.GetLength()} Set Length of Collection");
            Console.WriteLine("---");
            Console.WriteLine($"{myDeck.Length()} Deck slots in use");
            Console.WriteLine("---");
            foreach (Card card in myDeck)
            {
                Console.WriteLine($"{card.CardSuite} {card.NumberValue}");
            }
            Console.ReadLine();
        }
        static void Deal(Deck<Card> myDeck)
        {
            Console.Clear();
            Console.Clear();
            Console.WriteLine("Time to shuffle!");
            Console.WriteLine("---");
            myDeck.Shuffle();
            foreach (Card card in myDeck)
            {
                Console.WriteLine($"{card.CardSuite} {card.NumberValue}");
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("One more time");
            Console.WriteLine("---");
            myDeck.Shuffle();
            foreach (Card card in myDeck)
            {
                Console.WriteLine($"{card.CardSuite} {card.NumberValue}");
            }
        }
    }
}
