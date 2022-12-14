using AppPincho2.dto;
using AppPincho2.Logica;
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

namespace AppPincho2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LogicaNegocio logicaNegocio;

        public MainWindow()
        {
            InitializeComponent();
            logicaNegocio= new LogicaNegocio();
            //BINDING EN CODIGO 
            DataGridLibro.DataContext = logicaNegocio;
        }

        //ABRIMOS EL DIALOGO
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            DialogoLibro dialogoLibro= new DialogoLibro(logicaNegocio);
            dialogoLibro.ShowDialog();
        }

        private void btModificar_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridLibro.SelectedIndex != -1)
            {
                //SE ACTUALIZA AL SEGUNDO Y SI CANCELAS SE QUEDA LA MODIFICACION, HAY QUE HACERLO CLONABLE
                Libro libro = (Libro)DataGridLibro.SelectedItem;
                DialogoLibro dialogoLibro = new DialogoLibro(logicaNegocio,(Libro)libro.Clone(),DataGridLibro.SelectedIndex);
                dialogoLibro.ShowDialog();  
            }                       
        }
    }
}
