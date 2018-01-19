using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateRev_Click(object sender, EventArgs e)
        {
            int Tickets = 25;
            int CurrentRevenue;
            int Current;
            int Past;
            int PastRevenue;
            Current = Convert.ToInt32(CurrentContestants.Text);
            Past = Convert.ToInt32(PreviousContestants.Text);
            CurrentRevenue = Current * Tickets;
            Revenue.Text = "Aproximatly " + CurrentRevenue.ToString("c");
            PastRevenue = Past * Tickets;

            if (CurrentRevenue > PastRevenue)
                if ((PastRevenue * 2) <= CurrentRevenue)
                    MoreOrLess.Text = "The competition is more than twice as big this year!";
                else
                    MoreOrLess.Text = "The competition is bigger than ever!";
            else if (CurrentRevenue < PastRevenue)
                MoreOrLess.Text = "A tighter race this year! Come out and cast your vote!";
            else
                MoreOrLess.Text = "The Current Competition is equal with the last!";



        }
    }
}
