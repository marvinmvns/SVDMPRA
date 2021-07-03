namespace SVDMP_RA
{
    partial class frmclicon
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
            System.Windows.Forms.Label nome_do_ClienteLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmclicon));
            this.lbrg = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.TextBox();
            this.lbcodcli = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.fechar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gdvDadosSQLServer2 = new System.Windows.Forms.DataGridView();
            this.codClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filhosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telconDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sVDPMRADataSet3 = new tela.SVDPMRADataSet3();
            this.lbcpf = new System.Windows.Forms.TextBox();
            this.alterar = new System.Windows.Forms.Button();
            this.sVDPMRADataSet4 = new tela.SVDPMRADataSet4();
            this.sVDPMRADataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new tela.SVDPMRADataSet3TableAdapters.ClienteTableAdapter();
            nome_do_ClienteLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDadosSQLServer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nome_do_ClienteLabel
            // 
            nome_do_ClienteLabel.AutoSize = true;
            nome_do_ClienteLabel.Location = new System.Drawing.Point(36, 43);
            nome_do_ClienteLabel.Name = "nome_do_ClienteLabel";
            nome_do_ClienteLabel.Size = new System.Drawing.Size(88, 13);
            nome_do_ClienteLabel.TabIndex = 98;
            nome_do_ClienteLabel.Text = "Nome do Cliente:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(238, 18);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(26, 13);
            rGLabel.TabIndex = 101;
            rGLabel.Text = "RG:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(94, 18);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 102;
            cPFLabel.Text = "CPF:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(362, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 13);
            label1.TabIndex = 103;
            label1.Text = "Cod Cliente:";
            // 
            // lbrg
            // 
            this.lbrg.Location = new System.Drawing.Point(270, 14);
            this.lbrg.Name = "lbrg";
            this.lbrg.Size = new System.Drawing.Size(86, 20);
            this.lbrg.TabIndex = 2;
            this.lbrg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbrg_KeyPress);
            // 
            // lbnome
            // 
            this.lbnome.Location = new System.Drawing.Point(136, 40);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(382, 20);
            this.lbnome.TabIndex = 4;
            this.lbnome.TextChanged += new System.EventHandler(this.lbnome_TextChanged);
            // 
            // lbcodcli
            // 
            this.lbcodcli.Location = new System.Drawing.Point(432, 13);
            this.lbcodcli.Name = "lbcodcli";
            this.lbcodcli.Size = new System.Drawing.Size(86, 20);
            this.lbcodcli.TabIndex = 3;
            this.lbcodcli.TextChanged += new System.EventHandler(this.lbcodcli_TextChanged);
            this.lbcodcli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbcodcli_KeyPress);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(524, 12);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(77, 48);
            this.btnProcurar.TabIndex = 5;
            this.btnProcurar.Text = "Consultar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.button1_Click);
            // 
            // apagar
            // 
            this.apagar.Location = new System.Drawing.Point(357, 285);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(75, 23);
            this.apagar.TabIndex = 8;
            this.apagar.Text = "Apagar Registro";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // fechar
            // 
            this.fechar.Location = new System.Drawing.Point(500, 285);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(75, 23);
            this.fechar.TabIndex = 9;
            this.fechar.Text = "Fechar";
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gdvDadosSQLServer2
            // 
            this.gdvDadosSQLServer2.AllowUserToAddRows = false;
            this.gdvDadosSQLServer2.AllowUserToDeleteRows = false;
            this.gdvDadosSQLServer2.AllowUserToOrderColumns = true;
            this.gdvDadosSQLServer2.AutoGenerateColumns = false;
            this.gdvDadosSQLServer2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDadosSQLServer2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codClienteDataGridViewTextBoxColumn,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.filhosDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.telconDataGridViewTextBoxColumn,
            this.obsDataGridViewTextBoxColumn});
            this.gdvDadosSQLServer2.DataSource = this.clienteBindingSource;
            this.gdvDadosSQLServer2.Location = new System.Drawing.Point(15, 80);
            this.gdvDadosSQLServer2.Name = "gdvDadosSQLServer2";
            this.gdvDadosSQLServer2.ReadOnly = true;
            this.gdvDadosSQLServer2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvDadosSQLServer2.Size = new System.Drawing.Size(625, 192);
            this.gdvDadosSQLServer2.TabIndex = 106;
            this.gdvDadosSQLServer2.RowHeaderCellChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.gdvDadosSQLServer2_RowHeaderCellChanged);
            this.gdvDadosSQLServer2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gdvDadosSQLServer2_CellMouseClick);
            this.gdvDadosSQLServer2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvDadosSQLServer2_CellClick);
            this.gdvDadosSQLServer2.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gdvDadosSQLServer2_RowsRemoved);
            this.gdvDadosSQLServer2.Click += new System.EventHandler(this.gdvDadosSQLServer2_Click);
            this.gdvDadosSQLServer2.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.gdvDadosSQLServer2_ColumnAdded);
            this.gdvDadosSQLServer2.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.gdvDadosSQLServer2_ColumnRemoved);
            this.gdvDadosSQLServer2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvDadosSQLServer2_CellContentClick);
            // 
            // codClienteDataGridViewTextBoxColumn
            // 
            this.codClienteDataGridViewTextBoxColumn.DataPropertyName = "CodCliente";
            this.codClienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.codClienteDataGridViewTextBoxColumn.Name = "codClienteDataGridViewTextBoxColumn";
            this.codClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "NomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            this.nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            this.rGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filhosDataGridViewTextBoxColumn
            // 
            this.filhosDataGridViewTextBoxColumn.DataPropertyName = "Filhos";
            this.filhosDataGridViewTextBoxColumn.HeaderText = "Filhos";
            this.filhosDataGridViewTextBoxColumn.Name = "filhosDataGridViewTextBoxColumn";
            this.filhosDataGridViewTextBoxColumn.ReadOnly = true;
            this.filhosDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cEPDataGridViewTextBoxColumn.Visible = false;
            // 
            // telconDataGridViewTextBoxColumn
            // 
            this.telconDataGridViewTextBoxColumn.DataPropertyName = "telcon";
            this.telconDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telconDataGridViewTextBoxColumn.Name = "telconDataGridViewTextBoxColumn";
            this.telconDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obsDataGridViewTextBoxColumn
            // 
            this.obsDataGridViewTextBoxColumn.DataPropertyName = "Obs";
            this.obsDataGridViewTextBoxColumn.HeaderText = "Obs";
            this.obsDataGridViewTextBoxColumn.Name = "obsDataGridViewTextBoxColumn";
            this.obsDataGridViewTextBoxColumn.ReadOnly = true;
            this.obsDataGridViewTextBoxColumn.Visible = false;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.sVDPMRADataSet3;
            // 
            // sVDPMRADataSet3
            // 
            this.sVDPMRADataSet3.DataSetName = "SVDPMRADataSet3";
            this.sVDPMRADataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbcpf
            // 
            this.lbcpf.Location = new System.Drawing.Point(136, 13);
            this.lbcpf.Name = "lbcpf";
            this.lbcpf.Size = new System.Drawing.Size(86, 20);
            this.lbcpf.TabIndex = 1;
            this.lbcpf.TextChanged += new System.EventHandler(this.lbcpf_TextChanged);
            this.lbcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbcpf_KeyPress);
            // 
            // alterar
            // 
            this.alterar.Location = new System.Drawing.Point(207, 285);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(75, 23);
            this.alterar.TabIndex = 7;
            this.alterar.Text = "Alterar";
            this.alterar.UseVisualStyleBackColor = true;
            this.alterar.Click += new System.EventHandler(this.button2_Click);
            // 
            // sVDPMRADataSet4
            // 
            this.sVDPMRADataSet4.DataSetName = "SVDPMRADataSet4";
            this.sVDPMRADataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sVDPMRADataSet4BindingSource
            // 
            this.sVDPMRADataSet4BindingSource.DataSource = this.sVDPMRADataSet4;
            this.sVDPMRADataSet4BindingSource.Position = 0;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmclicon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(665, 320);
            this.Controls.Add(this.alterar);
            this.Controls.Add(this.lbcpf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.gdvDadosSQLServer2);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.lbcodcli);
            this.Controls.Add(label1);
            this.Controls.Add(this.lbrg);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(nome_do_ClienteLabel);
            this.Controls.Add(rGLabel);
            this.Controls.Add(cPFLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmclicon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta Cliente";
            this.Load += new System.EventHandler(this.frmclicon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvDadosSQLServer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVDPMRADataSet4BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lbrg;
        private System.Windows.Forms.TextBox lbnome;
        private System.Windows.Forms.TextBox lbcodcli;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gdvDadosSQLServer2;
        private System.Windows.Forms.TextBox lbcpf;
        private System.Windows.Forms.Button alterar;
        private System.Windows.Forms.BindingSource sVDPMRADataSet4BindingSource;
        private tela.SVDPMRADataSet4 sVDPMRADataSet4;
        private tela.SVDPMRADataSet3 sVDPMRADataSet3;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private tela.SVDPMRADataSet3TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filhosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telconDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
    }
}