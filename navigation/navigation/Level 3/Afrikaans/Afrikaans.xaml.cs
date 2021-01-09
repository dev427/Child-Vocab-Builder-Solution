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
    public partial class Afrikaans : ContentPage
    {
        public Afrikaans()
        {
            InitializeComponent();
        }

        async void GoToFifthPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FifthPage(), true);
        }

        async void GoToSixthPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SixthPage(), true);
        }


        async void GoToSeventhPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SeventhPage(), true);
        }

    }
}