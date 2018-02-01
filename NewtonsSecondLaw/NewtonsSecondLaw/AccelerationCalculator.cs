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
    public partial class AccelerationCalculator : Form
    {
        public AccelerationCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double dblForce;
            Double dblAcc;
            Double dblMass;
            String strPlanet;

            dblMass = Convert.ToDouble(txtMass.Text);
            dblForce = Convert.ToDouble(txtForce.Text);

            dblAcc = dblForce / dblMass;

            if (dblAcc == 1.625)
            {
                strPlanet = ("Moon");
            }
            else if (dblAcc == 9.8)
            {
                strPlanet = ("Earth");
            }
            else if (dblAcc == 3.8)
            {
                strPlanet = ("Mars");
            }
            else
            {
                strPlanet = ("an Unknown location");
            }

            lblAcc.Text = (dblAcc + " m/s^2, which is the acceleration of " + strPlanet + ".");
            lblEquation.Text = (dblAcc + " m/s^2 = " + dblForce + " N / " + dblMass + " kg");
        }
    }
}
