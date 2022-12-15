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
    public partial class FrmAlterarCliente : Form
    {

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txt_nome.Text, txt_email.Text, txt_senha.Text, txt_cpf.Text, txt_data_de_nascimento.Text, Convert.ToInt32(LoginInfo.Id));
            cliente.Nome

        }
    }
}
