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
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
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
        Int32 i = 0;
        Int32 j = 0;
        Int32 dni = 0;

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            VecNombreCliente = frmCargarCliente.VecNombreCliente;
            VecApellidoCliente = frmCargarCliente.VecApellidoCliente;
            VecEdadCliente = frmCargarCliente.VecEdadCliente;
            VecDNICliente = frmCargarCliente.VecDNICliente;
            VecDomicilioCliente = frmCargarCliente.VecDomicilioCliente;
            VecEmailCliente = frmCargarCliente.VecEmailCliente;
            VecTelefonoCliente = frmCargarCliente.VecTelefonoCliente;

            BtnBuscarBuscarCliente.Enabled = false;
        }

        private void BtnBuscarBuscarCliente_Click(object sender, EventArgs e)
        {
            dni = Convert.ToInt32(TxtBuscarDNICliente.Text);

            while (i < VecNombreCliente.Length)
            {
                if (dni == VecDNICliente[i])
                {
                    LblBuscarNombreMostrarCliente.Text = VecNombreCliente[i];
                    LblBuscarApellidoMostrarCliente.Text = VecApellidoCliente[i];
                    LblBuscarEdadMostrarCliente.Text = Convert.ToString(VecEdadCliente[i]);
                    LblBuscarDomicilioMostrarCliente.Text = VecDomicilioCliente[i];
                    LblBuscarMailMostrarCliente.Text = VecEmailCliente[i];
                    LblBuscarTelefonoMostrarCliente.Text = VecTelefonoCliente[i];

                    BtnBuscarBuscarCliente.Enabled = false;
                }
                i++;
            }

            if (dni != VecDNICliente[j] && dni != VecDNICliente[j + 1] && dni != VecDNICliente[j + 2])
            {
                MessageBox.Show("EL CLIENTE NO ESTA CARGADO O ESTA MAL INGRESADO.");

                BtnBuscarBuscarCliente.Enabled = false;
            }
        }

        private void TxtBuscarDNICliente_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarDNICliente.Text != "")
            {
                BtnBuscarBuscarCliente.Enabled = true;
            }
            else
            {
                BtnBuscarBuscarCliente.Enabled = false;
            }
        }

        private void BtnLimpiarBuscarCliente_Click(object sender, EventArgs e)
        {
            TxtBuscarDNICliente.Clear();
            LblBuscarNombreMostrarCliente.Text = "";
            LblBuscarApellidoMostrarCliente.Text = "";
            LblBuscarEdadMostrarCliente.Text = "";
            LblBuscarDomicilioMostrarCliente.Text = "";
            LblBuscarMailMostrarCliente.Text = "";
            LblBuscarTelefonoMostrarCliente.Text = "";

            i = 0;
            j = 0;
            dni = 0;

        }

        private void BtnVolverBuscarCliente_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }
    }
}
