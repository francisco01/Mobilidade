using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mobilidade.Paginas
{
    public partial class Inserir_estacao : System.Web.UI.Page
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
            desabilitaCampos();
            int tipo = Convert.ToInt16(DropDowntipo.SelectedValue);
            if ( tipo == 1)
            {
                liberaCamposAero();
            }
            else if (tipo == 2)
            {
                liberaCamposCiclo();
            }
            else if (tipo == 3)
            {
                liberaCamposMetro();
            }
            else if (tipo == 4)
            {
                liberaCamposVLT();
            }
            else if (tipo == 5)
            {
                liberaCamposBRT();
            }
            else
            {
                liberaCamposTrem();
            }

        }
        private void liberaCamposAero()
        {
            Txtnome.Enabled = true;
            Txtfone.Enabled = true;
            Txtcategoria.Enabled = true;
        }
        private void liberaCamposCiclo()
        {
            Txtnome.Enabled = true;
            Txtcomprm.Enabled = true;
        }
        private void liberaCamposMetro()
        {
            Txtnome.Enabled = true;
            Txtsuprf.Enabled = true;
            Txtbrt.Enabled = true;
            Txttrem.Enabled = true;
            Txtvlt.Enabled = true;
            Txtbus.Enabled = true;
        }
        private void liberaCamposTrem()
        {
            Txtnome.Enabled = true;
            Txtbus.Enabled = true;
            Txtbrt.Enabled = true;
        }
        private void liberaCamposBRT()
        {
            Txtnome.Enabled = true;
            Txtaero.Enabled = true;
            Txtmetro.Enabled = true;
            Txttrem.Enabled = true;
        }
        private void liberaCamposVLT()
        {
            Txtnome.Enabled = true;
            Txtaero.Enabled = true;
            Txtbarca.Enabled = true;
            Txttelef.Enabled = true;
            Txtmetro.Enabled = true;
        }
        private void desabilitaCampos()
        {
            Txtnome.Enabled = false;
            Txtaero.Enabled = false;
            Txtbarca.Enabled = false;
            Txttelef.Enabled = false;
            Txtmetro.Enabled = false;
            Txtbus.Enabled = false;
            Txtbrt.Enabled = false;
            Txtcomprm.Enabled = false;
            Txtfone.Enabled = false;
            Txtcategoria.Enabled = false;
            Txtsuprf.Enabled = false;
            Txttrem.Enabled = false;
            Txtvlt.Enabled = false;
        }
        private void limparCampos()
        {
            Txtnome.Text = "";
            Txtaero.Text = "";
            Txtbarca.Text = "";
            Txttelef.Text = "";
            Txtmetro.Text = "";
            Txtbus.Text = "";
            Txtbrt.Text = "";
            Txtcomprm.Text = "";
            Txtfone.Text = "";
            Txtcategoria.Text = "";
            Txtsuprf.Text = "";
            Txttrem.Text = "";
            Txtvlt.Text = "";
        }

        protected void Btnsalvar_Click(object sender, EventArgs e)
        {
            inserirServico();
        }
        private void inserirServico()
        {
            string tabela = DropDowntipo.SelectedItem.Text.Trim();
            int tipo = Convert.ToInt16(DropDowntipo.SelectedValue.Trim());
            try
            {
                string connectionString = "datasource=localhost;port=3306;username= '" + login + "';password='" + senha + "';database=mobilidade;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                // Prepare the connection
                string query = "INSERT INTO Servico(Nome, Tipo_Servico_idTipo_Servico)" + "Values('" + Txtnome.Text.Trim() + "', '" + DropDowntipo.SelectedValue.Trim() + "')";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                long ultimoid = commandDatabase.LastInsertedId;
                //lblmsg.Text = "Dados incluidos com sucesso!";
                databaseConnection.Close();
                if (tipo == 1)
                {
                    inserirAero(ultimoid, tabela);
                }
                else if (tipo == 2)
                {
                    inserirCiclo(ultimoid, tabela);
                }
                else if (tipo == 3)
                {
                    inserirMetro(ultimoid, tabela);
                }
                else if (tipo == 4)
                {
                    inserirVLT(ultimoid, tabela);
                }
                else if (tipo == 5)
                {
                    inserirBRT(ultimoid, tabela);
                }
                else
                {
                    inserirTrem(ultimoid, tabela);
                }

            }
            catch (Exception ex)
            {
                //throw new Exception("Erro" + ex.Message);
                Console.WriteLine("Erro" + ex.Message);
            }
        }
        private void inserirAero(long idservico, string tbl)
        {
           
            try
            {
                string connectionString = "datasource=localhost;port=3306;username= '" + login + "';password='" + senha + "';database=mobilidade;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                // Prepare the connection
                string query = "INSERT INTO " + tbl + " (Categoria, Telefone, Servico_idServico)" + "Values('" + Txtcategoria.Text.Trim() + "', '" + Txtfone.Text.Trim() + "', '" + idservico + "')";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                lblmsg.Text = "Dados incluidos com sucesso!";
                databaseConnection.Close();
                desabilitaCampos();
                limparCampos();

            }
            catch (Exception ex)
            {
                //throw new Exception("Erro" + ex.Message);
                Console.WriteLine("Erro" + ex.Message);
            }
        }
        private void inserirCiclo(long idservico, string tbl)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;username= '" + login + "';password='" + senha + "';database=mobilidade;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                // Prepare the connection
                string query = "INSERT INTO " + tbl + " (Comprimento, Servico_idServico)" + "Values('" + Txtcomprm.Text.Trim() + "', '" + idservico + "')";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                lblmsg.Text = "Dados incluidos com sucesso!";
                databaseConnection.Close();
                desabilitaCampos();
                limparCampos();
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro" + ex.Message);
                Console.WriteLine("Erro" + ex.Message);
            }
        }
        private void inserirBRT(long idservico, string tbl)
        {

            try
            {
                string connectionString = "datasource=localhost;port=3306;username= '" + login + "';password='" + senha + "';database=mobilidade;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                // Prepare the connection
                string query = "INSERT INTO " + tbl + " (Integra_Aero, Integra_Metro, Integra_Trem, Servico_idServico)" + "Values('" + Txtaero.Text.Trim() + "', '" + Txtmetro.Text.Trim() + "', '" + Txttrem.Text.Trim() + "','" + idservico + "')";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                lblmsg.Text = "Dados incluidos com sucesso!";
                databaseConnection.Close();
                desabilitaCampos();
                limparCampos();
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro" + ex.Message);
                Console.WriteLine("Erro" + ex.Message);
            }
        }
        private void inserirVLT(long idservico, string tbl)
        {

            try
            {
                string connectionString = "datasource=localhost;port=3306;username= '" + login + "';password='" + senha + "';database=mobilidade;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                // Prepare the connection
                string query = "INSERT INTO " + tbl + " (Integra_Aero, Integra_Barca, Integra_Teleferico, Integra_Metro, Servico_idServico)" + "Values('" + Txtaero.Text.Trim() + "', '" + Txtbarca.Text.Trim() + "', '" + Txttelef.Text.Trim() + "', '" + Txtmetro.Text.Trim() + "' ,'" + idservico + "')";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                lblmsg.Text = "Dados incluidos com sucesso!";
                databaseConnection.Close();
                desabilitaCampos();
                limparCampos();
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro" + ex.Message);
                Console.WriteLine("Erro" + ex.Message);
            }
        }
        private void inserirTrem(long idservico, string tbl)
        {

            try
            {
                string connectionString = "datasource=localhost;port=3306;username= '" + login + "';password='" + senha + "';database=mobilidade;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                // Prepare the connection
                string query = "INSERT INTO " + tbl + " (Integra_Onibus, Integra_Brt, Servico_idServico)" + "Values('" + Txtbus.Text.Trim() + "', '" + Txtbrt.Text.Trim() + "', '" + idservico + "')";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                lblmsg.Text = "Dados incluidos com sucesso!";
                databaseConnection.Close();
                desabilitaCampos();
                limparCampos();
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro" + ex.Message);
                Console.WriteLine("Erro" + ex.Message);
            }
        }
        private void inserirMetro(long idservico, string tbl)
        {

            try
            {
                string connectionString = "datasource=localhost;port=3306;username= '" + login + "';password='" + senha + "';database=mobilidade;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                // Prepare the connection
                string query = "INSERT INTO " + tbl + " (Metro_Superficie, Integra_Brt, Integra_Trem, Integra_Vlt, Integra_Onibus, Servico_idServico)" + "Values('" + Txtsuprf.Text.Trim() + "', '" + Txtbrt.Text.Trim() + "',  '" + Txttrem.Text.Trim() + "', '" + Txtvlt.Text.Trim() + "', '" + Txtbus.Text.Trim() + "' ,'" + idservico + "')";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
                lblmsg.Text = "Dados incluidos com sucesso!";
                databaseConnection.Close();
                desabilitaCampos();
                limparCampos();
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro" + ex.Message);
                Console.WriteLine("Erro" + ex.Message);
            }
        }

    }
}