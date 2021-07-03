using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using tela.Classes;


namespace tela.Móveis
{
    public partial class frmcadmov2 : Form
    {
        public frmcadmov2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string enderecofoto;
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

        private void button3_Click(object sender, EventArgs e)
        {
            
            
          //*  string sysDrive = System.Environment.GetEnvironmentVariable("SystemDrive") + @"\SVDMPRA\Sistema\";
          //  MessageBox.Show(sysDrive);
       //     string filePath = Path.Combine(sysDrive, "svdmpra.cfg");
        //    Stream st = File.Open(filePath, FileMode.Create);
       //     StreamWriter s = new StreamWriter(st);
       //     s.WriteLine("#");
        //    s.WriteLine("#Arquivo de Configuração SVDMP-RA");
        //    s.WriteLine("#\n");         
       //     s.WriteLine("#Carregamento dos drivers de video");
        //    s.WriteLine("");
        //    s.WriteLine("video artoolkit2");
        //    s.WriteLine("tracker artoolkit2");
        //    s.WriteLine("");
        //    s.WriteLine("#Objeto 1 - Especificar Patt");
       //     s.WriteLine("marker objeto01 single;patt.teste;80;0;0");//Validar Alguma maneira de buscar isso no banco apontamento de marcador
       //     s.WriteLine("");
       //     s.WriteLine("#Orientação Fisica do Objeto");
            //Para cada objeto essa orientação podera variar
            //Bolar alguma forma de cadastrar essa orientação(por um banco de dados por exemplo
            //ou configurar o objeto para ele ficar pronto ja cadastrado
          //  s.WriteLine("#Traslação x y z");
          //  s.WriteLine("translate objeto01" + " " + tx.Text + " " + ty.Text + " " + tx.Text); 
          //  s.WriteLine("#Escala x y z");
          //  s.WriteLine("scale objeto01" + " " + ex.Text + " " + ey.Text + " " + ez.Text);
          //  s.WriteLine("#Rotação 0 0 0");
          //  s.WriteLine("rotate objeto01" + " " + rx.Text + " " + ry.Text + " " + rz.Text + " " + rr.Text);
           // s.WriteLine("#Endereço do Objeto");
            //s.WriteLine("model objeto01"  + " " + tx3d.Text);//recuperar a localização do objeto pelo banco 
         //   s.WriteLine("");            
          //  MessageBox.Show("Teste gerado com sucesso, executar");
          //*  s.Close();

            int rxa, rya, rza, rra, exa, eya, eza, txa, tya, tza;
                

                rxa = Convert.ToInt32(rx.Text);
                rya = Convert.ToInt32(ry.Text);
                rra = Convert.ToInt32(rr.Text);
                rza = Convert.ToInt32(rz.Text);
                exa = Convert.ToInt32(ex.Text);
                eya = Convert.ToInt32(ey.Text);
                eza = Convert.ToInt32(ez.Text);
                txa = Convert.ToInt32(tx.Text);
                tya = Convert.ToInt32(ry.Text);
                tza = Convert.ToInt32(tz.Text);
             
            RA novo = new RA();
            novo.RAC();
            novo.RAGERA(1,"patt.teste", txa, tya, tza, exa, eya, eza, rxa, rxa, rya, rra, tx3d.Text);
            novo.ChamaRA();

             


             
            
            

        }
          

            private void btnadd_Click(object sender, EventArgs e)
            {
                string endereco3d; 
                OpenFileDialog fdialog = new OpenFileDialog();
                fdialog.Filter = "Arquivos de Imagem(*.ive; *.3ds; *.osg; *.dxf)|*.ive; *.3ds; *.osg*.dxf";                
                fdialog.Title = "Selecione a imagem do Móvel";
                fdialog.ShowDialog();
                endereco3d = fdialog.FileName.ToString();
                tx3d.Text = endereco3d;
           //     if (endereco3d != "")
           //     {
           //         tx3d.Text = "Objeto Adicionado";
            //    }
            //    else
            //    {
            //        tx3d.Text = "Objeto não Cadastrado";
            // 
            //    }
                 
            }

            private void lbfoto_Click(object sender, EventArgs e)
            {

            }

