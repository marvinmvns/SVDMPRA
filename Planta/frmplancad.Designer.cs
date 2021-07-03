namespace tela.Planta
{
    partial class frmplancad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmplancad));
            this.button3 = new System.Windows.Forms.Button();
            this.txnomeambiente = new System.Windows.Forms.TextBox();
            this.lbc = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txmtquad = new System.Windows.Forms.TextBox();
            this.lbfoto = new System.Windows.Forms.PictureBox();
            this.lbn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbcodimovel = new System.Windows.Forms.Label();
            this.lbnomimovel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 46;
            this.button3.Text = "Carregar Foto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txnomeambiente
            // 
            this.txnomeambiente.Location = new System.Drawing.Point(146, 91);
            this.txnomeambiente.Name = "txnomeambiente";
            this.txnomeambiente.Size = new System.Drawing.Size(152, 20);
            this.txnomeambiente.TabIndex = 45;
            // 
            // lbc
            // 
            this.lbc.AutoSize = true;
            this.lbc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbc.Location = new System.Drawing.Point(39, 94);
            this.lbc.Name = "lbc";
            this.lbc.Size = new System.Drawing.Size(100, 13);
            this.lbc.TabIndex = 44;
            this.lbc.Text = "Nome do Ambiente:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(301, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Foto da Planta:";
            // 
            // txmtquad
            // 
            this.txmtquad.Location = new System.Drawing.Point(146, 111);
            this.txmtquad.Name = "txmtquad";
            this.txmtquad.Size = new System.Drawing.Size(152, 20);
            this.txmtquad.TabIndex = 37;
            // 
            // lbfoto
            // 
            this.lbfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lbfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbfoto.Image = ((System.Drawing.Image)(resources.GetObject("lbfoto.Image")));
            this.lbfoto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbfoto.Location = new System.Drawing.Point(304, 42);
            this.lbfoto.Name = "lbfoto";
            this.lbfoto.Size = new System.Drawing.Size(232, 219);
            this.lbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lbfoto.TabIndex = 36;
            this.lbfoto.TabStop = false;
            // 
            // lbn
            // 
            this.lbn.AutoSize = true;
            this.lbn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbn.Location = new System.Drawing.Point(114, 114);
            this.lbn.Name = "lbn";
            this.lbn.Size = new System.Drawing.Size(25, 13);
            this.lbn.TabIndex = 32;
            this.lbn.Text = "M² :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(47, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Codigo do Imovel:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(52, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nome do Imovel:";
            // 
            // lbcodimovel
            // 
            this.lbcodimovel.AutoSize = true;
            this.lbcodimovel.Location = new System.Drawing.Point(145, 55);
            this.lbcodimovel.Name = "lbcodimovel";
            this.lbcodimovel.Size = new System.Drawing.Size(35, 13);
            this.lbcodimovel.TabIndex = 49;
            this.lbcodimovel.Text = "label3";
            // 
            // lbnomimovel
            // 
            this.lbnomimovel.AutoSize = true;
            this.lbnomimovel.Location = new System.Drawing.Point(145, 71);
            this.lbnomimovel.Name = "lbnomimovel";
            this.lbnomimovel.Size = new System.Drawing.Size(35, 13);
            this.lbnomimovel.TabIndex = 50;
            this.lbnomimovel.Text = "label4";
            this.lbnomimovel.Click += new System.EventHandler(this.marcus2_Click);
            // 
            // frmplancad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 324);
            this.Controls.Add(this.lbnomimovel);
            this.Controls.Add(this.lbcodimovel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txnomeambiente);
            this.Controls.Add(this.lbc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txmtquad);
            this.Controls.Add(this.lbfoto);
            this.Controls.Add(this.lbn);
            this.Name = "frmplancad";
            this.Text = "Cadastro de Plantas";
            this.Load += new System.EventHandler(this.frmplancad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txnomeambiente;
        private System.Windows.Forms.Label lbc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txmtquad;
        private System.Windows.Forms.PictureBox lbfoto;
        private System.Windows.Forms.Label lbn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbcodimovel;
        public System.Windows.Forms.Label lbnomimovel;
    }
}