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
    public partial class frmMostrarVentas : Form
    {
        public frmMostrarVentas()
        {
            InitializeComponent();
        }

        String[] VecApellidoClienteVenta = new String[3];
        String[] VecApellidoEmpleadoVenta = new String[3];
        String[] VecProductoVenta = new String[3];
        Int32[] VecCantidadVenta = new Int32[3];
        Int32[] VecMontoVenta = new Int32[3];

        private void BtnMostrarVentasRegistradas_Click(object sender, EventArgs e)
        {
            VecApellidoClienteVenta = frmCargarVenta.VecApellidoClienteVenta;
            VecApellidoEmpleadoVenta = frmCargarVenta.VecApellidoEmpleadoVenta;
            VecProductoVenta = frmCargarVenta.VecProductoVenta;
            VecCantidadVenta = frmCargarVenta.VecCantidadVenta;
            VecMontoVenta = frmCargarVenta.VecMontoVenta;

            for (int i = 0; i < VecApellidoClienteVenta.Length; i++)
            {
                DtvMostrarVentas.Rows.Add(VecApellidoClienteVenta[i], VecApellidoEmpleadoVenta[i], VecProductoVenta[i], VecCantidadVenta[i], VecMontoVenta[i]);
            }

            BtnMostrarVentasRegistradas.Enabled = false;
        }

        private void BtnLimpiarVentasRegistradas_Click(object sender, EventArgs e)
        {
            DtvMostrarVentas.Rows.Clear();

            BtnMostrarVentasRegistradas.Enabled = true;
        }

        private void BtnVolverVentasRegistradas_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }
    }
}
