using AppPincho2.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPincho2.Logica
{
    public class LogicaNegocio
    {
        public ObservableCollection<Libro> listaLibros { get; set; }

        public LogicaNegocio() 
        {
            listaLibros= new ObservableCollection<Libro>();
            listaLibros.Add(new Libro("Un titulo", "Manoliro", DateTime.Now));
        }

        public void anadirLibro(Libro libro)
        {
            listaLibros.Add(libro);
        }

        public void modificarLibro(Libro libro,int posicion)
        {
            listaLibros[posicion] = libro;
        }
    }
}
