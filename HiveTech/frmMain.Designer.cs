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
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrinhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarInformaçõesDeCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.atualizarHora = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.carrinhoToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.administradorToolStripMenuItem,
            this.contaToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(106, 514);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // carrinhoToolStripMenuItem
            // 
            this.carrinhoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.carrinhoToolStripMenuItem.Name = "carrinhoToolStripMenuItem";
            this.carrinhoToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.carrinhoToolStripMenuItem.Text = "Carrinho";
            this.carrinhoToolStripMenuItem.Click += new System.EventHandler(this.carrinhoToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroProdutosToolStripMenuItem,
            this.gerenciarEstoqueToolStripMenuItem,
            this.criarAdministradorToolStripMenuItem});
            this.administradorToolStripMenuItem.Enabled = false;
            this.administradorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Visible = false;
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // cadastroProdutosToolStripMenuItem
            // 
            this.cadastroProdutosToolStripMenuItem.Enabled = false;
            this.cadastroProdutosToolStripMenuItem.Name = "cadastroProdutosToolStripMenuItem";
            this.cadastroProdutosToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.cadastroProdutosToolStripMenuItem.Text = "Cadastro Produtos";
            this.cadastroProdutosToolStripMenuItem.Visible = false;
            this.cadastroProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroProdutosToolStripMenuItem_Click);
            // 
            // gerenciarEstoqueToolStripMenuItem
            // 
            this.gerenciarEstoqueToolStripMenuItem.Enabled = false;
            this.gerenciarEstoqueToolStripMenuItem.Name = "gerenciarEstoqueToolStripMenuItem";
            this.gerenciarEstoqueToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.gerenciarEstoqueToolStripMenuItem.Text = "Gerenciar Produtos";
            this.gerenciarEstoqueToolStripMenuItem.Visible = false;
            this.gerenciarEstoqueToolStripMenuItem.Click += new System.EventHandler(this.gerenciarEstoqueToolStripMenuItem_Click);
            // 
            // criarAdministradorToolStripMenuItem
            // 
            this.criarAdministradorToolStripMenuItem.Enabled = false;
            this.criarAdministradorToolStripMenuItem.Name = "criarAdministradorToolStripMenuItem";
            this.criarAdministradorToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.criarAdministradorToolStripMenuItem.Text = "Criar administrador";
            this.criarAdministradorToolStripMenuItem.Visible = false;
            this.criarAdministradorToolStripMenuItem.Click += new System.EventHandler(this.criarAdiministradorToolStripMenuItem_Click);
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarInformaçõesDeCadastroToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.contaToolStripMenuItem.Enabled = false;
            this.contaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.contaToolStripMenuItem.Text = "Conta";
            this.contaToolStripMenuItem.Visible = false;
            // 
            // alterarInformaçõesDeCadastroToolStripMenuItem
            // 
            this.alterarInformaçõesDeCadastroToolStripMenuItem.Name = "alterarInformaçõesDeCadastroToolStripMenuItem";
            this.alterarInformaçõesDeCadastroToolStripMenuItem.Size = new System.Drawing.Size(353, 30);
            this.alterarInformaçõesDeCadastroToolStripMenuItem.Text = "Alterar informações de cadastro";
            this.alterarInformaçõesDeCadastroToolStripMenuItem.Click += new System.EventHandler(this.alterarInformaçõesDeCadastroToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(353, 30);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Enabled = false;
            this.pedidosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Visible = false;
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser,
            this.txtHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 514);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1099, 30);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(111, 25);
            this.lblUser.Text = "Não logado";
            // 
            // txtHora
            // 
            this.txtHora.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(0, 25);
            // 
            // atualizarHora
            // 
            this.atualizarHora.Enabled = true;
            this.atualizarHora.Interval = 1000;
            this.atualizarHora.Tick += new System.EventHandler(this.atualizarHora_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::HiveTech.Properties.Resources.BACK__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 544);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarInformaçõesDeCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel txtHora;
        private System.Windows.Forms.Timer atualizarHora;
        private System.Windows.Forms.ToolStripMenuItem criarAdministradorToolStripMenuItem;
    }
}