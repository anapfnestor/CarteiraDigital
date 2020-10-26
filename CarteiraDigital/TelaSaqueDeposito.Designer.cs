namespace CarteiraDigital
{
    partial class TelaSaqueDeposito
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
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbVoltar = new System.Windows.Forms.ToolStripButton();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.lblValorDisponivel = new System.Windows.Forms.Label();
            this.lblSaldoDisponivel = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.radSacar = new System.Windows.Forms.RadioButton();
            this.radDepositar = new System.Windows.Forms.RadioButton();
            this.grpSaqueDeposito = new System.Windows.Forms.GroupBox();
            this.tsMenu.SuspendLayout();
            this.grpSaqueDeposito.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalvar,
            this.tsbVoltar,
            this.tsbFechar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(539, 25);
            this.tsMenu.TabIndex = 16;
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
            // lblValorDisponivel
            // 
            this.lblValorDisponivel.AutoSize = true;
            this.lblValorDisponivel.Location = new System.Drawing.Point(443, 16);
            this.lblValorDisponivel.Name = "lblValorDisponivel";
            this.lblValorDisponivel.Size = new System.Drawing.Size(40, 13);
            this.lblValorDisponivel.TabIndex = 25;
            this.lblValorDisponivel.Text = "100,00";
            // 
            // lblSaldoDisponivel
            // 
            this.lblSaldoDisponivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldoDisponivel.AutoSize = true;
            this.lblSaldoDisponivel.Location = new System.Drawing.Point(346, 16);
            this.lblSaldoDisponivel.Name = "lblSaldoDisponivel";
            this.lblSaldoDisponivel.Size = new System.Drawing.Size(91, 13);
            this.lblSaldoDisponivel.TabIndex = 24;
            this.lblSaldoDisponivel.Text = "Saldo Disponível:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(160, 90);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(187, 20);
            this.txtValor.TabIndex = 23;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(123, 93);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 22;
            this.lblValor.Text = "Valor";
            // 
            // radSacar
            // 
            this.radSacar.AutoSize = true;
            this.radSacar.Location = new System.Drawing.Point(181, 67);
            this.radSacar.Name = "radSacar";
            this.radSacar.Size = new System.Drawing.Size(53, 17);
            this.radSacar.TabIndex = 26;
            this.radSacar.TabStop = true;
            this.radSacar.Text = "Sacar";
            this.radSacar.UseVisualStyleBackColor = true;
            // 
            // radDepositar
            // 
            this.radDepositar.AutoSize = true;
            this.radDepositar.Location = new System.Drawing.Point(254, 67);
            this.radDepositar.Name = "radDepositar";
            this.radDepositar.Size = new System.Drawing.Size(70, 17);
            this.radDepositar.TabIndex = 27;
            this.radDepositar.TabStop = true;
            this.radDepositar.Text = "Depositar";
            this.radDepositar.UseVisualStyleBackColor = true;
            // 
            // grpSaqueDeposito
            // 
            this.grpSaqueDeposito.Controls.Add(this.lblSaldoDisponivel);
            this.grpSaqueDeposito.Controls.Add(this.lblValorDisponivel);
            this.grpSaqueDeposito.Controls.Add(this.radDepositar);
            this.grpSaqueDeposito.Controls.Add(this.radSacar);
            this.grpSaqueDeposito.Controls.Add(this.txtValor);
            this.grpSaqueDeposito.Controls.Add(this.lblValor);
            this.grpSaqueDeposito.Location = new System.Drawing.Point(12, 28);
            this.grpSaqueDeposito.Name = "grpSaqueDeposito";
            this.grpSaqueDeposito.Size = new System.Drawing.Size(515, 213);
            this.grpSaqueDeposito.TabIndex = 28;
            this.grpSaqueDeposito.TabStop = false;
            // 
            // TelaSaqueDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 243);
            this.ControlBox = false;
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.grpSaqueDeposito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaSaqueDeposito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.grpSaqueDeposito.ResumeLayout(false);
            this.grpSaqueDeposito.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbSalvar;
        private System.Windows.Forms.ToolStripButton tsbVoltar;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.Label lblValorDisponivel;
        private System.Windows.Forms.Label lblSaldoDisponivel;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.RadioButton radSacar;
        private System.Windows.Forms.RadioButton radDepositar;
        private System.Windows.Forms.GroupBox grpSaqueDeposito;
    }
}