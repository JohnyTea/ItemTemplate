using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemTemplate
{
    public class model : INotifyPropertyChanged
    {
        string nazwa;
        int cena;
        string obrazek;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public model(string nazwa, int cena, string obrazek)
        {
            Nazwa = nazwa;
            Cena = cena;
            Obrazek = obrazek;
        }

        public string Nazwa
        {
            get => nazwa; 
            set
            {
                nazwa = value;
                RaisePropertyChanged("Nazwa");
            }
        }
        public int Cena
        {
            get => cena; 
            set
            {
                cena = value;
                RaisePropertyChanged("Cena");
            }
        }
        public string Obrazek
        {
            get => obrazek; 
            set
            {
                obrazek = value;
                RaisePropertyChanged("Obrazek");
            }
        }

    }

}
