namespace tela.Marcadores
{
    partial class frmmarcador
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
            this.lbfoto = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nmmarcador = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lbnome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbfoto
            // 
            this.lbfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbfoto.Location = new System.Drawing.Point(47, 62);
            this.lbfoto.Name = "lbfoto";
            this.lbfoto.Size = new System.Drawing.Size(191, 167);
            this.lbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lbfoto.TabIndex = 0;
            this.lbfoto.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adicionar Foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nmmarcador
            // 
            this.nmmarcador.Location = new System.Drawing.Point(47, 36);
            this.nmmarcador.Name = "nmmarcador";
            this.nmmarcador.Size = new System.Drawing.Size(191, 20);
            this.nmmarcador.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(274, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Incluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(12, 39);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(38, 13);
            this.lbnome.TabIndex = 7;
            this.lbnome.Text = "Nome:";
            // 
            // frmmarcador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(361, 263);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.nmmarcador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbfoto);
            this.Name = "frmmarcador";
            this.Text = "Cadastrar Marcador";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox nmmarcador;
        public System.Windows.Forms.PictureBox lbfoto;
        public System.Windows.Forms.Label lbnome;
    }
}