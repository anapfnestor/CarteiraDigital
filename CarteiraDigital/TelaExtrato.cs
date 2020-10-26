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
    public partial class TelaExtrato : Form
    {
        public TelaExtrato()
        {
            InitializeComponent();
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

        private void tsbVoltar_Click(object sender, EventArgs e)
        {
            Form Menu = new TelaMenu();
            Menu.MdiParent = MDISingleton.instanciaMDI();
            Menu.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Menu.Dock = DockStyle.Fill;
            Menu.Show();
            this.Dispose();
        }
    }
}
