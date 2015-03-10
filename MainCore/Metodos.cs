using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WIA;
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
        /// Guarda los valores de la historia medica en la base de datos
        /// </summary>
        /// <param name="hist">Valores de historia medica</param>
        /// <param name="pac">paciente al que pertenece el odontograma</param>
        /// <returns></returns>
        public Boolean addHistoria(N_Historia hist, N_Paciente pac)
        {
            using (Model1Container Context = new Model1Container())
            {
                
                var xdf = (from arecord in Context.PacienteSet
                           where arecord.DNI == pac.DNI
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
                        Dbhistoria.Odontograma= hist.Odontograma;
                        Dbhistoria.ACV = hist.ACV;
                        Dbhistoria.EnfermedadCardioVascular = hist.EnfermedadCardioVascular;
                        Dbhistoria.EnfermedadRenal = hist.EnfermedadRenal;
                        Dbhistoria.EstadoSaludGeneral = hist.EstadoSaludGeneral;
                        Dbhistoria.GradoDesnutricion = hist.GradoDesnutricion;
                        Dbhistoria.GradoEdentulismo = hist.GradoEdentulismo;
                        Dbhistoria.ICTUS = hist.ICTUS;
                        Dbhistoria.Implantes = hist.Implantes;
                        Dbhistoria.NumeroCariados = hist.NumeroCariados;
                        Dbhistoria.NumeroDientesObturados = hist.NumeroDientesObturados;
                        Dbhistoria.Ortodoncia = hist.Ortodoncia;
                        Dbhistoria.ParalisisFacial = hist.ParalisisFacial;
                        Dbhistoria.Protesis = hist.Protesis;
                        Dbhistoria.NumeroDientesPerdidos = hist.NumeroDientesPerdidos; 
                        Dbhistoria.ParesAntagPerdidos = hist.ParesAntagPerdidos;

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

        /// <summary>
        /// Guarda los datos de las imagenes
        /// </summary>
        /// <param name="imagen">Valores de la imagen</param>
        /// <param name="pac">paciente al que pertenece el odontograma</param>
        /// <returns></returns>
        public Boolean addImagen(N_Imagenes imagen, N_Paciente pac, N_Mpat mpat)
        {
            using (Model1Container Context = new Model1Container())
            {

                var xdf = (from arecord in Context.PacienteSet
                           where arecord.DNI == pac.DNI
                           select new
                           {
                               arecord
                           }).FirstOrDefault();

                try
                {
                    if (xdf.arecord != null)
                    {
                        Imagenes Dbimagenes = new Imagenes();

                        Dbimagenes.IdPaciente = xdf.arecord.Id;
                        Dbimagenes.IdMPAT = mpat.Id;
                        Dbimagenes.NumeroCiclos = imagen.NumeroCiclos;
                        Dbimagenes.NumeroToma = imagen.NumeroToma;
                        Dbimagenes.Cara = imagen.Cara;
                        Dbimagenes.RutaImagen = imagen.Ruta;
                        Dbimagenes.Paciente = xdf.arecord;

                        

                        Context.ImagenesSet.Add(Dbimagenes);
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
        /// Alta de MPAT
        /// </summary>
        /// <param name="mpat">Elemento tipo Mpat que tenemos que dar de alta</param>
        /// <returns></returns>
        public Boolean addMpat(N_Mpat mpat)
        {
            using (Model1Container Context = new Model1Container())
            {
                //Genera instancia de objeto Paciente del Modelo
                MPAT DbMpat = new MPAT();

                //Popula el objeto DbPac
                DbMpat.AlimentoPrueba = mpat.AlimentoPrueba;
                DbMpat.Descripcion = mpat.Descripcion;
                DbMpat.WikiURL = mpat.WikiUrl;
                DbMpat.Id = mpat.Id;

                //Guardar el objeto DbPac en el Context
                try
                {
                    Context.MPATSet.Add(DbMpat);
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
        /// Dato un odontograma, devuelve el numero de dientes perdidos
        /// </summary>
        /// <param name="odont"></param>
        /// <returns></returns>
        public Int32 contarDientesPerdidos(String[] odont){
            Int32 cuenta=0;
            
            foreach (String o in odont)
            {
                if (o =="F"){
                    cuenta++;
                }
            }
            
            return cuenta;
        }


        /// <summary>
        /// Realiza el cálculo de contar los pares Antagonicos Perdidos
        /// </summary>
        /// <param name="odont"></param>
        /// <returns></returns>
        public Int32 contarParesAntagPerdidos(String[] odont){
            Int32 cuenta=0;
            Int32 n;
            for (n=3; n<8; n++)
            {
                //if (odont[n].CompareTo(odont[n + 24]) == 0)
                //{ 
                //    cuenta++;
                //}else 
                if (odont[n].CompareTo("F") == 0 || odont[n + 24].CompareTo("F") == 0)
                {
                    cuenta++;
                }
            }
            for (n = 11; n < 16; n++)
            {
                //if (odont[n].CompareTo(odont[n + 19-11]) == 0)
                //{
                if (odont[n].CompareTo("F") == 0 || odont[n + 8].CompareTo("F") == 0)
                    {
                        cuenta++;
                    }
            
            }
            return cuenta;
        }

        /// <summary>
        /// Obtiene un registro de Paciente de la base de datos por DNI
        /// </summary>
        /// <param name="dni">Id del paciente</param>
        /// <param name="pac">Referencia a Objeto N_Paciente</param>
        /// <returns>Retorna Id si existe, si error retorna 0</returns>
        public Boolean getPacienteDNI(String dni, N_Paciente pac)
        {
            using (Model1Container Context = new Model1Container())
            {
                //Selecciona un registro de paciente por su DNI
                var xdf = (from arecord in Context.PacienteSet
                           where arecord.DNI.CompareTo(pac.DNI)==0
                           select new
                           {
                               arecord
                           }).FirstOrDefault();
                try
                {
                    //Comprueba si el resultado es vacio
                    if (xdf.arecord != null)
                    {
                        //volcamos los datos de la consulta a la variable pac
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

        /// <summary>
        /// Dado un identificado ID de paciente, devolvemos la historia clinica del paciente
        /// </summary>
        /// <param name="p">ID del paciente</param>
        /// <param name="historia">retorno de la historia clinica del paciente</param>
        /// <returns>Devuelve true si se encuentra el paciente y la historia, devuelve false en cualquier otro caso</returns>
        public bool getHistoriaId(Int32 p, N_Historia historia)
        {
            using (Model1Container Context = new Model1Container())
            {
                //Selecciona un registro de paciente por su Id
                var xdf = (from arecord in Context.HistoriaClinicaSet
                           where arecord.IdPaciente==p
                           select new
                           {
                               arecord
                           }).FirstOrDefault();
                try
                {
                    //Comprueba si el resultado es vacio
                    if (xdf.arecord != null)
                    {
                        //volcamos los datos de la consulta a la variable historia
                        historia.Odontograma= xdf.arecord.Odontograma;
                        historia.ACV = xdf.arecord.ACV;
                        historia.EnfermedadCardioVascular = xdf.arecord.EnfermedadCardioVascular;
                        historia.EnfermedadRenal = xdf.arecord.EnfermedadRenal;
                        historia.EstadoSaludGeneral = xdf.arecord.EstadoSaludGeneral;
                        historia.GradoDesnutricion = xdf.arecord.GradoDesnutricion;
                        historia.GradoEdentulismo = xdf.arecord.GradoEdentulismo;
                        historia.ICTUS = xdf.arecord.ICTUS;
                        historia.Id = xdf.arecord.Id;
                        historia.IdPaciente = xdf.arecord.IdPaciente;
                        historia.Implantes = xdf.arecord.Implantes;
                        historia.NumeroCariados = xdf.arecord.NumeroCariados;
                        historia.NumeroDientesObturados = xdf.arecord.NumeroDientesObturados;
                        historia.NumeroDientesPerdidos = xdf.arecord.NumeroDientesPerdidos;
                        historia.Ortodoncia = xdf.arecord.Ortodoncia;
                        historia.ParalisisFacial = xdf.arecord.ParalisisFacial;
                        historia.ParesAntagPerdidos = xdf.arecord.ParesAntagPerdidos;
                        historia.Protesis = xdf.arecord.Protesis;
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
        /// Crea un listado con los informes almacenados en la base de datos
        /// </summary>
        /// <param name="listado"></param>
        /// <returns>Devuelve true si se ha encontrado informe, devuelve false si no se ha encontrdo informe</returns>
        public bool listarInformes(List<N_Informe> listado)
        {
            using (Model1Container Context = new Model1Container())
            {

                //Selecciona un registro de paciente por su Id
                var xdf = (from arecord in Context.PacienteSet
                           from ahistoria in Context.HistoriaClinicaSet
                           where ahistoria.IdPaciente == arecord.Id
                           select new
                           {
                               arecord.DNI,
                               arecord.Id,
                               arecord.Edad,
                               arecord.Nombre,
                               arecord.Sexo,
                               arecord.Ubicacion,
                               ahistoria.NumeroDientesPerdidos,
                               ahistoria.ParesAntagPerdidos,
                               ahistoria.Odontograma

                           }).ToList();
                try
                {
                    //Verifica que existan los registros
                    if (xdf != null)
                    {
                        foreach (var registro in xdf)
                        {

                            N_Informe Dbinforme = new N_Informe();
                            Dbinforme.NumeroDientesPerdidos = registro.NumeroDientesPerdidos;
                            Dbinforme.Nombre = registro.Nombre;
                            Dbinforme.Odontograma = registro.Odontograma;
                            Dbinforme.ParesAntagPerdidos = registro.ParesAntagPerdidos;
                            Dbinforme.Sexo = registro.Sexo;
                            Dbinforme.Ubicacion = registro.Ubicacion;
                            Dbinforme.DNI = registro.DNI;
                            Dbinforme.Edad = registro.Edad;
                            listado.Add(Dbinforme);
                            
                        }
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
        /// Crea listado con las historias almacenas en la base de datos
        /// </summary>
        /// <param name="listaHistorias"></param>
        /// <returns></returns>
        public bool ListarHistorias(List<N_Historia> listaHistorias)
        {
            using (Model1Container Context = new Model1Container())
            {
                //Selecciona un registro de paciente por su Id
                var xdf = (from arecord in Context.HistoriaClinicaSet
                           select new
                           {
                               arecord
                           }).ToList();
                try
                {
                    //Verifica que existan los registros
                    if (xdf != null)
                    {
                        foreach (var registro in xdf)
                        {
                            //crear instancia de objeto N_Paciente
                            N_Historia his = new N_Historia();
                            his.Id = registro.arecord.Id;
                            his.IdPaciente = registro.arecord.IdPaciente;
                            his.NumeroDientesPerdidos = registro.arecord.NumeroDientesPerdidos;
                            his.Odontograma = registro.arecord.Odontograma;
                            his.ParesAntagPerdidos = registro.arecord.ParesAntagPerdidos;
                            

                            //añadir pac a la lista
                            listaHistorias.Add(his);
                        }
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

        public bool getImagenId(int p, N_Imagenes imagen)
        {
            using (Model1Container Context = new Model1Container())
            {
                //Selecciona un registro de paciente por su Id
                var xdf = (from arecord in Context.ImagenesSet
                           where arecord.IdPaciente == p
                           select new
                           {
                               arecord
                           }).FirstOrDefault();
                try
                {
                    //Comprueba si el resultado es vacio
                    if (xdf.arecord != null)
                    {
                        //volcamos los datos de la consulta a la variable historia
                        imagen.Ruta = xdf.arecord.RutaImagen;
                        imagen.Id = xdf.arecord.Id;
                        imagen.IdMPAT = xdf.arecord.IdMPAT;
                        imagen.IdPaciente = xdf.arecord.IdPaciente;
                        imagen.NumeroCiclos = xdf.arecord.NumeroCiclos;
                        imagen.NumeroToma = xdf.arecord.NumeroToma;
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

        public bool ListarImagenes(List<N_Imagenes> listaImagenes)
        {
            using (Model1Container Context = new Model1Container())
            {
                //Selecciona un registro de paciente por su Id
                var xdf = (from arecord in Context.ImagenesSet
                           select new
                           {
                               arecord
                           }).ToList();
                try
                {
                    //Verifica que existan los registros
                    if (xdf != null)
                    {
                        foreach (var registro in xdf)
                        {
                            //crear instancia de objeto N_Paciente
                            N_Imagenes img = new N_Imagenes();
                            img.Id = registro.arecord.Id;
                            img.IdMPAT = registro.arecord.IdMPAT;
                            img.IdPaciente = registro.arecord.IdPaciente;
                            img.NumeroCiclos = registro.arecord.NumeroCiclos;
                            img.NumeroToma = registro.arecord.NumeroToma;
                            img.Ruta = registro.arecord.RutaImagen;
                            img.Cara = registro.arecord.Cara;


                            //añadir pac a la lista
                            listaImagenes.Add(img);
                        }
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

        public bool existe(string p)
        {
            using (Model1Container Context = new Model1Container())
            {
                //Selecciona un registro de paciente por su DNI
                var xdf = (from arecord in Context.PacienteSet
                           where arecord.DNI.CompareTo(p) == 0
                           select new
                           {
                               arecord
                           }).FirstOrDefault();
                try
                {
                    //Comprueba si el resultado es vacio
                    if (xdf.arecord != null)
                    {
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

        public bool updatePaciente(N_Paciente pac, N_Historia historia, N_Imagenes imagen, N_Mpat mpat)
        {
            using (Model1Container Context = new Model1Container())
            {
                //Selecciona un registro de paciente por su DNI
                var xdf = (from arecord in Context.PacienteSet
                           where arecord.DNI.CompareTo(pac.DNI) == 0
                           select new
                           {
                               arecord
                           }).FirstOrDefault();
                try
                {
                    //Comprueba si el resultado es vacio
                    if (xdf.arecord != null)
                    {
                        //volcamos los datos de la consulta a la variable pac
                        
                        this.deleteHistoria(historia);
                        this.deleteImagen(imagen);
                        this.BorrarPaciente(xdf.arecord.Id);

                        this.NuevoPaciente(pac);
                        this.addImagen(imagen, pac, mpat);
                        this.addHistoria(historia, pac);                        
                        
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

        private void deleteImagen(N_Imagenes imagen)
        {
            using (Model1Container Context = new Model1Container())
            {//Selecciona un registro de paciente por su DNI
                var xdf = (from arecord in Context.ImagenesSet
                           where arecord.Id == imagen.Id
                           select new
                           {
                               arecord
                           }).FirstOrDefault();
                try
                {
                    //Comprueba si el resultado es vacio
                    if (xdf.arecord != null)
                    {//Borra el registro
                        Context.ImagenesSet.Remove(xdf.arecord);
                        Context.SaveChanges();
                    }
                    else
                    {

                    }
                }
                catch (Exception e)
                {
                    Console.Write("Error " + e);
                }
            }
        }

        private void deleteHistoria(N_Historia historia)
        {
            using (Model1Container Context = new Model1Container())
            {//Selecciona un registro de paciente por su DNI
                var xdf = (from arecord in Context.HistoriaClinicaSet
                           where arecord.Id == historia.Id
                           select new
                           {
                               arecord
                           }).FirstOrDefault();
                try
                {
                    //Comprueba si el resultado es vacio
                    if (xdf.arecord != null)
                    {//Borra el registro
                        Context.HistoriaClinicaSet.Remove(xdf.arecord);
                        Context.SaveChanges();
                    }
                    else
                    {

                    }
                }
                catch (Exception e)
                {
                    Console.Write("Error " + e);
                }
            }
        }
    }

}