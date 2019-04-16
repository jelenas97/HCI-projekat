using System;
using System.Collections.Generic;
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
using System.ComponentModel;
using WorldMapOfResources.Model;
using System.Collections.ObjectModel;

namespace WorldMapOfResources
{
    /// <summary>
    /// Interaction logic for WindowResourcesDialog.xaml
    /// </summary>
    public partial class WindowResourcesDialog : Window, INotifyPropertyChanged

    {
        public static ObservableCollection<Resource> Res_list = new ObservableCollection<Resource>();
        private string code;
        private string type;
        private string renewable;
        private string mark;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        
        private double _test1;
        private LetterValid _test2;
        

        public double Test1
        {
            get
            {
                return _test1;
            }
            set
            {
                if (value != _test1)
                {
                    _test1 = value;
                    OnPropertyChanged("Test1");
                }
            }
        }

        public LetterValid Test2
        {
            get
            {
                return _test2;
            }
            set
            {
                if (value != _test2)
                {
                    _test2 = value;
                    OnPropertyChanged("Test2");
                }
            }
        }

        public WindowResourcesDialog()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Resource res = new Resource(code,mark,type,renewable);
            Res_list.Add(res);
            this.Close();
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
                return renewable;
            }
            set
            {
                if (value != renewable)
                {
                    renewable = value;
                    OnPropertyChanged("Renewability");
                }
            }
        }

        private void LoadSunce(object sender, RoutedEventArgs e)
        {
            Uri myUri = new Uri("sunce.jpg", UriKind.RelativeOrAbsolute);
            JpegBitmapDecoder decoder2 = new JpegBitmapDecoder(myUri, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
            BitmapSource bitmapSource2 = decoder2.Frames[0];

            // Draw the Image
            Loaded.Source = bitmapSource2;
            Loaded.Stretch = Stretch.Uniform;
            Loaded.Margin = new Thickness(20);
        }

        private void LoadNafta(object sender, RoutedEventArgs e)
        {
            Uri myUri = new Uri("nafta.jpg", UriKind.RelativeOrAbsolute);
            JpegBitmapDecoder decoder2 = new JpegBitmapDecoder(myUri, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
            BitmapSource bitmapSource2 = decoder2.Frames[0];

            // Draw the Image
            Loaded.Source = bitmapSource2;
            Loaded.Stretch = Stretch.Uniform;
            Loaded.Margin = new Thickness(20);
        }

        private void LoadAuto(object sender, RoutedEventArgs e)
        {
            Uri myUri = new Uri("auto.jpg", UriKind.RelativeOrAbsolute);
            JpegBitmapDecoder decoder2 = new JpegBitmapDecoder(myUri, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
            BitmapSource bitmapSource2 = decoder2.Frames[0];

            // Draw the Image
            Loaded.Source = bitmapSource2;
            Loaded.Stretch = Stretch.Uniform;
            Loaded.Margin = new Thickness(20);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}

