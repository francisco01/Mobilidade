using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobilidade.Paginas
{
    public partial class ConsultaLocacao : System.Web.UI.Page
    {
        int tiposervico;
        int idusu;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblmsg.Text = "";
            idusu = Convert.ToInt32(Session["Salvarid"].ToString());
            txtdata.Attributes.Add("onkeypress", "Mascaradt(this)");
            btnSalvar.Attributes.Add("onclick", "return valida_problema()");
            if (!IsPostBack)
            {
                carregarDados();
                carregarDadosprob();
            }
        }
        private void carregarDados()
        {
            //conexão;
            string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mobilidade;";
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
        private void carregarDadosprob()
        {
            //conexão;
            string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mobilidade;";
            //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=locadora;";
            string query = "select idTipo_Problema, Tipo_Problema FROM tipo_problema order by idTipo_Problema";
            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                DropDownprobl.DataSource = reader;
                DropDownprobl.DataValueField = "idTipo_Problema";
                DropDownprobl.DataTextField = "Tipo_Problema";
                DropDownprobl.DataBind();
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void habilitarCampos()
        {
            DropDownnome.Enabled = true;
            txtdata.Enabled = true;
            txtcomnt.Enabled = true;
            DropDownprobl.Enabled = true;
        }
        private void desabilitarCampos()
        {
            DropDownnome.Enabled = false;
            txtdata.Enabled = false;
            txtcomnt.Enabled = false;
            DropDownprobl.Enabled = false;
        }
        private void limparCampos()
        {
            txtcomnt.Text = "";
            txtdata.Text = "";
        }

        protected void dpltipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarCampos();
            Response.Write(DropDowntipo.SelectedItem.Text + DropDowntipo.SelectedValue);
            tiposervico = Convert.ToInt32(DropDowntipo.SelectedItem.Value);
            //conexão;
            string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mobilidade;";
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

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            int idserv = Convert.ToInt32(DropDownnome.SelectedValue);
            int idtpprobl = Convert.ToInt32(DropDownprobl.SelectedValue);
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mobilidade;";
                //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=locadora;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                // Prepare the connection
                MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO Comentario(Comentario, Usuario_idUsuario)" + "VALUES( '" + txtcomnt.Text.Trim() + "','" + idusu + "' )", databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                int idcoment = Convert.ToInt32(commandDatabase.LastInsertedId);
                MySqlCommand commandDatabase2 = new MySqlCommand("INSERT INTO Problema(Data_Ocorrencia, Tipo_Problema_idTipo_Problema, Comentario_idComentario, Servico_idServico)" + "VALUES( '" + txtdata.Text.Trim() + "', '" + idtpprobl + "','" + idcoment + "', '" + idserv + "'  )", databaseConnection);
                commandDatabase2.CommandTimeout = 60;
                commandDatabase2.ExecuteNonQuery();
                lblmsg.Text = "Problema relatado com sucesso!";
                databaseConnection.Close();
                limparCampos();
                desabilitarCampos();

            }
            catch (Exception ex)
            {
                // Show any error message.
                lblmsg.Text = "Ocorreu algum erro, problema não pode ser salvo!";
                throw new Exception("Erro" + ex.Message);
            }
        }

        /* protected void gridloc_SelectedIndexChanged(object sender, EventArgs e)
         {
             try
             {
                 string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=locadora;";
                 //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=locadora;";
                 MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                 databaseConnection.Open();
                 // Prepare the connection
                 int status = 1;
                 MySqlCommand commandDatabase2 = new MySqlCommand("update veiculo set vcl_status = '" + status + "' where vcl_placa = '" + gridloc.SelectedRow.Cells[1].Text.Trim() + "'", databaseConnection);
                 commandDatabase2.CommandTimeout = 60;
                 commandDatabase2.ExecuteNonQuery();
                 databaseConnection.Close();
                 //string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=locadora;";
                 //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=locadora;";
                 string query = "select clt_cnh from locacao where vcl_placa = '" + gridloc.SelectedRow.Cells[1].Text.Trim() + "'";
                 // MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                 databaseConnection = new MySqlConnection(connectionString);
                 MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

                 commandDatabase.CommandTimeout = 60;
                 databaseConnection.Open();
                 // Prepare the connection

                 //databaseConnection.Open();
                 //reader = commandDatabase.ExecuteReader();
                 Object retorno = commandDatabase.ExecuteScalar();
                 String aux = Convert.ToString(retorno);
                 int loc = 1;
                 MySqlCommand commandDatabase3 = new MySqlCommand("update cliente set clt_loc = '" + loc + "' where clt_cnh = '" + aux.Trim() + "'", databaseConnection);
                 commandDatabase3.CommandTimeout = 60;
                 commandDatabase3.ExecuteNonQuery();
                 lblmsg.Text = "O carro foi entregue!";
                 databaseConnection.Close();
                 carregarDados();

             }
             catch (Exception ex)
             {
                 // Show any error message.
                 lblmsg.Text = "Ocorreu algum erro, o carro não foi entregue!";
                 //throw new Exception("Erro" + ex.Message);
             }
         }*/

    }
}