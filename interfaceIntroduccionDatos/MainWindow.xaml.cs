﻿using System;
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
            N_Historia historia = new N_Historia();
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
            //inicializa el odontograma de la historia, inicializa ParesAntagPerdidos y DientesPerdidos
            getHistoria(historia); // cambiar a inicializar historia recibiendo el vector¿?¿?

            
            if(metodos.NuevoPaciente(nuevopaciente))
            {
                                      
                    MessageBox.Show("Paciente registrado con éxito");
                    
                    if (metodos.addHistoria(historia, nuevopaciente)) {
                        MessageBox.Show("Historia registrada con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar historia del paciente"+ nuevopaciente.DNI);
                    }
                    resetview();
                
            }
            else
            {
                MessageBox.Show("Error al registrar paciente");
            }

        }

        /// <summary>
        /// Captura de la vista los datos del odontograma, contarDientesPerdidos, contarParesAntagPerdidos 
        /// </summary>
        private void getHistoria(N_Historia historia)
        {
            String[] odontograma = new String[32];
            N_Paciente paciente = new N_Paciente();
            Metodos metodos = new Metodos();
                        
                    for (Int32 i = 0; i <= 31; i++)
                    {
                        odontograma[i] = "T";
                    }
                    if (D11.IsChecked == false)
                    {
                        odontograma[0] = "F";
                    }
                    if (D12.IsChecked==false){
                        odontograma[1] = "F";
                    }
                    if (D13.IsChecked == false)
                    {
                        odontograma[2] = "F";
                    }
                    if (D14.IsChecked == false)
                    {
                        odontograma[3] = "F";
                    }
                    if (D15.IsChecked == false)
                    {
                        odontograma[4] = "F";
                    }
                    if (D16.IsChecked == false)
                    {
                        odontograma[5] = "F";
                    }
                    if (D17.IsChecked == false)
                    {
                        odontograma[6] = "F";
                    }
                    if (D18.IsChecked == false)
                    {
                        odontograma[7] = "F";
                    }
                    //
                    if (D21.IsChecked == false)
                    {
                        odontograma[8] = "F";
                    }
                    if (D22.IsChecked == false)
                    {
                        odontograma[9] = "F";
                    }
                    if (D23.IsChecked == false)
                    {
                        odontograma[10] = "F";
                    }
                    if (D24.IsChecked == false)
                    {
                        odontograma[11] = "F";
                    }
                    if (D25.IsChecked == false)
                    {
                        odontograma[12] = "F";
                    }
                    if (D26.IsChecked == false)
                    {
                        odontograma[13] = "F";
                    }
                    if (D27.IsChecked == false)
                    {
                        odontograma[14] = "F";
                    }
                    if (D28.IsChecked == false)
                    {
                        odontograma[15] = "F";
                    }
                    //
                    if (D31.IsChecked == false)
                    {
                        odontograma[16] = "F";
                    }
                    if (D32.IsChecked == false)
                    {
                        odontograma[17] = "F";
                    }
                    if (D33.IsChecked == false)
                    {
                        odontograma[18] = "F";
                    }
                    if (D34.IsChecked == false)
                    {
                        odontograma[19] = "F";
                    }
                    if (D35.IsChecked == false)
                    {
                        odontograma[20] = "F";
                    }
                    if (D36.IsChecked == false)
                    {
                        odontograma[21] = "F";
                    }
                    if (D37.IsChecked == false)
                    {
                        odontograma[22] = "F";
                    }
                    if (D38.IsChecked == false)
                    {
                        odontograma[23] = "F";
                    }
                    //
                    if (D41.IsChecked == false)
                    {
                        odontograma[24] = "F";
                    }
                    if (D42.IsChecked == false)
                    {
                        odontograma[25] = "F";
                    }
                    if (D43.IsChecked == false)
                    {
                        odontograma[26] = "F";
                    }
                    if (D44.IsChecked == false)
                    {
                        odontograma[27] = "F";
                    }
                    if (D45.IsChecked == false)
                    {
                        odontograma[28] = "F";
                    }
                    if (D46.IsChecked == false)
                    {
                        odontograma[29] = "F";
                    }
                    if (D47.IsChecked == false)
                    {
                        odontograma[30] = "F";
                    }
                    if (D48.IsChecked == false)
                    {
                        odontograma[31] = "F";
                    }
                    historia.NumeroDientesPerdidos = metodos.contarDientesPerdidos(odontograma);
                    historia.ParesAntagPerdidos = metodos.contarParesAntagPerdidos(odontograma);
                    historia.Odontograma = odontograma.ToString();
            
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

            D11.IsChecked = true; D12.IsChecked = true; D13.IsChecked = true; D14.IsChecked = true;
            D15.IsChecked = true; D16.IsChecked = true; D17.IsChecked = true; D18.IsChecked = true;

            D21.IsChecked = true; D22.IsChecked = true; D23.IsChecked = true; D24.IsChecked = true;
            D25.IsChecked = true; D26.IsChecked = true; D27.IsChecked = true; D28.IsChecked = true;

            D31.IsChecked = true; D32.IsChecked = true; D33.IsChecked = true; D34.IsChecked = true;
            D35.IsChecked = true; D36.IsChecked = true; D37.IsChecked = true; D38.IsChecked = true;

            D41.IsChecked = true; D42.IsChecked = true; D43.IsChecked = true; D44.IsChecked = true;
            D45.IsChecked = true; D46.IsChecked = true; D47.IsChecked = true; D48.IsChecked = true;

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
            Metodos metodos = new Metodos();
            N_Paciente paciente = new N_Paciente();
            N_Historia historia = new N_Historia();
            paciente.DNI = txtidentificacion.Text;

            if( metodos.getPacienteId(paciente.DNI,paciente)){
                pintaPaciente(paciente);
                if(metodos.getHistoriaId(paciente.Id, historia)){

                }
                pintaHistoria(historia);
            }else{
                MessageBox.Show("Error al registrar paciente");
            }

            
        }

        private void pintaHistoria(N_Historia historia)
        {
            String odontograma = historia.Odontograma;

            
        }

        private void pintaPaciente(N_Paciente paciente)
        {
            txtedad.Text = paciente.Edad.ToString();
            txtidentificacion.Text = paciente.DNI;
            txtnombre.Text = paciente.Nombre;
            txtubicacion.Text = paciente.Ubicacion;

            if(paciente.Sexo==1){
                rb_f.IsChecked = false;
                rb_m.IsChecked = true;
            }
            else if (paciente.Sexo==2){
                rb_f.IsChecked = true;
                rb_m.IsChecked = false;
            }
            else
            {
                rb_f.IsChecked = false;
                rb_m.IsChecked = false;
            }

            
        }


    }
}
