using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobilidade.Paginas
{
    public partial class Locacao : System.Web.UI.Page
    {
        int tiposervico;
        int idusu;
        string login;
        string senha;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblmsg.Text = "";
            idusu = Convert.ToInt32(Session["Salvarid"].ToString());
            login = Convert.ToString(Session["Salvarnome"].ToString());
            senha = Convert.ToString(Session["Salvarsenha"].ToString());
            btnsalvar.Attributes.Add("onclick", "return valida_sugestao()");
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
            desabilitarCampos();
        }
        private void habilitarCampos()
        {
            DropDownnome.Enabled = true;
            txtcomnt.Enabled = true;
        }
        private void desabilitarCampos()
        {
            DropDownnome.Enabled = false;
            txtcomnt.Enabled = false;
        }
        private void limparCampos()
        {
            txtcomnt.Text = "";
        }

        protected void Dropdtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarCampos();
            Response.Write(DropDowntipo.SelectedItem.Text + DropDowntipo.SelectedValue);
            tiposervico = Convert.ToInt32(DropDowntipo.SelectedItem.Value);
            //conexão;
            string connectionString = "datasource=localhost;port=3306;username= '" + login + "';password='" + senha + "';database=mobilidade;";
            //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=locadora;";
            string query = "select * FROM servico where Tipo_Servico_idTipo_Servico = '" + tiposervico + "'";
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

        protected void btnsalvar_Click1(object sender, EventArgs e)
        {
            int idserv = Convert.ToInt32(DropDownnome.SelectedValue);
            try
            {
                string connectionString = "datasource=localhost;port=3306;username= '" + login + "';password='" + senha + "';database=mobilidade;";
                //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=locadora;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                // Prepare the connection
                MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO Comentario(Comentario, Usuario_idUsuario)" + "VALUES( '" + txtcomnt.Text.Trim() + "','" + idusu + "' )", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                int idcoment = Convert.ToInt32(commandDatabase.LastInsertedId);
                MySqlCommand commandDatabase2 = new MySqlCommand("INSERT INTO Sugestao(Comentario_idComentario, Servico_idServico)" + "VALUES( '" + idcoment + "', '" + idserv + "'  )", databaseConnection);
                commandDatabase2.CommandTimeout = 60;
                commandDatabase2.ExecuteNonQuery();
                lblmsg.Text = "Sugestão relatada com sucesso!";
                databaseConnection.Close();
                limparCampos();
                desabilitarCampos();

            }
            catch (Exception ex)
            {
                // Show any error message.
                lblmsg.Text = "Ocorreu algum erro, sugestão não pode ser salva!";
                throw new Exception("Erro" + ex.Message);
            }
        }     
    }
}
