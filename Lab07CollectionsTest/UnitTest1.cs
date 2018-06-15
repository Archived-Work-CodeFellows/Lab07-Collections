using System;
using Xunit;
using Lab07Collections;
using Lab07Collections.Classes;

namespace Lab07CollectionsTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddCardToTheDeck()
        {
            Deck<Card> myDeck = new Deck<Card>
            {
                new Card(1, Card.Suite.Hearts),
                new Card(7, Card.Suite.Club),
                new Card(1, Card.Suite.Spade),
                new Card(8, Card.Suite.Hearts),
                new Card(1, Card.Suite.Diamond),
                new Card(10, Card.Suite.Hearts),
            };
            myDeck.Add(new Card(4, Card.Suite.Spade));

            Assert.Equal(7, myDeck.Length());
        }
        [Fact]
        public void RemoveCardFromDeck()
        {
            Deck<Card> myDeck = new Deck<Card>
            {
                new Card(1, Card.Suite.Hearts),
                new Card(7, Card.Suite.Club),
                new Card(1, Card.Suite.Spade),
                new Card(8, Card.Suite.Hearts),
                new Card(1, Card.Suite.Diamond),
                new Card(10, Card.Suite.Hearts),
            };
            Assert.True(myDeck.Remove(4));
        }
        [Fact]
        public void CantRemoveCardFromDeck()
        {
            Deck<Card> myDeck = new Deck<Card>
            {
                new Card(1, Card.Suite.Hearts),
                new Card(7, Card.Suite.Club),
                new Card(1, Card.Suite.Spade),
                new Card(8, Card.Suite.Hearts),
                new Card(1, Card.Suite.Diamond),
                new Card(10, Card.Suite.Hearts),
            };
            Assert.False(myDeck.Remove(20));
        }
        [Fact]
        public void ShuffleDeckOfCards()
        {
            Deck<Card> myDeck = new Deck<Card>
            {
                new Card(1, Card.Suite.Hearts),
                new Card(2, Card.Suite.Club),
                new Card(3, Card.Suite.Spade),
                new Card(4, Card.Suite.Hearts),
                new Card(5, Card.Suite.Diamond),
                new Card(6, Card.Suite.Diamond),
                new Card(7, Card.Suite.Diamond),
                new Card(8, Card.Suite.Diamond),
                new Card(10, Card.Suite.Hearts),
            };

            Card preShuffle = myDeck.Find(4);
            myDeck.Shuffle();
            Card afterShuffle = myDeck.Find(4);

            Assert.NotEqual(preShuffle.NumberValue, afterShuffle.NumberValue);
        }
        [Fact]
        public void CheckCardEnumAndNumberValue()
        {
            Card test = new Card(1, Card.Suite.Hearts);

            Assert.NotEqual(Card.Suite.Club, test.CardSuite);
            Assert.NotEqual(Card.Suite.Diamond, test.CardSuite);
            Assert.NotEqual(Card.Suite.Spade, test.CardSuite);
        }
    }
}
