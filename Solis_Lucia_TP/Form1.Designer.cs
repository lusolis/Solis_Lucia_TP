
using System;

namespace Solis_Lucia_TP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDominio_Ingreso = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lstCochera = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDominio_Egreso = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEgresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDateEgreso = new System.Windows.Forms.TextBox();
            this.txtDateIngreso = new System.Windows.Forms.TextBox();
            this.txtTipoVehiculo = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDominio_Ingreso
            // 
            this.txtDominio_Ingreso.Location = new System.Drawing.Point(142, 40);
            this.txtDominio_Ingreso.MaxLength = 7;
            this.txtDominio_Ingreso.Name = "txtDominio_Ingreso";
            this.txtDominio_Ingreso.Size = new System.Drawing.Size(100, 20);
            this.txtDominio_Ingreso.TabIndex = 0;
            this.txtDominio_Ingreso.TextChanged += new System.EventHandler(this.txtDominio_Ingreso_TextChanged);
            this.txtDominio_Ingreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDominio_Ingreso_KeyPress);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(142, 111);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 7;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(264, 38);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(80, 33);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "&Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lstCochera
            // 
            this.lstCochera.FormattingEnabled = true;
            this.lstCochera.Location = new System.Drawing.Point(142, 184);
            this.lstCochera.Name = "lstCochera";
            this.lstCochera.Size = new System.Drawing.Size(121, 147);
            this.lstCochera.TabIndex = 12;
            this.lstCochera.Click += new System.EventHandler(this.lstCochera_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDominio_Ingreso);
            this.groupBox1.Controls.Add(this.lstCochera);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Location = new System.Drawing.Point(30, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 360);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cochera";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tipo Vehículo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Dominio";
            // 
            // txtDominio_Egreso
            // 
            this.txtDominio_Egreso.Location = new System.Drawing.Point(129, 40);
            this.txtDominio_Egreso.MaxLength = 7;
            this.txtDominio_Egreso.Name = "txtDominio_Egreso";
            this.txtDominio_Egreso.Size = new System.Drawing.Size(100, 20);
            this.txtDominio_Egreso.TabIndex = 5;
            this.txtDominio_Egreso.TextChanged += new System.EventHandler(this.txtDominio_Egreso_TextChanged);
            this.txtDominio_Egreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDominio_Egreso_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(293, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 33);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEgresar
            // 
            this.btnEgresar.Location = new System.Drawing.Point(293, 287);
            this.btnEgresar.Name = "btnEgresar";
            this.btnEgresar.Size = new System.Drawing.Size(91, 32);
            this.btnEgresar.TabIndex = 10;
            this.btnEgresar.Text = "&Egresar";
            this.btnEgresar.UseVisualStyleBackColor = true;
            this.btnEgresar.Click += new System.EventHandler(this.btnEgresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dominio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tipo vehículo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ubicación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Egreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Importe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDateEgreso);
            this.groupBox2.Controls.Add(this.txtDateIngreso);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnEgresar);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.txtTipoVehiculo);
            this.groupBox2.Controls.Add(this.txtImporte);
            this.groupBox2.Controls.Add(this.txtUbicacion);
            this.groupBox2.Controls.Add(this.txtDominio_Egreso);
            this.groupBox2.Location = new System.Drawing.Point(408, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 360);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Egreso";
            // 
            // txtDateEgreso
            // 
            this.txtDateEgreso.Location = new System.Drawing.Point(129, 230);
            this.txtDateEgreso.Name = "txtDateEgreso";
            this.txtDateEgreso.Size = new System.Drawing.Size(209, 20);
            this.txtDateEgreso.TabIndex = 18;
            // 
            // txtDateIngreso
            // 
            this.txtDateIngreso.Location = new System.Drawing.Point(129, 189);
            this.txtDateIngreso.Name = "txtDateIngreso";
            this.txtDateIngreso.Size = new System.Drawing.Size(209, 20);
            this.txtDateIngreso.TabIndex = 17;
            // 
            // txtTipoVehiculo
            // 
            this.txtTipoVehiculo.Location = new System.Drawing.Point(129, 87);
            this.txtTipoVehiculo.Name = "txtTipoVehiculo";
            this.txtTipoVehiculo.Size = new System.Drawing.Size(100, 20);
            this.txtTipoVehiculo.TabIndex = 6;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(129, 275);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 1;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(129, 140);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(100, 20);
            this.txtUbicacion.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(701, 428);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(91, 33);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 485);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = " Estacionamiento Central";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        
        #endregion

        private System.Windows.Forms.TextBox txtDominio_Ingreso;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ListBox lstCochera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDominio_Egreso;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEgresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDateEgreso;
        private System.Windows.Forms.TextBox txtDateIngreso;
        private System.Windows.Forms.TextBox txtTipoVehiculo;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Button btnCerrar;
    }
}

