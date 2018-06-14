using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07Collections
{
    class Deck<T> : IEnumerable
    {
        T[] cards = new T[5];
        int counter;

        public void Add(T card)
        {
            if (counter == cards.Length)
            {
                Array.Resize(ref cards, (cards.Length * 2));
            }
            cards[counter++] = card;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < counter; i++)
            {
                yield return cards[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //Add shuffle
        //Add remove
    }
}
