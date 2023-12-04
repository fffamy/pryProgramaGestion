using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryProgramaGestion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void cargarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarCliente frmCargarCliente = new frmCargarCliente();
            frmCargarCliente.Show();
            this.Hide();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCliente frmBuscarCliente = new frmBuscarCliente();
            frmBuscarCliente.Show();
            this.Hide();
        }

        private void mostrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesRegistrados frmClientesRegistrados = new frmClientesRegistrados();
            frmClientesRegistrados.Show();
            this.Hide();
        }

        private void cargarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarEmpleado frmCargarEmpleado = new frmCargarEmpleado();
            frmCargarEmpleado.Show();
            this.Hide();
        }

        private void buscarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleado frmBuscarEmpleado = new frmBuscarEmpleado();
            frmBuscarEmpleado.Show();
            this.Hide();
        }

        private void mostrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleadosRegistrados frmEmpleadosRegistrados = new frmEmpleadosRegistrados();
            frmEmpleadosRegistrados.Show();
            this.Hide();
        }

        private void cargarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarVenta frmCargarVenta = new frmCargarVenta();
            frmCargarVenta.Show();
            this.Hide();
        }

        private void mostrarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarVentas frmMostrarVentas = new frmMostrarVentas();
            frmMostrarVentas.Show();
            this.Hide();
        }
    }
}
