using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainCore
{
    class Muestra
    {
        [DataMember]
        private Int32 codigo;
        [DataMember]
        private Int32 paciente;
        [DataMember]
        private Int32 experimento;
        [DataMember]
        private Int32 mpat;
        [DataMember]
        private Int32 nCiclosMasticatorios;
        [DataMember]
        private Int32 idImagen;

        public Muestra()
        {
            this.codigo = 0;
            this.paciente = 0;
            this.experimento = 0;
            this.mpat = 0;
            this.nCiclosMasticatorios = 0;
            this.idImagen = 0;
        }
    }
}
