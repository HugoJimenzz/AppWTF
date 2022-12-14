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
using System.Windows.Shapes;

namespace AppPincho2
{
    /// <summary>
    /// Lógica de interacción para DialogoLibro.xaml
    /// </summary>
    public partial class DialogoLibro : Window
    {
        private LogicaNegocio logicaNegocio;
        public Libro libro;
        private int posicion;
        private Boolean modificar;
        private int errores;

        public DialogoLibro(LogicaNegocio logicaNegocio)
        {
            InitializeComponent();
            this.logicaNegocio= logicaNegocio;
            libro = new Libro();
            this.DataContext= libro;
            modificar= false;
        }

        //DOS CONSTRUCTORES CON MISMO NOMBRE PERO DIFERENTES PARAMETROS SE LLAMAN SOBRECARGADOS
        public DialogoLibro(LogicaNegocio logicaNegocio, Libro libroModificar, int posicion)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            this.libro= libroModificar;
            this.posicion = posicion;
            this.DataContext = libro;
            modificar = true;
        }

        //CERRAMOS EL DIALOGO
        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //EN EL BOTON DE ACEPTAR COMPROBAMOS SI ES UN REGISTRO NUEVO O ESTAMOS MODIFICANDO UNO EXISTENTE
        private void btAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (modificar)
            {
                logicaNegocio.modificarLibro(libro, posicion);
            }
            else
            {
                logicaNegocio.anadirLibro(libro);
            }
            this.Close();
        }

        //COMPROBAMOS SI HAY FALLOS PARA DESACTIVAR EL BOTON
        private void Validation_Error(Object sender, ValidationErrorEventArgs e)
        {
            if(e.Action == ValidationErrorEventAction.Added)
            {
                errores++;
            }
            else
            {
                errores--;
            }

            if(errores == 0)
            {
                btAceptar.IsEnabled = true;
            }
            else
            {
                btAceptar.IsEnabled = false;
            }
        }
    }
}