            private void button4_Click(object sender, EventArgs e)
            {
                try
                {


                    if (string.IsNullOrEmpty(txnomemv.Text) || string.IsNullOrEmpty(cxtipimovel.Text) || string.IsNullOrEmpty(tx.Text)
                     || string.IsNullOrEmpty(ty.Text) || string.IsNullOrEmpty(tz.Text) || string.IsNullOrEmpty(rx.Text) || string.IsNullOrEmpty(ry.Text) || string.IsNullOrEmpty(rz.Text) || string.IsNullOrEmpty(rx.Text) || string.IsNullOrEmpty(tx3d.Text))
                    {
                        MessageBox.Show("Todos os campos em Vermelho devem ser preenchidos ", "Cadastro Móveis",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                     
                        this.labe1.ForeColor = Color.Red;
                        this.label1.ForeColor = Color.Red;
                        this.label11.ForeColor = Color.Red;
                        this.label12.ForeColor = Color.Red;
                        this.label17.ForeColor = Color.Red;
                        this.label18.ForeColor = Color.Red;
                        this.label19.ForeColor = Color.Red;
                        this.label2.ForeColor = Color.Red;
                        this.label20.ForeColor = Color.Red;
                        this.label21.ForeColor = Color.Red;
                        this.label22.ForeColor = Color.Red;
                        this.label6.ForeColor = Color.Red;



                    }

                    else
                    {
                        tela.Classes.banco banco = new tela.Classes.banco();
                        string bancos = banco.b2();     
                        SqlConnection conn = new SqlConnection(bancos);

                            int rxv, ryv, rzv, rrv, exv, eyv, ezv, txv, tyv, tzv;

                            rxv = Convert.ToInt32(rx.Text);
                            ryv = Convert.ToInt32(ry.Text);
                            rzv = Convert.ToInt32(rz.Text);
                            rrv = Convert.ToInt32(rr.Text);
                            exv = Convert.ToInt32(ex.Text);
                            eyv = Convert.ToInt32(ey.Text);
                            ezv = Convert.ToInt32(ez.Text);
                            txv = Convert.ToInt32(tx.Text);
                            tyv = Convert.ToInt32(ty.Text);
                            tzv = Convert.ToInt32(tz.Text);
                            


                            SqlCommand comm = new SqlCommand("");
                            comm.Connection = conn;
                            comm.CommandText = "INSERT INTO Moveis  (NomMovel, TipMovel, Transx, Transy, Transz, Escalax, Escalay, Escalaz, Rotacaox, Rotacaoy, Rotacaoz, Rotacaor,  Observacao, endfisico, ext ) " +
                                               "VALUES             (@NomMovel, @TipMovel, @Transx, @Transy, @Transz, @Escalax, @Escalay, @Escalaz, @Rotacaox, @Rotacaoy, @Rotacaoz, @Rotacaor, @Observacao, @endfisico, @ext )";
                            comm.Parameters.AddWithValue("@NomMovel", txnomemv.Text);
                            comm.Parameters.AddWithValue("@TipMovel", cxtipimovel.Text);
                            comm.Parameters.AddWithValue("@Transx", txv);
                            comm.Parameters.AddWithValue("@Transy", tyv);
                            comm.Parameters.AddWithValue("@Transz", tzv);
                            comm.Parameters.AddWithValue("@Escalax", exv);
                            comm.Parameters.AddWithValue("@Escalay", eyv);
                            comm.Parameters.AddWithValue("@Escalaz", ezv);
                            comm.Parameters.AddWithValue("@Rotacaox", rxv);
                            comm.Parameters.AddWithValue("@Rotacaoy", ryv);
                            comm.Parameters.AddWithValue("@Rotacaoz", rzv);
                            comm.Parameters.AddWithValue("@Rotacaor", rrv);
                            comm.Parameters.AddWithValue("@Observacao", txobs.Text);
                            comm.Parameters.AddWithValue("@endfisico", tx3d.Text);
                            comm.Parameters.AddWithValue("@ext", lbfoto.ImageLocation);

                            conn.Open();
                            comm.ExecuteNonQuery();
                            conn.Close();


                            MessageBox.Show("Movel Cadastrado com sucesso!", "Cadastro de Móveis",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                    }
                }
                        
                
                catch (Exception)
                {
                    throw;
                }
            }

            private void frmcadmov2_Load(object sender, EventArgs e)
            {

            }

            private void button6_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void txnomemv_TextChanged(object sender, EventArgs e)
            {

            }

            private void button5_Click(object sender, EventArgs e)
            {
                txnomemv.Clear();
                tx3d.Clear();
                txobs.Clear();
               // cxtipimovel.Text = "";

            }
        }
    }

