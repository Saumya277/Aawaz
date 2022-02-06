using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aawaz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LangPage : ContentPage
    {
        public LangPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new EnglishPage());
        }
        private async void Button_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LocalPage());
        }
    }
}