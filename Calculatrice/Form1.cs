using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class 
       Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CLICK_NUMBER(object sender, EventArgs e)
        {
            Button btnNumber = sender as Button;
            string strNumber = btnNumber.Name;
        }

        private void CLICK_OPERATION(object sender, EventArgs e)
        {
            Button btnOperation = sender as Button;
            string strNuOperation = btnOperation.Name;
        }
    }
}
