namespace tela.Imoveis
{
    partial class frmaltimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmaltimo));
            this.button3 = new System.Windows.Forms.Button();
            this.lbconstr = new System.Windows.Forms.TextBox();
            this.lbc = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbcep = new System.Windows.Forms.TextBox();
            this.lbend = new System.Windows.Forms.TextBox();
            this.lbimovel = new System.Windows.Forms.TextBox();
            this.lbfoto = new System.Windows.Forms.PictureBox();
            this.lbc2 = new System.Windows.Forms.Label();
            this.lbe = new System.Windows.Forms.Label();
            this.lbt = new System.Windows.Forms.Label();
            this.lbn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            this.lbtipimovel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Alterar Foto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbconstr
            // 
            this.lbconstr.Location = new System.Drawing.Point(101, 84);
            this.lbconstr.Name = "lbconstr";
            this.lbconstr.Size = new System.Drawing.Size(155, 20);
            this.lbconstr.TabIndex = 1;
            // 
            // lbc
            // 
            this.lbc.AutoSize = true;
            this.lbc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbc.Location = new System.Drawing.Point(31, 87);
            this.lbc.Name = "lbc";
            this.lbc.Size = new System.Drawing.Size(64, 13);
            this.lbc.TabIndex = 44;
            this.lbc.Text = "Construtora:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(271, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Foto do Imóvel";
            // 
            // lbcep
            // 
            this.lbcep.Location = new System.Drawing.Point(101, 173);
            this.lbcep.Name = "lbcep";
            this.lbcep.Size = new System.Drawing.Size(154, 20);
            this.lbcep.TabIndex = 5;
            // 
            // lbend
            // 
            this.lbend.Location = new System.Drawing.Point(101, 151);
            this.lbend.Name = "lbend";
            this.lbend.Size = new System.Drawing.Size(154, 20);
            this.lbend.TabIndex = 4;
            // 
            // lbimovel
            // 
            this.lbimovel.Location = new System.Drawing.Point(101, 107);
            this.lbimovel.Name = "lbimovel";
            this.lbimovel.Size = new System.Drawing.Size(154, 20);
            this.lbimovel.TabIndex = 2;
            // 
            // lbfoto
            // 
            this.lbfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lbfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbfoto.Image = ((System.Drawing.Image)(resources.GetObject("lbfoto.Image")));
            this.lbfoto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbfoto.Location = new System.Drawing.Point(274, 54);
            this.lbfoto.Name = "lbfoto";
            this.lbfoto.Size = new System.Drawing.Size(232, 219);
            this.lbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lbfoto.TabIndex = 36;
            this.lbfoto.TabStop = false;
            // 
            // lbc2
            // 
            this.lbc2.AutoSize = true;
            this.lbc2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbc2.Location = new System.Drawing.Point(67, 176);
            this.lbc2.Name = "lbc2";
            this.lbc2.Size = new System.Drawing.Size(31, 13);
            this.lbc2.TabIndex = 35;
            this.lbc2.Text = "CEP:";
            // 
            // lbe
            // 
            this.lbe.AutoSize = true;
            this.lbe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbe.Location = new System.Drawing.Point(42, 154);
            this.lbe.Name = "lbe";
            this.lbe.Size = new System.Drawing.Size(56, 13);
            this.lbe.TabIndex = 34;
            this.lbe.Text = "Endereço:";
            // 
            // lbt
            // 
            this.lbt.AutoSize = true;
            this.lbt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbt.Location = new System.Drawing.Point(18, 133);
            this.lbt.Name = "lbt";
            this.lbt.Size = new System.Drawing.Size(80, 13);
            this.lbt.TabIndex = 33;
            this.lbt.Text = "Tipo do Imovel:";
            this.lbt.Click += new System.EventHandler(this.lbt_Click);
            // 
            // lbn
            // 
            this.lbn.AutoSize = true;
            this.lbn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbn.Location = new System.Drawing.Point(10, 110);
            this.lbn.Name = "lbn";
            this.lbn.Size = new System.Drawing.Size(87, 13);
            this.lbn.TabIndex = 32;
            this.lbn.Text = "Nome do Imovel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Codigo Imovel:";
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblcod.Location = new System.Drawing.Point(101, 66);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(26, 13);
            this.lblcod.TabIndex = 48;
            this.lblcod.Text = "Cod";
            // 
            // lbtipimovel
            // 
            this.lbtipimovel.FormattingEnabled = true;
            this.lbtipimovel.Items.AddRange(new object[] {
            "Casa",
            "Apartamento",
            "Pousada",
            "Chalé",
            "Kitnet"});
            this.lbtipimovel.Location = new System.Drawing.Point(101, 130);
            this.lbtipimovel.Name = "lbtipimovel";
            this.lbtipimovel.Size = new System.Drawing.Size(152, 21);
            this.lbtipimovel.TabIndex = 49;
            // 
            // frmaltimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(546, 340);
            this.Controls.Add(this.lbtipimovel);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbconstr);
            this.Controls.Add(this.lbc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbcep);
            this.Controls.Add(this.lbend);
            this.Controls.Add(this.lbimovel);
            this.Controls.Add(this.lbfoto);
            this.Controls.Add(this.lbc2);
            this.Controls.Add(this.lbe);
            this.Controls.Add(this.lbt);
            this.Controls.Add(this.lbn);
            this.Name = "frmaltimo";
            this.Text = "Modificação de Imóveis";
            this.Load += new System.EventHandler(this.frmaltimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbc2;
        private System.Windows.Forms.Label lbe;
        private System.Windows.Forms.Label lbt;
        private System.Windows.Forms.Label lbn;
        public System.Windows.Forms.TextBox lbconstr;
        public System.Windows.Forms.TextBox lbcep;
        public System.Windows.Forms.TextBox lbend;
        public System.Windows.Forms.TextBox lbimovel;
        public System.Windows.Forms.PictureBox lbfoto;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblcod;
        public System.Windows.Forms.ComboBox lbtipimovel;
    }
}