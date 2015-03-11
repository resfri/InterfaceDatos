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
using System.IO;

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

        private void borrar_registro(object sender, RoutedEventArgs e)
        {
            object Id = ((Button)sender).CommandParameter;
            Int32 miId = 0;
            miId = (Int32)Id;
            Metodos metodo = new Metodos();
            
            metodo.DeletePacienteID(miId);
            cargarDatos();
            
        }

        private Image devuelveImagen(String ruta)
        {
            Image img = new Image();
            byte[] imageBytes = LoadImageData(".\\"+ruta);
            ImageSource imageSource = CreateImage(imageBytes, 120, 0);
            img.Source = imageSource;
            return img;
        }

        private static byte[] LoadImageData(string filePath)
        {

            FileStream fs = new FileStream(filePath, FileMode.Open,

                FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            byte[] imageBytes = br.ReadBytes((int)fs.Length);

            br.Close();

            fs.Close();

            return imageBytes;

        }
        private static ImageSource CreateImage(byte[] imageData, int decodePixelWidth, int decodePixelHeight)
        {

            if (imageData == null) return null;
            BitmapImage result = new BitmapImage();
            result.BeginInit();

            if (decodePixelWidth > 0)
            {
                result.DecodePixelWidth = decodePixelWidth;
            }

            if (decodePixelHeight > 0)
            {
                result.DecodePixelHeight = decodePixelHeight;
            }

            result.StreamSource = new MemoryStream(imageData);
            result.CreateOptions = BitmapCreateOptions.None;
            result.CacheOption = BitmapCacheOption.Default;
            result.EndInit();
            return result;

        }
       
    }


}
