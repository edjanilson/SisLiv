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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pbCarrega.Value<=40)
            {
                pbCarrega.Value = pbCarrega.Value + 4;
                label1.Text = "Inicializando sistema..." + pbCarrega.Value + "%";
            }
            else
                if(pbCarrega.Value<=60)
            {
                pbCarrega.Value = pbCarrega.Value + 4;
                label1.Text = "Verificando..." + pbCarrega.Value + "%";
            }
            else
                if(pbCarrega.Value<90)
            {

                pbCarrega.Value = pbCarrega.Value + 4;
                label1.Text = "Aguarde..." + pbCarrega.Value + "%";
                
            }
            else
                if(pbCarrega.Value>90)
            {
                timer1.Enabled = false;
                telaprincipal principal = new telaprincipal();
                this.Visible = false;
                principal.ShowDialog();
            }
        }
    }
}
