using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionMDI
{
    public partial class Ticket : Form
    {
        int min = 0;
        int max = 10;

        public Ticket()
        {
            InitializeComponent();
        }

        private void btnLucky_Click(object sender, EventArgs e)
        {
            int luckNum = 5;
            int numComp = 0;
            numComp = RandomNumber(min, max);

            if(luckNum == numComp)
            {
                pictureBox1.Image = Properties.Resources.bora;
                lblResultado.Text = "Parabéns!! Você ganhou um ticket para uma Cirrose!";
            }
            else
            {
                pictureBox1.Image = Properties.Resources.fu;
                lblResultado.Text = "Você não ganhou, Infelizmente o \nseu fígado ficará Saudável!";
            }


        }

        private int RandomNumber(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }
    }
}
