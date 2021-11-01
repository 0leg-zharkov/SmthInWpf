using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SmthInWpf
{
    public class Player : INotifyPropertyChanged
    {
        private string name;
        private string type;
        private int level;
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string nameProp)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameProp));
        }

        public string Name
        {
            get => name;
            set
            {
                if (name == value) return;
                name = value;
                OnPropertyChanged("Name");
            }
        }


        public string Type
        {
            get => type;
            set
            {
                if (type == value) return;
                type = value;
                OnPropertyChanged("Type");
            }
        }


    }
}
