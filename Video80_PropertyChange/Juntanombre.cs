using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video80_PropertyChange
{
    public class Juntanombre: INotifyPropertyChanged
    {
        private string nombre, apellido, nombre_apellido;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;

                OnPropertyChanged("Nombre_Apellido");
            }

            
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value;
                OnPropertyChanged("Nombre_Apellido");
            }
        }

        public string Nombre_Apellido
        {
            get { nombre_apellido= Nombre + " " + Apellido;
                return nombre_apellido;
            }
            set { OnPropertyChanged("Nombre"); }
        }
    }
}
