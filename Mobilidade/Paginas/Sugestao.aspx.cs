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
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtplaca.Attributes.Add("onkeypress", "Mascaraplaca(this)");
            //txtdtfim.Attributes.Add("onkeypress", "Mascaradt(this)");
            //txtdtini.Attributes.Add("onkeypress", "Mascaradt(this)");
            //btnlocar.Attributes.Add("onclick", "valida_form_loc()");
            lblmsg.Text = "";
            idusu = Convert.ToInt32(Session["Salvarid"].ToString());
            if (!IsPostBack)
            {
                carregarDados();
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
                Dropdtipo.DataSource = reader;
                Dropdtipo.DataValueField = "idTipo_Servico";
                Dropdtipo.DataTextField = "Tipo_Servico";
                Dropdtipo.DataBind();
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
            Dropdnome.Enabled = true;
            txtcoment.Enabled = true;
        }
        private void desabilitarCampos()
        {
            Dropdnome.Enabled = false;
            txtcoment.Enabled = false;
        }
        private void limparCampos()
        {
            txtcoment.Text = "";
        }

        protected void Dropdtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarCampos();
            Response.Write(Dropdtipo.SelectedItem.Text + Dropdtipo.SelectedValue);
            tiposervico = Convert.ToInt32(Dropdtipo.SelectedItem.Value);
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
                Dropdnome.DataSource = reader;
                Dropdnome.DataValueField = "idServico";
                Dropdnome.DataTextField = "Nome";
                Dropdnome.DataBind();
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        protected void btnsalvar_Click1(object sender, EventArgs e)
        {
            int idserv = Convert.ToInt32(Dropdnome.SelectedValue);
            try
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=mobilidade;";
                //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=locadora;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                // Prepare the connection
                MySqlCommand commandDatabase = new MySqlCommand("INSERT INTO Comentario(Comentario, Usuario_idUsuario)" + "VALUES( '" + txtcoment.Text.Trim() + "','" + idusu + "' )", databaseConnection);
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

        /*   private bool verificaPlaca(string placa)
           {
               string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=locadora;";
               //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=locadora;";
               string query = "select vcl_placa from veiculo where vcl_placa = '"+placa+"'";

               MySqlConnection databaseConnection = new MySqlConnection(connectionString);
               MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

               // Prepare the connection
               commandDatabase.CommandTimeout = 60;
               MySqlDataReader reader;
               try
               {
                   databaseConnection.Open();
                   reader = commandDatabase.ExecuteReader();

                   if (reader.HasRows)
                   {
                       return true;
                   }
                   else
                   {
                       this.lblmsg.Text = "Não existe veículo cadastrado com esta placa !! ";
                       return false;
                   }
               }
               catch (Exception ex)
               {
                   this.lblmsg.Text = "Erro de verificação da placa! ";
                   //Console.WriteLine(ex.Message);
                   return false;
               }
               finally
               {
                   databaseConnection.Close();
               }
           }

           private bool verificaCnh(string cnh)
           {
               string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=locadora;";
               //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=locadora;";
               string query = "select clt_cnh from cliente where clt_cnh = '"+cnh+"'";

               MySqlConnection databaseConnection = new MySqlConnection(connectionString);
               MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

               commandDatabase.CommandTimeout = 60;
               MySqlDataReader reader;
               try
               {
                   databaseConnection.Open();
                   reader = commandDatabase.ExecuteReader();

                   if (reader.HasRows)
                   {
                       return true;
                   }
                   else
                   {
                       this.lblmsg.Text = this.lblmsg.Text + "  " + "Não existe cliente cadastrado com este cnh !! ";
                       return false;

                   }
               }
               catch (Exception ex)
               {
                   this.lblmsg.Text = "Erro de verificação cnh!";
                   //Console.WriteLine(ex.Message);
                   return false;
               }
               finally
               {
                   databaseConnection.Close();
               }
           }
           private bool verificaStatus()
           {
               string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=locadora;";
               //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=locadora;";
               string query = "select vcl_status from veiculo where vcl_placa = '"+txtplaca.Text.Trim()+"'";

               MySqlConnection databaseConnection = new MySqlConnection(connectionString);
               MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

               // Prepare the connection
               // MySqlCommand commandDatabase = new MySqlCommand("SELECT * FROM cliente WHERE clt_cnh = ' " + txtcnh.Text + "')", databaseConnection);
               commandDatabase.CommandTimeout = 60;
               MySqlDataReader reader;
               try
               {
                   databaseConnection.Open();
                   //reader = commandDatabase.ExecuteReader();
                   Object retorno = commandDatabase.ExecuteScalar();
                   int aux = Convert.ToInt16(retorno);
                   if (aux == 1)
                   {
                       return true;
                   }
                   else
                   {
                       this.lblmsg.Text = "Veiculo já está locado !! ";
                       return false;
                   }
               }
               catch (Exception ex)
               {
                   this.lblmsg.Text = "Erro de verificação!";
                   // Console.WriteLine(ex.Message);
                   return false;
               }
               finally
               {
                   databaseConnection.Close();
               }
           }
           private void getValor(string placa)
           {
               string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=locadora;";
               //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=locadora;";
               string query = "select vcl_valor from veiculo where vcl_placa = '"+placa+"'";

               MySqlConnection databaseConnection = new MySqlConnection(connectionString);
               MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

               // Prepare the connection
               commandDatabase.CommandTimeout = 60;
               MySqlDataReader reader;
               try
               {
                   databaseConnection.Open();
                   //reader = commandDatabase.ExecuteReader();
                   Object retorno = commandDatabase.ExecuteScalar();
                   double aux = Convert.ToDouble(retorno);
                   DateTime dtf, dti;
                  // dti = DateTime.Parse(txtdtini.Text);
                   //dtf = DateTime.Parse(txtdtfim.Text);
                  // DateTime calculaDias = new DateTime(dtf.Year, dtf.Month, dtf.Day);
                   //int dias = (int)calculaDias.Subtract(dti).TotalDays;
                   //aux = aux * dias;
                   //txtpreco.Text = Convert.ToString(aux);
                  // lblrs.Visible = true;
               }
               catch (Exception ex)
               {
                   Console.WriteLine(ex.Message);
               }
               finally
               {
                   databaseConnection.Close();
               }
           }

           protected void txtdtfim_TextChanged(object sender, EventArgs e)
           {

           }
           private bool verificaCnhLoc(string cnh)
           {
               string connectionString = "datasource=localhost;port=3306;username=root;password=s3t3mbr0;database=locadora;";
               //string connectionString = "datasource=localhost;port=3306;username=root;password=;database=locadora;";
               string query = "select clt_loc from cliente where clt_cnh = '" + cnh + "'";

               MySqlConnection databaseConnection = new MySqlConnection(connectionString);
               MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

               commandDatabase.CommandTimeout = 60;
               try
               {
                   databaseConnection.Open();
                   Object retorno = commandDatabase.ExecuteScalar();
                   int aux = Convert.ToInt16(retorno);

                   if (aux == 1)
                   {
                       return true;
                   }
                   else
                   {
                       this.lblmsg.Text = this.lblmsg.Text + "  " + "Cnh já possui um carro locado !! ";
                       return false;

                   }
               }
               catch (Exception ex)
               {
                   this.lblmsg.Text = "Erro de verificação cnh!";
                   //Console.WriteLine(ex.Message);
                   return false;
               }
               finally
               {
                   databaseConnection.Close();
               }
           }*/
    }
}
