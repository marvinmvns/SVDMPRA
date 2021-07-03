namespace tela.Marcadores
{
    partial class consulmark
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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txmarc = new System.Windows.Forms.TextBox();
            this.lbfoto = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txcmarc = new System.Windows.Forms.TextBox();
            this.dgmark = new System.Windows.Forms.DataGridView();
            this.codMarcadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomMarcadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endMarcadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoMarcadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sVDPMRADataSet12 = new tela.SVDPMRADataSet12();
            this.marcadorTableAdapter = new tela.SVDPMRADataSet12TableAdapters.MarcadorTableAdapter();
            this.apagar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Codigo do Marcador:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 34);
            this.button3.TabIndex = 71;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(320, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Foto do Marcador:";
            // 
            // txmarc
            // 
            this.txmarc.Location = new System.Drawing.Point(118, 29);
            this.txmarc.Name = "txmarc";
            this.txmarc.Size = new System.Drawing.Size(96, 20);
            this.txmarc.TabIndex = 69;
            // 
            // lbfoto
            // 
            this.lbfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lbfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbfoto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbfoto.Location = new System.Drawing.Point(309, 73);
            this.lbfoto.Name = "lbfoto";
            this.lbfoto.Size = new System.Drawing.Size(232, 189);
            this.lbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lbfoto.TabIndex = 68;
            this.lbfoto.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(19, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Nome do Marcador:";
            // 
            // txcmarc
            // 
            this.txcmarc.Location = new System.Drawing.Point(118, 9);
            this.txcmarc.Name = "txcmarc";
            this.txcmarc.Size = new System.Drawing.Size(32, 20);
            this.txcmarc.TabIndex = 75;
            // 
            // dgmark
            // 
            this.dgmark.AllowUserToAddRows = false;
            this.dgmark.AllowUserToDeleteRows = false;
            this.dgmark.AutoGenerateColumns = false;
            this.dgmark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmark.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMarcadorDataGridViewTextBoxColumn,
            this.nomMarcadorDataGridViewTextBoxColumn,
            this.endMarcadorDataGridViewTextBoxColumn,
            this.fotoMarcadorDataGridViewTextBoxColumn});
            this.dgmark.DataSource = this.marcadorBindingSource;
            this.dgmark.Location = new System.Drawing.Point(12, 73);
            this.dgmark.Name = "dgmark";
            this.dgmark.ReadOnly = true;
            this.dgmark.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgmark.Size = new System.Drawing.Size(290, 189);
            this.dgmark.TabIndex = 76;
            this.dgmark.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgmark_CellMouseClick);
            this.dgmark.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmark_CellContentClick);
            this.dgmark.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgmark_MouseClick);
            this.dgmark.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmark_CellContentClick);
            this.dgmark.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmark_CellContentClick);
            this.dgmark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgmark_KeyDown);
            this.dgmark.Move += new System.EventHandler(this.dgmark_Move);
            this.dgmark.Click += new System.EventHandler(this.dgmark_Click);
            this.dgmark.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgmark_KeyUp);
            this.dgmark.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmark_CellContentClick);
            // 
            // codMarcadorDataGridViewTextBoxColumn
            // 
            this.codMarcadorDataGridViewTextBoxColumn.DataPropertyName = "CodMarcador";
            this.codMarcadorDataGridViewTextBoxColumn.HeaderText = "Cod Marcador";
            this.codMarcadorDataGridViewTextBoxColumn.Name = "codMarcadorDataGridViewTextBoxColumn";
            this.codMarcadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomMarcadorDataGridViewTextBoxColumn
            // 
            this.nomMarcadorDataGridViewTextBoxColumn.DataPropertyName = "NomMarcador";
            this.nomMarcadorDataGridViewTextBoxColumn.HeaderText = "Nome Marcador";
            this.nomMarcadorDataGridViewTextBoxColumn.Name = "nomMarcadorDataGridViewTextBoxColumn";
            this.nomMarcadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomMarcadorDataGridViewTextBoxColumn.Width = 130;
            // 
            // endMarcadorDataGridViewTextBoxColumn
            // 
            this.endMarcadorDataGridViewTextBoxColumn.DataPropertyName = "EndMarcador";
            this.endMarcadorDataGridViewTextBoxColumn.HeaderText = "EndMarcador";
            this.endMarcadorDataGridViewTextBoxColumn.Name = "endMarcadorDataGridViewTextBoxColumn";
            this.endMarcadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.endMarcadorDataGridViewTextBoxColumn.Visible = false;
            // 
            // fotoMarcadorDataGridViewTextBoxColumn
            // 
            this.fotoMarcadorDataGridViewTextBoxColumn.DataPropertyName = "FotoMarcador";
            this.fotoMarcadorDataGridViewTextBoxColumn.HeaderText = "FotoMarcador";
            this.fotoMarcadorDataGridViewTextBoxColumn.Name = "fotoMarcadorDataGridViewTextBoxColumn";
            this.fotoMarcadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.fotoMarcadorDataGridViewTextBoxColumn.Visible = false;
            // 
            // marcadorBindingSource
            // 
            this.marcadorBindingSource.DataMember = "Marcador";
            this.marcadorBindingSource.DataSource = this.sVDPMRADataSet12;
            // 
            // sVDPMRADataSet12
            // 
            this.sVDPMRADataSet12.DataSetName = "SVDPMRADataSet12";
            this.sVDPMRADataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcadorTableAdapter
            // 
            this.marcadorTableAdapter.ClearBeforeFill = true;
            // 
            // apagar
            // 
            this.apagar.Location = new System.Drawing.Point(22, 268);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(75, 23);
            this.apagar.TabIndex = 77;
            this.apagar.Text = "Apagar";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(217, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 79;
            this.button4.Text = "Fechar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // consulmark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(553, 297);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.dgmark);
            this.Controls.Add(this.txcmarc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txmarc);
            this.Controls.Add(this.lbfoto);
            this.Controls.Add(this.label5);
            this.Name = "consulmark";
            this.Text = "Consultar Marcador";
            this.Load += new System.EventHandler(this.consulmark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txmarc;
        private System.Windows.Forms.PictureBox lbfoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txcmarc;
        private System.Windows.Forms.DataGridView dgmark;
        private SVDPMRADataSet12 sVDPMRADataSet12;
        private System.Windows.Forms.BindingSource marcadorBindingSource;
        private tela.SVDPMRADataSet12TableAdapters.MarcadorTableAdapter marcadorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMarcadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMarcadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endMarcadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotoMarcadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button button4;
    }
}