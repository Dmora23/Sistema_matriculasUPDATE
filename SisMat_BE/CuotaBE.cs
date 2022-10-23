using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMat_BE
{
    public class CuotaBE
    {
        // Definimos la entidad de negocio, con todas las propiedades de acuerdo a la estructura 
        // de la tabla Tb_CUOTA
        public Int16 Id_cuota { get; set; }
        public Int16 Id_alum { get; set; }
        public String Ndoc_cuota { get; set; }
        public DateTime Fec_pago { get; set; }
        public Int16 Est_cuota { get; set; }
        public Int16 Tip_cuota { get; set; }
        public DateTime Vencimiento { get; set; }
        public Single Precio_cuota { get; set; }

    }
}
