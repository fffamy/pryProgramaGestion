
namespace pryProgramaGestion
{
    partial class frmBuscarCliente
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
            this.LblBuscarDNICliente = new System.Windows.Forms.Label();
            this.TxtBuscarDNICliente = new System.Windows.Forms.TextBox();
            this.BtnBuscarBuscarCliente = new System.Windows.Forms.Button();
            this.BtnLimpiarBuscarCliente = new System.Windows.Forms.Button();
            this.MrcDatosCliente = new System.Windows.Forms.GroupBox();
            this.LblBuscarMailMostrarCliente = new System.Windows.Forms.Label();
            this.LblBuscarTelefonoMostrarCliente = new System.Windows.Forms.Label();
            this.LblBuscarDomicilioMostrarCliente = new System.Windows.Forms.Label();
            this.LblBuscarEdadMostrarCliente = new System.Windows.Forms.Label();
            this.LblBuscarApellidoMostrarCliente = new System.Windows.Forms.Label();
            this.LblBuscarNombreMostrarCliente = new System.Windows.Forms.Label();
            this.LblBuscarMailCliente = new System.Windows.Forms.Label();
            this.LblBuscarTelefonoCliente = new System.Windows.Forms.Label();
            this.LblBuscarDomicilioCliente = new System.Windows.Forms.Label();
            this.LblBuscarEdadCliente = new System.Windows.Forms.Label();
            this.LblBuscarApellidoCliente = new System.Windows.Forms.Label();
            this.LblBuscarNombreCliente = new System.Windows.Forms.Label();
            this.BtnVolverBuscarCliente = new System.Windows.Forms.Button();
            this.MrcDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblBuscarDNICliente
            // 
            this.LblBuscarDNICliente.AutoSize = true;
            this.LblBuscarDNICliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarDNICliente.Location = new System.Drawing.Point(12, 23);
            this.LblBuscarDNICliente.Name = "LblBuscarDNICliente";
            this.LblBuscarDNICliente.Size = new System.Drawing.Size(54, 22);
            this.LblBuscarDNICliente.TabIndex = 1;
            this.LblBuscarDNICliente.Text = "DNI: ";
            // 
            // TxtBuscarDNICliente
            // 
            this.TxtBuscarDNICliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarDNICliente.Location = new System.Drawing.Point(116, 20);
            this.TxtBuscarDNICliente.Name = "TxtBuscarDNICliente";
            this.TxtBuscarDNICliente.Size = new System.Drawing.Size(244, 29);
            this.TxtBuscarDNICliente.TabIndex = 4;
            this.TxtBuscarDNICliente.TextChanged += new System.EventHandler(this.TxtBuscarDNICliente_TextChanged);
            // 
            // BtnBuscarBuscarCliente
            // 
            this.BtnBuscarBuscarCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarBuscarCliente.Location = new System.Drawing.Point(16, 78);
            this.BtnBuscarBuscarCliente.Name = "BtnBuscarBuscarCliente";
            this.BtnBuscarBuscarCliente.Size = new System.Drawing.Size(125, 31);
            this.BtnBuscarBuscarCliente.TabIndex = 7;
            this.BtnBuscarBuscarCliente.Text = "Buscar";
            this.BtnBuscarBuscarCliente.UseVisualStyleBackColor = true;
            this.BtnBuscarBuscarCliente.Click += new System.EventHandler(this.BtnBuscarBuscarCliente_Click);
            // 
            // BtnLimpiarBuscarCliente
            // 
            this.BtnLimpiarBuscarCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarBuscarCliente.Location = new System.Drawing.Point(235, 78);
            this.BtnLimpiarBuscarCliente.Name = "BtnLimpiarBuscarCliente";
            this.BtnLimpiarBuscarCliente.Size = new System.Drawing.Size(125, 31);
            this.BtnLimpiarBuscarCliente.TabIndex = 8;
            this.BtnLimpiarBuscarCliente.Text = "Limpiar";
            this.BtnLimpiarBuscarCliente.UseVisualStyleBackColor = true;
            this.BtnLimpiarBuscarCliente.Click += new System.EventHandler(this.BtnLimpiarBuscarCliente_Click);
            // 
            // MrcDatosCliente
            // 
            this.MrcDatosCliente.Controls.Add(this.LblBuscarMailMostrarCliente);
            this.MrcDatosCliente.Controls.Add(this.LblBuscarTelefonoMostrarCliente);
            this.MrcDatosCliente.Controls.Add(this.LblBuscarDomicilioMostrarCliente);
            this.MrcDatosCliente.Controls.Add(this.LblBuscarEdadMostrarCliente);
            this.MrcDatosCliente.Controls.Add(this.LblBuscarApellidoMostrarCliente);
            this.MrcDatosCliente.Controls.Add(this.LblBuscarNombreMostrarCliente);
            this.MrcDatosCliente.Controls.Add(this.LblBuscarMailCliente);
            this.MrcDatosCliente.Controls.Add(this.LblBuscarTelefonoCliente);
            this.MrcDatosCliente.Controls.Add(this.LblBuscarDomicilioCliente);
            this.MrcDatosCliente.Controls.Add(this.LblBuscarEdadCliente);
            this.MrcDatosCliente.Controls.Add(this.LblBuscarApellidoCliente);
            this.MrcDatosCliente.Controls.Add(this.LblBuscarNombreCliente);
            this.MrcDatosCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MrcDatosCliente.Location = new System.Drawing.Point(12, 133);
            this.MrcDatosCliente.Name = "MrcDatosCliente";
            this.MrcDatosCliente.Size = new System.Drawing.Size(348, 275);
            this.MrcDatosCliente.TabIndex = 9;
            this.MrcDatosCliente.TabStop = false;
            this.MrcDatosCliente.Text = "Datos Cliente";
            // 
            // LblBuscarMailMostrarCliente
            // 
            this.LblBuscarMailMostrarCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblBuscarMailMostrarCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarMailMostrarCliente.Location = new System.Drawing.Point(111, 224);
            this.LblBuscarMailMostrarCliente.Name = "LblBuscarMailMostrarCliente";
            this.LblBuscarMailMostrarCliente.Size = new System.Drawing.Size(214, 22);
            this.LblBuscarMailMostrarCliente.TabIndex = 12;
            // 
            // LblBuscarTelefonoMostrarCliente
            // 
            this.LblBuscarTelefonoMostrarCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblBuscarTelefonoMostrarCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarTelefonoMostrarCliente.Location = new System.Drawing.Point(111, 189);
            this.LblBuscarTelefonoMostrarCliente.Name = "LblBuscarTelefonoMostrarCliente";
            this.LblBuscarTelefonoMostrarCliente.Size = new System.Drawing.Size(214, 22);
            this.LblBuscarTelefonoMostrarCliente.TabIndex = 11;
            // 
            // LblBuscarDomicilioMostrarCliente
            // 
            this.LblBuscarDomicilioMostrarCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblBuscarDomicilioMostrarCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarDomicilioMostrarCliente.Location = new System.Drawing.Point(111, 154);
            this.LblBuscarDomicilioMostrarCliente.Name = "LblBuscarDomicilioMostrarCliente";
            this.LblBuscarDomicilioMostrarCliente.Size = new System.Drawing.Size(214, 22);
            this.LblBuscarDomicilioMostrarCliente.TabIndex = 10;
            // 
            // LblBuscarEdadMostrarCliente
            // 
            this.LblBuscarEdadMostrarCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblBuscarEdadMostrarCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarEdadMostrarCliente.Location = new System.Drawing.Point(111, 116);
            this.LblBuscarEdadMostrarCliente.Name = "LblBuscarEdadMostrarCliente";
            this.LblBuscarEdadMostrarCliente.Size = new System.Drawing.Size(85, 22);
            this.LblBuscarEdadMostrarCliente.TabIndex = 9;
            // 
            // LblBuscarApellidoMostrarCliente
            // 
            this.LblBuscarApellidoMostrarCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblBuscarApellidoMostrarCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarApellidoMostrarCliente.Location = new System.Drawing.Point(111, 77);
            this.LblBuscarApellidoMostrarCliente.Name = "LblBuscarApellidoMostrarCliente";
            this.LblBuscarApellidoMostrarCliente.Size = new System.Drawing.Size(214, 22);
            this.LblBuscarApellidoMostrarCliente.TabIndex = 8;
            // 
            // LblBuscarNombreMostrarCliente
            // 
            this.LblBuscarNombreMostrarCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblBuscarNombreMostrarCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarNombreMostrarCliente.Location = new System.Drawing.Point(111, 38);
            this.LblBuscarNombreMostrarCliente.Name = "LblBuscarNombreMostrarCliente";
            this.LblBuscarNombreMostrarCliente.Size = new System.Drawing.Size(214, 22);
            this.LblBuscarNombreMostrarCliente.TabIndex = 7;
            // 
            // LblBuscarMailCliente
            // 
            this.LblBuscarMailCliente.AutoSize = true;
            this.LblBuscarMailCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarMailCliente.Location = new System.Drawing.Point(6, 225);
            this.LblBuscarMailCliente.Name = "LblBuscarMailCliente";
            this.LblBuscarMailCliente.Size = new System.Drawing.Size(53, 22);
            this.LblBuscarMailCliente.TabIndex = 6;
            this.LblBuscarMailCliente.Text = "Mail: ";
            // 
            // LblBuscarTelefonoCliente
            // 
            this.LblBuscarTelefonoCliente.AutoSize = true;
            this.LblBuscarTelefonoCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarTelefonoCliente.Location = new System.Drawing.Point(6, 190);
            this.LblBuscarTelefonoCliente.Name = "LblBuscarTelefonoCliente";
            this.LblBuscarTelefonoCliente.Size = new System.Drawing.Size(94, 22);
            this.LblBuscarTelefonoCliente.TabIndex = 5;
            this.LblBuscarTelefonoCliente.Text = "Telefono: ";
            // 
            // LblBuscarDomicilioCliente
            // 
            this.LblBuscarDomicilioCliente.AutoSize = true;
            this.LblBuscarDomicilioCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarDomicilioCliente.Location = new System.Drawing.Point(6, 154);
            this.LblBuscarDomicilioCliente.Name = "LblBuscarDomicilioCliente";
            this.LblBuscarDomicilioCliente.Size = new System.Drawing.Size(98, 22);
            this.LblBuscarDomicilioCliente.TabIndex = 4;
            this.LblBuscarDomicilioCliente.Text = "Domicilio: ";
            // 
            // LblBuscarEdadCliente
            // 
            this.LblBuscarEdadCliente.AutoSize = true;
            this.LblBuscarEdadCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarEdadCliente.Location = new System.Drawing.Point(6, 117);
            this.LblBuscarEdadCliente.Name = "LblBuscarEdadCliente";
            this.LblBuscarEdadCliente.Size = new System.Drawing.Size(65, 22);
            this.LblBuscarEdadCliente.TabIndex = 3;
            this.LblBuscarEdadCliente.Text = "Edad: ";
            // 
            // LblBuscarApellidoCliente
            // 
            this.LblBuscarApellidoCliente.AutoSize = true;
            this.LblBuscarApellidoCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarApellidoCliente.Location = new System.Drawing.Point(6, 77);
            this.LblBuscarApellidoCliente.Name = "LblBuscarApellidoCliente";
            this.LblBuscarApellidoCliente.Size = new System.Drawing.Size(89, 22);
            this.LblBuscarApellidoCliente.TabIndex = 2;
            this.LblBuscarApellidoCliente.Text = "Apellido: ";
            // 
            // LblBuscarNombreCliente
            // 
            this.LblBuscarNombreCliente.AutoSize = true;
            this.LblBuscarNombreCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarNombreCliente.Location = new System.Drawing.Point(6, 38);
            this.LblBuscarNombreCliente.Name = "LblBuscarNombreCliente";
            this.LblBuscarNombreCliente.Size = new System.Drawing.Size(88, 22);
            this.LblBuscarNombreCliente.TabIndex = 1;
            this.LblBuscarNombreCliente.Text = "Nombre: ";
            // 
            // BtnVolverBuscarCliente
            // 
            this.BtnVolverBuscarCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolverBuscarCliente.Location = new System.Drawing.Point(235, 433);
            this.BtnVolverBuscarCliente.Name = "BtnVolverBuscarCliente";
            this.BtnVolverBuscarCliente.Size = new System.Drawing.Size(125, 31);
            this.BtnVolverBuscarCliente.TabIndex = 10;
            this.BtnVolverBuscarCliente.Text = "Volver";
            this.BtnVolverBuscarCliente.UseVisualStyleBackColor = true;
            this.BtnVolverBuscarCliente.Click += new System.EventHandler(this.BtnVolverBuscarCliente_Click);
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 476);
            this.Controls.Add(this.BtnVolverBuscarCliente);
            this.Controls.Add(this.MrcDatosCliente);
            this.Controls.Add(this.BtnLimpiarBuscarCliente);
            this.Controls.Add(this.BtnBuscarBuscarCliente);
            this.Controls.Add(this.TxtBuscarDNICliente);
            this.Controls.Add(this.LblBuscarDNICliente);
            this.Name = "frmBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR CLIENTE";
            this.Load += new System.EventHandler(this.frmBuscarCliente_Load);
            this.MrcDatosCliente.ResumeLayout(false);
            this.MrcDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBuscarDNICliente;
        private System.Windows.Forms.TextBox TxtBuscarDNICliente;
        private System.Windows.Forms.Button BtnBuscarBuscarCliente;
        private System.Windows.Forms.Button BtnLimpiarBuscarCliente;
        private System.Windows.Forms.GroupBox MrcDatosCliente;
        private System.Windows.Forms.Label LblBuscarMailCliente;
        private System.Windows.Forms.Label LblBuscarTelefonoCliente;
        private System.Windows.Forms.Label LblBuscarDomicilioCliente;
        private System.Windows.Forms.Label LblBuscarEdadCliente;
        private System.Windows.Forms.Label LblBuscarApellidoCliente;
        private System.Windows.Forms.Label LblBuscarNombreCliente;
        private System.Windows.Forms.Label LblBuscarMailMostrarCliente;
        private System.Windows.Forms.Label LblBuscarTelefonoMostrarCliente;
        private System.Windows.Forms.Label LblBuscarDomicilioMostrarCliente;
        private System.Windows.Forms.Label LblBuscarEdadMostrarCliente;
        private System.Windows.Forms.Label LblBuscarApellidoMostrarCliente;
        private System.Windows.Forms.Label LblBuscarNombreMostrarCliente;
        private System.Windows.Forms.Button BtnVolverBuscarCliente;
    }
}