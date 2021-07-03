using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tela.Planta
{
    public partial class frmmodpla : Form
    {
        string enderecofoto;
        public frmmodpla()
        {
            
            InitializeComponent();
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
                MessageBox.Show(enderecofoto);
                lbfoto.ImageLocation = enderecofoto;
                lbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;


            }
            catch (Exception)
            {
                throw new ApplicationException("Erro ao Carregar a Imagem(você realmente adicionou uma imagem)?");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
