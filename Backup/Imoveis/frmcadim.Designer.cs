namespace SVDMP_RA
{
    partial class frmcadmov
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcadmov));
            this.lbcep = new System.Windows.Forms.TextBox();
            this.lbend = new System.Windows.Forms.TextBox();
            this.lbimovel = new System.Windows.Forms.TextBox();
            this.lbfoto = new System.Windows.Forms.PictureBox();
            this.lbc2 = new System.Windows.Forms.Label();
            this.lbe = new System.Windows.Forms.Label();
            this.lbt = new System.Windows.Forms.Label();
            this.lbn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbc = new System.Windows.Forms.Label();
            this.lbconstr = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.sVDPMRADataSet = new tela.SVDPMRADataSet();
            this.sVDPMRADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imoveisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imoveisTableAdapter = new tela.SVDPMRADataSetTableAdapters.ImoveisTableAdapter();
            this.lbtipimovel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imoveisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbcep
            // 
            this.lbcep.Location = new System.Drawing.Point(93, 157);
            this.lbcep.Name = "lbcep";
            this.lbcep.Size = new System.Drawing.Size(152, 20);
            this.lbcep.TabIndex = 5;
            this.lbcep.TextChanged += new System.EventHandler(this.lbcep_TextChanged);
            this.lbcep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbcep_KeyPress);
            // 
            // lbend
            // 
            this.lbend.Location = new System.Drawing.Point(93, 135);
            this.lbend.Name = "lbend";
            this.lbend.Size = new System.Drawing.Size(152, 20);
            this.lbend.TabIndex = 4;
            // 
            // lbimovel
            // 
            this.lbimovel.Location = new System.Drawing.Point(93, 90);
            this.lbimovel.Name = "lbimovel";
            this.lbimovel.Size = new System.Drawing.Size(152, 20);
            this.lbimovel.TabIndex = 2;
            this.lbimovel.TextChanged += new System.EventHandler(this.lbimovel_TextChanged);
            // 
            // lbfoto
            // 
            this.lbfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lbfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbfoto.Image = ((System.Drawing.Image)(resources.GetObject("lbfoto.Image")));
            this.lbfoto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbfoto.Location = new System.Drawing.Point(263, 51);
            this.lbfoto.Name = "lbfoto";
            this.lbfoto.Size = new System.Drawing.Size(232, 219);
            this.lbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lbfoto.TabIndex = 19;
            this.lbfoto.TabStop = false;
            this.lbfoto.Click += new System.EventHandler(this.lbfoto_Click);
            // 
            // lbc2
            // 
            this.lbc2.AutoSize = true;
            this.lbc2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbc2.Location = new System.Drawing.Point(56, 160);
            this.lbc2.Name = "lbc2";
            this.lbc2.Size = new System.Drawing.Size(31, 13);
            this.lbc2.TabIndex = 17;
            this.lbc2.Text = "CEP:";
            // 
            // lbe
            // 
            this.lbe.AutoSize = true;
            this.lbe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbe.Location = new System.Drawing.Point(32, 134);
            this.lbe.Name = "lbe";
            this.lbe.Size = new System.Drawing.Size(56, 13);
            this.lbe.TabIndex = 16;
            this.lbe.Text = "Endereço:";
            // 
            // lbt
            // 
            this.lbt.AutoSize = true;
            this.lbt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbt.Location = new System.Drawing.Point(7, 110);
            this.lbt.Name = "lbt";
            this.lbt.Size = new System.Drawing.Size(80, 13);
            this.lbt.TabIndex = 14;
            this.lbt.Text = "Tipo do Imovel:";
            // 
            // lbn
            // 
            this.lbn.AutoSize = true;
            this.lbn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbn.Location = new System.Drawing.Point(0, 91);
            this.lbn.Name = "lbn";
            this.lbn.Size = new System.Drawing.Size(87, 13);
            this.lbn.TabIndex = 13;
            this.lbn.Text = "Nome do Imovel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(260, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Foto do Imóvel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbc
            // 
            this.lbc.AutoSize = true;
            this.lbc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbc.Location = new System.Drawing.Point(22, 71);
            this.lbc.Name = "lbc";
            this.lbc.Size = new System.Drawing.Size(64, 13);
            this.lbc.TabIndex = 29;
            this.lbc.Text = "Construtora:";
            // 
            // lbconstr
            // 
            this.lbconstr.Location = new System.Drawing.Point(93, 69);
            this.lbconstr.Name = "lbconstr";
            this.lbconstr.Size = new System.Drawing.Size(152, 20);
            this.lbconstr.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(325, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Carregar Foto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sVDPMRADataSet
            // 
            this.sVDPMRADataSet.DataSetName = "SVDPMRADataSet";
            this.sVDPMRADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sVDPMRADataSetBindingSource
            // 
            this.sVDPMRADataSetBindingSource.DataSource = this.sVDPMRADataSet;
            this.sVDPMRADataSetBindingSource.Position = 0;
            // 
            // imoveisBindingSource
            // 
            this.imoveisBindingSource.DataMember = "Imoveis";
            this.imoveisBindingSource.DataSource = this.sVDPMRADataSetBindingSource;
            // 
            // imoveisTableAdapter
            // 
            this.imoveisTableAdapter.ClearBeforeFill = true;
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
            this.lbtipimovel.Location = new System.Drawing.Point(93, 112);
            this.lbtipimovel.Name = "lbtipimovel";
            this.lbtipimovel.Size = new System.Drawing.Size(152, 21);
            this.lbtipimovel.TabIndex = 3;
            this.lbtipimovel.SelectedIndexChanged += new System.EventHandler(this.lbtipim_SelectedIndexChanged);
            // 
            // frmcadmov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(507, 331);
            this.Controls.Add(this.lbtipimovel);
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
            this.Name = "frmcadmov";
            this.Text = "Cadastro de Imovel";
            this.Load += new System.EventHandler(this.frmcadmov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imoveisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lbcep;
        private System.Windows.Forms.TextBox lbend;
        private System.Windows.Forms.TextBox lbimovel;
        private System.Windows.Forms.PictureBox lbfoto;
        private System.Windows.Forms.Label lbc2;
        private System.Windows.Forms.Label lbe;
        private System.Windows.Forms.Label lbt;
        private System.Windows.Forms.Label lbn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbc;
        private System.Windows.Forms.TextBox lbconstr;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource sVDPMRADataSetBindingSource;
        private tela.SVDPMRADataSet sVDPMRADataSet;
        private System.Windows.Forms.BindingSource imoveisBindingSource;
        private tela.SVDPMRADataSetTableAdapters.ImoveisTableAdapter imoveisTableAdapter;
        public System.Windows.Forms.ComboBox lbtipimovel;
    }
}