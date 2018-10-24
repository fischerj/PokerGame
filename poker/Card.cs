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
        //private string[] _suits = { "H", "C", "D", "S" };
        //private int[] _values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
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
        #endregion

        #region  Private Methods 

        #endregion

        #region  Public Methods 

        #endregion

        #region  Public Events 

        #endregion

        #region  Public Event Handlers 

        #endregion

        #region Construction 

        #endregion
    }
}
