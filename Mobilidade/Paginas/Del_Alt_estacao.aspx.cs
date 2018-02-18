using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobilidade.Paginas
{
    public partial class Del_Alt_estacao : System.Web.UI.Page
    {
        string login;
        string senha;
        protected void Page_Load(object sender, EventArgs e)
        {

            int tpusu = Convert.ToInt16(Session["tpusu"].ToString());
            login = Convert.ToString(Session["Salvarnome"].ToString());
            senha = Convert.ToString(Session["Salvarsenha"].ToString());
            if (!IsPostBack)
            {
                carregarDados();
            }
            if (tpusu == 0)
            {
                Response.Redirect("/Default.aspx");
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
                DropDownServ.DataSource = reader;
                DropDownServ.DataValueField = "idTipo_Servico";
                DropDownServ.DataTextField = "Tipo_Servico";
                DropDownServ.DataBind();
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        private void carregarGrid()
        {
            string aux = DropDownServ.SelectedValue.Trim();
            //conexão;
            string connectionString = "datasource=localhost;port=3306;username= '" + login + "';password='" + senha + "';database=mobilidade;";
            //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=locadora;";
            string query = "select idServico as ID, nome as '" + DropDownServ.SelectedItem.Text + "'  from servico where Tipo_servico_idtipo_servico = " + aux;
            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                GridViewdados.DataSource = reader;
                GridViewdados.DataBind();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                Console.WriteLine(ex.Message);
            }

        }

        protected void DropDownServ_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarGrid();
        }

        protected void GridViewdados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txtnom.Text = "";
            Txtnom.Text = GridViewdados.SelectedRow.Cells[2].Text.Trim();
        }

        protected void Btnalterar_Click(object sender, EventArgs e)
        {
            Txtnom.Enabled = true;
        }

        protected void Btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username= '" + login + "';password='" + senha + "';database=mobilidade;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                // Prepare the connection
                string query = "DELETE FROM servico WHERE idServico = '" + GridViewdados.SelectedRow.Cells[1].Text.Trim() + "';";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                lblmsg.Text = "Excluxão realizada com Sucesso!";
                Txtnom.Text = "";
                Txtnom.Enabled = false;
                databaseConnection.Close();
                carregarGrid();
            }
            catch (Exception ex)
            {
                lblmsg.Text = "Ocorreu algum erro e o registro não foi excluido!";
                //throw new Exception("Erro" + ex.Message);
            }
    }

        protected void Btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username= '" + login + "';password='" + senha + "';database=mobilidade;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                // Prepare the connection
                string query = "UPDATE servico SET nome = '" + Txtnom.Text.Trim() + "' where idServico = '" + GridViewdados.SelectedRow.Cells[1].Text.Trim() + "'";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                lblmsg.Text = "Registro Atualizado com Sucesso!";
                Txtnom.Text = "";
                Txtnom.Enabled = false;
                databaseConnection.Close();
                carregarGrid();
            }
            catch (Exception ex)
            {
                lblmsg.Text = "Ocorreu algum erro e o registro não foi atualizado!";
                //throw new Exception("Erro" + ex.Message);
            }
        }
    }
}