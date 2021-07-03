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
using tela.Classes;


namespace tela.Geracao3d
{
    public partial class frmgeracao : Form
    {
        int contador = 0;
        int codsetgeral;
        public frmgeracao()
        {
            InitializeComponent();
        }

        private void kryptonGallery1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            RA novo = new RA();
            novo.RAC();

            for (int i = 0; i < dgset.Rows.Count; i++)
            {
                int rx, ry, rz, rr, ex, ey, ez, tx, ty, tz;
                string marcador, endobj;


              tx = Convert.ToInt32(dgset.Rows[i].Cells[3].Value.ToString());
              ty = Convert.ToInt32(dgset.Rows[i].Cells[4].Value.ToString());
              tz = Convert.ToInt32(dgset.Rows[i].Cells[5].Value.ToString());
              ex = Convert.ToInt32(dgset.Rows[i].Cells[6].Value.ToString());
              ey = Convert.ToInt32(dgset.Rows[i].Cells[7].Value.ToString());
              ez = Convert.ToInt32(dgset.Rows[i].Cells[8].Value.ToString());
              rx = Convert.ToInt32(dgset.Rows[i].Cells[9].Value.ToString());
              ry = Convert.ToInt32(dgset.Rows[i].Cells[10].Value.ToString());
              rz = Convert.ToInt32(dgset.Rows[i].Cells[11].Value.ToString());
              rr = Convert.ToInt32(dgset.Rows[i].Cells[12].Value.ToString());
              endobj = dgset.Rows[i].Cells[13].Value.ToString();
              marcador = dgset.Rows[i].Cells[14].Value.ToString();
              
                               
                novo.RAGERA(i, marcador, tx, ty, tz, ex, ey, ez, rx, ry, rz, rr, endobj);
            }
            novo.ChamaRA();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmgeracao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sVDPMRADataSet11.Moveis' table. You can move, or remove it, as needed.
            this.moveisTableAdapter.Fill(this.sVDPMRADataSet11.Moveis);
        

           

            btnexecutar.Enabled = true;

            try
            {
                







                if (lbnomeset.Text == "Não Adicionado Nome")
                {

                    frmnomeset frmAzul = new frmnomeset();


                    // Maximiza o formulário filho
                    frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

                    // Define quem o pai desta janela
                    //frmAzul.MdiParent = this;


                    // exibe o formulário
                    frmAzul.ShowDialog();
                    lbnomeset.Text = frmAzul.txnomeset.Text;
                    tela.Classes.banco banco = new tela.Classes.banco();
                    string bancos = banco.b2();

                    SqlConnection conn = new SqlConnection(bancos);

                    SqlCommand comm = new SqlCommand("");
                    comm.Connection = conn;
                    comm.CommandText = "INSERT INTO SET3D (NomeSet, Fk_CodImovel, Fk_CodPlanta, FK_CodCliente, FK_CodFuncionario) " +
                                       "VALUES            (@NomeSet, @Fk_CodImovel, @Fk_CodPlanta, @FK_CodCliente, @FK_CodFuncionario)";

                    int cimovel, cplanta, ccliente;


                    cimovel = Convert.ToInt32(codimovel.Text);
                    cplanta = Convert.ToInt32(codpla.Text);
                    ccliente = Convert.ToInt32(tlclicod.Text);



                    comm.Parameters.AddWithValue("@NomeSet", lbnomeset.Text);
                    comm.Parameters.AddWithValue("@Fk_CodImovel", cimovel);
                    comm.Parameters.AddWithValue("@Fk_CodPlanta", cplanta);
                    comm.Parameters.AddWithValue("@FK_CodCliente", ccliente);
                    comm.Parameters.AddWithValue("@FK_CodFuncionario", 1);


                    
                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();


                     string connetionString = null;
                      SqlConnection cnn = default(SqlConnection);
                      SqlCommand cmd = default(SqlCommand);
                      string sql = null;
                      connetionString = bancos;

                    sql = "SELECT IDENT_CURRENT('SET3D')";
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
                    cmd = new SqlCommand(sql, cnn);
                    string Codigo = Convert.ToString(cmd.ExecuteScalar());
                    cmd.Dispose();
                    cnn.Close();
                    lbcodset.Text = Codigo;
                    
                    codsetgeral = Convert.ToInt32(Codigo);







                                       
                }
            }
            catch (Exception)
            {
                throw;


            }
        
        }
        
     

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
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

