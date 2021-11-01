using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bzchecklist
{
    public partial class frmchecklist : Form
    {
        public frmchecklist()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você realmente quer fechar a janela?", "Fechar janela", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
                if (result == DialogResult.No)
            {
                this.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();

            //TelaImpressao imprimir = new TelaImpressao(cbTecnico.Text, cbEquipamento.Text, txtOS.Text, txtModelo.Text);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fonte1 = new Font("Arial", 30,FontStyle.Bold, GraphicsUnit.Pixel);
            e.Graphics.DrawString("Nome empresa: ", fonte1, Brushes.Black, 300, 50);

            Font fonte = new Font("Arial", 18, GraphicsUnit.Pixel);
            e.Graphics.DrawString("Endereço", fonte, Brushes.Black, 370, 80);
            e.Graphics.DrawString("Informações para contato.", fonte, Brushes.Black, 310, 97);
            /*e.Graphics.DrawString("(81) 3722-2793 / 81 99928-3937", fonte, Brushes.Black, 270, 117);
            e.Graphics.DrawString("suporte@bzinformatica.com.br", fonte, Brushes.Black, 270, 132);*/


            e.Graphics.DrawString("Técnico: ", fonte, Brushes.Black, 20, 185);
            e.Graphics.DrawString(cbTecnico.Text, fonte, Brushes.Black, 110, 185);

            e.Graphics.DrawString("Nº da OS: ", fonte, Brushes.Black, 20, 210);
            e.Graphics.DrawString(txtOS.Text, fonte, Brushes.Black, 115, 210);

            e.Graphics.DrawString("Equipamento: ", fonte, Brushes.Black, 20, 230);
            e.Graphics.DrawString(cbEquipamento.Text, fonte, Brushes.Black, 158,230);

            //Cabos flat começo
            e.Graphics.DrawString("Modelo: ", fonte, Brushes.Black, 20, 250);
            e.Graphics.DrawString(txtModelo.Text, fonte, Brushes.Black, 100, 250);

            e.Graphics.DrawString("Checklist Entrada ", fonte, Brushes.Black, 308, 287);
            

            e.Graphics.DrawString("Cabos flat: ", fonte, Brushes.Black, 20,320);
            e.Graphics.DrawString("Cabeça: ", fonte, Brushes.Black, 20, 350);
            e.Graphics.DrawString(cbCabeca.Text, fonte, Brushes.Black,100, 350);

            e.Graphics.DrawString("Placa: ", fonte, Brushes.Black, 20, 380);
            e.Graphics.DrawString(cbPlaca.Text, fonte, Brushes.Black, 100, 380);

            e.Graphics.DrawString("Painel: ", fonte, Brushes.Black, 20, 410);
            e.Graphics.DrawString(cbPainel.Text, fonte, Brushes.Black, 100, 410);

            e.Graphics.DrawString("Scanner: ", fonte, Brushes.Black, 20, 440);
            e.Graphics.DrawString(cbScanner.Text, fonte, Brushes.Black, 108, 440);
            //Cabo flat fim


            //Estrutura física começo
            e.Graphics.DrawString("Estrutura física: ", fonte, Brushes.Black, 300, 320);
            e.Graphics.DrawString("Suporte do papel traseiro: ", fonte, Brushes.Black, 200, 350);
            e.Graphics.DrawString(cbSPT.Text, fonte, Brushes.Black, 450, 350);

            e.Graphics.DrawString("Tampa dos dampers/dampers: ", fonte, Brushes.Black, 200, 380);
            e.Graphics.DrawString(cbSPT.Text, fonte, Brushes.Black, 495, 380);

            e.Graphics.DrawString("Suporte do papel frontal: ", fonte, Brushes.Black, 200, 410);
            e.Graphics.DrawString(cbSPT.Text, fonte, Brushes.Black, 460, 410);

            e.Graphics.DrawString("Suporte Mangueira/Mangueira: ", fonte, Brushes.Black, 200, 440);
            e.Graphics.DrawString(cbSPT.Text, fonte, Brushes.Black, 490, 440);
            //Estrutura física começo

            //Níveis de tintas começo
            e.Graphics.DrawString("Níveis de tintas: ", fonte, Brushes.Black, 598, 320);
            e.Graphics.DrawString("Preto: ", fonte, Brushes.Black,580, 350);
            e.Graphics.DrawString(cbPreto.Text, fonte, Brushes.Black, 650, 350);

            e.Graphics.DrawString("Amarelo: ", fonte, Brushes.Black, 580, 380);
            e.Graphics.DrawString(cbAmarelo.Text, fonte, Brushes.Black, 670, 380);

            e.Graphics.DrawString("Magenta: ", fonte, Brushes.Black, 580, 410);
            e.Graphics.DrawString(cbMagenta.Text, fonte, Brushes.Black, 670, 410);

            e.Graphics.DrawString("Azul: ", fonte, Brushes.Black, 580, 440);
            e.Graphics.DrawString(cbAzul.Text, fonte, Brushes.Black, 650, 440);
            //Níveis de tintas fim

            e.Graphics.DrawString("Inseriu no SHOficina?: ", fonte, Brushes.Black, 20, 490);
            e.Graphics.DrawString(cbOficina.Text, fonte, Brushes.Black, 235, 490);
            e.Graphics.DrawString("Inseriu no Grupo?: ", fonte, Brushes.Black, 20, 520);
            e.Graphics.DrawString(cbGrupo.Text, fonte, Brushes.Black, 215, 520);

            e.Graphics.DrawString("Observações: ", fonte, Brushes.Black, 20, 620);
            e.Graphics.DrawString(txtObs.Text, fonte, Brushes.Black, 20, 640);


            e.Graphics.DrawString("Orçamento/Peças: ", fonte, Brushes.Black, 650, 620);
            e.Graphics.DrawString(txtPecas.Text, fonte, Brushes.Black, 550, 640);

            //Código que permite exibir uma caixa de diálogo para escolher 
            //uma impressora

            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void cbEquipamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (cbEquipamento.SelectedIndex==1)
            {
                pnImpressora.Visible = true;
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            if (cbOficina.SelectedIndex == -1 || cbGrupo.SelectedIndex == -1 || cbCabeca.SelectedIndex == -1 || cbPlaca.SelectedIndex == -1 || cbPainel.SelectedIndex == -1 || cbScanner.SelectedIndex == -1 || cbTecnico.SelectedIndex == -1 || cbEquipamento.SelectedIndex == -1 || cbSPT.SelectedIndex == -1 || cbSPF.SelectedIndex == -1 || cbTD.SelectedIndex == -1 || cbAmarelo.SelectedIndex == -1 || cbPreto.SelectedIndex == -1 || cbMagenta.SelectedIndex == -1 || cbAzul.SelectedIndex == -1 || txtModelo.Text=="" || txtOS.Text=="" )
            {
                MessageBox.Show("Atenção!."+"\n\n"+"Preencha todos os dados corretamente. Tente novamente.");
            }
            else
           // if(cbOficina.SelectedIndex!=-1 && cbGrupo.SelectedIndex!= -1 && cbEquipamento.SelectedIndex!= -1 && cbTecnico.SelectedIndex != -1 && cbCabeca.SelectedIndex != -1 && cbPlaca.SelectedIndex != -1 && cbPainel.SelectedIndex != -1 && cbScanner.SelectedIndex != -1 && cbTecnico.SelectedIndex != -1 && cbEquipamento.SelectedIndex != -1 && cbSPT.SelectedIndex != -1 && cbSPF.SelectedIndex != -1 && cbTD.SelectedIndex = -1 && cbAmarelo.SelectedIndex != -1 && cbPreto.SelectedIndex != -1 && cbMagenta.SelectedIndex != -1 && cbAzul.SelectedIndex != -1 && txtModelo.Text != "" && txtOS.Text != "" )
            {
                btnImprimir.Enabled = true;
                MessageBox.Show("Dados preenchidos"+"\n\n"+"Dados Ok");
            }
        }

        private void cbSM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnImpressora_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbSPT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSPF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbAzul_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMagenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbAmarelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

