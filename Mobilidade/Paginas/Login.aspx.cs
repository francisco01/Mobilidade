using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobilidade.Paginas
{
    public partial class Login : System.Web.UI.Page
    {
        string user;
        string password;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            
            string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mobilidade;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
            user = this.txtLogin.Text;
            password = this.txtSenha.Text;
            string query = "select * from usuario where usuario.login = @Login and usuario.senha = @Senha;";
            MySqlCommand command = new MySqlCommand(query,databaseConnection);
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = user;
            command.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = password;
            MySqlDataReader reader = command.ExecuteReader();
            //MySqlDataReader reader2 = command2.ExecuteReader();
           // lblDebug.Text = rea
            //lblDebug.Text = reader.HasRows.ToString();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    Session["Salvarid"] = reader.GetUInt32(0);
                    Session["Salvarnome"] = reader.GetString("login");
                    Session["Salvarsenha"] = reader.GetString("senha");
                    Session["tpusu"] = reader.GetUInt16("UsuAdm");
                }
                FormsAuthentication.RedirectFromLoginPage(user,false);
                //Response.Redirect("Default.aspx",);
                //Response.Redirect("/Paginas/ConsultaVeiculos.aspx");
            } else
            {
                lblDebug.Text = "Login ou senha invalido!";
               // FormsAuthentication.RedirectToLoginPage();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mobilidade;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
            user = "maria.vitor" ;
            password = "123456";
            string query = "select 1 from usuario where usuario.login = @Login and usuario.senha = @Senha;";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = user;
            command.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = password;
            MySqlDataReader reader = command.ExecuteReader();
            lblDebug.Text = reader.HasRows.ToString();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    Session["Salvarid"] = "";
                    Session["Salvarnome"] = "";
                }
                FormsAuthentication.RedirectFromLoginPage(user, false);
                Response.Redirect("/Paginas/CadastroUsuario.aspx");

            }
        }
    }
}