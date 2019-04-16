using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Controls;

namespace WorldMapOfResources.Model
{
    public class TypeResource : INotifyPropertyChanged
    {
        private string code;
        private string description;
        private string name;
        private string path;
        private Image img;



        public TypeResource(string code, string description, string name,Image img,string path)
        {
            this.code = code;
            this.description = description;
            this.name = name;
            this.img = img;
            this.path = path;
                
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

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value != description)
                {
                    description = value;
                    OnPropertyChanged("Description");
                }
            }
        }

        public string Names
        {
            get
            {
                return name;
            }
            set
            {
                if (value != name)
                {
                    name = value;
                    OnPropertyChanged("Names");
                }
            }
        }

        public Image TImage
        {
            get
            {
                return img;
            }
            set
            {
                if (value != img)
                {
                    img = value;
                    OnPropertyChanged("TImage");
                }
            }

        }
        public string TPath
        {
            get
            {
                return path;
            }
            set
            {
                if (value != path)
                {
                    path = value;
                    OnPropertyChanged("TPath");
                }
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
