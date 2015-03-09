﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using MainCore;

namespace interfaceIntroduccionDatos
{
    /// <summary>
    /// Interaction logic for vetnala_listado.xaml
    /// </summary>
    public partial class vetnala_listado : Window
    {
        public vetnala_listado()
        {
            InitializeComponent();
            Loaded += MyWindow_Loaded;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cargarDatos();
        }

        private void MyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            cargarDatos();
        }
        private void cargarDatos()
        {
            Metodos metodo = new Metodos();
            List<N_Informe> listaInformes = new List<N_Informe>();

            if (metodo.listarInformes(listaInformes))
            {
                grid_listado.ItemsSource = listaInformes;

            }
            else
            {
                MessageBox.Show("Error al listar pacientes");
            }


        }

        private void Historias(object sender, RoutedEventArgs e)
        {
            Window1 win = new Window1();
            win.Show();
            //this.Close();
        }

       
    }


}
