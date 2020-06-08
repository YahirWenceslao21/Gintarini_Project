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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;



namespace Gintariny_Proyect
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

        private void btn_Cerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btn_BuscarArchivo_Click(object sender, RoutedEventArgs e)
        {
            //Codigo para abrir un archivo utilizando el explorador de archivos de windows
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)
                    Ruta_Destino.Text = filename;
            }
        }

        private void btn_BuscarCarpeta_Click(object sender, RoutedEventArgs e)
        {
            //var dialog = new System.Windows.Forms.FolderBrowserDialog();
            //System.Windows.Forms.DialogResult Result = dialog.ShowDialog();
            //Exportar_destino.Text = dialog.SelectedPath;
        }

        private void btn_WindowMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
