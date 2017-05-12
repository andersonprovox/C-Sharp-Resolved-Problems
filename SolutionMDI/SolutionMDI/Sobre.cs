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
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblNomes.Text = (" Anderson Gonzaga da Fonseca\n Pedro do Carmo Souza \n Luiz Fernando Marques dos Santos");
        }
    }
}
