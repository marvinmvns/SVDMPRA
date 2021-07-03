using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SVDMP_RA
{
    public partial class frmcodim : Form
    {
        string codigo;
        public frmcodim()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbcep.Text = "";
            lbconstr.Text = "";



        }

        private void frmcodim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sVDPMRADataSet.Imoveis' table. You can move, or remove it, as needed.
            this.imoveisTableAdapter.Fill(this.sVDPMRADataSet.Imoveis);
            btnapagar.Enabled = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbfoto.ImageLocation = dgimovel.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //cria um DataTabale
                    DataTable dt = new DataTable();
                    //define a string de conexão com o SQL Server
                    string strConn = @"Server =MVNS\sqlexpress;Database = SVDPMRA; Integrated Security = SSPI;";
                    //Abre a conexão
                    SqlConnection conn = new SqlConnection(strConn);


                    if (lbcep.Text != "")
                    {

                        SqlDataAdapter da = new SqlDataAdapter("Select * from Imoveis WHERE CEP = " + (lbcep.Text) + "", conn);
                        da.Fill(dt);
                    }
                    else
                    {
                        string constr = lbconstr.Text;
                        SqlDataAdapter da = new SqlDataAdapter("Select *  from Imoveis WHERE NomConstrutora  =  '" + constr + "'", conn);
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
                    lbcep.Text = "";
                    lbconstr.Text = "";

                    //exibe os dados no DataGridView
                    dgimovel.DataSource = dt.DefaultView;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal frm1 = (Principal)this.MdiParent;
            frm1.lbcodimo.Text = dgimovel.SelectedRows[0].Cells[0].Value.ToString(); 
            Principal frm2 = (Principal)this.MdiParent;
            frm2.tlnomeim.Text = dgimovel.SelectedRows[0].Cells[2].Value.ToString();
            MessageBox.Show("Imóvel Selecionado com Sucesso");
            this.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                
                codigo = dgimovel.SelectedRows[0].Cells[0].Value.ToString();
                
                string connetionString = null;
                SqlConnection cnn = default(SqlConnection);
                SqlCommand cmd = default(SqlCommand);
                string sql = null;
                tela.Classes.banco banco = new tela.Classes.banco();
                string bancos = banco.b2();
                connetionString = bancos;
                

                sql = "Delete from Plantas Where FK_CodImovel = " + (codigo) + "";
                
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.Dispose();
                string CODFR = Convert.ToString(cmd.ExecuteScalar());
                
                                
                
                sql = "Delete from Imoveis Where CodImovel = " + (codigo) + "";                
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.Dispose();
                string CODPL = Convert.ToString(cmd.ExecuteScalar());


                sql = "Delete from Imoveis Where CodImovel = " + (codigo) + "";               
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.Dispose();
                string CODFRA = Convert.ToString(cmd.ExecuteScalar());

                cnn.Close();

                if (codigo != "")
                {
                    MessageBox.Show("Imóvel Removido");
                    dgimovel.Refresh();
                    dgimovel.DataSource = sVDPMRADataSet;
                    btnapagar.Enabled = false;
                    dgimovel.DataSource = "";

                }
                else
                {
                    MessageBox.Show("Erro no Sistema");
                }



            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
          lbfoto.ImageLocation =  dgimovel.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void dgimovel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbfoto.ImageLocation = dgimovel.SelectedRows[0].Cells[6].Value.ToString();
            btnapagar.Enabled = true;
        }

        private void dgimovel_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbfoto.ImageLocation = dgimovel.SelectedRows[0].Cells[6].Value.ToString();
            
        }

        private void dgimovel_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //lbfoto.ImageLocation = dgimovel.SelectedRows[0].Cells[6].Value.ToString();
            //btnapagar.Enabled = true;
        }

        private void lbcep_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbcep_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void dgimovel_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            btnapagar.Enabled = false;
        }

        private void dgimovel_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            btnapagar.Enabled = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            // Cria um novo formulário 
            tela.Imoveis.frmaltimo frmAzul = new tela.Imoveis.frmaltimo();
            codigo = dgimovel.SelectedRows[0].Cells[0].Value.ToString();
            frmAzul.lblcod.Text   = dgimovel.SelectedRows[0].Cells[0].Value.ToString();
            frmAzul.lbconstr.Text = dgimovel.SelectedRows[0].Cells[1].Value.ToString();
            frmAzul.lbtipimovel.Text = dgimovel.SelectedRows[0].Cells[3].Value.ToString();
            frmAzul.lbimovel.Text = dgimovel.SelectedRows[0].Cells[2].Value.ToString();           
            frmAzul.lbend.Text = dgimovel.SelectedRows[0].Cells[4].Value.ToString();
            frmAzul.lbcep.Text = dgimovel.SelectedRows[0].Cells[5].Value.ToString();
            frmAzul.lbfoto.ImageLocation = dgimovel.SelectedRows[0].Cells[6].Value.ToString();
            
             // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
       
             frmAzul.ShowDialog();
            //cria um DataTabale
            DataTable dt = new DataTable();
            //define a string de conexão com o SQL Server
            string strConn = @"Server =MVNS\sqlexpress;Database = SVDPMRA; Integrated Security = SSPI;";
            //Abre a conexão
            SqlConnection conn = new SqlConnection(strConn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Imoveis WHERE CodImovel = " + (codigo) + "", conn);
            da.Fill(dt);
            dgimovel.DataSource = dt.DefaultView;

        }

        private void dgimovel_Click(object sender, EventArgs e)
        {
            lbfoto.ImageLocation = dgimovel.SelectedRows[0].Cells[6].Value.ToString();
            btnapagar.Enabled = true;
        }

        private void dgimovel_KeyDown(object sender, KeyEventArgs e)
        {
            lbfoto.ImageLocation = dgimovel.SelectedRows[0].Cells[6].Value.ToString();
            btnapagar.Enabled = true;
        }

        private void dgimovel_MouseClick(object sender, MouseEventArgs e)
        {
            lbfoto.ImageLocation = dgimovel.SelectedRows[0].Cells[6].Value.ToString();
            btnapagar.Enabled = true;
        }
    }
}

