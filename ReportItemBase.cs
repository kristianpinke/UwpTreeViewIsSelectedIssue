using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App2
{
    [Windows.UI.Xaml.Data.Bindable]
    public class ReportItemBase : INotifyPropertyChanged
    {
        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                if (_title == value)
                    return;

                _title = value;
                OnPropertyChanged();
            }
        }

        private bool _isChecked;
        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                if (_isChecked == value)
                    return;

                _isChecked = value;
                OnPropertyChanged();
            }
        }

        private bool _isOpened;
        public bool IsOpened
        {
            get => _isOpened;
            set
            {
                if (_isOpened == value)
                    return;

                _isOpened = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<ReportItemBase> _items;
        public ObservableCollection<ReportItemBase> Items
        {
            get => _items ?? (_items = new ObservableCollection<ReportItemBase>());

            set => _items = value;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
