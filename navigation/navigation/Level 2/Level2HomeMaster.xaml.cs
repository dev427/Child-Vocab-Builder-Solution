using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace navigation.Level_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Level2HomeMaster : ContentPage
    {
        public ListView ListView;

        public Level2HomeMaster()
        {
            InitializeComponent();

            BindingContext = new Level2HomeMasterViewModel();
            ListView = MenuItemsListView;
        }

        class Level2HomeMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<Level2HomeMasterMenuItem> MenuItems { get; set; }

            public Level2HomeMasterViewModel()
            {
                MenuItems = new ObservableCollection<Level2HomeMasterMenuItem>(new[]
                {
                    new Level2HomeMasterMenuItem { Id = 0, Title = "Page 1" },
                    new Level2HomeMasterMenuItem { Id = 1, Title = "Page 2" },
                    new Level2HomeMasterMenuItem { Id = 2, Title = "Page 3" },
                    new Level2HomeMasterMenuItem { Id = 3, Title = "Page 4" },
                    new Level2HomeMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}