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
    public partial class AlumnoMan : Form
    {
        public AlumnoMan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatricularAlumno matricularModal = new MatricularAlumno();
            matricularModal.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarAlumno actualizarModal = new ActualizarAlumno();
            actualizarModal.ShowDialog();

        }
    }
}
