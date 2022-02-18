using System.Collections.ObjectModel;
using System.Windows;

namespace ToscaCombobox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int Counter = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeItemsSource_OnClick(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is FirmaViewModel mvm2)
            {
                mvm2.Firmen = new ObservableCollection<Firma>
                {
                    new Firma {Name = "PALFINGER"},
                    new Firma {Name = "Qualysoft"},
                };
                Counter++;

                mvm2.SelectedFirma = mvm2.Firmen[1];
            }

            cmbFirmen.UpdateLayout();
        }
    }
}
