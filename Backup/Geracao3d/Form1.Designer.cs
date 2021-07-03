namespace tela.Geracao3d
{
    partial class frmgeracao
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
            this.button2 = new System.Windows.Forms.Button();
            this.lbcxtip = new System.Windows.Forms.ComboBox();
            this.dvmoveis = new System.Windows.Forms.DataGridView();
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
            this.rotacaorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endfisicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moveisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sVDPMRADataSet11 = new tela.SVDPMRADataSet11();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbcodmovel = new System.Windows.Forms.TextBox();
            this.lbnmmovel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnexecutar = new System.Windows.Forms.Button();
            this.dgset = new System.Windows.Forms.DataGridView();
            this.codmovel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmovel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codmarcador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endfisico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endmarcador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.lbfoto = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tlclicod = new System.Windows.Forms.Label();
            this.tlnomecli = new System.Windows.Forms.Label();
            this.tlnomeim = new System.Windows.Forms.Label();
            this.tlplanta = new System.Windows.Forms.Label();
            this.codpla = new System.Windows.Forms.Label();
            this.codimovel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbnomeset = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbcodset = new System.Windows.Forms.Label();
            this.moveisTableAdapter = new tela.SVDPMRADataSet11TableAdapters.MoveisTableAdapter();
            this.codmark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvmoveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(665, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbcxtip
            // 
            this.lbcxtip.FormattingEnabled = true;
            this.lbcxtip.Location = new System.Drawing.Point(417, 100);
            this.lbcxtip.Name = "lbcxtip";
            this.lbcxtip.Size = new System.Drawing.Size(126, 21);
            this.lbcxtip.TabIndex = 7;
            // 
            // dvmoveis
            // 
            this.dvmoveis.AllowUserToAddRows = false;
            this.dvmoveis.AllowUserToDeleteRows = false;
            this.dvmoveis.AutoGenerateColumns = false;
            this.dvmoveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvmoveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.rotacaorDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.endfisicoDataGridViewTextBoxColumn,
            this.extDataGridViewTextBoxColumn});
            this.dvmoveis.DataSource = this.moveisBindingSource;
            this.dvmoveis.Location = new System.Drawing.Point(293, 139);
            this.dvmoveis.Name = "dvmoveis";
            this.dvmoveis.ReadOnly = true;
            this.dvmoveis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvmoveis.Size = new System.Drawing.Size(366, 220);
            this.dvmoveis.TabIndex = 8;
            this.dvmoveis.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvmoveis_CellMouseClick);
            this.dvmoveis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvmoveis_CellContentClick);
            this.dvmoveis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dvmoveis_KeyDown);
            this.dvmoveis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dvmoveis_KeyDown);
            this.dvmoveis.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dvmoveis_KeyDown);
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
            // 
            // transyDataGridViewTextBoxColumn
            // 
            this.transyDataGridViewTextBoxColumn.DataPropertyName = "Transy";
            this.transyDataGridViewTextBoxColumn.HeaderText = "Transy";
            this.transyDataGridViewTextBoxColumn.Name = "transyDataGridViewTextBoxColumn";
            this.transyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transzDataGridViewTextBoxColumn
            // 
            this.transzDataGridViewTextBoxColumn.DataPropertyName = "Transz";
            this.transzDataGridViewTextBoxColumn.HeaderText = "Transz";
            this.transzDataGridViewTextBoxColumn.Name = "transzDataGridViewTextBoxColumn";
            this.transzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // escalaxDataGridViewTextBoxColumn
            // 
            this.escalaxDataGridViewTextBoxColumn.DataPropertyName = "Escalax";
            this.escalaxDataGridViewTextBoxColumn.HeaderText = "Escalax";
            this.escalaxDataGridViewTextBoxColumn.Name = "escalaxDataGridViewTextBoxColumn";
            this.escalaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // escalayDataGridViewTextBoxColumn
            // 
            this.escalayDataGridViewTextBoxColumn.DataPropertyName = "Escalay";
            this.escalayDataGridViewTextBoxColumn.HeaderText = "Escalay";
            this.escalayDataGridViewTextBoxColumn.Name = "escalayDataGridViewTextBoxColumn";
            this.escalayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // escalazDataGridViewTextBoxColumn
            // 
            this.escalazDataGridViewTextBoxColumn.DataPropertyName = "Escalaz";
            this.escalazDataGridViewTextBoxColumn.HeaderText = "Escalaz";
            this.escalazDataGridViewTextBoxColumn.Name = "escalazDataGridViewTextBoxColumn";
            this.escalazDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rotacaoxDataGridViewTextBoxColumn
            // 
            this.rotacaoxDataGridViewTextBoxColumn.DataPropertyName = "Rotacaox";
            this.rotacaoxDataGridViewTextBoxColumn.HeaderText = "Rotacaox";
            this.rotacaoxDataGridViewTextBoxColumn.Name = "rotacaoxDataGridViewTextBoxColumn";
            this.rotacaoxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rotacaoyDataGridViewTextBoxColumn
            // 
            this.rotacaoyDataGridViewTextBoxColumn.DataPropertyName = "Rotacaoy";
            this.rotacaoyDataGridViewTextBoxColumn.HeaderText = "Rotacaoy";
            this.rotacaoyDataGridViewTextBoxColumn.Name = "rotacaoyDataGridViewTextBoxColumn";
            this.rotacaoyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rotacaozDataGridViewTextBoxColumn
            // 
            this.rotacaozDataGridViewTextBoxColumn.DataPropertyName = "Rotacaoz";
            this.rotacaozDataGridViewTextBoxColumn.HeaderText = "Rotacaoz";
            this.rotacaozDataGridViewTextBoxColumn.Name = "rotacaozDataGridViewTextBoxColumn";
            this.rotacaozDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rotacaorDataGridViewTextBoxColumn
            // 
            this.rotacaorDataGridViewTextBoxColumn.DataPropertyName = "Rotacaor";
            this.rotacaorDataGridViewTextBoxColumn.HeaderText = "Rotacaor";
            this.rotacaorDataGridViewTextBoxColumn.Name = "rotacaorDataGridViewTextBoxColumn";
            this.rotacaorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endfisicoDataGridViewTextBoxColumn
            // 
            this.endfisicoDataGridViewTextBoxColumn.DataPropertyName = "endfisico";
            this.endfisicoDataGridViewTextBoxColumn.HeaderText = "endfisico";
            this.endfisicoDataGridViewTextBoxColumn.Name = "endfisicoDataGridViewTextBoxColumn";
            this.endfisicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extDataGridViewTextBoxColumn
            // 
            this.extDataGridViewTextBoxColumn.DataPropertyName = "ext";
            this.extDataGridViewTextBoxColumn.HeaderText = "ext";
            this.extDataGridViewTextBoxColumn.Name = "extDataGridViewTextBoxColumn";
            this.extDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moveisBindingSource
            // 
            this.moveisBindingSource.DataMember = "Moveis";
            this.moveisBindingSource.DataSource = this.sVDPMRADataSet11;
            // 
            // sVDPMRADataSet11
            // 
            this.sVDPMRADataSet11.DataSetName = "SVDPMRADataSet11";
            this.sVDPMRADataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código do Movel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome do Móvel:";
            // 
            // lbcodmovel
            // 
            this.lbcodmovel.Location = new System.Drawing.Point(417, 76);
            this.lbcodmovel.Name = "lbcodmovel";
            this.lbcodmovel.Size = new System.Drawing.Size(126, 20);
            this.lbcodmovel.TabIndex = 11;
            // 
            // lbnmmovel
            // 
            this.lbnmmovel.Location = new System.Drawing.Point(417, 50);
            this.lbnmmovel.Name = "lbnmmovel";
            this.lbnmmovel.Size = new System.Drawing.Size(126, 20);
            this.lbnmmovel.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo de Movel:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(559, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 80);
            this.button5.TabIndex = 14;
            this.button5.Text = "Consultar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnexecutar
            // 
            this.btnexecutar.Location = new System.Drawing.Point(787, 366);
            this.btnexecutar.Name = "btnexecutar";
            this.btnexecutar.Size = new System.Drawing.Size(118, 48);
            this.btnexecutar.TabIndex = 16;
            this.btnexecutar.Text = "Executar";
            this.btnexecutar.UseVisualStyleBackColor = true;
            this.btnexecutar.Click += new System.EventHandler(this.button6_Click);
            // 
            // dgset
            // 
            this.dgset.AllowUserToAddRows = false;
            this.dgset.AllowUserToDeleteRows = false;
            this.dgset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codmovel,
            this.nmovel,
            this.Codmarcador,
            this.tx,
            this.ty,
            this.tz,
            this.ex,
            this.ey,
            this.ez,
            this.rx,
            this.ry,
            this.rz,
            this.rr,
            this.endfisico,
            this.endmarcador});
            this.dgset.Location = new System.Drawing.Point(708, 143);
            this.dgset.Name = "dgset";
            this.dgset.ReadOnly = true;
            this.dgset.Size = new System.Drawing.Size(267, 216);
            this.dgset.TabIndex = 17;
            // 
            // codmovel
            // 
            this.codmovel.HeaderText = "Codigo do Movel";
            this.codmovel.Name = "codmovel";
            this.codmovel.ReadOnly = true;
            this.codmovel.Width = 115;
            // 
            // nmovel
            // 
            this.nmovel.HeaderText = "Nome Movel";
            this.nmovel.Name = "nmovel";
            this.nmovel.ReadOnly = true;
            // 
            // Codmarcador
            // 
            this.Codmarcador.HeaderText = "Codigo Marcador";
            this.Codmarcador.Name = "Codmarcador";
            this.Codmarcador.ReadOnly = true;
            this.Codmarcador.Visible = false;
            // 
            // tx
            // 
            this.tx.HeaderText = "tx";
            this.tx.Name = "tx";
            this.tx.ReadOnly = true;
            // 
            // ty
            // 
            this.ty.HeaderText = "ty";
            this.ty.Name = "ty";
            this.ty.ReadOnly = true;
            this.ty.Visible = false;
            // 
            // tz
            // 
            this.tz.HeaderText = "tz";
            this.tz.Name = "tz";
            this.tz.ReadOnly = true;
            this.tz.Visible = false;
            // 
            // ex
            // 
            this.ex.HeaderText = "ex";
            this.ex.Name = "ex";
            this.ex.ReadOnly = true;
            this.ex.Visible = false;
            // 
            // ey
            // 
            this.ey.HeaderText = "ey";
            this.ey.Name = "ey";
            this.ey.ReadOnly = true;
            this.ey.Visible = false;
            // 
            // ez
            // 
            this.ez.HeaderText = "ez";
            this.ez.Name = "ez";
            this.ez.ReadOnly = true;
            this.ez.Visible = false;
            // 
            // rx
            // 
            this.rx.HeaderText = "rx";
            this.rx.Name = "rx";
            this.rx.ReadOnly = true;
            this.rx.Visible = false;
            // 
            // ry
            // 
            this.ry.HeaderText = "ry";
            this.ry.Name = "ry";
            this.ry.ReadOnly = true;
            this.ry.Visible = false;
            // 
            // rz
            // 
            this.rz.HeaderText = "rz";
            this.rz.Name = "rz";
            this.rz.ReadOnly = true;
            this.rz.Visible = false;
            // 
            // rr
            // 
            this.rr.HeaderText = "rr";
            this.rr.Name = "rr";
            this.rr.ReadOnly = true;
            // 
            // endfisico
            // 
            this.endfisico.HeaderText = "end3d";
            this.endfisico.Name = "endfisico";
            this.endfisico.ReadOnly = true;
            // 
            // endmarcador
            // 
            this.endmarcador.HeaderText = "endmarcador";
            this.endmarcador.Name = "endmarcador";
            this.endmarcador.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(705, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Objetos Selecionados";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(665, 252);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(37, 23);
            this.button8.TabIndex = 21;
            this.button8.Text = "<";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // lbfoto
            // 
            this.lbfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbfoto.Image = global::tela.Properties.Resources.semimagen;
            this.lbfoto.Location = new System.Drawing.Point(12, 139);
            this.lbfoto.Name = "lbfoto";
            this.lbfoto.Size = new System.Drawing.Size(256, 220);
            this.lbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lbfoto.TabIndex = 0;
            this.lbfoto.TabStop = false;
            this.lbfoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(14, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nome Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(21, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Cod:Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(15, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Nome Imóvel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(16, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Local Planta:";
            // 
            // tlclicod
            // 
            this.tlclicod.AutoSize = true;
            this.tlclicod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tlclicod.Location = new System.Drawing.Point(91, 44);
            this.tlclicod.Name = "tlclicod";
            this.tlclicod.Size = new System.Drawing.Size(118, 13);
            this.tlclicod.TabIndex = 26;
            this.tlclicod.Text = "Não Adicionado Cliente";
            this.tlclicod.Click += new System.EventHandler(this.tlclicod_Click);
            // 
            // tlnomecli
            // 
            this.tlnomecli.AutoSize = true;
            this.tlnomecli.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tlnomecli.Location = new System.Drawing.Point(91, 57);
            this.tlnomecli.Name = "tlnomecli";
            this.tlnomecli.Size = new System.Drawing.Size(118, 13);
            this.tlnomecli.TabIndex = 27;
            this.tlnomecli.Text = "Não Adicionado Cliente";
            // 
            // tlnomeim
            // 
            this.tlnomeim.AutoSize = true;
            this.tlnomeim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tlnomeim.Location = new System.Drawing.Point(91, 70);
            this.tlnomeim.Name = "tlnomeim";
            this.tlnomeim.Size = new System.Drawing.Size(117, 13);
            this.tlnomeim.TabIndex = 28;
            this.tlnomeim.Text = "Não Adicionado Imovel";
            // 
            // tlplanta
            // 
            this.tlplanta.AutoSize = true;
            this.tlplanta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tlplanta.Location = new System.Drawing.Point(91, 83);
            this.tlplanta.Name = "tlplanta";
            this.tlplanta.Size = new System.Drawing.Size(116, 13);
            this.tlplanta.TabIndex = 29;
            this.tlplanta.Text = "Não Adicionado Planta";
            this.tlplanta.Click += new System.EventHandler(this.tlplanta_Click);
            // 
            // codpla
            // 
            this.codpla.AutoSize = true;
            this.codpla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.codpla.Location = new System.Drawing.Point(213, 83);
            this.codpla.Name = "codpla";
            this.codpla.Size = new System.Drawing.Size(39, 13);
            this.codpla.TabIndex = 31;
            this.codpla.Text = "codpla";
            this.codpla.Visible = false;
            this.codpla.Click += new System.EventHandler(this.codpla_Click);
            // 
            // codimovel
            // 
            this.codimovel.AutoSize = true;
            this.codimovel.Location = new System.Drawing.Point(214, 70);
            this.codimovel.Name = "codimovel";
            this.codimovel.Size = new System.Drawing.Size(55, 13);
            this.codimovel.TabIndex = 32;
            this.codimovel.Text = "codimovel";
            this.codimovel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Nome do Set:";
            // 
            // lbnomeset
            // 
            this.lbnomeset.AutoSize = true;
            this.lbnomeset.Location = new System.Drawing.Point(92, 31);
            this.lbnomeset.Name = "lbnomeset";
            this.lbnomeset.Size = new System.Drawing.Size(114, 13);
            this.lbnomeset.TabIndex = 34;
            this.lbnomeset.Text = "Não Adicionado Nome";
            this.lbnomeset.Click += new System.EventHandler(this.lbnomeset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 48);
            this.button1.TabIndex = 35;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 48);
            this.button3.TabIndex = 36;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbcodset
            // 
            this.lbcodset.AutoSize = true;
            this.lbcodset.Location = new System.Drawing.Point(215, 57);
            this.lbcodset.Name = "lbcodset";
            this.lbcodset.Size = new System.Drawing.Size(39, 13);
            this.lbcodset.TabIndex = 37;
            this.lbcodset.Text = "codset";
            this.lbcodset.Visible = false;
            // 
            // moveisTableAdapter
            // 
            this.moveisTableAdapter.ClearBeforeFill = true;
            // 
            // codmark
            // 
            this.codmark.AutoSize = true;
            this.codmark.Location = new System.Drawing.Point(215, 44);
            this.codmark.Name = "codmark";
            this.codmark.Size = new System.Drawing.Size(48, 13);
            this.codmark.TabIndex = 38;
            this.codmark.Text = "codmark";
            this.codmark.Visible = false;
            // 
            // frmgeracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(987, 426);
            this.ControlBox = false;
            this.Controls.Add(this.codmark);
            this.Controls.Add(this.lbcodset);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbnomeset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.codimovel);
            this.Controls.Add(this.codpla);
            this.Controls.Add(this.tlplanta);
            this.Controls.Add(this.tlnomeim);
            this.Controls.Add(this.tlnomecli);
            this.Controls.Add(this.tlclicod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgset);
            this.Controls.Add(this.btnexecutar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbnmmovel);
            this.Controls.Add(this.lbcodmovel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvmoveis);
            this.Controls.Add(this.lbcxtip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbfoto);
            this.Name = "frmgeracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Geração 3D";
            this.Load += new System.EventHandler(this.frmgeracao_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmgeracao_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dvmoveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lbfoto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox lbcxtip;
        private System.Windows.Forms.DataGridView dvmoveis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lbcodmovel;
        private System.Windows.Forms.TextBox lbnmmovel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnexecutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label tlclicod;
        public System.Windows.Forms.Label tlnomecli;
        public System.Windows.Forms.Label tlnomeim;
        public System.Windows.Forms.Label codpla;
        public System.Windows.Forms.Label tlplanta;
        public System.Windows.Forms.Label codimovel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbnomeset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label lbcodset;
        public System.Windows.Forms.DataGridView dgset;
        private SVDPMRADataSet11 sVDPMRADataSet11;
        private System.Windows.Forms.BindingSource moveisBindingSource;
        private tela.SVDPMRADataSet11TableAdapters.MoveisTableAdapter moveisTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn rotacaorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endfisicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extDataGridViewTextBoxColumn;
        public System.Windows.Forms.Label codmark;
        private System.Windows.Forms.DataGridViewTextBoxColumn codmovel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmovel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codmarcador;
        private System.Windows.Forms.DataGridViewTextBoxColumn tx;
        private System.Windows.Forms.DataGridViewTextBoxColumn ty;
        private System.Windows.Forms.DataGridViewTextBoxColumn tz;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ez;
        private System.Windows.Forms.DataGridViewTextBoxColumn rx;
        private System.Windows.Forms.DataGridViewTextBoxColumn ry;
        private System.Windows.Forms.DataGridViewTextBoxColumn rz;
        private System.Windows.Forms.DataGridViewTextBoxColumn rr;
        private System.Windows.Forms.DataGridViewTextBoxColumn endfisico;
        private System.Windows.Forms.DataGridViewTextBoxColumn endmarcador;
    }
}