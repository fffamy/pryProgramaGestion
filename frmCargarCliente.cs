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
    public partial class frmCargarCliente : Form
    {
        public frmCargarCliente()
        {
            InitializeComponent();
        }

        public static String[] VecNombreCliente = new String[3];
        public static String[] VecApellidoCliente = new String[3];
        public static Int32[] VecEdadCliente = new Int32[3]; 
        public static Int32[] VecDNICliente = new Int32[3];
        public static String[] VecDomicilioCliente = new String[3];
        public static String[] VecEmailCliente = new String[3];
        public static String[] VecTelefonoCliente = new String[3];
        public static Int32 i = 0;

        private void BtnGuardarCargarCliente_Click(object sender, EventArgs e)
        {
            if(i < VecNombreCliente.Length)
            {
                VecNombreCliente[i] = TxtCargarNombreCliente.Text;
                VecApellidoCliente[i] = TxtCargarApellidoCliente.Text;
                VecEdadCliente[i] = Convert.ToInt32(TxtCargarEdadCliente.Text);
                VecDNICliente[i] = Convert.ToInt32(TxtCargarDNICliente.Text);
                VecDomicilioCliente[i] = TxtCargarDomicilioCliente.Text;
                VecEmailCliente[i] = TxtCargarEmailCliente.Text;
                VecTelefonoCliente[i] = TxtCargarTelefonoCliente.Text;

                MessageBox.Show("LOS DATOS HAN SIDO GUARDADOS EXITOSAMENTE");
                TxtCargarNombreCliente.Clear();
                TxtCargarApellidoCliente.Clear();
                TxtCargarEdadCliente.Clear();
                TxtCargarDNICliente.Clear();
                TxtCargarDomicilioCliente.Clear();
                TxtCargarEmailCliente.Clear();
                TxtCargarTelefonoCliente.Clear();

                i++;
            }
            else
            {
                MessageBox.Show("NO SE PUEDEN GUARDAR MAS DATOS");
                TxtCargarNombreCliente.Clear();
                TxtCargarApellidoCliente.Clear();
                TxtCargarEdadCliente.Clear();
                TxtCargarDNICliente.Clear();
                TxtCargarDomicilioCliente.Clear();
                TxtCargarEmailCliente.Clear();
                TxtCargarTelefonoCliente.Clear();

                BtnGuardarCargarCliente.Enabled = false;
            }

        }

        private void BtnVolverCargarCliente_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }
    }
}
