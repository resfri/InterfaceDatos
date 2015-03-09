using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MainCore
{
    [DataContract]
    [Serializable]
    public class N_Mpat
    {
        [DataMember]
        public Int32 Id { get; set; }
        [DataMember]
        public String Descripcion { get; set; }
        [DataMember]
        public String WikiUrl { get; set; }
        [DataMember]
        public String AlimentoPrueba { get; set; }

        public N_Mpat(){
            this.Descripcion = "Masticar chicles durante 20 masticaciones";
            this.WikiUrl = "rutaWiki";
            this.AlimentoPrueba = "Chicle de color rojo";
            this.Id = 1;
        }
    }
}
