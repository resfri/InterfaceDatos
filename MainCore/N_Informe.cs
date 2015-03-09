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
    // La clase Informe recoge todos los datos de un paciente y su historia clinica
    public class N_Informe
    {
        [DataMember]
        public N_Historia historia { get; set; }
        [DataMember]
        public N_Paciente paciente {get; set;}

        public N_Informe(N_Historia hist, N_Paciente pac)
        {
            
            hist = new N_Historia();
            pac = new N_Paciente();
        }
    }
}
