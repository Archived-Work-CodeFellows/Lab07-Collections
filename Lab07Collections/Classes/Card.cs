using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07Collections.Classes
{
    public class Card
    {
        public int NumberValue { get; set; }
        public Suite CardSuite { get; set; }

        public Card(int numberValue, Suite suite)
        {
            NumberValue = numberValue;
            CardSuite = suite;
        }

        public enum Suite
        {
            Hearts,
            Spade,
            Diamond,
            Club
        }
    }
}
