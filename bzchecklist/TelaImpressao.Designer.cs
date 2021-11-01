namespace bzchecklist
{
    partial class TelaImpressao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rpImpressao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpImpressao
            // 
            this.rpImpressao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpImpressao.LocalReport.ReportEmbeddedResource = "bzchecklist.Impressao.rdlc";
            this.rpImpressao.Location = new System.Drawing.Point(0, 0);
            this.rpImpressao.Name = "rpImpressao";
            this.rpImpressao.ServerReport.BearerToken = null;
            this.rpImpressao.Size = new System.Drawing.Size(591, 435);
            this.rpImpressao.TabIndex = 0;
            // 
            // TelaImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 435);
            this.Controls.Add(this.rpImpressao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaImpressao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaImpressao";
            this.Load += new System.EventHandler(this.TelaImpressao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpImpressao;
    }
}