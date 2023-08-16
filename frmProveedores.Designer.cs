namespace MENU2
{
    partial class frmProveedores
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminarDatos = new System.Windows.Forms.Button();
            this.lblTelefonoProveedor = new System.Windows.Forms.Label();
            this.lblApellidoProveedor = new System.Windows.Forms.Label();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblProveedores2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.mtbTelefonoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtApellidoProveedor = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rtbDireccionProveedor = new System.Windows.Forms.RichTextBox();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumPagina = new System.Windows.Forms.TextBox();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.lblNumPagina = new System.Windows.Forms.Label();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.lblPagina = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbNumeroPagina = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnEliminarDatos);
            this.panel2.Controls.Add(this.lblTelefonoProveedor);
            this.panel2.Controls.Add(this.lblApellidoProveedor);
            this.panel2.Controls.Add(this.lblNombreProveedor);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.lblProveedores2);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblDireccion);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.lblNombreEmpresa);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(313, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 646);
            this.panel2.TabIndex = 49;
            // 
            // btnEliminarDatos
            // 
            this.btnEliminarDatos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(62)))), ((int)(((byte)(120)))));
            this.btnEliminarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDatos.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDatos.Location = new System.Drawing.Point(220, 537);
            this.btnEliminarDatos.Name = "btnEliminarDatos";
            this.btnEliminarDatos.Size = new System.Drawing.Size(183, 30);
            this.btnEliminarDatos.TabIndex = 73;
            this.btnEliminarDatos.Text = "Eliminar Datos";
            this.btnEliminarDatos.UseVisualStyleBackColor = false;
            // 
            // lblTelefonoProveedor
            // 
            this.lblTelefonoProveedor.AutoSize = true;
            this.lblTelefonoProveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoProveedor.ForeColor = System.Drawing.Color.White;
            this.lblTelefonoProveedor.Location = new System.Drawing.Point(39, 391);
            this.lblTelefonoProveedor.Name = "lblTelefonoProveedor";
            this.lblTelefonoProveedor.Size = new System.Drawing.Size(71, 20);
            this.lblTelefonoProveedor.TabIndex = 76;
            this.lblTelefonoProveedor.Text = "Teléfono";
            // 
            // lblApellidoProveedor
            // 
            this.lblApellidoProveedor.AutoSize = true;
            this.lblApellidoProveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoProveedor.ForeColor = System.Drawing.Color.White;
            this.lblApellidoProveedor.Location = new System.Drawing.Point(41, 300);
            this.lblApellidoProveedor.Name = "lblApellidoProveedor";
            this.lblApellidoProveedor.Size = new System.Drawing.Size(75, 20);
            this.lblApellidoProveedor.TabIndex = 80;
            this.lblApellidoProveedor.Text = "Apellidos";
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProveedor.ForeColor = System.Drawing.Color.White;
            this.lblNombreProveedor.Location = new System.Drawing.Point(38, 199);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(68, 20);
            this.lblNombreProveedor.TabIndex = 78;
            this.lblNombreProveedor.Text = "Nombre";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtNombreProveedor);
            this.panel5.Location = new System.Drawing.Point(23, 214);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(192, 57);
            this.panel5.TabIndex = 77;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreProveedor.Location = new System.Drawing.Point(3, 14);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(184, 20);
            this.txtNombreProveedor.TabIndex = 5;
            // 
            // lblProveedores2
            // 
            this.lblProveedores2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProveedores2.AutoSize = true;
            this.lblProveedores2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores2.ForeColor = System.Drawing.Color.White;
            this.lblProveedores2.Location = new System.Drawing.Point(19, 135);
            this.lblProveedores2.Name = "lblProveedores2";
            this.lblProveedores2.Size = new System.Drawing.Size(259, 22);
            this.lblProveedores2.TabIndex = 74;
            this.lblProveedores2.Text = "Registrar nuevo proveedor";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.mtbTelefonoEmpleado);
            this.panel7.Location = new System.Drawing.Point(25, 403);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(190, 42);
            this.panel7.TabIndex = 75;
            // 
            // mtbTelefonoEmpleado
            // 
            this.mtbTelefonoEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbTelefonoEmpleado.Location = new System.Drawing.Point(3, 13);
            this.mtbTelefonoEmpleado.Mask = "9999-9999";
            this.mtbTelefonoEmpleado.Name = "mtbTelefonoEmpleado";
            this.mtbTelefonoEmpleado.Size = new System.Drawing.Size(182, 20);
            this.mtbTelefonoEmpleado.TabIndex = 53;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtApellidoProveedor);
            this.panel3.Location = new System.Drawing.Point(25, 312);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 53);
            this.panel3.TabIndex = 79;
            // 
            // txtApellidoProveedor
            // 
            this.txtApellidoProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellidoProveedor.Location = new System.Drawing.Point(3, 15);
            this.txtApellidoProveedor.Name = "txtApellidoProveedor";
            this.txtApellidoProveedor.Size = new System.Drawing.Size(182, 20);
            this.txtApellidoProveedor.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(392, 300);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(80, 20);
            this.lblDireccion.TabIndex = 72;
            this.lblDireccion.Text = "Dirección";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.rtbDireccionProveedor);
            this.panel6.Location = new System.Drawing.Point(373, 311);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(265, 149);
            this.panel6.TabIndex = 71;
            // 
            // rtbDireccionProveedor
            // 
            this.rtbDireccionProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbDireccionProveedor.Location = new System.Drawing.Point(11, 15);
            this.rtbDireccionProveedor.Name = "rtbDireccionProveedor";
            this.rtbDireccionProveedor.Size = new System.Drawing.Size(243, 118);
            this.rtbDireccionProveedor.TabIndex = 0;
            this.rtbDireccionProveedor.Text = "";
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(389, 203);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(177, 20);
            this.lblNombreEmpresa.TabIndex = 70;
            this.lblNombreEmpresa.Text = "Nombre de la empresa";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Location = new System.Drawing.Point(373, 214);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 57);
            this.panel4.TabIndex = 69;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(13, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 20);
            this.textBox2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Controls.Add(this.txtNumPagina);
            this.panel1.Controls.Add(this.dgvProveedores);
            this.panel1.Controls.Add(this.lblNumPagina);
            this.panel1.Controls.Add(this.lblProveedores);
            this.panel1.Controls.Add(this.lblPagina);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.cbNumeroPagina);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 646);
            this.panel1.TabIndex = 50;
            // 
            // txtNumPagina
            // 
            this.txtNumPagina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumPagina.Location = new System.Drawing.Point(156, 511);
            this.txtNumPagina.Name = "txtNumPagina";
            this.txtNumPagina.Size = new System.Drawing.Size(25, 20);
            this.txtNumPagina.TabIndex = 55;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(4)))), ((int)(((byte)(61)))));
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(12, 170);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(293, 285);
            this.dgvProveedores.TabIndex = 57;
            // 
            // lblNumPagina
            // 
            this.lblNumPagina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumPagina.AutoSize = true;
            this.lblNumPagina.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPagina.ForeColor = System.Drawing.Color.White;
            this.lblNumPagina.Location = new System.Drawing.Point(101, 510);
            this.lblNumPagina.Name = "lblNumPagina";
            this.lblNumPagina.Size = new System.Drawing.Size(25, 17);
            this.lblNumPagina.TabIndex = 54;
            this.lblNumPagina.Text = "De";
            // 
            // lblProveedores
            // 
            this.lblProveedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.ForeColor = System.Drawing.Color.White;
            this.lblProveedores.Location = new System.Drawing.Point(16, 140);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(230, 22);
            this.lblProveedores.TabIndex = 56;
            this.lblProveedores.Text = "Proveedores registrados";
            // 
            // lblPagina
            // 
            this.lblPagina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.ForeColor = System.Drawing.Color.White;
            this.lblPagina.Location = new System.Drawing.Point(16, 511);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(49, 17);
            this.lblPagina.TabIndex = 49;
            this.lblPagina.Text = "Pagina";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(62)))), ((int)(((byte)(120)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(14, 459);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 34);
            this.btnAgregar.TabIndex = 50;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(62)))), ((int)(((byte)(120)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(102, 459);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(79, 34);
            this.btnActualizar.TabIndex = 51;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(62)))), ((int)(((byte)(120)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(187, 459);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 34);
            this.btnEliminar.TabIndex = 52;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // cbNumeroPagina
            // 
            this.cbNumeroPagina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNumeroPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumeroPagina.FormattingEnabled = true;
            this.cbNumeroPagina.Location = new System.Drawing.Point(71, 507);
            this.cbNumeroPagina.Name = "cbNumeroPagina";
            this.cbNumeroPagina.Size = new System.Drawing.Size(25, 23);
            this.cbNumeroPagina.TabIndex = 53;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(985, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEliminarDatos;
        private System.Windows.Forms.Label lblTelefonoProveedor;
        private System.Windows.Forms.Label lblApellidoProveedor;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label lblProveedores2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.MaskedTextBox mtbTelefonoEmpleado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtApellidoProveedor;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox rtbDireccionProveedor;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumPagina;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Label lblNumPagina;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbNumeroPagina;
    }
}