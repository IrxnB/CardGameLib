using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameLib
{
    public static class CardUtils
    {
        private static Random random = new Random();
        public static CardSuit GetRandomSuit()
        {
            return (CardSuit)(random.NextDouble() * 4 + 1);
        }

        public static CardValue GetRandomValue()
        {
            return (CardValue)(random.NextDouble() * 13 + 2);
        }
    }
}
