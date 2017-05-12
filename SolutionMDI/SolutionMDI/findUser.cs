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
    public partial class findUser : Form
    {
        public findUser()
        {
            InitializeComponent();
           

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            

            CadUser frmCad = new CadUser();
            
                lblNome.Text = frmCad.nome;
                lblCity.Text = frmCad.cidade;
                lblState.Text = frmCad.estado;
                lblProf.Text = frmCad.profissao;
           
            
        
        }
    }
}
