using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace tela.Imoveis
{
    public partial class frmaltimo : Form
    {
        public frmaltimo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void frmaltimo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrEmpty(lbconstr.Text) || string.IsNullOrEmpty(lbimovel.Text)
                 || string.IsNullOrEmpty(lbend.Text) || string.IsNullOrEmpty(lbcep.Text) || string.IsNullOrEmpty(lbfoto.ImageLocation))
                {
                    MessageBox.Show("Todos os campos em Vermelho devem ser preenchidos ", "Modificação de Imóveis",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.lbconstr.ForeColor = Color.Red;
                    this.lbtipimovel.ForeColor = Color.Red;
                    this.lbimovel.ForeColor = Color.Red;
                    this.lbend.ForeColor = Color.Red;
                    this.lbcep.ForeColor = Color.Red;
                    this.lbfoto.ForeColor = Color.Red;



                }

                else
                {
                  //  string connetionString = null;
                 //   SqlConnection cnn = default(SqlConnection);
                 //   SqlCommand cmd = default(SqlCommand);
                 //   string sql = null;

                    tela.Classes.banco banco = new tela.Classes.banco();
                    string bancos = banco.b2();

                   
                        
                        SqlConnection conn = new SqlConnection(bancos);

                        SqlCommand comm = new SqlCommand("");
                        comm.Connection = conn;
                        comm.CommandText =
                            // "UPDATE  Cliente  set (NomeCliente, CPF, RG, Filhos, email, CEP, telcon, Obs) " +
                            //                "VALUES             (@NomeCliente, @CPF, @RG, @Filhos, @email, @CEP, @telcon, @Obs)" +
                            //                "where CPF = cpf ";


                                           "UPDATE  Imoveis set NomConstrutora =  '" + this.lbconstr.Text + "', NomImovel =  '" + this.lbtipimovel.Text + "', TipoImovel =  '" + this.lbimovel + "', Endereco =  '" + this.lbend.Text + "', CEP =  '" + this.lbcep.Text + "', endimg =  '" + this.lbfoto.ImageLocation + "'  WHERE (CodImovel = '" + lblcod.Text + "')";

                                                

                        comm.Parameters.AddWithValue("@NomConstrutora", lbconstr.Text);
                        comm.Parameters.AddWithValue("@NomImovel", lbimovel.Text );
                        comm.Parameters.AddWithValue("@TipoImovel", lbtipimovel.SelectedItem.ToString());
                        comm.Parameters.AddWithValue("@Endereco", lbend.Text);
                        comm.Parameters.AddWithValue("@CEP", lbcep.Text);
                        comm.Parameters.AddWithValue("@endimg", lbfoto.ImageLocation);
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Imóvel Alerado com sucesso!", "Manutenção de Imóvel",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);        
                        this.Close();
                        
                        
                    }
                }
            
            catch (Exception)
            {
                throw;
            }
        }

        private void lbimovel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbt_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbconstr.Clear();
            lbend.Clear();
            lbcep.Clear();
            lbtipimovel.Text = "";
            lbimovel.Clear();
            // lbfoto validar;
        }
    }

        }
    

