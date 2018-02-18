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
        private void criaUsuario(string usu, string senha)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mobilidade;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("CREATE USER '"+usu+ "' IDENTIFIED BY '" +senha+ "'", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                lblacao.Text = "Erro ao tentar ciar usuario! " + ex.Message;
                //throw new Exception("Erro" + ex.Message);
               
            }
        }
        private void atribuirPermissaoComentario(string usu) 
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mobilidade;";
                MySqlConnection databaseConnection2 = new MySqlConnection(connectionString);
                databaseConnection2.Open();
                MySqlCommand commandDatabase2 = new MySqlCommand("GRANT SELECT,INSERT ON Comentario To '" + usu + "' ", databaseConnection2);
                commandDatabase2.ExecuteNonQuery();
                databaseConnection2.Close();

            }
            catch (Exception ex)
            {
                // Show any error message.
                lblacao.Text = "Erro ao tentar dar permissao! " + ex.Message;
                //throw new Exception("Erro" + ex.Message);
            }

        }

        private void atribuirPermissaoSugestao(string usu)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mobilidade;";
                MySqlConnection databaseConnection2 = new MySqlConnection(connectionString);
                databaseConnection2.Open();
                MySqlCommand commandDatabase2 = new MySqlCommand("GRANT SELECT,INSERT ON Sugestao To '" + usu + "' ", databaseConnection2);
                commandDatabase2.ExecuteNonQuery();
                databaseConnection2.Close();

            }
            catch (Exception ex)
            {
                // Show any error message.
                lblacao.Text = "Erro ao tentar dar permissao! " + ex.Message;
                //throw new Exception("Erro" + ex.Message);
            }

        }

        private void atribuirPermissaoProblema(string usu)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mobilidade;";
                MySqlConnection databaseConnection2 = new MySqlConnection(connectionString);
                databaseConnection2.Open();
                MySqlCommand commandDatabase2 = new MySqlCommand("GRANT SELECT,INSERT ON Problema To '" + usu + "' ", databaseConnection2);
                commandDatabase2.ExecuteNonQuery();
                databaseConnection2.Close();

            }
            catch (Exception ex)
            {
                // Show any error message.
                lblacao.Text = "Erro ao tentar dar permissao! " + ex.Message;
                //throw new Exception("Erro" + ex.Message);
            }

        }
        private void atribuirPermissaoAvalia(string usu)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mobilidade;";
                MySqlConnection databaseConnection2 = new MySqlConnection(connectionString);
                databaseConnection2.Open();
                MySqlCommand commandDatabase2 = new MySqlCommand("GRANT SELECT,INSERT ON Avalia To '" + usu + "' ", databaseConnection2);
                commandDatabase2.ExecuteNonQuery();
                databaseConnection2.Close();

            }
            catch (Exception ex)
            {
                // Show any error message.
                lblacao.Text = "Erro ao tentar dar permissao! " + ex.Message;
                //throw new Exception("Erro" + ex.Message);
            }

        }
        private void atribuirPermissaoServico(string usu)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mobilidade;";
                MySqlConnection databaseConnection2 = new MySqlConnection(connectionString);
                databaseConnection2.Open();
                MySqlCommand commandDatabase2 = new MySqlCommand("GRANT SELECT ON Servico To '" + usu + "' ", databaseConnection2);
                commandDatabase2.ExecuteNonQuery();
                databaseConnection2.Close();

            }
            catch (Exception ex)
            {
                // Show any error message.
                lblacao.Text = "Erro ao tentar dar permissao! " + ex.Message;
                //throw new Exception("Erro" + ex.Message);
            }

        }
        private void atribuirPermissaoTpServico(string usu)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mobilidade;";
                MySqlConnection databaseConnection2 = new MySqlConnection(connectionString);
                databaseConnection2.Open();
                MySqlCommand commandDatabase2 = new MySqlCommand("GRANT SELECT ON Tipo_Servico To '" + usu + "' ", databaseConnection2);
                commandDatabase2.ExecuteNonQuery();
                databaseConnection2.Close();

            }
            catch (Exception ex)
            {
                // Show any error message.
                lblacao.Text = "Erro ao tentar dar permissao! " + ex.Message;
                //throw new Exception("Erro" + ex.Message);
            }

        }
        private void atribuirPermissaoTpProblema(string usu)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mobilidade;";
                MySqlConnection databaseConnection2 = new MySqlConnection(connectionString);
                databaseConnection2.Open();
                MySqlCommand commandDatabase2 = new MySqlCommand("GRANT SELECT ON Tipo_Problema To '" + usu + "' ", databaseConnection2);
                commandDatabase2.ExecuteNonQuery();
                databaseConnection2.Close();

            }
            catch (Exception ex)
            {
                // Show any error message.
                lblacao.Text = "Erro ao tentar dar permissao! " + ex.Message;
                //throw new Exception("Erro" + ex.Message);
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int tipousu = 0;
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mobilidade;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO usuario(Nome, Idade, Sexo, Login, Senha, Cpf, UsuAdm)" + "VALUES( '"+txtnome.Text.Trim()+"','"+txtidade.Text.Trim()+"','"+dplsexo.Text.Trim()+"', '"+txtlogin.Text.Trim()+"', '"+txtsenha.Text.Trim()+"', '"+txtcpf.Text.Trim()+ "', '" + tipousu + "' )", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
                criaUsuario(txtlogin.Text.Trim(), txtsenha.Text.Trim());
                atribuirPermissaoComentario(txtlogin.Text.Trim());
                atribuirPermissaoSugestao(txtlogin.Text.Trim());
                atribuirPermissaoProblema(txtlogin.Text.Trim());
                atribuirPermissaoAvalia(txtlogin.Text.Trim());
                atribuirPermissaoServico(txtlogin.Text.Trim());
                atribuirPermissaoTpProblema(txtlogin.Text.Trim());
                atribuirPermissaoTpServico(txtlogin.Text.Trim());
                limparCampos();
                Response.Redirect("/Paginas/Login.aspx");
            }
            catch (Exception ex)
            {
                // Show any error message.
                lblacao.Text = "Erro ao tentar cadastrar usuario! " + ex.Message;
                //throw new Exception("Erro" + ex.Message);
            }
        }

    }
}