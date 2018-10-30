using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace poker
{
    public class Deck
    {
        #region Private Members
        private string[] _suits = { "H", "C", "D", "S" };
        private int[] _values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        private Queue<Card> _DeckOfCards;
        private List<Card> _cardList;
        #endregion

        #region Public Properties

        #endregion

        #region  Private Methods 
        private void CreateDeck()
        {
            foreach(string s in _suits)
            {
                foreach(int v in _values)
                {
                    Bitmap bmp = new Bitmap("images/" + s + v + ".gif");
                    Card card = new Card();
                    card.FrontImage = bmp;

                    bmp = new Bitmap("images/b1fv.gif");
                    card.BackImage = bmp;

                    card.Box.Width = bmp.Width;
                    card.Box.Height = bmp.Height;

                    card.Box.Image = card.BackImage;
                    card.Suit = s;
                    card.Value = v;
                    _cardList.Add(card);
                }
            }
        }

        private void Shuffle()
        {
            Random rng = new Random();

            for(int j=1; j<5;j++)
                for(int i = 0; i <_cardList.Count ;i++)
                {
                    int num = rng.Next (0,  _cardList.Count);
                    if (_cardList[num].Value > _cardList[i].Value)
                    {
                        //SWAP EM
                        Card temp = _cardList[num];
                        _cardList[num] = _cardList[i];
                        _cardList[i] = temp;
                    }
                }
        }

        private void QueueDeck()
        {
            foreach(Card c in _cardList)
            {
                _DeckOfCards.Enqueue(c);
            }
        }
        #endregion

        #region  Public Methods 
        public Card Deal()
        {
            Card c = _DeckOfCards.Dequeue();
            return c;
        }
        #endregion

        #region  Public Events 

        #endregion

        #region  Public Event Handlers 

        #endregion

        #region Construction 
        public Deck()
        {
            _DeckOfCards = new Queue<Card>();
            _cardList = new List<Card>();
            CreateDeck();
            Shuffle();
            QueueDeck();
        }
        #endregion

    }
}
