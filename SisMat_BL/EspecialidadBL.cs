using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar...
using SisMat_ADO;
namespace SisMat_BL
{
    public  class EspecialidadBL
    {
        EspecialidadADO objEspecialidadADO = new EspecialidadADO();

        public DataTable ListarEspecialidad()
        {
            return objEspecialidadADO.ListarEspecialidad();
        }
    }
}