                    string constr2 =  lbnmmovel.Text;
                    if (lbnmmovel.Text != "")
                    {

                        SqlDataAdapter da = new SqlDataAdapter("Select * from Moveis WHERE NomMovel = '" + lbnmmovel.Text + "'", conn);
                        da.Fill(dt);
                    }
                    else if (lbcxtip.Text != "")
                    {
                        string constr = lbcxtip.Text;
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
                    dvmoveis.DataSource = dt.DefaultView;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }

            }

        }

        private void dvmoveis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            lbfoto.ImageLocation = dvmoveis.SelectedRows[0].Cells[15].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                  


            tela.Geracao3d.Form2 frmAzul = new tela.Geracao3d.Form2();
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;
            frmAzul.codset.Text = lbcodset.Text;
            frmAzul.codxxx.Text = Convert.ToString(contador);
            frmAzul.ShowDialog();           
            string contstring = contador.ToString();
            
            
            
                       
                        dgset.Rows.Add();
                        dgset.Rows[contador].Cells[0].Value = dvmoveis.SelectedRows[0].Cells[0].Value;
                        int codmovelint = Convert.ToInt32(dvmoveis.SelectedRows[0].Cells[0].Value.ToString());
                        dgset.Rows[contador].Cells[1].Value = dvmoveis.SelectedRows[0].Cells[1].Value;
                        dgset.Rows[contador].Cells[2].Value = frmAzul.dgmarcador.SelectedRows[0].Cells[0].Value;
                        int codmarcadorint = Convert.ToInt32(frmAzul.dgmarcador.SelectedRows[0].Cells[0].Value.ToString());
                        int codsetint = Convert.ToInt32(lbcodset.Text);
                        dgset.Rows[contador].Cells[3].Value = dvmoveis.SelectedRows[0].Cells[3].Value;
                        dgset.Rows[contador].Cells[4].Value = dvmoveis.SelectedRows[0].Cells[4].Value;
                        dgset.Rows[contador].Cells[5].Value = dvmoveis.SelectedRows[0].Cells[5].Value;
                        dgset.Rows[contador].Cells[6].Value = dvmoveis.SelectedRows[0].Cells[6].Value;
                        dgset.Rows[contador].Cells[7].Value = dvmoveis.SelectedRows[0].Cells[7].Value;
                        dgset.Rows[contador].Cells[8].Value = dvmoveis.SelectedRows[0].Cells[8].Value;
                        dgset.Rows[contador].Cells[9].Value = dvmoveis.SelectedRows[0].Cells[9].Value;
                        dgset.Rows[contador].Cells[10].Value = dvmoveis.SelectedRows[0].Cells[10].Value;
                        dgset.Rows[contador].Cells[11].Value = dvmoveis.SelectedRows[0].Cells[11].Value;
                        dgset.Rows[contador].Cells[12].Value = dvmoveis.SelectedRows[0].Cells[12].Value;
                        dgset.Rows[contador].Cells[13].Value = dvmoveis.SelectedRows[0].Cells[14].Value;
                        dgset.Rows[contador].Cells[14].Value = frmAzul.dgmarcador.SelectedRows[0].Cells[2].Value;
                        this.dvmoveis.Rows.Remove(this.dvmoveis.CurrentRow);
                        contador++;
                        

             try
                {   
                  tela.Classes.banco banco = new tela.Classes.banco();
                string bancos = banco.b2();
                
                 
                    SqlConnection conn = new SqlConnection(bancos);
                    SqlCommand comm = new SqlCommand("");
                    comm.Connection = conn;
                    comm.CommandText = "INSERT INTO MovelSet (FK_CodSet, FK_CodMovel, FK_CodMarcador) " +
                                       "VALUES              (@FK_CodSet, @FK_CodMovel, @FK_CodMarcador)";
                    comm.Parameters.AddWithValue("@FK_CodSet", codsetint);
                    comm.Parameters.AddWithValue("@FK_CodMovel", codmovelint);
                    comm.Parameters.AddWithValue("@FK_CodMarcador", codmarcadorint);
                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();
                                 }
                 

             catch (Exception)
             {
                 throw;
             }
       
            
            
                     

                    }


                

       

        private void button8_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn = default(SqlConnection);
            SqlCommand cmd = default(SqlCommand);
            string sql = null;            
            int codmovela = Convert.ToInt32(dgset.CurrentRow.Cells[0].Value.ToString());
             tela.Classes.banco banco = new tela.Classes.banco();
                string bancos = banco.b2();
            connetionString = bancos;
            sql = "Delete from MovelSet Where FK_CodSet = "+(codsetgeral)+" and FK_CodMovel ="+(codmovela)+"";
            
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            cmd = new SqlCommand(sql, cnn);
            cmd.Dispose();
            string CPFR = Convert.ToString(cmd.ExecuteScalar());            
            this.dgset.Rows.Remove(this.dgset.CurrentRow);
            contador--;
        }

        private void tlplanta_Click(object sender, EventArgs e)
        {

        }

        private void lbcodimo_Click(object sender, EventArgs e)
        {

        }

        private void codpla_Click(object sender, EventArgs e)
        {

        }

        private void tlclicod_Click(object sender, EventArgs e)
        {

        }

        private void frmgeracao_MouseClick(object sender, MouseEventArgs e)
        {
            



        }

        private void lbnomeset_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void moveisBindingSource1_CurrentChanged(object sender, EventArgs e)
        {
                    }

        private void dvmoveis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbfoto.ImageLocation = dvmoveis.SelectedRows[0].Cells[15].Value.ToString();
        }

        private void dvmoveis_KeyDown(object sender, KeyEventArgs e)
        {
            lbfoto.ImageLocation = dvmoveis.SelectedRows[0].Cells[15].Value.ToString();
        }

        private void dvmoveis_KeyDown(object sender, KeyPressEventArgs e)
        {
            lbfoto.ImageLocation = dvmoveis.SelectedRows[0].Cells[15].Value.ToString();
        }
    }
}
