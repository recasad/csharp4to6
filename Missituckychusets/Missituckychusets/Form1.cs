﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Missituckychusets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            int intCanOne;
            int intCanTwo;
            int intCanThree;
            int intDele;
            int intCanOneDel;
            int intCanTwoDel;
            int intCanThreeDel;

            intCanOne = Convert.ToInt32(txtCanOne.Text);
            intCanTwo = Convert.ToInt32(txtCanTwo.Text);
            intDele = Convert.ToInt32(txtDelagates.Text);
            intCanThree = 100 - (intCanOne + intCanTwo);

            if (intCanOne > 50 || intCanTwo > 50 || intCanThree > 50)
            {
                if (intCanOne > 50)
                {
                    lblCanOneDel.Text = intDele.ToString();
                    lblCanTwoDel.Text = "0";
                    lblCanThreeDel.Text = "0";
                }
                else if (intCanTwo > 50)
                {
                    lblCanOneDel.Text = "0";
                    lblCanTwoDel.Text = intDele.ToString();
                    lblCanThreeDel.Text = "0";
                }
                else
                {
                    lblCanOneDel.Text = "0";
                    lblCanTwoDel.Text = "0";
                    lblCanThreeDel.Text = intDele.ToString();
                }
            }
            else if (intCanOne < 15 || intCanTwo < 15 || intCanThree < 15)
            {
                if(intCanOne < 15)
                {
                    intCanTwo = (intCanOne / 2) + intCanTwo;
                    intCanThree = (intCanOne / 2) + intCanThree;
                    intCanTwoDel = (intCanTwo * intDele) / 100;
                    intCanThreeDel = (intDele * intCanThree) / 100;
                    lblCanOneDel.Text = "0, non-viable";
                    lblCanTwoDel.Text = intCanTwoDel.ToString();
                    lblCanThreeDel.Text = intCanThreeDel.ToString();
                    
                }
                else if(intCanTwo < 15)
                {
                    intCanOne += (intCanTwo / 2);
                    intCanThree += (intCanTwo / 2);
                    intCanOneDel = (intDele * intCanOne) / 100;
                    intCanThreeDel = (intDele * intCanThree) / 100;
                    lblCanOneDel.Text = intCanOneDel.ToString();
                    lblCanTwoDel.Text = "0, non-viable";
                    lblCanThreeDel.Text = intCanThreeDel.ToString();
                   
                }
                else
                {
                    intCanOne += (intCanThree / 2);
                    intCanTwo += (intCanThree / 2);
                    intCanOneDel = (intDele * intCanOne) / 100;
                    intCanTwoDel = (intDele * intCanTwo) / 100;
                    lblCanOneDel.Text = intCanOneDel.ToString();
                    lblCanTwoDel.Text = intCanTwoDel.ToString();
                    lblCanThreeDel.Text = "0, non-viable";
                }
            }
            else
            {
                intCanOneDel = (intDele * intCanOne) / 100;
                intCanTwoDel = (intDele * intCanTwo) / 100;
                intCanThreeDel = (intDele * intCanThree) / 100;
                lblCanOneDel.Text = intCanOneDel.ToString();
                lblCanTwoDel.Text = intCanTwoDel.ToString();
                lblCanThreeDel.Text = intCanThreeDel.ToString();
            }
        }
    }
}
