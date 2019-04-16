using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WorldMapOfResources.Model;

namespace WorldMapOfResources.Dialogs
{
    /// <summary>
    /// Interaction logic for WindowResourceTypeDialog.xaml
    /// </summary>
    public partial class WindowResourceTypeDialog : Window,INotifyPropertyChanged

    {
        public static ObservableCollection<TypeResource> TypeList = new ObservableCollection<TypeResource>();
        private string code;
        private string description;
        private string name;
        private string path;
        private Image img = new Image();


        public WindowResourceTypeDialog()
        {
            InitializeComponent();
            this.DataContext = this;
            img.Source = Image.Source; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog opd = new OpenFileDialog();
            opd.DefaultExt = ".ico";
            opd.Filter = "JPEG files(*.jpeg)|*.jpeg|JPG files (*.jpg)|*.jpg|PNG files(*.png)|*.png";
            Nullable<bool> dialogOk = opd.ShowDialog();

            if (dialogOk == true)
            {
                string filePath = opd.FileName;
                txtIcon.Text = filePath;
                Image.Source = new BitmapImage(new Uri(opd.FileName));
                img.Source = Image.Source;
            }
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TypeResource tr = new TypeResource(code, description, name,img,img.Source.ToString());
            TypeList.Add(tr);
            this.Close();
        }

        private void Image_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
