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





namespace SVDMP_RA
{
    public partial class frmclicad : Form
    { 
        
          public frmclicad(){
            InitializeComponent();
        }



          private void btnInserir_Click(object sender, EventArgs e)
          {
              try
              {


                  if (string.IsNullOrEmpty(txnome.Text) || string.IsNullOrEmpty(txtCEP.Text) || string.IsNullOrEmpty(txtCPF.Text)
                   || string.IsNullOrEmpty(txtrg.Text) || string.IsNullOrEmpty(txmail.Text) || string.IsNullOrEmpty(txttelcol.Text))
                  {
                      MessageBox.Show("Todos os campos em Vermelho devem ser preenchidos ", "Cadastro de Cliente",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);

                      this.nmclientelb.ForeColor = Color.Red;
                      this.cpf.ForeColor = Color.Red;
                      this.rg.ForeColor = Color.Red;
                      this.email.ForeColor = Color.Red;
                      this.cep.ForeColor = Color.Red;
                      this.telco.ForeColor = Color.Red;



                  }

                  else
                  {
                      string connetionString = null;
                       SqlConnection cnn = default(SqlConnection);
                      SqlCommand cmd = default(SqlCommand);
                      string sql = null;
                      tela.Classes.banco banco = new tela.Classes.banco();
                      string bancos = banco.b2();
                      connetionString = bancos;

                     

                      sql = "Select Count(*) from cliente Where CPF = " + (txtCPF.Text) + "";
                      cnn = new SqlConnection(connetionString);


                      cnn.Open();
                      cmd = new SqlCommand(sql, cnn);
                      Int32 contador = Convert.ToInt32(cmd.ExecuteScalar());
                      cmd.Dispose();
                      cnn.Close();


                      if (contador > 1)
                      {
                          MessageBox.Show("Cliente já Cadastrado ", "Cadastro de Cliente",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);

                      }
                      else
                      {

                          double cpf, rg;
                         
                          

                          SqlConnection conn = new SqlConnection(bancos);

                          SqlCommand comm = new SqlCommand("");
                          comm.Connection = conn;
                          comm.CommandText = "INSERT INTO Cliente (NomeCliente, CPF, RG, Filhos, email, CEP, telcon, Obs) " +
                                             "VALUES             (@NomeCliente, @CPF, @RG, @Filhos, @email, @CEP, @telcon, @Obs)";
                          comm.Parameters.AddWithValue("@NomeCliente", txnome.Text);
                          cpf = Convert.ToDouble(txtCPF.Text);
                          rg = Convert.ToDouble(txtrg.Text);

                          comm.Parameters.AddWithValue("@CPF", cpf);
                          comm.Parameters.AddWithValue("@RG", rg);
                          comm.Parameters.AddWithValue("@Filhos", txfilhos.Text);
                          comm.Parameters.AddWithValue("@email", txmail.Text);
                          comm.Parameters.AddWithValue("@CEP", txtCEP.Text);
                          comm.Parameters.AddWithValue("@telcon", txttelcol.Text);
                          comm.Parameters.AddWithValue("@Obs", txtobs.Text);

                          conn.Open();
                          comm.ExecuteNonQuery();
                          conn.Close();


                          MessageBox.Show("Cliente Cadastrado com sucesso!", "Cadastro de Cliente",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                         if (MessageBox.Show("Deseja Usar esse Cliente para Efetuar a Simulação ", "Aviso",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)== DialogResult.Yes)
                         {


                             

                          sql = "Select CodCliente from cliente Where CPF = "+(txtCPF.Text)+"";
                          cnn = new SqlConnection(connetionString);
                          cnn.Open();
                          cmd = new SqlCommand(sql, cnn);
                          string Codigo = Convert.ToString(cmd.ExecuteScalar());
                          cmd.Dispose();
                          cnn.Close();

                          

                          Principal frm = (Principal)this.MdiParent;
                          frm.tlnomecli.Text = txnome.Text;
                          Principal frm2 = (Principal)this.MdiParent;
                          frm.tlclicod.Text = Codigo;
                          
                          this.Close();


                         }

                         else
                         {
                             this.Close();
                         }




                      }
                  }
              }
              catch (Exception)
              {
                  throw;
              }
          }
                          
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 
            frmclicad frmcli = new frmclicad();

            // Atribui um titulo ao formulário
            frmcli.Text = "Formulário AzuL";

            // Altera a cor de fundo do formulário
            //frmcli.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmcli.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            // Define quem o pai desta janela
            
            // exibe o formulário
            frmcli.Show(); 


        }

        private void frmclicad_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void qtde_ImoveisLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cEPLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rGLabel_Click(object sender, EventArgs e)
        {

        }

        private void filhosLabel_Click(object sender, EventArgs e)
        {

        }

        private void lbcpf_TextChanged(object sender, EventArgs e)
        {

        }

               



        private void lbtelcol_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbobs_TextChanged(object sender, EventArgs e)
        {

        }

       


        private void txtCEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_Keypress(object sender, KeyPressEventArgs e)
        {

           


           if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
           {
                e.Handled = true;
           }
        }

        


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Esse Comando Limpará Todo o Formulario, Deseja Continuar ", "Aviso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                txfilhos.Clear();
                txmail.Clear();
                txnome.Clear();
                txtCEP.Clear();
                txtCPF.Clear();
                txtobs.Clear();
                txtrg.Clear();
                txttelcol.Clear();

            }
            else
            {
            }
            }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void txtCEP_Click(object sender, EventArgs e)
        {
            txtCEP.SelectionStart = txtCEP.Text.Length + 1;
        }

    }
}

    

     

