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

namespace tela.Marcadores
{
    public partial class consulmark : Form
    {
        public consulmark()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
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



                if (txcmarc.Text != "")
                {
                    dgmark.DataSource = dt.DefaultView;
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Marcador WHERE CodMarcador = " + (txcmarc.Text) + "", conn);
                    da.Fill(dt);
                }
                else if (txmarc.Text != "")
                {
                    dgmark.DataSource = dt.DefaultView;
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Marcador WHERE NomMarcador = " + (txmarc.Text) + "", conn);
                    da.Fill(dt);
                }

                txcmarc.Text = "";
                txmarc.Text  = "";
               
                
                 dgmark.DataSource = dt.DefaultView;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }

        }

        private void consulmark_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sVDPMRADataSet12.Marcador' table. You can move, or remove it, as needed.
            this.marcadorTableAdapter.Fill(this.sVDPMRADataSet12.Marcador);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn = default(SqlConnection);
            SqlCommand cmd = default(SqlCommand);
            string sql = null;
            
            
            tela.Classes.banco banco = new tela.Classes.banco();
            string bancos = banco.b2();

            string cod; 
            cod = dgmark.SelectedRows[0].Cells[0].Value.ToString();
           
            connetionString = bancos;
          

            sql = "Delete from Marcador Where CodMarcador = " + (cod) + "";
            
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            cmd = new SqlCommand(sql, cnn);
            cmd.Dispose();
            string CPFR = Convert.ToString(cmd.ExecuteScalar());

            cnn.Close();

            apagar.Enabled = false;

            if (cod != "")
            {
                MessageBox.Show("Marcador removido com Sucesso!");
                dgmark.Refresh();
                


            }
            else
            {
                MessageBox.Show("Erro no Sistema");
            }

            this.Close();
            
        }

        private void dgmark_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbfoto.ImageLocation = dgmark.SelectedRows[0].Cells[3].Value.ToString();
            apagar.Enabled = true;
        }

        private void dgmark_Move(object sender, EventArgs e)
        {
            lbfoto.ImageLocation = dgmark.SelectedRows[0].Cells[3].Value.ToString();
            apagar.Enabled = true;
        }

        private void dgmark_MouseClick(object sender, MouseEventArgs e)
        {
            lbfoto.ImageLocation = dgmark.SelectedRows[0].Cells[3].Value.ToString();
            apagar.Enabled = true;
        }

        private void dgmark_KeyDown(object sender, KeyEventArgs e)
        {
            lbfoto.ImageLocation = dgmark.SelectedRows[0].Cells[3].Value.ToString();
            apagar.Enabled = true;
        }

        private void dgmark_KeyUp(object sender, KeyEventArgs e)
        {
            lbfoto.ImageLocation = dgmark.SelectedRows[0].Cells[3].Value.ToString();
            apagar.Enabled = true;
        }

        private void dgmark_Click(object sender, EventArgs e)
        {
            lbfoto.ImageLocation = dgmark.SelectedRows[0].Cells[3].Value.ToString();
            apagar.Enabled = true;
        }

        private void dgmark_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbfoto.ImageLocation = dgmark.SelectedRows[0].Cells[3].Value.ToString();
            apagar.Enabled = true;
        }
    }
}
