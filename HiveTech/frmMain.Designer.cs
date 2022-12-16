namespace HiveTech
{
    partial class frmMain
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrinhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.carrinhoToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.administradorToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1083, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // carrinhoToolStripMenuItem
            // 
            this.carrinhoToolStripMenuItem.Name = "carrinhoToolStripMenuItem";
            this.carrinhoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.carrinhoToolStripMenuItem.Text = "Carrinho";
            this.carrinhoToolStripMenuItem.Click += new System.EventHandler(this.carrinhoToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroProdutosToolStripMenuItem,
            this.gerenciarEstoqueToolStripMenuItem});
            this.administradorToolStripMenuItem.Enabled = false;
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Visible = false;
            // 
            // cadastroProdutosToolStripMenuItem
            // 
            this.cadastroProdutosToolStripMenuItem.Name = "cadastroProdutosToolStripMenuItem";
            this.cadastroProdutosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroProdutosToolStripMenuItem.Text = "Cadastro Produtos";
            this.cadastroProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroProdutosToolStripMenuItem_Click);
            // 
            // gerenciarEstoqueToolStripMenuItem
            // 
            this.gerenciarEstoqueToolStripMenuItem.Name = "gerenciarEstoqueToolStripMenuItem";
            this.gerenciarEstoqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerenciarEstoqueToolStripMenuItem.Text = "Gerenciar Produtos";
            this.gerenciarEstoqueToolStripMenuItem.Click += new System.EventHandler(this.gerenciarEstoqueToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 520);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrinhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarEstoqueToolStripMenuItem;
    }
}