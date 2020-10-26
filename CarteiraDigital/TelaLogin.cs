using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLDatabase;


namespace CarteiraDigital
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Form novoUsuario = new TelaNovoCadastro();
            novoUsuario.MdiParent = MDISingleton.instanciaMDI();
            novoUsuario.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            novoUsuario.Dock = DockStyle.Fill;
            novoUsuario.Show();

            tsbFechar_Click(sender,e);
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Form Menu = new TelaMenu();
            Menu.MdiParent = MDISingleton.instanciaMDI();
            Menu.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Menu.Dock = DockStyle.Fill;
            Menu.Show();
        }
    }
}
