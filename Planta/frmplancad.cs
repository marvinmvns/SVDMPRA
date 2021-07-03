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

namespace tela.Planta
{
    public partial class frmplancad : Form
    {
        string enderecofoto;
        public frmplancad()
        {

            InitializeComponent();
            //SVDMP_RA.principal frma = (SVDMP_RA.principal)this.MdiParent;
            //MessageBox.Show(frma.lbnomeim.Text);
            //marcus1.Text = frma.lbnomeim.Text;
            //MessageBox.Show(marcus1.Text);



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {




            OpenFileDialog fdialog = new OpenFileDialog();
            fdialog.Filter = "Arquivos de Imagem(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif*.bmp";
            fdialog.Title = "Selecione a imagem do empreendimento";
            fdialog.ShowDialog();
            enderecofoto = fdialog.FileName.ToString();
            
            lbfoto.ImageLocation = enderecofoto;
            lbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        private void frmplancad_Load(object sender, EventArgs e)
        {
           
            if (lbcodimovel.Text == "label7" || lbcodimovel.Text == "Não Adicionado Imovel")
            {
                MessageBox.Show("Para Cadastrar uma Planta é Necessario Cadastrar ou Selecionar um Imovel para isso Clique em no Item Imóveis","Atenção!",MessageBoxButtons.OK, MessageBoxIcon.Hand);                              
                    this.Close();
                }
                else
                {
                    
                }
   


            }

        private void button1_Click(object sender, EventArgs e)
        {
            try
              {//string connetionString = null;
                   //   SqlConnection cnn = default(SqlConnection);
                    //  SqlCommand cmd = default(SqlCommand);
                    //  string sql = null;
                 
                          int temp = Convert.ToInt32(lbcodimovel.Text);
                          tela.Classes.banco banco = new tela.Classes.banco();
                          string bancos = banco.b2();
                          SqlConnection conn = new SqlConnection(bancos);

                          SqlCommand comm = new SqlCommand("");
                          comm.Connection = conn;
                          comm.CommandText = "INSERT INTO Plantas (FK_CodImovel, NomAmbiente, MtQuad, endplanta) " +
                                             "VALUES             (@FK_CodImovel, @NomAmbiente, @MtQuad, @endplanta)";
                          comm.Parameters.AddWithValue("@FK_CodImovel", temp );
                          comm.Parameters.AddWithValue("@NomAmbiente", txnomeambiente.Text);
                          comm.Parameters.AddWithValue("@MtQuad", txmtquad.Text);
                          comm.Parameters.AddWithValue("@endplanta", enderecofoto);
                          

                          conn.Open();
                          comm.ExecuteNonQuery();
                          conn.Close();
                          MessageBox.Show("Imóvel Cadastrado com sucesso!", "Cadastro de Imóvel",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                          this.Close();

          



                      }
                  
              
              catch (Exception)
              {
                  throw;
              }

        }

        private void marcus2_Click(object sender, EventArgs e)
        {

        }
        }
    }


