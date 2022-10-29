using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginNurPractica
{
    public class Login
    {
        public string inicio (string user, string pass)
        {
            string estado = "";
            int intentos = 0;
            string[,] arreglo = { { "ocsicnarF", "ana" }, { "1991", "2016" } };
            if (user == arreglo[0, 0] && pass == arreglo[1, 0])
            {
                estado = "OK";
            }
            else
            {
                estado = "ERR";
                intentos += 1;
            }
            return estado;
        }
    }
}
