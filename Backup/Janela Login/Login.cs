using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SVDMP_RA
{
    public partial class login1 : Form
    {
        public login1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Logar_Click(object sender, EventArgs e)
        {

            Principal frm = (Principal)this.MdiParent;
            frm.tlbat.Text = this.Log.Text;
            this.Close();
            
           
             
            
      
              }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Log_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
