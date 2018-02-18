using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace Mobilidade.Paginas
{
    public partial class SugestaoRelatorio : System.Web.UI.Page
    {
        string login;
        string senha;
        protected void Page_Load(object sender, EventArgs e)
        {
            login = Convert.ToString(Session["Salvarnome"].ToString());
            senha = Convert.ToString(Session["Salvarsenha"].ToString());
            if (!IsPostBack)
            {
                carregarDados();
            }
        }
        private void carregarDados()
        {
            //conexão;
            string connectionString = "datasource=localhost;port=3306;username= '" + login + "';password='" + senha + "';database=mobilidade;";
            //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=locadora;";
            string query = "select idTipo_Servico, Tipo_Servico FROM tipo_servico  order by idTipo_Servico";
            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                DropDowntipo.DataSource = reader;
                DropDowntipo.DataValueField = "idTipo_Servico";
                DropDowntipo.DataTextField = "Tipo_Servico";
                DropDowntipo.DataBind();
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected void DropDowntipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //conexão;
            string connectionString = "datasource=localhost;port=3306;username= '" + login + "';password='" + senha + "';database=mobilidade;";
            //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=locadora;";
            string query = "select servico.Nome As '" + DropDowntipo.SelectedItem.Text.Trim() + "', comentario.Comentario from sugestao inner join comentario on idcomentario = comentario_idcomentario inner join servico on servico_idservico = idservico WHERE servico_idservico IN(select idservico from servico where tipo_servico_idtipo_servico ='" + DropDowntipo.SelectedValue.Trim() + "')";
            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                GridViewsugestao.DataSource = reader;
                GridViewsugestao.DataBind();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                Console.WriteLine(ex.Message);
            }
        }
    }
}