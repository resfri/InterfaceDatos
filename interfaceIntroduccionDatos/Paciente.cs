using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceIntroduccionDatos
{
    class Paciente
    {
        String identificacion;
        String nombre;
        String edad;
        String sexo;
        String ubicacion;
        String fechaRegistro;


        public Paciente(String id, String n, String e, String s, String u, String f) {
            this.identificacion = id;
            this.nombre = n;
            this.edad = e;
            this.sexo = s;
            this.ubicacion = u;
            this.fechaRegistro = f;
        }

        public Paciente()
        {
            
        }

        public string getIdentificacion()
        {
            return this.identificacion;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public string getEdad()
        {
            return this.edad;
        }
        public string getSexo()
        {
            return this.sexo;
        }
        public string getUbicacion()
        {
            return this.ubicacion;
        }
        public string getFechaRegistro()
        {
            return this.fechaRegistro;
        }
        public void setIdentificacion(String id)
        {
             this.identificacion= id;
        }
        public void setNombre(String n)
        {
            this.nombre = n;
        }
        public void setEdad(String s)
        {
            this.edad = s;
        }
        public void setSexo(String s)
        {
            this.sexo= s;
        }
        public void setUbicacion(String s)
        {
             this.ubicacion= s;
        }
        public void setFechaRegistro(String s)
        {
            this.fechaRegistro = s;
        }

        

        public void grabarFicheroPaciente(Paciente p)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb = new StringBuilder();

            foreach (string txtName in Directory.EnumerateFiles(mydocpath, "*.txt"))
            {
                using (StreamReader sr = new StreamReader(txtName))
                {
                    sb.AppendLine(txtName.ToString());
                    sb.AppendLine("= = = = = =");
                    sb.Append(sr.ReadToEnd());
                    sb.AppendLine();
                    sb.AppendLine();
                }
            }

            using (StreamWriter outfile = new StreamWriter(mydocpath + @"\AllTxtFiles.txt"))
            {
                outfile.Write(sb.ToString());
            }
        }

        public  String toString(){
            return "Id:"+ this.identificacion+"\nNombre: "+this.nombre;
        }

    }
}