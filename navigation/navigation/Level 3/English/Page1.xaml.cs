using navigation.English;
using navigation.Level_3.English;
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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        async void GoShapesButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Shapes(), true);
        }

        async void GoToColoursButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Colours(), true);
        }

        async void GoToAlphabetButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Alphabet(), true);
        }

        async void GoToNumbersPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NumbersPage(), true);
        }
    }
}