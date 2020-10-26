namespace CarteiraDigital
{
    partial class TelaExtrato
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
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.gridExtrato = new System.Windows.Forms.DataGridView();
            this.txtSaldoDisponivel = new System.Windows.Forms.TextBox();
            this.lblSaldoDisponivel = new System.Windows.Forms.Label();
            this.tsbVoltar = new System.Windows.Forms.ToolStripButton();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.grpExtrato = new System.Windows.Forms.GroupBox();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridExtrato)).BeginInit();
            this.grpExtrato.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Location = new System.Drawing.Point(6, 15);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(60, 13);
            this.lblDataInicial.TabIndex = 16;
            this.lblDataInicial.Text = "Data Inicial";
            // 
            // dtInicial
            // 
            this.dtInicial.CustomFormat = "dd/MM/yyyy";
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicial.Location = new System.Drawing.Point(72, 12);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(90, 20);
            this.dtInicial.TabIndex = 15;
            this.dtInicial.Value = new System.DateTime(2020, 10, 5, 0, 0, 0, 0);
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbVoltar,
            this.tsbFechar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(569, 25);
            this.tsMenu.TabIndex = 14;
            this.tsMenu.Text = "Menu";
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Location = new System.Drawing.Point(181, 15);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(55, 13);
            this.lblDataFinal.TabIndex = 18;
            this.lblDataFinal.Text = "Data Final";
            // 
            // dtFinal
            // 
            this.dtFinal.CustomFormat = "dd/MM/yyyy";
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFinal.Location = new System.Drawing.Point(242, 12);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(90, 20);
            this.dtFinal.TabIndex = 17;
            this.dtFinal.Value = new System.DateTime(2020, 10, 5, 0, 0, 0, 0);
            // 
            // gridExtrato
            // 
            this.gridExtrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridExtrato.Location = new System.Drawing.Point(6, 38);
            this.gridExtrato.Name = "gridExtrato";
            this.gridExtrato.Size = new System.Drawing.Size(535, 197);
            this.gridExtrato.TabIndex = 19;
            // 
            // txtSaldoDisponivel
            // 
            this.txtSaldoDisponivel.Enabled = false;
            this.txtSaldoDisponivel.Location = new System.Drawing.Point(439, 251);
            this.txtSaldoDisponivel.Name = "txtSaldoDisponivel";
            this.txtSaldoDisponivel.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoDisponivel.TabIndex = 23;
            // 
            // lblSaldoDisponivel
            // 
            this.lblSaldoDisponivel.AutoSize = true;
            this.lblSaldoDisponivel.Location = new System.Drawing.Point(345, 254);
            this.lblSaldoDisponivel.Name = "lblSaldoDisponivel";
            this.lblSaldoDisponivel.Size = new System.Drawing.Size(88, 13);
            this.lblSaldoDisponivel.TabIndex = 22;
            this.lblSaldoDisponivel.Text = "Saldo Disponível";
            // 
            // tsbVoltar
            // 
            this.tsbVoltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbVoltar.Image = global::CarteiraDigital.Properties.Resources.noun_back_2784542;
            this.tsbVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVoltar.Name = "tsbVoltar";
            this.tsbVoltar.Size = new System.Drawing.Size(23, 22);
            this.tsbVoltar.Text = "Voltar";
            this.tsbVoltar.ToolTipText = "Voltar";
            this.tsbVoltar.Click += new System.EventHandler(this.tsbVoltar_Click);
            // 
            // tsbFechar
            // 
            this.tsbFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFechar.Image = global::CarteiraDigital.Properties.Resources.noun_Close_1090901;
            this.tsbFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFechar.Name = "tsbFechar";
            this.tsbFechar.Size = new System.Drawing.Size(23, 22);
            this.tsbFechar.Text = "Fechar";
            this.tsbFechar.Click += new System.EventHandler(this.tsbFechar_Click);
            // 
            // grpExtrato
            // 
            this.grpExtrato.Controls.Add(this.lblDataFinal);
            this.grpExtrato.Controls.Add(this.gridExtrato);
            this.grpExtrato.Controls.Add(this.dtFinal);
            this.grpExtrato.Controls.Add(this.lblDataInicial);
            this.grpExtrato.Controls.Add(this.txtSaldoDisponivel);
            this.grpExtrato.Controls.Add(this.dtInicial);
            this.grpExtrato.Controls.Add(this.lblSaldoDisponivel);
            this.grpExtrato.Location = new System.Drawing.Point(10, 28);
            this.grpExtrato.Name = "grpExtrato";
            this.grpExtrato.Size = new System.Drawing.Size(547, 279);
            this.grpExtrato.TabIndex = 24;
            this.grpExtrato.TabStop = false;
            // 
            // TelaExtrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(569, 319);
            this.ControlBox = false;
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.grpExtrato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaExtrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridExtrato)).EndInit();
            this.grpExtrato.ResumeLayout(false);
            this.grpExtrato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbVoltar;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DataGridView gridExtrato;
        private System.Windows.Forms.TextBox txtSaldoDisponivel;
        private System.Windows.Forms.Label lblSaldoDisponivel;
        private System.Windows.Forms.GroupBox grpExtrato;
    }
}