using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiveTech
{
    public partial class FrmVerifChaveAdmin : Form
    {
        public FrmVerifChaveAdmin()
        {
            InitializeComponent();
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            AdministradorDAO AdminDAO = new AdministradorDAO();
            if (AdminDAO.VerifChave(txtChave.Text))
            {
                MessageBox.Show("Logado com sucesso!");
                LoginInfo.ChaveCinfirmado = true;
                Application.OpenForms.OfType<frmMain>().First().liberarAdmin();
                this.Close();
            }
            else
            {
                LoginInfo.ChaveCinfirmado = false;
                MessageBox.Show("Chave incorreta!");            
            }
        }
    }
}
