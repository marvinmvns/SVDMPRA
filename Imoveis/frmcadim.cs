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
    public partial class frmcadmov : Form
    {
        string enderecofoto;

        public frmcadmov()
        {

            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog fdialog = new OpenFileDialog();
                fdialog.Filter = "Arquivos de Imagem(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif*.bmp";
                fdialog.Title = "Selecione a imagem do empreendimento";
                fdialog.ShowDialog();
                enderecofoto = fdialog.FileName.ToString();
                lbfoto.ImageLocation = enderecofoto;
                lbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;


            }
            catch (Exception)
            {
                throw new ApplicationException("Erro ao Carregar a Imagem(você realmente adicionou uma imagem)?");
            }
        }

        private void lbfoto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
       
        {

           

                    if (string.IsNullOrEmpty(lbcep.Text) || string.IsNullOrEmpty(lbconstr.Text) || string.IsNullOrEmpty(lbend.Text)
                          && string.IsNullOrEmpty(lbimovel.Text) || string.IsNullOrEmpty(lbcep.Text) || string.IsNullOrEmpty(lbimovel.Text))
                    {
                        MessageBox.Show("Todos os campos em Vermelho devem ser preenchidos ", "Cadastro de Moveis",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                        this.lbe.ForeColor = Color.Red;
                        this.lbc.ForeColor = Color.Red;
                        this.lbc2.ForeColor = Color.Red;
                        this.lbn.ForeColor = Color.Red;
                        this.lbt.ForeColor = Color.Red;


                    }
                    else
                    {
                        tela.Classes.banco banco = new tela.Classes.banco();
                        string bancos = banco.b2();
                       
                        SqlConnection conn = new SqlConnection(bancos);

                        SqlCommand comm = new SqlCommand("");
                        comm.Connection = conn;
                        comm.CommandText = "INSERT INTO Imoveis(NomConstrutora,NomImovel, TipoImovel,  Endereco, Cep, endimg) " +
                                           "VALUES          (@NomConstrutora, @NomImovel, @TipoImovel, @Endereco, @Cep, @endimg)";
                        comm.Parameters.AddWithValue("@NomConstrutora", lbconstr.Text);
                        comm.Parameters.AddWithValue("@NomImovel", lbimovel.Text);
                        comm.Parameters.AddWithValue("@TipoImovel", lbtipimovel.SelectedItem.ToString());
                        comm.Parameters.AddWithValue("@Endereco", lbend.Text);
                        comm.Parameters.AddWithValue("@cep", lbcep.Text);
                        comm.Parameters.AddWithValue("@endimg", enderecofoto);
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();


                        MessageBox.Show("Imovel Cadastrado om sucesso!", "Cadastro de Imovel",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Deseja Usar esse Imovel para Efetuar a Simulação ", "Aviso",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            string connetionString = null;
                            SqlConnection cnn = default(SqlConnection);
                            SqlCommand cmd = default(SqlCommand);
                            string sql = null;
                            tela.Classes.banco banco2 = new tela.Classes.banco();
                            string bancos2 = banco.b2();
                            connetionString = bancos2;
                             
                            sql = "Select CEP from Imoveis Where CEP = " + (lbcep.Text) + "";
                            cnn = new SqlConnection(connetionString);
                            cnn.Open();
                            cmd = new SqlCommand(sql, cnn);
                            string Codigo = Convert.ToString(cmd.ExecuteScalar());
                            cmd.Dispose();
                            cnn.Close();
                            Principal frm = (Principal)this.MdiParent;
                            frm.tlnomeim.Text = lbimovel.Text;
                            Principal frm2 = (Principal)this.MdiParent;
                            frm2.lbcodimo.Text = Codigo;
                            this.Close();
                        }
                        else
                        {
                        }
                    }
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

        private void frmcadmov_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sVDPMRADataSet.Imoveis' table. You can move, or remove it, as needed.
            this.imoveisTableAdapter.Fill(this.sVDPMRADataSet.Imoveis);

        }

        private void lbtipim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbimovel_TextChanged(object sender, EventArgs e)
        {

        }
            }

            
        }
    
    


       
    

