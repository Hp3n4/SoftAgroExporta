using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftAgroExporta
{
    public class clsTipoJaba
    {
        private int mvarIdTipoJaba;
        private string mvarNomTipoJaba;
        private float mvarPesoJaba;

        public int IdTipoJaba
        {
            get { return mvarIdTipoJaba; }
            set { mvarIdTipoJaba = value; }
        }

        public string NomTipoJaba
        {
            get { return mvarNomTipoJaba; }
            set { mvarNomTipoJaba = value; }
        }

        public float PesoJaba
        {
            get { return mvarPesoJaba; }
            set { mvarPesoJaba = value; }
        }
    }
}
