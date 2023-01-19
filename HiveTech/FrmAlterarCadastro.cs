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
    public partial class FrmAlterarCadastro : Form
    {
        public FrmAlterarCadastro()
        {
            InitializeComponent();
        }

        private void FrmAlterarCadastro_Load(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            Cliente cliente = clienteDAO.BuscarPorId(Convert.ToInt32(LoginInfo.Id));
            txt_nome.Text = cliente.Nome;
            txt_email.Text = cliente.Email;
            txt_cpf.Text = cliente.Cpf;
            txt_data_de_nascimento.Text = cliente.Data_Nascimento;
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txt_nome.Text, txt_email.Text, txt_senha.Text, txt_cpf.Text.Replace(",", "."), txt_data_de_nascimento.Text, Convert.ToInt32(LoginInfo.Id));
            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.Alterar(cliente);
            MessageBox.Show("Alterado com sucesso!");
        }
    }
}
