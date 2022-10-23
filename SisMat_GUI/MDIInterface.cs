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
      public partial class MDIInterface : Form
      {
            public MDIInterface()
            {
                InitializeComponent();
                IsMdiContainer = true;
            }

            private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
            {
                AlumnoMan alumView = new AlumnoMan();
                alumView.MdiParent = this;
                alumView.Show();
            }

            private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
            {
              ProfesorMan profesorView = new ProfesorMan();
              profesorView.MdiParent = this;
              profesorView.Show();

            }

            private void cuotasToolStripMenuItem_Click(object sender, EventArgs e)
            {
              CuotaMan cuotasView = new CuotaMan();
              cuotasView.MdiParent = this;
              cuotasView.Show();
            }
      }
}
