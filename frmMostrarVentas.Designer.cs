
namespace pryProgramaGestion
{
    partial class frmMostrarVentas
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
            this.BtnVolverVentasRegistradas = new System.Windows.Forms.Button();
            this.BtnLimpiarVentasRegistradas = new System.Windows.Forms.Button();
            this.BtnMostrarVentasRegistradas = new System.Windows.Forms.Button();
            this.MrcVentasRegistradas = new System.Windows.Forms.GroupBox();
            this.DtvMostrarVentas = new System.Windows.Forms.DataGridView();
            this.ColumnaClienteVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEmpleadoVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaProductoVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidadVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaMontoVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MrcVentasRegistradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtvMostrarVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVolverVentasRegistradas
            // 
            this.BtnVolverVentasRegistradas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolverVentasRegistradas.Location = new System.Drawing.Point(624, 199);
            this.BtnVolverVentasRegistradas.Name = "BtnVolverVentasRegistradas";
            this.BtnVolverVentasRegistradas.Size = new System.Drawing.Size(125, 31);
            this.BtnVolverVentasRegistradas.TabIndex = 18;
            this.BtnVolverVentasRegistradas.Text = "Volver";
            this.BtnVolverVentasRegistradas.UseVisualStyleBackColor = true;
            this.BtnVolverVentasRegistradas.Click += new System.EventHandler(this.BtnVolverVentasRegistradas_Click);
            // 
            // BtnLimpiarVentasRegistradas
            // 
            this.BtnLimpiarVentasRegistradas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarVentasRegistradas.Location = new System.Drawing.Point(624, 137);
            this.BtnLimpiarVentasRegistradas.Name = "BtnLimpiarVentasRegistradas";
            this.BtnLimpiarVentasRegistradas.Size = new System.Drawing.Size(125, 31);
            this.BtnLimpiarVentasRegistradas.TabIndex = 17;
            this.BtnLimpiarVentasRegistradas.Text = "Limpiar";
            this.BtnLimpiarVentasRegistradas.UseVisualStyleBackColor = true;
            this.BtnLimpiarVentasRegistradas.Click += new System.EventHandler(this.BtnLimpiarVentasRegistradas_Click);
            // 
            // BtnMostrarVentasRegistradas
            // 
            this.BtnMostrarVentasRegistradas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarVentasRegistradas.Location = new System.Drawing.Point(624, 77);
            this.BtnMostrarVentasRegistradas.Name = "BtnMostrarVentasRegistradas";
            this.BtnMostrarVentasRegistradas.Size = new System.Drawing.Size(125, 31);
            this.BtnMostrarVentasRegistradas.TabIndex = 16;
            this.BtnMostrarVentasRegistradas.Text = "Mostrar";
            this.BtnMostrarVentasRegistradas.UseVisualStyleBackColor = true;
            this.BtnMostrarVentasRegistradas.Click += new System.EventHandler(this.BtnMostrarVentasRegistradas_Click);
            // 
            // MrcVentasRegistradas
            // 
            this.MrcVentasRegistradas.Controls.Add(this.DtvMostrarVentas);
            this.MrcVentasRegistradas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MrcVentasRegistradas.Location = new System.Drawing.Point(20, 18);
            this.MrcVentasRegistradas.Name = "MrcVentasRegistradas";
            this.MrcVentasRegistradas.Size = new System.Drawing.Size(587, 271);
            this.MrcVentasRegistradas.TabIndex = 15;
            this.MrcVentasRegistradas.TabStop = false;
            this.MrcVentasRegistradas.Text = "VENTAS";
            // 
            // DtvMostrarVentas
            // 
            this.DtvMostrarVentas.AllowUserToAddRows = false;
            this.DtvMostrarVentas.AllowUserToDeleteRows = false;
            this.DtvMostrarVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtvMostrarVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaClienteVentas,
            this.ColumnaEmpleadoVentas,
            this.ColumnaProductoVentas,
            this.ColumnaCantidadVentas,
            this.ColumnaMontoVentas});
            this.DtvMostrarVentas.Location = new System.Drawing.Point(19, 37);
            this.DtvMostrarVentas.Name = "DtvMostrarVentas";
            this.DtvMostrarVentas.ReadOnly = true;
            this.DtvMostrarVentas.Size = new System.Drawing.Size(543, 212);
            this.DtvMostrarVentas.TabIndex = 0;
            // 
            // ColumnaClienteVentas
            // 
            this.ColumnaClienteVentas.HeaderText = "Cliente";
            this.ColumnaClienteVentas.Name = "ColumnaClienteVentas";
            this.ColumnaClienteVentas.ReadOnly = true;
            // 
            // ColumnaEmpleadoVentas
            // 
            this.ColumnaEmpleadoVentas.HeaderText = "Empleado";
            this.ColumnaEmpleadoVentas.Name = "ColumnaEmpleadoVentas";
            this.ColumnaEmpleadoVentas.ReadOnly = true;
            // 
            // ColumnaProductoVentas
            // 
            this.ColumnaProductoVentas.HeaderText = "Producto";
            this.ColumnaProductoVentas.Name = "ColumnaProductoVentas";
            this.ColumnaProductoVentas.ReadOnly = true;
            // 
            // ColumnaCantidadVentas
            // 
            this.ColumnaCantidadVentas.HeaderText = "Cantidad";
            this.ColumnaCantidadVentas.Name = "ColumnaCantidadVentas";
            this.ColumnaCantidadVentas.ReadOnly = true;
            // 
            // ColumnaMontoVentas
            // 
            this.ColumnaMontoVentas.HeaderText = "Monto";
            this.ColumnaMontoVentas.Name = "ColumnaMontoVentas";
            this.ColumnaMontoVentas.ReadOnly = true;
            // 
            // frmMostrarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(773, 313);
            this.Controls.Add(this.BtnVolverVentasRegistradas);
            this.Controls.Add(this.BtnLimpiarVentasRegistradas);
            this.Controls.Add(this.BtnMostrarVentasRegistradas);
            this.Controls.Add(this.MrcVentasRegistradas);
            this.Name = "frmMostrarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOSTRAR VENTAS";
            this.MrcVentasRegistradas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtvMostrarVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVolverVentasRegistradas;
        private System.Windows.Forms.Button BtnLimpiarVentasRegistradas;
        private System.Windows.Forms.Button BtnMostrarVentasRegistradas;
        private System.Windows.Forms.GroupBox MrcVentasRegistradas;
        private System.Windows.Forms.DataGridView DtvMostrarVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaClienteVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaEmpleadoVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaProductoVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantidadVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaMontoVentas;
    }
}