//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MainCore
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paciente
    {
        public Paciente()
        {
            this.Imagenes = new HashSet<Imagenes>();
            this.HistoriaClinica = new HashSet<HistoriaClinica>();
        }
    
        public int Id { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Sexo { get; set; }
        public string Ubicacion { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual ICollection<Imagenes> Imagenes { get; set; }
        public virtual ICollection<HistoriaClinica> HistoriaClinica { get; set; }
    }
}