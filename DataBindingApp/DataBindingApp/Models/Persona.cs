using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBindingApp.Models
{
    public class Persona : INotifyPropertyChanged
    {
        private string name;
        private string phone;
        private string address;

        public string Name
        {
            get => name; set
            {
                name = value;
                onPropertyChanged();
            }
        }

        public string Phone
        {
            get => phone; set
            {
                phone = value;
                onPropertyChanged();
            }
        }

        public string Address
        {
            get => address; set
            {
                address = value;
                onPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void onPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

    }


}

