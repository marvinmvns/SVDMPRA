namespace tela.Móveis
{
    partial class frmmovcons
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
            this.lbnomemovel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labe1 = new System.Windows.Forms.Label();
            this.dgmovel = new System.Windows.Forms.DataGridView();
            this.codMovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomMovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipMovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escalaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escalayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escalazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotacaoxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotacaoyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotacaozDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endfisicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moveisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sVDPMRADataSet5 = new tela.SVDPMRADataSet5();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.moveisTableAdapter = new tela.SVDPMRADataSet5TableAdapters.MoveisTableAdapter();
            this.btnapagar = new System.Windows.Forms.Button();
            this.xctipo = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbfoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgmovel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnomemovel
            // 
            this.lbnomemovel.Location = new System.Drawing.Point(107, 32);
            this.lbnomemovel.Name = "lbnomemovel";
            this.lbnomemovel.Size = new System.Drawing.Size(134, 20);
            this.lbnomemovel.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(31, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Tipo do Móvel:";
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labe1.Location = new System.Drawing.Point(24, 32);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(85, 13);
            this.labe1.TabIndex = 82;
            this.labe1.Text = "Nome do Móvel:";
            // 
            // dgmovel
            // 
            this.dgmovel.AllowUserToAddRows = false;
            this.dgmovel.AllowUserToDeleteRows = false;
            this.dgmovel.AutoGenerateColumns = false;
            this.dgmovel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmovel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMovelDataGridViewTextBoxColumn,
            this.nomMovelDataGridViewTextBoxColumn,
            this.tipMovelDataGridViewTextBoxColumn,
            this.transxDataGridViewTextBoxColumn,
            this.transyDataGridViewTextBoxColumn,
            this.transzDataGridViewTextBoxColumn,
            this.escalaxDataGridViewTextBoxColumn,
            this.escalayDataGridViewTextBoxColumn,
            this.escalazDataGridViewTextBoxColumn,
            this.rotacaoxDataGridViewTextBoxColumn,
            this.rotacaoyDataGridViewTextBoxColumn,
            this.rotacaozDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.endfisicoDataGridViewTextBoxColumn,
            this.extDataGridViewTextBoxColumn});
            this.dgmovel.DataSource = this.moveisBindingSource;
            this.dgmovel.Location = new System.Drawing.Point(12, 114);
            this.dgmovel.Name = "dgmovel";
            this.dgmovel.ReadOnly = true;
            this.dgmovel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgmovel.Size = new System.Drawing.Size(311, 150);
            this.dgmovel.TabIndex = 86;
            this.dgmovel.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgmovel_CellMouseClick);
            this.dgmovel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgmovel_KeyDown);
            this.dgmovel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgmovel_KeyPress);
            this.dgmovel.Click += new System.EventHandler(this.dgmovel_Click);
            this.dgmovel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmovel_CellContentClick);
            // 
            // codMovelDataGridViewTextBoxColumn
            // 
            this.codMovelDataGridViewTextBoxColumn.DataPropertyName = "CodMovel";
            this.codMovelDataGridViewTextBoxColumn.HeaderText = "CodMovel";
            this.codMovelDataGridViewTextBoxColumn.Name = "codMovelDataGridViewTextBoxColumn";
            this.codMovelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomMovelDataGridViewTextBoxColumn
            // 
            this.nomMovelDataGridViewTextBoxColumn.DataPropertyName = "NomMovel";
            this.nomMovelDataGridViewTextBoxColumn.HeaderText = "NomMovel";
            this.nomMovelDataGridViewTextBoxColumn.Name = "nomMovelDataGridViewTextBoxColumn";
            this.nomMovelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipMovelDataGridViewTextBoxColumn
            // 
            this.tipMovelDataGridViewTextBoxColumn.DataPropertyName = "TipMovel";
            this.tipMovelDataGridViewTextBoxColumn.HeaderText = "TipMovel";
            this.tipMovelDataGridViewTextBoxColumn.Name = "tipMovelDataGridViewTextBoxColumn";
            this.tipMovelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transxDataGridViewTextBoxColumn
            // 
            this.transxDataGridViewTextBoxColumn.DataPropertyName = "Transx";
            this.transxDataGridViewTextBoxColumn.HeaderText = "Transx";
            this.transxDataGridViewTextBoxColumn.Name = "transxDataGridViewTextBoxColumn";
            this.transxDataGridViewTextBoxColumn.ReadOnly = true;
            this.transxDataGridViewTextBoxColumn.Visible = false;
            // 
            // transyDataGridViewTextBoxColumn
            // 
            this.transyDataGridViewTextBoxColumn.DataPropertyName = "Transy";
            this.transyDataGridViewTextBoxColumn.HeaderText = "Transy";
            this.transyDataGridViewTextBoxColumn.Name = "transyDataGridViewTextBoxColumn";
            this.transyDataGridViewTextBoxColumn.ReadOnly = true;
            this.transyDataGridViewTextBoxColumn.Visible = false;
            // 
            // transzDataGridViewTextBoxColumn
            // 
            this.transzDataGridViewTextBoxColumn.DataPropertyName = "Transz";
            this.transzDataGridViewTextBoxColumn.HeaderText = "Transz";
            this.transzDataGridViewTextBoxColumn.Name = "transzDataGridViewTextBoxColumn";
            this.transzDataGridViewTextBoxColumn.ReadOnly = true;
            this.transzDataGridViewTextBoxColumn.Visible = false;
            // 
            // escalaxDataGridViewTextBoxColumn
            // 
            this.escalaxDataGridViewTextBoxColumn.DataPropertyName = "Escalax";
            this.escalaxDataGridViewTextBoxColumn.HeaderText = "Escalax";
            this.escalaxDataGridViewTextBoxColumn.Name = "escalaxDataGridViewTextBoxColumn";
            this.escalaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.escalaxDataGridViewTextBoxColumn.Visible = false;
            // 
            // escalayDataGridViewTextBoxColumn
            // 
            this.escalayDataGridViewTextBoxColumn.DataPropertyName = "Escalay";
            this.escalayDataGridViewTextBoxColumn.HeaderText = "Escalay";
            this.escalayDataGridViewTextBoxColumn.Name = "escalayDataGridViewTextBoxColumn";
            this.escalayDataGridViewTextBoxColumn.ReadOnly = true;
            this.escalayDataGridViewTextBoxColumn.Visible = false;
            // 
            // escalazDataGridViewTextBoxColumn
            // 
            this.escalazDataGridViewTextBoxColumn.DataPropertyName = "Escalaz";
            this.escalazDataGridViewTextBoxColumn.HeaderText = "Escalaz";
            this.escalazDataGridViewTextBoxColumn.Name = "escalazDataGridViewTextBoxColumn";
            this.escalazDataGridViewTextBoxColumn.ReadOnly = true;
            this.escalazDataGridViewTextBoxColumn.Visible = false;
            // 
            // rotacaoxDataGridViewTextBoxColumn
            // 
            this.rotacaoxDataGridViewTextBoxColumn.DataPropertyName = "Rotacaox";
            this.rotacaoxDataGridViewTextBoxColumn.HeaderText = "Rotacaox";
            this.rotacaoxDataGridViewTextBoxColumn.Name = "rotacaoxDataGridViewTextBoxColumn";
            this.rotacaoxDataGridViewTextBoxColumn.ReadOnly = true;
            this.rotacaoxDataGridViewTextBoxColumn.Visible = false;
            // 
            // rotacaoyDataGridViewTextBoxColumn
            // 
            this.rotacaoyDataGridViewTextBoxColumn.DataPropertyName = "Rotacaoy";
            this.rotacaoyDataGridViewTextBoxColumn.HeaderText = "Rotacaoy";
            this.rotacaoyDataGridViewTextBoxColumn.Name = "rotacaoyDataGridViewTextBoxColumn";
            this.rotacaoyDataGridViewTextBoxColumn.ReadOnly = true;
            this.rotacaoyDataGridViewTextBoxColumn.Visible = false;
            // 
            // rotacaozDataGridViewTextBoxColumn
            // 
            this.rotacaozDataGridViewTextBoxColumn.DataPropertyName = "Rotacaoz";
            this.rotacaozDataGridViewTextBoxColumn.HeaderText = "Rotacaoz";
            this.rotacaozDataGridViewTextBoxColumn.Name = "rotacaozDataGridViewTextBoxColumn";
            this.rotacaozDataGridViewTextBoxColumn.ReadOnly = true;
            this.rotacaozDataGridViewTextBoxColumn.Visible = false;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // endfisicoDataGridViewTextBoxColumn
            // 
            this.endfisicoDataGridViewTextBoxColumn.DataPropertyName = "endfisico";
            this.endfisicoDataGridViewTextBoxColumn.HeaderText = "endfisico";
            this.endfisicoDataGridViewTextBoxColumn.Name = "endfisicoDataGridViewTextBoxColumn";
            this.endfisicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.endfisicoDataGridViewTextBoxColumn.Visible = false;
            // 
            // extDataGridViewTextBoxColumn
            // 
            this.extDataGridViewTextBoxColumn.DataPropertyName = "ext";
            this.extDataGridViewTextBoxColumn.HeaderText = "ext";
            this.extDataGridViewTextBoxColumn.Name = "extDataGridViewTextBoxColumn";
            this.extDataGridViewTextBoxColumn.ReadOnly = true;
            this.extDataGridViewTextBoxColumn.Visible = false;
            // 
            // moveisBindingSource
            // 
            this.moveisBindingSource.DataMember = "Moveis";
            this.moveisBindingSource.DataSource = this.sVDPMRADataSet5;
            // 
            // sVDPMRADataSet5
            // 
            this.sVDPMRADataSet5.DataSetName = "SVDPMRADataSet5";
            this.sVDPMRADataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(556, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 90;
            this.label8.Text = "Marcador Teste: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(338, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 87;
            this.label17.Text = "Imagem do Móvel";
            // 
            // button3
            // 
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(12, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 91;
            this.button3.Text = "Testar Objeto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(247, 32);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(77, 48);
            this.btnProcurar.TabIndex = 106;
            this.btnProcurar.Text = "Consultar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 107;
            this.button1.Text = "Alterar Móvel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // moveisTableAdapter
            // 
            this.moveisTableAdapter.ClearBeforeFill = true;
            // 
            // btnapagar
            // 
            this.btnapagar.Location = new System.Drawing.Point(194, 270);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(62, 23);
            this.btnapagar.TabIndex = 108;
            this.btnapagar.Text = "Apagar";
            this.btnapagar.UseVisualStyleBackColor = true;
            this.btnapagar.Click += new System.EventHandler(this.button2_Click);
            // 
            // xctipo
            // 
            this.xctipo.FormattingEnabled = true;
            this.xctipo.Location = new System.Drawing.Point(107, 55);
            this.xctipo.Name = "xctipo";
            this.xctipo.Size = new System.Drawing.Size(134, 21);
            this.xctipo.TabIndex = 109;
            this.xctipo.SelectedIndexChanged += new System.EventHandler(this.xctipo_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(262, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 23);
            this.button4.TabIndex = 110;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::tela.Properties.Resources.marcadortst0001;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(559, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // lbfoto
            // 
            this.lbfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbfoto.Image = global::tela.Properties.Resources.semimagen;
            this.lbfoto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbfoto.Location = new System.Drawing.Point(341, 118);
            this.lbfoto.Name = "lbfoto";
            this.lbfoto.Size = new System.Drawing.Size(212, 188);
            this.lbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lbfoto.TabIndex = 88;
            this.lbfoto.TabStop = false;
            // 
            // frmmovcons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 344);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.xctipo);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbfoto);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgmovel);
            this.Controls.Add(this.lbnomemovel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labe1);
            this.Name = "frmmovcons";
            this.Text = "Consulta de Móveis";
            this.Load += new System.EventHandler(this.frmmovcons_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmmovcons_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgmovel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lbnomemovel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.DataGridView dgmovel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox lbfoto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button button1;
        private SVDPMRADataSet5 sVDPMRADataSet5;
        private System.Windows.Forms.BindingSource moveisBindingSource;
        private tela.SVDPMRADataSet5TableAdapters.MoveisTableAdapter moveisTableAdapter;
        private System.Windows.Forms.Button btnapagar;
        private System.Windows.Forms.ComboBox xctipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipMovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn escalaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn escalayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn escalazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotacaoxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotacaoyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotacaozDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endfisicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
    }
}