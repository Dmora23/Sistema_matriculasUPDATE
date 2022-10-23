using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMat_BE
{
    public class AlumnoBE
    {
        // Definimos la entidad de negocio, con todas las propiedades de acuerdo a la estructura 
        // de la tabla Tb_Alumno
        public Int16 Id_alum { get; set; }
        public String Id_Ubigeo { get; set; }
        public String Dni_alum { get; set; }
        public Byte[] Foto_alum { get; set; }
        public DateTime Fec_nac { get; set; }
        public String Sexo { get; set; }
        public String Nom_alum { get; set; }
        public String Ape_alum { get; set; }
        public String Dir_alum { get; set; }
        public String Tel_alum { get; set; }
        public String Email_alum { get; set; }
        public String Usu_Registro { get; set; }
        public DateTime Fec_Registro { get; set; }
        public String Usu_Ult_Mod { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public Int16 Est_alum { get; set; }
    }
}
