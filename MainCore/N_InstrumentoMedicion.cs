using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainCore
{
    class InstrumentoMedicion
    {
        [DataMember]
        private String nombre;
        [DataMember]
        private String descripcion;
        [DataMember]
        private enum TipoInstrumentoMedicion
        {
            ESCANER = 1,
            CAMARA,
            ESPECTOFOTOGRAFO,
            BASCULAS,
            TAMIZADORAS
        }
        [DataMember]
        private TipoInstrumentoMedicion tipo;

        public InstrumentoMedicion()
        {
            this.nombre = string.Empty;
            this.descripcion = string.Empty;
            this.tipo = TipoInstrumentoMedicion.BASCULAS;
        }

    }
}
