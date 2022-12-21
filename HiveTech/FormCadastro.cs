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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(text_nome.Text, txt_email.Text, txt_senha.Text, txt_cpf.Text, txt_data_de_nascimento.Text);
            cliente.Nome = text_nome.Text;
            cliente.Email = txt_email.Text;
            cliente.Senha = txt_senha.Text;
            cliente.Cpf = txt_cpf.Text;
            cliente.Data_Nascimento = txt_data_de_nascimento.Text;

            ClienteDAO clienteDao = new ClienteDAO();
            clienteDao.Inserir(cliente);
            MessageBox.Show("Cadastrado com sucesso!");
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
