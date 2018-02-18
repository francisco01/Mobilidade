using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobilidade.Paginas
{
    public partial class ConsultaClientes : System.Web.UI.Page
    {
        int tiposervico;
        int idusu;
        string login;
        string senha;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblacao.Text = "";
            idusu = Convert.ToInt32(Session["Salvarid"].ToString());
            login = Convert.ToString(Session["Salvarnome"].ToString());
            senha = Convert.ToString(Session["Salvarsenha"].ToString());
            btngravar.Attributes.Add("onclick", "return valida_avaliacao()");
            if (!IsPostBack)
            {
                carregarDados();
                
            }
        }
        private void carregarDados()
        {
            //conexão;
            string connectionString = "datasource=localhost;port=3306;username= '"+login+ "';password='"+senha+"';database=mobilidade;";
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
            habilitarCampos();
        }
        private void habilitarCampos()
        {
            DropDownnome.Enabled = true;
            txtnota.Enabled = true;
            txtcoment.Enabled = true;
            btngravar.Enabled = true;
        }
        private void desabilitaCampos()
        {
            DropDownnome.Enabled = false;
            txtnota.Enabled = false;
            txtcoment.Enabled = false;
            btngravar.Enabled = false;
        }
        private void limparCampos()
        {
            //DropDowntipo.Text = "";
            DropDownnome.Enabled = false;
            txtnota.Text = "";
            txtcoment.Text = "";
            //lblacao.Text = "";
        }

        protected void btngravar_Click(object sender, EventArgs e)
        {
            int idserv = Convert.ToInt32(DropDownnome.SelectedValue);
            try
            {
                string connectionString = "datasource=localhost;port=3306;username= '" + login + "';password='" + senha + "';database=mobilidade;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                // Prepare the connection
                string query = "INSERT INTO avalia(Nota, Comentario, Usuario_idUsuario, Servico_idServico)" + "Values('" + txtnota.Text.Trim()+"', '"+ txtcoment.Text.Trim()+"', '"+idusu+"', '"+ idserv + "')";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                lblacao.Text = "Dados incluidos com sucesso!";
                databaseConnection.Close();
                //desabilitaCampos();
                //carregarDados();
                limparCampos();
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro" + ex.Message);
                Console.WriteLine("Erro" + ex.Message);
            }
        }

        protected void DropDowntipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownnome.Enabled = true;
            Response.Write(DropDowntipo.SelectedItem.Text + DropDowntipo.SelectedValue);
            tiposervico = Convert.ToInt32( DropDowntipo.SelectedItem.Value);
            //conexão;
            string connectionString = "datasource=localhost;port=3306;username= '" + login + "';password='" + senha + "';database=mobilidade;";
            //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=locadora;";
            string query = "select * FROM servico where Tipo_Servico_idTipo_Servico = '"+tiposervico+"'";
            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                DropDownnome.DataSource = reader;
                DropDownnome.DataValueField = "idServico";
                DropDownnome.DataTextField = "Nome";
                DropDownnome.DataBind();
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}