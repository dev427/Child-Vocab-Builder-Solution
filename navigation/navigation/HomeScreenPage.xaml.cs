using navigation.Level_1;
using navigation.Level_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeScreenPage : ContentPage
    {
        public HomeScreenPage()
        {
            InitializeComponent();
        }

        async void GoToLanguageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Language(), true);
        }

        async void GoToLevel2HomeButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Level2Home(), true);
        }

        async void GoToLevel1HomeButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Level1Home(), true);
        }
    }
}