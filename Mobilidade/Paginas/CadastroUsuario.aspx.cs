using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobilidade.Paginas
{
    public partial class CadastroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblacao.Text = "";
            Button1.Attributes.Add("onclick", "return valida_form_usu()");
            //txtfone.Attributes.Add("onkeypress", "Mascara(this)");
            //txtdata.Attributes.Add("onkeypress", "Mascaradt(this)");
        }

        private void limparCampos()
        {
            txtnome.Text = "";
            txtidade.Text = "";
            dplsexo.Text = "";
            txtlogin.Text = "";
            txtsenha.Text = "";
            txtlogin.Text = "";
            txtcpf.Text = "";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //conexão chico
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mobilidade;";
                //conexão jj
                //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=locadora;"; 
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                // Prepare the connection
                //int aux = 1;
                MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO usuario(Nome, Idade, Sexo, Login, Senha, Cpf)" + "VALUES( '"+txtnome.Text.Trim()+"','"+txtidade.Text.Trim()+"','"+dplsexo.Text.Trim()+"', '"+txtlogin.Text.Trim()+"', '"+txtsenha.Text.Trim()+"', '"+txtcpf.Text.Trim()+"')", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                //lblacao.Text = "1";
                databaseConnection.Close();
                limparCampos();
                Response.Redirect("/Paginas/Login.aspx");
            }
            catch (Exception ex)
            {
                // Show any error message.
                lblacao.Text = "Erro ao tentar incluir cliente! " + ex.Message;
                //throw new Exception("Erro" + ex.Message);
            }
        }

    }
}