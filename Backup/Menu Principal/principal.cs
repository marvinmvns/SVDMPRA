using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SVDMP_RA
{
    public partial class Principal : Form
    {

        public Principal()
        {

            InitializeComponent();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            frmclicad X = new frmclicad();
            X.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            // Cria um novo formulário 
            frmclicad frmAzul = new frmclicad();

            // Atribui um titulo ao formulário
            // frmAzul.Text = "Formulário Azul";


            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();

        }




        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void moveisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void geração3DToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void principal_Load(object sender, EventArgs e)
        {

            ajudaToolStripMenuItem.Enabled = false;


        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 
            frmcadmov frmAzul = new frmcadmov();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();
        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {


        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 
            frmclicon frmAzul = new frmclicon();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void checkpointToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lorenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlclicod.Text = "Testando";
        }

        private void labclicod_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 

            frmcodim frmAzul = new frmcodim();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();

        }

        private void apagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 

            tela.Móveis.frmcadmov2 frmAzul = new tela.Móveis.frmcadmov2();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();
        }

        private void incluirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int a = 0;

            if (tlnomecli.Text != "Não Adicionado Cliente")
            {
                a++;
            }

            if (tlnomeim.Text != "Não Adicionado Imóvel")
            {
                a++;
            }

            if (tlplanta.Text != "Não Adicionado Planta")
            {
                a++;
            }




            if (tlnomecli.Text == "Não Adicionado Cliente")
            {

                MessageBox.Show("Voce Devera Associar um Cliente ao Atendimento");

            }

            if (tlnomeim.Text == "Não Adicionado Imovel")
            {

                MessageBox.Show("Voce Devera Associar um Imóvel ao Atendimento");

            }

            if (tlplanta.Text == "Não Adicionado Planta")
            {

                MessageBox.Show("Voce Devera Associar uma Planta ao Atendimento");

            }




            if (a == 3)
            {
                if

                    (tlnomeim.Text == "Adicionado Imovel")
                {
                    MessageBox.Show("Voce Devera Associar um Cliente ao Atendimento");
                    this.Close();
                }



                // Cria um novo formulário 

                tela.Geracao3d.frmgeracao frmAzula = new tela.Geracao3d.frmgeracao();

                // Atribui um titulo ao formulário
                //frmAzul.Text = "Formulário Azul";

                // Altera a cor de fundo do formulário
                //frmAzul.BackColor = System.Drawing.Color.Blue;

                frmAzula.codpla.Text = codpla.Text;
                frmAzula.codimovel.Text = lbcodimo.Text;
                frmAzula.tlclicod.Text = tlclicod.Text;
                frmAzula.tlnomecli.Text = tlnomecli.Text;
                frmAzula.tlnomeim.Text = tlnomeim.Text;
                frmAzula.tlplanta.Text = tlplanta.Text;
                //frmAzul.lbcodimovel.Text = lbcodimo.Text;

                // Maximiza o formulário filho
                frmAzula.WindowState = System.Windows.Forms.FormWindowState.Normal;

                // Define quem o pai desta janela
                frmAzula.MdiParent = this;

                // exibe o formulário
                frmAzula.Show();
            }

            else
            {


            }
        }


        private void incluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (tlnomeim.Text == "Não Adicionado Imovel")
            {
                MessageBox.Show("Por favor, selecione um Imóvel");
            }
            else
            {







                tela.Planta.frmplancad frmAzul = new tela.Planta.frmplancad(); ;

                // Atribui um titulo ao formulário
                //frmAzul.Text = "Formulário Azul";

                frmAzul.lbcodimovel.Text = lbcodimo.Text;
                frmAzul.lbnomimovel.Text = tlnomeim.Text;

                // Altera a cor de fundo do formulário
                //frmAzul.BackColor = System.Drawing.Color.Blue;

                // Maximiza o formulário filho
                frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

                // Define quem o pai desta janela
                //frmAzul.MdiParent = this;



                // exibe o formulário
                frmAzul.Show();
            }
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            tela.Móveis.frmcadmov2 frmAzul = new tela.Móveis.frmcadmov2();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;




            // exibe o formulário
            frmAzul.Show();

        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            tela.Geracao3d.frmaltset frmAzul = new tela.Geracao3d.frmaltset();


            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            tela.Planta.frmplancad frmAzul = new tela.Planta.frmplancad(); ;

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            frmAzul.lbcodimovel.Text = lbcodimo.Text;
            frmAzul.lbnomimovel.Text = tlnomeim.Text;

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            //frmAzul.MdiParent = this;



            // exibe o formulário
            frmAzul.Show();

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e){
    
            if (tlnomeim.Text == "Não Adicionado Imovel")
            {
                MessageBox.Show("Por favor, selecione um Imóvel");
            }
            else
            {
            
            
            
            tela.Planta.Frmconpla frmAzul = new tela.Planta.Frmconpla();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            frmAzul.lbcodimovel.Text = lbcodimo.Text;
            frmAzul.lbnomimovel.Text = tlnomeim.Text;

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;



            // exibe o formulário
            frmAzul.Show();
        }}

        private void principal_MouseCaptureChanged(object sender, EventArgs e)
        {



        }

        private void principal_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tela.Móveis.frmmovcons frmAzul = new tela.Móveis.frmmovcons();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;


            // Define quem o pai desta janela
            frmAzul.MdiParent = this;


            // exibe o formulário
            frmAzul.Show();

        }

        private void lbcodimo_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void cliente_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            // Cria um novo formulário 
            frmclicon frmAzul = new frmclicon();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {


            bbar.Enabled = true;
            bbar.Visible = true;





        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 

            tela.Marcadores.frmmarcador frmAzul = new tela.Marcadores.frmmarcador();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            tlclicod.Text = "";
            tlnomecli.Text = "";
            tlnomeim.Text = "";
            tlplanta.Text = "";
            tlbat.Text = "";
            tlperf.Text = "";
        }

        private void bubbleButton20_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            // Cria um novo formulário 

            tela.Marcadores.frmmarcador frmAzul = new tela.Marcadores.frmmarcador();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();
        }

        private void bubbleButton1_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            // Cria um novo formulário 
            frmclicon frmAzul = new frmclicon();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;
            //frmAzul.WindowState = System.Windows.Forms.FormStartPosition;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();
        }

        private void bubbleButton2_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            // Cria um novo formulário 

            frmcodim frmAzul = new frmcodim();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();
        }

        private void bubbleButton11_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            tela.Planta.Frmconpla frmAzul = new tela.Planta.Frmconpla();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;



            // exibe o formulário
            frmAzul.Show();
        }

        private void bubbleButton19_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            // Cria um novo formulário 

            tela.Móveis.frmcadmov2 frmAzul = new tela.Móveis.frmcadmov2();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();
        }

        private void bubbleButton10_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            tela.Móveis.frmmovcons frmAzul = new tela.Móveis.frmmovcons();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;


            // Define quem o pai desta janela
            frmAzul.MdiParent = this;


            // exibe o formulário
            frmAzul.Show();

        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {

            bbar.Enabled = false;
            bbar.Visible = false;
        }

        private void bubbleButton22_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void incluirToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 

           
            tela.Marcadores.frmmarcador frmAzul = new tela.Marcadores.frmmarcador();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();
        }

        private void consultaModificaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 


            tela.Marcadores.consulmark frmAzul = new tela.Marcadores.consulmark();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();
        }

        private void bubbleButton21_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            // Cria um novo formulário 


            tela.Marcadores.consulmark frmAzul = new tela.Marcadores.consulmark();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();
        }

        private void bubbleButton13_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            tela.Geracao3d.frmaltset frmAzul = new tela.Geracao3d.frmaltset();


            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();
        }

        private void bubbleButton16_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

            // Cria um novo formulário 
            frmclicad frmAzul = new frmclicad();

            // Atribui um titulo ao formulário
            // frmAzul.Text = "Formulário Azul";


            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();

        }

        private void bubbleButton17_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            // Cria um novo formulário 
            frmcadmov frmAzul = new frmcadmov();

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();
        }

        private void bubbleButton18_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            tela.Planta.frmplancad frmAzul = new tela.Planta.frmplancad(); ;

            // Atribui um titulo ao formulário
            //frmAzul.Text = "Formulário Azul";

            frmAzul.lbcodimovel.Text = lbcodimo.Text;
            frmAzul.lbnomimovel.Text = tlnomeim.Text;

            // Altera a cor de fundo do formulário
            //frmAzul.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Normal;

            // Define quem o pai desta janela
            //frmAzul.MdiParent = this;



            // exibe o formulário
            frmAzul.Show();
        }
    }
}