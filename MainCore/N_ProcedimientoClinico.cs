using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainCore
{
    class ProcedimientoClinico
    {
        [DataMember]
        private String actividadClinica { set; get; }

        public ProcedimientoClinico()
        {
            this.actividadClinica = string.Empty;
        }
    }
}
