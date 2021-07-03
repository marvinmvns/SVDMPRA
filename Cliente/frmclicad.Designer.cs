namespace SVDMP_RA
{
    partial class frmclicad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmclicad));
            this.email = new System.Windows.Forms.Label();
            this.nmclientelb = new System.Windows.Forms.Label();
            this.rg = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.Label();
            this.cep = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.txmail = new System.Windows.Forms.TextBox();
            this.txnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtobs = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txfilhos = new System.Windows.Forms.TextBox();
            this.telco = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txttelcol = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(3, 164);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(35, 13);
            this.email.TabIndex = 106;
            this.email.Text = "Email:";
            // 
            // nmclientelb
            // 
            this.nmclientelb.AutoSize = true;
            this.nmclientelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmclientelb.Location = new System.Drawing.Point(3, 120);
            this.nmclientelb.Name = "nmclientelb";
            this.nmclientelb.Size = new System.Drawing.Size(85, 13);
            this.nmclientelb.TabIndex = 98;
            this.nmclientelb.Text = "Nome Completo:";
            // 
            // rg
            // 
            this.rg.AutoSize = true;
            this.rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rg.Location = new System.Drawing.Point(244, 142);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(26, 13);
            this.rg.TabIndex = 101;
            this.rg.Text = "RG:";
            this.rg.Click += new System.EventHandler(this.rGLabel_Click);
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(3, 142);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(30, 13);
            this.cpf.TabIndex = 102;
            this.cpf.Text = "CPF:";
            // 
            // cep
            // 
            this.cep.AutoSize = true;
            this.cep.Location = new System.Drawing.Point(3, 186);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(31, 13);
            this.cep.TabIndex = 104;
            this.cep.Text = "CEP:";
            this.cep.Click += new System.EventHandler(this.cEPLabel_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(94, 323);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 26;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(297, 323);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 37;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(195, 323);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 38;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // txmail
            // 
            this.txmail.Location = new System.Drawing.Point(94, 161);
            this.txmail.Name = "txmail";
            this.txmail.Size = new System.Drawing.Size(278, 20);
            this.txmail.TabIndex = 4;
            // 
            // txnome
            // 
            this.txnome.Location = new System.Drawing.Point(94, 117);
            this.txnome.Name = "txnome";
            this.txnome.Size = new System.Drawing.Size(278, 20);
            this.txnome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 116;
            this.label1.Text = "Observação:";
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(91, 209);
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(281, 92);
            this.txtobs.TabIndex = 8;
            this.txtobs.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(158, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 118;
            this.label2.Text = "Filhos:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txfilhos
            // 
            this.txfilhos.Location = new System.Drawing.Point(201, 183);
            this.txfilhos.Name = "txfilhos";
            this.txfilhos.Size = new System.Drawing.Size(22, 20);
            this.txfilhos.TabIndex = 6;
            this.txfilhos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txfilhos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_Keypress);
            // 
            // telco
            // 
            this.telco.AutoSize = true;
            this.telco.Location = new System.Drawing.Point(229, 186);
            this.telco.Name = "telco";
            this.telco.Size = new System.Drawing.Size(65, 13);
            this.telco.TabIndex = 120;
            this.telco.Text = "Tel Contato:";
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(276, 139);
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(96, 20);
            this.txtrg.TabIndex = 3;
            this.txtrg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_Keypress);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(94, 139);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(126, 20);
            this.txtCPF.TabIndex = 2;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_Keypress);
            // 
            // txttelcol
            // 
            this.txttelcol.Location = new System.Drawing.Point(293, 183);
            this.txttelcol.Name = "txttelcol";
            this.txttelcol.Size = new System.Drawing.Size(79, 20);
            this.txttelcol.TabIndex = 7;
            this.txttelcol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_Keypress);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(94, 183);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(57, 20);
            this.txtCEP.TabIndex = 5;
            this.txtCEP.TextChanged += new System.EventHandler(this.txtCEP_TextChanged);
            this.txtCEP.Click += new System.EventHandler(this.txtCEP_Click);
            this.txtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_Keypress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(149, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmclicad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(406, 358);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txttelcol);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.telco);
            this.Controls.Add(this.txfilhos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.txnome);
            this.Controls.Add(this.nmclientelb);
            this.Controls.Add(this.rg);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmclicad";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmclicad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox txmail;
        private System.Windows.Forms.TextBox txnome;
        public System.Windows.Forms.Label nmclientelb;
        public System.Windows.Forms.Label email;
        public System.Windows.Forms.Label cpf;
        public System.Windows.Forms.Label rg;
        public System.Windows.Forms.Label cep;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtobs;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txfilhos;
        private System.Windows.Forms.Label telco;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txttelcol;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}