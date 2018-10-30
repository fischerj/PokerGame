using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace poker
{
    public class Card
    {
        #region Private Members

        private PictureBox _Box;
        private int _value;
        private string _suit;

        private Image _frontImage;
        private Image _backImage;
        #endregion

        #region Public Properties
        public PictureBox Box
        {
            get { return _Box; }
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public Image FrontImage
        {
            get { return _frontImage; }
            set { _frontImage = value; }
        }

        public Image BackImage
        {
            get { return _backImage; }
            set { _backImage = value; }
        }
        #endregion

        public string Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }
        #region  Private Methods 

        #endregion

        #region  Public Methods 
        public void flip()
        {
            _Box.Image = _frontImage;
        }
        #endregion

        #region  Public Events 

        #endregion

        #region  Public Event Handlers 
        private void _Box_Click(object sender, EventArgs e)
        {
            flip();
        }

        private void _Box_MouseLeave(object sender, EventArgs e)
        {
            Point locat = _Box.Location;
            locat.Y = locat.Y - 3;
            _Box.Location = locat;

        }

        private void _Box_MouseEnter(object sender, EventArgs e)
        {
            Point locat = _Box.Location;
            locat.Y = locat.Y + 3;
            _Box.Location = locat;
        }
        #endregion

        #region Construction 
        public Card()
        {
            _Box = new PictureBox();
            _Box.Click += _Box_Click;
            _Box.MouseEnter += _Box_MouseEnter;
            _Box.MouseLeave += _Box_MouseLeave;
        }




        #endregion
    }
}
