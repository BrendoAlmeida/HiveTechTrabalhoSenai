namespace HiveTech
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txt_data_de_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(640, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 395);
            this.panel1.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(344, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "DATA DE NASCIMENTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(480, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 29);
            this.label7.TabIndex = 44;
            this.label7.Text = "CADASTRO";
            // 
            // text_nome
            // 
            this.text_nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.text_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_nome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nome.ForeColor = System.Drawing.Color.DimGray;
            this.text_nome.Location = new System.Drawing.Point(344, 88);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(440, 19);
            this.text_nome.TabIndex = 45;
            this.text_nome.Text = "NOME";
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 344;
            this.lineShape1.X2 = 782;
            this.lineShape1.Y1 = 112;
            this.lineShape1.Y2 = 112;
            this.lineShape1.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(863, 395);
            this.shapeContainer1.TabIndex = 46;
            this.shapeContainer1.TabStop = false;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.DimGray;
            this.txt_email.Location = new System.Drawing.Point(344, 152);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(440, 19);
            this.txt_email.TabIndex = 47;
            this.txt_email.Text = "E-MAIL";
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 342;
            this.lineShape2.X2 = 784;
            this.lineShape2.Y1 = 176;
            this.lineShape2.Y2 = 176;
            this.lineShape2.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_senha.ForeColor = System.Drawing.Color.LightGray;
            this.txt_senha.Location = new System.Drawing.Point(344, 224);
            this.txt_senha.Multiline = true;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(213, 12);
            this.txt_senha.TabIndex = 48;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 341;
            this.lineShape3.X2 = 553;
            this.lineShape3.Y1 = 243;
            this.lineShape3.Y2 = 242;
            this.lineShape3.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 593;
            this.lineShape4.X2 = 701;
            this.lineShape4.Y1 = 352;
            this.lineShape4.Y2 = 352;
            this.lineShape4.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // txt_data_de_nascimento
            // 
            this.txt_data_de_nascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_data_de_nascimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_data_de_nascimento.ForeColor = System.Drawing.Color.DimGray;
            this.txt_data_de_nascimento.Location = new System.Drawing.Point(520, 280);
            this.txt_data_de_nascimento.Mask = "99/99/9999";
            this.txt_data_de_nascimento.Name = "txt_data_de_nascimento";
            this.txt_data_de_nascimento.Size = new System.Drawing.Size(72, 13);
            this.txt_data_de_nascimento.TabIndex = 49;
            // 
            // txt_cpf
            // 
            this.txt_cpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cpf.ForeColor = System.Drawing.Color.DimGray;
            this.txt_cpf.Location = new System.Drawing.Point(680, 224);
            this.txt_cpf.Mask = "999.999.999-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(112, 13);
            this.txt_cpf.TabIndex = 50;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_enviar.FlatAppearance.BorderSize = 0;
            this.btn_enviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_enviar.Location = new System.Drawing.Point(336, 328);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(456, 41);
            this.btn_enviar.TabIndex = 51;
            this.btn_enviar.Text = "CADASTRAR DADOS";
            this.btn_enviar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(344, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "SENHA";
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 536;
            this.lineShape5.X2 = 600;
            this.lineShape5.Y1 = 343;
            this.lineShape5.Y2 = 344;
            this.lineShape5.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(863, 395);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_data_de_nascimento);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastro";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_nome;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox txt_email;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox txt_senha;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.MaskedTextBox txt_data_de_nascimento;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.Button btn_enviar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.Label label2;
    }
}