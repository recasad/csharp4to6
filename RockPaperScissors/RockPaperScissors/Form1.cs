using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public static class Variables
    {
        public static int RockCount = 0;
        public static int PaperCount = 0;
        public static int ScissorsCount = 0;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnRock_Click(object sender, EventArgs e)
        {
           Random rnd = new Random();
           int Random = rnd.Next(3);

           if (Random == 0)
               


        }
    }
}
