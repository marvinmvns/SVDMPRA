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
    public partial class frmclicon : Form
    {
        string CPF;
        public frmclicon()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

                

                  if  (lbcpf.Text != "")
                  {               
                
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Cliente WHERE CPF = " + (lbcpf.Text) + "", conn);
                    da.Fill(dt);
                }
                else if (lbrg.Text != "")
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Cliente WHERE RG = " + (lbrg.Text) + "", conn);
                    da.Fill(dt);
                }
                else if (lbcodcli.Text != "")
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Cliente WHERE CodCliente = " + (lbcodcli.Text) + "", conn);
                    da.Fill(dt);
                }
                else if (lbnome.Text != "")
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Cliente where NomeCliente =  '" + lbnome.Text + "'", conn);
                    da.Fill(dt);
                }

                lbcodcli.Text = "";
                lbcpf.Text = "";
                lbnome.Text = "";
                lbrg.Text = "";
               
                gdvDadosSQLServer2.DataSource = dt.DefaultView;
                

                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }

        }

        private void gdvDadosSQLServer1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmclicon_Load(object sender, EventArgs e)
        {
            
            apagar.Enabled = false;
            alterar.Enabled = false;
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Principal frm1 = (Principal)this.MdiParent;
            frm1.tlclicod.Text  = gdvDadosSQLServer2.SelectedRows[0].Cells[0].Value.ToString();
            Principal frm2 = (Principal)this.MdiParent;
            frm2.tlnomecli.Text = gdvDadosSQLServer2.SelectedRows[0].Cells[1].Value.ToString();
            MessageBox.Show("Cliente Selecionado com Sucesso");
            this.Close();
            


        }

        private void apagar_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlCeConnection cnn = new SqlCeConnection(x.b2(tipserv));
            SqlCommand cmd = default(SqlCommand);
            string sql = null;

            CPF = gdvDadosSQLServer2.SelectedRows[0].Cells[2].Value.ToString();
            tela.Classes.banco banco = new tela.Classes.banco();
            string bancos = banco.b2();
            
                connetionString = bancos;

                sql = "Delete from cliente Where CPF = " + (CPF) + "";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.Dispose();
                string CPFR = Convert.ToString(cmd.ExecuteScalar());

                cnn.Close();

                apagar.Enabled = false;
              
                 if (CPF != "")
                {
                    MessageBox.Show("Cliente Removido com Sucesso!");
                    gdvDadosSQLServer2.Refresh();
                    gdvDadosSQLServer2.DataSource = sVDPMRADataSet4;


                }
                else
                {
                    MessageBox.Show("Erro no Sistema");
                }

                 this.Close();
            
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gdvDadosSQLServer2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            apagar.Enabled = false;
            alterar.Enabled = false;
                                        
        }

        private void gdvDadosSQLServer2_Click(object sender, EventArgs e)
        {
            apagar.Enabled = false;
            alterar.Enabled = false;
        }

        private void gdvDadosSQLServer2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            apagar.Enabled = false;
            alterar.Enabled = false;
        }

        private void gdvDadosSQLServer2_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            apagar.Enabled = false;
            alterar.Enabled = false;
        }

        private void gdvDadosSQLServer2_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            apagar.Enabled = false;
            alterar.Enabled = false;
        }

        private void gdvDadosSQLServer2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            apagar.Enabled = false;
            alterar.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string temporal;
            
            tela.Cliente.frmclimod frmAzul = new tela.Cliente.frmclimod();

            temporal = gdvDadosSQLServer2.SelectedRows[0].Cells[2].Value.ToString();
            frmAzul.txnome.Text = gdvDadosSQLServer2.SelectedRows[0].Cells[1].Value.ToString();
            frmAzul.txtCPF.Text = gdvDadosSQLServer2.SelectedRows[0].Cells[2].Value.ToString();
            frmAzul.txtrg.Text = gdvDadosSQLServer2.SelectedRows[0].Cells[3].Value.ToString();
            frmAzul.txfilhos.Text = gdvDadosSQLServer2.SelectedRows[0].Cells[4].Value.ToString();
            frmAzul.txmail.Text = gdvDadosSQLServer2.SelectedRows[0].Cells[5].Value.ToString();
            frmAzul.txtCEP.Text = gdvDadosSQLServer2.SelectedRows[0].Cells[6].Value.ToString();
            frmAzul.txttelcol.Text = gdvDadosSQLServer2.SelectedRows[0].Cells[7].Value.ToString();
            frmAzul.txtobs.Text = gdvDadosSQLServer2.SelectedRows[0].Cells[8].Value.ToString();
            gdvDadosSQLServer2.Refresh();
            gdvDadosSQLServer2.DataSource = sVDPMRADataSet4;            
            
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;
          
            
            frmAzul.ShowDialog(this);
            //cria um DataTabale
            DataTable dt = new DataTable();
            //define a string de conexão com o SQL Server
            tela.Classes.banco banco = new tela.Classes.banco();
            string bancos = banco.b2();
            string strConn = bancos;
            //Abre a conexão
            SqlConnection conn = new SqlConnection(strConn);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Cliente WHERE CPF = " + (temporal) + "", conn);
            da.Fill(dt);
            gdvDadosSQLServer2.DataSource = dt.DefaultView;
           
        }

        private void lbcpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbcpf_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void lbrg_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void lbcodcli_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbcodcli_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void lbnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void gdvDadosSQLServer2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            alterar.Enabled = true;
            apagar.Enabled = true;
        }

        private void gdvDadosSQLServer2_RowHeaderCellChanged(object sender, DataGridViewRowEventArgs e)
        {
            alterar.Enabled = false;
            apagar.Enabled = false;
        }
    }
}
    

