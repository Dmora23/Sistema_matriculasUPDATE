namespace SisMat_GUI
{
    partial class ProfesorMan
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
            this.Id_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Id_profe,
            this.Nom_profe,
            this.Ape_profe,
            this.Dni_profe,
            this.Tel_profe,
            this.Email_profe,
            this.Estado,
            this.Departamento,
            this.Provincia,
            this.Distrito});
            this.dataGridView1.Location = new System.Drawing.Point(21, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id_profe
            // 
            this.Id_profe.DataPropertyName = "Id_profe";
            this.Id_profe.HeaderText = "ID";
            this.Id_profe.Name = "Id_profe";
            // 
            // Nom_profe
            // 
            this.Nom_profe.DataPropertyName = "Nom_profe";
            this.Nom_profe.HeaderText = "Nombre";
            this.Nom_profe.Name = "Nom_profe";
            // 
            // Ape_profe
            // 
            this.Ape_profe.DataPropertyName = "Ape_profe";
            this.Ape_profe.HeaderText = "Apellido";
            this.Ape_profe.Name = "Ape_profe";
            // 
            // Dni_profe
            // 
            this.Dni_profe.DataPropertyName = "Dni_profe";
            this.Dni_profe.HeaderText = "DNI";
            this.Dni_profe.Name = "Dni_profe";
            // 
            // Tel_profe
            // 
            this.Tel_profe.DataPropertyName = "Tel_profe";
            this.Tel_profe.HeaderText = "Teléfono";
            this.Tel_profe.Name = "Tel_profe";
            // 
            // Email_profe
            // 
            this.Email_profe.DataPropertyName = "Email_profe";
            this.Email_profe.HeaderText = "Email";
            this.Email_profe.Name = "Email_profe";
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
            this.button1.Location = new System.Drawing.Point(878, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(988, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProfesorMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MinimizeBox = false;
            this.Name = "ProfesorMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfesorMan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id_profe;
        private DataGridViewTextBoxColumn Nom_profe;
        private DataGridViewTextBoxColumn Ape_profe;
        private DataGridViewTextBoxColumn Dni_profe;
        private DataGridViewTextBoxColumn Tel_profe;
        private DataGridViewTextBoxColumn Email_profe;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Provincia;
        private DataGridViewTextBoxColumn Distrito;
        private Button button1;
        private Button button2;
    }
}