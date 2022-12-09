using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameLib
{
    internal static class CardMapper
    {
        public static Color SuitToColor(CardSuit suit)
        {
            return (suit == CardSuit.Hearts || suit == CardSuit.Diamonds)
                ? Color.Red
                : Color.Black;
        }
    }
}
