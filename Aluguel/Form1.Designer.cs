namespace Aluguel
{
    partial class Form1
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
            this.db_aluguelDataSet = new Aluguel.db_aluguelDataSet();
            this.tblclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_clienteTableAdapter = new Aluguel.db_aluguelDataSetTableAdapters.tbl_clienteTableAdapter();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeJogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_aluguelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.sexoClienteDataGridViewTextBoxColumn,
            this.cPFClienteDataGridViewTextBoxColumn,
            this.nomeJogoDataGridViewTextBoxColumn,
            this.cEPClienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblclienteBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // db_aluguelDataSet
            // 
            this.db_aluguelDataSet.DataSetName = "db_aluguelDataSet";
            this.db_aluguelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblclienteBindingSource
            // 
            this.tblclienteBindingSource.DataMember = "tbl_cliente";
            this.tblclienteBindingSource.DataSource = this.db_aluguelDataSet;
            // 
            // tbl_clienteTableAdapter
            // 
            this.tbl_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "Nome_Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "Nome_Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            // 
            // sexoClienteDataGridViewTextBoxColumn
            // 
            this.sexoClienteDataGridViewTextBoxColumn.DataPropertyName = "Sexo_Cliente";
            this.sexoClienteDataGridViewTextBoxColumn.HeaderText = "Sexo_Cliente";
            this.sexoClienteDataGridViewTextBoxColumn.Name = "sexoClienteDataGridViewTextBoxColumn";
            // 
            // cPFClienteDataGridViewTextBoxColumn
            // 
            this.cPFClienteDataGridViewTextBoxColumn.DataPropertyName = "CPF_Cliente";
            this.cPFClienteDataGridViewTextBoxColumn.HeaderText = "CPF_Cliente";
            this.cPFClienteDataGridViewTextBoxColumn.Name = "cPFClienteDataGridViewTextBoxColumn";
            // 
            // nomeJogoDataGridViewTextBoxColumn
            // 
            this.nomeJogoDataGridViewTextBoxColumn.DataPropertyName = "Nome_Jogo";
            this.nomeJogoDataGridViewTextBoxColumn.HeaderText = "Nome_Jogo";
            this.nomeJogoDataGridViewTextBoxColumn.Name = "nomeJogoDataGridViewTextBoxColumn";
            // 
            // cEPClienteDataGridViewTextBoxColumn
            // 
            this.cEPClienteDataGridViewTextBoxColumn.DataPropertyName = "CEP_Cliente";
            this.cEPClienteDataGridViewTextBoxColumn.HeaderText = "CEP_Cliente";
            this.cEPClienteDataGridViewTextBoxColumn.Name = "cEPClienteDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_aluguelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private db_aluguelDataSet db_aluguelDataSet;
        private System.Windows.Forms.BindingSource tblclienteBindingSource;
        private db_aluguelDataSetTableAdapters.tbl_clienteTableAdapter tbl_clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeJogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPClienteDataGridViewTextBoxColumn;
    }
}