using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftAgroExporta
{
    public class clsTipoParihuela
    {
        private int mvarIdTipoParihuela;
        private string mvarNomTipoParihuela;
        private float mvarPesoParihuela;

        public int IdTipoParihuela
        {
            get { return mvarIdTipoParihuela; }
            set { mvarIdTipoParihuela = value; }
        }

        public string NomTipoParihuela
        {
            get { return mvarNomTipoParihuela; }
            set { mvarNomTipoParihuela = value; }
        }

        public float PesoParihuela
        {
            get { return mvarPesoParihuela; }
            set { mvarPesoParihuela = value; }
        }
    }
}
