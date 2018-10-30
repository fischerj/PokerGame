using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poker
{
    public partial class frmPoker : Form
    {
        Deck deck;
        public frmPoker()
        {
            InitializeComponent();
            KeyDown += Form1_KeyDown;
            this.Load += FrmPoker_Load;
        }

        private void FrmPoker_Load(object sender, EventArgs e)
        {
            deck = new Deck();
            int x = 400;
            int y = 500;
            Point location = new Point(x, y);

            for (int i = 0; i < 52; i++)
            {
                //flpCards.Controls.Add(deck.Deal().Box);
                location = new Point(x, y);
                Card c = deck.Deal();
                c.Box.Location = location;
                this.Controls.Add(c.Box);

                x = x + 3;
                y = y - 3;
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt==true && e.KeyData==Keys.F4)
            {
                Application.Exit();
            }
        }
    }
}
