using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07Collections.Classes
{
    public class Card
    {
        public int NumberValue { get; set; }
        public string Suite { get; set; }

        public Card(int numberValue, string suite)
        {
            NumberValue = numberValue;
            Suite = suite;
        }
    }
}
