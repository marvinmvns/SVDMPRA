namespace tela.Planta
{
    partial class Frmconpla
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.plantasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sVDPMRADataSet1 = new tela.SVDPMRADataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbcep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plantasTableAdapter = new tela.SVDPMRADataSet1TableAdapters.PlantasTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.lbnomimovel = new System.Windows.Forms.Label();
            this.lbcodimovel = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.dgplanta = new System.Windows.Forms.DataGridView();
            this.codPlantaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKCodImovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomAmbienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtQuadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endplantaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sVDPMRADataSet6 = new tela.SVDPMRADataSet6();
            this.plantasTableAdapter1 = new tela.SVDPMRADataSet6TableAdapters.PlantasTableAdapter();
            this.lbfoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.plantasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgplanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(253, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 23);
            this.button4.TabIndex = 59;
            this.button4.Text = "Apagar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(239, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 34);
            this.button3.TabIndex = 56;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // plantasBindingSource
            // 
            this.plantasBindingSource.DataMember = "Plantas";
            this.plantasBindingSource.DataSource = this.sVDPMRADataSet1;
            // 
            // sVDPMRADataSet1
            // 
            this.sVDPMRADataSet1.DataSetName = "SVDPMRADataSet1";
            this.sVDPMRADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 54;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(320, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Foto da Planta:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbcep
            // 
            this.lbcep.Location = new System.Drawing.Point(121, 51);
            this.lbcep.Name = "lbcep";
            this.lbcep.Size = new System.Drawing.Size(96, 20);
            this.lbcep.TabIndex = 51;
            this.lbcep.TextChanged += new System.EventHandler(this.lbcep_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(28, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Nome Ambiente:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Nome do Imóvel:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // plantasTableAdapter
            // 
            this.plantasTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(415, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 62;
            this.button5.Text = "Ampliar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // lbnomimovel
            // 
            this.lbnomimovel.AutoSize = true;
            this.lbnomimovel.Location = new System.Drawing.Point(121, 37);
            this.lbnomimovel.Name = "lbnomimovel";
            this.lbnomimovel.Size = new System.Drawing.Size(35, 13);
            this.lbnomimovel.TabIndex = 64;
            this.lbnomimovel.Text = "label4";
            this.lbnomimovel.Click += new System.EventHandler(this.lbnomimovel_Click);
            // 
            // lbcodimovel
            // 
            this.lbcodimovel.AutoSize = true;
            this.lbcodimovel.Location = new System.Drawing.Point(557, 9);
            this.lbcodimovel.Name = "lbcodimovel";
            this.lbcodimovel.Size = new System.Drawing.Size(35, 13);
            this.lbcodimovel.TabIndex = 63;
            this.lbcodimovel.Text = "label3";
            this.lbcodimovel.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(109, 285);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 23);
            this.button6.TabIndex = 65;
            this.button6.Text = "Alterar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dgplanta
            // 
            this.dgplanta.AllowUserToAddRows = false;
            this.dgplanta.AllowUserToDeleteRows = false;
            this.dgplanta.AutoGenerateColumns = false;
            this.dgplanta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgplanta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codPlantaDataGridViewTextBoxColumn,
            this.fKCodImovelDataGridViewTextBoxColumn,
            this.nomAmbienteDataGridViewTextBoxColumn,
            this.mtQuadDataGridViewTextBoxColumn,
            this.endplantaDataGridViewTextBoxColumn});
            this.dgplanta.DataSource = this.plantasBindingSource1;
            this.dgplanta.Location = new System.Drawing.Point(31, 90);
            this.dgplanta.Name = "dgplanta";
            this.dgplanta.ReadOnly = true;
            this.dgplanta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgplanta.Size = new System.Drawing.Size(286, 189);
            this.dgplanta.TabIndex = 66;
            this.dgplanta.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgplanta_CellMouseClick);
            this.dgplanta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgplanta.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgplanta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgplanta_CellClick);
            this.dgplanta.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgplanta_CellMouseDoubleClick);
            this.dgplanta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgplanta_KeyDown);
            this.dgplanta.Move += new System.EventHandler(this.button6_Click);
            this.dgplanta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgplanta_KeyPress);
            this.dgplanta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codPlantaDataGridViewTextBoxColumn
            // 
            this.codPlantaDataGridViewTextBoxColumn.DataPropertyName = "CodPlanta";
            this.codPlantaDataGridViewTextBoxColumn.HeaderText = "CodPlanta";
            this.codPlantaDataGridViewTextBoxColumn.Name = "codPlantaDataGridViewTextBoxColumn";
            this.codPlantaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codPlantaDataGridViewTextBoxColumn.Visible = false;
            // 
            // fKCodImovelDataGridViewTextBoxColumn
            // 
            this.fKCodImovelDataGridViewTextBoxColumn.DataPropertyName = "FK_CodImovel";
            this.fKCodImovelDataGridViewTextBoxColumn.HeaderText = "FK_CodImovel";
            this.fKCodImovelDataGridViewTextBoxColumn.Name = "fKCodImovelDataGridViewTextBoxColumn";
            this.fKCodImovelDataGridViewTextBoxColumn.ReadOnly = true;
            this.fKCodImovelDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomAmbienteDataGridViewTextBoxColumn
            // 
            this.nomAmbienteDataGridViewTextBoxColumn.DataPropertyName = "NomAmbiente";
            this.nomAmbienteDataGridViewTextBoxColumn.HeaderText = "NomAmbiente";
            this.nomAmbienteDataGridViewTextBoxColumn.Name = "nomAmbienteDataGridViewTextBoxColumn";
            this.nomAmbienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomAmbienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // mtQuadDataGridViewTextBoxColumn
            // 
            this.mtQuadDataGridViewTextBoxColumn.DataPropertyName = "MtQuad";
            this.mtQuadDataGridViewTextBoxColumn.HeaderText = "MtQuad";
            this.mtQuadDataGridViewTextBoxColumn.Name = "mtQuadDataGridViewTextBoxColumn";
            this.mtQuadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endplantaDataGridViewTextBoxColumn
            // 
            this.endplantaDataGridViewTextBoxColumn.DataPropertyName = "endplanta";
            this.endplantaDataGridViewTextBoxColumn.HeaderText = "endplanta";
            this.endplantaDataGridViewTextBoxColumn.Name = "endplantaDataGridViewTextBoxColumn";
            this.endplantaDataGridViewTextBoxColumn.ReadOnly = true;
            this.endplantaDataGridViewTextBoxColumn.Visible = false;
            // 
            // plantasBindingSource1
            // 
            this.plantasBindingSource1.DataMember = "Plantas";
            this.plantasBindingSource1.DataSource = this.sVDPMRADataSet6;
            // 
            // sVDPMRADataSet6
            // 
            this.sVDPMRADataSet6.DataSetName = "SVDPMRADataSet6";
            this.sVDPMRADataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plantasTableAdapter1
            // 
            this.plantasTableAdapter1.ClearBeforeFill = true;
            // 
            // lbfoto
            // 
            this.lbfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lbfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbfoto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbfoto.Location = new System.Drawing.Point(323, 89);
            this.lbfoto.Name = "lbfoto";
            this.lbfoto.Size = new System.Drawing.Size(232, 189);
            this.lbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lbfoto.TabIndex = 50;
            this.lbfoto.TabStop = false;
            this.lbfoto.Click += new System.EventHandler(this.lbfoto_Click);
            // 
            // Frmconpla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(612, 328);
            this.Controls.Add(this.dgplanta);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lbnomimovel);
            this.Controls.Add(this.lbcodimovel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbcep);
            this.Controls.Add(this.lbfoto);
            this.Controls.Add(this.label5);
            this.Name = "Frmconpla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frmconpla";
            this.Load += new System.EventHandler(this.Frmconpla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plantasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgplanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lbcep;
        private System.Windows.Forms.PictureBox lbfoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private SVDPMRADataSet1 sVDPMRADataSet1;
        private System.Windows.Forms.BindingSource plantasBindingSource;
        private tela.SVDPMRADataSet1TableAdapters.PlantasTableAdapter plantasTableAdapter;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Label lbnomimovel;
        public System.Windows.Forms.Label lbcodimovel;
        private System.Windows.Forms.Button button6;
        private SVDPMRADataSet6 sVDPMRADataSet6;
        private System.Windows.Forms.BindingSource plantasBindingSource1;
        private tela.SVDPMRADataSet6TableAdapters.PlantasTableAdapter plantasTableAdapter1;
        public System.Windows.Forms.DataGridView dgplanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPlantaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKCodImovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomAmbienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtQuadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endplantaDataGridViewTextBoxColumn;
    }
}