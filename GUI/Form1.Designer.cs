namespace WindowsFormsApp1
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
            this.comboNombre = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DtpFechaFiltro = new System.Windows.Forms.DateTimePicker();
            this.comboServicioFiltro = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnReportar = new System.Windows.Forms.Button();
            this.LabelServicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labeltot = new System.Windows.Forms.Label();
            this.lblTotalizar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboNombre
            // 
            this.comboNombre.FormattingEnabled = true;
            this.comboNombre.Items.AddRange(new object[] {
            "ELECTRICARIBE",
            "GASCARIBE",
            "EMDUPAR"});
            this.comboNombre.Location = new System.Drawing.Point(103, 69);
            this.comboNombre.Name = "comboNombre";
            this.comboNombre.Size = new System.Drawing.Size(121, 21);
            this.comboNombre.TabIndex = 0;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(103, 97);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(103, 124);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(121, 20);
            this.DtpFecha.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(103, 151);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 20);
            this.txtValor.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(103, 192);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(498, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // DtpFechaFiltro
            // 
            this.DtpFechaFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFiltro.Location = new System.Drawing.Point(653, 24);
            this.DtpFechaFiltro.Name = "DtpFechaFiltro";
            this.DtpFechaFiltro.Size = new System.Drawing.Size(121, 20);
            this.DtpFechaFiltro.TabIndex = 7;
            // 
            // comboServicioFiltro
            // 
            this.comboServicioFiltro.FormattingEnabled = true;
            this.comboServicioFiltro.Items.AddRange(new object[] {
            "ELECTRICARIBE",
            "GASCARIBE",
            "EMDUPAR"});
            this.comboServicioFiltro.Location = new System.Drawing.Point(454, 24);
            this.comboServicioFiltro.Name = "comboServicioFiltro";
            this.comboServicioFiltro.Size = new System.Drawing.Size(121, 21);
            this.comboServicioFiltro.TabIndex = 6;
            this.comboServicioFiltro.SelectedIndexChanged += new System.EventHandler(this.comboServicioFiltro_SelectedIndexChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(794, 23);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnReportar
            // 
            this.btnReportar.Location = new System.Drawing.Point(696, 227);
            this.btnReportar.Name = "btnReportar";
            this.btnReportar.Size = new System.Drawing.Size(75, 23);
            this.btnReportar.TabIndex = 9;
            this.btnReportar.Text = "Reportar";
            this.btnReportar.UseVisualStyleBackColor = true;
            this.btnReportar.Click += new System.EventHandler(this.btnReportar_Click);
            // 
            // LabelServicio
            // 
            this.LabelServicio.AutoSize = true;
            this.LabelServicio.Location = new System.Drawing.Point(13, 76);
            this.LabelServicio.Name = "LabelServicio";
            this.LabelServicio.Size = new System.Drawing.Size(45, 13);
            this.LabelServicio.TabIndex = 10;
            this.LabelServicio.Text = "Servicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Numero recibo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor";
            // 
            // labeltot
            // 
            this.labeltot.AutoSize = true;
            this.labeltot.Location = new System.Drawing.Point(418, 232);
            this.labeltot.Name = "labeltot";
            this.labeltot.Size = new System.Drawing.Size(42, 13);
            this.labeltot.TabIndex = 14;
            this.labeltot.Text = "total:    ";
            // 
            // lblTotalizar
            // 
            this.lblTotalizar.AutoSize = true;
            this.lblTotalizar.Location = new System.Drawing.Point(489, 232);
            this.lblTotalizar.Name = "lblTotalizar";
            this.lblTotalizar.Size = new System.Drawing.Size(37, 13);
            this.lblTotalizar.TabIndex = 15;
            this.lblTotalizar.Text = "$$$$$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fecha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalizar);
            this.Controls.Add(this.labeltot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelServicio);
            this.Controls.Add(this.btnReportar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.DtpFechaFiltro);
            this.Controls.Add(this.comboServicioFiltro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.comboNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboNombre;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker DtpFechaFiltro;
        private System.Windows.Forms.ComboBox comboServicioFiltro;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnReportar;
        private System.Windows.Forms.Label LabelServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labeltot;
        private System.Windows.Forms.Label lblTotalizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

