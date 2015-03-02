using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MainCore;

namespace interfaceIntroduccionDatos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
             
        } 
        
        private void grabarDatos(object sender, RoutedEventArgs e)
        {
            //Paciente paciente = new Paciente(txtidentificacion.Text, txtnombre.Text, txtedad.Text, txtsexo.Text, txtubicacion.Text, txtfechaRegistro.Text);
            //String mensaje = paciente.toString();
            //grabarFicheroPaciente(paciente);
            //MessageBox.Show( mensaje, "Grabar Datos");

            //Nueva instancia de N_Paciente
            N_Paciente nuevopaciente = new N_Paciente();
            //Nueva instancia de Metoods
            Metodos metodos = new Metodos();

            nuevopaciente.DNI = txtidentificacion.Text;
            nuevopaciente.Nombre = txtnombre.Text;
            nuevopaciente.Edad = Int32.Parse(txtedad.Text);
            if(rb_m.IsChecked == true)
            {
                nuevopaciente.Sexo = 1;
            }
            else if(rb_f.IsChecked == true)
            {
                nuevopaciente.Sexo = 2;
            }
            else
            {
                MessageBox.Show("Debe seleccionar el sexo del paciente");
                return;
            }
            nuevopaciente.Ubicacion = txtidentificacion.Text;



            if(metodos.NuevoPaciente(nuevopaciente))
            {
                MessageBox.Show("Paciente registrado con éxito");
                resetview();
            }
            else
            {
                MessageBox.Show("Error al registrar paciente");
            }

        }
        /// <summary>
        /// Resetea los controles en la ventana principal
        /// </summary>
        private void resetview()
        {     
            txtedad.Text = "";
            txtidentificacion.Text = "";
            txtnombre.Text = "";
            txtubicacion.Text = "";

            rb_f.IsChecked = false;
            rb_m.IsChecked = false;
        }

        private void grabarFicheroPaciente(Paciente paciente)
        {
            //try
            //{
            //    StringBuilder sb = new StringBuilder();
            //        sb.AppendLine(
            //            txtidentificacion.Text + ";" + 
            //            txtnombre.Text + ";" + 
            //            txtedad.Text + ";" +
            //            txtsexo.Text + ";" + 
            //            txtubicacion.Text + ";" + 
            //            txtfechaRegistro.Text + "\n");
                
            //    using (StreamWriter sw = new StreamWriter("Salida.txt", true))
            //    {

            //        sw.Write(sb.ToString());
            //        sw.Close();
            //    }
                
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("The file could not be read:");
            //    Console.WriteLine(e.Message);
            //}

        }
        private void leerFicheroPaciente(object sender, RoutedEventArgs a)
        {
            //try
            //{
            //    using (StreamReader sr = new StreamReader("TextFile1.txt"))
            //    {
                    

            //        String line = sr.ReadToEnd();
            //        String[] linea = line.Split(';');
            //        txtidentificacion.Text = linea[0];
            //        txtnombre.Text = linea[1];
            //        txtedad.Text = linea[2];
            //        txtsexo.Text = linea[3];
            //        txtubicacion.Text = linea[4];
            //        txtfechaRegistro.Text = linea[5];
            //        //Console.WriteLine(linea[1]);
            //        //Console.WriteLine(line);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("The file could not be read:");
            //    Console.WriteLine(e.Message);
            //}
        }

        private void buscarPaciente(object sender, RoutedEventArgs e)
        {
            //String idPaciente = txtidentificacion.Text;
            //Paciente paciente = new Paciente();
            //paciente = buscaPaciente(idPaciente);
            //Console.Write(paciente.toString());
            //txtidentificacion.Text = paciente.getIdentificacion();
            //txtnombre.Text = paciente.getNombre();
            //txtedad.Text = paciente.getEdad();
            //txtsexo.Text = paciente.getSexo();
            //txtubicacion.Text = paciente.getUbicacion();
            //txtfechaRegistro.Text = paciente.getFechaRegistro();
            //bGrabarPac.IsEnabled = false;
            //MessageBox.Show("OK", "Buscar Paciente");
        }

        //private Paciente buscaPaciente(String idPaciente)
        //{
        //    Paciente paciente = new Paciente();
        //    paciente.setIdentificacion(idPaciente);
        //    int counter = 0;
        //    string line;
        //    Paciente pac;

        //    // Read the file and display it line by line.
        //    StreamReader file = new StreamReader("Salida.txt");

        //    while ((line = file.ReadLine()) != null)
        //    {
        //        Console.WriteLine(line);
        //        String[] linea = line.Split(';');
                
        //        if (idPaciente.CompareTo(linea[0]) == 0)
        //        {
        //            if (linea[0]!=null)
        //            {
        //                //se pierde buscando el vacio!
        //                pac = new Paciente(linea[0], linea[1], linea[2], linea[3], linea[4], linea[5]);
        //                Console.Write(pac.toString());
        //                return pac;
        //            }
        //        }
        //        else
        //        {
        //            counter++;
        //        }


        //    }
        //    Console.Write(counter);

        //    file.Close();

        //    // buscar en base de datos el paciente
        //    return paciente;
        //}


        //private void grabarExploracionClinica(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("OK", "Exploracion");
        //}

    }
}
