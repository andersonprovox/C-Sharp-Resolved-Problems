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
    public partial class CadUser : Form

    {
        public string nome;
        public string cidade;
        public string estado;
        public string profissao;


        public CadUser()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            nome = txtName.Text;
            cidade = txtCity.Text;
            estado = txtState.Text;
            profissao = txtProf.Text;
            MessageBox.Show("Cadastrado com sucesso");
          }
        }
    }


