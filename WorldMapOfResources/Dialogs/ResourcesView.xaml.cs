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
using System.Collections.ObjectModel;
using WorldMapOfResources.Model;
using WorldMapOfResources.Dialogs.Edit_Dialogs;

namespace WorldMapOfResources.Dialogs
{
    /// <summary>
    /// Interaction logic for ResourcesView.xaml
    /// </summary>
    public partial class ResourcesView : Window
    {
        public new ObservableCollection<Resource> Resources
        {
            get;
            set;
        }

        public ResourcesView()
        {
            InitializeComponent();
            this.DataContext = this;
            Resources = WindowResourcesDialog.Res_list;
        }



        private void Change_Click(object sender, RoutedEventArgs e)
        {
            WindowResourcesDialogEdit er = new WindowResourcesDialogEdit();
            er.ShowDialog();
        }




    }
}
