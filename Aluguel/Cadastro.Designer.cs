namespace Aluguel
{
    partial class Tn_Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tn_Cadastro));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alerarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jogoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.alerarToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.jogoToolStripMenuItem,
            this.produtoraToolStripMenuItem,
            this.generoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            resources.ApplyResources(this.cadastroToolStripMenuItem, "cadastroToolStripMenuItem");
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            resources.ApplyResources(this.clienteToolStripMenuItem, "clienteToolStripMenuItem");
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // jogoToolStripMenuItem
            // 
            this.jogoToolStripMenuItem.Name = "jogoToolStripMenuItem";
            resources.ApplyResources(this.jogoToolStripMenuItem, "jogoToolStripMenuItem");
            this.jogoToolStripMenuItem.Click += new System.EventHandler(this.jogoToolStripMenuItem_Click);
            // 
            // produtoraToolStripMenuItem
            // 
            this.produtoraToolStripMenuItem.Name = "produtoraToolStripMenuItem";
            resources.ApplyResources(this.produtoraToolStripMenuItem, "produtoraToolStripMenuItem");
            this.produtoraToolStripMenuItem.Click += new System.EventHandler(this.produtoraToolStripMenuItem_Click);
            // 
            // generoToolStripMenuItem
            // 
            this.generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            resources.ApplyResources(this.generoToolStripMenuItem, "generoToolStripMenuItem");
            this.generoToolStripMenuItem.Click += new System.EventHandler(this.generoToolStripMenuItem_Click);
            // 
            // alerarToolStripMenuItem
            // 
            this.alerarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.jogoToolStripMenuItem1,
            this.produtoraToolStripMenuItem1,
            this.generoToolStripMenuItem1});
            this.alerarToolStripMenuItem.Name = "alerarToolStripMenuItem";
            resources.ApplyResources(this.alerarToolStripMenuItem, "alerarToolStripMenuItem");
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            resources.ApplyResources(this.clienteToolStripMenuItem1, "clienteToolStripMenuItem1");
            // 
            // jogoToolStripMenuItem1
            // 
            this.jogoToolStripMenuItem1.Name = "jogoToolStripMenuItem1";
            resources.ApplyResources(this.jogoToolStripMenuItem1, "jogoToolStripMenuItem1");
            // 
            // produtoraToolStripMenuItem1
            // 
            this.produtoraToolStripMenuItem1.Name = "produtoraToolStripMenuItem1";
            resources.ApplyResources(this.produtoraToolStripMenuItem1, "produtoraToolStripMenuItem1");
            // 
            // generoToolStripMenuItem1
            // 
            this.generoToolStripMenuItem1.Name = "generoToolStripMenuItem1";
            resources.ApplyResources(this.generoToolStripMenuItem1, "generoToolStripMenuItem1");
            // 
            // Tn_Cadastro
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tn_Cadastro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alerarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtoraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generoToolStripMenuItem1;
    }
}

