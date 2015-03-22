using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MainCore
{

    [DataContract]
    [Serializable]
    public partial class HistoriaClinica
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Odontograma { get; set; }
        [DataMember]
        public int NumeroCariados { get; set; }
        [DataMember]
        public int NumeroDientesPerdidos { get; set; }
        [DataMember]
        public int NumeroDientesObturados { get; set; }
        [DataMember]
        public string Ortodoncia { get; set; }
        [DataMember]
        public string Protesis { get; set; }
        [DataMember]
        public int Implantes { get; set; }
        [DataMember]
        public int ParesAntagPerdidos { get; set; }
        [DataMember]
        public int GradoEdentulismo { get; set; }
        [DataMember]
        public bool EstadoSaludGeneral { get; set; }
        [DataMember]
        public bool EnfermedadCardioVascular { get; set; }
        [DataMember]
        public bool EnfermedadRenal { get; set; }
        [DataMember]
        public bool ICTUS { get; set; }
        [DataMember]
        public bool ACV { get; set; }
        [DataMember]
        public bool ParalisisFacial { get; set; }
        [DataMember]
        public int GradoDesnutricion { get; set; }
        [DataMember]
        public int IdPaciente { get; set; }
    
        public virtual Paciente Paciente { get; set; }
    }
}
