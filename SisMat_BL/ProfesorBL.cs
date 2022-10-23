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
    public class ProfesorBL
    {
        ProfesorADO objProfesorADO = new ProfesorADO();
        public Boolean InsertarProfesor(ProfesorBE objProfesorBE)
        {
            return objProfesorADO.InsertarProfesor(objProfesorBE);
        }
        public Boolean ActualizarProfesor(ProfesorBE objProfesorBE)
        {
            return objProfesorADO.ActualizarProfesor(objProfesorBE);
        }
        public Boolean EliminarProfesor(Int16 strCod)
        {
            return objProfesorADO.EliminarProfesor(strCod);
        }
        public ProfesorBE ConsultarProfesor(Int16 strCod)
        {
            return objProfesorADO.ConsultarProfesor(strCod);
        }
        public DataTable ListarProfesor()
        {
            return objProfesorADO.ListarProfesor();
        }

    }
}
