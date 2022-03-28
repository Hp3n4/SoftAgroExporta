using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftAgroExporta
{
    public class clsLogin
    {
        static int mvarIdUsuario;
        static string mvarNombre;
        static string mvarClave;

        public int IdUsuario
        {
            get { return mvarIdUsuario; }
            set { mvarIdUsuario = value; }
        }

        public string Nombre
        {
            get { return mvarNombre; }
            set { mvarNombre = value; }
        }

        public string Clave
        {
            get { return mvarClave; }
            set { mvarClave = value; }
        }
    }
}
