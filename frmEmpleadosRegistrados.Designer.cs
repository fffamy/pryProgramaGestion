
namespace pryProgramaGestion
{
    partial class frmEmpleadosRegistrados
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
            this.BtnVolverEmpleadosRegistrados = new System.Windows.Forms.Button();
            this.BtnLimpiarEmpleadosRegistrados = new System.Windows.Forms.Button();
            this.BtnMostrarEmpleadosRegistrados = new System.Windows.Forms.Button();
            this.MrcEmpleadosRegistrados = new System.Windows.Forms.GroupBox();
            this.DtvMostrarEmpleados = new System.Windows.Forms.DataGridView();
            this.ColumnaNombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaApellidoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEdadEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDNIEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDomicilioEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEmailEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTelefonoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MrcEmpleadosRegistrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtvMostrarEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVolverEmpleadosRegistrados
            // 
            this.BtnVolverEmpleadosRegistrados.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolverEmpleadosRegistrados.Location = new System.Drawing.Point(816, 197);
            this.BtnVolverEmpleadosRegistrados.Name = "BtnVolverEmpleadosRegistrados";
            this.BtnVolverEmpleadosRegistrados.Size = new System.Drawing.Size(125, 31);
            this.BtnVolverEmpleadosRegistrados.TabIndex = 14;
            this.BtnVolverEmpleadosRegistrados.Text = "Volver";
            this.BtnVolverEmpleadosRegistrados.UseVisualStyleBackColor = true;
            this.BtnVolverEmpleadosRegistrados.Click += new System.EventHandler(this.BtnVolverEmpleadosRegistrados_Click);
            // 
            // BtnLimpiarEmpleadosRegistrados
            // 
            this.BtnLimpiarEmpleadosRegistrados.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarEmpleadosRegistrados.Location = new System.Drawing.Point(816, 135);
            this.BtnLimpiarEmpleadosRegistrados.Name = "BtnLimpiarEmpleadosRegistrados";
            this.BtnLimpiarEmpleadosRegistrados.Size = new System.Drawing.Size(125, 31);
            this.BtnLimpiarEmpleadosRegistrados.TabIndex = 13;
            this.BtnLimpiarEmpleadosRegistrados.Text = "Limpiar";
            this.BtnLimpiarEmpleadosRegistrados.UseVisualStyleBackColor = true;
            this.BtnLimpiarEmpleadosRegistrados.Click += new System.EventHandler(this.BtnLimpiarEmpleadosRegistrados_Click);
            // 
            // BtnMostrarEmpleadosRegistrados
            // 
            this.BtnMostrarEmpleadosRegistrados.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarEmpleadosRegistrados.Location = new System.Drawing.Point(816, 75);
            this.BtnMostrarEmpleadosRegistrados.Name = "BtnMostrarEmpleadosRegistrados";
            this.BtnMostrarEmpleadosRegistrados.Size = new System.Drawing.Size(125, 31);
            this.BtnMostrarEmpleadosRegistrados.TabIndex = 12;
            this.BtnMostrarEmpleadosRegistrados.Text = "Mostrar";
            this.BtnMostrarEmpleadosRegistrados.UseVisualStyleBackColor = true;
            this.BtnMostrarEmpleadosRegistrados.Click += new System.EventHandler(this.BtnMostrarEmpleadosRegistrados_Click);
            // 
            // MrcEmpleadosRegistrados
            // 
            this.MrcEmpleadosRegistrados.Controls.Add(this.DtvMostrarEmpleados);
            this.MrcEmpleadosRegistrados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MrcEmpleadosRegistrados.Location = new System.Drawing.Point(17, 18);
            this.MrcEmpleadosRegistrados.Name = "MrcEmpleadosRegistrados";
            this.MrcEmpleadosRegistrados.Size = new System.Drawing.Size(778, 271);
            this.MrcEmpleadosRegistrados.TabIndex = 11;
            this.MrcEmpleadosRegistrados.TabStop = false;
            this.MrcEmpleadosRegistrados.Text = "EMPLEADOS REGISTRADOS";
            // 
            // DtvMostrarEmpleados
            // 
            this.DtvMostrarEmpleados.AllowUserToAddRows = false;
            this.DtvMostrarEmpleados.AllowUserToDeleteRows = false;
            this.DtvMostrarEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtvMostrarEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNombreEmpleado,
            this.ColumnaApellidoEmpleado,
            this.ColumnaEdadEmpleado,
            this.ColumnaDNIEmpleado,
            this.ColumnaDomicilioEmpleado,
            this.ColumnaEmailEmpleado,
            this.ColumnaTelefonoEmpleado});
            this.DtvMostrarEmpleados.Location = new System.Drawing.Point(15, 36);
            this.DtvMostrarEmpleados.Name = "DtvMostrarEmpleados";
            this.DtvMostrarEmpleados.ReadOnly = true;
            this.DtvMostrarEmpleados.Size = new System.Drawing.Size(743, 212);
            this.DtvMostrarEmpleados.TabIndex = 1;
            // 
            // ColumnaNombreEmpleado
            // 
            this.ColumnaNombreEmpleado.HeaderText = "Nombre";
            this.ColumnaNombreEmpleado.Name = "ColumnaNombreEmpleado";
            this.ColumnaNombreEmpleado.ReadOnly = true;
            // 
            // ColumnaApellidoEmpleado
            // 
            this.ColumnaApellidoEmpleado.HeaderText = "Apellido";
            this.ColumnaApellidoEmpleado.Name = "ColumnaApellidoEmpleado";
            this.ColumnaApellidoEmpleado.ReadOnly = true;
            // 
            // ColumnaEdadEmpleado
            // 
            this.ColumnaEdadEmpleado.HeaderText = "Edad";
            this.ColumnaEdadEmpleado.Name = "ColumnaEdadEmpleado";
            this.ColumnaEdadEmpleado.ReadOnly = true;
            // 
            // ColumnaDNIEmpleado
            // 
            this.ColumnaDNIEmpleado.HeaderText = "DNI";
            this.ColumnaDNIEmpleado.Name = "ColumnaDNIEmpleado";
            this.ColumnaDNIEmpleado.ReadOnly = true;
            // 
            // ColumnaDomicilioEmpleado
            // 
            this.ColumnaDomicilioEmpleado.HeaderText = "Domicilio";
            this.ColumnaDomicilioEmpleado.Name = "ColumnaDomicilioEmpleado";
            this.ColumnaDomicilioEmpleado.ReadOnly = true;
            // 
            // ColumnaEmailEmpleado
            // 
            this.ColumnaEmailEmpleado.HeaderText = "Email";
            this.ColumnaEmailEmpleado.Name = "ColumnaEmailEmpleado";
            this.ColumnaEmailEmpleado.ReadOnly = true;
            // 
            // ColumnaTelefonoEmpleado
            // 
            this.ColumnaTelefonoEmpleado.HeaderText = "Telefono";
            this.ColumnaTelefonoEmpleado.Name = "ColumnaTelefonoEmpleado";
            this.ColumnaTelefonoEmpleado.ReadOnly = true;
            // 
            // frmEmpleadosRegistrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(969, 306);
            this.Controls.Add(this.BtnVolverEmpleadosRegistrados);
            this.Controls.Add(this.BtnLimpiarEmpleadosRegistrados);
            this.Controls.Add(this.BtnMostrarEmpleadosRegistrados);
            this.Controls.Add(this.MrcEmpleadosRegistrados);
            this.Name = "frmEmpleadosRegistrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPLEADOS REGISTRADOS";
            this.MrcEmpleadosRegistrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtvMostrarEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVolverEmpleadosRegistrados;
        private System.Windows.Forms.Button BtnLimpiarEmpleadosRegistrados;
        private System.Windows.Forms.Button BtnMostrarEmpleadosRegistrados;
        private System.Windows.Forms.GroupBox MrcEmpleadosRegistrados;
        private System.Windows.Forms.DataGridView DtvMostrarEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaApellidoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaEdadEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDNIEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDomicilioEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaEmailEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTelefonoEmpleado;
    }
}