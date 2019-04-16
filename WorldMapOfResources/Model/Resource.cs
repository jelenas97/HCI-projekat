using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WorldMapOfResources.Model
{
   public class Resource : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        private string code;
        private string mark;
        private string type;
        private string renewability;

        public Resource(string code, string mark, string type, string renewability)
        {
            this.code = code;
            this.mark = mark;
            this.type = type;
            this.renewability = renewability;
        }



        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                if (value != code)
                {
                    code = value;
                    OnPropertyChanged("Code");
                }
            }
        }

        public string Mark
        {
            get
            {
                return mark;
            }
            set
            {
                if (value != mark)
                {
                    mark = value;
                    OnPropertyChanged("Mark");
                }
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value != type)
                {
                    type = value;
                    OnPropertyChanged("Type");
                }
            }
        }

        public string Renewability
        {
            get
            {
                return renewability;
            }
            set
            {
                if (value != renewability)
                {
                    renewability = value;
                    OnPropertyChanged("Renewability");
                }
            }
        }

        
    }
}

