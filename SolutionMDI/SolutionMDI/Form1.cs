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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cosultarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findUser fd = new findUser();
            fd.MdiParent = this;
            fd.Show();
            this.toolStripStatusLabel1.Text = "Você acessou a tela de Consulta de Usuário";
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadUser cd = new CadUser();
            cd.MdiParent = this;
            cd.Show();
            this.toolStripStatusLabel1.Text = "Você acessou a tela de Cadastro de Usuário";
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sb = new Sobre();
            sb.MdiParent = this;
            sb.Show();
            this.toolStripStatusLabel1.Text = "Você acessou a tela Sobre";
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ticket tc = new Ticket();
            tc.MdiParent = this;
            tc.Show();
            this.toolStripStatusLabel1.Text = "Você acessou o Ticket";
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sb = new Sobre();
            sb.MdiParent = this;
            sb.Show();
            this.toolStripStatusLabel1.Text = "Você acessou a tela Sobre";
        }
    }
}
