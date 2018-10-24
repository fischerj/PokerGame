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
        public frmPoker()
        {
            InitializeComponent();
            KeyDown += Form1_KeyDown;
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
