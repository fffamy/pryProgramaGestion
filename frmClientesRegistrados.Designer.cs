
namespace pryProgramaGestion
{
    partial class frmClientesRegistrados
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
            this.MrcClientesRegistrados = new System.Windows.Forms.GroupBox();
            this.DtvMostrarClientes = new System.Windows.Forms.DataGridView();
            this.ColumnaNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEdadCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDNICliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDomicilioCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEmailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnMostrarClientesRegistrados = new System.Windows.Forms.Button();
            this.BtnLimpiarClientesRegistrados = new System.Windows.Forms.Button();
            this.BtnVolverClientesRegistrados = new System.Windows.Forms.Button();
            this.MrcClientesRegistrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtvMostrarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // MrcClientesRegistrados
            // 
            this.MrcClientesRegistrados.Controls.Add(this.DtvMostrarClientes);
            this.MrcClientesRegistrados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MrcClientesRegistrados.Location = new System.Drawing.Point(18, 17);
            this.MrcClientesRegistrados.Name = "MrcClientesRegistrados";
            this.MrcClientesRegistrados.Size = new System.Drawing.Size(781, 271);
            this.MrcClientesRegistrados.TabIndex = 0;
            this.MrcClientesRegistrados.TabStop = false;
            this.MrcClientesRegistrados.Text = "CLIENTES REGISTRADOS";
            // 
            // DtvMostrarClientes
            // 
            this.DtvMostrarClientes.AllowUserToAddRows = false;
            this.DtvMostrarClientes.AllowUserToDeleteRows = false;
            this.DtvMostrarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtvMostrarClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNombreCliente,
            this.ColumnaApellidoCliente,
            this.ColumnaEdadCliente,
            this.ColumnaDNICliente,
            this.ColumnaDomicilioCliente,
            this.ColumnaEmailCliente,
            this.ColumnaTelefonoCliente});
            this.DtvMostrarClientes.Location = new System.Drawing.Point(19, 37);
            this.DtvMostrarClientes.Name = "DtvMostrarClientes";
            this.DtvMostrarClientes.ReadOnly = true;
            this.DtvMostrarClientes.Size = new System.Drawing.Size(743, 212);
            this.DtvMostrarClientes.TabIndex = 0;
            // 
            // ColumnaNombreCliente
            // 
            this.ColumnaNombreCliente.HeaderText = "Nombre";
            this.ColumnaNombreCliente.Name = "ColumnaNombreCliente";
            this.ColumnaNombreCliente.ReadOnly = true;
            // 
            // ColumnaApellidoCliente
            // 
            this.ColumnaApellidoCliente.HeaderText = "Apellido";
            this.ColumnaApellidoCliente.Name = "ColumnaApellidoCliente";
            this.ColumnaApellidoCliente.ReadOnly = true;
            // 
            // ColumnaEdadCliente
            // 
            this.ColumnaEdadCliente.HeaderText = "Edad";
            this.ColumnaEdadCliente.Name = "ColumnaEdadCliente";
            this.ColumnaEdadCliente.ReadOnly = true;
            // 
            // ColumnaDNICliente
            // 
            this.ColumnaDNICliente.HeaderText = "DNI";
            this.ColumnaDNICliente.Name = "ColumnaDNICliente";
            this.ColumnaDNICliente.ReadOnly = true;
            // 
            // ColumnaDomicilioCliente
            // 
            this.ColumnaDomicilioCliente.HeaderText = "Domicilio";
            this.ColumnaDomicilioCliente.Name = "ColumnaDomicilioCliente";
            this.ColumnaDomicilioCliente.ReadOnly = true;
            // 
            // ColumnaEmailCliente
            // 
            this.ColumnaEmailCliente.HeaderText = "Email";
            this.ColumnaEmailCliente.Name = "ColumnaEmailCliente";
            this.ColumnaEmailCliente.ReadOnly = true;
            // 
            // ColumnaTelefonoCliente
            // 
            this.ColumnaTelefonoCliente.HeaderText = "Telefono";
            this.ColumnaTelefonoCliente.Name = "ColumnaTelefonoCliente";
            this.ColumnaTelefonoCliente.ReadOnly = true;
            // 
            // BtnMostrarClientesRegistrados
            // 
            this.BtnMostrarClientesRegistrados.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarClientesRegistrados.Location = new System.Drawing.Point(817, 78);
            this.BtnMostrarClientesRegistrados.Name = "BtnMostrarClientesRegistrados";
            this.BtnMostrarClientesRegistrados.Size = new System.Drawing.Size(125, 31);
            this.BtnMostrarClientesRegistrados.TabIndex = 8;
            this.BtnMostrarClientesRegistrados.Text = "Mostrar";
            this.BtnMostrarClientesRegistrados.UseVisualStyleBackColor = true;
            this.BtnMostrarClientesRegistrados.Click += new System.EventHandler(this.BtnMostrarClientesRegistrados_Click);
            // 
            // BtnLimpiarClientesRegistrados
            // 
            this.BtnLimpiarClientesRegistrados.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarClientesRegistrados.Location = new System.Drawing.Point(817, 138);
            this.BtnLimpiarClientesRegistrados.Name = "BtnLimpiarClientesRegistrados";
            this.BtnLimpiarClientesRegistrados.Size = new System.Drawing.Size(125, 31);
            this.BtnLimpiarClientesRegistrados.TabIndex = 9;
            this.BtnLimpiarClientesRegistrados.Text = "Limpiar";
            this.BtnLimpiarClientesRegistrados.UseVisualStyleBackColor = true;
            this.BtnLimpiarClientesRegistrados.Click += new System.EventHandler(this.BtnLimpiarClientesRegistrados_Click);
            // 
            // BtnVolverClientesRegistrados
            // 
            this.BtnVolverClientesRegistrados.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolverClientesRegistrados.Location = new System.Drawing.Point(817, 200);
            this.BtnVolverClientesRegistrados.Name = "BtnVolverClientesRegistrados";
            this.BtnVolverClientesRegistrados.Size = new System.Drawing.Size(125, 31);
            this.BtnVolverClientesRegistrados.TabIndex = 10;
            this.BtnVolverClientesRegistrados.Text = "Volver";
            this.BtnVolverClientesRegistrados.UseVisualStyleBackColor = true;
            this.BtnVolverClientesRegistrados.Click += new System.EventHandler(this.BtnVolverClientesRegistrados_Click);
            // 
            // frmClientesRegistrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(969, 318);
            this.Controls.Add(this.BtnVolverClientesRegistrados);
            this.Controls.Add(this.BtnLimpiarClientesRegistrados);
            this.Controls.Add(this.BtnMostrarClientesRegistrados);
            this.Controls.Add(this.MrcClientesRegistrados);
            this.Name = "frmClientesRegistrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES REGISTRADOS";
            this.MrcClientesRegistrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtvMostrarClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MrcClientesRegistrados;
        private System.Windows.Forms.DataGridView DtvMostrarClientes;
        private System.Windows.Forms.Button BtnMostrarClientesRegistrados;
        private System.Windows.Forms.Button BtnLimpiarClientesRegistrados;
        private System.Windows.Forms.Button BtnVolverClientesRegistrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaEdadCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDNICliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDomicilioCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaEmailCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTelefonoCliente;
    }
}