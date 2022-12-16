namespace Cadastro
{
    partial class frJogos
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
            System.Windows.Forms.Label data_PubLabel;
            System.Windows.Forms.Label id_JogoLabel;
            System.Windows.Forms.Label id_ProdutorLabel1;
            System.Windows.Forms.Label num_copiasLabel;
            System.Windows.Forms.Label nome_JogoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frJogos));
            this.data_PubDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_JogoTextBox = new System.Windows.Forms.TextBox();
            this.id_ProdutorTextBox1 = new System.Windows.Forms.TextBox();
            this.num_copiasTextBox = new System.Windows.Forms.TextBox();
            this.nome_JogoTextBox = new System.Windows.Forms.TextBox();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Pesquisa = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_cadastar = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            data_PubLabel = new System.Windows.Forms.Label();
            id_JogoLabel = new System.Windows.Forms.Label();
            id_ProdutorLabel1 = new System.Windows.Forms.Label();
            num_copiasLabel = new System.Windows.Forms.Label();
            nome_JogoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_PubLabel
            // 
            data_PubLabel.AutoSize = true;
            data_PubLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            data_PubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_PubLabel.Location = new System.Drawing.Point(15, 219);
            data_PubLabel.Name = "data_PubLabel";
            data_PubLabel.Size = new System.Drawing.Size(80, 20);
            data_PubLabel.TabIndex = 26;
            data_PubLabel.Text = "Data Pub:";
            // 
            // id_JogoLabel
            // 
            id_JogoLabel.AutoSize = true;
            id_JogoLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            id_JogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_JogoLabel.Location = new System.Drawing.Point(43, 59);
            id_JogoLabel.Name = "id_JogoLabel";
            id_JogoLabel.Size = new System.Drawing.Size(64, 20);
            id_JogoLabel.TabIndex = 24;
            id_JogoLabel.Text = "id Jogo:";
            // 
            // id_ProdutorLabel1
            // 
            id_ProdutorLabel1.AutoSize = true;
            id_ProdutorLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            id_ProdutorLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_ProdutorLabel1.Location = new System.Drawing.Point(15, 133);
            id_ProdutorLabel1.Name = "id_ProdutorLabel1";
            id_ProdutorLabel1.Size = new System.Drawing.Size(92, 20);
            id_ProdutorLabel1.TabIndex = 23;
            id_ProdutorLabel1.Text = "Id Produtor:";
            // 
            // num_copiasLabel
            // 
            num_copiasLabel.AutoSize = true;
            num_copiasLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            num_copiasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            num_copiasLabel.Location = new System.Drawing.Point(15, 179);
            num_copiasLabel.Name = "num_copiasLabel";
            num_copiasLabel.Size = new System.Drawing.Size(94, 20);
            num_copiasLabel.TabIndex = 21;
            num_copiasLabel.Text = "num copias:";
            // 
            // nome_JogoLabel
            // 
            nome_JogoLabel.AutoSize = true;
            nome_JogoLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            nome_JogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_JogoLabel.Location = new System.Drawing.Point(15, 95);
            nome_JogoLabel.Name = "nome_JogoLabel";
            nome_JogoLabel.Size = new System.Drawing.Size(94, 20);
            nome_JogoLabel.TabIndex = 19;
            nome_JogoLabel.Text = "Nome Jogo:";
            // 
            // data_PubDateTimePicker
            // 
            this.data_PubDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_PubDateTimePicker.Location = new System.Drawing.Point(101, 219);
            this.data_PubDateTimePicker.Name = "data_PubDateTimePicker";
            this.data_PubDateTimePicker.Size = new System.Drawing.Size(321, 26);
            this.data_PubDateTimePicker.TabIndex = 28;
            // 
            // id_JogoTextBox
            // 
            this.id_JogoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_JogoTextBox.Location = new System.Drawing.Point(127, 53);
            this.id_JogoTextBox.Name = "id_JogoTextBox";
            this.id_JogoTextBox.Size = new System.Drawing.Size(129, 26);
            this.id_JogoTextBox.TabIndex = 27;
            // 
            // id_ProdutorTextBox1
            // 
            this.id_ProdutorTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_ProdutorTextBox1.Location = new System.Drawing.Point(127, 133);
            this.id_ProdutorTextBox1.Name = "id_ProdutorTextBox1";
            this.id_ProdutorTextBox1.Size = new System.Drawing.Size(129, 26);
            this.id_ProdutorTextBox1.TabIndex = 25;
            // 
            // num_copiasTextBox
            // 
            this.num_copiasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_copiasTextBox.Location = new System.Drawing.Point(127, 179);
            this.num_copiasTextBox.Name = "num_copiasTextBox";
            this.num_copiasTextBox.Size = new System.Drawing.Size(129, 26);
            this.num_copiasTextBox.TabIndex = 22;
            // 
            // nome_JogoTextBox
            // 
            this.nome_JogoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_JogoTextBox.Location = new System.Drawing.Point(127, 89);
            this.nome_JogoTextBox.Name = "nome_JogoTextBox";
            this.nome_JogoTextBox.Size = new System.Drawing.Size(129, 26);
            this.nome_JogoTextBox.TabIndex = 20;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.Navy;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Excluir.Location = new System.Drawing.Point(106, 268);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(150, 57);
            this.btn_Excluir.TabIndex = 15;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            // 
            // btn_Pesquisa
            // 
            this.btn_Pesquisa.BackColor = System.Drawing.Color.Navy;
            this.btn_Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisa.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Pesquisa.Location = new System.Drawing.Point(339, 268);
            this.btn_Pesquisa.Name = "btn_Pesquisa";
            this.btn_Pesquisa.Size = new System.Drawing.Size(150, 57);
            this.btn_Pesquisa.TabIndex = 16;
            this.btn_Pesquisa.Text = "Pesquisar";
            this.btn_Pesquisa.UseVisualStyleBackColor = false;
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.Navy;
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Alterar.Location = new System.Drawing.Point(389, 156);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(150, 57);
            this.btn_Alterar.TabIndex = 17;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            // 
            // btn_cadastar
            // 
            this.btn_cadastar.BackColor = System.Drawing.Color.Navy;
            this.btn_cadastar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastar.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_cadastar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadastar.Location = new System.Drawing.Point(389, 74);
            this.btn_cadastar.Name = "btn_cadastar";
            this.btn_cadastar.Size = new System.Drawing.Size(150, 57);
            this.btn_cadastar.TabIndex = 18;
            this.btn_cadastar.Text = "Cadastrar";
            this.btn_cadastar.UseVisualStyleBackColor = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(564, 25);
            this.bindingNavigator1.TabIndex = 29;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // frJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(564, 399);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(data_PubLabel);
            this.Controls.Add(this.data_PubDateTimePicker);
            this.Controls.Add(id_JogoLabel);
            this.Controls.Add(this.id_JogoTextBox);
            this.Controls.Add(id_ProdutorLabel1);
            this.Controls.Add(this.id_ProdutorTextBox1);
            this.Controls.Add(num_copiasLabel);
            this.Controls.Add(this.num_copiasTextBox);
            this.Controls.Add(nome_JogoLabel);
            this.Controls.Add(this.nome_JogoTextBox);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Pesquisa);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_cadastar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frJogos";
            this.Text = "Jogos";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker data_PubDateTimePicker;
        private System.Windows.Forms.TextBox id_JogoTextBox;
        private System.Windows.Forms.TextBox id_ProdutorTextBox1;
        private System.Windows.Forms.TextBox num_copiasTextBox;
        private System.Windows.Forms.TextBox nome_JogoTextBox;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Pesquisa;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_cadastar;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
    }
}