namespace Cadastro
{
    partial class Tl_Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.db_jogosDataSet1 = new Cadastro.db_jogosDataSet();
            this.tbl_JogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_JogoTableAdapter = new Cadastro.db_jogosDataSetTableAdapters.tbl_JogoTableAdapter();
            this.tableAdapterManager = new Cadastro.db_jogosDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menJogos = new System.Windows.Forms.ToolStripMenuItem();
            this.generoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.db_jogosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_JogoBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // db_jogosDataSet1
            // 
            this.db_jogosDataSet1.DataSetName = "db_jogosDataSet";
            this.db_jogosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_JogoBindingSource
            // 
            this.tbl_JogoBindingSource.DataMember = "tbl_Jogo";
            this.tbl_JogoBindingSource.DataSource = this.db_jogosDataSet1;
            // 
            // tbl_JogoTableAdapter
            // 
            this.tbl_JogoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_GeneroTableAdapter = null;
            this.tableAdapterManager.tbl_JogoTableAdapter = this.tbl_JogoTableAdapter;
            this.tableAdapterManager.tbl_ProdutorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cadastro.db_jogosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menJogos,
            this.generoToolStripMenuItem,
            this.produtorToolStripMenuItem,
            this.form4ToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // menJogos
            // 
            this.menJogos.Name = "menJogos";
            this.menJogos.Size = new System.Drawing.Size(180, 22);
            this.menJogos.Text = "Jogos";
            this.menJogos.Click += new System.EventHandler(this.menJogos_Click);
            // 
            // generoToolStripMenuItem
            // 
            this.generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            this.generoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generoToolStripMenuItem.Text = "Genero";
            this.generoToolStripMenuItem.Click += new System.EventHandler(this.generoToolStripMenuItem_Click);
            // 
            // produtorToolStripMenuItem
            // 
            this.produtorToolStripMenuItem.Name = "produtorToolStripMenuItem";
            this.produtorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtorToolStripMenuItem.Text = "Produtor";
            this.produtorToolStripMenuItem.Click += new System.EventHandler(this.produtorToolStripMenuItem_Click);
            // 
            // form4ToolStripMenuItem
            // 
            this.form4ToolStripMenuItem.Name = "form4ToolStripMenuItem";
            this.form4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.form4ToolStripMenuItem.Text = "form4";
            this.form4ToolStripMenuItem.Click += new System.EventHandler(this.form4ToolStripMenuItem_Click);
            // 
            // Tl_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 385);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tl_Cadastro";
            this.Text = "Tela Cadastro";
            this.Load += new System.EventHandler(this.Tl_Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_jogosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_JogoBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private db_jogosDataSet db_jogosDataSet1;
        private System.Windows.Forms.BindingSource tbl_JogoBindingSource;
        private db_jogosDataSetTableAdapters.tbl_JogoTableAdapter tbl_JogoTableAdapter;
        private db_jogosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menJogos;
        private System.Windows.Forms.ToolStripMenuItem generoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form4ToolStripMenuItem;
    }
}

