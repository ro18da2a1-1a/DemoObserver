using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using DemoObserver.Annotations;

namespace DemoObserver
{
    public class Person : INotifyPropertyChanged
    {
        private String _name;
        private String _addres;
        private String _telefon;

        public Person()
        {
        }

        public Person(string name, string addres, string telefon)
        {
            _name = name;
            _addres = addres;
            _telefon = telefon;
        }


        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Addres
        {
            get => _addres;
            set
            {
                _addres = value;
                OnPropertyChanged();
            }
        }

        public string Telefon
        {
            get => _telefon;
            set
            {
                _telefon = value;
                OnPropertyChanged();
            }
        }


        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Addres)}: {Addres}, {nameof(Telefon)}: {Telefon}";
        }

        // ObserverCollection
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
