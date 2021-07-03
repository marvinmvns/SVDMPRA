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
using SVDMP_RA;


namespace tela.Cliente
{
    public partial class frmclimod : Form
    {
        public frmclimod()
        {
            InitializeComponent();
        }

        public void frmclimod_Load(object sender, EventArgs e)
        {
              
            
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrEmpty(txnome.Text) || string.IsNullOrEmpty(txtCEP.Text) || string.IsNullOrEmpty(txtCPF.Text)
                 || string.IsNullOrEmpty(txtrg.Text) || string.IsNullOrEmpty(txmail.Text) || string.IsNullOrEmpty(txttelcol.Text))
                {
                    MessageBox.Show("Todos os campos em Vermelho devem ser preenchidos ", "Modificação de Cliente",
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
                   // string connetionString = null;
                 //   SqlConnection cnn = default(SqlConnection);
                //    SqlCommand cmd = default(SqlCommand);
                //    string sql = null;
                   

                   
                        double cpf, rg;
                        cpf = Convert.ToDouble(txtCPF.Text);
                        rg = Convert.ToDouble(txtrg.Text);
                        tela.Classes.banco banco = new tela.Classes.banco();
                        string bancos = banco.b2();
                        SqlConnection conn = new SqlConnection(bancos);

                        
                        SqlCommand comm = new SqlCommand("");
                        comm.Connection = conn;
                        comm.CommandText =
                            // "UPDATE  Cliente  set (NomeCliente, CPF, RG, Filhos, email, CEP, telcon, Obs) " +
                            //                "VALUES             (@NomeCliente, @CPF, @RG, @Filhos, @email, @CEP, @telcon, @Obs)" +
                            //                "where CPF = cpf ";


                                           "UPDATE  Cliente set NomeCliente =  '" + this.txnome.Text + "', CPF =  '" + this.txtCPF.Text + "', RG =  '" + this.txtrg.Text + "', Filhos =  '" + this.txfilhos.Text + "', email =  '" + this.txmail.Text + "', CEP =  '" + this.txtCEP.Text +"', telcon =  '" + this.txttelcol.Text + "', Obs =  '" + this.txtobs.Text + "'  WHERE (CPF = '" + txtCPF.Text + "')";
                    
                        
                        comm.Parameters.AddWithValue("@NomeCliente", txnome.Text);
                        

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


                        MessageBox.Show("Cliente Alerado com sucesso!", "Cadastro de Cliente",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                     
                        
                        
                    }
                }
            
            catch (Exception)
            {
                throw;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Esse Comando Limpara Todo o Formulario, Deseja Continuar ", "Aviso",
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

        }
    }
}
