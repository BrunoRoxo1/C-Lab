namespace Cadastro
{
    partial class frGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frGenero));
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Pesquisa = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_cadastar = new System.Windows.Forms.Button();
            this.db_jogosDataSet = new Cadastro.db_jogosDataSet();
            this.tbl_GeneroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_GeneroTableAdapter = new Cadastro.db_jogosDataSetTableAdapters.tbl_GeneroTableAdapter();
            this.tableAdapterManager = new Cadastro.db_jogosDataSetTableAdapters.TableAdapterManager();
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
            id_GeneroLabel = new System.Windows.Forms.Label();
            nome_GeneroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_jogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GeneroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GeneroBindingNavigator)).BeginInit();
            this.tbl_GeneroBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_GeneroLabel
            // 
            id_GeneroLabel.AutoSize = true;
            id_GeneroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_GeneroLabel.Location = new System.Drawing.Point(35, 55);
            id_GeneroLabel.Name = "id_GeneroLabel";
            id_GeneroLabel.Size = new System.Drawing.Size(99, 24);
            id_GeneroLabel.TabIndex = 5;
            id_GeneroLabel.Text = "id Genero:";
            // 
            // nome_GeneroLabel
            // 
            nome_GeneroLabel.AutoSize = true;
            nome_GeneroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_GeneroLabel.Location = new System.Drawing.Point(35, 124);
            nome_GeneroLabel.Name = "nome_GeneroLabel";
            nome_GeneroLabel.Size = new System.Drawing.Size(136, 24);
            nome_GeneroLabel.TabIndex = 7;
            nome_GeneroLabel.Text = "Nome Genero:";
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.Coral;
            this.btn_Excluir.Location = new System.Drawing.Point(127, 235);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(150, 57);
            this.btn_Excluir.TabIndex = 1;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            // 
            // btn_Pesquisa
            // 
            this.btn_Pesquisa.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisa.ForeColor = System.Drawing.Color.Coral;
            this.btn_Pesquisa.Location = new System.Drawing.Point(322, 235);
            this.btn_Pesquisa.Name = "btn_Pesquisa";
            this.btn_Pesquisa.Size = new System.Drawing.Size(153, 57);
            this.btn_Pesquisa.TabIndex = 2;
            this.btn_Pesquisa.Text = "Pesquisar";
            this.btn_Pesquisa.UseVisualStyleBackColor = false;
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.Color.Coral;
            this.btn_Alterar.Location = new System.Drawing.Point(322, 135);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(153, 57);
            this.btn_Alterar.TabIndex = 3;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            // 
            // btn_cadastar
            // 
            this.btn_cadastar.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_cadastar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastar.ForeColor = System.Drawing.Color.Coral;
            this.btn_cadastar.Location = new System.Drawing.Point(322, 44);
            this.btn_cadastar.Name = "btn_cadastar";
            this.btn_cadastar.Size = new System.Drawing.Size(153, 57);
            this.btn_cadastar.TabIndex = 4;
            this.btn_cadastar.Text = "Cadastrar";
            this.btn_cadastar.UseVisualStyleBackColor = false;
            // 
            // db_jogosDataSet
            // 
            this.db_jogosDataSet.DataSetName = "db_jogosDataSet";
            this.db_jogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_GeneroBindingSource
            // 
            this.tbl_GeneroBindingSource.DataMember = "tbl_Genero";
            this.tbl_GeneroBindingSource.DataSource = this.db_jogosDataSet;
            // 
            // tbl_GeneroTableAdapter
            // 
            this.tbl_GeneroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_GeneroTableAdapter = this.tbl_GeneroTableAdapter;
            this.tableAdapterManager.tbl_JogoTableAdapter = null;
            this.tableAdapterManager.tbl_ProdutorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cadastro.db_jogosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.tbl_GeneroBindingNavigator.Size = new System.Drawing.Size(515, 25);
            this.tbl_GeneroBindingNavigator.TabIndex = 5;
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
            this.id_GeneroTextBox.Location = new System.Drawing.Point(177, 55);
            this.id_GeneroTextBox.Name = "id_GeneroTextBox";
            this.id_GeneroTextBox.Size = new System.Drawing.Size(100, 29);
            this.id_GeneroTextBox.TabIndex = 6;
            // 
            // nome_GeneroTextBox
            // 
            this.nome_GeneroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_GeneroBindingSource, "Nome_Genero", true));
            this.nome_GeneroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_GeneroTextBox.Location = new System.Drawing.Point(177, 121);
            this.nome_GeneroTextBox.Name = "nome_GeneroTextBox";
            this.nome_GeneroTextBox.Size = new System.Drawing.Size(100, 29);
            this.nome_GeneroTextBox.TabIndex = 8;
            // 
            // frGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(515, 328);
            this.Controls.Add(nome_GeneroLabel);
            this.Controls.Add(this.nome_GeneroTextBox);
            this.Controls.Add(id_GeneroLabel);
            this.Controls.Add(this.id_GeneroTextBox);
            this.Controls.Add(this.tbl_GeneroBindingNavigator);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Pesquisa);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_cadastar);
            this.Name = "frGenero";
            this.Text = "Genero";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_jogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GeneroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_GeneroBindingNavigator)).EndInit();
            this.tbl_GeneroBindingNavigator.ResumeLayout(false);
            this.tbl_GeneroBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Pesquisa;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_cadastar;
        private db_jogosDataSet db_jogosDataSet;
        private System.Windows.Forms.BindingSource tbl_GeneroBindingSource;
        private db_jogosDataSetTableAdapters.tbl_GeneroTableAdapter tbl_GeneroTableAdapter;
        private db_jogosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
    }
}