using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormPropertyBindings
{
    class Class1 : INotifyPropertyChanged
    {
        private string _myStr;

        public string MyStr 
        {
            get { return _myStr; } 
            set 
            {
                //if(_myStr != value)
                if (value == MyStr) return;
                _myStr = value;
                OnPropertyChanged("MyStr");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
