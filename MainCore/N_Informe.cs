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
        public Int32 Id { get; set; }
        [DataMember]
        public String DNI {get; set;}
        [DataMember]
        public Int32 Edad  {get; set;}
        [DataMember]
        public String Nombre  {get; set;}
        [DataMember]
        public Int32 Sexo  {get; set;}
        [DataMember]
        public String Ubicacion  {get; set;}
        [DataMember]
        public Int32 NumeroDientesPerdidos  {get; set;}
        [DataMember]
        public Int32 ParesAntagPerdidos  {get; set;}
        [DataMember]
        public String Odontograma { get; set; }
        [DataMember]
        public String rutaImagen { get; set; }

        public N_Informe()
        {
            this.DNI = String.Empty;
            this.Edad = 0;
            this.Nombre = String.Empty;
            this.Sexo = 0;
            this.Ubicacion = String.Empty;
            this.NumeroDientesPerdidos = 0;
            this.ParesAntagPerdidos = 0;
            this.Odontograma = String.Empty;
            this.Id = 0;
            rutaImagen = String.Empty;
        }

        
    }
}
