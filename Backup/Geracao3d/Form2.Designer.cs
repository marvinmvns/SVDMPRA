namespace tela.Geracao3d
{
    partial class Form2
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
            this.btselect = new System.Windows.Forms.Button();
            this.dgmarcador = new System.Windows.Forms.DataGridView();
            this.codMarcadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomMarcadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endMarcadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoMarcadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sVDPMRADataSet8 = new tela.SVDPMRADataSet8();
            this.marcadorTableAdapter = new tela.SVDPMRADataSet8TableAdapters.MarcadorTableAdapter();
            this.lbfoto = new System.Windows.Forms.PictureBox();
            this.codset = new System.Windows.Forms.Label();
            this.codxxx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgmarcador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btselect
            // 
            this.btselect.Location = new System.Drawing.Point(136, 238);
            this.btselect.Name = "btselect";
            this.btselect.Size = new System.Drawing.Size(75, 23);
            this.btselect.TabIndex = 0;
            this.btselect.Text = "Selecionar";
            this.btselect.UseVisualStyleBackColor = true;
            this.btselect.Click += new System.EventHandler(this.OK_Click);
            // 
            // dgmarcador
            // 
            this.dgmarcador.AllowUserToAddRows = false;
            this.dgmarcador.AllowUserToDeleteRows = false;
            this.dgmarcador.AutoGenerateColumns = false;
            this.dgmarcador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmarcador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMarcadorDataGridViewTextBoxColumn,
            this.nomMarcadorDataGridViewTextBoxColumn,
            this.endMarcadorDataGridViewTextBoxColumn,
            this.fotoMarcadorDataGridViewTextBoxColumn});
            this.dgmarcador.DataSource = this.marcadorBindingSource;
            this.dgmarcador.Location = new System.Drawing.Point(40, 33);
            this.dgmarcador.Name = "dgmarcador";
            this.dgmarcador.ReadOnly = true;
            this.dgmarcador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgmarcador.Size = new System.Drawing.Size(304, 199);
            this.dgmarcador.TabIndex = 1;
            this.dgmarcador.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgmarcador_MouseClick);
            this.dgmarcador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgmarcador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgmarcador_KeyDown);
            this.dgmarcador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgmarcador_KeyUp);
            this.dgmarcador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codMarcadorDataGridViewTextBoxColumn
            // 
            this.codMarcadorDataGridViewTextBoxColumn.DataPropertyName = "CodMarcador";
            this.codMarcadorDataGridViewTextBoxColumn.FillWeight = 20F;
            this.codMarcadorDataGridViewTextBoxColumn.HeaderText = "Codigo do Marcador";
            this.codMarcadorDataGridViewTextBoxColumn.Name = "codMarcadorDataGridViewTextBoxColumn";
            this.codMarcadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codMarcadorDataGridViewTextBoxColumn.Width = 130;
            // 
            // nomMarcadorDataGridViewTextBoxColumn
            // 
            this.nomMarcadorDataGridViewTextBoxColumn.DataPropertyName = "NomMarcador";
            this.nomMarcadorDataGridViewTextBoxColumn.HeaderText = "Nome do Marcador";
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
            this.marcadorBindingSource.DataSource = this.sVDPMRADataSet8;
            // 
            // sVDPMRADataSet8
            // 
            this.sVDPMRADataSet8.DataSetName = "SVDPMRADataSet8";
            this.sVDPMRADataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcadorTableAdapter
            // 
            this.marcadorTableAdapter.ClearBeforeFill = true;
            // 
            // lbfoto
            // 
            this.lbfoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbfoto.Location = new System.Drawing.Point(366, 33);
            this.lbfoto.Name = "lbfoto";
            this.lbfoto.Size = new System.Drawing.Size(223, 199);
            this.lbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lbfoto.TabIndex = 2;
            this.lbfoto.TabStop = false;
            this.lbfoto.Click += new System.EventHandler(this.lbfoto_Click);
            // 
            // codset
            // 
            this.codset.AutoSize = true;
            this.codset.Location = new System.Drawing.Point(37, 9);
            this.codset.Name = "codset";
            this.codset.Size = new System.Drawing.Size(35, 13);
            this.codset.TabIndex = 3;
            this.codset.Text = "label1";
            // 
            // codxxx
            // 
            this.codxxx.AutoSize = true;
            this.codxxx.Location = new System.Drawing.Point(89, 9);
            this.codxxx.Name = "codxxx";
            this.codxxx.Size = new System.Drawing.Size(35, 13);
            this.codxxx.TabIndex = 4;
            this.codxxx.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 285);
            this.Controls.Add(this.codxxx);
            this.Controls.Add(this.codset);
            this.Controls.Add(this.lbfoto);
            this.Controls.Add(this.dgmarcador);
            this.Controls.Add(this.btselect);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgmarcador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btselect;
        private SVDPMRADataSet8 sVDPMRADataSet8;
        private System.Windows.Forms.BindingSource marcadorBindingSource;
        private tela.SVDPMRADataSet8TableAdapters.MarcadorTableAdapter marcadorTableAdapter;
        private System.Windows.Forms.PictureBox lbfoto;
        public System.Windows.Forms.DataGridView dgmarcador;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMarcadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMarcadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endMarcadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotoMarcadorDataGridViewTextBoxColumn;
        public System.Windows.Forms.Label codset;
        public System.Windows.Forms.Label codxxx;
    }
}