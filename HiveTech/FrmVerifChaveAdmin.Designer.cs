namespace HiveTech
{
    partial class FrmVerifChaveAdmin
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
            this.txtChave = new System.Windows.Forms.TextBox();
            this.BtnLogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.BackColor = System.Drawing.Color.Transparent;
            this.lblChave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChave.Location = new System.Drawing.Point(27, 16);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(38, 13);
            this.lblChave.TabIndex = 0;
            this.lblChave.Text = "Chave";
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(30, 32);
            this.txtChave.Name = "txtChave";
            this.txtChave.PasswordChar = '*';
            this.txtChave.Size = new System.Drawing.Size(176, 20);
            this.txtChave.TabIndex = 1;
            // 
            // BtnLogar
            // 
            this.BtnLogar.Location = new System.Drawing.Point(30, 58);
            this.BtnLogar.Name = "BtnLogar";
            this.BtnLogar.Size = new System.Drawing.Size(176, 23);
            this.BtnLogar.TabIndex = 2;
            this.BtnLogar.Text = "Login";
            this.BtnLogar.UseVisualStyleBackColor = true;
            this.BtnLogar.Click += new System.EventHandler(this.BtnLogar_Click);
            // 
            // FrmVerifChaveAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(232, 103);
            this.Controls.Add(this.BtnLogar);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.lblChave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVerifChaveAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmar Chave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Button BtnLogar;
    }
}