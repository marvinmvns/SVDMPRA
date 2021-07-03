using System;
using System.Diagnostics;
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
    public partial class frmmarcador : Form
    {
        string enderecofoto;
        public frmmarcador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {






            if (String.IsNullOrEmpty(lbfoto.ImageLocation) || (String.IsNullOrEmpty(nmmarcador.Text)))
            {
                if (String.IsNullOrEmpty(lbfoto.ImageLocation))
                {
                    MessageBox.Show("A Foto Não foi Adicionada");
                }
                else
                {
                    MessageBox.Show("Você precisa preencher o campo Nome do Marcador");
                     lbnome.ForeColor = Color.Red;
                }
                
            }

            else
            {
                
                string app = @"mk_patt.exe";
                Process myProcess = System.Diagnostics.Process.Start(app);
                myProcess.WaitForExit();
                string nome = nmmarcador.Text;
                string sysDrive = System.Environment.GetEnvironmentVariable("SystemDrive") + @"\SVDMPRA\Sistema\";
                string sysDrive2 = System.Environment.GetEnvironmentVariable("SystemDrive") + @"\SVDMPRA\Sistema\Marcadores\";
                System.IO.File.Copy(sysDrive + "marcador", sysDrive2 + "" + nome + ".patt");
                
                
                try
                {
                    tela.Classes.banco banco = new tela.Classes.banco();
                    string bancos = banco.b2();
                    

                    SqlConnection conn = new SqlConnection(bancos);

                    SqlCommand comm = new SqlCommand("");
                    comm.Connection = conn;
                    comm.CommandText = "INSERT INTO Marcador (NomMarcador, Endmarcador, FotoMarcador) " +
                                       "VALUES              (@NomMarcador, @Endmarcador, @FotoMarcador)";
                    comm.Parameters.AddWithValue("@NomMarcador", nmmarcador.Text);
                    comm.Parameters.AddWithValue("@Endmarcador", sysDrive2 + "" + nome + ".patt");
                    comm.Parameters.AddWithValue("@FotoMarcador", lbfoto.ImageLocation);
                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Marcador Cadastrado com Sucesso!", "Cadastro de Marcadores",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();




                }



                catch (Exception)
                {
                    throw;
                }

            }



            
        }
    }
}
