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
    public partial class frmClientesRegistrados : Form
    {
        public frmClientesRegistrados()
        {
            InitializeComponent();
        }

        String[] VecNombreCliente = new String[3];
        String[] VecApellidoCliente = new String[3];
        Int32[] VecEdadCliente = new Int32[3];
        Int32[] VecDNICliente = new Int32[3];
        String[] VecDomicilioCliente = new String[3];
        String[] VecEmailCliente = new String[3];
        String[] VecTelefonoCliente = new String[3];

        private void BtnMostrarClientesRegistrados_Click(object sender, EventArgs e)
        {
            VecNombreCliente = frmCargarCliente.VecNombreCliente;
            VecApellidoCliente = frmCargarCliente.VecApellidoCliente;
            VecEdadCliente = frmCargarCliente.VecEdadCliente;
            VecDNICliente = frmCargarCliente.VecDNICliente;
            VecDomicilioCliente = frmCargarCliente.VecDomicilioCliente;
            VecEmailCliente = frmCargarCliente.VecEmailCliente;
            VecTelefonoCliente = frmCargarCliente.VecTelefonoCliente;

            for(int i = 0; i < VecNombreCliente.Length; i++)
            {
                DtvMostrarClientes.Rows.Add(VecNombreCliente[i], VecApellidoCliente[i], VecEdadCliente[i], VecDNICliente[i], VecDomicilioCliente[i], VecEmailCliente[i], VecTelefonoCliente[i]);
            }

            BtnMostrarClientesRegistrados.Enabled = false;
        }

        private void BtnLimpiarClientesRegistrados_Click(object sender, EventArgs e)
        {
            DtvMostrarClientes.Rows.Clear();

            BtnMostrarClientesRegistrados.Enabled = true;
        }

        private void BtnVolverClientesRegistrados_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }
    }
}
