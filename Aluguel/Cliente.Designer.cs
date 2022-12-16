namespace Aluguel
{
    partial class tn_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tn_Cliente));
            System.Windows.Forms.Label nome_ClienteLabel;
            System.Windows.Forms.Label sexo_ClienteLabel;
            System.Windows.Forms.Label cPF_ClienteLabel;
            System.Windows.Forms.Label nome_JogoLabel;
            System.Windows.Forms.Label cEP_ClienteLabel;
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.db_aluguelDataSet = new Aluguel.db_aluguelDataSet();
            this.tbl_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_clienteTableAdapter = new Aluguel.db_aluguelDataSetTableAdapters.tbl_clienteTableAdapter();
            this.tableAdapterManager = new Aluguel.db_aluguelDataSetTableAdapters.TableAdapterManager();
            this.tbl_clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nome_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.sexo_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.cPF_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.nome_JogoTextBox = new System.Windows.Forms.TextBox();
            this.cEP_ClienteTextBox = new System.Windows.Forms.TextBox();
            nome_ClienteLabel = new System.Windows.Forms.Label();
            sexo_ClienteLabel = new System.Windows.Forms.Label();
            cPF_ClienteLabel = new System.Windows.Forms.Label();
            nome_JogoLabel = new System.Windows.Forms.Label();
            cEP_ClienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_aluguelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_clienteBindingNavigator)).BeginInit();
            this.tbl_clienteBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Beige;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Add.Location = new System.Drawing.Point(84, 311);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(219, 66);
            this.btn_Add.TabIndex = 25;
            this.btn_Add.Text = "Adcionar";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.Beige;
            this.btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Limpar.Location = new System.Drawing.Point(400, 311);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(219, 66);
            this.btn_Limpar.TabIndex = 25;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            // 
            // db_aluguelDataSet
            // 
            this.db_aluguelDataSet.DataSetName = "db_aluguelDataSet";
            this.db_aluguelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_clienteBindingSource
            // 
            this.tbl_clienteBindingSource.DataMember = "tbl_cliente";
            this.tbl_clienteBindingSource.DataSource = this.db_aluguelDataSet;
            // 
            // tbl_clienteTableAdapter
            // 
            this.tbl_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_clienteTableAdapter = this.tbl_clienteTableAdapter;
            this.tableAdapterManager.tbl_GeneroTableAdapter = null;
            this.tableAdapterManager.tbl_JogoTableAdapter = null;
            this.tableAdapterManager.tbl_ProdutoraTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aluguel.db_aluguelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_clienteBindingNavigator
            // 
            this.tbl_clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_clienteBindingNavigator.BindingSource = this.tbl_clienteBindingSource;
            this.tbl_clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_clienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_clienteBindingNavigatorSaveItem});
            this.tbl_clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_clienteBindingNavigator.Name = "tbl_clienteBindingNavigator";
            this.tbl_clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_clienteBindingNavigator.Size = new System.Drawing.Size(697, 25);
            this.tbl_clienteBindingNavigator.TabIndex = 26;
            this.tbl_clienteBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // tbl_clienteBindingNavigatorSaveItem
            // 
            this.tbl_clienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_clienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_clienteBindingNavigatorSaveItem.Image")));
            this.tbl_clienteBindingNavigatorSaveItem.Name = "tbl_clienteBindingNavigatorSaveItem";
            this.tbl_clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tbl_clienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbl_clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_clienteBindingNavigatorSaveItem_Click_3);
            // 
            // nome_ClienteLabel
            // 
            nome_ClienteLabel.AutoSize = true;
            nome_ClienteLabel.Location = new System.Drawing.Point(272, 68);
            nome_ClienteLabel.Name = "nome_ClienteLabel";
            nome_ClienteLabel.Size = new System.Drawing.Size(73, 13);
            nome_ClienteLabel.TabIndex = 26;
            nome_ClienteLabel.Text = "Nome Cliente:";
            // 
            // nome_ClienteTextBox
            // 
            this.nome_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_clienteBindingSource, "Nome_Cliente", true));
            this.nome_ClienteTextBox.Location = new System.Drawing.Point(351, 65);
            this.nome_ClienteTextBox.Name = "nome_ClienteTextBox";
            this.nome_ClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.nome_ClienteTextBox.TabIndex = 27;
            // 
            // sexo_ClienteLabel
            // 
            sexo_ClienteLabel.AutoSize = true;
            sexo_ClienteLabel.Location = new System.Drawing.Point(320, 123);
            sexo_ClienteLabel.Name = "sexo_ClienteLabel";
            sexo_ClienteLabel.Size = new System.Drawing.Size(69, 13);
            sexo_ClienteLabel.TabIndex = 27;
            sexo_ClienteLabel.Text = "Sexo Cliente:";
            // 
            // sexo_ClienteTextBox
            // 
            this.sexo_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_clienteBindingSource, "Sexo_Cliente", true));
            this.sexo_ClienteTextBox.Location = new System.Drawing.Point(395, 120);
            this.sexo_ClienteTextBox.Name = "sexo_ClienteTextBox";
            this.sexo_ClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.sexo_ClienteTextBox.TabIndex = 28;
            // 
            // cPF_ClienteLabel
            // 
            cPF_ClienteLabel.AutoSize = true;
            cPF_ClienteLabel.Location = new System.Drawing.Point(283, 175);
            cPF_ClienteLabel.Name = "cPF_ClienteLabel";
            cPF_ClienteLabel.Size = new System.Drawing.Size(65, 13);
            cPF_ClienteLabel.TabIndex = 28;
            cPF_ClienteLabel.Text = "CPF Cliente:";
            // 
            // cPF_ClienteTextBox
            // 
            this.cPF_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_clienteBindingSource, "CPF_Cliente", true));
            this.cPF_ClienteTextBox.Location = new System.Drawing.Point(354, 172);
            this.cPF_ClienteTextBox.Name = "cPF_ClienteTextBox";
            this.cPF_ClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.cPF_ClienteTextBox.TabIndex = 29;
            // 
            // nome_JogoLabel
            // 
            nome_JogoLabel.AutoSize = true;
            nome_JogoLabel.Location = new System.Drawing.Point(318, 213);
            nome_JogoLabel.Name = "nome_JogoLabel";
            nome_JogoLabel.Size = new System.Drawing.Size(64, 13);
            nome_JogoLabel.TabIndex = 29;
            nome_JogoLabel.Text = "Nome Jogo:";
            // 
            // nome_JogoTextBox
            // 
            this.nome_JogoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_clienteBindingSource, "Nome_Jogo", true));
            this.nome_JogoTextBox.Location = new System.Drawing.Point(388, 210);
            this.nome_JogoTextBox.Name = "nome_JogoTextBox";
            this.nome_JogoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nome_JogoTextBox.TabIndex = 30;
            // 
            // cEP_ClienteLabel
            // 
            cEP_ClienteLabel.AutoSize = true;
            cEP_ClienteLabel.Location = new System.Drawing.Point(369, 244);
            cEP_ClienteLabel.Name = "cEP_ClienteLabel";
            cEP_ClienteLabel.Size = new System.Drawing.Size(66, 13);
            cEP_ClienteLabel.TabIndex = 30;
            cEP_ClienteLabel.Text = "CEP Cliente:";
            // 
            // cEP_ClienteTextBox
            // 
            this.cEP_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_clienteBindingSource, "CEP_Cliente", true));
            this.cEP_ClienteTextBox.Location = new System.Drawing.Point(441, 241);
            this.cEP_ClienteTextBox.Name = "cEP_ClienteTextBox";
            this.cEP_ClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.cEP_ClienteTextBox.TabIndex = 31;
            // 
            // tn_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 401);
            this.Controls.Add(cEP_ClienteLabel);
            this.Controls.Add(this.cEP_ClienteTextBox);
            this.Controls.Add(nome_JogoLabel);
            this.Controls.Add(this.nome_JogoTextBox);
            this.Controls.Add(cPF_ClienteLabel);
            this.Controls.Add(this.cPF_ClienteTextBox);
            this.Controls.Add(sexo_ClienteLabel);
            this.Controls.Add(this.sexo_ClienteTextBox);
            this.Controls.Add(nome_ClienteLabel);
            this.Controls.Add(this.nome_ClienteTextBox);
            this.Controls.Add(this.tbl_clienteBindingNavigator);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Add);
            this.Name = "tn_Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_aluguelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_clienteBindingNavigator)).EndInit();
            this.tbl_clienteBindingNavigator.ResumeLayout(false);
            this.tbl_clienteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Limpar;
        private db_aluguelDataSet db_aluguelDataSet;
        private System.Windows.Forms.BindingSource tbl_clienteBindingSource;
        private db_aluguelDataSetTableAdapters.tbl_clienteTableAdapter tbl_clienteTableAdapter;
        private db_aluguelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_clienteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbl_clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nome_ClienteTextBox;
        private System.Windows.Forms.TextBox sexo_ClienteTextBox;
        private System.Windows.Forms.TextBox cPF_ClienteTextBox;
        private System.Windows.Forms.TextBox nome_JogoTextBox;
        private System.Windows.Forms.TextBox cEP_ClienteTextBox;
    }
}