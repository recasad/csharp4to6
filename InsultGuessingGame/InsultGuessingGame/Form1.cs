using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsultGuessingGame
{
    public partial class Form1 : Form
    {
        int intGuessedNumber;
        int intNumber = 13;
        int intLastNumber = -1;
     
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            intGuessedNumber = Convert.ToInt32(txtInputNumber.Text);

            do
            {
                if (intGuessedNumber > intNumber)
                {
                    lblOutput.Text = ("Try a smaller number");
                }
                if (intGuessedNumber < intNumber)
                {

                }
                if (intGuessedNumber == intNumber)
                {
                    lblOutput.Text = ("wow that's actually the right number");
                }
                intLastNumber = intGuessedNumber;


            } while (intNumberGuessed == lowerNumber || intGuessNumber == higherNumber);
        }
    }
}
