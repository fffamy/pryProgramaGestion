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
    public partial class frmCargarEmpleado : Form
    {
        public frmCargarEmpleado()
        {
            InitializeComponent();
        }

        public static String[] VecNombreEmpleado = new String[3];
        public static String[] VecApellidoEmpleado = new String[3];
        public static Int32[] VecEdadEmpleado = new Int32[3];
        public static Int32[] VecDNIEmpleado = new Int32[3];
        public static String[] VecDomicilioEmpleado = new String[3];
        public static String[] VecEmailEmpleado = new String[3];
        public static String[] VecTelefonoEmpleado = new String[3];
        public static Int32 i = 0;

        private void BtnGuardarCargarEmpleado_Click(object sender, EventArgs e)
        {
            if (i < VecNombreEmpleado.Length)
            {
                VecNombreEmpleado[i] = TxtCargarNombreEmpleado.Text;
                VecApellidoEmpleado[i] = TxtCargarApellidoEmpleado.Text;
                VecEdadEmpleado[i] = Convert.ToInt32(TxtCargarEdadEmpleado.Text);
                VecDNIEmpleado[i] = Convert.ToInt32(TxtCargarDNIEmpleado.Text);
                VecDomicilioEmpleado[i] = TxtCargarDomicilioEmpleado.Text;
                VecEmailEmpleado[i] = TxtCargarEmailEmpleado.Text;
                VecTelefonoEmpleado[i] = TxtCargarTelefonoEmpleado.Text;

                MessageBox.Show("LOS DATOS HAN SIDO GUARDADOS EXITOSAMENTE");
                TxtCargarNombreEmpleado.Clear();
                TxtCargarApellidoEmpleado.Clear();
                TxtCargarEdadEmpleado.Clear();
                TxtCargarDNIEmpleado.Clear();
                TxtCargarDomicilioEmpleado.Clear();
                TxtCargarEmailEmpleado.Clear();
                TxtCargarTelefonoEmpleado.Clear();

                i++;
            }
            else
            {
                MessageBox.Show("NO SE PUEDEN GUARDAR MAS DATOS");
                TxtCargarNombreEmpleado.Clear();
                TxtCargarApellidoEmpleado.Clear();
                TxtCargarEdadEmpleado.Clear();
                TxtCargarDNIEmpleado.Clear();
                TxtCargarDomicilioEmpleado.Clear();
                TxtCargarEmailEmpleado.Clear();
                TxtCargarTelefonoEmpleado.Clear();

                BtnGuardarCargarEmpleado.Enabled = false;
            }
        }

        private void BtnVolverCargarEmpleado_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }
    }
}
