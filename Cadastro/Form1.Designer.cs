namespace Cadastro
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
            this.db_jogosDataSet1 = new Cadastro.db_jogosDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbjogosDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblGeneroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_GeneroTableAdapter = new Cadastro.db_jogosDataSetTableAdapters.tbl_GeneroTableAdapter();
            this.idGeneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeGeneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.db_jogosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbjogosDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGeneroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // db_jogosDataSet1
            // 
            this.db_jogosDataSet1.DataSetName = "db_jogosDataSet";
            this.db_jogosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGeneroDataGridViewTextBoxColumn,
            this.nomeGeneroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblGeneroBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbjogosDataSet1BindingSource
            // 
            this.dbjogosDataSet1BindingSource.DataSource = this.db_jogosDataSet1;
            this.dbjogosDataSet1BindingSource.Position = 0;
            // 
            // tblGeneroBindingSource
            // 
            this.tblGeneroBindingSource.DataMember = "tbl_Genero";
            this.tblGeneroBindingSource.DataSource = this.dbjogosDataSet1BindingSource;
            // 
            // tbl_GeneroTableAdapter
            // 
            this.tbl_GeneroTableAdapter.ClearBeforeFill = true;
            // 
            // idGeneroDataGridViewTextBoxColumn
            // 
            this.idGeneroDataGridViewTextBoxColumn.DataPropertyName = "id_Genero";
            this.idGeneroDataGridViewTextBoxColumn.HeaderText = "id_Genero";
            this.idGeneroDataGridViewTextBoxColumn.Name = "idGeneroDataGridViewTextBoxColumn";
            // 
            // nomeGeneroDataGridViewTextBoxColumn
            // 
            this.nomeGeneroDataGridViewTextBoxColumn.DataPropertyName = "Nome_Genero";
            this.nomeGeneroDataGridViewTextBoxColumn.HeaderText = "Nome_Genero";
            this.nomeGeneroDataGridViewTextBoxColumn.Name = "nomeGeneroDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)(this.db_jogosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbjogosDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGeneroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private db_jogosDataSet db_jogosDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dbjogosDataSet1BindingSource;
        private System.Windows.Forms.BindingSource tblGeneroBindingSource;
        private db_jogosDataSetTableAdapters.tbl_GeneroTableAdapter tbl_GeneroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGeneroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeGeneroDataGridViewTextBoxColumn;
    }
}