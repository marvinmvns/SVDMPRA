using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using tela;
  




namespace tela.Móveis
{
    public partial class frmmovcons : Form
    {
        public frmmovcons()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //cria um DataTabale
                    DataTable dt = new DataTable();
                    //define a string de conexão com o SQL Server
                    tela.Classes.banco banco = new tela.Classes.banco();
                    string bancos = banco.b2();
                   
                    string strConn = bancos;
                    //Abre a conexão
                    SqlConnection conn = new SqlConnection(strConn);

                    string constr2 = lbnomemovel.Text;
                    if (lbnomemovel.Text != "")
                    {

                        SqlDataAdapter da = new SqlDataAdapter("Select * from Moveis WHERE NomMovel = '" + lbnomemovel.Text + "'", conn);
                        da.Fill(dt);
                    }
                    else
                    {
                        string constr = xctipo.Text;
                        SqlDataAdapter da = new SqlDataAdapter("Select *  from Moveis WHERE TipMovel  =  '" + constr + "'", conn);
                        da.Fill(dt);
                    }

                    //cria um DataAdapter selecionando os dados de um tabela do SQL Server
                    //SqlDataAdapter da = new SqlDataAdapter("Select * from Cliente WHERE CPF = "+(consulta.text)+" or RG = "+(lbrg.Text)+" or CodCliente = "+(lbcodcli.Text)+"",conn);

                    //conn.Parameters.AddWithValue("@NomeCliente", lbcodcli.Text); 
                    //conn.Parameters.AddWithValue("@CodCliente", lbcodcli.Text);
                    //conn.Parameters.AddWithValue("@CPF", lbcpf.Text);
                    //conn.Parameters.AddWithValue("@RG", lbrg.Text);
                    //preenche o DataTable
                    //da.Fill(dt);
                   

                    //exibe os dados no DataGridView
                    dgmovel.DataSource = dt.DefaultView;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }

            }

        }

        private void frmmovcons_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sVDPMRADataSet5.Moveis' table. You can move, or remove it, as needed.
            this.moveisTableAdapter.Fill(this.sVDPMRADataSet5.Moveis);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string codigo;
                codigo = dgmovel.SelectedRows[0].Cells[0].Value.ToString();
                string connetionString = null;
                SqlConnection cnn = default(SqlConnection);
                SqlCommand cmd = default(SqlCommand);
                string sql = null;
                tela.Classes.banco banco = new tela.Classes.banco();
                string bancos = banco.b2();
                connetionString = bancos;
                

                sql = "Delete from Moveis Where CodMovel = " + (codigo) + "";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.Dispose();
                string CODFR = Convert.ToString(cmd.ExecuteScalar());




                //sql = "Delete from Imoveis Where CodImovel = " + (codigo) + "";
               // MessageBox.Show(sql);
               // cnn = new SqlConnection(connetionString);
               // cnn.Open();
               // cmd = new SqlCommand(sql, cnn);
              //  cmd.Dispose();
              //  string codigo = Convert.ToString(cmd.ExecuteScalar());


              //  sql = "Delete from Imoveis Where CodImovel = " + (codigo) + "";
              //  MessageBox.Show(sql);
              //  cnn = new SqlConnection(connetionString);
              //  cnn.Open();
              //  cmd = new SqlCommand(sql, cnn);
              //  cmd.Dispose();
              //  string CODFRA = Convert.ToString(cmd.ExecuteScalar());

                cnn.Close();

                if (codigo != "")
                {
                    MessageBox.Show("Móvel Removido");
                    dgmovel.Refresh();
                    btnapagar.Enabled = false;
                    dgmovel.DataSource = "";
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Erro no Sistema");
                }



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


            int rxv, ryv, rzv, exv, eyv, ezv, txv, tyv, tzv;
            string marcador, tresd;

            tela.Classes.RA novo = new tela.Classes.RA();
            novo.RAC();


            txv = Convert.ToInt32(dgmovel.SelectedRows[0].Cells[3].Value.ToString());
            tyv = Convert.ToInt32(dgmovel.SelectedRows[0].Cells[4].Value.ToString());
            tzv = Convert.ToInt32(dgmovel.SelectedRows[0].Cells[5].Value.ToString());
            exv = Convert.ToInt32(dgmovel.SelectedRows[0].Cells[6].Value.ToString());
            eyv = Convert.ToInt32(dgmovel.SelectedRows[0].Cells[7].Value.ToString());
            ezv = Convert.ToInt32(dgmovel.SelectedRows[0].Cells[8].Value.ToString());
            rxv = Convert.ToInt32(dgmovel.SelectedRows[0].Cells[9].Value.ToString());
            ryv = Convert.ToInt32(dgmovel.SelectedRows[0].Cells[10].Value.ToString());
            rzv = Convert.ToInt32(dgmovel.SelectedRows[0].Cells[11].Value.ToString());
            tresd = dgmovel.SelectedRows[0].Cells[13].Value.ToString();
            int rrv = 1;
            marcador = System.Environment.GetEnvironmentVariable("SystemDrive") + @"\SVDMPRA\Sistema\patt.teste";
            MessageBox.Show("Teste gerado com sucesso, executando...");


                novo.RAC();               
                novo.RAGERA(1, marcador, txv, tyv, tzv, exv, eyv, ezv, rxv, ryv, rzv, rrv, tresd);
                novo.ChamaRA();

            
        }
           
            
            

      

            private void dgmovel_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                lbfoto.ImageLocation = dgmovel.SelectedRows[0].Cells[14].Value.ToString();
            }

            private void button1_Click(object sender, EventArgs e)
            {

            }

            private void xctipo_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void frmmovcons_KeyDown(object sender, KeyEventArgs e)
            {
                lbfoto.ImageLocation = dgmovel.SelectedRows[0].Cells[14].Value.ToString();
            }

            private void dgmovel_Click(object sender, EventArgs e)
            {
                lbfoto.ImageLocation = dgmovel.SelectedRows[0].Cells[14].Value.ToString();
            }

            private void dgmovel_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
                lbfoto.ImageLocation = dgmovel.SelectedRows[0].Cells[14].Value.ToString();
            }

            private void dgmovel_KeyDown(object sender, KeyEventArgs e)
            {
                lbfoto.ImageLocation = dgmovel.SelectedRows[0].Cells[14].Value.ToString();
            }

            private void dgmovel_KeyPress(object sender, KeyPressEventArgs e)
            {
                lbfoto.ImageLocation = dgmovel.SelectedRows[0].Cells[14].Value.ToString();
            }
        }
    }

