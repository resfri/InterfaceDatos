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
using System.Runtime.InteropServices;

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

            if (txtidentificacion.Text.CompareTo(String.Empty) == 0)
            {
                estado.Content = "Error: Debe introducir el nombre del paciente";
                return;
            }
            else
            {
                nuevopaciente.DNI = txtidentificacion.Text;
            }
            if (txtnombre.Text.CompareTo(String.Empty) == 0)
            {
                estado.Content = "Error: Debe introducir el nombre del paciente";
                return;
            }
            else
            {
                nuevopaciente.Nombre = txtnombre.Text;
            }
            
            if (txtedad.Text.CompareTo(String.Empty)==0)
            {
                estado.Content = "Error: Debe introducir la edad";
                return;
            }
            else
            {
                nuevopaciente.Edad = Int32.Parse(txtedad.Text);
            }
            
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
                estado.Content = "Error: Debe seleccionar el sexo del paciente";
                return;
            }
            if (txtubicacion.Text.CompareTo(String.Empty) == 0)
            {
                estado.Content = "Error: Debe introducir la hubicacion";
                return;
            }
            else
            {
                nuevopaciente.Ubicacion = txtubicacion.Text;
            }
            //inicializa el odontograma de la historia, inicializa ParesAntagPerdidos y DientesPerdidos
            getHistoria(historia); // cambiar a inicializar historia recibiendo el vector¿?¿?
                        
            if(metodos.NuevoPaciente(nuevopaciente))
            {
                if (metodos.addHistoria(historia, nuevopaciente)) {
                        estado.Content = "Paciente registrado con éxito. " + "Historia registrada con éxito";
                }
                else
                {
                    estado.Content = "Error al registrar historia del paciente" + nuevopaciente.DNI;
                }
                resetview();
                
            }
            else
            {
                estado.Content = "Error al registrar paciente";
            }

        }

        /// <summary>
        /// Captura de la vista los datos del odontograma, contarDientesPerdidos, contarParesAntagPerdidos 
        /// </summary>
        private void getHistoria(N_Historia historia)
        {
            String[] odontograma = new String[32];
            String res = "";
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
                    for (Int32 i=0; i<32; i++){
                        res = res + odontograma[i];
                    }
                    Console.Write(res);
                    historia.Odontograma = res;
            
        }


        /// <summary>
        /// Resetea los controles en la ventana principal
        /// </summary>
        private void resetview()
        {
            try
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

                byte[] imageBytes = LoadImageData("./Images/empty.jpg");
                ImageSource imageSource = CreateImage(imageBytes, 120, 0);
                imagen.Source = imageSource ;

                rutaImagen.Content = "";

                labelNDP.Content = "";
                labelNPP.Content = "";
            }
            catch (Exception e)
            {
                Console.Write("Error " + e);
            }
            


        }


        /// <summary>
        /// Genera fichero de texto plano con los datos de los pacientes
        /// </summary>
        /// <param name="paciente"></param>
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

        /// <summary>
        /// Desde fichero de texto plano incorpora los datos de los pacientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="a"></param>
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

        /// <summary>
        /// Ejecuta la busqueda del paciente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buscarPaciente(object sender, RoutedEventArgs e)
        {

            if (txtidentificacion.Text.CompareTo("")!=0)
            {
                Metodos metodos = new Metodos();
                N_Paciente paciente = new N_Paciente();
                N_Historia historia = new N_Historia();
                paciente.DNI = txtidentificacion.Text;

                if (metodos.getPacienteDNI(paciente.DNI, paciente))
                {
                    pintaPaciente(paciente);
                    if (metodos.getHistoriaId(paciente.Id, historia))
                    {
                        pintaHistoria(historia);
                    }
                }
                else
                {
                    estado.Content = "Error: Paciente no encontrado.";
                }
            }
            else
            {
                estado.Content = "Error: Para buscar debes introducir la Identificación.";
                return;
            }
        }

        /// <summary>
        /// Pinta en el inteface los valores de la histira clinica
        /// </summary>
        /// <param name="historia"></param>
        private void pintaHistoria(N_Historia historia)
        {
            String odontograma = historia.Odontograma;
            labelNDP.Content = "DP: "+historia.NumeroDientesPerdidos;
            labelNPP.Content = "PA: "+ historia.ParesAntagPerdidos;
            pintaOdontograma(odontograma);            
        }

        /// <summary>
        /// Pinta en el interface los valores del odontograma
        /// </summary>
        /// <param name="odont"></param>
        private void pintaOdontograma(String odont)
        {
            Int32 longitud = odont.Length;
            longitud = 32;
            String[] odontograma = new String[32];

            Console.Write("longitud: " + longitud+"\n");
            Console.Write("odont: " + odont + "\n");
            Console.Write("odontograma: " + odontograma + "\n");
            
            Char[] temp = odont.ToCharArray();

            
            for (Int32 i = 0; i < longitud; i++)
            {
                odontograma[i] = temp[i].ToString();
                Console.Write(temp[i].ToString());
            }
            if (odontograma == null) { } else { 
            if (odontograma[0].CompareTo("F")==0)
            {
                this.D11.IsChecked = false;
            }
            if (odontograma[1].CompareTo("F") == 0)
            {
                this.D12.IsChecked = false;
            }
            if (odontograma[2].CompareTo("F") == 0)
            {
                this.D13.IsChecked = false;
            }
            if (odontograma[3].CompareTo("F") == 0)
            {
                this.D14.IsChecked = false;
            }
            if (odontograma[4].CompareTo("F") == 0)
            {
                this.D15.IsChecked = false;
            }
            if (odontograma[5].CompareTo("F") == 0)
            {
                this.D16.IsChecked = false;
            }
            if (odontograma[6].CompareTo("F") == 0)
            {
                this.D17.IsChecked = false;
            }
            if (odontograma[7].CompareTo("F") == 0)
            {
                this.D18.IsChecked = false;
            }
            //
            if (odontograma[8].CompareTo("F") == 0)
            {
                this.D21.IsChecked = false;
            }
            if (odontograma[9].CompareTo("F") == 0)
            {
                this.D22.IsChecked = false;
            }
            if (odontograma[10].CompareTo("F") == 0)
            {
                this.D23.IsChecked = false;
            }
            if (odontograma[11].CompareTo("F") == 0)
            {
                this.D24.IsChecked = false;
            }
            if (odontograma[12].CompareTo("F") == 0)
            {
                this.D25.IsChecked = false;
            }
            if (odontograma[13].CompareTo("F") == 0)
            {
                this.D26.IsChecked = false;
            }
            if (odontograma[14].CompareTo("F") == 0)
            {
                this.D27.IsChecked = false;
            }
            
            if (odontograma[15].CompareTo("F") == 0)
            {
                this.D28.IsChecked = false;
            }
            //
            if (odontograma[16].CompareTo("F") == 0)
            {
                this.D31.IsChecked = false;
            }
            if (odontograma[17].CompareTo("F") == 0)
            {
                this.D32.IsChecked = false;
            }
            if (odontograma[18].CompareTo("F") == 0)
            {
                this.D33.IsChecked = false;
            }
            if (odontograma[19].CompareTo("F") == 0)
            {
                this.D34.IsChecked = false;
            }
            if (odontograma[20].CompareTo("F") == 0)
            {
                this.D35.IsChecked = false;
            }
            if (odontograma[21].CompareTo("F") == 0)
            {
                this.D36.IsChecked = false;
            }
            if (odontograma[22].CompareTo("F") == 0)
            {
                this.D37.IsChecked = false;
            }
            if (odontograma[23].CompareTo("F") == 0)
            {
                this.D38.IsChecked = false;
            }
            if (odontograma[24].CompareTo("F") == 0)
            {
                this.D41.IsChecked = false;
            }
            if (odontograma[25].CompareTo("F") == 0)
            {
                this.D42.IsChecked = false;
            }
            if (odontograma[26].CompareTo("F") == 0)
            {
                this.D43.IsChecked = false;
            }
            if (odontograma[27].CompareTo("F") == 0)
            {
                this.D44.IsChecked = false;
            }
            if (odontograma[28].CompareTo("F") == 0)
            {
                this.D45.IsChecked = false;
            }
            if (odontograma[29].CompareTo("F") == 0)
            {
                this.D46.IsChecked = false;
            }
            if (odontograma[30].CompareTo("F") == 0)
            {
                this.D47.IsChecked = false;
            }
            if (odontograma[31].CompareTo("F") == 0)
            {
                this.D48.IsChecked = false;
            }
            }
            

        }

        /// <summary>
        /// Pinta en el interface los datos del paciente
        /// </summary>
        /// <param name="paciente"></param>
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

        /// <summary>
        /// Abre ventana donde visualizar los datos almacenados en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonGeneraListado(object sender, RoutedEventArgs e)
        {
            vetnala_listado win = new vetnala_listado();
            win.Show();
            //this.Close();
        }

        private void botonRecuperaImagenPortapapeles(object sender, RoutedEventArgs e)
        {
            //WindowsClipboard win = new WindowsClipboard();
            //win.Show();
            //this.Close();

            if (Clipboard.ContainsImage())
            {   if (txtidentificacion.Text.CompareTo("") == 0)
                {  
                    estado.Content = "Debes introducir los datos del paciente";
                    return;
                }
                else
                {
                    byte[] imageBytes = LoadImageData(@"c:\temp\MyImage.jpg");
                    
                    // decode the image such that its width is 120 and its 
                    // height is scaled proportionally
                    ImageSource imageSource = CreateImage(imageBytes, 120, 0);

                    //Console.Write("Paso por getImage");
                    imageSource = ImageFromClipboardDib();
                    imageBytes = GetEncodedImageData(imageSource, ".jpg");

                    //SaveImageData(imageBytes, @"c:\temp\MyResizedImage.jpg");
                    imagen.Source = imageSource;
                    SaveImageData(imageBytes, "./muestras/"+this.txtidentificacion.Text+".jpg");
                    //rutaImagen.Content = "/muestras/"+this.txtidentificacion.Text + ".jpg";

                    


                }
            }
            else
            {
                estado.Content= "Portapapales vacio";
            }
            
            
        }

        internal byte[] GetEncodedImageData(ImageSource image, string preferredFormat)
        {

            byte[] result = null;
            BitmapEncoder encoder = null;

            switch (preferredFormat.ToLower())
            {
                case ".jpg":
                case ".jpeg":
                    encoder = new JpegBitmapEncoder();
                    break;
                case ".bmp":
                    encoder = new BmpBitmapEncoder();
                    break;
                case ".png":
                    encoder = new PngBitmapEncoder();
                    break;
                case ".tif":
                case ".tiff":
                    encoder = new TiffBitmapEncoder();
                    break;
                case ".gif":
                    encoder = new GifBitmapEncoder();
                    break;
                case ".wmp":
                    encoder = new WmpBitmapEncoder();
                    break;
            }

            if (image is BitmapSource)
            {
                MemoryStream stream = new MemoryStream();
                encoder.Frames.Add(BitmapFrame.Create(image as BitmapSource));
                encoder.Save(stream);
                stream.Seek(0, SeekOrigin.Begin);
                result = new byte[stream.Length];
                BinaryReader br = new BinaryReader(stream);
                br.Read(result, 0, (int)stream.Length);
                br.Close();
                stream.Close();
            }
            return result;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        private struct BITMAPFILEHEADER
        {
            public static readonly short BM = 0x4d42; // BM

            public short bfType;
            public int bfSize;
            public short bfReserved1;
            public short bfReserved2;
            public int bfOffBits;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct BITMAPINFOHEADER
        {
            public int biSize;
            public int biWidth;
            public int biHeight;
            public short biPlanes;
            public short biBitCount;
            public int biCompression;
            public int biSizeImage;
            public int biXPelsPerMeter;
            public int biYPelsPerMeter;
            public int biClrUsed;
            public int biClrImportant;
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


        public static class BinaryStructConverter
        {
            public static T FromByteArray<T>(byte[] bytes) where T : struct
            {
                IntPtr ptr = IntPtr.Zero;
                try
                {
                    int size = Marshal.SizeOf(typeof(T));
                    ptr = Marshal.AllocHGlobal(size);
                    Marshal.Copy(bytes, 0, ptr, size);
                    object obj = Marshal.PtrToStructure(ptr, typeof(T));
                    return (T)obj;
                }
                finally
                {
                    if (ptr != IntPtr.Zero)
                        Marshal.FreeHGlobal(ptr);
                }
            }

            public static byte[] ToByteArray<T>(T obj) where T : struct
            {
                IntPtr ptr = IntPtr.Zero;
                try
                {
                    int size = Marshal.SizeOf(typeof(T));
                    ptr = Marshal.AllocHGlobal(size);
                    Marshal.StructureToPtr(obj, ptr, true);
                    byte[] bytes = new byte[size];
                    Marshal.Copy(ptr, bytes, 0, size);
                    return bytes;
                }
                finally
                {
                    if (ptr != IntPtr.Zero)
                        Marshal.FreeHGlobal(ptr);
                }
            }
        }
        private ImageSource ImageFromClipboardDib()
        {
            MemoryStream ms = Clipboard.GetData("DeviceIndependentBitmap") as MemoryStream;
            if (ms != null)
            {
                byte[] dibBuffer = new byte[ms.Length];
                ms.Read(dibBuffer, 0, dibBuffer.Length);

                BITMAPINFOHEADER infoHeader =
                    BinaryStructConverter.FromByteArray<BITMAPINFOHEADER>(dibBuffer);

                int fileHeaderSize = Marshal.SizeOf(typeof(BITMAPFILEHEADER));
                int infoHeaderSize = infoHeader.biSize;
                int fileSize = fileHeaderSize + infoHeader.biSize + infoHeader.biSizeImage;

                BITMAPFILEHEADER fileHeader = new BITMAPFILEHEADER();
                fileHeader.bfType = BITMAPFILEHEADER.BM;
                fileHeader.bfSize = fileSize;
                fileHeader.bfReserved1 = 0;
                fileHeader.bfReserved2 = 0;
                fileHeader.bfOffBits = fileHeaderSize + infoHeaderSize + infoHeader.biClrUsed * 4;

                byte[] fileHeaderBytes =
                    BinaryStructConverter.ToByteArray<BITMAPFILEHEADER>(fileHeader);

                MemoryStream msBitmap = new MemoryStream();
                msBitmap.Write(fileHeaderBytes, 0, fileHeaderSize);
                msBitmap.Write(dibBuffer, 0, dibBuffer.Length);
                msBitmap.Seek(0, SeekOrigin.Begin);

                return BitmapFrame.Create(msBitmap);
            }
            return null;
        }

        private static void SaveImageData(byte[] imageData, string filePath)
        {

            FileStream fs = new FileStream(filePath, FileMode.Create,

                FileAccess.Write);

            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(imageData);

            bw.Close();

            fs.Close();

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
