namespace Aluguel
{
    partial class tn_Genero
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
            System.Windows.Forms.Label id_GeneroLabel;
            System.Windows.Forms.Label nome_GeneroLabel;
            System.Windows.Forms.Label faixaEt_GeneroLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tn_Genero));
            this.db_aluguelDataSet = new Aluguel.db_aluguelDataSet();
            this.tbl_GeneroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_GeneroTableAdapter = new Aluguel.db_aluguelDataSetTableAdapters.tbl_GeneroTableAdapter();
            this.tableAdapterManager = new Aluguel.db_aluguelDataSetTableAdapters.TableAdapterManager();
            this.tbl_GeneroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbl_GeneroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_GeneroTextBox = new System.Windows.Forms.TextBox();
            this.nome_GeneroTextBox = new System.Windows.Forms.TextBox();
            this.faixaEt_GeneroTextBox = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            id_GeneroLabel = new System.Windows.Forms.Label();
            nome_GeneroLabel = new System.Windows.Forms.Label();
            faixaEt_GeneroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_aluguelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GeneroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GeneroBindingNavigator)).BeginInit();
            this.tbl_GeneroBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_GeneroLabel
            // 
            id_GeneroLabel.AutoSize = true;
            id_GeneroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_GeneroLabel.Location = new System.Drawing.Point(156, 75);
            id_GeneroLabel.Name = "id_GeneroLabel";
            id_GeneroLabel.Size = new System.Drawing.Size(109, 24);
            id_GeneroLabel.TabIndex = 1;
            id_GeneroLabel.Text = "id Genero:";
            // 
            // nome_GeneroLabel
            // 
            nome_GeneroLabel.AutoSize = true;
            nome_GeneroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_GeneroLabel.Location = new System.Drawing.Point(117, 134);
            nome_GeneroLabel.Name = "nome_GeneroLabel";
            nome_GeneroLabel.Size = new System.Drawing.Size(148, 24);
            nome_GeneroLabel.TabIndex = 3;
            nome_GeneroLabel.Text = "Nome Genero:";
            // 
            // faixaEt_GeneroLabel
            // 
            faixaEt_GeneroLabel.AutoSize = true;
            faixaEt_GeneroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            faixaEt_GeneroLabel.Location = new System.Drawing.Point(97, 203);
            faixaEt_GeneroLabel.Name = "faixaEt_GeneroLabel";
            faixaEt_GeneroLabel.Size = new System.Drawing.Size(168, 24);
            faixaEt_GeneroLabel.TabIndex = 5;
            faixaEt_GeneroLabel.Text = "Faixa Et Genero:";
            // 
            // db_aluguelDataSet
            // 
            this.db_aluguelDataSet.DataSetName = "db_aluguelDataSet";
            this.db_aluguelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_GeneroBindingSource
            // 
            this.tbl_GeneroBindingSource.DataMember = "tbl_Genero";
            this.tbl_GeneroBindingSource.DataSource = this.db_aluguelDataSet;
            // 
            // tbl_GeneroTableAdapter
            // 
            this.tbl_GeneroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_clienteTableAdapter = null;
            this.tableAdapterManager.tbl_GeneroTableAdapter = this.tbl_GeneroTableAdapter;
            this.tableAdapterManager.tbl_JogoTableAdapter = null;
            this.tableAdapterManager.tbl_ProdutoraTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aluguel.db_aluguelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_GeneroBindingNavigator
            // 
            this.tbl_GeneroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_GeneroBindingNavigator.BindingSource = this.tbl_GeneroBindingSource;
            this.tbl_GeneroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_GeneroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_GeneroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_GeneroBindingNavigatorSaveItem});
            this.tbl_GeneroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_GeneroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_GeneroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_GeneroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_GeneroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_GeneroBindingNavigator.Name = "tbl_GeneroBindingNavigator";
            this.tbl_GeneroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_GeneroBindingNavigator.Size = new System.Drawing.Size(663, 25);
            this.tbl_GeneroBindingNavigator.TabIndex = 0;
            this.tbl_GeneroBindingNavigator.Text = "bindingNavigator1";
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
            // tbl_GeneroBindingNavigatorSaveItem
            // 
            this.tbl_GeneroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_GeneroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_GeneroBindingNavigatorSaveItem.Image")));
            this.tbl_GeneroBindingNavigatorSaveItem.Name = "tbl_GeneroBindingNavigatorSaveItem";
            this.tbl_GeneroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbl_GeneroBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbl_GeneroBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_GeneroBindingNavigatorSaveItem_Click);
            // 
            // id_GeneroTextBox
            // 
            this.id_GeneroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_GeneroBindingSource, "id_Genero", true));
            this.id_GeneroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_GeneroTextBox.Location = new System.Drawing.Point(276, 75);
            this.id_GeneroTextBox.Name = "id_GeneroTextBox";
            this.id_GeneroTextBox.Size = new System.Drawing.Size(223, 29);
            this.id_GeneroTextBox.TabIndex = 2;
            // 
            // nome_GeneroTextBox
            // 
            this.nome_GeneroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_GeneroBindingSource, "Nome_Genero", true));
            this.nome_GeneroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_GeneroTextBox.Location = new System.Drawing.Point(276, 129);
            this.nome_GeneroTextBox.Name = "nome_GeneroTextBox";
            this.nome_GeneroTextBox.Size = new System.Drawing.Size(223, 29);
            this.nome_GeneroTextBox.TabIndex = 4;
            // 
            // faixaEt_GeneroTextBox
            // 
            this.faixaEt_GeneroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_GeneroBindingSource, "FaixaEt_Genero", true));
            this.faixaEt_GeneroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faixaEt_GeneroTextBox.Location = new System.Drawing.Point(276, 203);
            this.faixaEt_GeneroTextBox.Name = "faixaEt_GeneroTextBox";
            this.faixaEt_GeneroTextBox.Size = new System.Drawing.Size(223, 29);
            this.faixaEt_GeneroTextBox.TabIndex = 6;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.Gray;
            this.btn_Limpar.Location = new System.Drawing.Point(358, 267);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(219, 66);
            this.btn_Limpar.TabIndex = 26;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Gray;
            this.btn_Add.Location = new System.Drawing.Point(42, 267);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(219, 66);
            this.btn_Add.TabIndex = 27;
            this.btn_Add.Text = "Adcionar";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // tn_Genero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(663, 389);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(faixaEt_GeneroLabel);
            this.Controls.Add(this.faixaEt_GeneroTextBox);
            this.Controls.Add(nome_GeneroLabel);
            this.Controls.Add(this.nome_GeneroTextBox);
            this.Controls.Add(id_GeneroLabel);
            this.Controls.Add(this.id_GeneroTextBox);
            this.Controls.Add(this.tbl_GeneroBindingNavigator);
            this.Name = "tn_Genero";
            this.Text = "Genero";
            this.Load += new System.EventHandler(this.tn_Genero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_aluguelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GeneroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GeneroBindingNavigator)).EndInit();
            this.tbl_GeneroBindingNavigator.ResumeLayout(false);
            this.tbl_GeneroBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_aluguelDataSet db_aluguelDataSet;
        private System.Windows.Forms.BindingSource tbl_GeneroBindingSource;
        private db_aluguelDataSetTableAdapters.tbl_GeneroTableAdapter tbl_GeneroTableAdapter;
        private db_aluguelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_GeneroBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbl_GeneroBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_GeneroTextBox;
        private System.Windows.Forms.TextBox nome_GeneroTextBox;
        private System.Windows.Forms.TextBox faixaEt_GeneroTextBox;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Add;
    }
}