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
    public partial class frmBuscarEmpleado : Form
    {
        public frmBuscarEmpleado()
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
        Int32 i = 0;
        Int32 j = 0;
        Int32 dni = 0;

        private void frmBuscarEmpleado_Load(object sender, EventArgs e)
        {
            VecNombreEmpleado = frmCargarEmpleado.VecNombreEmpleado;
            VecApellidoEmpleado = frmCargarEmpleado.VecApellidoEmpleado;
            VecEdadEmpleado = frmCargarEmpleado.VecEdadEmpleado;
            VecDNIEmpleado = frmCargarEmpleado.VecDNIEmpleado;
            VecDomicilioEmpleado = frmCargarEmpleado.VecDomicilioEmpleado;
            VecEmailEmpleado = frmCargarEmpleado.VecEmailEmpleado;
            VecTelefonoEmpleado = frmCargarEmpleado.VecTelefonoEmpleado;

            BtnBuscarBuscarEmpleado.Enabled = false;
        }

        private void BtnBuscarBuscarEmpleado_Click(object sender, EventArgs e)
        {
            dni = Convert.ToInt32(TxtBuscarDNIEmpleado.Text);

            while (i < VecNombreEmpleado.Length)
            {
                if (dni == VecDNIEmpleado[i])
                {
                    LblBuscarNombreMostrarEmpleado.Text = VecNombreEmpleado[i];
                    LblBuscarApellidoMostrarEmpleado.Text = VecApellidoEmpleado[i];
                    LblBuscarEdadMostrarEmpleado.Text = Convert.ToString(VecEdadEmpleado[i]);
                    LblBuscarDomicilioMostrarEmpleado.Text = VecDomicilioEmpleado[i];
                    LblBuscarMailMostrarEmpleado.Text = VecEmailEmpleado[i];
                    LblBuscarTelefonoMostrarEmpleado.Text = VecTelefonoEmpleado[i];

                    BtnBuscarBuscarEmpleado.Enabled = false;
                }
                i++;
            }

            if (dni != VecDNIEmpleado[j] && dni != VecDNIEmpleado[j + 1] && dni != VecDNIEmpleado[j + 2])
            {
                MessageBox.Show("EL CLIENTE NO ESTA CARGADO O ESTA MAL INGRESADO.");

                BtnBuscarBuscarEmpleado.Enabled = false;
            }
        }

        private void TxtBuscarDNIEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarDNIEmpleado.Text != "")
            {
                BtnBuscarBuscarEmpleado.Enabled = true;
            }
            else
            {
                BtnBuscarBuscarEmpleado.Enabled = false;
            }
        }

        private void BtnLimpiarBuscarEmpleado_Click(object sender, EventArgs e)
        {
            TxtBuscarDNIEmpleado.Clear();
            LblBuscarNombreMostrarEmpleado.Text = "";
            LblBuscarApellidoMostrarEmpleado.Text = "";
            LblBuscarEdadMostrarEmpleado.Text = "";
            LblBuscarDomicilioMostrarEmpleado.Text = "";
            LblBuscarMailMostrarEmpleado.Text = "";
            LblBuscarTelefonoMostrarEmpleado.Text = "";

            i = 0;
            j = 0;
            dni = 0;
        }

        private void BtnVolverBuscarEmpleado_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }
    }
}
