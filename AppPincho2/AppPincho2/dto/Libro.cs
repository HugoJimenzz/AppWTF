using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPincho2.dto
{
    public class Libro : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        private String titulo;
        public String Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Titulo"));
            }
        }

        private String autor;
        public String Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Autor"));
            }
        }

        private DateTime fecha;
        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Fecha"));
            }
        }       
        

        //CONSTRUCTOR LÑIBRO VACIO
        public Libro()
        {
            this.fecha = DateTime.Now;
        }

        //CONSTRUCTOR LIBRO DATOS
        public Libro(String titulo, String autor, DateTime fecha)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.fecha = fecha;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //CLONACION
        public object Clone()
        {
            //CLONA EL OBJETO Y TODOS SUS ATRIBUTOS
            return this.MemberwiseClone();
        }

        //VALIDACION
        public string Error
        {
            get { return ""; }
        }

        public string this[string columnName]
        {
            get 
            {
                String result = "";
                if(columnName == "Titulo")
                {
                    if (String.IsNullOrEmpty(titulo))
                    {
                        result = "Debe introducir Titulo";
                    }
                }

                if (columnName == "Autor")
                {
                    if (String.IsNullOrEmpty(autor))
                    {
                        result = "Debe introducir Autor";
                    }
                }

                return result;
            }

        }
    }
}
