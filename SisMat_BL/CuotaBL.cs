using SisMat_ADO;
using SisMat_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMat_BL
{
    public class CuotaBL
    {
        CuotaADO objCuotaADO = new CuotaADO();

        public DataTable ListarCuota()
        {
            return objCuotaADO.ListarCuota();
        }
        public Boolean InsertarCuota(CuotaBE objCuotaBE)
        {
            return objCuotaADO.InsertarCuota(objCuotaBE);
        }
        public Boolean ActualizarCuota(CuotaBE objCuotaBE)
        {
            return objCuotaADO.ActualizarCuota(objCuotaBE);
        }

        public Boolean EliminarCuota(Int16 idCuota)
        {
            return objCuotaADO.EliminarCuota(idCuota);
        }

    }
}
