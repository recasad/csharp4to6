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
    public partial class MassCalculator : Form
    {
        public MassCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double dblForce;
            Double dblAcc;
            Double dblMass;

            dblForce = Convert.ToDouble(txtForce.Text);

            if(radMoon.Checked == true)
            {
                dblAcc = 1.625;
            }
            else if(radMars.Checked == true)
            {
                dblAcc = 3.8;
            }
            else if(radEarth.Checked == true)
            {
                dblAcc = 9.8;
            }
            else
            {
                dblAcc = 9.8;
            }

            dblMass = dblForce / dblAcc;

            lblMass.Text = (dblMass + " kg");
            lblEquation.Text = (dblMass + " kg = " + dblForce + " N / " + dblAcc + " m/s^2");

        }
    }
}
