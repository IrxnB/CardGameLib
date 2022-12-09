using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardGameLib
{
    public class Card
    {
        private CardSuit _suit;
        private CardValue _value;
        private Color _color;

        public Card(CardSuit suit, CardValue value)
        {
            _suit = suit;
            _value = value;
            _color = CardMapper.SuitToColor(_suit);
        }

        public Card()
        {
            Suit = CardSuit.Hearts;
            Value = CardValue.Two;
        }

        public CardSuit Suit
        {
            get
            {
                return _suit;
            }
            set
            {
                _suit = value;
                _color = CardMapper.SuitToColor(_suit);
            }
        }
        public CardValue Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        public Color Color
        {
            get
            {
                return _color;
            }
        }

        public bool CanBeat(Card other, CardSuit trump)
        {
            return (this.Suit == other.Suit && this.Value > other.Value)
                || (this.Suit == trump && other.Suit != trump); 
        }

        public static Card GetRandomCard()
        {
            return new Card(CardUtils.GetRandomSuit(), CardUtils.GetRandomValue());
        }
    }
}