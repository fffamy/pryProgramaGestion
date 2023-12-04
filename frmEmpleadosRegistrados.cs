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
    public partial class frmEmpleadosRegistrados : Form
    {
        public frmEmpleadosRegistrados()
        {
            InitializeComponent();
        }

        String[] VecNombreEmpleado = new String[3];
        String[] VecApellidoEmpleado = new String[3];
        Int32[] VecEdadEmpleado = new Int32[3];
        Int32[] VecDNIEmpleado = new Int32[3];
        String[] VecDomicilioEmpleado = new String[3];
        String[] VecEmailEmpleado = new String[3];
        String[] VecTelefonoEmpleado = new String[3];

        private void BtnMostrarEmpleadosRegistrados_Click(object sender, EventArgs e)
        {
            VecNombreEmpleado = frmCargarEmpleado.VecNombreEmpleado;
            VecApellidoEmpleado = frmCargarEmpleado.VecApellidoEmpleado;
            VecEdadEmpleado = frmCargarEmpleado.VecEdadEmpleado;
            VecDNIEmpleado = frmCargarEmpleado.VecDNIEmpleado;
            VecDomicilioEmpleado = frmCargarEmpleado.VecDomicilioEmpleado;
            VecEmailEmpleado = frmCargarEmpleado.VecEmailEmpleado;
            VecTelefonoEmpleado = frmCargarEmpleado.VecTelefonoEmpleado;

            for (int i = 0; i < VecNombreEmpleado.Length; i++)
            {
                DtvMostrarEmpleados.Rows.Add(VecNombreEmpleado[i], VecApellidoEmpleado[i], VecEdadEmpleado[i], VecDNIEmpleado[i], VecDomicilioEmpleado[i], VecEmailEmpleado[i], VecTelefonoEmpleado[i]);
            }

            BtnMostrarEmpleadosRegistrados.Enabled = false;
        }

        private void BtnLimpiarEmpleadosRegistrados_Click(object sender, EventArgs e)
        {
            DtvMostrarEmpleados.Rows.Clear();

            BtnMostrarEmpleadosRegistrados.Enabled = true;
        }

        private void BtnVolverEmpleadosRegistrados_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }
    }
}
