namespace tela.Geracao3d
{
    partial class frmaltset
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sVDPMRADataSet13 = new tela.SVDPMRADataSet13();
            this.sET3DBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sET3DTableAdapter = new tela.SVDPMRADataSet13TableAdapters.SET3DTableAdapter();
            this.codSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkCodImovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkCodPlantaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKCodClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKCodFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sET3DBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codSetDataGridViewTextBoxColumn,
            this.nomeSetDataGridViewTextBoxColumn,
            this.fkCodImovelDataGridViewTextBoxColumn,
            this.fkCodPlantaDataGridViewTextBoxColumn,
            this.fKCodClienteDataGridViewTextBoxColumn,
            this.fKCodFuncionarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sET3DBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(243, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sVDPMRADataSet13
            // 
            this.sVDPMRADataSet13.DataSetName = "SVDPMRADataSet13";
            this.sVDPMRADataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sET3DBindingSource
            // 
            this.sET3DBindingSource.DataMember = "SET3D";
            this.sET3DBindingSource.DataSource = this.sVDPMRADataSet13;
            // 
            // sET3DTableAdapter
            // 
            this.sET3DTableAdapter.ClearBeforeFill = true;
            // 
            // codSetDataGridViewTextBoxColumn
            // 
            this.codSetDataGridViewTextBoxColumn.DataPropertyName = "CodSet";
            this.codSetDataGridViewTextBoxColumn.HeaderText = "CodSet";
            this.codSetDataGridViewTextBoxColumn.Name = "codSetDataGridViewTextBoxColumn";
            this.codSetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeSetDataGridViewTextBoxColumn
            // 
            this.nomeSetDataGridViewTextBoxColumn.DataPropertyName = "NomeSet";
            this.nomeSetDataGridViewTextBoxColumn.HeaderText = "NomeSet";
            this.nomeSetDataGridViewTextBoxColumn.Name = "nomeSetDataGridViewTextBoxColumn";
            this.nomeSetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkCodImovelDataGridViewTextBoxColumn
            // 
            this.fkCodImovelDataGridViewTextBoxColumn.DataPropertyName = "Fk_CodImovel";
            this.fkCodImovelDataGridViewTextBoxColumn.HeaderText = "Fk_CodImovel";
            this.fkCodImovelDataGridViewTextBoxColumn.Name = "fkCodImovelDataGridViewTextBoxColumn";
            this.fkCodImovelDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkCodImovelDataGridViewTextBoxColumn.Visible = false;
            // 
            // fkCodPlantaDataGridViewTextBoxColumn
            // 
            this.fkCodPlantaDataGridViewTextBoxColumn.DataPropertyName = "Fk_CodPlanta";
            this.fkCodPlantaDataGridViewTextBoxColumn.HeaderText = "Fk_CodPlanta";
            this.fkCodPlantaDataGridViewTextBoxColumn.Name = "fkCodPlantaDataGridViewTextBoxColumn";
            this.fkCodPlantaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkCodPlantaDataGridViewTextBoxColumn.Visible = false;
            // 
            // fKCodClienteDataGridViewTextBoxColumn
            // 
            this.fKCodClienteDataGridViewTextBoxColumn.DataPropertyName = "FK_CodCliente";
            this.fKCodClienteDataGridViewTextBoxColumn.HeaderText = "FK_CodCliente";
            this.fKCodClienteDataGridViewTextBoxColumn.Name = "fKCodClienteDataGridViewTextBoxColumn";
            this.fKCodClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.fKCodClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // fKCodFuncionarioDataGridViewTextBoxColumn
            // 
            this.fKCodFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "FK_CodFuncionario";
            this.fKCodFuncionarioDataGridViewTextBoxColumn.HeaderText = "FK_CodFuncionario";
            this.fKCodFuncionarioDataGridViewTextBoxColumn.Name = "fKCodFuncionarioDataGridViewTextBoxColumn";
            this.fKCodFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fKCodFuncionarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Apagar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código do SET:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do SET:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 278);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(190, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 42);
            this.button4.TabIndex = 9;
            this.button4.Text = "Consultar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmaltset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 278);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmaltset";
            this.Text = "Consulta e Modificação de SET";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sET3DBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SVDPMRADataSet13 sVDPMRADataSet13;
        private System.Windows.Forms.BindingSource sET3DBindingSource;
        private tela.SVDPMRADataSet13TableAdapters.SET3DTableAdapter sET3DTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkCodImovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkCodPlantaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKCodClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKCodFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
    }
}