using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using Correios.Net;


namespace Canta_Brasil_PROJ
{
   
    public partial class Form1 : Form
    {

        string connectionString = @"Server=.\sqlexpress;Database=CantaBrasilDB;Trusted_Connection=True;";
        bool novo;
        public Form1()
        {
            InitializeComponent();
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            mskCep.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUf.Enabled = false;
            txtComplemento.Enabled = false;
            mskTelefone.Enabled = false;
            mskTelefone2.Enabled = false;
            mskEmail.Enabled = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tstId.Enabled = false;
            tsbBuscar.Enabled = true;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            mskCep.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUf.Enabled = false;
            txtComplemento.Enabled = false;
            mskTelefone.Enabled = false;
            mskTelefone2.Enabled = false;
            mskEmail.Enabled = false;
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled = false;
            tsbSalvar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbExcluir.Enabled = false;
            tstId.Enabled = false;
            tsbBuscar.Enabled = false;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            mskCep.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtUf.Enabled = true;
            txtComplemento.Enabled = true;
            mskTelefone.Enabled = true;
            mskTelefone2.Enabled = true;
            mskEmail.Enabled = true;
            txtNome.Focus();
            novo = true;
        }
        

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                string sql = "INSERT INTO alunos(nome, endereco, numero, cep, bairro, cidade, uf, complemento, tel1, tel2, email) "
      + "VALUES ('" + txtNome.Text + "', '" + txtEndereco.Text + "', '" + txtNumero.Text.Trim() + "', '"
      + mskCep.Text.Trim() + "', '" + txtBairro.Text
      + "', '" + txtCidade.Text + "', '" + txtUf.Text + "', '" + txtComplemento.Text + "', '"
      + mskTelefone.Text.Trim() + "', '" + mskTelefone2.Text.Trim() + "', '"
      + mskEmail.Text + "')";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                string sql = "UPDATE alunos SET nome='" + txtNome.Text + "', endereco = '" + txtEndereco.Text + "', numero = '" + txtNumero.Text + "', " + "cep='" + mskCep.Text.Trim() + "', bairro='" + txtBairro.Text + "',cidade = '" + txtCidade.Text + "', " + "uf='" + txtUf.Text + "', " + "complemento='" + txtComplemento.Text + "', tel1='" + mskTelefone.Text.Trim() + "', tel2='" + mskTelefone2.Text.Trim() + "', email='" + mskEmail.Text + "' WHERE id= " + tstId.Text ;
        
        SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro atualizado com sucesso!");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }

            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tstId.Enabled = false;
            tsbBuscar.Enabled = true;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            mskCep.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUf.Enabled = false;
            txtComplemento.Enabled = false;
            mskTelefone.Enabled = false;
            mskTelefone2.Enabled = false;
            mskEmail.Enabled = false;
            tstId.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            mskCep.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            txtComplemento.Text = "";
            mskTelefone.Text = "";
            mskTelefone2.Text = "";
            mskEmail.Text = "";
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            const string msgDel =
        "Tem certeza que quer Excluir esse cadastro?";
            const string captionDel = "Excluir cadastro";
            var result = MessageBox.Show(msgDel, captionDel,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sql = "DELETE FROM alunos WHERE ID=" + tstId.Text;

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro excluído com sucesso!");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                tsbNovo.Enabled = true;
                tsbSalvar.Enabled = false;
                tsbCancelar.Enabled = false;
                tsbExcluir.Enabled = false;
                tstId.Enabled = false;
                tsbBuscar.Enabled = true;
                txtNome.Enabled = false;
                txtEndereco.Enabled = false;
                txtNumero.Enabled = false;
                mskCep.Enabled = false;
                txtBairro.Enabled = false;
                txtCidade.Enabled = false;
                txtUf.Enabled = false;
                txtComplemento.Enabled = false;
                mskTelefone.Enabled = false;
                mskTelefone2.Enabled = false;
                mskEmail.Enabled = false;
                tstId.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtNumero.Text = "";
                mskCep.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtUf.Text = "";
                txtComplemento.Text = "";
                mskTelefone.Text = "";
                mskTelefone2.Text = "";
                mskEmail.Text = "";
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            const string msgCancel =
        "Tem certeza que quer cancelar a criação do cadastro? Todos os dados não salvos serão perdidos.";
            const string captionCancel = "Cancelar a criação do cadastro";
            var result = MessageBox.Show(msgCancel, captionCancel,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                tsbNovo.Enabled = true;
                tsbSalvar.Enabled = false;
                tsbCancelar.Enabled = false;
                tsbExcluir.Enabled = false;
                tstId.Enabled = false;
                tsbBuscar.Enabled = true;
                txtNome.Enabled = false;
                txtEndereco.Enabled = false;
                txtNumero.Enabled = false;
                mskCep.Enabled = false;
                txtBairro.Enabled = false;
                txtCidade.Enabled = false;
                txtUf.Enabled = false;
                txtComplemento.Enabled = false;
                mskTelefone.Enabled = false;
                mskTelefone2.Enabled = false;
                mskEmail.Enabled = false;
                tstId.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtNumero.Text = "";
                mskCep.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtUf.Text = "";
                txtComplemento.Text = "";
                mskTelefone.Text = "";
                mskTelefone2.Text = "";
                mskEmail.Text = "";
            } 
            
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * From dbo.alunos WHERE " + comboBox1.Text + " LIKE '%"+ Pesquisa.Text +"%' ";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tsbNovo.Enabled = false;
                    tsbSalvar.Enabled = true;
                    tsbCancelar.Enabled = true;
                    tsbExcluir.Enabled = true;
                    tstId.Enabled = false;
                    tsbBuscar.Enabled = true;
                    txtNome.Enabled = true;
                    txtEndereco.Enabled = true;
                    txtNumero.Enabled = true;
                    mskCep.Enabled = true;
                    txtBairro.Enabled = true;
                    txtCidade.Enabled = true;
                    txtUf.Enabled = true;
                    txtComplemento.Enabled = true;
                    mskTelefone.Enabled = true;
                    mskTelefone2.Enabled = true;
                    mskEmail.Enabled = true;
                    txtNome.Focus();
                    tstId.Text = reader[0].ToString();
                    txtNome.Text = reader[1].ToString();
                    txtEndereco.Text = reader[2].ToString();
                    txtNumero.Text = reader[4].ToString();
                    mskCep.Text = reader[3].ToString();
                    txtBairro.Text = reader[5].ToString();
                    txtCidade.Text = reader[6].ToString();
                    txtUf.Text = reader[7].ToString();
                    txtComplemento.Text = reader[11].ToString();
                    mskTelefone.Text = reader[8].ToString();
                    mskTelefone2.Text = reader[9].ToString();
                    mskEmail.Text = reader[10].ToString();
                    novo = false;
                }
                else
                    MessageBox.Show("Nenhum registro encontrado!");
       
     }
            catch (System.Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tsbNovo_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnBuscaCep_Click(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        private void LocalizarCEP()
        {
            try 
            { 

            if (!string.IsNullOrWhiteSpace(mskCep.Text))
            {
                Address endereco = SearchZip.GetAddress(mskCep.Text.Trim());
                if (endereco.Zip != null)
                {


                        txtUf.Text = endereco.State;
                        txtCidade.Text = endereco.City;
                        txtBairro.Text = endereco.District;
                        txtEndereco.Text = endereco.Street;
                    
                    
                }
                else
                {
                    MessageBox.Show("Cep não localizado...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido");
            }

            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
