using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Card
{
    //a Card class with read-only properties for "Number" and "Suit," and a constructor that initializes these properties with the values provided as parameters.
    public string Number { get; }

    public string Suit { get; }

    public Card(string numParam, string suitParam)
    {
        Number = numParam;
        Suit = suitParam;
    }
}
