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
using WIA;
using System.IO;

namespace interfaceIntroduccionDatos
{
    /// <summary>
    /// Interaction logic for VentanaScan.xaml
    /// </summary>
    public partial class VentanaScan : Window
    {
        public VentanaScan()
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
            Devices.Items.Clear();
            var deviceManager = new DeviceManager();
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    return;
                }
                Devices.Items.Add(new Scanner(deviceManager.DeviceInfos[i]));
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var device = Devices.SelectedItem as Scanner;
            if (device == null)
            {
                MessageBox.Show("Please select a device.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            var image = device.Scan();
            var path = @"c:\scan.jpeg";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            try
            {
                image.SaveFile(path);
                BitmapImage BImage = new BitmapImage(new Uri(path, UriKind.Absolute));
                img.Source = BImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }    
    }
}
