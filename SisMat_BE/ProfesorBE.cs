using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMat_BE
{
    public class ProfesorBE
    {
        // Definimos la entidad de negocio, con todas las propiedades de acuerdo a la estructura 
        // de la tabla Tb_PROFESOR
        public Int16 Id_profe { get; set; }
        public String Id_Ubigeo { get; set; }
        public Int16 Id_esp { get; set; }
        public Byte[] Foto_profe { get; set; }
        public String Dni_profe { get; set; }
        public String Nom_profe { get; set; }
        public String Ape_profe { get; set; }
        public String Tel_profe { get; set; }
        public String Email_profe { get; set; }
        public String Usu_Registro { get; set; }
        public DateTime Fec_Registro { get; set; }
        public String Usu_Ult_Mod { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public Int16 Est_profe { get; set; }
    }
}
