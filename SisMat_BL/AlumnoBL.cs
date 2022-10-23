using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Using necesarios...
using System.Data;
using SisMat_ADO;
using SisMat_BE;

namespace SisMat_BL
{
    public class AlumnoBL
    {
        AlumnoADO objAlumnoADO = new AlumnoADO();
        public Boolean InsertarAlumno(AlumnoBE objAlumnoBE)
        {
            return objAlumnoADO.InsertarAlumno(objAlumnoBE);
        }
        public Boolean ActualizarAlumno(AlumnoBE objAlumnoBE)
        {
            return objAlumnoADO.ActualizarAlumno(objAlumnoBE);
        }
        public Boolean EliminarAlumno(Int16 strCod)
        {
            return objAlumnoADO.EliminarAlumno(strCod);
        }
        public AlumnoBE ConsultarAlumno(Int16 strCod)
        {
            return objAlumnoADO.ConsultarAlumno(strCod);
        }
        public DataTable ListarAlumno()
        {
            return objAlumnoADO.ListarAlumno();
        }

    }
}
