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
    public partial class FrmTornarAdministrador : Form
    {
        public FrmTornarAdministrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dao.TornarAdministrador(FrmGerenciarClientes.IdCliente, txtChaveAcesso.Text);
            MessageBox.Show("Cliente tornou-se administrador com sucesso!");
            this.Close();
        }
    }
}
