namespace SisMat_GUI
{
    partial class AgregarCuota
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
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.mskFechaPago = new System.Windows.Forms.MaskedTextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAlumnos = new System.Windows.Forms.ComboBox();
            this.mskPrecio = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregarCuota = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(126, 96);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(145, 23);
            this.txtCuota.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Agregar Cuota\r\n";
            // 
            // mskVencimiento
            // 
            this.mskVencimiento.Location = new System.Drawing.Point(126, 339);
            this.mskVencimiento.Mask = "0000/00/000 00:00";
            this.mskVencimiento.Name = "mskVencimiento";
            this.mskVencimiento.Size = new System.Drawing.Size(100, 23);
            this.mskVencimiento.TabIndex = 19;
            this.mskVencimiento.ValidatingType = typeof(System.DateTime);
            // 
            // mskFechaPago
            // 
            this.mskFechaPago.Location = new System.Drawing.Point(126, 385);
            this.mskFechaPago.Mask = "0000/00/000 00:00";
            this.mskFechaPago.Name = "mskFechaPago";
            this.mskFechaPago.Size = new System.Drawing.Size(100, 23);
            this.mskFechaPago.TabIndex = 20;
            this.mskFechaPago.ValidatingType = typeof(System.DateTime);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(126, 241);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(113, 23);
            this.cmbEstado.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Numero Cuota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Alumno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Fecha Pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Vencimiento";
            // 
            // cmbAlumnos
            // 
            this.cmbAlumnos.FormattingEnabled = true;
            this.cmbAlumnos.Location = new System.Drawing.Point(126, 190);
            this.cmbAlumnos.Name = "cmbAlumnos";
            this.cmbAlumnos.Size = new System.Drawing.Size(191, 23);
            this.cmbAlumnos.TabIndex = 28;
            // 
            // mskPrecio
            // 
            this.mskPrecio.Location = new System.Drawing.Point(126, 143);
            this.mskPrecio.Mask = "000.00";
            this.mskPrecio.Name = "mskPrecio";
            this.mskPrecio.Size = new System.Drawing.Size(100, 23);
            this.mskPrecio.TabIndex = 31;
            // 
            // btnAgregarCuota
            // 
            this.btnAgregarCuota.BackColor = System.Drawing.Color.IndianRed;
            this.btnAgregarCuota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarCuota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarCuota.Location = new System.Drawing.Point(192, 443);
            this.btnAgregarCuota.Name = "btnAgregarCuota";
            this.btnAgregarCuota.Size = new System.Drawing.Size(131, 34);
            this.btnAgregarCuota.TabIndex = 33;
            this.btnAgregarCuota.Text = "Confirmar";
            this.btnAgregarCuota.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(26, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 34);
            this.button2.TabIndex = 34;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(126, 288);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(113, 23);
            this.cmbTipo.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tipo";
            // 
            // AgregarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 510);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregarCuota);
            this.Controls.Add(this.mskPrecio);
            this.Controls.Add(this.cmbAlumnos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.mskFechaPago);
            this.Controls.Add(this.mskVencimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCuota);
            this.Name = "AgregarCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCuota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCuota;
        private Label label1;
        private MaskedTextBox mskVencimiento;
        private MaskedTextBox mskFechaPago;
        private ComboBox cmbEstado;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbAlumnos;
        private MaskedTextBox mskPrecio;
        private Button btnAgregarCuota;
        private Button button2;
        private ComboBox cmbTipo;
        private Label label8;
    }
}