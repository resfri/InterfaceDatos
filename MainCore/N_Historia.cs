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
    public class N_Historia
    {
        [DataMember]
        public Int32 Id { get; set; }
        [DataMember]
        public Int32 IdPaciente { get; set; }
        [DataMember]
        public String Odontograma { get; set; }
        [DataMember]
        public Int32 NumeroCariados { get; set; }
        [DataMember]
        public Int32 NumeroDientesPerdidos { get; set; }
        [DataMember]
        public Int32 NumeroDientesObturados { get; set; }
        [DataMember]
        public String Ortodoncia { get; set; }
        [DataMember]
        public String Protesis { get; set; }
        [DataMember]
        public Int32 Implantes { get; set; }
        [DataMember]
        public Int32 ParesAntagPerdidos{ get; set; }
        [DataMember]
        public Int32 GradoEdentulismo { get; set; }
        [DataMember]
        public Boolean EstadoSaludGeneral { get; set; }
        [DataMember]
        public Boolean EnfermedadCardioVascular{ get; set; }
        [DataMember]
        public Boolean EnfermedadRenal { get; set; }
        [DataMember]
        public Boolean ICTUS { get; set; }
        [DataMember]
        public Boolean ACV { get; set; }
        [DataMember]
        public Boolean ParalisisFacial { get; set; }
        [DataMember]
        public Int32 GradoDesnutricion { get; set; }

        /// <summary>
        /// Constructor general de la clase N_Paciente
        /// </summary>
        public N_Historia()
        {
            Id = 0;
            IdPaciente = 0;
            Odontograma = String.Empty;
            NumeroCariados = 0;
            NumeroDientesPerdidos = 0;
            NumeroDientesObturados = 0;
            Ortodoncia = String.Empty;
            Protesis = String.Empty;
            Implantes = 0;
            ParesAntagPerdidos = 0;
            GradoEdentulismo = 0;
            EstadoSaludGeneral = false;
            EnfermedadCardioVascular = false;
            EnfermedadRenal = false;
            ICTUS = false;
            ACV = false;
            ParalisisFacial = false;
            GradoDesnutricion = 0;
        }
    }
}
