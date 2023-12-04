
namespace pryProgramaGestion
{
    partial class frmCargarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnVolverCargarVenta = new System.Windows.Forms.Button();
            this.BtnGuardarCargarVenta = new System.Windows.Forms.Button();
            this.LblCargarDNIClienteVenta = new System.Windows.Forms.Label();
            this.LblCargarApellidoClienteVenta = new System.Windows.Forms.Label();
            this.LblCargarNombreClienteVenta = new System.Windows.Forms.Label();
            this.LblCargarDNIEmpleadoVenta = new System.Windows.Forms.Label();
            this.LblCargarApellidoEmpleadoVenta = new System.Windows.Forms.Label();
            this.LblCargarNombreEmpleadoVenta = new System.Windows.Forms.Label();
            this.CmbCargarVentaProducto = new System.Windows.Forms.ComboBox();
            this.LblProductoCargarVenta = new System.Windows.Forms.Label();
            this.LblMontoCargarVenta = new System.Windows.Forms.Label();
            this.TxtCargarMontoVenta = new System.Windows.Forms.TextBox();
            this.MrcCargarVenta = new System.Windows.Forms.GroupBox();
            this.BtnCargarVentaBuscarEmpleado = new System.Windows.Forms.Button();
            this.BtnCargarVentaBuscarCliente = new System.Windows.Forms.Button();
            this.TxtCargarVentaDNIEmpleado = new System.Windows.Forms.TextBox();
            this.TxtCargarVentaDNICliente = new System.Windows.Forms.TextBox();
            this.LblCargarVentaMostrarApellidoEmpleado = new System.Windows.Forms.Label();
            this.LblCargarVentaMostrarNombreEmpleado = new System.Windows.Forms.Label();
            this.LblCargarVentaMostrarApellidoCliente = new System.Windows.Forms.Label();
            this.LblCargarVentaMostrarNombreCliente = new System.Windows.Forms.Label();
            this.LblCantidadCargarVenta = new System.Windows.Forms.Label();
            this.NudCantidadCargarVenta = new System.Windows.Forms.NumericUpDown();
            this.BtnLimpiarCargarVenta = new System.Windows.Forms.Button();
            this.MrcCargarVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidadCargarVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVolverCargarVenta
            // 
            this.BtnVolverCargarVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolverCargarVenta.Location = new System.Drawing.Point(655, 275);
            this.BtnVolverCargarVenta.Name = "BtnVolverCargarVenta";
            this.BtnVolverCargarVenta.Size = new System.Drawing.Size(110, 42);
            this.BtnVolverCargarVenta.TabIndex = 23;
            this.BtnVolverCargarVenta.Text = "Volver";
            this.BtnVolverCargarVenta.UseVisualStyleBackColor = true;
            this.BtnVolverCargarVenta.Click += new System.EventHandler(this.BtnVolverCargarVenta_Click);
            // 
            // BtnGuardarCargarVenta
            // 
            this.BtnGuardarCargarVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarCargarVenta.Location = new System.Drawing.Point(484, 275);
            this.BtnGuardarCargarVenta.Name = "BtnGuardarCargarVenta";
            this.BtnGuardarCargarVenta.Size = new System.Drawing.Size(110, 42);
            this.BtnGuardarCargarVenta.TabIndex = 22;
            this.BtnGuardarCargarVenta.Text = "Guardar";
            this.BtnGuardarCargarVenta.UseVisualStyleBackColor = true;
            this.BtnGuardarCargarVenta.Click += new System.EventHandler(this.BtnGuardarCargarVenta_Click);
            // 
            // LblCargarDNIClienteVenta
            // 
            this.LblCargarDNIClienteVenta.AutoSize = true;
            this.LblCargarDNIClienteVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargarDNIClienteVenta.Location = new System.Drawing.Point(22, 35);
            this.LblCargarDNIClienteVenta.Name = "LblCargarDNIClienteVenta";
            this.LblCargarDNIClienteVenta.Size = new System.Drawing.Size(113, 22);
            this.LblCargarDNIClienteVenta.TabIndex = 18;
            this.LblCargarDNIClienteVenta.Text = "DNI cliente: ";
            // 
            // LblCargarApellidoClienteVenta
            // 
            this.LblCargarApellidoClienteVenta.AutoSize = true;
            this.LblCargarApellidoClienteVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargarApellidoClienteVenta.Location = new System.Drawing.Point(21, 196);
            this.LblCargarApellidoClienteVenta.Name = "LblCargarApellidoClienteVenta";
            this.LblCargarApellidoClienteVenta.Size = new System.Drawing.Size(149, 22);
            this.LblCargarApellidoClienteVenta.TabIndex = 17;
            this.LblCargarApellidoClienteVenta.Text = "Apellido cliente: ";
            // 
            // LblCargarNombreClienteVenta
            // 
            this.LblCargarNombreClienteVenta.AutoSize = true;
            this.LblCargarNombreClienteVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargarNombreClienteVenta.Location = new System.Drawing.Point(22, 139);
            this.LblCargarNombreClienteVenta.Name = "LblCargarNombreClienteVenta";
            this.LblCargarNombreClienteVenta.Size = new System.Drawing.Size(148, 22);
            this.LblCargarNombreClienteVenta.TabIndex = 16;
            this.LblCargarNombreClienteVenta.Text = "Nombre cliente: ";
            // 
            // LblCargarDNIEmpleadoVenta
            // 
            this.LblCargarDNIEmpleadoVenta.AutoSize = true;
            this.LblCargarDNIEmpleadoVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargarDNIEmpleadoVenta.Location = new System.Drawing.Point(391, 31);
            this.LblCargarDNIEmpleadoVenta.Name = "LblCargarDNIEmpleadoVenta";
            this.LblCargarDNIEmpleadoVenta.Size = new System.Drawing.Size(143, 22);
            this.LblCargarDNIEmpleadoVenta.TabIndex = 26;
            this.LblCargarDNIEmpleadoVenta.Text = "DNI empleado: ";
            // 
            // LblCargarApellidoEmpleadoVenta
            // 
            this.LblCargarApellidoEmpleadoVenta.AutoSize = true;
            this.LblCargarApellidoEmpleadoVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargarApellidoEmpleadoVenta.Location = new System.Drawing.Point(391, 192);
            this.LblCargarApellidoEmpleadoVenta.Name = "LblCargarApellidoEmpleadoVenta";
            this.LblCargarApellidoEmpleadoVenta.Size = new System.Drawing.Size(179, 22);
            this.LblCargarApellidoEmpleadoVenta.TabIndex = 25;
            this.LblCargarApellidoEmpleadoVenta.Text = "Apellido empleado: ";
            // 
            // LblCargarNombreEmpleadoVenta
            // 
            this.LblCargarNombreEmpleadoVenta.AutoSize = true;
            this.LblCargarNombreEmpleadoVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargarNombreEmpleadoVenta.Location = new System.Drawing.Point(392, 135);
            this.LblCargarNombreEmpleadoVenta.Name = "LblCargarNombreEmpleadoVenta";
            this.LblCargarNombreEmpleadoVenta.Size = new System.Drawing.Size(178, 22);
            this.LblCargarNombreEmpleadoVenta.TabIndex = 24;
            this.LblCargarNombreEmpleadoVenta.Text = "Nombre empleado: ";
            // 
            // CmbCargarVentaProducto
            // 
            this.CmbCargarVentaProducto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCargarVentaProducto.FormattingEnabled = true;
            this.CmbCargarVentaProducto.Items.AddRange(new object[] {
            "Procesador",
            "Placa de video",
            "MotherBoard"});
            this.CmbCargarVentaProducto.Location = new System.Drawing.Point(187, 277);
            this.CmbCargarVentaProducto.Name = "CmbCargarVentaProducto";
            this.CmbCargarVentaProducto.Size = new System.Drawing.Size(176, 30);
            this.CmbCargarVentaProducto.TabIndex = 30;
            // 
            // LblProductoCargarVenta
            // 
            this.LblProductoCargarVenta.AutoSize = true;
            this.LblProductoCargarVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductoCargarVenta.Location = new System.Drawing.Point(33, 285);
            this.LblProductoCargarVenta.Name = "LblProductoCargarVenta";
            this.LblProductoCargarVenta.Size = new System.Drawing.Size(108, 22);
            this.LblProductoCargarVenta.TabIndex = 31;
            this.LblProductoCargarVenta.Text = "Producto: ";
            // 
            // LblMontoCargarVenta
            // 
            this.LblMontoCargarVenta.AutoSize = true;
            this.LblMontoCargarVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMontoCargarVenta.Location = new System.Drawing.Point(34, 373);
            this.LblMontoCargarVenta.Name = "LblMontoCargarVenta";
            this.LblMontoCargarVenta.Size = new System.Drawing.Size(81, 22);
            this.LblMontoCargarVenta.TabIndex = 32;
            this.LblMontoCargarVenta.Text = "Monto: ";
            // 
            // TxtCargarMontoVenta
            // 
            this.TxtCargarMontoVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCargarMontoVenta.Location = new System.Drawing.Point(188, 366);
            this.TxtCargarMontoVenta.Name = "TxtCargarMontoVenta";
            this.TxtCargarMontoVenta.Size = new System.Drawing.Size(176, 29);
            this.TxtCargarMontoVenta.TabIndex = 33;
            // 
            // MrcCargarVenta
            // 
            this.MrcCargarVenta.Controls.Add(this.BtnCargarVentaBuscarEmpleado);
            this.MrcCargarVenta.Controls.Add(this.BtnCargarVentaBuscarCliente);
            this.MrcCargarVenta.Controls.Add(this.TxtCargarVentaDNIEmpleado);
            this.MrcCargarVenta.Controls.Add(this.TxtCargarVentaDNICliente);
            this.MrcCargarVenta.Controls.Add(this.LblCargarVentaMostrarApellidoEmpleado);
            this.MrcCargarVenta.Controls.Add(this.LblCargarVentaMostrarNombreEmpleado);
            this.MrcCargarVenta.Controls.Add(this.LblCargarVentaMostrarApellidoCliente);
            this.MrcCargarVenta.Controls.Add(this.LblCargarVentaMostrarNombreCliente);
            this.MrcCargarVenta.Controls.Add(this.LblCargarApellidoClienteVenta);
            this.MrcCargarVenta.Controls.Add(this.LblCargarNombreClienteVenta);
            this.MrcCargarVenta.Controls.Add(this.LblCargarDNIClienteVenta);
            this.MrcCargarVenta.Controls.Add(this.LblCargarNombreEmpleadoVenta);
            this.MrcCargarVenta.Controls.Add(this.LblCargarApellidoEmpleadoVenta);
            this.MrcCargarVenta.Controls.Add(this.LblCargarDNIEmpleadoVenta);
            this.MrcCargarVenta.Location = new System.Drawing.Point(12, 12);
            this.MrcCargarVenta.Name = "MrcCargarVenta";
            this.MrcCargarVenta.Size = new System.Drawing.Size(777, 247);
            this.MrcCargarVenta.TabIndex = 34;
            this.MrcCargarVenta.TabStop = false;
            // 
            // BtnCargarVentaBuscarEmpleado
            // 
            this.BtnCargarVentaBuscarEmpleado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarVentaBuscarEmpleado.Location = new System.Drawing.Point(395, 79);
            this.BtnCargarVentaBuscarEmpleado.Name = "BtnCargarVentaBuscarEmpleado";
            this.BtnCargarVentaBuscarEmpleado.Size = new System.Drawing.Size(187, 31);
            this.BtnCargarVentaBuscarEmpleado.TabIndex = 40;
            this.BtnCargarVentaBuscarEmpleado.Text = "Buscar empleado";
            this.BtnCargarVentaBuscarEmpleado.UseVisualStyleBackColor = true;
            this.BtnCargarVentaBuscarEmpleado.Click += new System.EventHandler(this.BtnCargarVentaBuscarEmpleado_Click);
            // 
            // BtnCargarVentaBuscarCliente
            // 
            this.BtnCargarVentaBuscarCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarVentaBuscarCliente.Location = new System.Drawing.Point(25, 79);
            this.BtnCargarVentaBuscarCliente.Name = "BtnCargarVentaBuscarCliente";
            this.BtnCargarVentaBuscarCliente.Size = new System.Drawing.Size(187, 31);
            this.BtnCargarVentaBuscarCliente.TabIndex = 39;
            this.BtnCargarVentaBuscarCliente.Text = "Buscar cliente";
            this.BtnCargarVentaBuscarCliente.UseVisualStyleBackColor = true;
            this.BtnCargarVentaBuscarCliente.Click += new System.EventHandler(this.BtnCargarVentaBuscarCliente_Click);
            // 
            // TxtCargarVentaDNIEmpleado
            // 
            this.TxtCargarVentaDNIEmpleado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCargarVentaDNIEmpleado.Location = new System.Drawing.Point(573, 28);
            this.TxtCargarVentaDNIEmpleado.Name = "TxtCargarVentaDNIEmpleado";
            this.TxtCargarVentaDNIEmpleado.Size = new System.Drawing.Size(180, 29);
            this.TxtCargarVentaDNIEmpleado.TabIndex = 38;
            this.TxtCargarVentaDNIEmpleado.TextChanged += new System.EventHandler(this.TxtCargarVentaDNIEmpleado_TextChanged);
            // 
            // TxtCargarVentaDNICliente
            // 
            this.TxtCargarVentaDNICliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCargarVentaDNICliente.Location = new System.Drawing.Point(172, 28);
            this.TxtCargarVentaDNICliente.Name = "TxtCargarVentaDNICliente";
            this.TxtCargarVentaDNICliente.Size = new System.Drawing.Size(180, 29);
            this.TxtCargarVentaDNICliente.TabIndex = 37;
            this.TxtCargarVentaDNICliente.TextChanged += new System.EventHandler(this.TxtCargarVentaDNICliente_TextChanged);
            // 
            // LblCargarVentaMostrarApellidoEmpleado
            // 
            this.LblCargarVentaMostrarApellidoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCargarVentaMostrarApellidoEmpleado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargarVentaMostrarApellidoEmpleado.Location = new System.Drawing.Point(573, 195);
            this.LblCargarVentaMostrarApellidoEmpleado.Name = "LblCargarVentaMostrarApellidoEmpleado";
            this.LblCargarVentaMostrarApellidoEmpleado.Size = new System.Drawing.Size(180, 22);
            this.LblCargarVentaMostrarApellidoEmpleado.TabIndex = 36;
            // 
            // LblCargarVentaMostrarNombreEmpleado
            // 
            this.LblCargarVentaMostrarNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCargarVentaMostrarNombreEmpleado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargarVentaMostrarNombreEmpleado.Location = new System.Drawing.Point(573, 138);
            this.LblCargarVentaMostrarNombreEmpleado.Name = "LblCargarVentaMostrarNombreEmpleado";
            this.LblCargarVentaMostrarNombreEmpleado.Size = new System.Drawing.Size(180, 22);
            this.LblCargarVentaMostrarNombreEmpleado.TabIndex = 35;
            // 
            // LblCargarVentaMostrarApellidoCliente
            // 
            this.LblCargarVentaMostrarApellidoCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCargarVentaMostrarApellidoCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargarVentaMostrarApellidoCliente.Location = new System.Drawing.Point(172, 196);
            this.LblCargarVentaMostrarApellidoCliente.Name = "LblCargarVentaMostrarApellidoCliente";
            this.LblCargarVentaMostrarApellidoCliente.Size = new System.Drawing.Size(180, 22);
            this.LblCargarVentaMostrarApellidoCliente.TabIndex = 34;
            // 
            // LblCargarVentaMostrarNombreCliente
            // 
            this.LblCargarVentaMostrarNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCargarVentaMostrarNombreCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargarVentaMostrarNombreCliente.Location = new System.Drawing.Point(172, 138);
            this.LblCargarVentaMostrarNombreCliente.Name = "LblCargarVentaMostrarNombreCliente";
            this.LblCargarVentaMostrarNombreCliente.Size = new System.Drawing.Size(180, 22);
            this.LblCargarVentaMostrarNombreCliente.TabIndex = 33;
            // 
            // LblCantidadCargarVenta
            // 
            this.LblCantidadCargarVenta.AutoSize = true;
            this.LblCantidadCargarVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadCargarVenta.Location = new System.Drawing.Point(33, 328);
            this.LblCantidadCargarVenta.Name = "LblCantidadCargarVenta";
            this.LblCantidadCargarVenta.Size = new System.Drawing.Size(105, 22);
            this.LblCantidadCargarVenta.TabIndex = 35;
            this.LblCantidadCargarVenta.Text = "Cantidad: ";
            // 
            // NudCantidadCargarVenta
            // 
            this.NudCantidadCargarVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudCantidadCargarVenta.Location = new System.Drawing.Point(187, 321);
            this.NudCantidadCargarVenta.Name = "NudCantidadCargarVenta";
            this.NudCantidadCargarVenta.Size = new System.Drawing.Size(53, 29);
            this.NudCantidadCargarVenta.TabIndex = 36;
            // 
            // BtnLimpiarCargarVenta
            // 
            this.BtnLimpiarCargarVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarCargarVenta.Location = new System.Drawing.Point(484, 353);
            this.BtnLimpiarCargarVenta.Name = "BtnLimpiarCargarVenta";
            this.BtnLimpiarCargarVenta.Size = new System.Drawing.Size(110, 42);
            this.BtnLimpiarCargarVenta.TabIndex = 37;
            this.BtnLimpiarCargarVenta.Text = "Limpiar";
            this.BtnLimpiarCargarVenta.UseVisualStyleBackColor = true;
            this.BtnLimpiarCargarVenta.Click += new System.EventHandler(this.BtnLimpiarCargarVenta_Click);
            // 
            // frmCargarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(818, 431);
            this.Controls.Add(this.BtnLimpiarCargarVenta);
            this.Controls.Add(this.NudCantidadCargarVenta);
            this.Controls.Add(this.LblCantidadCargarVenta);
            this.Controls.Add(this.MrcCargarVenta);
            this.Controls.Add(this.TxtCargarMontoVenta);
            this.Controls.Add(this.LblMontoCargarVenta);
            this.Controls.Add(this.LblProductoCargarVenta);
            this.Controls.Add(this.CmbCargarVentaProducto);
            this.Controls.Add(this.BtnVolverCargarVenta);
            this.Controls.Add(this.BtnGuardarCargarVenta);
            this.Name = "frmCargarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARGAR VENTA";
            this.Load += new System.EventHandler(this.frmCargarVenta_Load);
            this.MrcCargarVenta.ResumeLayout(false);
            this.MrcCargarVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidadCargarVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVolverCargarVenta;
        private System.Windows.Forms.Button BtnGuardarCargarVenta;
        private System.Windows.Forms.Label LblCargarDNIClienteVenta;
        private System.Windows.Forms.Label LblCargarApellidoClienteVenta;
        private System.Windows.Forms.Label LblCargarNombreClienteVenta;
        private System.Windows.Forms.Label LblCargarDNIEmpleadoVenta;
        private System.Windows.Forms.Label LblCargarApellidoEmpleadoVenta;
        private System.Windows.Forms.Label LblCargarNombreEmpleadoVenta;
        private System.Windows.Forms.ComboBox CmbCargarVentaProducto;
        private System.Windows.Forms.Label LblProductoCargarVenta;
        private System.Windows.Forms.Label LblMontoCargarVenta;
        private System.Windows.Forms.TextBox TxtCargarMontoVenta;
        private System.Windows.Forms.GroupBox MrcCargarVenta;
        private System.Windows.Forms.Label LblCantidadCargarVenta;
        private System.Windows.Forms.NumericUpDown NudCantidadCargarVenta;
        private System.Windows.Forms.Label LblCargarVentaMostrarApellidoEmpleado;
        private System.Windows.Forms.Label LblCargarVentaMostrarNombreEmpleado;
        private System.Windows.Forms.Label LblCargarVentaMostrarApellidoCliente;
        private System.Windows.Forms.Label LblCargarVentaMostrarNombreCliente;
        private System.Windows.Forms.TextBox TxtCargarVentaDNIEmpleado;
        private System.Windows.Forms.TextBox TxtCargarVentaDNICliente;
        private System.Windows.Forms.Button BtnCargarVentaBuscarEmpleado;
        private System.Windows.Forms.Button BtnCargarVentaBuscarCliente;
        private System.Windows.Forms.Button BtnLimpiarCargarVenta;
    }
}