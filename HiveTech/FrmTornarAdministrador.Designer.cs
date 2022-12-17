namespace HiveTech
{
    partial class FrmTornarAdministrador
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
            this.lblChave = new System.Windows.Forms.Label();
            this.txtChaveAcesso = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Location = new System.Drawing.Point(9, 26);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(91, 13);
            this.lblChave.TabIndex = 0;
            this.lblChave.Text = "Chave de Acesso";
            // 
            // txtChaveAcesso
            // 
            this.txtChaveAcesso.Location = new System.Drawing.Point(12, 53);
            this.txtChaveAcesso.Name = "txtChaveAcesso";
            this.txtChaveAcesso.Size = new System.Drawing.Size(239, 20);
            this.txtChaveAcesso.TabIndex = 1;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(12, 96);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(239, 23);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTornarAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 144);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtChaveAcesso);
            this.Controls.Add(this.lblChave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTornarAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTornarAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.TextBox txtChaveAcesso;
        private System.Windows.Forms.Button btnAtualizar;
    }
}