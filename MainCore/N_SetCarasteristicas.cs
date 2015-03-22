using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainCore
{
    class SetCarasteristicas
    {
        [DataMember]
        private Int32 idMuestra { set; get; }
        [DataMember]
        private Int32 idCaracteristica { set; get; }
        [DataMember]
        private Int32 valor { set; get; }

        public SetCarasteristicas()
        {
            this.idCaracteristica = 0;
            this.idMuestra = 0;
            this.valor = 0;

        }
    }
}
