namespace Cadastro
{
    partial class frProdutor
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
            System.Windows.Forms.Label id_ProdutorLabel;
            System.Windows.Forms.Label nome_ProdutoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frProdutor));
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Pesquisa = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_cadastar = new System.Windows.Forms.Button();
            this.db_jogosDataSet = new Cadastro.db_jogosDataSet();
            this.tbl_ProdutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ProdutorTableAdapter = new Cadastro.db_jogosDataSetTableAdapters.tbl_ProdutorTableAdapter();
            this.tableAdapterManager = new Cadastro.db_jogosDataSetTableAdapters.TableAdapterManager();
            this.tbl_ProdutorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbl_ProdutorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_ProdutorTextBox = new System.Windows.Forms.TextBox();
            this.nome_ProdutoTextBox = new System.Windows.Forms.TextBox();
            id_ProdutorLabel = new System.Windows.Forms.Label();
            nome_ProdutoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_jogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProdutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProdutorBindingNavigator)).BeginInit();
            this.tbl_ProdutorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_ProdutorLabel
            // 
            id_ProdutorLabel.AutoSize = true;
            id_ProdutorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_ProdutorLabel.Location = new System.Drawing.Point(26, 75);
            id_ProdutorLabel.Name = "id_ProdutorLabel";
            id_ProdutorLabel.Size = new System.Drawing.Size(107, 24);
            id_ProdutorLabel.TabIndex = 9;
            id_ProdutorLabel.Text = "Id Produtor:";
            // 
            // nome_ProdutoLabel
            // 
            nome_ProdutoLabel.AutoSize = true;
            nome_ProdutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_ProdutoLabel.Location = new System.Drawing.Point(10, 166);
            nome_ProdutoLabel.Name = "nome_ProdutoLabel";
            nome_ProdutoLabel.Size = new System.Drawing.Size(144, 24);
            nome_ProdutoLabel.TabIndex = 10;
            nome_ProdutoLabel.Text = "Nome Produtor:";
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Excluir.Location = new System.Drawing.Point(124, 266);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(150, 57);
            this.btn_Excluir.TabIndex = 5;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            // 
            // btn_Pesquisa
            // 
            this.btn_Pesquisa.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisa.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Pesquisa.Location = new System.Drawing.Point(319, 266);
            this.btn_Pesquisa.Name = "btn_Pesquisa";
            this.btn_Pesquisa.Size = new System.Drawing.Size(153, 57);
            this.btn_Pesquisa.TabIndex = 6;
            this.btn_Pesquisa.Text = "Pesquisar";
            this.btn_Pesquisa.UseVisualStyleBackColor = false;
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Alterar.Location = new System.Drawing.Point(319, 166);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(153, 57);
            this.btn_Alterar.TabIndex = 7;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            // 
            // btn_cadastar
            // 
            this.btn_cadastar.BackColor = System.Drawing.Color.LightBlue;
            this.btn_cadastar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cadastar.Location = new System.Drawing.Point(319, 62);
            this.btn_cadastar.Name = "btn_cadastar";
            this.btn_cadastar.Size = new System.Drawing.Size(153, 57);
            this.btn_cadastar.TabIndex = 8;
            this.btn_cadastar.Text = "Cadastrar";
            this.btn_cadastar.UseVisualStyleBackColor = false;
            // 
            // db_jogosDataSet
            // 
            this.db_jogosDataSet.DataSetName = "db_jogosDataSet";
            this.db_jogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ProdutorBindingSource
            // 
            this.tbl_ProdutorBindingSource.DataMember = "tbl_Produtor";
            this.tbl_ProdutorBindingSource.DataSource = this.db_jogosDataSet;
            // 
            // tbl_ProdutorTableAdapter
            // 
            this.tbl_ProdutorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_GeneroTableAdapter = null;
            this.tableAdapterManager.tbl_JogoTableAdapter = null;
            this.tableAdapterManager.tbl_ProdutorTableAdapter = this.tbl_ProdutorTableAdapter;
            this.tableAdapterManager.UpdateOrder = Cadastro.db_jogosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_ProdutorBindingNavigator
            // 
            this.tbl_ProdutorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_ProdutorBindingNavigator.BindingSource = this.tbl_ProdutorBindingSource;
            this.tbl_ProdutorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_ProdutorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_ProdutorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_ProdutorBindingNavigatorSaveItem});
            this.tbl_ProdutorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_ProdutorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_ProdutorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_ProdutorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_ProdutorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_ProdutorBindingNavigator.Name = "tbl_ProdutorBindingNavigator";
            this.tbl_ProdutorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_ProdutorBindingNavigator.Size = new System.Drawing.Size(533, 25);
            this.tbl_ProdutorBindingNavigator.TabIndex = 9;
            this.tbl_ProdutorBindingNavigator.Text = "bindingNavigator1";
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
            // tbl_ProdutorBindingNavigatorSaveItem
            // 
            this.tbl_ProdutorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_ProdutorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_ProdutorBindingNavigatorSaveItem.Image")));
            this.tbl_ProdutorBindingNavigatorSaveItem.Name = "tbl_ProdutorBindingNavigatorSaveItem";
            this.tbl_ProdutorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbl_ProdutorBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbl_ProdutorBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_ProdutorBindingNavigatorSaveItem_Click);
            // 
            // id_ProdutorTextBox
            // 
            this.id_ProdutorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProdutorBindingSource, "Id_Produtor", true));
            this.id_ProdutorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_ProdutorTextBox.Location = new System.Drawing.Point(193, 70);
            this.id_ProdutorTextBox.Name = "id_ProdutorTextBox";
            this.id_ProdutorTextBox.Size = new System.Drawing.Size(100, 29);
            this.id_ProdutorTextBox.TabIndex = 10;
            // 
            // nome_ProdutoTextBox
            // 
            this.nome_ProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProdutorBindingSource, "Nome_Produto", true));
            this.nome_ProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_ProdutoTextBox.Location = new System.Drawing.Point(193, 161);
            this.nome_ProdutoTextBox.Name = "nome_ProdutoTextBox";
            this.nome_ProdutoTextBox.Size = new System.Drawing.Size(100, 29);
            this.nome_ProdutoTextBox.TabIndex = 11;
            // 
            // frProdutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(533, 376);
            this.Controls.Add(nome_ProdutoLabel);
            this.Controls.Add(this.nome_ProdutoTextBox);
            this.Controls.Add(id_ProdutorLabel);
            this.Controls.Add(this.id_ProdutorTextBox);
            this.Controls.Add(this.tbl_ProdutorBindingNavigator);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Pesquisa);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_cadastar);
            this.Name = "frProdutor";
            this.Text = "Produtor";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_jogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProdutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProdutorBindingNavigator)).EndInit();
            this.tbl_ProdutorBindingNavigator.ResumeLayout(false);
            this.tbl_ProdutorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Pesquisa;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_cadastar;
        private db_jogosDataSet db_jogosDataSet;
        private System.Windows.Forms.BindingSource tbl_ProdutorBindingSource;
        private db_jogosDataSetTableAdapters.tbl_ProdutorTableAdapter tbl_ProdutorTableAdapter;
        private db_jogosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_ProdutorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbl_ProdutorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_ProdutorTextBox;
        private System.Windows.Forms.TextBox nome_ProdutoTextBox;
    }
}