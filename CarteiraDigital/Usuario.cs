using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLDatabase;
using System.Data;
using System.Data.SqlClient;

namespace CarteiraDigital
{
    class Usuario : Pessoa
    {
        public string Nome { get ; set ; }
        public string Sobrenome { get; set; }
        public int CPF { get; set; }
        public string Nacionalidade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Documento { get ; set ; }
        
        public string Nickname;

        public string Senha;

        public void Consultar()
        {

            throw new NotImplementedException();
        }

        public void Gravar()
        {
            try
            {
                //var ds = new DataSet();

                DatabaseConnect.OpenSqlConnection();
                
                SqlCommand cmd = new SqlCommand("procGravarUsuario", connectionString.sqlConn);


                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pStrNome",Nome );
                cmd.Parameters.AddWithValue("@pStrSobrenome", Sobrenome);
                cmd.Parameters.AddWithValue("@pDtDataNacimento", DataNascimento);
                cmd.Parameters.AddWithValue("@pStrDocumento", Documento);
                cmd.Parameters.AddWithValue("@pstrNacionalidade", Nacionalidade);
                cmd.Parameters.AddWithValue("@pStrUsuario", Nickname);
                cmd.Parameters.AddWithValue("@pStrSenha", Senha);

                cmd.Parameters.Add("@pIntResult", SqlDbType.Int);
                cmd.Parameters["@pIntResult"].Direction = ParameterDirection.Output;

                int i = cmd.ExecuteNonQuery();

                if( Convert.ToInt32(cmd.Parameters["@pIntResult"].Value) <= 0)
                {
                    MessageBox.Show("Não foi possivel realizar o cadastro.");
                }


                //SqlDataAdapter da = new SqlDataAdapter(cmd);

                //da.Fill(ds);

                //lblmsg.Text = "Contatos da cidade : " + txtCidade.Text;

                //GridView1.DataSource = ds;

                //GridView1.DataBind();
            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message) ;

            }

            finally

            {
                DatabaseConnect.CloseSqlConnection();
            }

        }
    }
}
