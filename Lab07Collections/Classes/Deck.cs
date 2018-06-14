using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07Collections
{
    public class Deck<T> : IEnumerable
    {
        T[] cards = new T[5];
        int counter;
        /// <summary>
        /// Method allows for us to add a card to the front
        /// of our collection
        /// </summary>
        /// <param name="card">Card object to be added</param>
        public void Add(T card)
        {
            if (counter == cards.Length)
            {
                Array.Resize(ref cards, (cards.Length * 2));
            }
            cards[counter++] = card;
        }
        /// <summary>
        /// Takes a give index and removes the card at that specific
        /// index. Then collapses the collection and resets counter
        /// </summary>
        /// <param name="index">Index to be removed</param>
        public void Remove(int index)
        {
            cards[index] = default;
            for (int i = 0; i < counter; i++)
            {
                if (i >= index) cards[i] = cards[i + 1];
            }
            if (counter < (cards.Length / 2)) Array.Resize(ref cards, (cards.Length / 2));
            counter--;
        }
        /// <summary>
        /// Method used to shuffle the deck. 
        /// </summary>
        public void Shuffle()
        {
            int i = 0;
            T[] shuffler = new T[cards.Length];
            int[] checker = new int[counter];
            Random random = new Random();

            while (i < counter)
            {
                int ranNum = random.Next(0, counter);
                checker[i] = ranNum;
                shuffler[i] = cards[checker[i]];
                i++;
                while (Array.IndexOf(checker, ranNum) != -1)
                {
                    ranNum = random.Next(0, counter);
                }
            }
            cards = shuffler;
        }
        /// <summary>
        /// Method used to show the amount of 
        /// allocation for the Collection
        /// </summary>
        /// <returns>The total length</returns>
        public int GetLength()
        {
            return cards.Length;
        }
        /// <summary>
        /// Method used to show only the indexes
        /// that are currently in use
        /// </summary>
        /// <returns>Length of how many in use</returns>
        public int Length()
        {
            return counter;
        }
        /// <summary>
        /// Method allows us to utilize a foreach
        /// loop
        /// </summary>
        /// <returns>A value if the index is assigned</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < counter; i++)
            {
                yield return cards[i];
            }
        }
        //Magic
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //Add shuffle
        //Add remove
    }
}
