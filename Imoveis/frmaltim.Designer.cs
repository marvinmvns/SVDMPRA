namespace SVDMP_RA
{
    partial class frmcodim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcodim));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbcep = new System.Windows.Forms.TextBox();
            this.lbfoto = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgimovel = new System.Windows.Forms.DataGridView();
            this.codImovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomConstrutoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomImovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoImovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endimgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imoveisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sVDPMRADataSet = new tela.SVDPMRADataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.lbconstr = new System.Windows.Forms.TextBox();
            this.lbc = new System.Windows.Forms.Label();
            this.imoveisTableAdapter = new tela.SVDPMRADataSetTableAdapters.ImoveisTableAdapter();
            this.btnapagar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgimovel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imoveisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(337, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Foto do Imóvel";
            // 
            // lbcep
            // 
            this.lbcep.Location = new System.Drawing.Point(82, 12);
            this.lbcep.Name = "lbcep";
            this.lbcep.Size = new System.Drawing.Size(72, 20);
            this.lbcep.TabIndex = 40;
            this.lbcep.TextChanged += new System.EventHandler(this.lbcep_TextChanged);
            this.lbcep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbcep_KeyPress);
            // 
            // lbfoto
            // 
            this.lbfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lbfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbfoto.Image = ((System.Drawing.Image)(resources.GetObject("lbfoto.Image")));
            this.lbfoto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbfoto.Location = new System.Drawing.Point(340, 65);
            this.lbfoto.Name = "lbfoto";
            this.lbfoto.Size = new System.Drawing.Size(232, 219);
            this.lbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lbfoto.TabIndex = 36;
            this.lbfoto.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "CEP:";
            // 
            // dgimovel
            // 
            this.dgimovel.AllowUserToAddRows = false;
            this.dgimovel.AllowUserToDeleteRows = false;
            this.dgimovel.AllowUserToOrderColumns = true;
            this.dgimovel.AutoGenerateColumns = false;
            this.dgimovel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgimovel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgimovel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codImovelDataGridViewTextBoxColumn,
            this.nomConstrutoraDataGridViewTextBoxColumn,
            this.nomImovelDataGridViewTextBoxColumn,
            this.tipoImovelDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.endimgDataGridViewTextBoxColumn});
            this.dgimovel.DataSource = this.imoveisBindingSource;
            this.dgimovel.Location = new System.Drawing.Point(12, 65);
            this.dgimovel.Name = "dgimovel";
            this.dgimovel.ReadOnly = true;
            this.dgimovel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgimovel.Size = new System.Drawing.Size(322, 189);
            this.dgimovel.TabIndex = 44;
            this.dgimovel.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgimovel_CellMouseClick);
            this.dgimovel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgimovel_MouseClick);
            this.dgimovel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgimovel_MouseClick);
            this.dgimovel.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgimovel_CellMouseMove);
            this.dgimovel.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgimovel_CellContentClick);
            this.dgimovel.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgimovel_UserDeletedRow);
            this.dgimovel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgimovel_CellContentClick);
            this.dgimovel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgimovel_KeyDown);
            this.dgimovel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbcep_KeyPress);
            this.dgimovel.Click += new System.EventHandler(this.dgimovel_Click);
            this.dgimovel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgimovel_KeyDown);
            this.dgimovel.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgimovel_ColumnRemoved);
            this.dgimovel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgimovel_CellContentClick);
            // 
            // codImovelDataGridViewTextBoxColumn
            // 
            this.codImovelDataGridViewTextBoxColumn.DataPropertyName = "CodImovel";
            this.codImovelDataGridViewTextBoxColumn.HeaderText = "CodImovel";
            this.codImovelDataGridViewTextBoxColumn.Name = "codImovelDataGridViewTextBoxColumn";
            this.codImovelDataGridViewTextBoxColumn.ReadOnly = true;
            this.codImovelDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomConstrutoraDataGridViewTextBoxColumn
            // 
            this.nomConstrutoraDataGridViewTextBoxColumn.DataPropertyName = "NomConstrutora";
            this.nomConstrutoraDataGridViewTextBoxColumn.HeaderText = "NomConstrutora";
            this.nomConstrutoraDataGridViewTextBoxColumn.Name = "nomConstrutoraDataGridViewTextBoxColumn";
            this.nomConstrutoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomImovelDataGridViewTextBoxColumn
            // 
            this.nomImovelDataGridViewTextBoxColumn.DataPropertyName = "NomImovel";
            this.nomImovelDataGridViewTextBoxColumn.HeaderText = "NomImovel";
            this.nomImovelDataGridViewTextBoxColumn.Name = "nomImovelDataGridViewTextBoxColumn";
            this.nomImovelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoImovelDataGridViewTextBoxColumn
            // 
            this.tipoImovelDataGridViewTextBoxColumn.DataPropertyName = "TipoImovel";
            this.tipoImovelDataGridViewTextBoxColumn.HeaderText = "TipoImovel";
            this.tipoImovelDataGridViewTextBoxColumn.Name = "tipoImovelDataGridViewTextBoxColumn";
            this.tipoImovelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endimgDataGridViewTextBoxColumn
            // 
            this.endimgDataGridViewTextBoxColumn.DataPropertyName = "endimg";
            this.endimgDataGridViewTextBoxColumn.HeaderText = "endimg";
            this.endimgDataGridViewTextBoxColumn.Name = "endimgDataGridViewTextBoxColumn";
            this.endimgDataGridViewTextBoxColumn.ReadOnly = true;
            this.endimgDataGridViewTextBoxColumn.Visible = false;
            // 
            // imoveisBindingSource
            // 
            this.imoveisBindingSource.DataMember = "Imoveis";
            this.imoveisBindingSource.DataSource = this.sVDPMRADataSet;
            // 
            // sVDPMRADataSet
            // 
            this.sVDPMRADataSet.DataSetName = "SVDPMRADataSet";
            this.sVDPMRADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 45;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbconstr
            // 
            this.lbconstr.Location = new System.Drawing.Point(82, 32);
            this.lbconstr.Name = "lbconstr";
            this.lbconstr.Size = new System.Drawing.Size(156, 20);
            this.lbconstr.TabIndex = 47;
            // 
            // lbc
            // 
            this.lbc.AutoSize = true;
            this.lbc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbc.Location = new System.Drawing.Point(12, 35);
            this.lbc.Name = "lbc";
            this.lbc.Size = new System.Drawing.Size(64, 13);
            this.lbc.TabIndex = 46;
            this.lbc.Text = "Construtora:";
            // 
            // imoveisTableAdapter
            // 
            this.imoveisTableAdapter.ClearBeforeFill = true;
            // 
            // btnapagar
            // 
            this.btnapagar.Location = new System.Drawing.Point(174, 261);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(75, 23);
            this.btnapagar.TabIndex = 48;
            this.btnapagar.Text = "Apagar";
            this.btnapagar.UseVisualStyleBackColor = true;
            this.btnapagar.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 49;
            this.button4.Text = "Alterar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // frmcodim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 320);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.lbconstr);
            this.Controls.Add(this.lbc);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgimovel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbcep);
            this.Controls.Add(this.lbfoto);
            this.Controls.Add(this.label5);
            this.Name = "frmcodim";
            this.Text = "Consulta Imóveis";
            this.Load += new System.EventHandler(this.frmcodim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgimovel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imoveisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lbcep;
        private System.Windows.Forms.PictureBox lbfoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgimovel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox lbconstr;
        private System.Windows.Forms.Label lbc;
        private tela.SVDPMRADataSet sVDPMRADataSet;
        private System.Windows.Forms.BindingSource imoveisBindingSource;
        private tela.SVDPMRADataSetTableAdapters.ImoveisTableAdapter imoveisTableAdapter;
        private System.Windows.Forms.Button btnapagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codImovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomConstrutoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomImovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoImovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endimgDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
    }
}