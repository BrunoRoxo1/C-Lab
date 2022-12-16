namespace Aluguel
{
    partial class tn_Produtora
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
            System.Windows.Forms.Label id_ProdutoraLabel;
            System.Windows.Forms.Label nome_ProdutoraLabel;
            System.Windows.Forms.Label tamanho_ProdutoraLabel;
            System.Windows.Forms.Label avaliacao_ProdutoraLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tn_Produtora));
            this.db_aluguelDataSet = new Aluguel.db_aluguelDataSet();
            this.tbl_ProdutoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ProdutoraTableAdapter = new Aluguel.db_aluguelDataSetTableAdapters.tbl_ProdutoraTableAdapter();
            this.tableAdapterManager = new Aluguel.db_aluguelDataSetTableAdapters.TableAdapterManager();
            this.tbl_ProdutoraBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbl_ProdutoraBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_ProdutoraTextBox = new System.Windows.Forms.TextBox();
            this.nome_ProdutoraTextBox = new System.Windows.Forms.TextBox();
            this.tamanho_ProdutoraTextBox = new System.Windows.Forms.TextBox();
            this.avaliacao_ProdutoraTextBox = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            id_ProdutoraLabel = new System.Windows.Forms.Label();
            nome_ProdutoraLabel = new System.Windows.Forms.Label();
            tamanho_ProdutoraLabel = new System.Windows.Forms.Label();
            avaliacao_ProdutoraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_aluguelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProdutoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProdutoraBindingNavigator)).BeginInit();
            this.tbl_ProdutoraBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_ProdutoraLabel
            // 
            id_ProdutoraLabel.AutoSize = true;
            id_ProdutoraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_ProdutoraLabel.Location = new System.Drawing.Point(186, 74);
            id_ProdutoraLabel.Name = "id_ProdutoraLabel";
            id_ProdutoraLabel.Size = new System.Drawing.Size(130, 24);
            id_ProdutoraLabel.TabIndex = 1;
            id_ProdutoraLabel.Text = "id Produtora:";
            // 
            // nome_ProdutoraLabel
            // 
            nome_ProdutoraLabel.AutoSize = true;
            nome_ProdutoraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_ProdutoraLabel.Location = new System.Drawing.Point(147, 114);
            nome_ProdutoraLabel.Name = "nome_ProdutoraLabel";
            nome_ProdutoraLabel.Size = new System.Drawing.Size(169, 24);
            nome_ProdutoraLabel.TabIndex = 3;
            nome_ProdutoraLabel.Text = "Nome Produtora:";
            // 
            // tamanho_ProdutoraLabel
            // 
            tamanho_ProdutoraLabel.AutoSize = true;
            tamanho_ProdutoraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tamanho_ProdutoraLabel.Location = new System.Drawing.Point(115, 157);
            tamanho_ProdutoraLabel.Name = "tamanho_ProdutoraLabel";
            tamanho_ProdutoraLabel.Size = new System.Drawing.Size(201, 24);
            tamanho_ProdutoraLabel.TabIndex = 5;
            tamanho_ProdutoraLabel.Text = "Tamanho Produtora:";
            // 
            // avaliacao_ProdutoraLabel
            // 
            avaliacao_ProdutoraLabel.AutoSize = true;
            avaliacao_ProdutoraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            avaliacao_ProdutoraLabel.Location = new System.Drawing.Point(113, 203);
            avaliacao_ProdutoraLabel.Name = "avaliacao_ProdutoraLabel";
            avaliacao_ProdutoraLabel.Size = new System.Drawing.Size(203, 24);
            avaliacao_ProdutoraLabel.TabIndex = 7;
            avaliacao_ProdutoraLabel.Text = "Avaliacao Produtora:";
            // 
            // db_aluguelDataSet
            // 
            this.db_aluguelDataSet.DataSetName = "db_aluguelDataSet";
            this.db_aluguelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ProdutoraBindingSource
            // 
            this.tbl_ProdutoraBindingSource.DataMember = "tbl_Produtora";
            this.tbl_ProdutoraBindingSource.DataSource = this.db_aluguelDataSet;
            // 
            // tbl_ProdutoraTableAdapter
            // 
            this.tbl_ProdutoraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_clienteTableAdapter = null;
            this.tableAdapterManager.tbl_GeneroTableAdapter = null;
            this.tableAdapterManager.tbl_JogoTableAdapter = null;
            this.tableAdapterManager.tbl_ProdutoraTableAdapter = this.tbl_ProdutoraTableAdapter;
            this.tableAdapterManager.UpdateOrder = Aluguel.db_aluguelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_ProdutoraBindingNavigator
            // 
            this.tbl_ProdutoraBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_ProdutoraBindingNavigator.BindingSource = this.tbl_ProdutoraBindingSource;
            this.tbl_ProdutoraBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_ProdutoraBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_ProdutoraBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_ProdutoraBindingNavigatorSaveItem});
            this.tbl_ProdutoraBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_ProdutoraBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_ProdutoraBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_ProdutoraBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_ProdutoraBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_ProdutoraBindingNavigator.Name = "tbl_ProdutoraBindingNavigator";
            this.tbl_ProdutoraBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_ProdutoraBindingNavigator.Size = new System.Drawing.Size(665, 25);
            this.tbl_ProdutoraBindingNavigator.TabIndex = 0;
            this.tbl_ProdutoraBindingNavigator.Text = "bindingNavigator1";
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
            // tbl_ProdutoraBindingNavigatorSaveItem
            // 
            this.tbl_ProdutoraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_ProdutoraBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_ProdutoraBindingNavigatorSaveItem.Image")));
            this.tbl_ProdutoraBindingNavigatorSaveItem.Name = "tbl_ProdutoraBindingNavigatorSaveItem";
            this.tbl_ProdutoraBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbl_ProdutoraBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbl_ProdutoraBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_ProdutoraBindingNavigatorSaveItem_Click);
            // 
            // id_ProdutoraTextBox
            // 
            this.id_ProdutoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProdutoraBindingSource, "id_Produtora", true));
            this.id_ProdutoraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_ProdutoraTextBox.Location = new System.Drawing.Point(332, 74);
            this.id_ProdutoraTextBox.Name = "id_ProdutoraTextBox";
            this.id_ProdutoraTextBox.Size = new System.Drawing.Size(189, 29);
            this.id_ProdutoraTextBox.TabIndex = 2;
            // 
            // nome_ProdutoraTextBox
            // 
            this.nome_ProdutoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProdutoraBindingSource, "Nome_Produtora", true));
            this.nome_ProdutoraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_ProdutoraTextBox.Location = new System.Drawing.Point(332, 114);
            this.nome_ProdutoraTextBox.Name = "nome_ProdutoraTextBox";
            this.nome_ProdutoraTextBox.Size = new System.Drawing.Size(189, 29);
            this.nome_ProdutoraTextBox.TabIndex = 4;
            // 
            // tamanho_ProdutoraTextBox
            // 
            this.tamanho_ProdutoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProdutoraBindingSource, "Tamanho_Produtora", true));
            this.tamanho_ProdutoraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanho_ProdutoraTextBox.Location = new System.Drawing.Point(332, 157);
            this.tamanho_ProdutoraTextBox.Name = "tamanho_ProdutoraTextBox";
            this.tamanho_ProdutoraTextBox.Size = new System.Drawing.Size(189, 29);
            this.tamanho_ProdutoraTextBox.TabIndex = 6;
            // 
            // avaliacao_ProdutoraTextBox
            // 
            this.avaliacao_ProdutoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProdutoraBindingSource, "Avaliacao_Produtora", true));
            this.avaliacao_ProdutoraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avaliacao_ProdutoraTextBox.Location = new System.Drawing.Point(332, 203);
            this.avaliacao_ProdutoraTextBox.Name = "avaliacao_ProdutoraTextBox";
            this.avaliacao_ProdutoraTextBox.Size = new System.Drawing.Size(189, 29);
            this.avaliacao_ProdutoraTextBox.TabIndex = 8;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.Indigo;
            this.btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Limpar.Location = new System.Drawing.Point(377, 263);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(219, 66);
            this.btn_Limpar.TabIndex = 28;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Indigo;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Add.Location = new System.Drawing.Point(61, 263);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(219, 66);
            this.btn_Add.TabIndex = 29;
            this.btn_Add.Text = "Adcionar";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // tn_Produtora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(665, 377);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(avaliacao_ProdutoraLabel);
            this.Controls.Add(this.avaliacao_ProdutoraTextBox);
            this.Controls.Add(tamanho_ProdutoraLabel);
            this.Controls.Add(this.tamanho_ProdutoraTextBox);
            this.Controls.Add(nome_ProdutoraLabel);
            this.Controls.Add(this.nome_ProdutoraTextBox);
            this.Controls.Add(id_ProdutoraLabel);
            this.Controls.Add(this.id_ProdutoraTextBox);
            this.Controls.Add(this.tbl_ProdutoraBindingNavigator);
            this.Name = "tn_Produtora";
            this.Text = "Produtora";
            this.Load += new System.EventHandler(this.tn_Produtora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_aluguelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProdutoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProdutoraBindingNavigator)).EndInit();
            this.tbl_ProdutoraBindingNavigator.ResumeLayout(false);
            this.tbl_ProdutoraBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_aluguelDataSet db_aluguelDataSet;
        private System.Windows.Forms.BindingSource tbl_ProdutoraBindingSource;
        private db_aluguelDataSetTableAdapters.tbl_ProdutoraTableAdapter tbl_ProdutoraTableAdapter;
        private db_aluguelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_ProdutoraBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbl_ProdutoraBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_ProdutoraTextBox;
        private System.Windows.Forms.TextBox nome_ProdutoraTextBox;
        private System.Windows.Forms.TextBox tamanho_ProdutoraTextBox;
        private System.Windows.Forms.TextBox avaliacao_ProdutoraTextBox;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Add;
    }
}