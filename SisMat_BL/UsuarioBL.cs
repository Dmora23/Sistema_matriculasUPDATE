using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisMat_ADO;
using SisMat_BE;

namespace SisMat_BL
{
    public class UsuarioBL
    {
        UsuarioADO objUsuarioADO = new UsuarioADO();

        public UsuarioBE ConsultarUsuario(String strCodigo)
        {
            return objUsuarioADO.ConsultarUsuario(strCodigo);
        }
    }
}
