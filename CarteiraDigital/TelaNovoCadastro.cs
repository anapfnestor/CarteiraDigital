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
    public partial class TelaNovoCadastro : Form
    {
        public TelaNovoCadastro()
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

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            Usuario novouser = new Usuario();
            novouser.Nome = txtNome.Text;
            novouser.Sobrenome = txtSobrenome.Text;
            novouser.Nacionalidade = cbNacionalidade.SelectedItem.ToString();
            novouser.DataNascimento = dtNascimento.Value;
            novouser.Documento = txtDocumento.Text;
            novouser.Nickname = Text;
            novouser.Senha = txtSenha.Text;

            novouser.Gravar();


            Form login = new formLogin();

            login.MdiParent = MDISingleton.instanciaMDI();
            login.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            login.Dock = DockStyle.Fill;
            login.Show();

            this.Dispose();
        }
    }
}
