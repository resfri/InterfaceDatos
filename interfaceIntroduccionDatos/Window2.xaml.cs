using MainCore;
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

namespace interfaceIntroduccionDatos
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
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
            List<N_Imagenes> listaImagenes = new List<N_Imagenes>();

            if (metodo.ListarImagenes(listaImagenes))
            {
                grid_listado.ItemsSource = listaImagenes;

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
