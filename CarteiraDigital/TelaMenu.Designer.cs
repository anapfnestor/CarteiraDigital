namespace CarteiraDigital
{
    partial class TelaMenu
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
            this.btnExtrato = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.btnSaqueDeposito = new System.Windows.Forms.Button();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExtrato
            // 
            this.btnExtrato.Location = new System.Drawing.Point(174, 106);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(221, 23);
            this.btnExtrato.TabIndex = 0;
            this.btnExtrato.Text = "Extrato";
            this.btnExtrato.UseVisualStyleBackColor = true;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Location = new System.Drawing.Point(174, 148);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(221, 23);
            this.btnTransferencia.TabIndex = 1;
            this.btnTransferencia.Text = "Transferência";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // btnSaqueDeposito
            // 
            this.btnSaqueDeposito.Location = new System.Drawing.Point(174, 190);
            this.btnSaqueDeposito.Name = "btnSaqueDeposito";
            this.btnSaqueDeposito.Size = new System.Drawing.Size(221, 23);
            this.btnSaqueDeposito.TabIndex = 2;
            this.btnSaqueDeposito.Text = "Saque/Depósito";
            this.btnSaqueDeposito.UseVisualStyleBackColor = true;
            this.btnSaqueDeposito.Click += new System.EventHandler(this.btnSaqueDeposito_Click);
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFechar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(569, 25);
            this.tsMenu.TabIndex = 8;
            this.tsMenu.Text = "Menu";
            // 
            // tsbFechar
            // 
            this.tsbFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFechar.Image = global::CarteiraDigital.Properties.Resources.noun_Close_1090901;
            this.tsbFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFechar.Name = "tsbFechar";
            this.tsbFechar.Size = new System.Drawing.Size(23, 22);
            this.tsbFechar.Text = "Sair";
            this.tsbFechar.Click += new System.EventHandler(this.tsbFechar_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Location = new System.Drawing.Point(4, 28);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(553, 279);
            this.grpMenu.TabIndex = 23;
            this.grpMenu.TabStop = false;
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 319);
            this.ControlBox = false;
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.btnSaqueDeposito);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.grpMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExtrato;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.Button btnSaqueDeposito;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.GroupBox grpMenu;
    }
}