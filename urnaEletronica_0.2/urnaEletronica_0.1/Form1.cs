using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urnaEletronica_0._1
{
    public partial class Form1 : Form
    {
        int bolsomito ;
        int jeremias ;
        int lula ;
        int aecio ;
        int nulo;
        int branco;
        int contagem=60;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if (txtDisplay.Text == "70")
            {

                bolsomito += 1;
            }
            else if (txtDisplay.Text == "45")
            {
                aecio += 1;
            }
            else if (txtDisplay.Text == "13")
            {
                lula += 1;
            }
            else if (txtDisplay.Text == "51")
            {
                jeremias += 1;
            }
            else
                nulo += 1;

            txtDisplay.Clear();
            lblNum.Text = "";
            lblName.Text = "";
            lblSig.Text = "";
            pictureBox1.Image = Properties.Resources.braso_republica_baixa_res;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtDisplay.Text = txtDisplay.Text + b.Text;
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            lblNum.Text = "";
            lblName.Text = "";
            lblSig.Text = "";
            pictureBox1.Image = Properties.Resources.braso_republica_baixa_res;
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            branco += 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contagem > 0)
            {
                contagem--;
                lblTime.Text = (contagem + " segundos.");
            }
            else
                timer1.Stop();
            // lblTime.Text = timer1.ToString();
            if (contagem == 0){ 
            lblAvisos.Text = "A votação acabou!!!";
            lblResultado.Text = ("Bolsonaro: " + bolsomito + "\nLula: " + lula + "\nAécio: " + aecio + "\nJeremias José: " + jeremias+"\nBrancos:" +branco+"\nNulo:"+nulo);
            lblResultado.Visible = true;
            btnConfirm.Enabled = false;
        }
            
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            if(txtDisplay.Text == "70")
            {
                lblName.Text ="Jair Bolsonaro" ;
                lblSig.Text = "PSC";
                lblNum.Text = "70";
                pictureBox1.Image = Properties.Resources.jair_bolsonaro;
            }
            else if (txtDisplay.Text == "45")
            {
                lblName.Text = "Aecio Neves";
                lblSig.Text = "PSDB";
                lblNum.Text = "45";
                pictureBox1.Image = Properties.Resources.Aécio_Neves;
            }
            else if (txtDisplay.Text == "13")
            {
                lblName.Text = "Lula";
                lblSig.Text = "PT";
                lblNum.Text = "13";
                pictureBox1.Image = Properties.Resources._200px_Luiz_Inácio_Lula_da_Silva;
            }
            else if (txtDisplay.Text == "51")
            {
                lblName.Text = "Jeremias José";
                lblSig.Text = "PMB";
                lblNum.Text = "51";
                pictureBox1.Image = Properties.Resources.jeremias;
            }
        }
    }
}
