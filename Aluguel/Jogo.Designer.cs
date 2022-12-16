namespace Aluguel
{
    partial class tn_Jogo
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
            System.Windows.Forms.Label id_JogoLabel;
            System.Windows.Forms.Label nome_GeneroLabel;
            System.Windows.Forms.Label nome_ProdutoraLabel;
            System.Windows.Forms.Label numCopia_JogoLabel;
            System.Windows.Forms.Label avaliacao_JogoLabel;
            System.Windows.Forms.Label nome_JogoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tn_Jogo));
            this.db_aluguelDataSet = new Aluguel.db_aluguelDataSet();
            this.tbl_JogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_JogoTableAdapter = new Aluguel.db_aluguelDataSetTableAdapters.tbl_JogoTableAdapter();
            this.tableAdapterManager = new Aluguel.db_aluguelDataSetTableAdapters.TableAdapterManager();
            this.tbl_JogoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbl_JogoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_JogoTextBox = new System.Windows.Forms.TextBox();
            this.nome_GeneroTextBox = new System.Windows.Forms.TextBox();
            this.nome_ProdutoraTextBox = new System.Windows.Forms.TextBox();
            this.numCopia_JogoTextBox = new System.Windows.Forms.TextBox();
            this.avaliacao_JogoTextBox = new System.Windows.Forms.TextBox();
            this.nome_JogoTextBox = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            id_JogoLabel = new System.Windows.Forms.Label();
            nome_GeneroLabel = new System.Windows.Forms.Label();
            nome_ProdutoraLabel = new System.Windows.Forms.Label();
            numCopia_JogoLabel = new System.Windows.Forms.Label();
            avaliacao_JogoLabel = new System.Windows.Forms.Label();
            nome_JogoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_aluguelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_JogoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_JogoBindingNavigator)).BeginInit();
            this.tbl_JogoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_JogoLabel
            // 
            id_JogoLabel.AutoSize = true;
            id_JogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_JogoLabel.Location = new System.Drawing.Point(186, 48);
            id_JogoLabel.Name = "id_JogoLabel";
            id_JogoLabel.Size = new System.Drawing.Size(85, 24);
            id_JogoLabel.TabIndex = 1;
            id_JogoLabel.Text = "id Jogo:";
            // 
            // nome_GeneroLabel
            // 
            nome_GeneroLabel.AutoSize = true;
            nome_GeneroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_GeneroLabel.Location = new System.Drawing.Point(130, 134);
            nome_GeneroLabel.Name = "nome_GeneroLabel";
            nome_GeneroLabel.Size = new System.Drawing.Size(148, 24);
            nome_GeneroLabel.TabIndex = 3;
            nome_GeneroLabel.Text = "Nome Genero:";
            // 
            // nome_ProdutoraLabel
            // 
            nome_ProdutoraLabel.AutoSize = true;
            nome_ProdutoraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_ProdutoraLabel.Location = new System.Drawing.Point(109, 186);
            nome_ProdutoraLabel.Name = "nome_ProdutoraLabel";
            nome_ProdutoraLabel.Size = new System.Drawing.Size(169, 24);
            nome_ProdutoraLabel.TabIndex = 5;
            nome_ProdutoraLabel.Text = "Nome Produtora:";
            // 
            // numCopia_JogoLabel
            // 
            numCopia_JogoLabel.AutoSize = true;
            numCopia_JogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numCopia_JogoLabel.Location = new System.Drawing.Point(109, 236);
            numCopia_JogoLabel.Name = "numCopia_JogoLabel";
            numCopia_JogoLabel.Size = new System.Drawing.Size(172, 24);
            numCopia_JogoLabel.TabIndex = 7;
            numCopia_JogoLabel.Text = "Num Copia Jogo:";
            // 
            // avaliacao_JogoLabel
            // 
            avaliacao_JogoLabel.AutoSize = true;
            avaliacao_JogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            avaliacao_JogoLabel.Location = new System.Drawing.Point(120, 285);
            avaliacao_JogoLabel.Name = "avaliacao_JogoLabel";
            avaliacao_JogoLabel.Size = new System.Drawing.Size(158, 24);
            avaliacao_JogoLabel.TabIndex = 9;
            avaliacao_JogoLabel.Text = "Avaliacao Jogo:";
            // 
            // nome_JogoLabel
            // 
            nome_JogoLabel.AutoSize = true;
            nome_JogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_JogoLabel.Location = new System.Drawing.Point(147, 92);
            nome_JogoLabel.Name = "nome_JogoLabel";
            nome_JogoLabel.Size = new System.Drawing.Size(124, 24);
            nome_JogoLabel.TabIndex = 11;
            nome_JogoLabel.Text = "Nome Jogo:";
            // 
            // db_aluguelDataSet
            // 
            this.db_aluguelDataSet.DataSetName = "db_aluguelDataSet";
            this.db_aluguelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_JogoBindingSource
            // 
            this.tbl_JogoBindingSource.DataMember = "tbl_Jogo";
            this.tbl_JogoBindingSource.DataSource = this.db_aluguelDataSet;
            // 
            // tbl_JogoTableAdapter
            // 
            this.tbl_JogoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_clienteTableAdapter = null;
            this.tableAdapterManager.tbl_GeneroTableAdapter = null;
            this.tableAdapterManager.tbl_JogoTableAdapter = this.tbl_JogoTableAdapter;
            this.tableAdapterManager.tbl_ProdutoraTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aluguel.db_aluguelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_JogoBindingNavigator
            // 
            this.tbl_JogoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_JogoBindingNavigator.BindingSource = this.tbl_JogoBindingSource;
            this.tbl_JogoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_JogoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_JogoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbl_JogoBindingNavigatorSaveItem});
            this.tbl_JogoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_JogoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_JogoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_JogoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_JogoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_JogoBindingNavigator.Name = "tbl_JogoBindingNavigator";
            this.tbl_JogoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_JogoBindingNavigator.Size = new System.Drawing.Size(634, 25);
            this.tbl_JogoBindingNavigator.TabIndex = 0;
            this.tbl_JogoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbl_JogoBindingNavigatorSaveItem
            // 
            this.tbl_JogoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_JogoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_JogoBindingNavigatorSaveItem.Image")));
            this.tbl_JogoBindingNavigatorSaveItem.Name = "tbl_JogoBindingNavigatorSaveItem";
            this.tbl_JogoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbl_JogoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbl_JogoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_JogoBindingNavigatorSaveItem_Click);
            // 
            // id_JogoTextBox
            // 
            this.id_JogoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_JogoBindingSource, "id_Jogo", true));
            this.id_JogoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_JogoTextBox.Location = new System.Drawing.Point(297, 48);
            this.id_JogoTextBox.Name = "id_JogoTextBox";
            this.id_JogoTextBox.Size = new System.Drawing.Size(216, 29);
            this.id_JogoTextBox.TabIndex = 2;
            this.id_JogoTextBox.TextChanged += new System.EventHandler(this.id_JogoTextBox_TextChanged);
            // 
            // nome_GeneroTextBox
            // 
            this.nome_GeneroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_JogoBindingSource, "Nome_Genero", true));
            this.nome_GeneroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_GeneroTextBox.Location = new System.Drawing.Point(297, 134);
            this.nome_GeneroTextBox.Name = "nome_GeneroTextBox";
            this.nome_GeneroTextBox.Size = new System.Drawing.Size(216, 29);
            this.nome_GeneroTextBox.TabIndex = 4;
            this.nome_GeneroTextBox.TextChanged += new System.EventHandler(this.nome_GeneroTextBox_TextChanged);
            // 
            // nome_ProdutoraTextBox
            // 
            this.nome_ProdutoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_JogoBindingSource, "Nome_Produtora", true));
            this.nome_ProdutoraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_ProdutoraTextBox.Location = new System.Drawing.Point(297, 183);
            this.nome_ProdutoraTextBox.Name = "nome_ProdutoraTextBox";
            this.nome_ProdutoraTextBox.Size = new System.Drawing.Size(216, 29);
            this.nome_ProdutoraTextBox.TabIndex = 6;
            this.nome_ProdutoraTextBox.TextChanged += new System.EventHandler(this.nome_ProdutoraTextBox_TextChanged);
            // 
            // numCopia_JogoTextBox
            // 
            this.numCopia_JogoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_JogoBindingSource, "NumCopia_Jogo", true));
            this.numCopia_JogoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCopia_JogoTextBox.Location = new System.Drawing.Point(298, 236);
            this.numCopia_JogoTextBox.Name = "numCopia_JogoTextBox";
            this.numCopia_JogoTextBox.Size = new System.Drawing.Size(216, 29);
            this.numCopia_JogoTextBox.TabIndex = 8;
            this.numCopia_JogoTextBox.TextChanged += new System.EventHandler(this.numCopia_JogoTextBox_TextChanged);
            // 
            // avaliacao_JogoTextBox
            // 
            this.avaliacao_JogoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_JogoBindingSource, "Avaliacao_Jogo", true));
            this.avaliacao_JogoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avaliacao_JogoTextBox.Location = new System.Drawing.Point(297, 285);
            this.avaliacao_JogoTextBox.Name = "avaliacao_JogoTextBox";
            this.avaliacao_JogoTextBox.Size = new System.Drawing.Size(216, 29);
            this.avaliacao_JogoTextBox.TabIndex = 10;
            this.avaliacao_JogoTextBox.TextChanged += new System.EventHandler(this.avaliacao_JogoTextBox_TextChanged);
            // 
            // nome_JogoTextBox
            // 
            this.nome_JogoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_JogoBindingSource, "Nome_Jogo", true));
            this.nome_JogoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_JogoTextBox.Location = new System.Drawing.Point(297, 92);
            this.nome_JogoTextBox.Name = "nome_JogoTextBox";
            this.nome_JogoTextBox.Size = new System.Drawing.Size(216, 29);
            this.nome_JogoTextBox.TabIndex = 12;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.Tan;
            this.btn_Limpar.Location = new System.Drawing.Point(357, 325);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(219, 66);
            this.btn_Limpar.TabIndex = 30;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Tan;
            this.btn_Add.Location = new System.Drawing.Point(41, 325);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(219, 66);
            this.btn_Add.TabIndex = 31;
            this.btn_Add.Text = "Adcionar";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // tn_Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 419);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(nome_JogoLabel);
            this.Controls.Add(this.nome_JogoTextBox);
            this.Controls.Add(avaliacao_JogoLabel);
            this.Controls.Add(this.avaliacao_JogoTextBox);
            this.Controls.Add(numCopia_JogoLabel);
            this.Controls.Add(this.numCopia_JogoTextBox);
            this.Controls.Add(nome_ProdutoraLabel);
            this.Controls.Add(this.nome_ProdutoraTextBox);
            this.Controls.Add(nome_GeneroLabel);
            this.Controls.Add(this.nome_GeneroTextBox);
            this.Controls.Add(id_JogoLabel);
            this.Controls.Add(this.id_JogoTextBox);
            this.Controls.Add(this.tbl_JogoBindingNavigator);
            this.Name = "tn_Jogo";
            this.Text = "Jogo";
            this.Load += new System.EventHandler(this.tn_Jogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_aluguelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_JogoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_JogoBindingNavigator)).EndInit();
            this.tbl_JogoBindingNavigator.ResumeLayout(false);
            this.tbl_JogoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_aluguelDataSet db_aluguelDataSet;
        private System.Windows.Forms.BindingSource tbl_JogoBindingSource;
        private db_aluguelDataSetTableAdapters.tbl_JogoTableAdapter tbl_JogoTableAdapter;
        private db_aluguelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_JogoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbl_JogoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_JogoTextBox;
        private System.Windows.Forms.TextBox nome_GeneroTextBox;
        private System.Windows.Forms.TextBox nome_ProdutoraTextBox;
        private System.Windows.Forms.TextBox numCopia_JogoTextBox;
        private System.Windows.Forms.TextBox avaliacao_JogoTextBox;
        private System.Windows.Forms.TextBox nome_JogoTextBox;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Add;
    }
}