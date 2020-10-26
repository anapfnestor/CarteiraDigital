namespace CarteiraDigital
{
    partial class TelaTransferencia
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
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbVoltar = new System.Windows.Forms.ToolStripButton();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.txtDocDest = new System.Windows.Forms.TextBox();
            this.lblDocDestinatario = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblSaldoDisponivel = new System.Windows.Forms.Label();
            this.lblValorDisponivel = new System.Windows.Forms.Label();
            this.grpTransferencia = new System.Windows.Forms.GroupBox();
            this.tsMenu.SuspendLayout();
            this.grpTransferencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(189, 141);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(63, 13);
            this.lblDestinatario.TabIndex = 0;
            this.lblDestinatario.Text = "Destinatário";
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Enabled = false;
            this.txtDestinatario.Location = new System.Drawing.Point(192, 157);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(187, 20);
            this.txtDestinatario.TabIndex = 1;
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalvar,
            this.tsbVoltar,
            this.tsbFechar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(569, 25);
            this.tsMenu.TabIndex = 15;
            this.tsMenu.Text = "Menu";
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvar.Image = global::CarteiraDigital.Properties.Resources.noun_Save_858111;
            this.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(23, 22);
            this.tsbSalvar.Text = "Salvar";
            this.tsbSalvar.ToolTipText = "Salvar";
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
            // txtDocDest
            // 
            this.txtDocDest.Location = new System.Drawing.Point(192, 100);
            this.txtDocDest.Name = "txtDocDest";
            this.txtDocDest.Size = new System.Drawing.Size(187, 20);
            this.txtDocDest.TabIndex = 17;
            // 
            // lblDocDestinatario
            // 
            this.lblDocDestinatario.AutoSize = true;
            this.lblDocDestinatario.Location = new System.Drawing.Point(189, 84);
            this.lblDocDestinatario.Name = "lblDocDestinatario";
            this.lblDocDestinatario.Size = new System.Drawing.Size(121, 13);
            this.lblDocDestinatario.TabIndex = 16;
            this.lblDocDestinatario.Text = "Documento Destinatário";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(192, 214);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(187, 20);
            this.txtValor.TabIndex = 19;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(189, 198);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 18;
            this.lblValor.Text = "Valor";
            // 
            // lblSaldoDisponivel
            // 
            this.lblSaldoDisponivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldoDisponivel.AutoSize = true;
            this.lblSaldoDisponivel.Location = new System.Drawing.Point(211, 238);
            this.lblSaldoDisponivel.Name = "lblSaldoDisponivel";
            this.lblSaldoDisponivel.Size = new System.Drawing.Size(91, 13);
            this.lblSaldoDisponivel.TabIndex = 20;
            this.lblSaldoDisponivel.Text = "Saldo Disponível:";
            // 
            // lblValorDisponivel
            // 
            this.lblValorDisponivel.AutoSize = true;
            this.lblValorDisponivel.Location = new System.Drawing.Point(308, 238);
            this.lblValorDisponivel.Name = "lblValorDisponivel";
            this.lblValorDisponivel.Size = new System.Drawing.Size(40, 13);
            this.lblValorDisponivel.TabIndex = 21;
            this.lblValorDisponivel.Text = "100,00";
            // 
            // grpTransferencia
            // 
            this.grpTransferencia.Controls.Add(this.lblSaldoDisponivel);
            this.grpTransferencia.Controls.Add(this.lblValorDisponivel);
            this.grpTransferencia.Location = new System.Drawing.Point(12, 28);
            this.grpTransferencia.Name = "grpTransferencia";
            this.grpTransferencia.Size = new System.Drawing.Size(545, 279);
            this.grpTransferencia.TabIndex = 22;
            this.grpTransferencia.TabStop = false;
            // 
            // TelaTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 319);
            this.ControlBox = false;
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtDocDest);
            this.Controls.Add(this.lblDocDestinatario);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.grpTransferencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaTransferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.grpTransferencia.ResumeLayout(false);
            this.grpTransferencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbVoltar;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.TextBox txtDocDest;
        private System.Windows.Forms.Label lblDocDestinatario;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ToolStripButton tsbSalvar;
        private System.Windows.Forms.Label lblSaldoDisponivel;
        private System.Windows.Forms.Label lblValorDisponivel;
        private System.Windows.Forms.GroupBox grpTransferencia;
    }
}