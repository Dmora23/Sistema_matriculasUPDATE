namespace SisMat_GUI
{
    partial class AlumnoMan
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
            this.Id_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Des_semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_alum,
            this.Nom_alum,
            this.Ape_alum,
            this.Dir_alum,
            this.Tel_alum,
            this.Email_alum,
            this.Nom_carrera,
            this.Des_semestre,
            this.Estado,
            this.Departamento,
            this.Provincia,
            this.Distrito});
            this.dataGridView1.Location = new System.Drawing.Point(43, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1241, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id_alum
            // 
            this.Id_alum.DataPropertyName = "Id_alum";
            this.Id_alum.HeaderText = "ID";
            this.Id_alum.Name = "Id_alum";
            // 
            // Nom_alum
            // 
            this.Nom_alum.DataPropertyName = "Nom_alum";
            this.Nom_alum.HeaderText = "Nombre";
            this.Nom_alum.Name = "Nom_alum";
            // 
            // Ape_alum
            // 
            this.Ape_alum.DataPropertyName = "Ape_alum";
            this.Ape_alum.HeaderText = "Apellido";
            this.Ape_alum.Name = "Ape_alum";
            // 
            // Dir_alum
            // 
            this.Dir_alum.DataPropertyName = "Dir_alum";
            this.Dir_alum.HeaderText = "Dirección";
            this.Dir_alum.Name = "Dir_alum";
            // 
            // Tel_alum
            // 
            this.Tel_alum.DataPropertyName = "Tel_alum";
            this.Tel_alum.HeaderText = "Telefono";
            this.Tel_alum.Name = "Tel_alum";
            // 
            // Email_alum
            // 
            this.Email_alum.DataPropertyName = "Email_alum";
            this.Email_alum.HeaderText = "Email";
            this.Email_alum.Name = "Email_alum";
            // 
            // Nom_carrera
            // 
            this.Nom_carrera.DataPropertyName = "Nom_carrera";
            this.Nom_carrera.HeaderText = "Carrera";
            this.Nom_carrera.Name = "Nom_carrera";
            // 
            // Des_semestre
            // 
            this.Des_semestre.DataPropertyName = "Des_semestre";
            this.Des_semestre.HeaderText = "Semestre";
            this.Des_semestre.Name = "Des_semestre";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "Provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Distrito";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.Name = "Distrito";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1099, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1209, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AlumnoMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MinimizeBox = false;
            this.Name = "AlumnoMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlumnoMan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id_alum;
        private DataGridViewTextBoxColumn Nom_alum;
        private DataGridViewTextBoxColumn Ape_alum;
        private DataGridViewTextBoxColumn Dir_alum;
        private DataGridViewTextBoxColumn Tel_alum;
        private DataGridViewTextBoxColumn Email_alum;
        private DataGridViewTextBoxColumn Nom_carrera;
        private DataGridViewTextBoxColumn Des_semestre;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Provincia;
        private DataGridViewTextBoxColumn Distrito;
        private Button button1;
        private Button button2;
    }
}