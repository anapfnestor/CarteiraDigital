using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarteiraDigital
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            Form Transferencia = new TelaTransferencia();

            Transferencia.MdiParent = MDISingleton.instanciaMDI();
            Transferencia.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Transferencia.Dock = DockStyle.Fill;

            Transferencia.Show();
            this.Dispose();
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            Form extrato = new TelaExtrato();

            extrato.MdiParent = MDISingleton.instanciaMDI();
            extrato.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            extrato.Dock = DockStyle.Fill;

            extrato.Show();
            this.Dispose();
        }

        private void btnSaqueDeposito_Click(object sender, EventArgs e)
        {
            Form SaqDep = new TelaSaqueDeposito();

            SaqDep.MdiParent = MDISingleton.instanciaMDI();
            SaqDep.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SaqDep.Dock = DockStyle.Fill;

            SaqDep.Show();
            this.Dispose();
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            Form login = new formLogin();

            login.MdiParent = MDISingleton.instanciaMDI();
            login.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            login.Dock = DockStyle.Fill;

            login.Show();
            this.Dispose();
        }
    }
}
