namespace SisMat_GUI
{
    partial class CuotaMan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ndoc_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_cuota,
            this.NombreCompleto,
            this.Ndoc_cuota,
            this.Fecha_pago,
            this.EstadoCuota,
            this.TipoCuota,
            this.Vencimiento,
            this.Precio_cuota});
            this.dataGridView1.Location = new System.Drawing.Point(35, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(844, 366);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id_cuota
            // 
            this.Id_cuota.DataPropertyName = "Id_cuota";
            this.Id_cuota.HeaderText = "ID";
            this.Id_cuota.Name = "Id_cuota";
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "Alumno";
            this.NombreCompleto.Name = "NombreCompleto";
            // 
            // Ndoc_cuota
            // 
            this.Ndoc_cuota.DataPropertyName = "Ndoc_cuota";
            this.Ndoc_cuota.HeaderText = "N. Cuota";
            this.Ndoc_cuota.Name = "Ndoc_cuota";
            // 
            // Fecha_pago
            // 
            this.Fecha_pago.DataPropertyName = "Fecha_pago";
            this.Fecha_pago.HeaderText = "Fecha Pago";
            this.Fecha_pago.Name = "Fecha_pago";
            // 
            // EstadoCuota
            // 
            this.EstadoCuota.DataPropertyName = "EstadoCuota";
            this.EstadoCuota.HeaderText = "Estado";
            this.EstadoCuota.Name = "EstadoCuota";
            // 
            // TipoCuota
            // 
            this.TipoCuota.DataPropertyName = "TipoCuota";
            this.TipoCuota.HeaderText = "Tipo";
            this.TipoCuota.Name = "TipoCuota";
            // 
            // Vencimiento
            // 
            this.Vencimiento.DataPropertyName = "Vencimiento";
            this.Vencimiento.HeaderText = "Vencimiento";
            this.Vencimiento.Name = "Vencimiento";
            // 
            // Precio_cuota
            // 
            this.Precio_cuota.DataPropertyName = "Precio_cuota";
            this.Precio_cuota.HeaderText = "Precio";
            this.Precio_cuota.Name = "Precio_cuota";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(804, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CuotaMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MinimizeBox = false;
            this.Name = "CuotaMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuotaMan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id_cuota;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Ndoc_cuota;
        private DataGridViewTextBoxColumn Fecha_pago;
        private DataGridViewTextBoxColumn EstadoCuota;
        private DataGridViewTextBoxColumn TipoCuota;
        private DataGridViewTextBoxColumn Vencimiento;
        private DataGridViewTextBoxColumn Precio_cuota;
        private Button button1;
        private Button button2;
    }
}