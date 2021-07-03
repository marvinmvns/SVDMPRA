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
    public partial class Frmconpla : Form
    {
        public Frmconpla()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frmconpla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sVDPMRADataSet6.Plantas' table. You can move, or remove it, as needed.
            this.plantasTableAdapter1.Fill(this.sVDPMRADataSet6.Plantas);
            // TODO: This line of code loads data into the 'sVDPMRADataSet1.Plantas' table. You can move, or remove it, as needed.
            this.plantasTableAdapter.Fill(this.sVDPMRADataSet1.Plantas);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.plantasTableAdapter1.FillBy(this.sVDPMRADataSet6.Plantas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbfoto.ImageLocation = dgplanta.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbfoto.ImageLocation = dgplanta.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SVDMP_RA.Principal frm1 = (SVDMP_RA.Principal)this.MdiParent;
            frm1.codpla.Text = dgplanta.SelectedRows[0].Cells[0].Value.ToString();
            SVDMP_RA.Principal frm2 = (SVDMP_RA.Principal)this.MdiParent;
            frm2.tlplanta.Text = dgplanta.SelectedRows[0].Cells[2].Value.ToString();
            MessageBox.Show("Planta Selecionada com Sucesso");
            this.Close();
        }

        private void dgplanta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbfoto.ImageLocation = dgplanta.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void dgplanta_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbfoto.ImageLocation = dgplanta.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void dgplanta_KeyDown(object sender, KeyEventArgs e)
        {
            lbfoto.ImageLocation = dgplanta.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void dgplanta_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbfoto.ImageLocation = dgplanta.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void dgplanta_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbfoto.ImageLocation = dgplanta.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void lbnomimovel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbcep_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbfoto_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
