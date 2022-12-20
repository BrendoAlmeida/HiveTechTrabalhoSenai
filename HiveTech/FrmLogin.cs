using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            MySqlConnection conn = new MySqlConnection("Server=26.196.221.145;Database=HiveTechDB;Uid=sa;Pwd=123456;");
            MySqlCommand sql = new MySqlCommand
            {
                Connection = conn,
                CommandText = @"SELECT * FROM cliente where email = @email and senha = SHA2( @senha , 256)"
            };
            sql.Parameters.AddWithValue("@email", txtEmail.Text);
            sql.Parameters.AddWithValue("@senha", txtSenha.Text);

            conn.Open();

            MySqlDataReader Reader = sql.ExecuteReader();

            if (Reader.HasRows)
            {
                Reader.Read();

                LoginInfo.Id = Convert.ToString(Reader["id"]);
                LoginInfo.IsLogin = true;
                LoginInfo.Nome = Convert.ToString(Reader["nome"]);

                AdministradorDAO AdmDAO = new AdministradorDAO();

                LoginInfo.IsAdmin = AdmDAO.IsAdmin(int.Parse(LoginInfo.Id));
                
                if (!Application.OpenForms.OfType<frmMain>().Any())
                {
                    frmMain Main = new frmMain();
                    Main.Show();
                }
                Application.OpenForms.OfType<frmMain>().First().verifIdAdmin();
                Application.OpenForms.OfType<frmMain>().First().verifIsLogin();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!");
            }
            Reader.Close();
            conn.Close();
        }

        private void lblCriarConta_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<frmMain>().Any())
            {
                frmMain Main = new frmMain();
                Main.Show();
            }
            FormCadastro Cadastro = new FormCadastro();
            Cadastro.MdiParent = Application.OpenForms.OfType<frmMain>().First();
            Cadastro.Show();
        }
    }
}
