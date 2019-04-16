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
    /// Interaction logic for TypeView.xaml
    /// </summary>
    public partial class TypeView : Window
    {
        public new ObservableCollection<TypeResource> Types
        {
            get;
            set;
        }

        public TypeView()
        {
            InitializeComponent();
            this.DataContext = this;
            Types = WindowResourceTypeDialog.TypeList;
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            WindowResourceTypeDialogEdit rte = new WindowResourceTypeDialogEdit();
            rte.ShowDialog();
        }
    }
}
