using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WorldMapOfResources.Dialogs.Edit_Dialogs;
using WorldMapOfResources.Model;

namespace WorldMapOfResources.Dialogs
{
    /// <summary>
    /// Interaction logic for EtiquetteView.xaml
    /// </summary>
    public partial class EtiquetteView : Window
    {

        public new ObservableCollection<Etiquette> Etiquettes
        {
            get;
            set;
        }

        public EtiquetteView()
        {
            InitializeComponent();
            this.DataContext = this;
            Etiquettes = WindowEtiquetteDialog.EtiquetteList;
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            WindowEtiquetteDialogEdit ee = new WindowEtiquetteDialogEdit();
            ee.ShowDialog();
        }
    }
}
