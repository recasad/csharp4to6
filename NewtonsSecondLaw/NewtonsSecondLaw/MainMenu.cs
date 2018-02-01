using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewtonsSecondLaw
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnMass_Click(object sender, EventArgs e)
        {
            MassCalculator massCalculator = new MassCalculator();
            massCalculator.Show();
        }

        private void btnForce_Click(object sender, EventArgs e)
        {
            ForceCalculator forceCalculator = new ForceCalculator();
            forceCalculator.Show();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            AccelerationCalculator accelerationCalculator = new AccelerationCalculator();
            accelerationCalculator.Show();
        }
    }
}
