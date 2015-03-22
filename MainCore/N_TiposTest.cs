using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainCore
{
    [DataContract]
    [Serializable]
    class TiposTest
    {

        [DataMember]
        private String nombre { set; get; }
        [DataMember]
        private String descripcion { set; get; }
        [DataMember]
        private Int32 indicadorTipoMuestra { set; get; }

        public TiposTest()
        {
            this.nombre = string.Empty;
            this.descripcion = string.Empty;
            this.indicadorTipoMuestra = 0;


        }
    }
}
