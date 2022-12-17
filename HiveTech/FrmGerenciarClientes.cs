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
    public partial class FrmGerenciarClientes : Form
    {
        public static int IdCliente;
        public FrmGerenciarClientes()
        {
            InitializeComponent();
        }

        private void FrmGerenciarClientes_Load(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            DgvClientes.Rows.Clear();
            ClienteDAO dao = new ClienteDAO();
            List<Cliente> clientes = dao.Listar();

            foreach (Cliente cliente in clientes)
            {
                DgvClientes.Rows.Add(cliente.Id, cliente.Nome, cliente.Email, cliente.Cpf, "Tornar Administrador");
            }
        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = DgvClientes.CurrentRow.Cells[0].Value.ToString();
            IdCliente = int.Parse(id);
            if (e.ColumnIndex == 4)
            {
                FrmTornarAdministrador frm = new FrmTornarAdministrador();
                frm.ShowDialog();
                DgvClientes.Rows.Clear();
                CarregarClientes();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarClientes();
        }
    }
}
