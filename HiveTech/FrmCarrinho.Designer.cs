namespace HiveTech
{
    partial class FrmCarrinho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adicionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Subtrair = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remover = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnComprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.AllowUserToAddRows = false;
            this.DgvProdutos.AllowUserToDeleteRows = false;
            this.DgvProdutos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Img,
            this.Nome,
            this.Descricao,
            this.Quantidade,
            this.SubTotal,
            this.Adicionar,
            this.Subtrair,
            this.Remover});
            this.DgvProdutos.Location = new System.Drawing.Point(-47, -25);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.ReadOnly = true;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            this.DgvProdutos.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.DgvProdutos.RowTemplate.Height = 120;
            this.DgvProdutos.Size = new System.Drawing.Size(1090, 462);
            this.DgvProdutos.TabIndex = 1;
            this.DgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Img
            // 
            this.Img.HeaderText = "Img";
            this.Img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Img.Name = "Img";
            this.Img.ReadOnly = true;
            this.Img.Width = 120;
            // 
            // Nome
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.DefaultCellStyle = dataGridViewCellStyle25;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Descricao
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descricao.DefaultCellStyle = dataGridViewCellStyle26;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 200;
            // 
            // Quantidade
            // 
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle27;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 50;
            // 
            // SubTotal
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle28;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 150;
            // 
            // Adicionar
            // 
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adicionar.DefaultCellStyle = dataGridViewCellStyle29;
            this.Adicionar.HeaderText = "Adicionar";
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.ReadOnly = true;
            this.Adicionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Adicionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Subtrair
            // 
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtrair.DefaultCellStyle = dataGridViewCellStyle30;
            this.Subtrair.HeaderText = "Subtrair";
            this.Subtrair.Name = "Subtrair";
            this.Subtrair.ReadOnly = true;
            this.Subtrair.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Subtrair.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Remover
            // 
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remover.DefaultCellStyle = dataGridViewCellStyle31;
            this.Remover.HeaderText = "Remover";
            this.Remover.Name = "Remover";
            this.Remover.ReadOnly = true;
            this.Remover.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remover.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Remover.Width = 125;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackgroundImage = global::HiveTech.Properties.Resources.recarregar;
            this.BtnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAtualizar.Location = new System.Drawing.Point(513, 443);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(75, 57);
            this.BtnAtualizar.TabIndex = 3;
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnComprar
            // 
            this.BtnComprar.BackgroundImage = global::HiveTech.Properties.Resources.carrinho;
            this.BtnComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnComprar.Location = new System.Drawing.Point(397, 443);
            this.BtnComprar.Name = "BtnComprar";
            this.BtnComprar.Size = new System.Drawing.Size(75, 57);
            this.BtnComprar.TabIndex = 2;
            this.BtnComprar.UseVisualStyleBackColor = true;
            this.BtnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // FrmCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 508);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnComprar);
            this.Controls.Add(this.DgvProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCarrinho";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrinho";
            this.Load += new System.EventHandler(this.FrmCarrinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.Button BtnComprar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn Img;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn Adicionar;
        private System.Windows.Forms.DataGridViewButtonColumn Subtrair;
        private System.Windows.Forms.DataGridViewButtonColumn Remover;
        private System.Windows.Forms.Button BtnAtualizar;
    }
}