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
    public class N_Imagenes
    {
        [DataMember]
        public Int32 Id { get; set; }
        [DataMember]
        public Int32 NumeroCiclos { get; set; }
        [DataMember]
        public Int32 IdPaciente { get; set; }
        [DataMember]
        public Int32 NumeroToma { get; set; }
        [DataMember]
        public Int32 Cara { get; set; }
        [DataMember]
        public Int32 IdMPAT { get; set; }
        [DataMember]
        public String Ruta { get; set; }

        public N_Imagenes()
        {
            Id = 0;
            NumeroCiclos = 0;
            IdPaciente = 0;
            NumeroToma = 0;
            Cara = 0;
            IdMPAT = 0;
            Ruta = String.Empty;
            
        }
        public N_Imagenes(Int32 id, Int32 nCic, Int32 idP, Int32 nTom, Int32 car, Int32 idM, String path)
        {
            Id = id;
            NumeroCiclos = nCic;
            IdPaciente = idP;
            NumeroToma = nTom;
            Cara = car;
            IdMPAT = idM;
            Ruta = path;
        }
    }
}
