﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MainCore
{
    [DataContract]
    [Serializable]
    public class Metodos
    {

        /// <summary>
        /// Constructor general de la clase Metodos
        /// </summary>
        public Metodos()
        {

        }
        /// <summary>
        /// Añade un registro de Paciente a la base de datos
        /// </summary>
        /// <param name="pac">Objeto N_Paciente</param>
        /// <returns></returns>
        public Boolean NuevoPaciente(N_Paciente pac)
        {
            using (Model1Container Context = new Model1Container())
            {
                //Genera instancia de objeto Paciente del Modelo
                Paciente DbPac = new Paciente();

                //Popula el objeto DbPac
                DbPac.DNI = pac.DNI;
                DbPac.Nombre = pac.Nombre;
                DbPac.Edad = pac.Edad;
                DbPac.Sexo = pac.Sexo;
                DbPac.Ubicacion = pac.Ubicacion;
                DbPac.FechaRegistro = pac.FechaRegistro;

                //Guardar el objeto DbPac en el Context
                try
                {
                    Context.PacienteSet.Add(DbPac);
                    Context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    Console.Write("Error " + e);
                    return false;
                }
                

            }
        }

        /// <summary>
        /// Obtiene un registro de Paciente de la base de datos
        /// </summary>
        /// <param name="Id">Id del paciente</param>
        /// <param name="pac">Referencia a Objeto N_Paciente</param>
        /// <returns>Retorna True si existe, de otro modo retorna False</returns>
        public Boolean getPaciente(Int32 Id, N_Paciente pac)
        {
            using (Model1Container Context = new Model1Container())
            {
                //Selecciona un registro de paciente por su Id
                var xdf = (from arecord in Context.PacienteSet
                           where arecord.Id == Id
                           select new
                           {
                               arecord
                           }).FirstOrDefault();
                try
                {
                    //Comprueba si el resultado es vacio
                    if(xdf.arecord != null)
                    {

                        pac.Id = xdf.arecord.Id;
                        pac.DNI = xdf.arecord.DNI;
                        pac.Nombre = xdf.arecord.Nombre;
                        pac.Edad = xdf.arecord.Edad;
                        pac.Sexo = xdf.arecord.Sexo;
                        pac.Ubicacion = xdf.arecord.Ubicacion;
                        pac.FechaRegistro = xdf.arecord.FechaRegistro;

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch(Exception e)
                {
                    Console.Write("Error " + e);
                    return false;
                }
            }
        }

        /// <summary>
        /// Borra un registro de paciente de la base de datos
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Boolean BorrarPaciente(Int32 Id)
        {
            using (Model1Container Context = new Model1Container())
            {
                //Selecciona un registro de paciente por su Id
                var xdf = (from arecord in Context.PacienteSet
                           where arecord.Id == Id
                           select new
                           {
                               arecord
                           }).FirstOrDefault();
                try
                {
                    //Comprueba si el resultado es vacio
                    if (xdf.arecord != null)
                    {
                        //Borra el registro
                        Context.PacienteSet.Remove(xdf.arecord);
                        Context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Console.Write("Error " + e);
                    return false;
                }
            }
        }

        /// <summary>
        /// Rellena una lista de objetos Paciente a partir de los registro de la base de datos
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>Retorna True si existen objetos en la lista, de otro modo retorna False</returns>
        public Boolean ListarPacients(List<N_Paciente> lista)
        {
            using (Model1Container Context = new Model1Container())
            {
                //Selecciona un registro de paciente por su Id
                var xdf = (from arecord in Context.PacienteSet
                           select new
                           {
                               arecord
                           }).ToList();
                try
                {
                    //Verifica que existan los registros
                    if(xdf != null)
                    {
                        foreach (var registro in xdf)
                        {
                            //crear instancia de objeto N_Paciente
                            N_Paciente pac = new N_Paciente();
                            pac.Id = registro.arecord.Id;
                            pac.DNI = registro.arecord.DNI;
                            pac.Nombre = registro.arecord.Nombre;
                            pac.Edad = registro.arecord.Edad;
                            pac.Sexo = registro.arecord.Sexo;
                            pac.Ubicacion = registro.arecord.Ubicacion;
                            pac.FechaRegistro = registro.arecord.FechaRegistro;

                            //añadir pac a la lista
                            lista.Add(pac);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch(Exception e)
                {
                    Console.Write("Error " + e);
                    return false;
                }
            }

        }

        /// <summary>
        /// Guarda los valores del odontograma en la base de datos
        /// </summary>
        /// <param name="odont">Valores del odontograma</param>
        /// <param name="Id">Id del paciente al que pertenece el odontograma</param>
        /// <returns></returns>
        public Boolean NuevoOdontograma(String[] odont, Int32 Id)
        {
            using (Model1Container Context = new Model1Container())
            {
                var xdf = (from arecord in Context.PacienteSet
                           where arecord.Id == Id
                           select new
                           {
                               arecord
                           }).FirstOrDefault();

                try
                {
                    if (xdf.arecord != null)
                    {
                        HistoriaClinica Dbhistoria = new HistoriaClinica();

                        Dbhistoria.IdPaciente= xdf.arecord.Id;
                        Dbhistoria.Odontograma= odont.ToString();
                        Dbhistoria.NumeroDientesPerdidos = contarDientesPerdidos(odont); //no chks
                        Dbhistoria.ParesAntagPerdidos = contarParesAntagPerdidos(odont);//
                        Context.HistoriaClinicaSet.Add(Dbhistoria);
                        Context.SaveChanges();
                        return true;
                        
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Console.Write("Error " + e);
                    return false;
                }
            }

        }

        private Int32 contarDientesPerdidos(String[] odont){
            Int32 cuenta=32;
            
            foreach (String o in odont)
            {
                if (o =="F"){
                    cuenta--;
                }
            }
            
            return cuenta;
        }

        private Int32 contarParesAntagPerdidos(String[] odont){
            Int32 cuenta=10;
            Int32 n;
            for (n=2; n<=7; n++){
                if (odont[n].CompareTo(odont[n + 8]) == 0)
                { 
                    if (odont[n].CompareTo("T") == 0)
                    {
                        cuenta--;
                    }
                }
            }
            for (n = 19; n <= 23; n++)
            {
                if (odont[n].CompareTo(odont[n + 8]) == 0)
                {
                    if (odont[n].CompareTo("T") == 0)
                    {
                        cuenta--;
                    }
                }
            }
            return cuenta;
        }

        /// <summary>
        /// Obtiene un registro de Paciente de la base de datos por DNI
        /// </summary>
        /// <param name="dni">Id del paciente</param>
        /// <param name="pac">Referencia a Objeto N_Paciente</param>
        /// <returns>Retorna True si existe, de otro modo retorna False</returns>
        public Boolean getPacienteDNI(String dni, N_Paciente pac)
        {
            using (Model1Container Context = new Model1Container())
            {
                //Selecciona un registro de paciente por su Id
                var xdf = (from arecord in Context.PacienteSet
                           where arecord.DNI.CompareTo(dni)==0
                           select new
                           {
                               arecord
                           }).FirstOrDefault();
                try
                {
                    //Comprueba si el resultado es vacio
                    if (xdf.arecord != null)
                    {

                        pac.Id = xdf.arecord.Id;
                        pac.DNI = xdf.arecord.DNI;
                        pac.Nombre = xdf.arecord.Nombre;
                        pac.Edad = xdf.arecord.Edad;
                        pac.Sexo = xdf.arecord.Sexo;
                        pac.Ubicacion = xdf.arecord.Ubicacion;
                        pac.FechaRegistro = xdf.arecord.FechaRegistro;

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Console.Write("Error " + e);
                    return false;
                }
            }
        }

    }


}