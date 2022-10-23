using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisMat_GUI
{
    public partial class ProfesorMan : Form
    {
        public ProfesorMan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarProfesor agregarProfeModal = new AgregarProfesor();
            agregarProfeModal.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarProfesor actualizarProfeModal = new ActualizarProfesor();
            actualizarProfeModal.ShowDialog();
        }

 
        private void ProfesorMan_Load(object sender, EventArgs e)
        {

        }
    }
}
