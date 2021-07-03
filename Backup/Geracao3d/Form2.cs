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


namespace tela.Geracao3d
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            tela.Geracao3d.frmgeracao frm = new tela.Geracao3d.frmgeracao();
            //frm.dgset.SelectedRows[0].Cells[2].Value = dgmarcador.SelectedRows[0].Cells[0].Value;
            frm.codmark.Text = dgmarcador.SelectedRows[0].Cells[0].Value.ToString();
            //string teste = dgmarcador.SelectedRows[0].Cells[0].Value.ToString();
            //MessageBox.Show(teste);

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            if (codxxx.Text == "0")
            {

                this.marcadorTableAdapter.Fill(this.sVDPMRADataSet8.Marcador);

            }
            else
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


                     SqlDataAdapter da = new SqlDataAdapter("Select CodMarcador, NomMarcador, EndMarcador, FotoMarcador from Marcador", conn);
                    //SqlDataAdapter da = new SqlDataAdapter("Select CodMarcador, NomMarcador, EndMarcador, FotoMarcador from Marcador, MovelSet WHERE FK_CodSet = " + (codset.Text) + "", conn);

                    
                    
                    da.Fill(dt);



                    dgmarcador.DataSource = dt.DefaultView;




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }


                // TODO: This line of code loads data into the 'sVDPMRADataSet8.Marcador' table. You can move, or remove it, as needed.
                // 

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbfoto.ImageLocation =  dgmarcador.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void dgmarcador_KeyDown(object sender, KeyEventArgs e)
        {
            lbfoto.ImageLocation = dgmarcador.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void dgmarcador_KeyUp(object sender, KeyEventArgs e)
        {
            lbfoto.ImageLocation = dgmarcador.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void dgmarcador_MouseClick(object sender, MouseEventArgs e)
        {
            lbfoto.ImageLocation = dgmarcador.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void lbfoto_Click(object sender, EventArgs e)
        {

        }
    }
}
