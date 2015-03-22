using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainCore
{
    [DataContract]
    [Serializable]
    class TestFood
    {
        [DataMember]
        private String nombre { set; get;}
        [DataMember]
        private String descripcion { set; get; }
        [DataMember]
        private Int32 tipo { set; get; }
        [DataMember]
        private String caracteristicasMonitorizadas { set; get; }

        public TestFood()
        {
            this.nombre = string.Empty;
            this.descripcion = string.Empty;
            this.tipo = 0;
            this.caracteristicasMonitorizadas = string.Empty;

        }
    }
}
