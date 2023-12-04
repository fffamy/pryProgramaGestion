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
    public partial class frmCargarVenta : Form
    {
        public frmCargarVenta()
        {
            InitializeComponent();
        }

        public static String[] VecNombreClienteVenta = new String[3];
        public static String[] VecApellidoClienteVenta = new String[3];
        public static Int32[] VecDNIClienteVenta = new Int32[3];
        public static String [] VecNombreEmpleadoVenta = new String[3];
        public static String[] VecApellidoEmpleadoVenta = new String[3];
        public static Int32[] VecDNIEmpleadoVenta = new Int32[3];
        public static String[] VecProductoVenta = new String[3];
        public static Int32[] VecCantidadVenta = new Int32[3];
        public static Int32[] VecMontoVenta = new Int32[3];
        String[] VecNombreCliente = new String[3];
        String[] VecApellidoCliente = new String[3];
        Int32[] VecDNICliente = new Int32[3];
        String[] VecNombreEmpleado = new String[3];
        String[] VecApellidoEmpleado = new String[3];
        Int32[] VecDNIEmpleado = new Int32[3];
        Int32 DniCliente = 0;
        Int32 DniEmpleado = 0;
        Int32 i = 0;
        Int32 j = 0;
        Int32 l = 0;
        Int32 k = 0;
        Int32 m = 0;
        Int32 n = 0;

        private void frmCargarVenta_Load(object sender, EventArgs e)
        {
            VecNombreCliente = frmCargarCliente.VecNombreCliente;
            VecApellidoCliente = frmCargarCliente.VecApellidoCliente;
            VecDNICliente = frmCargarCliente.VecDNICliente;

            VecNombreEmpleado = frmCargarEmpleado.VecNombreEmpleado;
            VecApellidoEmpleado = frmCargarEmpleado.VecApellidoEmpleado;
            VecDNIEmpleado = frmCargarEmpleado.VecDNIEmpleado;

            BtnCargarVentaBuscarCliente.Enabled = false;
            BtnCargarVentaBuscarEmpleado.Enabled = false;
        }

        private void BtnCargarVentaBuscarCliente_Click(object sender, EventArgs e)
        {
            DniCliente = Convert.ToInt32(TxtCargarVentaDNICliente.Text);

            while (j < VecNombreCliente.Length)
            {
                if (DniCliente == VecDNICliente[j])
                {
                    LblCargarVentaMostrarNombreCliente.Text = VecNombreCliente[j];
                    LblCargarVentaMostrarApellidoCliente.Text = VecApellidoCliente[j];

                    BtnCargarVentaBuscarCliente.Enabled = false;
                }
                j++;
            }

            if (DniCliente != VecDNICliente[k] && DniCliente != VecDNICliente[k + 1] && DniCliente != VecDNICliente[k + 2])
            {
                MessageBox.Show("EL CLIENTE NO ESTA CARGADO O ESTA MAL INGRESADO.");

                TxtCargarVentaDNICliente.Clear();
                LblCargarVentaMostrarNombreCliente.Text = "";
                LblCargarVentaMostrarApellidoCliente.Text = "";

                BtnCargarVentaBuscarCliente.Enabled = false;
            }
        }

        private void TxtCargarVentaDNICliente_TextChanged(object sender, EventArgs e)
        {
            if (TxtCargarVentaDNICliente.Text != "")
            {
                BtnCargarVentaBuscarCliente.Enabled = true;
            }
            else
            {
                BtnCargarVentaBuscarCliente.Enabled = false;
            }
        }

        private void BtnCargarVentaBuscarEmpleado_Click(object sender, EventArgs e)
        {
            DniEmpleado = Convert.ToInt32(TxtCargarVentaDNIEmpleado.Text);

            while (l < VecNombreEmpleado.Length)
            {
                if (DniEmpleado == VecDNIEmpleado[l])
                {
                    LblCargarVentaMostrarNombreEmpleado.Text = VecNombreEmpleado[l];
                    LblCargarVentaMostrarApellidoEmpleado.Text = VecApellidoEmpleado[l];

                    BtnCargarVentaBuscarEmpleado.Enabled = false;
                }
                l++;
            }

            if (DniEmpleado != VecDNIEmpleado[m] && DniEmpleado != VecDNIEmpleado[m + 1] && DniEmpleado != VecDNIEmpleado[m + 2])
            {
                MessageBox.Show("EL EMPLEADO NO ESTA CARGADO O ESTA MAL INGRESADO.");

                TxtCargarVentaDNIEmpleado.Clear();
                LblCargarVentaMostrarNombreEmpleado.Text = "";
                LblCargarVentaMostrarApellidoEmpleado.Text = "";

                BtnCargarVentaBuscarEmpleado.Enabled = false;
            }
        }
        private void TxtCargarVentaDNIEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (TxtCargarVentaDNIEmpleado.Text != "")
            {
                BtnCargarVentaBuscarEmpleado.Enabled = true;
            }
            else
            {
                BtnCargarVentaBuscarEmpleado.Enabled = false;
            }
        }

        private void BtnGuardarCargarVenta_Click(object sender, EventArgs e)
        {
            if (n < VecNombreClienteVenta.Length)
            {
                VecNombreClienteVenta[n] = VecNombreCliente[n];
                VecApellidoClienteVenta[n] = VecApellidoCliente[n];
                VecDNIClienteVenta[n] = VecDNICliente[n];

                VecNombreEmpleadoVenta[n] = VecNombreEmpleado[n];
                VecApellidoEmpleadoVenta[n] = VecApellidoEmpleado[n];
                VecDNIEmpleadoVenta[n] = VecDNIEmpleado[n];

                n++;
            }

            if (i < VecNombreCliente.Length)
            {
                VecDNIClienteVenta[i] = Convert.ToInt32(TxtCargarVentaDNICliente.Text);
                VecDNIEmpleadoVenta[i] = Convert.ToInt32(TxtCargarVentaDNIEmpleado.Text);
                VecNombreClienteVenta[i] = LblCargarVentaMostrarNombreCliente.Text;
                VecNombreEmpleadoVenta[i] = LblCargarVentaMostrarNombreEmpleado.Text;
                VecApellidoClienteVenta[i] = LblCargarVentaMostrarApellidoCliente.Text;
                VecApellidoEmpleadoVenta[i] = LblCargarVentaMostrarApellidoEmpleado.Text;
                VecProductoVenta[i] = CmbCargarVentaProducto.Text;
                VecCantidadVenta[i] = Convert.ToInt32(NudCantidadCargarVenta.Value);
                VecMontoVenta[i] = Convert.ToInt32(TxtCargarMontoVenta.Text);  

                MessageBox.Show("LA VENTA SE GUARDO EXITOSAMENTE.");

                TxtCargarVentaDNICliente.Clear();
                TxtCargarVentaDNIEmpleado.Clear();
                LblCargarVentaMostrarNombreCliente.Text = "";
                LblCargarVentaMostrarApellidoCliente.Text = "";
                LblCargarVentaMostrarNombreEmpleado.Text = "";
                LblCargarVentaMostrarApellidoEmpleado.Text = "";
                TxtCargarMontoVenta.Clear();
                NudCantidadCargarVenta.Value = 0;
                CmbCargarVentaProducto.Text = "";

                i++;
            }
            else
            {
                MessageBox.Show("NO SE PUEDEN CARGAR MAS VENTAS.");

                TxtCargarVentaDNICliente.Clear();
                TxtCargarVentaDNIEmpleado.Clear();
                LblCargarVentaMostrarNombreCliente.Text = "";
                LblCargarVentaMostrarApellidoCliente.Text = "";
                LblCargarVentaMostrarNombreEmpleado.Text = "";
                LblCargarVentaMostrarApellidoEmpleado.Text = "";
                TxtCargarMontoVenta.Clear();
                NudCantidadCargarVenta.Value = 0;
                CmbCargarVentaProducto.Text = "";

                BtnGuardarCargarVenta.Enabled = false;
            }

            DniCliente = 0;
            DniEmpleado = 0;
            BtnGuardarCargarVenta.Enabled = false;
            BtnCargarVentaBuscarCliente.Enabled = false;
            BtnCargarVentaBuscarEmpleado.Enabled = false;
        }

        private void BtnLimpiarCargarVenta_Click(object sender, EventArgs e)
        {
            DniCliente = 0;
            DniEmpleado = 0;
            j = 0;
            k = 0;
            l = 0;
            m = 0;
            TxtCargarVentaDNICliente.Clear();
            TxtCargarVentaDNIEmpleado.Clear();
            LblCargarVentaMostrarNombreCliente.Text = "";
            LblCargarVentaMostrarApellidoCliente.Text = "";
            LblCargarVentaMostrarNombreEmpleado.Text = "";
            LblCargarVentaMostrarApellidoEmpleado.Text = "";
            TxtCargarMontoVenta.Clear();
            NudCantidadCargarVenta.Value = 0;
            CmbCargarVentaProducto.Text = "";

            BtnGuardarCargarVenta.Enabled = true;
        }

        private void BtnVolverCargarVenta_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }
    }
}
