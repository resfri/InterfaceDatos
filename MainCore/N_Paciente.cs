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
    public class N_Paciente
    {
        [DataMember]
        public Int32 Id { get; set; }

        [DataMember]
        public String DNI { get; set; }

        [DataMember]
        public String Nombre { get; set; }
        [DataMember]
        public Int32 Edad { get; set; }
        [DataMember]
        public Int32 Sexo { get; set; }
        [DataMember]
        public String Ubicacion { get; set; }
        [DataMember]
        public DateTime FechaRegistro { get; set; }

        /// <summary>
        /// Constructor general de la clase N_Paciente
        /// </summary>
        public N_Paciente()
        {
            Id = 0;
            DNI = String.Empty;
            Nombre = String.Empty;
            Edad = 0;
            Sexo = 0;
            Ubicacion = String.Empty;
            FechaRegistro = DateTime.Now;

        }





    }
}
