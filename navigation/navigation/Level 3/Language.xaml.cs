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
    public partial class Language : ContentPage
    {
        public Language()
        {
            InitializeComponent();
        }

        async void GoToPage1ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(), true);
        }

        async void GoToAfrikaansButtonClicked(object sender, EventArgs e) 
            {
            await Navigation.PushAsync(new Afrikaans(), true);
            }


       

    }
}