using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobilidade.Paginas
{
    public partial class RemoverPermissaoAdmin : System.Web.UI.Page
    {
        string login;
        string senha;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
            int tpusu = Convert.ToInt16(Session["tpusu"].ToString());
            login = Convert.ToString(Session["Salvarnome"].ToString());
            senha = Convert.ToString(Session["Salvarsenha"].ToString());
            if (tpusu == 0)
            {
                Response.Redirect("/Default.aspx");
            }

        }

        protected void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {

                string connectionString = "datasource=localhost;port=3306;username='" + login + "';password='" + senha + "';database=mobilidade;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                string query = "update usuario set UsuAdm = 0 where login = '" + txtLogin.Text.Trim() + "'";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
                removerPermissaoAdmin(txtLogin.Text.Trim());
                lblMensagem.Text = "Usuario perdeu permissão admin!";
                txtLogin.Text = "";

            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro ao tentar dar permissao! " + ex.Message;
            }

        }
        private void removerPermissaoAdmin(string usu)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username='" + login + "';password='" + senha + "';database=mobilidade;";
                MySqlConnection databaseConnection2 = new MySqlConnection(connectionString);
                databaseConnection2.Open();
                MySqlCommand commandDatabase2 = new MySqlCommand("REVOKE ALL ON mobilidade.* FROM '" + usu + "'", databaseConnection2);
                commandDatabase2.ExecuteNonQuery();
                databaseConnection2.Close();

            }
            catch (Exception ex)
            {
                // Show any error message.
                lblMensagem.Text = "Erro ao tentar dar permissao! " + ex.Message;
                //throw new Exception("Erro" + ex.Message);
            }

        }

    }
}