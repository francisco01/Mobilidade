using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobilidade.Paginas
{
    public partial class PermissaoAdmin : System.Web.UI.Page
    {
        string login;
        string senha;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            int tpusu = Convert.ToInt16(Session["tpusu"].ToString());
            login = Convert.ToString(Session["Salvarnome"].ToString());
            senha = Convert.ToString(Session["Salvarsenha"].ToString());
            if (tpusu == 0)
            {
                Response.Redirect("/Default.aspx");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                string connectionString = "datasource=localhost;port=3306;username='" + login + "';password='" + senha + "';database=mobilidade;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                string query = "update usuario set UsuAdm = 1 where login = '" + TextBox1.Text.Trim() + "'";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
                atribuirPermissaoAdmin(TextBox1.Text.Trim());
                Label1.Text = "Usuario com permissão admin!";
                TextBox1.Text = "";

            }
            catch (Exception ex)
            {
                Label1.Text = "Erro ao tentar dar permissao! " + ex.Message;
            }

        }
        private void atribuirPermissaoAdmin(string usu)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username='" + login + "';password='" + senha + "';database=mobilidade;";
                MySqlConnection databaseConnection2 = new MySqlConnection(connectionString);
                databaseConnection2.Open();
                MySqlCommand commandDatabase2 = new MySqlCommand("GRANT ALL ON mobilidade.* To '" + usu + "' with grant option ", databaseConnection2);
                commandDatabase2.ExecuteNonQuery();
                databaseConnection2.Close();

            }
            catch (Exception ex)
            {
                // Show any error message.
                Label1.Text = "Erro ao tentar dar permissao! " + ex.Message;
                //throw new Exception("Erro" + ex.Message);
            }

        }
    }
}