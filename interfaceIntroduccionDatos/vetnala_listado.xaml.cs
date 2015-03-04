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
    /// Interaction logic for vetnala_listado.xaml
    /// </summary>
    public partial class vetnala_listado : Window
    {
        public vetnala_listado()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Metodos metodo = new Metodos();
            List<N_Paciente> listaPacientes = new List<N_Paciente>();

            if(metodo.ListarPacients(listaPacientes))
            {
                grid_listado.ItemsSource = listaPacientes;

            }
            else
            {
                MessageBox.Show("Error al listar pacientes");
            }
        }
    }
}
