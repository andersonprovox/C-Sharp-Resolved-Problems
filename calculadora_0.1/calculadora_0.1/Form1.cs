using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_0._1
{
    public partial class Form1 : Form
    {
        double result = 0;
        String operador = "";
        bool op_press = false;
        public Form1()
        {
            InitializeComponent();
        }
        //Metodo genérico para manipular botoes
        private void btn_Click(object sender, EventArgs e)
        {
            //se o texto tiver um zero na caixa ele vai apagar ao clicar no botao correpondente
            if ((txtDisplay.Text == "0")||(op_press))
                txtDisplay.Clear();

            Button b = (Button)sender;
            //condicao para evitar mais de um ponto decimal
            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + b.Text;
            }
            else
                txtDisplay.Text = txtDisplay.Text + b.Text;
            

        }
        //botao para zerar o display
        private void btnZera_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }
        private void op_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operador = b.Text;
            result = Double.Parse(txtDisplay.Text);
            op_press = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (operador)
            {
                case "+":
                    txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    if((txtDisplay.Text == "0")||(result == 0))
                    {
                        MessageBox.Show("Na divisão não pode conter zero!");
                    }
                    else
                    {
                        txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                    }
                        
                    break;
                default:
                    break;

            }
            op_press = false;
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            //vai limpar a caixa de texto e zerar a variável que armazena o resultado
            txtDisplay.Text  = "0";
            result = 0;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
              switch(e.KeyChar.ToString())
            {
                case "0":
                    btnZero.PerformClick();
                    break;
                case "1":
                    btnUm.PerformClick();
                    break;
                case "2":
                    btnDois.PerformClick();
                    break;
                case "3":
                    btnTres.PerformClick();
                    break;
                case "4":
                    btnQuatro.PerformClick();
                    break;
                case "5":
                    btnCinco.PerformClick();
                    break;
                case "6":
                    btnSeis.PerformClick();
                    break;
                case "7":
                    btnSete.PerformClick();
                    break;
                case "8":
                    btnOito.PerformClick();
                    break;
                case "9":
                    btnNove.PerformClick();
                    break;
                case "+":
                    btnMais.PerformClick();
                    break;
                case "-":
                    btnMenos.PerformClick();
                    break;
                case "*":
                    btnMulti.PerformClick();
                    break;
                case "/":
                    btnDiv.PerformClick();
                    break;
                case "=":
                    btnIgual.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void btn_Int_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrantes do Grupo: Rodrigo Celestiano e Anderson Gonzaga da Fonseca");
        }
    }
}
