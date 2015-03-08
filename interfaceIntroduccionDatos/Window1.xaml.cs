using System;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
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
            List<N_Historia> listaHistorias = new List<N_Historia>();

            if (metodo.ListarHistorias(listaHistorias))
            {
                grid_listado.ItemsSource = listaHistorias;

            }
            else
            {
                MessageBox.Show("Error al listar Historias");
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }
    }
}
