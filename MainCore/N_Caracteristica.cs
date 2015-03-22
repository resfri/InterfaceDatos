using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainCore
{
    class Caracteristica
    {
        [DataMember]
        private Int32 idInstrumento { set; get; }
        [DataMember]
        private String unidadMedida { set; get; }
        [DataMember]
        private String nombre { set; get; }
        [DataMember]
        private Int32 valorMedido { set; get; }

        public Caracteristica()
        {
            this.idInstrumento = 0;
            this.unidadMedida = string.Empty;
            this.nombre = string.Empty;
            this.valorMedido = 0;
        }
    }
}
