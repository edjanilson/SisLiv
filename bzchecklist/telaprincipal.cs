using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bzchecklist
{
    public partial class telaprincipal : Form
    {
        public telaprincipal()
        {
            InitializeComponent();
        }

        private void telaprincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmchecklist check = new frmchecklist();
            check.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você realmente quer fechar a janela?", "Fechar janela", MessageBoxButtons.YesNo);
            //Caso o botão SIM seja clicado
            if (result == DialogResult.Yes)
            {
                //O programa será fechado
                this.Close();
            }
            else
            if (result == DialogResult.No)
            {
                //Caso o botão clicado seja NÃO, então a aplicação não será fechada
                this.Visible = true;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CheckListSaida saida = new CheckListSaida();
            saida.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
        }
    }
}