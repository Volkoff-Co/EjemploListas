using System.Collections.ObjectModel;
using System.ComponentModel;

namespace EjemploListas
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private Persona personaActual;

        private ObservableCollection<Persona> personas;

        public MainWindowVM()
        {
            personas = new ObservableCollection<Persona>();
            personas.Add(new Persona("Gregory", 22));
            personas.Add(new Persona("Alejandro", 21));
            personas.Add(new Persona("Salvador", 23));
        }
        public ObservableCollection<Persona> Personas
        {
            get { return personas; }
            set
            {
                personas = value;
                NotifyPropertyChanged("Personas");
            }
        }

        public Persona PersonaActual
        {
            get { return personaActual; }
            set {
                personaActual = value;
                NotifyPropertyChanged("PersonaActual");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
