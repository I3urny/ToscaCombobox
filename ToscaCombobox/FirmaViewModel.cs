using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ToscaCombobox
{
    public class FirmaViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Firma> _firmen;
        private Firma _selectedFirma;

        public FirmaViewModel()
        {
            Firmen = new ObservableCollection<Firma>
            {
                new Firma {Name = "PALFINGER"},
                new Firma {Name = "Qualysoft"}
            };

            SelectedFirma = Firmen[1];
        }
        public ObservableCollection<Firma> Firmen
        {
            get { return _firmen; }
            set
            {
                _firmen = value;
                OnPropertyChanged(nameof(Firmen));
            }
        }

        public Firma SelectedFirma
        {
            get { return _selectedFirma; }
            set
            {
                _selectedFirma = value;
                OnPropertyChanged(nameof(SelectedFirma));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));

        }
    }
}
