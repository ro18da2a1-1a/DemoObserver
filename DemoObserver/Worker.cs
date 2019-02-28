using System;
using System.ComponentModel;

namespace DemoObserver
{
    internal class Worker
    {
        public Worker()
        {
        }

        public void Start()
        {
            Person p = new Person("peter","Sorø","33445566");

            p.PropertyChanged += (sender, args) => { Console.WriteLine("Person ændret er nu " + p); };

            p.Addres = "Roskilde";

            p.PropertyChanged += POnPropertyChanged;

            p.Telefon = "33221199";

            p.Addres = "Næstved";

            p.PropertyChanged -= POnPropertyChanged;

            p.Telefon = "23456789";

        }

        private void POnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine("Person property ændret " + e.PropertyName);
        }
    }
}