using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploListas
{
    class Persona: INotifyPropertyChanged
    {
        private string _nombre;
        public string Nombre
        {
            get { return this._nombre; }
            set
            {
                if (this._nombre != value)
                {
                    this._nombre = value;
                    this.NotifyPropertyChanged("Nombre");
                }
            }
        }

        private int _edad;
        public int Edad
        {
            get { return this._edad; }
            set
            {
                if (this._edad != value)
                {
                    this._edad = value;
                    this.NotifyPropertyChanged("Edad");
                }
            }
        }
        public Persona()
        {
            Nombre = "";
            Edad = 0;
        }
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
