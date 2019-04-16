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

namespace WorldMapOfResources.Dialogs.Edit_Dialogs
{
    /// <summary>
    /// Interaction logic for WindowEtiquetteDialogEdit.xaml
    /// </summary>
    public partial class WindowEtiquetteDialogEdit : Window,INotifyPropertyChanged
    {
        public static ObservableCollection<Etiquette> EtiquetteList = new ObservableCollection<Etiquette>();
        private string code;
        private string description;
        private Color color;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public WindowEtiquetteDialogEdit()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Etiquette et = new Etiquette(code, description, color);
            EtiquetteList.Add(et);
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

        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value != color)
                {
                    color = value;
                    OnPropertyChanged("Color");
                }
            }
        }

    }

}
