﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace HiveTech
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=HiveTechDB;Uid=root;Pwd=;");
            MySqlCommand sql = new MySqlCommand();
            sql.Connection = conn;
            sql.CommandText = @"SELECT * FROM cliente where email = @email and senha = SHA2( @senha , 256)";
            sql.Parameters.AddWithValue("@email", txtEmail.Text);
            sql.Parameters.AddWithValue("@senha", txtSenha.Text);

            conn.Open();

            MySqlDataReader Reader = sql.ExecuteReader();

            if (Reader.HasRows)
            {
                frmMain Main = new frmMain();
                Main.Show();
                this.Hide();
            }
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
