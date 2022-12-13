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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_data_de_nascimento = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(328, 72);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(213, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-MAIL";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(328, 136);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(216, 20);
            this.txt_email.TabIndex = 3;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(328, 200);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(219, 20);
            this.txt_senha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "SENHA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(328, 256);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(216, 20);
            this.txt_cpf.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "DATA DE NASCIMENTO";
            // 
            // txt_data_de_nascimento
            // 
            this.txt_data_de_nascimento.Location = new System.Drawing.Point(328, 320);
            this.txt_data_de_nascimento.Name = "txt_data_de_nascimento";
            this.txt_data_de_nascimento.Size = new System.Drawing.Size(216, 20);
            this.txt_data_de_nascimento.TabIndex = 10;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Location = new System.Drawing.Point(376, 352);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(112, 47);
            this.btn_enviar.TabIndex = 11;
            this.btn_enviar.Text = "ENVIAR";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 441);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_data_de_nascimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCadastro";
            this.Text = "FormCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_data_de_nascimento;
        private System.Windows.Forms.Button btn_enviar;
    }
}