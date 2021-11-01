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
    public partial class TelaImpressao : Form
    {
        public TelaImpressao(string tecnico,string OS, string equipamento,string modelo)
        {
            InitializeComponent();
            rpImpressao.LocalReport.DataSources.Clear();
            rpImpressao.LocalReport.ReportEmbeddedResource = "bzchecklist.Impressao.rdlc";

            Microsoft.Reporting.WinForms.ReportParameter[] P = new
                Microsoft.Reporting.WinForms.ReportParameter[3];

            P[0]= new Microsoft.Reporting.WinForms.ReportParameter("Técnico", tecnico);
            P[1] = new Microsoft.Reporting.WinForms.ReportParameter("Nº O.S", OS);
            P[2] = new Microsoft.Reporting.WinForms.ReportParameter("Equipamento", equipamento);
            P[3] = new Microsoft.Reporting.WinForms.ReportParameter("Modelo", modelo);

            rpImpressao.LocalReport.SetParameters(P);
            rpImpressao.LocalReport.Refresh();
            rpImpressao.RefreshReport();
        }

        private void TelaImpressao_Load(object sender, EventArgs e)
        {

            this.rpImpressao.RefreshReport();
        }
    }
}
