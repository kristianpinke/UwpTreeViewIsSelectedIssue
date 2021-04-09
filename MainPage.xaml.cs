using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ReportItemBase itemBase;

        public MainPage()
        {
            this.InitializeComponent();

            this.DataContext = this;

            itemBase = new ReportItemBase
            {
                Title = "Item 1.3",
                Items = new ObservableCollection<ReportItemBase>(new[]
                {
                    new ReportItemBase {Title = "Item 1.3.1"},
                    new ReportItemBase {Title = "1.3.2"},
                    new ReportItemBase {Title = "Item 1.3.3"}
                })
            };

            DataSource = new ObservableCollection<ReportItemBase>(new[]
            {
                new ReportItemBase
                {
                    Title = "Item 1",
                    Items = new ObservableCollection<ReportItemBase>(new[]
                    {
                        new ReportItemBase
                        {
                            Title = "Item 1.1",
                            Items = new ObservableCollection<ReportItemBase>(new[]
                            {
                                new ReportItemBase
                                {
                                    Title = "Item 1.1.1"
                                }
                            })
                        },
                        new ReportItemBase
                        {
                            Title = "Item 1.2"
                        },
                        itemBase })
                    }
            });
        }

        private ObservableCollection<ReportItemBase> DataSource;

        private void UIElement_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            itemBase.IsOpened = !itemBase.IsOpened;
        }
    }
}
