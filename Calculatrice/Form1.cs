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
            lblEcrire.Text = "";
            lblResultat.Text = "";
        }

        private void CLICK_NUMBER(object sender, EventArgs e)
        {
            Button btnNumber = sender as Button;
            string strNumber = btnNumber.Name;
            switch (strNumber)
            {
                case "btn1": lblEcrire.Text += "1";
                    break;
                case "btn2": lblEcrire.Text += "2";
                    break;
                case "btn3": lblEcrire.Text += "3";
                    break;
                case "btn4": lblEcrire.Text += "4";
                    break;
                case "btn5": lblEcrire.Text += "5";
                    break;
                case "btn6": lblEcrire.Text += "6";
                    break;
                case "btn7": lblEcrire.Text += "7";
                    break;
                case "btn8": lblEcrire.Text += "8";
                    break;
                case "btn9": lblEcrire.Text += "9";
                    break;
                case "btn0": lblEcrire.Text += "0";
                    break;
            }
        }

        private void CLICK_OPERATION(object sender, EventArgs e)
        {
            Button btnOperation = sender as Button;
            string strOperation = btnOperation.Name;
            switch (strOperation)
            {
                case "btnPlus": lblEcrire.Text += "+";
                    break;
                case "btnMoin": lblEcrire.Text += "-";
                    break;
                case "btnDiviser": lblEcrire.Text += "/";
                    break;
                case "btnPoint": lblEcrire.Text += ".";
                    break;
                case "btnFois": lblEcrire.Text += "*";
                    break;
            }
        }
    }
}
